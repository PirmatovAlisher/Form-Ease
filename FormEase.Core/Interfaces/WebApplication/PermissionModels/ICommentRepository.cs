using FormEase.Core.Models.WebApplication.PermissionModels;

namespace FormEase.Core.Interfaces.WebApplication.PermissionModels
{
    public interface ICommentRepository
    {
        Task<Comment> GetByIdAsync(Guid id);
        Task<List<Comment>> GetByTemplateIdAsync(Guid templateId);
        Task<List<Comment>> GetByUserIdAsync(string userId);
        Task AddRangeAsync(List<Comment> comments);
        Task UpdateRangeAsync(List<Comment> comments);
        Task DeleteRangeAsync(List<Guid> ids);
        Task<bool> ExistsAsync(Guid id);
    }
}
