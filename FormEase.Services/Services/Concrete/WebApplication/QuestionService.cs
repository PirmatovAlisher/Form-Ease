using AutoMapper;
using FluentValidation.Results;
using FormEase.Core.Dtos.QuestionDtos;
using FormEase.Core.Interfaces.WebApplication.CoreModels;
using FormEase.Core.Models.WebApplication.CoreModels;
using FormEase.Services.Services.Abstract.WebApplication;

namespace FormEase.Services.Services.Concrete.WebApplication
{
	public class QuestionService : IQuestionService
	{
		private readonly IQuestionRepository _questionRepository;
		private readonly IQuestionOptionService _questionOptionService;
		private readonly IMapper _mapper;
		private readonly ValidationService _validationService;

		public QuestionService(IQuestionRepository questionRepository, ValidationService validationService, IQuestionOptionService questionOptionService, IMapper mapper)
		{
			_questionRepository = questionRepository;
			_validationService = validationService;
			_questionOptionService = questionOptionService;
			_mapper = mapper;
		}

		public async Task<ValidationResult> ApplyQuestionChangesOldAsync(Guid templateId, List<QuestionDto> questionDtos)
		{
			var result = await _validationService.ValidateAsync(questionDtos);

			if (!result.IsValid)
			{
				return result;
			}

			try
			{
				var questions = _mapper.Map<List<Question>>(questionDtos);

				var questionIds = questions.Select(x => x.Id).ToHashSet();

				var existingQuestions = await _questionRepository.GetByTemplateIdWithOptionsAsync(templateId);

				var existingQuestionIds = existingQuestions.Select(x => x.Id).ToHashSet();

				var toCreate = questions.Where(q => !existingQuestionIds.Contains(q.Id)).ToList();
				toCreate.ForEach(q => q.TemplateId = templateId);

				var toUpdate = questions.Where(q => existingQuestionIds.Contains(q.Id)).ToList();

				var toDelete = existingQuestions.Where(q => !questionIds.Contains(q.Id)).ToList();


				//var updateOptions = await _questionOptionService.ApplyOptionChangesAsync(toUpdate);
				//if (!updateOptions.IsValid)
				//{
				//	result.Errors.AddRange(updateOptions.Errors);
				//}


				if (toCreate != null && toCreate.Count > 0)
				{
					await _questionRepository.AddRangeAsync(toCreate);
				}

				if (toUpdate != null && toUpdate.Count > 0)
				{
					await _questionRepository.UpdateRangeAsync(toUpdate);
				}

				if (toDelete != null && toDelete.Count > 0)
				{
					await _questionRepository.DeleteRangeAsync(toDelete);
				}
			}
			catch (Exception ex)
			{
				result.Errors.Add(new ValidationFailure
				{
					PropertyName = string.Empty,
					ErrorMessage = "An error occurred while updating template questions. Please try again."
				});
			}

			return result;

		}

		public async Task<ValidationResult> ApplyQuestionChangesAsync(Guid templateId, List<QuestionDto> questionDtos)
		{
			var result = await _validationService.ValidateAsync(questionDtos);

			if (!result.IsValid)
			{
				return result;
			}

			try
			{
				var questions = await _questionRepository.GetByTemplateIdWithOptionsAsync(templateId);

				var incomingById = questionDtos.Where(d => d.Id != Guid.Empty).ToDictionary(d => d.Id);
				var existingById = questions.ToDictionary(q => q.Id);

				var toCreateDtos = questionDtos.Where(dto => dto.Id == Guid.Empty);
				var toUpdateDtos = questionDtos.Where(d => existingById.ContainsKey(d.Id)).ToList();
				var toDelete = questions.Where(q => !incomingById.ContainsKey(q.Id));

				if (toDelete != null && toDelete.Any())
				{
					await _questionRepository.DeleteRangeAsync(toDelete);
				}

				var toCreate = toCreateDtos
					.Select(dto =>
					{
						var q = _mapper.Map<Question>(dto);
						q.TemplateId = templateId;
						return q;
					});

				if (toCreate != null && toCreate.Any())
				{
					await _questionRepository.AddRangeAsync(toCreate);
				}

				var toUpdate = new List<Question>();

				foreach (var dto in toUpdateDtos)
				{
					var question = existingById[dto.Id];
					_mapper.Map(dto, question);

					toUpdate.Add(question);
				}

				if (toUpdateDtos.Any())
				{
					var optResult = await _questionOptionService.ApplyOptionChangesAsync(toUpdateDtos);
					if (!optResult.IsValid)
					{
						result.Errors.AddRange(optResult.Errors);
					}
				}
							
			}
			catch (Exception ex)
			{
				result.Errors.Add(new ValidationFailure
				{
					PropertyName = string.Empty,
					ErrorMessage = "An error occurred while updating template questions. Please try again."
				});
			}

			return result;
		}
	}
}
