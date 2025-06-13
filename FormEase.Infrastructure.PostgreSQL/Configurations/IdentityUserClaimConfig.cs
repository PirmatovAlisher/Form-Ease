using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace FormEase.Infrastructure.PostgreSQL.Configurations
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
                }
                );
        }
    }
}
