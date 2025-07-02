using FormEase.Core.Models.WebApplication.CoreModels;

namespace FormEase.Core.Interfaces.WebApplication.CoreModels
{
	public interface ISelectedOptionRepository
	{
		Task AddRangeAsync(List<SelectedOption> options);
		void DeleteRange(List<SelectedOption> options);
	}
}
