using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TouristAgency.Infrastructure.Data.ValidationConstants;

namespace TouristAgency.Infrastructure.Data.Models.MssqlModels
{
    [Comment("This entity shows destinations through which cruises pass by")]
    public class PassByDestination
    {
        [Key]
        [Comment("PassByDestination identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(PassByDestinationConstants.NameMaxLength)]
        [Comment("Name of destination")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Comment("Country identifier")]
        public int CountryId { get; set; }


        [ForeignKey(nameof(CountryId))]
        public Country Country { get; set; } = null!;
    }
}
