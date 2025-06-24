using FluentValidation;
using FormEase.Core.Dtos.QuestionDtos;
using FormEase.Core.Models.WebApplication.CoreModels;
using FormEase.Services.FluentValidation.WebApplication.QuestionOptionValidation;

namespace FormEase.Services.FluentValidation.WebApplication.QuestionValidation
{
	public class QuestionCreateValidator : AbstractValidator<QuestionCreateDto>
	{
		public QuestionCreateValidator()
		{
			RuleFor(q => q.Title).NotEmpty().NotNull();
			RuleFor(q => q.Description).NotEmpty().NotNull();

			When(q => q.Type is QuestionType.Checkboxes or QuestionType.Dropdown, () =>
			RuleForEach(q => q.Options)
			.SetValidator(new QuestionOptionDtoValidator())
			);
		}
	}
}
