using AutoMapper;
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
		private readonly ITemplateRepository _templateRepo;
		private readonly ITemplateTagService _templateTagService;
		private readonly IQuestionService _questionService;
		private readonly IUserTemplateAccessService _userTemplateAccessService;
		private readonly IMapper _mapper;
		private readonly ValidationService _validationService;


		public TemplateService(ITemplateRepository templateRepo, IMapper mapper, ITemplateTagService templateTagService, IUserTemplateAccessService userTemplateAccessService, ValidationService validationService, IQuestionService questionService)
		{
			_templateRepo = templateRepo;
			_mapper = mapper;
			_templateTagService = templateTagService;
			_userTemplateAccessService = userTemplateAccessService;
			_validationService = validationService;
			_questionService = questionService;
		}

		public async Task<List<TemplateListDto>> GetAllCreatorTemplatesAsync(string creatorId)
		{
			var templates = await _templateRepo.GetByCreatorIdAsync(creatorId);

			var dtos = _mapper.Map<List<TemplateListDto>>(templates);

			return dtos;
		}

		public async Task<ValidationResult> AddAsync(TemplateCreateDto templateDto, List<QuestionDto> questions, List<UserDisplayDto> users, List<string> tagNames)
		{
			var result = await _validationService.ValidateAsync(templateDto);

			if (!result.IsValid)
			{
				return result;
			}

			var questionValidate = await _validationService.ValidateAsync(questions);
			if (!questionValidate.IsValid)
			{
				result.Errors.AddRange(questionValidate.Errors);
			}

			try
			{
				var template = _mapper.Map<Template>(templateDto);

				questions.ForEach(q => q.TemplateId = template.Id);
				template.Questions = _mapper.Map<List<Question>>(questions);
				template.AllowedUsers = users.Select(u => new UserTemplateAccess
				{
					Id = Guid.NewGuid(),
					UserId = u.Id,
					TemplateId = template.Id
				}).ToList();

				await _templateRepo.AddAsync(template);

				var tempTagResult = await _templateTagService.ApplyTemplateTagChangesAsync(template.Id, tagNames);
				if (!tempTagResult.IsValid)
				{
					result.Errors.AddRange(tempTagResult.Errors);
				}

				if (result.Errors.Any()) return result;
				await _templateRepo.SaveChangesAsync();
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

		public async Task<ValidationResult> EditAsync(TemplateEditDto templateDto, List<QuestionDto> questions, List<UserDisplayDto> users, List<string> tagNames)
		{
			var result = await _validationService.ValidateAsync(templateDto);

			if (!result.IsValid)
			{
				return result;
			}

			try
			{
				var template = await _templateRepo.GetByIdAsync(templateDto.Id);

				template.Title = templateDto.Title;
				template.Description = templateDto.Description;
				template.ImageUrl = templateDto.ImageUrl;
				template.IsPublic = templateDto.IsPublic;
				template.UpdatedAt = DateTime.UtcNow;
				template.TopicId = templateDto.TopicId;


				var qResult = await _questionService.ApplyQuestionChangesAsync(template.Id, questions);
				if (!qResult.IsValid)
				{
					result.Errors.AddRange(qResult.Errors);
				}

				var accessResult = await _userTemplateAccessService.ApplyAccessChangesAsync(template.Id, users);
				if (!accessResult.IsValid)
				{
					result.Errors.AddRange(accessResult.Errors);
				}

				var tempTagResult = await _templateTagService.ApplyTemplateTagChangesAsync(template.Id, tagNames);
				if (!tempTagResult.IsValid)
				{
					result.Errors.AddRange(tempTagResult.Errors);
				}


				if (result.Errors.Any()) return result;

				await _templateRepo.SaveChangesAsync();

			}
			catch (Exception ex)
			{
				result.Errors.Add(new ValidationFailure
				{
					PropertyName = string.Empty,
					ErrorMessage = "An error occurred while updating the template. Please try again."
				});
			}

			return result;
		}

		public async Task RemoveTemplatesAsync(List<Guid> templateIds)
		{
			await _templateRepo.DeleteRangeAsync(templateIds);
		}

		public async Task<TemplateEditDto> GetByIdAsync(string id)
		{
			var template = await _templateRepo.GetByIdWithDetailsAsync(Guid.Parse(id));

			var templateDto = _mapper.Map<TemplateEditDto>(template);

			return templateDto;
		}

		public async Task<List<TemplateDisplayDto>> GetLatestTemplatesAsync(int limit = 10)
		{
			var templates = await _templateRepo.GetLatestTemplatesAsync(limit);

			return _mapper.Map<List<TemplateDisplayDto>>(templates);
		}

		public async Task<TemplateFillDto> GetTemplateToFill(string templateId)
		{
			var template = await _templateRepo.GetByIdToFillAsync(Guid.Parse(templateId));

			var dto = _mapper.Map<TemplateFillDto>(template);

			return dto;
		}


	}
}
