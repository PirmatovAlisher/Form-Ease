using FormEase.Core.Models.WebApplication.MetadataModels;

namespace FormEase.Services.Services.Abstract.WebApplication
{
	public interface ITagService
	{
		Task<List<Tag>> SearchTegByName(string query, List<string> existingTagNames , int limit = 5);
	}
}
