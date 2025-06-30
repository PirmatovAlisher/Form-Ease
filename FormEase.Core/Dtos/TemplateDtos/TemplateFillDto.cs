using FormEase.Core.Dtos.CommentDtos;
using FormEase.Core.Dtos.QuestionDtos;
using FormEase.Core.Dtos.UserTemplateAccessDtos;
using FormEase.Core.Models.WebApplication.MetadataModels;

namespace FormEase.Core.Dtos.TemplateDtos
{
	public class TemplateFillDto
	{
		public Guid Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string? ImageUrl { get; set; }
		public bool IsPublic { get; set; }

		public string CreatorId { get; set; }
		public Guid TopicId { get; set; }
		public string? TopicName { get; set; }
		public List<QuestionFillDto> Questions { get; set; } = new();
		public List<CommentDto> Comments { get; set; } = new();
		public List<TemplateTagViewDto> TemplateTags { get; set; } = new();
		public List<UserTemplateAccessDto> AllowedUsers { get; set; } = new();
	}
}
