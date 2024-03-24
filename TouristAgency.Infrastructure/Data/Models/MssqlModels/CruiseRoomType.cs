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

        [Required]
        [MaxLength(CruiseRoomTypeConstants.DescriptionMaxLength)]
        [Comment("Description of CruiseRoomType")]
        public string Description { get; set; } = string.Empty;


        public ICollection<CruiseRoomTypeCruisePrice> CruiseRoomTypesCruisesPrices { get; set; } = new List<CruiseRoomTypeCruisePrice>();

        public ICollection<CruiseRoomTypeBookedCruise> CruiseRoomTypesBookedCruises { get; set; } = new List<CruiseRoomTypeBookedCruise>();
    }
}
