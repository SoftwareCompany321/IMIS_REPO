using Microsoft.EntityFrameworkCore.Migrations;

namespace IMIS_DataEntity.Migrations
{
    public partial class phase4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DisplayNameNep",
                table: "Imis_Menu",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DisplayNameNep",
                table: "Imis_Menu");
        }
    }
}
