using FormEase.Core.Interfaces.WebApplication.CoreModels;
using FormEase.Core.Models.WebApplication.CoreModels;
using FormEase.Infrastructure.PostgreSQL.Data;
using Microsoft.EntityFrameworkCore;

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


        public async Task AddRangeAsync(List<QuestionOption> options)
        {
            await _context.QuestionOptions.AddRangeAsync(options);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateRangeAsync(List<QuestionOption> options)
        {
            _context.QuestionOptions.UpdateRange(options);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteRangeAsync(List<Guid> ids)
        {
            var questionOpt = new List<QuestionOption>();
            foreach (var id in ids)
            {
                var question = await _context.QuestionOptions.FindAsync(id);
                if (question != null)
                {
                    questionOpt.Add(question);
                }
            }
            _context.QuestionOptions.RemoveRange(questionOpt);
            await _context.SaveChangesAsync();
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
