namespace FormEase.Core.Models.WebApplication.CoreModels
{
	public class Answer
	{
		public Guid Id { get; set; }
		public string? Value { get; set; }

		public Guid QuestionId { get; set; }
		public Question Question { get; set; }
		public Guid ResponseId { get; set; }
		public FormResponse Response { get; set; }

		public List<SelectedOption> SelectedOptions { get; set; } = new();
	}
}
