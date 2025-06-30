using FormEase.Core.Dtos.TemplateDtos;
using FormEase.Core.Interfaces.WebApplication.CoreModels;
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

		public async Task<List<Template>> GetByCreatorIdAsync(string creatorId)
		{
			var creatorTemps = await _context.Templates
				.AsNoTracking()
				.Where(t => t.CreatorId == creatorId)
				.Include(t => t.Topic)
				.OrderByDescending(t => t.UpdatedAt)
				.ToListAsync();

			return creatorTemps;
		}

		public async Task<Template> GetByIdWithDetailsAsync(Guid id)
		{
			var tempWithDetails = await _context.Templates
				.Include(t => t.Topic)
				.Include(t => t.Questions.OrderBy(q => q.Order))
				.ThenInclude(q => q.Options)
				.Include(t => t.TemplateTags)
				.ThenInclude(tt => tt.Tag)
				.Include(t => t.AllowedUsers)
				.ThenInclude(au => au.User)
				.FirstOrDefaultAsync(t => t.Id == id);

			return tempWithDetails;
		}

		public async Task<List<Template>> GetLatestTemplatesAsync(int limit)
		{
			return await _context.Templates
				.Where(t => t.IsPublic == true)
				.OrderByDescending(t => t.CreatedAt)
				.Take(limit)
				.Include(t => t.Topic)
				.Include(t => t.Creator)
				.Include(t => t.Likes)
				.ToListAsync();
		}

		public async Task<List<Template>> GetByCreatorIdWithDetailsAsync(string creatorId)
		{
			var creatorTemps = await _context.Templates
				.AsNoTracking()
				.Where(t => t.CreatorId == creatorId)
				.Include(t => t.Topic)
				.Include(t => t.TemplateTags)
				.ThenInclude(tt => tt.Tag)
				.ToListAsync();

			return creatorTemps;
		}

		public async Task<List<Template>> GetPublicTemplatesAsync()
		{
			var publicTemps = await _context.Templates
				.AsNoTracking()
				.Where(t => t.IsPublic == true)
				.Include(t => t.Creator)
				.Include(t => t.Topic)
				.Include(t => t.TemplateTags)
				.ThenInclude(tt => tt.Tag)
				.OrderBy(t => t.CreatedAt)
				.ToListAsync();

			return publicTemps;
		}

		public async Task<List<Template>> GetAccessibleTemplatesAsync(string userId)
		{
			var accessibleTemps = await _context.Templates
				.AsNoTracking()
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

		public async Task<string> GetCreatorIdByTemplateId(Guid templateId)
		{
			var template = await _context.Templates.FindAsync(templateId);

			return template.CreatorId;

		}

		public Task AddAsync(Template template)
		{
			_context.Templates.Add(template);
			return Task.CompletedTask;
		}

		public async Task UpdateAsync(Template template)
		{
			_context.UpdateRange(template);
			await _context.SaveChangesAsync();
		}

		public async Task DeleteRangeAsync(List<Guid> ids)
		{
			var templates = await _context.Templates
				.Where(t => ids.Contains(t.Id))
				.ToListAsync();

			_context.Templates.RemoveRange(templates);
			await _context.SaveChangesAsync();
		}

		public async Task SaveChangesAsync()
		{
			await _context.SaveChangesAsync();
		}

		public async Task<Template> GetByIdToFillAsync(Guid id)
		{
			var template = await _context.Templates
				.Include(t => t.Topic)
				.Include(t => t.Questions.OrderBy(q => q.Order))
				.ThenInclude(tq => tq.Options)
				.Include(t => t.Comments)
				.ThenInclude(tc => tc.Author)
				.Include(t => t.TemplateTags)
				.ThenInclude(tt => tt.Tag)
				.Include(t => t.AllowedUsers)
				.ThenInclude(ta => ta.User)
				.FirstOrDefaultAsync(t => t.Id == id);

			return template;
		}

		public async Task<Template> GetAllowedUsersByIdAsync(Guid templateId)
		{
			var template = await _context.Templates
				.Include(t => t.AllowedUsers)
				.ThenInclude(au => au.User)
				.FirstOrDefaultAsync(t => t.Id == templateId);

			return template;
		}
	}
}
