using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FormEase.Infrastructure.PostgreSQL.Configurations.Identity
{
    public class IdentityUserRoleConfig : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    UserId = Guid.Parse("BB49CE85-C5C9-41D9-9665-321D430B7E2E").ToString(),
                    RoleId = Guid.Parse("8815F0D6-DB8E-4606-8ACB-12844E7B796B").ToString(),
                },
                new IdentityUserRole<string>
                {
                    UserId = Guid.Parse("2ADE9CC9-9152-4209-AE22-F2E9E57B09A7").ToString(),
                    RoleId = Guid.Parse("D140EB54-ED6E-4FF2-9199-71FCBE722EF7").ToString(),
                },
                new IdentityUserRole<string>
                {
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000001").ToString(),
                    RoleId = Guid.Parse("D140EB54-ED6E-4FF2-9199-71FCBE722EF7").ToString(),
                },
                new IdentityUserRole<string>
                {
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000002").ToString(),
                    RoleId = Guid.Parse("D140EB54-ED6E-4FF2-9199-71FCBE722EF7").ToString(),
                },
                new IdentityUserRole<string>
                {
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000003").ToString(),
                    RoleId = Guid.Parse("D140EB54-ED6E-4FF2-9199-71FCBE722EF7").ToString(),
                }
                );
        }
    }
}
