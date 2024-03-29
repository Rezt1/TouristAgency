using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TouristAgency.Infrastructure.Data.Models.MssqlModels;

namespace TouristAgency.Infrastructure.Data.Configurations
{
    public class TransportTypeConfiguration : IEntityTypeConfiguration<TransportType>
    {
        public void Configure(EntityTypeBuilder<TransportType> builder)
        {
            builder.HasData(new TransportType[]
            {
                new TransportType()
                {
                    Id = 1,
                    Name = "Самолет"
                },
                new TransportType()
                {
                    Id = 2,
                    Name = "Автобус"
                },
                new TransportType()
                {
                    Id = 3,
                    Name = "Собствен"
                }
            });
        }
    }
}
