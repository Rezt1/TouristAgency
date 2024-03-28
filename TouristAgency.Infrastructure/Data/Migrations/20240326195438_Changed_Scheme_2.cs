using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TouristAgency.Infrastructure.Migrations
{
    public partial class Changed_Scheme_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activities_Tours_TourId",
                table: "Activities");

            migrationBuilder.DropForeignKey(
                name: "FK_OffersTransportTypesPrices_TransportTypes_TransportTypeId",
                table: "OffersTransportTypesPrices");

            migrationBuilder.DropForeignKey(
                name: "FK_OffersTransportTypesPrices_UnorganizedOffers_UnorganizedOfferId",
                table: "OffersTransportTypesPrices");

            migrationBuilder.DropForeignKey(
                name: "FK_OrganizedOffers_Tours_TourId",
                table: "OrganizedOffers");

            migrationBuilder.DropTable(
                name: "Tours");

            migrationBuilder.DropIndex(
                name: "IX_OrganizedOffers_TourId",
                table: "OrganizedOffers");

            migrationBuilder.DropIndex(
                name: "IX_Activities_TourId",
                table: "Activities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OffersTransportTypesPrices",
                table: "OffersTransportTypesPrices");

            migrationBuilder.DropColumn(
                name: "DayOneDescription",
                table: "OrganizedOffers");

            migrationBuilder.DropColumn(
                name: "LastDayDescription",
                table: "OrganizedOffers");

            migrationBuilder.DropColumn(
                name: "TourId",
                table: "OrganizedOffers");

            migrationBuilder.DropColumn(
                name: "IsAvailable",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "TourId",
                table: "Activities");

            migrationBuilder.RenameTable(
                name: "OffersTransportTypesPrices",
                newName: "UnorganizedOffersTransportTypesPrices");

            migrationBuilder.RenameIndex(
                name: "IX_OffersTransportTypesPrices_TransportTypeId",
                table: "UnorganizedOffersTransportTypesPrices",
                newName: "IX_UnorganizedOffersTransportTypesPrices_TransportTypeId");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "RoomTypes",
                type: "nvarchar(800)",
                maxLength: 800,
                nullable: false,
                comment: "Description of RoomType",
                oldClrType: typeof(string),
                oldType: "nvarchar(400)",
                oldMaxLength: 400,
                oldComment: "Description of RoomType");

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Reviews",
                type: "nvarchar(800)",
                maxLength: 800,
                nullable: false,
                comment: "Content of review",
                oldClrType: typeof(string),
                oldType: "nvarchar(400)",
                oldMaxLength: 400,
                oldComment: "Content of review");

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Hotels",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: false,
                comment: "Shows exact location of the hotel",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldComment: "Shows exact location of the hotel");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Destinations",
                type: "nvarchar(800)",
                maxLength: 800,
                nullable: false,
                comment: "Description of destination",
                oldClrType: typeof(string),
                oldType: "nvarchar(400)",
                oldMaxLength: 400,
                oldComment: "Description of destination");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "CruiseRoomTypes",
                type: "nvarchar(800)",
                maxLength: 800,
                nullable: false,
                comment: "Description of CruiseRoomType",
                oldClrType: typeof(string),
                oldType: "nvarchar(400)",
                oldMaxLength: 400,
                oldComment: "Description of CruiseRoomType");

            migrationBuilder.AddColumn<int>(
                name: "OrganizedOfferDayId",
                table: "Activities",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "OrganizedOfferDay identifier");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UnorganizedOffersTransportTypesPrices",
                table: "UnorganizedOffersTransportTypesPrices",
                columns: new[] { "UnorganizedOfferId", "TransportTypeId" });

            migrationBuilder.CreateTable(
                name: "OrganizedOfferDays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "OrganizedOffer identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DayNumber = table.Column<int>(type: "int", nullable: false, comment: "Number of day"),
                    Description = table.Column<string>(type: "nvarchar(800)", maxLength: 800, nullable: false, comment: "Description of day"),
                    ActivityId = table.Column<int>(type: "int", nullable: false, comment: "Activity identifier"),
                    OrganizedOfferId = table.Column<int>(type: "int", nullable: false, comment: "OrganizedOffer identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizedOfferDays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrganizedOfferDays_OrganizedOffers_OrganizedOfferId",
                        column: x => x.OrganizedOfferId,
                        principalTable: "OrganizedOffers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Entity showing what a day in an organized trip would look like");

            migrationBuilder.CreateIndex(
                name: "IX_Activities_OrganizedOfferDayId",
                table: "Activities",
                column: "OrganizedOfferDayId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrganizedOfferDays_OrganizedOfferId",
                table: "OrganizedOfferDays",
                column: "OrganizedOfferId");

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_OrganizedOfferDays_OrganizedOfferDayId",
                table: "Activities",
                column: "OrganizedOfferDayId",
                principalTable: "OrganizedOfferDays",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UnorganizedOffersTransportTypesPrices_TransportTypes_TransportTypeId",
                table: "UnorganizedOffersTransportTypesPrices",
                column: "TransportTypeId",
                principalTable: "TransportTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UnorganizedOffersTransportTypesPrices_UnorganizedOffers_UnorganizedOfferId",
                table: "UnorganizedOffersTransportTypesPrices",
                column: "UnorganizedOfferId",
                principalTable: "UnorganizedOffers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activities_OrganizedOfferDays_OrganizedOfferDayId",
                table: "Activities");

            migrationBuilder.DropForeignKey(
                name: "FK_UnorganizedOffersTransportTypesPrices_TransportTypes_TransportTypeId",
                table: "UnorganizedOffersTransportTypesPrices");

            migrationBuilder.DropForeignKey(
                name: "FK_UnorganizedOffersTransportTypesPrices_UnorganizedOffers_UnorganizedOfferId",
                table: "UnorganizedOffersTransportTypesPrices");

            migrationBuilder.DropTable(
                name: "OrganizedOfferDays");

            migrationBuilder.DropIndex(
                name: "IX_Activities_OrganizedOfferDayId",
                table: "Activities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UnorganizedOffersTransportTypesPrices",
                table: "UnorganizedOffersTransportTypesPrices");

            migrationBuilder.DropColumn(
                name: "OrganizedOfferDayId",
                table: "Activities");

            migrationBuilder.RenameTable(
                name: "UnorganizedOffersTransportTypesPrices",
                newName: "OffersTransportTypesPrices");

            migrationBuilder.RenameIndex(
                name: "IX_UnorganizedOffersTransportTypesPrices_TransportTypeId",
                table: "OffersTransportTypesPrices",
                newName: "IX_OffersTransportTypesPrices_TransportTypeId");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "RoomTypes",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: false,
                comment: "Description of RoomType",
                oldClrType: typeof(string),
                oldType: "nvarchar(800)",
                oldMaxLength: 800,
                oldComment: "Description of RoomType");

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Reviews",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: false,
                comment: "Content of review",
                oldClrType: typeof(string),
                oldType: "nvarchar(800)",
                oldMaxLength: 800,
                oldComment: "Content of review");

            migrationBuilder.AddColumn<string>(
                name: "DayOneDescription",
                table: "OrganizedOffers",
                type: "nvarchar(800)",
                maxLength: 800,
                nullable: false,
                defaultValue: "",
                comment: "Description of the first day of the trip");

            migrationBuilder.AddColumn<string>(
                name: "LastDayDescription",
                table: "OrganizedOffers",
                type: "nvarchar(800)",
                maxLength: 800,
                nullable: false,
                defaultValue: "",
                comment: "Description of the last day of the trip");

            migrationBuilder.AddColumn<int>(
                name: "TourId",
                table: "OrganizedOffers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Tour identifier");

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Hotels",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                comment: "Shows exact location of the hotel",
                oldClrType: typeof(string),
                oldType: "nvarchar(400)",
                oldMaxLength: 400,
                oldComment: "Shows exact location of the hotel");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Destinations",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: false,
                comment: "Description of destination",
                oldClrType: typeof(string),
                oldType: "nvarchar(800)",
                oldMaxLength: 800,
                oldComment: "Description of destination");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "CruiseRoomTypes",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: false,
                comment: "Description of CruiseRoomType",
                oldClrType: typeof(string),
                oldType: "nvarchar(800)",
                oldMaxLength: 800,
                oldComment: "Description of CruiseRoomType");

            migrationBuilder.AddColumn<bool>(
                name: "IsAvailable",
                table: "Activities",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Shows if the activity is currently available for the tour");

            migrationBuilder.AddColumn<int>(
                name: "TourId",
                table: "Activities",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Tour identifier");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OffersTransportTypesPrices",
                table: "OffersTransportTypesPrices",
                columns: new[] { "UnorganizedOfferId", "TransportTypeId" });

            migrationBuilder.CreateTable(
                name: "Tours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Tour identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false, comment: "Description of tour"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false, comment: "Name of tour")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tours", x => x.Id);
                },
                comment: "This entity shows the tour conducted in the given trip");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizedOffers_TourId",
                table: "OrganizedOffers",
                column: "TourId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Activities_TourId",
                table: "Activities",
                column: "TourId");

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_Tours_TourId",
                table: "Activities",
                column: "TourId",
                principalTable: "Tours",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OffersTransportTypesPrices_TransportTypes_TransportTypeId",
                table: "OffersTransportTypesPrices",
                column: "TransportTypeId",
                principalTable: "TransportTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OffersTransportTypesPrices_UnorganizedOffers_UnorganizedOfferId",
                table: "OffersTransportTypesPrices",
                column: "UnorganizedOfferId",
                principalTable: "UnorganizedOffers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrganizedOffers_Tours_TourId",
                table: "OrganizedOffers",
                column: "TourId",
                principalTable: "Tours",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
