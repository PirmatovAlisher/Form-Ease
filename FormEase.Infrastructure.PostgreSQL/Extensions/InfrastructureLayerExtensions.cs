using FormEase.Core.Interfaces.WebApplication.AccessControlModels;
using FormEase.Core.Interfaces.WebApplication.CoreModels;
using FormEase.Core.Interfaces.WebApplication.MetadataModels;
using FormEase.Core.Interfaces.WebApplication.PermissionModels;
using FormEase.Infrastructure.PostgreSQL.Repositories.WebApplication.AccessControlModels;
using FormEase.Infrastructure.PostgreSQL.Repositories.WebApplication.CoreModels;
using FormEase.Infrastructure.PostgreSQL.Repositories.WebApplication.MetadataModels;
using FormEase.Infrastructure.PostgreSQL.Repositories.WebApplication.PermissionModels;
using Microsoft.Extensions.DependencyInjection;

namespace FormEase.Infrastructure.PostgreSQL.Extensions
{
    public static class InfrastructureLayerExtensions
    {
        public static IServiceCollection LoadInfrastructureLayerExtensions(this IServiceCollection services)
        {
            services.AddScoped<ITemplateRepository, TemplateRepository>();
            services.AddScoped<IQuestionRepository, QuestionRepository>();
            services.AddScoped<IQuestionOptionRepository, QuestionOptionRepository>();
            services.AddScoped<IFormResponseRepository, FormResponseRepository>();
            services.AddScoped<IAnswerRepository, AnswerRepository>();
            services.AddScoped<ITopicRepository, TopicRepository>();
            services.AddScoped<ITagRepository, TagRepository>();
            services.AddScoped<IUserTemplateAccessRepository, UserTemplateAccessRepository>();
            services.AddScoped<ITemplateTagRepository, TemplateTagRepository>();
            services.AddScoped<ICommentRepository, CommentRepository>();
            services.AddScoped<ILikeRepository, LikeRepository>();
            services.AddScoped<ISelectedOptionRepository, SelectedOptionRepository>();

            return services;
        }
    }
}
