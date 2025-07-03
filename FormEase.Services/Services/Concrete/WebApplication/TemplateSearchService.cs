using AutoMapper;
using FormEase.Core.Dtos.TemplateDtos;
using FormEase.Core.Models.WebApplication.MetadataModels;
using FormEase.Infrastructure.PostgreSQL.Data;
using Microsoft.EntityFrameworkCore;
using NpgsqlTypes;

namespace FormEase.Services.Services.Concrete.WebApplication
{
	public class TemplateSearchService
	{
		private readonly ApplicationDbContext _context;
		private readonly IMapper _mapper;

		public TemplateSearchService(ApplicationDbContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}

		public async Task<List<TemplateDisplayDto>> SearchTemplatesAsync(string searchTerm, int limit = 20)
		{
			if (string.IsNullOrWhiteSpace(searchTerm))
			{
				return new();
			}

			var searchTsQuery = searchTerm.Replace(" ", " & ");

			var templates = await _context.Templates
				.Where(t => t.IsPublic &&  EF.Property<NpgsqlTsVector>(t, "SearchVector")
				.Matches(EF.Functions.ToTsQuery("english", searchTsQuery)))
				.Include(t => t.Topic)
				.Include(t => t.Creator)
				.Include(t => t.Likes)
				.OrderByDescending(t => t.CreatedAt)
				.Take(limit)
				.ToListAsync();

			var dtos = _mapper.Map<List<TemplateDisplayDto>>(templates);
			if (dtos.Any())
			{
				return dtos;
			}
			return new();
		}

		public async Task<List<TemplateDisplayDto>> GetTemplatesByTagIdAsync(string tagId)
		{
			var templates = await _context.TemplateTags
				.Where(tt => tt.TagId == Guid.Parse(tagId))
				.Include(tt => tt.Template)
				.ThenInclude(t =>t.Creator) 
				.Select(tt => tt.Template)
				.OrderByDescending(t => t.CreatedAt)
				.ToListAsync();

			var dtos = _mapper.Map<List<TemplateDisplayDto>>(templates);
			if (dtos.Any())
			{
				return dtos;
			}
			return new();
		}

		public async Task<List<Tag>> GetPopularTagsAsync(int count = 20)
		{
			return await _context.TemplateTags
				.GroupBy(tt => tt.Tag)
				.OrderByDescending(g => g.Count())
				.Select(g => g.Key)
				.Take(count)
				.ToListAsync();
		}
	}
}
