using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using FormEase.Core.Dtos.ApplicationUserDtos;
using FormEase.Core.Dtos.QuestionDtos;
using FormEase.Core.Dtos.TemplateDtos;
using FormEase.Core.Interfaces.WebApplication.CoreModels;
using FormEase.Core.Models.WebApplication.AccessControlModels;
using FormEase.Core.Models.WebApplication.CoreModels;
using FormEase.Services.Services.Abstract.WebApplication;

namespace FormEase.Services.Services.Concrete.WebApplication
{
	public class TemplateService : ITemplateService
	{
		private readonly IValidator<TemplateCreateDto> _tempvalidator;
		private readonly IValidator<QuestionCreateDto> _questionvalidator;
		private readonly ITemplateRepository _templateRepo;
		private readonly IMapper _mapper;


		public TemplateService(ITemplateRepository templateRepo, IMapper mapper, IValidator<TemplateCreateDto> tempvalidator, IValidator<QuestionCreateDto> questionvalidator)
		{
			_templateRepo = templateRepo;
			_mapper = mapper;
			_tempvalidator = tempvalidator;
			_questionvalidator = questionvalidator;
		}

		public async Task<List<TemplateListDto>> GetAllCreatorTemplates(string creatorId)
		{
			try
			{
				var templates = await _templateRepo.GetByCreatorIdAsync(creatorId);

				var templateListDto = _mapper.Map<List<TemplateListDto>>(templates);

				return templateListDto;
			}
			catch (Exception ex)
			{

				throw;
			}
		}

		public async Task<ValidationResult> AddAsync(TemplateCreateDto templateDto, List<QuestionCreateDto> questions, List<UserDisplayDto> users)
		{
			var result = await _tempvalidator.ValidateAsync(templateDto);

			if (!result.IsValid)
			{
				return result;
			}

			foreach (var question in questions)
			{
				var questionValidate = await _questionvalidator.ValidateAsync(question);
				if (!questionValidate.IsValid)
				{
					result.Errors.AddRange(questionValidate.Errors);
				}

				question.TemplateId = templateDto.Id;
				if (question.Type != QuestionType.Checkboxes && question.Type != QuestionType.Dropdown)
				{
					question.Options = null;
				}
			}

			try
			{
				var template = _mapper.Map<Template>(templateDto);

				template.Questions = _mapper.Map<List<Question>>(questions);

				template.AllowedUsers = users.
					Select(u => new UserTemplateAccess
					{
						Id = Guid.NewGuid(),
						UserId = u.Id,
						TemplateId = template.Id
					}).ToList();


				await _templateRepo.AddAsync(template);
				return result;
			}
			catch (Exception ex)
			{
				result.Errors.Add(new ValidationFailure
				{
					PropertyName = string.Empty,
					ErrorMessage = "An error occurred saving the template. Please try again."
				});
			}
			return result;
		}

		public async Task RemoveTemplates(List<Guid> templateIds)
		{
			await _templateRepo.DeleteRangeAsync(templateIds);
		}
	}
}
