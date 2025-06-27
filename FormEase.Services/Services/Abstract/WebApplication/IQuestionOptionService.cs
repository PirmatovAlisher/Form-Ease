using FluentValidation.Results;
using FormEase.Core.Dtos.QuestionDtos;

namespace FormEase.Services.Services.Abstract.WebApplication
{
	public interface IQuestionOptionService
	{
		Task<ValidationResult> ApplyOptionChangesAsync(List<QuestionDto> questionDtos);
	}
}
