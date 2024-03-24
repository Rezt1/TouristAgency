using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using TouristAgency.Infrastructure.Data.ValidationConstants;

namespace TouristAgency.Infrastructure.Data.Models.MssqlModels
{
    [Comment("Table about continents we make trips in")]
    public class Continent
    {
        [Key]
        [Comment("Continent table identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(ContinentConstants.NameMaxLength)]
        [Comment("Continent name")]
        public string Name { get; set; } = string.Empty;


        public ICollection<Country> Countries { get; set; } = new List<Country>();
    }
}
