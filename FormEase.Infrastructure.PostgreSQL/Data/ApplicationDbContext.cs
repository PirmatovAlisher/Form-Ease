using FormEase.Core.Models.Identity;
using FormEase.Core.Models.WebApplication.AccessControlModels;
using FormEase.Core.Models.WebApplication.CoreModels;
using FormEase.Core.Models.WebApplication.MetadataModels;
using FormEase.Core.Models.WebApplication.PermissionModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace FormEase.Infrastructure.PostgreSQL.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {

        public DbSet<Template> Templates { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<QuestionOption> QuestionOptions { get; set; }
        public DbSet<FormResponse> FormResponses { get; set; }
        public DbSet<Answer> Answers { get; set; }

        public DbSet<Topic> Topics { get; set; }
        public DbSet<Tag> Tags { get; set; }

        public DbSet<TemplateTag> TemplateTags { get; set; }
        public DbSet<UserTemplateAccess> UserTemplateAccesses { get; set; }

        public DbSet<Like> Likes { get; set; }
        public DbSet<Comment> Comments { get; set; }






        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }
    }
}
