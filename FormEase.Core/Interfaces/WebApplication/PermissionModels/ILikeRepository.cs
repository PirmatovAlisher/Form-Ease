using FormEase.Core.Models.WebApplication.PermissionModels;

namespace FormEase.Core.Interfaces.WebApplication.PermissionModels
{
    public interface ILikeRepository
    {
        Task<Like?> GetByIdAsync(Guid id);
        Task<bool> ExistsAsync(Guid templateId, string userId);
        Task<int> GetCountForTemplateAsync(Guid templateId);
        Task AddAsync(Like like);
        Task RemoveAsync(Like like);
        Task RemoveByUserAndTemplateAsync(string userId, Guid templateId);
    }
}
