using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TouristAgency.Infrastructure.Data.Models.MssqlModels;

namespace TouristAgency.Infrastructure.Data.Configurations
{
    public class ContinentConfiguration : IEntityTypeConfiguration<Continent>
    {
        public void Configure(EntityTypeBuilder<Continent> builder)
        {
            builder.HasData(new Continent[]
            {
                new Continent()
                {
                    Id = 1,
                    Name = "Европа"
                },
                new Continent()
                {
                    Id = 2,
                    Name = "Южна Америка"
                },
                new Continent()
                {
                    Id = 3,
                    Name = "Азия"
                },
                new Continent()
                {
                    Id = 4,
                    Name = "Африка"
                }
            });
        }
    }
}
