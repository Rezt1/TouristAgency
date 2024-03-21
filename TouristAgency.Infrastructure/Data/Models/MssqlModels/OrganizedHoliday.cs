using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TouristAgency.Infrastructure.Data.ValidationConstants;

namespace TouristAgency.Infrastructure.Data.Models.MssqlModels
{
    [Comment("This entity represents a trip which is organized by the agency")]
    public class OrganizedHoliday
    {
        [Key]
        [Comment("OrganizedHoliday identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Offer identifier")]
        public int OfferId { get; set; }

        [Required]
        [Comment("TransportType identifier")]
        public int TransportTypeId { get; set; }

        [Required]
        [Comment("Hotel identifier")]
        public int HotelId { get; set; }

        [Required]
        [Comment("Tour identifier")]
        public int TourId { get; set; }

        [Required]
        [Comment("Price of OrganizedHoliday, it includes the hotel services price(excluding room price) and transport price. It does not include activities price")]
        public decimal Price { get; set; }

        [Required]
        [Comment("Minumum people needed for the organized holiday to be made")]
        public int MinPeopleNeeded { get; set; }

        [Required]
        [Comment("Max people which can go to the organized holiday")]
        public int MaxPeople { get; set; }

        [Required]
        [MaxLength(OrganizedHolidayConstants.DayOneDescrpiptionMaxValue)]
        [Comment("Description of the first day of the trip")]
        public string DayOneDescription { get; set; } = string.Empty;

        [Required]
        [MaxLength(OrganizedHolidayConstants.LastDayDescriptionMaxValue)]
        [Comment("Description of the last day of the trip")]
        public string LastDayDescription { get; set; } = string.Empty;

        [Required]
        [Comment("Shows if the organized holiday is available or not")]
        public bool IsActive { get; set; }


        [ForeignKey(nameof(OfferId))]
        [Comment("Navigation property of OfferId")]
        public Offer Offer { get; set; } = null!;

        [ForeignKey(nameof(TransportTypeId))]
        [Comment("Navigation property of TransportTypeId")]
        public TransportType TransportType { get; set; } = null!;

        [ForeignKey(nameof(HotelId))]
        [Comment("Navigation property of HotelId")]
        public Hotel Hotel { get; set; } = null!;

        [ForeignKey(nameof(TourId))]
        [Comment("Navigation property of TourId")]
        public Tour Tour { get; set; } = null!;

        [Comment("Navigation property showing available dates for booking the trip")]
        public ICollection<OrganizedHolidayStartAndEndDate> OrganizedHolidayStartAndEndDates { get; set; } = new List<OrganizedHolidayStartAndEndDate>();
    }
}
