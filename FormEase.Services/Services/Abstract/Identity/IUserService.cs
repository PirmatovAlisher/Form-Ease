using FormEase.Core.Dtos.ApplicationUserDtos;
using FormEase.Core.Models.Identity;

namespace FormEase.Services.Services.Abstract.Identity
{
	public interface IUserService
	{
		Task<List<UserDisplayDto>> SearchUsers(string query, List<string> existingUserEmails, int limit = 5);
	}
}
