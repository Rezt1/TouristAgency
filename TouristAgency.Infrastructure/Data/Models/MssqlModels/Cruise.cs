using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace TouristAgency.Infrastructure.Data.Models.MssqlModels
{
    [Comment("This table shows cruises the agency has to offer")]
    public class Cruise
    {
        [Key]
        [Comment("Cruise identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength()]
        [Comment("Name of cruise")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength()]
        [Comment("Description of cruise")]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Comment("Date on which the cruise embarks")]
        public DateTime EmbarkDate { get; set; }

        [Required]
        [Comment("Date on whic the cruise returns")]
        public DateTime ReturnDate { get; set; }

        [Required]
        [Comment("Price of services in cruiuse excluding room price")]
        public decimal Price { get; set; }

        [Required]
        [Comment("Minumum people needed for the agency to make this trip happen")]
        public int MinPeopleNeeded { get; set; }

        [Required]
        [Comment("Maximum people which the agency can take")]
        public int MaxPeople { get; set; }

        [Required]
        [Comment("Shows if the cruise is available")]
        public bool IsActive { get; set; }


        public ICollection<CruiseRoomTypeCruisePrice> CruiseRoomTypesCruisesPrices { get; set; } = new List<CruiseRoomTypeCruisePrice>();

        public ICollection<CruisePassByDestination> CruisesDestinations { get; set; } = new List<CruisePassByDestination>();

        public ICollection<CruiseDay> CruiseDays { get; set; } = new List<CruiseDay>();

        public ICollection<BookedCruise> BookedCruises { get; set; } = new List<BookedCruise>();

        public ICollection<Review> Reviews { get; set; } = new List<Review>();
    }
}
