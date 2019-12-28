using Microsoft.EntityFrameworkCore.Migrations;

namespace IMIS_DataEntity.Migrations
{
    public partial class fix_for_isactive : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "INV_WAREHOUSE",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "INV_UNIT",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "INV_TYPE_SETUP",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "INV_REQ_DETAIL",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "INV_PROJECT",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "INV_ORG_TYPE",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "INV_ITEM_STATUSCHECK",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "INV_ITEM_SPEC",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "INV_DEPT",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "INV_BRAND",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "INV_WAREHOUSE");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "INV_UNIT");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "INV_TYPE_SETUP");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "INV_REQ_DETAIL");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "INV_PROJECT");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "INV_ORG_TYPE");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "INV_ITEM_STATUSCHECK");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "INV_ITEM_SPEC");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "INV_DEPT");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "INV_BRAND");
        }
    }
}
