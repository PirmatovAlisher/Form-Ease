using FormEase.Core.Interfaces.WebApplication.CoreModels;
using FormEase.Core.Models.WebApplication.CoreModels;
using FormEase.Infrastructure.PostgreSQL.Data;
using Microsoft.EntityFrameworkCore;

namespace FormEase.Infrastructure.PostgreSQL.Repositories.WebApplication.CoreModels
{
	public class QuestionRepository : IQuestionRepository
	{
		private readonly ApplicationDbContext _context;

		public QuestionRepository(ApplicationDbContext context)
		{
			_context = context;
		}


		public async Task<Question> GetByIdAsync(Guid id)
		{
			return await _context.Questions
				.FindAsync(id);
		}

		public async Task<Question> GetWithOptionsByIdAsync(Guid id)
		{
			return await _context.Questions
				.Include(q => q.Options)
				.FirstOrDefaultAsync(q => q.Id == id);
		}

		public async Task<List<Question>> GetByTemplateIdWithOptionsAsync(Guid templateId)
		{
			var questions = await _context.Questions
				 .Where(q => q.TemplateId == templateId)
				 .Include(q => q.Options)
				 .OrderBy(q => q.Order)
				 .ToListAsync();

			return questions;
		}


		public Task AddRangeAsync(IEnumerable<Question> questions)
		{
			_context.Questions.AddRange(questions);
			return Task.CompletedTask;
		}

		public Task UpdateRangeAsync(IEnumerable<Question> questions)
		{
			_context.Questions.UpdateRange(questions);
			return Task.CompletedTask;
		}

		public Task DeleteRangeAsync(List<Guid> ids)
		{
			var toRemove = _context.Questions
				.Where(q => ids.Contains(q.Id))
				.ToList();

			if (toRemove != null && toRemove.Any())
			{
				_context.Questions.RemoveRange(toRemove);
			}
			return Task.CompletedTask;
		}

		public Task DeleteRangeAsync(IEnumerable<Question> questions)
		{
			var ids = questions.Select(q => q.Id).ToHashSet();
			var toRemove = _context.Questions
				.Where(q => ids.Contains(q.Id))
				.ToList();

			if (toRemove != null && toRemove.Any())
			{
				_context.Questions.RemoveRange(toRemove);
			}
			return Task.CompletedTask;
		}

	}
}
