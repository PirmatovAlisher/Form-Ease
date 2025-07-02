using FormEase.Core.Dtos.AnswerDros;
using FormEase.Core.Dtos.TemplateDtos;

namespace FormEase.Core.Dtos.FormResponseDto
{
	public class FormResponseEditDto
	{
		public Guid Id { get; set; }
		public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

		public Guid TemplateId { get; set; }
		//public TemplateFillDto Template { get; set; }
		public string RespondentId { get; set; }
		public List<AnswerDto> Answers { get; set; } = new();
	}
}
