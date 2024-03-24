using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TouristAgency.Infrastructure.Data.ValidationConstants;

namespace TouristAgency.Infrastructure.Data.Models.MssqlModels
{
    [Comment("This table shows what hotels the agency has to present for a given offer")]
    public class Hotel
    {
        [Key]
        [Comment("Hotel identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(HotelConstants.NameMaxLength)]
        [Comment("Name of Hotel")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(HotelConstants.LocationMaxLength)]
        [Comment("Shows exact location of the hotel")]
        public string Location { get; set; } = string.Empty;

        [Required]
        [Comment("Offer identifier, shows the current hotel for what offer is used")]
        public int UnorganizedOfferId { get; set; }


        [ForeignKey(nameof(UnorganizedOfferId))]
        public UnorganizedOffer UnorganizedOffer { get; set; } = null!;

        public OrganizedOffer? OrganizedHoliday { get; set; }

        public ICollection<HotelRoomTypePrice> HotelsRoomTypesPrices { get; set; } = new List<HotelRoomTypePrice>();
    }
}
