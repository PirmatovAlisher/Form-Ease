using FormEase.Core.Dtos.AnswerDros;
using FormEase.Core.Dtos.ApplicationUserDtos;

namespace FormEase.Core.Dtos.FormResponseDto
{
	public class FormResponseDto
	{
		public Guid Id { get; set; }
		public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
		public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

		public Guid TemplateId { get; set; }
		public string RespondentId { get; set; }
		public UserDisplayDto Respondent { get; set; }
		public List<AnswerDto> Answers { get; set; } = new();
	}
}
