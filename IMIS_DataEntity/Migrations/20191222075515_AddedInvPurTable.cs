using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace IMIS_DataEntity.Migrations
{
    public partial class AddedInvPurTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InvPurType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    NepName = table.Column<string>(nullable: true),
                    NepEng = table.Column<string>(nullable: true),
                    Remarks = table.Column<string>(nullable: true),
                    Isdefault = table.Column<char>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvPurType", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InvPurType");
        }
    }
}
