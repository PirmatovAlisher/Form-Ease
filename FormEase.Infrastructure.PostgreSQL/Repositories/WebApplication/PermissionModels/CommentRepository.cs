using FormEase.Core.Interfaces.WebApplication.PermissionModels;
using FormEase.Core.Models.WebApplication.PermissionModels;
using FormEase.Infrastructure.PostgreSQL.Data;
using Microsoft.EntityFrameworkCore;

namespace FormEase.Infrastructure.PostgreSQL.Repositories.WebApplication.PermissionModels
{
    public class CommentRepository : ICommentRepository
    {
        private readonly ApplicationDbContext _context;

        public CommentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Comment> GetByIdAsync(Guid id)
        {
            var comment = await _context.Comments
                .Include(c => c.Template)
                .Include(c => c.Author)
                .FirstOrDefaultAsync(c => c.Id == id);
            return comment;
        }

        public async Task<List<Comment>> GetByTemplateIdAsync(Guid templateId)
        {
            var comments = await _context.Comments
                .Where(c => c.TemplateId == templateId)
                .Include(c => c.AuthorId)
                .OrderBy(c => c.CreatedAt)
                .ToListAsync();

            return comments;
        }

        public async Task<List<Comment>> GetByUserIdAsync(string userId)
        {
            var comments = await _context.Comments
                .Where(c => c.AuthorId == userId)
                .Include(c => c.Template)
                .OrderBy(c => c.CreatedAt)
                .ToListAsync();

            return comments;
        }


        public async Task AddRangeAsync(List<Comment> comments)
        {
            await _context.Comments.AddRangeAsync(comments);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateRangeAsync(List<Comment> comments)
        {
            _context.Comments.UpdateRange(comments);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteRangeAsync(List<Guid> ids)
        {
            var comments = new List<Comment>();

            foreach (var id in ids)
            {
                var comment = await _context.Comments.FindAsync(id);
                if (comment != null)
                {
                    comments.Add(comment);
                }
            }
            _context.Comments.RemoveRange(comments);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> ExistsAsync(Guid id)
        {
            return await _context.Comments.AnyAsync(c => c.Id == id);
        }
    }
}
