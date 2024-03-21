using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TouristAgency.Infrastructure.Data.Models.MssqlModels;

namespace TouristAgency.Infrastructure.Data.Configurations
{
    public class CruiseRoomTypeCruisePriceConfiguration : IEntityTypeConfiguration<CruiseRoomTypeCruisePrice>
    {
        public void Configure(EntityTypeBuilder<CruiseRoomTypeCruisePrice> builder)
        {
            builder.HasKey(pk => new { pk.CruiseRoomTypeId, pk.CruiseId });
        }
    }
}
