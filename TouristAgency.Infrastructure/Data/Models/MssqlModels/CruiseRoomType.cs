using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using TouristAgency.Infrastructure.Data.ValidationConstants;

namespace TouristAgency.Infrastructure.Data.Models.MssqlModels
{
    [Comment("This table shows what kind of rooms there are in a cruise")]
    public class CruiseRoomType
    {
        [Key]
        [Comment("CruiseRoomType identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(CruiseRoomTypeConstants.NameMaxLength)]
        [Comment("Name of room type in cruise")]
        public string Name { get; set; } = string.Empty;


        [Comment("Navigation property which leads to the price of a room in a given cruise")]
        public ICollection<CruiseRoomTypeCruisePrice> CruiseRoomTypesCruisesPrices { get; set; } = new List<CruiseRoomTypeCruisePrice>();

        [Comment("Navigation property which shows how much the current room type is booked")]
        public ICollection<CruiseRoomTypeBookedCruise> CruiseRoomTypesBookedCruises { get; set; } = new List<CruiseRoomTypeBookedCruise>();
    }
}
