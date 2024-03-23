using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TouristAgency.Infrastructure.Data.Models.MongoDbModels;
using TouristAgency.Infrastructure.Data.ValidationConstants;

namespace TouristAgency.Infrastructure.Data.Models.MssqlModels
{
    [Comment("Review written by an user about a trip")]
    public class Review
    {
        [Key]
        [Comment("Review identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(ReviewConstants.TitleMaxLength)]
        [Comment("Title of review")]
        public string Title { get; set; } = string.Empty;

        [Required]
        [MaxLength(ReviewConstants.ContentMaxLength)]
        [Comment("Content of review")]
        public string Content { get; set; } = string.Empty;

        [Required]
        [Comment("Date of writing the review")]
        public DateTime DateOfWriting { get; set; }

        [Required]
        [Comment("Identifier of user who wrote the review(could be anonymous)")]
        public Guid? ReviewerId { get; set; }

        [Required]
        [Comment("Identifier of trip which was reviewed")]
        public int ReviewedTripId { get; set; }

        [Required]
        [MaxLength(BookingConstants.DiscriminatorMaxLength)]
        [Comment("Discriminator which will signalize which navigation property should be filled")]
        public string Discriminator { get; set; } = string.Empty;

        
        [ForeignKey(nameof(ReviewerId))]
        [Comment("Navigation property of ReviewerId")]
        public ApplicationUser? ApplicationUser { get; set; }

        [Comment("Possible navigation property of ReviewedTripId")]
        public Offer? Offer { get; set; }

        [Comment("Possible navigation property of ReviewedTripId")]
        public Cruise? Cruise { get; set; }
    }
}