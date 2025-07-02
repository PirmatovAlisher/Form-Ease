using FluentValidation;
using FormEase.Core.Dtos.FormResponseDto;
using FormEase.Services.FluentValidation.WebApplication.AnswerValidation;

namespace FormEase.Services.FluentValidation.WebApplication.FormValidation
{
	public class FormEditValidator : AbstractValidator<FormResponseEditDto>
	{
		public FormEditValidator()
		{
			RuleForEach(t => t.Answers)
							.SetValidator(new AnswerValidator());
		}
	}
}
