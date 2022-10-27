using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class AddPackage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Packages",
                keyColumn: "PackageId",
                keyValue: 69);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Packages",
                columns: new[] { "PackageId", "Alcohol", "MealType", "Name", "Price", "StudentId", "canteenId", "collected", "orderPickup" },
                values: new object[] { 69, false, 1, "Pasta Kaasoufle", 10, null, null, false, new DateTime(2022, 5, 10, 18, 30, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
