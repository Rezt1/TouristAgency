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

            base.OnModelCreating(builder);
        }
    }
}
