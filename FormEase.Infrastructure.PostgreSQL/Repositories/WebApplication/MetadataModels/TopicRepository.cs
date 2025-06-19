using FormEase.Core.Interfaces.WebApplication.MetadataModels;
using FormEase.Core.Models.WebApplication.MetadataModels;
using FormEase.Infrastructure.PostgreSQL.Data;
using Microsoft.EntityFrameworkCore;

namespace FormEase.Infrastructure.PostgreSQL.Repositories.WebApplication.MetadataModels
{
    public class TopicRepository : ITopicRepository
    {
        private readonly ApplicationDbContext _context;

        public TopicRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Topic>> GetAllAsync()
        {
            return await _context.Topics.ToListAsync();
        }
    }
}
