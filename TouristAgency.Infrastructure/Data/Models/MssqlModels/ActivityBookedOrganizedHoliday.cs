using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TouristAgency.Infrastructure.Data.Models.MssqlModels
{
    [Comment("This entity gives info about what activities are booked for the trip")]
    public class ActivityBookedOrganizedHoliday
    {
        [Required]
        [Comment("Activity identifier")]
        public int ActivityId { get; set; }

        [Required]
        [Comment("BookedOrganizedHoliday identifier")]
        public int BookedOrganizedHolidayId { get; set; }


        [ForeignKey(nameof(ActivityId))]
        public Activity Activity { get; set; } = null!;

        [ForeignKey(nameof(BookedOrganizedHolidayId))]
        public BookedOrganizedHoliday BookedOrganizedHoliday { get; set; } = null!;
    }
}
