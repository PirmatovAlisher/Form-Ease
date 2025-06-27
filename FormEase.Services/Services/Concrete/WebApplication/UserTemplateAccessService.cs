using FluentValidation.Results;
using FormEase.Core.Dtos.ApplicationUserDtos;
using FormEase.Core.Interfaces.WebApplication.AccessControlModels;
using FormEase.Core.Models.WebApplication.AccessControlModels;
using FormEase.Services.Services.Abstract.WebApplication;

namespace FormEase.Services.Services.Concrete.WebApplication
{
	public class UserTemplateAccessService : IUserTemplateAccessService
	{
		private readonly IUserTemplateAccessRepository _repository;

		public UserTemplateAccessService(IUserTemplateAccessRepository repository)
		{
			_repository = repository;
		}

		public async Task CreateAsync(Guid templateId, List<UserDisplayDto> users)
		{
			var existingAccess = await _repository.GetByTemplateIdAsync(templateId);

			var existingUserIds = existingAccess
				.Select(a => a.UserId)
				.ToHashSet();

			var toCreate = users.
				Where(u => !existingUserIds.Contains(u.Id))
				.Select(u => new UserTemplateAccess
				{
					Id = Guid.NewGuid(),
					TemplateId = templateId,
					UserId = u.Id
				})
				.ToList();

			if (toCreate != null && toCreate.Any())
			{
				await _repository.AddRangeAsync(toCreate);
			}
		}

		public async Task<ValidationResult> ApplyAccessChangesAsync(Guid templateId, List<UserDisplayDto> users)
		{
			var result = new ValidationResult();

			try
			{
				var userTemplateAccesses = await _repository.GetByTemplateIdAsync(templateId);

				var existingUserIds = userTemplateAccesses.Select(a => a.UserId).ToHashSet();
				var incomingUserIds = users.Select(u => u.Id).ToHashSet();

				var toCreate = users
					.Where(u => !existingUserIds.Contains(u.Id))
					.Select(u => new UserTemplateAccess
					{
						UserId = u.Id,
						TemplateId = templateId,
					})
					.ToList();

				var toDelete = userTemplateAccesses.Where(a => !incomingUserIds.Contains(a.UserId)).ToList();

				if (toCreate != null && toCreate.Any())
				{
					await _repository.AddRangeAsync(toCreate);
				}

				if (toDelete != null && toDelete.Any())
				{
					await _repository.RemoveRangeAsync(toDelete);
				}
			}
			catch (Exception ex)
			{
				result.Errors.Add(new ValidationFailure
				{
					PropertyName = string.Empty,
					ErrorMessage = "An error occurred while updating user accesses for template. Please try again."
				});
			}

			return result;
		}
	}
}
