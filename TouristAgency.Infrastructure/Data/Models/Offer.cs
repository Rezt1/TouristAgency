﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TouristAgency.Infrastructure.Data.ValidationConstants;

namespace TouristAgency.Infrastructure.Data.Models
{
    [Comment("This table shows what we offer for a given destination")]
    public class Offer
    {
        [Key]
        [Comment("Offer identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(OfferConstants.NameMaxLength)]
        [Comment("Name of offer")]
        public string Name { get; set; } = string.Empty;

        [Comment("Discount of offer available to only special users")]
        public float? Discount { get; set; }

        [Required]
        [Comment("Identifier of destination in which is the offer")]
        public int DestinationId { get; set; }

        [Required]
        [Comment("Checks if the offer can be booked customly by the user")]
        public bool CanBeUnorganized { get; set; }


        [ForeignKey(nameof(DestinationId))]
        [Comment("Destination property for destination identifier")]
        public Destination Destination { get; set; } = null!;

        [Comment("Navigation property for UnorganizedHoliday which could be null")]
        public UnorganizedHoliday? UnorganizedHoliday { get; set; }

        [Comment("Navigation property which leads to the price of transport for current offer")]
        public ICollection<OfferTransportTypePrice> OffersTransportTypesPrices { get; set; } = new List<OfferTransportTypePrice>();
    }
}