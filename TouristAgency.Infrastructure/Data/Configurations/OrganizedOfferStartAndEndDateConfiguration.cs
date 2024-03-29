using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TouristAgency.Infrastructure.Data.Models.MssqlModels;

namespace TouristAgency.Infrastructure.Data.Configurations
{
    public class OrganizedOfferStartAndEndDateConfiguration : IEntityTypeConfiguration<OrganizedOfferStartAndEndDate>
    {
        public void Configure(EntityTypeBuilder<OrganizedOfferStartAndEndDate> builder)
        {
            builder.HasData(new OrganizedOfferStartAndEndDate[]
            {
                new OrganizedOfferStartAndEndDate()
                {
                    Id = 1,
                    OrganizedHolidayId = 1,
                    StartDate = new DateTime(2024, 5, 5),
                    EndDate = new DateTime(2024, 5, 9)
                },
                new OrganizedOfferStartAndEndDate()
                {
                    Id = 2,
                    OrganizedHolidayId = 1,
                    StartDate = new DateTime(2024, 5, 26),
                    EndDate = new DateTime(2024, 5, 30)
                },

                new OrganizedOfferStartAndEndDate()
                {
                    Id = 3,
                    OrganizedHolidayId = 2,
                    StartDate = new DateTime(2024, 5, 1),
                    EndDate = new DateTime(2024, 5, 8)
                },
                new OrganizedOfferStartAndEndDate()
                {
                    Id = 4,
                    OrganizedHolidayId = 2,
                    StartDate = new DateTime(2024, 6, 6),
                    EndDate = new DateTime(2024, 6, 13)
                },

                new OrganizedOfferStartAndEndDate()
                {
                    Id = 5,
                    OrganizedHolidayId = 3,
                    StartDate = new DateTime(2024, 5, 13),
                    EndDate = new DateTime(2024, 5, 17)
                },
                new OrganizedOfferStartAndEndDate()
                {
                    Id = 6,
                    OrganizedHolidayId = 3,
                    StartDate = new DateTime(2024, 7, 1),
                    EndDate = new DateTime(2024, 7, 5)
                },

                new OrganizedOfferStartAndEndDate()
                {
                    Id = 7,
                    OrganizedHolidayId = 4,
                    StartDate = new DateTime(2024, 4, 25),
                    EndDate = new DateTime(2024, 4, 30)
                },
                new OrganizedOfferStartAndEndDate()
                {
                    Id = 8,
                    OrganizedHolidayId = 4,
                    StartDate = new DateTime(2024, 6, 10),
                    EndDate = new DateTime(2024, 6, 15)
                },

                new OrganizedOfferStartAndEndDate()
                {
                    Id = 9,
                    OrganizedHolidayId = 5,
                    StartDate = new DateTime(2024, 4, 18),
                    EndDate = new DateTime(2024, 4, 22)
                },
                new OrganizedOfferStartAndEndDate()
                {
                    Id = 10,
                    OrganizedHolidayId = 5,
                    StartDate = new DateTime(2024, 5, 10),
                    EndDate = new DateTime(2024, 4, 14)
                },

                new OrganizedOfferStartAndEndDate()
                {
                    Id = 11,
                    OrganizedHolidayId = 6,
                    StartDate = new DateTime(2024, 6, 5),
                    EndDate = new DateTime(2024, 6, 12)
                },
                new OrganizedOfferStartAndEndDate()
                {
                    Id = 12,
                    OrganizedHolidayId = 6,
                    StartDate = new DateTime(2024, 7, 5),
                    EndDate = new DateTime(2024, 7, 12)
                },

                new OrganizedOfferStartAndEndDate()
                {
                    Id = 13,
                    OrganizedHolidayId = 7,
                    StartDate = new DateTime(2024, 5, 10),
                    EndDate = new DateTime(2024, 5, 17)
                },
                new OrganizedOfferStartAndEndDate()
                {
                    Id = 14,
                    OrganizedHolidayId = 7,
                    StartDate = new DateTime(2024, 6, 20),
                    EndDate = new DateTime(2024, 6, 27)
                },

                new OrganizedOfferStartAndEndDate()
                {
                    Id = 15,
                    OrganizedHolidayId = 8,
                    StartDate = new DateTime(2024, 4, 20),
                    EndDate = new DateTime(2024, 4, 23)
                },
                new OrganizedOfferStartAndEndDate()
                {
                    Id = 16,
                    OrganizedHolidayId = 8,
                    StartDate = new DateTime(2024, 5, 8),
                    EndDate = new DateTime(2024, 5, 11)
                },

                new OrganizedOfferStartAndEndDate()
                {
                    Id = 17,
                    OrganizedHolidayId = 9,
                    StartDate = new DateTime(2024, 5, 12),
                    EndDate = new DateTime(2024, 5, 15)
                },
                new OrganizedOfferStartAndEndDate()
                {
                    Id = 18,
                    OrganizedHolidayId = 9,
                    StartDate = new DateTime(2024, 6, 15),
                    EndDate = new DateTime(2024, 6, 18)
                },

                new OrganizedOfferStartAndEndDate()
                {
                    Id = 19,
                    OrganizedHolidayId = 10,
                    StartDate = new DateTime(2024, 4, 18),
                    EndDate = new DateTime(2024, 4, 21)
                },
                new OrganizedOfferStartAndEndDate()
                {
                    Id = 20,
                    OrganizedHolidayId = 10,
                    StartDate = new DateTime(2024, 6, 1),
                    EndDate = new DateTime(2024, 6, 4)
                },

                new OrganizedOfferStartAndEndDate()
                {
                    Id = 21,
                    OrganizedHolidayId = 11,
                    StartDate = new DateTime(2024, 6, 7),
                    EndDate = new DateTime(2024, 6, 14)
                },
                new OrganizedOfferStartAndEndDate()
                {
                    Id = 22,
                    OrganizedHolidayId = 11,
                    StartDate = new DateTime(2024, 7, 15),
                    EndDate = new DateTime(2024, 7, 22)
                },

                new OrganizedOfferStartAndEndDate()
                {
                    Id = 23,
                    OrganizedHolidayId = 12,
                    StartDate = new DateTime(2024, 6, 1),
                    EndDate = new DateTime(2024, 6, 8)
                },
                new OrganizedOfferStartAndEndDate()
                {
                    Id = 24,
                    OrganizedHolidayId = 12,
                    StartDate = new DateTime(2024, 7, 12),
                    EndDate = new DateTime(2024, 7, 19)
                },

                new OrganizedOfferStartAndEndDate()
                {
                    Id = 25,
                    OrganizedHolidayId = 13,
                    StartDate = new DateTime(2024, 6, 4),
                    EndDate = new DateTime(2024, 6, 11)
                },
                new OrganizedOfferStartAndEndDate()
                {
                    Id = 26,
                    OrganizedHolidayId = 13,
                    StartDate = new DateTime(2024, 8, 1),
                    EndDate = new DateTime(2024, 8, 8)
                },

                new OrganizedOfferStartAndEndDate()
                {
                    Id = 27,
                    OrganizedHolidayId = 14,
                    StartDate = new DateTime(2024, 5, 12),
                    EndDate = new DateTime(2024, 5, 19)
                },
                new OrganizedOfferStartAndEndDate()
                {   
                    Id = 28,
                    OrganizedHolidayId = 14,
                    StartDate = new DateTime(2024, 6, 11),
                    EndDate = new DateTime(2024, 6, 18)
                },

                new OrganizedOfferStartAndEndDate()
                {
                    Id = 29,
                    OrganizedHolidayId = 15,
                    StartDate = new DateTime(2024, 5, 28),
                    EndDate = new DateTime(2024, 6, 5)
                },
                new OrganizedOfferStartAndEndDate()
                {
                    Id = 30,
                    OrganizedHolidayId = 15,
                    StartDate = new DateTime(2024, 7, 4),
                    EndDate = new DateTime(2024, 7, 12)
                },

                new OrganizedOfferStartAndEndDate()
                {
                    Id = 31,
                    OrganizedHolidayId = 16,
                    StartDate = new DateTime(2024, 6, 11),
                    EndDate = new DateTime(2024, 6, 19)
                },
                new OrganizedOfferStartAndEndDate()
                {
                    Id = 32,
                    OrganizedHolidayId = 16,
                    StartDate = new DateTime(2024, 8, 1),
                    EndDate = new DateTime(2024, 8, 9)
                },

                new OrganizedOfferStartAndEndDate()
                {
                    Id = 33,
                    OrganizedHolidayId = 17,
                    StartDate = new DateTime(2024, 6, 20),
                    EndDate = new DateTime(2024, 6, 27)
                },
                new OrganizedOfferStartAndEndDate()
                {
                    Id = 34,
                    OrganizedHolidayId = 17,
                    StartDate = new DateTime(2024, 8, 3),
                    EndDate = new DateTime(2024, 8, 10)
                },

                new OrganizedOfferStartAndEndDate()
                {
                    Id = 35,
                    OrganizedHolidayId = 18,
                    StartDate = new DateTime(2024, 5, 11),
                    EndDate = new DateTime(2024, 5, 14)
                },
                new OrganizedOfferStartAndEndDate()
                {
                    Id = 36,
                    OrganizedHolidayId = 18,
                    StartDate = new DateTime(2024, 6, 18),
                    EndDate = new DateTime(2024, 6, 21)
                },

                new OrganizedOfferStartAndEndDate()
                {
                    Id = 37,
                    OrganizedHolidayId = 19,
                    StartDate = new DateTime(2024, 4, 22),
                    EndDate = new DateTime(2024, 4, 25)
                },
                new OrganizedOfferStartAndEndDate()
                {   
                    Id = 38,
                    OrganizedHolidayId = 19,
                    StartDate = new DateTime(2024, 5, 26),
                    EndDate = new DateTime(2024, 5, 29)
                },

                new OrganizedOfferStartAndEndDate()
                {
                    Id = 39,
                    OrganizedHolidayId = 20,
                    StartDate = new DateTime(2024, 6, 15),
                    EndDate = new DateTime(2024, 6, 21)
                },
                new OrganizedOfferStartAndEndDate()
                {
                    Id = 40,
                    OrganizedHolidayId = 20,
                    StartDate = new DateTime(2024, 8, 12),
                    EndDate = new DateTime(2024, 8, 18)
                },

                new OrganizedOfferStartAndEndDate()
                {
                    Id = 41,
                    OrganizedHolidayId = 21,
                    StartDate = new DateTime(2024, 6, 20),
                    EndDate = new DateTime(2024, 6, 29)
                },
                new OrganizedOfferStartAndEndDate()
                {
                    Id = 42,
                    OrganizedHolidayId = 21,
                    StartDate = new DateTime(2024, 8, 19),
                    EndDate = new DateTime(2024, 8, 28)
                },

                new OrganizedOfferStartAndEndDate()
                {
                    Id = 43,
                    OrganizedHolidayId = 22,
                    StartDate = new DateTime(2024, 6, 16),
                    EndDate = new DateTime(2024, 6, 21)
                },
                new OrganizedOfferStartAndEndDate()
                {
                    Id = 44,
                    OrganizedHolidayId = 22,
                    StartDate = new DateTime(2024, 7, 20),
                    EndDate = new DateTime(2024, 7, 25)
                },

                new OrganizedOfferStartAndEndDate()
                {
                    Id = 45,
                    OrganizedHolidayId = 23,
                    StartDate = new DateTime(2024, 5, 12),
                    EndDate = new DateTime(2024, 5, 18)
                },
                new OrganizedOfferStartAndEndDate()
                {
                    Id = 46,
                    OrganizedHolidayId = 23,
                    StartDate = new DateTime(2024, 6, 11),
                    EndDate = new DateTime(2024, 6, 17)
                },

                new OrganizedOfferStartAndEndDate()
                {
                    Id = 47,
                    OrganizedHolidayId = 24,
                    StartDate = new DateTime(2024, 7, 4),
                    EndDate = new DateTime(2024, 7, 10)
                },
                new OrganizedOfferStartAndEndDate()
                {
                    Id = 48,
                    OrganizedHolidayId = 24,
                    StartDate = new DateTime(2024, 9, 1),
                    EndDate = new DateTime(2024, 9, 7)
                },

                new OrganizedOfferStartAndEndDate()
                {
                    Id = 49,
                    OrganizedHolidayId = 25,
                    StartDate = new DateTime(2024, 7, 15),
                    EndDate = new DateTime(2024, 7, 21)
                },
                new OrganizedOfferStartAndEndDate()
                {
                    Id = 50,
                    OrganizedHolidayId = 25,
                    StartDate = new DateTime(2024, 8, 19),
                    EndDate = new DateTime(2024, 8, 25)
                },

                new OrganizedOfferStartAndEndDate()
                {
                    Id = 51,
                    OrganizedHolidayId = 26,
                    StartDate = new DateTime(2024, 5, 16),
                    EndDate = new DateTime(2024, 5, 22)
                },
                new OrganizedOfferStartAndEndDate()
                {
                    Id = 52,
                    OrganizedHolidayId = 26,
                    StartDate = new DateTime(2024, 7, 1),
                    EndDate = new DateTime(2024, 7, 7)
                },

                new OrganizedOfferStartAndEndDate()
                {
                    Id = 53,
                    OrganizedHolidayId = 27,
                    StartDate = new DateTime(2024, 6, 12),
                    EndDate = new DateTime(2024, 6, 18)
                },
                new OrganizedOfferStartAndEndDate()
                {
                    Id = 54,
                    OrganizedHolidayId = 27,
                    StartDate = new DateTime(2024, 7, 15),
                    EndDate = new DateTime(2024, 7, 21)
                },

                new OrganizedOfferStartAndEndDate()
                {
                    Id = 55,
                    OrganizedHolidayId = 28,
                    StartDate = new DateTime(2024, 7, 2),
                    EndDate = new DateTime(2024, 7, 8)
                },
                new OrganizedOfferStartAndEndDate()
                {
                    Id = 56,
                    OrganizedHolidayId = 28,
                    StartDate = new DateTime(2024, 8, 16),
                    EndDate = new DateTime(2024, 8, 22)
                },

                new OrganizedOfferStartAndEndDate()
                {
                    Id = 57,
                    OrganizedHolidayId = 29,
                    StartDate = new DateTime(2024, 7, 18),
                    EndDate = new DateTime(2024, 7, 26)
                },
                new OrganizedOfferStartAndEndDate()
                {
                    Id = 58,
                    OrganizedHolidayId = 29,
                    StartDate = new DateTime(2024, 9, 2),
                    EndDate = new DateTime(2024, 9, 10)
                },

                new OrganizedOfferStartAndEndDate()
                {
                    Id = 59,
                    OrganizedHolidayId = 30,
                    StartDate = new DateTime(2024, 5, 14),
                    EndDate = new DateTime(2024, 5, 21)
                },
                new OrganizedOfferStartAndEndDate()
                {
                    Id = 60,
                    OrganizedHolidayId = 30,
                    StartDate = new DateTime(2024, 7, 2),
                    EndDate = new DateTime(2024, 7, 9)
                },

                new OrganizedOfferStartAndEndDate()
                {
                    Id = 61,
                    OrganizedHolidayId = 31,
                    StartDate = new DateTime(2024, 5, 8),
                    EndDate = new DateTime(2024, 5, 15)
                },
                new OrganizedOfferStartAndEndDate()
                {
                    Id = 62,
                    OrganizedHolidayId = 31,
                    StartDate = new DateTime(2024, 7, 14),
                    EndDate = new DateTime(2024, 7, 21)
                },

                new OrganizedOfferStartAndEndDate()
                {
                    Id = 63,
                    OrganizedHolidayId = 32,
                    StartDate = new DateTime(2024, 6, 13),
                    EndDate = new DateTime(2024, 6, 18)
                },
                new OrganizedOfferStartAndEndDate()
                {
                    Id = 64,
                    OrganizedHolidayId = 32,
                    StartDate = new DateTime(2024, 7, 26),
                    EndDate = new DateTime(2024, 7, 31)
                },

                new OrganizedOfferStartAndEndDate()
                {
                    Id = 65,
                    OrganizedHolidayId = 33,
                    StartDate = new DateTime(2024, 5, 31),
                    EndDate = new DateTime(2024, 6, 5)
                },
                new OrganizedOfferStartAndEndDate()
                {
                    Id = 66,
                    OrganizedHolidayId = 33,
                    StartDate = new DateTime(2024, 7, 1),
                    EndDate = new DateTime(2024, 7, 6)
                },

                new OrganizedOfferStartAndEndDate()
                {
                    Id = 67,
                    OrganizedHolidayId = 34,
                    StartDate = new DateTime(2024, 4, 20),
                    EndDate = new DateTime(2024, 4, 25)
                },
                new OrganizedOfferStartAndEndDate()
                {
                    Id = 68,
                    OrganizedHolidayId = 34,
                    StartDate = new DateTime(2024, 6, 18),
                    EndDate = new DateTime(2024, 6, 23)
                },

                new OrganizedOfferStartAndEndDate()
                {
                    Id = 69,
                    OrganizedHolidayId = 35,
                    StartDate = new DateTime(2024, 6, 11),
                    EndDate = new DateTime(2024, 6, 18)
                },
                new OrganizedOfferStartAndEndDate()
                {
                    Id = 70,
                    OrganizedHolidayId = 35,
                    StartDate = new DateTime(2024, 7, 29),
                    EndDate = new DateTime(2024, 8, 5)
                },
            });
        }
    }
}
