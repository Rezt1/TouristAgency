using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TouristAgency.Infrastructure.Data.ValidationConstants;

namespace TouristAgency.Infrastructure.Data.Models.MssqlModels
{
    [Comment("Entity showing what a day in an organized trip would look like")]
    public class OrganizedOfferDay
    {
        [Key]
        [Comment("OrganizedOffer identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Number of day")]
        public int DayNumber { get; set; }

        [Required]
        [MaxLength(OrganizedOfferDayConstants.DescriptionMaxLength)]
        [Comment("Description of day")]
        public string Description { get; set; } = string.Empty;

        [Comment("Activity identifier")]
        public int? ActivityId { get; set; }

        [Required]
        [Comment("OrganizedOffer identifier")]
        public int OrganizedOfferId { get; set; }


        [ForeignKey(nameof(ActivityId))]
        public Activity? Activity { get; set; }

        [ForeignKey(nameof(OrganizedOfferId))]
        public OrganizedOffer OrganizedOffer { get; set; } = null!;
    }
}
