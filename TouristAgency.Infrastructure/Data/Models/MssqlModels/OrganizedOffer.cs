﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TouristAgency.Infrastructure.Data.ValidationConstants;

namespace TouristAgency.Infrastructure.Data.Models.MssqlModels
{
    [Comment("This entity represents a trip which is organized by the agency")]
    public class OrganizedOffer
    {
        [Key]
        [Comment("OrganizedHoliday identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(OrganizedOfferConstants.NameMaxLength)]
        [Comment("Name of OrganizedHoliday")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Comment("Destination identifier")]
        public int DestinationId { get; set; }

        [Required]
        [Comment("TransportType identifier")]
        public int TransportTypeId { get; set; }

        [Required]
        [Comment("Hotel identifier")]
        public int HotelId { get; set; }

        [Required]
        [Comment("Price of OrganizedHoliday, it includes the hotel services price(excluding room price) and transport price. It does not include activities price")]
        public decimal Price { get; set; }

        [Comment("Discount of OrganizedHoliday which could not exist")]
        public float? Discount { get; set; }

        [Required]
        [Comment("Minumum people needed for the organized holiday to be made")]
        public int MinPeopleNeeded { get; set; }

        [Required]
        [Comment("Max people which can go to the organized holiday")]
        public int MaxPeople { get; set; }

        [Required]
        [Comment("Shows if the organized holiday is available or not")]
        public bool IsActive { get; set; }


        [ForeignKey(nameof(DestinationId))]
        public Destination Destination { get; set; } = null!;

        [ForeignKey(nameof(TransportTypeId))]
        public TransportType TransportType { get; set; } = null!;

        [ForeignKey(nameof(HotelId))]
        public Hotel Hotel { get; set; } = null!;

        public ICollection<OrganizedOfferDay>  OrganizedOfferDays { get; set; } = new List<OrganizedOfferDay>();    

        public ICollection<OrganizedOfferStartAndEndDate> OrganizedOfferStartAndEndDates { get; set; } = new List<OrganizedOfferStartAndEndDate>();
    }
}
