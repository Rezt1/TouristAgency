using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TouristAgency.Infrastructure.Data.Models.MssqlModels
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
        public Cruise Cruise { get; set; } = null!;

        [ForeignKey(nameof(CruiseRoomTypeId))]
        public CruiseRoomType CruiseRoomType { get; set; } = null!;
    }
}
