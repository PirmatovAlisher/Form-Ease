using FluentValidation.Results;
using FormEase.Core.Dtos.ApplicationUserDtos;

namespace FormEase.Services.Services.Abstract.WebApplication
{
	public interface IUserTemplateAccessService
	{
		Task CreateAsync(Guid templateId, List<UserDisplayDto> users);
		Task<ValidationResult> ApplyAccessChangesAsync(Guid templateId, List<UserDisplayDto> users);
	}
}
