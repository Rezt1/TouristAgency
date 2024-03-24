using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TouristAgency.Infrastructure.Data.Models.MssqlModels
{
    [Comment("This table shows what we offer for a given destination")]
    public class UnorganizedOffer
    {
        [Key]
        [Comment("Offer identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Identifier of destination in which is the offer")]
        public int DestinationId { get; set; }

        [Required]
        [Comment("Checks if the offer is available for booking")]
        public bool IsAvailable { get; set; }


        [ForeignKey(nameof(DestinationId))]
        public Destination Destination { get; set; } = null!;

        public ICollection<UnorganizedHoliday> UnorganizedHolidays { get; set; } = new List<UnorganizedHoliday>();

        public ICollection<UnorganizedOfferTransportTypePrice> OffersTransportTypesPrices { get; set; } = new List<UnorganizedOfferTransportTypePrice>();

        public ICollection<Hotel> Hotels { get; set; } = new List<Hotel>();

        public ICollection<Review> Reviews { get; set; } = new List<Review>();
    }
}
