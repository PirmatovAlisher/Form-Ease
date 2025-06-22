using FormEase.Core.Models.WebApplication.MetadataModels;
using System.ComponentModel.DataAnnotations;

namespace FormEase.Core.Dtos.TemplateDtos
{
	public class TemplateListDto
	{
		public Guid Id { get; set; }

		public string Title { get; set; }

		public string Description { get; set; }

		public bool IsPublic { get; set; } = true;

		public DateTime CreatedAt { get; set; } 
		public DateTime UpdatedAt { get; set; } 

		public Guid TopicId { get; set; }
		public Topic Topic { get; set; }
	}
}
