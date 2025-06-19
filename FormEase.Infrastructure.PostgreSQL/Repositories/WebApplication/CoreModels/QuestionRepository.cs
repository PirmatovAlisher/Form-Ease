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

        public async Task<List<Question>> GetByTemplateIdAsync(Guid templateId)
        {
            var questions = await _context.Questions
                 .Where(q => q.TemplateId == templateId)
                 .OrderBy(q => q.Order)
                 .ToListAsync();

            return questions;
        }


        public async Task AddRangeAsync(List<Question> questions)
        {
            await _context.Questions.AddRangeAsync(questions);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateRangeAsync(List<Question> questions)
        {
            _context.Questions.UpdateRange(questions);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteRangeAsync(List<Guid> ids)
        {
            var questions = new List<Question>();

            foreach (var id in ids)
            {
                var question = await _context.Questions.FindAsync(id);

                if (question != null)
                {
                    questions.Add(question);
                }
            }
            _context.Questions.RemoveRange(questions);
            await _context.SaveChangesAsync();
        }


        public async Task UpdateShowInResponseListAsync(Guid questionId, bool showInResponseList)
        {
            var question = await _context.Questions.FindAsync(questionId);

            if (question != null)
            {
                question.ShowInResponseList = showInResponseList;
                await _context.SaveChangesAsync();
            }
        }
    }
}
