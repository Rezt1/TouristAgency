﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TouristAgency.Infrastructure.Data.Configurations;
using TouristAgency.Infrastructure.Data.Models.MssqlModels;

namespace TouristAgency.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Activity> Activities { get; set; } = null!;

        public DbSet<ActivityBookedOrganizedHoliday> ActivitiesBookedOrganizedHolidays { get; set; } = null!;

        public DbSet<AdditionalPerson> AdditionalPeople { get; set; } = null!;

        public DbSet<BookedCruise> BookedCruises { get; set; } = null!;

        public DbSet<BookedOrganizedHoliday> BookedOrganizedHolidays { get; set; } = null!;

        public DbSet<BookedOrganizedHolidayRoomType> BookedOrganizedHolidaysRoomTypes { get; set; } = null!;

        public DbSet<Booking> Bookings { get; set; } = null!;

        public DbSet<Continent> Continents { get; set; } = null!;

        public DbSet<Country> Countries { get; set; } = null!;

        public DbSet<Cruise> Cruises { get; set; } = null!;

        public DbSet<CruiseDay> CruiseDays { get; set; } = null!;

        public DbSet<CruisePassByDestination> CruisesPassByDestinations { get; set; } = null!;

        public DbSet<CruiseRoomType> CruiseRoomTypes { get; set; } = null!;

        public DbSet<CruiseRoomTypeBookedCruise> CruiseRoomTypesBookedCruises { get; set; } = null!;

        public DbSet<CruiseRoomTypeCruisePrice> CruiseRoomTypesCruisesPrices { get; set; } = null!;

        public DbSet<Destination> Destinations { get; set; } = null!;

        public DbSet<Hotel> Hotels { get; set; } = null!;

        public DbSet<HotelRoomTypePrice> HotelsRoomTypesPrices { get; set; } = null!;

        public DbSet<UnorganizedOffer> UnorganizedOffers { get; set; } = null!;

        public DbSet<UnorganizedOfferTransportTypePrice> UnorganizedOffersTransportTypesPrices { get; set; } = null!;

        public DbSet<OrganizedOffer> OrganizedOffers { get; set; } = null!;

        public DbSet<OrganizedOfferStartAndEndDate> OrganizedOfferStartAndEndDates { get; set; } = null!;

        public DbSet<Payment> Payments { get; set; } = null!;

        public DbSet<Review> Reviews { get; set; } = null!;

        public DbSet<RoomType> RoomTypes { get; set; } = null!;

        public DbSet<TransportType> TransportTypes { get; set; } = null!;

        public DbSet<UnorganizedHoliday> UnorganizedHolidays { get; set; } = null!;

        public DbSet<UnorganizedHolidayRoomType> UnorganizedHolidaysRoomTypes { get; set; } = null!;

        public DbSet<OrganizedOfferDay> OrganizedOfferDays { get; set; } = null!;

        public DbSet<PassByDestination> PassByDestinations { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ContinentConfiguration());
            builder.ApplyConfiguration(new CountryConfiguration());
            builder.ApplyConfiguration(new DestinationConfiguration());
            builder.ApplyConfiguration(new UnorganizedOfferConfiguration());
            builder.ApplyConfiguration(new TransportTypeConfiguration());
            builder.ApplyConfiguration(new UnorganizedOfferTransportTypePriceConfiguration());
            builder.ApplyConfiguration(new HotelConfiguration());
            builder.ApplyConfiguration(new RoomTypeConfiguration());
            builder.ApplyConfiguration(new HotelRoomTypePriceConfiguration());
            builder.ApplyConfiguration(new OrganizedOfferConfiguration());
            builder.ApplyConfiguration(new ActivityConfiguration());
            builder.ApplyConfiguration(new OrganizedOfferDayConfiguration());
            builder.ApplyConfiguration(new OrganizedOfferStartAndEndDateConfiguration());
            builder.ApplyConfiguration(new PassByDestinationConfiguration());
            builder.ApplyConfiguration(new CruiseRoomTypeConfiguration());
            builder.ApplyConfiguration(new CruiseConfiguration());
            builder.ApplyConfiguration(new CruiseRoomTypeCruisePriceConfiguration());
            builder.ApplyConfiguration(new CruisePassByDestinationConfiguration());
            builder.ApplyConfiguration(new CruiseDayConfiguration());
            builder.ApplyConfiguration(new ActivityBookedOrganizedHolidayConfiguration());
            builder.ApplyConfiguration(new BookedOrganizedHolidayRoomTypeConfiguration());
            builder.ApplyConfiguration(new BookingConfiguration());
            builder.ApplyConfiguration(new CruiseRoomTypeBookedCruiseConfiguration());
            builder.ApplyConfiguration(new OrganizedHolidayConfiguration());
            builder.ApplyConfiguration(new ReviewConfiguration());
            builder.ApplyConfiguration(new UnorganizedHolidayConfiguration());
            builder.ApplyConfiguration(new UnorganizedHolidayRoomTypeConfiguration());
            builder.ApplyConfiguration(new AspNetRoleConfiguration());
            builder.ApplyConfiguration(new AspNetUserConfiguration());
            builder.ApplyConfiguration(new AspNetUserRoleConfiguration());

            base.OnModelCreating(builder);
        }
    }
}