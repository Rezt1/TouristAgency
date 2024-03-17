using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TouristAgency.Infrastructure.Data.Models;

namespace TouristAgency.Infrastructure.Data.Configurations
{
    public class CruiseDestinationConfiguration : IEntityTypeConfiguration<CruiseDestination>
    {
        public void Configure(EntityTypeBuilder<CruiseDestination> builder)
        {
            builder.HasKey(pk => new { pk.CruiseId, pk.DestinationId });
        }
    }
}
