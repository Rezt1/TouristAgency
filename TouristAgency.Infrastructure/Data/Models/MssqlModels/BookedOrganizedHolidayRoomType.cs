using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TouristAgency.Infrastructure.Data.Models.MssqlModels
{
    [Comment("This entity shows how many rooms were booked for a trip")]
    public class BookedOrganizedHolidayRoomType
    {
        [Required]
        [Comment("BookedOrganizedHoliday identifier")]
        public int BookedOrganizedHolidayId { get; set; }

        [Required]
        [Comment("RoopType identifier")]
        public int RoomTypeId { get; set; }


        [ForeignKey(nameof(BookedOrganizedHolidayId))]
        [Comment("Navigation property for BookedOrganizedHolidayId")]
        public BookedOrganizedHoliday BookedOrganizedHoliday { get; set; } = null!;

        [ForeignKey(nameof(RoomTypeId))]
        [Comment("Navigation property for RoomTypeId")]
        public RoomType RoomType { get; set; } = null!;
    }
}
