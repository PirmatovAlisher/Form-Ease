using FormEase.Core.Models.WebApplication.CoreModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FormEase.Infrastructure.PostgreSQL.Configurations.WebApplication.CoreModels
{
	public class SelectedOptionConfig : IEntityTypeConfiguration<SelectedOption>
	{
		public void Configure(EntityTypeBuilder<SelectedOption> builder)
		{
			builder.HasOne(so => so.Answer)
				.WithMany(a => a.SelectedOptions)
				.HasForeignKey(so => so.AnswerId)
				.OnDelete(DeleteBehavior.Cascade);

			builder.HasOne(so => so.Option)
				.WithMany()
				.HasForeignKey(so => so.OptionId)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
