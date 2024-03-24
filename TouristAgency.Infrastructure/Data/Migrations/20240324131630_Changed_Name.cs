using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TouristAgency.Infrastructure.Migrations
{
    public partial class Changed_Name : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrganizedHolidays_Destinations_DestinationId",
                table: "OrganizedHolidays");

            migrationBuilder.DropForeignKey(
                name: "FK_OrganizedHolidays_Hotels_HotelId",
                table: "OrganizedHolidays");

            migrationBuilder.DropForeignKey(
                name: "FK_OrganizedHolidays_Tours_TourId",
                table: "OrganizedHolidays");

            migrationBuilder.DropForeignKey(
                name: "FK_OrganizedHolidays_TransportTypes_TransportTypeId",
                table: "OrganizedHolidays");

            migrationBuilder.DropForeignKey(
                name: "FK_OrganizedHolidayStartAndEndDates_OrganizedHolidays_OrganizedHolidayId",
                table: "OrganizedHolidayStartAndEndDates");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_OrganizedHolidays_OrganizedHolidayId",
                table: "Reviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrganizedHolidays",
                table: "OrganizedHolidays");

            migrationBuilder.RenameTable(
                name: "OrganizedHolidays",
                newName: "OrganizedOffers");

            migrationBuilder.RenameColumn(
                name: "discount",
                table: "OrganizedOffers",
                newName: "Discount");

            migrationBuilder.RenameIndex(
                name: "IX_OrganizedHolidays_TransportTypeId",
                table: "OrganizedOffers",
                newName: "IX_OrganizedOffers_TransportTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_OrganizedHolidays_TourId",
                table: "OrganizedOffers",
                newName: "IX_OrganizedOffers_TourId");

            migrationBuilder.RenameIndex(
                name: "IX_OrganizedHolidays_HotelId",
                table: "OrganizedOffers",
                newName: "IX_OrganizedOffers_HotelId");

            migrationBuilder.RenameIndex(
                name: "IX_OrganizedHolidays_DestinationId",
                table: "OrganizedOffers",
                newName: "IX_OrganizedOffers_DestinationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrganizedOffers",
                table: "OrganizedOffers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrganizedHolidayStartAndEndDates_OrganizedOffers_OrganizedHolidayId",
                table: "OrganizedHolidayStartAndEndDates",
                column: "OrganizedHolidayId",
                principalTable: "OrganizedOffers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrganizedOffers_Destinations_DestinationId",
                table: "OrganizedOffers",
                column: "DestinationId",
                principalTable: "Destinations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrganizedOffers_Hotels_HotelId",
                table: "OrganizedOffers",
                column: "HotelId",
                principalTable: "Hotels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrganizedOffers_Tours_TourId",
                table: "OrganizedOffers",
                column: "TourId",
                principalTable: "Tours",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrganizedOffers_TransportTypes_TransportTypeId",
                table: "OrganizedOffers",
                column: "TransportTypeId",
                principalTable: "TransportTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_OrganizedOffers_OrganizedHolidayId",
                table: "Reviews",
                column: "OrganizedHolidayId",
                principalTable: "OrganizedOffers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrganizedHolidayStartAndEndDates_OrganizedOffers_OrganizedHolidayId",
                table: "OrganizedHolidayStartAndEndDates");

            migrationBuilder.DropForeignKey(
                name: "FK_OrganizedOffers_Destinations_DestinationId",
                table: "OrganizedOffers");

            migrationBuilder.DropForeignKey(
                name: "FK_OrganizedOffers_Hotels_HotelId",
                table: "OrganizedOffers");

            migrationBuilder.DropForeignKey(
                name: "FK_OrganizedOffers_Tours_TourId",
                table: "OrganizedOffers");

            migrationBuilder.DropForeignKey(
                name: "FK_OrganizedOffers_TransportTypes_TransportTypeId",
                table: "OrganizedOffers");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_OrganizedOffers_OrganizedHolidayId",
                table: "Reviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrganizedOffers",
                table: "OrganizedOffers");

            migrationBuilder.RenameTable(
                name: "OrganizedOffers",
                newName: "OrganizedHolidays");

            migrationBuilder.RenameColumn(
                name: "Discount",
                table: "OrganizedHolidays",
                newName: "discount");

            migrationBuilder.RenameIndex(
                name: "IX_OrganizedOffers_TransportTypeId",
                table: "OrganizedHolidays",
                newName: "IX_OrganizedHolidays_TransportTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_OrganizedOffers_TourId",
                table: "OrganizedHolidays",
                newName: "IX_OrganizedHolidays_TourId");

            migrationBuilder.RenameIndex(
                name: "IX_OrganizedOffers_HotelId",
                table: "OrganizedHolidays",
                newName: "IX_OrganizedHolidays_HotelId");

            migrationBuilder.RenameIndex(
                name: "IX_OrganizedOffers_DestinationId",
                table: "OrganizedHolidays",
                newName: "IX_OrganizedHolidays_DestinationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrganizedHolidays",
                table: "OrganizedHolidays",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrganizedHolidays_Destinations_DestinationId",
                table: "OrganizedHolidays",
                column: "DestinationId",
                principalTable: "Destinations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrganizedHolidays_Hotels_HotelId",
                table: "OrganizedHolidays",
                column: "HotelId",
                principalTable: "Hotels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrganizedHolidays_Tours_TourId",
                table: "OrganizedHolidays",
                column: "TourId",
                principalTable: "Tours",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrganizedHolidays_TransportTypes_TransportTypeId",
                table: "OrganizedHolidays",
                column: "TransportTypeId",
                principalTable: "TransportTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrganizedHolidayStartAndEndDates_OrganizedHolidays_OrganizedHolidayId",
                table: "OrganizedHolidayStartAndEndDates",
                column: "OrganizedHolidayId",
                principalTable: "OrganizedHolidays",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_OrganizedHolidays_OrganizedHolidayId",
                table: "Reviews",
                column: "OrganizedHolidayId",
                principalTable: "OrganizedHolidays",
                principalColumn: "Id");
        }
    }
}
