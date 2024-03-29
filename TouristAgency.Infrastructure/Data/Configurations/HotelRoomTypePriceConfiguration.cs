using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TouristAgency.Infrastructure.Data.Models.MssqlModels;

namespace TouristAgency.Infrastructure.Data.Configurations
{
    public class HotelRoomTypePriceConfiguration : IEntityTypeConfiguration<HotelRoomTypePrice>
    {
        public void Configure(EntityTypeBuilder<HotelRoomTypePrice> builder)
        {
            builder.HasKey(pk => new { pk.HotelId, pk.RoomTypeId });

            Seed(builder);
        }

        private static void Seed(EntityTypeBuilder<HotelRoomTypePrice> builder)
        {
            builder.HasData(new HotelRoomTypePrice[]
            {
                new HotelRoomTypePrice()
                {
                    HotelId = 1,
                    RoomTypeId = 1,
                    PricePerNight = 81.50m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 1,
                    RoomTypeId = 2,
                    PricePerNight = 90.50m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 1,
                    RoomTypeId = 5,
                    PricePerNight = 110m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 1,
                    RoomTypeId = 10,
                    PricePerNight = 59.50m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 2,
                    RoomTypeId = 1,
                    PricePerNight = 80.50m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 2,
                    RoomTypeId = 2,
                    PricePerNight = 92.50m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 2,
                    RoomTypeId = 5,
                    PricePerNight = 112m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 2,
                    RoomTypeId = 10,
                    PricePerNight = 58m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 3,
                    RoomTypeId = 1,
                    PricePerNight = 81m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 3,
                    RoomTypeId = 2,
                    PricePerNight = 93.40m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 3,
                    RoomTypeId = 5,
                    PricePerNight = 114.50m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 3,
                    RoomTypeId = 10,
                    PricePerNight = 62m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 4,
                    RoomTypeId = 1,
                    PricePerNight = 91.70m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 4,
                    RoomTypeId = 2,
                    PricePerNight = 99.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 4,
                    RoomTypeId = 3,
                    PricePerNight = 105.20m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 4,
                    RoomTypeId = 4,
                    PricePerNight = 112m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 4,
                    RoomTypeId = 5,
                    PricePerNight = 115m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 4,
                    RoomTypeId = 10,
                    PricePerNight = 69m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 5,
                    RoomTypeId = 1,
                    PricePerNight = 90.10m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 5,
                    RoomTypeId = 2,
                    PricePerNight = 101.10m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 5,
                    RoomTypeId = 5,
                    PricePerNight = 115m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 5,
                    RoomTypeId = 9,
                    PricePerNight = 147.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 5,
                    RoomTypeId = 10,
                    PricePerNight = 73.20m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 6,
                    RoomTypeId = 1,
                    PricePerNight = 91.10m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 6,
                    RoomTypeId = 2,
                    PricePerNight = 100.10m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 6,
                    RoomTypeId = 5,
                    PricePerNight = 111m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 6,
                    RoomTypeId = 9,
                    PricePerNight = 150.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 6,
                    RoomTypeId = 10,
                    PricePerNight = 68.20m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 7,
                    RoomTypeId = 1,
                    PricePerNight = 89.20m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 7,
                    RoomTypeId = 2,
                    PricePerNight = 97.10m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 7,
                    RoomTypeId = 3,
                    PricePerNight = 105m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 7,
                    RoomTypeId = 4,
                    PricePerNight = 114.40m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 7,
                    RoomTypeId = 8,
                    PricePerNight = 104m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 7,
                    RoomTypeId = 10,
                    PricePerNight = 71m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 8,
                    RoomTypeId = 1,
                    PricePerNight = 88.20m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 8,
                    RoomTypeId = 2,
                    PricePerNight = 96.10m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 8,
                    RoomTypeId = 5,
                    PricePerNight = 115m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 8,
                    RoomTypeId = 9,
                    PricePerNight = 139.70m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 8,
                    RoomTypeId = 10,
                    PricePerNight = 70.10m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 9,
                    RoomTypeId = 1,
                    PricePerNight = 88.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 9,
                    RoomTypeId = 2,
                    PricePerNight = 96.40m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 9,
                    RoomTypeId = 5,
                    PricePerNight = 115.80m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 9,
                    RoomTypeId = 10,
                    PricePerNight = 70.20m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 10,
                    RoomTypeId = 1,
                    PricePerNight = 95.20m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 10,
                    RoomTypeId = 2,
                    PricePerNight = 103.40m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 10,
                    RoomTypeId = 10,
                    PricePerNight = 75.20m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 11,
                    RoomTypeId = 1,
                    PricePerNight = 96.20m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 11,
                    RoomTypeId = 2,
                    PricePerNight = 103.30m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 11,
                    RoomTypeId = 5,
                    PricePerNight = 113.30m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 11,
                    RoomTypeId = 10,
                    PricePerNight = 74.10m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 12,
                    RoomTypeId = 1,
                    PricePerNight = 96.70m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 12,
                    RoomTypeId = 2,
                    PricePerNight = 102.30m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 12,
                    RoomTypeId = 5,
                    PricePerNight = 113.39m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 12,
                    RoomTypeId = 8,
                    PricePerNight = 107m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 12,
                    RoomTypeId = 10,
                    PricePerNight = 72.10m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 13,
                    RoomTypeId = 1,
                    PricePerNight = 103.10m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 13,
                    RoomTypeId = 2,
                    PricePerNight = 113.30m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 13,
                    RoomTypeId = 5,
                    PricePerNight = 121.15m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 13,
                    RoomTypeId = 10,
                    PricePerNight = 82.10m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 14,
                    RoomTypeId = 1,
                    PricePerNight = 105.10m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 14,
                    RoomTypeId = 2,
                    PricePerNight = 111.30m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 14,
                    RoomTypeId = 8,
                    PricePerNight = 115.15m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 14,
                    RoomTypeId = 10,
                    PricePerNight = 83.10m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 15,
                    RoomTypeId = 1,
                    PricePerNight = 104.20m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 15,
                    RoomTypeId = 2,
                    PricePerNight = 114.30m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 15,
                    RoomTypeId = 10,
                    PricePerNight = 82.10m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 16,
                    RoomTypeId = 1,
                    PricePerNight = 98.20m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 16,
                    RoomTypeId = 2,
                    PricePerNight = 109.30m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 16,
                    RoomTypeId = 8,
                    PricePerNight = 112.05m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 16,
                    RoomTypeId = 10,
                    PricePerNight = 75.10m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 17,
                    RoomTypeId = 1,
                    PricePerNight = 98.50m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 17,
                    RoomTypeId = 2,
                    PricePerNight = 109.10m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 17,
                    RoomTypeId = 8,
                    PricePerNight = 113m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 17,
                    RoomTypeId = 10,
                    PricePerNight = 75.90m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 18,
                    RoomTypeId = 1,
                    PricePerNight = 100.50m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 18,
                    RoomTypeId = 2,
                    PricePerNight = 111.30m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 18,
                    RoomTypeId = 5,
                    PricePerNight = 119.05m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 18,
                    RoomTypeId = 10,
                    PricePerNight = 79.90m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 19,
                    RoomTypeId = 1,
                    PricePerNight = 96.50m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 19,
                    RoomTypeId = 2,
                    PricePerNight = 108.30m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 19,
                    RoomTypeId = 5,
                    PricePerNight = 119.05m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 19,
                    RoomTypeId = 9,
                    PricePerNight = 145.05m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 19,
                    RoomTypeId = 10,
                    PricePerNight = 81.90m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 20,
                    RoomTypeId = 1,
                    PricePerNight = 93.10m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 20,
                    RoomTypeId = 2,
                    PricePerNight = 104.30m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 20,
                    RoomTypeId = 8,
                    PricePerNight = 111.11m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 20,
                    RoomTypeId = 10,
                    PricePerNight = 75.90m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 21,
                    RoomTypeId = 1,
                    PricePerNight = 94.30m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 21,
                    RoomTypeId = 2,
                    PricePerNight = 103.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 21,
                    RoomTypeId = 8,
                    PricePerNight = 112.20m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 21,
                    RoomTypeId = 10,
                    PricePerNight = 70.90m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 22,
                    RoomTypeId = 1,
                    PricePerNight = 105.30m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 22,
                    RoomTypeId = 2,
                    PricePerNight = 114.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 22,
                    RoomTypeId = 5,
                    PricePerNight = 123.20m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 22,
                    RoomTypeId = 6,
                    PricePerNight = 170.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 22,
                    RoomTypeId = 10,
                    PricePerNight = 60.90m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 23,
                    RoomTypeId = 1,
                    PricePerNight = 99.30m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 23,
                    RoomTypeId = 2,
                    PricePerNight = 109.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 23,
                    RoomTypeId = 3,
                    PricePerNight = 114.20m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 23,
                    RoomTypeId = 4,
                    PricePerNight = 119.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 23,
                    RoomTypeId = 10,
                    PricePerNight = 68.90m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 24,
                    RoomTypeId = 1,
                    PricePerNight = 97.30m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 24,
                    RoomTypeId = 2,
                    PricePerNight = 106.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 24,
                    RoomTypeId = 5,
                    PricePerNight = 114.20m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 24,
                    RoomTypeId = 8,
                    PricePerNight = 109.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 24,
                    RoomTypeId = 10,
                    PricePerNight = 69.90m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 25,
                    RoomTypeId = 1,
                    PricePerNight = 120.20m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 25,
                    RoomTypeId = 2,
                    PricePerNight = 131.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 25,
                    RoomTypeId = 5,
                    PricePerNight = 143.40m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 25,
                    RoomTypeId = 6,
                    PricePerNight = 210.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 25,
                    RoomTypeId = 7,
                    PricePerNight = 370.80m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 25,
                    RoomTypeId = 10,
                    PricePerNight = 59.90m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 26,
                    RoomTypeId = 1,
                    PricePerNight = 121.20m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 26,
                    RoomTypeId = 2,
                    PricePerNight = 132.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 26,
                    RoomTypeId = 5,
                    PricePerNight = 143.20m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 26,
                    RoomTypeId = 6,
                    PricePerNight = 215.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 26,
                    RoomTypeId = 7,
                    PricePerNight = 365.80m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 26,
                    RoomTypeId = 10,
                    PricePerNight = 59.90m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 27,
                    RoomTypeId = 1,
                    PricePerNight = 120.20m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 27,
                    RoomTypeId = 2,
                    PricePerNight = 130.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 27,
                    RoomTypeId = 5,
                    PricePerNight = 143.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 27,
                    RoomTypeId = 6,
                    PricePerNight = 215.10m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 27,
                    RoomTypeId = 7,
                    PricePerNight = 364.40m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 27,
                    RoomTypeId = 10,
                    PricePerNight = 59.90m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 28,
                    RoomTypeId = 1,
                    PricePerNight = 110.20m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 28,
                    RoomTypeId = 2,
                    PricePerNight = 119.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 28,
                    RoomTypeId = 5,
                    PricePerNight = 128.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 28,
                    RoomTypeId = 6,
                    PricePerNight = 190.10m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 28,
                    RoomTypeId = 7,
                    PricePerNight = 310.40m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 28,
                    RoomTypeId = 10,
                    PricePerNight = 57.50m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 29,
                    RoomTypeId = 1,
                    PricePerNight = 109.20m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 29,
                    RoomTypeId = 2,
                    PricePerNight = 118.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 29,
                    RoomTypeId = 5,
                    PricePerNight = 129.80m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 29,
                    RoomTypeId = 6,
                    PricePerNight = 191.10m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 29,
                    RoomTypeId = 7,
                    PricePerNight = 315.40m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 29,
                    RoomTypeId = 10,
                    PricePerNight = 56.50m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 30,
                    RoomTypeId = 1,
                    PricePerNight = 109.50m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 30,
                    RoomTypeId = 2,
                    PricePerNight = 118.50m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 30,
                    RoomTypeId = 5,
                    PricePerNight = 129.10m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 30,
                    RoomTypeId = 6,
                    PricePerNight = 191.60m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 30,
                    RoomTypeId = 7,
                    PricePerNight = 315.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 30,
                    RoomTypeId = 10,
                    PricePerNight = 56.40m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 31,
                    RoomTypeId = 1,
                    PricePerNight = 93.10m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 31,
                    RoomTypeId = 2,
                    PricePerNight = 101.50m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 31,
                    RoomTypeId = 5,
                    PricePerNight = 113.10m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 31,
                    RoomTypeId = 6,
                    PricePerNight = 170.60m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 31,
                    RoomTypeId = 10,
                    PricePerNight = 58.40m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 32,
                    RoomTypeId = 1,
                    PricePerNight = 93.50m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 32,
                    RoomTypeId = 2,
                    PricePerNight = 101.70m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 32,
                    RoomTypeId = 5,
                    PricePerNight = 113.20m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 32,
                    RoomTypeId = 6,
                    PricePerNight = 168.80m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 32,
                    RoomTypeId = 10,
                    PricePerNight = 58.90m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 33,
                    RoomTypeId = 1,
                    PricePerNight = 94.50m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 33,
                    RoomTypeId = 2,
                    PricePerNight = 102.50m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 33,
                    RoomTypeId = 5,
                    PricePerNight = 112.20m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 33,
                    RoomTypeId = 6,
                    PricePerNight = 165.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 33,
                    RoomTypeId = 10,
                    PricePerNight = 58.10m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 34,
                    RoomTypeId = 1,
                    PricePerNight = 85.50m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 34,
                    RoomTypeId = 2,
                    PricePerNight = 94.40m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 34,
                    RoomTypeId = 5,
                    PricePerNight = 103.20m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 34,
                    RoomTypeId = 8,
                    PricePerNight = 99.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 34,
                    RoomTypeId = 10,
                    PricePerNight = 57.20m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 35,
                    RoomTypeId = 1,
                    PricePerNight = 83.50m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 35,
                    RoomTypeId = 2,
                    PricePerNight = 92.40m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 35,
                    RoomTypeId = 8,
                    PricePerNight = 98.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 35,
                    RoomTypeId = 10,
                    PricePerNight = 57.40m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 36,
                    RoomTypeId = 1,
                    PricePerNight = 82.50m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 36,
                    RoomTypeId = 2,
                    PricePerNight = 90.40m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 36,
                    RoomTypeId = 8,
                    PricePerNight = 97.10m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 36,
                    RoomTypeId = 10,
                    PricePerNight = 52.40m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 37,
                    RoomTypeId = 1,
                    PricePerNight = 82.60m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 37,
                    RoomTypeId = 2,
                    PricePerNight = 90.30m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 37,
                    RoomTypeId = 8,
                    PricePerNight = 97.20m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 37,
                    RoomTypeId = 10,
                    PricePerNight = 52.50m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 38,
                    RoomTypeId = 1,
                    PricePerNight = 82.10m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 38,
                    RoomTypeId = 2,
                    PricePerNight = 91.30m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 38,
                    RoomTypeId = 8,
                    PricePerNight = 95.20m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 38,
                    RoomTypeId = 10,
                    PricePerNight = 52.40m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 39,
                    RoomTypeId = 1,
                    PricePerNight = 80.10m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 39,
                    RoomTypeId = 2,
                    PricePerNight = 90.30m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 39,
                    RoomTypeId = 8,
                    PricePerNight = 96.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 39,
                    RoomTypeId = 10,
                    PricePerNight = 53.40m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 40,
                    RoomTypeId = 1,
                    PricePerNight = 90.30m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 40,
                    RoomTypeId = 2,
                    PricePerNight = 98.10m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 40,
                    RoomTypeId = 8,
                    PricePerNight = 103.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 40,
                    RoomTypeId = 10,
                    PricePerNight = 71.40m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 41,
                    RoomTypeId = 1,
                    PricePerNight = 90.50m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 41,
                    RoomTypeId = 2,
                    PricePerNight = 98.50m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 41,
                    RoomTypeId = 8,
                    PricePerNight = 104.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 41,
                    RoomTypeId = 10,
                    PricePerNight = 72.40m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 42,
                    RoomTypeId = 1,
                    PricePerNight = 90.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 42,
                    RoomTypeId = 2,
                    PricePerNight = 99.50m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 42,
                    RoomTypeId = 8,
                    PricePerNight = 103.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 42,
                    RoomTypeId = 10,
                    PricePerNight = 72.10m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 43,
                    RoomTypeId = 1,
                    PricePerNight = 96.80m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 43,
                    RoomTypeId = 2,
                    PricePerNight = 103.50m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 43,
                    RoomTypeId = 3,
                    PricePerNight = 107.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 43,
                    RoomTypeId = 4,
                    PricePerNight = 114.90m
                },
                 new HotelRoomTypePrice()
                {
                    HotelId = 43,
                    RoomTypeId = 9,
                    PricePerNight = 140.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 43,
                    RoomTypeId = 10,
                    PricePerNight = 71.10m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 44,
                    RoomTypeId = 1,
                    PricePerNight = 96.40m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 44,
                    RoomTypeId = 2,
                    PricePerNight = 103.60m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 44,
                    RoomTypeId = 3,
                    PricePerNight = 108.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 44,
                    RoomTypeId = 4,
                    PricePerNight = 116.10m
                },
                 new HotelRoomTypePrice()
                {
                    HotelId = 44,
                    RoomTypeId = 9,
                    PricePerNight = 140.10m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 44,
                    RoomTypeId = 10,
                    PricePerNight = 70.10m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 45,
                    RoomTypeId = 1,
                    PricePerNight = 96.60m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 45,
                    RoomTypeId = 2,
                    PricePerNight = 103.70m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 45,
                    RoomTypeId = 3,
                    PricePerNight = 108.50m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 45,
                    RoomTypeId = 4,
                    PricePerNight = 116.90m
                },
                 new HotelRoomTypePrice()
                {
                    HotelId = 45,
                    RoomTypeId = 9,
                    PricePerNight = 144.10m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 45,
                    RoomTypeId = 10,
                    PricePerNight = 71.10m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 46,
                    RoomTypeId = 1,
                    PricePerNight = 86.60m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 46,
                    RoomTypeId = 2,
                    PricePerNight = 94.70m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 46,
                    RoomTypeId = 5,
                    PricePerNight = 103.50m
                },
                 new HotelRoomTypePrice()
                {
                    HotelId = 46,
                    RoomTypeId = 9,
                    PricePerNight = 144.40m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 46,
                    RoomTypeId = 10,
                    PricePerNight = 72.10m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 47,
                    RoomTypeId = 1,
                    PricePerNight = 86.20m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 47,
                    RoomTypeId = 2,
                    PricePerNight = 94.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 47,
                    RoomTypeId = 5,
                    PricePerNight = 103.90m
                },
                 new HotelRoomTypePrice()
                {
                    HotelId = 47,
                    RoomTypeId = 9,
                    PricePerNight = 144.10m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 47,
                    RoomTypeId = 10,
                    PricePerNight = 72.20m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 48,
                    RoomTypeId = 1,
                    PricePerNight = 87.20m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 48,
                    RoomTypeId = 2,
                    PricePerNight = 95.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 48,
                    RoomTypeId = 5,
                    PricePerNight = 102.90m
                },
                 new HotelRoomTypePrice()
                {
                    HotelId = 48,
                    RoomTypeId = 9,
                    PricePerNight = 144.50m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 48,
                    RoomTypeId = 10,
                    PricePerNight = 72.20m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 49,
                    RoomTypeId = 1,
                    PricePerNight = 95.20m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 49,
                    RoomTypeId = 2,
                    PricePerNight = 104.80m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 49,
                    RoomTypeId = 5,
                    PricePerNight = 109.90m
                },
                 new HotelRoomTypePrice()
                {
                    HotelId = 49,
                    RoomTypeId = 7,
                    PricePerNight = 290.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 49,
                    RoomTypeId = 10,
                    PricePerNight = 49.10m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 50,
                    RoomTypeId = 1,
                    PricePerNight = 95.10m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 50,
                    RoomTypeId = 2,
                    PricePerNight = 103.20m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 50,
                    RoomTypeId = 5,
                    PricePerNight = 110.90m
                },
                 new HotelRoomTypePrice()
                {
                    HotelId = 50,
                    RoomTypeId = 7,
                    PricePerNight = 291.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 50,
                    RoomTypeId = 10,
                    PricePerNight = 49.10m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 51,
                    RoomTypeId = 1,
                    PricePerNight = 95.40m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 51,
                    RoomTypeId = 2,
                    PricePerNight = 103.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 51,
                    RoomTypeId = 5,
                    PricePerNight = 112.90m
                },
                 new HotelRoomTypePrice()
                {
                    HotelId = 51,
                    RoomTypeId = 7,
                    PricePerNight = 291.40m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 51,
                    RoomTypeId = 10,
                    PricePerNight = 49.10m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 52,
                    RoomTypeId = 1,
                    PricePerNight = 92.10m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 52,
                    RoomTypeId = 2,
                    PricePerNight = 101.50m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 52,
                    RoomTypeId = 5,
                    PricePerNight = 109.60m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 52,
                    RoomTypeId = 6,
                    PricePerNight = 152.80m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 52,
                    RoomTypeId = 8,
                    PricePerNight = 105.10m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 52,
                    RoomTypeId = 10,
                    PricePerNight = 61.10m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 53,
                    RoomTypeId = 1,
                    PricePerNight = 92.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 53,
                    RoomTypeId = 2,
                    PricePerNight = 101.60m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 53,
                    RoomTypeId = 5,
                    PricePerNight = 110.10m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 53,
                    RoomTypeId = 6,
                    PricePerNight = 154.10m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 53,
                    RoomTypeId = 8,
                    PricePerNight = 105.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 53,
                    RoomTypeId = 10,
                    PricePerNight = 61.20m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 54,
                    RoomTypeId = 1,
                    PricePerNight = 93.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 54,
                    RoomTypeId = 2,
                    PricePerNight = 102.60m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 54,
                    RoomTypeId = 5,
                    PricePerNight = 112.10m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 54,
                    RoomTypeId = 6,
                    PricePerNight = 155.10m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 54,
                    RoomTypeId = 8,
                    PricePerNight = 106.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 54,
                    RoomTypeId = 10,
                    PricePerNight = 62.20m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 55,
                    RoomTypeId = 1,
                    PricePerNight = 104.15m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 55,
                    RoomTypeId = 2,
                    PricePerNight = 112.60m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 55,
                    RoomTypeId = 6,
                    PricePerNight = 170.10m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 55,
                    RoomTypeId = 7,
                    PricePerNight = 390.10m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 55,
                    RoomTypeId = 10,
                    PricePerNight = 40.20m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 56,
                    RoomTypeId = 1,
                    PricePerNight = 104.25m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 56,
                    RoomTypeId = 2,
                    PricePerNight = 112.70m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 56,
                    RoomTypeId = 6,
                    PricePerNight = 170.30m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 56,
                    RoomTypeId = 7,
                    PricePerNight = 390.50m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 56,
                    RoomTypeId = 10,
                    PricePerNight = 40.30m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 57,
                    RoomTypeId = 1,
                    PricePerNight = 104.20m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 57,
                    RoomTypeId = 2,
                    PricePerNight = 112.50m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 57,
                    RoomTypeId = 6,
                    PricePerNight = 170.10m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 57,
                    RoomTypeId = 7,
                    PricePerNight = 390.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 57,
                    RoomTypeId = 10,
                    PricePerNight = 40.90m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 58,
                    RoomTypeId = 1,
                    PricePerNight = 120.20m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 58,
                    RoomTypeId = 2,
                    PricePerNight = 132.50m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 58,
                    RoomTypeId = 5,
                    PricePerNight = 147.50m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 58,
                    RoomTypeId = 7,
                    PricePerNight = 440.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 58,
                    RoomTypeId = 10,
                    PricePerNight = 31.90m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 59,
                    RoomTypeId = 1,
                    PricePerNight = 120.50m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 59,
                    RoomTypeId = 2,
                    PricePerNight = 134.50m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 59,
                    RoomTypeId = 5,
                    PricePerNight = 148.30m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 59,
                    RoomTypeId = 7,
                    PricePerNight = 442.40m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 59,
                    RoomTypeId = 10,
                    PricePerNight = 31.80m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 60,
                    RoomTypeId = 1,
                    PricePerNight = 121.40m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 60,
                    RoomTypeId = 2,
                    PricePerNight = 136.10m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 60,
                    RoomTypeId = 5,
                    PricePerNight = 148.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 60,
                    RoomTypeId = 7,
                    PricePerNight = 444.40m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 60,
                    RoomTypeId = 10,
                    PricePerNight = 30.90m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 61,
                    RoomTypeId = 1,
                    PricePerNight = 111.40m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 61,
                    RoomTypeId = 2,
                    PricePerNight = 120.10m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 61,
                    RoomTypeId = 3,
                    PricePerNight = 127.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 61,
                    RoomTypeId = 10,
                    PricePerNight = 50.90m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 62,
                    RoomTypeId = 1,
                    PricePerNight = 111.30m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 62,
                    RoomTypeId = 2,
                    PricePerNight = 124.10m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 62,
                    RoomTypeId = 3,
                    PricePerNight = 128.80m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 62,
                    RoomTypeId = 10,
                    PricePerNight = 51.90m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 63,
                    RoomTypeId = 1,
                    PricePerNight = 111.40m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 63,
                    RoomTypeId = 2,
                    PricePerNight = 124.30m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 63,
                    RoomTypeId = 3,
                    PricePerNight = 129.80m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 63,
                    RoomTypeId = 10,
                    PricePerNight = 50.80m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 64,
                    RoomTypeId = 1,
                    PricePerNight = 99.40m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 64,
                    RoomTypeId = 2,
                    PricePerNight = 107.30m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 64,
                    RoomTypeId = 4,
                    PricePerNight = 117.80m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 64,
                    RoomTypeId = 8,
                    PricePerNight = 113.40m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 64,
                    RoomTypeId = 10,
                    PricePerNight = 61.10m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 65,
                    RoomTypeId = 1,
                    PricePerNight = 99.30m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 65,
                    RoomTypeId = 2,
                    PricePerNight = 107.40m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 65,
                    RoomTypeId = 4,
                    PricePerNight = 118.30m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 65,
                    RoomTypeId = 8,
                    PricePerNight = 113.10m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 65,
                    RoomTypeId = 10,
                    PricePerNight = 61.30m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 66,
                    RoomTypeId = 1,
                    PricePerNight = 100.10m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 66,
                    RoomTypeId = 2,
                    PricePerNight = 108.40m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 66,
                    RoomTypeId = 4,
                    PricePerNight = 119.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 66,
                    RoomTypeId = 8,
                    PricePerNight = 114.60m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 66,
                    RoomTypeId = 10,
                    PricePerNight = 61.10m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 67,
                    RoomTypeId = 1,
                    PricePerNight = 121.10m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 67,
                    RoomTypeId = 2,
                    PricePerNight = 133.40m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 67,
                    RoomTypeId = 5,
                    PricePerNight = 144.50m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 67,
                    RoomTypeId = 6,
                    PricePerNight = 190.60m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 67,
                    RoomTypeId = 7,
                    PricePerNight = 460.60m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 67,
                    RoomTypeId = 10,
                    PricePerNight = 34.10m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 68,
                    RoomTypeId = 1,
                    PricePerNight = 121.60m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 68,
                    RoomTypeId = 2,
                    PricePerNight = 133.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 68,
                    RoomTypeId = 5,
                    PricePerNight = 145.40m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 68,
                    RoomTypeId = 6,
                    PricePerNight = 191.70m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 68,
                    RoomTypeId = 7,
                    PricePerNight = 461.50m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 68,
                    RoomTypeId = 10,
                    PricePerNight = 33.50m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 69,
                    RoomTypeId = 1,
                    PricePerNight = 121.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 69,
                    RoomTypeId = 2,
                    PricePerNight = 134.60m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 69,
                    RoomTypeId = 5,
                    PricePerNight = 145.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 69,
                    RoomTypeId = 6,
                    PricePerNight = 192.60m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 69,
                    RoomTypeId = 7,
                    PricePerNight = 461.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 69,
                    RoomTypeId = 10,
                    PricePerNight = 33.70m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 70,
                    RoomTypeId = 1,
                    PricePerNight = 134.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 70,
                    RoomTypeId = 2,
                    PricePerNight = 145.60m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 70,
                    RoomTypeId = 3,
                    PricePerNight = 154.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 70,
                    RoomTypeId = 4,
                    PricePerNight = 166.60m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 70,
                    RoomTypeId = 6,
                    PricePerNight = 210.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 70,
                    RoomTypeId = 10,
                    PricePerNight = 42.70m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 71,
                    RoomTypeId = 1,
                    PricePerNight = 135.70m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 71,
                    RoomTypeId = 2,
                    PricePerNight = 146.60m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 71,
                    RoomTypeId = 3,
                    PricePerNight = 155.60m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 71,
                    RoomTypeId = 4,
                    PricePerNight = 167.60m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 71,
                    RoomTypeId = 6,
                    PricePerNight = 211.60m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 71,
                    RoomTypeId = 10,
                    PricePerNight = 42.60m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 72,
                    RoomTypeId = 1,
                    PricePerNight = 135.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 72,
                    RoomTypeId = 2,
                    PricePerNight = 146.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 72,
                    RoomTypeId = 3,
                    PricePerNight = 155.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 72,
                    RoomTypeId = 4,
                    PricePerNight = 167.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 72,
                    RoomTypeId = 6,
                    PricePerNight = 211.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 72,
                    RoomTypeId = 10,
                    PricePerNight = 42.90m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 73,
                    RoomTypeId = 1,
                    PricePerNight = 128.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 73,
                    RoomTypeId = 2,
                    PricePerNight = 134.50m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 73,
                    RoomTypeId = 3,
                    PricePerNight = 142.60m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 73,
                    RoomTypeId = 4,
                    PricePerNight = 151.40m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 73,
                    RoomTypeId = 10,
                    PricePerNight = 39.90m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 74,
                    RoomTypeId = 1,
                    PricePerNight = 129.30m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 74,
                    RoomTypeId = 2,
                    PricePerNight = 135.40m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 74,
                    RoomTypeId = 3,
                    PricePerNight = 143.20m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 74,
                    RoomTypeId = 4,
                    PricePerNight = 151.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 74,
                    RoomTypeId = 10,
                    PricePerNight = 39.80m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 75,
                    RoomTypeId = 1,
                    PricePerNight = 129.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 75,
                    RoomTypeId = 2,
                    PricePerNight = 135.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 75,
                    RoomTypeId = 3,
                    PricePerNight = 143.80m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 75,
                    RoomTypeId = 4,
                    PricePerNight = 152.60m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 75,
                    RoomTypeId = 10,
                    PricePerNight = 40.20m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 76,
                    RoomTypeId = 1,
                    PricePerNight = 111.70m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 76,
                    RoomTypeId = 2,
                    PricePerNight = 122.10m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 76,
                    RoomTypeId = 3,
                    PricePerNight = 131.20m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 76,
                    RoomTypeId = 4,
                    PricePerNight = 142.60m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 76,
                    RoomTypeId = 10,
                    PricePerNight = 44.20m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 77,
                    RoomTypeId = 1,
                    PricePerNight = 112.50m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 77,
                    RoomTypeId = 2,
                    PricePerNight = 122.70m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 77,
                    RoomTypeId = 3,
                    PricePerNight = 131.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 77,
                    RoomTypeId = 4,
                    PricePerNight = 143.30m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 77,
                    RoomTypeId = 10,
                    PricePerNight = 44.40m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 78,
                    RoomTypeId = 1,
                    PricePerNight = 113.30m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 78,
                    RoomTypeId = 2,
                    PricePerNight = 123.40m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 78,
                    RoomTypeId = 3,
                    PricePerNight = 131.50m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 78,
                    RoomTypeId = 4,
                    PricePerNight = 145.10m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 78,
                    RoomTypeId = 10,
                    PricePerNight = 44.50m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 79,
                    RoomTypeId = 1,
                    PricePerNight = 120.10m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 79,
                    RoomTypeId = 2,
                    PricePerNight = 131.40m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 79,
                    RoomTypeId = 3,
                    PricePerNight = 142.50m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 79,
                    RoomTypeId = 4,
                    PricePerNight = 151.10m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 79,
                    RoomTypeId = 6,
                    PricePerNight = 211.70m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 79,
                    RoomTypeId = 10,
                    PricePerNight = 34.50m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 80,
                    RoomTypeId = 1,
                    PricePerNight = 120.80m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 80,
                    RoomTypeId = 2,
                    PricePerNight = 131.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 80,
                    RoomTypeId = 3,
                    PricePerNight = 143.30m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 80,
                    RoomTypeId = 4,
                    PricePerNight = 151.70m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 80,
                    RoomTypeId = 6,
                    PricePerNight = 212.60m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 80,
                    RoomTypeId = 10,
                    PricePerNight = 34.60m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 81,
                    RoomTypeId = 1,
                    PricePerNight = 121.60m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 81,
                    RoomTypeId = 2,
                    PricePerNight = 132.60m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 81,
                    RoomTypeId = 3,
                    PricePerNight = 143.70m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 81,
                    RoomTypeId = 4,
                    PricePerNight = 152.50m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 81,
                    RoomTypeId = 6,
                    PricePerNight = 213.10m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 81,
                    RoomTypeId = 10,
                    PricePerNight = 34.70m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 82,
                    RoomTypeId = 1,
                    PricePerNight = 101.50m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 82,
                    RoomTypeId = 2,
                    PricePerNight = 109.60m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 82,
                    RoomTypeId = 3,
                    PricePerNight = 118.70m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 82,
                    RoomTypeId = 4,
                    PricePerNight = 124.40m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 82,
                    RoomTypeId = 10,
                    PricePerNight = 32.70m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 83,
                    RoomTypeId = 1,
                    PricePerNight = 101.80m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 83,
                    RoomTypeId = 2,
                    PricePerNight = 109.50m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 83,
                    RoomTypeId = 3,
                    PricePerNight = 117.60m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 83,
                    RoomTypeId = 4,
                    PricePerNight = 124.70m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 83,
                    RoomTypeId = 10,
                    PricePerNight = 32.80m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 84,
                    RoomTypeId = 1,
                    PricePerNight = 102.20m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 84,
                    RoomTypeId = 2,
                    PricePerNight = 109.80m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 84,
                    RoomTypeId = 3,
                    PricePerNight = 118.10m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 84,
                    RoomTypeId = 4,
                    PricePerNight = 125.40m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 84,
                    RoomTypeId = 10,
                    PricePerNight = 32.90m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 85,
                    RoomTypeId = 1,
                    PricePerNight = 141.10m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 85,
                    RoomTypeId = 2,
                    PricePerNight = 152.80m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 85,
                    RoomTypeId = 5,
                    PricePerNight = 161.10m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 85,
                    RoomTypeId = 8,
                    PricePerNight = 158.40m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 85,
                    RoomTypeId = 9,
                    PricePerNight = 220.70m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 85,
                    RoomTypeId = 10,
                    PricePerNight = 50.90m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 86,
                    RoomTypeId = 1,
                    PricePerNight = 142.40m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 86,
                    RoomTypeId = 2,
                    PricePerNight = 153.50m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 86,
                    RoomTypeId = 5,
                    PricePerNight = 161.70m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 86,
                    RoomTypeId = 8,
                    PricePerNight = 158.10m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 86,
                    RoomTypeId = 9,
                    PricePerNight = 221.50m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 86,
                    RoomTypeId = 10,
                    PricePerNight = 50.60m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 87,
                    RoomTypeId = 1,
                    PricePerNight = 142.80m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 87,
                    RoomTypeId = 2,
                    PricePerNight = 154.50m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 87,
                    RoomTypeId = 5,
                    PricePerNight = 162.70m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 87,
                    RoomTypeId = 8,
                    PricePerNight = 159.10m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 87,
                    RoomTypeId = 9,
                    PricePerNight = 222.50m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 87,
                    RoomTypeId = 10,
                    PricePerNight = 51.60m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 88,
                    RoomTypeId = 1,
                    PricePerNight = 99.80m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 88,
                    RoomTypeId = 2,
                    PricePerNight = 107.50m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 88,
                    RoomTypeId = 3,
                    PricePerNight = 114.70m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 88,
                    RoomTypeId = 4,
                    PricePerNight = 121.10m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 88,
                    RoomTypeId = 10,
                    PricePerNight = 21.60m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 89,
                    RoomTypeId = 1,
                    PricePerNight = 99.50m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 89,
                    RoomTypeId = 2,
                    PricePerNight = 107.10m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 89,
                    RoomTypeId = 3,
                    PricePerNight = 114.30m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 89,
                    RoomTypeId = 4,
                    PricePerNight = 120.60m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 89,
                    RoomTypeId = 10,
                    PricePerNight = 21.50m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 90,
                    RoomTypeId = 1,
                    PricePerNight = 99.10m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 90,
                    RoomTypeId = 2,
                    PricePerNight = 106.50m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 90,
                    RoomTypeId = 3,
                    PricePerNight = 113.80m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 90,
                    RoomTypeId = 4,
                    PricePerNight = 120.10m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 90,
                    RoomTypeId = 10,
                    PricePerNight = 21.10m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 91,
                    RoomTypeId = 1,
                    PricePerNight = 99.60m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 91,
                    RoomTypeId = 2,
                    PricePerNight = 106.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 91,
                    RoomTypeId = 3,
                    PricePerNight = 114.30m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 91,
                    RoomTypeId = 4,
                    PricePerNight = 120.40m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 91,
                    RoomTypeId = 10,
                    PricePerNight = 21.20m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 92,
                    RoomTypeId = 1,
                    PricePerNight = 99.40m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 92,
                    RoomTypeId = 2,
                    PricePerNight = 106.70m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 92,
                    RoomTypeId = 3,
                    PricePerNight = 114.20m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 92,
                    RoomTypeId = 4,
                    PricePerNight = 120.20m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 92,
                    RoomTypeId = 10,
                    PricePerNight = 21.00m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 93,
                    RoomTypeId = 1,
                    PricePerNight = 99.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 93,
                    RoomTypeId = 2,
                    PricePerNight = 107.80m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 93,
                    RoomTypeId = 3,
                    PricePerNight = 114.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 93,
                    RoomTypeId = 4,
                    PricePerNight = 120.70m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 93,
                    RoomTypeId = 10,
                    PricePerNight = 21.50m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 94,
                    RoomTypeId = 1,
                    PricePerNight = 102.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 94,
                    RoomTypeId = 2,
                    PricePerNight = 113.80m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 94,
                    RoomTypeId = 3,
                    PricePerNight = 120.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 94,
                    RoomTypeId = 4,
                    PricePerNight = 128.70m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 94,
                    RoomTypeId = 10,
                    PricePerNight = 23.50m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 95,
                    RoomTypeId = 1,
                    PricePerNight = 102.50m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 95,
                    RoomTypeId = 2,
                    PricePerNight = 113.40m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 95,
                    RoomTypeId = 3,
                    PricePerNight = 120.30m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 95,
                    RoomTypeId = 4,
                    PricePerNight = 128.10m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 95,
                    RoomTypeId = 10,
                    PricePerNight = 23.30m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 96,
                    RoomTypeId = 1,
                    PricePerNight = 102.70m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 96,
                    RoomTypeId = 2,
                    PricePerNight = 113.60m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 96,
                    RoomTypeId = 3,
                    PricePerNight = 120.70m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 96,
                    RoomTypeId = 4,
                    PricePerNight = 128.50m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 96,
                    RoomTypeId = 10,
                    PricePerNight = 23.50m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 97,
                    RoomTypeId = 1,
                    PricePerNight = 91.60m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 97,
                    RoomTypeId = 2,
                    PricePerNight = 99.30m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 97,
                    RoomTypeId = 3,
                    PricePerNight = 106.40m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 97,
                    RoomTypeId = 4,
                    PricePerNight = 113.10m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 97,
                    RoomTypeId = 10,
                    PricePerNight = 24.60m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 98,
                    RoomTypeId = 1,
                    PricePerNight = 91.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 98,
                    RoomTypeId = 2,
                    PricePerNight = 99.80m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 98,
                    RoomTypeId = 3,
                    PricePerNight = 106.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 98,
                    RoomTypeId = 4,
                    PricePerNight = 113.40m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 98,
                    RoomTypeId = 10,
                    PricePerNight = 24.20m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 99,
                    RoomTypeId = 1,
                    PricePerNight = 92.60m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 99,
                    RoomTypeId = 2,
                    PricePerNight = 100.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 99,
                    RoomTypeId = 3,
                    PricePerNight = 107.80m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 99,
                    RoomTypeId = 4,
                    PricePerNight = 113.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 99,
                    RoomTypeId = 10,
                    PricePerNight = 23.70m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 100,
                    RoomTypeId = 1,
                    PricePerNight = 87.50m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 100,
                    RoomTypeId = 2,
                    PricePerNight = 95.80m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 100,
                    RoomTypeId = 3,
                    PricePerNight = 104.30m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 100,
                    RoomTypeId = 4,
                    PricePerNight = 111.10m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 100,
                    RoomTypeId = 10,
                    PricePerNight = 23.90m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 101,
                    RoomTypeId = 1,
                    PricePerNight = 87.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 101,
                    RoomTypeId = 2,
                    PricePerNight = 96.30m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 101,
                    RoomTypeId = 3,
                    PricePerNight = 104.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 101,
                    RoomTypeId = 4,
                    PricePerNight = 111.70m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 101,
                    RoomTypeId = 10,
                    PricePerNight = 23.80m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 102,
                    RoomTypeId = 1,
                    PricePerNight = 87.80m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 102,
                    RoomTypeId = 2,
                    PricePerNight = 96.20m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 102,
                    RoomTypeId = 3,
                    PricePerNight = 104.80m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 102,
                    RoomTypeId = 4,
                    PricePerNight = 111.60m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 102,
                    RoomTypeId = 10,
                    PricePerNight = 23.70m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 103,
                    RoomTypeId = 1,
                    PricePerNight = 81.10m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 103,
                    RoomTypeId = 2,
                    PricePerNight = 88.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 103,
                    RoomTypeId = 3,
                    PricePerNight = 95.60m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 103,
                    RoomTypeId = 4,
                    PricePerNight = 102.30m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 103,
                    RoomTypeId = 10,
                    PricePerNight = 23.90m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 104,
                    RoomTypeId = 1,
                    PricePerNight = 81.60m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 104,
                    RoomTypeId = 2,
                    PricePerNight = 89.40m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 104,
                    RoomTypeId = 3,
                    PricePerNight = 95.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 104,
                    RoomTypeId = 4,
                    PricePerNight = 102.90m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 104,
                    RoomTypeId = 10,
                    PricePerNight = 23.10m
                },



                new HotelRoomTypePrice()
                {
                    HotelId = 105,
                    RoomTypeId = 1,
                    PricePerNight = 81.40m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 105,
                    RoomTypeId = 2,
                    PricePerNight = 89.40m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 105,
                    RoomTypeId = 3,
                    PricePerNight = 95.70m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 105,
                    RoomTypeId = 4,
                    PricePerNight = 102.40m
                },
                new HotelRoomTypePrice()
                {
                    HotelId = 105,
                    RoomTypeId = 10,
                    PricePerNight = 23.30m
                },
            });
        }
    }
}