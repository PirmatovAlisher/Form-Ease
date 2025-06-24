using FluentValidation.Results;
using FormEase.Core.Dtos.ApplicationUserDtos;
using FormEase.Core.Dtos.QuestionDtos;
using FormEase.Core.Dtos.TemplateDtos;

namespace FormEase.Services.Services.Abstract.WebApplication
{
	public interface ITemplateService
	{
		Task<ValidationResult> AddAsync(TemplateCreateDto templateDto, List<QuestionCreateDto> questions, List<UserDisplayDto> users);
		Task<List<TemplateListDto>> GetAllCreatorTemplates(string creatorId);
		Task RemoveTemplates(List<Guid> templateIds);
	}
}
