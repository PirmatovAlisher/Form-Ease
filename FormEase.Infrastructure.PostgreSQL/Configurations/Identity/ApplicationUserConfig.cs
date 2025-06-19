using FormEase.Core.Models.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FormEase.Infrastructure.PostgreSQL.Configurations.Identity
{
    public class ApplicationUserConfig : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {

            builder.HasIndex(u => u.FirstName).IsUnique();

            #region Relationships

            builder.HasMany(u => u.CreatedTemplates)
                .WithOne(t => t.Creator)
                .HasForeignKey(t => t.CreatorId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(u => u.FormResponses)
                .WithOne(fr => fr.Respondent)
                .HasForeignKey(fr => fr.RespondentId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(u => u.AllowedTemplates)
                .WithOne(uta => uta.User)
                .HasForeignKey(uta => uta.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(u => u.Comments)
                .WithOne(c => c.Author)
                .HasForeignKey(c => c.AuthorId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(u => u.Likes)
                .WithOne(l => l.User)
                .HasForeignKey(l => l.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            #endregion


            #region Seed Data

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

            var siteAdmin = new ApplicationUser
            {
                Id = "00000000-0000-0000-0000-000000000001",
                UserName = "admin@example.com",
                NormalizedUserName = "ADMIN@EXAMPLE.COM",
                Email = "admin@example.com",
                NormalizedEmail = "ADMIN@EXAMPLE.COM",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Admin",
                LastName = "User",
                IsBlocked = false
            };
            var siteAdminPasswordHash = PasswordHash(siteAdmin, "Pirmatov_123");
            siteAdmin.PasswordHash = siteAdminPasswordHash;
            builder.HasData(siteAdmin);

            var creator = new ApplicationUser
            {
                Id = "00000000-0000-0000-0000-000000000002",
                UserName = "creator@example.com",
                NormalizedUserName = "CREATOR@EXAMPLE.COM",
                Email = "creator@example.com",
                NormalizedEmail = "CREATOR@EXAMPLE.COM",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "John",
                LastName = "Doe",
                IsBlocked = false
            };
            var creatorPasswordHash = PasswordHash(creator, "Pirmatov_123");
            creator.PasswordHash = creatorPasswordHash;
            builder.HasData(creator);

            var respondent = new ApplicationUser
            {
                Id = "00000000-0000-0000-0000-000000000003",
                UserName = "respondent@example.com",
                NormalizedUserName = "RESPONDENT@EXAMPLE.COM",
                Email = "respondent@example.com",
                NormalizedEmail = "RESPONDENT@EXAMPLE.COM",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Alice",
                LastName = "Johnson",
                IsBlocked = false
            };
            var respondentPasswordHash = PasswordHash(respondent, "Pirmatov_123");
            respondent.PasswordHash = respondentPasswordHash;
            builder.HasData(respondent);
            #endregion
        }

        private string PasswordHash(ApplicationUser user, string password)
        {
            var passwordHasher = new PasswordHasher<ApplicationUser>();
            return passwordHasher.HashPassword(user, password);
        }
    }
}
