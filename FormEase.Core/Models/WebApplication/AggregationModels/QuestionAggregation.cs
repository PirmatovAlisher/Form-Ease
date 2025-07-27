using FormEase.Core.Models.WebApplication.CoreModels;

namespace FormEase.Core.Models.WebApplication.AggregationModels
{
	public class QuestionAggregation
	{
		public Guid Id { get; set; }
		public string Title { get; set; }
		public QuestionType QuestionType { get; set; }
		public int TotalResponses { get; set; }

		public TextAggregation? TextAggregate { get; set; }
		public NumberAggregation? NumberAggregate { get; set; }
		public ChoiceAggregation? ChoiceAggregate { get; set; }
	}
}
