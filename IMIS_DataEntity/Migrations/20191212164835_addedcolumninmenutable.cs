using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IMIS_DataEntity.Migrations
{
    public partial class addedcolumninmenutable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Imis_Menu",
                nullable: true,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Imis_Menu",
                nullable: true,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Imis_Menu");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Imis_Menu");
        }
    }
}
