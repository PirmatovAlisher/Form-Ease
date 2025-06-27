using FluentValidation.Results;

namespace FormEase.Services.Services.Abstract.WebApplication
{
	public interface ITemplateTagService
	{
		Task<ValidationResult> ApplyTemplateTagChangesAsync(Guid templateId, List<string> tagNames);
	}
}
