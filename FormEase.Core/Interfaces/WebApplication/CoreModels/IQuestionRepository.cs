using FormEase.Core.Models.WebApplication.CoreModels;

namespace FormEase.Core.Interfaces.WebApplication.CoreModels
{
    public interface IQuestionRepository
    {
        Task<Question> GetByIdAsync(Guid id);
        Task<Question> GetWithOptionsByIdAsync(Guid id);
        Task<List<Question>> GetByTemplateIdAsync(Guid templateId);
        Task AddRangeAsync(List<Question> questions);
        Task UpdateRangeAsync(List<Question> questions);
        Task DeleteRangeAsync(List<Guid> ids);
        Task UpdateShowInResponseListAsync(Guid questionId, bool showInResponseList);
    }
}
