using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace IMIS_DataEntity.Migrations
{
    public partial class Phase1_Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ACC_BANK_STATEMENT",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: true),
                    BANK_ID = table.Column<int>(nullable: true),
                    TRANSACTION_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    TRANSACTION_DATE_EN = table.Column<DateTime>(nullable: true),
                    CHEQUE_NO = table.Column<string>(maxLength: 30, nullable: true),
                    DESCRIPTION = table.Column<string>(maxLength: 100, nullable: true),
                    DR_AMT = table.Column<float>(nullable: true),
                    CR_AMT = table.Column<float>(nullable: true),
                    BANK_TRANSACTION_ID = table.Column<int>(nullable: true),
                    BALANCE = table.Column<float>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ACC_BGT_ALLOCATE",
                columns: table => new
                {
                    BGT_ALLOCATE_ID = table.Column<int>(nullable: false),
                    ACC_ID = table.Column<int>(nullable: true),
                    REVISED_AMOUNT = table.Column<float>(nullable: true),
                    AMOUNT = table.Column<float>(nullable: true),
                    FISCAL_YEAR = table.Column<string>(maxLength: 10, nullable: true),
                    ALLOCATED_DATE_NP = table.Column<string>(maxLength: 10, nullable: true),
                    ENTRY_USER_ID = table.Column<int>(nullable: true),
                    ENTRY_DATETIME = table.Column<DateTime>(nullable: true),
                    UPDATE_USER_ID = table.Column<int>(nullable: true),
                    UPDATE_DATETIME = table.Column<DateTime>(nullable: true),
                    SUB_MODULE_ID = table.Column<int>(nullable: true),
                    BUDGET_SOURCE_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ACC_BGT_ALLOCATE_pkey", x => x.BGT_ALLOCATE_ID);
                });

            migrationBuilder.CreateTable(
                name: "ACC_CHEQUE_TYPES",
                columns: table => new
                {
                    CHEQUE_TYPE_ID = table.Column<short>(nullable: false),
                    CHEQUE_TYPE = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ACC_CHEQUE_TYPES_pkey", x => x.CHEQUE_TYPE_ID);
                });

            migrationBuilder.CreateTable(
                name: "ACC_CURRENCTY",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    NP_NAME = table.Column<string>(nullable: true),
                    ENG_NAME = table.Column<string>(nullable: true),
                    SYMBOL = table.Column<string>(maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ACC_CURRENCTY", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ACC_FUND_PROVIDR_MSTR",
                columns: table => new
                {
                    PROVIDER_ID = table.Column<int>(nullable: false),
                    NAME_NP = table.Column<string>(maxLength: 70, nullable: false),
                    NAME_EN = table.Column<string>(maxLength: 50, nullable: false),
                    PHONES = table.Column<string>(maxLength: 50, nullable: true),
                    EMAILS = table.Column<string>(maxLength: 50, nullable: true),
                    CHAIRMAN = table.Column<string>(maxLength: 70, nullable: true),
                    CONTACT_PERSON = table.Column<string>(maxLength: 70, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ACC_FUND_PROVIDR_MSTR_pkey", x => x.PROVIDER_ID);
                });

            migrationBuilder.CreateTable(
                name: "ACC_INCOME_RATE",
                columns: table => new
                {
                    RATE_ID = table.Column<int>(nullable: false),
                    ACC_ID = table.Column<int>(nullable: true),
                    RATE = table.Column<int>(nullable: true),
                    FISCAL_YEAR = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ACC_INCOME_RATE_pkey", x => x.RATE_ID);
                });

            migrationBuilder.CreateTable(
                name: "ACC_LAST_YR_PESKI",
                columns: table => new
                {
                    SN = table.Column<int>(nullable: false),
                    PERSON_TYPE_ID = table.Column<int>(nullable: true),
                    PERSON_ID = table.Column<int>(nullable: true),
                    ADVANCE_TYPE = table.Column<string>(maxLength: 1, nullable: true),
                    SUB_MODULE_ID = table.Column<int>(nullable: true),
                    TOTAL_PES_REM = table.Column<float>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ACC_LAST_YR_PESKI_pkey", x => x.SN);
                });

            migrationBuilder.CreateTable(
                name: "ACC_LASTYEAR_ADV_DETAILS",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    PAYMENT_ID = table.Column<int>(nullable: true),
                    FISCAL_YEAR = table.Column<string>(maxLength: 15, nullable: true),
                    WORK_ID = table.Column<int>(nullable: true),
                    VHCR_ID = table.Column<int>(nullable: true),
                    ACC_ID = table.Column<int>(nullable: true),
                    BUDGET_ACC_ID = table.Column<int>(nullable: true),
                    BUDGET_SOURCE_ID = table.Column<int>(nullable: true),
                    PAYMENT_TYPE_ID = table.Column<int>(nullable: true),
                    PERSON_ID = table.Column<int>(nullable: true),
                    DR_AMOUNT = table.Column<float>(nullable: true),
                    STATUS = table.Column<string>(maxLength: 2, nullable: true),
                    REMARKS = table.Column<string>(maxLength: 255, nullable: true),
                    ADD_USER_ID = table.Column<int>(nullable: true),
                    ADD_DATE = table.Column<string>(maxLength: 15, nullable: true),
                    VOUCHER_NO = table.Column<string>(maxLength: 50, nullable: true),
                    VOUCHER_DATE = table.Column<string>(maxLength: 15, nullable: true),
                    LAST_YR_PESKI_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ACC_LASTYEAR_ADV_DETAILS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ACC_ORG_MASTER",
                columns: table => new
                {
                    ORG_ID = table.Column<int>(nullable: false),
                    NAME_NP = table.Column<string>(maxLength: 90, nullable: true),
                    NAME_EN = table.Column<string>(maxLength: 90, nullable: true),
                    ADDRESS = table.Column<string>(maxLength: 90, nullable: true),
                    PHONES = table.Column<string>(maxLength: 40, nullable: true),
                    EMAILS = table.Column<string>(maxLength: 100, nullable: true),
                    REG_NO = table.Column<string>(maxLength: 25, nullable: true),
                    VAT_NO = table.Column<string>(maxLength: 25, nullable: true),
                    PAN_NO = table.Column<string>(maxLength: 25, nullable: true),
                    ZONE = table.Column<int>(nullable: true),
                    DISTRICT = table.Column<int>(nullable: true),
                    VDC = table.Column<int>(nullable: true),
                    MINISTRY = table.Column<int>(nullable: true),
                    CODE = table.Column<string>(maxLength: 30, nullable: true),
                    HEAD = table.Column<string>(maxLength: 50, nullable: true),
                    MOBILE_NO = table.Column<string>(maxLength: 20, nullable: true),
                    RELATED_PERSON = table.Column<string>(maxLength: 100, nullable: true),
                    ORG_MASTER_ID = table.Column<int>(nullable: true),
                    SAPATI = table.Column<string>(maxLength: 2, nullable: true),
                    ORC_ACC_TYPE_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ACC_ORG_MASTER_pkey", x => x.ORG_ID);
                });

            migrationBuilder.CreateTable(
                name: "ACC_PADADHIKARI_POST",
                columns: table => new
                {
                    POST_ID = table.Column<int>(nullable: false),
                    NAME_NP = table.Column<string>(maxLength: 70, nullable: true),
                    NAME_EN = table.Column<string>(maxLength: 50, nullable: true),
                    DURATION_IN_YRS = table.Column<int>(nullable: true),
                    POST_LEVEL = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ACC_PADADHIKARI_POST_pkey", x => x.POST_ID);
                });

            migrationBuilder.CreateTable(
                name: "ACC_PAYMENT_CREDIT",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    PAYMENT_ID = table.Column<int>(nullable: true),
                    IS_OF_LAST_YEAR = table.Column<string>(maxLength: 1, nullable: true),
                    ACC_ID = table.Column<int>(nullable: true),
                    BUDGET_ACC_ID = table.Column<int>(nullable: true),
                    BUDGET_SOURCE_ID = table.Column<int>(nullable: true),
                    AMOUNT = table.Column<float>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ACC_RECEIVABLE",
                columns: table => new
                {
                    SN = table.Column<int>(nullable: true),
                    TAXPAYERID = table.Column<int>(nullable: true),
                    FISCALYEAR = table.Column<string>(maxLength: 10, nullable: true),
                    NETTAXAMOUNT = table.Column<float>(nullable: true),
                    FINEAMOUNT = table.Column<float>(nullable: true),
                    ADDITIONALCHARGES = table.Column<float>(nullable: true),
                    REDUCTIONALCHARGES = table.Column<float>(nullable: true),
                    TAXTYPE = table.Column<string>(maxLength: 5, nullable: true),
                    TYPE = table.Column<int>(nullable: true),
                    VCHRID = table.Column<int>(nullable: true),
                    VCHR_DATE = table.Column<string>(maxLength: 12, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ACC_SUB_MODULE_TYPE",
                columns: table => new
                {
                    SUB_MODULE_ID = table.Column<int>(nullable: false),
                    NAME_NP = table.Column<string>(maxLength: 70, nullable: false),
                    NAME_EN = table.Column<string>(maxLength: 50, nullable: false),
                    MODULE = table.Column<string>(maxLength: 2, nullable: false),
                    CODE = table.Column<string>(maxLength: 50, nullable: true),
                    ISCAPITAL = table.Column<int>(nullable: true),
                    BUDGET_ACC_NO = table.Column<string>(maxLength: 50, nullable: true),
                    ISEXPENCES = table.Column<int>(nullable: true),
                    ACC_EXPENCES_CODE = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ACC_SUB_MODULE_TYPE_pkey", x => x.SUB_MODULE_ID);
                });

            migrationBuilder.CreateTable(
                name: "ACC_TRANS_TYPE",
                columns: table => new
                {
                    TYPE_ID = table.Column<int>(nullable: false),
                    TYPE_CODE = table.Column<string>(maxLength: 10, nullable: false),
                    NEP_NAME = table.Column<string>(maxLength: 70, nullable: false),
                    ENG_NAME = table.Column<string>(maxLength: 50, nullable: true),
                    MODULE = table.Column<string>(maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ACC_TRANS_TYPE_pkey", x => x.TYPE_ID);
                });

            migrationBuilder.CreateTable(
                name: "ACC_UNAUTHORISED",
                columns: table => new
                {
                    UNAUTHORISED_ID = table.Column<int>(nullable: false),
                    SUB_MODULE_ID = table.Column<int>(nullable: true),
                    WORK_ID = table.Column<int>(nullable: true),
                    UNAUTHORISED_DAFA_ID = table.Column<int>(nullable: true),
                    UNAUTHORISED_AMT = table.Column<int>(nullable: true),
                    INSPECT_DATE = table.Column<string>(maxLength: 20, nullable: true),
                    INSPECT_DETAILS = table.Column<string>(maxLength: 200, nullable: true),
                    INSPECT_AMT = table.Column<int>(nullable: true),
                    FILLEDBY_EMPID = table.Column<int>(nullable: true),
                    VERIFIEDBY_EMPID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ACC_UNAUTHORISED_pkey", x => x.UNAUTHORISED_ID);
                });

            migrationBuilder.CreateTable(
                name: "ACC_USER_COMITE_MSTR",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    NEP_NAME = table.Column<string>(maxLength: 150, nullable: true),
                    ENG_NAME = table.Column<string>(maxLength: 70, nullable: true),
                    WARD = table.Column<int>(nullable: true),
                    ADDRESS = table.Column<string>(maxLength: 90, nullable: true),
                    EMAIL = table.Column<string>(maxLength: 50, nullable: true),
                    PHONES = table.Column<string>(maxLength: 50, nullable: true),
                    CHAIRMAN = table.Column<string>(maxLength: 70, nullable: true),
                    CONCERN_PERSON = table.Column<string>(maxLength: 70, nullable: true),
                    MOBILE_NO = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ACC_USER_COMITE_MSTR", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ACC_VCHR_TYPE_MASTER",
                columns: table => new
                {
                    VCHR_TYPE_ID = table.Column<int>(nullable: false),
                    NEP_NAME = table.Column<string>(maxLength: 100, nullable: true),
                    ENG_NAME = table.Column<string>(maxLength: 100, nullable: true),
                    MODULE = table.Column<string>(maxLength: 2, nullable: false),
                    ISAUTOMATIC = table.Column<string>(maxLength: 1, nullable: true),
                    ISFIXED = table.Column<string>(maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ACC_VCHR_TYPE_MASTER_pkey", x => x.VCHR_TYPE_ID);
                });

            migrationBuilder.CreateTable(
                name: "ACC_WORK_MASTER",
                columns: table => new
                {
                    WORK_ID = table.Column<int>(nullable: false),
                    NAME_NP = table.Column<string>(maxLength: 90, nullable: true),
                    NAME_EN = table.Column<string>(maxLength: 50, nullable: true),
                    ESTIMATED_AMT = table.Column<float>(nullable: true),
                    VARIATION_AMT = table.Column<float>(nullable: true),
                    CORRECTED_AMT = table.Column<float>(nullable: true),
                    FINAL_ACTUAL_AMT_TOBE_PAID = table.Column<float>(nullable: true),
                    TOTAL_ACTUAL_COST = table.Column<float>(nullable: true),
                    AGREEMENT_PARTY = table.Column<string>(maxLength: 70, nullable: true),
                    AGREEMENT_AMT = table.Column<float>(nullable: true),
                    AGREEMENT_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    AGREEMENT_EXPIRY_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    WORK_COMPLETE_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    MEASURE_BOOK_NO = table.Column<string>(maxLength: 70, nullable: true),
                    DEPOSIT_AMT = table.Column<float>(nullable: true),
                    BANK_GUARANTEE_AMT = table.Column<float>(nullable: true),
                    DEPOSIT_RELEASE_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    DEPOSIT_RELEASED_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    WARD_NO = table.Column<int>(nullable: true),
                    IS_COMPLETED = table.Column<string>(maxLength: 1, nullable: true),
                    DEADLINE_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    TP_NO = table.Column<string>(maxLength: 25, nullable: true),
                    BANKID = table.Column<int>(nullable: true),
                    EMP_ID = table.Column<int>(nullable: true),
                    PARTY_PERSONTYPEID = table.Column<int>(nullable: true),
                    PARTY_ID = table.Column<int>(nullable: true),
                    PERSON_PERSONTYPEID = table.Column<int>(nullable: true),
                    PERSON_ID = table.Column<int>(nullable: true),
                    DEPOSITS_ACC_ID = table.Column<int>(nullable: true),
                    DEPOSITS_FORFEIT_ACC_ID = table.Column<int>(nullable: true),
                    IS_KRAMAGAT = table.Column<string>(maxLength: 1, nullable: true),
                    YOJANA_NATUR_ID = table.Column<int>(nullable: true),
                    AGREEMENT_SIGNING_PERSON = table.Column<string>(maxLength: 70, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ACC_WORK_MASTER_pkey", x => x.WORK_ID);
                });

            migrationBuilder.CreateTable(
                name: "ACCODE",
                columns: table => new
                {
                    ACCODE = table.Column<int>(nullable: false),
                    SBCODE = table.Column<int>(nullable: true),
                    GRCODE = table.Column<int>(nullable: true),
                    TRANTYPE = table.Column<string>(maxLength: 1, nullable: true),
                    NEPNAME = table.Column<string>(maxLength: 70, nullable: true),
                    ENGNAME = table.Column<string>(maxLength: 50, nullable: true),
                    ISDOLLAR = table.Column<string>(maxLength: 2, nullable: true),
                    LOCALCODE = table.Column<string>(maxLength: 20, nullable: true),
                    ISASSIGNED = table.Column<string>(maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ACCODE_pkey", x => x.ACCODE);
                });

            migrationBuilder.CreateTable(
                name: "APPLICATION_CONFIGURATION",
                columns: table => new
                {
                    SN = table.Column<short>(nullable: false),
                    NAME_CONFIG = table.Column<string>(maxLength: 70, nullable: true),
                    VALUE_CONFIG = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("APPLICATION_CONFIGURATION_pkey", x => x.SN);
                });
  
            migrationBuilder.CreateTable(
                name: "BANKMASTER",
                columns: table => new
                {
                    BANKID = table.Column<int>(nullable: false),
                    ENGNAME = table.Column<string>(maxLength: 100, nullable: true),
                    NEPNAME = table.Column<string>(maxLength: 100, nullable: true),
                    BANKCODE = table.Column<string>(maxLength: 50, nullable: true),
                    SUB_MODULE_ID = table.Column<int>(nullable: true),
                    ADDRESS = table.Column<string>(maxLength: 100, nullable: true),
                    PHONES = table.Column<string>(maxLength: 40, nullable: true),
                    EMAILS = table.Column<string>(maxLength: 100, nullable: true),
                    ACCOUNTNUMBER = table.Column<string>(maxLength: 25, nullable: true),
                    BRANCHCODE = table.Column<string>(maxLength: 200, nullable: true),
                    TRANCODE = table.Column<string>(maxLength: 200, nullable: true),
                    CYCODE = table.Column<string>(maxLength: 200, nullable: true),
                    FINANCEL_INSTITUTE_ID = table.Column<int>(nullable: true),
                    BRANCH = table.Column<string>(maxLength: 50, nullable: true),
                    BANKNAME = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("BANKMASTER_pkey", x => x.BANKID);
                });

            migrationBuilder.CreateTable(
                name: "BUDJET_SOURCE",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    PARENT_ID = table.Column<int>(nullable: true),
                    COUNTRY_ID = table.Column<int>(nullable: true),
                    CODE = table.Column<string>(maxLength: 70, nullable: true),
                    EMAIL = table.Column<string>(maxLength: 50, nullable: true),
                    PHONE = table.Column<string>(maxLength: 50, nullable: true),
                    ADDRESS = table.Column<string>(maxLength: 100, nullable: true),
                    NEP_NAME = table.Column<string>(maxLength: 100, nullable: true),
                    ENG_NAME = table.Column<string>(maxLength: 100, nullable: true),
                    REMARKS = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BUDJET_SOURCE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BUDJET_SUB_HEAD",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: true),
                    CODE = table.Column<string>(maxLength: 70, nullable: true),
                    MINISTRY_ID = table.Column<int>(nullable: true),
                    MINISTRY_CODE = table.Column<string>(maxLength: 70, nullable: true),
                    PARENT_CODE = table.Column<int>(nullable: true),
                    FISCAL_YEAR = table.Column<string>(maxLength: 70, nullable: true),
                    NEPNAME = table.Column<string>(maxLength: 70, nullable: true),
                    ENGNAME = table.Column<string>(maxLength: 70, nullable: true),
                    REMARKS = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "BUSINESSMASTER_HISTORY",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: true),
                    BIZ_ID = table.Column<int>(nullable: true),
                    NEPNAME = table.Column<string>(maxLength: 70, nullable: true),
                    BUSINESSGROUPID = table.Column<int>(nullable: true),
                    TAXPAYERID = table.Column<int>(nullable: true),
                    ADD_DATE = table.Column<DateTime>(nullable: true),
                    COMPUTER_NAME = table.Column<string>(maxLength: 100, nullable: true),
                    DATA_STATUS = table.Column<string>(maxLength: 20, nullable: true),
                    WINDOWS_USER = table.Column<string>(maxLength: 100, nullable: true),
                    TRAN_TIME = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CELEDGER20682069",
                columns: table => new
                {
                    SN = table.Column<int>(nullable: true),
                    IID = table.Column<int>(nullable: true),
                    HOUSEID = table.Column<int>(nullable: true),
                    CONSTRUCTIONTYPEID = table.Column<int>(nullable: true),
                    CONSTRUCTIONID = table.Column<int>(nullable: true),
                    TALANUMBER = table.Column<int>(nullable: true),
                    TOTALAREA = table.Column<int>(nullable: true),
                    RATEID = table.Column<int>(nullable: true),
                    RATEPERUNIT = table.Column<int>(nullable: true),
                    CALCULATEDVALUE = table.Column<int>(nullable: true),
                    VSDATEOFMADE = table.Column<string>(maxLength: 10, nullable: true),
                    DEPPERCENT = table.Column<int>(nullable: true),
                    DEPRECIATIONAMOUNT = table.Column<int>(nullable: true),
                    OTHERPLUSINEVALUATIONS = table.Column<int>(nullable: true),
                    OTHERMINUSINEVALUATIONS = table.Column<int>(nullable: true),
                    OTHERPLUSMINUSDESCRIPTIONS = table.Column<string>(maxLength: 90, nullable: true),
                    NETCALCULATEDVALUE = table.Column<int>(nullable: true),
                    NONCOMPLETIONREASONID = table.Column<int>(nullable: true),
                    NONCOMPLETIONREASONS = table.Column<string>(maxLength: 90, nullable: true),
                    REMARKS = table.Column<string>(maxLength: 90, nullable: true),
                    SPACEMEASURINGUNIT = table.Column<int>(nullable: true),
                    TAXED = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "COLLECTIONCOUNTERS",
                columns: table => new
                {
                    COUNTERID = table.Column<int>(nullable: false),
                    NEPNAME = table.Column<string>(maxLength: 50, nullable: true),
                    COUNTERHEADID = table.Column<int>(nullable: true),
                    WARDNO = table.Column<int>(nullable: true),
                    LOCATION = table.Column<string>(maxLength: 50, nullable: true),
                    SPECIALNOTES = table.Column<string>(maxLength: 90, nullable: true),
                    CMPTR_NAME = table.Column<string>(maxLength: 50, nullable: true),
                    MACADDRESS = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("COLLECTIONCOUNTERS_pkey", x => x.COUNTERID);
                });

            migrationBuilder.CreateTable(
                name: "CONSTANTVALUES",
                columns: table => new
                {
                    SN = table.Column<int>(nullable: true),
                    VARNAME = table.Column<string>(maxLength: 50, nullable: true),
                    STRVALUE = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CONTACTS",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    NEPNAME = table.Column<string>(maxLength: 100, nullable: true),
                    ENGNAME = table.Column<string>(maxLength: 100, nullable: true),
                    CODE = table.Column<string>(maxLength: 50, nullable: true),
                    DISTRICTID = table.Column<int>(nullable: true),
                    REMARKS = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONTACTS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "COUNTRY",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: true),
                    NEPNAME = table.Column<string>(maxLength: 50, nullable: false),
                    ENGNAME = table.Column<string>(maxLength: 50, nullable: false),
                    CODE = table.Column<string>(maxLength: 50, nullable: true),
                    REMARKS = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "DDC",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: true),
                    NEPNAME = table.Column<string>(maxLength: 50, nullable: false),
                    ENGNAME = table.Column<string>(maxLength: 50, nullable: false),
                    CODE = table.Column<string>(maxLength: 50, nullable: true),
                    REMARKS = table.Column<string>(maxLength: 100, nullable: true),
                    DISTRICTID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "DEV_REGION",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: true),
                    NEPNAME = table.Column<string>(maxLength: 50, nullable: false),
                    ENGNAME = table.Column<string>(maxLength: 50, nullable: false),
                    CODE = table.Column<string>(maxLength: 50, nullable: true),
                    REMARKS = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "DISTRICT",
                columns: table => new
                {
                    DISTRICTID = table.Column<int>(nullable: true),
                    NEPNAME = table.Column<string>(maxLength: 50, nullable: false),
                    ENGNAME = table.Column<string>(maxLength: 50, nullable: false),
                    CODE = table.Column<string>(maxLength: 50, nullable: true),
                    REMARKS = table.Column<string>(maxLength: 100, nullable: true),
                    ZONEID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "EMP_GRP",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    NEPNAME = table.Column<string>(maxLength: 80, nullable: true),
                    ENGNAME = table.Column<string>(maxLength: 80, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EMP_GRP", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FISCALYEARS",
                columns: table => new
                {
                    SN = table.Column<int>(nullable: true),
                    FISCALYEAR = table.Column<string>(maxLength: 9, nullable: true),
                    DATEFROM = table.Column<string>(maxLength: 10, nullable: true),
                    DATETO = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "FYWISERENTDARRATE",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    RATEID = table.Column<int>(nullable: true),
                    RATENAME = table.Column<string>(maxLength: 100, nullable: true),
                    RENT_PER = table.Column<float>(nullable: true),
                    RENT_TYPEID = table.Column<int>(nullable: true),
                    FISCAL_YEAR = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FYWISERENTDARRATE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FYWISESANITATION_RATE",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    RATEID = table.Column<int>(nullable: true),
                    GROUPID = table.Column<int>(nullable: true),
                    SUBGROUPID = table.Column<int>(nullable: true),
                    ROAD_TYPEID = table.Column<int>(nullable: true),
                    RATENAME = table.Column<string>(nullable: true),
                    RATE = table.Column<float>(nullable: true),
                    FISCAL_YEAR = table.Column<string>(maxLength: 10, nullable: true),
                    AREA_UPTO = table.Column<int>(nullable: true),
                    FOR_EACH_AREA = table.Column<int>(nullable: true),
                    EACH_AREA_RATE = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Imis_Menu",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MenuName = table.Column<string>(nullable: true),
                    MenuUrl = table.Column<string>(nullable: true),
                    DisplayName = table.Column<string>(nullable: true),
                    ParentMenuId = table.Column<int>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    IsLocked = table.Column<bool>(nullable: false),
                    Visible = table.Column<bool>(nullable: false),
                    Icon = table.Column<string>(nullable: true),
                    MenuOrder = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdateBy = table.Column<string>(nullable: true),
                    DisplayNepName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DisplayNameNep = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imis_Menu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "INCOMEBILLDETAILS_HISTORY",
                columns: table => new
                {
                    SN = table.Column<int>(nullable: true),
                    SN_INCOMEBILLDTL = table.Column<int>(nullable: true),
                    BILLID = table.Column<int>(nullable: true),
                    BILLNO = table.Column<string>(maxLength: 25, nullable: true),
                    BILLDATE = table.Column<string>(maxLength: 10, nullable: true),
                    COUNTERID = table.Column<int>(nullable: true),
                    PERSONID = table.Column<int>(nullable: true),
                    ACCODE = table.Column<int>(nullable: true),
                    AMOUNT = table.Column<int>(nullable: true),
                    VRNO = table.Column<int>(nullable: true),
                    VCHR_DATE_NP = table.Column<string>(maxLength: 10, nullable: true),
                    ORDERINBILL = table.Column<int>(nullable: true),
                    REMARKS = table.Column<string>(maxLength: 200, nullable: true),
                    VCHR_ID = table.Column<int>(nullable: true),
                    ACC_ID = table.Column<int>(nullable: true),
                    FISCAL_YEAR = table.Column<string>(maxLength: 10, nullable: true),
                    PROJECT = table.Column<string>(maxLength: 10, nullable: true),
                    TAXADDTNLID = table.Column<int>(nullable: true),
                    QTY = table.Column<int>(nullable: true),
                    BUDGET_SOURCE_ID = table.Column<int>(nullable: true),
                    TAX_TYPE = table.Column<string>(maxLength: 5, nullable: true),
                    BACKUP_PERSONID = table.Column<int>(nullable: true),
                    ADD_DATE = table.Column<DateTime>(nullable: true),
                    COMPUTER_NAME = table.Column<string>(maxLength: 100, nullable: true),
                    DATA_STATUS = table.Column<string>(maxLength: 20, nullable: true),
                    WINDOWS_USER = table.Column<string>(maxLength: 100, nullable: true),
                    TRAN_TIME = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "INV_APPLICANT_RATE",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    APPLICANTID = table.Column<int>(nullable: true),
                    ITEM_DETAIL_ID = table.Column<int>(nullable: true),
                    AMOUNT = table.Column<float>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INV_APPLICANT_RATE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "INV_BRAND",
                columns: table => new
                {
                    BRAND_ID = table.Column<int>(nullable: false),
                    NAME_NP = table.Column<string>(maxLength: 50, nullable: false),
                    NAME_EN = table.Column<string>(maxLength: 50, nullable: true),
                    IS_ACTIVE = table.Column<string>(maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("INV_BRAND_pkey", x => x.BRAND_ID);
                });

            migrationBuilder.CreateTable(
                name: "INV_DEPLIST",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    FISCALYEAR = table.Column<string>(maxLength: 10, nullable: true),
                    DAKHILA_ID = table.Column<int>(nullable: true),
                    ITEM_ID = table.Column<int>(nullable: true),
                    QTY = table.Column<float>(nullable: true),
                    PURCHASE_DATE = table.Column<string>(maxLength: 15, nullable: true),
                    PURCHASE_AMT = table.Column<float>(nullable: true),
                    BRAND_ID = table.Column<int>(nullable: true),
                    SPEC_ID = table.Column<int>(nullable: true),
                    UNIT_ID = table.Column<int>(nullable: true),
                    DEPRE_DURATON = table.Column<float>(nullable: true),
                    DEPRE_PER = table.Column<int>(nullable: true),
                    DEPRE_AMT = table.Column<float>(nullable: true),
                    MAX_DEPRE_AMT = table.Column<float>(nullable: true),
                    MIN_DEPRE_AMT = table.Column<float>(nullable: true),
                    DEDUCT_AMT = table.Column<float>(nullable: true),
                    NET_AMT = table.Column<float>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INV_DEPLIST", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "INV_DEPRECIATION",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    FISCALYEAR = table.Column<string>(maxLength: 10, nullable: true),
                    DAKHILA_ID = table.Column<int>(nullable: true),
                    ITEM_ID = table.Column<int>(nullable: true),
                    BRAND_ID = table.Column<int>(nullable: true),
                    SPEC_ID = table.Column<int>(nullable: true),
                    UNIT_ID = table.Column<int>(nullable: true),
                    QTY = table.Column<float>(nullable: true),
                    ORGINAL_RATE = table.Column<float>(nullable: true),
                    DEPRE_RATE = table.Column<float>(nullable: true),
                    DEPRE_PER = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INV_DEPRECIATION", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "INV_DEPT",
                columns: table => new
                {
                    DEPT_ID = table.Column<int>(nullable: false),
                    NAME_NP = table.Column<string>(maxLength: 50, nullable: false),
                    NAME_EN = table.Column<string>(maxLength: 50, nullable: true),
                    OFFICE_ID = table.Column<int>(nullable: true),
                    IS_ACTIVE = table.Column<string>(maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("INV_DEPT_pkey", x => x.DEPT_ID);
                });

            migrationBuilder.CreateTable(
                name: "INV_INCREASE_DECREASE",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    NUM_ID = table.Column<int>(nullable: true),
                    DAKHILA_ID = table.Column<int>(nullable: true),
                    ITEM_ID = table.Column<int>(nullable: true),
                    BRAND_ID = table.Column<int>(nullable: true),
                    SPEC_ID = table.Column<int>(nullable: true),
                    UNIT_ID = table.Column<int>(nullable: true),
                    PURCHASE_DATE = table.Column<string>(maxLength: 30, nullable: true),
                    STOCK_QTY = table.Column<float>(nullable: true),
                    AMOUNT = table.Column<float>(nullable: true),
                    SCAP_AMOUNT = table.Column<float>(nullable: true),
                    FISCALYEAR = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INV_INCREASE_DECREASE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "INV_ISSUE_DAKHILA",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    ITEM_ID = table.Column<int>(nullable: true),
                    SPEC_ID = table.Column<int>(nullable: true),
                    BRAND_ID = table.Column<int>(nullable: true),
                    UNIT_ID = table.Column<int>(nullable: true),
                    ISSUE_DETAIL_ID = table.Column<int>(nullable: true),
                    ISSU_MASTER_ID = table.Column<int>(nullable: true),
                    DAKHILA_ID = table.Column<int>(nullable: true),
                    ISSUE_NO = table.Column<float>(nullable: true),
                    REMARKS = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INV_ISSUE_DAKHILA", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "INV_ITEM_ADJ_TYPE",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    NAME_NP = table.Column<string>(maxLength: 50, nullable: false),
                    NAME_EN = table.Column<string>(maxLength: 50, nullable: true),
                    ADD_SUB = table.Column<string>(maxLength: 15, nullable: true),
                    ADJ_TYPE = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INV_ITEM_ADJ_TYPE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "INV_ITEM_CATEGORY",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    NAME_NP = table.Column<string>(maxLength: 50, nullable: false),
                    NAME_EN = table.Column<string>(maxLength: 50, nullable: true),
                    PARENT_ID = table.Column<int>(nullable: true),
                    GRP_LEVEL = table.Column<int>(nullable: true),
                    IS_HEADER = table.Column<int>(nullable: true),
                    ISEXP = table.Column<short>(nullable: true),
                    ISLAST = table.Column<short>(nullable: true),
                    CODE = table.Column<string>(maxLength: 10, nullable: true),
                    UNIT = table.Column<int>(nullable: true),
                    MINL = table.Column<int>(nullable: true),
                    MAXL = table.Column<int>(nullable: true),
                    RMINL = table.Column<int>(nullable: true),
                    RMAXL = table.Column<int>(nullable: true),
                    DEPRECIATION_PER = table.Column<decimal>(nullable: true),
                    DEPRECIATION_MIN = table.Column<decimal>(nullable: true),
                    DEPRECIATION_MAX = table.Column<decimal>(nullable: true),
                    REMARKS = table.Column<string>(maxLength: 100, nullable: true),
                    ITEM_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INV_ITEM_CATEGORY", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "INV_ITEM_SPEC",
                columns: table => new
                {
                    SPEC_ID = table.Column<int>(nullable: false),
                    NAME_NP = table.Column<string>(maxLength: 50, nullable: false),
                    NAME_EN = table.Column<string>(maxLength: 50, nullable: true),
                    IS_ACTIVE = table.Column<string>(maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("INV_ITEM_SPEC_pkey", x => x.SPEC_ID);
                });

            migrationBuilder.CreateTable(
                name: "INV_LILAM_APPMASTER",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    APPNO = table.Column<int>(nullable: true),
                    PROJID = table.Column<int>(nullable: true),
                    APPLYLILAMID = table.Column<int>(nullable: true),
                    ORGAPPLICANTNAME = table.Column<string>(maxLength: 50, nullable: true),
                    ORGAPPLICANTPOST = table.Column<string>(maxLength: 50, nullable: true),
                    APPLYDATE = table.Column<string>(maxLength: 10, nullable: true),
                    APPLYENGDATE = table.Column<DateTime>(nullable: true),
                    REMARKS = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INV_LILAM_APPMASTER", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "INV_LILAM_DETAIL",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    MINIMUMRATE = table.Column<float>(nullable: true),
                    LILAM_ID = table.Column<int>(nullable: true),
                    DAKHILAID = table.Column<int>(nullable: true),
                    NIKASHAID = table.Column<int>(nullable: true),
                    ITEM_ID = table.Column<int>(nullable: true),
                    UNIT_ID = table.Column<int>(nullable: true),
                    SPEC_ID = table.Column<int>(nullable: true),
                    BRAND_ID = table.Column<int>(nullable: true),
                    ITEM_TYPE = table.Column<int>(nullable: true),
                    ITEM_ISSUE_NO = table.Column<float>(nullable: true),
                    TOTAL_IN_STOCK = table.Column<float>(nullable: true),
                    DEP_AMT = table.Column<float>(nullable: true),
                    ISSUE_DT = table.Column<string>(maxLength: 10, nullable: true),
                    DELIVERY_STATUS = table.Column<string>(maxLength: 1, nullable: true),
                    REMARKS = table.Column<string>(nullable: true),
                    ISSUE_DT_ENG = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INV_LILAM_DETAIL", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "INV_LILAM_MAST",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    LILAM_NO = table.Column<string>(maxLength: 50, nullable: false),
                    ISSUE_BY = table.Column<int>(nullable: true),
                    LILAMTYPE = table.Column<int>(nullable: true),
                    RECEIVE_BY = table.Column<int>(nullable: true),
                    RECEIVE_PERSON_NAME = table.Column<string>(maxLength: 50, nullable: true),
                    RECIVE_PERSON_POST = table.Column<string>(maxLength: 50, nullable: true),
                    REMARKS = table.Column<string>(nullable: true),
                    PREP_BY = table.Column<int>(nullable: true),
                    CHECK_BY = table.Column<int>(nullable: true),
                    ISSUE_DT = table.Column<string>(maxLength: 10, nullable: true),
                    ACCEPT_BY = table.Column<int>(nullable: true),
                    ACCEPT_DT = table.Column<string>(maxLength: 10, nullable: true),
                    PREP_DT = table.Column<string>(maxLength: 10, nullable: true),
                    CHECK_DT = table.Column<string>(maxLength: 10, nullable: true),
                    ISSUE_DT_ENG = table.Column<DateTime>(nullable: true),
                    PREP_DT_ENG = table.Column<DateTime>(nullable: true),
                    CHECK_DT_ENG = table.Column<DateTime>(nullable: true),
                    FISCAL_YEAR = table.Column<string>(maxLength: 10, nullable: true),
                    ACCEPT_DT_ENG = table.Column<DateTime>(nullable: true),
                    PAGENO = table.Column<string>(maxLength: 200, nullable: true),
                    REGISTERNO = table.Column<string>(maxLength: 200, nullable: true),
                    PUBLISH_DATE = table.Column<string>(maxLength: 20, nullable: true),
                    DESCRIPTION = table.Column<string>(maxLength: 200, nullable: true),
                    NEWSPAPER_NAME = table.Column<string>(maxLength: 200, nullable: true),
                    PERNEWS_RATE = table.Column<float>(nullable: true),
                    ACCEPT_PERCENT = table.Column<float>(nullable: true),
                    BANKID = table.Column<int>(nullable: true),
                    VALID_DAYS = table.Column<int>(nullable: true),
                    FISCALYEAR_CHUKTA = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INV_LILAM_MAST", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "INV_LILAM_REC_LIST",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: true),
                    REC_DATE_NP = table.Column<string>(maxLength: 10, nullable: true),
                    APPLICANTID = table.Column<int>(nullable: true),
                    EMP_ID = table.Column<int>(nullable: true),
                    USER_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "INV_ORG_TYPE",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    NAME_NP = table.Column<string>(maxLength: 50, nullable: false),
                    NAME_EN = table.Column<string>(maxLength: 50, nullable: true),
                    IS_ACTIVE = table.Column<string>(maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INV_ORG_TYPE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "INV_PROJECT",
                columns: table => new
                {
                    PROJECT_ID = table.Column<int>(nullable: false),
                    NAME_NP = table.Column<string>(maxLength: 50, nullable: false),
                    NAME_EN = table.Column<string>(maxLength: 50, nullable: true),
                    IS_ACTIVE = table.Column<string>(maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("INV_PROJECT_pkey", x => x.PROJECT_ID);
                });

            migrationBuilder.CreateTable(
                name: "INV_PUR_MAST_PLAN",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    NAME_NP = table.Column<string>(maxLength: 70, nullable: false),
                    NAME_EN = table.Column<string>(maxLength: 50, nullable: true),
                    PKG_NO = table.Column<string>(maxLength: 20, nullable: true),
                    APPROX_AMT = table.Column<float>(nullable: true),
                    BUDGET1YEAR = table.Column<float>(nullable: true),
                    BUDGET2YEAR = table.Column<float>(nullable: true),
                    BUDGET3YEAR = table.Column<float>(nullable: true),
                    PUR_TYPE = table.Column<string>(maxLength: 10, nullable: true),
                    AGREEMENT_TYPE = table.Column<string>(maxLength: 10, nullable: true),
                    BUDGET_RESOURCE = table.Column<string>(maxLength: 30, nullable: true),
                    WORK_ST_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    WORK_END_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    WORK_ST_DATE_AD = table.Column<DateTime>(nullable: true),
                    WORK_END_DATE_AD = table.Column<DateTime>(nullable: true),
                    BUDGET_YEAR = table.Column<string>(maxLength: 10, nullable: true),
                    REMARKS = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INV_PUR_MAST_PLAN", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "INV_PUR_TYPE",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    NEP_NAME = table.Column<string>(maxLength: 100, nullable: true),
                    NEP_ENG = table.Column<string>(maxLength: 100, nullable: true),
                    REMARKS = table.Column<string>(maxLength: 100, nullable: true),
                    ISDEFAULT = table.Column<char>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "INV_SUP_ITM_DET",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    ITEM_ID = table.Column<int>(nullable: true),
                    SUP_ID = table.Column<int>(nullable: true),
                    QTY = table.Column<int>(nullable: true),
                    RATE = table.Column<int>(nullable: true),
                    ACC_ID = table.Column<int>(nullable: true),
                    FISCAL_YEAR = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INV_SUP_ITM_DET", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "INV_SUPPLIER",
                columns: table => new
                {
                    SUP_ID = table.Column<int>(nullable: false),
                    NAME_NP = table.Column<string>(maxLength: 70, nullable: false),
                    NAME_EN = table.Column<string>(maxLength: 50, nullable: true),
                    COMPANY_NAME_NP = table.Column<string>(maxLength: 70, nullable: true),
                    COMPANY_NAME_EN = table.Column<string>(maxLength: 50, nullable: true),
                    REGI_TYPE = table.Column<string>(maxLength: 25, nullable: true),
                    TPIN_PAN_NO = table.Column<string>(maxLength: 30, nullable: true),
                    ADDRESS = table.Column<string>(maxLength: 100, nullable: true),
                    PHONE_NO = table.Column<string>(maxLength: 15, nullable: true),
                    EMAIL = table.Column<string>(maxLength: 30, nullable: true),
                    DATE_VS = table.Column<string>(maxLength: 10, nullable: true),
                    DATE_AD = table.Column<DateTime>(nullable: true),
                    ORG_TYPE = table.Column<string>(maxLength: 50, nullable: true),
                    ORG_ID = table.Column<int>(nullable: true),
                    IS_SELECTED = table.Column<string>(maxLength: 5, nullable: true),
                    REG_NO = table.Column<string>(maxLength: 30, nullable: true),
                    SUP_TYPE = table.Column<string>(maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("INV_SUPPLIER_pkey", x => x.SUP_ID);
                });

            migrationBuilder.CreateTable(
                name: "INV_SUPPLIER_FISCALYEAR",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    SUP_ID = table.Column<int>(nullable: true),
                    FISCAL_YEAR = table.Column<string>(maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INV_SUPPLIER_FISCALYEAR", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "INV_TAX_RATE",
                columns: table => new
                {
                    TAX_RATE_ID = table.Column<int>(nullable: false),
                    NAME_NP = table.Column<string>(maxLength: 50, nullable: false),
                    NAME_EN = table.Column<string>(maxLength: 50, nullable: true),
                    TAX_RATE = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("INV_TAX_RATE_pkey", x => x.TAX_RATE_ID);
                });

            migrationBuilder.CreateTable(
                name: "INV_TYPE_SETUP",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    DESC_NP = table.Column<string>(maxLength: 50, nullable: false),
                    DESC_EN = table.Column<string>(maxLength: 50, nullable: true),
                    TYPE_ID = table.Column<int>(nullable: true),
                    IS_ACTIVE = table.Column<string>(maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INV_TYPE_SETUP", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "INV_UNIT",
                columns: table => new
                {
                    UNIT_ID = table.Column<int>(nullable: false),
                    DESC_NP = table.Column<string>(maxLength: 50, nullable: false),
                    DESC_EN = table.Column<string>(maxLength: 50, nullable: true),
                    MUL_FACTOR = table.Column<int>(nullable: true),
                    RELATED_TO = table.Column<string>(maxLength: 10, nullable: true),
                    NO_OF_UNITS = table.Column<int>(nullable: true),
                    IS_ACTIVE = table.Column<string>(maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("INV_UNIT_pkey", x => x.UNIT_ID);
                });

            migrationBuilder.CreateTable(
                name: "INV_WAREHOUSE",
                columns: table => new
                {
                    WAREHOUSE_ID = table.Column<int>(nullable: false),
                    NAME_NP = table.Column<string>(maxLength: 50, nullable: false),
                    NAME_EN = table.Column<string>(maxLength: 50, nullable: true),
                    IS_ACTIVE = table.Column<string>(maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("INV_WAREHOUSE_pkey", x => x.WAREHOUSE_ID);
                });

            migrationBuilder.CreateTable(
                name: "INV_YRLY_PUR_PLAN",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    NAME_NP = table.Column<string>(maxLength: 70, nullable: false),
                    NAME_EN = table.Column<string>(maxLength: 50, nullable: true),
                    APPROX_AMT = table.Column<float>(nullable: true),
                    PUR_TYPE = table.Column<string>(maxLength: 10, nullable: true),
                    AGREEMENT_TYPE = table.Column<string>(maxLength: 30, nullable: true),
                    APRX_AMT_ACPT_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    INFO_PUBLISH_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    TENDR_SALE_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    FORM_ENTRY_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    TENDR_OPEN_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    TENDR_ACCEPT_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    WRK_ORDER_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    WRK_ACMPLSH_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    ANLYSIS_DSGN_DT_AD = table.Column<DateTime>(nullable: true),
                    APRX_AMT_ACPT_DT_AD = table.Column<DateTime>(nullable: true),
                    TENDR_ACCEPT_DT_AD = table.Column<DateTime>(nullable: true),
                    TENDR_CALL_DT_AD = table.Column<DateTime>(nullable: true),
                    TENDR_OPEN_DT_AD = table.Column<DateTime>(nullable: true),
                    AGREEMENT_DT_AD = table.Column<DateTime>(nullable: true),
                    WRK_2_FIN_DT_AD = table.Column<DateTime>(nullable: true),
                    WRK_ACMPLSH_DT_AD = table.Column<DateTime>(nullable: true),
                    REMARKS = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INV_YRLY_PUR_PLAN", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "IPTTAXSUMMARY_HISTORY",
                columns: table => new
                {
                    SN = table.Column<int>(nullable: true),
                    IID = table.Column<int>(nullable: true),
                    FISCALYEAR = table.Column<string>(maxLength: 9, nullable: true),
                    NETTAXAMOUNT = table.Column<int>(nullable: true),
                    FINEAMOUNT = table.Column<int>(nullable: true),
                    ADDITIONALCHARGES = table.Column<int>(nullable: true),
                    REDUCTIONALCHARGES = table.Column<int>(nullable: true),
                    ISTHISFROMREVENUEACCOUNT = table.Column<int>(nullable: true),
                    TAXPAIDAMOUNT = table.Column<int>(nullable: true),
                    DATEPAID = table.Column<string>(maxLength: 10, nullable: true),
                    SPECIALNOTES = table.Column<string>(nullable: true),
                    USERID = table.Column<int>(nullable: true),
                    USERIDE = table.Column<int>(nullable: true),
                    DATAENTRYVSDATE = table.Column<string>(maxLength: 10, nullable: true),
                    DATAENTRYADDATETIME = table.Column<DateTime>(nullable: true),
                    DATAEDITADDATETIME = table.Column<DateTime>(nullable: true),
                    BILLID = table.Column<int>(nullable: true),
                    BILLNO = table.Column<string>(maxLength: 25, nullable: true),
                    LAST_TAX_PAID_AMOUNT = table.Column<float>(nullable: true),
                    TAX_TYPE = table.Column<string>(maxLength: 2, nullable: true),
                    REM_IPT_PAID_AMOUNT = table.Column<float>(nullable: true),
                    REM_HL_PAID_AMOUNT = table.Column<float>(nullable: true),
                    REM_IPT_FINE_AMOUNT = table.Column<float>(nullable: true),
                    REM_HL_FINE_AMOUNT = table.Column<float>(nullable: true),
                    REM_HL_FINE_STATUS = table.Column<string>(maxLength: 1, nullable: true),
                    REM_IPT_FINE_STATUS = table.Column<string>(maxLength: 1, nullable: true),
                    YEAR = table.Column<int>(nullable: true),
                    MONTH = table.Column<int>(nullable: true),
                    ADD_DATE = table.Column<DateTime>(nullable: true),
                    COMPUTER_NAME = table.Column<string>(maxLength: 100, nullable: true),
                    DATA_STATUS = table.Column<string>(maxLength: 20, nullable: true),
                    WINDOWS_USER = table.Column<string>(maxLength: 100, nullable: true),
                    TRAN_TIME = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ISSUEDBILLS",
                columns: table => new
                {
                    SN = table.Column<int>(nullable: true),
                    DATEISSUED = table.Column<string>(maxLength: 10, nullable: true),
                    THELINO = table.Column<int>(nullable: true),
                    BILLNOFROM = table.Column<string>(maxLength: 25, nullable: true),
                    BILLNOTO = table.Column<string>(maxLength: 25, nullable: true),
                    COUNTERID = table.Column<int>(nullable: true),
                    USERID = table.Column<int>(nullable: true),
                    SPECIALNOTES = table.Column<string>(maxLength: 90, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "LANDMEASURINGUNITS",
                columns: table => new
                {
                    UNITID = table.Column<int>(nullable: true),
                    UNITNAME = table.Column<string>(maxLength: 50, nullable: true),
                    SQFTPERUNIT = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "LANDSMULTIEVALUATIONDETAIL",
                columns: table => new
                {
                    SN = table.Column<int>(nullable: true),
                    IID = table.Column<int>(nullable: true),
                    LANDID = table.Column<int>(nullable: true),
                    KITTANUMBER = table.Column<string>(maxLength: 50, nullable: true),
                    GENERALRATEID = table.Column<int>(nullable: true),
                    AREAINSQFT = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "LELEDGER20682069",
                columns: table => new
                {
                    SN = table.Column<int>(nullable: true),
                    IID = table.Column<int>(nullable: true),
                    LANDID = table.Column<int>(nullable: true),
                    WARDNO = table.Column<int>(nullable: true),
                    TRACKID = table.Column<int>(nullable: true),
                    KITTANUMBER = table.Column<string>(maxLength: 50, nullable: true),
                    TOTALAREA = table.Column<int>(nullable: true),
                    NONEVALUATEDAREA = table.Column<int>(nullable: true),
                    NETEVALUATINGAREA = table.Column<int>(nullable: true),
                    RATEID = table.Column<int>(nullable: true),
                    RATEPERUNIT = table.Column<int>(nullable: true),
                    CALCULATEDVALUE = table.Column<int>(nullable: true),
                    OTHERPLUSINEVALUATIONS = table.Column<int>(nullable: true),
                    OTHERMINUSINEVALUATIONS = table.Column<int>(nullable: true),
                    OTHERPLUSMINUSDESCRIPTIONS = table.Column<string>(maxLength: 90, nullable: true),
                    NETCALCULATEDVALUE = table.Column<int>(nullable: true),
                    SELFDECLAREDVALUE = table.Column<int>(nullable: true),
                    APPLIEDVALUE = table.Column<int>(nullable: true),
                    NONCOMPLETIONREASONID = table.Column<int>(nullable: true),
                    NONCOMPLETIONREASONS = table.Column<string>(maxLength: 90, nullable: true),
                    REMARKS = table.Column<string>(maxLength: 90, nullable: true),
                    LANDMEASURINGUNIT = table.Column<int>(nullable: true),
                    TAXED = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "MALPOT_LANDS",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    IID = table.Column<int>(nullable: true),
                    EID = table.Column<string>(maxLength: 200, nullable: true),
                    NP_FIRSTNAME = table.Column<string>(maxLength: 200, nullable: true),
                    NP_LASTNAME = table.Column<string>(maxLength: 200, nullable: true),
                    OLDVDCID = table.Column<int>(nullable: true),
                    OLDWORDNO = table.Column<string>(maxLength: 100, nullable: true),
                    MOTHNUMBER = table.Column<string>(maxLength: 200, nullable: true),
                    KITTANUMBER = table.Column<string>(maxLength: 200, nullable: true),
                    VDCID = table.Column<int>(nullable: true),
                    WORDNO = table.Column<int>(nullable: true),
                    AREAINSQFT = table.Column<float>(nullable: true),
                    NONFUNCTIONALAREAINSQFT = table.Column<float>(nullable: true),
                    ADD_USERID = table.Column<int>(nullable: true),
                    EDIT_USERID = table.Column<int>(nullable: true),
                    ADD_DATE = table.Column<string>(maxLength: 30, nullable: true),
                    EDIT_DATE = table.Column<string>(maxLength: 30, nullable: true),
                    IS_IPT = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MALPOT_LANDS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MAP_CONSTRCTION_KIND",
                columns: table => new
                {
                    ID = table.Column<short>(nullable: false),
                    NAME_NP = table.Column<string>(maxLength: 70, nullable: false),
                    NAME_EN = table.Column<string>(maxLength: 70, nullable: true),
                    DESCRIPTION = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_CONSTRCTION_KIND", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MAP_DESIGNER_DTL",
                columns: table => new
                {
                    ID = table.Column<short>(nullable: false),
                    REG_NO = table.Column<string>(maxLength: 20, nullable: false),
                    ENGCOUNCILREG_NO = table.Column<string>(maxLength: 20, nullable: true),
                    FIRM_NAME = table.Column<string>(maxLength: 70, nullable: true),
                    DESIGNER_NAME = table.Column<string>(maxLength: 70, nullable: true),
                    ADDRESS = table.Column<string>(maxLength: 200, nullable: true),
                    PHONE_NO = table.Column<string>(maxLength: 20, nullable: true),
                    CLASS = table.Column<string>(maxLength: 1, nullable: true),
                    STATUS_ID = table.Column<string>(maxLength: 1, nullable: true),
                    REMARKS = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_DESIGNER_DTL", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MAP_DIRECTION",
                columns: table => new
                {
                    ID = table.Column<short>(nullable: false),
                    NAME_NP = table.Column<string>(maxLength: 70, nullable: true),
                    NAME_EN = table.Column<string>(maxLength: 70, nullable: false),
                    DESCRIPTION = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_DIRECTION", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MAP_DRAIN_TYPE",
                columns: table => new
                {
                    ID = table.Column<short>(nullable: false),
                    NAME_NP = table.Column<string>(maxLength: 70, nullable: false),
                    NAME_EN = table.Column<string>(maxLength: 70, nullable: true),
                    DESCRIPTION = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_DRAIN_TYPE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MAP_FLOOR",
                columns: table => new
                {
                    ID = table.Column<short>(nullable: false),
                    NAME_NP = table.Column<string>(maxLength: 70, nullable: false),
                    NAME_EN = table.Column<string>(maxLength: 70, nullable: true),
                    DESCRIPTION = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_FLOOR", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MAP_HOUSEUSE_TYPE",
                columns: table => new
                {
                    ID = table.Column<short>(nullable: false),
                    NAME_NP = table.Column<string>(maxLength: 70, nullable: false),
                    NAME_EN = table.Column<string>(maxLength: 70, nullable: true),
                    DESCRIPTION = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_HOUSEUSE_TYPE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MAP_HTSTANDARD",
                columns: table => new
                {
                    SN = table.Column<short>(nullable: false),
                    KV = table.Column<int>(nullable: true),
                    DISTANCEFT = table.Column<int>(nullable: true),
                    REMARKS = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("MAP_HTSTANDARD_pkey", x => x.SN);
                });

            migrationBuilder.CreateTable(
                name: "MAP_LAND_OWNER_TYPE",
                columns: table => new
                {
                    ID = table.Column<short>(nullable: false),
                    NAME_NP = table.Column<string>(maxLength: 70, nullable: false),
                    NAME_EN = table.Column<string>(maxLength: 70, nullable: true),
                    DESCRIPTION = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_LAND_OWNER_TYPE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MAP_NEIGHBOUR_TYPE",
                columns: table => new
                {
                    ID = table.Column<short>(nullable: false),
                    NAME_NP = table.Column<string>(maxLength: 70, nullable: false),
                    NAME_EN = table.Column<string>(maxLength: 70, nullable: true),
                    DESCRIPTION = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_NEIGHBOUR_TYPE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MAP_RATE",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    DESCRIPTION = table.Column<string>(maxLength: 150, nullable: true),
                    RATE_PERMIT = table.Column<float>(nullable: true),
                    DEPOSITE_RATE_PERMIT = table.Column<float>(nullable: true),
                    USERID = table.Column<int>(nullable: true),
                    ENTRY_DATE = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_RATE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MAP_ROOF_CNSTRCT_TYPE",
                columns: table => new
                {
                    ID = table.Column<short>(nullable: false),
                    NAME_NP = table.Column<string>(maxLength: 70, nullable: false),
                    NAME_EN = table.Column<string>(maxLength: 70, nullable: true),
                    DESCRIPTION = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_ROOF_CNSTRCT_TYPE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MAP_ROOF_TYPE",
                columns: table => new
                {
                    ID = table.Column<short>(nullable: false),
                    NAME_NP = table.Column<string>(maxLength: 70, nullable: true),
                    NAME_EN = table.Column<string>(maxLength: 70, nullable: false),
                    DESCRIPTION = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_ROOF_TYPE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MAP_SITE",
                columns: table => new
                {
                    SN = table.Column<int>(nullable: false),
                    PERMITID = table.Column<int>(nullable: true),
                    LANDSHAPE = table.Column<short>(nullable: true),
                    SIDE_A = table.Column<float>(nullable: true),
                    SIDE_B = table.Column<float>(nullable: true),
                    SIDE_C = table.Column<float>(nullable: true),
                    AREA = table.Column<float>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("MAP_SITE_pkey", x => x.SN);
                });

            migrationBuilder.CreateTable(
                name: "MAP_STDHEIGHT_RW",
                columns: table => new
                {
                    ID = table.Column<short>(nullable: false),
                    ROAD_WIDTH = table.Column<float>(nullable: true),
                    HOUSE_HEIGHT = table.Column<float>(nullable: true),
                    FISCAL_YEAR = table.Column<string>(maxLength: 10, nullable: true),
                    REMARKS = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_STDHEIGHT_RW", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MAP_STOREYS",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    NAME_NP = table.Column<string>(maxLength: 70, nullable: false),
                    NAME_EN = table.Column<string>(maxLength: 70, nullable: true),
                    DESCRIPTION = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_STOREYS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MAP_STRUCTURE_TYPE",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    NAME_NP = table.Column<string>(maxLength: 70, nullable: false),
                    NAME_EN = table.Column<string>(maxLength: 70, nullable: true),
                    DESCRIPTION = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_STRUCTURE_TYPE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MAP_ZONE",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    NAME_NP = table.Column<string>(maxLength: 70, nullable: false),
                    NAME_EN = table.Column<string>(maxLength: 70, nullable: true),
                    DESCRIPTION = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_ZONE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MINISTRY",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: true),
                    CODE = table.Column<string>(maxLength: 70, nullable: true),
                    ZONE = table.Column<int>(nullable: true),
                    DISTRICT = table.Column<int>(nullable: true),
                    VDC = table.Column<int>(nullable: true),
                    PHONE = table.Column<string>(maxLength: 70, nullable: true),
                    ADDRESS = table.Column<string>(maxLength: 150, nullable: true),
                    NEPNAME = table.Column<string>(maxLength: 70, nullable: true),
                    ENGNAME = table.Column<string>(maxLength: 70, nullable: true),
                    REMARKS = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "MINISTRY_ACC_HEAD",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    MINISTRY_ID = table.Column<int>(nullable: true),
                    ACC_ID = table.Column<int>(nullable: true),
                    SUB_HEAD_ID = table.Column<int>(nullable: true),
                    FISCAL_YEAR = table.Column<string>(maxLength: 70, nullable: true),
                    REMARKS = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MINISTRY_ACC_HEAD", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "NATIONALITIES",
                columns: table => new
                {
                    NATIONALITYID = table.Column<int>(nullable: true),
                    CODE = table.Column<string>(maxLength: 50, nullable: true),
                    NEPNAME = table.Column<string>(maxLength: 50, nullable: true),
                    ENGNAME = table.Column<string>(maxLength: 25, nullable: true),
                    DESCRIPTION = table.Column<string>(maxLength: 70, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "NEW_PROPERTY_TAXTABLE",
                columns: table => new
                {
                    SN = table.Column<int>(nullable: false),
                    RATESN = table.Column<int>(nullable: true),
                    FROMPROPERTYVALUE = table.Column<float>(nullable: true),
                    TOPROPERTYVALUE = table.Column<float>(nullable: true),
                    FROMTAXAMOUNT = table.Column<float>(nullable: true),
                    TOTAXAMOUNT = table.Column<float>(nullable: true),
                    REMARKS = table.Column<string>(maxLength: 190, nullable: true),
                    FISCALYEAR = table.Column<string>(maxLength: 10, nullable: true),
                    TAX_PERCENT = table.Column<float>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("NEW_PROPERTY_TAXTABLE_pkey", x => x.SN);
                });

            migrationBuilder.CreateTable(
                name: "OFFICE_TYPE",
                columns: table => new
                {
                    OFFICE_TYPE_ID = table.Column<int>(nullable: false),
                    OFFICE_TYPE = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OFFICE_TYPE", x => x.OFFICE_TYPE_ID);
                });

            migrationBuilder.CreateTable(
                name: "PAYMENT_SLIP_MASTER",
                columns: table => new
                {
                    PAYMENT_SLIP_ID = table.Column<int>(nullable: false),
                    PAYMENT_DESCRIPTION = table.Column<string>(maxLength: 100, nullable: true),
                    TRANSACTION_TYPEID = table.Column<int>(nullable: true),
                    PERSON_TYPE_ID = table.Column<int>(nullable: true),
                    PERSON_ID = table.Column<int>(nullable: true),
                    WORK_ID = table.Column<int>(nullable: true),
                    BILL_AMT = table.Column<float>(nullable: true),
                    VAT_AMT = table.Column<float>(nullable: true),
                    RETENTION_MONEY_EDUCTION = table.Column<float>(nullable: true),
                    CONTRACT_TAX_DEDUCTION = table.Column<float>(nullable: true),
                    INCOME_TAX_DEDUCTION = table.Column<float>(nullable: true),
                    LAST_YEARS_ADV_DEDUCTION = table.Column<float>(nullable: true),
                    VAT_DEDUCTION = table.Column<float>(nullable: true),
                    OTHER_DEDUCTION = table.Column<float>(nullable: true),
                    CHEQUE_PAYMENT = table.Column<float>(nullable: true),
                    CASH_PAYMENT = table.Column<float>(nullable: true),
                    ADV_CLEARED_FROM_BILL = table.Column<float>(nullable: true),
                    ADV_CLEARED_FROM_BANK = table.Column<float>(nullable: true),
                    ADV_CLEARED_FROM_CASH = table.Column<float>(nullable: true),
                    LY_ADV_CLEARED_FROM_BILL = table.Column<float>(nullable: true),
                    LY_ADV_CLEARED_FROM_BANK = table.Column<float>(nullable: true),
                    LY_ADV_CLEARED_FROM_CASH = table.Column<float>(nullable: true),
                    IS_PESKI = table.Column<string>(maxLength: 1, nullable: true),
                    VR_NO = table.Column<int>(nullable: true),
                    VR_DATE = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PAYMENT_SLIP_MASTER_pkey", x => x.PAYMENT_SLIP_ID);
                });

            migrationBuilder.CreateTable(
                name: "PERSON_TYPE_MASTER",
                columns: table => new
                {
                    PERSON_TYPE_ID = table.Column<int>(nullable: false),
                    NAME_NP = table.Column<string>(nullable: true),
                    NAME_EN = table.Column<string>(nullable: true),
                    ISFIXED = table.Column<string>(maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PERSON_TYPE_MASTER_pkey", x => x.PERSON_TYPE_ID);
                });

            migrationBuilder.CreateTable(
                name: "PIS_APPOINTMENT_TYPE",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    NAME_NP = table.Column<string>(maxLength: 50, nullable: true),
                    NAME_EN = table.Column<string>(maxLength: 50, nullable: true),
                    DESCRIPTION = table.Column<string>(maxLength: 70, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PIS_APPOINTMENT_TYPE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PIS_ATTRIBUTES",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    NAME_NEP = table.Column<string>(maxLength: 70, nullable: true),
                    DESCRIPTION = table.Column<string>(maxLength: 90, nullable: true),
                    APPLY_TO = table.Column<string>(maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PIS_ATTRIBUTES", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PIS_EDU_BOARD",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    NAME_NEP = table.Column<string>(maxLength: 100, nullable: true),
                    NAME_ENG = table.Column<string>(maxLength: 100, nullable: true),
                    COUNTRY_ID = table.Column<int>(nullable: true),
                    PLACE = table.Column<string>(maxLength: 70, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PIS_EDU_BOARD", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PIS_EDU_LEVEL",
                columns: table => new
                {
                    EDU_ID = table.Column<int>(nullable: false),
                    EDU_NAME = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PIS_EDU_LEVEL_pkey", x => x.EDU_ID);
                });

            migrationBuilder.CreateTable(
                name: "PIS_EMP_BARGA",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    NAME_NP = table.Column<string>(maxLength: 25, nullable: true),
                    NAME_EN = table.Column<string>(maxLength: 25, nullable: true),
                    DESCRIPTION = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PIS_EMP_BARGA", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PIS_EMP_DEP",
                columns: table => new
                {
                    DEPT_ID = table.Column<int>(nullable: false),
                    NAME_NP = table.Column<string>(maxLength: 70, nullable: false),
                    NAME_EN = table.Column<string>(maxLength: 70, nullable: true),
                    DESCRIPTION = table.Column<string>(maxLength: 70, nullable: true),
                    SALARY_ACC_ID = table.Column<int>(nullable: false),
                    ALLOWANCE_ACC_ID = table.Column<int>(nullable: true),
                    ADD_PF_ACC_ID = table.Column<int>(nullable: true),
                    ADD_INSRNCE_ACC_ID = table.Column<int>(nullable: true),
                    SUB_PF_ACC_ID = table.Column<int>(nullable: true),
                    SUB_INSRNCE_ACC_ID = table.Column<int>(nullable: true),
                    CIT_ACC_ID = table.Column<int>(nullable: true),
                    INCME_TAX_ACC_ID = table.Column<int>(nullable: true),
                    LEND_PF_D_ACC_ID = table.Column<int>(nullable: true),
                    SOC_SEC_TAX = table.Column<int>(nullable: true),
                    BHATTA_ACC_ID = table.Column<int>(nullable: true),
                    PESKI_KATTI_ACC_ID = table.Column<int>(nullable: true),
                    OTHR_KATTI_ACC_ID = table.Column<int>(nullable: true),
                    ABSNT_KATTI_ACC_ID = table.Column<int>(nullable: true),
                    SAPATI_KATTI_ACC_ID = table.Column<int>(nullable: true),
                    BUDGET_SOURCE_ID = table.Column<int>(nullable: true),
                    TDS_ACC_ID = table.Column<int>(nullable: true),
                    WORK_ID = table.Column<int>(nullable: true),
                    BUDJET_SOURCE_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PIS_EMP_DEP_pkey", x => x.DEPT_ID);
                });

            migrationBuilder.CreateTable(
                name: "PIS_EMP_INSURANCE_PAID",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    EMP_ID = table.Column<int>(nullable: true),
                    AMOUNT = table.Column<float>(nullable: true),
                    FISCAL_YEAR = table.Column<string>(maxLength: 10, nullable: true),
                    REMARKS = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PIS_EMP_INSURANCE_PAID", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PIS_GEO_REGION",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    GR_ID = table.Column<string>(maxLength: 2, nullable: true),
                    GR_NAME = table.Column<string>(maxLength: 50, nullable: true),
                    MARKS_PER_YEAR = table.Column<float>(nullable: true),
                    DETAILS = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PIS_GEO_REGION", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PIS_HAJIRI",
                columns: table => new
                {
                    SN = table.Column<int>(nullable: false),
                    YEAR = table.Column<int>(nullable: true),
                    MONTH = table.Column<int>(nullable: true),
                    EMP_ID = table.Column<int>(nullable: true),
                    LOCAL_POST = table.Column<int>(nullable: true),
                    TOTAL_DAYS = table.Column<int>(nullable: true),
                    PUBLIC_HOLIDAYS = table.Column<int>(nullable: true),
                    HAJIRI_DAYS = table.Column<int>(nullable: true),
                    GHABIS = table.Column<int>(nullable: true),
                    BIBIS = table.Column<int>(nullable: true),
                    CABIS = table.Column<int>(nullable: true),
                    BETALABIS = table.Column<int>(nullable: true),
                    OTHER = table.Column<int>(nullable: true),
                    GAYAL = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PIS_HAJIRI_pkey", x => x.SN);
                });

            migrationBuilder.CreateTable(
                name: "PIS_LAND_BLDNGS",
                columns: table => new
                {
                    SN = table.Column<int>(nullable: false),
                    EMP_ID = table.Column<int>(nullable: true),
                    DESCRIPTION = table.Column<string>(maxLength: 150, nullable: true),
                    UNIT_DESC = table.Column<string>(maxLength: 100, nullable: true),
                    ZONE_ID = table.Column<int>(nullable: true),
                    DISTRICT_ID = table.Column<int>(nullable: true),
                    VDC_ID = table.Column<int>(nullable: true),
                    WARD_NO = table.Column<string>(maxLength: 10, nullable: true),
                    ROAD_ID = table.Column<int>(nullable: true),
                    STREET = table.Column<string>(maxLength: 70, nullable: true),
                    OWNERSHIP_DETAILS = table.Column<string>(maxLength: 100, nullable: true),
                    AQUISITION_TYPE_ID = table.Column<int>(nullable: true),
                    SPECIAL_NOTES = table.Column<string>(maxLength: 150, nullable: true),
                    APPLY_TO = table.Column<string>(maxLength: 2, nullable: true),
                    USER_ID = table.Column<int>(nullable: true),
                    USER_IDE = table.Column<int>(nullable: true),
                    DATA_ENTRY_VS_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    DATA_ENTRY_AD_DATE = table.Column<DateTime>(nullable: true),
                    DATA_EDIT_AD_DATE = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PIS_LAND_BLDNGS_pkey", x => x.SN);
                });

            migrationBuilder.CreateTable(
                name: "PIS_LOAN_DHITO_GIVEN",
                columns: table => new
                {
                    SN = table.Column<int>(nullable: false),
                    EMP_ID = table.Column<int>(nullable: true),
                    DESCRIPTION = table.Column<string>(maxLength: 150, nullable: true),
                    TRANS_DESC = table.Column<string>(maxLength: 100, nullable: true),
                    REASON_TO_TAKE = table.Column<string>(maxLength: 100, nullable: true),
                    VALUE_IN_NRS = table.Column<float>(nullable: true),
                    RETURNING_DURATION = table.Column<string>(maxLength: 50, nullable: true),
                    SPECIAL_NOTES = table.Column<string>(maxLength: 150, nullable: true),
                    APPLY_TO = table.Column<string>(maxLength: 2, nullable: true),
                    USER_ID = table.Column<int>(nullable: true),
                    USER_IDE = table.Column<int>(nullable: true),
                    DATA_ENTRY_VS_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    DATA_ENTRY_AD_DATE = table.Column<DateTime>(nullable: true),
                    DATA_EDIT_AD_DATE = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PIS_LOAN_DHITO_GIVEN_pkey", x => x.SN);
                });

            migrationBuilder.CreateTable(
                name: "PIS_LOAN_DHITO_TAKEN",
                columns: table => new
                {
                    SN = table.Column<int>(nullable: false),
                    EMP_ID = table.Column<int>(nullable: true),
                    DESCRIPTION = table.Column<string>(maxLength: 150, nullable: true),
                    TRANS_DESC = table.Column<string>(maxLength: 100, nullable: true),
                    REASON_TO_TAKE = table.Column<string>(maxLength: 100, nullable: true),
                    VALUE_IN_NRS = table.Column<float>(nullable: true),
                    RETURNING_DURATION = table.Column<string>(maxLength: 50, nullable: true),
                    SPECIAL_NOTES = table.Column<string>(maxLength: 150, nullable: true),
                    APPLY_TO = table.Column<string>(maxLength: 2, nullable: true),
                    USER_ID = table.Column<int>(nullable: true),
                    USER_IDE = table.Column<int>(nullable: true),
                    DATA_ENTRY_VS_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    DATA_ENTRY_AD_DATE = table.Column<DateTime>(nullable: true),
                    DATA_EDIT_AD_DATE = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PIS_LOAN_DHITO_TAKEN_pkey", x => x.SN);
                });

            migrationBuilder.CreateTable(
                name: "PIS_NIJAMATI_SEWA_SAMUHA",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    PARENT_ID = table.Column<int>(nullable: true),
                    NAME_NP = table.Column<string>(maxLength: 100, nullable: true),
                    NAME_EN = table.Column<string>(maxLength: 100, nullable: true),
                    GRP_LEVEL = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PIS_NIJAMATI_SEWA_SAMUHA", x => x.ID);
                    table.ForeignKey(
                        name: "FK_NIJAMATI_PARENT_ID",
                        column: x => x.PARENT_ID,
                        principalTable: "PIS_NIJAMATI_SEWA_SAMUHA",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PIS_ORNAMENTS",
                columns: table => new
                {
                    SN = table.Column<int>(nullable: false),
                    EMP_ID = table.Column<int>(nullable: true),
                    DESCRIPTION = table.Column<string>(maxLength: 150, nullable: true),
                    UNIT_DESC = table.Column<string>(maxLength: 100, nullable: true),
                    AQUISITION_TYPE_ID = table.Column<int>(nullable: true),
                    SPECIAL_NOTES = table.Column<string>(maxLength: 150, nullable: true),
                    APPLY_TO = table.Column<string>(maxLength: 2, nullable: true),
                    USER_ID = table.Column<int>(nullable: true),
                    USER_IDE = table.Column<int>(nullable: true),
                    DATA_ENTRY_VS_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    DATA_ENTRY_AD_DATE = table.Column<DateTime>(nullable: true),
                    DATA_EDIT_AD_DATE = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PIS_ORNAMENTS_pkey", x => x.SN);
                });

            migrationBuilder.CreateTable(
                name: "PIS_PAYROLLS",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    MONTH = table.Column<short>(nullable: true),
                    EMP_ID = table.Column<int>(nullable: false),
                    LOCAL_POST_ID = table.Column<int>(nullable: true),
                    POST_IN_SHORT = table.Column<string>(maxLength: 40, nullable: true),
                    LOCAL_POST = table.Column<string>(maxLength: 70, nullable: true),
                    EMP_NAME_NP = table.Column<string>(maxLength: 70, nullable: true),
                    BASIC_SALARY = table.Column<float>(nullable: true),
                    GRADE_INC_MONTH = table.Column<short>(nullable: true),
                    RATE_OF_GRADE = table.Column<float>(nullable: true),
                    GRADE_AMOUNT = table.Column<float>(nullable: true),
                    GRADE_SALARY_TOTAL = table.Column<float>(nullable: true),
                    ALLOWANCE_AMT = table.Column<float>(nullable: true),
                    OTHER_ALLOWANCE_AMT = table.Column<float>(nullable: true),
                    PF_ADD_AMT = table.Column<float>(nullable: true),
                    INSURANCE_ADD_AMT = table.Column<float>(nullable: true),
                    NET_SALARY = table.Column<float>(nullable: true),
                    PF_DEDUCT_AMT = table.Column<float>(nullable: true),
                    INSURANCE_DEDUCT_AMT = table.Column<float>(nullable: true),
                    CIT_PERCENT = table.Column<float>(nullable: true),
                    CIT_AMT = table.Column<float>(nullable: true),
                    TAX_AMT = table.Column<float>(nullable: true),
                    ADVANCE_DEDUCT_AMT = table.Column<float>(nullable: true),
                    LOAN_DEDUCT_AMT = table.Column<float>(nullable: true),
                    ABSENT_DAYS = table.Column<int>(nullable: true),
                    ABSENT_DEDUCT_AMT = table.Column<float>(nullable: true),
                    OTHER_DEDUCT_TOTAL = table.Column<float>(nullable: true),
                    TOTAL_PAYABLE_SALARY = table.Column<float>(nullable: true),
                    PAYMODE = table.Column<string>(maxLength: 30, nullable: true),
                    POST_LEVEL = table.Column<int>(nullable: true),
                    VCHR_ID = table.Column<int>(nullable: true),
                    VCHR_DATE_NP = table.Column<string>(maxLength: 10, nullable: true),
                    PAY_BANK_ID = table.Column<int>(nullable: true),
                    TRANS_TPE_ID = table.Column<int>(nullable: true),
                    DEDUCT_DEP_VCHR_ID = table.Column<int>(nullable: true),
                    DEDUCT_DEP_VCHR_DATE_NEP = table.Column<string>(maxLength: 10, nullable: true),
                    REMARKS = table.Column<string>(maxLength: 100, nullable: true),
                    FISCAL_YEAR = table.Column<string>(maxLength: 9, nullable: true),
                    FESTIVE_VCHR_ID = table.Column<int>(nullable: true),
                    FESTIVE_VCHR_DATE_NEP = table.Column<string>(maxLength: 10, nullable: true),
                    PENSIONKOSH_ADD_AMT = table.Column<int>(nullable: true),
                    PENSIONKOSH_DED_AMT = table.Column<int>(nullable: true),
                    TDS_AMT = table.Column<float>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PIS_PAYROLLS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PIS_PD_ORG_INVLVMNT",
                columns: table => new
                {
                    SN = table.Column<int>(nullable: false),
                    EMP_ID = table.Column<int>(nullable: true),
                    ORG_NAME = table.Column<string>(maxLength: 70, nullable: true),
                    ORG_ADD = table.Column<string>(maxLength: 100, nullable: true),
                    ORG_FORMED_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    ORG_AIMS = table.Column<string>(maxLength: 150, nullable: true),
                    ORG_ACHEIVMNTS = table.Column<string>(maxLength: 150, nullable: true),
                    NO_OF_BENIFIC_POPLN = table.Column<int>(nullable: true),
                    POST_IN_ORG = table.Column<string>(maxLength: 50, nullable: true),
                    RESPNSBLTY_IN_ORG = table.Column<string>(maxLength: 90, nullable: true),
                    ORG_JOINED_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    ORG_LEFT_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    REMARKS = table.Column<string>(maxLength: 100, nullable: true),
                    USER_ID = table.Column<int>(nullable: true),
                    USER_IDE = table.Column<int>(nullable: true),
                    DATA_ENTRY_VS_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    DATA_ENTRY_AD_DATE = table.Column<DateTime>(nullable: true),
                    DATA_EDIT_AD_DATE = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PIS_PD_ORG_INVLVMNT_pkey", x => x.SN);
                });

            migrationBuilder.CreateTable(
                name: "PIS_PD_SRVC_DTLS",
                columns: table => new
                {
                    SN = table.Column<int>(nullable: false),
                    EMP_ID = table.Column<int>(nullable: true),
                    LOCAL_POST_ID = table.Column<int>(nullable: true),
                    APPOINTMNT_LEVEL = table.Column<string>(maxLength: 50, nullable: true),
                    APPOINTMNT_TYPE = table.Column<int>(nullable: true),
                    OFFICE_DETAIL = table.Column<string>(maxLength: 70, nullable: true),
                    DATE_FROM = table.Column<string>(maxLength: 10, nullable: true),
                    DATE_TO = table.Column<string>(maxLength: 10, nullable: true),
                    REMARKS = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PIS_PD_SRVC_DTLS_pkey", x => x.SN);
                });

            migrationBuilder.CreateTable(
                name: "PIS_PERSON_VISIT_RECRD",
                columns: table => new
                {
                    SN = table.Column<int>(nullable: false),
                    PERSON_TYPE_ID = table.Column<int>(nullable: true),
                    PERSON_ID = table.Column<int>(nullable: true),
                    PERSON_NAME = table.Column<string>(maxLength: 100, nullable: true),
                    PERSON_POST = table.Column<string>(maxLength: 70, nullable: true),
                    REF_NO = table.Column<string>(maxLength: 50, nullable: true),
                    FROM_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    TO_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    AMOUNT_TAKEN = table.Column<float>(nullable: true),
                    VISIT_LOCATION = table.Column<string>(maxLength: 100, nullable: true),
                    JOB_DETAILS = table.Column<string>(maxLength: 70, nullable: true),
                    REMARKS = table.Column<string>(maxLength: 100, nullable: true),
                    USER_ID = table.Column<int>(nullable: true),
                    USER_IDE = table.Column<int>(nullable: true),
                    DATA_ENTRY_VS_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    DATA_ENTRY_AD_DATE = table.Column<DateTime>(nullable: true),
                    DATA_EDIT_AD_DATE = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PIS_PERSON_VISIT_RECRD_pkey", x => x.SN);
                });

            migrationBuilder.CreateTable(
                name: "PIS_POST_MASTER",
                columns: table => new
                {
                    POST_ID = table.Column<int>(nullable: false),
                    GENERAL_POST = table.Column<string>(maxLength: 70, nullable: true),
                    GENERAL_POST_SHORT = table.Column<string>(maxLength: 40, nullable: true),
                    POST_LEVEL = table.Column<int>(nullable: true),
                    BASIC_SALARY = table.Column<float>(nullable: true),
                    RATE_OF_GRADE = table.Column<int>(nullable: true),
                    MAX_GRADE_RATE = table.Column<int>(nullable: true),
                    PRABIDIK_OR_PRASASAN = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PIS_POST_MASTER_pkey", x => x.POST_ID);
                });

            migrationBuilder.CreateTable(
                name: "PIS_SERVICE_STATUS",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    NAME_NP = table.Column<string>(maxLength: 50, nullable: true),
                    NAME_EN = table.Column<string>(maxLength: 50, nullable: true),
                    DESCRIPTION = table.Column<string>(maxLength: 70, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PIS_SERVICE_STATUS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PIS_SHARE_BANKBALANCE",
                columns: table => new
                {
                    SN = table.Column<int>(nullable: false),
                    EMP_ID = table.Column<int>(nullable: true),
                    DESCRIPTION = table.Column<string>(maxLength: 150, nullable: true),
                    COMPANY_OR_BANK = table.Column<string>(maxLength: 70, nullable: true),
                    VALUE_IN_NRS = table.Column<float>(nullable: true),
                    OWNERSHIP_DETAILS = table.Column<string>(maxLength: 100, nullable: true),
                    AQUISITION_TYPE_ID = table.Column<int>(nullable: true),
                    SPECIAL_NOTES = table.Column<string>(maxLength: 150, nullable: true),
                    APPLY_TO = table.Column<string>(maxLength: 2, nullable: true),
                    USER_ID = table.Column<int>(nullable: true),
                    USER_IDE = table.Column<int>(nullable: true),
                    DATA_ENTRY_VS_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    DATA_ENTRY_AD_DATE = table.Column<DateTime>(nullable: true),
                    DATA_EDIT_AD_DATE = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PIS_SHARE_BANKBALANCE_pkey", x => x.SN);
                });

            migrationBuilder.CreateTable(
                name: "PMS_YOJTYPE",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    YOJTYPE_NAME_NP = table.Column<string>(maxLength: 150, nullable: false),
                    YOJTYPE_NAME_ENG = table.Column<string>(maxLength: 150, nullable: true),
                    YOJTYPE_REMARKS = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PMS_YOJTYPE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RENT_DAR_RATE",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    RATENAME = table.Column<string>(maxLength: 100, nullable: true),
                    RENT_PER = table.Column<float>(nullable: true),
                    RENT_TYPEID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RENT_DAR_RATE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RENTTYPE",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: true),
                    NEPNAME = table.Column<string>(maxLength: 50, nullable: true),
                    ENGNAME = table.Column<string>(maxLength: 50, nullable: true),
                    REMARKS = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "REPORT_GENERAL",
                columns: table => new
                {
                    REPORT_ID = table.Column<int>(nullable: true),
                    OFFICE_TYPE_ID = table.Column<int>(nullable: true),
                    REPORT_NAME = table.Column<string>(maxLength: 60, nullable: true),
                    REPORT_FOR = table.Column<string>(maxLength: 50, nullable: true),
                    ANUSUCHI_HEAD = table.Column<string>(maxLength: 30, nullable: true),
                    ANUSUCHI_DETAILS = table.Column<string>(maxLength: 200, nullable: true),
                    REPORT_HEADING = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SANITATION_GROUP",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    GROUPNAME = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SANITATION_GROUP", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SPACEMEASURINGUNITS",
                columns: table => new
                {
                    UNITID = table.Column<int>(nullable: true),
                    UNITNAME = table.Column<string>(maxLength: 50, nullable: true),
                    SQFTPERUNIT = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SUBJECT_AREA",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    PARENT_ID = table.Column<int>(nullable: true),
                    CODE = table.Column<string>(maxLength: 70, nullable: true),
                    NEP_NAME = table.Column<string>(nullable: true),
                    ENG_NAME = table.Column<string>(maxLength: 100, nullable: true),
                    REMARKS = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SUBJECT_AREA", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SV_BUSINESSMASTER",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    NEPNAME = table.Column<string>(maxLength: 70, nullable: true),
                    DESCRIPTION = table.Column<string>(maxLength: 70, nullable: true),
                    BUSINESSGROUPID = table.Column<int>(nullable: true),
                    TYPEID = table.Column<int>(nullable: true),
                    TAXPAYERID = table.Column<int>(nullable: true),
                    INITIALCAPITAL = table.Column<int>(nullable: true),
                    ZONEID = table.Column<int>(nullable: true),
                    DISTRICTID = table.Column<int>(nullable: true),
                    VDCID = table.Column<int>(nullable: true),
                    WARDNO = table.Column<int>(nullable: true),
                    STREET = table.Column<string>(maxLength: 70, nullable: true),
                    TRACKID = table.Column<int>(nullable: true),
                    HOUSENO = table.Column<string>(maxLength: 50, nullable: true),
                    PHONES = table.Column<string>(maxLength: 50, nullable: true),
                    EMAILS = table.Column<string>(maxLength: 100, nullable: true),
                    HOUSEOWNER = table.Column<string>(maxLength: 70, nullable: true),
                    ISINRENT = table.Column<short>(nullable: true),
                    MONTHLYRENT = table.Column<int>(nullable: true),
                    AREAINSQUAREFEETS = table.Column<int>(nullable: true),
                    INITIALREGISTEREDOFFICE = table.Column<string>(maxLength: 70, nullable: true),
                    INITIALREGNO = table.Column<string>(maxLength: 30, nullable: true),
                    INITIALREGDATE = table.Column<string>(maxLength: 10, nullable: true),
                    MUNICIPALREGNO = table.Column<string>(maxLength: 30, nullable: true),
                    MUNICIPALLREGDATE = table.Column<string>(maxLength: 10, nullable: true),
                    SQFEETSOFSIGNBOARD = table.Column<int>(nullable: true),
                    LENGTHOFSIGNBOARD = table.Column<int>(nullable: true),
                    WIDTHOFSIGNBOARD = table.Column<int>(nullable: true),
                    CONTENTOFSIGNBOARD = table.Column<string>(maxLength: 90, nullable: true),
                    BUSINESSSTARTINGDATE = table.Column<string>(maxLength: 10, nullable: true),
                    SPECIALNOTES = table.Column<string>(maxLength: 100, nullable: true),
                    USERID = table.Column<int>(nullable: true),
                    USERIDE = table.Column<int>(nullable: true),
                    DATAENTRYVSDATE = table.Column<string>(maxLength: 10, nullable: true),
                    DATAENTRYADDATETIME = table.Column<DateTime>(nullable: true),
                    DATAEDITADDATETIME = table.Column<DateTime>(nullable: true),
                    GENERALRATEID = table.Column<int>(nullable: true),
                    MAIL_ADDRESS = table.Column<string>(maxLength: 200, nullable: true),
                    BUSINESS_STATUS = table.Column<short>(nullable: true),
                    CLOSED_VS_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    CLOSE_REASON = table.Column<string>(maxLength: 200, nullable: true),
                    PAID_LAST_FISCALYEAR = table.Column<string>(maxLength: 10, nullable: true),
                    SANITATIONID = table.Column<int>(nullable: true),
                    MAXCAPITAL = table.Column<float>(nullable: true),
                    YEARLY_TRAN_AMOUNT = table.Column<float>(nullable: true),
                    SHIFTDATE = table.Column<string>(maxLength: 12, nullable: true),
                    SHIFTTAXPAYERID = table.Column<int>(nullable: true),
                    ADDRESSCHANGE = table.Column<string>(maxLength: 12, nullable: true),
                    HOUSEID = table.Column<int>(nullable: true),
                    BUSINESSOWNERTAX_IID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SV_BUSINESSMASTER", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SV_CONSTRUCTIONS",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    IID = table.Column<int>(nullable: true),
                    HOUSEID = table.Column<int>(nullable: true),
                    TALANUMBER = table.Column<int>(nullable: true),
                    CONSTRUCTIONTYPEID = table.Column<int>(nullable: true),
                    LENGTHINFEET = table.Column<int>(nullable: true),
                    WIDTHTHINFEET = table.Column<int>(nullable: true),
                    HEIGHTINFEET = table.Column<int>(nullable: true),
                    AREAINSQFEET = table.Column<int>(nullable: true),
                    VSDATEOFMADE = table.Column<string>(maxLength: 10, nullable: true),
                    CONSTRUCTIONUSESTYPEID = table.Column<int>(nullable: true),
                    SELFUSEORINRENT = table.Column<short>(nullable: true),
                    GENERALRATEID = table.Column<int>(nullable: true),
                    INCLUDEINEVALUATION = table.Column<short>(nullable: true),
                    SPECIALNOTE = table.Column<string>(maxLength: 90, nullable: true),
                    USERID = table.Column<int>(nullable: true),
                    USERIDE = table.Column<int>(nullable: true),
                    DATAENTRYVSDATE = table.Column<string>(maxLength: 10, nullable: true),
                    DATAENTRYADDATETIME = table.Column<DateTime>(nullable: true),
                    DATAEDITADDATETIME = table.Column<DateTime>(nullable: true),
                    TAXPAYER_DEFINE_AMOUNT = table.Column<int>(nullable: true),
                    VSMAPPDATE = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SV_CONSTRUCTIONS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SV_HOUSES",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    IID = table.Column<int>(nullable: true),
                    LANDID = table.Column<int>(nullable: true),
                    HOUSENUMBER = table.Column<string>(maxLength: 50, nullable: true),
                    HOUSETYPEID = table.Column<int>(nullable: true),
                    HOUSECONSTRUCTIONTYPEID = table.Column<int>(nullable: true),
                    SALES_DT = table.Column<string>(maxLength: 10, nullable: true),
                    VSDATEOFMADE = table.Column<string>(maxLength: 10, nullable: true),
                    AQUISITIONDATE = table.Column<string>(maxLength: 10, nullable: true),
                    USESTYPEID = table.Column<int>(nullable: true),
                    HASMAPREGISTERED = table.Column<short>(nullable: true),
                    MAPREGISTEREDDATE = table.Column<string>(maxLength: 10, nullable: true),
                    NUMOFTALAS = table.Column<int>(nullable: true),
                    HEIGHTINFEETS = table.Column<int>(nullable: true),
                    LENGTHINFEETS = table.Column<int>(nullable: true),
                    WIDTHINFEETS = table.Column<int>(nullable: true),
                    AREAINSQFEETS = table.Column<int>(nullable: true),
                    SPECIALNOTE = table.Column<string>(nullable: true),
                    INCLUDEINEVALUATION = table.Column<short>(nullable: true),
                    AREAOFCONSTRUCTIONSINSQFEETS = table.Column<int>(nullable: true),
                    USERID = table.Column<int>(nullable: true),
                    USERIDE = table.Column<int>(nullable: true),
                    DATAENTRYVSDATE = table.Column<string>(maxLength: 10, nullable: true),
                    DATAENTRYADDATETIME = table.Column<DateTime>(nullable: true),
                    DATAEDITADDATETIME = table.Column<DateTime>(nullable: true),
                    DEFINE_AMT = table.Column<float>(nullable: true),
                    SANITATIONRATEID = table.Column<int>(nullable: true),
                    BUILDINGCODE = table.Column<string>(maxLength: 30, nullable: true),
                    BIN_GIS = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SV_HOUSES", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SV_LANDS",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    IID = table.Column<int>(nullable: true),
                    OLDVDCID = table.Column<int>(nullable: true),
                    OLDWARDNO = table.Column<string>(maxLength: 30, nullable: true),
                    LAND_RULES = table.Column<string>(nullable: true),
                    WARDNO = table.Column<int>(nullable: true),
                    MOTHNUMBER = table.Column<string>(maxLength: 50, nullable: true),
                    MAPNUMBER = table.Column<string>(maxLength: 50, nullable: true),
                    KITTANUMBER = table.Column<string>(nullable: true),
                    STREETNAME = table.Column<string>(maxLength: 70, nullable: true),
                    HASTRACK = table.Column<short>(nullable: true),
                    TRACKID = table.Column<int>(nullable: true),
                    TRACKRELATIONID = table.Column<int>(nullable: true),
                    AQUISITIONDATE = table.Column<string>(maxLength: 10, nullable: true),
                    AQUISITIONTYPEID = table.Column<int>(nullable: true),
                    USESTYPEID = table.Column<int>(nullable: true),
                    VALUEINRSONAQUISITION = table.Column<int>(nullable: true),
                    AREAINSQFT = table.Column<int>(nullable: true),
                    NONFUNCTIONALAREAINSQFT = table.Column<int>(nullable: true),
                    EASTBOUNDARY = table.Column<string>(maxLength: 70, nullable: true),
                    WESTBOUNDARY = table.Column<string>(maxLength: 70, nullable: true),
                    NORTHTBOUNDARY = table.Column<string>(maxLength: 70, nullable: true),
                    SOUTHTBOUNDARY = table.Column<string>(maxLength: 70, nullable: true),
                    LQTYPEID = table.Column<int>(nullable: true),
                    LANDNATUREID = table.Column<int>(nullable: true),
                    LOCATIONFACTORID = table.Column<int>(nullable: true),
                    SELFDECLAREDVALUEINRS = table.Column<int>(nullable: true),
                    SPECIALNOTE = table.Column<string>(maxLength: 90, nullable: true),
                    GENERALRATEID = table.Column<int>(nullable: true),
                    INCLUDEINEVALUATION = table.Column<short>(nullable: true),
                    USERID = table.Column<int>(nullable: true),
                    USERIDE = table.Column<int>(nullable: true),
                    DATAENTRYVSDATE = table.Column<string>(maxLength: 10, nullable: true),
                    SALES_DT = table.Column<string>(maxLength: 10, nullable: true),
                    DATAENTRYADDATETIME = table.Column<DateTime>(nullable: true),
                    DATAEDITADDATETIME = table.Column<DateTime>(nullable: true),
                    EVALEXCLUSIONREASONID = table.Column<int>(nullable: true),
                    MALPOTRATE = table.Column<int>(nullable: true),
                    AREA_TYPE_ID = table.Column<int>(nullable: true),
                    NOMINATION_DIRECTION = table.Column<int>(nullable: true),
                    NOMINATION_AREA = table.Column<int>(nullable: true),
                    NOMINATION_LENGTH = table.Column<int>(nullable: true),
                    NOMINATION_BREADTH = table.Column<int>(nullable: true),
                    NOMINATION_TF = table.Column<int>(nullable: true),
                    LANDTYPE = table.Column<int>(nullable: true),
                    EASTBOUNDARY_KITTA = table.Column<string>(maxLength: 50, nullable: true),
                    WESTBOUNDARY_KITTA = table.Column<string>(maxLength: 50, nullable: true),
                    NORTHBOUNDARY_KITTA = table.Column<string>(maxLength: 50, nullable: true),
                    SOUTHBOUNDARY_KITTA = table.Column<string>(maxLength: 50, nullable: true),
                    TOLENAME = table.Column<string>(maxLength: 50, nullable: true),
                    LANDMEASURINGUNITID = table.Column<int>(nullable: true),
                    GRID_NO = table.Column<string>(maxLength: 100, nullable: true),
                    SHEET_NO = table.Column<string>(maxLength: 100, nullable: true),
                    EASTRUNFT = table.Column<string>(maxLength: 5, nullable: true),
                    WESTRUNFT = table.Column<string>(maxLength: 5, nullable: true),
                    NORTHRUNFT = table.Column<string>(maxLength: 5, nullable: true),
                    SOUTHRUNFT = table.Column<string>(maxLength: 5, nullable: true),
                    AREAINSQFT_FIELD = table.Column<int>(nullable: true),
                    IS_LRMIS_ADD = table.Column<string>(maxLength: 2, nullable: true),
                    DEIGSTERTYPEID = table.Column<string>(maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SV_LANDS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SV_LANDSMULTIEVALUATIONDETAIL",
                columns: table => new
                {
                    SN = table.Column<int>(nullable: true),
                    IID = table.Column<int>(nullable: true),
                    LANDID = table.Column<int>(nullable: true),
                    KITTANUMBER = table.Column<string>(maxLength: 50, nullable: true),
                    GENERALRATEID = table.Column<int>(nullable: true),
                    AREAINSQFT = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SV_PEOPLE",
                columns: table => new
                {
                    IID = table.Column<int>(nullable: false),
                    EID = table.Column<string>(maxLength: 50, nullable: true),
                    SEX = table.Column<short>(nullable: true),
                    FIRSTNEPNAME = table.Column<string>(maxLength: 120, nullable: true),
                    LASTNEPNAME = table.Column<string>(maxLength: 64, nullable: true),
                    FIRSTENGNAME = table.Column<string>(maxLength: 120, nullable: true),
                    LASTENGNAME = table.Column<string>(maxLength: 64, nullable: true),
                    DOB = table.Column<string>(maxLength: 10, nullable: true),
                    FATHERORHUSBAND = table.Column<string>(maxLength: 70, nullable: true),
                    GFORFINLAW = table.Column<string>(maxLength: 70, nullable: true),
                    PHONES = table.Column<string>(maxLength: 60, nullable: true),
                    MOBILES = table.Column<string>(maxLength: 60, nullable: true),
                    EMAIL = table.Column<string>(maxLength: 90, nullable: true),
                    OCUPATIONID = table.Column<int>(nullable: true),
                    RELIGIONID = table.Column<int>(nullable: true),
                    MOTHERLANGUAGEID = table.Column<int>(nullable: true),
                    NATIONALITYID = table.Column<int>(nullable: true),
                    HASCC = table.Column<short>(nullable: true),
                    CCNUMBER = table.Column<string>(maxLength: 50, nullable: true),
                    CCISSUEDDRISTICTID = table.Column<int>(nullable: true),
                    CCISSUEDDATE = table.Column<string>(maxLength: 10, nullable: true),
                    COUNTRYID = table.Column<int>(nullable: true),
                    ZONEID = table.Column<int>(nullable: true),
                    DISTRICTID = table.Column<int>(nullable: true),
                    VDCID = table.Column<int>(nullable: true),
                    WARDNO = table.Column<int>(nullable: true),
                    STREETNAME = table.Column<string>(maxLength: 60, nullable: true),
                    TRACKID = table.Column<int>(nullable: true),
                    HOUSENO = table.Column<string>(maxLength: 50, nullable: true),
                    CORESPADDRESSLINE1 = table.Column<string>(maxLength: 50, nullable: true),
                    CORESPADDRESSLINE2 = table.Column<string>(maxLength: 50, nullable: true),
                    CORESPADDRESSLINE3 = table.Column<string>(maxLength: 50, nullable: true),
                    CORESPADDRESSLINE4 = table.Column<string>(maxLength: 50, nullable: true),
                    OTHERDETAILS = table.Column<string>(maxLength: 180, nullable: true),
                    INDIVIDUALTYPE = table.Column<int>(nullable: true),
                    PHOTO = table.Column<string>(nullable: true),
                    USERID = table.Column<int>(nullable: true),
                    USERIDE = table.Column<int>(nullable: true),
                    DATAENTRYVSDATE = table.Column<string>(maxLength: 10, nullable: true),
                    DATAENTRYADDATETIME = table.Column<DateTime>(nullable: true),
                    DATAEDITADDATETIME = table.Column<DateTime>(nullable: true),
                    IPT_UNPAID_FISCAL_YEAR = table.Column<string>(maxLength: 9, nullable: true),
                    IPT_UNPAID_AMOUNT = table.Column<float>(nullable: true),
                    HLT_UNPAID_FISCAL_YEAR = table.Column<string>(maxLength: 9, nullable: true),
                    HLT_UNPAID_AMOUNT = table.Column<float>(nullable: true),
                    IS_UNPAID_CLEARED = table.Column<string>(maxLength: 1, nullable: true),
                    CANCEL_DATE = table.Column<string>(maxLength: 12, nullable: true),
                    CANCEL_REASON = table.Column<string>(nullable: true),
                    TOLBIKASHID = table.Column<int>(nullable: true),
                    IS_LRMIS_ADD = table.Column<string>(maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SV_PEOPLE_pkey", x => x.IID);
                });

            migrationBuilder.CreateTable(
                name: "SV_TBHOUSEKITTANUMBER",
                columns: table => new
                {
                    IID = table.Column<int>(nullable: true),
                    HOUSEID = table.Column<int>(nullable: true),
                    LANDID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SV_VEHICLEMASTER",
                columns: table => new
                {
                    SN = table.Column<int>(nullable: false),
                    TAXPAYERID = table.Column<int>(nullable: true),
                    VEHICLENAME = table.Column<string>(maxLength: 70, nullable: true),
                    VEHICLETYPE = table.Column<int>(nullable: true),
                    VEHICLENO = table.Column<string>(maxLength: 50, nullable: true),
                    REGISTEREDOFFICE = table.Column<string>(maxLength: 70, nullable: true),
                    REGISTEREDDATE = table.Column<string>(maxLength: 10, nullable: true),
                    MUNICIPALTYREGNO = table.Column<string>(maxLength: 30, nullable: true),
                    MUNICIPALTYREGDATE = table.Column<string>(maxLength: 10, nullable: true),
                    AQUISITIONTYPE = table.Column<int>(nullable: true),
                    AQUISITIONDATE = table.Column<string>(maxLength: 10, nullable: true),
                    AQUIREDFROM = table.Column<string>(maxLength: 70, nullable: true),
                    USESTYPE = table.Column<int>(nullable: true),
                    COLOR = table.Column<string>(maxLength: 30, nullable: true),
                    NUMBEROFSEATES = table.Column<string>(maxLength: 50, nullable: true),
                    CCORHPRSPOWER = table.Column<string>(maxLength: 50, nullable: true),
                    MADEOF = table.Column<string>(maxLength: 90, nullable: true),
                    ENGINENO = table.Column<string>(maxLength: 50, nullable: true),
                    CHESISNO = table.Column<string>(maxLength: 50, nullable: true),
                    MODELDESCRIPTION = table.Column<string>(maxLength: 70, nullable: true),
                    NOOFCILENDERS = table.Column<string>(maxLength: 50, nullable: true),
                    USEDFUEL = table.Column<int>(nullable: true),
                    SPECIALNOTES = table.Column<string>(maxLength: 100, nullable: true),
                    USERID = table.Column<int>(nullable: true),
                    USERIDE = table.Column<int>(nullable: true),
                    DATAENTRYVSDATE = table.Column<string>(maxLength: 10, nullable: true),
                    DATAENTRYADDATETIME = table.Column<DateTime>(nullable: true),
                    DATAEDITADDATETIME = table.Column<DateTime>(nullable: true),
                    VEHICLE_STATUS = table.Column<short>(nullable: true),
                    CLOSED_VS_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    CLOSE_REASON = table.Column<string>(maxLength: 200, nullable: true),
                    PAID_LAST_FISCALYEAR = table.Column<string>(maxLength: 10, nullable: true),
                    NAMASARIMITI = table.Column<string>(maxLength: 12, nullable: true),
                    NAMASARITAXPAYERID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SV_VEHICLEMASTER_pkey", x => x.SN);
                });

            migrationBuilder.CreateTable(
                name: "TAX_MALPOT",
                columns: table => new
                {
                    SN = table.Column<long>(nullable: true),
                    FISCALYEAR = table.Column<string>(maxLength: 9, nullable: true),
                    TAXPAYERID = table.Column<int>(nullable: true),
                    LANDID = table.Column<int>(nullable: true),
                    KITTANUMBER = table.Column<string>(nullable: true),
                    GENERALRATEID = table.Column<int>(nullable: true),
                    RATEPERUNIT = table.Column<float>(nullable: true),
                    SPECIALNOTES = table.Column<string>(nullable: true),
                    NETTAXAMOUNT = table.Column<float>(nullable: true),
                    FINEAMOUNT = table.Column<float>(nullable: true),
                    ADDITIONALCHARGES = table.Column<float>(nullable: true),
                    REDUCTIONALCHARGES = table.Column<float>(nullable: true),
                    TAXPAIDAMOUNT = table.Column<float>(nullable: true),
                    LAST_TAX_PAID_AMOUNT = table.Column<float>(nullable: true),
                    TOTALAREA = table.Column<int>(nullable: true),
                    NONEVALUATEDAREA = table.Column<int>(nullable: true),
                    NETEVALUATINGAREA = table.Column<int>(nullable: true),
                    BILLID = table.Column<int>(nullable: true),
                    BILLDATE = table.Column<string>(maxLength: 10, nullable: true),
                    BILLNO = table.Column<string>(maxLength: 25, nullable: true),
                    COUNTERID = table.Column<int>(nullable: true),
                    USERID = table.Column<int>(nullable: true),
                    USERIDE = table.Column<int>(nullable: true),
                    DATAENTRYVSDATE = table.Column<string>(maxLength: 10, nullable: true),
                    DATAENTRYADDATETIME = table.Column<DateTime>(nullable: true),
                    DATAEDITADDATETIME = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TAX_MALPOT_HISTORY",
                columns: table => new
                {
                    SN = table.Column<long>(nullable: true),
                    MALPOT_ID = table.Column<long>(nullable: true),
                    FISCALYEAR = table.Column<string>(maxLength: 9, nullable: true),
                    TAXPAYERID = table.Column<int>(nullable: true),
                    LANDID = table.Column<int>(nullable: true),
                    KITTANUMBER = table.Column<string>(nullable: true),
                    GENERALRATEID = table.Column<int>(nullable: true),
                    RATEPERUNIT = table.Column<float>(nullable: true),
                    SPECIALNOTES = table.Column<string>(nullable: true),
                    NETTAXAMOUNT = table.Column<float>(nullable: true),
                    FINEAMOUNT = table.Column<float>(nullable: true),
                    ADDITIONALCHARGES = table.Column<float>(nullable: true),
                    REDUCTIONALCHARGES = table.Column<float>(nullable: true),
                    TAXPAIDAMOUNT = table.Column<float>(nullable: true),
                    LAST_TAX_PAID_AMOUNT = table.Column<float>(nullable: true),
                    TOTALAREA = table.Column<int>(nullable: true),
                    NONEVALUATEDAREA = table.Column<int>(nullable: true),
                    NETEVALUATINGAREA = table.Column<int>(nullable: true),
                    BILLID = table.Column<int>(nullable: true),
                    BILLDATE = table.Column<string>(maxLength: 10, nullable: true),
                    BILLNO = table.Column<string>(maxLength: 25, nullable: true),
                    COUNTERID = table.Column<int>(nullable: true),
                    USERID = table.Column<int>(nullable: true),
                    USERIDE = table.Column<int>(nullable: true),
                    DATAENTRYVSDATE = table.Column<string>(maxLength: 10, nullable: true),
                    DATAENTRYADDATETIME = table.Column<DateTime>(nullable: true),
                    DATAEDITADDATETIME = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TAX_RATE_CEILING",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    NP_FROM = table.Column<string>(maxLength: 15, nullable: true),
                    NP_TO = table.Column<string>(maxLength: 15, nullable: true),
                    MARRIED_STATUS = table.Column<string>(maxLength: 50, nullable: true),
                    TAX_RATE = table.Column<float>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TAX_RATE_CEILING", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TAX_RENTAL",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: true),
                    FISCALYEAR = table.Column<string>(maxLength: 10, nullable: true),
                    TAXPAYERID = table.Column<int>(nullable: true),
                    CONSTRUCTIONID = table.Column<int>(nullable: true),
                    RENTID = table.Column<int>(nullable: true),
                    RATEID = table.Column<int>(nullable: true),
                    REMARKS = table.Column<string>(nullable: true),
                    NETTAXAMOUNT = table.Column<float>(nullable: true),
                    FINEAMOUNT = table.Column<float>(nullable: true),
                    ADDITIONALCHARGES = table.Column<float>(nullable: true),
                    REDUCTIONALCHARGES = table.Column<float>(nullable: true),
                    TAXPAIDAMOUNT = table.Column<float>(nullable: true),
                    LAST_TAX_PAID_AMOUNT = table.Column<float>(nullable: true),
                    BILLID = table.Column<int>(nullable: true),
                    BILLNO = table.Column<string>(maxLength: 50, nullable: true),
                    BILLDATE = table.Column<string>(maxLength: 12, nullable: true),
                    COUNTERID = table.Column<int>(nullable: true),
                    USERID = table.Column<int>(nullable: true),
                    DATEENTRYVSDATE = table.Column<string>(maxLength: 12, nullable: true),
                    DATAENTRYADDATE = table.Column<DateTime>(nullable: true),
                    YEAR = table.Column<int>(nullable: true),
                    MONTH = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TAX_RT_RENTDTL",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: true),
                    CONSTRUCTION_ID = table.Column<int>(nullable: true),
                    RNAME = table.Column<string>(maxLength: 100, nullable: true),
                    RENT_TYPE_ID = table.Column<int>(nullable: true),
                    RENT_INSQFEET = table.Column<int>(nullable: true),
                    ANUAL_RENT_INCOME = table.Column<float>(nullable: true),
                    FISCAL_YEAR = table.Column<string>(maxLength: 10, nullable: true),
                    AGREEMENT_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    VALID_UNTIL = table.Column<string>(maxLength: 10, nullable: true),
                    RENT_STATUS = table.Column<string>(maxLength: 5, nullable: true),
                    RATEID = table.Column<int>(nullable: true),
                    TAXPAYERID = table.Column<int>(nullable: true),
                    BUSINESSID = table.Column<int>(nullable: true),
                    REMARKS = table.Column<string>(nullable: true),
                    DATAENTRYADDATETIME = table.Column<DateTime>(nullable: true),
                    DATAEDITADDATETIME = table.Column<DateTime>(nullable: true),
                    USERID = table.Column<int>(nullable: true),
                    USERIDE = table.Column<int>(nullable: true),
                    DATAENTRYVSDATE = table.Column<string>(maxLength: 12, nullable: true),
                    IS_TAX_PAID_BUSINESS_PERSON = table.Column<string>(maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TAX_SANITATION",
                columns: table => new
                {
                    SN = table.Column<int>(nullable: true),
                    FISCALYEAR = table.Column<string>(maxLength: 10, nullable: true),
                    YEAR = table.Column<int>(nullable: true),
                    MONTH = table.Column<int>(nullable: true),
                    TAXPAYERID = table.Column<int>(nullable: true),
                    HOUSEID = table.Column<int>(nullable: true),
                    RATEID = table.Column<int>(nullable: true),
                    SPECIALNOTES = table.Column<string>(nullable: true),
                    NETTAXAMOUNT = table.Column<float>(nullable: true),
                    FINEAMOUNT = table.Column<float>(nullable: true),
                    REDUCTIONALCHARGES = table.Column<float>(nullable: true),
                    TAXPAIDAMOUNT = table.Column<float>(nullable: true),
                    LAST_TAX_PAID_AMOUNT = table.Column<float>(nullable: true),
                    BILLID = table.Column<int>(nullable: true),
                    BILLNO = table.Column<string>(maxLength: 25, nullable: true),
                    BILLDATE = table.Column<string>(maxLength: 10, nullable: true),
                    COUNTERID = table.Column<int>(nullable: true),
                    USERID = table.Column<int>(nullable: true),
                    USERIDE = table.Column<int>(nullable: true),
                    DATAENTRYVSDATE = table.Column<string>(maxLength: 10, nullable: true),
                    DATAENTRYADDATETIME = table.Column<DateTime>(nullable: true),
                    DATAEDITADDATETIME = table.Column<DateTime>(nullable: true),
                    SERVICETYPE = table.Column<string>(maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TBHOUSEKITTANUMBER",
                columns: table => new
                {
                    IID = table.Column<int>(nullable: true),
                    HOUSEID = table.Column<int>(nullable: true),
                    LANDID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TBL_BANK_ACCNT_TYPE",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    NEPNAME = table.Column<string>(maxLength: 100, nullable: true),
                    ENGNAME = table.Column<string>(maxLength: 100, nullable: true),
                    REMARKS = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_BANK_ACCNT_TYPE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_BANK_FINANCE_INSTITUTUE",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    NP_NAME = table.Column<string>(nullable: true),
                    ENG_NAME = table.Column<string>(maxLength: 200, nullable: true),
                    DESCRIPTIONG = table.Column<string>(nullable: true),
                    ACCOUNT_NAME = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_BANK_FINANCE_INSTITUTUE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_BGT_MGMT",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    FISCAL_YEAR = table.Column<string>(maxLength: 10, nullable: true),
                    MINISTRY_ID = table.Column<int>(nullable: true),
                    BGT_SUB_HEAD_ID = table.Column<int>(nullable: true),
                    TOTAL_BGT_AMT = table.Column<float>(nullable: true),
                    REMARKS = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_BGT_MGMT", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_BGT_MGMT_ORG",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    FISCAL_YEAR = table.Column<string>(maxLength: 10, nullable: true),
                    MINISTRY_ID = table.Column<int>(nullable: true),
                    ORG_ID = table.Column<int>(nullable: true),
                    BGT_SUB_HEAD_ID = table.Column<int>(nullable: true),
                    TOTAL_BGT_AMT_ORG = table.Column<float>(nullable: true),
                    REMARKS = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_BGT_MGMT_ORG", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_DATA_HISTORY",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    TABLE_NAME = table.Column<string>(maxLength: 100, nullable: true),
                    FIELD_NAME = table.Column<string>(maxLength: 100, nullable: true),
                    NEW_VALUE = table.Column<string>(nullable: true),
                    OLD_VALUE = table.Column<string>(maxLength: 100, nullable: true),
                    USER_ID_A = table.Column<int>(nullable: true),
                    ADD_DATE = table.Column<DateTime>(nullable: true),
                    COMPUTER_NAME = table.Column<string>(maxLength: 100, nullable: true),
                    DATA_STATUS = table.Column<string>(maxLength: 20, nullable: true),
                    WINDOWS_USER = table.Column<string>(maxLength: 100, nullable: true),
                    TRAN_TIME = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_DATA_HISTORY", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_DEGISTER",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    NP_NAME = table.Column<string>(maxLength: 100, nullable: true),
                    ENG_NAME = table.Column<string>(maxLength: 100, nullable: true),
                    REMARKS = table.Column<string>(nullable: true),
                    IS_FULL_DEGISTER = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_DEGISTER", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_KHARIDA_AADASH",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    NP_NAME = table.Column<string>(maxLength: 200, nullable: true),
                    ENG_NAME = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_KHARIDA_AADASH", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_NALI_TYPE",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    NEPNAME = table.Column<string>(maxLength: 50, nullable: true),
                    ENGNAME = table.Column<string>(maxLength: 50, nullable: true),
                    DESCRIPTION = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_NALI_TYPE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_ORGANIZATIONMASTER",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    NP_NAME = table.Column<string>(nullable: true),
                    ENG_NAME = table.Column<string>(maxLength: 200, nullable: true),
                    DESCRIPTIONG = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_ORGANIZATIONMASTER", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_PAYMENT_ORDER",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    ORDER_CODE = table.Column<string>(maxLength: 100, nullable: true),
                    DATE_BS = table.Column<string>(maxLength: 15, nullable: true),
                    TOKEN_NO = table.Column<string>(maxLength: 100, nullable: true),
                    REMARKS = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_PAYMENT_ORDER", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_PAYMENT_PROCESS",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    PAYMENT_PROCESS = table.Column<string>(maxLength: 100, nullable: true),
                    PAYMENT_PROCESS_ENG = table.Column<string>(maxLength: 100, nullable: true),
                    REMARKS = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_PAYMENT_PROCESS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_PAYMENT_TYPE",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    PAYMENT_TYPE = table.Column<string>(maxLength: 100, nullable: true),
                    PAYMENT_TYPE_ENG = table.Column<string>(maxLength: 100, nullable: true),
                    REMARKS = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_PAYMENT_TYPE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_PROPERTY_TAX",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    IID = table.Column<int>(nullable: true),
                    NP_ENTRY_DATE = table.Column<string>(maxLength: 12, nullable: true),
                    FISCAL_YEAR = table.Column<string>(maxLength: 12, nullable: true),
                    HOUSE_LAND_AMOUNT = table.Column<float>(nullable: true),
                    MALPOT_AMOUNT = table.Column<float>(nullable: true),
                    TOTAL_TAX = table.Column<float>(nullable: true),
                    REMARKS = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_PROPERTY_TAX", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_SANITAION_TAX",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: true),
                    FROM_AREA = table.Column<float>(nullable: true),
                    TO_AREA = table.Column<float>(nullable: true),
                    AMOUNT = table.Column<float>(nullable: true),
                    REMARKS = table.Column<string>(nullable: true),
                    FISCAL_YEAR = table.Column<string>(maxLength: 15, nullable: true),
                    ACC_ID = table.Column<int>(nullable: true),
                    IS_APARTMENT = table.Column<string>(maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TBL_STATUS_DETAILS",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    MASTERID = table.Column<int>(nullable: true),
                    ITEM_ID = table.Column<int>(nullable: true),
                    BRAND_ID = table.Column<int>(nullable: true),
                    SPEC_ID = table.Column<int>(nullable: true),
                    UNIT_ID = table.Column<int>(nullable: true),
                    RATE = table.Column<float>(nullable: true),
                    STOCK_QTY = table.Column<float>(nullable: true),
                    USE_IN_QTY = table.Column<float>(nullable: true),
                    NOT_USE_IN_QTY = table.Column<float>(nullable: true),
                    REPAIR_QTY = table.Column<float>(nullable: true),
                    NOT_REPAIR_QTY = table.Column<float>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_STATUS_DETAILS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_TAX_TYPE",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    CODE = table.Column<string>(maxLength: 200, nullable: true),
                    NP_NAME = table.Column<string>(nullable: true),
                    ENG_NAME = table.Column<string>(maxLength: 200, nullable: true),
                    DESCRIPTIONG = table.Column<string>(nullable: true),
                    ACC_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_TAX_TYPE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_TAXSOURCERECORDNEW",
                columns: table => new
                {
                    TAXSRCID = table.Column<int>(nullable: false),
                    FISCALYEAR = table.Column<string>(maxLength: 10, nullable: true),
                    RECORDTYPE = table.Column<int>(nullable: true),
                    NETINCOME_CURFY = table.Column<int>(nullable: true),
                    TAXPAIDTAXPAYERCNT_CURFY = table.Column<int>(nullable: true),
                    NETINCOME_LASTFY = table.Column<int>(nullable: true),
                    TAXPAIDTAXPAYERCNT_LASTFY = table.Column<int>(nullable: true),
                    TAXNOTPAIDTAXPAYERCNT = table.Column<int>(nullable: true),
                    AMOUNTNOTCOLLECTED = table.Column<int>(nullable: true),
                    TOTALTAXPAYERCNT = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("TBL_TAXSOURCERECORDNEW_pkey", x => x.TAXSRCID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_TOLABIKASA_ORG",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    NP_NAME = table.Column<string>(maxLength: 150, nullable: true),
                    ENG_NAME = table.Column<string>(maxLength: 150, nullable: true),
                    ADDRESS = table.Column<string>(maxLength: 150, nullable: true),
                    CHAIRMAN = table.Column<string>(maxLength: 50, nullable: true),
                    SACHIBA = table.Column<string>(maxLength: 50, nullable: true),
                    CONTACTNO = table.Column<string>(maxLength: 50, nullable: true),
                    EMAIL = table.Column<string>(maxLength: 50, nullable: true),
                    WARDNO = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_TOLABIKASA_ORG", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_VEHICLE_PARTS",
                columns: table => new
                {
                    SN = table.Column<int>(nullable: false),
                    NP_NAME = table.Column<string>(maxLength: 200, nullable: true),
                    ENG_NAME = table.Column<string>(maxLength: 100, nullable: true),
                    REMARKS = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("TBL_VEHICLE_PARTS_pkey", x => x.SN);
                });

            migrationBuilder.CreateTable(
                name: "TBLBILLTYPE",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    NEPNAME = table.Column<string>(maxLength: 100, nullable: true),
                    ISINCOME = table.Column<string>(maxLength: 1, nullable: true),
                    DESCRIPTION = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBLBILLTYPE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBLEXEVERSION",
                columns: table => new
                {
                    EXEID = table.Column<int>(nullable: true),
                    EXEDATE = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TBLFYWISEBTRATES",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: true),
                    GROUPID = table.Column<int>(nullable: true),
                    SUBGROUPID = table.Column<int>(nullable: true),
                    SNSUBGROUP = table.Column<int>(nullable: true),
                    RATEID = table.Column<int>(nullable: true),
                    NEPNAME = table.Column<string>(maxLength: 100, nullable: true),
                    DESCRIPTION = table.Column<string>(maxLength: 20, nullable: true),
                    FISCALYEAR = table.Column<string>(maxLength: 9, nullable: true),
                    RATEPERUNIT = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TBLHL_ADD_SUBTRACT",
                columns: table => new
                {
                    SN = table.Column<int>(nullable: false),
                    FISCAL_YEAR = table.Column<string>(maxLength: 10, nullable: true),
                    RATEID = table.Column<int>(nullable: true),
                    FLAT_RATE = table.Column<int>(nullable: true),
                    RATE_PERCENT = table.Column<float>(nullable: true),
                    ADD_FLAG = table.Column<string>(maxLength: 1, nullable: true),
                    ADD_SUB_TRACT_TYPE = table.Column<string>(maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("TBLHL_ADD_SUBTRACT_pkey", x => x.SN);
                });

            migrationBuilder.CreateTable(
                name: "TBLLAND_TYPE_AREA",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    CODE = table.Column<string>(maxLength: 50, nullable: false),
                    NEP_NAME = table.Column<string>(maxLength: 50, nullable: true),
                    REMARKS = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBLLAND_TYPE_AREA", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBLMALPOTGROUP",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    NEPNAME = table.Column<string>(maxLength: 100, nullable: true),
                    DESCRIPTION = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBLMALPOTGROUP", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBLTAX_FINE_REBATE",
                columns: table => new
                {
                    SN = table.Column<int>(nullable: false),
                    FISCAL_YEAR = table.Column<string>(maxLength: 10, nullable: true),
                    DURATION_IN_YEARS = table.Column<float>(nullable: true),
                    TAX_TYPE = table.Column<string>(maxLength: 3, nullable: true),
                    FLAT_RATE = table.Column<int>(nullable: true),
                    RATE_PERCENT = table.Column<float>(nullable: true),
                    REBATE_FLAG = table.Column<string>(maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("TBLTAX_FINE_REBATE_pkey", x => x.SN);
                });

            migrationBuilder.CreateTable(
                name: "TBLTAXCALCULATIONROKA",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: true),
                    IID = table.Column<int>(nullable: true),
                    REASON = table.Column<string>(maxLength: 255, nullable: true),
                    ROKA_DATE = table.Column<string>(maxLength: 12, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TBUSERSECURITYRIGHTS",
                columns: table => new
                {
                    USERID = table.Column<int>(nullable: true),
                    RIGHTSID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TYPES",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: true),
                    NEPNAME = table.Column<string>(maxLength: 50, nullable: false),
                    ENGNAME = table.Column<string>(maxLength: 50, nullable: false),
                    CODE = table.Column<string>(maxLength: 50, nullable: true),
                    REMARKS = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "USERASSIGNMENTS",
                columns: table => new
                {
                    SN = table.Column<int>(nullable: true),
                    NEPNAME = table.Column<string>(maxLength: 90, nullable: true),
                    RIGHTSNAME = table.Column<string>(maxLength: 200, nullable: true),
                    MODULE = table.Column<string>(maxLength: 5, nullable: true),
                    ACTIVE = table.Column<bool>(nullable: false),
                    CREATEDAT = table.Column<DateTime>(nullable: false, defaultValueSql: "'2001-01-01 00:00:00'::timestamp without time zone"),
                    CREATEDBY = table.Column<string>(maxLength: 100, nullable: true),
                    DISPLAYNAME = table.Column<string>(maxLength: 100, nullable: true),
                    ICON = table.Column<string>(maxLength: 50, nullable: true),
                    ISLOCKED = table.Column<bool>(nullable: false),
                    MENUNAME = table.Column<string>(maxLength: 100, nullable: true),
                    MENUORDER = table.Column<short>(nullable: false, defaultValueSql: "'0'::smallint"),
                    MENUURL = table.Column<string>(maxLength: 500, nullable: true),
                    PARENTMENUID = table.Column<int>(nullable: false),
                    VISIBLE = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Usermaster",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Userid = table.Column<string>(nullable: true),
                    Userpassword = table.Column<string>(nullable: true),
                    Nepname = table.Column<string>(nullable: true),
                    Engname = table.Column<string>(nullable: true),
                    Userstatus = table.Column<short>(nullable: true),
                    Lastloggedon = table.Column<DateTime>(nullable: true),
                    Lastloggedout = table.Column<DateTime>(nullable: true),
                    Grants = table.Column<string>(nullable: true),
                    Updatedby = table.Column<int>(nullable: true),
                    EmpId = table.Column<int>(nullable: true),
                    OrgCode = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    FromCentral = table.Column<string>(nullable: true),
                    WardNo = table.Column<string>(nullable: true),
                    PwdChangedDate = table.Column<DateTime>(nullable: true),
                    FiscalYear = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usermaster", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VDC",
                columns: table => new
                {
                    VDCID = table.Column<int>(nullable: true),
                    NEPNAME = table.Column<string>(maxLength: 50, nullable: false),
                    ENGNAME = table.Column<string>(maxLength: 50, nullable: false),
                    CODE = table.Column<string>(maxLength: 50, nullable: true),
                    REMARKS = table.Column<string>(maxLength: 100, nullable: true),
                    DISTRICTID = table.Column<int>(nullable: true),
                    TYPEID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ZONE",
                columns: table => new
                {
                    ZONEID = table.Column<int>(nullable: true),
                    NEPNAME = table.Column<string>(maxLength: 50, nullable: false),
                    ENGNAME = table.Column<string>(maxLength: 50, nullable: false),
                    CODE = table.Column<string>(maxLength: 50, nullable: true),
                    REMARKS = table.Column<string>(maxLength: 100, nullable: true),
                    REGIONID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ACC_BGT_RVSN",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    BGT_ALCTN_ID = table.Column<int>(nullable: true),
                    RVSN_DATE_NP = table.Column<string>(maxLength: 10, nullable: true),
                    AMOUNT = table.Column<float>(nullable: true),
                    RVSN_REASON = table.Column<string>(maxLength: 200, nullable: true),
                    UPDATE_USER_ID = table.Column<int>(nullable: true),
                    UPDATE_DATETIME = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ACC_BGT_RVSN", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ACC_BGT_RVSN_BGT_ID",
                        column: x => x.BGT_ALCTN_ID,
                        principalTable: "ACC_BGT_ALLOCATE",
                        principalColumn: "BGT_ALLOCATE_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ACC_CURRENCTY_RATE",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    CURRENCY_ID = table.Column<int>(nullable: true),
                    NP_DATE = table.Column<string>(maxLength: 15, nullable: true),
                    RATE = table.Column<float>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ACC_CURRENCTY_RATE", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ACC_CURRENCTY_RATE",
                        column: x => x.CURRENCY_ID,
                        principalTable: "ACC_CURRENCTY",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TBL_BGT_RELEASE",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    FISCAL_YEAR = table.Column<string>(maxLength: 10, nullable: true),
                    MINISTRY_ID = table.Column<int>(nullable: true),
                    ORG_ID = table.Column<int>(nullable: true),
                    RELEASE_TYPE = table.Column<int>(nullable: true),
                    RELEASE_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    CHALANI_NO = table.Column<string>(maxLength: 50, nullable: true),
                    LETTER_SN = table.Column<string>(maxLength: 50, nullable: true),
                    APPROVED_BGT_YEARLY = table.Column<float>(nullable: true),
                    PREVIOUS_RELEASE_AMT = table.Column<float>(nullable: true),
                    RELEASE_AMOUNT = table.Column<float>(nullable: true),
                    SPECIAL_TIPPANI = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_BGT_RELEASE", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BGT_REL_ORG",
                        column: x => x.ORG_ID,
                        principalTable: "ACC_ORG_MASTER",
                        principalColumn: "ORG_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ACC_PADADHIKARI_MSTR",
                columns: table => new
                {
                    PADADIKARI_ID = table.Column<int>(nullable: false),
                    NAME_NP = table.Column<string>(maxLength: 70, nullable: true),
                    NAME_EN = table.Column<string>(maxLength: 50, nullable: true),
                    POST_ID = table.Column<int>(nullable: true),
                    ADDRESS = table.Column<string>(maxLength: 50, nullable: true),
                    WARD_NO = table.Column<int>(nullable: true),
                    ELECTED_DATE_NP = table.Column<string>(maxLength: 10, nullable: true),
                    QUALIFICATION = table.Column<string>(maxLength: 100, nullable: true),
                    MOBILE_NO = table.Column<string>(maxLength: 20, nullable: true),
                    LAST_NAME_NP = table.Column<string>(maxLength: 50, nullable: true),
                    LAST_NAME_EN = table.Column<string>(maxLength: 50, nullable: true),
                    TITLE = table.Column<string>(maxLength: 10, nullable: true),
                    GENDER = table.Column<string>(maxLength: 1, nullable: true),
                    RELIGION_ID = table.Column<int>(nullable: true),
                    MOTHER_LANG_ID = table.Column<int>(nullable: true),
                    DATE_OF_BIRTH = table.Column<string>(maxLength: 10, nullable: true),
                    PARENT_NAME = table.Column<string>(maxLength: 70, nullable: true),
                    P_OCUPATION = table.Column<int>(nullable: true),
                    SPOUSE_NAME = table.Column<string>(maxLength: 70, nullable: true),
                    S_OCUPATION = table.Column<int>(nullable: true),
                    GRANDFATHER_NAME = table.Column<string>(maxLength: 70, nullable: true),
                    GF_OCUPATION = table.Column<int>(nullable: true),
                    MARRIED_STATUS = table.Column<string>(maxLength: 1, nullable: true),
                    NO_OF_SON = table.Column<int>(nullable: true),
                    NO_OF_DAUGHTER = table.Column<int>(nullable: true),
                    FIRST_APPOINT_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    FIRST_APPOINT_POST_ID = table.Column<int>(nullable: true),
                    CURRENT_POST_APPOINT_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    RETIRE_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    PRE_EXPERIENCE = table.Column<string>(maxLength: 50, nullable: true),
                    ZONE_ID = table.Column<int>(nullable: true),
                    DISTRICT_ID = table.Column<int>(nullable: true),
                    VDC_ID = table.Column<int>(nullable: true),
                    TRACK_ID = table.Column<int>(nullable: true),
                    STREET = table.Column<string>(maxLength: 70, nullable: true),
                    PHONES = table.Column<string>(maxLength: 50, nullable: true),
                    EMAILS = table.Column<string>(maxLength: 50, nullable: true),
                    MOBILE = table.Column<string>(maxLength: 50, nullable: true),
                    CITIZENSHIP_NO = table.Column<string>(maxLength: 25, nullable: true),
                    CITZN_ISSUED_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    CITZN_ISSUED_DISTR_ID = table.Column<int>(nullable: true),
                    IS_TOILET_IN_HOME = table.Column<string>(maxLength: 1, nullable: true),
                    SPECIAL_NOTES = table.Column<string>(maxLength: 150, nullable: true),
                    USER_ID = table.Column<int>(nullable: true),
                    USER_IDE = table.Column<int>(nullable: true),
                    DATA_ENTRY_VS_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    DATA_ENTRY_AD_DATE = table.Column<DateTime>(nullable: true),
                    DATA_EDIT_AD_DATE = table.Column<DateTime>(nullable: true),
                    DATE_OF_BIRTH_AD = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ACC_PADADHIKARI_MSTR_pkey", x => x.PADADIKARI_ID);
                    table.ForeignKey(
                        name: "FK_POST_ID",
                        column: x => x.POST_ID,
                        principalTable: "ACC_PADADHIKARI_POST",
                        principalColumn: "POST_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ACC_ACC_MASTER",
                columns: table => new
                {
                    ACC_ID = table.Column<int>(nullable: false),
                    CODE = table.Column<string>(maxLength: 100, nullable: false),
                    NEP_NAME = table.Column<string>(maxLength: 200, nullable: true),
                    ENG_NAME = table.Column<string>(maxLength: 70, nullable: true),
                    PARENT_ACC_ID = table.Column<int>(nullable: true),
                    GRP_LEVEL = table.Column<int>(nullable: true),
                    IS_FIXED = table.Column<string>(maxLength: 1, nullable: true),
                    IS_TRANSACTABLE = table.Column<string>(maxLength: 1, nullable: true),
                    IS_BUDGETABLE = table.Column<string>(maxLength: 1, nullable: true),
                    DISP_CODE = table.Column<string>(maxLength: 100, nullable: true),
                    DISP_NAME = table.Column<string>(maxLength: 200, nullable: true),
                    ACC_TYPE = table.Column<string>(maxLength: 1, nullable: true),
                    TYPE_ID = table.Column<int>(nullable: true),
                    ACC_CODE = table.Column<string>(maxLength: 200, nullable: true),
                    SUB_MODULE_ID = table.Column<int>(nullable: true),
                    FISCAL_YEAR = table.Column<string>(maxLength: 10, nullable: true),
                    IS_HIDE = table.Column<string>(maxLength: 1, nullable: true),
                    ISCAPITALCURRENT = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ACC_ACC_MASTER_pkey", x => x.ACC_ID);
                    table.ForeignKey(
                        name: "FK_ACC_ACC_MASTER_TYPID",
                        column: x => x.TYPE_ID,
                        principalTable: "ACC_TRANS_TYPE",
                        principalColumn: "TYPE_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ACC_VCHR_MASTER",
                columns: table => new
                {
                    VCHR_ID = table.Column<int>(nullable: false),
                    VCHR_NO = table.Column<int>(nullable: true),
                    VCHR_DATE_NEP = table.Column<string>(maxLength: 10, nullable: true),
                    VCHR_TYPE_ID = table.Column<int>(nullable: true),
                    NARRATION = table.Column<string>(maxLength: 200, nullable: true),
                    USER_ID = table.Column<int>(nullable: true),
                    UPDATE_DATE = table.Column<DateTime>(nullable: true),
                    FISCALYEAR = table.Column<string>(maxLength: 10, nullable: true),
                    MODULE = table.Column<string>(maxLength: 2, nullable: false),
                    IS_POSTED = table.Column<string>(maxLength: 1, nullable: true),
                    SUB_MODULE_ID = table.Column<int>(nullable: true),
                    NAME_CHEQUE_PAYEE = table.Column<string>(maxLength: 100, nullable: true),
                    IS_OF_LAST_YEAR = table.Column<string>(maxLength: 1, nullable: true),
                    REMARKS = table.Column<string>(maxLength: 200, nullable: true),
                    CHEQUE_TYPE_ID = table.Column<short>(nullable: true),
                    FATHER_NAME = table.Column<string>(maxLength: 50, nullable: true),
                    GRAND_FATHER_NAME = table.Column<string>(maxLength: 50, nullable: true),
                    CONTACT_PHONE = table.Column<string>(maxLength: 50, nullable: true),
                    IS_NIKASH = table.Column<string>(maxLength: 1, nullable: true),
                    WARDNO = table.Column<string>(maxLength: 10, nullable: true),
                    PREP_BY = table.Column<int>(nullable: true),
                    CHECK_BY = table.Column<int>(nullable: true),
                    ACCEPT_BY = table.Column<int>(nullable: true),
                    INTERNAL_LEKHA = table.Column<string>(maxLength: 50, nullable: true),
                    NIYAMIT_AMT = table.Column<float>(nullable: true),
                    ASULI_AMT = table.Column<float>(nullable: true),
                    VALID_AMT = table.Column<float>(nullable: true),
                    N_VALID_AMT = table.Column<float>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ACC_VCHR_MASTER_pkey", x => x.VCHR_ID);
                    table.ForeignKey(
                        name: "FK_ACC_SUB_MODULE_TYPE",
                        column: x => x.SUB_MODULE_ID,
                        principalTable: "ACC_SUB_MODULE_TYPE",
                        principalColumn: "SUB_MODULE_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MAST_VCHR_TYPE_ID",
                        column: x => x.VCHR_TYPE_ID,
                        principalTable: "ACC_VCHR_TYPE_MASTER",
                        principalColumn: "VCHR_TYPE_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ACC_BANK_GRNTY",
                columns: table => new
                {
                    GRNTY_ID = table.Column<int>(nullable: false),
                    GRNTY_NO = table.Column<string>(maxLength: 25, nullable: true),
                    GRNTY_VS_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    BANK_NAME = table.Column<string>(maxLength: 200, nullable: true),
                    GRNTY_AMOUNT = table.Column<float>(nullable: true),
                    GRNTY_TYPE = table.Column<string>(maxLength: 2, nullable: true),
                    WORK_ID = table.Column<int>(nullable: true),
                    PERSON_ID = table.Column<int>(nullable: true),
                    PHUKUWA_PS = table.Column<string>(maxLength: 15, nullable: true),
                    PHUKUWA_CN = table.Column<string>(maxLength: 15, nullable: true),
                    PHUKUWA_VS_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    MAG_PS = table.Column<string>(maxLength: 15, nullable: true),
                    MAG_CN = table.Column<string>(maxLength: 15, nullable: true),
                    MAG_VS_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    ENTRY_DATETIME = table.Column<DateTime>(nullable: true),
                    EXPRY_VS_DATE = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ACC_BANK_GRNTY_pkey", x => x.GRNTY_ID);
                    table.ForeignKey(
                        name: "FK_GRNTY_PERSON_ORG_ID",
                        column: x => x.PERSON_ID,
                        principalTable: "ACC_ORG_MASTER",
                        principalColumn: "ORG_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GRNTY_WORK_ID",
                        column: x => x.WORK_ID,
                        principalTable: "ACC_WORK_MASTER",
                        principalColumn: "WORK_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ACC_WORK_FUNDS_DETAIL",
                columns: table => new
                {
                    FUND_DETAIL_ID = table.Column<int>(nullable: false),
                    WORK_ID = table.Column<int>(nullable: true),
                    PROVIDER_ID = table.Column<int>(nullable: true),
                    FUNDED_AMT = table.Column<float>(nullable: true),
                    FUNDED_PERCENT = table.Column<float>(nullable: true),
                    ISJANASARAMDHA = table.Column<int>(nullable: true),
                    ISOWNOFFICE = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ACC_WORK_FUNDS_DETAIL_pkey", x => x.FUND_DETAIL_ID);
                    table.ForeignKey(
                        name: "FK_ACC_PROVIDER_ID",
                        column: x => x.PROVIDER_ID,
                        principalTable: "ACC_FUND_PROVIDR_MSTR",
                        principalColumn: "PROVIDER_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WORK_MASTER_ID",
                        column: x => x.WORK_ID,
                        principalTable: "ACC_WORK_MASTER",
                        principalColumn: "WORK_ID",
                        onDelete: ReferentialAction.Restrict);
                });

         
            migrationBuilder.CreateTable(
                name: "BANK_BRANCH",
                columns: table => new
                {
                    BRANCH_ID = table.Column<int>(nullable: false),
                    BANKID = table.Column<int>(nullable: true),
                    NEPNAME = table.Column<string>(maxLength: 200, nullable: true),
                    ENGNAME = table.Column<string>(maxLength: 200, nullable: true),
                    BRANCH_CODE = table.Column<string>(maxLength: 50, nullable: true),
                    ADDRESS = table.Column<string>(maxLength: 200, nullable: true),
                    EMAIL = table.Column<string>(maxLength: 100, nullable: true),
                    PHONE = table.Column<string>(maxLength: 25, nullable: true),
                    IS_PERMITTED = table.Column<string>(maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("BANK_BRANCH_pkey", x => x.BRANCH_ID);
                    table.ForeignKey(
                        name: "FK_BANK_MSTR",
                        column: x => x.BANKID,
                        principalTable: "BANKMASTER",
                        principalColumn: "BANKID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SUB_MODULE_SOURCE",
                columns: table => new
                {
                    SUB_MODULE_ID = table.Column<int>(nullable: false),
                    BUDJET_SOURCE_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SUB_MODULE_SOURCE_pkey", x => new { x.BUDJET_SOURCE_ID, x.SUB_MODULE_ID });
                    table.ForeignKey(
                        name: "SYS_C004357",
                        column: x => x.BUDJET_SOURCE_ID,
                        principalTable: "BUDJET_SOURCE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "SYS_C004317",
                        column: x => x.SUB_MODULE_ID,
                        principalTable: "ACC_SUB_MODULE_TYPE",
                        principalColumn: "SUB_MODULE_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "INV_ROOM_MST",
                columns: table => new
                {
                    ROOM_ID = table.Column<int>(nullable: false),
                    FLOOR_NO = table.Column<int>(nullable: true),
                    BLOCK_NO = table.Column<string>(maxLength: 10, nullable: true),
                    DESC_NP = table.Column<string>(maxLength: 50, nullable: true),
                    DESC_EN = table.Column<string>(maxLength: 50, nullable: true),
                    DEPT_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("INV_ROOM_MST_pkey", x => x.ROOM_ID);
                    table.ForeignKey(
                        name: "FK_ROOM_DEP_ID",
                        column: x => x.DEPT_ID,
                        principalTable: "INV_DEPT",
                        principalColumn: "DEPT_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "INV_LILAMAPPDETAILS",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    LILAMAPPLIID = table.Column<int>(nullable: true),
                    DAKHILAID = table.Column<int>(nullable: true),
                    NIKASHAID = table.Column<int>(nullable: true),
                    ITEMID = table.Column<int>(nullable: true),
                    UNITID = table.Column<int>(nullable: true),
                    BRANDID = table.Column<int>(nullable: true),
                    SPECID = table.Column<int>(nullable: true),
                    LILAMQTY = table.Column<int>(nullable: true),
                    LILAMTOTALAMT = table.Column<float>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INV_LILAMAPPDETAILS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_INV_APPLIMASTID",
                        column: x => x.LILAMAPPLIID,
                        principalTable: "INV_LILAM_APPMASTER",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "INV_ITEM_MST",
                columns: table => new
                {
                    ITEM_ID = table.Column<int>(nullable: false),
                    NAME_NP = table.Column<string>(maxLength: 50, nullable: false),
                    NAME_EN = table.Column<string>(maxLength: 50, nullable: true),
                    UNIT_ID = table.Column<int>(nullable: true),
                    ITEM_MAIN_CLASS = table.Column<int>(nullable: true),
                    ITEM_TYPE = table.Column<int>(nullable: true),
                    ITEM_NATURE = table.Column<int>(nullable: true),
                    MAXL = table.Column<int>(nullable: true),
                    MINL = table.Column<int>(nullable: true),
                    RMAXL = table.Column<int>(nullable: true),
                    RMINL = table.Column<int>(nullable: true),
                    GUSSAGE = table.Column<int>(nullable: true),
                    SIZES = table.Column<int>(nullable: true),
                    COUNTRYID = table.Column<int>(nullable: true),
                    COMPANYNAME = table.Column<string>(maxLength: 50, nullable: true),
                    SOURCE = table.Column<string>(maxLength: 50, nullable: true),
                    REMARKS = table.Column<string>(maxLength: 100, nullable: true),
                    CODE = table.Column<string>(maxLength: 50, nullable: true),
                    KITTA_NO = table.Column<string>(maxLength: 150, nullable: true),
                    LAND_LOCATION = table.Column<string>(maxLength: 150, nullable: true),
                    CONSTRUCTONTYPE = table.Column<string>(maxLength: 150, nullable: true),
                    DEPRECIATION = table.Column<float>(nullable: true),
                    MINRATE = table.Column<float>(nullable: true),
                    DEPMAXRATE = table.Column<float>(nullable: true),
                    PROPERTYTYPE = table.Column<int>(nullable: true),
                    LAND_AREA_INSQ_FEETS = table.Column<int>(nullable: true),
                    AREA_INSQ_FEETS = table.Column<int>(nullable: true),
                    LAND_UNIT_RATE = table.Column<int>(nullable: true),
                    LAND_MARKET_RATE = table.Column<int>(nullable: true),
                    LANDID = table.Column<int>(nullable: true),
                    ACC_ID = table.Column<int>(nullable: true),
                    BUDGET_ACC_ID = table.Column<int>(nullable: true),
                    VEHICLE_PARTS_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("INV_ITEM_MST_pkey", x => x.ITEM_ID);
                    table.ForeignKey(
                        name: "FK_ITEM_UNIT_ID",
                        column: x => x.UNIT_ID,
                        principalTable: "INV_UNIT",
                        principalColumn: "UNIT_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MAP_AREA_GND_COV",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    REGIONID = table.Column<int>(nullable: true),
                    GROUND_COV = table.Column<float>(nullable: true),
                    AREA = table.Column<long>(nullable: true),
                    REMARKS = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_AREA_GND_COV", x => x.ID);
                    table.ForeignKey(
                        name: "FK_REGN_ID_AP_GND_COV",
                        column: x => x.REGIONID,
                        principalTable: "MAP_ZONE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MAP_REGION_FAR",
                columns: table => new
                {
                    ID = table.Column<short>(nullable: false),
                    REGIONID = table.Column<int>(nullable: true),
                    AREA_FROM = table.Column<int>(nullable: true),
                    AREA_TO = table.Column<int>(nullable: true),
                    FISCAL_YEAR = table.Column<string>(maxLength: 10, nullable: true),
                    FAR = table.Column<float>(nullable: true),
                    REMARKS = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_REGION_FAR", x => x.ID);
                    table.ForeignKey(
                        name: "FK_REGIONID",
                        column: x => x.REGIONID,
                        principalTable: "MAP_ZONE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ACC_BUDJET_SOURCE",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    MIN_ACC_ID = table.Column<int>(nullable: true),
                    SOURCE_ID = table.Column<int>(nullable: true),
                    AMOUNT = table.Column<int>(nullable: true),
                    REMARKS = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ACC_BUDJET_SOURCE", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MIN_ACC",
                        column: x => x.MIN_ACC_ID,
                        principalTable: "MINISTRY_ACC_HEAD",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BUD_SOURCE",
                        column: x => x.SOURCE_ID,
                        principalTable: "BUDJET_SOURCE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ACC_ASULI_BIBARAN",
                columns: table => new
                {
                    ASULI_ID = table.Column<int>(nullable: false),
                    PERSON_TYPE_ID = table.Column<int>(nullable: true),
                    PAYMENT_PERSON_ID = table.Column<int>(nullable: true),
                    PERSON_NAME = table.Column<string>(maxLength: 90, nullable: true),
                    WORK_NAME = table.Column<string>(maxLength: 100, nullable: true),
                    AMT_TAKEN = table.Column<float>(nullable: true),
                    RESPONSIVE_TAKEN = table.Column<string>(maxLength: 100, nullable: true),
                    COLLECT_REASON = table.Column<string>(maxLength: 200, nullable: true),
                    PESKI_AMT = table.Column<float>(nullable: true),
                    PESKI_EMPLOYEE_ID = table.Column<int>(nullable: true),
                    PROPERTY_DETAILS = table.Column<string>(maxLength: 200, nullable: true),
                    PROPERTY_EMPLOYEE_ID = table.Column<int>(nullable: true),
                    PROPERTY_ROKA = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ACC_ASULI_BIBARAN_pkey", x => x.ASULI_ID);
                    table.ForeignKey(
                        name: "FK_ACC_PERSON_TYPE",
                        column: x => x.PERSON_TYPE_ID,
                        principalTable: "PERSON_TYPE_MASTER",
                        principalColumn: "PERSON_TYPE_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PIS_EDUCATION",
                columns: table => new
                {
                    SN = table.Column<int>(nullable: false),
                    EMP_ID = table.Column<int>(nullable: true),
                    EDU_NAME = table.Column<string>(maxLength: 70, nullable: true),
                    EDU_LEVEL_ID = table.Column<int>(nullable: true),
                    INSTITUTE = table.Column<string>(maxLength: 70, nullable: true),
                    BOARD_ID = table.Column<int>(nullable: true),
                    MARKS_PERCNT = table.Column<float>(nullable: true),
                    MARKS_GRADE = table.Column<float>(nullable: true),
                    DIVISION = table.Column<string>(maxLength: 25, nullable: true),
                    COMPLETION_YR_VS = table.Column<string>(maxLength: 10, nullable: true),
                    COMPLETION_YR_AD = table.Column<DateTime>(nullable: true),
                    SUBJECTS = table.Column<string>(maxLength: 100, nullable: true),
                    VALID_FOR_EVAL = table.Column<int>(nullable: true),
                    APPLY_TO = table.Column<string>(maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PIS_EDUCATION_pkey", x => x.SN);
                    table.ForeignKey(
                        name: "FK_EDU_BRD",
                        column: x => x.BOARD_ID,
                        principalTable: "PIS_EDU_BOARD",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EDU_LVL",
                        column: x => x.EDU_LEVEL_ID,
                        principalTable: "PIS_EDU_LEVEL",
                        principalColumn: "EDU_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PIS_EMP_DEP_SOURCE",
                columns: table => new
                {
                    DEPT_ID = table.Column<int>(nullable: false),
                    BUDJET_SOURCE_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PIS_EMP_DEP_SOURCE_pkey", x => x.DEPT_ID);
                    table.ForeignKey(
                        name: "SYS_C004356",
                        column: x => x.BUDJET_SOURCE_ID,
                        principalTable: "BUDJET_SOURCE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "SYS_C004447",
                        column: x => x.DEPT_ID,
                        principalTable: "PIS_EMP_DEP",
                        principalColumn: "DEPT_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ORGANIZATION_TREE",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    PARENT_ID = table.Column<int>(nullable: true),
                    NEP_NAME = table.Column<string>(maxLength: 70, nullable: true),
                    ENG_NAME = table.Column<string>(maxLength: 70, nullable: true),
                    CONTAINS_DARBANDI = table.Column<int>(nullable: true),
                    GEO_REGION = table.Column<int>(nullable: true),
                    GRP_LEVEL = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ORGANIZATION_TREE", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ORG_GEO_ID",
                        column: x => x.GEO_REGION,
                        principalTable: "PIS_GEO_REGION",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ORG_PARENT_ID",
                        column: x => x.PARENT_ID,
                        principalTable: "ORGANIZATION_TREE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PIS_LOCAL_POST_MASTER",
                columns: table => new
                {
                    LOCAL_POST_ID = table.Column<int>(nullable: false),
                    LOCAL_POST_NAME = table.Column<string>(maxLength: 70, nullable: true),
                    LOCAL_POST_NAME_EN = table.Column<string>(maxLength: 50, nullable: true),
                    POST_ID = table.Column<int>(nullable: true),
                    POST_DUTIES = table.Column<string>(nullable: true),
                    BASIC_SALARY = table.Column<float>(nullable: true),
                    GRADE_RATE = table.Column<float>(nullable: true),
                    ALLWANCE = table.Column<float>(nullable: true),
                    INSURANCE_ADD_AMT = table.Column<float>(nullable: true),
                    PAYROLL_ORDER = table.Column<int>(nullable: true),
                    ALLLWANCE = table.Column<float>(nullable: true),
                    ALLOWANCE = table.Column<float>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PIS_LOCAL_POST_MASTER_pkey", x => x.LOCAL_POST_ID);
                    table.ForeignKey(
                        name: "FK_LO_PIS_POST_MASTER",
                        column: x => x.POST_ID,
                        principalTable: "PIS_POST_MASTER",
                        principalColumn: "POST_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SANITATION_SUBGROUP",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    GROUPID = table.Column<int>(nullable: true),
                    SUBGROUPNAME = table.Column<string>(maxLength: 200, nullable: true),
                    REMARKS = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SANITATION_SUBGROUP", x => x.ID);
                    table.ForeignKey(
                        name: "SYS_C004385",
                        column: x => x.GROUPID,
                        principalTable: "SANITATION_GROUP",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TBL_BGT_MGMT_EXP",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    BGT_MGMT_ID = table.Column<int>(nullable: true),
                    ACC_ID = table.Column<int>(nullable: true),
                    BGT_AMT = table.Column<float>(nullable: true),
                    REMARKS = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_BGT_MGMT_EXP", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BGT_MGMT",
                        column: x => x.BGT_MGMT_ID,
                        principalTable: "TBL_BGT_MGMT",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TBL_BGT_MGMT_EXP_ORG",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    BGT_MGMT_ORG_ID = table.Column<int>(nullable: true),
                    ACC_ID = table.Column<int>(nullable: true),
                    BGT_AMT_ORG = table.Column<float>(nullable: true),
                    REMARKS = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_BGT_MGMT_EXP_ORG", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BGT_MGMT_ORG",
                        column: x => x.BGT_MGMT_ORG_ID,
                        principalTable: "TBL_BGT_MGMT_ORG",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TBL_PAYMENT_ORDER_DETAILS",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    PAYMENT_ORDER_ID = table.Column<int>(nullable: true),
                    VOUCHER_ID = table.Column<int>(nullable: true),
                    LINK_VOUCHER_ID = table.Column<int>(nullable: true),
                    PAYMENT_PERMISS_NO = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_PAYMENT_ORDER_DETAILS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DETAILS_TBL_PAYMENT_ORDER",
                        column: x => x.PAYMENT_ORDER_ID,
                        principalTable: "TBL_PAYMENT_ORDER",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "STOREDBILLS",
                columns: table => new
                {
                    SN = table.Column<int>(nullable: false),
                    DATEISSUED = table.Column<string>(maxLength: 10, nullable: true),
                    DESCRIPTION = table.Column<string>(maxLength: 70, nullable: true),
                    BILLNOFROM = table.Column<string>(maxLength: 25, nullable: true),
                    BILLNOTO = table.Column<string>(maxLength: 25, nullable: true),
                    CODE = table.Column<int>(nullable: true),
                    BILLTYPEID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("STOREDBILLS_pkey", x => x.SN);
                    table.ForeignKey(
                        name: "SYS_C004391",
                        column: x => x.BILLTYPEID,
                        principalTable: "TBLBILLTYPE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TBLMALPOTSUBGROUP",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    GROUPID = table.Column<int>(nullable: true),
                    NEPNAME = table.Column<string>(maxLength: 100, nullable: true),
                    DESCRIPTION = table.Column<string>(maxLength: 150, nullable: true),
                    WORDA = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBLMALPOTSUBGROUP", x => x.ID);
                    table.ForeignKey(
                        name: "SYS_C004392",
                        column: x => x.GROUPID,
                        principalTable: "TBLMALPOTGROUP",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });
             
            migrationBuilder.CreateTable(
                name: "TBL_BGT_MGMT_RELEASE",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    BGT_RELEASE_ID = table.Column<int>(nullable: true),
                    FISCAL_YEAR = table.Column<string>(maxLength: 10, nullable: true),
                    MINISTRY_ID = table.Column<int>(nullable: true),
                    ORG_ID = table.Column<int>(nullable: true),
                    BGT_SUB_HEAD_ID = table.Column<int>(nullable: true),
                    AMT = table.Column<float>(nullable: true),
                    REMARKS = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_BGT_MGMT_RELEASE", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BGT_MGMT_REL",
                        column: x => x.BGT_RELEASE_ID,
                        principalTable: "TBL_BGT_RELEASE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ACC_BGT_TRANSFER",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    FROM_ACC_ID = table.Column<int>(nullable: true),
                    TO_ACC_ID = table.Column<int>(nullable: true),
                    BGT_ALCTN_ID = table.Column<int>(nullable: true),
                    TRNSFR_DATE_NP = table.Column<string>(maxLength: 10, nullable: true),
                    TRNSFR_REASON = table.Column<string>(maxLength: 200, nullable: true),
                    UPDATE_USER_ID = table.Column<int>(nullable: true),
                    UPDATE_DATETIME = table.Column<DateTime>(nullable: true),
                    AMOUNT = table.Column<float>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ACC_BGT_TRANSFER", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TRNSFR_BGT_ALCTN_ID",
                        column: x => x.BGT_ALCTN_ID,
                        principalTable: "ACC_BGT_ALLOCATE",
                        principalColumn: "BGT_ALLOCATE_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FROM_ACC_ID",
                        column: x => x.FROM_ACC_ID,
                        principalTable: "ACC_ACC_MASTER",
                        principalColumn: "ACC_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TO_ACC_ID",
                        column: x => x.TO_ACC_ID,
                        principalTable: "ACC_ACC_MASTER",
                        principalColumn: "ACC_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ACC_EXPENSES_DETAILS",
                columns: table => new
                {
                    EXPENSE_ID = table.Column<int>(nullable: false),
                    TRANS_TYPE_ID = table.Column<int>(nullable: true),
                    PERSON_TYPE_ID = table.Column<int>(nullable: true),
                    EMP_ID = table.Column<int>(nullable: true),
                    PADADHIKARI_ID = table.Column<int>(nullable: true),
                    ORG_ID = table.Column<int>(nullable: true),
                    UC_ID = table.Column<int>(nullable: true),
                    WARD_ID = table.Column<int>(nullable: true),
                    WORK_ID = table.Column<int>(nullable: true),
                    ACC_ID = table.Column<int>(nullable: true),
                    DR_AMT = table.Column<float>(nullable: true),
                    CR_AMT = table.Column<float>(nullable: true),
                    VAT_AMT = table.Column<float>(nullable: true),
                    PAYMENT_SLIP_ID = table.Column<int>(nullable: true),
                    VCHR_ID = table.Column<int>(nullable: true),
                    VCHR_DATE_NP = table.Column<string>(maxLength: 10, nullable: true),
                    ORDER_IN_PAYMENT_SLIP = table.Column<int>(nullable: true),
                    ADVEXPTYPE = table.Column<string>(maxLength: 1, nullable: true),
                    IS_OF_LAST_YEAR = table.Column<string>(maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ACC_EXPENSES_DETAILS_pkey", x => x.EXPENSE_ID);
                    table.ForeignKey(
                        name: "FK_DETAIL_ACC_ID",
                        column: x => x.ACC_ID,
                        principalTable: "ACC_ACC_MASTER",
                        principalColumn: "ACC_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DETAIL_PAMENT_SLIPID",
                        column: x => x.PAYMENT_SLIP_ID,
                        principalTable: "PAYMENT_SLIP_MASTER",
                        principalColumn: "PAYMENT_SLIP_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DETAIL_PERSON_TYPE_ID",
                        column: x => x.PERSON_TYPE_ID,
                        principalTable: "PERSON_TYPE_MASTER",
                        principalColumn: "PERSON_TYPE_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ACC_TRANS_TYPE",
                        column: x => x.TRANS_TYPE_ID,
                        principalTable: "ACC_TRANS_TYPE",
                        principalColumn: "TYPE_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DETAIL_WWORK_ID",
                        column: x => x.WORK_ID,
                        principalTable: "ACC_WORK_MASTER",
                        principalColumn: "WORK_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ACC_PAYMENT_CLEARANCE",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    PAYMENT_ID = table.Column<int>(nullable: true),
                    IS_OF_LAST_YEAR = table.Column<string>(maxLength: 1, nullable: true),
                    ACC_ID = table.Column<int>(nullable: true),
                    BUDGET_ACC_ID = table.Column<int>(nullable: true),
                    AMOUNT = table.Column<float>(nullable: true),
                    BUDGET_SOURCE_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ACC_PAYMENT_CLEARANCE", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ACPAYCLEAR_ACCID",
                        column: x => x.ACC_ID,
                        principalTable: "ACC_ACC_MASTER",
                        principalColumn: "ACC_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ACPAYCLEAR_BUDGET",
                        column: x => x.BUDGET_ACC_ID,
                        principalTable: "ACC_ACC_MASTER",
                        principalColumn: "ACC_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FIREBRIGADESTATE",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    NEPNAME = table.Column<string>(maxLength: 50, nullable: true),
                    SERVICECHARGERATE = table.Column<int>(nullable: true),
                    MINIMUMSERVICECHARGE = table.Column<int>(nullable: true),
                    ACC_ID = table.Column<int>(nullable: true),
                    TYPE = table.Column<short>(nullable: true),
                    FISCAL_YEAR = table.Column<string>(maxLength: 10, nullable: true),
                    RATEID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FIREBRIGADESTATE", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FIREBRIG_ACC_ID",
                        column: x => x.ACC_ID,
                        principalTable: "ACC_ACC_MASTER",
                        principalColumn: "ACC_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MAP_INCOME_TYPE",
                columns: table => new
                {
                    ID = table.Column<short>(nullable: false),
                    NAME_NP = table.Column<string>(maxLength: 70, nullable: false),
                    NAME_EN = table.Column<string>(maxLength: 70, nullable: true),
                    ACC_ID = table.Column<int>(nullable: true),
                    DESCRIPTION = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_INCOME_TYPE", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MINCOME_TYPE_ACCID",
                        column: x => x.ACC_ID,
                        principalTable: "ACC_ACC_MASTER",
                        principalColumn: "ACC_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SERVICE_CHARGE_MASTER",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    RATEID = table.Column<int>(nullable: true),
                    ACCODE = table.Column<int>(nullable: true),
                    ACC_ID = table.Column<int>(nullable: true),
                    SERVICE_CHARGE_PERCENT = table.Column<float>(nullable: true),
                    FLAT_CHARGE_RATE = table.Column<float>(nullable: true),
                    ISAPPLICABLEFORHOUSE = table.Column<short>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SERVICE_CHARGE_MASTER", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SERVICE_CHR_ACC_ID",
                        column: x => x.ACC_ID,
                        principalTable: "ACC_ACC_MASTER",
                        principalColumn: "ACC_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TAX_ADDTNL_CHRG_DTLS",
                columns: table => new
                {
                    SN = table.Column<int>(nullable: false),
                    FISCAL_YEAR = table.Column<string>(maxLength: 9, nullable: true),
                    IID = table.Column<int>(nullable: true),
                    ACCODE = table.Column<int>(nullable: true),
                    ACC_ID = table.Column<int>(nullable: true),
                    AMOUNT = table.Column<int>(nullable: true),
                    LAND_ID = table.Column<int>(nullable: true),
                    RENT_ID = table.Column<int>(nullable: true),
                    SERVICE_CHARGE_PERCENT = table.Column<float>(nullable: true),
                    FLAT_CHARGE_RATE = table.Column<float>(nullable: true),
                    ISAPPLICABLEFORHOUSE = table.Column<short>(nullable: true),
                    TAX_TYPE = table.Column<string>(maxLength: 3, nullable: true),
                    SERVICE_CHARGE_TYPE = table.Column<string>(maxLength: 2, nullable: true),
                    ISREGISTATIONFEE = table.Column<string>(maxLength: 2, nullable: true),
                    BILL_ID = table.Column<int>(nullable: true),
                    BILL_NO = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("TAX_ADDTNL_CHRG_DTLS_pkey", x => x.SN);
                    table.ForeignKey(
                        name: "FK_TAX_ADD_DTL_ACC_ID",
                        column: x => x.ACC_ID,
                        principalTable: "ACC_ACC_MASTER",
                        principalColumn: "ACC_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TAX_ADDTNL_CHRG_DTLS_ACCODE",
                        column: x => x.ACCODE,
                        principalTable: "ACCODE",
                        principalColumn: "ACCODE",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TBL_CONSTRUCTION_OTHER_CHARGES",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    RATEID = table.Column<int>(nullable: true),
                    ACCODE = table.Column<int>(nullable: true),
                    ACC_ID = table.Column<int>(nullable: true),
                    PERCENT_OF_TAX = table.Column<float>(nullable: true),
                    FLAT_CHARGE_RATE = table.Column<int>(nullable: true),
                    FISCAL_YEAR = table.Column<string>(maxLength: 10, nullable: true),
                    SERVICE_CHARGE_CALCULATION = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_CONSTRUCTION_OTHER_CHARGES", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CONST_OTH_CH_ACC_ID",
                        column: x => x.ACC_ID,
                        principalTable: "ACC_ACC_MASTER",
                        principalColumn: "ACC_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TBL_LAND_OTHER_CHARGES",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    RATEID = table.Column<int>(nullable: true),
                    ACCODE = table.Column<int>(nullable: true),
                    ACC_ID = table.Column<int>(nullable: true),
                    PERCENT_OF_TAX = table.Column<float>(nullable: true),
                    FLAT_CHARGE_RATE = table.Column<int>(nullable: true),
                    FISCAL_YEAR = table.Column<string>(maxLength: 10, nullable: true),
                    SERVICE_CHARGE_CALCULATION = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_LAND_OTHER_CHARGES", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LAN_OTH_CHA_ACC_ID",
                        column: x => x.ACC_ID,
                        principalTable: "ACC_ACC_MASTER",
                        principalColumn: "ACC_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TBLBUSINESS_SERVICE_CH_MST",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    RATEID = table.Column<int>(nullable: true),
                    ACCODE = table.Column<int>(nullable: true),
                    ACC_ID = table.Column<int>(nullable: true),
                    SERVICECHARGEPERCENT = table.Column<float>(nullable: true),
                    FLATCHARGERATE = table.Column<float>(nullable: true),
                    FISCAL_YEAR = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBLBUSINESS_SERVICE_CH_MST", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BUS_SERCH_ACC_ID",
                        column: x => x.ACC_ID,
                        principalTable: "ACC_ACC_MASTER",
                        principalColumn: "ACC_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TBLVEH_SER_CH_MSTR",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    RATEID = table.Column<int>(nullable: true),
                    ACCODE = table.Column<int>(nullable: true),
                    ACC_ID = table.Column<int>(nullable: true),
                    SERVICE_CHARGE_PERCENT = table.Column<float>(nullable: true),
                    FLAT_CHARGE_RATE = table.Column<float>(nullable: true),
                    FISCAL_YEAR = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBLVEH_SER_CH_MSTR", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LAND_SERCH_ACC_ID",
                        column: x => x.ACC_ID,
                        principalTable: "ACC_ACC_MASTER",
                        principalColumn: "ACC_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ACC_DHRTI_BILL_DTL",
                columns: table => new
                {
                    DHRTI_DTL_ID = table.Column<int>(nullable: false),
                    DHRTI_MASTER_ID = table.Column<int>(nullable: true),
                    BILL_NO = table.Column<string>(maxLength: 25, nullable: true),
                    BILL_DATE_NP = table.Column<string>(maxLength: 10, nullable: true),
                    COUNTER_ID = table.Column<int>(nullable: true),
                    PERSON_ID = table.Column<int>(nullable: true),
                    AMOUNT = table.Column<float>(nullable: true),
                    VCHR_ID = table.Column<int>(nullable: true),
                    ACC_ID = table.Column<int>(nullable: true),
                    VCHR_DATE_NP = table.Column<string>(maxLength: 10, nullable: true),
                    ORDER_IN_BILL = table.Column<int>(nullable: true),
                    REMARKS = table.Column<string>(maxLength: 200, nullable: true),
                    BUDGET_SOURCE_ID = table.Column<int>(nullable: true),
                    WORK_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ACC_DHRTI_BILL_DTL_pkey", x => x.DHRTI_DTL_ID);
                    table.ForeignKey(
                        name: "FK_AC_DHRTI_DTL_ACC_ID",
                        column: x => x.ACC_ID,
                        principalTable: "ACC_ACC_MASTER",
                        principalColumn: "ACC_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AC_DHRTI_DTL_VCHR_ID",
                        column: x => x.VCHR_ID,
                        principalTable: "ACC_VCHR_MASTER",
                        principalColumn: "VCHR_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "SYS_C004345",
                        column: x => x.WORK_ID,
                        principalTable: "ACC_WORK_MASTER",
                        principalColumn: "WORK_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ACC_DHRTI_BILL_MASTER",
                columns: table => new
                {
                    DHRTI_MASTER_ID = table.Column<int>(nullable: false),
                    BILL_NO = table.Column<string>(maxLength: 25, nullable: true),
                    DESCRIPTION = table.Column<string>(maxLength: 200, nullable: true),
                    COUNTER_ID = table.Column<int>(nullable: true),
                    PERSON_ID = table.Column<int>(nullable: true),
                    BLL_DATE_NP = table.Column<string>(maxLength: 10, nullable: true),
                    CASH_AMT = table.Column<float>(nullable: true),
                    BANK_AMT = table.Column<float>(nullable: true),
                    VCHR_ID = table.Column<int>(nullable: true),
                    VCHR_DATE_NP = table.Column<string>(maxLength: 10, nullable: true),
                    USERID = table.Column<int>(nullable: true),
                    USERIDE = table.Column<int>(nullable: true),
                    DATE_ENTRY_VS_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    DATE_ENTRY_TIME = table.Column<DateTime>(nullable: true),
                    DATE_EDIT_TIME = table.Column<DateTime>(nullable: true),
                    NAME = table.Column<string>(maxLength: 100, nullable: true),
                    ADDRESS = table.Column<string>(maxLength: 100, nullable: true),
                    WARD_NO = table.Column<short>(nullable: true),
                    CANCEL_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    CANCEL_REASON = table.Column<string>(maxLength: 200, nullable: true),
                    BILL_NO_MANUAL = table.Column<string>(maxLength: 25, nullable: true),
                    FISCAL_YEAR = table.Column<string>(maxLength: 10, nullable: true),
                    BILLTYPEID = table.Column<int>(nullable: true),
                    SUB_MODULE_ID = table.Column<int>(nullable: true),
                    WORK_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ACC_DHRTI_BILL_MASTER_pkey", x => x.DHRTI_MASTER_ID);
                    table.ForeignKey(
                        name: "SYS_C004389",
                        column: x => x.BILLTYPEID,
                        principalTable: "TBLBILLTYPE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "SYS_C004315",
                        column: x => x.SUB_MODULE_ID,
                        principalTable: "ACC_SUB_MODULE_TYPE",
                        principalColumn: "SUB_MODULE_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AC_DHRTI_MST_VCHRID",
                        column: x => x.VCHR_ID,
                        principalTable: "ACC_VCHR_MASTER",
                        principalColumn: "VCHR_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "SYS_C004344",
                        column: x => x.WORK_ID,
                        principalTable: "ACC_WORK_MASTER",
                        principalColumn: "WORK_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ACC_PAYMENT_MASTER",
                columns: table => new
                {
                    PAYMENT_ID = table.Column<int>(nullable: false),
                    TRANS_TYPE_ID = table.Column<int>(nullable: true),
                    PERSON_TYPE_ID = table.Column<int>(nullable: true),
                    PERSON_ID = table.Column<int>(nullable: true),
                    WORK_ID = table.Column<int>(nullable: true),
                    BILL_NO = table.Column<string>(maxLength: 50, nullable: true),
                    BILL_AMT = table.Column<float>(nullable: true),
                    VAT_AMT = table.Column<float>(nullable: true),
                    PAYMENT_DESCRIPTION = table.Column<string>(maxLength: 100, nullable: true),
                    RETENTION_MONEY_EDUCTION = table.Column<float>(nullable: true),
                    CONTRACT_TAX_DEDUCTION = table.Column<float>(nullable: true),
                    INCOME_TAX_DEDUCTION = table.Column<float>(nullable: true),
                    LAST_YEARS_ADV_DEDUCTION = table.Column<float>(nullable: true),
                    VAT_DEDUCTION = table.Column<float>(nullable: true),
                    OTHER_DEDUCTION = table.Column<float>(nullable: true),
                    CHEQUE_PAYMENT = table.Column<float>(nullable: true),
                    CASH_PAYMENT = table.Column<float>(nullable: true),
                    ADV_CLEARED_FROM_BILL = table.Column<float>(nullable: true),
                    ADV_CLEARED_FROM_BANK = table.Column<float>(nullable: true),
                    ADV_CLEARED_FROM_CASH = table.Column<float>(nullable: true),
                    LY_ADV_CLEARED_FROM_BILL = table.Column<float>(nullable: true),
                    LY_ADV_CLEARED_FROM_BANK = table.Column<float>(nullable: true),
                    LY_ADV_CLEARED_FROM_CASH = table.Column<float>(nullable: true),
                    ADVEXPTYPE = table.Column<string>(maxLength: 1, nullable: true),
                    VCHR_ID = table.Column<int>(nullable: true),
                    VCHR_DATE_NP = table.Column<string>(maxLength: 10, nullable: true),
                    FISCAL_YEAR = table.Column<string>(maxLength: 10, nullable: true),
                    SUB_MODULE_ID = table.Column<int>(nullable: true),
                    ISPESKI = table.Column<string>(maxLength: 1, nullable: true),
                    DEDUCT_DEP_VCHR_ID = table.Column<int>(nullable: true),
                    DEDUCT_DEP_VCHR_DATE_NEP = table.Column<string>(maxLength: 10, nullable: true),
                    ACC_DEDUCT_DEP_VCHR_ID = table.Column<int>(nullable: true),
                    ACC_DEDUCT_DEP_VCHR_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    EXPIRE_DATE_NP = table.Column<string>(maxLength: 10, nullable: true),
                    CR_AMOUNT = table.Column<float>(nullable: true),
                    SUBJECT_AREA_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ACC_PAYMENT_MASTER_pkey", x => x.PAYMENT_ID);
                    table.ForeignKey(
                        name: "FK_ACC_PAMT_PER_TYPE_ID",
                        column: x => x.PERSON_TYPE_ID,
                        principalTable: "PERSON_TYPE_MASTER",
                        principalColumn: "PERSON_TYPE_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ACC_PAMT_MST_SUB_MODL",
                        column: x => x.SUB_MODULE_ID,
                        principalTable: "ACC_SUB_MODULE_TYPE",
                        principalColumn: "SUB_MODULE_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ACC_PAMT_TRANS_ID",
                        column: x => x.TRANS_TYPE_ID,
                        principalTable: "ACC_TRANS_TYPE",
                        principalColumn: "TYPE_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ACC_PAMT_MST_VCHR_ID",
                        column: x => x.VCHR_ID,
                        principalTable: "ACC_VCHR_MASTER",
                        principalColumn: "VCHR_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ACC_PAMT_WORK_ID",
                        column: x => x.WORK_ID,
                        principalTable: "ACC_WORK_MASTER",
                        principalColumn: "WORK_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ACC_VCHR_DETAILS",
                columns: table => new
                {
                    VCHR_DETAIL_ID = table.Column<int>(nullable: false),
                    VCHR_ID = table.Column<int>(nullable: true),
                    ACC_ID = table.Column<int>(nullable: true),
                    DR_AMT = table.Column<float>(nullable: true, defaultValueSql: "'0'::real"),
                    CR_AMT = table.Column<float>(nullable: true, defaultValueSql: "'0'::real"),
                    VCHR_TYPE_ID = table.Column<int>(nullable: true),
                    ID_FROM_SRC = table.Column<int>(nullable: true),
                    ACC_TYPE = table.Column<string>(maxLength: 1, nullable: false),
                    TRANS_TYPE_ID = table.Column<int>(nullable: true),
                    VCHR_DATE_ENG = table.Column<DateTime>(nullable: true),
                    VCHR_DATE_NEP = table.Column<string>(maxLength: 10, nullable: true),
                    REMARKS = table.Column<string>(maxLength: 100, nullable: true),
                    IS_POSTED = table.Column<string>(maxLength: 1, nullable: true),
                    MODULE = table.Column<string>(maxLength: 2, nullable: false),
                    SUB_MODULE_ID = table.Column<int>(nullable: false),
                    BUDGET_SOURCE_ID = table.Column<int>(nullable: true),
                    BANKID = table.Column<int>(nullable: true),
                    BILL_ID = table.Column<int>(nullable: true),
                    BUDGET_ACC_ID = table.Column<int>(nullable: true),
                    ORG_ID = table.Column<int>(nullable: true),
                    WORK_ID = table.Column<int>(nullable: true),
                    IS_JAFAT = table.Column<string>(maxLength: 1, nullable: true),
                    EXPIRE_DATE_NP = table.Column<string>(maxLength: 20, nullable: true),
                    IS_GROUP = table.Column<string>(maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ACC_VCHR_DETAILS_pkey", x => x.VCHR_DETAIL_ID);
                    table.ForeignKey(
                        name: "FK_DTL_SUB_MODULEID",
                        column: x => x.SUB_MODULE_ID,
                        principalTable: "ACC_SUB_MODULE_TYPE",
                        principalColumn: "SUB_MODULE_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DETAIL_TRANS_TYPE_ID",
                        column: x => x.TRANS_TYPE_ID,
                        principalTable: "ACC_TRANS_TYPE",
                        principalColumn: "TYPE_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DETAIL_ACC_VCHR_ID",
                        column: x => x.VCHR_ID,
                        principalTable: "ACC_VCHR_MASTER",
                        principalColumn: "VCHR_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DETAIL_VCHR_TYPE_ID",
                        column: x => x.VCHR_TYPE_ID,
                        principalTable: "ACC_VCHR_TYPE_MASTER",
                        principalColumn: "VCHR_TYPE_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "SYS_C004349",
                        column: x => x.WORK_ID,
                        principalTable: "ACC_WORK_MASTER",
                        principalColumn: "WORK_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ACC_WORK_PAYMNT_TRANS",
                columns: table => new
                {
                    TRANS_ID = table.Column<int>(nullable: false),
                    WORK_ID = table.Column<int>(nullable: true),
                    PAYMENT_SLIP_ID = table.Column<int>(nullable: true),
                    PERSON_TYPE_ID = table.Column<int>(nullable: true),
                    EMP_ID = table.Column<int>(nullable: true),
                    PADADHIKARI_ID = table.Column<int>(nullable: true),
                    ORG_ID = table.Column<int>(nullable: true),
                    UC_ID = table.Column<int>(nullable: true),
                    BILL_AMT = table.Column<float>(nullable: true),
                    VAT_AMT = table.Column<float>(nullable: true),
                    VCHR_ID = table.Column<int>(nullable: true),
                    VCHR_DATE_NP = table.Column<string>(maxLength: 10, nullable: true),
                    IS_OF_LAST_YEAR = table.Column<string>(maxLength: 1, nullable: true),
                    FISCAL_YEAR = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ACC_WORK_PAYMNT_TRANS_pkey", x => x.TRANS_ID);
                    table.ForeignKey(
                        name: "FK_PAYMENT_PERSON_TYP_ID",
                        column: x => x.PERSON_TYPE_ID,
                        principalTable: "PERSON_TYPE_MASTER",
                        principalColumn: "PERSON_TYPE_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PAYMENT_VCHR_ID",
                        column: x => x.VCHR_ID,
                        principalTable: "ACC_VCHR_MASTER",
                        principalColumn: "VCHR_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PAYMENT_WORKID",
                        column: x => x.WORK_ID,
                        principalTable: "ACC_WORK_MASTER",
                        principalColumn: "WORK_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "INCOMEBILLDETAILS",
                columns: table => new
                {
                    SN = table.Column<int>(nullable: false),
                    BILLID = table.Column<int>(nullable: true),
                    BILLNO = table.Column<string>(maxLength: 25, nullable: true),
                    BILLDATE = table.Column<string>(maxLength: 10, nullable: true),
                    COUNTERID = table.Column<int>(nullable: true),
                    PERSONID = table.Column<int>(nullable: true),
                    ACCODE = table.Column<int>(nullable: true),
                    AMOUNT = table.Column<int>(nullable: true),
                    VCHR_DATE_NP = table.Column<string>(maxLength: 10, nullable: true),
                    ORDERINBILL = table.Column<int>(nullable: true),
                    REMARKS = table.Column<string>(maxLength: 200, nullable: true),
                    VCHR_ID = table.Column<int>(nullable: true),
                    ACC_ID = table.Column<int>(nullable: true),
                    FISCAL_YEAR = table.Column<string>(maxLength: 10, nullable: true),
                    PROJECT = table.Column<string>(maxLength: 10, nullable: true),
                    TAXADDTNLID = table.Column<int>(nullable: true),
                    TAX_TYPE = table.Column<string>(maxLength: 5, nullable: true),
                    QTY = table.Column<int>(nullable: true),
                    BUDGET_SOURCE_ID = table.Column<int>(nullable: true),
                    BACKUP_PERSONID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("INCOMEBILLDETAILS_pkey", x => x.SN);
                    table.ForeignKey(
                        name: "FK_INBILL_DETL_ACC_ID",
                        column: x => x.ACC_ID,
                        principalTable: "ACC_ACC_MASTER",
                        principalColumn: "ACC_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INBILL_DET_VCHR_ID",
                        column: x => x.VCHR_ID,
                        principalTable: "ACC_VCHR_MASTER",
                        principalColumn: "VCHR_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "INCOMEBILLMASTER",
                columns: table => new
                {
                    SN = table.Column<int>(nullable: false),
                    BILLNO = table.Column<string>(maxLength: 25, nullable: true),
                    DESCRIPTION = table.Column<string>(nullable: true),
                    COUNTERID = table.Column<int>(nullable: true),
                    PERSONID = table.Column<int>(nullable: true),
                    BILLDATE = table.Column<string>(maxLength: 10, nullable: true),
                    CASHAMOUNT = table.Column<int>(nullable: true),
                    BANKAMOUNT = table.Column<int>(nullable: true),
                    VCHR_ID = table.Column<int>(nullable: true),
                    VCHR_DATE_NP = table.Column<string>(maxLength: 10, nullable: true),
                    USERID = table.Column<int>(nullable: true),
                    USERIDE = table.Column<int>(nullable: true),
                    DATAENTRYVSDATE = table.Column<string>(maxLength: 10, nullable: true),
                    DATAENTRYADDATETIME = table.Column<DateTime>(nullable: true),
                    DATAEDITADDATETIME = table.Column<DateTime>(nullable: true),
                    BILLTYPEID = table.Column<int>(nullable: true),
                    TAXINCOMETYPE = table.Column<string>(maxLength: 10, nullable: true),
                    NAME = table.Column<string>(nullable: true),
                    ADDRESS = table.Column<string>(maxLength: 100, nullable: true),
                    WARD_NO = table.Column<short>(nullable: true),
                    CANCEL_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    CANCEL_REASON = table.Column<string>(maxLength: 200, nullable: true),
                    BILL_NO_MANUAL = table.Column<string>(maxLength: 25, nullable: true),
                    FISCAL_YEAR = table.Column<string>(maxLength: 10, nullable: true),
                    PROJECT = table.Column<string>(maxLength: 10, nullable: true),
                    SUB_MODULE_ID = table.Column<int>(nullable: true),
                    CURRENCY_ID = table.Column<int>(nullable: true),
                    BACKUP_PERSONID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("INCOMEBILLMASTER_pkey", x => x.SN);
                    table.ForeignKey(
                        name: "SYS_C004390",
                        column: x => x.BILLTYPEID,
                        principalTable: "TBLBILLTYPE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "SYS_C004316",
                        column: x => x.SUB_MODULE_ID,
                        principalTable: "ACC_SUB_MODULE_TYPE",
                        principalColumn: "SUB_MODULE_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INBILL_MAST_VCHR_ID",
                        column: x => x.VCHR_ID,
                        principalTable: "ACC_VCHR_MASTER",
                        principalColumn: "VCHR_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ORG_BANK_ACCOUNT",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    ORG_ID = table.Column<int>(nullable: true),
                    BANKID = table.Column<int>(nullable: true),
                    BRANCH_ID = table.Column<int>(nullable: true),
                    BANK_ACCNT_TYPE_ID = table.Column<int>(nullable: true),
                    ACC_NO = table.Column<string>(maxLength: 50, nullable: true),
                    ACC_NAME = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ORG_BANK_ACCOUNT", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BANK_ACCNT_TYPE",
                        column: x => x.BANK_ACCNT_TYPE_ID,
                        principalTable: "TBL_BANK_ACCNT_TYPE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BANK_BRANCH",
                        column: x => x.BRANCH_ID,
                        principalTable: "BANK_BRANCH",
                        principalColumn: "BRANCH_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ORG_MASTER",
                        column: x => x.ORG_ID,
                        principalTable: "ACC_ORG_MASTER",
                        principalColumn: "ORG_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "INV_ISSUE_DETAIL",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    ISSUE_MAST_ID = table.Column<int>(nullable: true),
                    ITEM_ID = table.Column<int>(nullable: true),
                    SPEC_ID = table.Column<int>(nullable: true),
                    BRAND_ID = table.Column<int>(nullable: true),
                    ITEM_TYPE = table.Column<int>(nullable: true),
                    ITEM_REQ_NO = table.Column<float>(nullable: true),
                    ITEM_ISSUE_NO = table.Column<float>(nullable: true),
                    ISSUE_DT = table.Column<string>(maxLength: 10, nullable: true),
                    DELIVERY_STATUS = table.Column<string>(maxLength: 1, nullable: true),
                    REMARKS = table.Column<string>(maxLength: 100, nullable: true),
                    ISSUE_DT_ENG = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INV_ISSUE_DETAIL", x => x.ID);
                    table.ForeignKey(
                        name: "FK_INV_ISS_DTL_BRAND_ID",
                        column: x => x.BRAND_ID,
                        principalTable: "INV_BRAND",
                        principalColumn: "BRAND_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_ISS_DTL_ITEM_ID",
                        column: x => x.ITEM_ID,
                        principalTable: "INV_ITEM_MST",
                        principalColumn: "ITEM_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_ISS_DTL_ITEM_TYPE",
                        column: x => x.ITEM_TYPE,
                        principalTable: "INV_ITEM_CATEGORY",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_ISS_DTL_SPEC_ID",
                        column: x => x.SPEC_ID,
                        principalTable: "INV_ITEM_SPEC",
                        principalColumn: "SPEC_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PIS_AWARDS",
                columns: table => new
                {
                    SN = table.Column<int>(nullable: false),
                    EMP_ID = table.Column<int>(nullable: true),
                    LOCAL_POST_ID = table.Column<int>(nullable: true),
                    NEP_NAME = table.Column<string>(maxLength: 70, nullable: true),
                    LEVEL_DESC = table.Column<string>(maxLength: 50, nullable: true),
                    DESCRIPTION = table.Column<string>(maxLength: 100, nullable: true),
                    WORKING_OFFICE = table.Column<string>(maxLength: 70, nullable: true),
                    RVCD_DATE_VS = table.Column<string>(maxLength: 10, nullable: true),
                    RCVD_DATE_AD = table.Column<DateTime>(nullable: true),
                    REMARKS = table.Column<string>(maxLength: 90, nullable: true),
                    APPLY_TO = table.Column<string>(maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PIS_AWARDS_pkey", x => x.SN);
                    table.ForeignKey(
                        name: "FK_AWARDS_LOC_POST_ID",
                        column: x => x.LOCAL_POST_ID,
                        principalTable: "PIS_LOCAL_POST_MASTER",
                        principalColumn: "LOCAL_POST_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PIS_DARBANDI",
                columns: table => new
                {
                    DARBANDI_ID = table.Column<int>(nullable: false),
                    OFFICE_ID = table.Column<int>(nullable: true),
                    POST_ID = table.Column<int>(nullable: true),
                    POST_LEVEL = table.Column<int>(nullable: true),
                    LOCAL_POST_ID = table.Column<int>(nullable: true),
                    SEWA_SAMUHA_UPASAMUHA = table.Column<string>(maxLength: 100, nullable: true),
                    NO_OF_POST = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PIS_DARBANDI_pkey", x => x.DARBANDI_ID);
                    table.ForeignKey(
                        name: "FK_DARBANDI_LOC_POST_ID",
                        column: x => x.LOCAL_POST_ID,
                        principalTable: "PIS_LOCAL_POST_MASTER",
                        principalColumn: "LOCAL_POST_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DARBANDI_OFFICE_ID",
                        column: x => x.OFFICE_ID,
                        principalTable: "ORGANIZATION_TREE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DARBANDI_POST_ID",
                        column: x => x.POST_ID,
                        principalTable: "PIS_POST_MASTER",
                        principalColumn: "POST_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PIS_EMPLOYEE_MASTER",
                columns: table => new
                {
                    EMP_ID = table.Column<int>(nullable: false),
                    FIRST_NAME_NP = table.Column<string>(maxLength: 70, nullable: true),
                    LAST_NAME_NP = table.Column<string>(maxLength: 50, nullable: true),
                    FIRST_NAME_EN = table.Column<string>(maxLength: 70, nullable: true),
                    LAST_NAME_EN = table.Column<string>(maxLength: 50, nullable: true),
                    POST_ID = table.Column<int>(nullable: true),
                    SERVICE_GROUP = table.Column<string>(maxLength: 30, nullable: true),
                    TITLE = table.Column<string>(maxLength: 30, nullable: true),
                    GENDER = table.Column<string>(maxLength: 1, nullable: true),
                    FATHER_NAME = table.Column<string>(maxLength: 70, nullable: true),
                    HUSBAND_NAME = table.Column<string>(maxLength: 70, nullable: true),
                    WILL_PERSON = table.Column<string>(maxLength: 70, nullable: true),
                    ADDRESS = table.Column<string>(maxLength: 100, nullable: true),
                    DATE_OF_BIRTH = table.Column<string>(maxLength: 25, nullable: true),
                    FIRST_APPOINT_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    FIRST_APPOINT_POST_ID = table.Column<int>(nullable: true),
                    CURRENT_POST_APPOINT_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    SERVICE_STATUS = table.Column<string>(maxLength: 40, nullable: true),
                    POST_STATUS = table.Column<string>(maxLength: 40, nullable: true),
                    GRADES = table.Column<int>(nullable: true),
                    CIT_PERCENT = table.Column<int>(nullable: true),
                    PAYMODE = table.Column<string>(maxLength: 30, nullable: true),
                    GOVT_EMP_ID = table.Column<string>(maxLength: 50, nullable: true),
                    PF_ID = table.Column<string>(maxLength: 50, nullable: true),
                    CIT_ID = table.Column<string>(maxLength: 50, nullable: true),
                    POST_LEVEL = table.Column<int>(nullable: true),
                    RETIRE_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    LOCAL_POST_ID = table.Column<int>(nullable: true),
                    PHONES = table.Column<string>(maxLength: 50, nullable: true),
                    EMAILS = table.Column<string>(maxLength: 50, nullable: true),
                    PAYEMENT_BANK_ID = table.Column<int>(nullable: true),
                    MARRIED_STATUS = table.Column<string>(maxLength: 1, nullable: true),
                    INSURANCE_NO = table.Column<string>(maxLength: 50, nullable: true),
                    MOBILE_NO = table.Column<string>(maxLength: 20, nullable: true),
                    RELIGION = table.Column<int>(nullable: true),
                    PARENT_OCUPATION = table.Column<int>(nullable: true),
                    SPOUSE_OCUPATION = table.Column<int>(nullable: true),
                    GF_NAME = table.Column<string>(maxLength: 70, nullable: true),
                    GF_OCUPATION = table.Column<int>(nullable: true),
                    REL_WITH_WILL_PERSON = table.Column<string>(maxLength: 25, nullable: true),
                    ZONE_ID = table.Column<int>(nullable: true),
                    DISTRICT_ID = table.Column<int>(nullable: true),
                    VDC_ID = table.Column<int>(nullable: true),
                    WARD_NO = table.Column<int>(nullable: true),
                    MAIL_ADDRESS = table.Column<string>(maxLength: 100, nullable: true),
                    APPOINMENT_TYPE = table.Column<int>(nullable: true),
                    CITIZENSHIP_NO = table.Column<string>(maxLength: 25, nullable: true),
                    CS_ISSUED_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    CS_ISSUED_DISTRICT = table.Column<int>(nullable: true),
                    DATE_OF_BIRTH_AD = table.Column<DateTime>(nullable: true),
                    INSURANCE_FACILITY = table.Column<string>(maxLength: 1, nullable: true),
                    DEDUCT_ABSENT = table.Column<string>(maxLength: 1, nullable: true),
                    LEKHA_NO = table.Column<string>(maxLength: 50, nullable: true),
                    DEPT_ID = table.Column<int>(nullable: true),
                    PENSION_KOSH = table.Column<string>(maxLength: 2, nullable: true),
                    CIT_CODE = table.Column<string>(maxLength: 20, nullable: true),
                    ROOM_ID = table.Column<int>(nullable: true),
                    CODE = table.Column<string>(maxLength: 70, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PIS_EMPLOYEE_MASTER_pkey", x => x.EMP_ID);
                    table.ForeignKey(
                        name: "SYS_C004448",
                        column: x => x.DEPT_ID,
                        principalTable: "PIS_EMP_DEP",
                        principalColumn: "DEPT_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FIRST_APMT_POST_ID",
                        column: x => x.FIRST_APPOINT_POST_ID,
                        principalTable: "PIS_POST_MASTER",
                        principalColumn: "POST_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LOCAL_POST_ID",
                        column: x => x.LOCAL_POST_ID,
                        principalTable: "PIS_LOCAL_POST_MASTER",
                        principalColumn: "LOCAL_POST_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PAYBANK_ID",
                        column: x => x.PAYEMENT_BANK_ID,
                        principalTable: "BANKMASTER",
                        principalColumn: "BANKID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_POST_MST_POST_ID",
                        column: x => x.POST_ID,
                        principalTable: "PIS_POST_MASTER",
                        principalColumn: "POST_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PIS_FOREIGN_VISITS",
                columns: table => new
                {
                    SN = table.Column<int>(nullable: false),
                    EMP_ID = table.Column<int>(nullable: true),
                    LOCAL_POST_ID = table.Column<int>(nullable: true),
                    WORKING_OFFICE = table.Column<string>(maxLength: 70, nullable: true),
                    FROM_DATE_VS = table.Column<string>(maxLength: 10, nullable: true),
                    TO_DATE_VS = table.Column<string>(maxLength: 10, nullable: true),
                    FROM_DATE_AD = table.Column<DateTime>(nullable: true),
                    TO_DATE_AD = table.Column<DateTime>(nullable: true),
                    VISITING_PRPSE = table.Column<string>(maxLength: 100, nullable: true),
                    FUNDED_BY = table.Column<string>(maxLength: 70, nullable: true),
                    REMARKS = table.Column<string>(maxLength: 90, nullable: true),
                    APPLY_TO = table.Column<string>(maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PIS_FOREIGN_VISITS_pkey", x => x.SN);
                    table.ForeignKey(
                        name: "FK_FORGN_LOC_POST_ID",
                        column: x => x.LOCAL_POST_ID,
                        principalTable: "PIS_LOCAL_POST_MASTER",
                        principalColumn: "LOCAL_POST_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PIS_OTHER_ADD_SUB",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    ACC_ID = table.Column<int>(nullable: true),
                    LOCAL_POST_ID = table.Column<int>(nullable: true),
                    AMOUNT = table.Column<float>(nullable: true),
                    ADD_SUB = table.Column<string>(maxLength: 1, nullable: true),
                    DESCRIPTION = table.Column<string>(maxLength: 80, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PIS_OTHER_ADD_SUB", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ADD_SUB_LOCAL_POST_ID",
                        column: x => x.LOCAL_POST_ID,
                        principalTable: "PIS_LOCAL_POST_MASTER",
                        principalColumn: "LOCAL_POST_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PIS_PRIZES",
                columns: table => new
                {
                    SN = table.Column<int>(nullable: false),
                    EMP_ID = table.Column<int>(nullable: true),
                    LOCAL_POST_ID = table.Column<int>(nullable: true),
                    NAME_NP = table.Column<string>(maxLength: 70, nullable: true),
                    DESCRIPTION = table.Column<string>(maxLength: 100, nullable: true),
                    AWARD_TYPE = table.Column<string>(maxLength: 30, nullable: true),
                    AMOUNT = table.Column<float>(nullable: true),
                    AWARDED_BY = table.Column<string>(maxLength: 70, nullable: true),
                    WORKING_OFFICE = table.Column<string>(maxLength: 70, nullable: true),
                    ISSUED_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    REMARKS = table.Column<string>(maxLength: 100, nullable: true),
                    APPLY_TO = table.Column<string>(maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PIS_PRIZES_pkey", x => x.SN);
                    table.ForeignKey(
                        name: "FK_PRIZE_LOC_POST_ID",
                        column: x => x.LOCAL_POST_ID,
                        principalTable: "PIS_LOCAL_POST_MASTER",
                        principalColumn: "LOCAL_POST_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PIS_PUBLICATION",
                columns: table => new
                {
                    SN = table.Column<int>(nullable: false),
                    EMP_ID = table.Column<int>(nullable: true),
                    LOCAL_POST_ID = table.Column<int>(nullable: true),
                    NEP_NAME = table.Column<string>(maxLength: 70, nullable: true),
                    DESCRIPTION = table.Column<string>(maxLength: 100, nullable: true),
                    WORKING_OFFICE = table.Column<string>(maxLength: 70, nullable: true),
                    PUBLSH_DATE_VS = table.Column<string>(maxLength: 10, nullable: true),
                    PUBLSH_DATE_AD = table.Column<DateTime>(nullable: true),
                    PUBLISHER = table.Column<string>(maxLength: 100, nullable: true),
                    REMARKS = table.Column<string>(maxLength: 90, nullable: true),
                    APPLY_TO = table.Column<string>(maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PIS_PUBLICATION_pkey", x => x.SN);
                    table.ForeignKey(
                        name: "FK_PBLCN_LOC_POST_ID",
                        column: x => x.LOCAL_POST_ID,
                        principalTable: "PIS_LOCAL_POST_MASTER",
                        principalColumn: "LOCAL_POST_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PIS_SGNFCNT_WORK",
                columns: table => new
                {
                    SN = table.Column<int>(nullable: false),
                    EMP_ID = table.Column<int>(nullable: true),
                    LOCAL_POST_ID = table.Column<int>(nullable: true),
                    NAME_NP = table.Column<string>(maxLength: 70, nullable: true),
                    DESCRIPTION = table.Column<string>(maxLength: 100, nullable: true),
                    WORKING_OFFICE = table.Column<string>(maxLength: 70, nullable: true),
                    FROM_DATE_VS = table.Column<string>(maxLength: 10, nullable: true),
                    TO_DATE_VS = table.Column<string>(maxLength: 10, nullable: true),
                    FROM_DATE_AD = table.Column<DateTime>(nullable: true),
                    TO_DATE_AD = table.Column<DateTime>(nullable: true),
                    DURATION = table.Column<string>(maxLength: 25, nullable: true),
                    REMARKS = table.Column<string>(maxLength: 100, nullable: true),
                    APPLY_TO = table.Column<string>(maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PIS_SGNFCNT_WORK_pkey", x => x.SN);
                    table.ForeignKey(
                        name: "FK_SGNWRK_LOC_POST_ID",
                        column: x => x.LOCAL_POST_ID,
                        principalTable: "PIS_LOCAL_POST_MASTER",
                        principalColumn: "LOCAL_POST_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PIS_TRAINING",
                columns: table => new
                {
                    SN = table.Column<int>(nullable: false),
                    EMP_ID = table.Column<int>(nullable: true),
                    LOCAL_POST_ID = table.Column<int>(nullable: true),
                    TRAINING_TYPE = table.Column<string>(maxLength: 70, nullable: true),
                    TRAINING_NAME = table.Column<string>(maxLength: 70, nullable: true),
                    INSTITUTE = table.Column<string>(maxLength: 70, nullable: true),
                    COUNTRY_ID = table.Column<int>(nullable: true),
                    FRM_DATE_VS = table.Column<string>(maxLength: 10, nullable: true),
                    TO_DATE_VS = table.Column<string>(maxLength: 10, nullable: true),
                    FRM_DATE_AD = table.Column<DateTime>(nullable: true),
                    TO_DATE_AD = table.Column<DateTime>(nullable: true),
                    DURATION = table.Column<string>(maxLength: 25, nullable: true),
                    DIVISION = table.Column<string>(maxLength: 15, nullable: true),
                    MARKS_OBTND = table.Column<float>(nullable: true),
                    VALID_FOR_EVAL = table.Column<int>(nullable: true),
                    APPLY_TO = table.Column<string>(maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PIS_TRAINING_pkey", x => x.SN);
                    table.ForeignKey(
                        name: "FK_TRNG_LOC_POST_ID",
                        column: x => x.LOCAL_POST_ID,
                        principalTable: "PIS_LOCAL_POST_MASTER",
                        principalColumn: "LOCAL_POST_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PIS_WORKSHOP",
                columns: table => new
                {
                    SN = table.Column<int>(nullable: false),
                    EMP_ID = table.Column<int>(nullable: true),
                    LOCAL_POST_ID = table.Column<int>(nullable: true),
                    NEP_NAME = table.Column<string>(maxLength: 70, nullable: true),
                    DESCRIPTION = table.Column<string>(maxLength: 100, nullable: true),
                    WORKING_OFFICE = table.Column<string>(maxLength: 70, nullable: true),
                    DURATION = table.Column<string>(maxLength: 25, nullable: true),
                    FROM_DATE_VS = table.Column<string>(maxLength: 10, nullable: true),
                    TO_DATE_VS = table.Column<string>(maxLength: 10, nullable: true),
                    FROM_DATE_AD = table.Column<DateTime>(nullable: true),
                    TO_DATE_AD = table.Column<DateTime>(nullable: true),
                    ORGANIZER = table.Column<string>(maxLength: 100, nullable: true),
                    COUNTRY_ID = table.Column<int>(nullable: true),
                    REMARKS = table.Column<string>(maxLength: 90, nullable: true),
                    APPLY_TO = table.Column<string>(maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PIS_WORKSHOP_pkey", x => x.SN);
                    table.ForeignKey(
                        name: "FK_WRKSHP_LOC_POST_ID",
                        column: x => x.LOCAL_POST_ID,
                        principalTable: "PIS_LOCAL_POST_MASTER",
                        principalColumn: "LOCAL_POST_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SANITATION_RATE",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    GROUPID = table.Column<int>(nullable: true),
                    SUBGROUPID = table.Column<int>(nullable: true),
                    ROAD_TYPEID = table.Column<int>(nullable: true),
                    RATENAME = table.Column<string>(nullable: true),
                    RATE = table.Column<float>(nullable: true),
                    FISCAL_YEAR = table.Column<string>(maxLength: 10, nullable: true),
                    AREA_UPTO = table.Column<int>(nullable: true),
                    FOR_EACH_AREA = table.Column<int>(nullable: true),
                    EACH_AREA_RATE = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SANITATION_RATE", x => x.ID);
                    table.ForeignKey(
                        name: "SYS_C004386",
                        column: x => x.GROUPID,
                        principalTable: "SANITATION_GROUP",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "SYS_C004387",
                        column: x => x.SUBGROUPID,
                        principalTable: "SANITATION_SUBGROUP",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TBL_BGT_MGMT_SRC",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    BGT_MGMT_EXP_ID = table.Column<int>(nullable: true),
                    SOURCE_ID = table.Column<int>(nullable: true),
                    AMT = table.Column<float>(nullable: true),
                    PAYMENT_TYPE_ID = table.Column<int>(nullable: true),
                    PAYMENT_PROCESS_ID = table.Column<int>(nullable: true),
                    REMARKS = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_BGT_MGMT_SRC", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BGT_MGMT_EXP",
                        column: x => x.BGT_MGMT_EXP_ID,
                        principalTable: "TBL_BGT_MGMT_EXP",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TBL_BGT_MGMT_SRC_ORG",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    BGT_MGMT_EXP_ORG_ID = table.Column<int>(nullable: true),
                    SOURCE_ID = table.Column<int>(nullable: true),
                    AMT = table.Column<float>(nullable: true),
                    CC_ID = table.Column<int>(nullable: true),
                    CC_ACTIVE = table.Column<string>(maxLength: 2, nullable: true),
                    PAYMENT_TYPE_ID = table.Column<int>(nullable: true),
                    PAYMENT_PROCESS_ID = table.Column<int>(nullable: true),
                    REMARKS = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_BGT_MGMT_SRC_ORG", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BGT_MGMT_ORG_EXP",
                        column: x => x.BGT_MGMT_EXP_ORG_ID,
                        principalTable: "TBL_BGT_MGMT_EXP_ORG",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CC",
                        column: x => x.CC_ID,
                        principalTable: "CONTACTS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TAX_THLI_ISSUED_CNTR",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    THELI_ID = table.Column<int>(nullable: true),
                    CNTR_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TAX_THLI_ISSUED_CNTR", x => x.ID);
                    table.ForeignKey(
                        name: "SYS_C004358",
                        column: x => x.CNTR_ID,
                        principalTable: "COLLECTIONCOUNTERS",
                        principalColumn: "COUNTERID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "SYS_C004388",
                        column: x => x.THELI_ID,
                        principalTable: "STOREDBILLS",
                        principalColumn: "SN",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TBLMALPOTRATES",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    GROUPID = table.Column<int>(nullable: true),
                    SUBGROUPID = table.Column<int>(nullable: true),
                    NEPNAME = table.Column<string>(maxLength: 100, nullable: true),
                    RATEPERUNIT = table.Column<int>(nullable: true),
                    DESCRIPTION = table.Column<string>(maxLength: 150, nullable: true),
                    AREA_UPTO = table.Column<int>(nullable: true),
                    FOR_EACH_AREA = table.Column<int>(nullable: true),
                    EACH_AREA_RATE = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBLMALPOTRATES", x => x.ID);
                    table.ForeignKey(
                        name: "SYS_C004393",
                        column: x => x.GROUPID,
                        principalTable: "TBLMALPOTGROUP",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "SYS_C004397",
                        column: x => x.SUBGROUPID,
                        principalTable: "TBLMALPOTSUBGROUP",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TBL_BGT_MGMT_EXP_RELEASE",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    BGT_MGMT_RELEASE_ID = table.Column<int>(nullable: true),
                    ACC_ID = table.Column<int>(nullable: true),
                    AMT = table.Column<float>(nullable: true),
                    REMARKS = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_BGT_MGMT_EXP_RELEASE", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BGT_MGMT_RELEASE",
                        column: x => x.BGT_MGMT_RELEASE_ID,
                        principalTable: "TBL_BGT_MGMT_RELEASE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BANKTRANSACTIONS",
                columns: table => new
                {
                    SN = table.Column<int>(nullable: false),
                    BANKID = table.Column<int>(nullable: true),
                    DESCRIPTION = table.Column<string>(nullable: true),
                    DRAMOUNT = table.Column<float>(nullable: true),
                    CRAMOUNT = table.Column<float>(nullable: true),
                    INCOMEEXPTYPEID = table.Column<int>(nullable: true),
                    ISOFLASTYEAR = table.Column<string>(maxLength: 1, nullable: true),
                    VCHR_DATE_NP = table.Column<string>(maxLength: 10, nullable: true),
                    ORDERINPAYMENTSLIP = table.Column<int>(nullable: true),
                    VCHR_ID = table.Column<int>(nullable: true),
                    BILLID = table.Column<int>(nullable: true),
                    MODULE = table.Column<string>(maxLength: 2, nullable: true),
                    SUBMODULE_TYPE_ID = table.Column<int>(nullable: true),
                    DHRTI_MASTER_ID = table.Column<int>(nullable: true),
                    EXP_SLIP_ID = table.Column<int>(nullable: true),
                    PAYMENT_ORDER_NO = table.Column<string>(maxLength: 50, nullable: true),
                    CHEQUE_TYPE_ID = table.Column<int>(nullable: true),
                    PAYEENAME = table.Column<string>(nullable: true),
                    BUDGET_SOURCE_ID = table.Column<int>(nullable: true),
                    PAYEENAME_ENG = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("BANKTRANSACTIONS_pkey", x => x.SN);
                    table.ForeignKey(
                        name: "SYS_C004545",
                        column: x => x.DHRTI_MASTER_ID,
                        principalTable: "ACC_DHRTI_BILL_MASTER",
                        principalColumn: "DHRTI_MASTER_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "SYS_C004319",
                        column: x => x.SUBMODULE_TYPE_ID,
                        principalTable: "ACC_SUB_MODULE_TYPE",
                        principalColumn: "SUB_MODULE_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BANKTRAN_VCHR_ID",
                        column: x => x.VCHR_ID,
                        principalTable: "ACC_VCHR_MASTER",
                        principalColumn: "VCHR_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CASHTRANSACTION",
                columns: table => new
                {
                    SN = table.Column<int>(nullable: false),
                    DESCRIPTION = table.Column<string>(nullable: true),
                    DRAMOUNT = table.Column<int>(nullable: true),
                    CRAMOUNT = table.Column<int>(nullable: true),
                    INCOMEEXPTYPEID = table.Column<int>(nullable: true),
                    ISOFLASTYEAR = table.Column<string>(maxLength: 1, nullable: true),
                    VCHR_DATE_NP = table.Column<string>(maxLength: 10, nullable: true),
                    VCHR_ID = table.Column<int>(nullable: true),
                    BILLID = table.Column<int>(nullable: true),
                    MODULE = table.Column<string>(maxLength: 2, nullable: true),
                    SUBMODULE_TYPE_ID = table.Column<int>(nullable: true),
                    DHRTI_MASTER_ID = table.Column<int>(nullable: true),
                    EXP_SLIP_ID = table.Column<int>(nullable: true),
                    BUDGET_SOURCE_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CASHTRANSACTION_pkey", x => x.SN);
                    table.ForeignKey(
                        name: "SYS_C004544",
                        column: x => x.DHRTI_MASTER_ID,
                        principalTable: "ACC_DHRTI_BILL_MASTER",
                        principalColumn: "DHRTI_MASTER_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "SYS_C004318",
                        column: x => x.SUBMODULE_TYPE_ID,
                        principalTable: "ACC_SUB_MODULE_TYPE",
                        principalColumn: "SUB_MODULE_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CASHTRAN_VCHR_ID",
                        column: x => x.VCHR_ID,
                        principalTable: "ACC_VCHR_MASTER",
                        principalColumn: "VCHR_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ACC_PAYMENT_DEDUCTION",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    PAYMENT_ID = table.Column<int>(nullable: true),
                    ACC_ID = table.Column<int>(nullable: true),
                    BUDGET_ACC_ID = table.Column<int>(nullable: true),
                    AMOUNT = table.Column<float>(nullable: true),
                    STATUS = table.Column<string>(maxLength: 1, nullable: true),
                    DEDUCTIONTYPE = table.Column<string>(maxLength: 5, nullable: true),
                    BUDGET_SOURCE_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ACC_PAYMENT_DEDUCTION", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ACID_PAY_DEDU",
                        column: x => x.ACC_ID,
                        principalTable: "ACC_ACC_MASTER",
                        principalColumn: "ACC_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BUDGETID_PAY_DEDU",
                        column: x => x.BUDGET_ACC_ID,
                        principalTable: "ACC_ACC_MASTER",
                        principalColumn: "ACC_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PAYID_DEDUC",
                        column: x => x.PAYMENT_ID,
                        principalTable: "ACC_PAYMENT_MASTER",
                        principalColumn: "PAYMENT_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ACC_PAYMENT_DETAILS",
                columns: table => new
                {
                    PAYMENT_DETAIL_ID = table.Column<int>(nullable: false),
                    PAYMENT_ID = table.Column<int>(nullable: true),
                    TRANS_TYPE_ID = table.Column<int>(nullable: true),
                    PERSON_TYPE_ID = table.Column<int>(nullable: true),
                    EMP_ID = table.Column<int>(nullable: true),
                    PADADHIKARI_ID = table.Column<int>(nullable: true),
                    ORG_ID = table.Column<int>(nullable: true),
                    UC_ID = table.Column<int>(nullable: true),
                    WARD_ID = table.Column<int>(nullable: true),
                    WORK_ID = table.Column<int>(nullable: true),
                    ACC_ID = table.Column<int>(nullable: true),
                    BUDGET_ACC_ID = table.Column<int>(nullable: true),
                    DR_AMT = table.Column<float>(nullable: true, defaultValueSql: "'0'::real"),
                    CR_AMT = table.Column<float>(nullable: true, defaultValueSql: "'0'::real"),
                    VAT_AMT = table.Column<float>(nullable: true),
                    PAYMENT_SLIP_ID = table.Column<int>(nullable: true),
                    VCHR_ID = table.Column<int>(nullable: true),
                    VCHR_DATE_NP = table.Column<string>(maxLength: 10, nullable: true),
                    ORDER_IN_PAYMENT_SLIP = table.Column<int>(nullable: true),
                    ADVEXPTYPE = table.Column<string>(maxLength: 1, nullable: true),
                    IS_OF_LAST_YEAR = table.Column<string>(maxLength: 1, nullable: true),
                    FISCAL_YEAR = table.Column<string>(maxLength: 10, nullable: true),
                    BUDGET_SOURCE_ID = table.Column<int>(nullable: true),
                    SUB_MODULE_ID = table.Column<int>(nullable: true),
                    ADVANCE_TYPE = table.Column<string>(maxLength: 1, nullable: true),
                    EXPIRE_DATE_NP = table.Column<string>(maxLength: 10, nullable: true),
                    SUPPLIER_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ACC_PAYMENT_DETAILS_pkey", x => x.PAYMENT_DETAIL_ID);
                    table.ForeignKey(
                        name: "FK_DETAIL_ACC_ID1",
                        column: x => x.ACC_ID,
                        principalTable: "ACC_ACC_MASTER",
                        principalColumn: "ACC_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DTL_BUDGET_ACC_ID1",
                        column: x => x.BUDGET_ACC_ID,
                        principalTable: "ACC_ACC_MASTER",
                        principalColumn: "ACC_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PAM_DETAIL_PAYMENT_ID1",
                        column: x => x.PAYMENT_ID,
                        principalTable: "ACC_PAYMENT_MASTER",
                        principalColumn: "PAYMENT_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DETAIL_PERSON_TYPE_ID1",
                        column: x => x.PERSON_TYPE_ID,
                        principalTable: "PERSON_TYPE_MASTER",
                        principalColumn: "PERSON_TYPE_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ACC_TRANS_TYPE1",
                        column: x => x.TRANS_TYPE_ID,
                        principalTable: "ACC_TRANS_TYPE",
                        principalColumn: "TYPE_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PAYMNT_DETL_VCHR_ID1",
                        column: x => x.VCHR_ID,
                        principalTable: "ACC_VCHR_MASTER",
                        principalColumn: "VCHR_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DETAIL_WORK_ID1",
                        column: x => x.WORK_ID,
                        principalTable: "ACC_WORK_MASTER",
                        principalColumn: "WORK_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ACC_BANK_TRANS",
                columns: table => new
                {
                    BANK_TRANS_ID = table.Column<int>(nullable: false),
                    VCHR_ID = table.Column<int>(nullable: true),
                    VCHR_DATE_NEP = table.Column<string>(maxLength: 10, nullable: true),
                    DESCRIPTION = table.Column<string>(maxLength: 200, nullable: true),
                    DR_AMT = table.Column<float>(nullable: true, defaultValueSql: "'0'::real"),
                    CR_AMT = table.Column<float>(nullable: true, defaultValueSql: "'0'::real"),
                    IS_OF_LASTYEAR = table.Column<string>(maxLength: 2, nullable: true),
                    TRANS_TYPE_ID = table.Column<int>(nullable: true),
                    BILL_ID = table.Column<int>(nullable: true),
                    BANK_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ACC_BANK_TRANS_pkey", x => x.BANK_TRANS_ID);
                    table.ForeignKey(
                        name: "FK_BANK_BANK_ID",
                        column: x => x.BANK_ID,
                        principalTable: "BANKMASTER",
                        principalColumn: "BANKID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BANK_BILL_ID",
                        column: x => x.BILL_ID,
                        principalTable: "INCOMEBILLMASTER",
                        principalColumn: "SN",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__BANK_VCHR_ID",
                        column: x => x.VCHR_ID,
                        principalTable: "ACC_VCHR_MASTER",
                        principalColumn: "VCHR_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ACC_CASH_TRANS",
                columns: table => new
                {
                    CASH_TRANS_ID = table.Column<int>(nullable: false),
                    VCHR_ID = table.Column<int>(nullable: true),
                    VCHR_DATE_NEP = table.Column<string>(maxLength: 10, nullable: true),
                    DESCRIPTION = table.Column<string>(maxLength: 200, nullable: true),
                    DR_AMT = table.Column<float>(nullable: true, defaultValueSql: "'0'::real"),
                    CR_AMT = table.Column<float>(nullable: true, defaultValueSql: "'0'::real"),
                    IS_OF_LASTYEAR = table.Column<string>(maxLength: 2, nullable: true),
                    INCOME_EXP_TYPE_ID = table.Column<int>(nullable: true),
                    BILL_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ACC_CASH_TRANS_pkey", x => x.CASH_TRANS_ID);
                    table.ForeignKey(
                        name: "FK_CASH_BILL_ID",
                        column: x => x.BILL_ID,
                        principalTable: "INCOMEBILLMASTER",
                        principalColumn: "SN",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CASH_VCHR_ID",
                        column: x => x.VCHR_ID,
                        principalTable: "ACC_VCHR_MASTER",
                        principalColumn: "VCHR_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PIS_FULFILLED_DARBANDI",
                columns: table => new
                {
                    SN = table.Column<int>(nullable: false),
                    OFFICE_ID = table.Column<int>(nullable: true),
                    DARBANDI_ID = table.Column<int>(nullable: true),
                    PERSON_TYPE_ID = table.Column<int>(nullable: true),
                    EMP_ID = table.Column<int>(nullable: true),
                    DATE_FULFILLED = table.Column<string>(maxLength: 10, nullable: true),
                    APPOINTMNT_TYPE = table.Column<int>(nullable: true),
                    LOCAL_POST_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PIS_FULFILLED_DARBANDI_pkey", x => x.SN);
                    table.ForeignKey(
                        name: "FK_FULFIL_DARBANDI_ID",
                        column: x => x.DARBANDI_ID,
                        principalTable: "PIS_DARBANDI",
                        principalColumn: "DARBANDI_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FULFIL_DARB_LOC_POST_ID",
                        column: x => x.LOCAL_POST_ID,
                        principalTable: "PIS_LOCAL_POST_MASTER",
                        principalColumn: "LOCAL_POST_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FULFIL_DARB_OFFICE_ID",
                        column: x => x.OFFICE_ID,
                        principalTable: "ORGANIZATION_TREE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "INV_GOODS_ADJUST",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    DAKHILA_ID = table.Column<int>(nullable: true),
                    GD_ADJ_ID = table.Column<string>(maxLength: 10, nullable: false),
                    BUDGET_YEAR = table.Column<string>(maxLength: 10, nullable: true),
                    MONTH = table.Column<string>(maxLength: 10, nullable: true),
                    ITEM_ID = table.Column<int>(nullable: true),
                    ITEM_TYPE = table.Column<int>(nullable: true),
                    SPEC_ID = table.Column<int>(nullable: true),
                    BRAND_ID = table.Column<int>(nullable: true),
                    ADJ_QTY = table.Column<float>(nullable: true),
                    ADJ_TYPE_ID = table.Column<int>(nullable: true),
                    ITEM_ADJ_RATE = table.Column<float>(nullable: true),
                    ADJ_DT_NP = table.Column<string>(maxLength: 10, nullable: true),
                    ADJ_DT_ENG = table.Column<DateTime>(nullable: true),
                    REMARKS = table.Column<string>(maxLength: 100, nullable: true),
                    PREP_BY = table.Column<int>(nullable: true),
                    PREP_DT_NP = table.Column<string>(maxLength: 10, nullable: true),
                    PREP_DT_ENG = table.Column<DateTime>(nullable: true),
                    ACCEPT_BY = table.Column<int>(nullable: true),
                    ACCEPT_DT_NP = table.Column<string>(maxLength: 10, nullable: true),
                    ACCEPT_DT_ENG = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INV_GOODS_ADJUST", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ACCEPT_BY_GOOD_ADJ",
                        column: x => x.ACCEPT_BY,
                        principalTable: "PIS_EMPLOYEE_MASTER",
                        principalColumn: "EMP_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GOODS_ADJUST_BRAND_ID",
                        column: x => x.BRAND_ID,
                        principalTable: "INV_BRAND",
                        principalColumn: "BRAND_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GOODS_ADJUST_ITEM_ID",
                        column: x => x.ITEM_ID,
                        principalTable: "INV_ITEM_MST",
                        principalColumn: "ITEM_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PREP_BY_GOOD_ADJ",
                        column: x => x.PREP_BY,
                        principalTable: "PIS_EMPLOYEE_MASTER",
                        principalColumn: "EMP_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GOODS_ADJUST_SPEC_ID",
                        column: x => x.SPEC_ID,
                        principalTable: "INV_ITEM_SPEC",
                        principalColumn: "SPEC_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "INV_GOODS_REC_MAST",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    DAKHILA_ID = table.Column<string>(maxLength: 10, nullable: false),
                    PUR_MASTER_ID = table.Column<int>(nullable: true),
                    REPAIR_ID = table.Column<int>(nullable: true),
                    DAKHILA_DT = table.Column<string>(maxLength: 10, nullable: true),
                    WAREHOUSE_ID = table.Column<int>(nullable: true),
                    INV_BILL_NO = table.Column<string>(maxLength: 10, nullable: true),
                    INV_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    DETAILS_NEP = table.Column<string>(maxLength: 200, nullable: true),
                    DETAILS_ENG = table.Column<string>(maxLength: 200, nullable: true),
                    PREP_BY = table.Column<int>(nullable: true),
                    PREP_DT = table.Column<string>(maxLength: 10, nullable: true),
                    CHECK_BY = table.Column<int>(nullable: true),
                    CHECK_DT = table.Column<string>(maxLength: 10, nullable: true),
                    ACCEPT_BY = table.Column<int>(nullable: true),
                    ACCEPT_DT = table.Column<string>(maxLength: 10, nullable: true),
                    DAKHILA_DT_ENG = table.Column<DateTime>(nullable: true),
                    INV_DATE_ENG = table.Column<DateTime>(nullable: true),
                    PREP_DT_ENG = table.Column<DateTime>(nullable: true),
                    CHECK_DT_ENG = table.Column<DateTime>(nullable: true),
                    ACCEPT_DT_ENG = table.Column<DateTime>(nullable: true),
                    FISCAL_YEAR = table.Column<string>(maxLength: 10, nullable: true),
                    PAYMENT_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INV_GOODS_REC_MAST", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ACCEPT_BY_GOOD_EMP",
                        column: x => x.ACCEPT_BY,
                        principalTable: "PIS_EMPLOYEE_MASTER",
                        principalColumn: "EMP_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CHECK_BY_GOOD_EMP",
                        column: x => x.CHECK_BY,
                        principalTable: "PIS_EMPLOYEE_MASTER",
                        principalColumn: "EMP_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PREP_BY_GOOD_EMP",
                        column: x => x.PREP_BY,
                        principalTable: "PIS_EMPLOYEE_MASTER",
                        principalColumn: "EMP_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "INV_ITEM_STATUSCHECK",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    ITEM_ID = table.Column<int>(nullable: true),
                    SPEC_ID = table.Column<int>(nullable: true),
                    BRAND_ID = table.Column<int>(nullable: true),
                    INSP_ST_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    INSP_ST_DATE_ENG = table.Column<DateTime>(nullable: true),
                    INSP_ED_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    INSP_ED_DATE_ENG = table.Column<DateTime>(nullable: true),
                    STK_MST_COUNT = table.Column<int>(nullable: true),
                    COUNT_YES_NO = table.Column<string>(maxLength: 2, nullable: true),
                    STK_CUR_COUNT = table.Column<int>(nullable: true),
                    COUNT_UP_DOWN = table.Column<string>(maxLength: 2, nullable: true),
                    INSPECT_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    INSPECT_DATE_ENG = table.Column<DateTime>(nullable: true),
                    UP_DOWN_DETAIL = table.Column<string>(maxLength: 30, nullable: true),
                    REMARKS = table.Column<string>(maxLength: 100, nullable: true),
                    PREP_BY = table.Column<int>(nullable: true),
                    PREP_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    PREP_DATE_ENG = table.Column<DateTime>(nullable: true),
                    TALLY_BY = table.Column<int>(nullable: true),
                    CHECKED_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    CHECK_QTY = table.Column<int>(nullable: true),
                    RATE = table.Column<int>(nullable: true),
                    CHECKED_DATE_ENG = table.Column<DateTime>(nullable: true),
                    ACCEPTED_BY = table.Column<int>(nullable: true),
                    ACCEPTED_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    ACCEPTED_DATE_ENG = table.Column<DateTime>(nullable: true),
                    FISICAL_YEAR = table.Column<string>(maxLength: 10, nullable: true),
                    IS_ACTIVE = table.Column<string>(maxLength: 2, nullable: true),
                    UP_DOWN_NO = table.Column<int>(nullable: true),
                    CHECK_STATUS = table.Column<string>(maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INV_ITEM_STATUSCHECK", x => x.ID);
                    table.ForeignKey(
                        name: "FK_STATUSCHECK_ACCEPT_BY",
                        column: x => x.ACCEPTED_BY,
                        principalTable: "PIS_EMPLOYEE_MASTER",
                        principalColumn: "EMP_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_STATUSCHECK_BRAND_ID",
                        column: x => x.BRAND_ID,
                        principalTable: "INV_BRAND",
                        principalColumn: "BRAND_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ITEM_STATUS_CHECK",
                        column: x => x.ITEM_ID,
                        principalTable: "INV_ITEM_MST",
                        principalColumn: "ITEM_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_STATUSCHECK_PREP_BY",
                        column: x => x.PREP_BY,
                        principalTable: "PIS_EMPLOYEE_MASTER",
                        principalColumn: "EMP_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_STATUSCHECK_SPEC_ID",
                        column: x => x.SPEC_ID,
                        principalTable: "INV_ITEM_SPEC",
                        principalColumn: "SPEC_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_STATUSCHECK_CHECK_BY",
                        column: x => x.TALLY_BY,
                        principalTable: "PIS_EMPLOYEE_MASTER",
                        principalColumn: "EMP_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "INV_PUR_ORDER_MAST",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    PUR_ORDER_NO = table.Column<string>(maxLength: 50, nullable: true),
                    REPAIR_ORDER_NO = table.Column<string>(maxLength: 50, nullable: true),
                    LETTER_ORDER_NO = table.Column<string>(maxLength: 50, nullable: true),
                    CUSTOM_ORDER_NO = table.Column<string>(maxLength: 50, nullable: true),
                    PUR_TYPE = table.Column<int>(nullable: true),
                    PUR_ORDER_TYPE = table.Column<int>(nullable: true),
                    SUPP_ID = table.Column<int>(nullable: true),
                    REQ_ID = table.Column<int>(nullable: true),
                    BUDGET_YEAR = table.Column<string>(maxLength: 10, nullable: true),
                    RETURN_ITEM_DT = table.Column<string>(maxLength: 10, nullable: true),
                    RETURN_ITEM_DT_ENG = table.Column<DateTime>(nullable: true),
                    PREPARED_BY = table.Column<int>(nullable: true),
                    PREPARED_DT = table.Column<string>(maxLength: 10, nullable: true),
                    PREPARED_DT_ENG = table.Column<DateTime>(nullable: true),
                    CHECKED_BY = table.Column<int>(nullable: true),
                    CHECKED_DT = table.Column<string>(maxLength: 10, nullable: true),
                    CHECKED_DT_ENG = table.Column<DateTime>(nullable: true),
                    ACCEPTED_BY = table.Column<int>(nullable: true),
                    ACCEPTED_DT = table.Column<string>(maxLength: 10, nullable: true),
                    ACCEPTED_DT_ENG = table.Column<DateTime>(nullable: true),
                    PUR_ORDER_DT = table.Column<string>(maxLength: 10, nullable: true),
                    DAKHILA_LAST_ENTRY_DT = table.Column<string>(maxLength: 12, nullable: true),
                    PUR_ORDER_DT_ENG = table.Column<DateTime>(nullable: true),
                    ISDAKHILA = table.Column<string>(maxLength: 1, nullable: true),
                    REMARKS = table.Column<string>(maxLength: 255, nullable: true),
                    ACCOUNTID = table.Column<int>(nullable: true),
                    PURCHASE_DECISION_NO = table.Column<string>(maxLength: 50, nullable: true),
                    PURCHASE_DECISION_DATE = table.Column<string>(maxLength: 12, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INV_PUR_ORDER_MAST", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ACCEPTED_BY_USR",
                        column: x => x.ACCEPTED_BY,
                        principalTable: "PIS_EMPLOYEE_MASTER",
                        principalColumn: "EMP_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CHECKED_BY_USR",
                        column: x => x.CHECKED_BY,
                        principalTable: "PIS_EMPLOYEE_MASTER",
                        principalColumn: "EMP_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PREPARED_BY_USR",
                        column: x => x.PREPARED_BY,
                        principalTable: "PIS_EMPLOYEE_MASTER",
                        principalColumn: "EMP_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SUPP_ID_SPPLIER",
                        column: x => x.SUPP_ID,
                        principalTable: "INV_SUPPLIER",
                        principalColumn: "SUP_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "INV_REQUISITION_MAST",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    REQ_ID = table.Column<string>(maxLength: 10, nullable: true),
                    REQ_DATE_NEP = table.Column<string>(maxLength: 10, nullable: true),
                    REQ_BY = table.Column<int>(nullable: true),
                    TYPE_ID = table.Column<int>(nullable: true),
                    ITEM_ID = table.Column<int>(nullable: true),
                    MAINTAIN_ITEM_ID = table.Column<int>(nullable: true),
                    PROJ_ID = table.Column<int>(nullable: true),
                    HANDOVER_ID = table.Column<int>(nullable: true),
                    HANDOVER_ROOM_ID = table.Column<int>(nullable: true),
                    FISCAL_YEAR = table.Column<string>(maxLength: 10, nullable: true),
                    REMARKS = table.Column<string>(maxLength: 100, nullable: true),
                    PREP_BY = table.Column<int>(nullable: true),
                    PREP_DT = table.Column<string>(maxLength: 10, nullable: true),
                    CHECK_BY = table.Column<int>(nullable: true),
                    CHECK_DT = table.Column<string>(maxLength: 10, nullable: true),
                    ACCEPT_BY = table.Column<int>(nullable: true),
                    ACCEPT_DT = table.Column<string>(maxLength: 10, nullable: true),
                    ORGSTAFFNAME = table.Column<string>(maxLength: 60, nullable: true),
                    ORGSTAFFPOST = table.Column<string>(maxLength: 100, nullable: true),
                    REQ_TYPE = table.Column<int>(nullable: true),
                    USERID = table.Column<int>(nullable: true),
                    VEHICLE_ID = table.Column<int>(nullable: true),
                    REASION = table.Column<string>(nullable: true),
                    REQ_DATE_ENG = table.Column<DateTime>(nullable: true),
                    PREP_DT_ENG = table.Column<DateTime>(nullable: true),
                    CHECK_DT_ENG = table.Column<DateTime>(nullable: true),
                    ACCEPT_DT_ENG = table.Column<DateTime>(nullable: true),
                    PURCHASE_GIVE = table.Column<string>(maxLength: 1, nullable: true),
                    STOCK_GIVE = table.Column<string>(maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INV_REQUISITION_MAST", x => x.ID);
                    table.ForeignKey(
                        name: "FK_REQ_ACCEPT_BY_EMP",
                        column: x => x.ACCEPT_BY,
                        principalTable: "PIS_EMPLOYEE_MASTER",
                        principalColumn: "EMP_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_REQ_CHECK_BY_EMP",
                        column: x => x.CHECK_BY,
                        principalTable: "PIS_EMPLOYEE_MASTER",
                        principalColumn: "EMP_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_REQ_ITEM_ID",
                        column: x => x.ITEM_ID,
                        principalTable: "INV_ITEM_MST",
                        principalColumn: "ITEM_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_REQ_PREP_BY_EMP",
                        column: x => x.PREP_BY,
                        principalTable: "PIS_EMPLOYEE_MASTER",
                        principalColumn: "EMP_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_REQ_PROJECT_ID",
                        column: x => x.PROJ_ID,
                        principalTable: "INV_PROJECT",
                        principalColumn: "PROJECT_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_REQ_REQ_BY",
                        column: x => x.REQ_BY,
                        principalTable: "PIS_EMPLOYEE_MASTER",
                        principalColumn: "EMP_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "INV_STATUS_DETAIL",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    CODE = table.Column<string>(maxLength: 50, nullable: true),
                    STATUSDATEAD = table.Column<DateTime>(nullable: true),
                    STATUSDATEVS = table.Column<string>(maxLength: 10, nullable: true),
                    FISCAL_YEAR = table.Column<string>(maxLength: 10, nullable: true),
                    TOTALQTY = table.Column<int>(nullable: true),
                    ITEM_ID = table.Column<int>(nullable: true),
                    BRAND_ID = table.Column<int>(nullable: true),
                    SPEC_ID = table.Column<int>(nullable: true),
                    ITEM_STATUS_ID = table.Column<int>(nullable: true),
                    REMARKS = table.Column<string>(maxLength: 255, nullable: true),
                    PREBY = table.Column<int>(nullable: true),
                    PREVSDATE = table.Column<string>(maxLength: 10, nullable: true),
                    CHECKEDBY = table.Column<int>(nullable: true),
                    CHECKVSDATE = table.Column<string>(maxLength: 10, nullable: true),
                    ACCEPTBY = table.Column<int>(nullable: true),
                    MAIN_ID = table.Column<int>(nullable: true),
                    ACCEPTVSDATE = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INV_STATUS_DETAIL", x => x.ID);
                    table.ForeignKey(
                        name: "FK_INV_STADEL_ACCEPTBY",
                        column: x => x.ACCEPTBY,
                        principalTable: "PIS_EMPLOYEE_MASTER",
                        principalColumn: "EMP_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_STADEL_CHECKEDBY",
                        column: x => x.CHECKEDBY,
                        principalTable: "PIS_EMPLOYEE_MASTER",
                        principalColumn: "EMP_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_STADEL_PREBY",
                        column: x => x.PREBY,
                        principalTable: "PIS_EMPLOYEE_MASTER",
                        principalColumn: "EMP_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PIS_BANK_PAYROLL",
                columns: table => new
                {
                    SN = table.Column<int>(nullable: false),
                    EMP_ID = table.Column<int>(nullable: true),
                    BANK_ID = table.Column<int>(nullable: true),
                    BANK_FOLIO = table.Column<string>(maxLength: 25, nullable: true),
                    ACCOUNT_NO = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PIS_BANK_PAYROLL_pkey", x => x.SN);
                    table.ForeignKey(
                        name: "FK_BNK_PYRL_BANK_ID",
                        column: x => x.BANK_ID,
                        principalTable: "BANKMASTER",
                        principalColumn: "BANKID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BNK_PYRL_EMP_ID",
                        column: x => x.EMP_ID,
                        principalTable: "PIS_EMPLOYEE_MASTER",
                        principalColumn: "EMP_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PIS_EMP_ADV_DED_DTL",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    EMP_ID = table.Column<int>(nullable: true),
                    ACC_ID = table.Column<int>(nullable: true),
                    AMOUNT_CUR = table.Column<float>(nullable: true),
                    AMOUNT_PREV = table.Column<float>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PIS_EMP_ADV_DED_DTL", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ADV_DED_EMP_ID",
                        column: x => x.EMP_ID,
                        principalTable: "PIS_EMPLOYEE_MASTER",
                        principalColumn: "EMP_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PIS_EMP_LOANS",
                columns: table => new
                {
                    LOAN_ID = table.Column<int>(nullable: false),
                    NAME_NP = table.Column<string>(maxLength: 70, nullable: true),
                    NAME_EN = table.Column<string>(maxLength: 70, nullable: true),
                    EMP_ID = table.Column<int>(nullable: true),
                    ACC_ID = table.Column<int>(nullable: true),
                    LOAN_AMT = table.Column<float>(nullable: true),
                    INSTALLMENT_AMT = table.Column<float>(nullable: true),
                    PAID_AMOUNT = table.Column<float>(nullable: true),
                    CLEARED = table.Column<string>(maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PIS_EMP_LOANS_pkey", x => x.LOAN_ID);
                    table.ForeignKey(
                        name: "FK_EMP_LOANS_EMP_ID",
                        column: x => x.EMP_ID,
                        principalTable: "PIS_EMPLOYEE_MASTER",
                        principalColumn: "EMP_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PIS_EMP_LONG_LEAVES",
                columns: table => new
                {
                    SN = table.Column<int>(nullable: false),
                    EMP_ID = table.Column<int>(nullable: true),
                    LOCAL_POST_ID = table.Column<int>(nullable: true),
                    LEAVE_NAME = table.Column<string>(maxLength: 70, nullable: true),
                    WORKING_OFFICE = table.Column<string>(maxLength: 70, nullable: true),
                    FROM_DATE_VS = table.Column<string>(maxLength: 10, nullable: true),
                    TO_DATE_VS = table.Column<string>(maxLength: 10, nullable: true),
                    REMARKS = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PIS_EMP_LONG_LEAVES_pkey", x => x.SN);
                    table.ForeignKey(
                        name: "FK_LEAVES_EMP_ID",
                        column: x => x.EMP_ID,
                        principalTable: "PIS_EMPLOYEE_MASTER",
                        principalColumn: "EMP_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LEAVES_LOC_POST_ID",
                        column: x => x.LOCAL_POST_ID,
                        principalTable: "PIS_LOCAL_POST_MASTER",
                        principalColumn: "LOCAL_POST_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PIS_EMP_MED_EXPENSE",
                columns: table => new
                {
                    SN = table.Column<int>(nullable: false),
                    EMP_ID = table.Column<int>(nullable: true),
                    LOCAL_POST_ID = table.Column<int>(nullable: true),
                    WORKING_OFFICE = table.Column<string>(maxLength: 70, nullable: true),
                    ISSUED_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    REGULAR_AMT = table.Column<float>(nullable: true),
                    SPECIAL_AMT = table.Column<float>(nullable: true),
                    REMARKS = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PIS_EMP_MED_EXPENSE_pkey", x => x.SN);
                    table.ForeignKey(
                        name: "FK_MED_EMP_ID",
                        column: x => x.EMP_ID,
                        principalTable: "PIS_EMPLOYEE_MASTER",
                        principalColumn: "EMP_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MED_LOC_POST_ID",
                        column: x => x.LOCAL_POST_ID,
                        principalTable: "PIS_LOCAL_POST_MASTER",
                        principalColumn: "LOCAL_POST_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PIS_EMP_PUNISHMNTS",
                columns: table => new
                {
                    SN = table.Column<int>(nullable: false),
                    EMP_ID = table.Column<int>(nullable: true),
                    LOCAL_POST_ID = table.Column<int>(nullable: true),
                    WORKING_OFFICE = table.Column<string>(maxLength: 70, nullable: true),
                    PUNISH_TYPE = table.Column<string>(maxLength: 90, nullable: true),
                    PUNISH_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    REMARKS = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PIS_EMP_PUNISHMNTS_pkey", x => x.SN);
                    table.ForeignKey(
                        name: "FK_PUNISH_EMP_ID",
                        column: x => x.EMP_ID,
                        principalTable: "PIS_EMPLOYEE_MASTER",
                        principalColumn: "EMP_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PUNISH_LOC_POST_ID",
                        column: x => x.LOCAL_POST_ID,
                        principalTable: "PIS_LOCAL_POST_MASTER",
                        principalColumn: "LOCAL_POST_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PIS_EMP_SRVC_DTLS",
                columns: table => new
                {
                    SN = table.Column<int>(nullable: false),
                    EMP_ID = table.Column<int>(nullable: true),
                    LOCAL_POST_ID = table.Column<int>(nullable: true),
                    OFFICE_DETAIL = table.Column<string>(maxLength: 70, nullable: true),
                    GEO_REGION = table.Column<int>(nullable: true),
                    APPOINTMENT_TYPE = table.Column<int>(nullable: true),
                    DATE_FROM = table.Column<string>(maxLength: 10, nullable: true),
                    DATE_TO = table.Column<string>(maxLength: 10, nullable: true),
                    REMARKS = table.Column<string>(maxLength: 90, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PIS_EMP_SRVC_DTLS_pkey", x => x.SN);
                    table.ForeignKey(
                        name: "FK_SRVC_EMP_ID",
                        column: x => x.EMP_ID,
                        principalTable: "PIS_EMPLOYEE_MASTER",
                        principalColumn: "EMP_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SRVC_LOC_POST_ID",
                        column: x => x.LOCAL_POST_ID,
                        principalTable: "PIS_LOCAL_POST_MASTER",
                        principalColumn: "LOCAL_POST_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PIS_EMP_SUSPENDS",
                columns: table => new
                {
                    SN = table.Column<int>(nullable: false),
                    EMP_ID = table.Column<int>(nullable: true),
                    LOCAL_POST_ID = table.Column<int>(nullable: true),
                    NAME_NP = table.Column<string>(maxLength: 100, nullable: true),
                    WORKING_OFFICE = table.Column<string>(maxLength: 70, nullable: true),
                    FROM_DATE_VS = table.Column<string>(maxLength: 10, nullable: true),
                    TO_DATE_VS = table.Column<string>(maxLength: 10, nullable: true),
                    REMARKS = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PIS_EMP_SUSPENDS_pkey", x => x.SN);
                    table.ForeignKey(
                        name: "FK_SUSPND_EMP_ID",
                        column: x => x.EMP_ID,
                        principalTable: "PIS_EMPLOYEE_MASTER",
                        principalColumn: "EMP_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SUSPND_LOC_POST_ID",
                        column: x => x.LOCAL_POST_ID,
                        principalTable: "PIS_LOCAL_POST_MASTER",
                        principalColumn: "LOCAL_POST_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PIS_EMP_TRNSFR_REC",
                columns: table => new
                {
                    SN = table.Column<int>(nullable: false),
                    EMP_ID = table.Column<int>(nullable: true),
                    LOCAL_POST_ID = table.Column<int>(nullable: true),
                    REF_NO = table.Column<string>(maxLength: 50, nullable: true),
                    TRNSFR_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    AMT_TAKEN = table.Column<float>(nullable: true),
                    TRNSFRD_OFFICE = table.Column<string>(maxLength: 70, nullable: true),
                    MOVED_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    REMARKS = table.Column<string>(maxLength: 100, nullable: true),
                    USER_ID = table.Column<int>(nullable: true),
                    USER_IDE = table.Column<int>(nullable: true),
                    DATA_ENTRY_VS_DATE = table.Column<string>(maxLength: 10, nullable: true),
                    DATA_ENTRY_AD_DATE = table.Column<DateTime>(nullable: true),
                    DATA_EDIT_AD_DATE = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PIS_EMP_TRNSFR_REC_pkey", x => x.SN);
                    table.ForeignKey(
                        name: "FK_TRNSFR_EMP_ID",
                        column: x => x.EMP_ID,
                        principalTable: "PIS_EMPLOYEE_MASTER",
                        principalColumn: "EMP_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TRNSFR_LOC_POST_ID",
                        column: x => x.LOCAL_POST_ID,
                        principalTable: "PIS_LOCAL_POST_MASTER",
                        principalColumn: "LOCAL_POST_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PIS_INTERNAL_TRANSFER",
                columns: table => new
                {
                    SN = table.Column<int>(nullable: false),
                    EMP_ID = table.Column<int>(nullable: true),
                    OFFICE_ID = table.Column<int>(nullable: true),
                    DARBANDI_ID = table.Column<int>(nullable: true),
                    DATE_FROM = table.Column<string>(maxLength: 10, nullable: true),
                    DATE_TO = table.Column<string>(maxLength: 10, nullable: true),
                    APPOINTMNT_TYPE = table.Column<int>(nullable: true),
                    DATE_OF_DECISION = table.Column<string>(maxLength: 10, nullable: true),
                    DECISION_REFERENCE = table.Column<string>(maxLength: 50, nullable: true),
                    REMARKS = table.Column<string>(maxLength: 100, nullable: true),
                    TO_OFFICE_ID = table.Column<int>(nullable: true),
                    TO_LOCAL_POST_ID = table.Column<int>(nullable: true),
                    TO_APPOINTMNT_TYPE = table.Column<int>(nullable: true),
                    REPLACED_EMP_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PIS_INTERNAL_TRANSFER_pkey", x => x.SN);
                    table.ForeignKey(
                        name: "FK_INT_APNTMT_TYPE",
                        column: x => x.APPOINTMNT_TYPE,
                        principalTable: "PIS_APPOINTMENT_TYPE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INT_TRNSFR_DARBANDI_ID",
                        column: x => x.DARBANDI_ID,
                        principalTable: "PIS_DARBANDI",
                        principalColumn: "DARBANDI_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INT_TRNSFR_EMP_ID",
                        column: x => x.EMP_ID,
                        principalTable: "PIS_EMPLOYEE_MASTER",
                        principalColumn: "EMP_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INT_TRNSFR_OFFICE_ID",
                        column: x => x.OFFICE_ID,
                        principalTable: "ORGANIZATION_TREE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INT_TO_APNTMT_TYPE",
                        column: x => x.TO_APPOINTMNT_TYPE,
                        principalTable: "PIS_APPOINTMENT_TYPE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INT_LOC_POST_ID",
                        column: x => x.TO_LOCAL_POST_ID,
                        principalTable: "PIS_LOCAL_POST_MASTER",
                        principalColumn: "LOCAL_POST_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INT_TRNSFR_TO_OFFICE_ID",
                        column: x => x.TO_OFFICE_ID,
                        principalTable: "ORGANIZATION_TREE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PIS_PYROLL_OTHR_DTLS",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    MONTH = table.Column<short>(nullable: true),
                    EMPLOYEE_ID = table.Column<int>(nullable: true),
                    PAYROLL_ID = table.Column<int>(nullable: true),
                    AMOUNT = table.Column<float>(nullable: true),
                    ADD_SUB = table.Column<string>(maxLength: 1, nullable: true),
                    DESCRIPTION = table.Column<string>(maxLength: 100, nullable: true),
                    ACC_ID = table.Column<int>(nullable: true),
                    SOURCE_TYPE = table.Column<string>(maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PIS_PYROLL_OTHR_DTLS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PYROL_OTHR_DTLS_EMPID",
                        column: x => x.EMPLOYEE_ID,
                        principalTable: "PIS_EMPLOYEE_MASTER",
                        principalColumn: "EMP_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PYROLL_OTHR_DTLS_ID",
                        column: x => x.PAYROLL_ID,
                        principalTable: "PIS_PAYROLLS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WARD_MASTER",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    NEP_NAME = table.Column<string>(maxLength: 100, nullable: true),
                    ENG_NAME = table.Column<string>(maxLength: 50, nullable: true),
                    ADDRESS = table.Column<string>(maxLength: 50, nullable: true),
                    PRAMUKH_ID = table.Column<int>(nullable: true),
                    UPPRAMUKH_ID = table.Column<int>(nullable: true),
                    NUMBER_OF_MEMBERS = table.Column<int>(nullable: true),
                    WARD_SECRETARY_ID = table.Column<int>(nullable: true),
                    MOBILE_NO = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WARD_MASTER", x => x.ID);
                    table.ForeignKey(
                        name: "FK_WARD_PRAMUKH_ID",
                        column: x => x.PRAMUKH_ID,
                        principalTable: "ACC_PADADHIKARI_MSTR",
                        principalColumn: "PADADIKARI_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WARD_UPAPRAMUKH_ID",
                        column: x => x.UPPRAMUKH_ID,
                        principalTable: "ACC_PADADHIKARI_MSTR",
                        principalColumn: "PADADIKARI_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WARD_SECRETARY_ID",
                        column: x => x.WARD_SECRETARY_ID,
                        principalTable: "PIS_EMPLOYEE_MASTER",
                        principalColumn: "EMP_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PIS_VISITED_COUNTRIES",
                columns: table => new
                {
                    SN = table.Column<int>(nullable: false),
                    VISIT_ID = table.Column<int>(nullable: true),
                    EMP_ID = table.Column<int>(nullable: true),
                    COUNTRY_ID = table.Column<int>(nullable: true),
                    APPLY_TO = table.Column<string>(maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PIS_VISITED_COUNTRIES_pkey", x => x.SN);
                    table.ForeignKey(
                        name: "FK_VISIT_ID",
                        column: x => x.VISIT_ID,
                        principalTable: "PIS_FOREIGN_VISITS",
                        principalColumn: "SN",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TBL_MALPOT_OTHER_CHARGES",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    RATEID = table.Column<int>(nullable: true),
                    ACCODE = table.Column<int>(nullable: true),
                    ACC_ID = table.Column<int>(nullable: true),
                    PERCENT_OF_TAX = table.Column<float>(nullable: true),
                    FLAT_CHARGE_RATE = table.Column<int>(nullable: true),
                    FISCAL_YEAR = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_MALPOT_OTHER_CHARGES", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MAL_OTH_CH_ACC_ID",
                        column: x => x.ACC_ID,
                        principalTable: "ACC_ACC_MASTER",
                        principalColumn: "ACC_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "SYS_C004396",
                        column: x => x.RATEID,
                        principalTable: "TBLMALPOTRATES",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TBLFYWISEMPOTASSRATE",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    GROUPID = table.Column<int>(nullable: true),
                    SUBGROUPID = table.Column<int>(nullable: true),
                    RATEID = table.Column<int>(nullable: true),
                    NEPNAME = table.Column<string>(maxLength: 100, nullable: true),
                    FISCALYEAR = table.Column<string>(maxLength: 9, nullable: true),
                    RATEPERUNIT = table.Column<int>(nullable: true),
                    AREA_UPTO = table.Column<int>(nullable: true),
                    FOR_EACH_AREA = table.Column<int>(nullable: true),
                    EACH_AREA_RATE = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBLFYWISEMPOTASSRATE", x => x.ID);
                    table.ForeignKey(
                        name: "SYS_C004394",
                        column: x => x.GROUPID,
                        principalTable: "TBLMALPOTGROUP",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "SYS_C004395",
                        column: x => x.RATEID,
                        principalTable: "TBLMALPOTRATES",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "SYS_C004398",
                        column: x => x.SUBGROUPID,
                        principalTable: "TBLMALPOTSUBGROUP",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TBL_BGT_MGMT_SRC_RELEASE",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    BGT_MGMT_EXP_RELEASE_ID = table.Column<int>(nullable: true),
                    SOURCE_ID = table.Column<int>(nullable: true),
                    AMT = table.Column<float>(nullable: true),
                    CC_ID = table.Column<int>(nullable: true),
                    CC_ACTIVE = table.Column<string>(maxLength: 2, nullable: true),
                    PAYMENT_TYPE_ID = table.Column<int>(nullable: true),
                    PAYMENT_PROCESS_ID = table.Column<int>(nullable: true),
                    REMARKS = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_BGT_MGMT_SRC_RELEASE", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BGT_MGMT_REL_EXP",
                        column: x => x.BGT_MGMT_EXP_RELEASE_ID,
                        principalTable: "TBL_BGT_MGMT_EXP_RELEASE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CC_RELEASE",
                        column: x => x.CC_ID,
                        principalTable: "CONTACTS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PIS_DELETD_FRM_FULFILD_DARB",
                columns: table => new
                {
                    SN = table.Column<int>(nullable: false),
                    EMP_ID = table.Column<int>(nullable: true),
                    FRM_SN_IN_FD = table.Column<int>(nullable: true),
                    FRM_OFFICE_ID = table.Column<int>(nullable: true),
                    FRM_DARBANDI_ID = table.Column<int>(nullable: true),
                    FRM_DATE_FULFILLED = table.Column<string>(maxLength: 10, nullable: true),
                    FRM_APPOINTMNT_TYPE = table.Column<int>(nullable: true),
                    TO_SN_IN_FD = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PIS_DELETD_FRM_FULFILD_DARB_pkey", x => x.SN);
                    table.ForeignKey(
                        name: "FK_DEL_FD_DARBANDI_ID",
                        column: x => x.FRM_DARBANDI_ID,
                        principalTable: "PIS_DARBANDI",
                        principalColumn: "DARBANDI_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DEL_FD_OFFICE_ID",
                        column: x => x.FRM_OFFICE_ID,
                        principalTable: "ORGANIZATION_TREE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FROM_SN_IN_FD",
                        column: x => x.FRM_SN_IN_FD,
                        principalTable: "PIS_FULFILLED_DARBANDI",
                        principalColumn: "SN",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TO_SN_IN_FD",
                        column: x => x.TO_SN_IN_FD,
                        principalTable: "PIS_FULFILLED_DARBANDI",
                        principalColumn: "SN",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PIS_REPLACED_IN_DARBANDI",
                columns: table => new
                {
                    SN = table.Column<int>(nullable: false),
                    EMP_ID = table.Column<int>(nullable: true),
                    ENTRY_SN_IN_FD = table.Column<int>(nullable: true),
                    OFFICE_ID = table.Column<int>(nullable: true),
                    DARBANDI_ID = table.Column<int>(nullable: true),
                    DATE_FULFILLED = table.Column<string>(maxLength: 10, nullable: true),
                    APPOINTMNT_TYPE = table.Column<int>(nullable: true),
                    REPLACED_BY = table.Column<int>(nullable: true),
                    DATE_REPLACED = table.Column<string>(maxLength: 10, nullable: true),
                    DATE_OF_DECISION = table.Column<string>(maxLength: 10, nullable: true),
                    DECISION_REFERENCE = table.Column<string>(maxLength: 50, nullable: true),
                    IS_PLACED_IN_DARBANDI = table.Column<int>(nullable: true),
                    REMARKS = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PIS_REPLACED_IN_DARBANDI_pkey", x => x.SN);
                    table.ForeignKey(
                        name: "FK_REPL_FD_DARBANDI_ID",
                        column: x => x.DARBANDI_ID,
                        principalTable: "PIS_DARBANDI",
                        principalColumn: "DARBANDI_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ENTRY_SN_IN_FD",
                        column: x => x.ENTRY_SN_IN_FD,
                        principalTable: "PIS_FULFILLED_DARBANDI",
                        principalColumn: "SN",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_REPL_FD_OFFICE_ID",
                        column: x => x.OFFICE_ID,
                        principalTable: "ORGANIZATION_TREE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "INV_GOODS_REC_DETL",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    GOODS_MASTER_ID = table.Column<int>(nullable: true),
                    ITEM_ID = table.Column<int>(nullable: true),
                    UNIT_ID = table.Column<int>(nullable: true),
                    BRAND_ID = table.Column<int>(nullable: true),
                    SPEC_ID = table.Column<int>(nullable: true),
                    PUR_QTY = table.Column<float>(nullable: true),
                    RECV_QTY = table.Column<float>(nullable: true),
                    RATE = table.Column<float>(nullable: true),
                    WHETHER_TAX = table.Column<string>(maxLength: 1, nullable: true),
                    TAX_PER_UNIT_AMT = table.Column<float>(nullable: true),
                    DISC_AMT = table.Column<float>(nullable: true),
                    OTHER_EXPENCES_AMT = table.Column<float>(nullable: true),
                    NET_AMT = table.Column<float>(nullable: true),
                    REMARKS = table.Column<string>(maxLength: 100, nullable: true),
                    ISNUMBERED = table.Column<string>(maxLength: 1, nullable: true, defaultValueSql: "'N'::character varying"),
                    DAKHILA_DT_ENG = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INV_GOODS_REC_DETL", x => x.ID);
                    table.ForeignKey(
                        name: "FK_GOODS_BRAND_ID",
                        column: x => x.BRAND_ID,
                        principalTable: "INV_BRAND",
                        principalColumn: "BRAND_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GOODS_DTL_MASTERID",
                        column: x => x.GOODS_MASTER_ID,
                        principalTable: "INV_GOODS_REC_MAST",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GOODS_ITEM_ID",
                        column: x => x.ITEM_ID,
                        principalTable: "INV_ITEM_MST",
                        principalColumn: "ITEM_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GOODS_SPEC_ID",
                        column: x => x.SPEC_ID,
                        principalTable: "INV_ITEM_SPEC",
                        principalColumn: "SPEC_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GOODS_UNIT_ID",
                        column: x => x.UNIT_ID,
                        principalTable: "INV_UNIT",
                        principalColumn: "UNIT_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "INV_ITEM_DETAILS",
                columns: table => new
                {
                    ITEM_DTL_ID = table.Column<int>(nullable: false),
                    ITEM_ID = table.Column<int>(nullable: false),
                    BRAND_ID = table.Column<int>(nullable: false),
                    SPEC_ID = table.Column<int>(nullable: false),
                    QTY = table.Column<float>(nullable: true),
                    ITEM_RATE = table.Column<float>(nullable: true),
                    ITEM_STATUS = table.Column<string>(maxLength: 10, nullable: true),
                    BUDGET_YEAR = table.Column<string>(maxLength: 10, nullable: true),
                    DAKHILA_ID = table.Column<int>(nullable: true),
                    ENTRY_DT = table.Column<string>(maxLength: 10, nullable: true),
                    ISSUE_ID = table.Column<int>(nullable: true),
                    ISSUE_DT = table.Column<string>(maxLength: 10, nullable: true),
                    GD_ADJ_ID = table.Column<int>(nullable: true),
                    ADJ_TYPE = table.Column<int>(nullable: true),
                    LILAM_ID = table.Column<int>(nullable: true),
                    LILAM_DT = table.Column<string>(maxLength: 10, nullable: true),
                    STOK_RT_ID = table.Column<int>(nullable: true),
                    STOK_RT_DT = table.Column<string>(maxLength: 10, nullable: true),
                    ENGINE_NO = table.Column<string>(maxLength: 20, nullable: true),
                    CHASIS_NO = table.Column<string>(maxLength: 20, nullable: true),
                    MODEL_NO = table.Column<string>(maxLength: 20, nullable: true),
                    REG_NO = table.Column<string>(maxLength: 20, nullable: true),
                    WEIGHT_VEH = table.Column<int>(nullable: true),
                    PREP_BY = table.Column<int>(nullable: true),
                    PREP_DT = table.Column<string>(maxLength: 10, nullable: true),
                    CHECK_BY = table.Column<int>(nullable: true),
                    CHECK_DT = table.Column<string>(maxLength: 10, nullable: true),
                    ACCEPT_BY = table.Column<int>(nullable: true),
                    ACCEPT_DT = table.Column<string>(maxLength: 10, nullable: true),
                    UNIT = table.Column<int>(nullable: true),
                    REL_UNIT = table.Column<string>(maxLength: 20, nullable: true),
                    REL_QTY = table.Column<float>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("INV_ITEM_DETAILS_pkey", x => x.ITEM_DTL_ID);
                    table.ForeignKey(
                        name: "FK_ITEM_DETL_ACCEPT_BY",
                        column: x => x.ACCEPT_BY,
                        principalTable: "PIS_EMPLOYEE_MASTER",
                        principalColumn: "EMP_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ITEM_DETL_BRAND_ID",
                        column: x => x.BRAND_ID,
                        principalTable: "INV_BRAND",
                        principalColumn: "BRAND_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ITEM_DETL_CHECK_BY",
                        column: x => x.CHECK_BY,
                        principalTable: "PIS_EMPLOYEE_MASTER",
                        principalColumn: "EMP_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ITEM_DETL_DAKHILA_ID",
                        column: x => x.DAKHILA_ID,
                        principalTable: "INV_GOODS_REC_MAST",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ITEM_DETL_GD_ADJ_ID",
                        column: x => x.GD_ADJ_ID,
                        principalTable: "INV_GOODS_ADJUST",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ITEM_DETL_ITEM_ID",
                        column: x => x.ITEM_ID,
                        principalTable: "INV_ITEM_MST",
                        principalColumn: "ITEM_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ITEM_DETL_PREP_BY",
                        column: x => x.PREP_BY,
                        principalTable: "PIS_EMPLOYEE_MASTER",
                        principalColumn: "EMP_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ITEM_DETL_SPEC_ID",
                        column: x => x.SPEC_ID,
                        principalTable: "INV_ITEM_SPEC",
                        principalColumn: "SPEC_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "INV_PUR_ORDER_DETL",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    PUR_MST_ID = table.Column<int>(nullable: true),
                    ITEM_ID = table.Column<int>(nullable: true),
                    UNIT_ID = table.Column<int>(nullable: true),
                    SPEC_ID = table.Column<int>(nullable: true),
                    BRAND_ID = table.Column<int>(nullable: true),
                    ITEM_TYPE = table.Column<int>(nullable: true),
                    QTY = table.Column<float>(nullable: true),
                    ITEM_RATE = table.Column<float>(nullable: true),
                    TOTAL_AMT = table.Column<float>(nullable: true),
                    TAX_AMT = table.Column<float>(nullable: true),
                    REMARKS = table.Column<string>(maxLength: 100, nullable: true),
                    ISDAKHILA = table.Column<string>(maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INV_PUR_ORDER_DETL", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PUR_ORDER_BRAND_ID",
                        column: x => x.BRAND_ID,
                        principalTable: "INV_BRAND",
                        principalColumn: "BRAND_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PUR_ORDER_ITEM_ID",
                        column: x => x.ITEM_ID,
                        principalTable: "INV_ITEM_MST",
                        principalColumn: "ITEM_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PUR_ORDER_ITEM_TYPE",
                        column: x => x.ITEM_TYPE,
                        principalTable: "INV_ITEM_CATEGORY",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_PUR_MAST_ID",
                        column: x => x.PUR_MST_ID,
                        principalTable: "INV_PUR_ORDER_MAST",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PUR_ORDER_SPEC_ID",
                        column: x => x.SPEC_ID,
                        principalTable: "INV_ITEM_SPEC",
                        principalColumn: "SPEC_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PUR_ORDER_UNIT_ID",
                        column: x => x.UNIT_ID,
                        principalTable: "INV_UNIT",
                        principalColumn: "UNIT_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "INV_ISSUE_MASTER",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    ISSUE_NO = table.Column<string>(maxLength: 10, nullable: false),
                    REQUEST_ID = table.Column<int>(nullable: true),
                    ISSUE_BY = table.Column<int>(nullable: true),
                    ISSUE_RECEIVE = table.Column<int>(nullable: true),
                    RECEIVE_EMP_ID = table.Column<int>(nullable: true),
                    ISSUE_DT = table.Column<string>(maxLength: 10, nullable: true),
                    REMARKS = table.Column<string>(maxLength: 100, nullable: true),
                    ISSUE_BY_CAT = table.Column<string>(maxLength: 30, nullable: true),
                    HO_NAME = table.Column<string>(maxLength: 30, nullable: true),
                    HO_POST = table.Column<string>(maxLength: 30, nullable: true),
                    PREP_BY = table.Column<int>(nullable: true),
                    PREP_DT = table.Column<string>(maxLength: 10, nullable: true),
                    CHECK_BY = table.Column<int>(nullable: true),
                    CHECK_DT = table.Column<string>(maxLength: 10, nullable: true),
                    ACCEPT_BY = table.Column<int>(nullable: true),
                    ACCEPT_DT = table.Column<string>(maxLength: 10, nullable: true),
                    BUDGET_YEAR = table.Column<string>(maxLength: 10, nullable: true),
                    TYPE = table.Column<int>(nullable: true),
                    TRANSFER_DECISION_NO = table.Column<string>(maxLength: 50, nullable: true),
                    TRANSFER_DECISION_DATE = table.Column<string>(maxLength: 12, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INV_ISSUE_MASTER", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ISS_MAST_ACCEPT_BY",
                        column: x => x.ACCEPT_BY,
                        principalTable: "PIS_EMPLOYEE_MASTER",
                        principalColumn: "EMP_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ISS_MAST_CHECK_BY",
                        column: x => x.CHECK_BY,
                        principalTable: "PIS_EMPLOYEE_MASTER",
                        principalColumn: "EMP_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ISS_MAST_ISSUE_BY",
                        column: x => x.ISSUE_BY,
                        principalTable: "PIS_EMPLOYEE_MASTER",
                        principalColumn: "EMP_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ISS_MAST_PREP_BY",
                        column: x => x.PREP_BY,
                        principalTable: "PIS_EMPLOYEE_MASTER",
                        principalColumn: "EMP_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ISS_MAST_REQUEST_ID",
                        column: x => x.REQUEST_ID,
                        principalTable: "INV_REQUISITION_MAST",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "INV_REQ_DETAIL",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    REQ_MAST_ID = table.Column<int>(nullable: true),
                    ITEM_ID = table.Column<int>(nullable: true),
                    SPEC_ID = table.Column<int>(nullable: true),
                    BRAND_ID = table.Column<int>(nullable: true),
                    QTY = table.Column<float>(nullable: true),
                    REMARKS = table.Column<string>(maxLength: 100, nullable: true),
                    IS_ACTIVE = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INV_REQ_DETAIL", x => x.ID);
                    table.ForeignKey(
                        name: "FK_IN_REQ_DETL_BRAND_ID",
                        column: x => x.BRAND_ID,
                        principalTable: "INV_BRAND",
                        principalColumn: "BRAND_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IN_REQ_DETL_ITEM_ID",
                        column: x => x.ITEM_ID,
                        principalTable: "INV_ITEM_MST",
                        principalColumn: "ITEM_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IN_REQ_DETL_MASTER_ID",
                        column: x => x.REQ_MAST_ID,
                        principalTable: "INV_REQUISITION_MAST",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IN_REQ_DETL_SPEC_ID",
                        column: x => x.SPEC_ID,
                        principalTable: "INV_ITEM_SPEC",
                        principalColumn: "SPEC_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PIS_PYROLL_LOAN_DTLS",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    LOAND_ID = table.Column<int>(nullable: true),
                    MONTH = table.Column<short>(nullable: true),
                    NAME_NP = table.Column<string>(maxLength: 100, nullable: true),
                    EMP_ID = table.Column<int>(nullable: true),
                    ACC_ID = table.Column<int>(nullable: true),
                    LOAND_AMT = table.Column<float>(nullable: true),
                    INSTALLMENT_AMT = table.Column<float>(nullable: true),
                    CLEARED = table.Column<string>(maxLength: 1, nullable: true),
                    PAYROLL_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PIS_PYROLL_LOAN_DTLS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PYROLL_LOAN_DTLS_ACCID",
                        column: x => x.ACC_ID,
                        principalTable: "ACC_ACC_MASTER",
                        principalColumn: "ACC_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PYROLL_LOAN_DTLS_EMPID",
                        column: x => x.EMP_ID,
                        principalTable: "PIS_EMPLOYEE_MASTER",
                        principalColumn: "EMP_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PYROLL_LOAN_DTLS_LID",
                        column: x => x.LOAND_ID,
                        principalTable: "PIS_EMP_LOANS",
                        principalColumn: "LOAN_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PYROLL_LOAN_DTLS_PRID",
                        column: x => x.PAYROLL_ID,
                        principalTable: "PIS_PAYROLLS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ACC_ACC_MASTER_TYPE_ID",
                table: "ACC_ACC_MASTER",
                column: "TYPE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ACC_ASULI_BIBARAN_PERSON_TYPE_ID",
                table: "ACC_ASULI_BIBARAN",
                column: "PERSON_TYPE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ACC_BANK_GRNTY_PERSON_ID",
                table: "ACC_BANK_GRNTY",
                column: "PERSON_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ACC_BANK_GRNTY_WORK_ID",
                table: "ACC_BANK_GRNTY",
                column: "WORK_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ACC_BANK_TRANS_BANK_ID",
                table: "ACC_BANK_TRANS",
                column: "BANK_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ACC_BANK_TRANS_BILL_ID",
                table: "ACC_BANK_TRANS",
                column: "BILL_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ACC_BANK_TRANS_VCHR_ID",
                table: "ACC_BANK_TRANS",
                column: "VCHR_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ACC_BGT_RVSN_BGT_ALCTN_ID",
                table: "ACC_BGT_RVSN",
                column: "BGT_ALCTN_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ACC_BGT_TRANSFER_BGT_ALCTN_ID",
                table: "ACC_BGT_TRANSFER",
                column: "BGT_ALCTN_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ACC_BGT_TRANSFER_FROM_ACC_ID",
                table: "ACC_BGT_TRANSFER",
                column: "FROM_ACC_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ACC_BGT_TRANSFER_TO_ACC_ID",
                table: "ACC_BGT_TRANSFER",
                column: "TO_ACC_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ACC_BUDJET_SOURCE_MIN_ACC_ID",
                table: "ACC_BUDJET_SOURCE",
                column: "MIN_ACC_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ACC_BUDJET_SOURCE_SOURCE_ID",
                table: "ACC_BUDJET_SOURCE",
                column: "SOURCE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ACC_CASH_TRANS_BILL_ID",
                table: "ACC_CASH_TRANS",
                column: "BILL_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ACC_CASH_TRANS_VCHR_ID",
                table: "ACC_CASH_TRANS",
                column: "VCHR_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ACC_CURRENCTY_RATE_CURRENCY_ID",
                table: "ACC_CURRENCTY_RATE",
                column: "CURRENCY_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ACC_DHRTI_BILL_DTL_ACC_ID",
                table: "ACC_DHRTI_BILL_DTL",
                column: "ACC_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ACC_DHRTI_BILL_DTL_VCHR_ID",
                table: "ACC_DHRTI_BILL_DTL",
                column: "VCHR_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ACC_DHRTI_BILL_DTL_WORK_ID",
                table: "ACC_DHRTI_BILL_DTL",
                column: "WORK_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ACC_DHRTI_BILL_MASTER_BILLTYPEID",
                table: "ACC_DHRTI_BILL_MASTER",
                column: "BILLTYPEID");

            migrationBuilder.CreateIndex(
                name: "IX_ACC_DHRTI_BILL_MASTER_SUB_MODULE_ID",
                table: "ACC_DHRTI_BILL_MASTER",
                column: "SUB_MODULE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ACC_DHRTI_BILL_MASTER_VCHR_ID",
                table: "ACC_DHRTI_BILL_MASTER",
                column: "VCHR_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ACC_DHRTI_BILL_MASTER_WORK_ID",
                table: "ACC_DHRTI_BILL_MASTER",
                column: "WORK_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ACC_EXPENSES_DETAILS_ACC_ID",
                table: "ACC_EXPENSES_DETAILS",
                column: "ACC_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ACC_EXPENSES_DETAILS_PAYMENT_SLIP_ID",
                table: "ACC_EXPENSES_DETAILS",
                column: "PAYMENT_SLIP_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ACC_EXPENSES_DETAILS_PERSON_TYPE_ID",
                table: "ACC_EXPENSES_DETAILS",
                column: "PERSON_TYPE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ACC_EXPENSES_DETAILS_TRANS_TYPE_ID",
                table: "ACC_EXPENSES_DETAILS",
                column: "TRANS_TYPE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ACC_EXPENSES_DETAILS_WORK_ID",
                table: "ACC_EXPENSES_DETAILS",
                column: "WORK_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ACC_PADADHIKARI_MSTR_POST_ID",
                table: "ACC_PADADHIKARI_MSTR",
                column: "POST_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ACC_PAYMENT_CLEARANCE_ACC_ID",
                table: "ACC_PAYMENT_CLEARANCE",
                column: "ACC_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ACC_PAYMENT_CLEARANCE_BUDGET_ACC_ID",
                table: "ACC_PAYMENT_CLEARANCE",
                column: "BUDGET_ACC_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ACC_PAYMENT_DEDUCTION_ACC_ID",
                table: "ACC_PAYMENT_DEDUCTION",
                column: "ACC_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ACC_PAYMENT_DEDUCTION_BUDGET_ACC_ID",
                table: "ACC_PAYMENT_DEDUCTION",
                column: "BUDGET_ACC_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ACC_PAYMENT_DEDUCTION_PAYMENT_ID",
                table: "ACC_PAYMENT_DEDUCTION",
                column: "PAYMENT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ACC_PAYMENT_DETAILS_ACC_ID",
                table: "ACC_PAYMENT_DETAILS",
                column: "ACC_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ACC_PAYMENT_DETAILS_BUDGET_ACC_ID",
                table: "ACC_PAYMENT_DETAILS",
                column: "BUDGET_ACC_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ACC_PAYMENT_DETAILS_PAYMENT_ID",
                table: "ACC_PAYMENT_DETAILS",
                column: "PAYMENT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ACC_PAYMENT_DETAILS_PERSON_TYPE_ID",
                table: "ACC_PAYMENT_DETAILS",
                column: "PERSON_TYPE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ACC_PAYMENT_DETAILS_TRANS_TYPE_ID",
                table: "ACC_PAYMENT_DETAILS",
                column: "TRANS_TYPE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ACC_PAYMENT_DETAILS_VCHR_ID",
                table: "ACC_PAYMENT_DETAILS",
                column: "VCHR_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ACC_PAYMENT_DETAILS_WORK_ID",
                table: "ACC_PAYMENT_DETAILS",
                column: "WORK_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ACC_PAYMENT_MASTER_PERSON_TYPE_ID",
                table: "ACC_PAYMENT_MASTER",
                column: "PERSON_TYPE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ACC_PAYMENT_MASTER_SUB_MODULE_ID",
                table: "ACC_PAYMENT_MASTER",
                column: "SUB_MODULE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ACC_PAYMENT_MASTER_TRANS_TYPE_ID",
                table: "ACC_PAYMENT_MASTER",
                column: "TRANS_TYPE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ACC_PAYMENT_MASTER_VCHR_ID",
                table: "ACC_PAYMENT_MASTER",
                column: "VCHR_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ACC_PAYMENT_MASTER_WORK_ID",
                table: "ACC_PAYMENT_MASTER",
                column: "WORK_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ACC_VCHR_DETAILS_SUB_MODULE_ID",
                table: "ACC_VCHR_DETAILS",
                column: "SUB_MODULE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ACC_VCHR_DETAILS_TRANS_TYPE_ID",
                table: "ACC_VCHR_DETAILS",
                column: "TRANS_TYPE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ACC_VCHR_DETAILS_VCHR_ID",
                table: "ACC_VCHR_DETAILS",
                column: "VCHR_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ACC_VCHR_DETAILS_VCHR_TYPE_ID",
                table: "ACC_VCHR_DETAILS",
                column: "VCHR_TYPE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ACC_VCHR_DETAILS_WORK_ID",
                table: "ACC_VCHR_DETAILS",
                column: "WORK_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ACC_VCHR_MASTER_SUB_MODULE_ID",
                table: "ACC_VCHR_MASTER",
                column: "SUB_MODULE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ACC_VCHR_MASTER_VCHR_TYPE_ID",
                table: "ACC_VCHR_MASTER",
                column: "VCHR_TYPE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ACC_WORK_FUNDS_DETAIL_PROVIDER_ID",
                table: "ACC_WORK_FUNDS_DETAIL",
                column: "PROVIDER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ACC_WORK_FUNDS_DETAIL_WORK_ID",
                table: "ACC_WORK_FUNDS_DETAIL",
                column: "WORK_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ACC_WORK_PAYMNT_TRANS_PERSON_TYPE_ID",
                table: "ACC_WORK_PAYMNT_TRANS",
                column: "PERSON_TYPE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ACC_WORK_PAYMNT_TRANS_VCHR_ID",
                table: "ACC_WORK_PAYMNT_TRANS",
                column: "VCHR_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ACC_WORK_PAYMNT_TRANS_WORK_ID",
                table: "ACC_WORK_PAYMNT_TRANS",
                column: "WORK_ID");
             

            migrationBuilder.CreateIndex(
                name: "IX_BANK_BRANCH_BANKID",
                table: "BANK_BRANCH",
                column: "BANKID");

            migrationBuilder.CreateIndex(
                name: "IX_BANKTRANSACTIONS_DHRTI_MASTER_ID",
                table: "BANKTRANSACTIONS",
                column: "DHRTI_MASTER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_BANKTRANSACTIONS_SUBMODULE_TYPE_ID",
                table: "BANKTRANSACTIONS",
                column: "SUBMODULE_TYPE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_BANKTRANSACTIONS_VCHR_ID",
                table: "BANKTRANSACTIONS",
                column: "VCHR_ID");

            migrationBuilder.CreateIndex(
                name: "IX_CASHTRANSACTION_DHRTI_MASTER_ID",
                table: "CASHTRANSACTION",
                column: "DHRTI_MASTER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_CASHTRANSACTION_SUBMODULE_TYPE_ID",
                table: "CASHTRANSACTION",
                column: "SUBMODULE_TYPE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_CASHTRANSACTION_VCHR_ID",
                table: "CASHTRANSACTION",
                column: "VCHR_ID");

            migrationBuilder.CreateIndex(
                name: "IX_FIREBRIGADESTATE_ACC_ID",
                table: "FIREBRIGADESTATE",
                column: "ACC_ID");

            migrationBuilder.CreateIndex(
                name: "IX_INCOMEBILLDETAILS_ACC_ID",
                table: "INCOMEBILLDETAILS",
                column: "ACC_ID");

            migrationBuilder.CreateIndex(
                name: "IX_INCOMEBILLDETAILS_VCHR_ID",
                table: "INCOMEBILLDETAILS",
                column: "VCHR_ID");

            migrationBuilder.CreateIndex(
                name: "IX_INCOMEBILLMASTER_BILLTYPEID",
                table: "INCOMEBILLMASTER",
                column: "BILLTYPEID");

            migrationBuilder.CreateIndex(
                name: "IX_INCOMEBILLMASTER_SUB_MODULE_ID",
                table: "INCOMEBILLMASTER",
                column: "SUB_MODULE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_INCOMEBILLMASTER_VCHR_ID",
                table: "INCOMEBILLMASTER",
                column: "VCHR_ID");

            migrationBuilder.CreateIndex(
                name: "IX_INV_GOODS_ADJUST_ACCEPT_BY",
                table: "INV_GOODS_ADJUST",
                column: "ACCEPT_BY");

            migrationBuilder.CreateIndex(
                name: "IX_INV_GOODS_ADJUST_BRAND_ID",
                table: "INV_GOODS_ADJUST",
                column: "BRAND_ID");

            migrationBuilder.CreateIndex(
                name: "IX_INV_GOODS_ADJUST_ITEM_ID",
                table: "INV_GOODS_ADJUST",
                column: "ITEM_ID");

            migrationBuilder.CreateIndex(
                name: "IX_INV_GOODS_ADJUST_PREP_BY",
                table: "INV_GOODS_ADJUST",
                column: "PREP_BY");

            migrationBuilder.CreateIndex(
                name: "IX_INV_GOODS_ADJUST_SPEC_ID",
                table: "INV_GOODS_ADJUST",
                column: "SPEC_ID");

            migrationBuilder.CreateIndex(
                name: "IX_INV_GOODS_REC_DETL_BRAND_ID",
                table: "INV_GOODS_REC_DETL",
                column: "BRAND_ID");

            migrationBuilder.CreateIndex(
                name: "IX_INV_GOODS_REC_DETL_GOODS_MASTER_ID",
                table: "INV_GOODS_REC_DETL",
                column: "GOODS_MASTER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_INV_GOODS_REC_DETL_ITEM_ID",
                table: "INV_GOODS_REC_DETL",
                column: "ITEM_ID");

            migrationBuilder.CreateIndex(
                name: "IX_INV_GOODS_REC_DETL_SPEC_ID",
                table: "INV_GOODS_REC_DETL",
                column: "SPEC_ID");

            migrationBuilder.CreateIndex(
                name: "IX_INV_GOODS_REC_DETL_UNIT_ID",
                table: "INV_GOODS_REC_DETL",
                column: "UNIT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_INV_GOODS_REC_MAST_ACCEPT_BY",
                table: "INV_GOODS_REC_MAST",
                column: "ACCEPT_BY");

            migrationBuilder.CreateIndex(
                name: "IX_INV_GOODS_REC_MAST_CHECK_BY",
                table: "INV_GOODS_REC_MAST",
                column: "CHECK_BY");

            migrationBuilder.CreateIndex(
                name: "IX_INV_GOODS_REC_MAST_PREP_BY",
                table: "INV_GOODS_REC_MAST",
                column: "PREP_BY");

            migrationBuilder.CreateIndex(
                name: "IX_INV_ISSUE_DETAIL_BRAND_ID",
                table: "INV_ISSUE_DETAIL",
                column: "BRAND_ID");

            migrationBuilder.CreateIndex(
                name: "IX_INV_ISSUE_DETAIL_ITEM_ID",
                table: "INV_ISSUE_DETAIL",
                column: "ITEM_ID");

            migrationBuilder.CreateIndex(
                name: "IX_INV_ISSUE_DETAIL_ITEM_TYPE",
                table: "INV_ISSUE_DETAIL",
                column: "ITEM_TYPE");

            migrationBuilder.CreateIndex(
                name: "IX_INV_ISSUE_DETAIL_SPEC_ID",
                table: "INV_ISSUE_DETAIL",
                column: "SPEC_ID");

            migrationBuilder.CreateIndex(
                name: "IX_INV_ISSUE_MASTER_ACCEPT_BY",
                table: "INV_ISSUE_MASTER",
                column: "ACCEPT_BY");

            migrationBuilder.CreateIndex(
                name: "IX_INV_ISSUE_MASTER_CHECK_BY",
                table: "INV_ISSUE_MASTER",
                column: "CHECK_BY");

            migrationBuilder.CreateIndex(
                name: "IX_INV_ISSUE_MASTER_ISSUE_BY",
                table: "INV_ISSUE_MASTER",
                column: "ISSUE_BY");

            migrationBuilder.CreateIndex(
                name: "IX_INV_ISSUE_MASTER_PREP_BY",
                table: "INV_ISSUE_MASTER",
                column: "PREP_BY");

            migrationBuilder.CreateIndex(
                name: "IX_INV_ISSUE_MASTER_REQUEST_ID",
                table: "INV_ISSUE_MASTER",
                column: "REQUEST_ID");

            migrationBuilder.CreateIndex(
                name: "IX_INV_ITEM_DETAILS_ACCEPT_BY",
                table: "INV_ITEM_DETAILS",
                column: "ACCEPT_BY");

            migrationBuilder.CreateIndex(
                name: "IX_INV_ITEM_DETAILS_BRAND_ID",
                table: "INV_ITEM_DETAILS",
                column: "BRAND_ID");

            migrationBuilder.CreateIndex(
                name: "IX_INV_ITEM_DETAILS_CHECK_BY",
                table: "INV_ITEM_DETAILS",
                column: "CHECK_BY");

            migrationBuilder.CreateIndex(
                name: "IX_INV_ITEM_DETAILS_DAKHILA_ID",
                table: "INV_ITEM_DETAILS",
                column: "DAKHILA_ID");

            migrationBuilder.CreateIndex(
                name: "IX_INV_ITEM_DETAILS_GD_ADJ_ID",
                table: "INV_ITEM_DETAILS",
                column: "GD_ADJ_ID");

            migrationBuilder.CreateIndex(
                name: "IX_INV_ITEM_DETAILS_ITEM_ID",
                table: "INV_ITEM_DETAILS",
                column: "ITEM_ID");

            migrationBuilder.CreateIndex(
                name: "IX_INV_ITEM_DETAILS_PREP_BY",
                table: "INV_ITEM_DETAILS",
                column: "PREP_BY");

            migrationBuilder.CreateIndex(
                name: "IX_INV_ITEM_DETAILS_SPEC_ID",
                table: "INV_ITEM_DETAILS",
                column: "SPEC_ID");

            migrationBuilder.CreateIndex(
                name: "IX_INV_ITEM_MST_UNIT_ID",
                table: "INV_ITEM_MST",
                column: "UNIT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_INV_ITEM_STATUSCHECK_ACCEPTED_BY",
                table: "INV_ITEM_STATUSCHECK",
                column: "ACCEPTED_BY");

            migrationBuilder.CreateIndex(
                name: "IX_INV_ITEM_STATUSCHECK_BRAND_ID",
                table: "INV_ITEM_STATUSCHECK",
                column: "BRAND_ID");

            migrationBuilder.CreateIndex(
                name: "IX_INV_ITEM_STATUSCHECK_ITEM_ID",
                table: "INV_ITEM_STATUSCHECK",
                column: "ITEM_ID");

            migrationBuilder.CreateIndex(
                name: "IX_INV_ITEM_STATUSCHECK_PREP_BY",
                table: "INV_ITEM_STATUSCHECK",
                column: "PREP_BY");

            migrationBuilder.CreateIndex(
                name: "IX_INV_ITEM_STATUSCHECK_SPEC_ID",
                table: "INV_ITEM_STATUSCHECK",
                column: "SPEC_ID");

            migrationBuilder.CreateIndex(
                name: "IX_INV_ITEM_STATUSCHECK_TALLY_BY",
                table: "INV_ITEM_STATUSCHECK",
                column: "TALLY_BY");

            migrationBuilder.CreateIndex(
                name: "IX_INV_LILAMAPPDETAILS_LILAMAPPLIID",
                table: "INV_LILAMAPPDETAILS",
                column: "LILAMAPPLIID");

            migrationBuilder.CreateIndex(
                name: "IX_INV_PUR_ORDER_DETL_BRAND_ID",
                table: "INV_PUR_ORDER_DETL",
                column: "BRAND_ID");

            migrationBuilder.CreateIndex(
                name: "IX_INV_PUR_ORDER_DETL_ITEM_ID",
                table: "INV_PUR_ORDER_DETL",
                column: "ITEM_ID");

            migrationBuilder.CreateIndex(
                name: "IX_INV_PUR_ORDER_DETL_ITEM_TYPE",
                table: "INV_PUR_ORDER_DETL",
                column: "ITEM_TYPE");

            migrationBuilder.CreateIndex(
                name: "IX_INV_PUR_ORDER_DETL_PUR_MST_ID",
                table: "INV_PUR_ORDER_DETL",
                column: "PUR_MST_ID");

            migrationBuilder.CreateIndex(
                name: "IX_INV_PUR_ORDER_DETL_SPEC_ID",
                table: "INV_PUR_ORDER_DETL",
                column: "SPEC_ID");

            migrationBuilder.CreateIndex(
                name: "IX_INV_PUR_ORDER_DETL_UNIT_ID",
                table: "INV_PUR_ORDER_DETL",
                column: "UNIT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_INV_PUR_ORDER_MAST_ACCEPTED_BY",
                table: "INV_PUR_ORDER_MAST",
                column: "ACCEPTED_BY");

            migrationBuilder.CreateIndex(
                name: "IX_INV_PUR_ORDER_MAST_CHECKED_BY",
                table: "INV_PUR_ORDER_MAST",
                column: "CHECKED_BY");

            migrationBuilder.CreateIndex(
                name: "IX_INV_PUR_ORDER_MAST_PREPARED_BY",
                table: "INV_PUR_ORDER_MAST",
                column: "PREPARED_BY");

            migrationBuilder.CreateIndex(
                name: "IX_INV_PUR_ORDER_MAST_SUPP_ID",
                table: "INV_PUR_ORDER_MAST",
                column: "SUPP_ID");

            migrationBuilder.CreateIndex(
                name: "IX_INV_REQ_DETAIL_BRAND_ID",
                table: "INV_REQ_DETAIL",
                column: "BRAND_ID");

            migrationBuilder.CreateIndex(
                name: "IX_INV_REQ_DETAIL_ITEM_ID",
                table: "INV_REQ_DETAIL",
                column: "ITEM_ID");

            migrationBuilder.CreateIndex(
                name: "IX_INV_REQ_DETAIL_REQ_MAST_ID",
                table: "INV_REQ_DETAIL",
                column: "REQ_MAST_ID");

            migrationBuilder.CreateIndex(
                name: "IX_INV_REQ_DETAIL_SPEC_ID",
                table: "INV_REQ_DETAIL",
                column: "SPEC_ID");

            migrationBuilder.CreateIndex(
                name: "IX_INV_REQUISITION_MAST_ACCEPT_BY",
                table: "INV_REQUISITION_MAST",
                column: "ACCEPT_BY");

            migrationBuilder.CreateIndex(
                name: "IX_INV_REQUISITION_MAST_CHECK_BY",
                table: "INV_REQUISITION_MAST",
                column: "CHECK_BY");

            migrationBuilder.CreateIndex(
                name: "IX_INV_REQUISITION_MAST_ITEM_ID",
                table: "INV_REQUISITION_MAST",
                column: "ITEM_ID");

            migrationBuilder.CreateIndex(
                name: "IX_INV_REQUISITION_MAST_PREP_BY",
                table: "INV_REQUISITION_MAST",
                column: "PREP_BY");

            migrationBuilder.CreateIndex(
                name: "IX_INV_REQUISITION_MAST_PROJ_ID",
                table: "INV_REQUISITION_MAST",
                column: "PROJ_ID");

            migrationBuilder.CreateIndex(
                name: "IX_INV_REQUISITION_MAST_REQ_BY",
                table: "INV_REQUISITION_MAST",
                column: "REQ_BY");

            migrationBuilder.CreateIndex(
                name: "IX_INV_ROOM_MST_DEPT_ID",
                table: "INV_ROOM_MST",
                column: "DEPT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_INV_STATUS_DETAIL_ACCEPTBY",
                table: "INV_STATUS_DETAIL",
                column: "ACCEPTBY");

            migrationBuilder.CreateIndex(
                name: "IX_INV_STATUS_DETAIL_CHECKEDBY",
                table: "INV_STATUS_DETAIL",
                column: "CHECKEDBY");

            migrationBuilder.CreateIndex(
                name: "IX_INV_STATUS_DETAIL_PREBY",
                table: "INV_STATUS_DETAIL",
                column: "PREBY");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_AREA_GND_COV_REGIONID",
                table: "MAP_AREA_GND_COV",
                column: "REGIONID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_INCOME_TYPE_ACC_ID",
                table: "MAP_INCOME_TYPE",
                column: "ACC_ID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_REGION_FAR_REGIONID",
                table: "MAP_REGION_FAR",
                column: "REGIONID");

            migrationBuilder.CreateIndex(
                name: "IX_ORG_BANK_ACCOUNT_BANK_ACCNT_TYPE_ID",
                table: "ORG_BANK_ACCOUNT",
                column: "BANK_ACCNT_TYPE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ORG_BANK_ACCOUNT_BRANCH_ID",
                table: "ORG_BANK_ACCOUNT",
                column: "BRANCH_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ORG_BANK_ACCOUNT_ORG_ID",
                table: "ORG_BANK_ACCOUNT",
                column: "ORG_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ORGANIZATION_TREE_GEO_REGION",
                table: "ORGANIZATION_TREE",
                column: "GEO_REGION");

            migrationBuilder.CreateIndex(
                name: "IX_ORGANIZATION_TREE_PARENT_ID",
                table: "ORGANIZATION_TREE",
                column: "PARENT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_AWARDS_LOCAL_POST_ID",
                table: "PIS_AWARDS",
                column: "LOCAL_POST_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_BANK_PAYROLL_BANK_ID",
                table: "PIS_BANK_PAYROLL",
                column: "BANK_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_BANK_PAYROLL_EMP_ID",
                table: "PIS_BANK_PAYROLL",
                column: "EMP_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_DARBANDI_LOCAL_POST_ID",
                table: "PIS_DARBANDI",
                column: "LOCAL_POST_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_DARBANDI_OFFICE_ID",
                table: "PIS_DARBANDI",
                column: "OFFICE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_DARBANDI_POST_ID",
                table: "PIS_DARBANDI",
                column: "POST_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_DELETD_FRM_FULFILD_DARB_FRM_DARBANDI_ID",
                table: "PIS_DELETD_FRM_FULFILD_DARB",
                column: "FRM_DARBANDI_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_DELETD_FRM_FULFILD_DARB_FRM_OFFICE_ID",
                table: "PIS_DELETD_FRM_FULFILD_DARB",
                column: "FRM_OFFICE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_DELETD_FRM_FULFILD_DARB_FRM_SN_IN_FD",
                table: "PIS_DELETD_FRM_FULFILD_DARB",
                column: "FRM_SN_IN_FD");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_DELETD_FRM_FULFILD_DARB_TO_SN_IN_FD",
                table: "PIS_DELETD_FRM_FULFILD_DARB",
                column: "TO_SN_IN_FD");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_EDUCATION_BOARD_ID",
                table: "PIS_EDUCATION",
                column: "BOARD_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_EDUCATION_EDU_LEVEL_ID",
                table: "PIS_EDUCATION",
                column: "EDU_LEVEL_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_EMP_ADV_DED_DTL_EMP_ID",
                table: "PIS_EMP_ADV_DED_DTL",
                column: "EMP_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_EMP_DEP_SOURCE_BUDJET_SOURCE_ID",
                table: "PIS_EMP_DEP_SOURCE",
                column: "BUDJET_SOURCE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_EMP_LOANS_EMP_ID",
                table: "PIS_EMP_LOANS",
                column: "EMP_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_EMP_LONG_LEAVES_EMP_ID",
                table: "PIS_EMP_LONG_LEAVES",
                column: "EMP_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_EMP_LONG_LEAVES_LOCAL_POST_ID",
                table: "PIS_EMP_LONG_LEAVES",
                column: "LOCAL_POST_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_EMP_MED_EXPENSE_EMP_ID",
                table: "PIS_EMP_MED_EXPENSE",
                column: "EMP_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_EMP_MED_EXPENSE_LOCAL_POST_ID",
                table: "PIS_EMP_MED_EXPENSE",
                column: "LOCAL_POST_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_EMP_PUNISHMNTS_EMP_ID",
                table: "PIS_EMP_PUNISHMNTS",
                column: "EMP_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_EMP_PUNISHMNTS_LOCAL_POST_ID",
                table: "PIS_EMP_PUNISHMNTS",
                column: "LOCAL_POST_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_EMP_SRVC_DTLS_EMP_ID",
                table: "PIS_EMP_SRVC_DTLS",
                column: "EMP_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_EMP_SRVC_DTLS_LOCAL_POST_ID",
                table: "PIS_EMP_SRVC_DTLS",
                column: "LOCAL_POST_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_EMP_SUSPENDS_EMP_ID",
                table: "PIS_EMP_SUSPENDS",
                column: "EMP_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_EMP_SUSPENDS_LOCAL_POST_ID",
                table: "PIS_EMP_SUSPENDS",
                column: "LOCAL_POST_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_EMP_TRNSFR_REC_EMP_ID",
                table: "PIS_EMP_TRNSFR_REC",
                column: "EMP_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_EMP_TRNSFR_REC_LOCAL_POST_ID",
                table: "PIS_EMP_TRNSFR_REC",
                column: "LOCAL_POST_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_EMPLOYEE_MASTER_DEPT_ID",
                table: "PIS_EMPLOYEE_MASTER",
                column: "DEPT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_EMPLOYEE_MASTER_FIRST_APPOINT_POST_ID",
                table: "PIS_EMPLOYEE_MASTER",
                column: "FIRST_APPOINT_POST_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_EMPLOYEE_MASTER_LOCAL_POST_ID",
                table: "PIS_EMPLOYEE_MASTER",
                column: "LOCAL_POST_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_EMPLOYEE_MASTER_PAYEMENT_BANK_ID",
                table: "PIS_EMPLOYEE_MASTER",
                column: "PAYEMENT_BANK_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_EMPLOYEE_MASTER_POST_ID",
                table: "PIS_EMPLOYEE_MASTER",
                column: "POST_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_FOREIGN_VISITS_LOCAL_POST_ID",
                table: "PIS_FOREIGN_VISITS",
                column: "LOCAL_POST_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_FULFILLED_DARBANDI_DARBANDI_ID",
                table: "PIS_FULFILLED_DARBANDI",
                column: "DARBANDI_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_FULFILLED_DARBANDI_LOCAL_POST_ID",
                table: "PIS_FULFILLED_DARBANDI",
                column: "LOCAL_POST_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_FULFILLED_DARBANDI_OFFICE_ID",
                table: "PIS_FULFILLED_DARBANDI",
                column: "OFFICE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_INTERNAL_TRANSFER_APPOINTMNT_TYPE",
                table: "PIS_INTERNAL_TRANSFER",
                column: "APPOINTMNT_TYPE");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_INTERNAL_TRANSFER_DARBANDI_ID",
                table: "PIS_INTERNAL_TRANSFER",
                column: "DARBANDI_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_INTERNAL_TRANSFER_EMP_ID",
                table: "PIS_INTERNAL_TRANSFER",
                column: "EMP_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_INTERNAL_TRANSFER_OFFICE_ID",
                table: "PIS_INTERNAL_TRANSFER",
                column: "OFFICE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_INTERNAL_TRANSFER_TO_APPOINTMNT_TYPE",
                table: "PIS_INTERNAL_TRANSFER",
                column: "TO_APPOINTMNT_TYPE");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_INTERNAL_TRANSFER_TO_LOCAL_POST_ID",
                table: "PIS_INTERNAL_TRANSFER",
                column: "TO_LOCAL_POST_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_INTERNAL_TRANSFER_TO_OFFICE_ID",
                table: "PIS_INTERNAL_TRANSFER",
                column: "TO_OFFICE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_LOCAL_POST_MASTER_POST_ID",
                table: "PIS_LOCAL_POST_MASTER",
                column: "POST_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_NIJAMATI_SEWA_SAMUHA_PARENT_ID",
                table: "PIS_NIJAMATI_SEWA_SAMUHA",
                column: "PARENT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_OTHER_ADD_SUB_LOCAL_POST_ID",
                table: "PIS_OTHER_ADD_SUB",
                column: "LOCAL_POST_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_PRIZES_LOCAL_POST_ID",
                table: "PIS_PRIZES",
                column: "LOCAL_POST_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_PUBLICATION_LOCAL_POST_ID",
                table: "PIS_PUBLICATION",
                column: "LOCAL_POST_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_PYROLL_LOAN_DTLS_ACC_ID",
                table: "PIS_PYROLL_LOAN_DTLS",
                column: "ACC_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_PYROLL_LOAN_DTLS_EMP_ID",
                table: "PIS_PYROLL_LOAN_DTLS",
                column: "EMP_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_PYROLL_LOAN_DTLS_LOAND_ID",
                table: "PIS_PYROLL_LOAN_DTLS",
                column: "LOAND_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_PYROLL_LOAN_DTLS_PAYROLL_ID",
                table: "PIS_PYROLL_LOAN_DTLS",
                column: "PAYROLL_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_PYROLL_OTHR_DTLS_EMPLOYEE_ID",
                table: "PIS_PYROLL_OTHR_DTLS",
                column: "EMPLOYEE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_PYROLL_OTHR_DTLS_PAYROLL_ID",
                table: "PIS_PYROLL_OTHR_DTLS",
                column: "PAYROLL_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_REPLACED_IN_DARBANDI_DARBANDI_ID",
                table: "PIS_REPLACED_IN_DARBANDI",
                column: "DARBANDI_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_REPLACED_IN_DARBANDI_ENTRY_SN_IN_FD",
                table: "PIS_REPLACED_IN_DARBANDI",
                column: "ENTRY_SN_IN_FD");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_REPLACED_IN_DARBANDI_OFFICE_ID",
                table: "PIS_REPLACED_IN_DARBANDI",
                column: "OFFICE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_SGNFCNT_WORK_LOCAL_POST_ID",
                table: "PIS_SGNFCNT_WORK",
                column: "LOCAL_POST_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_TRAINING_LOCAL_POST_ID",
                table: "PIS_TRAINING",
                column: "LOCAL_POST_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_VISITED_COUNTRIES_VISIT_ID",
                table: "PIS_VISITED_COUNTRIES",
                column: "VISIT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PIS_WORKSHOP_LOCAL_POST_ID",
                table: "PIS_WORKSHOP",
                column: "LOCAL_POST_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SANITATION_RATE_GROUPID",
                table: "SANITATION_RATE",
                column: "GROUPID");

            migrationBuilder.CreateIndex(
                name: "IX_SANITATION_RATE_SUBGROUPID",
                table: "SANITATION_RATE",
                column: "SUBGROUPID");

            migrationBuilder.CreateIndex(
                name: "IX_SANITATION_SUBGROUP_GROUPID",
                table: "SANITATION_SUBGROUP",
                column: "GROUPID");

            migrationBuilder.CreateIndex(
                name: "IX_SERVICE_CHARGE_MASTER_ACC_ID",
                table: "SERVICE_CHARGE_MASTER",
                column: "ACC_ID");

            migrationBuilder.CreateIndex(
                name: "IX_STOREDBILLS_BILLTYPEID",
                table: "STOREDBILLS",
                column: "BILLTYPEID");

            migrationBuilder.CreateIndex(
                name: "IX_SUB_MODULE_SOURCE_BUDJET_SOURCE_ID",
                table: "SUB_MODULE_SOURCE",
                column: "BUDJET_SOURCE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SUB_MODULE_SOURCE_SUB_MODULE_ID",
                table: "SUB_MODULE_SOURCE",
                column: "SUB_MODULE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TAX_ADDTNL_CHRG_DTLS_ACC_ID",
                table: "TAX_ADDTNL_CHRG_DTLS",
                column: "ACC_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TAX_ADDTNL_CHRG_DTLS_ACCODE",
                table: "TAX_ADDTNL_CHRG_DTLS",
                column: "ACCODE");

            migrationBuilder.CreateIndex(
                name: "IX_TAX_THLI_ISSUED_CNTR_CNTR_ID",
                table: "TAX_THLI_ISSUED_CNTR",
                column: "CNTR_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TAX_THLI_ISSUED_CNTR_THELI_ID",
                table: "TAX_THLI_ISSUED_CNTR",
                column: "THELI_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_BGT_MGMT_EXP_BGT_MGMT_ID",
                table: "TBL_BGT_MGMT_EXP",
                column: "BGT_MGMT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_BGT_MGMT_EXP_ORG_BGT_MGMT_ORG_ID",
                table: "TBL_BGT_MGMT_EXP_ORG",
                column: "BGT_MGMT_ORG_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_BGT_MGMT_EXP_RELEASE_BGT_MGMT_RELEASE_ID",
                table: "TBL_BGT_MGMT_EXP_RELEASE",
                column: "BGT_MGMT_RELEASE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_BGT_MGMT_RELEASE_BGT_RELEASE_ID",
                table: "TBL_BGT_MGMT_RELEASE",
                column: "BGT_RELEASE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_BGT_MGMT_SRC_BGT_MGMT_EXP_ID",
                table: "TBL_BGT_MGMT_SRC",
                column: "BGT_MGMT_EXP_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_BGT_MGMT_SRC_ORG_BGT_MGMT_EXP_ORG_ID",
                table: "TBL_BGT_MGMT_SRC_ORG",
                column: "BGT_MGMT_EXP_ORG_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_BGT_MGMT_SRC_ORG_CC_ID",
                table: "TBL_BGT_MGMT_SRC_ORG",
                column: "CC_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_BGT_MGMT_SRC_RELEASE_BGT_MGMT_EXP_RELEASE_ID",
                table: "TBL_BGT_MGMT_SRC_RELEASE",
                column: "BGT_MGMT_EXP_RELEASE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_BGT_MGMT_SRC_RELEASE_CC_ID",
                table: "TBL_BGT_MGMT_SRC_RELEASE",
                column: "CC_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_BGT_RELEASE_ORG_ID",
                table: "TBL_BGT_RELEASE",
                column: "ORG_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_CONSTRUCTION_OTHER_CHARGES_ACC_ID",
                table: "TBL_CONSTRUCTION_OTHER_CHARGES",
                column: "ACC_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_LAND_OTHER_CHARGES_ACC_ID",
                table: "TBL_LAND_OTHER_CHARGES",
                column: "ACC_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_MALPOT_OTHER_CHARGES_ACC_ID",
                table: "TBL_MALPOT_OTHER_CHARGES",
                column: "ACC_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_MALPOT_OTHER_CHARGES_RATEID",
                table: "TBL_MALPOT_OTHER_CHARGES",
                column: "RATEID");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_PAYMENT_ORDER_DETAILS_PAYMENT_ORDER_ID",
                table: "TBL_PAYMENT_ORDER_DETAILS",
                column: "PAYMENT_ORDER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TBLBUSINESS_SERVICE_CH_MST_ACC_ID",
                table: "TBLBUSINESS_SERVICE_CH_MST",
                column: "ACC_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TBLFYWISEMPOTASSRATE_GROUPID",
                table: "TBLFYWISEMPOTASSRATE",
                column: "GROUPID");

            migrationBuilder.CreateIndex(
                name: "IX_TBLFYWISEMPOTASSRATE_RATEID",
                table: "TBLFYWISEMPOTASSRATE",
                column: "RATEID");

            migrationBuilder.CreateIndex(
                name: "IX_TBLFYWISEMPOTASSRATE_SUBGROUPID",
                table: "TBLFYWISEMPOTASSRATE",
                column: "SUBGROUPID");

            migrationBuilder.CreateIndex(
                name: "IX_TBLMALPOTRATES_GROUPID",
                table: "TBLMALPOTRATES",
                column: "GROUPID");

            migrationBuilder.CreateIndex(
                name: "IX_TBLMALPOTRATES_SUBGROUPID",
                table: "TBLMALPOTRATES",
                column: "SUBGROUPID");

            migrationBuilder.CreateIndex(
                name: "IX_TBLMALPOTSUBGROUP_GROUPID",
                table: "TBLMALPOTSUBGROUP",
                column: "GROUPID");

            migrationBuilder.CreateIndex(
                name: "IX_TBLVEH_SER_CH_MSTR_ACC_ID",
                table: "TBLVEH_SER_CH_MSTR",
                column: "ACC_ID");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Usermaster",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Usermaster",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WARD_MASTER_PRAMUKH_ID",
                table: "WARD_MASTER",
                column: "PRAMUKH_ID");

            migrationBuilder.CreateIndex(
                name: "IX_WARD_MASTER_UPPRAMUKH_ID",
                table: "WARD_MASTER",
                column: "UPPRAMUKH_ID");

            migrationBuilder.CreateIndex(
                name: "IX_WARD_MASTER_WARD_SECRETARY_ID",
                table: "WARD_MASTER",
                column: "WARD_SECRETARY_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ACC_ASULI_BIBARAN");

            migrationBuilder.DropTable(
                name: "ACC_BANK_GRNTY");

            migrationBuilder.DropTable(
                name: "ACC_BANK_STATEMENT");

            migrationBuilder.DropTable(
                name: "ACC_BANK_TRANS");

            migrationBuilder.DropTable(
                name: "ACC_BGT_RVSN");

            migrationBuilder.DropTable(
                name: "ACC_BGT_TRANSFER");

            migrationBuilder.DropTable(
                name: "ACC_BUDJET_SOURCE");

            migrationBuilder.DropTable(
                name: "ACC_CASH_TRANS");

            migrationBuilder.DropTable(
                name: "ACC_CHEQUE_TYPES");

            migrationBuilder.DropTable(
                name: "ACC_CURRENCTY_RATE");

            migrationBuilder.DropTable(
                name: "ACC_DHRTI_BILL_DTL");

            migrationBuilder.DropTable(
                name: "ACC_EXPENSES_DETAILS");

            migrationBuilder.DropTable(
                name: "ACC_INCOME_RATE");

            migrationBuilder.DropTable(
                name: "ACC_LAST_YR_PESKI");

            migrationBuilder.DropTable(
                name: "ACC_LASTYEAR_ADV_DETAILS");

            migrationBuilder.DropTable(
                name: "ACC_PAYMENT_CLEARANCE");

            migrationBuilder.DropTable(
                name: "ACC_PAYMENT_CREDIT");

            migrationBuilder.DropTable(
                name: "ACC_PAYMENT_DEDUCTION");

            migrationBuilder.DropTable(
                name: "ACC_PAYMENT_DETAILS");

            migrationBuilder.DropTable(
                name: "ACC_RECEIVABLE");

            migrationBuilder.DropTable(
                name: "ACC_UNAUTHORISED");

            migrationBuilder.DropTable(
                name: "ACC_USER_COMITE_MSTR");

            migrationBuilder.DropTable(
                name: "ACC_VCHR_DETAILS");

            migrationBuilder.DropTable(
                name: "ACC_WORK_FUNDS_DETAIL");

            migrationBuilder.DropTable(
                name: "ACC_WORK_PAYMNT_TRANS");

            migrationBuilder.DropTable(
                name: "APPLICATION_CONFIGURATION"); 
            migrationBuilder.DropTable(
                name: "BANKTRANSACTIONS");

            migrationBuilder.DropTable(
                name: "BUDJET_SUB_HEAD");

            migrationBuilder.DropTable(
                name: "BUSINESSMASTER_HISTORY");

            migrationBuilder.DropTable(
                name: "CASHTRANSACTION");

            migrationBuilder.DropTable(
                name: "CELEDGER20682069");

            migrationBuilder.DropTable(
                name: "CONSTANTVALUES");

            migrationBuilder.DropTable(
                name: "COUNTRY");

            migrationBuilder.DropTable(
                name: "DDC");

            migrationBuilder.DropTable(
                name: "DEV_REGION");

            migrationBuilder.DropTable(
                name: "DISTRICT");

            migrationBuilder.DropTable(
                name: "EMP_GRP");

            migrationBuilder.DropTable(
                name: "FIREBRIGADESTATE");

            migrationBuilder.DropTable(
                name: "FISCALYEARS");

            migrationBuilder.DropTable(
                name: "FYWISERENTDARRATE");

            migrationBuilder.DropTable(
                name: "FYWISESANITATION_RATE");

            migrationBuilder.DropTable(
                name: "Imis_Menu");

            migrationBuilder.DropTable(
                name: "INCOMEBILLDETAILS");

            migrationBuilder.DropTable(
                name: "INCOMEBILLDETAILS_HISTORY");

            migrationBuilder.DropTable(
                name: "INV_APPLICANT_RATE");

            migrationBuilder.DropTable(
                name: "INV_DEPLIST");

            migrationBuilder.DropTable(
                name: "INV_DEPRECIATION");

            migrationBuilder.DropTable(
                name: "INV_GOODS_REC_DETL");

            migrationBuilder.DropTable(
                name: "INV_INCREASE_DECREASE");

            migrationBuilder.DropTable(
                name: "INV_ISSUE_DAKHILA");

            migrationBuilder.DropTable(
                name: "INV_ISSUE_DETAIL");

            migrationBuilder.DropTable(
                name: "INV_ISSUE_MASTER");

            migrationBuilder.DropTable(
                name: "INV_ITEM_ADJ_TYPE");

            migrationBuilder.DropTable(
                name: "INV_ITEM_DETAILS");

            migrationBuilder.DropTable(
                name: "INV_ITEM_STATUSCHECK");

            migrationBuilder.DropTable(
                name: "INV_LILAM_DETAIL");

            migrationBuilder.DropTable(
                name: "INV_LILAM_MAST");

            migrationBuilder.DropTable(
                name: "INV_LILAM_REC_LIST");

            migrationBuilder.DropTable(
                name: "INV_LILAMAPPDETAILS");

            migrationBuilder.DropTable(
                name: "INV_ORG_TYPE");

            migrationBuilder.DropTable(
                name: "INV_PUR_MAST_PLAN");

            migrationBuilder.DropTable(
                name: "INV_PUR_ORDER_DETL");

            migrationBuilder.DropTable(
                name: "INV_PUR_TYPE");

            migrationBuilder.DropTable(
                name: "INV_REQ_DETAIL");

            migrationBuilder.DropTable(
                name: "INV_ROOM_MST");

            migrationBuilder.DropTable(
                name: "INV_STATUS_DETAIL");

            migrationBuilder.DropTable(
                name: "INV_SUP_ITM_DET");

            migrationBuilder.DropTable(
                name: "INV_SUPPLIER_FISCALYEAR");

            migrationBuilder.DropTable(
                name: "INV_TAX_RATE");

            migrationBuilder.DropTable(
                name: "INV_TYPE_SETUP");

            migrationBuilder.DropTable(
                name: "INV_WAREHOUSE");

            migrationBuilder.DropTable(
                name: "INV_YRLY_PUR_PLAN");

            migrationBuilder.DropTable(
                name: "IPTTAXSUMMARY_HISTORY");

            migrationBuilder.DropTable(
                name: "ISSUEDBILLS");

            migrationBuilder.DropTable(
                name: "LANDMEASURINGUNITS");

            migrationBuilder.DropTable(
                name: "LANDSMULTIEVALUATIONDETAIL");

            migrationBuilder.DropTable(
                name: "LELEDGER20682069");

            migrationBuilder.DropTable(
                name: "MALPOT_LANDS");

            migrationBuilder.DropTable(
                name: "MAP_AREA_GND_COV");

            migrationBuilder.DropTable(
                name: "MAP_CONSTRCTION_KIND");

            migrationBuilder.DropTable(
                name: "MAP_DESIGNER_DTL");

            migrationBuilder.DropTable(
                name: "MAP_DIRECTION");

            migrationBuilder.DropTable(
                name: "MAP_DRAIN_TYPE");

            migrationBuilder.DropTable(
                name: "MAP_FLOOR");

            migrationBuilder.DropTable(
                name: "MAP_HOUSEUSE_TYPE");

            migrationBuilder.DropTable(
                name: "MAP_HTSTANDARD");

            migrationBuilder.DropTable(
                name: "MAP_INCOME_TYPE");

            migrationBuilder.DropTable(
                name: "MAP_LAND_OWNER_TYPE");

            migrationBuilder.DropTable(
                name: "MAP_NEIGHBOUR_TYPE");

            migrationBuilder.DropTable(
                name: "MAP_RATE");

            migrationBuilder.DropTable(
                name: "MAP_REGION_FAR");

            migrationBuilder.DropTable(
                name: "MAP_ROOF_CNSTRCT_TYPE");

            migrationBuilder.DropTable(
                name: "MAP_ROOF_TYPE");

            migrationBuilder.DropTable(
                name: "MAP_SITE");

            migrationBuilder.DropTable(
                name: "MAP_STDHEIGHT_RW");

            migrationBuilder.DropTable(
                name: "MAP_STOREYS");

            migrationBuilder.DropTable(
                name: "MAP_STRUCTURE_TYPE");

            migrationBuilder.DropTable(
                name: "MINISTRY");

            migrationBuilder.DropTable(
                name: "NATIONALITIES");

            migrationBuilder.DropTable(
                name: "NEW_PROPERTY_TAXTABLE");

            migrationBuilder.DropTable(
                name: "OFFICE_TYPE");

            migrationBuilder.DropTable(
                name: "ORG_BANK_ACCOUNT");

            migrationBuilder.DropTable(
                name: "PIS_ATTRIBUTES");

            migrationBuilder.DropTable(
                name: "PIS_AWARDS");

            migrationBuilder.DropTable(
                name: "PIS_BANK_PAYROLL");

            migrationBuilder.DropTable(
                name: "PIS_DELETD_FRM_FULFILD_DARB");

            migrationBuilder.DropTable(
                name: "PIS_EDUCATION");

            migrationBuilder.DropTable(
                name: "PIS_EMP_ADV_DED_DTL");

            migrationBuilder.DropTable(
                name: "PIS_EMP_BARGA");

            migrationBuilder.DropTable(
                name: "PIS_EMP_DEP_SOURCE");

            migrationBuilder.DropTable(
                name: "PIS_EMP_INSURANCE_PAID");

            migrationBuilder.DropTable(
                name: "PIS_EMP_LONG_LEAVES");

            migrationBuilder.DropTable(
                name: "PIS_EMP_MED_EXPENSE");

            migrationBuilder.DropTable(
                name: "PIS_EMP_PUNISHMNTS");

            migrationBuilder.DropTable(
                name: "PIS_EMP_SRVC_DTLS");

            migrationBuilder.DropTable(
                name: "PIS_EMP_SUSPENDS");

            migrationBuilder.DropTable(
                name: "PIS_EMP_TRNSFR_REC");

            migrationBuilder.DropTable(
                name: "PIS_HAJIRI");

            migrationBuilder.DropTable(
                name: "PIS_INTERNAL_TRANSFER");

            migrationBuilder.DropTable(
                name: "PIS_LAND_BLDNGS");

            migrationBuilder.DropTable(
                name: "PIS_LOAN_DHITO_GIVEN");

            migrationBuilder.DropTable(
                name: "PIS_LOAN_DHITO_TAKEN");

            migrationBuilder.DropTable(
                name: "PIS_NIJAMATI_SEWA_SAMUHA");

            migrationBuilder.DropTable(
                name: "PIS_ORNAMENTS");

            migrationBuilder.DropTable(
                name: "PIS_OTHER_ADD_SUB");

            migrationBuilder.DropTable(
                name: "PIS_PD_ORG_INVLVMNT");

            migrationBuilder.DropTable(
                name: "PIS_PD_SRVC_DTLS");

            migrationBuilder.DropTable(
                name: "PIS_PERSON_VISIT_RECRD");

            migrationBuilder.DropTable(
                name: "PIS_PRIZES");

            migrationBuilder.DropTable(
                name: "PIS_PUBLICATION");

            migrationBuilder.DropTable(
                name: "PIS_PYROLL_LOAN_DTLS");

            migrationBuilder.DropTable(
                name: "PIS_PYROLL_OTHR_DTLS");

            migrationBuilder.DropTable(
                name: "PIS_REPLACED_IN_DARBANDI");

            migrationBuilder.DropTable(
                name: "PIS_SERVICE_STATUS");

            migrationBuilder.DropTable(
                name: "PIS_SGNFCNT_WORK");

            migrationBuilder.DropTable(
                name: "PIS_SHARE_BANKBALANCE");

            migrationBuilder.DropTable(
                name: "PIS_TRAINING");

            migrationBuilder.DropTable(
                name: "PIS_VISITED_COUNTRIES");

            migrationBuilder.DropTable(
                name: "PIS_WORKSHOP");

            migrationBuilder.DropTable(
                name: "PMS_YOJTYPE");

            migrationBuilder.DropTable(
                name: "RENT_DAR_RATE");

            migrationBuilder.DropTable(
                name: "RENTTYPE");

            migrationBuilder.DropTable(
                name: "REPORT_GENERAL");

            migrationBuilder.DropTable(
                name: "SANITATION_RATE");

            migrationBuilder.DropTable(
                name: "SERVICE_CHARGE_MASTER");

            migrationBuilder.DropTable(
                name: "SPACEMEASURINGUNITS");

            migrationBuilder.DropTable(
                name: "SUB_MODULE_SOURCE");

            migrationBuilder.DropTable(
                name: "SUBJECT_AREA");

            migrationBuilder.DropTable(
                name: "SV_BUSINESSMASTER");

            migrationBuilder.DropTable(
                name: "SV_CONSTRUCTIONS");

            migrationBuilder.DropTable(
                name: "SV_HOUSES");

            migrationBuilder.DropTable(
                name: "SV_LANDS");

            migrationBuilder.DropTable(
                name: "SV_LANDSMULTIEVALUATIONDETAIL");

            migrationBuilder.DropTable(
                name: "SV_PEOPLE");

            migrationBuilder.DropTable(
                name: "SV_TBHOUSEKITTANUMBER");

            migrationBuilder.DropTable(
                name: "SV_VEHICLEMASTER");

            migrationBuilder.DropTable(
                name: "TAX_ADDTNL_CHRG_DTLS");

            migrationBuilder.DropTable(
                name: "TAX_MALPOT");

            migrationBuilder.DropTable(
                name: "TAX_MALPOT_HISTORY");

            migrationBuilder.DropTable(
                name: "TAX_RATE_CEILING");

            migrationBuilder.DropTable(
                name: "TAX_RENTAL");

            migrationBuilder.DropTable(
                name: "TAX_RT_RENTDTL");

            migrationBuilder.DropTable(
                name: "TAX_SANITATION");

            migrationBuilder.DropTable(
                name: "TAX_THLI_ISSUED_CNTR");

            migrationBuilder.DropTable(
                name: "TBHOUSEKITTANUMBER");

            migrationBuilder.DropTable(
                name: "TBL_BANK_FINANCE_INSTITUTUE");

            migrationBuilder.DropTable(
                name: "TBL_BGT_MGMT_SRC");

            migrationBuilder.DropTable(
                name: "TBL_BGT_MGMT_SRC_ORG");

            migrationBuilder.DropTable(
                name: "TBL_BGT_MGMT_SRC_RELEASE");

            migrationBuilder.DropTable(
                name: "TBL_CONSTRUCTION_OTHER_CHARGES");

            migrationBuilder.DropTable(
                name: "TBL_DATA_HISTORY");

            migrationBuilder.DropTable(
                name: "TBL_DEGISTER");

            migrationBuilder.DropTable(
                name: "TBL_KHARIDA_AADASH");

            migrationBuilder.DropTable(
                name: "TBL_LAND_OTHER_CHARGES");

            migrationBuilder.DropTable(
                name: "TBL_MALPOT_OTHER_CHARGES");

            migrationBuilder.DropTable(
                name: "TBL_NALI_TYPE");

            migrationBuilder.DropTable(
                name: "TBL_ORGANIZATIONMASTER");

            migrationBuilder.DropTable(
                name: "TBL_PAYMENT_ORDER_DETAILS");

            migrationBuilder.DropTable(
                name: "TBL_PAYMENT_PROCESS");

            migrationBuilder.DropTable(
                name: "TBL_PAYMENT_TYPE");

            migrationBuilder.DropTable(
                name: "TBL_PROPERTY_TAX");

            migrationBuilder.DropTable(
                name: "TBL_SANITAION_TAX");

            migrationBuilder.DropTable(
                name: "TBL_STATUS_DETAILS");

            migrationBuilder.DropTable(
                name: "TBL_TAX_TYPE");

            migrationBuilder.DropTable(
                name: "TBL_TAXSOURCERECORDNEW");

            migrationBuilder.DropTable(
                name: "TBL_TOLABIKASA_ORG");

            migrationBuilder.DropTable(
                name: "TBL_VEHICLE_PARTS");

            migrationBuilder.DropTable(
                name: "TBLBUSINESS_SERVICE_CH_MST");

            migrationBuilder.DropTable(
                name: "TBLEXEVERSION");

            migrationBuilder.DropTable(
                name: "TBLFYWISEBTRATES");

            migrationBuilder.DropTable(
                name: "TBLFYWISEMPOTASSRATE");

            migrationBuilder.DropTable(
                name: "TBLHL_ADD_SUBTRACT");

            migrationBuilder.DropTable(
                name: "TBLLAND_TYPE_AREA");

            migrationBuilder.DropTable(
                name: "TBLTAX_FINE_REBATE");

            migrationBuilder.DropTable(
                name: "TBLTAXCALCULATIONROKA");

            migrationBuilder.DropTable(
                name: "TBLVEH_SER_CH_MSTR");

            migrationBuilder.DropTable(
                name: "TBUSERSECURITYRIGHTS");

            migrationBuilder.DropTable(
                name: "TYPES");

            migrationBuilder.DropTable(
                name: "USERASSIGNMENTS");

            migrationBuilder.DropTable(
                name: "VDC");

            migrationBuilder.DropTable(
                name: "WARD_MASTER");

            migrationBuilder.DropTable(
                name: "ZONE");

            migrationBuilder.DropTable(
                name: "ACC_BGT_ALLOCATE");

            migrationBuilder.DropTable(
                name: "MINISTRY_ACC_HEAD");

            migrationBuilder.DropTable(
                name: "INCOMEBILLMASTER");

            migrationBuilder.DropTable(
                name: "ACC_CURRENCTY");

            migrationBuilder.DropTable(
                name: "PAYMENT_SLIP_MASTER");

            migrationBuilder.DropTable(
                name: "ACC_PAYMENT_MASTER");

            migrationBuilder.DropTable(
                name: "ACC_FUND_PROVIDR_MSTR"); 

            migrationBuilder.DropTable(
                name: "Usermaster");

            migrationBuilder.DropTable(
                name: "ACC_DHRTI_BILL_MASTER");

            migrationBuilder.DropTable(
                name: "INV_GOODS_REC_MAST");

            migrationBuilder.DropTable(
                name: "INV_GOODS_ADJUST");

            migrationBuilder.DropTable(
                name: "INV_LILAM_APPMASTER");

            migrationBuilder.DropTable(
                name: "INV_ITEM_CATEGORY");

            migrationBuilder.DropTable(
                name: "INV_PUR_ORDER_MAST");

            migrationBuilder.DropTable(
                name: "INV_REQUISITION_MAST");

            migrationBuilder.DropTable(
                name: "INV_DEPT");

            migrationBuilder.DropTable(
                name: "MAP_ZONE");

            migrationBuilder.DropTable(
                name: "TBL_BANK_ACCNT_TYPE");

            migrationBuilder.DropTable(
                name: "BANK_BRANCH");

            migrationBuilder.DropTable(
                name: "PIS_EDU_BOARD");

            migrationBuilder.DropTable(
                name: "PIS_EDU_LEVEL");

            migrationBuilder.DropTable(
                name: "PIS_APPOINTMENT_TYPE");

            migrationBuilder.DropTable(
                name: "PIS_EMP_LOANS");

            migrationBuilder.DropTable(
                name: "PIS_PAYROLLS");

            migrationBuilder.DropTable(
                name: "PIS_FULFILLED_DARBANDI");

            migrationBuilder.DropTable(
                name: "PIS_FOREIGN_VISITS");

            migrationBuilder.DropTable(
                name: "SANITATION_SUBGROUP");

            migrationBuilder.DropTable(
                name: "BUDJET_SOURCE");

            migrationBuilder.DropTable(
                name: "ACCODE");

            migrationBuilder.DropTable(
                name: "COLLECTIONCOUNTERS");

            migrationBuilder.DropTable(
                name: "STOREDBILLS");

            migrationBuilder.DropTable(
                name: "TBL_BGT_MGMT_EXP");

            migrationBuilder.DropTable(
                name: "TBL_BGT_MGMT_EXP_ORG");

            migrationBuilder.DropTable(
                name: "TBL_BGT_MGMT_EXP_RELEASE");

            migrationBuilder.DropTable(
                name: "CONTACTS");

            migrationBuilder.DropTable(
                name: "TBL_PAYMENT_ORDER");

            migrationBuilder.DropTable(
                name: "TBLMALPOTRATES");

            migrationBuilder.DropTable(
                name: "ACC_ACC_MASTER");

            migrationBuilder.DropTable(
                name: "ACC_PADADHIKARI_MSTR");

            migrationBuilder.DropTable(
                name: "PERSON_TYPE_MASTER");

            migrationBuilder.DropTable(
                name: "ACC_VCHR_MASTER");

            migrationBuilder.DropTable(
                name: "ACC_WORK_MASTER");

            migrationBuilder.DropTable(
                name: "INV_BRAND");

            migrationBuilder.DropTable(
                name: "INV_ITEM_SPEC");

            migrationBuilder.DropTable(
                name: "INV_SUPPLIER");

            migrationBuilder.DropTable(
                name: "INV_ITEM_MST");

            migrationBuilder.DropTable(
                name: "INV_PROJECT");

            migrationBuilder.DropTable(
                name: "PIS_EMPLOYEE_MASTER");

            migrationBuilder.DropTable(
                name: "PIS_DARBANDI");

            migrationBuilder.DropTable(
                name: "SANITATION_GROUP");

            migrationBuilder.DropTable(
                name: "TBLBILLTYPE");

            migrationBuilder.DropTable(
                name: "TBL_BGT_MGMT");

            migrationBuilder.DropTable(
                name: "TBL_BGT_MGMT_ORG");

            migrationBuilder.DropTable(
                name: "TBL_BGT_MGMT_RELEASE");

            migrationBuilder.DropTable(
                name: "TBLMALPOTSUBGROUP");

            migrationBuilder.DropTable(
                name: "ACC_TRANS_TYPE");

            migrationBuilder.DropTable(
                name: "ACC_PADADHIKARI_POST");

            migrationBuilder.DropTable(
                name: "ACC_SUB_MODULE_TYPE");

            migrationBuilder.DropTable(
                name: "ACC_VCHR_TYPE_MASTER");

            migrationBuilder.DropTable(
                name: "INV_UNIT");

            migrationBuilder.DropTable(
                name: "PIS_EMP_DEP");

            migrationBuilder.DropTable(
                name: "BANKMASTER");

            migrationBuilder.DropTable(
                name: "PIS_LOCAL_POST_MASTER");

            migrationBuilder.DropTable(
                name: "ORGANIZATION_TREE");

            migrationBuilder.DropTable(
                name: "TBL_BGT_RELEASE");

            migrationBuilder.DropTable(
                name: "TBLMALPOTGROUP");

            migrationBuilder.DropTable(
                name: "PIS_POST_MASTER");

            migrationBuilder.DropTable(
                name: "PIS_GEO_REGION");

            migrationBuilder.DropTable(
                name: "ACC_ORG_MASTER");
        }
    }
}
