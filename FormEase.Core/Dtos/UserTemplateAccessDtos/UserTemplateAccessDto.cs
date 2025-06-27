using FormEase.Core.Dtos.ApplicationUserDtos;

namespace FormEase.Core.Dtos.UserTemplateAccessDtos
{
	public class UserTemplateAccessDto
	{
		public Guid Id { get; set; }

		public Guid TemplateId { get; set; }

		public string UserId { get; set; }
		public UserDisplayDto User { get; set; }
	}
}
