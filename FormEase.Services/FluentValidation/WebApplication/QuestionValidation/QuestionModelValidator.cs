using FluentValidation;
using FormEase.Core.Models.WebApplication.CoreModels;
using FormEase.Services.FluentValidation.WebApplication.QuestionOptionValidation;

namespace FormEase.Services.FluentValidation.WebApplication.QuestionValidation
{
	public class QuestionModelValidator : AbstractValidator<Question>
	{
		public QuestionModelValidator()
		{
			RuleFor(q => q.Title)
			.NotEmpty().WithMessage("Title is required.");

			RuleFor(q => q.Description)
				.NotEmpty().WithMessage("Description is required.");

			When(q => q.Type is QuestionType.Checkboxes or QuestionType.Dropdown, () =>
			{
				RuleFor(q => q.Options)
				.NotNull().WithMessage("Options are required.")
				.Must(opts => opts.Any()).WithMessage("At least one option is required.");

				RuleForEach(q => q.Options)
				.SetValidator(new QuestionOptionModelValidator());
			}
			);
		}
	}
}
