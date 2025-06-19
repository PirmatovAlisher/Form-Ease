using FormEase.Core.Models.WebApplication.CoreModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FormEase.Infrastructure.PostgreSQL.Configurations.WebApplication.CoreModels
{
    internal class AnswerConfig : IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> builder)
        {
            #region Relationships Configuration

            // Answer -> Question  (Cascade delete)
            builder.HasOne(a => a.Question)
                .WithMany(q => q.Answers)
                .HasForeignKey(a => a.QuestionId)
                .OnDelete(DeleteBehavior.Cascade);

            // Answer -> FormResponse (Cascade delete)
            builder.HasOne(a => a.Response)
                .WithMany(r => r.Answers)
                .HasForeignKey(r => r.ResponseId)
                .OnDelete(DeleteBehavior.Cascade);

            #endregion
        }
    }
}
