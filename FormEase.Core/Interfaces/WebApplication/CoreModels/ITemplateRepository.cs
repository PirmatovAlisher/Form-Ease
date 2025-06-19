using FormEase.Core.Models.WebApplication.CoreModels;

namespace FormEase.Core.Interfaces.WebApplication.CoreModels
{
    public interface ITemplateRepository
    {
        Task<Template> GetByIdAsync(Guid id);
        Task<Template> GetByIdWithDetailsAsync(Guid id);
        Task<List<Template>> GetPublicTemplatesAsync();
        Task<List<Template>> GetByCreatorAsync(string creatorId);
        Task<List<Template>> GetAccessibleTemplatesAsync(string userId);

        Task AddRangeAsync(List<Template> templates);
        Task UpdateRangeAsync(List<Template> templates);
        Task DeleteRangeAsync(List<Guid> ids);

        Task<bool> ExistsAsync(Guid id);
        Task AddAllowedUsersAsync(Guid templateId, List<string> userIds);
        Task RemoveAllowedUsersAsync(Guid templateId, List<string> userIds);
        Task AddTagsAsync(Guid templateId, List<Guid> tagIds);
        Task RemoveTagsAsync(Guid templateId, List<Guid> tagIds);
    }
}
