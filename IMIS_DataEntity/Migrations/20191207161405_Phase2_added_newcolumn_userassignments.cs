using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IMIS_DataEntity.Migrations
{
    public partial class Phase2_added_newcolumn_userassignments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ACTIVE",
                table: "USERASSIGNMENTS",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "CREATEDAT",
                table: "USERASSIGNMENTS",
                type: "TIMESTAMP",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CREATEDBY",
                table: "USERASSIGNMENTS",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DISPLAYNAME",
                table: "USERASSIGNMENTS",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ICON",
                table: "USERASSIGNMENTS",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ISLOCKED",
                table: "USERASSIGNMENTS",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "MENUNAME",
                table: "USERASSIGNMENTS",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<short>(
                name: "MENUORDER",
                table: "USERASSIGNMENTS",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<string>(
                name: "MENUURL",
                table: "USERASSIGNMENTS",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PARENTMENUID",
                table: "USERASSIGNMENTS",
                type: "numeric(22,0)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<bool>(
                name: "VISIBLE",
                table: "USERASSIGNMENTS",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ACTIVE",
                table: "USERASSIGNMENTS");

            migrationBuilder.DropColumn(
                name: "CREATEDAT",
                table: "USERASSIGNMENTS");

            migrationBuilder.DropColumn(
                name: "CREATEDBY",
                table: "USERASSIGNMENTS");

            migrationBuilder.DropColumn(
                name: "DISPLAYNAME",
                table: "USERASSIGNMENTS");

            migrationBuilder.DropColumn(
                name: "ICON",
                table: "USERASSIGNMENTS");

            migrationBuilder.DropColumn(
                name: "ISLOCKED",
                table: "USERASSIGNMENTS");

            migrationBuilder.DropColumn(
                name: "MENUNAME",
                table: "USERASSIGNMENTS");

            migrationBuilder.DropColumn(
                name: "MENUORDER",
                table: "USERASSIGNMENTS");

            migrationBuilder.DropColumn(
                name: "MENUURL",
                table: "USERASSIGNMENTS");

            migrationBuilder.DropColumn(
                name: "PARENTMENUID",
                table: "USERASSIGNMENTS");

            migrationBuilder.DropColumn(
                name: "VISIBLE",
                table: "USERASSIGNMENTS");
        }
    }
}
