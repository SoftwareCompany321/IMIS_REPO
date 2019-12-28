using Microsoft.EntityFrameworkCore.Migrations;

namespace IMIS_DataEntity.Migrations
{
    public partial class AddedColumnCode_In_every_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IS_ACTIVE",
                table: "INV_WAREHOUSE");

            migrationBuilder.DropColumn(
                name: "IS_ACTIVE",
                table: "INV_UNIT");

            migrationBuilder.DropColumn(
                name: "IS_ACTIVE",
                table: "INV_TYPE_SETUP");

            migrationBuilder.DropColumn(
                name: "IS_ACTIVE",
                table: "INV_REQ_DETAIL");

            migrationBuilder.DropColumn(
                name: "IS_ACTIVE",
                table: "INV_PROJECT");

            migrationBuilder.DropColumn(
                name: "IS_ACTIVE",
                table: "INV_ORG_TYPE");

            migrationBuilder.DropColumn(
                name: "IS_ACTIVE",
                table: "INV_ITEM_STATUSCHECK");

            migrationBuilder.DropColumn(
                name: "IS_ACTIVE",
                table: "INV_ITEM_SPEC");

            migrationBuilder.DropColumn(
                name: "IS_ACTIVE",
                table: "INV_DEPT");

            migrationBuilder.DropColumn(
                name: "IS_ACTIVE",
                table: "INV_BRAND");

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "WARD_MASTER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "USERASSIGNMENTS",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "TBUSERSECURITYRIGHTS",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "TBLTAXCALCULATIONROKA",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "TBLTAX_FINE_REBATE",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "TBLMALPOTSUBGROUP",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "TBLMALPOTRATES",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "TBLMALPOTGROUP",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "TBLHL_ADD_SUBTRACT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "TBLFYWISEMPOTASSRATE",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "TBLFYWISEBTRATES",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "TBLEXEVERSION",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "TBLBUSINESS_SERVICE_CH_MST",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "TBLBILLTYPE",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "TBL_VEHICLE_PARTS",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "TBL_TOLABIKASA_ORG",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "TBL_TAXSOURCERECORDNEW",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "TBL_STATUS_DETAILS",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "TBL_SANITAION_TAX",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "TBL_PROPERTY_TAX",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "TBL_PAYMENT_TYPE",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "TBL_PAYMENT_PROCESS",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "TBL_PAYMENT_ORDER_DETAILS",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "TBL_ORGANIZATIONMASTER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "TBL_NALI_TYPE",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "TBL_MALPOT_OTHER_CHARGES",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "TBL_LAND_OTHER_CHARGES",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "TBL_KHARIDA_AADASH",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "TBL_DEGISTER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "TBL_DATA_HISTORY",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "TBL_CONSTRUCTION_OTHER_CHARGES",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "TBL_BGT_RELEASE",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "TBL_BGT_MGMT_SRC_RELEASE",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "TBL_BGT_MGMT_SRC_ORG",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "TBL_BGT_MGMT_SRC",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "TBL_BGT_MGMT_RELEASE",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "TBL_BGT_MGMT_ORG",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "TBL_BGT_MGMT_EXP_RELEASE",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "TBL_BGT_MGMT_EXP_ORG",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "TBL_BGT_MGMT_EXP",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "TBL_BGT_MGMT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "TBL_BANK_FINANCE_INSTITUTUE",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "TBL_BANK_ACCNT_TYPE",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "TBHOUSEKITTANUMBER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "TAX_THLI_ISSUED_CNTR",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "TAX_SANITATION",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "TAX_RT_RENTDTL",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "TAX_RENTAL",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "TAX_RATE_CEILING",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "TAX_MALPOT_HISTORY",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "TAX_MALPOT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "TAX_ADDTNL_CHRG_DTLS",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "SV_VEHICLEMASTER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "SV_TBHOUSEKITTANUMBER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "SV_PEOPLE",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "SV_LANDSMULTIEVALUATIONDETAIL",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "SV_LANDS",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "SV_HOUSES",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "SV_CONSTRUCTIONS",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "SV_BUSINESSMASTER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "SUB_MODULE_SOURCE",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "SPACEMEASURINGUNITS",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "SERVICE_CHARGE_MASTER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "SANITATION_SUBGROUP",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "SANITATION_RATE",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "SANITATION_GROUP",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "REPORT_GENERAL",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "RENTTYPE",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "RENT_DAR_RATE",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "PMS_YOJTYPE",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "PIS_WORKSHOP",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "PIS_VISITED_COUNTRIES",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "PIS_TRAINING",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "PIS_SHARE_BANKBALANCE",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "PIS_SGNFCNT_WORK",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "PIS_SERVICE_STATUS",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "PIS_REPLACED_IN_DARBANDI",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "PIS_PYROLL_OTHR_DTLS",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "PIS_PYROLL_LOAN_DTLS",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "PIS_PUBLICATION",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "PIS_PRIZES",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "PIS_POST_MASTER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "PIS_PERSON_VISIT_RECRD",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "PIS_PD_SRVC_DTLS",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "PIS_PD_ORG_INVLVMNT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "PIS_PAYROLLS",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "PIS_OTHER_ADD_SUB",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "PIS_ORNAMENTS",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "PIS_NIJAMATI_SEWA_SAMUHA",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "PIS_LOCAL_POST_MASTER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "PIS_LOAN_DHITO_TAKEN",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "PIS_LOAN_DHITO_GIVEN",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "PIS_LAND_BLDNGS",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "PIS_INTERNAL_TRANSFER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "PIS_HAJIRI",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "PIS_GEO_REGION",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "PIS_FULFILLED_DARBANDI",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "PIS_FOREIGN_VISITS",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "PIS_EMP_TRNSFR_REC",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "PIS_EMP_SUSPENDS",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "PIS_EMP_SRVC_DTLS",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "PIS_EMP_PUNISHMNTS",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "PIS_EMP_MED_EXPENSE",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "PIS_EMP_LONG_LEAVES",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "PIS_EMP_LOANS",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "PIS_EMP_INSURANCE_PAID",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "PIS_EMP_DEP_SOURCE",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "PIS_EMP_DEP",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "PIS_EMP_BARGA",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "PIS_EMP_ADV_DED_DTL",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "PIS_EDUCATION",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "PIS_EDU_LEVEL",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "PIS_EDU_BOARD",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "PIS_DELETD_FRM_FULFILD_DARB",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "PIS_DARBANDI",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "PIS_BANK_PAYROLL",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "PIS_AWARDS",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "PIS_ATTRIBUTES",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "PIS_APPOINTMENT_TYPE",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "PERSON_TYPE_MASTER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "PAYMENT_SLIP_MASTER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "ORGANIZATION_TREE",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "ORG_BANK_ACCOUNT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "OFFICE_TYPE",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "NEW_PROPERTY_TAXTABLE",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "MINISTRY_ACC_HEAD",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "MAP_ZONE",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "MAP_STRUCTURE_TYPE",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "MAP_STOREYS",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "MAP_STDHEIGHT_RW",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "MAP_SITE",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "MAP_ROOF_TYPE",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "MAP_ROOF_CNSTRCT_TYPE",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "MAP_REGION_FAR",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "MAP_RATE",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "MAP_NEIGHBOUR_TYPE",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "MAP_LAND_OWNER_TYPE",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "MAP_INCOME_TYPE",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "MAP_HTSTANDARD",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "MAP_HOUSEUSE_TYPE",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "MAP_FLOOR",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "MAP_DRAIN_TYPE",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "MAP_DIRECTION",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "MAP_DESIGNER_DTL",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "MAP_CONSTRCTION_KIND",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "MAP_AREA_GND_COV",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "MALPOT_LANDS",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SN",
                table: "LELEDGER20682069",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "LELEDGER20682069",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SN",
                table: "LANDSMULTIEVALUATIONDETAIL",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "LANDSMULTIEVALUATIONDETAIL",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UNITID",
                table: "LANDMEASURINGUNITS",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "LANDMEASURINGUNITS",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "ISSUEDBILLS",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "IPTTAXSUMMARY_HISTORY",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "InvYrlyPurPlan",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "InvPurType",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "INV_WAREHOUSE",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "INV_UNIT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "INV_TYPE_SETUP",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "INV_TAX_RATE",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "INV_SUPPLIER_FISCALYEAR",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "INV_SUPPLIER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "INV_SUP_ITM_DET",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "INV_ROOM_MST",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "INV_REQUISITION_MAST",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "INV_REQ_DETAIL",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "INV_PUR_ORDER_MAST",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "INV_PUR_ORDER_DETL",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "INV_PUR_MAST_PLAN",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "INV_PROJECT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "INV_ORG_TYPE",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "INV_LILAMAPPDETAILS",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "INV_LILAM_REC_LIST",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "INV_LILAM_MAST",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "INV_LILAM_DETAIL",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "INV_LILAM_APPMASTER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "INV_ITEM_STATUSCHECK",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "INV_ITEM_SPEC",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "INV_ITEM_DETAILS",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "INV_ITEM_ADJ_TYPE",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "INV_ISSUE_MASTER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "INV_ISSUE_DETAIL",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "INV_ISSUE_DAKHILA",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "INV_INCREASE_DECREASE",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "INV_GOODS_REC_MAST",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "INV_GOODS_REC_DETL",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "INV_GOODS_ADJUST",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "INV_DEPT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "INV_DEPRECIATION",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "INV_DEPLIST",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "INV_BRAND",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "INV_APPLICANT_RATE",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "INCOMEBILLMASTER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "INCOMEBILLDETAILS_HISTORY",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "INCOMEBILLDETAILS",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "FYWISESANITATION_RATE",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "FYWISERENTDARRATE",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "FISCALYEARS",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "FIREBRIGADESTATE",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "EMP_GRP",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "CONSTANTVALUES",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "COLLECTIONCOUNTERS",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "CELEDGER20682069",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "CASHTRANSACTION",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "BUSINESSMASTER_HISTORY",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "BANKTRANSACTIONS",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "BANKMASTER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "BANK_BRANCH",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "APPLICATION_CONFIGURATION",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "ACCODE",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "ACC_WORK_PAYMNT_TRANS",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "ACC_WORK_MASTER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "ACC_WORK_FUNDS_DETAIL",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "ACC_VCHR_TYPE_MASTER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "ACC_VCHR_MASTER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "ACC_VCHR_DETAILS",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "ACC_USER_COMITE_MSTR",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "ACC_UNAUTHORISED",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "ACC_TRANS_TYPE",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SN",
                table: "ACC_RECEIVABLE",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "ACC_RECEIVABLE",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "ACC_PAYMENT_MASTER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "ACC_PAYMENT_DETAILS",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "ACC_PAYMENT_DEDUCTION",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "ACC_PAYMENT_CREDIT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "ACC_PAYMENT_CLEARANCE",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "ACC_PADADHIKARI_POST",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "ACC_PADADHIKARI_MSTR",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "ACC_LASTYEAR_ADV_DETAILS",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "ACC_LAST_YR_PESKI",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "ACC_INCOME_RATE",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "ACC_FUND_PROVIDR_MSTR",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "ACC_EXPENSES_DETAILS",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "ACC_DHRTI_BILL_MASTER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "ACC_DHRTI_BILL_DTL",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "ACC_CURRENCTY_RATE",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "ACC_CURRENCTY",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "ACC_CHEQUE_TYPES",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "ACC_CASH_TRANS",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "ACC_BUDJET_SOURCE",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "ACC_BGT_TRANSFER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "ACC_BGT_RVSN",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "ACC_BGT_ALLOCATE",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "ACC_BANK_TRANS",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "ACC_BANK_STATEMENT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "ACC_BANK_GRNTY",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "ACC_ASULI_BIBARAN",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "WARD_MASTER");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "USERASSIGNMENTS");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "TBUSERSECURITYRIGHTS");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "TBLTAXCALCULATIONROKA");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "TBLTAX_FINE_REBATE");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "TBLMALPOTSUBGROUP");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "TBLMALPOTRATES");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "TBLMALPOTGROUP");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "TBLHL_ADD_SUBTRACT");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "TBLFYWISEMPOTASSRATE");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "TBLFYWISEBTRATES");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "TBLEXEVERSION");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "TBLBUSINESS_SERVICE_CH_MST");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "TBLBILLTYPE");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "TBL_VEHICLE_PARTS");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "TBL_TOLABIKASA_ORG");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "TBL_TAXSOURCERECORDNEW");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "TBL_STATUS_DETAILS");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "TBL_SANITAION_TAX");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "TBL_PROPERTY_TAX");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "TBL_PAYMENT_TYPE");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "TBL_PAYMENT_PROCESS");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "TBL_PAYMENT_ORDER_DETAILS");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "TBL_ORGANIZATIONMASTER");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "TBL_NALI_TYPE");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "TBL_MALPOT_OTHER_CHARGES");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "TBL_LAND_OTHER_CHARGES");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "TBL_KHARIDA_AADASH");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "TBL_DEGISTER");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "TBL_DATA_HISTORY");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "TBL_CONSTRUCTION_OTHER_CHARGES");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "TBL_BGT_RELEASE");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "TBL_BGT_MGMT_SRC_RELEASE");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "TBL_BGT_MGMT_SRC_ORG");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "TBL_BGT_MGMT_SRC");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "TBL_BGT_MGMT_RELEASE");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "TBL_BGT_MGMT_ORG");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "TBL_BGT_MGMT_EXP_RELEASE");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "TBL_BGT_MGMT_EXP_ORG");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "TBL_BGT_MGMT_EXP");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "TBL_BGT_MGMT");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "TBL_BANK_FINANCE_INSTITUTUE");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "TBL_BANK_ACCNT_TYPE");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "TBHOUSEKITTANUMBER");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "TAX_THLI_ISSUED_CNTR");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "TAX_SANITATION");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "TAX_RT_RENTDTL");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "TAX_RENTAL");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "TAX_RATE_CEILING");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "TAX_MALPOT_HISTORY");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "TAX_MALPOT");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "TAX_ADDTNL_CHRG_DTLS");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "SV_VEHICLEMASTER");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "SV_TBHOUSEKITTANUMBER");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "SV_PEOPLE");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "SV_LANDSMULTIEVALUATIONDETAIL");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "SV_LANDS");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "SV_HOUSES");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "SV_CONSTRUCTIONS");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "SV_BUSINESSMASTER");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "SUB_MODULE_SOURCE");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "SPACEMEASURINGUNITS");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "SERVICE_CHARGE_MASTER");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "SANITATION_SUBGROUP");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "SANITATION_RATE");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "SANITATION_GROUP");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "REPORT_GENERAL");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "RENTTYPE");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "RENT_DAR_RATE");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "PMS_YOJTYPE");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "PIS_WORKSHOP");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "PIS_VISITED_COUNTRIES");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "PIS_TRAINING");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "PIS_SHARE_BANKBALANCE");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "PIS_SGNFCNT_WORK");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "PIS_SERVICE_STATUS");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "PIS_REPLACED_IN_DARBANDI");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "PIS_PYROLL_OTHR_DTLS");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "PIS_PYROLL_LOAN_DTLS");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "PIS_PUBLICATION");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "PIS_PRIZES");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "PIS_POST_MASTER");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "PIS_PERSON_VISIT_RECRD");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "PIS_PD_SRVC_DTLS");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "PIS_PD_ORG_INVLVMNT");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "PIS_PAYROLLS");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "PIS_OTHER_ADD_SUB");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "PIS_ORNAMENTS");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "PIS_NIJAMATI_SEWA_SAMUHA");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "PIS_LOCAL_POST_MASTER");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "PIS_LOAN_DHITO_TAKEN");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "PIS_LOAN_DHITO_GIVEN");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "PIS_LAND_BLDNGS");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "PIS_INTERNAL_TRANSFER");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "PIS_HAJIRI");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "PIS_GEO_REGION");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "PIS_FULFILLED_DARBANDI");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "PIS_FOREIGN_VISITS");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "PIS_EMP_TRNSFR_REC");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "PIS_EMP_SUSPENDS");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "PIS_EMP_SRVC_DTLS");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "PIS_EMP_PUNISHMNTS");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "PIS_EMP_MED_EXPENSE");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "PIS_EMP_LONG_LEAVES");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "PIS_EMP_LOANS");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "PIS_EMP_INSURANCE_PAID");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "PIS_EMP_DEP_SOURCE");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "PIS_EMP_DEP");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "PIS_EMP_BARGA");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "PIS_EMP_ADV_DED_DTL");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "PIS_EDUCATION");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "PIS_EDU_LEVEL");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "PIS_EDU_BOARD");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "PIS_DELETD_FRM_FULFILD_DARB");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "PIS_DARBANDI");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "PIS_BANK_PAYROLL");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "PIS_AWARDS");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "PIS_ATTRIBUTES");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "PIS_APPOINTMENT_TYPE");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "PERSON_TYPE_MASTER");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "PAYMENT_SLIP_MASTER");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "ORGANIZATION_TREE");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "ORG_BANK_ACCOUNT");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "OFFICE_TYPE");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "NEW_PROPERTY_TAXTABLE");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "MINISTRY_ACC_HEAD");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "MAP_ZONE");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "MAP_STRUCTURE_TYPE");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "MAP_STOREYS");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "MAP_STDHEIGHT_RW");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "MAP_SITE");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "MAP_ROOF_TYPE");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "MAP_ROOF_CNSTRCT_TYPE");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "MAP_REGION_FAR");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "MAP_RATE");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "MAP_NEIGHBOUR_TYPE");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "MAP_LAND_OWNER_TYPE");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "MAP_INCOME_TYPE");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "MAP_HTSTANDARD");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "MAP_HOUSEUSE_TYPE");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "MAP_FLOOR");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "MAP_DRAIN_TYPE");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "MAP_DIRECTION");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "MAP_DESIGNER_DTL");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "MAP_CONSTRCTION_KIND");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "MAP_AREA_GND_COV");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "MALPOT_LANDS");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "LELEDGER20682069");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "LANDSMULTIEVALUATIONDETAIL");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "LANDMEASURINGUNITS");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "ISSUEDBILLS");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "IPTTAXSUMMARY_HISTORY");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "InvYrlyPurPlan");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "InvPurType");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "INV_WAREHOUSE");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "INV_UNIT");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "INV_TYPE_SETUP");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "INV_TAX_RATE");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "INV_SUPPLIER_FISCALYEAR");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "INV_SUPPLIER");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "INV_SUP_ITM_DET");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "INV_ROOM_MST");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "INV_REQUISITION_MAST");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "INV_REQ_DETAIL");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "INV_PUR_ORDER_MAST");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "INV_PUR_ORDER_DETL");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "INV_PUR_MAST_PLAN");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "INV_PROJECT");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "INV_ORG_TYPE");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "INV_LILAMAPPDETAILS");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "INV_LILAM_REC_LIST");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "INV_LILAM_MAST");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "INV_LILAM_DETAIL");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "INV_LILAM_APPMASTER");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "INV_ITEM_STATUSCHECK");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "INV_ITEM_SPEC");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "INV_ITEM_DETAILS");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "INV_ITEM_ADJ_TYPE");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "INV_ISSUE_MASTER");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "INV_ISSUE_DETAIL");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "INV_ISSUE_DAKHILA");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "INV_INCREASE_DECREASE");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "INV_GOODS_REC_MAST");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "INV_GOODS_REC_DETL");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "INV_GOODS_ADJUST");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "INV_DEPT");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "INV_DEPRECIATION");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "INV_DEPLIST");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "INV_BRAND");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "INV_APPLICANT_RATE");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "INCOMEBILLMASTER");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "INCOMEBILLDETAILS_HISTORY");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "INCOMEBILLDETAILS");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "FYWISESANITATION_RATE");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "FYWISERENTDARRATE");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "FISCALYEARS");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "FIREBRIGADESTATE");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "EMP_GRP");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "CONSTANTVALUES");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "COLLECTIONCOUNTERS");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "CELEDGER20682069");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "CASHTRANSACTION");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "BUSINESSMASTER_HISTORY");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "BANKTRANSACTIONS");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "BANKMASTER");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "BANK_BRANCH");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "APPLICATION_CONFIGURATION");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "ACCODE");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "ACC_WORK_PAYMNT_TRANS");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "ACC_WORK_MASTER");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "ACC_WORK_FUNDS_DETAIL");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "ACC_VCHR_TYPE_MASTER");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "ACC_VCHR_MASTER");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "ACC_VCHR_DETAILS");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "ACC_USER_COMITE_MSTR");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "ACC_UNAUTHORISED");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "ACC_TRANS_TYPE");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "ACC_RECEIVABLE");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "ACC_PAYMENT_MASTER");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "ACC_PAYMENT_DETAILS");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "ACC_PAYMENT_DEDUCTION");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "ACC_PAYMENT_CREDIT");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "ACC_PAYMENT_CLEARANCE");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "ACC_PADADHIKARI_POST");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "ACC_PADADHIKARI_MSTR");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "ACC_LASTYEAR_ADV_DETAILS");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "ACC_LAST_YR_PESKI");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "ACC_INCOME_RATE");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "ACC_FUND_PROVIDR_MSTR");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "ACC_EXPENSES_DETAILS");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "ACC_DHRTI_BILL_MASTER");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "ACC_DHRTI_BILL_DTL");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "ACC_CURRENCTY_RATE");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "ACC_CURRENCTY");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "ACC_CHEQUE_TYPES");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "ACC_CASH_TRANS");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "ACC_BUDJET_SOURCE");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "ACC_BGT_TRANSFER");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "ACC_BGT_RVSN");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "ACC_BGT_ALLOCATE");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "ACC_BANK_TRANS");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "ACC_BANK_STATEMENT");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "ACC_BANK_GRNTY");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "ACC_ASULI_BIBARAN");

            migrationBuilder.AlterColumn<int>(
                name: "SN",
                table: "LELEDGER20682069",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "SN",
                table: "LANDSMULTIEVALUATIONDETAIL",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "UNITID",
                table: "LANDMEASURINGUNITS",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "IS_ACTIVE",
                table: "INV_WAREHOUSE",
                type: "character varying(1)",
                maxLength: 1,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IS_ACTIVE",
                table: "INV_UNIT",
                type: "character varying(1)",
                maxLength: 1,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IS_ACTIVE",
                table: "INV_TYPE_SETUP",
                type: "character varying(1)",
                maxLength: 1,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IS_ACTIVE",
                table: "INV_REQ_DETAIL",
                type: "character varying(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IS_ACTIVE",
                table: "INV_PROJECT",
                type: "character varying(1)",
                maxLength: 1,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IS_ACTIVE",
                table: "INV_ORG_TYPE",
                type: "character varying(1)",
                maxLength: 1,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IS_ACTIVE",
                table: "INV_ITEM_STATUSCHECK",
                type: "character varying(2)",
                maxLength: 2,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IS_ACTIVE",
                table: "INV_ITEM_SPEC",
                type: "character varying(1)",
                maxLength: 1,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IS_ACTIVE",
                table: "INV_DEPT",
                type: "character varying(1)",
                maxLength: 1,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IS_ACTIVE",
                table: "INV_BRAND",
                type: "character varying(1)",
                maxLength: 1,
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SN",
                table: "ACC_RECEIVABLE",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
