using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TouristAgency.Infrastructure.Data.Models.MssqlModels;

namespace TouristAgency.Infrastructure.Data.Configurations
{
    public class OfferTransportTypePriceConfiguration : IEntityTypeConfiguration<UnorganizedOfferTransportTypePrice>
    {
        public void Configure(EntityTypeBuilder<UnorganizedOfferTransportTypePrice> builder)
        {
            builder.HasKey(pk => new { pk.UnorganizedOfferId, pk.TransportTypeId });
        }
    }
}
