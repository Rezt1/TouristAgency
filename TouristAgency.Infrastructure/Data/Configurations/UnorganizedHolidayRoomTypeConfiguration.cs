using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TouristAgency.Infrastructure.Data.Models;

namespace TouristAgency.Infrastructure.Data.Configurations
{
    public class UnorganizedHolidayRoomTypeConfiguration : IEntityTypeConfiguration<UnorganizedHolidayRoomType>
    {
        public void Configure(EntityTypeBuilder<UnorganizedHolidayRoomType> builder)
        {
            builder.HasKey(pk => new { pk.UnorganizedHolidayId, pk.RoomTypeId });
        }
    }
}
