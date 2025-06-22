using FormEase.Core.Dtos.ApplicationUserDtos;
using FormEase.Core.Models.Identity;
using FormEase.Infrastructure.PostgreSQL.Data;
using FormEase.Services.Services.Abstract.Identity;
using Microsoft.EntityFrameworkCore;

namespace FormEase.Services.Services.Concrete.Identity
{
	public class UserService : IUserService
	{
		private readonly ApplicationDbContext _context;

		public UserService(ApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<List<UserDisplayDto>> SearchUsers(string query, List<string> existingUserEmails, int take = 5)
		{
			if (string.IsNullOrWhiteSpace(query) || query.Length < 2)
			{
				return new List<UserDisplayDto>();
			}

			try
			{
				var normalizedQuery = $"%{query.ToLower()}%";

				var queryable = _context.Users
					.Where(u => !u.IsBlocked &&
					(EF.Functions.Like(u.FirstName.ToLower(), normalizedQuery) ||
					EF.Functions.Like(u.Email.ToLower(), normalizedQuery)));

				if (existingUserEmails.Count > 0)
				{
					queryable = queryable.Where(u => !existingUserEmails.Contains(u.Email));
				}

				var users = await queryable
					.OrderBy(u => u.FirstName)
					.Select(u => new UserDisplayDto
					{
						Id = u.Id,
						FirstName = u.FirstName,
						Email = u.Email
					})
					.Take(take)
					.ToListAsync();

				return users;
			}
			catch (Exception ex)
			{
				return new List<UserDisplayDto>();
			}
		}
	}
}
