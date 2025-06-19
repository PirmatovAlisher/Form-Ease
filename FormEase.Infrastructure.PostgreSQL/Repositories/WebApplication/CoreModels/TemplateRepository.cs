using FormEase.Core.Interfaces.WebApplication.CoreModels;
using FormEase.Core.Models.WebApplication.AccessControlModels;
using FormEase.Core.Models.WebApplication.CoreModels;
using FormEase.Infrastructure.PostgreSQL.Data;
using Microsoft.EntityFrameworkCore;

namespace FormEase.Infrastructure.PostgreSQL.Repositories.WebApplication.CoreModels
{
    public class TemplateRepository : ITemplateRepository
    {
        private readonly ApplicationDbContext _context;

        public TemplateRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Template> GetByIdAsync(Guid id)
        {
            return await _context.Templates.FindAsync(id);
        }

        public async Task<Template> GetByIdWithDetailsAsync(Guid id)
        {
            var tempWithDetails = await _context.Templates
                .Include(t => t.Creator)
                .Include(t => t.Topic)
                .Include(t => t.Questions)
                .ThenInclude(q => q.Options)
                .Include(t => t.TemplateTags)
                .ThenInclude(tt => tt.Tag)
                .Include(t => t.AllowedUsers)
                .ThenInclude(au => au.User)
                .FirstOrDefaultAsync(t => t.Id == id);

            return tempWithDetails;
        }

        public async Task<List<Template>> GetPublicTemplatesAsync()
        {
            var publicTemps = await _context.Templates
                .Where(t => t.IsPublic == true)
                .Include(t => t.Creator)
                .Include(t => t.Topic)
                .Include(t => t.TemplateTags)
                .ThenInclude(tt => tt.Tag)
                .OrderBy(t => t.CreatedAt)
                .ToListAsync();

            return publicTemps;
        }

        public async Task<List<Template>> GetByCreatorAsync(string creatorId)
        {
            var creatorTemps = await _context.Templates
                .Where(t => t.CreatorId == creatorId)
                .Include(t => t.Topic)
                .Include(t => t.TemplateTags)
                .ThenInclude(tt => tt.Tag)
                .ToListAsync();

            return creatorTemps;
        }

        public async Task<List<Template>> GetAccessibleTemplatesAsync(string userId)
        {
            var accessibleTemps = await _context.Templates
                .Where(t => t.IsPublic ||
                            t.AllowedUsers.Any(au => au.UserId == userId) ||
                            t.CreatorId == userId.ToString())
                .Include(t => t.Creator)
                .Include(t => t.Topic)
                .Include(t => t.TemplateTags)
                .ThenInclude(tt => tt.Tag)
                .ToListAsync();

            return accessibleTemps;
        }



        public async Task AddRangeAsync(List<Template> templates)
        {
            await _context.Templates.AddRangeAsync(templates);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateRangeAsync(List<Template> templates)
        {
            _context.UpdateRange(templates);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteRangeAsync(List<Guid> ids)
        {
            var templates = new List<Template>();

            foreach (var id in ids)
            {
                var template = await _context.Templates.FindAsync(id);
                if (template != null)
                {
                    templates.Add(template);
                }
            }

            _context.Templates.RemoveRange(templates);
            await _context.SaveChangesAsync();
        }



        public async Task<bool> ExistsAsync(Guid id)
        {
            return await _context.Templates.AnyAsync(t => t.Id == id);
        }

        public async Task AddAllowedUsersAsync(Guid templateId, List<string> userIds)
        {
            var userAccesses = new List<UserTemplateAccess>();

            foreach (var userId in userIds)
            {
                var access = new UserTemplateAccess
                {
                    Id = templateId,
                    UserId = userId
                };
                userAccesses.Add(access);
            }

            await _context.UserTemplateAccesses.AddRangeAsync(userAccesses);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveAllowedUsersAsync(Guid templateId, List<string> userIds)
        {
            var userAccesses = new List<UserTemplateAccess>();

            foreach (var userId in userIds)
            {
                var access = await _context.UserTemplateAccesses
                    .FirstOrDefaultAsync(a => a.TemplateId == templateId && a.UserId == userId);

                if (access != null)
                {
                    userAccesses.Add(access);
                }
            }

            _context.UserTemplateAccesses.RemoveRange(userAccesses);
            await _context.SaveChangesAsync();
        }

        public async Task AddTagsAsync(Guid templateId, List<Guid> tagIds)
        {
            var tempTags = new List<TemplateTag>();

            foreach (var tagId in tagIds)
            {
                var tempTag = new TemplateTag
                {
                    TemplateId = templateId,
                    TagId = tagId
                };
                tempTags.Add(tempTag);
            }

            await _context.TemplateTags.AddRangeAsync(tempTags);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveTagsAsync(Guid templateId, List<Guid> tagIds)
        {
            var tempTags = new List<TemplateTag>();

            foreach (var tagId in tagIds)
            {
                var tag = await _context.TemplateTags
                    .FirstOrDefaultAsync(tt => tt.TemplateId == templateId && tt.TagId == tagId);
                if (tag != null)
                {
                    tempTags.Add(tag);
                }
            }

            _context.TemplateTags.RemoveRange(tempTags);
            await _context.SaveChangesAsync();
        }

    }
}
