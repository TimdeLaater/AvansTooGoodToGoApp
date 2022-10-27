using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class NullablePAckage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "servesHot",
                table: "Canteen",
                newName: "ServesHot");

            migrationBuilder.RenameColumn(
                name: "location",
                table: "Canteen",
                newName: "Name");

            migrationBuilder.AddColumn<int>(
                name: "City",
                table: "StudentModel",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "StudentModel");

            migrationBuilder.RenameColumn(
                name: "ServesHot",
                table: "Canteen",
                newName: "servesHot");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Canteen",
                newName: "location");
        }
    }
}
