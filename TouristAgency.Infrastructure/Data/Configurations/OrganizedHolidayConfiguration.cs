using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TouristAgency.Infrastructure.Data.Models.MssqlModels;

namespace TouristAgency.Infrastructure.Data.Configurations
{
    public class OrganizedHolidayConfiguration : IEntityTypeConfiguration<OrganizedOffer>
    {
        public void Configure(EntityTypeBuilder<OrganizedOffer> builder)
        {
            builder.HasOne(b => b.Destination)
                .WithMany(d => d.OrganizedOffers)
                .HasForeignKey(b => b.DestinationId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
