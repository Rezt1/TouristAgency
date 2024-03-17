using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TouristAgency.Infrastructure.Data.Models
{
    [Comment("This table shows the destination through which cruises pass by")]
    public class CruiseDestination
    {
        [Required]
        [Comment("Cruise identifier")]
        public int CruiseId { get; set; }

        [Required]
        [Comment("Destination identifier")]
        public int DestinationId { get; set; }


        [ForeignKey(nameof(CruiseId))]
        [Comment("Navigation property of CruiseId")]
        public Cruise Cruise { get; set; } = null!;

        [ForeignKey(nameof(DestinationId))]
        [Comment("Navigation property of DestinationId")]
        public Destination Destination { get; set; } = null!;
    }
}
