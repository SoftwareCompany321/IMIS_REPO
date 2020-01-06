using Microsoft.EntityFrameworkCore.Migrations;

namespace IMIS_DataEntity.Migrations
{
    public partial class addedcolum_column_reqmst : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "PurchaseGive",
                table: "INV_REQUISITION_MAST",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "StockGive",
                table: "INV_REQUISITION_MAST",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PurchaseGive",
                table: "INV_REQUISITION_MAST");

            migrationBuilder.DropColumn(
                name: "StockGive",
                table: "INV_REQUISITION_MAST");
        }
    }
}
