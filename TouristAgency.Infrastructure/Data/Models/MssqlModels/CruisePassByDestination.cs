using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TouristAgency.Infrastructure.Data.Models.MssqlModels
{
    [Comment("This table shows the destination through which cruises pass by")]
    public class CruisePassByDestination
    {
        [Required]
        [Comment("Cruise identifier")]
        public int CruiseId { get; set; }

        [Required]
        [Comment("Destination identifier")]
        public int PassByDestinationId { get; set; }

        [Required]
        [Comment("Signifies turn of visiting this destination during the whole cruise")]
        public int PositionOfDestination { get; set; }

        [ForeignKey(nameof(CruiseId))]
        public Cruise Cruise { get; set; } = null!;

        [ForeignKey(nameof(PassByDestinationId))]
        public PassByDestination PassByDestination { get; set; } = null!;
    }
}
