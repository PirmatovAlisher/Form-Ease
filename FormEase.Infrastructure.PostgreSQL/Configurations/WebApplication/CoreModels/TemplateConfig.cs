using FormEase.Core.Models.WebApplication.CoreModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FormEase.Infrastructure.PostgreSQL.Configurations.WebApplication.CoreModels
{
    internal class TemplateConfig : IEntityTypeConfiguration<Template>
    {
        public void Configure(EntityTypeBuilder<Template> builder)
        {
            builder.HasIndex(t => t.TopicId);
            builder.HasIndex(t => t.IsPublic);

            #region Relationships Configuration

            // Template -> Creator
            builder.HasOne(t => t.Creator)
                .WithMany(u => u.CreatedTemplates)
                .HasForeignKey(t => t.CreatorId)
                .OnDelete(DeleteBehavior.Cascade);


            // Template -> Topic
            builder.HasOne(t => t.Topic)
                .WithMany()
                .HasForeignKey(t => t.TopicId)
                .OnDelete(DeleteBehavior.Restrict);  // Prevents topic deletion if referenced


            // Template -> Questions (Cascade delete)
            builder.HasMany(t => t.Questions)
                .WithOne(q => q.Template)
                .HasForeignKey(q => q.TemplateId)
                .OnDelete(DeleteBehavior.Cascade);

            // Template -> FormResponses (Cascade delete)
            builder.HasMany(t => t.FormResponses)
                .WithOne(fr => fr.Template)
                .HasForeignKey(fr => fr.TemplateId)
                .OnDelete(DeleteBehavior.Cascade);

            // Template -> Tags (Many-to-many via TemplateTag)
            builder.HasMany(t => t.TemplateTags)
                .WithOne(tt => tt.Template)
                .HasForeignKey(tt => tt.TemplateId)
                .OnDelete(DeleteBehavior.Cascade);

            // Template -> Allowed Users (Many-to-many via UserTemplateAccess)
            builder.HasMany(t => t.AllowedUsers)
                .WithOne(uta => uta.Template)
                .HasForeignKey(uta => uta.TemplateId)
                .OnDelete(DeleteBehavior.Cascade);

            // Template => Comments (Cascade delete)
            builder.HasMany(tc => tc.Comments)
                .WithOne(t => t.Template)
                .HasForeignKey(tc  => tc.TemplateId)
                .OnDelete(DeleteBehavior.Cascade);

            #endregion
        }
    }
}
