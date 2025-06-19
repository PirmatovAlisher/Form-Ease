using FormEase.Core.Models.WebApplication.AccessControlModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FormEase.Infrastructure.PostgreSQL.Configurations.WebApplication.AccessControlModels
{
    internal class UserTemplateAccessConfig : IEntityTypeConfiguration<UserTemplateAccess>
    {
        public void Configure(EntityTypeBuilder<UserTemplateAccess> builder)
        {

            // Template Relationship (Many-to-One)
            builder.HasOne(uta => uta.Template)
                .WithMany(t => t.AllowedUsers)
                .HasForeignKey(uta => uta.TemplateId)
                .OnDelete(DeleteBehavior.Cascade);

            // User Relationship (Many-to-One)
            builder.HasOne(uta => uta.User)
                .WithMany(u => u.AllowedTemplates)
                .HasForeignKey(uta => uta.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
