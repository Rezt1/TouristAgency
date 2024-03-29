using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TouristAgency.Infrastructure.Data.Configurations.SampleData;
using TouristAgency.Infrastructure.Data.Models.MssqlModels;

namespace TouristAgency.Infrastructure.Data.Configurations
{
    public class AspNetRoleConfiguration : IEntityTypeConfiguration<ApplicationRole>
    {
        public void Configure(EntityTypeBuilder<ApplicationRole> builder)
        {
            IdentitySampleData sampleData = new IdentitySampleData();

            builder.HasData(new ApplicationRole[]
            {
                sampleData.AdministratorRole,
                sampleData.SpecialGuestRole
            });
        }
    }
}
