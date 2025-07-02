using FormEase.Core.Dtos.TemplateDtos;

namespace FormEase.Core.Dtos.FormResponseDto
{
	public class FormResponseListDto
	{
		public Guid Id { get; set; }
		public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
		public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

		public Guid TemplateId { get; set; }
		public TemplateListDto Template { get; set; }
	}
}
