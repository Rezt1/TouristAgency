using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TouristAgency.Infrastructure.Data.Models.MssqlModels
{
    [Comment("This entity shows how many rooms were booked for a give cruise")]
    public class CruiseRoomTypeBookedCruise
    {
        [Required]
        [Comment("CruiseRoomType identifier")]
        public int CruiseRoomTypeId { get; set; }

        [Required]
        [Comment("BookedCruise identifier")]
        public int BookedCruiseId { get; set; }

        [Required]
        [Comment("Number of booked rooms of current room type")]
        public int Number { get; set; }


        [ForeignKey(nameof(CruiseRoomTypeId))]
        public CruiseRoomType CruiseRoomType { get; set; } = null!;

        [ForeignKey(nameof(BookedCruiseId))]
        public BookedCruise BookedCruise { get; set; } = null!;
    }
}
