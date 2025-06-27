using FormEase.Core.Interfaces.WebApplication.AccessControlModels;
using FormEase.Core.Models.WebApplication.AccessControlModels;
using FormEase.Infrastructure.PostgreSQL.Data;
using Microsoft.EntityFrameworkCore;

namespace FormEase.Infrastructure.PostgreSQL.Repositories.WebApplication.AccessControlModels
{
	public class UserTemplateAccessRepository : IUserTemplateAccessRepository
	{
		private readonly ApplicationDbContext _context;

		public UserTemplateAccessRepository(ApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<UserTemplateAccess> GetByIdAsync(Guid id)
		{
			var access = await _context.UserTemplateAccesses
				.Include(uta => uta.Template)
				.Include(uta => uta.User)
				.FirstOrDefaultAsync(uta => uta.Id == id);

			return access;
		}

		public async Task<List<UserTemplateAccess>> GetByTemplateIdAsync(Guid templateId)
		{
			var accesses = await _context.UserTemplateAccesses
				.Where(uta => uta.TemplateId == templateId)
				.Include(uta => uta.User)
				.ToListAsync();

			return accesses;
		}

		public async Task<List<UserTemplateAccess>> GetByUserIdAsync(string userId)
		{
			var accesses = await _context.UserTemplateAccesses.
				Where(uta => uta.UserId == userId)
				.Include(uta => uta.Template)
				.ToListAsync();

			return accesses;
		}


		public Task AddRangeAsync(List<UserTemplateAccess> accesses)
		{
			_context.UserTemplateAccesses.AddRange(accesses);
			return Task.CompletedTask;
		}

		public Task RemoveRangeAsync(List<UserTemplateAccess> accesses)
		{
			var ids = accesses.Select(uta => uta.Id).ToHashSet();

			var toDelete = _context.UserTemplateAccesses
				.Where(uta => ids.Contains(uta.Id))
				.ToList();

			if (toDelete != null && toDelete.Any())
			{
				_context.UserTemplateAccesses.RemoveRange(toDelete);
			}
			return Task.CompletedTask;
		}

		public async Task<bool> ExistsAsync(Guid templateId, string userId)
		{
			return await _context.UserTemplateAccesses
				 .AnyAsync(uta => uta.TemplateId == templateId && uta.UserId == userId);
		}
	}
}
