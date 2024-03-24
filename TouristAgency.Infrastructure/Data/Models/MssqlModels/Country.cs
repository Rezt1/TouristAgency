using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TouristAgency.Infrastructure.Data.ValidationConstants;

namespace TouristAgency.Infrastructure.Data.Models.MssqlModels
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
        public Continent Continent { get; set; } = null!;

        public ICollection<Destination> Destinations { get; set; } = new List<Destination>();
    }
}
