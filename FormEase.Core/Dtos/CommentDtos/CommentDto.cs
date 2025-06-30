using FormEase.Core.Dtos.ApplicationUserDtos;

namespace FormEase.Core.Dtos.CommentDtos
{
	public class CommentDto
	{
		public Guid Id { get; set; }
		public string Content { get; set; }
		public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

		public Guid TemplateId { get; set; }
		public string AuthorId { get; set; }
		public UserDisplayDto Author { get; set; }
	}
}
