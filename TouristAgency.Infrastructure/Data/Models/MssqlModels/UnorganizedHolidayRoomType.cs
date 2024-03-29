using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TouristAgency.Infrastructure.Data.Models.MssqlModels
{
    [Comment("This entity shows how many rooms were booked for a certain trip")]
    public class UnorganizedHolidayRoomType
    {
        [Required]
        [Comment("UnorganizedHoliday identifier")]
        public int UnorganizedHolidayId { get; set; }

        [Required]
        [Comment("RoopType identifier")]
        public int RoomTypeId { get; set; }

        [Required]
        [Comment("Number of booked rooms of current room type")]
        public int Number { get; set; }


        [ForeignKey(nameof(UnorganizedHolidayId))]
        public UnorganizedHoliday UnorganizedHoliday { get; set; } = null!;

        [ForeignKey(nameof(RoomTypeId))]
        public RoomType RoomType { get; set; } = null!;
    }
}
