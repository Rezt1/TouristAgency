using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TouristAgency.Infrastructure.Data.Models;

namespace TouristAgency.Infrastructure.Data.Configurations
{
    public class CruiseRoomTypeBookedCruiseConfiguration : IEntityTypeConfiguration<CruiseRoomTypeBookedCruise>
    {
        public void Configure(EntityTypeBuilder<CruiseRoomTypeBookedCruise> builder)
        {
            builder.HasKey(pk => new { pk.CruiseRoomTypeId, pk.BookedCruiseId });
        }
    }
}
