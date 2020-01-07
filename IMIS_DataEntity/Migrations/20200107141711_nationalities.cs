using Microsoft.EntityFrameworkCore.Migrations;

namespace IMIS_DataEntity.Migrations
{
    public partial class nationalities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddPrimaryKey(
                name: "NATIONALITIES_pkey",
                table: "NATIONALITIES",
                column: "NATIONALITYID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "NATIONALITIES_pkey",
                table: "NATIONALITIES");
        }
    }
}
