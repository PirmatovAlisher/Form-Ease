using FormEase.Core.Models.WebApplication.AccessControlModels;

namespace FormEase.Core.Interfaces.WebApplication.AccessControlModels
{
    public interface IUserTemplateAccessRepository
    {
        Task<UserTemplateAccess> GetByIdAsync(Guid id);
        Task<List<UserTemplateAccess>> GetByTemplateIdAsync(Guid templateId);
        Task<List<UserTemplateAccess>> GetByUserIdAsync(string userId);
        Task AddRangeAsync(List<UserTemplateAccess> accesses);
        Task RemoveRangeAsync(List<UserTemplateAccess> accesses);
        Task<bool> ExistsAsync(Guid templateId, string userId);
    }
}
