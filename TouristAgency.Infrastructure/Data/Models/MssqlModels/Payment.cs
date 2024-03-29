using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TouristAgency.Infrastructure.Data.Enumerations;

namespace TouristAgency.Infrastructure.Data.Models.MssqlModels
{
    [Comment("This entity shows payment details")]
    public class Payment
    {
        [Key]
        [Comment("Payment identifier")]
        public int Id { get; set; }

        [Comment("Paid amount")]
        public decimal? Amount { get; set; }

        [Comment("Date of payment")]
        public DateTime? PaymentDate { get; set; }

        [Required]
        [Comment("Method of paying(cash or debit card)")]
        public PaymentMethod PaymentMethod { get; set; }

        [Required]
        [Comment("Booking identifier")]
        public int BookingId { get; set; }


        [ForeignKey(nameof(BookingId))]
        public Booking Booking { get; set; } = null!;
    }
}
