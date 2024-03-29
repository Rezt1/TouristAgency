using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TouristAgency.Infrastructure.Data.Models.MssqlModels;

namespace TouristAgency.Infrastructure.Data.Configurations
{
    public class CruisePassByDestinationConfiguration : IEntityTypeConfiguration<CruisePassByDestination>
    {
        public void Configure(EntityTypeBuilder<CruisePassByDestination> builder)
        {
            builder.HasKey(pk => new { pk.CruiseId, pk.PassByDestinationId });

            Seed(builder);
        }

        private static void Seed(EntityTypeBuilder<CruisePassByDestination> builder)
        {
            builder.HasData(new CruisePassByDestination[]
            {
                new CruisePassByDestination()
                {
                    CruiseId = 1,
                    PassByDestinationId = 1,
                    PositionOfDestination = 1
                },
                new CruisePassByDestination()
                {
                    CruiseId = 1,
                    PassByDestinationId = 2,
                    PositionOfDestination = 2
                },
                new CruisePassByDestination()
                {
                    CruiseId = 1,
                    PassByDestinationId = 3,
                    PositionOfDestination = 3
                },
                new CruisePassByDestination()
                {
                    CruiseId = 1,
                    PassByDestinationId = 4,
                    PositionOfDestination = 4
                },
                new CruisePassByDestination()
                {
                    CruiseId = 1,
                    PassByDestinationId = 5,
                    PositionOfDestination = 5
                },
                new CruisePassByDestination()
                {
                    CruiseId = 1,
                    PassByDestinationId = 6,
                    PositionOfDestination = 6
                },
                new CruisePassByDestination()
                {
                    CruiseId = 1,
                    PassByDestinationId = 7,
                    PositionOfDestination = 7
                },

                new CruisePassByDestination()
                {
                    CruiseId = 2,
                    PassByDestinationId = 8,
                    PositionOfDestination = 1
                },
                new CruisePassByDestination()
                {
                    CruiseId = 2,
                    PassByDestinationId = 9,
                    PositionOfDestination = 2
                },
                new CruisePassByDestination()
                {
                    CruiseId = 2,
                    PassByDestinationId = 10,
                    PositionOfDestination = 3
                },
                new CruisePassByDestination()
                {
                    CruiseId = 2,
                    PassByDestinationId = 11,
                    PositionOfDestination = 4
                },
                new CruisePassByDestination()
                {
                    CruiseId = 2,
                    PassByDestinationId = 12,
                    PositionOfDestination = 5
                },

                new CruisePassByDestination()
                {
                    CruiseId = 3,
                    PassByDestinationId = 13,
                    PositionOfDestination = 1
                },
                new CruisePassByDestination()
                {
                    CruiseId = 3,
                    PassByDestinationId = 14,
                    PositionOfDestination = 2
                },
                new CruisePassByDestination()
                {
                    CruiseId = 3,
                    PassByDestinationId = 15,
                    PositionOfDestination = 3
                },
                new CruisePassByDestination()
                {
                    CruiseId = 3,
                    PassByDestinationId = 16,
                    PositionOfDestination = 4
                },
                new CruisePassByDestination()
                {
                    CruiseId = 3,
                    PassByDestinationId = 17,
                    PositionOfDestination = 5
                },
            });
        }
    }
}
