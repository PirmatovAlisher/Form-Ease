using System.ComponentModel.DataAnnotations;

namespace FormEase.Core.Dtos.QuestionOptionDtos
{
	public class QuestionOptionDto
	{
		public Guid Id { get; set; }

		[Required(ErrorMessage = "Question option value is required")]
		public string Value { get; set; }

		public Guid QuestionId { get; set; }
	}
}
