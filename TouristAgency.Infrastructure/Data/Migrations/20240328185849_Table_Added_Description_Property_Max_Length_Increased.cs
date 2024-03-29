using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TouristAgency.Infrastructure.Migrations
{
    public partial class Table_Added_Description_Property_Max_Length_Increased : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookedOrganizedHolidays_OrganizedHolidayStartAndEndDates_OrganizedHolidayStartAndEndDateId",
                table: "BookedOrganizedHolidays");

            migrationBuilder.DropTable(
                name: "CruisesDestinations");

            migrationBuilder.DropTable(
                name: "OrganizedHolidayStartAndEndDates");

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 2, 10 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 1, 11 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 2, 11 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 3, 11 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 1, 12 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 2, 12 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 3, 12 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 1, 13 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 2, 13 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 3, 13 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 1, 14 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 2, 14 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 3, 14 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 1, 15 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 2, 15 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 3, 15 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 1, 16 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 2, 16 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 3, 16 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 1, 17 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 2, 17 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 3, 17 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 1, 18 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 2, 18 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 3, 18 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 1, 19 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 2, 19 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 3, 19 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 1, 20 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 1, 21 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 1, 22 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 1, 23 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 1, 24 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 1, 25 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 1, 26 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 1, 27 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 1, 28 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 1, 29 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 1, 30 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 1, 31 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 1, 32 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 1, 33 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 1, 34 });

            migrationBuilder.DeleteData(
                table: "UnorganizedOffersTransportTypesPrices",
                keyColumns: new[] { "TransportTypeId", "UnorganizedOfferId" },
                keyValues: new object[] { 1, 35 });

            migrationBuilder.RenameColumn(
                name: "OrganizedHolidayStartAndEndDateId",
                table: "BookedOrganizedHolidays",
                newName: "OrganizedOfferStartAndEndDateId");

            migrationBuilder.RenameIndex(
                name: "IX_BookedOrganizedHolidays_OrganizedHolidayStartAndEndDateId",
                table: "BookedOrganizedHolidays",
                newName: "IX_BookedOrganizedHolidays_OrganizedOfferStartAndEndDateId");

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Reviews",
                type: "nvarchar(1600)",
                maxLength: 1600,
                nullable: false,
                comment: "Content of review",
                oldClrType: typeof(string),
                oldType: "nvarchar(800)",
                oldMaxLength: 800,
                oldComment: "Content of review");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "OrganizedOfferDays",
                type: "nvarchar(3000)",
                maxLength: 3000,
                nullable: false,
                comment: "Description of day",
                oldClrType: typeof(string),
                oldType: "nvarchar(800)",
                oldMaxLength: 800,
                oldComment: "Description of day");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Destinations",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                comment: "Description of destination",
                oldClrType: typeof(string),
                oldType: "nvarchar(800)",
                oldMaxLength: 800,
                oldComment: "Description of destination");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "CruiseDays",
                type: "nvarchar(3000)",
                maxLength: 3000,
                nullable: false,
                comment: "Description of current day",
                oldClrType: typeof(string),
                oldType: "nvarchar(800)",
                oldMaxLength: 800,
                oldComment: "Description of current day");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Activities",
                type: "nvarchar(3000)",
                maxLength: 3000,
                nullable: false,
                comment: "Description of activity",
                oldClrType: typeof(string),
                oldType: "nvarchar(800)",
                oldMaxLength: 800,
                oldComment: "Description of activity");

            migrationBuilder.CreateTable(
                name: "OrganizedOfferStartAndEndDates",
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
                    table.PrimaryKey("PK_OrganizedOfferStartAndEndDates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrganizedOfferStartAndEndDates_OrganizedOffers_OrganizedHolidayId",
                        column: x => x.OrganizedHolidayId,
                        principalTable: "OrganizedOffers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "This entity contains the start and end date of an organizedHoliday");

            migrationBuilder.CreateTable(
                name: "PassByDestinations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "PassByDestination identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false, comment: "Name of destination"),
                    CountryId = table.Column<int>(type: "int", nullable: false, comment: "Country identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PassByDestinations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PassByDestinations_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "This entity shows destinations through which cruises pass by");

            migrationBuilder.CreateTable(
                name: "CruisesPassByDestinations",
                columns: table => new
                {
                    CruiseId = table.Column<int>(type: "int", nullable: false, comment: "Cruise identifier"),
                    PassByDestinationId = table.Column<int>(type: "int", nullable: false, comment: "Destination identifier"),
                    PositionOfDestination = table.Column<int>(type: "int", nullable: false, comment: "Signifies turn of visiting this destination during the whole cruise"),
                    DestinationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CruisesPassByDestinations", x => new { x.CruiseId, x.PassByDestinationId });
                    table.ForeignKey(
                        name: "FK_CruisesPassByDestinations_Cruises_CruiseId",
                        column: x => x.CruiseId,
                        principalTable: "Cruises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CruisesPassByDestinations_Destinations_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "Destinations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CruisesPassByDestinations_PassByDestinations_PassByDestinationId",
                        column: x => x.PassByDestinationId,
                        principalTable: "PassByDestinations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "This table shows the destination through which cruises pass by");

            migrationBuilder.CreateIndex(
                name: "IX_CruisesPassByDestinations_DestinationId",
                table: "CruisesPassByDestinations",
                column: "DestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_CruisesPassByDestinations_PassByDestinationId",
                table: "CruisesPassByDestinations",
                column: "PassByDestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizedOfferStartAndEndDates_OrganizedHolidayId",
                table: "OrganizedOfferStartAndEndDates",
                column: "OrganizedHolidayId");

            migrationBuilder.CreateIndex(
                name: "IX_PassByDestinations_CountryId",
                table: "PassByDestinations",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookedOrganizedHolidays_OrganizedOfferStartAndEndDates_OrganizedOfferStartAndEndDateId",
                table: "BookedOrganizedHolidays",
                column: "OrganizedOfferStartAndEndDateId",
                principalTable: "OrganizedOfferStartAndEndDates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookedOrganizedHolidays_OrganizedOfferStartAndEndDates_OrganizedOfferStartAndEndDateId",
                table: "BookedOrganizedHolidays");

            migrationBuilder.DropTable(
                name: "CruisesPassByDestinations");

            migrationBuilder.DropTable(
                name: "OrganizedOfferStartAndEndDates");

            migrationBuilder.DropTable(
                name: "PassByDestinations");

            migrationBuilder.RenameColumn(
                name: "OrganizedOfferStartAndEndDateId",
                table: "BookedOrganizedHolidays",
                newName: "OrganizedHolidayStartAndEndDateId");

            migrationBuilder.RenameIndex(
                name: "IX_BookedOrganizedHolidays_OrganizedOfferStartAndEndDateId",
                table: "BookedOrganizedHolidays",
                newName: "IX_BookedOrganizedHolidays_OrganizedHolidayStartAndEndDateId");

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Reviews",
                type: "nvarchar(800)",
                maxLength: 800,
                nullable: false,
                comment: "Content of review",
                oldClrType: typeof(string),
                oldType: "nvarchar(1600)",
                oldMaxLength: 1600,
                oldComment: "Content of review");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "OrganizedOfferDays",
                type: "nvarchar(800)",
                maxLength: 800,
                nullable: false,
                comment: "Description of day",
                oldClrType: typeof(string),
                oldType: "nvarchar(3000)",
                oldMaxLength: 3000,
                oldComment: "Description of day");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Destinations",
                type: "nvarchar(800)",
                maxLength: 800,
                nullable: false,
                comment: "Description of destination",
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldComment: "Description of destination");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "CruiseDays",
                type: "nvarchar(800)",
                maxLength: 800,
                nullable: false,
                comment: "Description of current day",
                oldClrType: typeof(string),
                oldType: "nvarchar(3000)",
                oldMaxLength: 3000,
                oldComment: "Description of current day");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Activities",
                type: "nvarchar(800)",
                maxLength: 800,
                nullable: false,
                comment: "Description of activity",
                oldClrType: typeof(string),
                oldType: "nvarchar(3000)",
                oldMaxLength: 3000,
                oldComment: "Description of activity");

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
                name: "OrganizedHolidayStartAndEndDates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "OrganizedHolidayStartAndEndDate identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrganizedHolidayId = table.Column<int>(type: "int", nullable: false, comment: "OrganizedHoliday identifier"),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date of coming back from the trip"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date of setting off for the trip")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizedHolidayStartAndEndDates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrganizedHolidayStartAndEndDates_OrganizedOffers_OrganizedHolidayId",
                        column: x => x.OrganizedHolidayId,
                        principalTable: "OrganizedOffers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "This entity contains the start and end date of an organizedHoliday");

            migrationBuilder.InsertData(
                table: "UnorganizedOffersTransportTypesPrices",
                columns: new[] { "TransportTypeId", "UnorganizedOfferId", "Price" },
                values: new object[,]
                {
                    { 2, 1, 40m },
                    { 3, 1, 0m },
                    { 1, 2, 400m },
                    { 1, 3, 450m },
                    { 1, 4, 225m },
                    { 1, 5, 500m },
                    { 2, 5, 150m },
                    { 3, 5, 0m },
                    { 1, 6, 500m },
                    { 1, 7, 525m },
                    { 1, 8, 550m },
                    { 2, 8, 210m },
                    { 3, 8, 0m },
                    { 1, 9, 600m },
                    { 2, 9, 240m },
                    { 3, 9, 0m },
                    { 1, 10, 700m },
                    { 2, 10, 280m },
                    { 3, 10, 0m },
                    { 1, 11, 650m },
                    { 2, 11, 300m },
                    { 3, 11, 0m },
                    { 1, 12, 670m },
                    { 2, 12, 310m },
                    { 3, 12, 0m },
                    { 1, 13, 680m },
                    { 2, 13, 295m },
                    { 3, 13, 0m },
                    { 1, 14, 320m },
                    { 2, 14, 110m },
                    { 3, 14, 0m },
                    { 1, 15, 250m },
                    { 2, 15, 95m },
                    { 3, 15, 0m },
                    { 1, 16, 310m },
                    { 2, 16, 105m },
                    { 3, 16, 0m },
                    { 1, 17, 240m },
                    { 2, 17, 85m },
                    { 3, 17, 0m },
                    { 1, 18, 750m },
                    { 2, 18, 310m }
                });

            migrationBuilder.InsertData(
                table: "UnorganizedOffersTransportTypesPrices",
                columns: new[] { "TransportTypeId", "UnorganizedOfferId", "Price" },
                values: new object[,]
                {
                    { 3, 18, 0m },
                    { 1, 19, 200m },
                    { 2, 19, 70m },
                    { 3, 19, 0m },
                    { 1, 20, 1400m },
                    { 1, 21, 1320m },
                    { 1, 22, 1350m },
                    { 1, 23, 1380m },
                    { 1, 24, 1500m },
                    { 1, 25, 1490m },
                    { 1, 26, 1200m },
                    { 1, 27, 1440m },
                    { 1, 28, 1400m },
                    { 1, 29, 1300m },
                    { 1, 30, 480m },
                    { 1, 31, 490m },
                    { 1, 32, 500m },
                    { 1, 33, 880m },
                    { 1, 34, 680m },
                    { 1, 35, 650m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CruisesDestinations_DestinationId",
                table: "CruisesDestinations",
                column: "DestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizedHolidayStartAndEndDates_OrganizedHolidayId",
                table: "OrganizedHolidayStartAndEndDates",
                column: "OrganizedHolidayId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookedOrganizedHolidays_OrganizedHolidayStartAndEndDates_OrganizedHolidayStartAndEndDateId",
                table: "BookedOrganizedHolidays",
                column: "OrganizedHolidayStartAndEndDateId",
                principalTable: "OrganizedHolidayStartAndEndDates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
