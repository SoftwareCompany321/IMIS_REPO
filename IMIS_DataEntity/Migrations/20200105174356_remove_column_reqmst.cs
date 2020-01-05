using Microsoft.EntityFrameworkCore.Migrations;

namespace IMIS_DataEntity.Migrations
{
    public partial class remove_column_reqmst : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PURCHASE_GIVE",
                table: "INV_REQUISITION_MAST");

            migrationBuilder.DropColumn(
                name: "STOCK_GIVE",
                table: "INV_REQUISITION_MAST");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PURCHASE_GIVE",
                table: "INV_REQUISITION_MAST",
                type: "character varying(1)",
                maxLength: 1,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "STOCK_GIVE",
                table: "INV_REQUISITION_MAST",
                type: "character varying(1)",
                maxLength: 1,
                nullable: true);
        }
    }
}
