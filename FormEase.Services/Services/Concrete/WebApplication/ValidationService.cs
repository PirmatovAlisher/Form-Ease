using FluentValidation;
using FluentValidation.Results;
using Microsoft.Extensions.DependencyInjection;

namespace FormEase.Services.Services.Concrete.WebApplication
{
	public class ValidationService
	{
		private readonly IServiceProvider _serviceProvider;

		public ValidationService(IServiceProvider serviceProvider)
		{
			_serviceProvider = serviceProvider;
		}

		public async Task<ValidationResult> ValidateAsync<T>(T item) where T : class
		{
			var validator = _serviceProvider.GetRequiredService<IValidator<T>>();

			return await validator.ValidateAsync(item);
		}

		public async Task<ValidationResult> ValidateAsync<T>(List<T> items) where T : class
		{
			var validator = _serviceProvider.GetRequiredService<IValidator<T>>();
			var failures = new List<ValidationFailure>();
			foreach (var item in items)
			{
				var result = await validator.ValidateAsync(item);
				if (!result.IsValid)
				{
					failures.AddRange(result.Errors);
				}
			}

			return new ValidationResult(failures);
		}
	}
}
