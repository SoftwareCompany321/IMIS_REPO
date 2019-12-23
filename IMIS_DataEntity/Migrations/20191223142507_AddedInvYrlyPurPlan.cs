using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace IMIS_DataEntity.Migrations
{
    public partial class AddedInvYrlyPurPlan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InvYrlyPurPlan",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    NameNp = table.Column<string>(nullable: true),
                    NameEn = table.Column<string>(nullable: true),
                    ApproxAmt = table.Column<float>(nullable: true),
                    PurType = table.Column<string>(nullable: true),
                    AgreementType = table.Column<string>(nullable: true),
                    AprxAmtAcptDate = table.Column<string>(nullable: true),
                    InfoPublishDate = table.Column<string>(nullable: true),
                    TendrSaleDate = table.Column<string>(nullable: true),
                    FormEntryDate = table.Column<string>(nullable: true),
                    TendrOpenDate = table.Column<string>(nullable: true),
                    TendrAcceptDate = table.Column<string>(nullable: true),
                    WrkOrderDate = table.Column<string>(nullable: true),
                    WrkAcmplshDate = table.Column<string>(nullable: true),
                    AnlysisDsgnDtAd = table.Column<DateTime>(nullable: true),
                    AprxAmtAcptDtAd = table.Column<DateTime>(nullable: true),
                    TendrAcceptDtAd = table.Column<DateTime>(nullable: true),
                    TendrCallDtAd = table.Column<DateTime>(nullable: true),
                    TendrOpenDtAd = table.Column<DateTime>(nullable: true),
                    AgreementDtAd = table.Column<DateTime>(nullable: true),
                    Wrk2FinDtAd = table.Column<DateTime>(nullable: true),
                    WrkAcmplshDtAd = table.Column<DateTime>(nullable: true),
                    Remarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvYrlyPurPlan", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InvYrlyPurPlan");
        }
    }
}
