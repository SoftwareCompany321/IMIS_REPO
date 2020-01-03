using Microsoft.EntityFrameworkCore.Migrations;

namespace IMIS_DataEntity.Migrations
{
    public partial class Order : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "order",
                table: "PIS_NIJAMATI_SEWA_SAMUHA",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "order",
                table: "ORGANIZATION_TREE",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "ACC_ACC_MASTER",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "order",
                table: "PIS_NIJAMATI_SEWA_SAMUHA");

            migrationBuilder.DropColumn(
                name: "order",
                table: "ORGANIZATION_TREE");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "ACC_ACC_MASTER");
        }
    }
}
