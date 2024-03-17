using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TouristAgency.Infrastructure.Data.Models
{
    [Comment("This table shows the prices of different transports in different offers")]
    public class OfferTransportTypePrice
    {
        [Required]
        [Comment("Offer identifier")]
        public int OfferId { get; set; }

        [Required]
        [Comment("TransportType identifier")]
        public int TransportTypeId { get; set; }

        [Required]
        [Comment("Price of transport in given offer")]
        public decimal Price { get; set; }


        [ForeignKey(nameof(OfferId))]
        [Comment("Navigation property of OfferId")]
        public Offer Offer { get; set; } = null!;

        [ForeignKey(nameof(TransportTypeId))]
        [Comment("Navigation property of TransportTypeId")]
        public TransportType TransportType { get; set; } = null!;
    }
}
