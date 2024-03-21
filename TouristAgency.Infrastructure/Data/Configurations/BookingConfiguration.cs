using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TouristAgency.Infrastructure.Data.Models.MssqlModels;

namespace TouristAgency.Infrastructure.Data.Configurations
{
    public class BookingConfiguration : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder.HasDiscriminator(b => b.Discriminator)
                .HasValue(nameof(UnorganizedHoliday))
                .HasValue(nameof(BookedOrganizedHoliday))
                .HasValue(nameof(BookedCruise));
        }
    }
}
