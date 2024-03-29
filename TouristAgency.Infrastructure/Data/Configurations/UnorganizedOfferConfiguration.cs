using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TouristAgency.Infrastructure.Data.Models.MssqlModels;

namespace TouristAgency.Infrastructure.Data.Configurations
{
    public class UnorganizedOfferConfiguration : IEntityTypeConfiguration<UnorganizedOffer>
    {
        public void Configure(EntityTypeBuilder<UnorganizedOffer> builder)
        {
            builder.HasData(new UnorganizedOffer[]
            {
                new UnorganizedOffer()
                {
                    Id = 1,
                    DestinationId = 1,
                    IsAvailable = true
                    
                },
                new UnorganizedOffer()
                {
                    Id = 2,
                    DestinationId = 2,
                    IsAvailable = true
                },
                new UnorganizedOffer()
                {
                    Id = 3,
                    DestinationId = 3,
                    IsAvailable = true
                },
                new UnorganizedOffer()
                {
                    Id = 4,
                    DestinationId = 4,
                    IsAvailable = true
                },
                new UnorganizedOffer()
                {
                    Id = 5,
                    DestinationId = 5,
                    IsAvailable = true
                },
                new UnorganizedOffer()
                {
                    Id = 6,
                    DestinationId = 6,
                    IsAvailable = true
                },
                new UnorganizedOffer()
                {
                    Id = 7,
                    DestinationId = 7,
                    IsAvailable = true
                },
                new UnorganizedOffer()
                {
                    Id = 8,
                    DestinationId = 8,
                    IsAvailable = true
                },
                new UnorganizedOffer()
                {
                    Id = 9,
                    DestinationId = 9,
                    IsAvailable = true
                },
                new UnorganizedOffer()
                {
                    Id = 10,
                    DestinationId = 10,
                    IsAvailable = true
                },
                new UnorganizedOffer()
                {
                    Id = 11,
                    DestinationId = 11,
                    IsAvailable = true
                },
                new UnorganizedOffer()
                {
                    Id = 12,
                    DestinationId = 12,
                    IsAvailable = true
                },
                new UnorganizedOffer()
                {
                    Id = 13,
                    DestinationId = 13,
                    IsAvailable = true
                },
                new UnorganizedOffer()
                {
                    Id = 14,
                    DestinationId = 14,
                    IsAvailable = true
                },
                new UnorganizedOffer()
                {
                    Id = 15,
                    DestinationId = 15,
                    IsAvailable = true
                },
                new UnorganizedOffer()
                {
                    Id = 16,
                    DestinationId = 16,
                    IsAvailable = true
                },
                new UnorganizedOffer()
                {
                    Id = 17,
                    DestinationId = 17,
                    IsAvailable = true
                },
                new UnorganizedOffer()
                {
                    Id = 18,
                    DestinationId = 18,
                    IsAvailable = true
                },
                new UnorganizedOffer()
                {
                    Id = 19,
                    DestinationId = 19,
                    IsAvailable = true
                },
                new UnorganizedOffer()
                {
                    Id = 20,
                    DestinationId = 20,
                    IsAvailable = true
                },
                new UnorganizedOffer()
                {
                    Id = 21,
                    DestinationId = 21,
                    IsAvailable = true
                },
                new UnorganizedOffer()
                {
                    Id = 22,
                    DestinationId = 22,
                    IsAvailable = true
                },
                new UnorganizedOffer()
                {
                    Id = 23,
                    DestinationId = 23,
                    IsAvailable = true
                },
                new UnorganizedOffer()
                {
                    Id = 24,
                    DestinationId = 24,
                    IsAvailable = true
                },
                new UnorganizedOffer()
                {
                    Id = 25,
                    DestinationId = 25,
                    IsAvailable = true
                },
                new UnorganizedOffer()
                {
                    Id = 26,
                    DestinationId = 26,
                    IsAvailable = true
                },
                new UnorganizedOffer()
                {
                    Id = 27,
                    DestinationId = 27,
                    IsAvailable = true
                },
                new UnorganizedOffer()
                {
                    Id = 28,
                    DestinationId = 28,
                    IsAvailable = true
                },
                new UnorganizedOffer()
                {
                    Id = 29,
                    DestinationId = 29,
                    IsAvailable = true
                },
                new UnorganizedOffer()
                {
                    Id = 30,
                    DestinationId = 30,
                    IsAvailable = true
                },
                new UnorganizedOffer()
                {
                    Id = 31,
                    DestinationId = 31,
                    IsAvailable = true
                },
                new UnorganizedOffer()
                {
                    Id = 32,
                    DestinationId = 32,
                    IsAvailable = true
                },
                new UnorganizedOffer()
                {
                    Id = 33,
                    DestinationId = 33,
                    IsAvailable = true
                },
                new UnorganizedOffer()
                {
                    Id = 34,
                    DestinationId = 34,
                    IsAvailable = true
                },
                new UnorganizedOffer()
                {
                    Id = 35,
                    DestinationId = 35,
                    IsAvailable = true
                }
            });
        }
    }
}
