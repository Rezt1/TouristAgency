using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TouristAgency.Infrastructure.ValidationConstants;

namespace TouristAgency.Infrastructure.Models
{
    [Comment("This table shows what we offer for a given destination")]
    public class Offer
    {
        [Key]
        [Comment("Offer identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(OfferConstants.NameMaxLength)]
        [Comment("Name of offer")]
        public string Name { get; set; } = string.Empty;

        [Comment("Discount of offer available to only special users")]
        public float? Discount { get; set; }

        [Required]
        [Comment("Identifier of destination in which is the offer")]
        public int DestinationId { get; set; }

        [ForeignKey(nameof(DestinationId))]
        [Comment("Destination property for destination identifier")]
        public Destination Destination { get; set; } = null!;
    }
}
