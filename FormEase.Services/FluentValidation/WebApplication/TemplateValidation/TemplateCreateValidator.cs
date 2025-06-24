using FluentValidation;
using FormEase.Core.Dtos.TemplateDtos;
using FormEase.Services.FluentValidation.WebApplication.QuestionValidation;

namespace FormEase.Services.FluentValidation.WebApplication.TemplateValidation
{
	public class TemplateCreateValidator : AbstractValidator<TemplateCreateDto>
	{
		public TemplateCreateValidator()
		{
			RuleFor(t => t.TopicId).NotEmpty().NotNull().WithMessage("Select a Topic");

			RuleForEach(t => t.Questions)
				.SetValidator(new QuestionCreateValidator());
		}
	}
}
