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
        [Comment("Offer identifier related to current unorganizedHoliday")]
        public int OfferId { get; set; }

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


        [ForeignKey(nameof(OfferId))]
        [Comment("Navigation property of OfferId")]
        public Offer Offer { get; set; } = null!;

        [ForeignKey(nameof(TransportTypeId))]
        [Comment("Navigation property of TransportTypeId")]
        public TransportType TransportType { get; set; } = null!;

        [ForeignKey(nameof(HotelId))]
        [Comment("Navigation property of HotelId")]
        public Hotel Hotel { get; set; } = null!;

        [Comment("Navigation property whcih shows how many rooms were booked for the current trip")]
        public ICollection<UnorganizedHolidayRoomType> UnorganizedHolidaysRoomTypes { get; set; } = new List<UnorganizedHolidayRoomType>();
    }
}
