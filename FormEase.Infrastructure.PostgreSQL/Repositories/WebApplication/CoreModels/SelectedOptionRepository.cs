using FormEase.Core.Interfaces.WebApplication.CoreModels;
using FormEase.Core.Models.WebApplication.CoreModels;
using FormEase.Infrastructure.PostgreSQL.Data;

namespace FormEase.Infrastructure.PostgreSQL.Repositories.WebApplication.CoreModels
{
	public class SelectedOptionRepository : ISelectedOptionRepository
	{
		private readonly ApplicationDbContext _context;

		public SelectedOptionRepository(ApplicationDbContext context)
		{
			_context = context;
		}

		public async Task AddRangeAsync(List<SelectedOption> options)
		{
			await _context.SelectedOptions.AddRangeAsync(options);
		}

		public void DeleteRange(List<SelectedOption> options)
		{
			_context.RemoveRange(options);
		}
	}
}
