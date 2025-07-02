using FormEase.Core.Models.WebApplication.CoreModels;

namespace FormEase.Core.Interfaces.WebApplication.CoreModels
{
	public interface IFormResponseRepository
	{
		Task<FormResponse> GetByIdAsync(Guid id);
		Task<List<FormResponse>> GetByTemplateIdAsync(Guid templateId);
		Task<List<FormResponse>> GetByRespondentIdForTableAsync(string respondentId);
		Task<string> GetRespondentIdByFormId(Guid formId);
		Task<FormResponse> GetWithAnswersAndSelectionsAsync(Guid formId);
		Task<bool> HasUserSubmittedTemplateAsync(string userId, Guid templateId);

		Task AddAsync(FormResponse formResponse);
		Task UpdateAsync(FormResponse formResponse);
		Task DeleteRangeAsync(List<Guid> ids);
		Task<bool> ExistsAsync(Guid id);
		Task SaveChangesAsync();
	}
}
