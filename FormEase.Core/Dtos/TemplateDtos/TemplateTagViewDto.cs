using FormEase.Core.Models.WebApplication.CoreModels;
using FormEase.Core.Models.WebApplication.MetadataModels;

namespace FormEase.Core.Dtos.TemplateDtos
{
	public class TemplateTagViewDto
	{
		public Guid Id { get; set; }

		public Guid TemplateId { get; set; }
		public Guid TagId { get; set; }
		public Tag Tag { get; set; }
	}
}
