using FormEase.Core.Interfaces.WebApplication.CoreModels;
using FormEase.Core.Models.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace FormEase.Services.Services.Concrete.Identity
{
	public class PermissionService
	{
		private readonly IHttpContextAccessor _httpContextAccessor;
		private readonly UserManager<ApplicationUser> _userManager;
		private readonly ITemplateRepository _templateRepository;
		private readonly IFormResponseRepository _formResponseRepository;

		public PermissionService(UserManager<ApplicationUser> userManager, ITemplateRepository templateRepository, IFormResponseRepository formResponseRepository, IHttpContextAccessor httpContextAccessor)
		{
			_userManager = userManager;
			_templateRepository = templateRepository;
			_formResponseRepository = formResponseRepository;
			_httpContextAccessor = httpContextAccessor;
		}

		public async Task<bool> CanEditTemplate(Guid templateId)
		{
			var user = await GetCurrentUserAsync();
			var creatorId = await _templateRepository.GetCreatorIdByTemplateId(templateId);

			if (user.Id == creatorId || user.IsAdmin)
			{
				return true;
			}
			return false;
		}

		public async Task<bool> CanViewForm(Guid templateId)
		{
			var template = await _templateRepository.GetAllowedUsersByIdAsync(templateId);

			if (template.IsPublic)
				return true;

			var allowedUserIds = template.AllowedUsers
				.Select(au => au.User.Id)
				.ToHashSet();

			var user = await GetCurrentUserAsync();

			if (allowedUserIds.Contains(user.Id) || user.IsAdmin)
				return true;


			return false;
		}

		public async Task<bool> CanEditResponse(Guid formId)
		{
			var user = await GetCurrentUserAsync();
			var respondentId = await _formResponseRepository.GetRespondentIdByFormId(formId);

			if (user.Id == respondentId || user.IsAdmin)
			{
				return true;
			}
			return false;
		}

		public async Task<bool> IsUserAuthenticated()
		{
			var principal = _httpContextAccessor.HttpContext?.User;

			return principal.Identity.IsAuthenticated;
		}

		public async Task<string> GetCurrentUserId()
		{
			var userInfo = await GetCurrentUserAsync();
			return userInfo.Id;
		}

		private async Task<CurrentUserInfo> GetCurrentUserAsync()
		{
			var principal = _httpContextAccessor.HttpContext?.User;

			if (principal == null || !principal.Identity?.IsAuthenticated == true)
			{
				_httpContextAccessor.HttpContext.Response.Redirect("/Account/Login");

			}

			var identityUser = await _userManager.GetUserAsync(principal);
			if (identityUser == null)
				return null;


			var isAdmin = await _userManager.IsInRoleAsync(identityUser, "Admin");

			return new CurrentUserInfo
			{
				Id = identityUser.Id,
				IsAdmin = isAdmin
			};
		}

		private class CurrentUserInfo
		{
			public string Id { get; set; }
			public bool IsAdmin { get; set; }
		}
	}

}
