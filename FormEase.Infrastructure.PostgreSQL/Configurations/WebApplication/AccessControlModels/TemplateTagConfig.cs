using FormEase.Core.Models.WebApplication.AccessControlModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FormEase.Infrastructure.PostgreSQL.Configurations.WebApplication.AccessControlModels
{
    internal class TemplateTagConfig : IEntityTypeConfiguration<TemplateTag>
    {
        public void Configure(EntityTypeBuilder<TemplateTag> builder)
        {
            builder.HasOne(tt => tt.Template)
                .WithMany(t => t.TemplateTags)
                .HasForeignKey(tt => tt.TemplateId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
