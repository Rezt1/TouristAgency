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


        [Comment("Navigation property which leads to the price of a room in the cruise")]
        public ICollection<CruiseRoomTypeCruisePrice> CruiseRoomTypesCruisesPrices { get; set; } = new List<CruiseRoomTypeCruisePrice>();

        [Comment("Navigation property which leads to the destinations through which the cruise passes by")]
        public ICollection<CruiseDestination> CruisesDestinations { get; set; } = new List<CruiseDestination>();

        [Comment("Navigation property which shows description of all days in the cruise")]
        public ICollection<CruiseDay> CruiseDays { get; set; } = new List<CruiseDay>();

        [Comment("Navigation property which shows how many times the cruise was booked and with how many rooms")]
        public ICollection<BookedCruise> BookedCruises { get; set; } = new List<BookedCruise>();

        [Comment("Navigation property which shows review about the current cruise")]
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
    }
}
