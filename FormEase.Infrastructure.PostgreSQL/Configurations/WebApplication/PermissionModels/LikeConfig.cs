using FormEase.Core.Models.WebApplication.PermissionModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FormEase.Infrastructure.PostgreSQL.Configurations.WebApplication.PermissionModels
{
    internal class LikeConfig : IEntityTypeConfiguration<Like>
    {
        public void Configure(EntityTypeBuilder<Like> builder)
        {

            // Relationships Configuration

            // Like -> Template (Many-to-One)
            builder.HasOne(l => l.Template)
                .WithMany(t => t.Likes)
                .HasForeignKey(l => l.TemplateId)
                .OnDelete(DeleteBehavior.Cascade);

            // Like -> User (Many-to-One)
            builder.HasOne(l => l.User)
                .WithMany(u => u.Likes)
                .HasForeignKey(l => l.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // Unique Constraint (User can like a template only once)
            builder.HasIndex(l => new { l.TemplateId, l.UserId })
                .IsUnique();
        }
    }
}
