using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TouristAgency.Infrastructure.Data.Models.MssqlModels;

namespace TouristAgency.Infrastructure.Data.Configurations
{
    public class PassByDestinationConfiguration : IEntityTypeConfiguration<PassByDestination>
    {
        public void Configure(EntityTypeBuilder<PassByDestination> builder)
        {
            builder.HasData(new PassByDestination[]
            {
                new PassByDestination()
                {
                    Id = 1,
                    Name = "Атина (Пирея)",
                    CountryId = 2
                },
                new PassByDestination()
                {
                    Id = 2,
                    Name = "Солун",
                    CountryId = 2
                },
                new PassByDestination()
                {
                    Id = 3,
                    Name = "Кавала",
                    CountryId = 2
                },
                new PassByDestination()
                {
                    Id = 4,
                    Name = "Истанбул",
                    CountryId = 6
                },
                new PassByDestination()
                {
                    Id = 5,
                    Name = "Дикили",
                    CountryId = 6
                },
                new PassByDestination()
                {
                    Id = 6,
                    Name = "Кушадасъ",
                    CountryId = 6
                },
                new PassByDestination()
                {
                    Id = 7,
                    Name = "Патмос",
                    CountryId = 2
                },


                new PassByDestination()
                {
                    Id = 8,
                    Name = "Рим",
                    CountryId = 3
                },
                new PassByDestination()
                {
                    Id = 9,
                    Name = "Неапол",
                    CountryId = 3
                },
                new PassByDestination()
                {
                    Id = 10,
                    Name = "Палермо",
                    CountryId = 3
                },
                new PassByDestination()
                {
                    Id = 11,
                    Name = "Каляри",
                    CountryId = 3
                },
                new PassByDestination()
                {
                    Id = 12,
                    Name = "Тунис",
                    CountryId = 20
                },

                new PassByDestination()
                {
                    Id = 13,
                    Name = "Нант",
                    CountryId = 4
                },
                new PassByDestination()
                {
                    Id = 14,
                    Name = "Ла Рошел",
                    CountryId = 4
                },
                new PassByDestination()
                {
                    Id = 15,
                    Name = "Билбао",
                    CountryId = 5
                },
                new PassByDestination()
                {
                    Id = 16,
                    Name = "Порто",
                    CountryId = 7
                },
                new PassByDestination()
                {
                    Id = 17,
                    Name = "Лисабон",
                    CountryId = 7
                },
            });
        }
    }
}
