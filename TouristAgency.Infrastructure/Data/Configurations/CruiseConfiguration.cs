using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TouristAgency.Infrastructure.Data.Models.MssqlModels;

namespace TouristAgency.Infrastructure.Data.Configurations
{
    public class CruiseConfiguration : IEntityTypeConfiguration<Cruise>
    {
        public void Configure(EntityTypeBuilder<Cruise> builder)
        {
            builder.HasData(new Cruise[]
            {
                new Cruise()
                {
                    Id = 1,
                    Name = "8-дневен круиз Steps of Paul",
                    Description = "Атина (Пирея) - Солун - Кавала - Истанбул - Дикили - Кушадасъ - Патмос - Атина (Пирея)",
                    EmbarkDate = new DateTime(2024, 10, 12),
                    ReturnDate = new DateTime(2024, 10, 19),
                    Price = 2240m,
                    MinPeopleNeeded = 30,
                    MaxPeople = 100,
                    IsActive = true
                },
                new Cruise()
                {
                    Id = 2,
                    Name = "7-дневен круиз Steps of Marcelo",
                    Description = "Рим - Неапол - Палермо - Каляри - Тунис - Рим",
                    EmbarkDate = new DateTime(2024, 9, 2),
                    ReturnDate = new DateTime(2024, 9, 8),
                    Price = 1820m,
                    MinPeopleNeeded = 25,
                    MaxPeople = 100,
                    IsActive = true
                },
                new Cruise()
                {
                    Id = 3,
                    Name = "8-дневен круиз Steps of Napoleon",
                    Description = "Нант - Ла Рошел - Билбао - Порто - Лисабон - Нант",
                    EmbarkDate = new DateTime(2024, 11, 9),
                    ReturnDate = new DateTime(2024, 11, 16),
                    Price = 2500m,
                    MinPeopleNeeded = 35,
                    MaxPeople = 100,
                    IsActive = true
                }
            });
        }
    }
}
