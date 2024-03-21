using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TouristAgency.Infrastructure.Data.Models.MssqlModels
{
    [Comment("This entity shows the booked cruise with the number of booked rooms")]
    public class BookedCruise
    {
        [Key]
        [Comment("BookedCruise identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Cruise identifier")]
        public int CruiseId { get; set; }


        [ForeignKey(nameof(CruiseId))]
        [Comment("Navigation property of CruiseId")]
        public Cruise Cruise { get; set; } = null!;


        [Comment("Navigation property which shows how many rooms were booked for the current cruise")]
        public ICollection<CruiseRoomTypeBookedCruise> CruiseRoomTypesBookedCruises { get; set; } = new List<CruiseRoomTypeBookedCruise>();
    }
}
