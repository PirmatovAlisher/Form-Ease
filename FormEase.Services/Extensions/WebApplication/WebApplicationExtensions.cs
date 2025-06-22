using FormEase.Services.Services.Abstract.Identity;
using FormEase.Services.Services.Abstract.WebApplication;
using FormEase.Services.Services.Concrete.Identity;
using FormEase.Services.Services.Concrete.WebApplication;
using Microsoft.Extensions.DependencyInjection;

namespace FormEase.Services.Extensions.WebApplication
{
	public static class WebApplicationExtensions
	{
		public static IServiceCollection LoadWebApplicationExtensions(this IServiceCollection services)
		{
			services.AddScoped<IImageUploadService, ImageUploadService>();
			services.AddScoped<ITemplateService, TemplateService>();
			services.AddScoped<IUserService, UserService>();

			return services;
		}
	}
}
