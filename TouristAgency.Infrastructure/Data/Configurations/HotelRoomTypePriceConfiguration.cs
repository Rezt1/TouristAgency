using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TouristAgency.Infrastructure.Data.Models.MssqlModels;

namespace TouristAgency.Infrastructure.Data.Configurations
{
    public class HotelRoomTypePriceConfiguration : IEntityTypeConfiguration<HotelRoomTypePrice>
    {
        public void Configure(EntityTypeBuilder<HotelRoomTypePrice> builder)
        {
            builder.HasKey(pk => new { pk.HotelId, pk.RoomTypeId });
        }
    }
}
