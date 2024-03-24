﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using TouristAgency.Infrastructure.Data.ValidationConstants;

namespace TouristAgency.Infrastructure.Data.Models.MssqlModels
{
    [Comment("This entity shows the tour conducted in the given trip")]
    public class Tour
    {
        [Key]
        [Comment("Tour identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(TourConstants.NameMaxLength)]
        [Comment("Name of tour")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(TourConstants.DescriptionMaxLength)]
        [Comment("Description of tour")]
        public string Description { get; set; } = string.Empty;


        public OrganizedOffer OrganizedHoliday { get; set; } = null!;

        public ICollection<Activity> Activities { get; set; } = new List<Activity>();
    }
}