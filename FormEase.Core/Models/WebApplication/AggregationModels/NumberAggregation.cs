namespace FormEase.Core.Models.WebApplication.AggregationModels
{
	public class NumberAggregation
	{
		public double? Average { get; set; }
		public double? Min { get; set; }
		public double? Max { get; set; }
		public List<double>? AllValues { get; set; }
	}
}
