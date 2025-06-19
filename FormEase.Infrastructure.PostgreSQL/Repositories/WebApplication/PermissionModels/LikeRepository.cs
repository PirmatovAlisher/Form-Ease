using FormEase.Core.Interfaces.WebApplication.PermissionModels;
using FormEase.Core.Models.WebApplication.PermissionModels;
using FormEase.Infrastructure.PostgreSQL.Data;
using Microsoft.EntityFrameworkCore;

namespace FormEase.Infrastructure.PostgreSQL.Repositories.WebApplication.PermissionModels
{
    public class LikeRepository : ILikeRepository
    {
        private readonly ApplicationDbContext _context;

        public LikeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Like?> GetByIdAsync(Guid id)
        {
            return await _context.Likes.FindAsync(id);
        }

        public async Task<int> GetCountForTemplateAsync(Guid templateId)
        {
            return await _context.Likes.AsNoTracking().CountAsync(l => l.TemplateId == templateId);
        }


        public async Task AddAsync(Like like)
        {
            await _context.Likes.AddAsync(like);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveAsync(Like like)
        {
            _context.Likes.Remove(like);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveByUserAndTemplateAsync(string userId, Guid templateId)
        {
            var like = await _context.Likes
                .FirstOrDefaultAsync(l => l.UserId == userId && l.TemplateId == templateId);

            if (like != null)
            {
                _context.Likes.Remove(like);
                await _context.SaveChangesAsync();
            }
        }


        public async Task<bool> ExistsAsync(Guid templateId, string userId)
        {
            return await _context.Likes
                 .AsNoTracking()
                 .AnyAsync(l => l.UserId == userId && l.TemplateId == templateId);
        }
    }
}
