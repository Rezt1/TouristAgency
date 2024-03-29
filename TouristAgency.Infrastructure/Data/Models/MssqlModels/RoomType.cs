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

        [Required]
        [MaxLength(RoomTypeConstants.DescriptionMaxLength)]
        [Comment("Description of RoomType")]
        public string Description { get; set; } = string.Empty;


        public ICollection<HotelRoomTypePrice> HotelsRoomTypesPrices { get; set; } = new List<HotelRoomTypePrice>();

        public ICollection<UnorganizedHoliday> UnorganizedHolidays { get; set; } = new List<UnorganizedHoliday>();

        public ICollection<BookedOrganizedHolidayRoomType> BookedOrganzedHolidaysRoomTypes { get; set; } = new List<BookedOrganizedHolidayRoomType>();

        public ICollection<UnorganizedHolidayRoomType> UnorganizedHolidaysRoomTypes { get; set; } = new List<UnorganizedHolidayRoomType>();
    }
}
