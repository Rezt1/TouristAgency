using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using TouristAgency.Infrastructure.Data.ValidationConstants;

namespace TouristAgency.Infrastructure.Data.Models
{
    [Comment("This table shows what type of transport is availabe for a specific offer")]
    public class TransportType
    {
        [Key]
        [Comment("TransportType identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(TransportTypeConstants.NameMaxLength)]
        [Comment("Name of transport")]
        public string Name { get; set; } = string.Empty;


        [Comment("Contains UnorganizedHolidays which chose this kind of transport")]
        public ICollection<UnorganizedHoliday> UnorganizedHolidays { get; set; } = new List<UnorganizedHoliday>();

        [Comment("Navigation property which leads to the price of transport for given offer")]
        public ICollection<OfferTransportTypePrice> OffersTransportTypesPrices { get; set; } = new List<OfferTransportTypePrice>();
    }
}