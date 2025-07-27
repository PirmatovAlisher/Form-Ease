namespace FormEase.Core.Models.WebApplication.AggregationModels
{
	public class ChoiceAggregation
	{
		public Dictionary<string, int>? OptionCounts { get; set; }
		public List<string>? MostFrequentOptions { get; set; }
	}
}
