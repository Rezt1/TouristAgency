using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TouristAgency.Infrastructure.Data.Models.MssqlModels
{
    [Comment("This table shows the prices of different transports in different offers")]
    public class UnorganizedOfferTransportTypePrice
    {
        [Required]
        [Comment("Offer identifier")]
        public int UnorganizedOfferId { get; set; }

        [Required]
        [Comment("TransportType identifier")]
        public int TransportTypeId { get; set; }

        [Required]
        [Comment("Price of transport in given offer")]
        public decimal Price { get; set; }


        [ForeignKey(nameof(UnorganizedOfferId))]
        public UnorganizedOffer UnorganizedOffer { get; set; } = null!;

        [ForeignKey(nameof(TransportTypeId))]
        public TransportType TransportType { get; set; } = null!;
    }
}
