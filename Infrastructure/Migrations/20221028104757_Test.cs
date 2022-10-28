using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Packages_StudentModel_StudentId",
                table: "Packages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentModel",
                table: "StudentModel");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "StudentModel",
                newName: "Name");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "StudentModel",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDay",
                table: "StudentModel",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "StudentModel",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "StudentModel",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "StudentModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "StudentModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "StudentModel",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "StudentModel",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "StudentModel",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "StudentModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "StudentModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "StudentModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "StudentModel",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "StudentModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "StudentModel",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "StudentModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentModel",
                table: "StudentModel",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Packages_StudentModel_StudentId",
                table: "Packages",
                column: "StudentId",
                principalTable: "StudentModel",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Packages_StudentModel_StudentId",
                table: "Packages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentModel",
                table: "StudentModel");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "StudentModel");

            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "StudentModel");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "StudentModel");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "StudentModel");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "StudentModel");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "StudentModel");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "StudentModel");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "StudentModel");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "StudentModel");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "StudentModel");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "StudentModel");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "StudentModel");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "StudentModel");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "StudentModel",
                newName: "name");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "StudentModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "StudentModel",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BirthDay",
                table: "StudentModel",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentModel",
                table: "StudentModel",
                column: "Email");

            migrationBuilder.AddForeignKey(
                name: "FK_Packages_StudentModel_StudentId",
                table: "Packages",
                column: "StudentId",
                principalTable: "StudentModel",
                principalColumn: "Email");
        }
    }
}
