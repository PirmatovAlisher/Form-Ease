using FormEase.Core.Dtos.QuestionOptionDtos;

namespace FormEase.Core.Dtos.AnswerDros
{
	public class AnswerDto
	{
		public Guid Id { get; set; }

		public string? Value { get; set; }

		public Guid QuestionId { get; set; }
		public Guid ResponseId { get; set; }

		public List<SelectedOptionDto> SelectedOptions { get; set; } = new();
	}
}
