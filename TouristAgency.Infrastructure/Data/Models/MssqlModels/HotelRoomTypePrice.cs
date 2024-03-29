using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TouristAgency.Infrastructure.Data.Models.MssqlModels
{
    [Comment("This table shows the price of a RoomType in a given hotel")]
    public class HotelRoomTypePrice
    {
        [Required]
        [Comment("Hotel identifier")]
        public int HotelId { get; set; }

        [Required]
        [Comment("RoomType identifier")]
        public int RoomTypeId { get; set; }

        [Required]
        [Comment("Price of a roomType in a given hotel")]
        public decimal PricePerNight { get; set; }


        [ForeignKey(nameof(HotelId))]
        public Hotel Hotel { get; set; } = null!;

        [ForeignKey(nameof(RoomTypeId))]
        public RoomType RoomType { get; set; } = null!;
    }
}
