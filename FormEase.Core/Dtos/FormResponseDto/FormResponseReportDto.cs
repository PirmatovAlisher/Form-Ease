using FormEase.Core.Dtos.ApplicationUserDtos;

namespace FormEase.Core.Dtos.FormResponseDto
{
	public class FormResponseReportDto
	{
		public Guid Id { get; set; }
		public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
		public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

		public Guid TemplateId { get; set; }
		public string RespondentId { get; set; }
		public UserDisplayDto Respondent { get; set; }
	}
}
