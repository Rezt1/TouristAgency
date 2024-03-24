using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TouristAgency.Infrastructure.Migrations
{
    public partial class Changed_Scheme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hotels_Offers_OfferId",
                table: "Hotels");

            migrationBuilder.DropForeignKey(
                name: "FK_OffersTransportTypesPrices_Offers_OfferId",
                table: "OffersTransportTypesPrices");

            migrationBuilder.DropForeignKey(
                name: "FK_OrganizedHolidays_Offers_OfferId",
                table: "OrganizedHolidays");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Offers_OfferId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_UnorganizedHolidays_Offers_OfferId",
                table: "UnorganizedHolidays");

            migrationBuilder.DropTable(
                name: "Offers");

            migrationBuilder.DropIndex(
                name: "IX_UnorganizedHolidays_OfferId",
                table: "UnorganizedHolidays");

            migrationBuilder.DropIndex(
                name: "IX_OrganizedHolidays_OfferId",
                table: "OrganizedHolidays");

            migrationBuilder.DropColumn(
                name: "OfferId",
                table: "UnorganizedHolidays");

            migrationBuilder.DropColumn(
                name: "OfferId",
                table: "OrganizedHolidays");

            migrationBuilder.RenameColumn(
                name: "OfferId",
                table: "OffersTransportTypesPrices",
                newName: "UnorganizedOfferId");

            migrationBuilder.RenameColumn(
                name: "OfferId",
                table: "Hotels",
                newName: "UnorganizedOfferId");

            migrationBuilder.RenameIndex(
                name: "IX_Hotels_OfferId",
                table: "Hotels",
                newName: "IX_Hotels_UnorganizedOfferId");

            migrationBuilder.AddColumn<int>(
                name: "UnorganizedOfferId",
                table: "UnorganizedHolidays",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "UnorganizedOffer identifier");

            migrationBuilder.AddColumn<int>(
                name: "OrganizedHolidayId",
                table: "Reviews",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DestinationId",
                table: "OrganizedHolidays",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Destination identifier");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "OrganizedHolidays",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                defaultValue: "",
                comment: "Name of OrganizedHoliday");

            migrationBuilder.AddColumn<float>(
                name: "discount",
                table: "OrganizedHolidays",
                type: "real",
                nullable: true,
                comment: "Discount of OrganizedHoliday which could not exist");

            migrationBuilder.CreateTable(
                name: "UnorganizedOffers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Offer identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DestinationId = table.Column<int>(type: "int", nullable: false, comment: "Identifier of destination in which is the offer"),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false, comment: "Checks if the offer is available for booking")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnorganizedOffers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UnorganizedOffers_Destinations_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "Destinations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "This table shows what we offer for a given destination");

            migrationBuilder.CreateIndex(
                name: "IX_UnorganizedHolidays_UnorganizedOfferId",
                table: "UnorganizedHolidays",
                column: "UnorganizedOfferId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_OrganizedHolidayId",
                table: "Reviews",
                column: "OrganizedHolidayId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizedHolidays_DestinationId",
                table: "OrganizedHolidays",
                column: "DestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_UnorganizedOffers_DestinationId",
                table: "UnorganizedOffers",
                column: "DestinationId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Hotels_UnorganizedOffers_UnorganizedOfferId",
                table: "Hotels",
                column: "UnorganizedOfferId",
                principalTable: "UnorganizedOffers",
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
                name: "FK_OrganizedHolidays_Destinations_DestinationId",
                table: "OrganizedHolidays",
                column: "DestinationId",
                principalTable: "Destinations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_OrganizedHolidays_OrganizedHolidayId",
                table: "Reviews",
                column: "OrganizedHolidayId",
                principalTable: "OrganizedHolidays",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_UnorganizedOffers_OfferId",
                table: "Reviews",
                column: "OfferId",
                principalTable: "UnorganizedOffers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UnorganizedHolidays_UnorganizedOffers_UnorganizedOfferId",
                table: "UnorganizedHolidays",
                column: "UnorganizedOfferId",
                principalTable: "UnorganizedOffers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hotels_UnorganizedOffers_UnorganizedOfferId",
                table: "Hotels");

            migrationBuilder.DropForeignKey(
                name: "FK_OffersTransportTypesPrices_UnorganizedOffers_UnorganizedOfferId",
                table: "OffersTransportTypesPrices");

            migrationBuilder.DropForeignKey(
                name: "FK_OrganizedHolidays_Destinations_DestinationId",
                table: "OrganizedHolidays");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_OrganizedHolidays_OrganizedHolidayId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_UnorganizedOffers_OfferId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_UnorganizedHolidays_UnorganizedOffers_UnorganizedOfferId",
                table: "UnorganizedHolidays");

            migrationBuilder.DropTable(
                name: "UnorganizedOffers");

            migrationBuilder.DropIndex(
                name: "IX_UnorganizedHolidays_UnorganizedOfferId",
                table: "UnorganizedHolidays");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_OrganizedHolidayId",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_OrganizedHolidays_DestinationId",
                table: "OrganizedHolidays");

            migrationBuilder.DropColumn(
                name: "UnorganizedOfferId",
                table: "UnorganizedHolidays");

            migrationBuilder.DropColumn(
                name: "OrganizedHolidayId",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "DestinationId",
                table: "OrganizedHolidays");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "OrganizedHolidays");

            migrationBuilder.DropColumn(
                name: "discount",
                table: "OrganizedHolidays");

            migrationBuilder.RenameColumn(
                name: "UnorganizedOfferId",
                table: "OffersTransportTypesPrices",
                newName: "OfferId");

            migrationBuilder.RenameColumn(
                name: "UnorganizedOfferId",
                table: "Hotels",
                newName: "OfferId");

            migrationBuilder.RenameIndex(
                name: "IX_Hotels_UnorganizedOfferId",
                table: "Hotels",
                newName: "IX_Hotels_OfferId");

            migrationBuilder.AddColumn<int>(
                name: "OfferId",
                table: "UnorganizedHolidays",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Offer identifier related to current unorganizedHoliday");

            migrationBuilder.AddColumn<int>(
                name: "OfferId",
                table: "OrganizedHolidays",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Offer identifier");

            migrationBuilder.CreateTable(
                name: "Offers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Offer identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DestinationId = table.Column<int>(type: "int", nullable: false, comment: "Identifier of destination in which is the offer"),
                    CanBeUnorganized = table.Column<bool>(type: "bit", nullable: false, comment: "Checks if the offer can be booked customly by the user"),
                    Discount = table.Column<float>(type: "real", nullable: true, comment: "Discount of offer available to only special users"),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false, comment: "Checks if the offer is available for booking"),
                    Name = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false, comment: "Name of offer")
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

            migrationBuilder.CreateIndex(
                name: "IX_UnorganizedHolidays_OfferId",
                table: "UnorganizedHolidays",
                column: "OfferId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrganizedHolidays_OfferId",
                table: "OrganizedHolidays",
                column: "OfferId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Offers_DestinationId",
                table: "Offers",
                column: "DestinationId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Hotels_Offers_OfferId",
                table: "Hotels",
                column: "OfferId",
                principalTable: "Offers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OffersTransportTypesPrices_Offers_OfferId",
                table: "OffersTransportTypesPrices",
                column: "OfferId",
                principalTable: "Offers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrganizedHolidays_Offers_OfferId",
                table: "OrganizedHolidays",
                column: "OfferId",
                principalTable: "Offers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Offers_OfferId",
                table: "Reviews",
                column: "OfferId",
                principalTable: "Offers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UnorganizedHolidays_Offers_OfferId",
                table: "UnorganizedHolidays",
                column: "OfferId",
                principalTable: "Offers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
