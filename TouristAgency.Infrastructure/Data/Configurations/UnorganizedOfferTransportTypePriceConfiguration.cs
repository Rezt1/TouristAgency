using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TouristAgency.Infrastructure.Data.Models.MssqlModels;

namespace TouristAgency.Infrastructure.Data.Configurations
{
    public class UnorganizedOfferTransportTypePriceConfiguration : IEntityTypeConfiguration<UnorganizedOfferTransportTypePrice>
    {
        public void Configure(EntityTypeBuilder<UnorganizedOfferTransportTypePrice> builder)
        {
            builder.HasKey(pk => new { pk.UnorganizedOfferId, pk.TransportTypeId });

            Seed(builder);
        }

        private static void Seed(EntityTypeBuilder<UnorganizedOfferTransportTypePrice> builder)
        {
            builder.HasData(new UnorganizedOfferTransportTypePrice[]
            {
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 1,
                    TransportTypeId = 2,
                    Price = 40m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 1,
                    TransportTypeId = 3,
                    Price = 0m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 2,
                    TransportTypeId = 1,
                    Price = 400m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 3,
                    TransportTypeId = 1,
                    Price = 450m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 3,
                    TransportTypeId = 2,
                    Price = 60m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 3,
                    TransportTypeId = 3,
                    Price = 0m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 4,
                    TransportTypeId = 1,
                    Price = 225m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 4,
                    TransportTypeId = 2,
                    Price = 80m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 4,
                    TransportTypeId = 3,
                    Price = 0m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 5,
                    TransportTypeId = 1,
                    Price = 500m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 5,
                    TransportTypeId = 2,
                    Price = 150m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 5,
                    TransportTypeId = 3,
                    Price = 0m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 6,
                    TransportTypeId = 1,
                    Price = 500m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 7,
                    TransportTypeId = 1,
                    Price = 525m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 8,
                    TransportTypeId = 1,
                    Price = 550m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 8,
                    TransportTypeId = 2,
                    Price = 210m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 8,
                    TransportTypeId = 3,
                    Price = 0m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 9,
                    TransportTypeId = 1,
                    Price = 600m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 9,
                    TransportTypeId = 2,
                    Price = 240m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 9,
                    TransportTypeId = 3,
                    Price = 0m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 10,
                    TransportTypeId = 1,
                    Price = 700m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 10,
                    TransportTypeId = 2,
                    Price = 280m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 10,
                    TransportTypeId = 3,
                    Price = 0m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 11,
                    TransportTypeId = 1,
                    Price = 650m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 11,
                    TransportTypeId = 2,
                    Price = 300m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 11,
                    TransportTypeId = 3,
                    Price = 0m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 12,
                    TransportTypeId = 1,
                    Price = 670m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 12,
                    TransportTypeId = 2,
                    Price = 310m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 12,
                    TransportTypeId = 3,
                    Price = 0m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 13,
                    TransportTypeId = 1,
                    Price = 680m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 13,
                    TransportTypeId = 2,
                    Price = 295m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 13,
                    TransportTypeId = 3,
                    Price = 0m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 14,
                    TransportTypeId = 1,
                    Price = 320m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 14,
                    TransportTypeId = 2,
                    Price = 110m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 14,
                    TransportTypeId = 3,
                    Price = 0m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 15,
                    TransportTypeId = 1,
                    Price = 250m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 15,
                    TransportTypeId = 2,
                    Price = 95m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 15,
                    TransportTypeId = 3,
                    Price = 0m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 16,
                    TransportTypeId = 1,
                    Price = 310m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 16,
                    TransportTypeId = 2,
                    Price = 105m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 16,
                    TransportTypeId = 3,
                    Price = 0m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 17,
                    TransportTypeId = 1,
                    Price = 240m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 17,
                    TransportTypeId = 2,
                    Price = 85m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 17,
                    TransportTypeId = 3,
                    Price = 0m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 18,
                    TransportTypeId = 1,
                    Price = 750m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 18,
                    TransportTypeId = 2,
                    Price = 310m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 18,
                    TransportTypeId = 3,
                    Price = 0m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 19,
                    TransportTypeId = 1,
                    Price = 200m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 19,
                    TransportTypeId = 2,
                    Price = 70m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 19,
                    TransportTypeId = 3,
                    Price = 0m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 20,
                    TransportTypeId = 1,
                    Price = 1400m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 21,
                    TransportTypeId = 1,
                    Price = 1320m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 22,
                    TransportTypeId = 1,
                    Price = 1350m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 23,
                    TransportTypeId = 1,
                    Price = 1380m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 24,
                    TransportTypeId = 1,
                    Price = 1500m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 25,
                    TransportTypeId = 1,
                    Price = 1490m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 26,
                    TransportTypeId = 1,
                    Price = 1200m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 27,
                    TransportTypeId = 1,
                    Price = 1440m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 28,
                    TransportTypeId = 1,
                    Price = 1400m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 29,
                    TransportTypeId = 1,
                    Price = 1300m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 30,
                    TransportTypeId = 1,
                    Price = 480m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 31,
                    TransportTypeId = 1,
                    Price = 490m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 32,
                    TransportTypeId = 1,
                    Price = 500m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 33,
                    TransportTypeId = 1,
                    Price = 880m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 34,
                    TransportTypeId = 1,
                    Price = 680m
                },
                new UnorganizedOfferTransportTypePrice()
                {
                    UnorganizedOfferId = 35,
                    TransportTypeId = 1,
                    Price = 650m
                },
            });
        }
    }
}
