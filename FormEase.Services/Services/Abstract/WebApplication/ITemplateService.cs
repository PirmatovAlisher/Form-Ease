using FluentValidation.Results;
using FormEase.Core.Dtos.ApplicationUserDtos;
using FormEase.Core.Dtos.QuestionDtos;
using FormEase.Core.Dtos.TemplateDtos;

namespace FormEase.Services.Services.Abstract.WebApplication
{
	public interface ITemplateService
	{
		Task<ValidationResult> AddAsync(TemplateCreateDto templateDto, List<QuestionDto> questions, List<UserDisplayDto> users, List<string> tagNames);
		Task<ValidationResult> EditAsync(TemplateEditDto templateDto, List<QuestionDto> questions, List<UserDisplayDto> users, List<string> tagNames);
		Task<List<TemplateListDto>> GetAllCreatorTemplatesAsync(string creatorId);
		Task<TemplateEditDto> GetByIdAsync(string id);
		Task RemoveTemplatesAsync(List<Guid> templateIds);
	}
}
