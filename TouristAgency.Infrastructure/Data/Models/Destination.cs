using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TouristAgency.Infrastructure.Data.ValidationConstants;

namespace TouristAgency.Infrastructure.Data.Models
{
    [Comment("This table shows the destinations in which we make trips")]
    public class Destination
    {
        [Key]
        [Comment("Destination identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(DestinationConstants.NameMaxLength)]
        [Comment("Name of destination")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(DestinationConstants.DescriptionMaxLength)]
        [Comment("Description of destination")]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Comment("Country identifier of destination")]
        public int CountryId { get; set; }


        [ForeignKey(nameof(CountryId))]
        [Comment("Country property for country identifier")]
        public Country Country { get; set; } = null!;

        [Required]
        [Comment("Offer property for what offer we have for the current destination")]
        public Offer Offer { get; set; } = null!;


        [Comment("Navigation property which leads to the cruises which pass by this destination")]
        public ICollection<CruiseDestination> CruisesDestinations { get; set; } = new List<CruiseDestination>();
    }
}
