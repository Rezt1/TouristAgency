using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TouristAgency.Infrastructure.Data.Models.MssqlModels;

namespace TouristAgency.Infrastructure.Data.Configurations
{
    public class OfferTransportTypePriceConfiguration : IEntityTypeConfiguration<OfferTransportTypePrice>
    {
        public void Configure(EntityTypeBuilder<OfferTransportTypePrice> builder)
        {
            builder.HasKey(pk => new { pk.OfferId, pk.TransportTypeId });
        }
    }
}
