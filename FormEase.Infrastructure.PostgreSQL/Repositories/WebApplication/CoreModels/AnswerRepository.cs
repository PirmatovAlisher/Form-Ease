using FormEase.Core.Interfaces.WebApplication.CoreModels;
using FormEase.Core.Models.WebApplication.CoreModels;
using FormEase.Infrastructure.PostgreSQL.Data;
using Microsoft.EntityFrameworkCore;

namespace FormEase.Infrastructure.PostgreSQL.Repositories.WebApplication.CoreModels
{
	public class AnswerRepository : IAnswerRepository
	{
		private readonly ApplicationDbContext _context;

		public AnswerRepository(ApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<Answer> GetByIdAsync(Guid id)
		{
			var answer = await _context.Answers.FindAsync(id);

			return answer;
		}

		public async Task<Answer> GetByIdWithDetailsAsync(Guid id)
		{
			var answer = await _context.Answers
				.Include(a => a.Question)
				.Include(a => a.Response)
				.FirstOrDefaultAsync(a => a.Id == id);

			return answer;
		}

		public async Task<List<Answer>> GetByResponseIdAsync(Guid responseId)
		{
			var answers = await _context.Answers
				.Where(a => a.ResponseId == responseId)
				.Include(a => a.Question)
				.ThenInclude(o => o.Options)
				.ToListAsync();

			return answers;
		}


		public async Task AddRangeAsync(List<Answer> answers)
		{
			await _context.Answers.AddRangeAsync(answers);
			await _context.SaveChangesAsync();
		}

		public async Task UpdateRangeAsync(List<Answer> answers)
		{
			_context.Answers.UpdateRange(answers);
			await _context.SaveChangesAsync();
		}

		public async Task DeleteRangeAsync(List<Guid> ids)
		{
			var answers = await _context.Answers
				.Where(a => ids.Contains(a.Id))
				.ToListAsync();

			if (answers != null && answers.Any())
			{
				_context.Answers.RemoveRange(answers);
				await _context.SaveChangesAsync();
			}
		}
	}
}
