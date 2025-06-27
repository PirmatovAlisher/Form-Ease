using FluentValidation.Results;
using FormEase.Core.Dtos.QuestionDtos;

namespace FormEase.Services.Services.Abstract.WebApplication
{
	public interface IQuestionService
	{
		Task<ValidationResult> ApplyQuestionChangesAsync(Guid templateId, List<QuestionDto> questionDtos);
	}
}
