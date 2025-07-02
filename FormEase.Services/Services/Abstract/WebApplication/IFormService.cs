using FluentValidation.Results;
using FormEase.Core.Dtos.FormResponseDto;

namespace FormEase.Services.Services.Abstract.WebApplication
{
	public interface IFormService
	{
		Task<ValidationResult> CreateFormAsync(FormResponseDto formDto, Dictionary<Guid, List<Guid>> checkboxSelections, Dictionary<Guid, Guid?> dropdownSelections);
		Task<ValidationResult> EditFormAsync(FormResponseEditDto formDto, Dictionary<Guid, List<Guid>> checkboxSelections, Dictionary<Guid, Guid?> dropdownSelections);
		Task<List<FormResponseListDto>> GetFormsForTableAsync(string respondentId);
		Task<FormResponseEditDto> GetForEditById(string formId);
		Task<ValidationResult> RemoveFormsAsync(List<Guid> formIds);
	}
}
