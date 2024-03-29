using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TouristAgency.Infrastructure.Data.Models.MssqlModels;

namespace TouristAgency.Infrastructure.Data.Configurations
{
    public class CruiseRoomTypeConfiguration : IEntityTypeConfiguration<CruiseRoomType>
    {
        public void Configure(EntityTypeBuilder<CruiseRoomType> builder)
        {
            builder.HasData(new CruiseRoomType[]
            {
                new CruiseRoomType()
                {
                    Id = 1,
                    Name = "Вътрешнa каютa",
                    Description = "Най-малката по размер и квадратура, без прозорец и е разположена от вътрешната страна на кораба"
                },
                new CruiseRoomType()
                {
                    Id = 2,
                    Name = "Външна каюта",
                    Description = "Известна още като каюта с прозорец, е тази която представя изглед към външният свят чрез прозорец или илюминатор (кръгъл прозорец). Обикновено външната каюта е малко по-голяма от вътрешната като квадратура"
                },
                new CruiseRoomType()
                {
                    Id = 3,
                    Name = "Външна каюта",
                    Description = "Предоставя ви частна веранда, която ви позволява да излезете навън без да сте на обществена палуба"
                },
                new CruiseRoomType()
                {
                    Id = 4,
                    Name = "Апартамент",
                    Description = "Апартаментите са големи каюти с балкон, които са с отделна всекидневна и често допълнителни спални, понякога с две нива тип мезонет и предлагат повече пространство и  удобства. Също така придобивките към тях са: ол инлузив включени напитки, бакшиши към персонала, вип зони отделени само за гостите на апартаменти например: специален ресторант, лаундж бар, басейн и релакс открита частна палуба; консиерж за резервации по време на вашето пътуване; иконом 24 часа на разположение; приоритетно качване и слизане от кораба"
                },
            });
        }
    }
}
