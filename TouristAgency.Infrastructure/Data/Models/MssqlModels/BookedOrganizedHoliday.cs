using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TouristAgency.Infrastructure.Data.Models.MssqlModels
{
    [Comment("this entity shows the date, room type and signed activities for the trip")]
    public class BookedOrganizedHoliday
    {
        [Key]
        [Comment("BookedOrganizedHoliday identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("OrganizedHolidayStartAndEndDate identifier")]
        public int OrganizedHolidayStartAndEndDateId { get; set; }


        [ForeignKey(nameof(OrganizedHolidayStartAndEndDateId))]
        public OrganizedHolidayStartAndEndDate OrganizedHolidayStartAndEndDate { get; set; } = null!;

        public ICollection<BookedOrganizedHolidayRoomType> BookedOrganzedHolidaysRoomTypes { get; set; } = new List<BookedOrganizedHolidayRoomType>();

        public ICollection<ActivityBookedOrganizedHoliday> ActivitiesBookedOrganizedHolidays { get; set; } = new List<ActivityBookedOrganizedHoliday>();
    }
}