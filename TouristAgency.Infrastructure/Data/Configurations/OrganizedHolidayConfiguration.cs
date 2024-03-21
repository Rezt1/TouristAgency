using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TouristAgency.Infrastructure.Data.Models.MssqlModels;

namespace TouristAgency.Infrastructure.Data.Configurations
{
    public class OrganizedHolidayConfiguration : IEntityTypeConfiguration<OrganizedHoliday>
    {
        public void Configure(EntityTypeBuilder<OrganizedHoliday> builder)
        {
            builder.HasOne(b => b.Offer)
                .WithOne(o => o.OrganizedHoliday)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
