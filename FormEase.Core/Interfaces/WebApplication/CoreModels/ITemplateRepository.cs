using FormEase.Core.Models.WebApplication.CoreModels;

namespace FormEase.Core.Interfaces.WebApplication.CoreModels
{
	public interface ITemplateRepository
	{
		Task<Template> GetByIdAsync(Guid id);
		Task<Template> GetByIdWithDetailsAsync(Guid id);
		Task<List<Template>> GetPublicTemplatesAsync();
		Task<List<Template>> GetByCreatorIdWithDetailsAsync(string creatorId);
		Task<List<Template>> GetByCreatorIdAsync(string creatorId);
		Task<List<Template>> GetAccessibleTemplatesAsync(string userId);

		Task AddAsync(Template template);
		Task UpdateAsync(Template template);
		Task DeleteRangeAsync(List<Guid> ids);
		Task SaveChangesAsync();

	}
}
