using FormEase.Core.Dtos.ApplicationUserDtos;
using FormEase.Core.Models.WebApplication.MetadataModels;
using FormEase.Core.Models.WebApplication.PermissionModels;

namespace FormEase.Core.Dtos.TemplateDtos
{
	public class TemplateDisplayDto
	{
		public Guid Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string? ImageUrl { get; set; }

		public string CreatorId { get; set; }
		public UserDisplayDto Creator { get; set; }
		public Guid TopicId { get; set; }
		public Topic Topic { get; set; }
		public List<Like> Likes { get; set; } = new();
	}
}
