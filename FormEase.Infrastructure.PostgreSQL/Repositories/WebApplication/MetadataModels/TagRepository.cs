using FormEase.Core.Interfaces.WebApplication.MetadataModels;
using FormEase.Core.Models.WebApplication.MetadataModels;
using FormEase.Infrastructure.PostgreSQL.Data;
using Microsoft.EntityFrameworkCore;

namespace FormEase.Infrastructure.PostgreSQL.Repositories.WebApplication.MetadataModels
{
    public class TagRepository : ITagRepository
    {
        private readonly ApplicationDbContext _context;

        public TagRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Tag?> GetByIdAsync(Guid id)
        {
            return await _context.Tags.FindAsync(id);
        }

        public async Task<List<Tag>> GetAllAsync()
        {
            return await _context.Tags.AsNoTracking().ToListAsync();
        }

        public async Task<List<Tag>> GetByPrefixAsync(string prefix, int limit = 10)
        {
            var tags = await _context.Tags.
                Where(t => t.Name.StartsWith(prefix))
                .OrderBy(t => t.Name)
                .Take(limit)
                .AsNoTracking()
                .ToListAsync();

            return tags;
        }


        public async Task AddRangeAsync(List<Tag> tags)
        {
            await _context.Tags.AddRangeAsync(tags);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateRangeAsync(List<Tag> tags)
        {
            _context.Tags.UpdateRange(tags);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteRangeAsync(List<Guid> ids)
        {
            var tags = new List<Tag>();

            foreach (var id in ids)
            {
                var tag = await _context.Tags.FindAsync(id);
                if (tag != null)
                {
                    tags.Add(tag);
                }
            }
            _context.Tags.RemoveRange(tags);
            await _context.SaveChangesAsync();
        }


        public async Task<bool> ExistsAsync(string name)
        {
            return await _context.Tags.AnyAsync(t => t.Name == name);
        }


        public async Task<List<Tag>> GetOrCreateTagsAsync(List<string> tagNames)
        {
            var normalizedNames = tagNames
                .Select(n => n.Trim().ToLower())
                .Distinct()
                .ToList();

            var existingTags = await _context.Tags
                .Where(t => normalizedNames.Contains(t.Name.ToLower()))
                .ToListAsync();

            var existingNames = existingTags
                .Select(t => t.Name.ToLower())
                .ToHashSet();

            var newTags = normalizedNames
                .Where(n => !existingNames.Contains(n))
                .Select(n => new Tag { Name = n })
                .ToList();

            if (newTags.Any())
            {
                await _context.Tags.AddRangeAsync(newTags);
                await _context.SaveChangesAsync();
            }

            return existingTags.Concat(newTags).ToList();
        }

    }
}
