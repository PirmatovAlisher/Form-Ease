using FormEase.Core.Models.WebApplication.MetadataModels;

namespace FormEase.Core.Interfaces.WebApplication.MetadataModels
{
    public interface ITagRepository
    {
        Task<Tag?> GetByIdAsync(Guid id);
        Task<List<Tag>> GetAllAsync();
        Task<List<Tag>> GetByPrefixAsync(string prefix, int limit = 10);
        Task AddRangeAsync(List<Tag> tags);
        Task UpdateRangeAsync(List<Tag> tags);
        Task DeleteRangeAsync(List<Guid> ids);
        Task<bool> ExistsAsync(string name);
        Task<List<Tag>> GetOrCreateTagsAsync(List<string> tagNames);
    }
}
