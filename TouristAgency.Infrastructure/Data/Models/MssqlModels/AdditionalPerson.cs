using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TouristAgency.Infrastructure.Data.ValidationConstants;

namespace TouristAgency.Infrastructure.Data.Models.MssqlModels
{
    [Comment("This entity shows information about additional people signed for a booking")]
    public class AdditionalPerson
    {
        [Key]
        [Comment("AdditionalPerson identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(ApplicationUserConstants.FirstNameMaxLength)]
        [Comment("First name of additonal person")]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [MaxLength(ApplicationUserConstants.LastNameMaxLength)]
        [Comment("Last name of additonal person")]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [Comment("Booking identifier")]
        public int BookingId { get; set; }

        [ForeignKey(nameof(BookingId))]
        [Comment("Navigation property of BookingId")]
        public Booking Booking { get; set; } = null!;
    }
}
