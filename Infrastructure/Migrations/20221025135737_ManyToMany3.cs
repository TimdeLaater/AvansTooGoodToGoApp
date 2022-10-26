using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class ManyToMany3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Canteen",
                columns: new[] { "canteenId", "Name", "ServesHot", "city" },
                values: new object[,]
                {
                    { 44, "LA", true, 1 },
                    { 45, "LD", true, 1 },
                    { 46, "HA", true, 1 },
                    { 47, "HA", true, 2 },
                    { 48, "HA", true, 3 }
                });

            migrationBuilder.InsertData(
                table: "Packages",
                columns: new[] { "PackageId", "Alcohol", "MealType", "Name", "Price", "StudentId", "canteenId", "collected", "orderPickup" },
                values: new object[] { 69, false, 1, "Pasta Kaasoufle", 10, null, null, false, new DateTime(2022, 5, 10, 18, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Alcohol", "Name" },
                values: new object[,]
                {
                    { 69, false, "KaasoufleeBitch" },
                    { 99, false, "Brie" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Canteen",
                keyColumn: "canteenId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Canteen",
                keyColumn: "canteenId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Canteen",
                keyColumn: "canteenId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Canteen",
                keyColumn: "canteenId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Canteen",
                keyColumn: "canteenId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Packages",
                keyColumn: "PackageId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 99);
        }
    }
}
