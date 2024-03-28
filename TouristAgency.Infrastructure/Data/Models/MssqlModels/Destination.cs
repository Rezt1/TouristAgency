using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TouristAgency.Infrastructure.Data.ValidationConstants;

namespace TouristAgency.Infrastructure.Data.Models.MssqlModels
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
        public Country Country { get; set; } = null!;

        public UnorganizedOffer UnorganizedOffer { get; set; } = null!;

        public ICollection<CruisePassByDestination> CruisesDestinations { get; set; } = new List<CruisePassByDestination>();

        public ICollection<OrganizedOffer> OrganizedOffers { get; set; } = new List<OrganizedOffer>();
    }
}
