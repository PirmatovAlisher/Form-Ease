using FormEase.Core.Interfaces.WebApplication.AccessControlModels;
using FormEase.Core.Models.WebApplication.AccessControlModels;
using FormEase.Infrastructure.PostgreSQL.Data;
using Microsoft.EntityFrameworkCore;

namespace FormEase.Infrastructure.PostgreSQL.Repositories.WebApplication.AccessControlModels
{
    public class TemplateTagRepository : ITemplateTagRepository
    {
        private readonly ApplicationDbContext _context;

        public TemplateTagRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<TemplateTag> GetByIdAsync(Guid id)
        {
            var tagTemp = await _context.TemplateTags
                .Include(tt => tt.Tag)
                .Include(tt => tt.Template)
                .FirstOrDefaultAsync(tt => tt.Id == id);

            return tagTemp;
        }

        public async Task<List<TemplateTag>> GetByTemplateIdAsync(Guid templateId)
        {
            var tagTeps = await _context.TemplateTags
                .Where(tt => tt.TemplateId == templateId)
                .Include(tt => tt.Tag)
                .OrderBy(tt => tt.Tag.Name)
                .ToListAsync();

            return tagTeps;
        }

        public async Task<List<TemplateTag>> GetByTagIdAsync(Guid tagId)
        {
            var tagTemps = await _context.TemplateTags
                .Where(tt => tt.TagId == tagId)
                .Include(tt => tt.Template)
                .Include(tt => tt.Tag)
                .OrderBy(tt => tt.Tag.Name)
                .ToListAsync();

            return tagTemps;
        }


        public async Task AddRangeAsync(List<TemplateTag> templateTags)
        {
            await _context.TemplateTags.AddRangeAsync(templateTags);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveRangeAsync(List<Guid> tagTempIds)
        {
            var tagTemps = new List<TemplateTag>();
            foreach (var tagTempId in tagTempIds)
            {
                var tagTemp = await _context.TemplateTags.FindAsync(tagTempId);
                if (tagTemp != null)
                {
                    tagTemps.Add(tagTemp);
                }
            }
            _context.TemplateTags.RemoveRange(tagTemps);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> ExistsAsync(Guid templateId, Guid tagId)
        {
            return await _context.TemplateTags.AnyAsync(tt => tt.TemplateId == templateId && tt.TagId == tagId);
        }
    }
}
