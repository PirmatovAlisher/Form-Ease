using FormEase.Core.Dtos.QuestionOptionDtos;
using FormEase.Core.Models.WebApplication.CoreModels;

namespace FormEase.Core.Dtos.QuestionDtos
{
	public class QuestionFillDto
	{
		public Guid Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public int Order { get; set; }
		public bool IsRequired { get; set; }
		public QuestionType Type { get; set; } = QuestionType.Text;


		public Guid TemplateId { get; set; }
		public List<QuestionOptionDto> Options { get; set; }
	}
}
