using FluentValidation;
using FormEase.Core.Dtos.TemplateDtos;
using FormEase.Services.FluentValidation.WebApplication.QuestionValidation;

namespace FormEase.Services.FluentValidation.WebApplication.TemplateValidation
{
	public class TemplateEditValidator : AbstractValidator<TemplateEditDto>
	{
		public TemplateEditValidator()
		{
			RuleFor(t => t.Title).NotNull().NotEmpty();
			RuleFor(t => t.Description).NotNull().NotEmpty();
			RuleFor(t => t.TopicId).NotNull().NotEmpty();

			RuleFor(t => t.TopicId).Must(TopicId => !string.IsNullOrWhiteSpace(TopicId.ToString()))
					.WithMessage("Select a Topic");

			RuleForEach(t => t.Questions)
				.SetValidator(new QuestionValidator());

		}
	}
}
