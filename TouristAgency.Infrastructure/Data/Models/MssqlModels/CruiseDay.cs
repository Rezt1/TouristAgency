using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TouristAgency.Infrastructure.Data.ValidationConstants;

namespace TouristAgency.Infrastructure.Data.Models.MssqlModels
{
    [Comment("This entity shows the description of a single day in a cruise vacation")]
    public class CruiseDay
    {
        [Key]
        [Comment("CruiseDay identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Number of day")]
        public int DayNumber { get; set; }

        [Required]
        [MaxLength(CruiseDayConstants.DescriptionMaxLength)]
        [Comment("Description of current day")]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Comment("Cruise identifier")]
        public int CruiseId { get; set; }


        [ForeignKey(nameof(CruiseId))]
        public Cruise Cruise { get; set; } = null!;
    }
}
