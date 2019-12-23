using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IMIS_DataEntity.Migrations
{
    public partial class Removetableinvyrlypurplaan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "INV_YRLY_PUR_PLAN");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "INV_YRLY_PUR_PLAN",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false),
                    AGREEMENT_DT_AD = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    AGREEMENT_TYPE = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    ANLYSIS_DSGN_DT_AD = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    APPROX_AMT = table.Column<float>(type: "real", nullable: true),
                    APRX_AMT_ACPT_DATE = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    APRX_AMT_ACPT_DT_AD = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    FORM_ENTRY_DATE = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    INFO_PUBLISH_DATE = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    NAME_EN = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    NAME_NP = table.Column<string>(type: "character varying(70)", maxLength: 70, nullable: false),
                    PUR_TYPE = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    REMARKS = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    TENDR_ACCEPT_DATE = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    TENDR_ACCEPT_DT_AD = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    TENDR_CALL_DT_AD = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    TENDR_OPEN_DATE = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    TENDR_OPEN_DT_AD = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    TENDR_SALE_DATE = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    WRK_2_FIN_DT_AD = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    WRK_ACMPLSH_DATE = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    WRK_ACMPLSH_DT_AD = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    WRK_ORDER_DATE = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INV_YRLY_PUR_PLAN", x => x.ID);
                });
        }
    }
}
