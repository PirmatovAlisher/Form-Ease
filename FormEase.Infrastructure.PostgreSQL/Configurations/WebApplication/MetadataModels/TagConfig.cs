using FormEase.Core.Models.WebApplication.MetadataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FormEase.Infrastructure.PostgreSQL.Configurations.WebApplication.MetadataModels
{
	internal class TagConfig : IEntityTypeConfiguration<Tag>
	{
		public void Configure(EntityTypeBuilder<Tag> builder)
		{
			// Index
			builder.HasIndex(t => t.Name)
				.IsUnique();


			var tags = new List<Tag>
	{
		new() { Id = Guid.Parse("00000000-0000-0000-0005-000000000001"), Name = "Mathematics" },
		new() { Id = Guid.Parse("00000000-0000-0000-0005-000000000002"), Name = "Algebra" },
		new() { Id = Guid.Parse("00000000-0000-0000-0005-000000000003"), Name = "HR" },
		new() { Id = Guid.Parse("00000000-0000-0000-0005-000000000004"), Name = "Workplace" },
		new() { Id = Guid.Parse("00000000-0000-0000-0005-000000000005"), Name = "Science" },
		new() { Id = Guid.Parse("00000000-0000-0000-0005-000000000006"), Name = "Physics" },
		new() { Id = Guid.Parse("00000000-0000-0000-0005-000000000007"), Name = "Chemistry" },
		new() { Id = Guid.Parse("00000000-0000-0000-0005-000000000008"), Name = "Biology" },
		new() { Id = Guid.Parse("00000000-0000-0000-0005-000000000009"), Name = "Technology" },
		new() { Id = Guid.Parse("00000000-0000-0000-0005-000000000010"), Name = "Programming" },
		new() { Id = Guid.Parse("00000000-0000-0000-0005-000000000011"), Name = "Web Development" },
		new() { Id = Guid.Parse("00000000-0000-0000-0005-000000000012"), Name = "Data Science" },
		new() { Id = Guid.Parse("00000000-0000-0000-0005-000000000013"), Name = "AI" },
		new() { Id = Guid.Parse("00000000-0000-0000-0005-000000000014"), Name = "Machine Learning" },
		new() { Id = Guid.Parse("00000000-0000-0000-0005-000000000015"), Name = "Business" },
		new() { Id = Guid.Parse("00000000-0000-0000-0005-000000000016"), Name = "Marketing" },
		new() { Id = Guid.Parse("00000000-0000-0000-0005-000000000017"), Name = "Finance" },
		new() { Id = Guid.Parse("00000000-0000-0000-0005-000000000018"), Name = "Startup" },
		new() { Id = Guid.Parse("00000000-0000-0000-0005-000000000019"), Name = "Education" },
		new() { Id = Guid.Parse("00000000-0000-0000-0005-000000000020"), Name = "E-Learning" },
		new() { Id = Guid.Parse("00000000-0000-0000-0005-000000000021"), Name = "History" },
		new() { Id = Guid.Parse("00000000-0000-0000-0005-000000000022"), Name = "Geography" },
		new() { Id = Guid.Parse("00000000-0000-0000-0005-000000000023"), Name = "Literature" },
		new() { Id = Guid.Parse("00000000-0000-0000-0005-000000000024"), Name = "Languages" },
		new() { Id = Guid.Parse("00000000-0000-0000-0005-000000000025"), Name = "English" },
		new() { Id = Guid.Parse("00000000-0000-0000-0005-000000000026"), Name = "Spanish" },
		new() { Id = Guid.Parse("00000000-0000-0000-0005-000000000027"), Name = "Health" },
		new() { Id = Guid.Parse("00000000-0000-0000-0005-000000000028"), Name = "Fitness" },
		new() { Id = Guid.Parse("00000000-0000-0000-0005-000000000029"), Name = "Nutrition" },
		new() { Id = Guid.Parse("00000000-0000-0000-0005-000000000030"), Name = "Mental Health" },
		new() { Id = Guid.Parse("00000000-0000-0000-0005-000000000031"), Name = "Art" },
		new() { Id = Guid.Parse("00000000-0000-0000-0005-000000000032"), Name = "Music" },
		new() { Id = Guid.Parse("00000000-0000-0000-0005-000000000033"), Name = "Photography" },
		new() { Id = Guid.Parse("00000000-0000-0000-0005-000000000034"), Name = "Design" },
		new() { Id = Guid.Parse("00000000-0000-0000-0005-000000000035"), Name = "UX/UI" },
		new() { Id = Guid.Parse("00000000-0000-0000-0005-000000000036"), Name = "Sports" },
		new() { Id = Guid.Parse("00000000-0000-0000-0005-000000000037"), Name = "Football" },
		new() { Id = Guid.Parse("00000000-0000-0000-0005-000000000038"), Name = "Basketball" },
		new() { Id = Guid.Parse("00000000-0000-0000-0005-000000000039"), Name = "Entertainment" },
		new() { Id = Guid.Parse("00000000-0000-0000-0005-000000000040"), Name = "Movies" },
		new() { Id = Guid.Parse("00000000-0000-0000-0005-000000000041"), Name = "Gaming" },
		new() { Id = Guid.Parse("00000000-0000-0000-0005-000000000042"), Name = "Social Media" },
		new() { Id = Guid.Parse("00000000-0000-0000-0005-000000000043"), Name = "Cooking" },
		new() { Id = Guid.Parse("00000000-0000-0000-0005-000000000044"), Name = "Travel" },
		new() { Id = Guid.Parse("00000000-0000-0000-0005-000000000045"), Name = "Sustainability" },
		new() { Id = Guid.Parse("00000000-0000-0000-0005-000000000046"), Name = "Environment" },
		new() { Id = Guid.Parse("00000000-0000-0000-0005-000000000047"), Name = "Politics" },
		new() { Id = Guid.Parse("00000000-0000-0000-0005-000000000048"), Name = "Society" },
		new() { Id = Guid.Parse("00000000-0000-0000-0005-000000000049"), Name = "Survey" },
		new() { Id = Guid.Parse("00000000-0000-0000-0005-000000000050"), Name = "Feedback" }
	};

			builder.HasData(tags);
		}
	}
}
