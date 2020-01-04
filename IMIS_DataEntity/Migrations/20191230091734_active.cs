using Microsoft.EntityFrameworkCore.Migrations;

namespace IMIS_DataEntity.Migrations
{
    public partial class active : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "TBL_VEHICLE_PARTS",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "TBL_KHARIDA_AADASH",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "STOREDBILLS",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "NATIONALITIES",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "ISSUEDBILLS",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "InvYrlyPurPlan",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "InvPurType",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "INV_TAX_RATE",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "INV_SUPPLIER_FISCALYEAR",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "INV_SUPPLIER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "INV_ROOM_MST",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "INV_PUR_MAST_PLAN",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "INV_ITEM_MST",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "INV_ITEM_CATEGORY",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "INV_ITEM_ADJ_TYPE",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "COLLECTIONCOUNTERS",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "BANKMASTER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "ACC_ORG_MASTER",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "TBL_VEHICLE_PARTS");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "TBL_KHARIDA_AADASH");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "STOREDBILLS");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "NATIONALITIES");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "ISSUEDBILLS");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "InvYrlyPurPlan");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "InvPurType");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "INV_TAX_RATE");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "INV_SUPPLIER_FISCALYEAR");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "INV_SUPPLIER");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "INV_ROOM_MST");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "INV_PUR_MAST_PLAN");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "INV_ITEM_MST");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "INV_ITEM_CATEGORY");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "INV_ITEM_ADJ_TYPE");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "COLLECTIONCOUNTERS");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "BANKMASTER");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "ACC_ORG_MASTER");
        }
    }
}
