using FormEase.Core.Models.WebApplication.CoreModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FormEase.Infrastructure.PostgreSQL.Configurations.WebApplication.CoreModels
{
    internal class QuestionOptionConfig : IEntityTypeConfiguration<QuestionOption>
    {
        public void Configure(EntityTypeBuilder<QuestionOption> builder)
        {

            // QuestionOption -> Question (Many-to-One)
            builder.HasOne(o => o.Question)
                .WithMany(q => q.Options)
                .HasForeignKey(o => o.QuestionId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
