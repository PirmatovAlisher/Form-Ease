using FormEase.Core.Dtos.ApplicationUserDtos;
using FormEase.Core.Dtos.TemplateDtos;

namespace FormEase.Services.Services.Abstract.WebApplication
{
	public interface ITemplateService
	{
		Task AddAsync(TemplateCreateDto templateDto, List<UserDisplayDto> users);
		Task<List<TemplateListDto>> GetAllCreatorTemplates(string creatorId);
		Task RemoveTemplates(List<Guid> templateIds);
	}
}
