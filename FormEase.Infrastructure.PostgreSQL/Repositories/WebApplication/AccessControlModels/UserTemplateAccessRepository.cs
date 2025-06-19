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
            var accesses = await _context.UserTemplateAccesses.
                Where(uta => uta.TemplateId == templateId)
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


        public async Task AddRangeAsync(List<UserTemplateAccess> accesses)
        {
            await _context.UserTemplateAccesses.AddRangeAsync(accesses);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveRangeAsync(List<UserTemplateAccess> accesses)
        {
            _context.UserTemplateAccesses.RemoveRange(accesses);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> ExistsAsync(Guid templateId, string userId)
        {
            return await _context.UserTemplateAccesses
                 .AnyAsync(uta => uta.TemplateId == templateId && uta.UserId == userId);
        }
    }
}
