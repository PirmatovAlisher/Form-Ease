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


		public Task AddRangeAsync(IEnumerable<TemplateTag> templateTags)
		{
			_context.TemplateTags.AddRange(templateTags);
			return Task.CompletedTask;
		}

		public Task RemoveRangeAsync(IEnumerable<TemplateTag> tempTags)
		{

			if (tempTags == null) return Task.CompletedTask;

			_context.TemplateTags.RemoveRange(tempTags);
			return Task.CompletedTask;
		}

		public async Task<bool> ExistsAsync(Guid templateId, Guid tagId)
		{
			return await _context.TemplateTags.AnyAsync(tt => tt.TemplateId == templateId && tt.TagId == tagId);
		}
	}
}
