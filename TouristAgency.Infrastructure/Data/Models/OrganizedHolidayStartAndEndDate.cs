using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TouristAgency.Infrastructure.Data.Models
{
    [Comment("This entity contains the start and end date of an organizedHoliday")]
    public class OrganizedHolidayStartAndEndDate
    {
        [Key]
        [Comment("OrganizedHolidayStartAndEndDate identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("OrganizedHoliday identifier")]
        public int OrganizedHolidayId { get; set; }

        [Required]
        [Comment("Date of setting off for the trip")]
        public DateTime StartDate { get; set; }

        [Required]
        [Comment("Date of coming back from the trip")]
        public DateTime EndDate { get; set; }

        [ForeignKey(nameof(OrganizedHolidayId))]
        [Comment("Navigation property of OrganizedHolidayId")]
        public OrganizedHoliday OrganizedHoliday { get; set; } = null!;
    }
}
