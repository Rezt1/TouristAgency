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

            builder.HasOne(b => b.Activity)
                .WithMany(a => a.ActivitiesBookedOrganizedHolidays)
                .HasForeignKey(b => b.ActivityId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(b => b.BookedOrganizedHoliday)
                .WithMany(boh => boh.ActivitiesBookedOrganizedHolidays)
                .HasForeignKey(b => b.BookedOrganizedHolidayId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
