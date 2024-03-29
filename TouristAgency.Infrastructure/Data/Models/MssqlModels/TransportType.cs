using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using TouristAgency.Infrastructure.Data.ValidationConstants;

namespace TouristAgency.Infrastructure.Data.Models.MssqlModels
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


        public ICollection<UnorganizedHoliday> UnorganizedHolidays { get; set; } = new List<UnorganizedHoliday>();

        public ICollection<UnorganizedOfferTransportTypePrice> OffersTransportTypesPrices { get; set; } = new List<UnorganizedOfferTransportTypePrice>();
    }
}