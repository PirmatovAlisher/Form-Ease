using FluentValidation.Results;
using FormEase.Core.Dtos.FormResponseDto;

namespace FormEase.Services.Services.Abstract.WebApplication
{
	public interface IFormService
	{
		Task<ValidationResult> CreateFormAsync(FormResponseDto formDto, Dictionary<Guid, List<Guid>> checkboxSelections, Dictionary<Guid, Guid?> dropdownSelections);
	}
}
