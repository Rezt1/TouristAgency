using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TouristAgency.Infrastructure.Data.Configurations.SampleData;

namespace TouristAgency.Infrastructure.Data.Configurations
{
    public class AspNetUserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<Guid>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<Guid>> builder)
        {
            IdentitySampleData sampleData = new IdentitySampleData();

            builder.HasData(new IdentityUserRole<Guid>[]
            {
                new IdentityUserRole<Guid>()
                {
                    UserId = sampleData.Administrator.Id,
                    RoleId = sampleData.AdministratorRole.Id
                }
            });
        }
    }
}
