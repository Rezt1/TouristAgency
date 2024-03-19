using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TouristAgency.Infrastructure.Data.Configurations;

namespace TouristAgency.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new OfferTransportTypePriceConfiguration());
            builder.ApplyConfiguration(new HotelRoomTypePriceConfiguration());
            builder.ApplyConfiguration(new CruiseRoomTypeCruisePriceConfiguration());
            builder.ApplyConfiguration(new CruiseDestinationConfiguration());
            builder.ApplyConfiguration(new ActivityBookedOrganizedHolidayConfiguration());
            builder.ApplyConfiguration(new BookedOrganizedHolidayRoomTypeConfiguration());
            builder.ApplyConfiguration(new UnorganizedHolidayRoomTypeConfiguration());
            builder.ApplyConfiguration(new CruiseRoomTypeBookedCruiseConfiguration());
            builder.ApplyConfiguration(new BookingConfiguration());
            builder.ApplyConfiguration(new ReviewConfiguration());

            base.OnModelCreating(builder);
        }
    }
}