using FormEase.Core.Models.WebApplication.CoreModels;

namespace FormEase.Core.Interfaces.WebApplication.CoreModels
{
    public interface IQuestionRepository
    {
        Task<Question> GetByIdAsync(Guid id);
        Task<Question> GetWithOptionsByIdAsync(Guid id);
        Task<List<Question>> GetByTemplateIdWithOptionsAsync(Guid templateId);
        Task AddRangeAsync(IEnumerable<Question> questions);
        Task UpdateRangeAsync(IEnumerable<Question> questions);
        Task DeleteRangeAsync(List<Guid> ids);
        Task DeleteRangeAsync(IEnumerable<Question> questions);
    }
}
