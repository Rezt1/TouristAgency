using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TouristAgency.Infrastructure.Data.ValidationConstants;

namespace TouristAgency.Infrastructure.Data.Models.MssqlModels
{
    [Comment("This entity shows the activiy made in the tour")]
    public class Activity
    {
        [Key]
        [Comment("Activity identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(ActivityConstants.NameMaxLength)]
        [Comment("Name of activity")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(ActivityConstants.DescriptionMaxLength)]
        [Comment("Description of activity")]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Comment("Price of activity")]
        public decimal Price { get; set; }

        [Required]
        [Comment("Minumum amount of people needed for the activity to be made")]
        public int MinPeopleNeeded { get; set; }

        [Required]
        [Comment("Shows if the activity is currently available for the tour")]
        public bool IsAvailable { get; set; }

        [Required]
        [Comment("Tour identifier")]
        public int TourId { get; set; }


        [ForeignKey(nameof(TourId))]
        [Comment("Navigation property of TourId")]
        public Tour Tour { get; set; } = null!;

        [Comment("Navigation property which shows which activities were chosen for the given trip")]
        public ICollection<ActivityBookedOrganizedHoliday> ActivitiesBookedOrganizedHolidays { get; set; } = new List<ActivityBookedOrganizedHoliday>();
    }
}
