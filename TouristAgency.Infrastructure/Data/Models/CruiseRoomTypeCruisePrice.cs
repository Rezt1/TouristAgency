using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TouristAgency.Infrastructure.Data.Models
{
    [Comment("This table shows the price of room in a cruise")]
    public class CruiseRoomTypeCruisePrice
    {
        [Required]
        [Comment("Cruise identifier")]
        public int CruiseId { get; set; }

        [Required]
        [Comment("CruiseRoomTypeIdentifier")]
        public int CruiseRoomTypeId { get; set; }

        [Required]
        [Comment("Price of room per night")]
        public decimal PricePerNight { get; set; }


        [ForeignKey(nameof(CruiseId))]
        [Comment("Navigation property of CruiseId")]
        public Cruise Cruise { get; set; } = null!;

        [ForeignKey(nameof(CruiseRoomTypeId))]
        [Comment("Navigation property of CruiseRoomTypeId")]
        public CruiseRoomType CruiseRoomType { get; set; } = null!;
    }
}
