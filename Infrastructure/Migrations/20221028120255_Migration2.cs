using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class Migration2 : Migration
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
                table: "Products",
                columns: new[] { "ProductId", "Alcohol", "Name" },
                values: new object[,]
                {
                    { 69, false, "Kaassouflee" },
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
