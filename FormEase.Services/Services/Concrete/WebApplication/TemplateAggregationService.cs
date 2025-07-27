using FormEase.Core.Models.WebApplication.AggregationModels;
using FormEase.Core.Models.WebApplication.CoreModels;
using FormEase.Infrastructure.PostgreSQL.Data;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace FormEase.Services.Services.Concrete.WebApplication
{
	public class TemplateAggregationService
	{
		private readonly ApplicationDbContext _context;

		public TemplateAggregationService(ApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<List<QuestionAggregation>> GetAggregatedAnswersForTemplate(Guid templateId)
		{
			var template = await _context.Templates
				.Where(t => t.Id == templateId)
				.Include(t => t.Questions.OrderBy(q => q.Order))
				.Include(t => t.FormResponses)
				.ThenInclude(fr => fr.Answers)
				.ThenInclude(a => a.SelectedOptions)
				.ThenInclude(so => so.Option)
				.FirstOrDefaultAsync();

			if (template == null)
			{
				return new();
			}

			var aggregations = new List<QuestionAggregation>();

			foreach (var question in template.Questions.OrderBy(q => q.Order))
			{
				var questionAgg = new QuestionAggregation
				{
					Id = question.Id,
					Title = question.Title,
					QuestionType = question.Type
				};

				var answersForQuestion = template.FormResponses
					.SelectMany(fr => fr.Answers)
					.Where(a => a.QuestionId == question.Id)
					.ToList();

				questionAgg.TotalResponses = answersForQuestion.Count;

				if (questionAgg.TotalResponses == 0)
				{
					aggregations.Add(questionAgg);
					continue;
				}

				// --- REVISED SWITCH STATEMENT ---
				switch (question.Type)
				{
					case QuestionType.Text:
					case QuestionType.Paragraph: // Both Text and Paragraph use text aggregation
						AggregateText(questionAgg, answersForQuestion);
						break;
					case QuestionType.Number:
						AggregateNumber(questionAgg, answersForQuestion);
						break;
					case QuestionType.Dropdown:   // Maps to SingleChoice logic
					case QuestionType.Checkboxes: // Maps to MultipleChoice logic
						AggregateChoice(questionAgg, answersForQuestion);
						break;
					// If you add new QuestionTypes later (e.g., Date, File), add new cases here
					default:
						// Handle unaggregated types or log a warning if needed
						break;
				}
				aggregations.Add(questionAgg);
			}

			return aggregations;
		}

		private void AggregateText(QuestionAggregation agg, List<Answer> answers)
		{
			var valueCounts = new Dictionary<string, int>();
			string? mostFrequent = null;
			int maxCount = 0;

			foreach (var answer in answers.Where(a => !string.IsNullOrWhiteSpace(a.Value)))
			{
				string value = answer.Value!.Trim();
				valueCounts.TryGetValue(value, out int count);
				valueCounts[value] = count + 1;

				if (valueCounts[value] > maxCount)
				{
					maxCount = valueCounts[value];
					mostFrequent = value;
				}
			}

			agg.TextAggregate = new TextAggregation
			{
				MostFrequentAnswer = mostFrequent,
				MostFrequentCount = maxCount,
				ValueCounts = valueCounts.OrderByDescending(kv => kv.Value).ToDictionary(kv => kv.Key, kv => kv.Value)
			};
		}

		private void AggregateNumber(QuestionAggregation agg, List<Answer> answers)
		{
			var numericValues = answers
				.Where(a => double.TryParse(a.Value, NumberStyles.Any, CultureInfo.InvariantCulture, out _))
				.Select(a => double.Parse(a.Value!, NumberStyles.Any, CultureInfo.InvariantCulture))
				.ToList();

			if (numericValues.Any())
			{
				agg.NumberAggregate = new NumberAggregation
				{
					Average = numericValues.Average(),
					Min = numericValues.Min(),
					Max = numericValues.Max(),
					AllValues = numericValues.OrderBy(v => v).ToList()
				};
			}
		}

		private void AggregateChoice(QuestionAggregation agg, List<Answer> answers)
		{
			var optionCounts = new Dictionary<string, int>();
			List<string> allSelectedOptionNames = new List<string>();

			foreach (var answer in answers)
			{
				foreach (var selectedOption in answer.SelectedOptions)
				{
					if (selectedOption.Option != null)
					{
						string optionName = selectedOption.Option.Value;
						optionCounts.TryGetValue(optionName, out int count);
						optionCounts[optionName] = count + 1;
					}
				}
			}

			List<string> mostFrequentOptions = new List<string>();
			if (optionCounts.Any())
			{
				int maxCount = optionCounts.Values.Max();
				mostFrequentOptions = optionCounts
					.Where(kv => kv.Value == maxCount)
					.Select(kv => kv.Key)
					.ToList();
			}

			agg.ChoiceAggregate = new ChoiceAggregation
			{
				OptionCounts = optionCounts.OrderByDescending(kv => kv.Value).ToDictionary(kv => kv.Key, kv => kv.Value),
				MostFrequentOptions = mostFrequentOptions
			};
		}
	}
}
