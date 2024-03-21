using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TouristAgency.Infrastructure.Data.Enumerations;
using TouristAgency.Infrastructure.Data.ValidationConstants;

namespace TouristAgency.Infrastructure.Data.Models.MssqlModels
{
    [Comment("This entity shows the whole information about a booking")]
    public class Booking
    {
        [Key]
        [Comment("Booking identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Identifier of the person who makes the booking")]
        public Guid BookerId { get; set; }

        [Required]
        [Comment("identifier of trip which shows details about the booking")]
        public int TripId { get; set; }

        [Required]
        [Comment("Exact time of booking the trip")]
        public DateTime TimeOfBooking { get; set; }

        [Required]
        [MaxLength(BookingConstants.DiscriminatorMaxLength)]
        [Comment("Discriminator column which will show what kind of trip has been booked(OrganizedHoliday, UnorganizedHoliday, Cruise)")]
        public string Discriminator { get; set; } = string.Empty;

        [Required]
        [Comment("Total price of the trip")]
        public decimal TotalPrice { get; set; }

        [Required]
        [Comment("Shows current status of the booking")]
        public BookingStatus BookingStatus { get; set; }

        [Required]
        [Comment("Payment identifier")]
        public int PaymentId { get; set; }

        [Required]
        [Comment("Shows if booking was payed or not")]
        public PaymentStatus PaymentStatus { get; set; }


        [ForeignKey(nameof(BookerId))]
        [Comment("Navigation property of BookerId")]
        public ApplicationUser ApplicationUser { get; set; } = null!;

        [Comment("Possible navigation property of TripId")]
        public UnorganizedHoliday? UnorganizedHoliday { get; set; }

        [Comment("Possible navigation property of TripId")]
        public BookedOrganizedHoliday? BookedOrganizedHoliday { get; set; }

        [Comment("Possible navigation property of TripId")]
        public BookedCruise? BookedCruise { get; set; }

        [Comment("Navigation property of PaymentId")]
        public Payment Payment { get; set; } = null!;

        [Comment("Navigation property showing how many more people are signed for the booking")]
        public ICollection<AdditionalPerson> AdditionalPeople { get; set; } = new List<AdditionalPerson>();
    }
}
