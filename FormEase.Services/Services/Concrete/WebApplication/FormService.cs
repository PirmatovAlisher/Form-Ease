using AutoMapper;
using FluentValidation.Results;
using FormEase.Core.Dtos.FormResponseDto;
using FormEase.Core.Dtos.QuestionOptionDtos;
using FormEase.Core.Interfaces.WebApplication.CoreModels;
using FormEase.Core.Models.WebApplication.CoreModels;
using FormEase.Services.Services.Abstract.WebApplication;

namespace FormEase.Services.Services.Concrete.WebApplication
{
	public class FormService : IFormService
	{
		private readonly IFormResponseRepository _responseRepository;
		private readonly ValidationService _validationService;
		private readonly IMapper _mapper;

		public FormService(IFormResponseRepository responseRepository, IMapper mapper, ValidationService validationService)
		{
			_responseRepository = responseRepository;
			_mapper = mapper;
			_validationService = validationService;
		}

		public async Task<ValidationResult> CreateFormAsync(FormResponseDto formDto, Dictionary<Guid, List<Guid>> checkboxSelections, Dictionary<Guid, Guid?> dropdownSelections)
		{
			foreach (var answer in formDto.Answers)
			{
				answer.SelectedOptions = new List<SelectedOptionDto>();
			}

			if (checkboxSelections != null)
			{
				foreach (var kvp in checkboxSelections)
				{
					var questionId = kvp.Key;
					var optionIds = kvp.Value;

					var answer = formDto.Answers
						.FirstOrDefault(a => a.QuestionId == questionId);
					if (answer != null && optionIds != null)
					{
						answer.SelectedOptions = optionIds
							.Select(optId => new SelectedOptionDto
							{
								AnswerId = answer.Id,
								OptionId = optId
							})
							.ToList();
					}
				}
			}

			if (dropdownSelections != null)
			{
				foreach (var kvp in dropdownSelections)
				{
					var questionId = kvp.Key;
					var selectedOptId = kvp.Value;

					var answer = formDto.Answers
						.FirstOrDefault(a => a.QuestionId == questionId);
					if (answer != null && selectedOptId.HasValue)
					{
						answer.SelectedOptions = new List<SelectedOptionDto> {
					new SelectedOptionDto {
						AnswerId = answer.Id,
						OptionId = selectedOptId.Value
					}
				};
					}
				}
			}

			var result = await _validationService.ValidateAsync(formDto);
			if (!result.IsValid)
			{
				return result;
			}

			try
			{
				var form = _mapper.Map<FormResponse>(formDto);

				await _responseRepository.AddAsync(form);
				await _responseRepository.SaveChangesAsync();
			}
			catch (Exception ex)
			{
				result.Errors.Add(new ValidationFailure
				{
					PropertyName = string.Empty,
					ErrorMessage = "An error occurred while saving the form. Please try again."
				});
			}

			return result;
		}
	}
}
