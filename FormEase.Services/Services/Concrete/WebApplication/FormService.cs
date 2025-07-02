using AutoMapper;
using FluentValidation.Results;
using FormEase.Core.Dtos.AnswerDros;
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
		private readonly ISelectedOptionRepository _selectedOptionRepository;
		private readonly ValidationService _validationService;
		private readonly IMapper _mapper;

		public FormService(IFormResponseRepository responseRepository, IMapper mapper, ValidationService validationService, ISelectedOptionRepository selectedOptionRepository)
		{
			_responseRepository = responseRepository;
			_mapper = mapper;
			_validationService = validationService;
			_selectedOptionRepository = selectedOptionRepository;
		}

		public async Task<ValidationResult> CreateFormAsync(
			FormResponseDto formDto,
			Dictionary<Guid, List<Guid>> checkboxSelections,
			Dictionary<Guid, Guid?> dropdownSelections)
		{
			PopulateSelectedOptions(formDto.Answers, checkboxSelections, dropdownSelections);

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



		public async Task<List<FormResponseListDto>> GetFormsForTableAsync(string respondentId)
		{
			var forms = await _responseRepository.GetByRespondentIdForTableAsync(respondentId);

			var dto = _mapper.Map<List<FormResponseListDto>>(forms);

			return dto;
		}

		public async Task<List<FormResponseReportDto>> GetFormsByTemplateId(string templateId)
		{
			var forms = await _responseRepository.GetByTemplateIdAsync(Guid.Parse(templateId));

			var dto = _mapper.Map<List<FormResponseReportDto>>(forms);

			return dto;
		}

		public async Task<FormResponseEditDto> GetForEditById(string formId)
		{
			var form = await _responseRepository.GetByIdAsync(Guid.Parse(formId));

			var dto = _mapper.Map<FormResponseEditDto>(form);

			return dto;
		}

		public async Task<ValidationResult> RemoveFormsAsync(List<Guid> formIds)
		{
			var result = new ValidationResult();

			try
			{
				await _responseRepository.DeleteRangeAsync(formIds);
			}
			catch (Exception ex)
			{
				result.Errors.Add(new ValidationFailure
				{
					PropertyName = string.Empty,
					ErrorMessage = "An error occurred while saving the template. Please try again."
				});
			}
			return result;
		}

		public async Task<ValidationResult> EditFormAsync(FormResponseEditDto formDto,
			Dictionary<Guid, List<Guid>> allSelections)
		{

			var result = await _validationService.ValidateAsync(formDto);
			if (!result.IsValid)
			{
				return result;
			}

			try
			{
				var existingForm = await _responseRepository.GetWithAnswersAndSelectionsAsync(formDto.Id);

				var optionsToDelete = new List<SelectedOption>();
				var optionsToAdd = new List<SelectedOption>();

				foreach (var answer in existingForm.Answers)
				{
					var questionId = answer.QuestionId;

					HashSet<Guid> incomingOptIds;

					allSelections.TryGetValue(questionId, out var incomingOptList);

					incomingOptIds = (incomingOptList ?? new List<Guid>()).ToHashSet();
					 

					var existingOptIds = answer.SelectedOptions.Select(x => x.OptionId).ToHashSet();

					foreach (var toRemove in answer.SelectedOptions
				   .Where(o => !incomingOptIds.Contains(o.OptionId)))
					{
						optionsToDelete.Add(toRemove);
					}

					foreach (var toInsert in incomingOptIds.Except(existingOptIds))
					{
						optionsToAdd.Add(new SelectedOption
						{
							AnswerId = answer.Id,
							OptionId = toInsert
						});
					}
				}

				if (optionsToDelete.Any())
					_selectedOptionRepository.DeleteRange(optionsToDelete);

				if (optionsToAdd.Any())
					await _selectedOptionRepository.AddRangeAsync(optionsToAdd);

				foreach (var answer in existingForm.Answers)
				{
					var dto = formDto.Answers.First(a => a.QuestionId == answer.QuestionId);
					answer.Value = dto.Value;
				}


				existingForm.UpdatedAt = formDto.UpdatedAt;

				await _responseRepository.SaveChangesAsync();
			}
			catch (Exception ex)
			{
				result.Errors.Add(new ValidationFailure
				{
					PropertyName = string.Empty,
					ErrorMessage = "An error occurred while updating the form. Please try again."
				});
			}

			return result;
		}

		/// <summary>
		/// Fills each AnswerDto.SelectedOptions based on the two selection maps.
		/// </summary>
		private void PopulateSelectedOptions<TAnswer>(
			IEnumerable<TAnswer> answers,
			Dictionary<Guid, List<Guid>> checkboxSelections,
			Dictionary<Guid, Guid?> dropdownSelections
		) where TAnswer : AnswerDto
		{
			// initialize to empty
			foreach (var ans in answers)
				ans.SelectedOptions = new List<SelectedOptionDto>();

			// checkboxes
			if (checkboxSelections != null)
			{
				foreach (var (questionId, optionIds) in checkboxSelections)
				{
					var ans = answers.FirstOrDefault(a => a.QuestionId == questionId);
					if (ans != null && optionIds != null)
					{
						ans.SelectedOptions = optionIds
							.Select(optId => new SelectedOptionDto
							{
								AnswerId = ans.Id,
								OptionId = optId
							})
							.ToList();
					}
				}
			}

			// dropdown
			if (dropdownSelections != null)
			{
				foreach (var (questionId, selectedOptId) in dropdownSelections)
				{
					var ans = answers.FirstOrDefault(a => a.QuestionId == questionId);
					if (ans != null && selectedOptId.HasValue)
					{
						ans.SelectedOptions = new List<SelectedOptionDto> {
						new SelectedOptionDto {
							AnswerId = ans.Id,
							OptionId = selectedOptId.Value
						}
					};
					}
				}
			}
		}
	}

}
