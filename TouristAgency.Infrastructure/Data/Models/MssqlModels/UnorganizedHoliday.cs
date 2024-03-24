using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TouristAgency.Infrastructure.Data.Models.MssqlModels
{
    [Comment("These are holidays which don't have tours organized by the agency and the user chooses where to stay, when to go and what to do")]
    public class UnorganizedHoliday
    {
        [Key]
        [Comment("UnorganizedHoliday identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("UnorganizedOffer identifier")]
        public int UnorganizedOfferId { get; set; }

        [Required]
        [Comment("Date of checking in the booked hotel")]
        public DateTime CheckInDate { get; set; }

        [Required]
        [Comment("Date of checking out the booked hotel")]
        public DateTime CheckOutDate { get; set; }

        [Required]
        [Comment("TransportType identifier")]
        public int TransportTypeId { get; set; }

        [Required]
        [Comment("Hotel identifier for hotel in which the user(s) will be staying in")]
        public int HotelId { get; set; }



        [ForeignKey(nameof(UnorganizedOfferId))]
        public UnorganizedOffer UnorganizedOffer { get; set; } = null!;

        [ForeignKey(nameof(TransportTypeId))]
        public TransportType TransportType { get; set; } = null!;

        [ForeignKey(nameof(HotelId))]
        public Hotel Hotel { get; set; } = null!;

        public ICollection<UnorganizedHolidayRoomType> UnorganizedHolidaysRoomTypes { get; set; } = new List<UnorganizedHolidayRoomType>();
    }
}
