using FormEase.Core.Models.WebApplication.MetadataModels;
using FormEase.Infrastructure.PostgreSQL.Data;
using FormEase.Services.Services.Abstract.WebApplication;
using Microsoft.EntityFrameworkCore;

namespace FormEase.Services.Services.Concrete.WebApplication
{
	public class TagService : ITagService
	{
		private readonly ApplicationDbContext _context;

		public TagService(ApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<List<Tag>> SearchTegByName(string query, List<string> existingTagNames, int limit = 5)
		{
			if (string.IsNullOrWhiteSpace(query) || query.Length < 2)
			{
				return new List<Tag>();
			}

			try
			{
				var normalizedQuery = $"%{query.ToLower()}%";

				var queryable = _context.Tags
					.Where(t => EF.Functions.Like(t.Name.ToLower(), normalizedQuery));

				if (existingTagNames.Count > 0)
				{
					queryable = queryable.Where(t => !existingTagNames.Contains(t.Name));
				}

				var tags = await queryable
					.OrderBy(t => t.Name)
					.Take(limit)
					.ToListAsync();

				return tags;

			}
			catch (Exception ex)
			{
				return new List<Tag>();
			}
		}
	}
}
