using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TouristAgency.Infrastructure.Migrations
{
    public partial class Added_Columns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Number",
                table: "UnorganizedHolidaysRoomTypes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Number of booked rooms of current room type");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "RoomTypes",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: false,
                defaultValue: "",
                comment: "Description of RoomType");

            migrationBuilder.AddColumn<int>(
                name: "Number",
                table: "CruiseRoomTypesBookedCruises",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Number of booked rooms of current room type");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "CruiseRoomTypes",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: false,
                defaultValue: "",
                comment: "Description of CruiseRoomType");

            migrationBuilder.AddColumn<int>(
                name: "Number",
                table: "BookedOrganizedHolidaysRoomTypes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Number of booked rooms of current room type");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Number",
                table: "UnorganizedHolidaysRoomTypes");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "RoomTypes");

            migrationBuilder.DropColumn(
                name: "Number",
                table: "CruiseRoomTypesBookedCruises");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "CruiseRoomTypes");

            migrationBuilder.DropColumn(
                name: "Number",
                table: "BookedOrganizedHolidaysRoomTypes");
        }
    }
}
