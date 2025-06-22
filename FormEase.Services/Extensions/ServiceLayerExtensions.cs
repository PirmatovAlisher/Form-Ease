using FormEase.Services.Extensions.Identity;
using FormEase.Services.Extensions.WebApplication;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace FormEase.Services.Extensions
{
	public static class ServiceLayerExtensions
	{
		public static IServiceCollection LoadServiceLayerExtensions(this IServiceCollection services)
		{
			services.LoadIdentityExtensions();
			services.LoadWebApplicationExtensions();

			services.AddAutoMapper(Assembly.GetExecutingAssembly());

			return services;
		}
	}
}
