using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using TouristAgency.Infrastructure.Data.ValidationConstants;

namespace TouristAgency.Infrastructure.Data.Models.MssqlModels
{
    [Comment("This table shows what kind of rooms the agency can offer")]
    public class RoomType
    {
        [Key]
        [Comment("RoomType identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(RoomTypeConstants.NameMaxLength)]
        [Comment("Name of RoomType")]
        public string Name { get; set; } = string.Empty;


        [Comment("Navigation property leading to the prices of rooms in given hotels")]
        public ICollection<HotelRoomTypePrice> HotelsRoomTypesPrices { get; set; } = new List<HotelRoomTypePrice>();

        [Comment("Navigation property leading to the unorganizedHolidays which booked this kind of room")]
        public ICollection<UnorganizedHoliday> UnorganizedHolidays { get; set; } = new List<UnorganizedHoliday>();

        [Comment("Navigation property which shows how much this room was booked")]
        public ICollection<BookedOrganizedHolidayRoomType> BookedOrganzedHolidaysRoomTypes { get; set; } = new List<BookedOrganizedHolidayRoomType>();

        [Comment("Navigation property whcih shows how much this room type was booked")]
        public ICollection<UnorganizedHolidayRoomType> UnorganizedHolidaysRoomTypes { get; set; } = new List<UnorganizedHolidayRoomType>();
    }
}
