namespace FormEase.Core.Models.WebApplication.CoreModels
{
	public class SelectedOption
	{
		public Guid Id { get; set; }

		public Guid AnswerId { get; set; }
		public Answer Answer { get; set; }

		public Guid OptionId { get; set; }
		public QuestionOption Option { get; set; }
	}
}
