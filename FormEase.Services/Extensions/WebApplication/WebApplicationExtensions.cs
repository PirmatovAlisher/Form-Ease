using FluentValidation;
using FluentValidation.AspNetCore;
using FormEase.Services.FluentValidation.WebApplication.AnswerValidation;
using FormEase.Services.FluentValidation.WebApplication.FormValidation;
using FormEase.Services.FluentValidation.WebApplication.QuestionOptionValidation;
using FormEase.Services.FluentValidation.WebApplication.QuestionValidation;
using FormEase.Services.FluentValidation.WebApplication.TemplateValidation;
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
			services.AddScoped<PermissionService>();
			services.AddScoped<IImageUploadService, ImageUploadService>();
			services.AddScoped<ITemplateService, TemplateService>();
			services.AddScoped<IUserService, UserService>();
			services.AddScoped<ITagService, TagService>();
			services.AddScoped<IFormService, FormService>();
			services.AddScoped<ITemplateTagService, TemplateTagService>();
			services.AddScoped<IUserTemplateAccessService, UserTemplateAccessService>();
			services.AddScoped<IQuestionService, QuestionService>();
			services.AddScoped<IQuestionOptionService, QuestionOptionService>();
			services.AddScoped<ValidationService>();

			services.AddFluentValidationAutoValidation()
				.AddFluentValidationClientsideAdapters(); ;


			services.AddValidatorsFromAssemblyContaining<TemplateCreateValidator>();
			services.AddValidatorsFromAssemblyContaining<TemplateEditValidator>();
			services.AddValidatorsFromAssemblyContaining<QuestionValidator>();
			services.AddValidatorsFromAssemblyContaining<QuestionModelValidator>();
			services.AddValidatorsFromAssemblyContaining<QuestionOptionDtoValidator>();
			services.AddValidatorsFromAssemblyContaining<QuestionOptionModelValidator>();
			services.AddValidatorsFromAssemblyContaining<FormCreateValidatior>();
			services.AddValidatorsFromAssemblyContaining<FormEditValidator>();
			services.AddValidatorsFromAssemblyContaining<AnswerValidator>();

			return services;
		}
	}
}
