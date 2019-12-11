using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace IMIS_DataEntity.Migrations
{
    public partial class Phase3_AddedMenuTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Imis_Menu",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MenuName = table.Column<string>(type: "varchar(250)", nullable: true),
                    MenuUrl = table.Column<string>(type: "varchar(500)", nullable: true),
                    DisplayName = table.Column<string>(type: "varchar(100)", nullable: true),
                    ParentMenuId = table.Column<int>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    IsLocked = table.Column<bool>(nullable: false),
                    Visible = table.Column<bool>(nullable: false),
                    Icon = table.Column<string>(type: "varchar(250)", nullable: true),
                    MenuOrder = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(450)", nullable: true),
                    UpdateBy = table.Column<string>(type: "varchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imis_Menu", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Imis_Menu");
        }
    }
}
