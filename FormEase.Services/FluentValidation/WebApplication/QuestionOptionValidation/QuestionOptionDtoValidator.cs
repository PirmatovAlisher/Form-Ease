﻿using FluentValidation;
using FormEase.Core.Dtos.QuestionOptionDtos;

namespace FormEase.Services.FluentValidation.WebApplication.QuestionOptionValidation
{
	public class QuestionOptionDtoValidator : AbstractValidator<QuestionOptionDto>
	{
		public QuestionOptionDtoValidator()
		{
			RuleFor(o => o.Value)
					.Must(value => !string.IsNullOrWhiteSpace(value))
					.WithMessage("Question Option text is required.");

		}
	}
}
