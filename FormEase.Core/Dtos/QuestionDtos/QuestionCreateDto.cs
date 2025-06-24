using FormEase.Core.Dtos.QuestionOptionDtos;
using FormEase.Core.Models.WebApplication.CoreModels;
using System.ComponentModel.DataAnnotations;

namespace FormEase.Core.Dtos.QuestionDtos
{
	public class QuestionCreateDto
	{
		public QuestionCreateDto()
		{
			Options = new List<QuestionOptionDto> {
				new QuestionOptionDto()
			{
					Id = Guid.NewGuid(),
					Value ="Option",
					QuestionId = Id
			}
			};
		}
		public Guid Id { get; set; } = Guid.NewGuid();

		[Required, MaxLength(255)]
		public string Title { get; set; }

		[Required, MaxLength(2000)]
		public string Description { get; set; }

		public int Order { get; set; } // Display order

		public bool IsRequired { get; set; } = false;

		public bool ShowInResponseList { get; set; } = false;

		public QuestionType Type { get; set; } = QuestionType.Text;


		public Guid TemplateId { get; set; }

		public List<QuestionOptionDto> Options { get; set; } // For choice-based questions
	}
}
