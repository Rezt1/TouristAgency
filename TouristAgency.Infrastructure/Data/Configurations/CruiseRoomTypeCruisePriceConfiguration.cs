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

            Seed(builder);
        }

        private static void Seed(EntityTypeBuilder<CruiseRoomTypeCruisePrice> builder)
        {
            builder.HasData(new CruiseRoomTypeCruisePrice[]
            {
                new CruiseRoomTypeCruisePrice()
                {
                    CruiseId = 1,
                    CruiseRoomTypeId = 1,
                    PricePerNight = 70.20m
                },
                new CruiseRoomTypeCruisePrice()
                {
                    CruiseId = 1,
                    CruiseRoomTypeId = 2,
                    PricePerNight = 79.10m
                },
                new CruiseRoomTypeCruisePrice()
                {
                    CruiseId = 1,
                    CruiseRoomTypeId = 3,
                    PricePerNight = 91.50m
                },
                new CruiseRoomTypeCruisePrice()
                {
                    CruiseId = 1,
                    CruiseRoomTypeId = 4,
                    PricePerNight = 118.90m
                },

                new CruiseRoomTypeCruisePrice()
                {
                    CruiseId = 2,
                    CruiseRoomTypeId = 1,
                    PricePerNight = 69.10m
                },
                new CruiseRoomTypeCruisePrice()
                {
                    CruiseId = 2,
                    CruiseRoomTypeId = 2,
                    PricePerNight = 75.90m
                },
                new CruiseRoomTypeCruisePrice()
                {
                    CruiseId = 2,
                    CruiseRoomTypeId = 3,
                    PricePerNight = 89.10m
                },
                new CruiseRoomTypeCruisePrice()
                {
                    CruiseId = 2,
                    CruiseRoomTypeId = 4,
                    PricePerNight = 116.40m
                },

                new CruiseRoomTypeCruisePrice()
                {
                    CruiseId = 3,
                    CruiseRoomTypeId = 1,
                    PricePerNight = 78.70m
                },
                new CruiseRoomTypeCruisePrice()
                {
                    CruiseId = 3,
                    CruiseRoomTypeId = 2,
                    PricePerNight = 88.80m
                },
                new CruiseRoomTypeCruisePrice()
                {
                    CruiseId = 3,
                    CruiseRoomTypeId = 3,
                    PricePerNight = 101.10m
                },
                new CruiseRoomTypeCruisePrice()
                {
                    CruiseId = 3,
                    CruiseRoomTypeId = 4,
                    PricePerNight = 129.20m
                }
            });
        }
    }
}
