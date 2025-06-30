using FluentValidation;
using FormEase.Core.Dtos.AnswerDros;

namespace FormEase.Services.FluentValidation.WebApplication.AnswerValidation
{
	public class AnswerValidator : AbstractValidator<AnswerDto>
	{
		public AnswerValidator()
		{
			When(a => a.SelectedOptions.Count == 0, () =>
			{
				RuleFor(a => a.Value)
						.Must(value => !string.IsNullOrWhiteSpace(value))
						.WithMessage("Answer is required.");
			});
		}
	}
}
