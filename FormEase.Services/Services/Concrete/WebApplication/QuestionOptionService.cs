using AutoMapper;
using FluentValidation.Results;
using FormEase.Core.Dtos.QuestionDtos;
using FormEase.Core.Dtos.QuestionOptionDtos;
using FormEase.Core.Interfaces.WebApplication.CoreModels;
using FormEase.Core.Models.WebApplication.CoreModels;
using FormEase.Services.Services.Abstract.WebApplication;

namespace FormEase.Services.Services.Concrete.WebApplication
{
	public class QuestionOptionService : IQuestionOptionService
	{
		private readonly IQuestionOptionRepository _questionOptionRepository;
		private readonly ValidationService _validationService;
		private readonly IMapper _mapper;

		public QuestionOptionService(IQuestionOptionRepository questionOptionRepository, ValidationService validationService, IMapper mapper)
		{
			_questionOptionRepository = questionOptionRepository;
			_validationService = validationService;
			_mapper = mapper;
		}

		public async Task<ValidationResult> ApplyOptionChangesAsync(List<QuestionDto> questionDtos)
		{
			var result = await _validationService.ValidateAsync(questionDtos);

			if (!result.IsValid)
			{
				return result;
			}

			try
			{
				var questionIds = questionDtos.Select(x => x.Id).ToList();

				var existingOptions = await _questionOptionRepository.GetByQuestionIdsAsync(questionIds);

				var incomingByQuestion = questionDtos.
					SelectMany(q => q.Options)
					.GroupBy(o => o.QuestionId)
					.ToDictionary(g => g.Key, g => g.ToList());

				var existingByQuestion = existingOptions.
					GroupBy(o => o.QuestionId)
					.ToDictionary(g => g.Key, g => g.ToList());

				var toDelete = new List<QuestionOption>();

				foreach (var qId in questionIds)
				{
					incomingByQuestion.TryGetValue(qId, out var incomingOpts);
					existingByQuestion.TryGetValue(qId, out var existingOpts);

					incomingOpts ??= new List<QuestionOptionDto>();
					existingOpts ??= new List<QuestionOption>();

					var incomingIds = incomingOpts.Select(x => x.Id).ToHashSet();
					var existingIds = existingOpts.Select(x => x.Id).ToHashSet();

					toDelete.AddRange(existingOptions.Where(o => !incomingIds.Contains(o.Id)));

					foreach (var opt in incomingOpts.Where(o => existingIds.Contains(o.Id)))
					{
						var entity = existingOpts.First(o => o.Id == opt.Id);
						entity.Value = opt.Value;
					}
				}

				if (toDelete.Any())
				{
					await _questionOptionRepository.DeleteRangeAsync(toDelete);
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
