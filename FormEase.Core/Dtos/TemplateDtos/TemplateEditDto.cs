using FormEase.Core.Dtos.QuestionDtos;
using FormEase.Core.Dtos.UserTemplateAccessDtos;
using FormEase.Core.Models.WebApplication.AccessControlModels;
using System.ComponentModel.DataAnnotations;

namespace FormEase.Core.Dtos.TemplateDtos
{
	public class TemplateEditDto
	{
		public Guid Id { get; set; }

		[Required, MaxLength(200)]
		public string Title { get; set; }

		[Required, MaxLength(2000)]
		public string Description { get; set; }

		public string? ImageUrl { get; set; }
		public bool IsPublic { get; set; }
		public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

		public string CreatorId { get; set; }

		[Required]
		public Guid TopicId { get; set; }

		public List<QuestionDto> Questions { get; set; } = new();

		public List<TemplateTag> TemplateTags { get; set; } = new();

		public List<UserTemplateAccessDto> AllowedUsers { get; set; } = new();
	}
}
