using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Security.Claims;

namespace FormEase.Infrastructure.PostgreSQL.Configurations.Identity
{
    public class IdentityUserClaimConfig : IEntityTypeConfiguration<IdentityUserClaim<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserClaim<string>> builder)
        {

            builder.HasData(
                new IdentityUserClaim<string>()
                {
                    Id = 1,
                    UserId = Guid.Parse("BB49CE85-C5C9-41D9-9665-321D430B7E2E").ToString(),
                    ClaimType = ClaimTypes.Role,
                    ClaimValue = "Admin"
                },
                new IdentityUserClaim<string>()
                {
                    Id = 2,
                    UserId = Guid.Parse("2ADE9CC9-9152-4209-AE22-F2E9E57B09A7").ToString(),
                    ClaimType = ClaimTypes.Role,
                    ClaimValue = "Member"
                },
                new IdentityUserClaim<string>()
                {
                    Id = 3,
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000001").ToString(),
                    ClaimType = ClaimTypes.Role,
                    ClaimValue = "Member"
                },
                new IdentityUserClaim<string>()
                {
                    Id = 4,
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000002").ToString(),
                    ClaimType = ClaimTypes.Role,
                    ClaimValue = "Member"
                },
                new IdentityUserClaim<string>()
                {
                    Id = 5,
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000003").ToString(),
                    ClaimType = ClaimTypes.Role,
                    ClaimValue = "Member"
                }
                );
        }
    }
}
