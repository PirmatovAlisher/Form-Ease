using FormEase.Core.Models.WebApplication.AccessControlModels;

namespace FormEase.Core.Interfaces.WebApplication.AccessControlModels
{
	public interface ITemplateTagRepository
	{
		Task<TemplateTag> GetByIdAsync(Guid id);
		Task<List<TemplateTag>> GetByTemplateIdAsync(Guid templateId);
		Task<List<TemplateTag>> GetByTagIdAsync(Guid tagId);
		Task AddRangeAsync(IEnumerable<TemplateTag> templateTags);
		Task RemoveRangeAsync(IEnumerable<TemplateTag> tempTags);
		Task<bool> ExistsAsync(Guid templateId, Guid tagId);
	}
}
