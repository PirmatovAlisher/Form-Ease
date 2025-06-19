using FormEase.Core.Models.WebApplication.MetadataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FormEase.Infrastructure.PostgreSQL.Configurations.WebApplication.MetadataModels
{
    internal class TopicConfig : IEntityTypeConfiguration<Topic>
    {
        public void Configure(EntityTypeBuilder<Topic> builder)
        {
            // Index
            builder.HasIndex(t => t.Name)
                .IsUnique();

            // Seed Data for Default Topics
            builder.HasData(
                new Topic { Id = Guid.Parse("00000000-0000-0000-0001-000000000001"), Name = "Education" },
                new Topic { Id = Guid.Parse("00000000-0000-0000-0002-000000000002"), Name = "Quiz" },
                new Topic { Id = Guid.Parse("00000000-0000-0000-0003-000000000003"), Name = "Survey" },
                new Topic { Id = Guid.Parse("00000000-0000-0000-0004-000000000004"), Name = "Feedback" },
                new Topic { Id = Guid.Parse("00000000-0000-0000-0005-000000000005"), Name = "Other" }
            );
        }
    }
}
