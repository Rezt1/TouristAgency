using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TouristAgency.Infrastructure.Migrations
{
    public partial class Seeded_Database_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BulgarianName",
                table: "AspNetRoles",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                comment: "Name of role in bulgarian");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "BulgarianName", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("00b65b02-defd-44e0-ba06-6ec23d617199"), "Администратор", "ad7842aa-767d-4e92-b00b-cf59fd662d42", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "BulgarianName", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("e3ff5c00-2c71-4a66-8533-e1ba370a8066"), "Специален гост", "7f699cd7-5f28-4aef-9081-d2cc283b2cad", "Special guest", "SPEICAL GUEST" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("ee1db236-356f-48e9-9ba3-3962e8f34fac"), 0, "222c45a4-d783-4c89-aee5-18c8af0d4c8c", "ivaylo20044@gmail.com", true, "Ivaylo", "Hristov", false, null, "IVAYLO20044@GMAIL.COM", "IVAYLO20044@GMAIL.COM", "AEffYjQUs92sA5+7hpjtyNL1iYc//6IP7iB373q6ZfBWGpsZTV2Dy8ZpU/43ZKWpvw==", "0877814910", true, "6b56d4a5-2b16-4f76-937f-c430d9870418", false, "ivaylo20044@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("00b65b02-defd-44e0-ba06-6ec23d617199"), new Guid("ee1db236-356f-48e9-9ba3-3962e8f34fac") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e3ff5c00-2c71-4a66-8533-e1ba370a8066"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("00b65b02-defd-44e0-ba06-6ec23d617199"), new Guid("ee1db236-356f-48e9-9ba3-3962e8f34fac") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("00b65b02-defd-44e0-ba06-6ec23d617199"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ee1db236-356f-48e9-9ba3-3962e8f34fac"));

            migrationBuilder.DropColumn(
                name: "BulgarianName",
                table: "AspNetRoles");
        }
    }
}
