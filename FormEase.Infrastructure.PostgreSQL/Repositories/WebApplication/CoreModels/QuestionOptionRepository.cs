using FormEase.Core.Interfaces.WebApplication.CoreModels;
using FormEase.Core.Models.WebApplication.CoreModels;
using FormEase.Infrastructure.PostgreSQL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace FormEase.Infrastructure.PostgreSQL.Repositories.WebApplication.CoreModels
{
	public class QuestionOptionRepository : IQuestionOptionRepository
	{
		private readonly ApplicationDbContext _context;

		public QuestionOptionRepository(ApplicationDbContext context)
		{
			_context = context;
		}


		public async Task<QuestionOption> GetByIdAsync(Guid id)
		{
			return await _context.QuestionOptions.FindAsync(id);
		}

		public async Task<List<QuestionOption>> GetByQuestionIdAsync(Guid questionId)
		{
			var questionOpt = await _context.QuestionOptions
				.Where(o => o.QuestionId == questionId)
				.ToListAsync();

			return questionOpt;
		}

		public async Task<List<QuestionOption>> GetByQuestionIdsAsync(List<Guid> questionIds)
		{
			var options = await _context.QuestionOptions
				.Where(o => questionIds.Contains(o.QuestionId))
				.ToListAsync();

			return options;
		}


		public Task AddRangeAsync(List<QuestionOption> options)
		{
			_context.QuestionOptions.AddRange(options);
			return Task.CompletedTask;
		}

		public Task UpdateRangeAsync(List<QuestionOption> options)
		{
			_context.QuestionOptions.UpdateRange(options);
			return Task.CompletedTask;
		}

		public Task DeleteRangeAsync(List<Guid> ids)
		{
			var toDelete = _context.QuestionOptions
				.Where(o => ids.Contains(o.Id))
				.ToList();

			if (toDelete != null && toDelete.Any())
			{
				_context.QuestionOptions.RemoveRange(toDelete);
			}
			return Task.CompletedTask;
		}

		public Task DeleteRangeAsync(List<QuestionOption> options)
		{
			var ids = options.Select(o => o.Id).ToHashSet();
			var toDelete = _context.QuestionOptions
				.Where(o => ids.Contains(o.Id))
				.ToList();

			if (toDelete != null && toDelete.Any())
			{
				_context.QuestionOptions.RemoveRange(toDelete);
			}
			return Task.CompletedTask;
		}


		public async Task DeleteByQuestionIdAsync(Guid questionId)
		{
			var questionOpt = _context.QuestionOptions.FirstOrDefault(o => o.QuestionId == questionId);
			if (questionOpt != null)
			{
				_context.QuestionOptions.Remove(questionOpt);
				await _context.SaveChangesAsync();
			}
		}

		public async Task<bool> ExistsAsync(Guid id)
		{
			return await _context.QuestionOptions.AnyAsync(o => o.Id == id);
		}
	}
}
