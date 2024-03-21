﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TouristAgency.Infrastructure.Data.Models.MssqlModels;

namespace TouristAgency.Infrastructure.Data.Configurations
{
    public class UnorganizedHolidayConfiguration : IEntityTypeConfiguration<UnorganizedHoliday>
    {
        public void Configure(EntityTypeBuilder<UnorganizedHoliday> builder)
        {
            builder.HasOne(b => b.Offer)
                .WithOne(o => o.UnorganizedHoliday)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
