using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TouristAgency.Infrastructure.Migrations
{
    public partial class Database_Structure_Created : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                },
                comment: "Extended IdentityRole");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, comment: "First name of user"),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, comment: "Last name of user"),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                },
                comment: "Extended IdentityUser");

            migrationBuilder.CreateTable(
                name: "Continents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Continent table identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, comment: "Continent name")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Continents", x => x.Id);
                },
                comment: "Table about continents we make trips in");

            migrationBuilder.CreateTable(
                name: "CruiseRoomTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "CruiseRoomType identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Name of room type in cruise")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CruiseRoomTypes", x => x.Id);
                },
                comment: "This table shows what kind of rooms there are in a cruise");

            migrationBuilder.CreateTable(
                name: "Cruises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Cruise identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Name of cruise"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Description of cruise"),
                    EmbarkDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date on which the cruise embarks"),
                    ReturnDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date on whic the cruise returns"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "Price of services in cruiuse excluding room price"),
                    MinPeopleNeeded = table.Column<int>(type: "int", nullable: false, comment: "Minumum people needed for the agency to make this trip happen"),
                    MaxPeople = table.Column<int>(type: "int", nullable: false, comment: "Maximum people which the agency can take"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, comment: "Shows if the cruise is available")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cruises", x => x.Id);
                },
                comment: "This table shows cruises the agency has to offer");

            migrationBuilder.CreateTable(
                name: "RoomTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "RoomType identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Name of RoomType")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomTypes", x => x.Id);
                },
                comment: "This table shows what kind of rooms the agency can offer");

            migrationBuilder.CreateTable(
                name: "Tours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Tour identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false, comment: "Name of tour"),
                    Description = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false, comment: "Description of tour")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tours", x => x.Id);
                },
                comment: "This entity shows the tour conducted in the given trip");

            migrationBuilder.CreateTable(
                name: "TransportTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "TransportType identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, comment: "Name of transport")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportTypes", x => x.Id);
                },
                comment: "This table shows what type of transport is availabe for a specific offer");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Country identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false, comment: "Country name"),
                    ContinentId = table.Column<int>(type: "int", nullable: false, comment: "Continent identifier of country")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Countries_Continents_ContinentId",
                        column: x => x.ContinentId,
                        principalTable: "Continents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Countries that we make trips in");

            migrationBuilder.CreateTable(
                name: "BookedCruises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "BookedCruise identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CruiseId = table.Column<int>(type: "int", nullable: false, comment: "Cruise identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookedCruises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookedCruises_Cruises_CruiseId",
                        column: x => x.CruiseId,
                        principalTable: "Cruises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "This entity shows the booked cruise with the number of booked rooms");

            migrationBuilder.CreateTable(
                name: "CruiseDays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "CruiseDay identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DayNumber = table.Column<int>(type: "int", nullable: false, comment: "Number of day"),
                    Description = table.Column<string>(type: "nvarchar(800)", maxLength: 800, nullable: false, comment: "Description of current day"),
                    CruiseId = table.Column<int>(type: "int", nullable: false, comment: "Cruise identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CruiseDays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CruiseDays_Cruises_CruiseId",
                        column: x => x.CruiseId,
                        principalTable: "Cruises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "This entity shows the description of a single day in a cruise vacation");

            migrationBuilder.CreateTable(
                name: "CruiseRoomTypesCruisesPrices",
                columns: table => new
                {
                    CruiseId = table.Column<int>(type: "int", nullable: false, comment: "Cruise identifier"),
                    CruiseRoomTypeId = table.Column<int>(type: "int", nullable: false, comment: "CruiseRoomTypeIdentifier"),
                    PricePerNight = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "Price of room per night")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CruiseRoomTypesCruisesPrices", x => new { x.CruiseRoomTypeId, x.CruiseId });
                    table.ForeignKey(
                        name: "FK_CruiseRoomTypesCruisesPrices_CruiseRoomTypes_CruiseRoomTypeId",
                        column: x => x.CruiseRoomTypeId,
                        principalTable: "CruiseRoomTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CruiseRoomTypesCruisesPrices_Cruises_CruiseId",
                        column: x => x.CruiseId,
                        principalTable: "Cruises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "This table shows the price of room in a cruise");

            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Activity identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false, comment: "Name of activity"),
                    Description = table.Column<string>(type: "nvarchar(800)", maxLength: 800, nullable: false, comment: "Description of activity"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "Price of activity"),
                    MinPeopleNeeded = table.Column<int>(type: "int", nullable: false, comment: "Minumum amount of people needed for the activity to be made"),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false, comment: "Shows if the activity is currently available for the tour"),
                    TourId = table.Column<int>(type: "int", nullable: false, comment: "Tour identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Activities_Tours_TourId",
                        column: x => x.TourId,
                        principalTable: "Tours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "This entity shows the activiy made in the tour");

            migrationBuilder.CreateTable(
                name: "Destinations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Destination identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false, comment: "Name of destination"),
                    Description = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false, comment: "Description of destination"),
                    CountryId = table.Column<int>(type: "int", nullable: false, comment: "Country identifier of destination")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Destinations_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "This table shows the destinations in which we make trips");

            migrationBuilder.CreateTable(
                name: "CruiseRoomTypesBookedCruises",
                columns: table => new
                {
                    CruiseRoomTypeId = table.Column<int>(type: "int", nullable: false, comment: "CruiseRoomType identifier"),
                    BookedCruiseId = table.Column<int>(type: "int", nullable: false, comment: "BookedCruise identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CruiseRoomTypesBookedCruises", x => new { x.CruiseRoomTypeId, x.BookedCruiseId });
                    table.ForeignKey(
                        name: "FK_CruiseRoomTypesBookedCruises_BookedCruises_BookedCruiseId",
                        column: x => x.BookedCruiseId,
                        principalTable: "BookedCruises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CruiseRoomTypesBookedCruises_CruiseRoomTypes_CruiseRoomTypeId",
                        column: x => x.CruiseRoomTypeId,
                        principalTable: "CruiseRoomTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "This entity shows how many rooms were booked for a give cruise");

            migrationBuilder.CreateTable(
                name: "CruisesDestinations",
                columns: table => new
                {
                    CruiseId = table.Column<int>(type: "int", nullable: false, comment: "Cruise identifier"),
                    DestinationId = table.Column<int>(type: "int", nullable: false, comment: "Destination identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CruisesDestinations", x => new { x.CruiseId, x.DestinationId });
                    table.ForeignKey(
                        name: "FK_CruisesDestinations_Cruises_CruiseId",
                        column: x => x.CruiseId,
                        principalTable: "Cruises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CruisesDestinations_Destinations_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "Destinations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "This table shows the destination through which cruises pass by");

            migrationBuilder.CreateTable(
                name: "Offers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Offer identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false, comment: "Name of offer"),
                    Discount = table.Column<float>(type: "real", nullable: true, comment: "Discount of offer available to only special users"),
                    DestinationId = table.Column<int>(type: "int", nullable: false, comment: "Identifier of destination in which is the offer"),
                    CanBeUnorganized = table.Column<bool>(type: "bit", nullable: false, comment: "Checks if the offer can be booked customly by the user"),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false, comment: "Checks if the offer is available for booking")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Offers_Destinations_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "Destinations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "This table shows what we offer for a given destination");

            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Hotel identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false, comment: "Name of Hotel"),
                    Location = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, comment: "Shows exact location of the hotel"),
                    OfferId = table.Column<int>(type: "int", nullable: false, comment: "Offer identifier, shows the current hotel for what offer is used")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hotels_Offers_OfferId",
                        column: x => x.OfferId,
                        principalTable: "Offers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "This table shows what hotels the agency has to present for a given offer");

            migrationBuilder.CreateTable(
                name: "OffersTransportTypesPrices",
                columns: table => new
                {
                    OfferId = table.Column<int>(type: "int", nullable: false, comment: "Offer identifier"),
                    TransportTypeId = table.Column<int>(type: "int", nullable: false, comment: "TransportType identifier"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "Price of transport in given offer")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OffersTransportTypesPrices", x => new { x.OfferId, x.TransportTypeId });
                    table.ForeignKey(
                        name: "FK_OffersTransportTypesPrices_Offers_OfferId",
                        column: x => x.OfferId,
                        principalTable: "Offers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OffersTransportTypesPrices_TransportTypes_TransportTypeId",
                        column: x => x.TransportTypeId,
                        principalTable: "TransportTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "This table shows the prices of different transports in different offers");

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Review identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Title of review"),
                    Content = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false, comment: "Content of review"),
                    DateOfWriting = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date of writing the review"),
                    ReviewerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Identifier of user who wrote the review(could be anonymous)"),
                    ReviewedTripId = table.Column<int>(type: "int", nullable: false, comment: "Identifier of trip which was reviewed"),
                    Discriminator = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Discriminator which will signalize which navigation property should be filled"),
                    OfferId = table.Column<int>(type: "int", nullable: true),
                    CruiseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_AspNetUsers_ReviewerId",
                        column: x => x.ReviewerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Cruises_CruiseId",
                        column: x => x.CruiseId,
                        principalTable: "Cruises",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reviews_Offers_OfferId",
                        column: x => x.OfferId,
                        principalTable: "Offers",
                        principalColumn: "Id");
                },
                comment: "Review written by an user about a trip");

            migrationBuilder.CreateTable(
                name: "HotelsRoomTypesPrices",
                columns: table => new
                {
                    HotelId = table.Column<int>(type: "int", nullable: false, comment: "Hotel identifier"),
                    RoomTypeId = table.Column<int>(type: "int", nullable: false, comment: "RoomType identifier"),
                    PricePerNight = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "Price of a roomType in a given hotel")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelsRoomTypesPrices", x => new { x.HotelId, x.RoomTypeId });
                    table.ForeignKey(
                        name: "FK_HotelsRoomTypesPrices_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HotelsRoomTypesPrices_RoomTypes_RoomTypeId",
                        column: x => x.RoomTypeId,
                        principalTable: "RoomTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "This table shows the price of a RoomType in a given hotel");

            migrationBuilder.CreateTable(
                name: "OrganizedHolidays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "OrganizedHoliday identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OfferId = table.Column<int>(type: "int", nullable: false, comment: "Offer identifier"),
                    TransportTypeId = table.Column<int>(type: "int", nullable: false, comment: "TransportType identifier"),
                    HotelId = table.Column<int>(type: "int", nullable: false, comment: "Hotel identifier"),
                    TourId = table.Column<int>(type: "int", nullable: false, comment: "Tour identifier"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "Price of OrganizedHoliday, it includes the hotel services price(excluding room price) and transport price. It does not include activities price"),
                    MinPeopleNeeded = table.Column<int>(type: "int", nullable: false, comment: "Minumum people needed for the organized holiday to be made"),
                    MaxPeople = table.Column<int>(type: "int", nullable: false, comment: "Max people which can go to the organized holiday"),
                    DayOneDescription = table.Column<string>(type: "nvarchar(800)", maxLength: 800, nullable: false, comment: "Description of the first day of the trip"),
                    LastDayDescription = table.Column<string>(type: "nvarchar(800)", maxLength: 800, nullable: false, comment: "Description of the last day of the trip"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, comment: "Shows if the organized holiday is available or not")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizedHolidays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrganizedHolidays_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrganizedHolidays_Offers_OfferId",
                        column: x => x.OfferId,
                        principalTable: "Offers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrganizedHolidays_Tours_TourId",
                        column: x => x.TourId,
                        principalTable: "Tours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrganizedHolidays_TransportTypes_TransportTypeId",
                        column: x => x.TransportTypeId,
                        principalTable: "TransportTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "This entity represents a trip which is organized by the agency");

            migrationBuilder.CreateTable(
                name: "UnorganizedHolidays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "UnorganizedHoliday identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OfferId = table.Column<int>(type: "int", nullable: false, comment: "Offer identifier related to current unorganizedHoliday"),
                    CheckInDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date of checking in the booked hotel"),
                    CheckOutDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date of checking out the booked hotel"),
                    TransportTypeId = table.Column<int>(type: "int", nullable: false, comment: "TransportType identifier"),
                    HotelId = table.Column<int>(type: "int", nullable: false, comment: "Hotel identifier for hotel in which the user(s) will be staying in"),
                    RoomTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnorganizedHolidays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UnorganizedHolidays_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UnorganizedHolidays_Offers_OfferId",
                        column: x => x.OfferId,
                        principalTable: "Offers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UnorganizedHolidays_RoomTypes_RoomTypeId",
                        column: x => x.RoomTypeId,
                        principalTable: "RoomTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UnorganizedHolidays_TransportTypes_TransportTypeId",
                        column: x => x.TransportTypeId,
                        principalTable: "TransportTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "These are holidays which don't have tours organized by the agency and the user chooses where to stay, when to go and what to do");

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Data = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    ReviewId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Image_Reviews_ReviewId",
                        column: x => x.ReviewId,
                        principalTable: "Reviews",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrganizedHolidayStartAndEndDates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "OrganizedHolidayStartAndEndDate identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrganizedHolidayId = table.Column<int>(type: "int", nullable: false, comment: "OrganizedHoliday identifier"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date of setting off for the trip"),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date of coming back from the trip")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizedHolidayStartAndEndDates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrganizedHolidayStartAndEndDates_OrganizedHolidays_OrganizedHolidayId",
                        column: x => x.OrganizedHolidayId,
                        principalTable: "OrganizedHolidays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "This entity contains the start and end date of an organizedHoliday");

            migrationBuilder.CreateTable(
                name: "UnorganizedHolidaysRoomTypes",
                columns: table => new
                {
                    UnorganizedHolidayId = table.Column<int>(type: "int", nullable: false, comment: "UnorganizedHoliday identifier"),
                    RoomTypeId = table.Column<int>(type: "int", nullable: false, comment: "RoopType identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnorganizedHolidaysRoomTypes", x => new { x.UnorganizedHolidayId, x.RoomTypeId });
                    table.ForeignKey(
                        name: "FK_UnorganizedHolidaysRoomTypes_RoomTypes_RoomTypeId",
                        column: x => x.RoomTypeId,
                        principalTable: "RoomTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UnorganizedHolidaysRoomTypes_UnorganizedHolidays_UnorganizedHolidayId",
                        column: x => x.UnorganizedHolidayId,
                        principalTable: "UnorganizedHolidays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "This entity shows how many rooms were booked for a certain trip");

            migrationBuilder.CreateTable(
                name: "BookedOrganizedHolidays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "BookedOrganizedHoliday identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrganizedHolidayStartAndEndDateId = table.Column<int>(type: "int", nullable: false, comment: "OrganizedHolidayStartAndEndDate identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookedOrganizedHolidays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookedOrganizedHolidays_OrganizedHolidayStartAndEndDates_OrganizedHolidayStartAndEndDateId",
                        column: x => x.OrganizedHolidayStartAndEndDateId,
                        principalTable: "OrganizedHolidayStartAndEndDates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "this entity shows the date, room type and signed activities for the trip");

            migrationBuilder.CreateTable(
                name: "ActivitiesBookedOrganizedHolidays",
                columns: table => new
                {
                    ActivityId = table.Column<int>(type: "int", nullable: false, comment: "Activity identifier"),
                    BookedOrganizedHolidayId = table.Column<int>(type: "int", nullable: false, comment: "BookedOrganizedHoliday identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivitiesBookedOrganizedHolidays", x => new { x.ActivityId, x.BookedOrganizedHolidayId });
                    table.ForeignKey(
                        name: "FK_ActivitiesBookedOrganizedHolidays_Activities_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ActivitiesBookedOrganizedHolidays_BookedOrganizedHolidays_BookedOrganizedHolidayId",
                        column: x => x.BookedOrganizedHolidayId,
                        principalTable: "BookedOrganizedHolidays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "This entity gives info about what activities are booked for the trip");

            migrationBuilder.CreateTable(
                name: "BookedOrganizedHolidaysRoomTypes",
                columns: table => new
                {
                    BookedOrganizedHolidayId = table.Column<int>(type: "int", nullable: false, comment: "BookedOrganizedHoliday identifier"),
                    RoomTypeId = table.Column<int>(type: "int", nullable: false, comment: "RoopType identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookedOrganizedHolidaysRoomTypes", x => new { x.BookedOrganizedHolidayId, x.RoomTypeId });
                    table.ForeignKey(
                        name: "FK_BookedOrganizedHolidaysRoomTypes_BookedOrganizedHolidays_BookedOrganizedHolidayId",
                        column: x => x.BookedOrganizedHolidayId,
                        principalTable: "BookedOrganizedHolidays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookedOrganizedHolidaysRoomTypes_RoomTypes_RoomTypeId",
                        column: x => x.RoomTypeId,
                        principalTable: "RoomTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "This entity shows how many rooms were booked for a trip");

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Booking identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Identifier of the person who makes the booking"),
                    TripId = table.Column<int>(type: "int", nullable: false, comment: "identifier of trip which shows details about the booking"),
                    TimeOfBooking = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Exact time of booking the trip"),
                    Discriminator = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Discriminator column which will show what kind of trip has been booked(OrganizedHoliday, UnorganizedHoliday, Cruise)"),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "Total price of the trip"),
                    BookingStatus = table.Column<int>(type: "int", nullable: false, comment: "Shows current status of the booking"),
                    PaymentId = table.Column<int>(type: "int", nullable: false, comment: "Payment identifier"),
                    PaymentStatus = table.Column<int>(type: "int", nullable: false, comment: "Shows if booking was payed or not"),
                    UnorganizedHolidayId = table.Column<int>(type: "int", nullable: true),
                    BookedOrganizedHolidayId = table.Column<int>(type: "int", nullable: true),
                    BookedCruiseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookings_AspNetUsers_BookerId",
                        column: x => x.BookerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bookings_BookedCruises_BookedCruiseId",
                        column: x => x.BookedCruiseId,
                        principalTable: "BookedCruises",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bookings_BookedOrganizedHolidays_BookedOrganizedHolidayId",
                        column: x => x.BookedOrganizedHolidayId,
                        principalTable: "BookedOrganizedHolidays",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bookings_UnorganizedHolidays_UnorganizedHolidayId",
                        column: x => x.UnorganizedHolidayId,
                        principalTable: "UnorganizedHolidays",
                        principalColumn: "Id");
                },
                comment: "This entity shows the whole information about a booking");

            migrationBuilder.CreateTable(
                name: "AdditionalPeople",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "AdditionalPerson identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "First name of additonal person"),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Last name of additonal person"),
                    BookingId = table.Column<int>(type: "int", nullable: false, comment: "Booking identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalPeople", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdditionalPeople_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "This entity shows information about additional people signed for a booking");

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Payment identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true, comment: "Paid amount"),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Date of payment"),
                    PaymentMethod = table.Column<int>(type: "int", nullable: false, comment: "Method of paying(cash or debit card)"),
                    BookingId = table.Column<int>(type: "int", nullable: false, comment: "Booking identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "This entity shows payment details");

            migrationBuilder.CreateIndex(
                name: "IX_Activities_TourId",
                table: "Activities",
                column: "TourId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivitiesBookedOrganizedHolidays_BookedOrganizedHolidayId",
                table: "ActivitiesBookedOrganizedHolidays",
                column: "BookedOrganizedHolidayId");

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalPeople_BookingId",
                table: "AdditionalPeople",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BookedCruises_CruiseId",
                table: "BookedCruises",
                column: "CruiseId");

            migrationBuilder.CreateIndex(
                name: "IX_BookedOrganizedHolidays_OrganizedHolidayStartAndEndDateId",
                table: "BookedOrganizedHolidays",
                column: "OrganizedHolidayStartAndEndDateId");

            migrationBuilder.CreateIndex(
                name: "IX_BookedOrganizedHolidaysRoomTypes_RoomTypeId",
                table: "BookedOrganizedHolidaysRoomTypes",
                column: "RoomTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_BookedCruiseId",
                table: "Bookings",
                column: "BookedCruiseId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_BookedOrganizedHolidayId",
                table: "Bookings",
                column: "BookedOrganizedHolidayId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_BookerId",
                table: "Bookings",
                column: "BookerId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_UnorganizedHolidayId",
                table: "Bookings",
                column: "UnorganizedHolidayId");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_ContinentId",
                table: "Countries",
                column: "ContinentId");

            migrationBuilder.CreateIndex(
                name: "IX_CruiseDays_CruiseId",
                table: "CruiseDays",
                column: "CruiseId");

            migrationBuilder.CreateIndex(
                name: "IX_CruiseRoomTypesBookedCruises_BookedCruiseId",
                table: "CruiseRoomTypesBookedCruises",
                column: "BookedCruiseId");

            migrationBuilder.CreateIndex(
                name: "IX_CruiseRoomTypesCruisesPrices_CruiseId",
                table: "CruiseRoomTypesCruisesPrices",
                column: "CruiseId");

            migrationBuilder.CreateIndex(
                name: "IX_CruisesDestinations_DestinationId",
                table: "CruisesDestinations",
                column: "DestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_Destinations_CountryId",
                table: "Destinations",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_OfferId",
                table: "Hotels",
                column: "OfferId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelsRoomTypesPrices_RoomTypeId",
                table: "HotelsRoomTypesPrices",
                column: "RoomTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Image_ReviewId",
                table: "Image",
                column: "ReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_Offers_DestinationId",
                table: "Offers",
                column: "DestinationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OffersTransportTypesPrices_TransportTypeId",
                table: "OffersTransportTypesPrices",
                column: "TransportTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizedHolidays_HotelId",
                table: "OrganizedHolidays",
                column: "HotelId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrganizedHolidays_OfferId",
                table: "OrganizedHolidays",
                column: "OfferId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrganizedHolidays_TourId",
                table: "OrganizedHolidays",
                column: "TourId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrganizedHolidays_TransportTypeId",
                table: "OrganizedHolidays",
                column: "TransportTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizedHolidayStartAndEndDates_OrganizedHolidayId",
                table: "OrganizedHolidayStartAndEndDates",
                column: "OrganizedHolidayId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_BookingId",
                table: "Payments",
                column: "BookingId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_CruiseId",
                table: "Reviews",
                column: "CruiseId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_OfferId",
                table: "Reviews",
                column: "OfferId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ReviewerId",
                table: "Reviews",
                column: "ReviewerId");

            migrationBuilder.CreateIndex(
                name: "IX_UnorganizedHolidays_HotelId",
                table: "UnorganizedHolidays",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_UnorganizedHolidays_OfferId",
                table: "UnorganizedHolidays",
                column: "OfferId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UnorganizedHolidays_RoomTypeId",
                table: "UnorganizedHolidays",
                column: "RoomTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_UnorganizedHolidays_TransportTypeId",
                table: "UnorganizedHolidays",
                column: "TransportTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_UnorganizedHolidaysRoomTypes_RoomTypeId",
                table: "UnorganizedHolidaysRoomTypes",
                column: "RoomTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivitiesBookedOrganizedHolidays");

            migrationBuilder.DropTable(
                name: "AdditionalPeople");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BookedOrganizedHolidaysRoomTypes");

            migrationBuilder.DropTable(
                name: "CruiseDays");

            migrationBuilder.DropTable(
                name: "CruiseRoomTypesBookedCruises");

            migrationBuilder.DropTable(
                name: "CruiseRoomTypesCruisesPrices");

            migrationBuilder.DropTable(
                name: "CruisesDestinations");

            migrationBuilder.DropTable(
                name: "HotelsRoomTypesPrices");

            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropTable(
                name: "OffersTransportTypesPrices");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "UnorganizedHolidaysRoomTypes");

            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "CruiseRoomTypes");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "BookedCruises");

            migrationBuilder.DropTable(
                name: "BookedOrganizedHolidays");

            migrationBuilder.DropTable(
                name: "UnorganizedHolidays");

            migrationBuilder.DropTable(
                name: "Cruises");

            migrationBuilder.DropTable(
                name: "OrganizedHolidayStartAndEndDates");

            migrationBuilder.DropTable(
                name: "RoomTypes");

            migrationBuilder.DropTable(
                name: "OrganizedHolidays");

            migrationBuilder.DropTable(
                name: "Hotels");

            migrationBuilder.DropTable(
                name: "Tours");

            migrationBuilder.DropTable(
                name: "TransportTypes");

            migrationBuilder.DropTable(
                name: "Offers");

            migrationBuilder.DropTable(
                name: "Destinations");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Continents");
        }
    }
}
