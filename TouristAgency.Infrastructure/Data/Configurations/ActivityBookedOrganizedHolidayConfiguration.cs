using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TouristAgency.Infrastructure.Data.Models.MssqlModels;

namespace TouristAgency.Infrastructure.Data.Configurations
{
    public class ActivityBookedOrganizedHolidayConfiguration : IEntityTypeConfiguration<ActivityBookedOrganizedHoliday>
    {
        public void Configure(EntityTypeBuilder<ActivityBookedOrganizedHoliday> builder)
        {
            builder.HasKey(pk => new { pk.ActivityId, pk.BookedOrganizedHolidayId });
        }
    }
}
