using FormEase.Core.Models.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FormEase.Infrastructure.PostgreSQL.Configurations
{
    public class ApplicationUserConfig : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasData();

            var admin = new ApplicationUser
            {
                Id = Guid.Parse("BB49CE85-C5C9-41D9-9665-321D430B7E2E").ToString(),
                Email = "pirmatovalisher2000@gmail.com",
                NormalizedEmail = "PIRMATOVALISHER2000@GMAIL.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                UserName = "pirmatovalisher2000@gmail.com",
                NormalizedUserName = "PIRMATOVALISHER2000@GMAIL.COM",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                SecurityStamp = Guid.NewGuid().ToString(),
                IsBlocked = false,
                FirstName = "Alisher",
                LastName = "Pirmatov"
            };
            var adminPasswordHash = PasswordHash(admin, "Pirmatov_123");
            admin.PasswordHash = adminPasswordHash;
            builder.HasData(admin);

            var member = new ApplicationUser
            {
                Id = Guid.Parse("2ADE9CC9-9152-4209-AE22-F2E9E57B09A7").ToString(),
                Email = "pirmatovalisher@gmail.com",
                NormalizedEmail = "PIRMATOVALISHER@GMAIL.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                UserName = "pirmatovalisher@gmail.com",
                NormalizedUserName = "PIRMATOVALISHER@GMAIL.COM",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                SecurityStamp = Guid.NewGuid().ToString(),
                IsBlocked = false,
				FirstName = "Ali",
				LastName = "Pandya"
			};
            var memberPasswordHash = PasswordHash(member, "Pirmatov_123");
            member.PasswordHash = memberPasswordHash;
            builder.HasData(member);
        }

        private string PasswordHash(ApplicationUser user, string password)
        {
            var passwordHasher = new PasswordHasher<ApplicationUser>();
            return passwordHasher.HashPassword(user, password);
        }
    }
}
