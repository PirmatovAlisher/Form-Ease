using FormEase.Core.Models.WebApplication.CoreModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FormEase.Infrastructure.PostgreSQL.Configurations.WebApplication.CoreModels
{
    internal class FormResponseConfig : IEntityTypeConfiguration<FormResponse>
    {
        public void Configure(EntityTypeBuilder<FormResponse> builder)
        {
            #region Relationships Configuration

            // FormResponse->Template  (Cascade delete)
            builder.HasOne(fr => fr.Template)
                .WithMany(t => t.FormResponses)
                .HasForeignKey(t => t.TemplateId)
                .OnDelete(DeleteBehavior.Cascade);

            // FormResponse -> Respondent (Cascade delete)
            builder.HasOne(fr => fr.Respondent)
                .WithMany(u => u.FormResponses)
                .HasForeignKey(fr => fr.RespondentId)
                .OnDelete(DeleteBehavior.Cascade);

            // FormResponse -> Answers (Cascade delete)
            builder.HasMany(fr => fr.Answers)
                .WithOne(a => a.Response)
                .HasForeignKey(fr => fr.ResponseId)
                .OnDelete(DeleteBehavior.Cascade);

            #endregion
        }
    }
}
