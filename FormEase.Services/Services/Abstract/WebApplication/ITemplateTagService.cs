using FormEase.Core.Models.WebApplication.AccessControlModels;

namespace FormEase.Services.Services.Abstract.WebApplication
{
	public interface ITemplateTagService
	{
		Task<List<TemplateTag>> CreateTemplateTagsAsync(Guid templateId, List<string> tagNames);
	}
}
