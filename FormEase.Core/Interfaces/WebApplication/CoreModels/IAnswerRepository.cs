using FormEase.Core.Models.WebApplication.CoreModels;

namespace FormEase.Core.Interfaces.WebApplication.CoreModels
{
    public interface IAnswerRepository
    {
        Task<Answer> GetByIdAsync(Guid id);
        Task<Answer> GetByIdWithDetailsAsync(Guid id);
        Task<List<Answer>> GetByResponseIdAsync(Guid responseId);
        Task AddRangeAsync(List<Answer> answers);
        Task UpdateRangeAsync(List<Answer> answers);
        Task DeleteRangeAsync(List<Guid> ids);
    }
}
