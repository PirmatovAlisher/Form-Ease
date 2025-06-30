using FormEase.Core.Models.WebApplication.CoreModels;

namespace FormEase.Core.Dtos.QuestionOptionDtos
{
	public class SelectedOptionDto
	{
		public Guid Id { get; set; }

		public Guid AnswerId { get; set; }

		public Guid OptionId { get; set; }
	}
}
