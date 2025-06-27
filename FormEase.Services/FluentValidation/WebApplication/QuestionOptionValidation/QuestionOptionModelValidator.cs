using FluentValidation;
using FormEase.Core.Models.WebApplication.CoreModels;

namespace FormEase.Services.FluentValidation.WebApplication.QuestionOptionValidation
{
	public class QuestionOptionModelValidator : AbstractValidator<QuestionOption>
	{
		public QuestionOptionModelValidator()
		{
			RuleFor(o => o.Value)
					.Must(value => !string.IsNullOrWhiteSpace(value))
					.WithMessage("Question Option text is required.");
		}
	}
}
