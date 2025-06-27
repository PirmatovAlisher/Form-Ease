using FormEase.Core.Interfaces.WebApplication.CoreModels;
using FormEase.Core.Models.WebApplication.CoreModels;
using FormEase.Infrastructure.PostgreSQL.Data;
using Microsoft.EntityFrameworkCore;

namespace FormEase.Infrastructure.PostgreSQL.Repositories.WebApplication.CoreModels
{
	public class FormResponseRepository : IFormResponseRepository
	{
		private readonly ApplicationDbContext _context;

		public FormResponseRepository(ApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<FormResponse> GetByIdAsync(Guid id)
		{
			var form = await _context.FormResponses
				.Include(fr => fr.Answers)
				.ThenInclude(a => a.Question)
				.Include(fr => fr.Template)
				.ThenInclude(t => t.Questions)
				.Include(fr => fr.Respondent)
				.FirstOrDefaultAsync(fr => fr.Id == id);

			return form;
		}

		public async Task<List<FormResponse>> GetByTemplateIdAsync(Guid templateId)
		{
			var forms = await _context.FormResponses
				.Where(fr => fr.TemplateId == templateId)
				.Include(fr => fr.Answers)
				.Include(fr => fr.Respondent)
				.OrderBy(fr => fr.CreatedAt)
				.ToListAsync();

			return forms;
		}

		public async Task<List<FormResponse>> GetByRespondentIdAsync(string respondentId)
		{
			var forms = await _context.FormResponses
				.Where(fr => fr.RespondentId == respondentId)
				.Include(fr => fr.Respondent)
				.Include(fr => fr.Answers)
				.OrderBy(fr => fr.CreatedAt)
				.ToListAsync();

			return forms;
		}


		public async Task AddAsync(FormResponse formResponse)
		{
			await _context.FormResponses.AddAsync(formResponse);
			await _context.SaveChangesAsync();
		}

		public async Task UpdateAsync(FormResponse formResponse)
		{
			_context.FormResponses.Update(formResponse);
			await _context.SaveChangesAsync();
		}

		public async Task DeleteRangeAsync(List<Guid> ids)
		{
			var forms = await _context.FormResponses
				.Where(fr => ids.Contains(fr.Id))
				.ToListAsync();

			if (forms != null && forms.Any())
			{
				_context.FormResponses.RemoveRange(forms);
				await _context.SaveChangesAsync();
			}
		}

		public async Task<bool> ExistsAsync(Guid id)
		{
			return await _context.FormResponses.AnyAsync(fr => fr.Id == id);
		}
	}
}
