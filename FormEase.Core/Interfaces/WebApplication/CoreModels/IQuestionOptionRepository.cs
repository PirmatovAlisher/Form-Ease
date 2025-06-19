using FormEase.Core.Models.WebApplication.CoreModels;

namespace FormEase.Core.Interfaces.WebApplication.CoreModels
{
    public interface IQuestionOptionRepository
    {
        Task<QuestionOption> GetByIdAsync(Guid id);
        Task<List<QuestionOption>> GetByQuestionIdAsync(Guid questionId);
        Task AddRangeAsync(List<QuestionOption> options);
        Task UpdateRangeAsync(List<QuestionOption> options);
        Task DeleteRangeAsync(List<Guid> ids);
        Task DeleteByQuestionIdAsync(Guid questionId);
        Task<bool> ExistsAsync(Guid id);
    }
}
