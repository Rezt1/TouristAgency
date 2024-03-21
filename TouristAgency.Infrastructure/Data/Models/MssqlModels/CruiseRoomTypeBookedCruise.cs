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


        [ForeignKey(nameof(CruiseRoomTypeId))]
        [Comment("Navigation property of CruiseRoomTypeId")]
        public CruiseRoomType CruiseRoomType { get; set; } = null!;

        [ForeignKey(nameof(BookedCruiseId))]
        [Comment("Navigation property of BookedCruiseId")]
        public BookedCruise BookedCruise { get; set; } = null!;
    }
}
