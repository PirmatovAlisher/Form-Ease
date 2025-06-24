using System.ComponentModel.DataAnnotations;

namespace FormEase.Core.Dtos.QuestionOptionDtos
{
	public class QuestionOptionDto
	{
		public Guid Id { get; set; } = Guid.NewGuid();

		[Required]
		public string Value { get; set; }

		public Guid QuestionId { get; set; }
	}
}
