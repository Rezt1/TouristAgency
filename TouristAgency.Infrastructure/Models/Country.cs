using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TouristAgency.Infrastructure.ValidationConstants;

namespace TouristAgency.Infrastructure.Models
{
    [Comment("Countries that we make trips in")]
    public class Country
    {
        [Key]
        [Comment("Country identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(CountryConstants.NameMaxLength)]
        [Comment("Country name")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Comment("Continent identifier of country")]
        public int ContinentId { get; set; }

        [ForeignKey(nameof(ContinentId))]
        [Comment("Continent property for continent identifier")]
        public Continent Continent { get; set; } = null!;
    }
}
