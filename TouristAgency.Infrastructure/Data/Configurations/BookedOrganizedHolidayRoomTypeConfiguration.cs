using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TouristAgency.Infrastructure.Data.Models;

namespace TouristAgency.Infrastructure.Data.Configurations
{
    public class BookedOrganizedHolidayRoomTypeConfiguration : IEntityTypeConfiguration<BookedOrganizedHolidayRoomType>
    {
        public void Configure(EntityTypeBuilder<BookedOrganizedHolidayRoomType> builder)
        {
            builder.HasKey(pk => new { pk.BookedOrganizedHolidayId, pk.RoomTypeId });
        }
    }
}
