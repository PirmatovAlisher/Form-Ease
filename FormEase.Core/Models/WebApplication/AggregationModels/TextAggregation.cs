namespace FormEase.Core.Models.WebApplication.AggregationModels
{
	public class TextAggregation
	{
		public string? MostFrequentAnswer { get; set; }
		public int MostFrequentCount { get; set; }
		public Dictionary<string, int>? ValueCounts { get; set; }
	}
}
