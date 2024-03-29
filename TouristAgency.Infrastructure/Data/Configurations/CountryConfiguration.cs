using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TouristAgency.Infrastructure.Data.Models.MssqlModels;

namespace TouristAgency.Infrastructure.Data.Configurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(new Country[]
            {
                new Country()
                {
                    Id = 1,
                    Name = "България",
                    ContinentId = 1
                },
                new Country()
                {
                    Id = 2,
                    Name = "Гърция",
                    ContinentId = 1
                },
                new Country()
                {
                    Id = 3,
                    Name = "Италия",
                    ContinentId = 1
                },
                new Country()
                {
                    Id = 4,
                    Name = "Франция",
                    ContinentId = 1
                },
                new Country()
                {
                    Id = 5,
                    Name = "Испания",
                    ContinentId = 1
                },
                new Country()
                {
                    Id = 6,
                    Name = "Турция",
                    ContinentId = 1
                },
                new Country()
                {
                    Id = 7,
                    Name = "Португалия",
                    ContinentId = 1
                },
                new Country()
                {
                    Id = 8,
                    Name = "Чехия",
                    ContinentId = 1
                },
                new Country()
                {
                    Id = 9,
                    Name = "Аржентина",
                    ContinentId = 2
                },
                new Country()
                {
                    Id = 10,
                    Name = "Куба",
                    ContinentId = 2
                },
                new Country()
                {
                    Id = 11,
                    Name = "Перу",
                    ContinentId = 2
                },
                new Country()
                {
                    Id = 12,
                    Name = "Бразилия",
                    ContinentId = 2
                },
                new Country()
                {
                    Id = 13,
                    Name = "Япония",
                    ContinentId = 3
                },
                new Country()
                {
                    Id = 14,
                    Name = "Шри Ланка",
                    ContinentId = 3
                },
                new Country()
                {
                    Id = 15,
                    Name = "Китай",
                    ContinentId = 3
                },
                new Country()
                {
                    Id = 16,
                    Name = "Сингапур",
                    ContinentId = 3
                },
                new Country()
                {
                    Id = 17,
                    Name = "Малдиви",
                    ContinentId = 3
                },
                new Country()
                {
                    Id = 18,
                    Name = "Египет",
                    ContinentId = 4
                },
                new Country()
                {
                    Id = 19,
                    Name = "Мароко",
                    ContinentId = 4
                },
                new Country()
                {
                    Id = 20,
                    Name = "Тунис",
                    ContinentId = 4
                },
            });    
        }
    }
}
