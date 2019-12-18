using Microsoft.EntityFrameworkCore.Migrations;

namespace IMIS_DataEntity.Migrations
{
    public partial class Phase5InvPurTypePrimaryKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "REMARKS",
                table: "INV_PUR_TYPE",
                type: "varchar(100)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NEP_NAME",
                table: "INV_PUR_TYPE",
                type: "varchar(100)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NEP_ENG",
                table: "INV_PUR_TYPE",
                type: "varchar(100)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ISDEFAULT",
                table: "INV_PUR_TYPE",
                type: "char(1)",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(1)",
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ID",
                table: "INV_PUR_TYPE",
                type: "numeric(22,0)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(22,0)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "REMARKS",
                table: "INV_PUR_TYPE",
                type: "character varying(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NEP_NAME",
                table: "INV_PUR_TYPE",
                type: "character varying(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NEP_ENG",
                table: "INV_PUR_TYPE",
                type: "character varying(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ISDEFAULT",
                table: "INV_PUR_TYPE",
                type: "character varying(1)",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "char(1)",
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ID",
                table: "INV_PUR_TYPE",
                type: "numeric(22,0)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "numeric(22,0)");
        }
    }
}
