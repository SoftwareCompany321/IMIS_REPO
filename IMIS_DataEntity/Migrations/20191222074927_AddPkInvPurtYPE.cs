using Microsoft.EntityFrameworkCore.Migrations;

namespace IMIS_DataEntity.Migrations
{
    public partial class AddPkInvPurtYPE : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "INV_PUR_TYPE");

            migrationBuilder.AlterColumn<int>(
                name: "NATIONALITYID",
                table: "NATIONALITIES",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SN",
                table: "ISSUEDBILLS",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "NATIONALITYID",
                table: "NATIONALITIES",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "SN",
                table: "ISSUEDBILLS",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateTable(
                name: "INV_PUR_TYPE",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false),
                    ISDEFAULT = table.Column<char>(type: "character(1)", nullable: true),
                    NEP_ENG = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    NEP_NAME = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    REMARKS = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                });
        }
    }
}
