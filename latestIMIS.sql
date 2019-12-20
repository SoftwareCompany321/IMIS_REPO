PGDMP         ,                w            IMIS    12.1    12.1    �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            �           1262    76225    IMIS    DATABASE     �   CREATE DATABASE "IMIS" WITH TEMPLATE = template0 ENCODING = 'UTF8' LC_COLLATE = 'English_United States.1252' LC_CTYPE = 'English_United States.1252';
    DROP DATABASE "IMIS";
                postgres    false            �            1259    76324    ACCODE    TABLE     N  CREATE TABLE public."ACCODE" (
    "ACCODE" integer NOT NULL,
    "SBCODE" integer,
    "GRCODE" integer,
    "TRANTYPE" character varying(1),
    "NEPNAME" character varying(70),
    "ENGNAME" character varying(50),
    "ISDOLLAR" character varying(2),
    "LOCALCODE" character varying(20),
    "ISASSIGNED" character varying(2)
);
    DROP TABLE public."ACCODE";
       public         heap    postgres    false            z           1259    77211    ACC_ACC_MASTER    TABLE     �  CREATE TABLE public."ACC_ACC_MASTER" (
    "ACC_ID" integer NOT NULL,
    "CODE" character varying(100) NOT NULL,
    "NEP_NAME" character varying(200),
    "ENG_NAME" character varying(70),
    "PARENT_ACC_ID" integer,
    "GRP_LEVEL" integer,
    "IS_FIXED" character varying(1),
    "IS_TRANSACTABLE" character varying(1),
    "IS_BUDGETABLE" character varying(1),
    "DISP_CODE" character varying(100),
    "DISP_NAME" character varying(200),
    "ACC_TYPE" character varying(1),
    "TYPE_ID" integer,
    "ACC_CODE" character varying(200),
    "SUB_MODULE_ID" integer,
    "FISCAL_YEAR" character varying(10),
    "IS_HIDE" character varying(1),
    "ISCAPITALCURRENT" integer
);
 $   DROP TABLE public."ACC_ACC_MASTER";
       public         heap    postgres    false            �           1259    77383    ACC_ASULI_BIBARAN    TABLE       CREATE TABLE public."ACC_ASULI_BIBARAN" (
    "ASULI_ID" integer NOT NULL,
    "PERSON_TYPE_ID" integer,
    "PAYMENT_PERSON_ID" integer,
    "PERSON_NAME" character varying(90),
    "WORK_NAME" character varying(100),
    "AMT_TAKEN" real,
    "RESPONSIVE_TAKEN" character varying(100),
    "COLLECT_REASON" character varying(200),
    "PESKI_AMT" real,
    "PESKI_EMPLOYEE_ID" integer,
    "PROPERTY_DETAILS" character varying(200),
    "PROPERTY_EMPLOYEE_ID" integer,
    "PROPERTY_ROKA" character varying(200)
);
 '   DROP TABLE public."ACC_ASULI_BIBARAN";
       public         heap    postgres    false            |           1259    77242    ACC_BANK_GRNTY    TABLE     ~  CREATE TABLE public."ACC_BANK_GRNTY" (
    "GRNTY_ID" integer NOT NULL,
    "GRNTY_NO" character varying(25),
    "GRNTY_VS_DATE" character varying(10),
    "BANK_NAME" character varying(200),
    "GRNTY_AMOUNT" real,
    "GRNTY_TYPE" character varying(2),
    "WORK_ID" integer,
    "PERSON_ID" integer,
    "PHUKUWA_PS" character varying(15),
    "PHUKUWA_CN" character varying(15),
    "PHUKUWA_VS_DATE" character varying(10),
    "MAG_PS" character varying(15),
    "MAG_CN" character varying(15),
    "MAG_VS_DATE" character varying(10),
    "ENTRY_DATETIME" timestamp without time zone,
    "EXPRY_VS_DATE" character varying(10)
);
 $   DROP TABLE public."ACC_BANK_GRNTY";
       public         heap    postgres    false            �            1259    76231    ACC_BANK_STATEMENT    TABLE     i  CREATE TABLE public."ACC_BANK_STATEMENT" (
    "ID" integer,
    "BANK_ID" integer,
    "TRANSACTION_DATE" character varying(10),
    "TRANSACTION_DATE_EN" timestamp without time zone,
    "CHEQUE_NO" character varying(30),
    "DESCRIPTION" character varying(100),
    "DR_AMT" real,
    "CR_AMT" real,
    "BANK_TRANSACTION_ID" integer,
    "BALANCE" real
);
 (   DROP TABLE public."ACC_BANK_STATEMENT";
       public         heap    postgres    false            �           1259    78270    ACC_BANK_TRANS    TABLE     {  CREATE TABLE public."ACC_BANK_TRANS" (
    "BANK_TRANS_ID" integer NOT NULL,
    "VCHR_ID" integer,
    "VCHR_DATE_NEP" character varying(10),
    "DESCRIPTION" character varying(200),
    "DR_AMT" real DEFAULT '0'::real,
    "CR_AMT" real DEFAULT '0'::real,
    "IS_OF_LASTYEAR" character varying(2),
    "TRANS_TYPE_ID" integer,
    "BILL_ID" integer,
    "BANK_ID" integer
);
 $   DROP TABLE public."ACC_BANK_TRANS";
       public         heap    postgres    false            �            1259    76234    ACC_BGT_ALLOCATE    TABLE     �  CREATE TABLE public."ACC_BGT_ALLOCATE" (
    "BGT_ALLOCATE_ID" integer NOT NULL,
    "ACC_ID" integer,
    "REVISED_AMOUNT" real,
    "AMOUNT" real,
    "FISCAL_YEAR" character varying(10),
    "ALLOCATED_DATE_NP" character varying(10),
    "ENTRY_USER_ID" integer,
    "ENTRY_DATETIME" timestamp without time zone,
    "UPDATE_USER_ID" integer,
    "UPDATE_DATETIME" timestamp without time zone,
    "SUB_MODULE_ID" integer,
    "BUDGET_SOURCE_ID" integer
);
 &   DROP TABLE public."ACC_BGT_ALLOCATE";
       public         heap    postgres    false            v           1259    77165    ACC_BGT_RVSN    TABLE       CREATE TABLE public."ACC_BGT_RVSN" (
    "ID" integer NOT NULL,
    "BGT_ALCTN_ID" integer,
    "RVSN_DATE_NP" character varying(10),
    "AMOUNT" real,
    "RVSN_REASON" character varying(200),
    "UPDATE_USER_ID" integer,
    "UPDATE_DATETIME" timestamp without time zone
);
 "   DROP TABLE public."ACC_BGT_RVSN";
       public         heap    postgres    false            �           1259    77583    ACC_BGT_TRANSFER    TABLE     R  CREATE TABLE public."ACC_BGT_TRANSFER" (
    "ID" integer NOT NULL,
    "FROM_ACC_ID" integer,
    "TO_ACC_ID" integer,
    "BGT_ALCTN_ID" integer,
    "TRNSFR_DATE_NP" character varying(10),
    "TRNSFR_REASON" character varying(200),
    "UPDATE_USER_ID" integer,
    "UPDATE_DATETIME" timestamp without time zone,
    "AMOUNT" real
);
 &   DROP TABLE public."ACC_BGT_TRANSFER";
       public         heap    postgres    false            �           1259    77368    ACC_BUDJET_SOURCE    TABLE     �   CREATE TABLE public."ACC_BUDJET_SOURCE" (
    "ID" integer NOT NULL,
    "MIN_ACC_ID" integer,
    "SOURCE_ID" integer,
    "AMOUNT" integer,
    "REMARKS" character varying(200)
);
 '   DROP TABLE public."ACC_BUDJET_SOURCE";
       public         heap    postgres    false            �           1259    78292    ACC_CASH_TRANS    TABLE     i  CREATE TABLE public."ACC_CASH_TRANS" (
    "CASH_TRANS_ID" integer NOT NULL,
    "VCHR_ID" integer,
    "VCHR_DATE_NEP" character varying(10),
    "DESCRIPTION" character varying(200),
    "DR_AMT" real DEFAULT '0'::real,
    "CR_AMT" real DEFAULT '0'::real,
    "IS_OF_LASTYEAR" character varying(2),
    "INCOME_EXP_TYPE_ID" integer,
    "BILL_ID" integer
);
 $   DROP TABLE public."ACC_CASH_TRANS";
       public         heap    postgres    false            �            1259    76239    ACC_CHEQUE_TYPES    TABLE     |   CREATE TABLE public."ACC_CHEQUE_TYPES" (
    "CHEQUE_TYPE_ID" smallint NOT NULL,
    "CHEQUE_TYPE" character varying(30)
);
 &   DROP TABLE public."ACC_CHEQUE_TYPES";
       public         heap    postgres    false            �            1259    76244    ACC_CURRENCTY    TABLE     �   CREATE TABLE public."ACC_CURRENCTY" (
    "ID" integer NOT NULL,
    "NP_NAME" text,
    "ENG_NAME" text,
    "SYMBOL" character varying(40)
);
 #   DROP TABLE public."ACC_CURRENCTY";
       public         heap    postgres    false            w           1259    77175    ACC_CURRENCTY_RATE    TABLE     �   CREATE TABLE public."ACC_CURRENCTY_RATE" (
    "ID" integer NOT NULL,
    "CURRENCY_ID" integer,
    "NP_DATE" character varying(15),
    "RATE" real
);
 (   DROP TABLE public."ACC_CURRENCTY_RATE";
       public         heap    postgres    false            �           1259    77733    ACC_DHRTI_BILL_DTL    TABLE     �  CREATE TABLE public."ACC_DHRTI_BILL_DTL" (
    "DHRTI_DTL_ID" integer NOT NULL,
    "DHRTI_MASTER_ID" integer,
    "BILL_NO" character varying(25),
    "BILL_DATE_NP" character varying(10),
    "COUNTER_ID" integer,
    "PERSON_ID" integer,
    "AMOUNT" real,
    "VCHR_ID" integer,
    "ACC_ID" integer,
    "VCHR_DATE_NP" character varying(10),
    "ORDER_IN_BILL" integer,
    "REMARKS" character varying(200),
    "BUDGET_SOURCE_ID" integer,
    "WORK_ID" integer
);
 (   DROP TABLE public."ACC_DHRTI_BILL_DTL";
       public         heap    postgres    false            �           1259    77753    ACC_DHRTI_BILL_MASTER    TABLE     �  CREATE TABLE public."ACC_DHRTI_BILL_MASTER" (
    "DHRTI_MASTER_ID" integer NOT NULL,
    "BILL_NO" character varying(25),
    "DESCRIPTION" character varying(200),
    "COUNTER_ID" integer,
    "PERSON_ID" integer,
    "BLL_DATE_NP" character varying(10),
    "CASH_AMT" real,
    "BANK_AMT" real,
    "VCHR_ID" integer,
    "VCHR_DATE_NP" character varying(10),
    "USERID" integer,
    "USERIDE" integer,
    "DATE_ENTRY_VS_DATE" character varying(10),
    "DATE_ENTRY_TIME" timestamp without time zone,
    "DATE_EDIT_TIME" timestamp without time zone,
    "NAME" character varying(100),
    "ADDRESS" character varying(100),
    "WARD_NO" smallint,
    "CANCEL_DATE" character varying(10),
    "CANCEL_REASON" character varying(200),
    "BILL_NO_MANUAL" character varying(25),
    "FISCAL_YEAR" character varying(10),
    "BILLTYPEID" integer,
    "SUB_MODULE_ID" integer,
    "WORK_ID" integer
);
 +   DROP TABLE public."ACC_DHRTI_BILL_MASTER";
       public         heap    postgres    false            �           1259    77603    ACC_EXPENSES_DETAILS    TABLE     B  CREATE TABLE public."ACC_EXPENSES_DETAILS" (
    "EXPENSE_ID" integer NOT NULL,
    "TRANS_TYPE_ID" integer,
    "PERSON_TYPE_ID" integer,
    "EMP_ID" integer,
    "PADADHIKARI_ID" integer,
    "ORG_ID" integer,
    "UC_ID" integer,
    "WARD_ID" integer,
    "WORK_ID" integer,
    "ACC_ID" integer,
    "DR_AMT" real,
    "CR_AMT" real,
    "VAT_AMT" real,
    "PAYMENT_SLIP_ID" integer,
    "VCHR_ID" integer,
    "VCHR_DATE_NP" character varying(10),
    "ORDER_IN_PAYMENT_SLIP" integer,
    "ADVEXPTYPE" character varying(1),
    "IS_OF_LAST_YEAR" character varying(1)
);
 *   DROP TABLE public."ACC_EXPENSES_DETAILS";
       public         heap    postgres    false            �            1259    76252    ACC_FUND_PROVIDR_MSTR    TABLE     J  CREATE TABLE public."ACC_FUND_PROVIDR_MSTR" (
    "PROVIDER_ID" integer NOT NULL,
    "NAME_NP" character varying(70) NOT NULL,
    "NAME_EN" character varying(50) NOT NULL,
    "PHONES" character varying(50),
    "EMAILS" character varying(50),
    "CHAIRMAN" character varying(70),
    "CONTACT_PERSON" character varying(70)
);
 +   DROP TABLE public."ACC_FUND_PROVIDR_MSTR";
       public         heap    postgres    false            �            1259    76257    ACC_INCOME_RATE    TABLE     �   CREATE TABLE public."ACC_INCOME_RATE" (
    "RATE_ID" integer NOT NULL,
    "ACC_ID" integer,
    "RATE" integer,
    "FISCAL_YEAR" character varying(10)
);
 %   DROP TABLE public."ACC_INCOME_RATE";
       public         heap    postgres    false            �            1259    76267    ACC_LASTYEAR_ADV_DETAILS    TABLE     \  CREATE TABLE public."ACC_LASTYEAR_ADV_DETAILS" (
    "ID" integer NOT NULL,
    "PAYMENT_ID" integer,
    "FISCAL_YEAR" character varying(15),
    "WORK_ID" integer,
    "VHCR_ID" integer,
    "ACC_ID" integer,
    "BUDGET_ACC_ID" integer,
    "BUDGET_SOURCE_ID" integer,
    "PAYMENT_TYPE_ID" integer,
    "PERSON_ID" integer,
    "DR_AMOUNT" real,
    "STATUS" character varying(2),
    "REMARKS" character varying(255),
    "ADD_USER_ID" integer,
    "ADD_DATE" character varying(15),
    "VOUCHER_NO" character varying(50),
    "VOUCHER_DATE" character varying(15),
    "LAST_YR_PESKI_ID" integer
);
 .   DROP TABLE public."ACC_LASTYEAR_ADV_DETAILS";
       public         heap    postgres    false            �            1259    76262    ACC_LAST_YR_PESKI    TABLE     �   CREATE TABLE public."ACC_LAST_YR_PESKI" (
    "SN" integer NOT NULL,
    "PERSON_TYPE_ID" integer,
    "PERSON_ID" integer,
    "ADVANCE_TYPE" character varying(1),
    "SUB_MODULE_ID" integer,
    "TOTAL_PES_REM" real
);
 '   DROP TABLE public."ACC_LAST_YR_PESKI";
       public         heap    postgres    false            �            1259    76272    ACC_ORG_MASTER    TABLE     �  CREATE TABLE public."ACC_ORG_MASTER" (
    "ORG_ID" integer NOT NULL,
    "NAME_NP" character varying(90),
    "NAME_EN" character varying(90),
    "ADDRESS" character varying(90),
    "PHONES" character varying(40),
    "EMAILS" character varying(100),
    "REG_NO" character varying(25),
    "VAT_NO" character varying(25),
    "PAN_NO" character varying(25),
    "ZONE" integer,
    "DISTRICT" integer,
    "VDC" integer,
    "MINISTRY" integer,
    "CODE" character varying(30),
    "HEAD" character varying(50),
    "MOBILE_NO" character varying(20),
    "RELATED_PERSON" character varying(100),
    "ORG_MASTER_ID" integer,
    "SAPATI" character varying(2),
    "ORC_ACC_TYPE_ID" integer
);
 $   DROP TABLE public."ACC_ORG_MASTER";
       public         heap    postgres    false            y           1259    77198    ACC_PADADHIKARI_MSTR    TABLE     M  CREATE TABLE public."ACC_PADADHIKARI_MSTR" (
    "PADADIKARI_ID" integer NOT NULL,
    "NAME_NP" character varying(70),
    "NAME_EN" character varying(50),
    "POST_ID" integer,
    "ADDRESS" character varying(50),
    "WARD_NO" integer,
    "ELECTED_DATE_NP" character varying(10),
    "QUALIFICATION" character varying(100),
    "MOBILE_NO" character varying(20),
    "LAST_NAME_NP" character varying(50),
    "LAST_NAME_EN" character varying(50),
    "TITLE" character varying(10),
    "GENDER" character varying(1),
    "RELIGION_ID" integer,
    "MOTHER_LANG_ID" integer,
    "DATE_OF_BIRTH" character varying(10),
    "PARENT_NAME" character varying(70),
    "P_OCUPATION" integer,
    "SPOUSE_NAME" character varying(70),
    "S_OCUPATION" integer,
    "GRANDFATHER_NAME" character varying(70),
    "GF_OCUPATION" integer,
    "MARRIED_STATUS" character varying(1),
    "NO_OF_SON" integer,
    "NO_OF_DAUGHTER" integer,
    "FIRST_APPOINT_DATE" character varying(10),
    "FIRST_APPOINT_POST_ID" integer,
    "CURRENT_POST_APPOINT_DATE" character varying(10),
    "RETIRE_DATE" character varying(10),
    "PRE_EXPERIENCE" character varying(50),
    "ZONE_ID" integer,
    "DISTRICT_ID" integer,
    "VDC_ID" integer,
    "TRACK_ID" integer,
    "STREET" character varying(70),
    "PHONES" character varying(50),
    "EMAILS" character varying(50),
    "MOBILE" character varying(50),
    "CITIZENSHIP_NO" character varying(25),
    "CITZN_ISSUED_DATE" character varying(10),
    "CITZN_ISSUED_DISTR_ID" integer,
    "IS_TOILET_IN_HOME" character varying(1),
    "SPECIAL_NOTES" character varying(150),
    "USER_ID" integer,
    "USER_IDE" integer,
    "DATA_ENTRY_VS_DATE" character varying(10),
    "DATA_ENTRY_AD_DATE" timestamp without time zone,
    "DATA_EDIT_AD_DATE" timestamp without time zone,
    "DATE_OF_BIRTH_AD" timestamp without time zone
);
 *   DROP TABLE public."ACC_PADADHIKARI_MSTR";
       public         heap    postgres    false            �            1259    76280    ACC_PADADHIKARI_POST    TABLE     �   CREATE TABLE public."ACC_PADADHIKARI_POST" (
    "POST_ID" integer NOT NULL,
    "NAME_NP" character varying(70),
    "NAME_EN" character varying(50),
    "DURATION_IN_YRS" integer,
    "POST_LEVEL" integer
);
 *   DROP TABLE public."ACC_PADADHIKARI_POST";
       public         heap    postgres    false            �           1259    77633    ACC_PAYMENT_CLEARANCE    TABLE     �   CREATE TABLE public."ACC_PAYMENT_CLEARANCE" (
    "ID" integer NOT NULL,
    "PAYMENT_ID" integer,
    "IS_OF_LAST_YEAR" character varying(1),
    "ACC_ID" integer,
    "BUDGET_ACC_ID" integer,
    "AMOUNT" real,
    "BUDGET_SOURCE_ID" integer
);
 +   DROP TABLE public."ACC_PAYMENT_CLEARANCE";
       public         heap    postgres    false            �            1259    76285    ACC_PAYMENT_CREDIT    TABLE     �   CREATE TABLE public."ACC_PAYMENT_CREDIT" (
    "ID" integer NOT NULL,
    "PAYMENT_ID" integer,
    "IS_OF_LAST_YEAR" character varying(1),
    "ACC_ID" integer,
    "BUDGET_ACC_ID" integer,
    "BUDGET_SOURCE_ID" integer,
    "AMOUNT" real
);
 (   DROP TABLE public."ACC_PAYMENT_CREDIT";
       public         heap    postgres    false            �           1259    78208    ACC_PAYMENT_DEDUCTION    TABLE       CREATE TABLE public."ACC_PAYMENT_DEDUCTION" (
    "ID" integer NOT NULL,
    "PAYMENT_ID" integer,
    "ACC_ID" integer,
    "BUDGET_ACC_ID" integer,
    "AMOUNT" real,
    "STATUS" character varying(1),
    "DEDUCTIONTYPE" character varying(5),
    "BUDGET_SOURCE_ID" integer
);
 +   DROP TABLE public."ACC_PAYMENT_DEDUCTION";
       public         heap    postgres    false            �           1259    78228    ACC_PAYMENT_DETAILS    TABLE     y  CREATE TABLE public."ACC_PAYMENT_DETAILS" (
    "PAYMENT_DETAIL_ID" integer NOT NULL,
    "PAYMENT_ID" integer,
    "TRANS_TYPE_ID" integer,
    "PERSON_TYPE_ID" integer,
    "EMP_ID" integer,
    "PADADHIKARI_ID" integer,
    "ORG_ID" integer,
    "UC_ID" integer,
    "WARD_ID" integer,
    "WORK_ID" integer,
    "ACC_ID" integer,
    "BUDGET_ACC_ID" integer,
    "DR_AMT" real DEFAULT '0'::real,
    "CR_AMT" real DEFAULT '0'::real,
    "VAT_AMT" real,
    "PAYMENT_SLIP_ID" integer,
    "VCHR_ID" integer,
    "VCHR_DATE_NP" character varying(10),
    "ORDER_IN_PAYMENT_SLIP" integer,
    "ADVEXPTYPE" character varying(1),
    "IS_OF_LAST_YEAR" character varying(1),
    "FISCAL_YEAR" character varying(10),
    "BUDGET_SOURCE_ID" integer,
    "SUB_MODULE_ID" integer,
    "ADVANCE_TYPE" character varying(1),
    "EXPIRE_DATE_NP" character varying(10),
    "SUPPLIER_ID" integer
);
 )   DROP TABLE public."ACC_PAYMENT_DETAILS";
       public         heap    postgres    false            �           1259    77781    ACC_PAYMENT_MASTER    TABLE     �  CREATE TABLE public."ACC_PAYMENT_MASTER" (
    "PAYMENT_ID" integer NOT NULL,
    "TRANS_TYPE_ID" integer,
    "PERSON_TYPE_ID" integer,
    "PERSON_ID" integer,
    "WORK_ID" integer,
    "BILL_NO" character varying(50),
    "BILL_AMT" real,
    "VAT_AMT" real,
    "PAYMENT_DESCRIPTION" character varying(100),
    "RETENTION_MONEY_EDUCTION" real,
    "CONTRACT_TAX_DEDUCTION" real,
    "INCOME_TAX_DEDUCTION" real,
    "LAST_YEARS_ADV_DEDUCTION" real,
    "VAT_DEDUCTION" real,
    "OTHER_DEDUCTION" real,
    "CHEQUE_PAYMENT" real,
    "CASH_PAYMENT" real,
    "ADV_CLEARED_FROM_BILL" real,
    "ADV_CLEARED_FROM_BANK" real,
    "ADV_CLEARED_FROM_CASH" real,
    "LY_ADV_CLEARED_FROM_BILL" real,
    "LY_ADV_CLEARED_FROM_BANK" real,
    "LY_ADV_CLEARED_FROM_CASH" real,
    "ADVEXPTYPE" character varying(1),
    "VCHR_ID" integer,
    "VCHR_DATE_NP" character varying(10),
    "FISCAL_YEAR" character varying(10),
    "SUB_MODULE_ID" integer,
    "ISPESKI" character varying(1),
    "DEDUCT_DEP_VCHR_ID" integer,
    "DEDUCT_DEP_VCHR_DATE_NEP" character varying(10),
    "ACC_DEDUCT_DEP_VCHR_ID" integer,
    "ACC_DEDUCT_DEP_VCHR_DATE" character varying(10),
    "EXPIRE_DATE_NP" character varying(10),
    "CR_AMOUNT" real,
    "SUBJECT_AREA_ID" integer
);
 (   DROP TABLE public."ACC_PAYMENT_MASTER";
       public         heap    postgres    false            �            1259    76288    ACC_RECEIVABLE    TABLE     _  CREATE TABLE public."ACC_RECEIVABLE" (
    "SN" integer,
    "TAXPAYERID" integer,
    "FISCALYEAR" character varying(10),
    "NETTAXAMOUNT" real,
    "FINEAMOUNT" real,
    "ADDITIONALCHARGES" real,
    "REDUCTIONALCHARGES" real,
    "TAXTYPE" character varying(5),
    "TYPE" integer,
    "VCHRID" integer,
    "VCHR_DATE" character varying(12)
);
 $   DROP TABLE public."ACC_RECEIVABLE";
       public         heap    postgres    false            �            1259    76291    ACC_SUB_MODULE_TYPE    TABLE     �  CREATE TABLE public."ACC_SUB_MODULE_TYPE" (
    "SUB_MODULE_ID" integer NOT NULL,
    "NAME_NP" character varying(70) NOT NULL,
    "NAME_EN" character varying(50) NOT NULL,
    "MODULE" character varying(2) NOT NULL,
    "CODE" character varying(50),
    "ISCAPITAL" integer,
    "BUDGET_ACC_NO" character varying(50),
    "ISEXPENCES" integer,
    "ACC_EXPENCES_CODE" character varying(50)
);
 )   DROP TABLE public."ACC_SUB_MODULE_TYPE";
       public         heap    postgres    false            �            1259    76296    ACC_TRANS_TYPE    TABLE     �   CREATE TABLE public."ACC_TRANS_TYPE" (
    "TYPE_ID" integer NOT NULL,
    "TYPE_CODE" character varying(10) NOT NULL,
    "NEP_NAME" character varying(70) NOT NULL,
    "ENG_NAME" character varying(50),
    "MODULE" character varying(2) NOT NULL
);
 $   DROP TABLE public."ACC_TRANS_TYPE";
       public         heap    postgres    false            �            1259    76301    ACC_UNAUTHORISED    TABLE     |  CREATE TABLE public."ACC_UNAUTHORISED" (
    "UNAUTHORISED_ID" integer NOT NULL,
    "SUB_MODULE_ID" integer,
    "WORK_ID" integer,
    "UNAUTHORISED_DAFA_ID" integer,
    "UNAUTHORISED_AMT" integer,
    "INSPECT_DATE" character varying(20),
    "INSPECT_DETAILS" character varying(200),
    "INSPECT_AMT" integer,
    "FILLEDBY_EMPID" integer,
    "VERIFIEDBY_EMPID" integer
);
 &   DROP TABLE public."ACC_UNAUTHORISED";
       public         heap    postgres    false            �            1259    76306    ACC_USER_COMITE_MSTR    TABLE     �  CREATE TABLE public."ACC_USER_COMITE_MSTR" (
    "ID" integer NOT NULL,
    "NEP_NAME" character varying(150),
    "ENG_NAME" character varying(70),
    "WARD" integer,
    "ADDRESS" character varying(90),
    "EMAIL" character varying(50),
    "PHONES" character varying(50),
    "CHAIRMAN" character varying(70),
    "CONCERN_PERSON" character varying(70),
    "MOBILE_NO" character varying(20)
);
 *   DROP TABLE public."ACC_USER_COMITE_MSTR";
       public         heap    postgres    false            �           1259    77811    ACC_VCHR_DETAILS    TABLE     R  CREATE TABLE public."ACC_VCHR_DETAILS" (
    "VCHR_DETAIL_ID" integer NOT NULL,
    "VCHR_ID" integer,
    "ACC_ID" integer,
    "DR_AMT" real DEFAULT '0'::real,
    "CR_AMT" real DEFAULT '0'::real,
    "VCHR_TYPE_ID" integer,
    "ID_FROM_SRC" integer,
    "ACC_TYPE" character varying(1) NOT NULL,
    "TRANS_TYPE_ID" integer,
    "VCHR_DATE_ENG" timestamp without time zone,
    "VCHR_DATE_NEP" character varying(10),
    "REMARKS" character varying(100),
    "IS_POSTED" character varying(1),
    "MODULE" character varying(2) NOT NULL,
    "SUB_MODULE_ID" integer NOT NULL,
    "BUDGET_SOURCE_ID" integer,
    "BANKID" integer,
    "BILL_ID" integer,
    "BUDGET_ACC_ID" integer,
    "ORG_ID" integer,
    "WORK_ID" integer,
    "IS_JAFAT" character varying(1),
    "EXPIRE_DATE_NP" character varying(20),
    "IS_GROUP" character varying(1)
);
 &   DROP TABLE public."ACC_VCHR_DETAILS";
       public         heap    postgres    false            {           1259    77224    ACC_VCHR_MASTER    TABLE     �  CREATE TABLE public."ACC_VCHR_MASTER" (
    "VCHR_ID" integer NOT NULL,
    "VCHR_NO" integer,
    "VCHR_DATE_NEP" character varying(10),
    "VCHR_TYPE_ID" integer,
    "NARRATION" character varying(200),
    "USER_ID" integer,
    "UPDATE_DATE" timestamp without time zone,
    "FISCALYEAR" character varying(10),
    "MODULE" character varying(2) NOT NULL,
    "IS_POSTED" character varying(1),
    "SUB_MODULE_ID" integer,
    "NAME_CHEQUE_PAYEE" character varying(100),
    "IS_OF_LAST_YEAR" character varying(1),
    "REMARKS" character varying(200),
    "CHEQUE_TYPE_ID" smallint,
    "FATHER_NAME" character varying(50),
    "GRAND_FATHER_NAME" character varying(50),
    "CONTACT_PHONE" character varying(50),
    "IS_NIKASH" character varying(1),
    "WARDNO" character varying(10),
    "PREP_BY" integer,
    "CHECK_BY" integer,
    "ACCEPT_BY" integer,
    "INTERNAL_LEKHA" character varying(50),
    "NIYAMIT_AMT" real,
    "ASULI_AMT" real,
    "VALID_AMT" real,
    "N_VALID_AMT" real
);
 %   DROP TABLE public."ACC_VCHR_MASTER";
       public         heap    postgres    false            �            1259    76314    ACC_VCHR_TYPE_MASTER    TABLE       CREATE TABLE public."ACC_VCHR_TYPE_MASTER" (
    "VCHR_TYPE_ID" integer NOT NULL,
    "NEP_NAME" character varying(100),
    "ENG_NAME" character varying(100),
    "MODULE" character varying(2) NOT NULL,
    "ISAUTOMATIC" character varying(1),
    "ISFIXED" character varying(1)
);
 *   DROP TABLE public."ACC_VCHR_TYPE_MASTER";
       public         heap    postgres    false            }           1259    77257    ACC_WORK_FUNDS_DETAIL    TABLE     �   CREATE TABLE public."ACC_WORK_FUNDS_DETAIL" (
    "FUND_DETAIL_ID" integer NOT NULL,
    "WORK_ID" integer,
    "PROVIDER_ID" integer,
    "FUNDED_AMT" real,
    "FUNDED_PERCENT" real,
    "ISJANASARAMDHA" integer,
    "ISOWNOFFICE" integer
);
 +   DROP TABLE public."ACC_WORK_FUNDS_DETAIL";
       public         heap    postgres    false            �            1259    76319    ACC_WORK_MASTER    TABLE     �  CREATE TABLE public."ACC_WORK_MASTER" (
    "WORK_ID" integer NOT NULL,
    "NAME_NP" character varying(90),
    "NAME_EN" character varying(50),
    "ESTIMATED_AMT" real,
    "VARIATION_AMT" real,
    "CORRECTED_AMT" real,
    "FINAL_ACTUAL_AMT_TOBE_PAID" real,
    "TOTAL_ACTUAL_COST" real,
    "AGREEMENT_PARTY" character varying(70),
    "AGREEMENT_AMT" real,
    "AGREEMENT_DATE" character varying(10),
    "AGREEMENT_EXPIRY_DATE" character varying(10),
    "WORK_COMPLETE_DATE" character varying(10),
    "MEASURE_BOOK_NO" character varying(70),
    "DEPOSIT_AMT" real,
    "BANK_GUARANTEE_AMT" real,
    "DEPOSIT_RELEASE_DATE" character varying(10),
    "DEPOSIT_RELEASED_DATE" character varying(10),
    "WARD_NO" integer,
    "IS_COMPLETED" character varying(1),
    "DEADLINE_DATE" character varying(10),
    "TP_NO" character varying(25),
    "BANKID" integer,
    "EMP_ID" integer,
    "PARTY_PERSONTYPEID" integer,
    "PARTY_ID" integer,
    "PERSON_PERSONTYPEID" integer,
    "PERSON_ID" integer,
    "DEPOSITS_ACC_ID" integer,
    "DEPOSITS_FORFEIT_ACC_ID" integer,
    "IS_KRAMAGAT" character varying(1),
    "YOJANA_NATUR_ID" integer,
    "AGREEMENT_SIGNING_PERSON" character varying(70)
);
 %   DROP TABLE public."ACC_WORK_MASTER";
       public         heap    postgres    false            �           1259    77843    ACC_WORK_PAYMNT_TRANS    TABLE     �  CREATE TABLE public."ACC_WORK_PAYMNT_TRANS" (
    "TRANS_ID" integer NOT NULL,
    "WORK_ID" integer,
    "PAYMENT_SLIP_ID" integer,
    "PERSON_TYPE_ID" integer,
    "EMP_ID" integer,
    "PADADHIKARI_ID" integer,
    "ORG_ID" integer,
    "UC_ID" integer,
    "BILL_AMT" real,
    "VAT_AMT" real,
    "VCHR_ID" integer,
    "VCHR_DATE_NP" character varying(10),
    "IS_OF_LAST_YEAR" character varying(1),
    "FISCAL_YEAR" character varying(10)
);
 +   DROP TABLE public."ACC_WORK_PAYMNT_TRANS";
       public         heap    postgres    false            �            1259    76329    APPLICATION_CONFIGURATION    TABLE     �   CREATE TABLE public."APPLICATION_CONFIGURATION" (
    "SN" smallint NOT NULL,
    "NAME_CONFIG" character varying(70),
    "VALUE_CONFIG" character varying(30)
);
 /   DROP TABLE public."APPLICATION_CONFIGURATION";
       public         heap    postgres    false            �            1259    76334 
   BANKMASTER    TABLE     @  CREATE TABLE public."BANKMASTER" (
    "BANKID" integer NOT NULL,
    "ENGNAME" character varying(100),
    "NEPNAME" character varying(100),
    "BANKCODE" character varying(50),
    "SUB_MODULE_ID" integer,
    "ADDRESS" character varying(100),
    "PHONES" character varying(40),
    "EMAILS" character varying(100),
    "ACCOUNTNUMBER" character varying(25),
    "BRANCHCODE" character varying(200),
    "TRANCODE" character varying(200),
    "CYCODE" character varying(200),
    "FINANCEL_INSTITUTE_ID" integer,
    "BRANCH" character varying(50),
    "BANKNAME" text
);
     DROP TABLE public."BANKMASTER";
       public         heap    postgres    false            �           1259    78162    BANKTRANSACTIONS    TABLE     y  CREATE TABLE public."BANKTRANSACTIONS" (
    "SN" integer NOT NULL,
    "BANKID" integer,
    "DESCRIPTION" text,
    "DRAMOUNT" real,
    "CRAMOUNT" real,
    "INCOMEEXPTYPEID" integer,
    "ISOFLASTYEAR" character varying(1),
    "VCHR_DATE_NP" character varying(10),
    "ORDERINPAYMENTSLIP" integer,
    "VCHR_ID" integer,
    "BILLID" integer,
    "MODULE" character varying(2),
    "SUBMODULE_TYPE_ID" integer,
    "DHRTI_MASTER_ID" integer,
    "EXP_SLIP_ID" integer,
    "PAYMENT_ORDER_NO" character varying(50),
    "CHEQUE_TYPE_ID" integer,
    "PAYEENAME" text,
    "BUDGET_SOURCE_ID" integer,
    "PAYEENAME_ENG" text
);
 &   DROP TABLE public."BANKTRANSACTIONS";
       public         heap    postgres    false            ~           1259    77272    BANK_BRANCH    TABLE     i  CREATE TABLE public."BANK_BRANCH" (
    "BRANCH_ID" integer NOT NULL,
    "BANKID" integer,
    "NEPNAME" character varying(200),
    "ENGNAME" character varying(200),
    "BRANCH_CODE" character varying(50),
    "ADDRESS" character varying(200),
    "EMAIL" character varying(100),
    "PHONE" character varying(25),
    "IS_PERMITTED" character varying(2)
);
 !   DROP TABLE public."BANK_BRANCH";
       public         heap    postgres    false            �            1259    76342    BUDJET_SOURCE    TABLE     x  CREATE TABLE public."BUDJET_SOURCE" (
    "ID" integer NOT NULL,
    "PARENT_ID" integer,
    "COUNTRY_ID" integer,
    "CODE" character varying(70),
    "EMAIL" character varying(50),
    "PHONE" character varying(50),
    "ADDRESS" character varying(100),
    "NEP_NAME" character varying(100),
    "ENG_NAME" character varying(100),
    "REMARKS" character varying(200)
);
 #   DROP TABLE public."BUDJET_SOURCE";
       public         heap    postgres    false            �            1259    76350    BUDJET_SUB_HEAD    TABLE     X  CREATE TABLE public."BUDJET_SUB_HEAD" (
    "ID" integer,
    "CODE" character varying(70),
    "MINISTRY_ID" integer,
    "MINISTRY_CODE" character varying(70),
    "PARENT_CODE" integer,
    "FISCAL_YEAR" character varying(70),
    "NEPNAME" character varying(70),
    "ENGNAME" character varying(70),
    "REMARKS" character varying(200)
);
 %   DROP TABLE public."BUDJET_SUB_HEAD";
       public         heap    postgres    false            �            1259    76356    BUSINESSMASTER_HISTORY    TABLE     �  CREATE TABLE public."BUSINESSMASTER_HISTORY" (
    "ID" integer,
    "BIZ_ID" integer,
    "NEPNAME" character varying(70),
    "BUSINESSGROUPID" integer,
    "TAXPAYERID" integer,
    "ADD_DATE" timestamp without time zone,
    "COMPUTER_NAME" character varying(100),
    "DATA_STATUS" character varying(20),
    "WINDOWS_USER" character varying(100),
    "TRAN_TIME" character varying(20)
);
 ,   DROP TABLE public."BUSINESSMASTER_HISTORY";
       public         heap    postgres    false            �           1259    78185    CASHTRANSACTION    TABLE     �  CREATE TABLE public."CASHTRANSACTION" (
    "SN" integer NOT NULL,
    "DESCRIPTION" text,
    "DRAMOUNT" integer,
    "CRAMOUNT" integer,
    "INCOMEEXPTYPEID" integer,
    "ISOFLASTYEAR" character varying(1),
    "VCHR_DATE_NP" character varying(10),
    "VCHR_ID" integer,
    "BILLID" integer,
    "MODULE" character varying(2),
    "SUBMODULE_TYPE_ID" integer,
    "DHRTI_MASTER_ID" integer,
    "EXP_SLIP_ID" integer,
    "BUDGET_SOURCE_ID" integer
);
 %   DROP TABLE public."CASHTRANSACTION";
       public         heap    postgres    false            �            1259    76359    CELEDGER20682069    TABLE     �  CREATE TABLE public."CELEDGER20682069" (
    "SN" integer,
    "IID" integer,
    "HOUSEID" integer,
    "CONSTRUCTIONTYPEID" integer,
    "CONSTRUCTIONID" integer,
    "TALANUMBER" integer,
    "TOTALAREA" integer,
    "RATEID" integer,
    "RATEPERUNIT" integer,
    "CALCULATEDVALUE" integer,
    "VSDATEOFMADE" character varying(10),
    "DEPPERCENT" integer,
    "DEPRECIATIONAMOUNT" integer,
    "OTHERPLUSINEVALUATIONS" integer,
    "OTHERMINUSINEVALUATIONS" integer,
    "OTHERPLUSMINUSDESCRIPTIONS" character varying(90),
    "NETCALCULATEDVALUE" integer,
    "NONCOMPLETIONREASONID" integer,
    "NONCOMPLETIONREASONS" character varying(90),
    "REMARKS" character varying(90),
    "SPACEMEASURINGUNIT" integer,
    "TAXED" integer
);
 &   DROP TABLE public."CELEDGER20682069";
       public         heap    postgres    false            �            1259    76362    COLLECTIONCOUNTERS    TABLE     H  CREATE TABLE public."COLLECTIONCOUNTERS" (
    "COUNTERID" integer NOT NULL,
    "NEPNAME" character varying(50),
    "COUNTERHEADID" integer,
    "WARDNO" integer,
    "LOCATION" character varying(50),
    "SPECIALNOTES" character varying(90),
    "CMPTR_NAME" character varying(50),
    "MACADDRESS" character varying(200)
);
 (   DROP TABLE public."COLLECTIONCOUNTERS";
       public         heap    postgres    false            �            1259    76367    CONSTANTVALUES    TABLE     u   CREATE TABLE public."CONSTANTVALUES" (
    "SN" integer,
    "VARNAME" character varying(50),
    "STRVALUE" text
);
 $   DROP TABLE public."CONSTANTVALUES";
       public         heap    postgres    false            �            1259    76373    CONTACTS    TABLE     �   CREATE TABLE public."CONTACTS" (
    "ID" integer NOT NULL,
    "NEPNAME" character varying(100),
    "ENGNAME" character varying(100),
    "CODE" character varying(50),
    "DISTRICTID" integer,
    "REMARKS" character varying(150)
);
    DROP TABLE public."CONTACTS";
       public         heap    postgres    false            �            1259    76378    COUNTRY    TABLE     �   CREATE TABLE public."COUNTRY" (
    "ID" integer,
    "NEPNAME" character varying(50) NOT NULL,
    "ENGNAME" character varying(50) NOT NULL,
    "CODE" character varying(50),
    "REMARKS" character varying(100)
);
    DROP TABLE public."COUNTRY";
       public         heap    postgres    false            �            1259    76381    DDC    TABLE     �   CREATE TABLE public."DDC" (
    "ID" integer,
    "NEPNAME" character varying(50) NOT NULL,
    "ENGNAME" character varying(50) NOT NULL,
    "CODE" character varying(50),
    "REMARKS" character varying(100),
    "DISTRICTID" integer
);
    DROP TABLE public."DDC";
       public         heap    postgres    false            �            1259    76384 
   DEV_REGION    TABLE     �   CREATE TABLE public."DEV_REGION" (
    "ID" integer,
    "NEPNAME" character varying(50) NOT NULL,
    "ENGNAME" character varying(50) NOT NULL,
    "CODE" character varying(50),
    "REMARKS" character varying(100)
);
     DROP TABLE public."DEV_REGION";
       public         heap    postgres    false            �            1259    76387    DISTRICT    TABLE     �   CREATE TABLE public."DISTRICT" (
    "DISTRICTID" integer,
    "NEPNAME" character varying(50) NOT NULL,
    "ENGNAME" character varying(50) NOT NULL,
    "CODE" character varying(50),
    "REMARKS" character varying(100),
    "ZONEID" integer
);
    DROP TABLE public."DISTRICT";
       public         heap    postgres    false            �            1259    76390    EMP_GRP    TABLE     �   CREATE TABLE public."EMP_GRP" (
    "ID" integer NOT NULL,
    "NEPNAME" character varying(80),
    "ENGNAME" character varying(80)
);
    DROP TABLE public."EMP_GRP";
       public         heap    postgres    false            �           1259    77648    FIREBRIGADESTATE    TABLE       CREATE TABLE public."FIREBRIGADESTATE" (
    "ID" integer NOT NULL,
    "NEPNAME" character varying(50),
    "SERVICECHARGERATE" integer,
    "MINIMUMSERVICECHARGE" integer,
    "ACC_ID" integer,
    "TYPE" smallint,
    "FISCAL_YEAR" character varying(10),
    "RATEID" integer
);
 &   DROP TABLE public."FIREBRIGADESTATE";
       public         heap    postgres    false            �            1259    76395    FISCALYEARS    TABLE     �   CREATE TABLE public."FISCALYEARS" (
    "SN" integer,
    "FISCALYEAR" character varying(9),
    "DATEFROM" character varying(10),
    "DATETO" character varying(10)
);
 !   DROP TABLE public."FISCALYEARS";
       public         heap    postgres    false            �            1259    76398    FYWISERENTDARRATE    TABLE     �   CREATE TABLE public."FYWISERENTDARRATE" (
    "ID" integer NOT NULL,
    "RATEID" integer,
    "RATENAME" character varying(100),
    "RENT_PER" real,
    "RENT_TYPEID" integer,
    "FISCAL_YEAR" character varying(10)
);
 '   DROP TABLE public."FYWISERENTDARRATE";
       public         heap    postgres    false            �            1259    76403    FYWISESANITATION_RATE    TABLE     P  CREATE TABLE public."FYWISESANITATION_RATE" (
    "ID" integer NOT NULL,
    "RATEID" integer,
    "GROUPID" integer,
    "SUBGROUPID" integer,
    "ROAD_TYPEID" integer,
    "RATENAME" text,
    "RATE" real,
    "FISCAL_YEAR" character varying(10),
    "AREA_UPTO" integer,
    "FOR_EACH_AREA" integer,
    "EACH_AREA_RATE" integer
);
 +   DROP TABLE public."FYWISESANITATION_RATE";
       public         heap    postgres    false            �            1259    76419    IMISRole    TABLE     �   CREATE TABLE public."IMISRole" (
    "Id" text NOT NULL,
    "Name" character varying(256),
    "NormalizedName" character varying(256),
    "ConcurrencyStamp" text
);
    DROP TABLE public."IMISRole";
       public         heap    postgres    false            �           1259    77302    IMISRoleClaim    TABLE     �   CREATE TABLE public."IMISRoleClaim" (
    "Id" integer NOT NULL,
    "RoleId" text NOT NULL,
    "ClaimType" text,
    "ClaimValue" text
);
 #   DROP TABLE public."IMISRoleClaim";
       public         heap    postgres    false            �           1259    77300    IMISRoleClaim_Id_seq    SEQUENCE     �   ALTER TABLE public."IMISRoleClaim" ALTER COLUMN "Id" ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public."IMISRoleClaim_Id_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    385            �           1259    77516    IMISUserClaim    TABLE     �   CREATE TABLE public."IMISUserClaim" (
    "Id" integer NOT NULL,
    "UserId" text NOT NULL,
    "ClaimType" text,
    "ClaimValue" text
);
 #   DROP TABLE public."IMISUserClaim";
       public         heap    postgres    false            �           1259    77514    IMISUserClaim_Id_seq    SEQUENCE     �   ALTER TABLE public."IMISUserClaim" ALTER COLUMN "Id" ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public."IMISUserClaim_Id_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    404            �           1259    77529    IMISUserLogin    TABLE     �   CREATE TABLE public."IMISUserLogin" (
    "LoginProvider" character varying(128) NOT NULL,
    "ProviderKey" character varying(128) NOT NULL,
    "ProviderDisplayName" text,
    "UserId" text NOT NULL
);
 #   DROP TABLE public."IMISUserLogin";
       public         heap    postgres    false            �           1259    77542    IMISUserRole    TABLE     _   CREATE TABLE public."IMISUserRole" (
    "UserId" text NOT NULL,
    "RoleId" text NOT NULL
);
 "   DROP TABLE public."IMISUserRole";
       public         heap    postgres    false            �           1259    77560    IMISUserToken    TABLE     �   CREATE TABLE public."IMISUserToken" (
    "UserId" text NOT NULL,
    "LoginProvider" character varying(128) NOT NULL,
    "Name" character varying(128) NOT NULL,
    "Value" text
);
 #   DROP TABLE public."IMISUserToken";
       public         heap    postgres    false            �           1259    77863    INCOMEBILLDETAILS    TABLE     |  CREATE TABLE public."INCOMEBILLDETAILS" (
    "SN" integer NOT NULL,
    "BILLID" integer,
    "BILLNO" character varying(25),
    "BILLDATE" character varying(10),
    "COUNTERID" integer,
    "PERSONID" integer,
    "ACCODE" integer,
    "AMOUNT" integer,
    "VCHR_DATE_NP" character varying(10),
    "ORDERINBILL" integer,
    "REMARKS" character varying(200),
    "VCHR_ID" integer,
    "ACC_ID" integer,
    "FISCAL_YEAR" character varying(10),
    "PROJECT" character varying(10),
    "TAXADDTNLID" integer,
    "TAX_TYPE" character varying(5),
    "QTY" integer,
    "BUDGET_SOURCE_ID" integer,
    "BACKUP_PERSONID" integer
);
 '   DROP TABLE public."INCOMEBILLDETAILS";
       public         heap    postgres    false            �            1259    76427    INCOMEBILLDETAILS_HISTORY    TABLE     �  CREATE TABLE public."INCOMEBILLDETAILS_HISTORY" (
    "SN" integer,
    "SN_INCOMEBILLDTL" integer,
    "BILLID" integer,
    "BILLNO" character varying(25),
    "BILLDATE" character varying(10),
    "COUNTERID" integer,
    "PERSONID" integer,
    "ACCODE" integer,
    "AMOUNT" integer,
    "VRNO" integer,
    "VCHR_DATE_NP" character varying(10),
    "ORDERINBILL" integer,
    "REMARKS" character varying(200),
    "VCHR_ID" integer,
    "ACC_ID" integer,
    "FISCAL_YEAR" character varying(10),
    "PROJECT" character varying(10),
    "TAXADDTNLID" integer,
    "QTY" integer,
    "BUDGET_SOURCE_ID" integer,
    "TAX_TYPE" character varying(5),
    "BACKUP_PERSONID" integer,
    "ADD_DATE" timestamp without time zone,
    "COMPUTER_NAME" character varying(100),
    "DATA_STATUS" character varying(20),
    "WINDOWS_USER" character varying(100),
    "TRAN_TIME" character varying(20)
);
 /   DROP TABLE public."INCOMEBILLDETAILS_HISTORY";
       public         heap    postgres    false            �           1259    77878    INCOMEBILLMASTER    TABLE     �  CREATE TABLE public."INCOMEBILLMASTER" (
    "SN" integer NOT NULL,
    "BILLNO" character varying(25),
    "DESCRIPTION" text,
    "COUNTERID" integer,
    "PERSONID" integer,
    "BILLDATE" character varying(10),
    "CASHAMOUNT" integer,
    "BANKAMOUNT" integer,
    "VCHR_ID" integer,
    "VCHR_DATE_NP" character varying(10),
    "USERID" integer,
    "USERIDE" integer,
    "DATAENTRYVSDATE" character varying(10),
    "DATAENTRYADDATETIME" timestamp without time zone,
    "DATAEDITADDATETIME" timestamp without time zone,
    "BILLTYPEID" integer,
    "TAXINCOMETYPE" character varying(10),
    "NAME" text,
    "ADDRESS" character varying(100),
    "WARD_NO" smallint,
    "CANCEL_DATE" character varying(10),
    "CANCEL_REASON" character varying(200),
    "BILL_NO_MANUAL" character varying(25),
    "FISCAL_YEAR" character varying(10),
    "PROJECT" character varying(10),
    "SUB_MODULE_ID" integer,
    "CURRENCY_ID" integer,
    "BACKUP_PERSONID" integer
);
 &   DROP TABLE public."INCOMEBILLMASTER";
       public         heap    postgres    false            �            1259    76433    INV_APPLICANT_RATE    TABLE     �   CREATE TABLE public."INV_APPLICANT_RATE" (
    "ID" integer NOT NULL,
    "APPLICANTID" integer,
    "ITEM_DETAIL_ID" integer,
    "AMOUNT" real
);
 (   DROP TABLE public."INV_APPLICANT_RATE";
       public         heap    postgres    false            �            1259    76438 	   INV_BRAND    TABLE     �   CREATE TABLE public."INV_BRAND" (
    "BRAND_ID" integer NOT NULL,
    "NAME_NP" character varying(50) NOT NULL,
    "NAME_EN" character varying(50),
    "IS_ACTIVE" character varying(1)
);
    DROP TABLE public."INV_BRAND";
       public         heap    postgres    false            �            1259    76443    INV_DEPLIST    TABLE     �  CREATE TABLE public."INV_DEPLIST" (
    "ID" integer NOT NULL,
    "FISCALYEAR" character varying(10),
    "DAKHILA_ID" integer,
    "ITEM_ID" integer,
    "QTY" real,
    "PURCHASE_DATE" character varying(15),
    "PURCHASE_AMT" real,
    "BRAND_ID" integer,
    "SPEC_ID" integer,
    "UNIT_ID" integer,
    "DEPRE_DURATON" real,
    "DEPRE_PER" integer,
    "DEPRE_AMT" real,
    "MAX_DEPRE_AMT" real,
    "MIN_DEPRE_AMT" real,
    "DEDUCT_AMT" real,
    "NET_AMT" real
);
 !   DROP TABLE public."INV_DEPLIST";
       public         heap    postgres    false            �            1259    76448    INV_DEPRECIATION    TABLE     >  CREATE TABLE public."INV_DEPRECIATION" (
    "ID" integer NOT NULL,
    "FISCALYEAR" character varying(10),
    "DAKHILA_ID" integer,
    "ITEM_ID" integer,
    "BRAND_ID" integer,
    "SPEC_ID" integer,
    "UNIT_ID" integer,
    "QTY" real,
    "ORGINAL_RATE" real,
    "DEPRE_RATE" real,
    "DEPRE_PER" integer
);
 &   DROP TABLE public."INV_DEPRECIATION";
       public         heap    postgres    false            �            1259    76453    INV_DEPT    TABLE     �   CREATE TABLE public."INV_DEPT" (
    "DEPT_ID" integer NOT NULL,
    "NAME_NP" character varying(50) NOT NULL,
    "NAME_EN" character varying(50),
    "OFFICE_ID" integer,
    "IS_ACTIVE" character varying(1)
);
    DROP TABLE public."INV_DEPT";
       public         heap    postgres    false            �           1259    78329    INV_GOODS_ADJUST    TABLE     �  CREATE TABLE public."INV_GOODS_ADJUST" (
    "ID" integer NOT NULL,
    "DAKHILA_ID" integer,
    "GD_ADJ_ID" character varying(10) NOT NULL,
    "BUDGET_YEAR" character varying(10),
    "MONTH" character varying(10),
    "ITEM_ID" integer,
    "ITEM_TYPE" integer,
    "SPEC_ID" integer,
    "BRAND_ID" integer,
    "ADJ_QTY" real,
    "ADJ_TYPE_ID" integer,
    "ITEM_ADJ_RATE" real,
    "ADJ_DT_NP" character varying(10),
    "ADJ_DT_ENG" timestamp without time zone,
    "REMARKS" character varying(100),
    "PREP_BY" integer,
    "PREP_DT_NP" character varying(10),
    "PREP_DT_ENG" timestamp without time zone,
    "ACCEPT_BY" integer,
    "ACCEPT_DT_NP" character varying(10),
    "ACCEPT_DT_ENG" timestamp without time zone
);
 &   DROP TABLE public."INV_GOODS_ADJUST";
       public         heap    postgres    false            �           1259    78808    INV_GOODS_REC_DETL    TABLE     )  CREATE TABLE public."INV_GOODS_REC_DETL" (
    "ID" integer NOT NULL,
    "GOODS_MASTER_ID" integer,
    "ITEM_ID" integer,
    "UNIT_ID" integer,
    "BRAND_ID" integer,
    "SPEC_ID" integer,
    "PUR_QTY" real,
    "RECV_QTY" real,
    "RATE" real,
    "WHETHER_TAX" character varying(1),
    "TAX_PER_UNIT_AMT" real,
    "DISC_AMT" real,
    "OTHER_EXPENCES_AMT" real,
    "NET_AMT" real,
    "REMARKS" character varying(100),
    "ISNUMBERED" character varying(1) DEFAULT 'N'::character varying,
    "DAKHILA_DT_ENG" timestamp without time zone
);
 (   DROP TABLE public."INV_GOODS_REC_DETL";
       public         heap    postgres    false            �           1259    78359    INV_GOODS_REC_MAST    TABLE     �  CREATE TABLE public."INV_GOODS_REC_MAST" (
    "ID" integer NOT NULL,
    "DAKHILA_ID" character varying(10) NOT NULL,
    "PUR_MASTER_ID" integer,
    "REPAIR_ID" integer,
    "DAKHILA_DT" character varying(10),
    "WAREHOUSE_ID" integer,
    "INV_BILL_NO" character varying(10),
    "INV_DATE" character varying(10),
    "DETAILS_NEP" character varying(200),
    "DETAILS_ENG" character varying(200),
    "PREP_BY" integer,
    "PREP_DT" character varying(10),
    "CHECK_BY" integer,
    "CHECK_DT" character varying(10),
    "ACCEPT_BY" integer,
    "ACCEPT_DT" character varying(10),
    "DAKHILA_DT_ENG" timestamp without time zone,
    "INV_DATE_ENG" timestamp without time zone,
    "PREP_DT_ENG" timestamp without time zone,
    "CHECK_DT_ENG" timestamp without time zone,
    "ACCEPT_DT_ENG" timestamp without time zone,
    "FISCAL_YEAR" character varying(10),
    "PAYMENT_ID" integer
);
 (   DROP TABLE public."INV_GOODS_REC_MAST";
       public         heap    postgres    false            �            1259    76458    INV_INCREASE_DECREASE    TABLE     l  CREATE TABLE public."INV_INCREASE_DECREASE" (
    "ID" integer NOT NULL,
    "NUM_ID" integer,
    "DAKHILA_ID" integer,
    "ITEM_ID" integer,
    "BRAND_ID" integer,
    "SPEC_ID" integer,
    "UNIT_ID" integer,
    "PURCHASE_DATE" character varying(30),
    "STOCK_QTY" real,
    "AMOUNT" real,
    "SCAP_AMOUNT" real,
    "FISCALYEAR" character varying(30)
);
 +   DROP TABLE public."INV_INCREASE_DECREASE";
       public         heap    postgres    false            �            1259    76463    INV_ISSUE_DAKHILA    TABLE     $  CREATE TABLE public."INV_ISSUE_DAKHILA" (
    "ID" integer NOT NULL,
    "ITEM_ID" integer,
    "SPEC_ID" integer,
    "BRAND_ID" integer,
    "UNIT_ID" integer,
    "ISSUE_DETAIL_ID" integer,
    "ISSU_MASTER_ID" integer,
    "DAKHILA_ID" integer,
    "ISSUE_NO" real,
    "REMARKS" text
);
 '   DROP TABLE public."INV_ISSUE_DAKHILA";
       public         heap    postgres    false            �           1259    77921    INV_ISSUE_DETAIL    TABLE     �  CREATE TABLE public."INV_ISSUE_DETAIL" (
    "ID" integer NOT NULL,
    "ISSUE_MAST_ID" integer,
    "ITEM_ID" integer,
    "SPEC_ID" integer,
    "BRAND_ID" integer,
    "ITEM_TYPE" integer,
    "ITEM_REQ_NO" real,
    "ITEM_ISSUE_NO" real,
    "ISSUE_DT" character varying(10),
    "DELIVERY_STATUS" character varying(1),
    "REMARKS" character varying(100),
    "ISSUE_DT_ENG" timestamp without time zone
);
 &   DROP TABLE public."INV_ISSUE_DETAIL";
       public         heap    postgres    false            �           1259    78919    INV_ISSUE_MASTER    TABLE     �  CREATE TABLE public."INV_ISSUE_MASTER" (
    "ID" integer NOT NULL,
    "ISSUE_NO" character varying(10) NOT NULL,
    "REQUEST_ID" integer,
    "ISSUE_BY" integer,
    "ISSUE_RECEIVE" integer,
    "RECEIVE_EMP_ID" integer,
    "ISSUE_DT" character varying(10),
    "REMARKS" character varying(100),
    "ISSUE_BY_CAT" character varying(30),
    "HO_NAME" character varying(30),
    "HO_POST" character varying(30),
    "PREP_BY" integer,
    "PREP_DT" character varying(10),
    "CHECK_BY" integer,
    "CHECK_DT" character varying(10),
    "ACCEPT_BY" integer,
    "ACCEPT_DT" character varying(10),
    "BUDGET_YEAR" character varying(10),
    "TYPE" integer,
    "TRANSFER_DECISION_NO" character varying(50),
    "TRANSFER_DECISION_DATE" character varying(12)
);
 &   DROP TABLE public."INV_ISSUE_MASTER";
       public         heap    postgres    false            �            1259    76471    INV_ITEM_ADJ_TYPE    TABLE     �   CREATE TABLE public."INV_ITEM_ADJ_TYPE" (
    "ID" integer NOT NULL,
    "NAME_NP" character varying(50) NOT NULL,
    "NAME_EN" character varying(50),
    "ADD_SUB" character varying(15),
    "ADJ_TYPE" character varying(30)
);
 '   DROP TABLE public."INV_ITEM_ADJ_TYPE";
       public         heap    postgres    false            �            1259    76476    INV_ITEM_CATEGORY    TABLE     7  CREATE TABLE public."INV_ITEM_CATEGORY" (
    "ID" integer NOT NULL,
    "NAME_NP" character varying(50) NOT NULL,
    "NAME_EN" character varying(50),
    "PARENT_ID" integer,
    "GRP_LEVEL" integer,
    "IS_HEADER" integer,
    "ISEXP" smallint,
    "ISLAST" smallint,
    "CODE" character varying(10),
    "UNIT" integer,
    "MINL" integer,
    "MAXL" integer,
    "RMINL" integer,
    "RMAXL" integer,
    "DEPRECIATION_PER" numeric,
    "DEPRECIATION_MIN" numeric,
    "DEPRECIATION_MAX" numeric,
    "REMARKS" character varying(100),
    "ITEM_ID" integer
);
 '   DROP TABLE public."INV_ITEM_CATEGORY";
       public         heap    postgres    false            �           1259    78839    INV_ITEM_DETAILS    TABLE       CREATE TABLE public."INV_ITEM_DETAILS" (
    "ITEM_DTL_ID" integer NOT NULL,
    "ITEM_ID" integer NOT NULL,
    "BRAND_ID" integer NOT NULL,
    "SPEC_ID" integer NOT NULL,
    "QTY" real,
    "ITEM_RATE" real,
    "ITEM_STATUS" character varying(10),
    "BUDGET_YEAR" character varying(10),
    "DAKHILA_ID" integer,
    "ENTRY_DT" character varying(10),
    "ISSUE_ID" integer,
    "ISSUE_DT" character varying(10),
    "GD_ADJ_ID" integer,
    "ADJ_TYPE" integer,
    "LILAM_ID" integer,
    "LILAM_DT" character varying(10),
    "STOK_RT_ID" integer,
    "STOK_RT_DT" character varying(10),
    "ENGINE_NO" character varying(20),
    "CHASIS_NO" character varying(20),
    "MODEL_NO" character varying(20),
    "REG_NO" character varying(20),
    "WEIGHT_VEH" integer,
    "PREP_BY" integer,
    "PREP_DT" character varying(10),
    "CHECK_BY" integer,
    "CHECK_DT" character varying(10),
    "ACCEPT_BY" integer,
    "ACCEPT_DT" character varying(10),
    "UNIT" integer,
    "REL_UNIT" character varying(20),
    "REL_QTY" real
);
 &   DROP TABLE public."INV_ITEM_DETAILS";
       public         heap    postgres    false            �           1259    77335    INV_ITEM_MST    TABLE     �  CREATE TABLE public."INV_ITEM_MST" (
    "ITEM_ID" integer NOT NULL,
    "NAME_NP" character varying(50) NOT NULL,
    "NAME_EN" character varying(50),
    "UNIT_ID" integer,
    "ITEM_MAIN_CLASS" integer,
    "ITEM_TYPE" integer,
    "ITEM_NATURE" integer,
    "MAXL" integer,
    "MINL" integer,
    "RMAXL" integer,
    "RMINL" integer,
    "GUSSAGE" integer,
    "SIZES" integer,
    "COUNTRYID" integer,
    "COMPANYNAME" character varying(50),
    "SOURCE" character varying(50),
    "REMARKS" character varying(100),
    "CODE" character varying(50),
    "KITTA_NO" character varying(150),
    "LAND_LOCATION" character varying(150),
    "CONSTRUCTONTYPE" character varying(150),
    "DEPRECIATION" real,
    "MINRATE" real,
    "DEPMAXRATE" real,
    "PROPERTYTYPE" integer,
    "LAND_AREA_INSQ_FEETS" integer,
    "AREA_INSQ_FEETS" integer,
    "LAND_UNIT_RATE" integer,
    "LAND_MARKET_RATE" integer,
    "LANDID" integer,
    "ACC_ID" integer,
    "BUDGET_ACC_ID" integer,
    "VEHICLE_PARTS_ID" integer
);
 "   DROP TABLE public."INV_ITEM_MST";
       public         heap    postgres    false            �            1259    76484    INV_ITEM_SPEC    TABLE     �   CREATE TABLE public."INV_ITEM_SPEC" (
    "SPEC_ID" integer NOT NULL,
    "NAME_NP" character varying(50) NOT NULL,
    "NAME_EN" character varying(50),
    "IS_ACTIVE" character varying(1)
);
 #   DROP TABLE public."INV_ITEM_SPEC";
       public         heap    postgres    false            �           1259    78382    INV_ITEM_STATUSCHECK    TABLE     �  CREATE TABLE public."INV_ITEM_STATUSCHECK" (
    "ID" integer NOT NULL,
    "ITEM_ID" integer,
    "SPEC_ID" integer,
    "BRAND_ID" integer,
    "INSP_ST_DATE" character varying(10),
    "INSP_ST_DATE_ENG" timestamp without time zone,
    "INSP_ED_DATE" character varying(10),
    "INSP_ED_DATE_ENG" timestamp without time zone,
    "STK_MST_COUNT" integer,
    "COUNT_YES_NO" character varying(2),
    "STK_CUR_COUNT" integer,
    "COUNT_UP_DOWN" character varying(2),
    "INSPECT_DATE" character varying(10),
    "INSPECT_DATE_ENG" timestamp without time zone,
    "UP_DOWN_DETAIL" character varying(30),
    "REMARKS" character varying(100),
    "PREP_BY" integer,
    "PREP_DATE" character varying(10),
    "PREP_DATE_ENG" timestamp without time zone,
    "TALLY_BY" integer,
    "CHECKED_DATE" character varying(10),
    "CHECK_QTY" integer,
    "RATE" integer,
    "CHECKED_DATE_ENG" timestamp without time zone,
    "ACCEPTED_BY" integer,
    "ACCEPTED_DATE" character varying(10),
    "ACCEPTED_DATE_ENG" timestamp without time zone,
    "FISICAL_YEAR" character varying(10),
    "IS_ACTIVE" character varying(2),
    "UP_DOWN_NO" integer,
    "CHECK_STATUS" character varying(1)
);
 *   DROP TABLE public."INV_ITEM_STATUSCHECK";
       public         heap    postgres    false            �           1259    77325    INV_LILAMAPPDETAILS    TABLE     "  CREATE TABLE public."INV_LILAMAPPDETAILS" (
    "ID" integer NOT NULL,
    "LILAMAPPLIID" integer,
    "DAKHILAID" integer,
    "NIKASHAID" integer,
    "ITEMID" integer,
    "UNITID" integer,
    "BRANDID" integer,
    "SPECID" integer,
    "LILAMQTY" integer,
    "LILAMTOTALAMT" real
);
 )   DROP TABLE public."INV_LILAMAPPDETAILS";
       public         heap    postgres    false            �            1259    76489    INV_LILAM_APPMASTER    TABLE     i  CREATE TABLE public."INV_LILAM_APPMASTER" (
    "ID" integer NOT NULL,
    "APPNO" integer,
    "PROJID" integer,
    "APPLYLILAMID" integer,
    "ORGAPPLICANTNAME" character varying(50),
    "ORGAPPLICANTPOST" character varying(50),
    "APPLYDATE" character varying(10),
    "APPLYENGDATE" timestamp without time zone,
    "REMARKS" character varying(150)
);
 )   DROP TABLE public."INV_LILAM_APPMASTER";
       public         heap    postgres    false            �            1259    76494    INV_LILAM_DETAIL    TABLE     �  CREATE TABLE public."INV_LILAM_DETAIL" (
    "ID" integer NOT NULL,
    "MINIMUMRATE" real,
    "LILAM_ID" integer,
    "DAKHILAID" integer,
    "NIKASHAID" integer,
    "ITEM_ID" integer,
    "UNIT_ID" integer,
    "SPEC_ID" integer,
    "BRAND_ID" integer,
    "ITEM_TYPE" integer,
    "ITEM_ISSUE_NO" real,
    "TOTAL_IN_STOCK" real,
    "DEP_AMT" real,
    "ISSUE_DT" character varying(10),
    "DELIVERY_STATUS" character varying(1),
    "REMARKS" text,
    "ISSUE_DT_ENG" timestamp without time zone
);
 &   DROP TABLE public."INV_LILAM_DETAIL";
       public         heap    postgres    false            �            1259    76502    INV_LILAM_MAST    TABLE     ^  CREATE TABLE public."INV_LILAM_MAST" (
    "ID" integer NOT NULL,
    "LILAM_NO" character varying(50) NOT NULL,
    "ISSUE_BY" integer,
    "LILAMTYPE" integer,
    "RECEIVE_BY" integer,
    "RECEIVE_PERSON_NAME" character varying(50),
    "RECIVE_PERSON_POST" character varying(50),
    "REMARKS" text,
    "PREP_BY" integer,
    "CHECK_BY" integer,
    "ISSUE_DT" character varying(10),
    "ACCEPT_BY" integer,
    "ACCEPT_DT" character varying(10),
    "PREP_DT" character varying(10),
    "CHECK_DT" character varying(10),
    "ISSUE_DT_ENG" timestamp without time zone,
    "PREP_DT_ENG" timestamp without time zone,
    "CHECK_DT_ENG" timestamp without time zone,
    "FISCAL_YEAR" character varying(10),
    "ACCEPT_DT_ENG" timestamp without time zone,
    "PAGENO" character varying(200),
    "REGISTERNO" character varying(200),
    "PUBLISH_DATE" character varying(20),
    "DESCRIPTION" character varying(200),
    "NEWSPAPER_NAME" character varying(200),
    "PERNEWS_RATE" real,
    "ACCEPT_PERCENT" real,
    "BANKID" integer,
    "VALID_DAYS" integer,
    "FISCALYEAR_CHUKTA" character varying(10)
);
 $   DROP TABLE public."INV_LILAM_MAST";
       public         heap    postgres    false            �            1259    76510    INV_LILAM_REC_LIST    TABLE     �   CREATE TABLE public."INV_LILAM_REC_LIST" (
    "ID" integer,
    "REC_DATE_NP" character varying(10),
    "APPLICANTID" integer,
    "EMP_ID" integer,
    "USER_ID" integer
);
 (   DROP TABLE public."INV_LILAM_REC_LIST";
       public         heap    postgres    false                        1259    76513    INV_ORG_TYPE    TABLE     �   CREATE TABLE public."INV_ORG_TYPE" (
    "ID" integer NOT NULL,
    "NAME_NP" character varying(50) NOT NULL,
    "NAME_EN" character varying(50),
    "IS_ACTIVE" character varying(1)
);
 "   DROP TABLE public."INV_ORG_TYPE";
       public         heap    postgres    false                       1259    76518    INV_PROJECT    TABLE     �   CREATE TABLE public."INV_PROJECT" (
    "PROJECT_ID" integer NOT NULL,
    "NAME_NP" character varying(50) NOT NULL,
    "NAME_EN" character varying(50),
    "IS_ACTIVE" character varying(1)
);
 !   DROP TABLE public."INV_PROJECT";
       public         heap    postgres    false                       1259    76523    INV_PUR_MAST_PLAN    TABLE     �  CREATE TABLE public."INV_PUR_MAST_PLAN" (
    "ID" integer NOT NULL,
    "NAME_NP" character varying(70) NOT NULL,
    "NAME_EN" character varying(50),
    "PKG_NO" character varying(20),
    "APPROX_AMT" real,
    "BUDGET1YEAR" real,
    "BUDGET2YEAR" real,
    "BUDGET3YEAR" real,
    "PUR_TYPE" character varying(10),
    "AGREEMENT_TYPE" character varying(10),
    "BUDGET_RESOURCE" character varying(30),
    "WORK_ST_DATE" character varying(10),
    "WORK_END_DATE" character varying(10),
    "WORK_ST_DATE_AD" timestamp without time zone,
    "WORK_END_DATE_AD" timestamp without time zone,
    "BUDGET_YEAR" character varying(10),
    "REMARKS" character varying(100)
);
 '   DROP TABLE public."INV_PUR_MAST_PLAN";
       public         heap    postgres    false            �           1259    78884    INV_PUR_ORDER_DETL    TABLE     t  CREATE TABLE public."INV_PUR_ORDER_DETL" (
    "ID" integer NOT NULL,
    "PUR_MST_ID" integer,
    "ITEM_ID" integer,
    "UNIT_ID" integer,
    "SPEC_ID" integer,
    "BRAND_ID" integer,
    "ITEM_TYPE" integer,
    "QTY" real,
    "ITEM_RATE" real,
    "TOTAL_AMT" real,
    "TAX_AMT" real,
    "REMARKS" character varying(100),
    "ISDAKHILA" character varying(1)
);
 (   DROP TABLE public."INV_PUR_ORDER_DETL";
       public         heap    postgres    false            �           1259    78417    INV_PUR_ORDER_MAST    TABLE     �  CREATE TABLE public."INV_PUR_ORDER_MAST" (
    "ID" integer NOT NULL,
    "PUR_ORDER_NO" character varying(50),
    "REPAIR_ORDER_NO" character varying(50),
    "LETTER_ORDER_NO" character varying(50),
    "CUSTOM_ORDER_NO" character varying(50),
    "PUR_TYPE" integer,
    "PUR_ORDER_TYPE" integer,
    "SUPP_ID" integer,
    "REQ_ID" integer,
    "BUDGET_YEAR" character varying(10),
    "RETURN_ITEM_DT" character varying(10),
    "RETURN_ITEM_DT_ENG" timestamp without time zone,
    "PREPARED_BY" integer,
    "PREPARED_DT" character varying(10),
    "PREPARED_DT_ENG" timestamp without time zone,
    "CHECKED_BY" integer,
    "CHECKED_DT" character varying(10),
    "CHECKED_DT_ENG" timestamp without time zone,
    "ACCEPTED_BY" integer,
    "ACCEPTED_DT" character varying(10),
    "ACCEPTED_DT_ENG" timestamp without time zone,
    "PUR_ORDER_DT" character varying(10),
    "DAKHILA_LAST_ENTRY_DT" character varying(12),
    "PUR_ORDER_DT_ENG" timestamp without time zone,
    "ISDAKHILA" character varying(1),
    "REMARKS" character varying(255),
    "ACCOUNTID" integer,
    "PURCHASE_DECISION_NO" character varying(50),
    "PURCHASE_DECISION_DATE" character varying(12)
);
 (   DROP TABLE public."INV_PUR_ORDER_MAST";
       public         heap    postgres    false                       1259    76528    INV_PUR_TYPE    TABLE     �   CREATE TABLE public."INV_PUR_TYPE" (
    "ID" integer NOT NULL,
    "NEP_NAME" character varying(100),
    "NEP_ENG" character varying(100),
    "REMARKS" character varying(100),
    "ISDEFAULT" character(1)
);
 "   DROP TABLE public."INV_PUR_TYPE";
       public         heap    postgres    false            �           1259    78445    INV_REQUISITION_MAST    TABLE       CREATE TABLE public."INV_REQUISITION_MAST" (
    "ID" integer NOT NULL,
    "REQ_ID" character varying(10),
    "REQ_DATE_NEP" character varying(10),
    "REQ_BY" integer,
    "TYPE_ID" integer,
    "ITEM_ID" integer,
    "MAINTAIN_ITEM_ID" integer,
    "PROJ_ID" integer,
    "HANDOVER_ID" integer,
    "HANDOVER_ROOM_ID" integer,
    "FISCAL_YEAR" character varying(10),
    "REMARKS" character varying(100),
    "PREP_BY" integer,
    "PREP_DT" character varying(10),
    "CHECK_BY" integer,
    "CHECK_DT" character varying(10),
    "ACCEPT_BY" integer,
    "ACCEPT_DT" character varying(10),
    "ORGSTAFFNAME" character varying(60),
    "ORGSTAFFPOST" character varying(100),
    "REQ_TYPE" integer,
    "USERID" integer,
    "VEHICLE_ID" integer,
    "REASION" text,
    "REQ_DATE_ENG" timestamp without time zone,
    "PREP_DT_ENG" timestamp without time zone,
    "CHECK_DT_ENG" timestamp without time zone,
    "ACCEPT_DT_ENG" timestamp without time zone,
    "PURCHASE_GIVE" character varying(1),
    "STOCK_GIVE" character varying(1)
);
 *   DROP TABLE public."INV_REQUISITION_MAST";
       public         heap    postgres    false            �           1259    78949    INV_REQ_DETAIL    TABLE       CREATE TABLE public."INV_REQ_DETAIL" (
    "ID" integer NOT NULL,
    "REQ_MAST_ID" integer,
    "ITEM_ID" integer,
    "SPEC_ID" integer,
    "BRAND_ID" integer,
    "QTY" real,
    "REMARKS" character varying(100),
    "IS_ACTIVE" character varying(10)
);
 $   DROP TABLE public."INV_REQ_DETAIL";
       public         heap    postgres    false            �           1259    77315    INV_ROOM_MST    TABLE     �   CREATE TABLE public."INV_ROOM_MST" (
    "ROOM_ID" integer NOT NULL,
    "FLOOR_NO" integer,
    "BLOCK_NO" character varying(10),
    "DESC_NP" character varying(50),
    "DESC_EN" character varying(50),
    "DEPT_ID" integer
);
 "   DROP TABLE public."INV_ROOM_MST";
       public         heap    postgres    false            �           1259    78483    INV_STATUS_DETAIL    TABLE     e  CREATE TABLE public."INV_STATUS_DETAIL" (
    "ID" integer NOT NULL,
    "CODE" character varying(50),
    "STATUSDATEAD" timestamp without time zone,
    "STATUSDATEVS" character varying(10),
    "FISCAL_YEAR" character varying(10),
    "TOTALQTY" integer,
    "ITEM_ID" integer,
    "BRAND_ID" integer,
    "SPEC_ID" integer,
    "ITEM_STATUS_ID" integer,
    "REMARKS" character varying(255),
    "PREBY" integer,
    "PREVSDATE" character varying(10),
    "CHECKEDBY" integer,
    "CHECKVSDATE" character varying(10),
    "ACCEPTBY" integer,
    "MAIN_ID" integer,
    "ACCEPTVSDATE" character varying(10)
);
 '   DROP TABLE public."INV_STATUS_DETAIL";
       public         heap    postgres    false                       1259    76536    INV_SUPPLIER    TABLE     �  CREATE TABLE public."INV_SUPPLIER" (
    "SUP_ID" integer NOT NULL,
    "NAME_NP" character varying(70) NOT NULL,
    "NAME_EN" character varying(50),
    "COMPANY_NAME_NP" character varying(70),
    "COMPANY_NAME_EN" character varying(50),
    "REGI_TYPE" character varying(25),
    "TPIN_PAN_NO" character varying(30),
    "ADDRESS" character varying(100),
    "PHONE_NO" character varying(15),
    "EMAIL" character varying(30),
    "DATE_VS" character varying(10),
    "DATE_AD" timestamp without time zone,
    "ORG_TYPE" character varying(50),
    "ORG_ID" integer,
    "IS_SELECTED" character varying(5),
    "REG_NO" character varying(30),
    "SUP_TYPE" character varying(1)
);
 "   DROP TABLE public."INV_SUPPLIER";
       public         heap    postgres    false                       1259    76544    INV_SUPPLIER_FISCALYEAR    TABLE     �   CREATE TABLE public."INV_SUPPLIER_FISCALYEAR" (
    "ID" integer NOT NULL,
    "SUP_ID" integer,
    "FISCAL_YEAR" character varying(15)
);
 -   DROP TABLE public."INV_SUPPLIER_FISCALYEAR";
       public         heap    postgres    false                       1259    76531    INV_SUP_ITM_DET    TABLE     �   CREATE TABLE public."INV_SUP_ITM_DET" (
    "ID" integer NOT NULL,
    "ITEM_ID" integer,
    "SUP_ID" integer,
    "QTY" integer,
    "RATE" integer,
    "ACC_ID" integer,
    "FISCAL_YEAR" character varying(10)
);
 %   DROP TABLE public."INV_SUP_ITM_DET";
       public         heap    postgres    false                       1259    76549    INV_TAX_RATE    TABLE     �   CREATE TABLE public."INV_TAX_RATE" (
    "TAX_RATE_ID" integer NOT NULL,
    "NAME_NP" character varying(50) NOT NULL,
    "NAME_EN" character varying(50),
    "TAX_RATE" real NOT NULL
);
 "   DROP TABLE public."INV_TAX_RATE";
       public         heap    postgres    false                       1259    76554    INV_TYPE_SETUP    TABLE     �   CREATE TABLE public."INV_TYPE_SETUP" (
    "ID" integer NOT NULL,
    "DESC_NP" character varying(50) NOT NULL,
    "DESC_EN" character varying(50),
    "TYPE_ID" integer,
    "IS_ACTIVE" character varying(1)
);
 $   DROP TABLE public."INV_TYPE_SETUP";
       public         heap    postgres    false            	           1259    76559    INV_UNIT    TABLE       CREATE TABLE public."INV_UNIT" (
    "UNIT_ID" integer NOT NULL,
    "DESC_NP" character varying(50) NOT NULL,
    "DESC_EN" character varying(50),
    "MUL_FACTOR" integer,
    "RELATED_TO" character varying(10),
    "NO_OF_UNITS" integer,
    "IS_ACTIVE" character varying(1)
);
    DROP TABLE public."INV_UNIT";
       public         heap    postgres    false            
           1259    76564    INV_WAREHOUSE    TABLE     �   CREATE TABLE public."INV_WAREHOUSE" (
    "WAREHOUSE_ID" integer NOT NULL,
    "NAME_NP" character varying(50) NOT NULL,
    "NAME_EN" character varying(50),
    "IS_ACTIVE" character varying(1)
);
 #   DROP TABLE public."INV_WAREHOUSE";
       public         heap    postgres    false                       1259    76569    INV_YRLY_PUR_PLAN    TABLE     >  CREATE TABLE public."INV_YRLY_PUR_PLAN" (
    "ID" integer NOT NULL,
    "NAME_NP" character varying(70) NOT NULL,
    "NAME_EN" character varying(50),
    "APPROX_AMT" real,
    "PUR_TYPE" character varying(10),
    "AGREEMENT_TYPE" character varying(30),
    "APRX_AMT_ACPT_DATE" character varying(10),
    "INFO_PUBLISH_DATE" character varying(10),
    "TENDR_SALE_DATE" character varying(10),
    "FORM_ENTRY_DATE" character varying(10),
    "TENDR_OPEN_DATE" character varying(10),
    "TENDR_ACCEPT_DATE" character varying(10),
    "WRK_ORDER_DATE" character varying(10),
    "WRK_ACMPLSH_DATE" character varying(10),
    "ANLYSIS_DSGN_DT_AD" timestamp without time zone,
    "APRX_AMT_ACPT_DT_AD" timestamp without time zone,
    "TENDR_ACCEPT_DT_AD" timestamp without time zone,
    "TENDR_CALL_DT_AD" timestamp without time zone,
    "TENDR_OPEN_DT_AD" timestamp without time zone,
    "AGREEMENT_DT_AD" timestamp without time zone,
    "WRK_2_FIN_DT_AD" timestamp without time zone,
    "WRK_ACMPLSH_DT_AD" timestamp without time zone,
    "REMARKS" character varying(100)
);
 '   DROP TABLE public."INV_YRLY_PUR_PLAN";
       public         heap    postgres    false                       1259    76574    IPTTAXSUMMARY_HISTORY    TABLE     �  CREATE TABLE public."IPTTAXSUMMARY_HISTORY" (
    "SN" integer,
    "IID" integer,
    "FISCALYEAR" character varying(9),
    "NETTAXAMOUNT" integer,
    "FINEAMOUNT" integer,
    "ADDITIONALCHARGES" integer,
    "REDUCTIONALCHARGES" integer,
    "ISTHISFROMREVENUEACCOUNT" integer,
    "TAXPAIDAMOUNT" integer,
    "DATEPAID" character varying(10),
    "SPECIALNOTES" text,
    "USERID" integer,
    "USERIDE" integer,
    "DATAENTRYVSDATE" character varying(10),
    "DATAENTRYADDATETIME" timestamp without time zone,
    "DATAEDITADDATETIME" timestamp without time zone,
    "BILLID" integer,
    "BILLNO" character varying(25),
    "LAST_TAX_PAID_AMOUNT" real,
    "TAX_TYPE" character varying(2),
    "REM_IPT_PAID_AMOUNT" real,
    "REM_HL_PAID_AMOUNT" real,
    "REM_IPT_FINE_AMOUNT" real,
    "REM_HL_FINE_AMOUNT" real,
    "REM_HL_FINE_STATUS" character varying(1),
    "REM_IPT_FINE_STATUS" character varying(1),
    "YEAR" integer,
    "MONTH" integer,
    "ADD_DATE" timestamp without time zone,
    "COMPUTER_NAME" character varying(100),
    "DATA_STATUS" character varying(20),
    "WINDOWS_USER" character varying(100),
    "TRAN_TIME" character varying(20)
);
 +   DROP TABLE public."IPTTAXSUMMARY_HISTORY";
       public         heap    postgres    false                       1259    76580    ISSUEDBILLS    TABLE       CREATE TABLE public."ISSUEDBILLS" (
    "SN" integer,
    "DATEISSUED" character varying(10),
    "THELINO" integer,
    "BILLNOFROM" character varying(25),
    "BILLNOTO" character varying(25),
    "COUNTERID" integer,
    "USERID" integer,
    "SPECIALNOTES" character varying(90)
);
 !   DROP TABLE public."ISSUEDBILLS";
       public         heap    postgres    false            �            1259    76411 	   Imis_Menu    TABLE     �  CREATE TABLE public."Imis_Menu" (
    "MenuName" text,
    "MenuUrl" text,
    "DisplayName" text,
    "ParentMenuId" integer NOT NULL,
    "Active" boolean NOT NULL,
    "IsLocked" boolean NOT NULL,
    "Visible" boolean NOT NULL,
    "Icon" text,
    "MenuOrder" integer NOT NULL,
    "CreatedBy" text,
    "UpdateBy" text,
    "DisplayNepName" text,
    "CreatedAt" timestamp without time zone,
    "UpdatedAt" timestamp without time zone,
    "Id" integer NOT NULL
);
    DROP TABLE public."Imis_Menu";
       public         heap    postgres    false            �           1259    79246    Imis_Menu_Id_seq    SEQUENCE     �   CREATE SEQUENCE public."Imis_Menu_Id_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 )   DROP SEQUENCE public."Imis_Menu_Id_seq";
       public          postgres    false    239            �           0    0    Imis_Menu_Id_seq    SEQUENCE OWNED BY     K   ALTER SEQUENCE public."Imis_Menu_Id_seq" OWNED BY public."Imis_Menu"."Id";
          public          postgres    false    482                       1259    76583    LANDMEASURINGUNITS    TABLE     �   CREATE TABLE public."LANDMEASURINGUNITS" (
    "UNITID" integer,
    "UNITNAME" character varying(50),
    "SQFTPERUNIT" integer
);
 (   DROP TABLE public."LANDMEASURINGUNITS";
       public         heap    postgres    false                       1259    76586    LANDSMULTIEVALUATIONDETAIL    TABLE     �   CREATE TABLE public."LANDSMULTIEVALUATIONDETAIL" (
    "SN" integer,
    "IID" integer,
    "LANDID" integer,
    "KITTANUMBER" character varying(50),
    "GENERALRATEID" integer,
    "AREAINSQFT" integer
);
 0   DROP TABLE public."LANDSMULTIEVALUATIONDETAIL";
       public         heap    postgres    false                       1259    76589    LELEDGER20682069    TABLE     �  CREATE TABLE public."LELEDGER20682069" (
    "SN" integer,
    "IID" integer,
    "LANDID" integer,
    "WARDNO" integer,
    "TRACKID" integer,
    "KITTANUMBER" character varying(50),
    "TOTALAREA" integer,
    "NONEVALUATEDAREA" integer,
    "NETEVALUATINGAREA" integer,
    "RATEID" integer,
    "RATEPERUNIT" integer,
    "CALCULATEDVALUE" integer,
    "OTHERPLUSINEVALUATIONS" integer,
    "OTHERMINUSINEVALUATIONS" integer,
    "OTHERPLUSMINUSDESCRIPTIONS" character varying(90),
    "NETCALCULATEDVALUE" integer,
    "SELFDECLAREDVALUE" integer,
    "APPLIEDVALUE" integer,
    "NONCOMPLETIONREASONID" integer,
    "NONCOMPLETIONREASONS" character varying(90),
    "REMARKS" character varying(90),
    "LANDMEASURINGUNIT" integer,
    "TAXED" integer
);
 &   DROP TABLE public."LELEDGER20682069";
       public         heap    postgres    false                       1259    76592    MALPOT_LANDS    TABLE     ]  CREATE TABLE public."MALPOT_LANDS" (
    "ID" integer NOT NULL,
    "IID" integer,
    "EID" character varying(200),
    "NP_FIRSTNAME" character varying(200),
    "NP_LASTNAME" character varying(200),
    "OLDVDCID" integer,
    "OLDWORDNO" character varying(100),
    "MOTHNUMBER" character varying(200),
    "KITTANUMBER" character varying(200),
    "VDCID" integer,
    "WORDNO" integer,
    "AREAINSQFT" real,
    "NONFUNCTIONALAREAINSQFT" real,
    "ADD_USERID" integer,
    "EDIT_USERID" integer,
    "ADD_DATE" character varying(30),
    "EDIT_DATE" character varying(30),
    "IS_IPT" integer
);
 "   DROP TABLE public."MALPOT_LANDS";
       public         heap    postgres    false            �           1259    77348    MAP_AREA_GND_COV    TABLE     �   CREATE TABLE public."MAP_AREA_GND_COV" (
    "ID" integer NOT NULL,
    "REGIONID" integer,
    "GROUND_COV" real,
    "AREA" bigint,
    "REMARKS" character varying(150)
);
 &   DROP TABLE public."MAP_AREA_GND_COV";
       public         heap    postgres    false                       1259    76600    MAP_CONSTRCTION_KIND    TABLE     �   CREATE TABLE public."MAP_CONSTRCTION_KIND" (
    "ID" smallint NOT NULL,
    "NAME_NP" character varying(70) NOT NULL,
    "NAME_EN" character varying(70),
    "DESCRIPTION" character varying(100)
);
 *   DROP TABLE public."MAP_CONSTRCTION_KIND";
       public         heap    postgres    false                       1259    76605    MAP_DESIGNER_DTL    TABLE     �  CREATE TABLE public."MAP_DESIGNER_DTL" (
    "ID" smallint NOT NULL,
    "REG_NO" character varying(20) NOT NULL,
    "ENGCOUNCILREG_NO" character varying(20),
    "FIRM_NAME" character varying(70),
    "DESIGNER_NAME" character varying(70),
    "ADDRESS" character varying(200),
    "PHONE_NO" character varying(20),
    "CLASS" character varying(1),
    "STATUS_ID" character varying(1),
    "REMARKS" character varying(150)
);
 &   DROP TABLE public."MAP_DESIGNER_DTL";
       public         heap    postgres    false                       1259    76613    MAP_DIRECTION    TABLE     �   CREATE TABLE public."MAP_DIRECTION" (
    "ID" smallint NOT NULL,
    "NAME_NP" character varying(70),
    "NAME_EN" character varying(70) NOT NULL,
    "DESCRIPTION" character varying(100)
);
 #   DROP TABLE public."MAP_DIRECTION";
       public         heap    postgres    false                       1259    76618    MAP_DRAIN_TYPE    TABLE     �   CREATE TABLE public."MAP_DRAIN_TYPE" (
    "ID" smallint NOT NULL,
    "NAME_NP" character varying(70) NOT NULL,
    "NAME_EN" character varying(70),
    "DESCRIPTION" character varying(100)
);
 $   DROP TABLE public."MAP_DRAIN_TYPE";
       public         heap    postgres    false                       1259    76623 	   MAP_FLOOR    TABLE     �   CREATE TABLE public."MAP_FLOOR" (
    "ID" smallint NOT NULL,
    "NAME_NP" character varying(70) NOT NULL,
    "NAME_EN" character varying(70),
    "DESCRIPTION" character varying(100)
);
    DROP TABLE public."MAP_FLOOR";
       public         heap    postgres    false                       1259    76628    MAP_HOUSEUSE_TYPE    TABLE     �   CREATE TABLE public."MAP_HOUSEUSE_TYPE" (
    "ID" smallint NOT NULL,
    "NAME_NP" character varying(70) NOT NULL,
    "NAME_EN" character varying(70),
    "DESCRIPTION" character varying(100)
);
 '   DROP TABLE public."MAP_HOUSEUSE_TYPE";
       public         heap    postgres    false                       1259    76633    MAP_HTSTANDARD    TABLE     �   CREATE TABLE public."MAP_HTSTANDARD" (
    "SN" smallint NOT NULL,
    "KV" integer,
    "DISTANCEFT" integer,
    "REMARKS" character varying(150)
);
 $   DROP TABLE public."MAP_HTSTANDARD";
       public         heap    postgres    false            �           1259    77658    MAP_INCOME_TYPE    TABLE     �   CREATE TABLE public."MAP_INCOME_TYPE" (
    "ID" smallint NOT NULL,
    "NAME_NP" character varying(70) NOT NULL,
    "NAME_EN" character varying(70),
    "ACC_ID" integer,
    "DESCRIPTION" character varying(100)
);
 %   DROP TABLE public."MAP_INCOME_TYPE";
       public         heap    postgres    false                       1259    76638    MAP_LAND_OWNER_TYPE    TABLE     �   CREATE TABLE public."MAP_LAND_OWNER_TYPE" (
    "ID" smallint NOT NULL,
    "NAME_NP" character varying(70) NOT NULL,
    "NAME_EN" character varying(70),
    "DESCRIPTION" character varying(100)
);
 )   DROP TABLE public."MAP_LAND_OWNER_TYPE";
       public         heap    postgres    false                       1259    76643    MAP_NEIGHBOUR_TYPE    TABLE     �   CREATE TABLE public."MAP_NEIGHBOUR_TYPE" (
    "ID" smallint NOT NULL,
    "NAME_NP" character varying(70) NOT NULL,
    "NAME_EN" character varying(70),
    "DESCRIPTION" character varying(100)
);
 (   DROP TABLE public."MAP_NEIGHBOUR_TYPE";
       public         heap    postgres    false                       1259    76648    MAP_RATE    TABLE     �   CREATE TABLE public."MAP_RATE" (
    "ID" integer NOT NULL,
    "DESCRIPTION" character varying(150),
    "RATE_PERMIT" real,
    "DEPOSITE_RATE_PERMIT" real,
    "USERID" integer,
    "ENTRY_DATE" character varying(10)
);
    DROP TABLE public."MAP_RATE";
       public         heap    postgres    false            �           1259    77358    MAP_REGION_FAR    TABLE     �   CREATE TABLE public."MAP_REGION_FAR" (
    "ID" smallint NOT NULL,
    "REGIONID" integer,
    "AREA_FROM" integer,
    "AREA_TO" integer,
    "FISCAL_YEAR" character varying(10),
    "FAR" real,
    "REMARKS" character varying(150)
);
 $   DROP TABLE public."MAP_REGION_FAR";
       public         heap    postgres    false                       1259    76653    MAP_ROOF_CNSTRCT_TYPE    TABLE     �   CREATE TABLE public."MAP_ROOF_CNSTRCT_TYPE" (
    "ID" smallint NOT NULL,
    "NAME_NP" character varying(70) NOT NULL,
    "NAME_EN" character varying(70),
    "DESCRIPTION" character varying(100)
);
 +   DROP TABLE public."MAP_ROOF_CNSTRCT_TYPE";
       public         heap    postgres    false                       1259    76658    MAP_ROOF_TYPE    TABLE     �   CREATE TABLE public."MAP_ROOF_TYPE" (
    "ID" smallint NOT NULL,
    "NAME_NP" character varying(70),
    "NAME_EN" character varying(70) NOT NULL,
    "DESCRIPTION" character varying(100)
);
 #   DROP TABLE public."MAP_ROOF_TYPE";
       public         heap    postgres    false                       1259    76663    MAP_SITE    TABLE     �   CREATE TABLE public."MAP_SITE" (
    "SN" integer NOT NULL,
    "PERMITID" integer,
    "LANDSHAPE" smallint,
    "SIDE_A" real,
    "SIDE_B" real,
    "SIDE_C" real,
    "AREA" real
);
    DROP TABLE public."MAP_SITE";
       public         heap    postgres    false                       1259    76668    MAP_STDHEIGHT_RW    TABLE     �   CREATE TABLE public."MAP_STDHEIGHT_RW" (
    "ID" smallint NOT NULL,
    "ROAD_WIDTH" real,
    "HOUSE_HEIGHT" real,
    "FISCAL_YEAR" character varying(10),
    "REMARKS" character varying(150)
);
 &   DROP TABLE public."MAP_STDHEIGHT_RW";
       public         heap    postgres    false                        1259    76673    MAP_STOREYS    TABLE     �   CREATE TABLE public."MAP_STOREYS" (
    "ID" integer NOT NULL,
    "NAME_NP" character varying(70) NOT NULL,
    "NAME_EN" character varying(70),
    "DESCRIPTION" character varying(100)
);
 !   DROP TABLE public."MAP_STOREYS";
       public         heap    postgres    false            !           1259    76678    MAP_STRUCTURE_TYPE    TABLE     �   CREATE TABLE public."MAP_STRUCTURE_TYPE" (
    "ID" integer NOT NULL,
    "NAME_NP" character varying(70) NOT NULL,
    "NAME_EN" character varying(70),
    "DESCRIPTION" character varying(100)
);
 (   DROP TABLE public."MAP_STRUCTURE_TYPE";
       public         heap    postgres    false            "           1259    76683    MAP_ZONE    TABLE     �   CREATE TABLE public."MAP_ZONE" (
    "ID" integer NOT NULL,
    "NAME_NP" character varying(70) NOT NULL,
    "NAME_EN" character varying(70),
    "DESCRIPTION" character varying(100)
);
    DROP TABLE public."MAP_ZONE";
       public         heap    postgres    false            #           1259    76688    MINISTRY    TABLE     O  CREATE TABLE public."MINISTRY" (
    "ID" integer,
    "CODE" character varying(70),
    "ZONE" integer,
    "DISTRICT" integer,
    "VDC" integer,
    "PHONE" character varying(70),
    "ADDRESS" character varying(150),
    "NEPNAME" character varying(70),
    "ENGNAME" character varying(70),
    "REMARKS" character varying(200)
);
    DROP TABLE public."MINISTRY";
       public         heap    postgres    false            $           1259    76694    MINISTRY_ACC_HEAD    TABLE     �   CREATE TABLE public."MINISTRY_ACC_HEAD" (
    "ID" integer NOT NULL,
    "MINISTRY_ID" integer,
    "ACC_ID" integer,
    "SUB_HEAD_ID" integer,
    "FISCAL_YEAR" character varying(70),
    "REMARKS" character varying(200)
);
 '   DROP TABLE public."MINISTRY_ACC_HEAD";
       public         heap    postgres    false            %           1259    76699    NATIONALITIES    TABLE     �   CREATE TABLE public."NATIONALITIES" (
    "NATIONALITYID" integer,
    "CODE" character varying(50),
    "NEPNAME" character varying(50),
    "ENGNAME" character varying(25),
    "DESCRIPTION" character varying(70)
);
 #   DROP TABLE public."NATIONALITIES";
       public         heap    postgres    false            &           1259    76702    NEW_PROPERTY_TAXTABLE    TABLE     3  CREATE TABLE public."NEW_PROPERTY_TAXTABLE" (
    "SN" integer NOT NULL,
    "RATESN" integer,
    "FROMPROPERTYVALUE" real,
    "TOPROPERTYVALUE" real,
    "FROMTAXAMOUNT" real,
    "TOTAXAMOUNT" real,
    "REMARKS" character varying(190),
    "FISCALYEAR" character varying(10),
    "TAX_PERCENT" real
);
 +   DROP TABLE public."NEW_PROPERTY_TAXTABLE";
       public         heap    postgres    false            '           1259    76707    OFFICE_TYPE    TABLE        CREATE TABLE public."OFFICE_TYPE" (
    "OFFICE_TYPE_ID" integer NOT NULL,
    "OFFICE_TYPE" character varying(30) NOT NULL
);
 !   DROP TABLE public."OFFICE_TYPE";
       public         heap    postgres    false            �           1259    77426    ORGANIZATION_TREE    TABLE        CREATE TABLE public."ORGANIZATION_TREE" (
    "ID" integer NOT NULL,
    "PARENT_ID" integer,
    "NEP_NAME" character varying(70),
    "ENG_NAME" character varying(70),
    "CONTAINS_DARBANDI" integer,
    "GEO_REGION" integer,
    "GRP_LEVEL" integer
);
 '   DROP TABLE public."ORGANIZATION_TREE";
       public         heap    postgres    false            �           1259    77901    ORG_BANK_ACCOUNT    TABLE     �   CREATE TABLE public."ORG_BANK_ACCOUNT" (
    "ID" integer NOT NULL,
    "ORG_ID" integer,
    "BANKID" integer,
    "BRANCH_ID" integer,
    "BANK_ACCNT_TYPE_ID" integer,
    "ACC_NO" character varying(50),
    "ACC_NAME" character varying(150)
);
 &   DROP TABLE public."ORG_BANK_ACCOUNT";
       public         heap    postgres    false            (           1259    76712    PAYMENT_SLIP_MASTER    TABLE     M  CREATE TABLE public."PAYMENT_SLIP_MASTER" (
    "PAYMENT_SLIP_ID" integer NOT NULL,
    "PAYMENT_DESCRIPTION" character varying(100),
    "TRANSACTION_TYPEID" integer,
    "PERSON_TYPE_ID" integer,
    "PERSON_ID" integer,
    "WORK_ID" integer,
    "BILL_AMT" real,
    "VAT_AMT" real,
    "RETENTION_MONEY_EDUCTION" real,
    "CONTRACT_TAX_DEDUCTION" real,
    "INCOME_TAX_DEDUCTION" real,
    "LAST_YEARS_ADV_DEDUCTION" real,
    "VAT_DEDUCTION" real,
    "OTHER_DEDUCTION" real,
    "CHEQUE_PAYMENT" real,
    "CASH_PAYMENT" real,
    "ADV_CLEARED_FROM_BILL" real,
    "ADV_CLEARED_FROM_BANK" real,
    "ADV_CLEARED_FROM_CASH" real,
    "LY_ADV_CLEARED_FROM_BILL" real,
    "LY_ADV_CLEARED_FROM_BANK" real,
    "LY_ADV_CLEARED_FROM_CASH" real,
    "IS_PESKI" character varying(1),
    "VR_NO" integer,
    "VR_DATE" character varying(10)
);
 )   DROP TABLE public."PAYMENT_SLIP_MASTER";
       public         heap    postgres    false            )           1259    76717    PERSON_TYPE_MASTER    TABLE     �   CREATE TABLE public."PERSON_TYPE_MASTER" (
    "PERSON_TYPE_ID" integer NOT NULL,
    "NAME_NP" text,
    "NAME_EN" text,
    "ISFIXED" character varying(1)
);
 (   DROP TABLE public."PERSON_TYPE_MASTER";
       public         heap    postgres    false            *           1259    76725    PIS_APPOINTMENT_TYPE    TABLE     �   CREATE TABLE public."PIS_APPOINTMENT_TYPE" (
    "ID" integer NOT NULL,
    "NAME_NP" character varying(50),
    "NAME_EN" character varying(50),
    "DESCRIPTION" character varying(70)
);
 *   DROP TABLE public."PIS_APPOINTMENT_TYPE";
       public         heap    postgres    false            +           1259    76730    PIS_ATTRIBUTES    TABLE     �   CREATE TABLE public."PIS_ATTRIBUTES" (
    "ID" integer NOT NULL,
    "NAME_NEP" character varying(70),
    "DESCRIPTION" character varying(90),
    "APPLY_TO" character varying(2)
);
 $   DROP TABLE public."PIS_ATTRIBUTES";
       public         heap    postgres    false            �           1259    77946 
   PIS_AWARDS    TABLE     �  CREATE TABLE public."PIS_AWARDS" (
    "SN" integer NOT NULL,
    "EMP_ID" integer,
    "LOCAL_POST_ID" integer,
    "NEP_NAME" character varying(70),
    "LEVEL_DESC" character varying(50),
    "DESCRIPTION" character varying(100),
    "WORKING_OFFICE" character varying(70),
    "RVCD_DATE_VS" character varying(10),
    "RCVD_DATE_AD" timestamp without time zone,
    "REMARKS" character varying(90),
    "APPLY_TO" character varying(2)
);
     DROP TABLE public."PIS_AWARDS";
       public         heap    postgres    false            �           1259    78503    PIS_BANK_PAYROLL    TABLE     �   CREATE TABLE public."PIS_BANK_PAYROLL" (
    "SN" integer NOT NULL,
    "EMP_ID" integer,
    "BANK_ID" integer,
    "BANK_FOLIO" character varying(25),
    "ACCOUNT_NO" character varying(25)
);
 &   DROP TABLE public."PIS_BANK_PAYROLL";
       public         heap    postgres    false            �           1259    77956    PIS_DARBANDI    TABLE        CREATE TABLE public."PIS_DARBANDI" (
    "DARBANDI_ID" integer NOT NULL,
    "OFFICE_ID" integer,
    "POST_ID" integer,
    "POST_LEVEL" integer,
    "LOCAL_POST_ID" integer,
    "SEWA_SAMUHA_UPASAMUHA" character varying(100),
    "NO_OF_POST" integer
);
 "   DROP TABLE public."PIS_DARBANDI";
       public         heap    postgres    false            �           1259    78763    PIS_DELETD_FRM_FULFILD_DARB    TABLE     -  CREATE TABLE public."PIS_DELETD_FRM_FULFILD_DARB" (
    "SN" integer NOT NULL,
    "EMP_ID" integer,
    "FRM_SN_IN_FD" integer,
    "FRM_OFFICE_ID" integer,
    "FRM_DARBANDI_ID" integer,
    "FRM_DATE_FULFILLED" character varying(10),
    "FRM_APPOINTMNT_TYPE" integer,
    "TO_SN_IN_FD" integer
);
 1   DROP TABLE public."PIS_DELETD_FRM_FULFILD_DARB";
       public         heap    postgres    false            �           1259    77396    PIS_EDUCATION    TABLE     �  CREATE TABLE public."PIS_EDUCATION" (
    "SN" integer NOT NULL,
    "EMP_ID" integer,
    "EDU_NAME" character varying(70),
    "EDU_LEVEL_ID" integer,
    "INSTITUTE" character varying(70),
    "BOARD_ID" integer,
    "MARKS_PERCNT" real,
    "MARKS_GRADE" real,
    "DIVISION" character varying(25),
    "COMPLETION_YR_VS" character varying(10),
    "COMPLETION_YR_AD" timestamp without time zone,
    "SUBJECTS" character varying(100),
    "VALID_FOR_EVAL" integer,
    "APPLY_TO" character varying(2)
);
 #   DROP TABLE public."PIS_EDUCATION";
       public         heap    postgres    false            ,           1259    76735    PIS_EDU_BOARD    TABLE     �   CREATE TABLE public."PIS_EDU_BOARD" (
    "ID" integer NOT NULL,
    "NAME_NEP" character varying(100),
    "NAME_ENG" character varying(100),
    "COUNTRY_ID" integer,
    "PLACE" character varying(70)
);
 #   DROP TABLE public."PIS_EDU_BOARD";
       public         heap    postgres    false            -           1259    76740    PIS_EDU_LEVEL    TABLE     n   CREATE TABLE public."PIS_EDU_LEVEL" (
    "EDU_ID" integer NOT NULL,
    "EDU_NAME" character varying(100)
);
 #   DROP TABLE public."PIS_EDU_LEVEL";
       public         heap    postgres    false            �           1259    77976    PIS_EMPLOYEE_MASTER    TABLE     w  CREATE TABLE public."PIS_EMPLOYEE_MASTER" (
    "EMP_ID" integer NOT NULL,
    "FIRST_NAME_NP" character varying(70),
    "LAST_NAME_NP" character varying(50),
    "FIRST_NAME_EN" character varying(70),
    "LAST_NAME_EN" character varying(50),
    "POST_ID" integer,
    "SERVICE_GROUP" character varying(30),
    "TITLE" character varying(30),
    "GENDER" character varying(1),
    "FATHER_NAME" character varying(70),
    "HUSBAND_NAME" character varying(70),
    "WILL_PERSON" character varying(70),
    "ADDRESS" character varying(100),
    "DATE_OF_BIRTH" character varying(25),
    "FIRST_APPOINT_DATE" character varying(10),
    "FIRST_APPOINT_POST_ID" integer,
    "CURRENT_POST_APPOINT_DATE" character varying(10),
    "SERVICE_STATUS" character varying(40),
    "POST_STATUS" character varying(40),
    "GRADES" integer,
    "CIT_PERCENT" integer,
    "PAYMODE" character varying(30),
    "GOVT_EMP_ID" character varying(50),
    "PF_ID" character varying(50),
    "CIT_ID" character varying(50),
    "POST_LEVEL" integer,
    "RETIRE_DATE" character varying(10),
    "LOCAL_POST_ID" integer,
    "PHONES" character varying(50),
    "EMAILS" character varying(50),
    "PAYEMENT_BANK_ID" integer,
    "MARRIED_STATUS" character varying(1),
    "INSURANCE_NO" character varying(50),
    "MOBILE_NO" character varying(20),
    "RELIGION" integer,
    "PARENT_OCUPATION" integer,
    "SPOUSE_OCUPATION" integer,
    "GF_NAME" character varying(70),
    "GF_OCUPATION" integer,
    "REL_WITH_WILL_PERSON" character varying(25),
    "ZONE_ID" integer,
    "DISTRICT_ID" integer,
    "VDC_ID" integer,
    "WARD_NO" integer,
    "MAIL_ADDRESS" character varying(100),
    "APPOINMENT_TYPE" integer,
    "CITIZENSHIP_NO" character varying(25),
    "CS_ISSUED_DATE" character varying(10),
    "CS_ISSUED_DISTRICT" integer,
    "DATE_OF_BIRTH_AD" timestamp without time zone,
    "INSURANCE_FACILITY" character varying(1),
    "DEDUCT_ABSENT" character varying(1),
    "LEKHA_NO" character varying(50),
    "DEPT_ID" integer,
    "PENSION_KOSH" character varying(2),
    "CIT_CODE" character varying(20),
    "ROOM_ID" integer,
    "CODE" character varying(70)
);
 )   DROP TABLE public."PIS_EMPLOYEE_MASTER";
       public         heap    postgres    false            �           1259    78518    PIS_EMP_ADV_DED_DTL    TABLE     �   CREATE TABLE public."PIS_EMP_ADV_DED_DTL" (
    "ID" integer NOT NULL,
    "EMP_ID" integer,
    "ACC_ID" integer,
    "AMOUNT_CUR" real,
    "AMOUNT_PREV" real
);
 )   DROP TABLE public."PIS_EMP_ADV_DED_DTL";
       public         heap    postgres    false            .           1259    76745    PIS_EMP_BARGA    TABLE     �   CREATE TABLE public."PIS_EMP_BARGA" (
    "ID" integer NOT NULL,
    "NAME_NP" character varying(25),
    "NAME_EN" character varying(25),
    "DESCRIPTION" character varying(100)
);
 #   DROP TABLE public."PIS_EMP_BARGA";
       public         heap    postgres    false            /           1259    76750    PIS_EMP_DEP    TABLE       CREATE TABLE public."PIS_EMP_DEP" (
    "DEPT_ID" integer NOT NULL,
    "NAME_NP" character varying(70) NOT NULL,
    "NAME_EN" character varying(70),
    "DESCRIPTION" character varying(70),
    "SALARY_ACC_ID" integer NOT NULL,
    "ALLOWANCE_ACC_ID" integer,
    "ADD_PF_ACC_ID" integer,
    "ADD_INSRNCE_ACC_ID" integer,
    "SUB_PF_ACC_ID" integer,
    "SUB_INSRNCE_ACC_ID" integer,
    "CIT_ACC_ID" integer,
    "INCME_TAX_ACC_ID" integer,
    "LEND_PF_D_ACC_ID" integer,
    "SOC_SEC_TAX" integer,
    "BHATTA_ACC_ID" integer,
    "PESKI_KATTI_ACC_ID" integer,
    "OTHR_KATTI_ACC_ID" integer,
    "ABSNT_KATTI_ACC_ID" integer,
    "SAPATI_KATTI_ACC_ID" integer,
    "BUDGET_SOURCE_ID" integer,
    "TDS_ACC_ID" integer,
    "WORK_ID" integer,
    "BUDJET_SOURCE_ID" integer
);
 !   DROP TABLE public."PIS_EMP_DEP";
       public         heap    postgres    false            �           1259    77411    PIS_EMP_DEP_SOURCE    TABLE     v   CREATE TABLE public."PIS_EMP_DEP_SOURCE" (
    "DEPT_ID" integer NOT NULL,
    "BUDJET_SOURCE_ID" integer NOT NULL
);
 (   DROP TABLE public."PIS_EMP_DEP_SOURCE";
       public         heap    postgres    false            0           1259    76755    PIS_EMP_INSURANCE_PAID    TABLE     �   CREATE TABLE public."PIS_EMP_INSURANCE_PAID" (
    "ID" integer NOT NULL,
    "EMP_ID" integer,
    "AMOUNT" real,
    "FISCAL_YEAR" character varying(10),
    "REMARKS" text
);
 ,   DROP TABLE public."PIS_EMP_INSURANCE_PAID";
       public         heap    postgres    false            �           1259    78528    PIS_EMP_LOANS    TABLE     +  CREATE TABLE public."PIS_EMP_LOANS" (
    "LOAN_ID" integer NOT NULL,
    "NAME_NP" character varying(70),
    "NAME_EN" character varying(70),
    "EMP_ID" integer,
    "ACC_ID" integer,
    "LOAN_AMT" real,
    "INSTALLMENT_AMT" real,
    "PAID_AMOUNT" real,
    "CLEARED" character varying(1)
);
 #   DROP TABLE public."PIS_EMP_LOANS";
       public         heap    postgres    false            �           1259    78538    PIS_EMP_LONG_LEAVES    TABLE     H  CREATE TABLE public."PIS_EMP_LONG_LEAVES" (
    "SN" integer NOT NULL,
    "EMP_ID" integer,
    "LOCAL_POST_ID" integer,
    "LEAVE_NAME" character varying(70),
    "WORKING_OFFICE" character varying(70),
    "FROM_DATE_VS" character varying(10),
    "TO_DATE_VS" character varying(10),
    "REMARKS" character varying(100)
);
 )   DROP TABLE public."PIS_EMP_LONG_LEAVES";
       public         heap    postgres    false            �           1259    78553    PIS_EMP_MED_EXPENSE    TABLE     '  CREATE TABLE public."PIS_EMP_MED_EXPENSE" (
    "SN" integer NOT NULL,
    "EMP_ID" integer,
    "LOCAL_POST_ID" integer,
    "WORKING_OFFICE" character varying(70),
    "ISSUED_DATE" character varying(10),
    "REGULAR_AMT" real,
    "SPECIAL_AMT" real,
    "REMARKS" character varying(100)
);
 )   DROP TABLE public."PIS_EMP_MED_EXPENSE";
       public         heap    postgres    false            �           1259    78568    PIS_EMP_PUNISHMNTS    TABLE       CREATE TABLE public."PIS_EMP_PUNISHMNTS" (
    "SN" integer NOT NULL,
    "EMP_ID" integer,
    "LOCAL_POST_ID" integer,
    "WORKING_OFFICE" character varying(70),
    "PUNISH_TYPE" character varying(90),
    "PUNISH_DATE" character varying(10),
    "REMARKS" character varying(100)
);
 (   DROP TABLE public."PIS_EMP_PUNISHMNTS";
       public         heap    postgres    false            �           1259    78583    PIS_EMP_SRVC_DTLS    TABLE     P  CREATE TABLE public."PIS_EMP_SRVC_DTLS" (
    "SN" integer NOT NULL,
    "EMP_ID" integer,
    "LOCAL_POST_ID" integer,
    "OFFICE_DETAIL" character varying(70),
    "GEO_REGION" integer,
    "APPOINTMENT_TYPE" integer,
    "DATE_FROM" character varying(10),
    "DATE_TO" character varying(10),
    "REMARKS" character varying(90)
);
 '   DROP TABLE public."PIS_EMP_SRVC_DTLS";
       public         heap    postgres    false            �           1259    78598    PIS_EMP_SUSPENDS    TABLE     C  CREATE TABLE public."PIS_EMP_SUSPENDS" (
    "SN" integer NOT NULL,
    "EMP_ID" integer,
    "LOCAL_POST_ID" integer,
    "NAME_NP" character varying(100),
    "WORKING_OFFICE" character varying(70),
    "FROM_DATE_VS" character varying(10),
    "TO_DATE_VS" character varying(10),
    "REMARKS" character varying(100)
);
 &   DROP TABLE public."PIS_EMP_SUSPENDS";
       public         heap    postgres    false            �           1259    78613    PIS_EMP_TRNSFR_REC    TABLE     "  CREATE TABLE public."PIS_EMP_TRNSFR_REC" (
    "SN" integer NOT NULL,
    "EMP_ID" integer,
    "LOCAL_POST_ID" integer,
    "REF_NO" character varying(50),
    "TRNSFR_DATE" character varying(10),
    "AMT_TAKEN" real,
    "TRNSFRD_OFFICE" character varying(70),
    "MOVED_DATE" character varying(10),
    "REMARKS" character varying(100),
    "USER_ID" integer,
    "USER_IDE" integer,
    "DATA_ENTRY_VS_DATE" character varying(10),
    "DATA_ENTRY_AD_DATE" timestamp without time zone,
    "DATA_EDIT_AD_DATE" timestamp without time zone
);
 (   DROP TABLE public."PIS_EMP_TRNSFR_REC";
       public         heap    postgres    false            �           1259    78009    PIS_FOREIGN_VISITS    TABLE     �  CREATE TABLE public."PIS_FOREIGN_VISITS" (
    "SN" integer NOT NULL,
    "EMP_ID" integer,
    "LOCAL_POST_ID" integer,
    "WORKING_OFFICE" character varying(70),
    "FROM_DATE_VS" character varying(10),
    "TO_DATE_VS" character varying(10),
    "FROM_DATE_AD" timestamp without time zone,
    "TO_DATE_AD" timestamp without time zone,
    "VISITING_PRPSE" character varying(100),
    "FUNDED_BY" character varying(70),
    "REMARKS" character varying(90),
    "APPLY_TO" character varying(2)
);
 (   DROP TABLE public."PIS_FOREIGN_VISITS";
       public         heap    postgres    false            �           1259    78309    PIS_FULFILLED_DARBANDI    TABLE       CREATE TABLE public."PIS_FULFILLED_DARBANDI" (
    "SN" integer NOT NULL,
    "OFFICE_ID" integer,
    "DARBANDI_ID" integer,
    "PERSON_TYPE_ID" integer,
    "EMP_ID" integer,
    "DATE_FULFILLED" character varying(10),
    "APPOINTMNT_TYPE" integer,
    "LOCAL_POST_ID" integer
);
 ,   DROP TABLE public."PIS_FULFILLED_DARBANDI";
       public         heap    postgres    false            1           1259    76763    PIS_GEO_REGION    TABLE     �   CREATE TABLE public."PIS_GEO_REGION" (
    "ID" integer NOT NULL,
    "GR_ID" character varying(2),
    "GR_NAME" character varying(50),
    "MARKS_PER_YEAR" real,
    "DETAILS" text
);
 $   DROP TABLE public."PIS_GEO_REGION";
       public         heap    postgres    false            2           1259    76771 
   PIS_HAJIRI    TABLE     p  CREATE TABLE public."PIS_HAJIRI" (
    "SN" integer NOT NULL,
    "YEAR" integer,
    "MONTH" integer,
    "EMP_ID" integer,
    "LOCAL_POST" integer,
    "TOTAL_DAYS" integer,
    "PUBLIC_HOLIDAYS" integer,
    "HAJIRI_DAYS" integer,
    "GHABIS" integer,
    "BIBIS" integer,
    "CABIS" integer,
    "BETALABIS" integer,
    "OTHER" integer,
    "GAYAL" integer
);
     DROP TABLE public."PIS_HAJIRI";
       public         heap    postgres    false            �           1259    78628    PIS_INTERNAL_TRANSFER    TABLE       CREATE TABLE public."PIS_INTERNAL_TRANSFER" (
    "SN" integer NOT NULL,
    "EMP_ID" integer,
    "OFFICE_ID" integer,
    "DARBANDI_ID" integer,
    "DATE_FROM" character varying(10),
    "DATE_TO" character varying(10),
    "APPOINTMNT_TYPE" integer,
    "DATE_OF_DECISION" character varying(10),
    "DECISION_REFERENCE" character varying(50),
    "REMARKS" character varying(100),
    "TO_OFFICE_ID" integer,
    "TO_LOCAL_POST_ID" integer,
    "TO_APPOINTMNT_TYPE" integer,
    "REPLACED_EMP_ID" integer
);
 +   DROP TABLE public."PIS_INTERNAL_TRANSFER";
       public         heap    postgres    false            3           1259    76776    PIS_LAND_BLDNGS    TABLE     �  CREATE TABLE public."PIS_LAND_BLDNGS" (
    "SN" integer NOT NULL,
    "EMP_ID" integer,
    "DESCRIPTION" character varying(150),
    "UNIT_DESC" character varying(100),
    "ZONE_ID" integer,
    "DISTRICT_ID" integer,
    "VDC_ID" integer,
    "WARD_NO" character varying(10),
    "ROAD_ID" integer,
    "STREET" character varying(70),
    "OWNERSHIP_DETAILS" character varying(100),
    "AQUISITION_TYPE_ID" integer,
    "SPECIAL_NOTES" character varying(150),
    "APPLY_TO" character varying(2),
    "USER_ID" integer,
    "USER_IDE" integer,
    "DATA_ENTRY_VS_DATE" character varying(10),
    "DATA_ENTRY_AD_DATE" timestamp without time zone,
    "DATA_EDIT_AD_DATE" timestamp without time zone
);
 %   DROP TABLE public."PIS_LAND_BLDNGS";
       public         heap    postgres    false            4           1259    76784    PIS_LOAN_DHITO_GIVEN    TABLE     D  CREATE TABLE public."PIS_LOAN_DHITO_GIVEN" (
    "SN" integer NOT NULL,
    "EMP_ID" integer,
    "DESCRIPTION" character varying(150),
    "TRANS_DESC" character varying(100),
    "REASON_TO_TAKE" character varying(100),
    "VALUE_IN_NRS" real,
    "RETURNING_DURATION" character varying(50),
    "SPECIAL_NOTES" character varying(150),
    "APPLY_TO" character varying(2),
    "USER_ID" integer,
    "USER_IDE" integer,
    "DATA_ENTRY_VS_DATE" character varying(10),
    "DATA_ENTRY_AD_DATE" timestamp without time zone,
    "DATA_EDIT_AD_DATE" timestamp without time zone
);
 *   DROP TABLE public."PIS_LOAN_DHITO_GIVEN";
       public         heap    postgres    false            5           1259    76792    PIS_LOAN_DHITO_TAKEN    TABLE     D  CREATE TABLE public."PIS_LOAN_DHITO_TAKEN" (
    "SN" integer NOT NULL,
    "EMP_ID" integer,
    "DESCRIPTION" character varying(150),
    "TRANS_DESC" character varying(100),
    "REASON_TO_TAKE" character varying(100),
    "VALUE_IN_NRS" real,
    "RETURNING_DURATION" character varying(50),
    "SPECIAL_NOTES" character varying(150),
    "APPLY_TO" character varying(2),
    "USER_ID" integer,
    "USER_IDE" integer,
    "DATA_ENTRY_VS_DATE" character varying(10),
    "DATA_ENTRY_AD_DATE" timestamp without time zone,
    "DATA_EDIT_AD_DATE" timestamp without time zone
);
 *   DROP TABLE public."PIS_LOAN_DHITO_TAKEN";
       public         heap    postgres    false            �           1259    77441    PIS_LOCAL_POST_MASTER    TABLE     �  CREATE TABLE public."PIS_LOCAL_POST_MASTER" (
    "LOCAL_POST_ID" integer NOT NULL,
    "LOCAL_POST_NAME" character varying(70),
    "LOCAL_POST_NAME_EN" character varying(50),
    "POST_ID" integer,
    "POST_DUTIES" text,
    "BASIC_SALARY" real,
    "GRADE_RATE" real,
    "ALLWANCE" real,
    "INSURANCE_ADD_AMT" real,
    "PAYROLL_ORDER" integer,
    "ALLLWANCE" real,
    "ALLOWANCE" real
);
 +   DROP TABLE public."PIS_LOCAL_POST_MASTER";
       public         heap    postgres    false            6           1259    76800    PIS_NIJAMATI_SEWA_SAMUHA    TABLE     �   CREATE TABLE public."PIS_NIJAMATI_SEWA_SAMUHA" (
    "ID" integer NOT NULL,
    "PARENT_ID" integer,
    "NAME_NP" character varying(100),
    "NAME_EN" character varying(100),
    "GRP_LEVEL" integer
);
 .   DROP TABLE public."PIS_NIJAMATI_SEWA_SAMUHA";
       public         heap    postgres    false            7           1259    76810    PIS_ORNAMENTS    TABLE     �  CREATE TABLE public."PIS_ORNAMENTS" (
    "SN" integer NOT NULL,
    "EMP_ID" integer,
    "DESCRIPTION" character varying(150),
    "UNIT_DESC" character varying(100),
    "AQUISITION_TYPE_ID" integer,
    "SPECIAL_NOTES" character varying(150),
    "APPLY_TO" character varying(2),
    "USER_ID" integer,
    "USER_IDE" integer,
    "DATA_ENTRY_VS_DATE" character varying(10),
    "DATA_ENTRY_AD_DATE" timestamp without time zone,
    "DATA_EDIT_AD_DATE" timestamp without time zone
);
 #   DROP TABLE public."PIS_ORNAMENTS";
       public         heap    postgres    false            �           1259    78019    PIS_OTHER_ADD_SUB    TABLE     �   CREATE TABLE public."PIS_OTHER_ADD_SUB" (
    "ID" integer NOT NULL,
    "ACC_ID" integer,
    "LOCAL_POST_ID" integer,
    "AMOUNT" real,
    "ADD_SUB" character varying(1),
    "DESCRIPTION" character varying(80)
);
 '   DROP TABLE public."PIS_OTHER_ADD_SUB";
       public         heap    postgres    false            8           1259    76815    PIS_PAYROLLS    TABLE     Y  CREATE TABLE public."PIS_PAYROLLS" (
    "ID" integer NOT NULL,
    "MONTH" smallint,
    "EMP_ID" integer NOT NULL,
    "LOCAL_POST_ID" integer,
    "POST_IN_SHORT" character varying(40),
    "LOCAL_POST" character varying(70),
    "EMP_NAME_NP" character varying(70),
    "BASIC_SALARY" real,
    "GRADE_INC_MONTH" smallint,
    "RATE_OF_GRADE" real,
    "GRADE_AMOUNT" real,
    "GRADE_SALARY_TOTAL" real,
    "ALLOWANCE_AMT" real,
    "OTHER_ALLOWANCE_AMT" real,
    "PF_ADD_AMT" real,
    "INSURANCE_ADD_AMT" real,
    "NET_SALARY" real,
    "PF_DEDUCT_AMT" real,
    "INSURANCE_DEDUCT_AMT" real,
    "CIT_PERCENT" real,
    "CIT_AMT" real,
    "TAX_AMT" real,
    "ADVANCE_DEDUCT_AMT" real,
    "LOAN_DEDUCT_AMT" real,
    "ABSENT_DAYS" integer,
    "ABSENT_DEDUCT_AMT" real,
    "OTHER_DEDUCT_TOTAL" real,
    "TOTAL_PAYABLE_SALARY" real,
    "PAYMODE" character varying(30),
    "POST_LEVEL" integer,
    "VCHR_ID" integer,
    "VCHR_DATE_NP" character varying(10),
    "PAY_BANK_ID" integer,
    "TRANS_TPE_ID" integer,
    "DEDUCT_DEP_VCHR_ID" integer,
    "DEDUCT_DEP_VCHR_DATE_NEP" character varying(10),
    "REMARKS" character varying(100),
    "FISCAL_YEAR" character varying(9),
    "FESTIVE_VCHR_ID" integer,
    "FESTIVE_VCHR_DATE_NEP" character varying(10),
    "PENSIONKOSH_ADD_AMT" integer,
    "PENSIONKOSH_DED_AMT" integer,
    "TDS_AMT" real
);
 "   DROP TABLE public."PIS_PAYROLLS";
       public         heap    postgres    false            9           1259    76820    PIS_PD_ORG_INVLVMNT    TABLE     �  CREATE TABLE public."PIS_PD_ORG_INVLVMNT" (
    "SN" integer NOT NULL,
    "EMP_ID" integer,
    "ORG_NAME" character varying(70),
    "ORG_ADD" character varying(100),
    "ORG_FORMED_DATE" character varying(10),
    "ORG_AIMS" character varying(150),
    "ORG_ACHEIVMNTS" character varying(150),
    "NO_OF_BENIFIC_POPLN" integer,
    "POST_IN_ORG" character varying(50),
    "RESPNSBLTY_IN_ORG" character varying(90),
    "ORG_JOINED_DATE" character varying(10),
    "ORG_LEFT_DATE" character varying(10),
    "REMARKS" character varying(100),
    "USER_ID" integer,
    "USER_IDE" integer,
    "DATA_ENTRY_VS_DATE" character varying(10),
    "DATA_ENTRY_AD_DATE" timestamp without time zone,
    "DATA_EDIT_AD_DATE" timestamp without time zone
);
 )   DROP TABLE public."PIS_PD_ORG_INVLVMNT";
       public         heap    postgres    false            :           1259    76828    PIS_PD_SRVC_DTLS    TABLE     c  CREATE TABLE public."PIS_PD_SRVC_DTLS" (
    "SN" integer NOT NULL,
    "EMP_ID" integer,
    "LOCAL_POST_ID" integer,
    "APPOINTMNT_LEVEL" character varying(50),
    "APPOINTMNT_TYPE" integer,
    "OFFICE_DETAIL" character varying(70),
    "DATE_FROM" character varying(10),
    "DATE_TO" character varying(10),
    "REMARKS" character varying(100)
);
 &   DROP TABLE public."PIS_PD_SRVC_DTLS";
       public         heap    postgres    false            ;           1259    76833    PIS_PERSON_VISIT_RECRD    TABLE     �  CREATE TABLE public."PIS_PERSON_VISIT_RECRD" (
    "SN" integer NOT NULL,
    "PERSON_TYPE_ID" integer,
    "PERSON_ID" integer,
    "PERSON_NAME" character varying(100),
    "PERSON_POST" character varying(70),
    "REF_NO" character varying(50),
    "FROM_DATE" character varying(10),
    "TO_DATE" character varying(10),
    "AMOUNT_TAKEN" real,
    "VISIT_LOCATION" character varying(100),
    "JOB_DETAILS" character varying(70),
    "REMARKS" character varying(100),
    "USER_ID" integer,
    "USER_IDE" integer,
    "DATA_ENTRY_VS_DATE" character varying(10),
    "DATA_ENTRY_AD_DATE" timestamp without time zone,
    "DATA_EDIT_AD_DATE" timestamp without time zone
);
 ,   DROP TABLE public."PIS_PERSON_VISIT_RECRD";
       public         heap    postgres    false            <           1259    76841    PIS_POST_MASTER    TABLE     6  CREATE TABLE public."PIS_POST_MASTER" (
    "POST_ID" integer NOT NULL,
    "GENERAL_POST" character varying(70),
    "GENERAL_POST_SHORT" character varying(40),
    "POST_LEVEL" integer,
    "BASIC_SALARY" real,
    "RATE_OF_GRADE" integer,
    "MAX_GRADE_RATE" integer,
    "PRABIDIK_OR_PRASASAN" integer
);
 %   DROP TABLE public."PIS_POST_MASTER";
       public         heap    postgres    false            �           1259    78029 
   PIS_PRIZES    TABLE     �  CREATE TABLE public."PIS_PRIZES" (
    "SN" integer NOT NULL,
    "EMP_ID" integer,
    "LOCAL_POST_ID" integer,
    "NAME_NP" character varying(70),
    "DESCRIPTION" character varying(100),
    "AWARD_TYPE" character varying(30),
    "AMOUNT" real,
    "AWARDED_BY" character varying(70),
    "WORKING_OFFICE" character varying(70),
    "ISSUED_DATE" character varying(10),
    "REMARKS" character varying(100),
    "APPLY_TO" character varying(2)
);
     DROP TABLE public."PIS_PRIZES";
       public         heap    postgres    false            �           1259    78039    PIS_PUBLICATION    TABLE     �  CREATE TABLE public."PIS_PUBLICATION" (
    "SN" integer NOT NULL,
    "EMP_ID" integer,
    "LOCAL_POST_ID" integer,
    "NEP_NAME" character varying(70),
    "DESCRIPTION" character varying(100),
    "WORKING_OFFICE" character varying(70),
    "PUBLSH_DATE_VS" character varying(10),
    "PUBLSH_DATE_AD" timestamp without time zone,
    "PUBLISHER" character varying(100),
    "REMARKS" character varying(90),
    "APPLY_TO" character varying(2)
);
 %   DROP TABLE public."PIS_PUBLICATION";
       public         heap    postgres    false            �           1259    78974    PIS_PYROLL_LOAN_DTLS    TABLE     :  CREATE TABLE public."PIS_PYROLL_LOAN_DTLS" (
    "ID" integer NOT NULL,
    "LOAND_ID" integer,
    "MONTH" smallint,
    "NAME_NP" character varying(100),
    "EMP_ID" integer,
    "ACC_ID" integer,
    "LOAND_AMT" real,
    "INSTALLMENT_AMT" real,
    "CLEARED" character varying(1),
    "PAYROLL_ID" integer
);
 *   DROP TABLE public."PIS_PYROLL_LOAN_DTLS";
       public         heap    postgres    false            �           1259    78668    PIS_PYROLL_OTHR_DTLS    TABLE     4  CREATE TABLE public."PIS_PYROLL_OTHR_DTLS" (
    "ID" integer NOT NULL,
    "MONTH" smallint,
    "EMPLOYEE_ID" integer,
    "PAYROLL_ID" integer,
    "AMOUNT" real,
    "ADD_SUB" character varying(1),
    "DESCRIPTION" character varying(100),
    "ACC_ID" integer,
    "SOURCE_TYPE" character varying(2)
);
 *   DROP TABLE public."PIS_PYROLL_OTHR_DTLS";
       public         heap    postgres    false            �           1259    78788    PIS_REPLACED_IN_DARBANDI    TABLE     �  CREATE TABLE public."PIS_REPLACED_IN_DARBANDI" (
    "SN" integer NOT NULL,
    "EMP_ID" integer,
    "ENTRY_SN_IN_FD" integer,
    "OFFICE_ID" integer,
    "DARBANDI_ID" integer,
    "DATE_FULFILLED" character varying(10),
    "APPOINTMNT_TYPE" integer,
    "REPLACED_BY" integer,
    "DATE_REPLACED" character varying(10),
    "DATE_OF_DECISION" character varying(10),
    "DECISION_REFERENCE" character varying(50),
    "IS_PLACED_IN_DARBANDI" integer,
    "REMARKS" character varying(100)
);
 .   DROP TABLE public."PIS_REPLACED_IN_DARBANDI";
       public         heap    postgres    false            =           1259    76846    PIS_SERVICE_STATUS    TABLE     �   CREATE TABLE public."PIS_SERVICE_STATUS" (
    "ID" integer NOT NULL,
    "NAME_NP" character varying(50),
    "NAME_EN" character varying(50),
    "DESCRIPTION" character varying(70)
);
 (   DROP TABLE public."PIS_SERVICE_STATUS";
       public         heap    postgres    false            �           1259    78049    PIS_SGNFCNT_WORK    TABLE       CREATE TABLE public."PIS_SGNFCNT_WORK" (
    "SN" integer NOT NULL,
    "EMP_ID" integer,
    "LOCAL_POST_ID" integer,
    "NAME_NP" character varying(70),
    "DESCRIPTION" character varying(100),
    "WORKING_OFFICE" character varying(70),
    "FROM_DATE_VS" character varying(10),
    "TO_DATE_VS" character varying(10),
    "FROM_DATE_AD" timestamp without time zone,
    "TO_DATE_AD" timestamp without time zone,
    "DURATION" character varying(25),
    "REMARKS" character varying(100),
    "APPLY_TO" character varying(2)
);
 &   DROP TABLE public."PIS_SGNFCNT_WORK";
       public         heap    postgres    false            >           1259    76851    PIS_SHARE_BANKBALANCE    TABLE     >  CREATE TABLE public."PIS_SHARE_BANKBALANCE" (
    "SN" integer NOT NULL,
    "EMP_ID" integer,
    "DESCRIPTION" character varying(150),
    "COMPANY_OR_BANK" character varying(70),
    "VALUE_IN_NRS" real,
    "OWNERSHIP_DETAILS" character varying(100),
    "AQUISITION_TYPE_ID" integer,
    "SPECIAL_NOTES" character varying(150),
    "APPLY_TO" character varying(2),
    "USER_ID" integer,
    "USER_IDE" integer,
    "DATA_ENTRY_VS_DATE" character varying(10),
    "DATA_ENTRY_AD_DATE" timestamp without time zone,
    "DATA_EDIT_AD_DATE" timestamp without time zone
);
 +   DROP TABLE public."PIS_SHARE_BANKBALANCE";
       public         heap    postgres    false            �           1259    78059    PIS_TRAINING    TABLE     a  CREATE TABLE public."PIS_TRAINING" (
    "SN" integer NOT NULL,
    "EMP_ID" integer,
    "LOCAL_POST_ID" integer,
    "TRAINING_TYPE" character varying(70),
    "TRAINING_NAME" character varying(70),
    "INSTITUTE" character varying(70),
    "COUNTRY_ID" integer,
    "FRM_DATE_VS" character varying(10),
    "TO_DATE_VS" character varying(10),
    "FRM_DATE_AD" timestamp without time zone,
    "TO_DATE_AD" timestamp without time zone,
    "DURATION" character varying(25),
    "DIVISION" character varying(15),
    "MARKS_OBTND" real,
    "VALID_FOR_EVAL" integer,
    "APPLY_TO" character varying(2)
);
 "   DROP TABLE public."PIS_TRAINING";
       public         heap    postgres    false            �           1259    78703    PIS_VISITED_COUNTRIES    TABLE     �   CREATE TABLE public."PIS_VISITED_COUNTRIES" (
    "SN" integer NOT NULL,
    "VISIT_ID" integer,
    "EMP_ID" integer,
    "COUNTRY_ID" integer,
    "APPLY_TO" character varying(2)
);
 +   DROP TABLE public."PIS_VISITED_COUNTRIES";
       public         heap    postgres    false            �           1259    78069    PIS_WORKSHOP    TABLE     S  CREATE TABLE public."PIS_WORKSHOP" (
    "SN" integer NOT NULL,
    "EMP_ID" integer,
    "LOCAL_POST_ID" integer,
    "NEP_NAME" character varying(70),
    "DESCRIPTION" character varying(100),
    "WORKING_OFFICE" character varying(70),
    "DURATION" character varying(25),
    "FROM_DATE_VS" character varying(10),
    "TO_DATE_VS" character varying(10),
    "FROM_DATE_AD" timestamp without time zone,
    "TO_DATE_AD" timestamp without time zone,
    "ORGANIZER" character varying(100),
    "COUNTRY_ID" integer,
    "REMARKS" character varying(90),
    "APPLY_TO" character varying(2)
);
 "   DROP TABLE public."PIS_WORKSHOP";
       public         heap    postgres    false            ?           1259    76856    PMS_YOJTYPE    TABLE     �   CREATE TABLE public."PMS_YOJTYPE" (
    "ID" integer NOT NULL,
    "YOJTYPE_NAME_NP" character varying(150) NOT NULL,
    "YOJTYPE_NAME_ENG" character varying(150),
    "YOJTYPE_REMARKS" character varying(100)
);
 !   DROP TABLE public."PMS_YOJTYPE";
       public         heap    postgres    false            A           1259    76866    RENTTYPE    TABLE     �   CREATE TABLE public."RENTTYPE" (
    "ID" integer,
    "NEPNAME" character varying(50),
    "ENGNAME" character varying(50),
    "REMARKS" character varying(255)
);
    DROP TABLE public."RENTTYPE";
       public         heap    postgres    false            @           1259    76861    RENT_DAR_RATE    TABLE     �   CREATE TABLE public."RENT_DAR_RATE" (
    "ID" integer NOT NULL,
    "RATENAME" character varying(100),
    "RENT_PER" real,
    "RENT_TYPEID" integer
);
 #   DROP TABLE public."RENT_DAR_RATE";
       public         heap    postgres    false            B           1259    76869    REPORT_GENERAL    TABLE     8  CREATE TABLE public."REPORT_GENERAL" (
    "REPORT_ID" integer,
    "OFFICE_TYPE_ID" integer,
    "REPORT_NAME" character varying(60),
    "REPORT_FOR" character varying(50),
    "ANUSUCHI_HEAD" character varying(30),
    "ANUSUCHI_DETAILS" character varying(200),
    "REPORT_HEADING" character varying(200)
);
 $   DROP TABLE public."REPORT_GENERAL";
       public         heap    postgres    false            C           1259    76875    SANITATION_GROUP    TABLE     n   CREATE TABLE public."SANITATION_GROUP" (
    "ID" integer NOT NULL,
    "GROUPNAME" character varying(200)
);
 &   DROP TABLE public."SANITATION_GROUP";
       public         heap    postgres    false            �           1259    78079    SANITATION_RATE    TABLE     4  CREATE TABLE public."SANITATION_RATE" (
    "ID" integer NOT NULL,
    "GROUPID" integer,
    "SUBGROUPID" integer,
    "ROAD_TYPEID" integer,
    "RATENAME" text,
    "RATE" real,
    "FISCAL_YEAR" character varying(10),
    "AREA_UPTO" integer,
    "FOR_EACH_AREA" integer,
    "EACH_AREA_RATE" integer
);
 %   DROP TABLE public."SANITATION_RATE";
       public         heap    postgres    false            �           1259    77454    SANITATION_SUBGROUP    TABLE     �   CREATE TABLE public."SANITATION_SUBGROUP" (
    "ID" integer NOT NULL,
    "GROUPID" integer,
    "SUBGROUPNAME" character varying(200),
    "REMARKS" character varying(255)
);
 )   DROP TABLE public."SANITATION_SUBGROUP";
       public         heap    postgres    false            �           1259    77668    SERVICE_CHARGE_MASTER    TABLE     �   CREATE TABLE public."SERVICE_CHARGE_MASTER" (
    "ID" integer NOT NULL,
    "RATEID" integer,
    "ACCODE" integer,
    "ACC_ID" integer,
    "SERVICE_CHARGE_PERCENT" real,
    "FLAT_CHARGE_RATE" real,
    "ISAPPLICABLEFORHOUSE" smallint
);
 +   DROP TABLE public."SERVICE_CHARGE_MASTER";
       public         heap    postgres    false            D           1259    76880    SPACEMEASURINGUNITS    TABLE     �   CREATE TABLE public."SPACEMEASURINGUNITS" (
    "UNITID" integer,
    "UNITNAME" character varying(50),
    "SQFTPERUNIT" integer
);
 )   DROP TABLE public."SPACEMEASURINGUNITS";
       public         heap    postgres    false            �           1259    77494    STOREDBILLS    TABLE       CREATE TABLE public."STOREDBILLS" (
    "SN" integer NOT NULL,
    "DATEISSUED" character varying(10),
    "DESCRIPTION" character varying(70),
    "BILLNOFROM" character varying(25),
    "BILLNOTO" character varying(25),
    "CODE" integer,
    "BILLTYPEID" integer
);
 !   DROP TABLE public."STOREDBILLS";
       public         heap    postgres    false            E           1259    76883    SUBJECT_AREA    TABLE     �   CREATE TABLE public."SUBJECT_AREA" (
    "ID" integer NOT NULL,
    "PARENT_ID" integer,
    "CODE" character varying(70),
    "NEP_NAME" text,
    "ENG_NAME" character varying(100),
    "REMARKS" character varying(200)
);
 "   DROP TABLE public."SUBJECT_AREA";
       public         heap    postgres    false                       1259    77285    SUB_MODULE_SOURCE    TABLE     {   CREATE TABLE public."SUB_MODULE_SOURCE" (
    "SUB_MODULE_ID" integer NOT NULL,
    "BUDJET_SOURCE_ID" integer NOT NULL
);
 '   DROP TABLE public."SUB_MODULE_SOURCE";
       public         heap    postgres    false            F           1259    76891    SV_BUSINESSMASTER    TABLE       CREATE TABLE public."SV_BUSINESSMASTER" (
    "ID" integer NOT NULL,
    "NEPNAME" character varying(70),
    "DESCRIPTION" character varying(70),
    "BUSINESSGROUPID" integer,
    "TYPEID" integer,
    "TAXPAYERID" integer,
    "INITIALCAPITAL" integer,
    "ZONEID" integer,
    "DISTRICTID" integer,
    "VDCID" integer,
    "WARDNO" integer,
    "STREET" character varying(70),
    "TRACKID" integer,
    "HOUSENO" character varying(50),
    "PHONES" character varying(50),
    "EMAILS" character varying(100),
    "HOUSEOWNER" character varying(70),
    "ISINRENT" smallint,
    "MONTHLYRENT" integer,
    "AREAINSQUAREFEETS" integer,
    "INITIALREGISTEREDOFFICE" character varying(70),
    "INITIALREGNO" character varying(30),
    "INITIALREGDATE" character varying(10),
    "MUNICIPALREGNO" character varying(30),
    "MUNICIPALLREGDATE" character varying(10),
    "SQFEETSOFSIGNBOARD" integer,
    "LENGTHOFSIGNBOARD" integer,
    "WIDTHOFSIGNBOARD" integer,
    "CONTENTOFSIGNBOARD" character varying(90),
    "BUSINESSSTARTINGDATE" character varying(10),
    "SPECIALNOTES" character varying(100),
    "USERID" integer,
    "USERIDE" integer,
    "DATAENTRYVSDATE" character varying(10),
    "DATAENTRYADDATETIME" timestamp without time zone,
    "DATAEDITADDATETIME" timestamp without time zone,
    "GENERALRATEID" integer,
    "MAIL_ADDRESS" character varying(200),
    "BUSINESS_STATUS" smallint,
    "CLOSED_VS_DATE" character varying(10),
    "CLOSE_REASON" character varying(200),
    "PAID_LAST_FISCALYEAR" character varying(10),
    "SANITATIONID" integer,
    "MAXCAPITAL" real,
    "YEARLY_TRAN_AMOUNT" real,
    "SHIFTDATE" character varying(12),
    "SHIFTTAXPAYERID" integer,
    "ADDRESSCHANGE" character varying(12),
    "HOUSEID" integer,
    "BUSINESSOWNERTAX_IID" integer
);
 '   DROP TABLE public."SV_BUSINESSMASTER";
       public         heap    postgres    false            G           1259    76899    SV_CONSTRUCTIONS    TABLE       CREATE TABLE public."SV_CONSTRUCTIONS" (
    "ID" integer NOT NULL,
    "IID" integer,
    "HOUSEID" integer,
    "TALANUMBER" integer,
    "CONSTRUCTIONTYPEID" integer,
    "LENGTHINFEET" integer,
    "WIDTHTHINFEET" integer,
    "HEIGHTINFEET" integer,
    "AREAINSQFEET" integer,
    "VSDATEOFMADE" character varying(10),
    "CONSTRUCTIONUSESTYPEID" integer,
    "SELFUSEORINRENT" smallint,
    "GENERALRATEID" integer,
    "INCLUDEINEVALUATION" smallint,
    "SPECIALNOTE" character varying(90),
    "USERID" integer,
    "USERIDE" integer,
    "DATAENTRYVSDATE" character varying(10),
    "DATAENTRYADDATETIME" timestamp without time zone,
    "DATAEDITADDATETIME" timestamp without time zone,
    "TAXPAYER_DEFINE_AMOUNT" integer,
    "VSMAPPDATE" character varying(10)
);
 &   DROP TABLE public."SV_CONSTRUCTIONS";
       public         heap    postgres    false            H           1259    76904 	   SV_HOUSES    TABLE     �  CREATE TABLE public."SV_HOUSES" (
    "ID" integer NOT NULL,
    "IID" integer,
    "LANDID" integer,
    "HOUSENUMBER" character varying(50),
    "HOUSETYPEID" integer,
    "HOUSECONSTRUCTIONTYPEID" integer,
    "SALES_DT" character varying(10),
    "VSDATEOFMADE" character varying(10),
    "AQUISITIONDATE" character varying(10),
    "USESTYPEID" integer,
    "HASMAPREGISTERED" smallint,
    "MAPREGISTEREDDATE" character varying(10),
    "NUMOFTALAS" integer,
    "HEIGHTINFEETS" integer,
    "LENGTHINFEETS" integer,
    "WIDTHINFEETS" integer,
    "AREAINSQFEETS" integer,
    "SPECIALNOTE" text,
    "INCLUDEINEVALUATION" smallint,
    "AREAOFCONSTRUCTIONSINSQFEETS" integer,
    "USERID" integer,
    "USERIDE" integer,
    "DATAENTRYVSDATE" character varying(10),
    "DATAENTRYADDATETIME" timestamp without time zone,
    "DATAEDITADDATETIME" timestamp without time zone,
    "DEFINE_AMT" real,
    "SANITATIONRATEID" integer,
    "BUILDINGCODE" character varying(30),
    "BIN_GIS" integer
);
    DROP TABLE public."SV_HOUSES";
       public         heap    postgres    false            I           1259    76912    SV_LANDS    TABLE     _  CREATE TABLE public."SV_LANDS" (
    "ID" integer NOT NULL,
    "IID" integer,
    "OLDVDCID" integer,
    "OLDWARDNO" character varying(30),
    "LAND_RULES" text,
    "WARDNO" integer,
    "MOTHNUMBER" character varying(50),
    "MAPNUMBER" character varying(50),
    "KITTANUMBER" text,
    "STREETNAME" character varying(70),
    "HASTRACK" smallint,
    "TRACKID" integer,
    "TRACKRELATIONID" integer,
    "AQUISITIONDATE" character varying(10),
    "AQUISITIONTYPEID" integer,
    "USESTYPEID" integer,
    "VALUEINRSONAQUISITION" integer,
    "AREAINSQFT" integer,
    "NONFUNCTIONALAREAINSQFT" integer,
    "EASTBOUNDARY" character varying(70),
    "WESTBOUNDARY" character varying(70),
    "NORTHTBOUNDARY" character varying(70),
    "SOUTHTBOUNDARY" character varying(70),
    "LQTYPEID" integer,
    "LANDNATUREID" integer,
    "LOCATIONFACTORID" integer,
    "SELFDECLAREDVALUEINRS" integer,
    "SPECIALNOTE" character varying(90),
    "GENERALRATEID" integer,
    "INCLUDEINEVALUATION" smallint,
    "USERID" integer,
    "USERIDE" integer,
    "DATAENTRYVSDATE" character varying(10),
    "SALES_DT" character varying(10),
    "DATAENTRYADDATETIME" timestamp without time zone,
    "DATAEDITADDATETIME" timestamp without time zone,
    "EVALEXCLUSIONREASONID" integer,
    "MALPOTRATE" integer,
    "AREA_TYPE_ID" integer,
    "NOMINATION_DIRECTION" integer,
    "NOMINATION_AREA" integer,
    "NOMINATION_LENGTH" integer,
    "NOMINATION_BREADTH" integer,
    "NOMINATION_TF" integer,
    "LANDTYPE" integer,
    "EASTBOUNDARY_KITTA" character varying(50),
    "WESTBOUNDARY_KITTA" character varying(50),
    "NORTHBOUNDARY_KITTA" character varying(50),
    "SOUTHBOUNDARY_KITTA" character varying(50),
    "TOLENAME" character varying(50),
    "LANDMEASURINGUNITID" integer,
    "GRID_NO" character varying(100),
    "SHEET_NO" character varying(100),
    "EASTRUNFT" character varying(5),
    "WESTRUNFT" character varying(5),
    "NORTHRUNFT" character varying(5),
    "SOUTHRUNFT" character varying(5),
    "AREAINSQFT_FIELD" integer,
    "IS_LRMIS_ADD" character varying(2),
    "DEIGSTERTYPEID" character varying(2)
);
    DROP TABLE public."SV_LANDS";
       public         heap    postgres    false            J           1259    76920    SV_LANDSMULTIEVALUATIONDETAIL    TABLE     �   CREATE TABLE public."SV_LANDSMULTIEVALUATIONDETAIL" (
    "SN" integer,
    "IID" integer,
    "LANDID" integer,
    "KITTANUMBER" character varying(50),
    "GENERALRATEID" integer,
    "AREAINSQFT" integer
);
 3   DROP TABLE public."SV_LANDSMULTIEVALUATIONDETAIL";
       public         heap    postgres    false            K           1259    76923 	   SV_PEOPLE    TABLE     
  CREATE TABLE public."SV_PEOPLE" (
    "IID" integer NOT NULL,
    "EID" character varying(50),
    "SEX" smallint,
    "FIRSTNEPNAME" character varying(120),
    "LASTNEPNAME" character varying(64),
    "FIRSTENGNAME" character varying(120),
    "LASTENGNAME" character varying(64),
    "DOB" character varying(10),
    "FATHERORHUSBAND" character varying(70),
    "GFORFINLAW" character varying(70),
    "PHONES" character varying(60),
    "MOBILES" character varying(60),
    "EMAIL" character varying(90),
    "OCUPATIONID" integer,
    "RELIGIONID" integer,
    "MOTHERLANGUAGEID" integer,
    "NATIONALITYID" integer,
    "HASCC" smallint,
    "CCNUMBER" character varying(50),
    "CCISSUEDDRISTICTID" integer,
    "CCISSUEDDATE" character varying(10),
    "COUNTRYID" integer,
    "ZONEID" integer,
    "DISTRICTID" integer,
    "VDCID" integer,
    "WARDNO" integer,
    "STREETNAME" character varying(60),
    "TRACKID" integer,
    "HOUSENO" character varying(50),
    "CORESPADDRESSLINE1" character varying(50),
    "CORESPADDRESSLINE2" character varying(50),
    "CORESPADDRESSLINE3" character varying(50),
    "CORESPADDRESSLINE4" character varying(50),
    "OTHERDETAILS" character varying(180),
    "INDIVIDUALTYPE" integer,
    "PHOTO" text,
    "USERID" integer,
    "USERIDE" integer,
    "DATAENTRYVSDATE" character varying(10),
    "DATAENTRYADDATETIME" timestamp without time zone,
    "DATAEDITADDATETIME" timestamp without time zone,
    "IPT_UNPAID_FISCAL_YEAR" character varying(9),
    "IPT_UNPAID_AMOUNT" real,
    "HLT_UNPAID_FISCAL_YEAR" character varying(9),
    "HLT_UNPAID_AMOUNT" real,
    "IS_UNPAID_CLEARED" character varying(1),
    "CANCEL_DATE" character varying(12),
    "CANCEL_REASON" text,
    "TOLBIKASHID" integer,
    "IS_LRMIS_ADD" character varying(2)
);
    DROP TABLE public."SV_PEOPLE";
       public         heap    postgres    false            L           1259    76931    SV_TBHOUSEKITTANUMBER    TABLE     p   CREATE TABLE public."SV_TBHOUSEKITTANUMBER" (
    "IID" integer,
    "HOUSEID" integer,
    "LANDID" integer
);
 +   DROP TABLE public."SV_TBHOUSEKITTANUMBER";
       public         heap    postgres    false            M           1259    76934    SV_VEHICLEMASTER    TABLE     O  CREATE TABLE public."SV_VEHICLEMASTER" (
    "SN" integer NOT NULL,
    "TAXPAYERID" integer,
    "VEHICLENAME" character varying(70),
    "VEHICLETYPE" integer,
    "VEHICLENO" character varying(50),
    "REGISTEREDOFFICE" character varying(70),
    "REGISTEREDDATE" character varying(10),
    "MUNICIPALTYREGNO" character varying(30),
    "MUNICIPALTYREGDATE" character varying(10),
    "AQUISITIONTYPE" integer,
    "AQUISITIONDATE" character varying(10),
    "AQUIREDFROM" character varying(70),
    "USESTYPE" integer,
    "COLOR" character varying(30),
    "NUMBEROFSEATES" character varying(50),
    "CCORHPRSPOWER" character varying(50),
    "MADEOF" character varying(90),
    "ENGINENO" character varying(50),
    "CHESISNO" character varying(50),
    "MODELDESCRIPTION" character varying(70),
    "NOOFCILENDERS" character varying(50),
    "USEDFUEL" integer,
    "SPECIALNOTES" character varying(100),
    "USERID" integer,
    "USERIDE" integer,
    "DATAENTRYVSDATE" character varying(10),
    "DATAENTRYADDATETIME" timestamp without time zone,
    "DATAEDITADDATETIME" timestamp without time zone,
    "VEHICLE_STATUS" smallint,
    "CLOSED_VS_DATE" character varying(10),
    "CLOSE_REASON" character varying(200),
    "PAID_LAST_FISCALYEAR" character varying(10),
    "NAMASARIMITI" character varying(12),
    "NAMASARITAXPAYERID" integer
);
 &   DROP TABLE public."SV_VEHICLEMASTER";
       public         heap    postgres    false            �           1259    77678    TAX_ADDTNL_CHRG_DTLS    TABLE     
  CREATE TABLE public."TAX_ADDTNL_CHRG_DTLS" (
    "SN" integer NOT NULL,
    "FISCAL_YEAR" character varying(9),
    "IID" integer,
    "ACCODE" integer,
    "ACC_ID" integer,
    "AMOUNT" integer,
    "LAND_ID" integer,
    "RENT_ID" integer,
    "SERVICE_CHARGE_PERCENT" real,
    "FLAT_CHARGE_RATE" real,
    "ISAPPLICABLEFORHOUSE" smallint,
    "TAX_TYPE" character varying(3),
    "SERVICE_CHARGE_TYPE" character varying(2),
    "ISREGISTATIONFEE" character varying(2),
    "BILL_ID" integer,
    "BILL_NO" integer
);
 *   DROP TABLE public."TAX_ADDTNL_CHRG_DTLS";
       public         heap    postgres    false            N           1259    76942 
   TAX_MALPOT    TABLE     5  CREATE TABLE public."TAX_MALPOT" (
    "SN" bigint,
    "FISCALYEAR" character varying(9),
    "TAXPAYERID" integer,
    "LANDID" integer,
    "KITTANUMBER" text,
    "GENERALRATEID" integer,
    "RATEPERUNIT" real,
    "SPECIALNOTES" text,
    "NETTAXAMOUNT" real,
    "FINEAMOUNT" real,
    "ADDITIONALCHARGES" real,
    "REDUCTIONALCHARGES" real,
    "TAXPAIDAMOUNT" real,
    "LAST_TAX_PAID_AMOUNT" real,
    "TOTALAREA" integer,
    "NONEVALUATEDAREA" integer,
    "NETEVALUATINGAREA" integer,
    "BILLID" integer,
    "BILLDATE" character varying(10),
    "BILLNO" character varying(25),
    "COUNTERID" integer,
    "USERID" integer,
    "USERIDE" integer,
    "DATAENTRYVSDATE" character varying(10),
    "DATAENTRYADDATETIME" timestamp without time zone,
    "DATAEDITADDATETIME" timestamp without time zone
);
     DROP TABLE public."TAX_MALPOT";
       public         heap    postgres    false            O           1259    76948    TAX_MALPOT_HISTORY    TABLE     U  CREATE TABLE public."TAX_MALPOT_HISTORY" (
    "SN" bigint,
    "MALPOT_ID" bigint,
    "FISCALYEAR" character varying(9),
    "TAXPAYERID" integer,
    "LANDID" integer,
    "KITTANUMBER" text,
    "GENERALRATEID" integer,
    "RATEPERUNIT" real,
    "SPECIALNOTES" text,
    "NETTAXAMOUNT" real,
    "FINEAMOUNT" real,
    "ADDITIONALCHARGES" real,
    "REDUCTIONALCHARGES" real,
    "TAXPAIDAMOUNT" real,
    "LAST_TAX_PAID_AMOUNT" real,
    "TOTALAREA" integer,
    "NONEVALUATEDAREA" integer,
    "NETEVALUATINGAREA" integer,
    "BILLID" integer,
    "BILLDATE" character varying(10),
    "BILLNO" character varying(25),
    "COUNTERID" integer,
    "USERID" integer,
    "USERIDE" integer,
    "DATAENTRYVSDATE" character varying(10),
    "DATAENTRYADDATETIME" timestamp without time zone,
    "DATAEDITADDATETIME" timestamp without time zone
);
 (   DROP TABLE public."TAX_MALPOT_HISTORY";
       public         heap    postgres    false            P           1259    76954    TAX_RATE_CEILING    TABLE     �   CREATE TABLE public."TAX_RATE_CEILING" (
    "ID" integer NOT NULL,
    "NP_FROM" character varying(15),
    "NP_TO" character varying(15),
    "MARRIED_STATUS" character varying(50),
    "TAX_RATE" real
);
 &   DROP TABLE public."TAX_RATE_CEILING";
       public         heap    postgres    false            Q           1259    76959 
   TAX_RENTAL    TABLE     �  CREATE TABLE public."TAX_RENTAL" (
    "ID" integer,
    "FISCALYEAR" character varying(10),
    "TAXPAYERID" integer,
    "CONSTRUCTIONID" integer,
    "RENTID" integer,
    "RATEID" integer,
    "REMARKS" text,
    "NETTAXAMOUNT" real,
    "FINEAMOUNT" real,
    "ADDITIONALCHARGES" real,
    "REDUCTIONALCHARGES" real,
    "TAXPAIDAMOUNT" real,
    "LAST_TAX_PAID_AMOUNT" real,
    "BILLID" integer,
    "BILLNO" character varying(50),
    "BILLDATE" character varying(12),
    "COUNTERID" integer,
    "USERID" integer,
    "DATEENTRYVSDATE" character varying(12),
    "DATAENTRYADDATE" timestamp without time zone,
    "YEAR" integer,
    "MONTH" integer
);
     DROP TABLE public."TAX_RENTAL";
       public         heap    postgres    false            R           1259    76965    TAX_RT_RENTDTL    TABLE     �  CREATE TABLE public."TAX_RT_RENTDTL" (
    "ID" integer,
    "CONSTRUCTION_ID" integer,
    "RNAME" character varying(100),
    "RENT_TYPE_ID" integer,
    "RENT_INSQFEET" integer,
    "ANUAL_RENT_INCOME" real,
    "FISCAL_YEAR" character varying(10),
    "AGREEMENT_DATE" character varying(10),
    "VALID_UNTIL" character varying(10),
    "RENT_STATUS" character varying(5),
    "RATEID" integer,
    "TAXPAYERID" integer,
    "BUSINESSID" integer,
    "REMARKS" text,
    "DATAENTRYADDATETIME" timestamp without time zone,
    "DATAEDITADDATETIME" timestamp without time zone,
    "USERID" integer,
    "USERIDE" integer,
    "DATAENTRYVSDATE" character varying(12),
    "IS_TAX_PAID_BUSINESS_PERSON" character varying(2)
);
 $   DROP TABLE public."TAX_RT_RENTDTL";
       public         heap    postgres    false            S           1259    76971    TAX_SANITATION    TABLE     �  CREATE TABLE public."TAX_SANITATION" (
    "SN" integer,
    "FISCALYEAR" character varying(10),
    "YEAR" integer,
    "MONTH" integer,
    "TAXPAYERID" integer,
    "HOUSEID" integer,
    "RATEID" integer,
    "SPECIALNOTES" text,
    "NETTAXAMOUNT" real,
    "FINEAMOUNT" real,
    "REDUCTIONALCHARGES" real,
    "TAXPAIDAMOUNT" real,
    "LAST_TAX_PAID_AMOUNT" real,
    "BILLID" integer,
    "BILLNO" character varying(25),
    "BILLDATE" character varying(10),
    "COUNTERID" integer,
    "USERID" integer,
    "USERIDE" integer,
    "DATAENTRYVSDATE" character varying(10),
    "DATAENTRYADDATETIME" timestamp without time zone,
    "DATAEDITADDATETIME" timestamp without time zone,
    "SERVICETYPE" character varying(5)
);
 $   DROP TABLE public."TAX_SANITATION";
       public         heap    postgres    false            �           1259    78122    TAX_THLI_ISSUED_CNTR    TABLE     y   CREATE TABLE public."TAX_THLI_ISSUED_CNTR" (
    "ID" integer NOT NULL,
    "THELI_ID" integer,
    "CNTR_ID" integer
);
 *   DROP TABLE public."TAX_THLI_ISSUED_CNTR";
       public         heap    postgres    false            T           1259    76977    TBHOUSEKITTANUMBER    TABLE     m   CREATE TABLE public."TBHOUSEKITTANUMBER" (
    "IID" integer,
    "HOUSEID" integer,
    "LANDID" integer
);
 (   DROP TABLE public."TBHOUSEKITTANUMBER";
       public         heap    postgres    false            h           1259    77103    TBLBILLTYPE    TABLE     �   CREATE TABLE public."TBLBILLTYPE" (
    "ID" integer NOT NULL,
    "NEPNAME" character varying(100),
    "ISINCOME" character varying(1),
    "DESCRIPTION" character varying(150)
);
 !   DROP TABLE public."TBLBILLTYPE";
       public         heap    postgres    false            �           1259    77713    TBLBUSINESS_SERVICE_CH_MST    TABLE     �   CREATE TABLE public."TBLBUSINESS_SERVICE_CH_MST" (
    "ID" integer NOT NULL,
    "RATEID" integer,
    "ACCODE" integer,
    "ACC_ID" integer,
    "SERVICECHARGEPERCENT" real,
    "FLATCHARGERATE" real,
    "FISCAL_YEAR" character varying(10)
);
 0   DROP TABLE public."TBLBUSINESS_SERVICE_CH_MST";
       public         heap    postgres    false            i           1259    77108    TBLEXEVERSION    TABLE     h   CREATE TABLE public."TBLEXEVERSION" (
    "EXEID" integer,
    "EXEDATE" timestamp without time zone
);
 #   DROP TABLE public."TBLEXEVERSION";
       public         heap    postgres    false            j           1259    77111    TBLFYWISEBTRATES    TABLE     /  CREATE TABLE public."TBLFYWISEBTRATES" (
    "ID" integer,
    "GROUPID" integer,
    "SUBGROUPID" integer,
    "SNSUBGROUP" integer,
    "RATEID" integer,
    "NEPNAME" character varying(100),
    "DESCRIPTION" character varying(20),
    "FISCALYEAR" character varying(9),
    "RATEPERUNIT" integer
);
 &   DROP TABLE public."TBLFYWISEBTRATES";
       public         heap    postgres    false            �           1259    78728    TBLFYWISEMPOTASSRATE    TABLE     M  CREATE TABLE public."TBLFYWISEMPOTASSRATE" (
    "ID" integer NOT NULL,
    "GROUPID" integer,
    "SUBGROUPID" integer,
    "RATEID" integer,
    "NEPNAME" character varying(100),
    "FISCALYEAR" character varying(9),
    "RATEPERUNIT" integer,
    "AREA_UPTO" integer,
    "FOR_EACH_AREA" integer,
    "EACH_AREA_RATE" integer
);
 *   DROP TABLE public."TBLFYWISEMPOTASSRATE";
       public         heap    postgres    false            k           1259    77114    TBLHL_ADD_SUBTRACT    TABLE       CREATE TABLE public."TBLHL_ADD_SUBTRACT" (
    "SN" integer NOT NULL,
    "FISCAL_YEAR" character varying(10),
    "RATEID" integer,
    "FLAT_RATE" integer,
    "RATE_PERCENT" real,
    "ADD_FLAG" character varying(1),
    "ADD_SUB_TRACT_TYPE" character varying(2)
);
 (   DROP TABLE public."TBLHL_ADD_SUBTRACT";
       public         heap    postgres    false            l           1259    77119    TBLLAND_TYPE_AREA    TABLE     �   CREATE TABLE public."TBLLAND_TYPE_AREA" (
    "ID" integer NOT NULL,
    "CODE" character varying(50) NOT NULL,
    "NEP_NAME" character varying(50),
    "REMARKS" character varying(100)
);
 '   DROP TABLE public."TBLLAND_TYPE_AREA";
       public         heap    postgres    false            m           1259    77124    TBLMALPOTGROUP    TABLE     �   CREATE TABLE public."TBLMALPOTGROUP" (
    "ID" integer NOT NULL,
    "NEPNAME" character varying(100),
    "DESCRIPTION" character varying(150)
);
 $   DROP TABLE public."TBLMALPOTGROUP";
       public         heap    postgres    false            �           1259    78137    TBLMALPOTRATES    TABLE     4  CREATE TABLE public."TBLMALPOTRATES" (
    "ID" integer NOT NULL,
    "GROUPID" integer,
    "SUBGROUPID" integer,
    "NEPNAME" character varying(100),
    "RATEPERUNIT" integer,
    "DESCRIPTION" character varying(150),
    "AREA_UPTO" integer,
    "FOR_EACH_AREA" integer,
    "EACH_AREA_RATE" integer
);
 $   DROP TABLE public."TBLMALPOTRATES";
       public         heap    postgres    false            �           1259    77504    TBLMALPOTSUBGROUP    TABLE     �   CREATE TABLE public."TBLMALPOTSUBGROUP" (
    "ID" integer NOT NULL,
    "GROUPID" integer,
    "NEPNAME" character varying(100),
    "DESCRIPTION" character varying(150),
    "WORDA" integer
);
 '   DROP TABLE public."TBLMALPOTSUBGROUP";
       public         heap    postgres    false            o           1259    77134    TBLTAXCALCULATIONROKA    TABLE     �   CREATE TABLE public."TBLTAXCALCULATIONROKA" (
    "ID" integer,
    "IID" integer,
    "REASON" character varying(255),
    "ROKA_DATE" character varying(12)
);
 +   DROP TABLE public."TBLTAXCALCULATIONROKA";
       public         heap    postgres    false            n           1259    77129    TBLTAX_FINE_REBATE    TABLE       CREATE TABLE public."TBLTAX_FINE_REBATE" (
    "SN" integer NOT NULL,
    "FISCAL_YEAR" character varying(10),
    "DURATION_IN_YEARS" real,
    "TAX_TYPE" character varying(3),
    "FLAT_RATE" integer,
    "RATE_PERCENT" real,
    "REBATE_FLAG" character varying(1)
);
 (   DROP TABLE public."TBLTAX_FINE_REBATE";
       public         heap    postgres    false            �           1259    77723    TBLVEH_SER_CH_MSTR    TABLE     �   CREATE TABLE public."TBLVEH_SER_CH_MSTR" (
    "ID" integer NOT NULL,
    "RATEID" integer,
    "ACCODE" integer,
    "ACC_ID" integer,
    "SERVICE_CHARGE_PERCENT" real,
    "FLAT_CHARGE_RATE" real,
    "FISCAL_YEAR" character varying(10)
);
 (   DROP TABLE public."TBLVEH_SER_CH_MSTR";
       public         heap    postgres    false            U           1259    76980    TBL_BANK_ACCNT_TYPE    TABLE     �   CREATE TABLE public."TBL_BANK_ACCNT_TYPE" (
    "ID" integer NOT NULL,
    "NEPNAME" character varying(100),
    "ENGNAME" character varying(100),
    "REMARKS" character varying(150)
);
 )   DROP TABLE public."TBL_BANK_ACCNT_TYPE";
       public         heap    postgres    false            V           1259    76985    TBL_BANK_FINANCE_INSTITUTUE    TABLE     �   CREATE TABLE public."TBL_BANK_FINANCE_INSTITUTUE" (
    "ID" integer NOT NULL,
    "NP_NAME" text,
    "ENG_NAME" character varying(200),
    "DESCRIPTIONG" text,
    "ACCOUNT_NAME" text
);
 1   DROP TABLE public."TBL_BANK_FINANCE_INSTITUTUE";
       public         heap    postgres    false            W           1259    76993    TBL_BGT_MGMT    TABLE     �   CREATE TABLE public."TBL_BGT_MGMT" (
    "ID" integer NOT NULL,
    "FISCAL_YEAR" character varying(10),
    "MINISTRY_ID" integer,
    "BGT_SUB_HEAD_ID" integer,
    "TOTAL_BGT_AMT" real,
    "REMARKS" character varying(200)
);
 "   DROP TABLE public."TBL_BGT_MGMT";
       public         heap    postgres    false            �           1259    77464    TBL_BGT_MGMT_EXP    TABLE     �   CREATE TABLE public."TBL_BGT_MGMT_EXP" (
    "ID" integer NOT NULL,
    "BGT_MGMT_ID" integer,
    "ACC_ID" integer,
    "BGT_AMT" real,
    "REMARKS" character varying(200)
);
 &   DROP TABLE public."TBL_BGT_MGMT_EXP";
       public         heap    postgres    false            �           1259    77474    TBL_BGT_MGMT_EXP_ORG    TABLE     �   CREATE TABLE public."TBL_BGT_MGMT_EXP_ORG" (
    "ID" integer NOT NULL,
    "BGT_MGMT_ORG_ID" integer,
    "ACC_ID" integer,
    "BGT_AMT_ORG" real,
    "REMARKS" character varying(200)
);
 *   DROP TABLE public."TBL_BGT_MGMT_EXP_ORG";
       public         heap    postgres    false            �           1259    78152    TBL_BGT_MGMT_EXP_RELEASE    TABLE     �   CREATE TABLE public."TBL_BGT_MGMT_EXP_RELEASE" (
    "ID" integer NOT NULL,
    "BGT_MGMT_RELEASE_ID" integer,
    "ACC_ID" integer,
    "AMT" real,
    "REMARKS" character varying(200)
);
 .   DROP TABLE public."TBL_BGT_MGMT_EXP_RELEASE";
       public         heap    postgres    false            X           1259    76998    TBL_BGT_MGMT_ORG    TABLE       CREATE TABLE public."TBL_BGT_MGMT_ORG" (
    "ID" integer NOT NULL,
    "FISCAL_YEAR" character varying(10),
    "MINISTRY_ID" integer,
    "ORG_ID" integer,
    "BGT_SUB_HEAD_ID" integer,
    "TOTAL_BGT_AMT_ORG" real,
    "REMARKS" character varying(200)
);
 &   DROP TABLE public."TBL_BGT_MGMT_ORG";
       public         heap    postgres    false            �           1259    77573    TBL_BGT_MGMT_RELEASE    TABLE       CREATE TABLE public."TBL_BGT_MGMT_RELEASE" (
    "ID" integer NOT NULL,
    "BGT_RELEASE_ID" integer,
    "FISCAL_YEAR" character varying(10),
    "MINISTRY_ID" integer,
    "ORG_ID" integer,
    "BGT_SUB_HEAD_ID" integer,
    "AMT" real,
    "REMARKS" character varying(200)
);
 *   DROP TABLE public."TBL_BGT_MGMT_RELEASE";
       public         heap    postgres    false            �           1259    78097    TBL_BGT_MGMT_SRC    TABLE     �   CREATE TABLE public."TBL_BGT_MGMT_SRC" (
    "ID" integer NOT NULL,
    "BGT_MGMT_EXP_ID" integer,
    "SOURCE_ID" integer,
    "AMT" real,
    "PAYMENT_TYPE_ID" integer,
    "PAYMENT_PROCESS_ID" integer,
    "REMARKS" character varying(200)
);
 &   DROP TABLE public."TBL_BGT_MGMT_SRC";
       public         heap    postgres    false            �           1259    78107    TBL_BGT_MGMT_SRC_ORG    TABLE     8  CREATE TABLE public."TBL_BGT_MGMT_SRC_ORG" (
    "ID" integer NOT NULL,
    "BGT_MGMT_EXP_ORG_ID" integer,
    "SOURCE_ID" integer,
    "AMT" real,
    "CC_ID" integer,
    "CC_ACTIVE" character varying(2),
    "PAYMENT_TYPE_ID" integer,
    "PAYMENT_PROCESS_ID" integer,
    "REMARKS" character varying(200)
);
 *   DROP TABLE public."TBL_BGT_MGMT_SRC_ORG";
       public         heap    postgres    false            �           1259    78748    TBL_BGT_MGMT_SRC_RELEASE    TABLE     @  CREATE TABLE public."TBL_BGT_MGMT_SRC_RELEASE" (
    "ID" integer NOT NULL,
    "BGT_MGMT_EXP_RELEASE_ID" integer,
    "SOURCE_ID" integer,
    "AMT" real,
    "CC_ID" integer,
    "CC_ACTIVE" character varying(2),
    "PAYMENT_TYPE_ID" integer,
    "PAYMENT_PROCESS_ID" integer,
    "REMARKS" character varying(200)
);
 .   DROP TABLE public."TBL_BGT_MGMT_SRC_RELEASE";
       public         heap    postgres    false            x           1259    77185    TBL_BGT_RELEASE    TABLE     �  CREATE TABLE public."TBL_BGT_RELEASE" (
    "ID" integer NOT NULL,
    "FISCAL_YEAR" character varying(10),
    "MINISTRY_ID" integer,
    "ORG_ID" integer,
    "RELEASE_TYPE" integer,
    "RELEASE_DATE" character varying(10),
    "CHALANI_NO" character varying(50),
    "LETTER_SN" character varying(50),
    "APPROVED_BGT_YEARLY" real,
    "PREVIOUS_RELEASE_AMT" real,
    "RELEASE_AMOUNT" real,
    "SPECIAL_TIPPANI" text
);
 %   DROP TABLE public."TBL_BGT_RELEASE";
       public         heap    postgres    false            �           1259    77693    TBL_CONSTRUCTION_OTHER_CHARGES    TABLE     $  CREATE TABLE public."TBL_CONSTRUCTION_OTHER_CHARGES" (
    "ID" integer NOT NULL,
    "RATEID" integer,
    "ACCODE" integer,
    "ACC_ID" integer,
    "PERCENT_OF_TAX" real,
    "FLAT_CHARGE_RATE" integer,
    "FISCAL_YEAR" character varying(10),
    "SERVICE_CHARGE_CALCULATION" integer
);
 4   DROP TABLE public."TBL_CONSTRUCTION_OTHER_CHARGES";
       public         heap    postgres    false            Y           1259    77003    TBL_DATA_HISTORY    TABLE     �  CREATE TABLE public."TBL_DATA_HISTORY" (
    "ID" integer NOT NULL,
    "TABLE_NAME" character varying(100),
    "FIELD_NAME" character varying(100),
    "NEW_VALUE" text,
    "OLD_VALUE" character varying(100),
    "USER_ID_A" integer,
    "ADD_DATE" timestamp without time zone,
    "COMPUTER_NAME" character varying(100),
    "DATA_STATUS" character varying(20),
    "WINDOWS_USER" character varying(100),
    "TRAN_TIME" character varying(20)
);
 &   DROP TABLE public."TBL_DATA_HISTORY";
       public         heap    postgres    false            Z           1259    77011    TBL_DEGISTER    TABLE     �   CREATE TABLE public."TBL_DEGISTER" (
    "ID" integer NOT NULL,
    "NP_NAME" character varying(100),
    "ENG_NAME" character varying(100),
    "REMARKS" text,
    "IS_FULL_DEGISTER" integer
);
 "   DROP TABLE public."TBL_DEGISTER";
       public         heap    postgres    false            [           1259    77019    TBL_KHARIDA_AADASH    TABLE     �   CREATE TABLE public."TBL_KHARIDA_AADASH" (
    "ID" integer NOT NULL,
    "NP_NAME" character varying(200),
    "ENG_NAME" character varying(100)
);
 (   DROP TABLE public."TBL_KHARIDA_AADASH";
       public         heap    postgres    false            �           1259    77703    TBL_LAND_OTHER_CHARGES    TABLE       CREATE TABLE public."TBL_LAND_OTHER_CHARGES" (
    "ID" integer NOT NULL,
    "RATEID" integer,
    "ACCODE" integer,
    "ACC_ID" integer,
    "PERCENT_OF_TAX" real,
    "FLAT_CHARGE_RATE" integer,
    "FISCAL_YEAR" character varying(10),
    "SERVICE_CHARGE_CALCULATION" integer
);
 ,   DROP TABLE public."TBL_LAND_OTHER_CHARGES";
       public         heap    postgres    false            �           1259    78713    TBL_MALPOT_OTHER_CHARGES    TABLE     �   CREATE TABLE public."TBL_MALPOT_OTHER_CHARGES" (
    "ID" integer NOT NULL,
    "RATEID" integer,
    "ACCODE" integer,
    "ACC_ID" integer,
    "PERCENT_OF_TAX" real,
    "FLAT_CHARGE_RATE" integer,
    "FISCAL_YEAR" character varying(10)
);
 .   DROP TABLE public."TBL_MALPOT_OTHER_CHARGES";
       public         heap    postgres    false            \           1259    77024    TBL_NALI_TYPE    TABLE     �   CREATE TABLE public."TBL_NALI_TYPE" (
    "ID" integer NOT NULL,
    "NEPNAME" character varying(50),
    "ENGNAME" character varying(50),
    "DESCRIPTION" character varying(50)
);
 #   DROP TABLE public."TBL_NALI_TYPE";
       public         heap    postgres    false            ]           1259    77029    TBL_ORGANIZATIONMASTER    TABLE     �   CREATE TABLE public."TBL_ORGANIZATIONMASTER" (
    "ID" integer NOT NULL,
    "NP_NAME" text,
    "ENG_NAME" character varying(200),
    "DESCRIPTIONG" text
);
 ,   DROP TABLE public."TBL_ORGANIZATIONMASTER";
       public         heap    postgres    false            ^           1259    77037    TBL_PAYMENT_ORDER    TABLE     �   CREATE TABLE public."TBL_PAYMENT_ORDER" (
    "ID" integer NOT NULL,
    "ORDER_CODE" character varying(100),
    "DATE_BS" character varying(15),
    "TOKEN_NO" character varying(100),
    "REMARKS" text
);
 '   DROP TABLE public."TBL_PAYMENT_ORDER";
       public         heap    postgres    false            �           1259    77484    TBL_PAYMENT_ORDER_DETAILS    TABLE     �   CREATE TABLE public."TBL_PAYMENT_ORDER_DETAILS" (
    "ID" integer NOT NULL,
    "PAYMENT_ORDER_ID" integer,
    "VOUCHER_ID" integer,
    "LINK_VOUCHER_ID" integer,
    "PAYMENT_PERMISS_NO" character varying(200)
);
 /   DROP TABLE public."TBL_PAYMENT_ORDER_DETAILS";
       public         heap    postgres    false            _           1259    77045    TBL_PAYMENT_PROCESS    TABLE     �   CREATE TABLE public."TBL_PAYMENT_PROCESS" (
    "ID" integer NOT NULL,
    "PAYMENT_PROCESS" character varying(100),
    "PAYMENT_PROCESS_ENG" character varying(100),
    "REMARKS" character varying(200)
);
 )   DROP TABLE public."TBL_PAYMENT_PROCESS";
       public         heap    postgres    false            `           1259    77050    TBL_PAYMENT_TYPE    TABLE     �   CREATE TABLE public."TBL_PAYMENT_TYPE" (
    "ID" integer NOT NULL,
    "PAYMENT_TYPE" character varying(100),
    "PAYMENT_TYPE_ENG" character varying(100),
    "REMARKS" character varying(200)
);
 &   DROP TABLE public."TBL_PAYMENT_TYPE";
       public         heap    postgres    false            a           1259    77055    TBL_PROPERTY_TAX    TABLE       CREATE TABLE public."TBL_PROPERTY_TAX" (
    "ID" integer NOT NULL,
    "IID" integer,
    "NP_ENTRY_DATE" character varying(12),
    "FISCAL_YEAR" character varying(12),
    "HOUSE_LAND_AMOUNT" real,
    "MALPOT_AMOUNT" real,
    "TOTAL_TAX" real,
    "REMARKS" text
);
 &   DROP TABLE public."TBL_PROPERTY_TAX";
       public         heap    postgres    false            b           1259    77063    TBL_SANITAION_TAX    TABLE     �   CREATE TABLE public."TBL_SANITAION_TAX" (
    "ID" integer,
    "FROM_AREA" real,
    "TO_AREA" real,
    "AMOUNT" real,
    "REMARKS" text,
    "FISCAL_YEAR" character varying(15),
    "ACC_ID" integer,
    "IS_APARTMENT" character varying(2)
);
 '   DROP TABLE public."TBL_SANITAION_TAX";
       public         heap    postgres    false            c           1259    77069    TBL_STATUS_DETAILS    TABLE     H  CREATE TABLE public."TBL_STATUS_DETAILS" (
    "ID" integer NOT NULL,
    "MASTERID" integer,
    "ITEM_ID" integer,
    "BRAND_ID" integer,
    "SPEC_ID" integer,
    "UNIT_ID" integer,
    "RATE" real,
    "STOCK_QTY" real,
    "USE_IN_QTY" real,
    "NOT_USE_IN_QTY" real,
    "REPAIR_QTY" real,
    "NOT_REPAIR_QTY" real
);
 (   DROP TABLE public."TBL_STATUS_DETAILS";
       public         heap    postgres    false            e           1259    77082    TBL_TAXSOURCERECORDNEW    TABLE     �  CREATE TABLE public."TBL_TAXSOURCERECORDNEW" (
    "TAXSRCID" integer NOT NULL,
    "FISCALYEAR" character varying(10),
    "RECORDTYPE" integer,
    "NETINCOME_CURFY" integer,
    "TAXPAIDTAXPAYERCNT_CURFY" integer,
    "NETINCOME_LASTFY" integer,
    "TAXPAIDTAXPAYERCNT_LASTFY" integer,
    "TAXNOTPAIDTAXPAYERCNT" integer,
    "AMOUNTNOTCOLLECTED" integer,
    "TOTALTAXPAYERCNT" integer
);
 ,   DROP TABLE public."TBL_TAXSOURCERECORDNEW";
       public         heap    postgres    false            d           1259    77074    TBL_TAX_TYPE    TABLE     �   CREATE TABLE public."TBL_TAX_TYPE" (
    "ID" integer NOT NULL,
    "CODE" character varying(200),
    "NP_NAME" text,
    "ENG_NAME" character varying(200),
    "DESCRIPTIONG" text,
    "ACC_ID" integer
);
 "   DROP TABLE public."TBL_TAX_TYPE";
       public         heap    postgres    false            f           1259    77087    TBL_TOLABIKASA_ORG    TABLE     f  CREATE TABLE public."TBL_TOLABIKASA_ORG" (
    "ID" integer NOT NULL,
    "NP_NAME" character varying(150),
    "ENG_NAME" character varying(150),
    "ADDRESS" character varying(150),
    "CHAIRMAN" character varying(50),
    "SACHIBA" character varying(50),
    "CONTACTNO" character varying(50),
    "EMAIL" character varying(50),
    "WARDNO" integer
);
 (   DROP TABLE public."TBL_TOLABIKASA_ORG";
       public         heap    postgres    false            g           1259    77095    TBL_VEHICLE_PARTS    TABLE     �   CREATE TABLE public."TBL_VEHICLE_PARTS" (
    "SN" integer NOT NULL,
    "NP_NAME" character varying(200),
    "ENG_NAME" character varying(100),
    "REMARKS" text
);
 '   DROP TABLE public."TBL_VEHICLE_PARTS";
       public         heap    postgres    false            p           1259    77137    TBUSERSECURITYRIGHTS    TABLE     ]   CREATE TABLE public."TBUSERSECURITYRIGHTS" (
    "USERID" integer,
    "RIGHTSID" integer
);
 *   DROP TABLE public."TBUSERSECURITYRIGHTS";
       public         heap    postgres    false            q           1259    77140    TYPES    TABLE     �   CREATE TABLE public."TYPES" (
    "ID" integer,
    "NEPNAME" character varying(50) NOT NULL,
    "ENGNAME" character varying(50) NOT NULL,
    "CODE" character varying(50),
    "REMARKS" character varying(100)
);
    DROP TABLE public."TYPES";
       public         heap    postgres    false            r           1259    77143    USERASSIGNMENTS    TABLE     �  CREATE TABLE public."USERASSIGNMENTS" (
    "SN" integer,
    "NEPNAME" character varying(90),
    "RIGHTSNAME" character varying(200),
    "MODULE" character varying(5),
    "ACTIVE" boolean NOT NULL,
    "CREATEDAT" timestamp without time zone DEFAULT '2001-01-01 00:00:00'::timestamp without time zone NOT NULL,
    "CREATEDBY" character varying(100),
    "DISPLAYNAME" character varying(100),
    "ICON" character varying(50),
    "ISLOCKED" boolean NOT NULL,
    "MENUNAME" character varying(100),
    "MENUORDER" smallint DEFAULT '0'::smallint NOT NULL,
    "MENUURL" character varying(500),
    "PARENTMENUID" integer NOT NULL,
    "VISIBLE" boolean NOT NULL
);
 %   DROP TABLE public."USERASSIGNMENTS";
       public         heap    postgres    false            s           1259    77151 
   Usermaster    TABLE     �  CREATE TABLE public."Usermaster" (
    "Id" text NOT NULL,
    "UserName" character varying(256),
    "NormalizedUserName" character varying(256),
    "Email" character varying(256),
    "NormalizedEmail" character varying(256),
    "EmailConfirmed" boolean NOT NULL,
    "PasswordHash" text,
    "SecurityStamp" text,
    "ConcurrencyStamp" text,
    "PhoneNumber" text,
    "PhoneNumberConfirmed" boolean NOT NULL,
    "TwoFactorEnabled" boolean NOT NULL,
    "LockoutEnd" timestamp with time zone,
    "LockoutEnabled" boolean NOT NULL,
    "AccessFailedCount" integer NOT NULL,
    "Userid" text,
    "Userpassword" text,
    "Nepname" text,
    "Engname" text,
    "Userstatus" smallint,
    "Lastloggedon" timestamp without time zone,
    "Lastloggedout" timestamp without time zone,
    "Grants" text,
    "Updatedby" integer,
    "EmpId" integer,
    "OrgCode" text,
    "Code" text,
    "FromCentral" text,
    "WardNo" text,
    "PwdChangedDate" timestamp without time zone,
    "FiscalYear" text
);
     DROP TABLE public."Usermaster";
       public         heap    postgres    false            t           1259    77159    VDC    TABLE       CREATE TABLE public."VDC" (
    "VDCID" integer,
    "NEPNAME" character varying(50) NOT NULL,
    "ENGNAME" character varying(50) NOT NULL,
    "CODE" character varying(50),
    "REMARKS" character varying(100),
    "DISTRICTID" integer,
    "TYPEID" integer
);
    DROP TABLE public."VDC";
       public         heap    postgres    false            �           1259    78683    WARD_MASTER    TABLE     R  CREATE TABLE public."WARD_MASTER" (
    "ID" integer NOT NULL,
    "NEP_NAME" character varying(100),
    "ENG_NAME" character varying(50),
    "ADDRESS" character varying(50),
    "PRAMUKH_ID" integer,
    "UPPRAMUKH_ID" integer,
    "NUMBER_OF_MEMBERS" integer,
    "WARD_SECRETARY_ID" integer,
    "MOBILE_NO" character varying(20)
);
 !   DROP TABLE public."WARD_MASTER";
       public         heap    postgres    false            u           1259    77162    ZONE    TABLE     �   CREATE TABLE public."ZONE" (
    "ZONEID" integer,
    "NEPNAME" character varying(50) NOT NULL,
    "ENGNAME" character varying(50) NOT NULL,
    "CODE" character varying(50),
    "REMARKS" character varying(100),
    "REGIONID" integer
);
    DROP TABLE public."ZONE";
       public         heap    postgres    false            �            1259    76226    __EFMigrationsHistory    TABLE     �   CREATE TABLE public."__EFMigrationsHistory" (
    "MigrationId" character varying(150) NOT NULL,
    "ProductVersion" character varying(32) NOT NULL
);
 +   DROP TABLE public."__EFMigrationsHistory";
       public         heap    postgres    false            !           2604    79248    Imis_Menu Id    DEFAULT     r   ALTER TABLE ONLY public."Imis_Menu" ALTER COLUMN "Id" SET DEFAULT nextval('public."Imis_Menu_Id_seq"'::regclass);
 ?   ALTER TABLE public."Imis_Menu" ALTER COLUMN "Id" DROP DEFAULT;
       public          postgres    false    482    239            �          0    76324    ACCODE 
   TABLE DATA           �   COPY public."ACCODE" ("ACCODE", "SBCODE", "GRCODE", "TRANTYPE", "NEPNAME", "ENGNAME", "ISDOLLAR", "LOCALCODE", "ISASSIGNED") FROM stdin;
    public          postgres    false    221   I2                0    77211    ACC_ACC_MASTER 
   TABLE DATA             COPY public."ACC_ACC_MASTER" ("ACC_ID", "CODE", "NEP_NAME", "ENG_NAME", "PARENT_ACC_ID", "GRP_LEVEL", "IS_FIXED", "IS_TRANSACTABLE", "IS_BUDGETABLE", "DISP_CODE", "DISP_NAME", "ACC_TYPE", "TYPE_ID", "ACC_CODE", "SUB_MODULE_ID", "FISCAL_YEAR", "IS_HIDE", "ISCAPITALCURRENT") FROM stdin;
    public          postgres    false    378   f2      +          0    77383    ACC_ASULI_BIBARAN 
   TABLE DATA             COPY public."ACC_ASULI_BIBARAN" ("ASULI_ID", "PERSON_TYPE_ID", "PAYMENT_PERSON_ID", "PERSON_NAME", "WORK_NAME", "AMT_TAKEN", "RESPONSIVE_TAKEN", "COLLECT_REASON", "PESKI_AMT", "PESKI_EMPLOYEE_ID", "PROPERTY_DETAILS", "PROPERTY_EMPLOYEE_ID", "PROPERTY_ROKA") FROM stdin;
    public          postgres    false    392   �2                0    77242    ACC_BANK_GRNTY 
   TABLE DATA             COPY public."ACC_BANK_GRNTY" ("GRNTY_ID", "GRNTY_NO", "GRNTY_VS_DATE", "BANK_NAME", "GRNTY_AMOUNT", "GRNTY_TYPE", "WORK_ID", "PERSON_ID", "PHUKUWA_PS", "PHUKUWA_CN", "PHUKUWA_VS_DATE", "MAG_PS", "MAG_CN", "MAG_VS_DATE", "ENTRY_DATETIME", "EXPRY_VS_DATE") FROM stdin;
    public          postgres    false    380   �2      n          0    76231    ACC_BANK_STATEMENT 
   TABLE DATA           �   COPY public."ACC_BANK_STATEMENT" ("ID", "BANK_ID", "TRANSACTION_DATE", "TRANSACTION_DATE_EN", "CHEQUE_NO", "DESCRIPTION", "DR_AMT", "CR_AMT", "BANK_TRANSACTION_ID", "BALANCE") FROM stdin;
    public          postgres    false    203   �2      d          0    78270    ACC_BANK_TRANS 
   TABLE DATA           �   COPY public."ACC_BANK_TRANS" ("BANK_TRANS_ID", "VCHR_ID", "VCHR_DATE_NEP", "DESCRIPTION", "DR_AMT", "CR_AMT", "IS_OF_LASTYEAR", "TRANS_TYPE_ID", "BILL_ID", "BANK_ID") FROM stdin;
    public          postgres    false    449   �2      o          0    76234    ACC_BGT_ALLOCATE 
   TABLE DATA           �   COPY public."ACC_BGT_ALLOCATE" ("BGT_ALLOCATE_ID", "ACC_ID", "REVISED_AMOUNT", "AMOUNT", "FISCAL_YEAR", "ALLOCATED_DATE_NP", "ENTRY_USER_ID", "ENTRY_DATETIME", "UPDATE_USER_ID", "UPDATE_DATETIME", "SUB_MODULE_ID", "BUDGET_SOURCE_ID") FROM stdin;
    public          postgres    false    204   �2                0    77165    ACC_BGT_RVSN 
   TABLE DATA           �   COPY public."ACC_BGT_RVSN" ("ID", "BGT_ALCTN_ID", "RVSN_DATE_NP", "AMOUNT", "RVSN_REASON", "UPDATE_USER_ID", "UPDATE_DATETIME") FROM stdin;
    public          postgres    false    374   3      <          0    77583    ACC_BGT_TRANSFER 
   TABLE DATA           �   COPY public."ACC_BGT_TRANSFER" ("ID", "FROM_ACC_ID", "TO_ACC_ID", "BGT_ALCTN_ID", "TRNSFR_DATE_NP", "TRNSFR_REASON", "UPDATE_USER_ID", "UPDATE_DATETIME", "AMOUNT") FROM stdin;
    public          postgres    false    409   13      *          0    77368    ACC_BUDJET_SOURCE 
   TABLE DATA           c   COPY public."ACC_BUDJET_SOURCE" ("ID", "MIN_ACC_ID", "SOURCE_ID", "AMOUNT", "REMARKS") FROM stdin;
    public          postgres    false    391   N3      e          0    78292    ACC_CASH_TRANS 
   TABLE DATA           �   COPY public."ACC_CASH_TRANS" ("CASH_TRANS_ID", "VCHR_ID", "VCHR_DATE_NEP", "DESCRIPTION", "DR_AMT", "CR_AMT", "IS_OF_LASTYEAR", "INCOME_EXP_TYPE_ID", "BILL_ID") FROM stdin;
    public          postgres    false    450   k3      p          0    76239    ACC_CHEQUE_TYPES 
   TABLE DATA           M   COPY public."ACC_CHEQUE_TYPES" ("CHEQUE_TYPE_ID", "CHEQUE_TYPE") FROM stdin;
    public          postgres    false    205   �3      q          0    76244    ACC_CURRENCTY 
   TABLE DATA           P   COPY public."ACC_CURRENCTY" ("ID", "NP_NAME", "ENG_NAME", "SYMBOL") FROM stdin;
    public          postgres    false    206   �3                0    77175    ACC_CURRENCTY_RATE 
   TABLE DATA           V   COPY public."ACC_CURRENCTY_RATE" ("ID", "CURRENCY_ID", "NP_DATE", "RATE") FROM stdin;
    public          postgres    false    375   �3      G          0    77733    ACC_DHRTI_BILL_DTL 
   TABLE DATA           �   COPY public."ACC_DHRTI_BILL_DTL" ("DHRTI_DTL_ID", "DHRTI_MASTER_ID", "BILL_NO", "BILL_DATE_NP", "COUNTER_ID", "PERSON_ID", "AMOUNT", "VCHR_ID", "ACC_ID", "VCHR_DATE_NP", "ORDER_IN_BILL", "REMARKS", "BUDGET_SOURCE_ID", "WORK_ID") FROM stdin;
    public          postgres    false    420   �3      H          0    77753    ACC_DHRTI_BILL_MASTER 
   TABLE DATA           �  COPY public."ACC_DHRTI_BILL_MASTER" ("DHRTI_MASTER_ID", "BILL_NO", "DESCRIPTION", "COUNTER_ID", "PERSON_ID", "BLL_DATE_NP", "CASH_AMT", "BANK_AMT", "VCHR_ID", "VCHR_DATE_NP", "USERID", "USERIDE", "DATE_ENTRY_VS_DATE", "DATE_ENTRY_TIME", "DATE_EDIT_TIME", "NAME", "ADDRESS", "WARD_NO", "CANCEL_DATE", "CANCEL_REASON", "BILL_NO_MANUAL", "FISCAL_YEAR", "BILLTYPEID", "SUB_MODULE_ID", "WORK_ID") FROM stdin;
    public          postgres    false    421   �3      =          0    77603    ACC_EXPENSES_DETAILS 
   TABLE DATA           7  COPY public."ACC_EXPENSES_DETAILS" ("EXPENSE_ID", "TRANS_TYPE_ID", "PERSON_TYPE_ID", "EMP_ID", "PADADHIKARI_ID", "ORG_ID", "UC_ID", "WARD_ID", "WORK_ID", "ACC_ID", "DR_AMT", "CR_AMT", "VAT_AMT", "PAYMENT_SLIP_ID", "VCHR_ID", "VCHR_DATE_NP", "ORDER_IN_PAYMENT_SLIP", "ADVEXPTYPE", "IS_OF_LAST_YEAR") FROM stdin;
    public          postgres    false    410   4      r          0    76252    ACC_FUND_PROVIDR_MSTR 
   TABLE DATA           �   COPY public."ACC_FUND_PROVIDR_MSTR" ("PROVIDER_ID", "NAME_NP", "NAME_EN", "PHONES", "EMAILS", "CHAIRMAN", "CONTACT_PERSON") FROM stdin;
    public          postgres    false    207   64      s          0    76257    ACC_INCOME_RATE 
   TABLE DATA           W   COPY public."ACC_INCOME_RATE" ("RATE_ID", "ACC_ID", "RATE", "FISCAL_YEAR") FROM stdin;
    public          postgres    false    208   S4      u          0    76267    ACC_LASTYEAR_ADV_DETAILS 
   TABLE DATA           +  COPY public."ACC_LASTYEAR_ADV_DETAILS" ("ID", "PAYMENT_ID", "FISCAL_YEAR", "WORK_ID", "VHCR_ID", "ACC_ID", "BUDGET_ACC_ID", "BUDGET_SOURCE_ID", "PAYMENT_TYPE_ID", "PERSON_ID", "DR_AMOUNT", "STATUS", "REMARKS", "ADD_USER_ID", "ADD_DATE", "VOUCHER_NO", "VOUCHER_DATE", "LAST_YR_PESKI_ID") FROM stdin;
    public          postgres    false    210   p4      t          0    76262    ACC_LAST_YR_PESKI 
   TABLE DATA           �   COPY public."ACC_LAST_YR_PESKI" ("SN", "PERSON_TYPE_ID", "PERSON_ID", "ADVANCE_TYPE", "SUB_MODULE_ID", "TOTAL_PES_REM") FROM stdin;
    public          postgres    false    209   �4      v          0    76272    ACC_ORG_MASTER 
   TABLE DATA             COPY public."ACC_ORG_MASTER" ("ORG_ID", "NAME_NP", "NAME_EN", "ADDRESS", "PHONES", "EMAILS", "REG_NO", "VAT_NO", "PAN_NO", "ZONE", "DISTRICT", "VDC", "MINISTRY", "CODE", "HEAD", "MOBILE_NO", "RELATED_PERSON", "ORG_MASTER_ID", "SAPATI", "ORC_ACC_TYPE_ID") FROM stdin;
    public          postgres    false    211   �4                0    77198    ACC_PADADHIKARI_MSTR 
   TABLE DATA           6  COPY public."ACC_PADADHIKARI_MSTR" ("PADADIKARI_ID", "NAME_NP", "NAME_EN", "POST_ID", "ADDRESS", "WARD_NO", "ELECTED_DATE_NP", "QUALIFICATION", "MOBILE_NO", "LAST_NAME_NP", "LAST_NAME_EN", "TITLE", "GENDER", "RELIGION_ID", "MOTHER_LANG_ID", "DATE_OF_BIRTH", "PARENT_NAME", "P_OCUPATION", "SPOUSE_NAME", "S_OCUPATION", "GRANDFATHER_NAME", "GF_OCUPATION", "MARRIED_STATUS", "NO_OF_SON", "NO_OF_DAUGHTER", "FIRST_APPOINT_DATE", "FIRST_APPOINT_POST_ID", "CURRENT_POST_APPOINT_DATE", "RETIRE_DATE", "PRE_EXPERIENCE", "ZONE_ID", "DISTRICT_ID", "VDC_ID", "TRACK_ID", "STREET", "PHONES", "EMAILS", "MOBILE", "CITIZENSHIP_NO", "CITZN_ISSUED_DATE", "CITZN_ISSUED_DISTR_ID", "IS_TOILET_IN_HOME", "SPECIAL_NOTES", "USER_ID", "USER_IDE", "DATA_ENTRY_VS_DATE", "DATA_ENTRY_AD_DATE", "DATA_EDIT_AD_DATE", "DATE_OF_BIRTH_AD") FROM stdin;
    public          postgres    false    377   �4      w          0    76280    ACC_PADADHIKARI_POST 
   TABLE DATA           r   COPY public."ACC_PADADHIKARI_POST" ("POST_ID", "NAME_NP", "NAME_EN", "DURATION_IN_YRS", "POST_LEVEL") FROM stdin;
    public          postgres    false    212   �4      >          0    77633    ACC_PAYMENT_CLEARANCE 
   TABLE DATA           �   COPY public."ACC_PAYMENT_CLEARANCE" ("ID", "PAYMENT_ID", "IS_OF_LAST_YEAR", "ACC_ID", "BUDGET_ACC_ID", "AMOUNT", "BUDGET_SOURCE_ID") FROM stdin;
    public          postgres    false    411   5      x          0    76285    ACC_PAYMENT_CREDIT 
   TABLE DATA           �   COPY public."ACC_PAYMENT_CREDIT" ("ID", "PAYMENT_ID", "IS_OF_LAST_YEAR", "ACC_ID", "BUDGET_ACC_ID", "BUDGET_SOURCE_ID", "AMOUNT") FROM stdin;
    public          postgres    false    213   5      b          0    78208    ACC_PAYMENT_DEDUCTION 
   TABLE DATA           �   COPY public."ACC_PAYMENT_DEDUCTION" ("ID", "PAYMENT_ID", "ACC_ID", "BUDGET_ACC_ID", "AMOUNT", "STATUS", "DEDUCTIONTYPE", "BUDGET_SOURCE_ID") FROM stdin;
    public          postgres    false    447   ;5      c          0    78228    ACC_PAYMENT_DETAILS 
   TABLE DATA           �  COPY public."ACC_PAYMENT_DETAILS" ("PAYMENT_DETAIL_ID", "PAYMENT_ID", "TRANS_TYPE_ID", "PERSON_TYPE_ID", "EMP_ID", "PADADHIKARI_ID", "ORG_ID", "UC_ID", "WARD_ID", "WORK_ID", "ACC_ID", "BUDGET_ACC_ID", "DR_AMT", "CR_AMT", "VAT_AMT", "PAYMENT_SLIP_ID", "VCHR_ID", "VCHR_DATE_NP", "ORDER_IN_PAYMENT_SLIP", "ADVEXPTYPE", "IS_OF_LAST_YEAR", "FISCAL_YEAR", "BUDGET_SOURCE_ID", "SUB_MODULE_ID", "ADVANCE_TYPE", "EXPIRE_DATE_NP", "SUPPLIER_ID") FROM stdin;
    public          postgres    false    448   X5      I          0    77781    ACC_PAYMENT_MASTER 
   TABLE DATA           �  COPY public."ACC_PAYMENT_MASTER" ("PAYMENT_ID", "TRANS_TYPE_ID", "PERSON_TYPE_ID", "PERSON_ID", "WORK_ID", "BILL_NO", "BILL_AMT", "VAT_AMT", "PAYMENT_DESCRIPTION", "RETENTION_MONEY_EDUCTION", "CONTRACT_TAX_DEDUCTION", "INCOME_TAX_DEDUCTION", "LAST_YEARS_ADV_DEDUCTION", "VAT_DEDUCTION", "OTHER_DEDUCTION", "CHEQUE_PAYMENT", "CASH_PAYMENT", "ADV_CLEARED_FROM_BILL", "ADV_CLEARED_FROM_BANK", "ADV_CLEARED_FROM_CASH", "LY_ADV_CLEARED_FROM_BILL", "LY_ADV_CLEARED_FROM_BANK", "LY_ADV_CLEARED_FROM_CASH", "ADVEXPTYPE", "VCHR_ID", "VCHR_DATE_NP", "FISCAL_YEAR", "SUB_MODULE_ID", "ISPESKI", "DEDUCT_DEP_VCHR_ID", "DEDUCT_DEP_VCHR_DATE_NEP", "ACC_DEDUCT_DEP_VCHR_ID", "ACC_DEDUCT_DEP_VCHR_DATE", "EXPIRE_DATE_NP", "CR_AMOUNT", "SUBJECT_AREA_ID") FROM stdin;
    public          postgres    false    422   u5      y          0    76288    ACC_RECEIVABLE 
   TABLE DATA           �   COPY public."ACC_RECEIVABLE" ("SN", "TAXPAYERID", "FISCALYEAR", "NETTAXAMOUNT", "FINEAMOUNT", "ADDITIONALCHARGES", "REDUCTIONALCHARGES", "TAXTYPE", "TYPE", "VCHRID", "VCHR_DATE") FROM stdin;
    public          postgres    false    214   �5      z          0    76291    ACC_SUB_MODULE_TYPE 
   TABLE DATA           �   COPY public."ACC_SUB_MODULE_TYPE" ("SUB_MODULE_ID", "NAME_NP", "NAME_EN", "MODULE", "CODE", "ISCAPITAL", "BUDGET_ACC_NO", "ISEXPENCES", "ACC_EXPENCES_CODE") FROM stdin;
    public          postgres    false    215   �5      {          0    76296    ACC_TRANS_TYPE 
   TABLE DATA           d   COPY public."ACC_TRANS_TYPE" ("TYPE_ID", "TYPE_CODE", "NEP_NAME", "ENG_NAME", "MODULE") FROM stdin;
    public          postgres    false    216   �5      |          0    76301    ACC_UNAUTHORISED 
   TABLE DATA           �   COPY public."ACC_UNAUTHORISED" ("UNAUTHORISED_ID", "SUB_MODULE_ID", "WORK_ID", "UNAUTHORISED_DAFA_ID", "UNAUTHORISED_AMT", "INSPECT_DATE", "INSPECT_DETAILS", "INSPECT_AMT", "FILLEDBY_EMPID", "VERIFIEDBY_EMPID") FROM stdin;
    public          postgres    false    217   �5      }          0    76306    ACC_USER_COMITE_MSTR 
   TABLE DATA           �   COPY public."ACC_USER_COMITE_MSTR" ("ID", "NEP_NAME", "ENG_NAME", "WARD", "ADDRESS", "EMAIL", "PHONES", "CHAIRMAN", "CONCERN_PERSON", "MOBILE_NO") FROM stdin;
    public          postgres    false    218   6      J          0    77811    ACC_VCHR_DETAILS 
   TABLE DATA           q  COPY public."ACC_VCHR_DETAILS" ("VCHR_DETAIL_ID", "VCHR_ID", "ACC_ID", "DR_AMT", "CR_AMT", "VCHR_TYPE_ID", "ID_FROM_SRC", "ACC_TYPE", "TRANS_TYPE_ID", "VCHR_DATE_ENG", "VCHR_DATE_NEP", "REMARKS", "IS_POSTED", "MODULE", "SUB_MODULE_ID", "BUDGET_SOURCE_ID", "BANKID", "BILL_ID", "BUDGET_ACC_ID", "ORG_ID", "WORK_ID", "IS_JAFAT", "EXPIRE_DATE_NP", "IS_GROUP") FROM stdin;
    public          postgres    false    423   #6                0    77224    ACC_VCHR_MASTER 
   TABLE DATA           �  COPY public."ACC_VCHR_MASTER" ("VCHR_ID", "VCHR_NO", "VCHR_DATE_NEP", "VCHR_TYPE_ID", "NARRATION", "USER_ID", "UPDATE_DATE", "FISCALYEAR", "MODULE", "IS_POSTED", "SUB_MODULE_ID", "NAME_CHEQUE_PAYEE", "IS_OF_LAST_YEAR", "REMARKS", "CHEQUE_TYPE_ID", "FATHER_NAME", "GRAND_FATHER_NAME", "CONTACT_PHONE", "IS_NIKASH", "WARDNO", "PREP_BY", "CHECK_BY", "ACCEPT_BY", "INTERNAL_LEKHA", "NIYAMIT_AMT", "ASULI_AMT", "VALID_AMT", "N_VALID_AMT") FROM stdin;
    public          postgres    false    379   @6      ~          0    76314    ACC_VCHR_TYPE_MASTER 
   TABLE DATA           |   COPY public."ACC_VCHR_TYPE_MASTER" ("VCHR_TYPE_ID", "NEP_NAME", "ENG_NAME", "MODULE", "ISAUTOMATIC", "ISFIXED") FROM stdin;
    public          postgres    false    219   ]6                 0    77257    ACC_WORK_FUNDS_DETAIL 
   TABLE DATA           �   COPY public."ACC_WORK_FUNDS_DETAIL" ("FUND_DETAIL_ID", "WORK_ID", "PROVIDER_ID", "FUNDED_AMT", "FUNDED_PERCENT", "ISJANASARAMDHA", "ISOWNOFFICE") FROM stdin;
    public          postgres    false    381   z6                0    76319    ACC_WORK_MASTER 
   TABLE DATA           {  COPY public."ACC_WORK_MASTER" ("WORK_ID", "NAME_NP", "NAME_EN", "ESTIMATED_AMT", "VARIATION_AMT", "CORRECTED_AMT", "FINAL_ACTUAL_AMT_TOBE_PAID", "TOTAL_ACTUAL_COST", "AGREEMENT_PARTY", "AGREEMENT_AMT", "AGREEMENT_DATE", "AGREEMENT_EXPIRY_DATE", "WORK_COMPLETE_DATE", "MEASURE_BOOK_NO", "DEPOSIT_AMT", "BANK_GUARANTEE_AMT", "DEPOSIT_RELEASE_DATE", "DEPOSIT_RELEASED_DATE", "WARD_NO", "IS_COMPLETED", "DEADLINE_DATE", "TP_NO", "BANKID", "EMP_ID", "PARTY_PERSONTYPEID", "PARTY_ID", "PERSON_PERSONTYPEID", "PERSON_ID", "DEPOSITS_ACC_ID", "DEPOSITS_FORFEIT_ACC_ID", "IS_KRAMAGAT", "YOJANA_NATUR_ID", "AGREEMENT_SIGNING_PERSON") FROM stdin;
    public          postgres    false    220   �6      K          0    77843    ACC_WORK_PAYMNT_TRANS 
   TABLE DATA           �   COPY public."ACC_WORK_PAYMNT_TRANS" ("TRANS_ID", "WORK_ID", "PAYMENT_SLIP_ID", "PERSON_TYPE_ID", "EMP_ID", "PADADHIKARI_ID", "ORG_ID", "UC_ID", "BILL_AMT", "VAT_AMT", "VCHR_ID", "VCHR_DATE_NP", "IS_OF_LAST_YEAR", "FISCAL_YEAR") FROM stdin;
    public          postgres    false    424   �6      �          0    76329    APPLICATION_CONFIGURATION 
   TABLE DATA           Z   COPY public."APPLICATION_CONFIGURATION" ("SN", "NAME_CONFIG", "VALUE_CONFIG") FROM stdin;
    public          postgres    false    222   �6      �          0    76334 
   BANKMASTER 
   TABLE DATA           �   COPY public."BANKMASTER" ("BANKID", "ENGNAME", "NEPNAME", "BANKCODE", "SUB_MODULE_ID", "ADDRESS", "PHONES", "EMAILS", "ACCOUNTNUMBER", "BRANCHCODE", "TRANCODE", "CYCODE", "FINANCEL_INSTITUTE_ID", "BRANCH", "BANKNAME") FROM stdin;
    public          postgres    false    223   �6      `          0    78162    BANKTRANSACTIONS 
   TABLE DATA           Z  COPY public."BANKTRANSACTIONS" ("SN", "BANKID", "DESCRIPTION", "DRAMOUNT", "CRAMOUNT", "INCOMEEXPTYPEID", "ISOFLASTYEAR", "VCHR_DATE_NP", "ORDERINPAYMENTSLIP", "VCHR_ID", "BILLID", "MODULE", "SUBMODULE_TYPE_ID", "DHRTI_MASTER_ID", "EXP_SLIP_ID", "PAYMENT_ORDER_NO", "CHEQUE_TYPE_ID", "PAYEENAME", "BUDGET_SOURCE_ID", "PAYEENAME_ENG") FROM stdin;
    public          postgres    false    445   7      !          0    77272    BANK_BRANCH 
   TABLE DATA           �   COPY public."BANK_BRANCH" ("BRANCH_ID", "BANKID", "NEPNAME", "ENGNAME", "BRANCH_CODE", "ADDRESS", "EMAIL", "PHONE", "IS_PERMITTED") FROM stdin;
    public          postgres    false    382   (7      �          0    76342    BUDJET_SOURCE 
   TABLE DATA           �   COPY public."BUDJET_SOURCE" ("ID", "PARENT_ID", "COUNTRY_ID", "CODE", "EMAIL", "PHONE", "ADDRESS", "NEP_NAME", "ENG_NAME", "REMARKS") FROM stdin;
    public          postgres    false    224   E7      �          0    76350    BUDJET_SUB_HEAD 
   TABLE DATA           �   COPY public."BUDJET_SUB_HEAD" ("ID", "CODE", "MINISTRY_ID", "MINISTRY_CODE", "PARENT_CODE", "FISCAL_YEAR", "NEPNAME", "ENGNAME", "REMARKS") FROM stdin;
    public          postgres    false    225   b7      �          0    76356    BUSINESSMASTER_HISTORY 
   TABLE DATA           �   COPY public."BUSINESSMASTER_HISTORY" ("ID", "BIZ_ID", "NEPNAME", "BUSINESSGROUPID", "TAXPAYERID", "ADD_DATE", "COMPUTER_NAME", "DATA_STATUS", "WINDOWS_USER", "TRAN_TIME") FROM stdin;
    public          postgres    false    226   7      a          0    78185    CASHTRANSACTION 
   TABLE DATA           �   COPY public."CASHTRANSACTION" ("SN", "DESCRIPTION", "DRAMOUNT", "CRAMOUNT", "INCOMEEXPTYPEID", "ISOFLASTYEAR", "VCHR_DATE_NP", "VCHR_ID", "BILLID", "MODULE", "SUBMODULE_TYPE_ID", "DHRTI_MASTER_ID", "EXP_SLIP_ID", "BUDGET_SOURCE_ID") FROM stdin;
    public          postgres    false    446   �7      �          0    76359    CELEDGER20682069 
   TABLE DATA           �  COPY public."CELEDGER20682069" ("SN", "IID", "HOUSEID", "CONSTRUCTIONTYPEID", "CONSTRUCTIONID", "TALANUMBER", "TOTALAREA", "RATEID", "RATEPERUNIT", "CALCULATEDVALUE", "VSDATEOFMADE", "DEPPERCENT", "DEPRECIATIONAMOUNT", "OTHERPLUSINEVALUATIONS", "OTHERMINUSINEVALUATIONS", "OTHERPLUSMINUSDESCRIPTIONS", "NETCALCULATEDVALUE", "NONCOMPLETIONREASONID", "NONCOMPLETIONREASONS", "REMARKS", "SPACEMEASURINGUNIT", "TAXED") FROM stdin;
    public          postgres    false    227   �7      �          0    76362    COLLECTIONCOUNTERS 
   TABLE DATA           �   COPY public."COLLECTIONCOUNTERS" ("COUNTERID", "NEPNAME", "COUNTERHEADID", "WARDNO", "LOCATION", "SPECIALNOTES", "CMPTR_NAME", "MACADDRESS") FROM stdin;
    public          postgres    false    228   �7      �          0    76367    CONSTANTVALUES 
   TABLE DATA           G   COPY public."CONSTANTVALUES" ("SN", "VARNAME", "STRVALUE") FROM stdin;
    public          postgres    false    229   �7      �          0    76373    CONTACTS 
   TABLE DATA           a   COPY public."CONTACTS" ("ID", "NEPNAME", "ENGNAME", "CODE", "DISTRICTID", "REMARKS") FROM stdin;
    public          postgres    false    230   8      �          0    76378    COUNTRY 
   TABLE DATA           R   COPY public."COUNTRY" ("ID", "NEPNAME", "ENGNAME", "CODE", "REMARKS") FROM stdin;
    public          postgres    false    231   -8      �          0    76381    DDC 
   TABLE DATA           \   COPY public."DDC" ("ID", "NEPNAME", "ENGNAME", "CODE", "REMARKS", "DISTRICTID") FROM stdin;
    public          postgres    false    232   J8      �          0    76384 
   DEV_REGION 
   TABLE DATA           U   COPY public."DEV_REGION" ("ID", "NEPNAME", "ENGNAME", "CODE", "REMARKS") FROM stdin;
    public          postgres    false    233   g8      �          0    76387    DISTRICT 
   TABLE DATA           e   COPY public."DISTRICT" ("DISTRICTID", "NEPNAME", "ENGNAME", "CODE", "REMARKS", "ZONEID") FROM stdin;
    public          postgres    false    234   �8      �          0    76390    EMP_GRP 
   TABLE DATA           ?   COPY public."EMP_GRP" ("ID", "NEPNAME", "ENGNAME") FROM stdin;
    public          postgres    false    235   �8      ?          0    77648    FIREBRIGADESTATE 
   TABLE DATA           �   COPY public."FIREBRIGADESTATE" ("ID", "NEPNAME", "SERVICECHARGERATE", "MINIMUMSERVICECHARGE", "ACC_ID", "TYPE", "FISCAL_YEAR", "RATEID") FROM stdin;
    public          postgres    false    412   �8      �          0    76395    FISCALYEARS 
   TABLE DATA           Q   COPY public."FISCALYEARS" ("SN", "FISCALYEAR", "DATEFROM", "DATETO") FROM stdin;
    public          postgres    false    236   �8      �          0    76398    FYWISERENTDARRATE 
   TABLE DATA           s   COPY public."FYWISERENTDARRATE" ("ID", "RATEID", "RATENAME", "RENT_PER", "RENT_TYPEID", "FISCAL_YEAR") FROM stdin;
    public          postgres    false    237   �8      �          0    76403    FYWISESANITATION_RATE 
   TABLE DATA           �   COPY public."FYWISESANITATION_RATE" ("ID", "RATEID", "GROUPID", "SUBGROUPID", "ROAD_TYPEID", "RATENAME", "RATE", "FISCAL_YEAR", "AREA_UPTO", "FOR_EACH_AREA", "EACH_AREA_RATE") FROM stdin;
    public          postgres    false    238   9      �          0    76419    IMISRole 
   TABLE DATA           X   COPY public."IMISRole" ("Id", "Name", "NormalizedName", "ConcurrencyStamp") FROM stdin;
    public          postgres    false    240   29      $          0    77302    IMISRoleClaim 
   TABLE DATA           T   COPY public."IMISRoleClaim" ("Id", "RoleId", "ClaimType", "ClaimValue") FROM stdin;
    public          postgres    false    385   O9      7          0    77516    IMISUserClaim 
   TABLE DATA           T   COPY public."IMISUserClaim" ("Id", "UserId", "ClaimType", "ClaimValue") FROM stdin;
    public          postgres    false    404   l9      8          0    77529    IMISUserLogin 
   TABLE DATA           j   COPY public."IMISUserLogin" ("LoginProvider", "ProviderKey", "ProviderDisplayName", "UserId") FROM stdin;
    public          postgres    false    405   �9      9          0    77542    IMISUserRole 
   TABLE DATA           <   COPY public."IMISUserRole" ("UserId", "RoleId") FROM stdin;
    public          postgres    false    406   �9      :          0    77560    IMISUserToken 
   TABLE DATA           U   COPY public."IMISUserToken" ("UserId", "LoginProvider", "Name", "Value") FROM stdin;
    public          postgres    false    407   �9      L          0    77863    INCOMEBILLDETAILS 
   TABLE DATA           "  COPY public."INCOMEBILLDETAILS" ("SN", "BILLID", "BILLNO", "BILLDATE", "COUNTERID", "PERSONID", "ACCODE", "AMOUNT", "VCHR_DATE_NP", "ORDERINBILL", "REMARKS", "VCHR_ID", "ACC_ID", "FISCAL_YEAR", "PROJECT", "TAXADDTNLID", "TAX_TYPE", "QTY", "BUDGET_SOURCE_ID", "BACKUP_PERSONID") FROM stdin;
    public          postgres    false    425   �9      �          0    76427    INCOMEBILLDETAILS_HISTORY 
   TABLE DATA           �  COPY public."INCOMEBILLDETAILS_HISTORY" ("SN", "SN_INCOMEBILLDTL", "BILLID", "BILLNO", "BILLDATE", "COUNTERID", "PERSONID", "ACCODE", "AMOUNT", "VRNO", "VCHR_DATE_NP", "ORDERINBILL", "REMARKS", "VCHR_ID", "ACC_ID", "FISCAL_YEAR", "PROJECT", "TAXADDTNLID", "QTY", "BUDGET_SOURCE_ID", "TAX_TYPE", "BACKUP_PERSONID", "ADD_DATE", "COMPUTER_NAME", "DATA_STATUS", "WINDOWS_USER", "TRAN_TIME") FROM stdin;
    public          postgres    false    241   �9      M          0    77878    INCOMEBILLMASTER 
   TABLE DATA           �  COPY public."INCOMEBILLMASTER" ("SN", "BILLNO", "DESCRIPTION", "COUNTERID", "PERSONID", "BILLDATE", "CASHAMOUNT", "BANKAMOUNT", "VCHR_ID", "VCHR_DATE_NP", "USERID", "USERIDE", "DATAENTRYVSDATE", "DATAENTRYADDATETIME", "DATAEDITADDATETIME", "BILLTYPEID", "TAXINCOMETYPE", "NAME", "ADDRESS", "WARD_NO", "CANCEL_DATE", "CANCEL_REASON", "BILL_NO_MANUAL", "FISCAL_YEAR", "PROJECT", "SUB_MODULE_ID", "CURRENCY_ID", "BACKUP_PERSONID") FROM stdin;
    public          postgres    false    426   :      �          0    76433    INV_APPLICANT_RATE 
   TABLE DATA           _   COPY public."INV_APPLICANT_RATE" ("ID", "APPLICANTID", "ITEM_DETAIL_ID", "AMOUNT") FROM stdin;
    public          postgres    false    242   7:      �          0    76438 	   INV_BRAND 
   TABLE DATA           T   COPY public."INV_BRAND" ("BRAND_ID", "NAME_NP", "NAME_EN", "IS_ACTIVE") FROM stdin;
    public          postgres    false    243   T:      �          0    76443    INV_DEPLIST 
   TABLE DATA             COPY public."INV_DEPLIST" ("ID", "FISCALYEAR", "DAKHILA_ID", "ITEM_ID", "QTY", "PURCHASE_DATE", "PURCHASE_AMT", "BRAND_ID", "SPEC_ID", "UNIT_ID", "DEPRE_DURATON", "DEPRE_PER", "DEPRE_AMT", "MAX_DEPRE_AMT", "MIN_DEPRE_AMT", "DEDUCT_AMT", "NET_AMT") FROM stdin;
    public          postgres    false    244   q:      �          0    76448    INV_DEPRECIATION 
   TABLE DATA           �   COPY public."INV_DEPRECIATION" ("ID", "FISCALYEAR", "DAKHILA_ID", "ITEM_ID", "BRAND_ID", "SPEC_ID", "UNIT_ID", "QTY", "ORGINAL_RATE", "DEPRE_RATE", "DEPRE_PER") FROM stdin;
    public          postgres    false    245   �:      �          0    76453    INV_DEPT 
   TABLE DATA           _   COPY public."INV_DEPT" ("DEPT_ID", "NAME_NP", "NAME_EN", "OFFICE_ID", "IS_ACTIVE") FROM stdin;
    public          postgres    false    246   �:      g          0    78329    INV_GOODS_ADJUST 
   TABLE DATA           ;  COPY public."INV_GOODS_ADJUST" ("ID", "DAKHILA_ID", "GD_ADJ_ID", "BUDGET_YEAR", "MONTH", "ITEM_ID", "ITEM_TYPE", "SPEC_ID", "BRAND_ID", "ADJ_QTY", "ADJ_TYPE_ID", "ITEM_ADJ_RATE", "ADJ_DT_NP", "ADJ_DT_ENG", "REMARKS", "PREP_BY", "PREP_DT_NP", "PREP_DT_ENG", "ACCEPT_BY", "ACCEPT_DT_NP", "ACCEPT_DT_ENG") FROM stdin;
    public          postgres    false    452   �:                0    78808    INV_GOODS_REC_DETL 
   TABLE DATA             COPY public."INV_GOODS_REC_DETL" ("ID", "GOODS_MASTER_ID", "ITEM_ID", "UNIT_ID", "BRAND_ID", "SPEC_ID", "PUR_QTY", "RECV_QTY", "RATE", "WHETHER_TAX", "TAX_PER_UNIT_AMT", "DISC_AMT", "OTHER_EXPENCES_AMT", "NET_AMT", "REMARKS", "ISNUMBERED", "DAKHILA_DT_ENG") FROM stdin;
    public          postgres    false    476   �:      h          0    78359    INV_GOODS_REC_MAST 
   TABLE DATA           n  COPY public."INV_GOODS_REC_MAST" ("ID", "DAKHILA_ID", "PUR_MASTER_ID", "REPAIR_ID", "DAKHILA_DT", "WAREHOUSE_ID", "INV_BILL_NO", "INV_DATE", "DETAILS_NEP", "DETAILS_ENG", "PREP_BY", "PREP_DT", "CHECK_BY", "CHECK_DT", "ACCEPT_BY", "ACCEPT_DT", "DAKHILA_DT_ENG", "INV_DATE_ENG", "PREP_DT_ENG", "CHECK_DT_ENG", "ACCEPT_DT_ENG", "FISCAL_YEAR", "PAYMENT_ID") FROM stdin;
    public          postgres    false    453   ;      �          0    76458    INV_INCREASE_DECREASE 
   TABLE DATA           �   COPY public."INV_INCREASE_DECREASE" ("ID", "NUM_ID", "DAKHILA_ID", "ITEM_ID", "BRAND_ID", "SPEC_ID", "UNIT_ID", "PURCHASE_DATE", "STOCK_QTY", "AMOUNT", "SCAP_AMOUNT", "FISCALYEAR") FROM stdin;
    public          postgres    false    247   ;      �          0    76463    INV_ISSUE_DAKHILA 
   TABLE DATA           �   COPY public."INV_ISSUE_DAKHILA" ("ID", "ITEM_ID", "SPEC_ID", "BRAND_ID", "UNIT_ID", "ISSUE_DETAIL_ID", "ISSU_MASTER_ID", "DAKHILA_ID", "ISSUE_NO", "REMARKS") FROM stdin;
    public          postgres    false    248   <;      O          0    77921    INV_ISSUE_DETAIL 
   TABLE DATA           �   COPY public."INV_ISSUE_DETAIL" ("ID", "ISSUE_MAST_ID", "ITEM_ID", "SPEC_ID", "BRAND_ID", "ITEM_TYPE", "ITEM_REQ_NO", "ITEM_ISSUE_NO", "ISSUE_DT", "DELIVERY_STATUS", "REMARKS", "ISSUE_DT_ENG") FROM stdin;
    public          postgres    false    428   Y;      �          0    78919    INV_ISSUE_MASTER 
   TABLE DATA           I  COPY public."INV_ISSUE_MASTER" ("ID", "ISSUE_NO", "REQUEST_ID", "ISSUE_BY", "ISSUE_RECEIVE", "RECEIVE_EMP_ID", "ISSUE_DT", "REMARKS", "ISSUE_BY_CAT", "HO_NAME", "HO_POST", "PREP_BY", "PREP_DT", "CHECK_BY", "CHECK_DT", "ACCEPT_BY", "ACCEPT_DT", "BUDGET_YEAR", "TYPE", "TRANSFER_DECISION_NO", "TRANSFER_DECISION_DATE") FROM stdin;
    public          postgres    false    479   v;      �          0    76471    INV_ITEM_ADJ_TYPE 
   TABLE DATA           `   COPY public."INV_ITEM_ADJ_TYPE" ("ID", "NAME_NP", "NAME_EN", "ADD_SUB", "ADJ_TYPE") FROM stdin;
    public          postgres    false    249   �;      �          0    76476    INV_ITEM_CATEGORY 
   TABLE DATA             COPY public."INV_ITEM_CATEGORY" ("ID", "NAME_NP", "NAME_EN", "PARENT_ID", "GRP_LEVEL", "IS_HEADER", "ISEXP", "ISLAST", "CODE", "UNIT", "MINL", "MAXL", "RMINL", "RMAXL", "DEPRECIATION_PER", "DEPRECIATION_MIN", "DEPRECIATION_MAX", "REMARKS", "ITEM_ID") FROM stdin;
    public          postgres    false    250   �;      �          0    78839    INV_ITEM_DETAILS 
   TABLE DATA           �  COPY public."INV_ITEM_DETAILS" ("ITEM_DTL_ID", "ITEM_ID", "BRAND_ID", "SPEC_ID", "QTY", "ITEM_RATE", "ITEM_STATUS", "BUDGET_YEAR", "DAKHILA_ID", "ENTRY_DT", "ISSUE_ID", "ISSUE_DT", "GD_ADJ_ID", "ADJ_TYPE", "LILAM_ID", "LILAM_DT", "STOK_RT_ID", "STOK_RT_DT", "ENGINE_NO", "CHASIS_NO", "MODEL_NO", "REG_NO", "WEIGHT_VEH", "PREP_BY", "PREP_DT", "CHECK_BY", "CHECK_DT", "ACCEPT_BY", "ACCEPT_DT", "UNIT", "REL_UNIT", "REL_QTY") FROM stdin;
    public          postgres    false    477   �;      '          0    77335    INV_ITEM_MST 
   TABLE DATA           �  COPY public."INV_ITEM_MST" ("ITEM_ID", "NAME_NP", "NAME_EN", "UNIT_ID", "ITEM_MAIN_CLASS", "ITEM_TYPE", "ITEM_NATURE", "MAXL", "MINL", "RMAXL", "RMINL", "GUSSAGE", "SIZES", "COUNTRYID", "COMPANYNAME", "SOURCE", "REMARKS", "CODE", "KITTA_NO", "LAND_LOCATION", "CONSTRUCTONTYPE", "DEPRECIATION", "MINRATE", "DEPMAXRATE", "PROPERTYTYPE", "LAND_AREA_INSQ_FEETS", "AREA_INSQ_FEETS", "LAND_UNIT_RATE", "LAND_MARKET_RATE", "LANDID", "ACC_ID", "BUDGET_ACC_ID", "VEHICLE_PARTS_ID") FROM stdin;
    public          postgres    false    388   �;      �          0    76484    INV_ITEM_SPEC 
   TABLE DATA           W   COPY public."INV_ITEM_SPEC" ("SPEC_ID", "NAME_NP", "NAME_EN", "IS_ACTIVE") FROM stdin;
    public          postgres    false    251   <      i          0    78382    INV_ITEM_STATUSCHECK 
   TABLE DATA             COPY public."INV_ITEM_STATUSCHECK" ("ID", "ITEM_ID", "SPEC_ID", "BRAND_ID", "INSP_ST_DATE", "INSP_ST_DATE_ENG", "INSP_ED_DATE", "INSP_ED_DATE_ENG", "STK_MST_COUNT", "COUNT_YES_NO", "STK_CUR_COUNT", "COUNT_UP_DOWN", "INSPECT_DATE", "INSPECT_DATE_ENG", "UP_DOWN_DETAIL", "REMARKS", "PREP_BY", "PREP_DATE", "PREP_DATE_ENG", "TALLY_BY", "CHECKED_DATE", "CHECK_QTY", "RATE", "CHECKED_DATE_ENG", "ACCEPTED_BY", "ACCEPTED_DATE", "ACCEPTED_DATE_ENG", "FISICAL_YEAR", "IS_ACTIVE", "UP_DOWN_NO", "CHECK_STATUS") FROM stdin;
    public          postgres    false    454   $<      &          0    77325    INV_LILAMAPPDETAILS 
   TABLE DATA           �   COPY public."INV_LILAMAPPDETAILS" ("ID", "LILAMAPPLIID", "DAKHILAID", "NIKASHAID", "ITEMID", "UNITID", "BRANDID", "SPECID", "LILAMQTY", "LILAMTOTALAMT") FROM stdin;
    public          postgres    false    387   A<      �          0    76489    INV_LILAM_APPMASTER 
   TABLE DATA           �   COPY public."INV_LILAM_APPMASTER" ("ID", "APPNO", "PROJID", "APPLYLILAMID", "ORGAPPLICANTNAME", "ORGAPPLICANTPOST", "APPLYDATE", "APPLYENGDATE", "REMARKS") FROM stdin;
    public          postgres    false    252   ^<      �          0    76494    INV_LILAM_DETAIL 
   TABLE DATA           	  COPY public."INV_LILAM_DETAIL" ("ID", "MINIMUMRATE", "LILAM_ID", "DAKHILAID", "NIKASHAID", "ITEM_ID", "UNIT_ID", "SPEC_ID", "BRAND_ID", "ITEM_TYPE", "ITEM_ISSUE_NO", "TOTAL_IN_STOCK", "DEP_AMT", "ISSUE_DT", "DELIVERY_STATUS", "REMARKS", "ISSUE_DT_ENG") FROM stdin;
    public          postgres    false    253   {<      �          0    76502    INV_LILAM_MAST 
   TABLE DATA           �  COPY public."INV_LILAM_MAST" ("ID", "LILAM_NO", "ISSUE_BY", "LILAMTYPE", "RECEIVE_BY", "RECEIVE_PERSON_NAME", "RECIVE_PERSON_POST", "REMARKS", "PREP_BY", "CHECK_BY", "ISSUE_DT", "ACCEPT_BY", "ACCEPT_DT", "PREP_DT", "CHECK_DT", "ISSUE_DT_ENG", "PREP_DT_ENG", "CHECK_DT_ENG", "FISCAL_YEAR", "ACCEPT_DT_ENG", "PAGENO", "REGISTERNO", "PUBLISH_DATE", "DESCRIPTION", "NEWSPAPER_NAME", "PERNEWS_RATE", "ACCEPT_PERCENT", "BANKID", "VALID_DAYS", "FISCALYEAR_CHUKTA") FROM stdin;
    public          postgres    false    254   �<      �          0    76510    INV_LILAM_REC_LIST 
   TABLE DATA           g   COPY public."INV_LILAM_REC_LIST" ("ID", "REC_DATE_NP", "APPLICANTID", "EMP_ID", "USER_ID") FROM stdin;
    public          postgres    false    255   �<      �          0    76513    INV_ORG_TYPE 
   TABLE DATA           Q   COPY public."INV_ORG_TYPE" ("ID", "NAME_NP", "NAME_EN", "IS_ACTIVE") FROM stdin;
    public          postgres    false    256   �<      �          0    76518    INV_PROJECT 
   TABLE DATA           X   COPY public."INV_PROJECT" ("PROJECT_ID", "NAME_NP", "NAME_EN", "IS_ACTIVE") FROM stdin;
    public          postgres    false    257   �<      �          0    76523    INV_PUR_MAST_PLAN 
   TABLE DATA           !  COPY public."INV_PUR_MAST_PLAN" ("ID", "NAME_NP", "NAME_EN", "PKG_NO", "APPROX_AMT", "BUDGET1YEAR", "BUDGET2YEAR", "BUDGET3YEAR", "PUR_TYPE", "AGREEMENT_TYPE", "BUDGET_RESOURCE", "WORK_ST_DATE", "WORK_END_DATE", "WORK_ST_DATE_AD", "WORK_END_DATE_AD", "BUDGET_YEAR", "REMARKS") FROM stdin;
    public          postgres    false    258   =      �          0    78884    INV_PUR_ORDER_DETL 
   TABLE DATA           �   COPY public."INV_PUR_ORDER_DETL" ("ID", "PUR_MST_ID", "ITEM_ID", "UNIT_ID", "SPEC_ID", "BRAND_ID", "ITEM_TYPE", "QTY", "ITEM_RATE", "TOTAL_AMT", "TAX_AMT", "REMARKS", "ISDAKHILA") FROM stdin;
    public          postgres    false    478   )=      j          0    78417    INV_PUR_ORDER_MAST 
   TABLE DATA             COPY public."INV_PUR_ORDER_MAST" ("ID", "PUR_ORDER_NO", "REPAIR_ORDER_NO", "LETTER_ORDER_NO", "CUSTOM_ORDER_NO", "PUR_TYPE", "PUR_ORDER_TYPE", "SUPP_ID", "REQ_ID", "BUDGET_YEAR", "RETURN_ITEM_DT", "RETURN_ITEM_DT_ENG", "PREPARED_BY", "PREPARED_DT", "PREPARED_DT_ENG", "CHECKED_BY", "CHECKED_DT", "CHECKED_DT_ENG", "ACCEPTED_BY", "ACCEPTED_DT", "ACCEPTED_DT_ENG", "PUR_ORDER_DT", "DAKHILA_LAST_ENTRY_DT", "PUR_ORDER_DT_ENG", "ISDAKHILA", "REMARKS", "ACCOUNTID", "PURCHASE_DECISION_NO", "PURCHASE_DECISION_DATE") FROM stdin;
    public          postgres    false    455   F=      �          0    76528    INV_PUR_TYPE 
   TABLE DATA           ]   COPY public."INV_PUR_TYPE" ("ID", "NEP_NAME", "NEP_ENG", "REMARKS", "ISDEFAULT") FROM stdin;
    public          postgres    false    259   c=      k          0    78445    INV_REQUISITION_MAST 
   TABLE DATA           �  COPY public."INV_REQUISITION_MAST" ("ID", "REQ_ID", "REQ_DATE_NEP", "REQ_BY", "TYPE_ID", "ITEM_ID", "MAINTAIN_ITEM_ID", "PROJ_ID", "HANDOVER_ID", "HANDOVER_ROOM_ID", "FISCAL_YEAR", "REMARKS", "PREP_BY", "PREP_DT", "CHECK_BY", "CHECK_DT", "ACCEPT_BY", "ACCEPT_DT", "ORGSTAFFNAME", "ORGSTAFFPOST", "REQ_TYPE", "USERID", "VEHICLE_ID", "REASION", "REQ_DATE_ENG", "PREP_DT_ENG", "CHECK_DT_ENG", "ACCEPT_DT_ENG", "PURCHASE_GIVE", "STOCK_GIVE") FROM stdin;
    public          postgres    false    456   �=      �          0    78949    INV_REQ_DETAIL 
   TABLE DATA           �   COPY public."INV_REQ_DETAIL" ("ID", "REQ_MAST_ID", "ITEM_ID", "SPEC_ID", "BRAND_ID", "QTY", "REMARKS", "IS_ACTIVE") FROM stdin;
    public          postgres    false    480   �=      %          0    77315    INV_ROOM_MST 
   TABLE DATA           l   COPY public."INV_ROOM_MST" ("ROOM_ID", "FLOOR_NO", "BLOCK_NO", "DESC_NP", "DESC_EN", "DEPT_ID") FROM stdin;
    public          postgres    false    386   �=      l          0    78483    INV_STATUS_DETAIL 
   TABLE DATA             COPY public."INV_STATUS_DETAIL" ("ID", "CODE", "STATUSDATEAD", "STATUSDATEVS", "FISCAL_YEAR", "TOTALQTY", "ITEM_ID", "BRAND_ID", "SPEC_ID", "ITEM_STATUS_ID", "REMARKS", "PREBY", "PREVSDATE", "CHECKEDBY", "CHECKVSDATE", "ACCEPTBY", "MAIN_ID", "ACCEPTVSDATE") FROM stdin;
    public          postgres    false    457   �=      �          0    76536    INV_SUPPLIER 
   TABLE DATA           �   COPY public."INV_SUPPLIER" ("SUP_ID", "NAME_NP", "NAME_EN", "COMPANY_NAME_NP", "COMPANY_NAME_EN", "REGI_TYPE", "TPIN_PAN_NO", "ADDRESS", "PHONE_NO", "EMAIL", "DATE_VS", "DATE_AD", "ORG_TYPE", "ORG_ID", "IS_SELECTED", "REG_NO", "SUP_TYPE") FROM stdin;
    public          postgres    false    261   �=      �          0    76544    INV_SUPPLIER_FISCALYEAR 
   TABLE DATA           R   COPY public."INV_SUPPLIER_FISCALYEAR" ("ID", "SUP_ID", "FISCAL_YEAR") FROM stdin;
    public          postgres    false    262   >      �          0    76531    INV_SUP_ITM_DET 
   TABLE DATA           n   COPY public."INV_SUP_ITM_DET" ("ID", "ITEM_ID", "SUP_ID", "QTY", "RATE", "ACC_ID", "FISCAL_YEAR") FROM stdin;
    public          postgres    false    260   .>      �          0    76549    INV_TAX_RATE 
   TABLE DATA           Y   COPY public."INV_TAX_RATE" ("TAX_RATE_ID", "NAME_NP", "NAME_EN", "TAX_RATE") FROM stdin;
    public          postgres    false    263   K>      �          0    76554    INV_TYPE_SETUP 
   TABLE DATA           ^   COPY public."INV_TYPE_SETUP" ("ID", "DESC_NP", "DESC_EN", "TYPE_ID", "IS_ACTIVE") FROM stdin;
    public          postgres    false    264   h>      �          0    76559    INV_UNIT 
   TABLE DATA           }   COPY public."INV_UNIT" ("UNIT_ID", "DESC_NP", "DESC_EN", "MUL_FACTOR", "RELATED_TO", "NO_OF_UNITS", "IS_ACTIVE") FROM stdin;
    public          postgres    false    265   �>      �          0    76564    INV_WAREHOUSE 
   TABLE DATA           \   COPY public."INV_WAREHOUSE" ("WAREHOUSE_ID", "NAME_NP", "NAME_EN", "IS_ACTIVE") FROM stdin;
    public          postgres    false    266   �>      �          0    76569    INV_YRLY_PUR_PLAN 
   TABLE DATA           �  COPY public."INV_YRLY_PUR_PLAN" ("ID", "NAME_NP", "NAME_EN", "APPROX_AMT", "PUR_TYPE", "AGREEMENT_TYPE", "APRX_AMT_ACPT_DATE", "INFO_PUBLISH_DATE", "TENDR_SALE_DATE", "FORM_ENTRY_DATE", "TENDR_OPEN_DATE", "TENDR_ACCEPT_DATE", "WRK_ORDER_DATE", "WRK_ACMPLSH_DATE", "ANLYSIS_DSGN_DT_AD", "APRX_AMT_ACPT_DT_AD", "TENDR_ACCEPT_DT_AD", "TENDR_CALL_DT_AD", "TENDR_OPEN_DT_AD", "AGREEMENT_DT_AD", "WRK_2_FIN_DT_AD", "WRK_ACMPLSH_DT_AD", "REMARKS") FROM stdin;
    public          postgres    false    267   �>      �          0    76574    IPTTAXSUMMARY_HISTORY 
   TABLE DATA           L  COPY public."IPTTAXSUMMARY_HISTORY" ("SN", "IID", "FISCALYEAR", "NETTAXAMOUNT", "FINEAMOUNT", "ADDITIONALCHARGES", "REDUCTIONALCHARGES", "ISTHISFROMREVENUEACCOUNT", "TAXPAIDAMOUNT", "DATEPAID", "SPECIALNOTES", "USERID", "USERIDE", "DATAENTRYVSDATE", "DATAENTRYADDATETIME", "DATAEDITADDATETIME", "BILLID", "BILLNO", "LAST_TAX_PAID_AMOUNT", "TAX_TYPE", "REM_IPT_PAID_AMOUNT", "REM_HL_PAID_AMOUNT", "REM_IPT_FINE_AMOUNT", "REM_HL_FINE_AMOUNT", "REM_HL_FINE_STATUS", "REM_IPT_FINE_STATUS", "YEAR", "MONTH", "ADD_DATE", "COMPUTER_NAME", "DATA_STATUS", "WINDOWS_USER", "TRAN_TIME") FROM stdin;
    public          postgres    false    268   �>      �          0    76580    ISSUEDBILLS 
   TABLE DATA           �   COPY public."ISSUEDBILLS" ("SN", "DATEISSUED", "THELINO", "BILLNOFROM", "BILLNOTO", "COUNTERID", "USERID", "SPECIALNOTES") FROM stdin;
    public          postgres    false    269   �>      �          0    76411 	   Imis_Menu 
   TABLE DATA           �   COPY public."Imis_Menu" ("MenuName", "MenuUrl", "DisplayName", "ParentMenuId", "Active", "IsLocked", "Visible", "Icon", "MenuOrder", "CreatedBy", "UpdateBy", "DisplayNepName", "CreatedAt", "UpdatedAt", "Id") FROM stdin;
    public          postgres    false    239   ?      �          0    76583    LANDMEASURINGUNITS 
   TABLE DATA           S   COPY public."LANDMEASURINGUNITS" ("UNITID", "UNITNAME", "SQFTPERUNIT") FROM stdin;
    public          postgres    false    270   pA      �          0    76586    LANDSMULTIEVALUATIONDETAIL 
   TABLE DATA           {   COPY public."LANDSMULTIEVALUATIONDETAIL" ("SN", "IID", "LANDID", "KITTANUMBER", "GENERALRATEID", "AREAINSQFT") FROM stdin;
    public          postgres    false    271   �A      �          0    76589    LELEDGER20682069 
   TABLE DATA           �  COPY public."LELEDGER20682069" ("SN", "IID", "LANDID", "WARDNO", "TRACKID", "KITTANUMBER", "TOTALAREA", "NONEVALUATEDAREA", "NETEVALUATINGAREA", "RATEID", "RATEPERUNIT", "CALCULATEDVALUE", "OTHERPLUSINEVALUATIONS", "OTHERMINUSINEVALUATIONS", "OTHERPLUSMINUSDESCRIPTIONS", "NETCALCULATEDVALUE", "SELFDECLAREDVALUE", "APPLIEDVALUE", "NONCOMPLETIONREASONID", "NONCOMPLETIONREASONS", "REMARKS", "LANDMEASURINGUNIT", "TAXED") FROM stdin;
    public          postgres    false    272   �A      �          0    76592    MALPOT_LANDS 
   TABLE DATA             COPY public."MALPOT_LANDS" ("ID", "IID", "EID", "NP_FIRSTNAME", "NP_LASTNAME", "OLDVDCID", "OLDWORDNO", "MOTHNUMBER", "KITTANUMBER", "VDCID", "WORDNO", "AREAINSQFT", "NONFUNCTIONALAREAINSQFT", "ADD_USERID", "EDIT_USERID", "ADD_DATE", "EDIT_DATE", "IS_IPT") FROM stdin;
    public          postgres    false    273   �A      (          0    77348    MAP_AREA_GND_COV 
   TABLE DATA           _   COPY public."MAP_AREA_GND_COV" ("ID", "REGIONID", "GROUND_COV", "AREA", "REMARKS") FROM stdin;
    public          postgres    false    389   �A      �          0    76600    MAP_CONSTRCTION_KIND 
   TABLE DATA           [   COPY public."MAP_CONSTRCTION_KIND" ("ID", "NAME_NP", "NAME_EN", "DESCRIPTION") FROM stdin;
    public          postgres    false    274   B      �          0    76605    MAP_DESIGNER_DTL 
   TABLE DATA           �   COPY public."MAP_DESIGNER_DTL" ("ID", "REG_NO", "ENGCOUNCILREG_NO", "FIRM_NAME", "DESIGNER_NAME", "ADDRESS", "PHONE_NO", "CLASS", "STATUS_ID", "REMARKS") FROM stdin;
    public          postgres    false    275   B      �          0    76613    MAP_DIRECTION 
   TABLE DATA           T   COPY public."MAP_DIRECTION" ("ID", "NAME_NP", "NAME_EN", "DESCRIPTION") FROM stdin;
    public          postgres    false    276   ;B      �          0    76618    MAP_DRAIN_TYPE 
   TABLE DATA           U   COPY public."MAP_DRAIN_TYPE" ("ID", "NAME_NP", "NAME_EN", "DESCRIPTION") FROM stdin;
    public          postgres    false    277   XB      �          0    76623 	   MAP_FLOOR 
   TABLE DATA           P   COPY public."MAP_FLOOR" ("ID", "NAME_NP", "NAME_EN", "DESCRIPTION") FROM stdin;
    public          postgres    false    278   uB      �          0    76628    MAP_HOUSEUSE_TYPE 
   TABLE DATA           X   COPY public."MAP_HOUSEUSE_TYPE" ("ID", "NAME_NP", "NAME_EN", "DESCRIPTION") FROM stdin;
    public          postgres    false    279   �B      �          0    76633    MAP_HTSTANDARD 
   TABLE DATA           O   COPY public."MAP_HTSTANDARD" ("SN", "KV", "DISTANCEFT", "REMARKS") FROM stdin;
    public          postgres    false    280   �B      @          0    77658    MAP_INCOME_TYPE 
   TABLE DATA           `   COPY public."MAP_INCOME_TYPE" ("ID", "NAME_NP", "NAME_EN", "ACC_ID", "DESCRIPTION") FROM stdin;
    public          postgres    false    413   �B      �          0    76638    MAP_LAND_OWNER_TYPE 
   TABLE DATA           Z   COPY public."MAP_LAND_OWNER_TYPE" ("ID", "NAME_NP", "NAME_EN", "DESCRIPTION") FROM stdin;
    public          postgres    false    281   �B      �          0    76643    MAP_NEIGHBOUR_TYPE 
   TABLE DATA           Y   COPY public."MAP_NEIGHBOUR_TYPE" ("ID", "NAME_NP", "NAME_EN", "DESCRIPTION") FROM stdin;
    public          postgres    false    282   C      �          0    76648    MAP_RATE 
   TABLE DATA           x   COPY public."MAP_RATE" ("ID", "DESCRIPTION", "RATE_PERMIT", "DEPOSITE_RATE_PERMIT", "USERID", "ENTRY_DATE") FROM stdin;
    public          postgres    false    283   #C      )          0    77358    MAP_REGION_FAR 
   TABLE DATA           u   COPY public."MAP_REGION_FAR" ("ID", "REGIONID", "AREA_FROM", "AREA_TO", "FISCAL_YEAR", "FAR", "REMARKS") FROM stdin;
    public          postgres    false    390   @C      �          0    76653    MAP_ROOF_CNSTRCT_TYPE 
   TABLE DATA           \   COPY public."MAP_ROOF_CNSTRCT_TYPE" ("ID", "NAME_NP", "NAME_EN", "DESCRIPTION") FROM stdin;
    public          postgres    false    284   ]C      �          0    76658    MAP_ROOF_TYPE 
   TABLE DATA           T   COPY public."MAP_ROOF_TYPE" ("ID", "NAME_NP", "NAME_EN", "DESCRIPTION") FROM stdin;
    public          postgres    false    285   zC      �          0    76663    MAP_SITE 
   TABLE DATA           i   COPY public."MAP_SITE" ("SN", "PERMITID", "LANDSHAPE", "SIDE_A", "SIDE_B", "SIDE_C", "AREA") FROM stdin;
    public          postgres    false    286   �C      �          0    76668    MAP_STDHEIGHT_RW 
   TABLE DATA           j   COPY public."MAP_STDHEIGHT_RW" ("ID", "ROAD_WIDTH", "HOUSE_HEIGHT", "FISCAL_YEAR", "REMARKS") FROM stdin;
    public          postgres    false    287   �C      �          0    76673    MAP_STOREYS 
   TABLE DATA           R   COPY public."MAP_STOREYS" ("ID", "NAME_NP", "NAME_EN", "DESCRIPTION") FROM stdin;
    public          postgres    false    288   �C      �          0    76678    MAP_STRUCTURE_TYPE 
   TABLE DATA           Y   COPY public."MAP_STRUCTURE_TYPE" ("ID", "NAME_NP", "NAME_EN", "DESCRIPTION") FROM stdin;
    public          postgres    false    289   �C      �          0    76683    MAP_ZONE 
   TABLE DATA           O   COPY public."MAP_ZONE" ("ID", "NAME_NP", "NAME_EN", "DESCRIPTION") FROM stdin;
    public          postgres    false    290   D      �          0    76688    MINISTRY 
   TABLE DATA           �   COPY public."MINISTRY" ("ID", "CODE", "ZONE", "DISTRICT", "VDC", "PHONE", "ADDRESS", "NEPNAME", "ENGNAME", "REMARKS") FROM stdin;
    public          postgres    false    291   (D      �          0    76694    MINISTRY_ACC_HEAD 
   TABLE DATA           u   COPY public."MINISTRY_ACC_HEAD" ("ID", "MINISTRY_ID", "ACC_ID", "SUB_HEAD_ID", "FISCAL_YEAR", "REMARKS") FROM stdin;
    public          postgres    false    292   ED      �          0    76699    NATIONALITIES 
   TABLE DATA           g   COPY public."NATIONALITIES" ("NATIONALITYID", "CODE", "NEPNAME", "ENGNAME", "DESCRIPTION") FROM stdin;
    public          postgres    false    293   bD      �          0    76702    NEW_PROPERTY_TAXTABLE 
   TABLE DATA           �   COPY public."NEW_PROPERTY_TAXTABLE" ("SN", "RATESN", "FROMPROPERTYVALUE", "TOPROPERTYVALUE", "FROMTAXAMOUNT", "TOTAXAMOUNT", "REMARKS", "FISCALYEAR", "TAX_PERCENT") FROM stdin;
    public          postgres    false    294   D      �          0    76707    OFFICE_TYPE 
   TABLE DATA           H   COPY public."OFFICE_TYPE" ("OFFICE_TYPE_ID", "OFFICE_TYPE") FROM stdin;
    public          postgres    false    295   �D      .          0    77426    ORGANIZATION_TREE 
   TABLE DATA           �   COPY public."ORGANIZATION_TREE" ("ID", "PARENT_ID", "NEP_NAME", "ENG_NAME", "CONTAINS_DARBANDI", "GEO_REGION", "GRP_LEVEL") FROM stdin;
    public          postgres    false    395   �D      N          0    77901    ORG_BANK_ACCOUNT 
   TABLE DATA              COPY public."ORG_BANK_ACCOUNT" ("ID", "ORG_ID", "BANKID", "BRANCH_ID", "BANK_ACCNT_TYPE_ID", "ACC_NO", "ACC_NAME") FROM stdin;
    public          postgres    false    427   �D      �          0    76712    PAYMENT_SLIP_MASTER 
   TABLE DATA             COPY public."PAYMENT_SLIP_MASTER" ("PAYMENT_SLIP_ID", "PAYMENT_DESCRIPTION", "TRANSACTION_TYPEID", "PERSON_TYPE_ID", "PERSON_ID", "WORK_ID", "BILL_AMT", "VAT_AMT", "RETENTION_MONEY_EDUCTION", "CONTRACT_TAX_DEDUCTION", "INCOME_TAX_DEDUCTION", "LAST_YEARS_ADV_DEDUCTION", "VAT_DEDUCTION", "OTHER_DEDUCTION", "CHEQUE_PAYMENT", "CASH_PAYMENT", "ADV_CLEARED_FROM_BILL", "ADV_CLEARED_FROM_BANK", "ADV_CLEARED_FROM_CASH", "LY_ADV_CLEARED_FROM_BILL", "LY_ADV_CLEARED_FROM_BANK", "LY_ADV_CLEARED_FROM_CASH", "IS_PESKI", "VR_NO", "VR_DATE") FROM stdin;
    public          postgres    false    296   �D      �          0    76717    PERSON_TYPE_MASTER 
   TABLE DATA           a   COPY public."PERSON_TYPE_MASTER" ("PERSON_TYPE_ID", "NAME_NP", "NAME_EN", "ISFIXED") FROM stdin;
    public          postgres    false    297   E      �          0    76725    PIS_APPOINTMENT_TYPE 
   TABLE DATA           [   COPY public."PIS_APPOINTMENT_TYPE" ("ID", "NAME_NP", "NAME_EN", "DESCRIPTION") FROM stdin;
    public          postgres    false    298   -E      �          0    76730    PIS_ATTRIBUTES 
   TABLE DATA           W   COPY public."PIS_ATTRIBUTES" ("ID", "NAME_NEP", "DESCRIPTION", "APPLY_TO") FROM stdin;
    public          postgres    false    299   JE      P          0    77946 
   PIS_AWARDS 
   TABLE DATA           �   COPY public."PIS_AWARDS" ("SN", "EMP_ID", "LOCAL_POST_ID", "NEP_NAME", "LEVEL_DESC", "DESCRIPTION", "WORKING_OFFICE", "RVCD_DATE_VS", "RCVD_DATE_AD", "REMARKS", "APPLY_TO") FROM stdin;
    public          postgres    false    429   gE      m          0    78503    PIS_BANK_PAYROLL 
   TABLE DATA           c   COPY public."PIS_BANK_PAYROLL" ("SN", "EMP_ID", "BANK_ID", "BANK_FOLIO", "ACCOUNT_NO") FROM stdin;
    public          postgres    false    458   �E      Q          0    77956    PIS_DARBANDI 
   TABLE DATA           �   COPY public."PIS_DARBANDI" ("DARBANDI_ID", "OFFICE_ID", "POST_ID", "POST_LEVEL", "LOCAL_POST_ID", "SEWA_SAMUHA_UPASAMUHA", "NO_OF_POST") FROM stdin;
    public          postgres    false    430   �E      }          0    78763    PIS_DELETD_FRM_FULFILD_DARB 
   TABLE DATA           �   COPY public."PIS_DELETD_FRM_FULFILD_DARB" ("SN", "EMP_ID", "FRM_SN_IN_FD", "FRM_OFFICE_ID", "FRM_DARBANDI_ID", "FRM_DATE_FULFILLED", "FRM_APPOINTMNT_TYPE", "TO_SN_IN_FD") FROM stdin;
    public          postgres    false    474   �E      ,          0    77396    PIS_EDUCATION 
   TABLE DATA           �   COPY public."PIS_EDUCATION" ("SN", "EMP_ID", "EDU_NAME", "EDU_LEVEL_ID", "INSTITUTE", "BOARD_ID", "MARKS_PERCNT", "MARKS_GRADE", "DIVISION", "COMPLETION_YR_VS", "COMPLETION_YR_AD", "SUBJECTS", "VALID_FOR_EVAL", "APPLY_TO") FROM stdin;
    public          postgres    false    393   �E      �          0    76735    PIS_EDU_BOARD 
   TABLE DATA           ^   COPY public."PIS_EDU_BOARD" ("ID", "NAME_NEP", "NAME_ENG", "COUNTRY_ID", "PLACE") FROM stdin;
    public          postgres    false    300   �E      �          0    76740    PIS_EDU_LEVEL 
   TABLE DATA           ?   COPY public."PIS_EDU_LEVEL" ("EDU_ID", "EDU_NAME") FROM stdin;
    public          postgres    false    301   F      R          0    77976    PIS_EMPLOYEE_MASTER 
   TABLE DATA           �  COPY public."PIS_EMPLOYEE_MASTER" ("EMP_ID", "FIRST_NAME_NP", "LAST_NAME_NP", "FIRST_NAME_EN", "LAST_NAME_EN", "POST_ID", "SERVICE_GROUP", "TITLE", "GENDER", "FATHER_NAME", "HUSBAND_NAME", "WILL_PERSON", "ADDRESS", "DATE_OF_BIRTH", "FIRST_APPOINT_DATE", "FIRST_APPOINT_POST_ID", "CURRENT_POST_APPOINT_DATE", "SERVICE_STATUS", "POST_STATUS", "GRADES", "CIT_PERCENT", "PAYMODE", "GOVT_EMP_ID", "PF_ID", "CIT_ID", "POST_LEVEL", "RETIRE_DATE", "LOCAL_POST_ID", "PHONES", "EMAILS", "PAYEMENT_BANK_ID", "MARRIED_STATUS", "INSURANCE_NO", "MOBILE_NO", "RELIGION", "PARENT_OCUPATION", "SPOUSE_OCUPATION", "GF_NAME", "GF_OCUPATION", "REL_WITH_WILL_PERSON", "ZONE_ID", "DISTRICT_ID", "VDC_ID", "WARD_NO", "MAIL_ADDRESS", "APPOINMENT_TYPE", "CITIZENSHIP_NO", "CS_ISSUED_DATE", "CS_ISSUED_DISTRICT", "DATE_OF_BIRTH_AD", "INSURANCE_FACILITY", "DEDUCT_ABSENT", "LEKHA_NO", "DEPT_ID", "PENSION_KOSH", "CIT_CODE", "ROOM_ID", "CODE") FROM stdin;
    public          postgres    false    431   2F      n          0    78518    PIS_EMP_ADV_DED_DTL 
   TABLE DATA           f   COPY public."PIS_EMP_ADV_DED_DTL" ("ID", "EMP_ID", "ACC_ID", "AMOUNT_CUR", "AMOUNT_PREV") FROM stdin;
    public          postgres    false    459   OF      �          0    76745    PIS_EMP_BARGA 
   TABLE DATA           T   COPY public."PIS_EMP_BARGA" ("ID", "NAME_NP", "NAME_EN", "DESCRIPTION") FROM stdin;
    public          postgres    false    302   lF      �          0    76750    PIS_EMP_DEP 
   TABLE DATA           �  COPY public."PIS_EMP_DEP" ("DEPT_ID", "NAME_NP", "NAME_EN", "DESCRIPTION", "SALARY_ACC_ID", "ALLOWANCE_ACC_ID", "ADD_PF_ACC_ID", "ADD_INSRNCE_ACC_ID", "SUB_PF_ACC_ID", "SUB_INSRNCE_ACC_ID", "CIT_ACC_ID", "INCME_TAX_ACC_ID", "LEND_PF_D_ACC_ID", "SOC_SEC_TAX", "BHATTA_ACC_ID", "PESKI_KATTI_ACC_ID", "OTHR_KATTI_ACC_ID", "ABSNT_KATTI_ACC_ID", "SAPATI_KATTI_ACC_ID", "BUDGET_SOURCE_ID", "TDS_ACC_ID", "WORK_ID", "BUDJET_SOURCE_ID") FROM stdin;
    public          postgres    false    303   �F      -          0    77411    PIS_EMP_DEP_SOURCE 
   TABLE DATA           M   COPY public."PIS_EMP_DEP_SOURCE" ("DEPT_ID", "BUDJET_SOURCE_ID") FROM stdin;
    public          postgres    false    394   �F      �          0    76755    PIS_EMP_INSURANCE_PAID 
   TABLE DATA           f   COPY public."PIS_EMP_INSURANCE_PAID" ("ID", "EMP_ID", "AMOUNT", "FISCAL_YEAR", "REMARKS") FROM stdin;
    public          postgres    false    304   �F      o          0    78528    PIS_EMP_LOANS 
   TABLE DATA           �   COPY public."PIS_EMP_LOANS" ("LOAN_ID", "NAME_NP", "NAME_EN", "EMP_ID", "ACC_ID", "LOAN_AMT", "INSTALLMENT_AMT", "PAID_AMOUNT", "CLEARED") FROM stdin;
    public          postgres    false    460   �F      p          0    78538    PIS_EMP_LONG_LEAVES 
   TABLE DATA           �   COPY public."PIS_EMP_LONG_LEAVES" ("SN", "EMP_ID", "LOCAL_POST_ID", "LEAVE_NAME", "WORKING_OFFICE", "FROM_DATE_VS", "TO_DATE_VS", "REMARKS") FROM stdin;
    public          postgres    false    461   �F      q          0    78553    PIS_EMP_MED_EXPENSE 
   TABLE DATA           �   COPY public."PIS_EMP_MED_EXPENSE" ("SN", "EMP_ID", "LOCAL_POST_ID", "WORKING_OFFICE", "ISSUED_DATE", "REGULAR_AMT", "SPECIAL_AMT", "REMARKS") FROM stdin;
    public          postgres    false    462   G      r          0    78568    PIS_EMP_PUNISHMNTS 
   TABLE DATA           �   COPY public."PIS_EMP_PUNISHMNTS" ("SN", "EMP_ID", "LOCAL_POST_ID", "WORKING_OFFICE", "PUNISH_TYPE", "PUNISH_DATE", "REMARKS") FROM stdin;
    public          postgres    false    463   7G      s          0    78583    PIS_EMP_SRVC_DTLS 
   TABLE DATA           �   COPY public."PIS_EMP_SRVC_DTLS" ("SN", "EMP_ID", "LOCAL_POST_ID", "OFFICE_DETAIL", "GEO_REGION", "APPOINTMENT_TYPE", "DATE_FROM", "DATE_TO", "REMARKS") FROM stdin;
    public          postgres    false    464   TG      t          0    78598    PIS_EMP_SUSPENDS 
   TABLE DATA           �   COPY public."PIS_EMP_SUSPENDS" ("SN", "EMP_ID", "LOCAL_POST_ID", "NAME_NP", "WORKING_OFFICE", "FROM_DATE_VS", "TO_DATE_VS", "REMARKS") FROM stdin;
    public          postgres    false    465   qG      u          0    78613    PIS_EMP_TRNSFR_REC 
   TABLE DATA           �   COPY public."PIS_EMP_TRNSFR_REC" ("SN", "EMP_ID", "LOCAL_POST_ID", "REF_NO", "TRNSFR_DATE", "AMT_TAKEN", "TRNSFRD_OFFICE", "MOVED_DATE", "REMARKS", "USER_ID", "USER_IDE", "DATA_ENTRY_VS_DATE", "DATA_ENTRY_AD_DATE", "DATA_EDIT_AD_DATE") FROM stdin;
    public          postgres    false    466   �G      S          0    78009    PIS_FOREIGN_VISITS 
   TABLE DATA           �   COPY public."PIS_FOREIGN_VISITS" ("SN", "EMP_ID", "LOCAL_POST_ID", "WORKING_OFFICE", "FROM_DATE_VS", "TO_DATE_VS", "FROM_DATE_AD", "TO_DATE_AD", "VISITING_PRPSE", "FUNDED_BY", "REMARKS", "APPLY_TO") FROM stdin;
    public          postgres    false    432   �G      f          0    78309    PIS_FULFILLED_DARBANDI 
   TABLE DATA           �   COPY public."PIS_FULFILLED_DARBANDI" ("SN", "OFFICE_ID", "DARBANDI_ID", "PERSON_TYPE_ID", "EMP_ID", "DATE_FULFILLED", "APPOINTMNT_TYPE", "LOCAL_POST_ID") FROM stdin;
    public          postgres    false    451   �G      �          0    76763    PIS_GEO_REGION 
   TABLE DATA           a   COPY public."PIS_GEO_REGION" ("ID", "GR_ID", "GR_NAME", "MARKS_PER_YEAR", "DETAILS") FROM stdin;
    public          postgres    false    305   �G      �          0    76771 
   PIS_HAJIRI 
   TABLE DATA           �   COPY public."PIS_HAJIRI" ("SN", "YEAR", "MONTH", "EMP_ID", "LOCAL_POST", "TOTAL_DAYS", "PUBLIC_HOLIDAYS", "HAJIRI_DAYS", "GHABIS", "BIBIS", "CABIS", "BETALABIS", "OTHER", "GAYAL") FROM stdin;
    public          postgres    false    306   H      v          0    78628    PIS_INTERNAL_TRANSFER 
   TABLE DATA           
  COPY public."PIS_INTERNAL_TRANSFER" ("SN", "EMP_ID", "OFFICE_ID", "DARBANDI_ID", "DATE_FROM", "DATE_TO", "APPOINTMNT_TYPE", "DATE_OF_DECISION", "DECISION_REFERENCE", "REMARKS", "TO_OFFICE_ID", "TO_LOCAL_POST_ID", "TO_APPOINTMNT_TYPE", "REPLACED_EMP_ID") FROM stdin;
    public          postgres    false    467   H      �          0    76776    PIS_LAND_BLDNGS 
   TABLE DATA           ;  COPY public."PIS_LAND_BLDNGS" ("SN", "EMP_ID", "DESCRIPTION", "UNIT_DESC", "ZONE_ID", "DISTRICT_ID", "VDC_ID", "WARD_NO", "ROAD_ID", "STREET", "OWNERSHIP_DETAILS", "AQUISITION_TYPE_ID", "SPECIAL_NOTES", "APPLY_TO", "USER_ID", "USER_IDE", "DATA_ENTRY_VS_DATE", "DATA_ENTRY_AD_DATE", "DATA_EDIT_AD_DATE") FROM stdin;
    public          postgres    false    307   <H      �          0    76784    PIS_LOAN_DHITO_GIVEN 
   TABLE DATA           
  COPY public."PIS_LOAN_DHITO_GIVEN" ("SN", "EMP_ID", "DESCRIPTION", "TRANS_DESC", "REASON_TO_TAKE", "VALUE_IN_NRS", "RETURNING_DURATION", "SPECIAL_NOTES", "APPLY_TO", "USER_ID", "USER_IDE", "DATA_ENTRY_VS_DATE", "DATA_ENTRY_AD_DATE", "DATA_EDIT_AD_DATE") FROM stdin;
    public          postgres    false    308   YH      �          0    76792    PIS_LOAN_DHITO_TAKEN 
   TABLE DATA           
  COPY public."PIS_LOAN_DHITO_TAKEN" ("SN", "EMP_ID", "DESCRIPTION", "TRANS_DESC", "REASON_TO_TAKE", "VALUE_IN_NRS", "RETURNING_DURATION", "SPECIAL_NOTES", "APPLY_TO", "USER_ID", "USER_IDE", "DATA_ENTRY_VS_DATE", "DATA_ENTRY_AD_DATE", "DATA_EDIT_AD_DATE") FROM stdin;
    public          postgres    false    309   vH      /          0    77441    PIS_LOCAL_POST_MASTER 
   TABLE DATA           �   COPY public."PIS_LOCAL_POST_MASTER" ("LOCAL_POST_ID", "LOCAL_POST_NAME", "LOCAL_POST_NAME_EN", "POST_ID", "POST_DUTIES", "BASIC_SALARY", "GRADE_RATE", "ALLWANCE", "INSURANCE_ADD_AMT", "PAYROLL_ORDER", "ALLLWANCE", "ALLOWANCE") FROM stdin;
    public          postgres    false    396   �H      �          0    76800    PIS_NIJAMATI_SEWA_SAMUHA 
   TABLE DATA           j   COPY public."PIS_NIJAMATI_SEWA_SAMUHA" ("ID", "PARENT_ID", "NAME_NP", "NAME_EN", "GRP_LEVEL") FROM stdin;
    public          postgres    false    310   �H      �          0    76810    PIS_ORNAMENTS 
   TABLE DATA           �   COPY public."PIS_ORNAMENTS" ("SN", "EMP_ID", "DESCRIPTION", "UNIT_DESC", "AQUISITION_TYPE_ID", "SPECIAL_NOTES", "APPLY_TO", "USER_ID", "USER_IDE", "DATA_ENTRY_VS_DATE", "DATA_ENTRY_AD_DATE", "DATA_EDIT_AD_DATE") FROM stdin;
    public          postgres    false    311   �H      T          0    78019    PIS_OTHER_ADD_SUB 
   TABLE DATA           r   COPY public."PIS_OTHER_ADD_SUB" ("ID", "ACC_ID", "LOCAL_POST_ID", "AMOUNT", "ADD_SUB", "DESCRIPTION") FROM stdin;
    public          postgres    false    433   �H      �          0    76815    PIS_PAYROLLS 
   TABLE DATA              COPY public."PIS_PAYROLLS" ("ID", "MONTH", "EMP_ID", "LOCAL_POST_ID", "POST_IN_SHORT", "LOCAL_POST", "EMP_NAME_NP", "BASIC_SALARY", "GRADE_INC_MONTH", "RATE_OF_GRADE", "GRADE_AMOUNT", "GRADE_SALARY_TOTAL", "ALLOWANCE_AMT", "OTHER_ALLOWANCE_AMT", "PF_ADD_AMT", "INSURANCE_ADD_AMT", "NET_SALARY", "PF_DEDUCT_AMT", "INSURANCE_DEDUCT_AMT", "CIT_PERCENT", "CIT_AMT", "TAX_AMT", "ADVANCE_DEDUCT_AMT", "LOAN_DEDUCT_AMT", "ABSENT_DAYS", "ABSENT_DEDUCT_AMT", "OTHER_DEDUCT_TOTAL", "TOTAL_PAYABLE_SALARY", "PAYMODE", "POST_LEVEL", "VCHR_ID", "VCHR_DATE_NP", "PAY_BANK_ID", "TRANS_TPE_ID", "DEDUCT_DEP_VCHR_ID", "DEDUCT_DEP_VCHR_DATE_NEP", "REMARKS", "FISCAL_YEAR", "FESTIVE_VCHR_ID", "FESTIVE_VCHR_DATE_NEP", "PENSIONKOSH_ADD_AMT", "PENSIONKOSH_DED_AMT", "TDS_AMT") FROM stdin;
    public          postgres    false    312   I      �          0    76820    PIS_PD_ORG_INVLVMNT 
   TABLE DATA           I  COPY public."PIS_PD_ORG_INVLVMNT" ("SN", "EMP_ID", "ORG_NAME", "ORG_ADD", "ORG_FORMED_DATE", "ORG_AIMS", "ORG_ACHEIVMNTS", "NO_OF_BENIFIC_POPLN", "POST_IN_ORG", "RESPNSBLTY_IN_ORG", "ORG_JOINED_DATE", "ORG_LEFT_DATE", "REMARKS", "USER_ID", "USER_IDE", "DATA_ENTRY_VS_DATE", "DATA_ENTRY_AD_DATE", "DATA_EDIT_AD_DATE") FROM stdin;
    public          postgres    false    313   $I      �          0    76828    PIS_PD_SRVC_DTLS 
   TABLE DATA           �   COPY public."PIS_PD_SRVC_DTLS" ("SN", "EMP_ID", "LOCAL_POST_ID", "APPOINTMNT_LEVEL", "APPOINTMNT_TYPE", "OFFICE_DETAIL", "DATE_FROM", "DATE_TO", "REMARKS") FROM stdin;
    public          postgres    false    314   AI      �          0    76833    PIS_PERSON_VISIT_RECRD 
   TABLE DATA           +  COPY public."PIS_PERSON_VISIT_RECRD" ("SN", "PERSON_TYPE_ID", "PERSON_ID", "PERSON_NAME", "PERSON_POST", "REF_NO", "FROM_DATE", "TO_DATE", "AMOUNT_TAKEN", "VISIT_LOCATION", "JOB_DETAILS", "REMARKS", "USER_ID", "USER_IDE", "DATA_ENTRY_VS_DATE", "DATA_ENTRY_AD_DATE", "DATA_EDIT_AD_DATE") FROM stdin;
    public          postgres    false    315   ^I      �          0    76841    PIS_POST_MASTER 
   TABLE DATA           �   COPY public."PIS_POST_MASTER" ("POST_ID", "GENERAL_POST", "GENERAL_POST_SHORT", "POST_LEVEL", "BASIC_SALARY", "RATE_OF_GRADE", "MAX_GRADE_RATE", "PRABIDIK_OR_PRASASAN") FROM stdin;
    public          postgres    false    316   {I      U          0    78029 
   PIS_PRIZES 
   TABLE DATA           �   COPY public."PIS_PRIZES" ("SN", "EMP_ID", "LOCAL_POST_ID", "NAME_NP", "DESCRIPTION", "AWARD_TYPE", "AMOUNT", "AWARDED_BY", "WORKING_OFFICE", "ISSUED_DATE", "REMARKS", "APPLY_TO") FROM stdin;
    public          postgres    false    434   �I      V          0    78039    PIS_PUBLICATION 
   TABLE DATA           �   COPY public."PIS_PUBLICATION" ("SN", "EMP_ID", "LOCAL_POST_ID", "NEP_NAME", "DESCRIPTION", "WORKING_OFFICE", "PUBLSH_DATE_VS", "PUBLSH_DATE_AD", "PUBLISHER", "REMARKS", "APPLY_TO") FROM stdin;
    public          postgres    false    435   �I      �          0    78974    PIS_PYROLL_LOAN_DTLS 
   TABLE DATA           �   COPY public."PIS_PYROLL_LOAN_DTLS" ("ID", "LOAND_ID", "MONTH", "NAME_NP", "EMP_ID", "ACC_ID", "LOAND_AMT", "INSTALLMENT_AMT", "CLEARED", "PAYROLL_ID") FROM stdin;
    public          postgres    false    481   �I      w          0    78668    PIS_PYROLL_OTHR_DTLS 
   TABLE DATA           �   COPY public."PIS_PYROLL_OTHR_DTLS" ("ID", "MONTH", "EMPLOYEE_ID", "PAYROLL_ID", "AMOUNT", "ADD_SUB", "DESCRIPTION", "ACC_ID", "SOURCE_TYPE") FROM stdin;
    public          postgres    false    468   �I      ~          0    78788    PIS_REPLACED_IN_DARBANDI 
   TABLE DATA             COPY public."PIS_REPLACED_IN_DARBANDI" ("SN", "EMP_ID", "ENTRY_SN_IN_FD", "OFFICE_ID", "DARBANDI_ID", "DATE_FULFILLED", "APPOINTMNT_TYPE", "REPLACED_BY", "DATE_REPLACED", "DATE_OF_DECISION", "DECISION_REFERENCE", "IS_PLACED_IN_DARBANDI", "REMARKS") FROM stdin;
    public          postgres    false    475   J      �          0    76846    PIS_SERVICE_STATUS 
   TABLE DATA           Y   COPY public."PIS_SERVICE_STATUS" ("ID", "NAME_NP", "NAME_EN", "DESCRIPTION") FROM stdin;
    public          postgres    false    317   )J      W          0    78049    PIS_SGNFCNT_WORK 
   TABLE DATA           �   COPY public."PIS_SGNFCNT_WORK" ("SN", "EMP_ID", "LOCAL_POST_ID", "NAME_NP", "DESCRIPTION", "WORKING_OFFICE", "FROM_DATE_VS", "TO_DATE_VS", "FROM_DATE_AD", "TO_DATE_AD", "DURATION", "REMARKS", "APPLY_TO") FROM stdin;
    public          postgres    false    436   FJ      �          0    76851    PIS_SHARE_BANKBALANCE 
   TABLE DATA             COPY public."PIS_SHARE_BANKBALANCE" ("SN", "EMP_ID", "DESCRIPTION", "COMPANY_OR_BANK", "VALUE_IN_NRS", "OWNERSHIP_DETAILS", "AQUISITION_TYPE_ID", "SPECIAL_NOTES", "APPLY_TO", "USER_ID", "USER_IDE", "DATA_ENTRY_VS_DATE", "DATA_ENTRY_AD_DATE", "DATA_EDIT_AD_DATE") FROM stdin;
    public          postgres    false    318   cJ      X          0    78059    PIS_TRAINING 
   TABLE DATA             COPY public."PIS_TRAINING" ("SN", "EMP_ID", "LOCAL_POST_ID", "TRAINING_TYPE", "TRAINING_NAME", "INSTITUTE", "COUNTRY_ID", "FRM_DATE_VS", "TO_DATE_VS", "FRM_DATE_AD", "TO_DATE_AD", "DURATION", "DIVISION", "MARKS_OBTND", "VALID_FOR_EVAL", "APPLY_TO") FROM stdin;
    public          postgres    false    437   �J      y          0    78703    PIS_VISITED_COUNTRIES 
   TABLE DATA           g   COPY public."PIS_VISITED_COUNTRIES" ("SN", "VISIT_ID", "EMP_ID", "COUNTRY_ID", "APPLY_TO") FROM stdin;
    public          postgres    false    470   �J      Y          0    78069    PIS_WORKSHOP 
   TABLE DATA           �   COPY public."PIS_WORKSHOP" ("SN", "EMP_ID", "LOCAL_POST_ID", "NEP_NAME", "DESCRIPTION", "WORKING_OFFICE", "DURATION", "FROM_DATE_VS", "TO_DATE_VS", "FROM_DATE_AD", "TO_DATE_AD", "ORGANIZER", "COUNTRY_ID", "REMARKS", "APPLY_TO") FROM stdin;
    public          postgres    false    438   �J      �          0    76856    PMS_YOJTYPE 
   TABLE DATA           g   COPY public."PMS_YOJTYPE" ("ID", "YOJTYPE_NAME_NP", "YOJTYPE_NAME_ENG", "YOJTYPE_REMARKS") FROM stdin;
    public          postgres    false    319   �J      �          0    76866    RENTTYPE 
   TABLE DATA           K   COPY public."RENTTYPE" ("ID", "NEPNAME", "ENGNAME", "REMARKS") FROM stdin;
    public          postgres    false    321   �J      �          0    76861    RENT_DAR_RATE 
   TABLE DATA           V   COPY public."RENT_DAR_RATE" ("ID", "RATENAME", "RENT_PER", "RENT_TYPEID") FROM stdin;
    public          postgres    false    320   K      �          0    76869    REPORT_GENERAL 
   TABLE DATA           �   COPY public."REPORT_GENERAL" ("REPORT_ID", "OFFICE_TYPE_ID", "REPORT_NAME", "REPORT_FOR", "ANUSUCHI_HEAD", "ANUSUCHI_DETAILS", "REPORT_HEADING") FROM stdin;
    public          postgres    false    322   .K      �          0    76875    SANITATION_GROUP 
   TABLE DATA           ?   COPY public."SANITATION_GROUP" ("ID", "GROUPNAME") FROM stdin;
    public          postgres    false    323   KK      Z          0    78079    SANITATION_RATE 
   TABLE DATA           �   COPY public."SANITATION_RATE" ("ID", "GROUPID", "SUBGROUPID", "ROAD_TYPEID", "RATENAME", "RATE", "FISCAL_YEAR", "AREA_UPTO", "FOR_EACH_AREA", "EACH_AREA_RATE") FROM stdin;
    public          postgres    false    439   hK      0          0    77454    SANITATION_SUBGROUP 
   TABLE DATA           [   COPY public."SANITATION_SUBGROUP" ("ID", "GROUPID", "SUBGROUPNAME", "REMARKS") FROM stdin;
    public          postgres    false    397   �K      A          0    77668    SERVICE_CHARGE_MASTER 
   TABLE DATA           �   COPY public."SERVICE_CHARGE_MASTER" ("ID", "RATEID", "ACCODE", "ACC_ID", "SERVICE_CHARGE_PERCENT", "FLAT_CHARGE_RATE", "ISAPPLICABLEFORHOUSE") FROM stdin;
    public          postgres    false    414   �K      �          0    76880    SPACEMEASURINGUNITS 
   TABLE DATA           T   COPY public."SPACEMEASURINGUNITS" ("UNITID", "UNITNAME", "SQFTPERUNIT") FROM stdin;
    public          postgres    false    324   �K      4          0    77494    STOREDBILLS 
   TABLE DATA           z   COPY public."STOREDBILLS" ("SN", "DATEISSUED", "DESCRIPTION", "BILLNOFROM", "BILLNOTO", "CODE", "BILLTYPEID") FROM stdin;
    public          postgres    false    401   �K      �          0    76883    SUBJECT_AREA 
   TABLE DATA           f   COPY public."SUBJECT_AREA" ("ID", "PARENT_ID", "CODE", "NEP_NAME", "ENG_NAME", "REMARKS") FROM stdin;
    public          postgres    false    325   �K      "          0    77285    SUB_MODULE_SOURCE 
   TABLE DATA           R   COPY public."SUB_MODULE_SOURCE" ("SUB_MODULE_ID", "BUDJET_SOURCE_ID") FROM stdin;
    public          postgres    false    383   L      �          0    76891    SV_BUSINESSMASTER 
   TABLE DATA           S  COPY public."SV_BUSINESSMASTER" ("ID", "NEPNAME", "DESCRIPTION", "BUSINESSGROUPID", "TYPEID", "TAXPAYERID", "INITIALCAPITAL", "ZONEID", "DISTRICTID", "VDCID", "WARDNO", "STREET", "TRACKID", "HOUSENO", "PHONES", "EMAILS", "HOUSEOWNER", "ISINRENT", "MONTHLYRENT", "AREAINSQUAREFEETS", "INITIALREGISTEREDOFFICE", "INITIALREGNO", "INITIALREGDATE", "MUNICIPALREGNO", "MUNICIPALLREGDATE", "SQFEETSOFSIGNBOARD", "LENGTHOFSIGNBOARD", "WIDTHOFSIGNBOARD", "CONTENTOFSIGNBOARD", "BUSINESSSTARTINGDATE", "SPECIALNOTES", "USERID", "USERIDE", "DATAENTRYVSDATE", "DATAENTRYADDATETIME", "DATAEDITADDATETIME", "GENERALRATEID", "MAIL_ADDRESS", "BUSINESS_STATUS", "CLOSED_VS_DATE", "CLOSE_REASON", "PAID_LAST_FISCALYEAR", "SANITATIONID", "MAXCAPITAL", "YEARLY_TRAN_AMOUNT", "SHIFTDATE", "SHIFTTAXPAYERID", "ADDRESSCHANGE", "HOUSEID", "BUSINESSOWNERTAX_IID") FROM stdin;
    public          postgres    false    326   3L      �          0    76899    SV_CONSTRUCTIONS 
   TABLE DATA           �  COPY public."SV_CONSTRUCTIONS" ("ID", "IID", "HOUSEID", "TALANUMBER", "CONSTRUCTIONTYPEID", "LENGTHINFEET", "WIDTHTHINFEET", "HEIGHTINFEET", "AREAINSQFEET", "VSDATEOFMADE", "CONSTRUCTIONUSESTYPEID", "SELFUSEORINRENT", "GENERALRATEID", "INCLUDEINEVALUATION", "SPECIALNOTE", "USERID", "USERIDE", "DATAENTRYVSDATE", "DATAENTRYADDATETIME", "DATAEDITADDATETIME", "TAXPAYER_DEFINE_AMOUNT", "VSMAPPDATE") FROM stdin;
    public          postgres    false    327   PL      �          0    76904 	   SV_HOUSES 
   TABLE DATA             COPY public."SV_HOUSES" ("ID", "IID", "LANDID", "HOUSENUMBER", "HOUSETYPEID", "HOUSECONSTRUCTIONTYPEID", "SALES_DT", "VSDATEOFMADE", "AQUISITIONDATE", "USESTYPEID", "HASMAPREGISTERED", "MAPREGISTEREDDATE", "NUMOFTALAS", "HEIGHTINFEETS", "LENGTHINFEETS", "WIDTHINFEETS", "AREAINSQFEETS", "SPECIALNOTE", "INCLUDEINEVALUATION", "AREAOFCONSTRUCTIONSINSQFEETS", "USERID", "USERIDE", "DATAENTRYVSDATE", "DATAENTRYADDATETIME", "DATAEDITADDATETIME", "DEFINE_AMT", "SANITATIONRATEID", "BUILDINGCODE", "BIN_GIS") FROM stdin;
    public          postgres    false    328   mL      �          0    76912    SV_LANDS 
   TABLE DATA           	  COPY public."SV_LANDS" ("ID", "IID", "OLDVDCID", "OLDWARDNO", "LAND_RULES", "WARDNO", "MOTHNUMBER", "MAPNUMBER", "KITTANUMBER", "STREETNAME", "HASTRACK", "TRACKID", "TRACKRELATIONID", "AQUISITIONDATE", "AQUISITIONTYPEID", "USESTYPEID", "VALUEINRSONAQUISITION", "AREAINSQFT", "NONFUNCTIONALAREAINSQFT", "EASTBOUNDARY", "WESTBOUNDARY", "NORTHTBOUNDARY", "SOUTHTBOUNDARY", "LQTYPEID", "LANDNATUREID", "LOCATIONFACTORID", "SELFDECLAREDVALUEINRS", "SPECIALNOTE", "GENERALRATEID", "INCLUDEINEVALUATION", "USERID", "USERIDE", "DATAENTRYVSDATE", "SALES_DT", "DATAENTRYADDATETIME", "DATAEDITADDATETIME", "EVALEXCLUSIONREASONID", "MALPOTRATE", "AREA_TYPE_ID", "NOMINATION_DIRECTION", "NOMINATION_AREA", "NOMINATION_LENGTH", "NOMINATION_BREADTH", "NOMINATION_TF", "LANDTYPE", "EASTBOUNDARY_KITTA", "WESTBOUNDARY_KITTA", "NORTHBOUNDARY_KITTA", "SOUTHBOUNDARY_KITTA", "TOLENAME", "LANDMEASURINGUNITID", "GRID_NO", "SHEET_NO", "EASTRUNFT", "WESTRUNFT", "NORTHRUNFT", "SOUTHRUNFT", "AREAINSQFT_FIELD", "IS_LRMIS_ADD", "DEIGSTERTYPEID") FROM stdin;
    public          postgres    false    329   �L      �          0    76920    SV_LANDSMULTIEVALUATIONDETAIL 
   TABLE DATA           ~   COPY public."SV_LANDSMULTIEVALUATIONDETAIL" ("SN", "IID", "LANDID", "KITTANUMBER", "GENERALRATEID", "AREAINSQFT") FROM stdin;
    public          postgres    false    330   �L      �          0    76923 	   SV_PEOPLE 
   TABLE DATA           !  COPY public."SV_PEOPLE" ("IID", "EID", "SEX", "FIRSTNEPNAME", "LASTNEPNAME", "FIRSTENGNAME", "LASTENGNAME", "DOB", "FATHERORHUSBAND", "GFORFINLAW", "PHONES", "MOBILES", "EMAIL", "OCUPATIONID", "RELIGIONID", "MOTHERLANGUAGEID", "NATIONALITYID", "HASCC", "CCNUMBER", "CCISSUEDDRISTICTID", "CCISSUEDDATE", "COUNTRYID", "ZONEID", "DISTRICTID", "VDCID", "WARDNO", "STREETNAME", "TRACKID", "HOUSENO", "CORESPADDRESSLINE1", "CORESPADDRESSLINE2", "CORESPADDRESSLINE3", "CORESPADDRESSLINE4", "OTHERDETAILS", "INDIVIDUALTYPE", "PHOTO", "USERID", "USERIDE", "DATAENTRYVSDATE", "DATAENTRYADDATETIME", "DATAEDITADDATETIME", "IPT_UNPAID_FISCAL_YEAR", "IPT_UNPAID_AMOUNT", "HLT_UNPAID_FISCAL_YEAR", "HLT_UNPAID_AMOUNT", "IS_UNPAID_CLEARED", "CANCEL_DATE", "CANCEL_REASON", "TOLBIKASHID", "IS_LRMIS_ADD") FROM stdin;
    public          postgres    false    331   �L      �          0    76931    SV_TBHOUSEKITTANUMBER 
   TABLE DATA           M   COPY public."SV_TBHOUSEKITTANUMBER" ("IID", "HOUSEID", "LANDID") FROM stdin;
    public          postgres    false    332   �L      �          0    76934    SV_VEHICLEMASTER 
   TABLE DATA           P  COPY public."SV_VEHICLEMASTER" ("SN", "TAXPAYERID", "VEHICLENAME", "VEHICLETYPE", "VEHICLENO", "REGISTEREDOFFICE", "REGISTEREDDATE", "MUNICIPALTYREGNO", "MUNICIPALTYREGDATE", "AQUISITIONTYPE", "AQUISITIONDATE", "AQUIREDFROM", "USESTYPE", "COLOR", "NUMBEROFSEATES", "CCORHPRSPOWER", "MADEOF", "ENGINENO", "CHESISNO", "MODELDESCRIPTION", "NOOFCILENDERS", "USEDFUEL", "SPECIALNOTES", "USERID", "USERIDE", "DATAENTRYVSDATE", "DATAENTRYADDATETIME", "DATAEDITADDATETIME", "VEHICLE_STATUS", "CLOSED_VS_DATE", "CLOSE_REASON", "PAID_LAST_FISCALYEAR", "NAMASARIMITI", "NAMASARITAXPAYERID") FROM stdin;
    public          postgres    false    333   �L      B          0    77678    TAX_ADDTNL_CHRG_DTLS 
   TABLE DATA             COPY public."TAX_ADDTNL_CHRG_DTLS" ("SN", "FISCAL_YEAR", "IID", "ACCODE", "ACC_ID", "AMOUNT", "LAND_ID", "RENT_ID", "SERVICE_CHARGE_PERCENT", "FLAT_CHARGE_RATE", "ISAPPLICABLEFORHOUSE", "TAX_TYPE", "SERVICE_CHARGE_TYPE", "ISREGISTATIONFEE", "BILL_ID", "BILL_NO") FROM stdin;
    public          postgres    false    415   M      �          0    76942 
   TAX_MALPOT 
   TABLE DATA           �  COPY public."TAX_MALPOT" ("SN", "FISCALYEAR", "TAXPAYERID", "LANDID", "KITTANUMBER", "GENERALRATEID", "RATEPERUNIT", "SPECIALNOTES", "NETTAXAMOUNT", "FINEAMOUNT", "ADDITIONALCHARGES", "REDUCTIONALCHARGES", "TAXPAIDAMOUNT", "LAST_TAX_PAID_AMOUNT", "TOTALAREA", "NONEVALUATEDAREA", "NETEVALUATINGAREA", "BILLID", "BILLDATE", "BILLNO", "COUNTERID", "USERID", "USERIDE", "DATAENTRYVSDATE", "DATAENTRYADDATETIME", "DATAEDITADDATETIME") FROM stdin;
    public          postgres    false    334   8M      �          0    76948    TAX_MALPOT_HISTORY 
   TABLE DATA           �  COPY public."TAX_MALPOT_HISTORY" ("SN", "MALPOT_ID", "FISCALYEAR", "TAXPAYERID", "LANDID", "KITTANUMBER", "GENERALRATEID", "RATEPERUNIT", "SPECIALNOTES", "NETTAXAMOUNT", "FINEAMOUNT", "ADDITIONALCHARGES", "REDUCTIONALCHARGES", "TAXPAIDAMOUNT", "LAST_TAX_PAID_AMOUNT", "TOTALAREA", "NONEVALUATEDAREA", "NETEVALUATINGAREA", "BILLID", "BILLDATE", "BILLNO", "COUNTERID", "USERID", "USERIDE", "DATAENTRYVSDATE", "DATAENTRYADDATETIME", "DATAEDITADDATETIME") FROM stdin;
    public          postgres    false    335   UM      �          0    76954    TAX_RATE_CEILING 
   TABLE DATA           d   COPY public."TAX_RATE_CEILING" ("ID", "NP_FROM", "NP_TO", "MARRIED_STATUS", "TAX_RATE") FROM stdin;
    public          postgres    false    336   rM      �          0    76959 
   TAX_RENTAL 
   TABLE DATA           Y  COPY public."TAX_RENTAL" ("ID", "FISCALYEAR", "TAXPAYERID", "CONSTRUCTIONID", "RENTID", "RATEID", "REMARKS", "NETTAXAMOUNT", "FINEAMOUNT", "ADDITIONALCHARGES", "REDUCTIONALCHARGES", "TAXPAIDAMOUNT", "LAST_TAX_PAID_AMOUNT", "BILLID", "BILLNO", "BILLDATE", "COUNTERID", "USERID", "DATEENTRYVSDATE", "DATAENTRYADDATE", "YEAR", "MONTH") FROM stdin;
    public          postgres    false    337   �M      �          0    76965    TAX_RT_RENTDTL 
   TABLE DATA           f  COPY public."TAX_RT_RENTDTL" ("ID", "CONSTRUCTION_ID", "RNAME", "RENT_TYPE_ID", "RENT_INSQFEET", "ANUAL_RENT_INCOME", "FISCAL_YEAR", "AGREEMENT_DATE", "VALID_UNTIL", "RENT_STATUS", "RATEID", "TAXPAYERID", "BUSINESSID", "REMARKS", "DATAENTRYADDATETIME", "DATAEDITADDATETIME", "USERID", "USERIDE", "DATAENTRYVSDATE", "IS_TAX_PAID_BUSINESS_PERSON") FROM stdin;
    public          postgres    false    338   �M      �          0    76971    TAX_SANITATION 
   TABLE DATA           p  COPY public."TAX_SANITATION" ("SN", "FISCALYEAR", "YEAR", "MONTH", "TAXPAYERID", "HOUSEID", "RATEID", "SPECIALNOTES", "NETTAXAMOUNT", "FINEAMOUNT", "REDUCTIONALCHARGES", "TAXPAIDAMOUNT", "LAST_TAX_PAID_AMOUNT", "BILLID", "BILLNO", "BILLDATE", "COUNTERID", "USERID", "USERIDE", "DATAENTRYVSDATE", "DATAENTRYADDATETIME", "DATAEDITADDATETIME", "SERVICETYPE") FROM stdin;
    public          postgres    false    339   �M      ]          0    78122    TAX_THLI_ISSUED_CNTR 
   TABLE DATA           M   COPY public."TAX_THLI_ISSUED_CNTR" ("ID", "THELI_ID", "CNTR_ID") FROM stdin;
    public          postgres    false    442   �M      �          0    76977    TBHOUSEKITTANUMBER 
   TABLE DATA           J   COPY public."TBHOUSEKITTANUMBER" ("IID", "HOUSEID", "LANDID") FROM stdin;
    public          postgres    false    340   N                0    77103    TBLBILLTYPE 
   TABLE DATA           S   COPY public."TBLBILLTYPE" ("ID", "NEPNAME", "ISINCOME", "DESCRIPTION") FROM stdin;
    public          postgres    false    360    N      E          0    77713    TBLBUSINESS_SERVICE_CH_MST 
   TABLE DATA           �   COPY public."TBLBUSINESS_SERVICE_CH_MST" ("ID", "RATEID", "ACCODE", "ACC_ID", "SERVICECHARGEPERCENT", "FLATCHARGERATE", "FISCAL_YEAR") FROM stdin;
    public          postgres    false    418   =N                0    77108    TBLEXEVERSION 
   TABLE DATA           =   COPY public."TBLEXEVERSION" ("EXEID", "EXEDATE") FROM stdin;
    public          postgres    false    361   ZN                0    77111    TBLFYWISEBTRATES 
   TABLE DATA           �   COPY public."TBLFYWISEBTRATES" ("ID", "GROUPID", "SUBGROUPID", "SNSUBGROUP", "RATEID", "NEPNAME", "DESCRIPTION", "FISCALYEAR", "RATEPERUNIT") FROM stdin;
    public          postgres    false    362   wN      {          0    78728    TBLFYWISEMPOTASSRATE 
   TABLE DATA           �   COPY public."TBLFYWISEMPOTASSRATE" ("ID", "GROUPID", "SUBGROUPID", "RATEID", "NEPNAME", "FISCALYEAR", "RATEPERUNIT", "AREA_UPTO", "FOR_EACH_AREA", "EACH_AREA_RATE") FROM stdin;
    public          postgres    false    472   �N                0    77114    TBLHL_ADD_SUBTRACT 
   TABLE DATA           �   COPY public."TBLHL_ADD_SUBTRACT" ("SN", "FISCAL_YEAR", "RATEID", "FLAT_RATE", "RATE_PERCENT", "ADD_FLAG", "ADD_SUB_TRACT_TYPE") FROM stdin;
    public          postgres    false    363   �N                0    77119    TBLLAND_TYPE_AREA 
   TABLE DATA           R   COPY public."TBLLAND_TYPE_AREA" ("ID", "CODE", "NEP_NAME", "REMARKS") FROM stdin;
    public          postgres    false    364   �N                0    77124    TBLMALPOTGROUP 
   TABLE DATA           J   COPY public."TBLMALPOTGROUP" ("ID", "NEPNAME", "DESCRIPTION") FROM stdin;
    public          postgres    false    365   �N      ^          0    78137    TBLMALPOTRATES 
   TABLE DATA           �   COPY public."TBLMALPOTRATES" ("ID", "GROUPID", "SUBGROUPID", "NEPNAME", "RATEPERUNIT", "DESCRIPTION", "AREA_UPTO", "FOR_EACH_AREA", "EACH_AREA_RATE") FROM stdin;
    public          postgres    false    443   O      5          0    77504    TBLMALPOTSUBGROUP 
   TABLE DATA           a   COPY public."TBLMALPOTSUBGROUP" ("ID", "GROUPID", "NEPNAME", "DESCRIPTION", "WORDA") FROM stdin;
    public          postgres    false    402   %O                0    77134    TBLTAXCALCULATIONROKA 
   TABLE DATA           U   COPY public."TBLTAXCALCULATIONROKA" ("ID", "IID", "REASON", "ROKA_DATE") FROM stdin;
    public          postgres    false    367   BO                0    77129    TBLTAX_FINE_REBATE 
   TABLE DATA           �   COPY public."TBLTAX_FINE_REBATE" ("SN", "FISCAL_YEAR", "DURATION_IN_YEARS", "TAX_TYPE", "FLAT_RATE", "RATE_PERCENT", "REBATE_FLAG") FROM stdin;
    public          postgres    false    366   _O      F          0    77723    TBLVEH_SER_CH_MSTR 
   TABLE DATA           �   COPY public."TBLVEH_SER_CH_MSTR" ("ID", "RATEID", "ACCODE", "ACC_ID", "SERVICE_CHARGE_PERCENT", "FLAT_CHARGE_RATE", "FISCAL_YEAR") FROM stdin;
    public          postgres    false    419   |O      �          0    76980    TBL_BANK_ACCNT_TYPE 
   TABLE DATA           V   COPY public."TBL_BANK_ACCNT_TYPE" ("ID", "NEPNAME", "ENGNAME", "REMARKS") FROM stdin;
    public          postgres    false    341   �O      �          0    76985    TBL_BANK_FINANCE_INSTITUTUE 
   TABLE DATA           t   COPY public."TBL_BANK_FINANCE_INSTITUTUE" ("ID", "NP_NAME", "ENG_NAME", "DESCRIPTIONG", "ACCOUNT_NAME") FROM stdin;
    public          postgres    false    342   �O      �          0    76993    TBL_BGT_MGMT 
   TABLE DATA           {   COPY public."TBL_BGT_MGMT" ("ID", "FISCAL_YEAR", "MINISTRY_ID", "BGT_SUB_HEAD_ID", "TOTAL_BGT_AMT", "REMARKS") FROM stdin;
    public          postgres    false    343   �O      1          0    77464    TBL_BGT_MGMT_EXP 
   TABLE DATA           a   COPY public."TBL_BGT_MGMT_EXP" ("ID", "BGT_MGMT_ID", "ACC_ID", "BGT_AMT", "REMARKS") FROM stdin;
    public          postgres    false    398   �O      2          0    77474    TBL_BGT_MGMT_EXP_ORG 
   TABLE DATA           m   COPY public."TBL_BGT_MGMT_EXP_ORG" ("ID", "BGT_MGMT_ORG_ID", "ACC_ID", "BGT_AMT_ORG", "REMARKS") FROM stdin;
    public          postgres    false    399   P      _          0    78152    TBL_BGT_MGMT_EXP_RELEASE 
   TABLE DATA           m   COPY public."TBL_BGT_MGMT_EXP_RELEASE" ("ID", "BGT_MGMT_RELEASE_ID", "ACC_ID", "AMT", "REMARKS") FROM stdin;
    public          postgres    false    444   *P      �          0    76998    TBL_BGT_MGMT_ORG 
   TABLE DATA           �   COPY public."TBL_BGT_MGMT_ORG" ("ID", "FISCAL_YEAR", "MINISTRY_ID", "ORG_ID", "BGT_SUB_HEAD_ID", "TOTAL_BGT_AMT_ORG", "REMARKS") FROM stdin;
    public          postgres    false    344   GP      ;          0    77573    TBL_BGT_MGMT_RELEASE 
   TABLE DATA           �   COPY public."TBL_BGT_MGMT_RELEASE" ("ID", "BGT_RELEASE_ID", "FISCAL_YEAR", "MINISTRY_ID", "ORG_ID", "BGT_SUB_HEAD_ID", "AMT", "REMARKS") FROM stdin;
    public          postgres    false    408   dP      [          0    78097    TBL_BGT_MGMT_SRC 
   TABLE DATA           �   COPY public."TBL_BGT_MGMT_SRC" ("ID", "BGT_MGMT_EXP_ID", "SOURCE_ID", "AMT", "PAYMENT_TYPE_ID", "PAYMENT_PROCESS_ID", "REMARKS") FROM stdin;
    public          postgres    false    440   �P      \          0    78107    TBL_BGT_MGMT_SRC_ORG 
   TABLE DATA           �   COPY public."TBL_BGT_MGMT_SRC_ORG" ("ID", "BGT_MGMT_EXP_ORG_ID", "SOURCE_ID", "AMT", "CC_ID", "CC_ACTIVE", "PAYMENT_TYPE_ID", "PAYMENT_PROCESS_ID", "REMARKS") FROM stdin;
    public          postgres    false    441   �P      |          0    78748    TBL_BGT_MGMT_SRC_RELEASE 
   TABLE DATA           �   COPY public."TBL_BGT_MGMT_SRC_RELEASE" ("ID", "BGT_MGMT_EXP_RELEASE_ID", "SOURCE_ID", "AMT", "CC_ID", "CC_ACTIVE", "PAYMENT_TYPE_ID", "PAYMENT_PROCESS_ID", "REMARKS") FROM stdin;
    public          postgres    false    473   �P                0    77185    TBL_BGT_RELEASE 
   TABLE DATA           �   COPY public."TBL_BGT_RELEASE" ("ID", "FISCAL_YEAR", "MINISTRY_ID", "ORG_ID", "RELEASE_TYPE", "RELEASE_DATE", "CHALANI_NO", "LETTER_SN", "APPROVED_BGT_YEARLY", "PREVIOUS_RELEASE_AMT", "RELEASE_AMOUNT", "SPECIAL_TIPPANI") FROM stdin;
    public          postgres    false    376   �P      C          0    77693    TBL_CONSTRUCTION_OTHER_CHARGES 
   TABLE DATA           �   COPY public."TBL_CONSTRUCTION_OTHER_CHARGES" ("ID", "RATEID", "ACCODE", "ACC_ID", "PERCENT_OF_TAX", "FLAT_CHARGE_RATE", "FISCAL_YEAR", "SERVICE_CHARGE_CALCULATION") FROM stdin;
    public          postgres    false    416   �P      �          0    77003    TBL_DATA_HISTORY 
   TABLE DATA           �   COPY public."TBL_DATA_HISTORY" ("ID", "TABLE_NAME", "FIELD_NAME", "NEW_VALUE", "OLD_VALUE", "USER_ID_A", "ADD_DATE", "COMPUTER_NAME", "DATA_STATUS", "WINDOWS_USER", "TRAN_TIME") FROM stdin;
    public          postgres    false    345   Q      �          0    77011    TBL_DEGISTER 
   TABLE DATA           d   COPY public."TBL_DEGISTER" ("ID", "NP_NAME", "ENG_NAME", "REMARKS", "IS_FULL_DEGISTER") FROM stdin;
    public          postgres    false    346   /Q      �          0    77019    TBL_KHARIDA_AADASH 
   TABLE DATA           K   COPY public."TBL_KHARIDA_AADASH" ("ID", "NP_NAME", "ENG_NAME") FROM stdin;
    public          postgres    false    347   LQ      D          0    77703    TBL_LAND_OTHER_CHARGES 
   TABLE DATA           �   COPY public."TBL_LAND_OTHER_CHARGES" ("ID", "RATEID", "ACCODE", "ACC_ID", "PERCENT_OF_TAX", "FLAT_CHARGE_RATE", "FISCAL_YEAR", "SERVICE_CHARGE_CALCULATION") FROM stdin;
    public          postgres    false    417   iQ      z          0    78713    TBL_MALPOT_OTHER_CHARGES 
   TABLE DATA           �   COPY public."TBL_MALPOT_OTHER_CHARGES" ("ID", "RATEID", "ACCODE", "ACC_ID", "PERCENT_OF_TAX", "FLAT_CHARGE_RATE", "FISCAL_YEAR") FROM stdin;
    public          postgres    false    471   �Q      �          0    77024    TBL_NALI_TYPE 
   TABLE DATA           T   COPY public."TBL_NALI_TYPE" ("ID", "NEPNAME", "ENGNAME", "DESCRIPTION") FROM stdin;
    public          postgres    false    348   �Q                 0    77029    TBL_ORGANIZATIONMASTER 
   TABLE DATA           _   COPY public."TBL_ORGANIZATIONMASTER" ("ID", "NP_NAME", "ENG_NAME", "DESCRIPTIONG") FROM stdin;
    public          postgres    false    349   �Q                0    77037    TBL_PAYMENT_ORDER 
   TABLE DATA           c   COPY public."TBL_PAYMENT_ORDER" ("ID", "ORDER_CODE", "DATE_BS", "TOKEN_NO", "REMARKS") FROM stdin;
    public          postgres    false    350   �Q      3          0    77484    TBL_PAYMENT_ORDER_DETAILS 
   TABLE DATA           �   COPY public."TBL_PAYMENT_ORDER_DETAILS" ("ID", "PAYMENT_ORDER_ID", "VOUCHER_ID", "LINK_VOUCHER_ID", "PAYMENT_PERMISS_NO") FROM stdin;
    public          postgres    false    400   �Q                0    77045    TBL_PAYMENT_PROCESS 
   TABLE DATA           j   COPY public."TBL_PAYMENT_PROCESS" ("ID", "PAYMENT_PROCESS", "PAYMENT_PROCESS_ENG", "REMARKS") FROM stdin;
    public          postgres    false    351   R                0    77050    TBL_PAYMENT_TYPE 
   TABLE DATA           a   COPY public."TBL_PAYMENT_TYPE" ("ID", "PAYMENT_TYPE", "PAYMENT_TYPE_ENG", "REMARKS") FROM stdin;
    public          postgres    false    352   4R                0    77055    TBL_PROPERTY_TAX 
   TABLE DATA           �   COPY public."TBL_PROPERTY_TAX" ("ID", "IID", "NP_ENTRY_DATE", "FISCAL_YEAR", "HOUSE_LAND_AMOUNT", "MALPOT_AMOUNT", "TOTAL_TAX", "REMARKS") FROM stdin;
    public          postgres    false    353   QR                0    77063    TBL_SANITAION_TAX 
   TABLE DATA           �   COPY public."TBL_SANITAION_TAX" ("ID", "FROM_AREA", "TO_AREA", "AMOUNT", "REMARKS", "FISCAL_YEAR", "ACC_ID", "IS_APARTMENT") FROM stdin;
    public          postgres    false    354   nR                0    77069    TBL_STATUS_DETAILS 
   TABLE DATA           �   COPY public."TBL_STATUS_DETAILS" ("ID", "MASTERID", "ITEM_ID", "BRAND_ID", "SPEC_ID", "UNIT_ID", "RATE", "STOCK_QTY", "USE_IN_QTY", "NOT_USE_IN_QTY", "REPAIR_QTY", "NOT_REPAIR_QTY") FROM stdin;
    public          postgres    false    355   �R                0    77082    TBL_TAXSOURCERECORDNEW 
   TABLE DATA           �   COPY public."TBL_TAXSOURCERECORDNEW" ("TAXSRCID", "FISCALYEAR", "RECORDTYPE", "NETINCOME_CURFY", "TAXPAIDTAXPAYERCNT_CURFY", "NETINCOME_LASTFY", "TAXPAIDTAXPAYERCNT_LASTFY", "TAXNOTPAIDTAXPAYERCNT", "AMOUNTNOTCOLLECTED", "TOTALTAXPAYERCNT") FROM stdin;
    public          postgres    false    357   �R                0    77074    TBL_TAX_TYPE 
   TABLE DATA           g   COPY public."TBL_TAX_TYPE" ("ID", "CODE", "NP_NAME", "ENG_NAME", "DESCRIPTIONG", "ACC_ID") FROM stdin;
    public          postgres    false    356   �R      	          0    77087    TBL_TOLABIKASA_ORG 
   TABLE DATA           �   COPY public."TBL_TOLABIKASA_ORG" ("ID", "NP_NAME", "ENG_NAME", "ADDRESS", "CHAIRMAN", "SACHIBA", "CONTACTNO", "EMAIL", "WARDNO") FROM stdin;
    public          postgres    false    358   �R      
          0    77095    TBL_VEHICLE_PARTS 
   TABLE DATA           U   COPY public."TBL_VEHICLE_PARTS" ("SN", "NP_NAME", "ENG_NAME", "REMARKS") FROM stdin;
    public          postgres    false    359   �R                0    77137    TBUSERSECURITYRIGHTS 
   TABLE DATA           F   COPY public."TBUSERSECURITYRIGHTS" ("USERID", "RIGHTSID") FROM stdin;
    public          postgres    false    368   S                0    77140    TYPES 
   TABLE DATA           P   COPY public."TYPES" ("ID", "NEPNAME", "ENGNAME", "CODE", "REMARKS") FROM stdin;
    public          postgres    false    369   9S                0    77143    USERASSIGNMENTS 
   TABLE DATA           �   COPY public."USERASSIGNMENTS" ("SN", "NEPNAME", "RIGHTSNAME", "MODULE", "ACTIVE", "CREATEDAT", "CREATEDBY", "DISPLAYNAME", "ICON", "ISLOCKED", "MENUNAME", "MENUORDER", "MENUURL", "PARENTMENUID", "VISIBLE") FROM stdin;
    public          postgres    false    370   VS                0    77151 
   Usermaster 
   TABLE DATA           �  COPY public."Usermaster" ("Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount", "Userid", "Userpassword", "Nepname", "Engname", "Userstatus", "Lastloggedon", "Lastloggedout", "Grants", "Updatedby", "EmpId", "OrgCode", "Code", "FromCentral", "WardNo", "PwdChangedDate", "FiscalYear") FROM stdin;
    public          postgres    false    371   sS                0    77159    VDC 
   TABLE DATA           i   COPY public."VDC" ("VDCID", "NEPNAME", "ENGNAME", "CODE", "REMARKS", "DISTRICTID", "TYPEID") FROM stdin;
    public          postgres    false    372   mT      x          0    78683    WARD_MASTER 
   TABLE DATA           �   COPY public."WARD_MASTER" ("ID", "NEP_NAME", "ENG_NAME", "ADDRESS", "PRAMUKH_ID", "UPPRAMUKH_ID", "NUMBER_OF_MEMBERS", "WARD_SECRETARY_ID", "MOBILE_NO") FROM stdin;
    public          postgres    false    469   �T                0    77162    ZONE 
   TABLE DATA           _   COPY public."ZONE" ("ZONEID", "NEPNAME", "ENGNAME", "CODE", "REMARKS", "REGIONID") FROM stdin;
    public          postgres    false    373   �T      m          0    76226    __EFMigrationsHistory 
   TABLE DATA           R   COPY public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") FROM stdin;
    public          postgres    false    202   �T      �           0    0    IMISRoleClaim_Id_seq    SEQUENCE SET     E   SELECT pg_catalog.setval('public."IMISRoleClaim_Id_seq"', 1, false);
          public          postgres    false    384            �           0    0    IMISUserClaim_Id_seq    SEQUENCE SET     E   SELECT pg_catalog.setval('public."IMISUserClaim_Id_seq"', 1, false);
          public          postgres    false    403            �           0    0    Imis_Menu_Id_seq    SEQUENCE SET     A   SELECT pg_catalog.setval('public."Imis_Menu_Id_seq"', 1, false);
          public          postgres    false    482            N           2606    76328    ACCODE ACCODE_pkey 
   CONSTRAINT     Z   ALTER TABLE ONLY public."ACCODE"
    ADD CONSTRAINT "ACCODE_pkey" PRIMARY KEY ("ACCODE");
 @   ALTER TABLE ONLY public."ACCODE" DROP CONSTRAINT "ACCODE_pkey";
       public            postgres    false    221            @           2606    77218 "   ACC_ACC_MASTER ACC_ACC_MASTER_pkey 
   CONSTRAINT     j   ALTER TABLE ONLY public."ACC_ACC_MASTER"
    ADD CONSTRAINT "ACC_ACC_MASTER_pkey" PRIMARY KEY ("ACC_ID");
 P   ALTER TABLE ONLY public."ACC_ACC_MASTER" DROP CONSTRAINT "ACC_ACC_MASTER_pkey";
       public            postgres    false    378            l           2606    77390 (   ACC_ASULI_BIBARAN ACC_ASULI_BIBARAN_pkey 
   CONSTRAINT     r   ALTER TABLE ONLY public."ACC_ASULI_BIBARAN"
    ADD CONSTRAINT "ACC_ASULI_BIBARAN_pkey" PRIMARY KEY ("ASULI_ID");
 V   ALTER TABLE ONLY public."ACC_ASULI_BIBARAN" DROP CONSTRAINT "ACC_ASULI_BIBARAN_pkey";
       public            postgres    false    392            G           2606    77246 "   ACC_BANK_GRNTY ACC_BANK_GRNTY_pkey 
   CONSTRAINT     l   ALTER TABLE ONLY public."ACC_BANK_GRNTY"
    ADD CONSTRAINT "ACC_BANK_GRNTY_pkey" PRIMARY KEY ("GRNTY_ID");
 P   ALTER TABLE ONLY public."ACC_BANK_GRNTY" DROP CONSTRAINT "ACC_BANK_GRNTY_pkey";
       public            postgres    false    380            J           2606    78276 "   ACC_BANK_TRANS ACC_BANK_TRANS_pkey 
   CONSTRAINT     q   ALTER TABLE ONLY public."ACC_BANK_TRANS"
    ADD CONSTRAINT "ACC_BANK_TRANS_pkey" PRIMARY KEY ("BANK_TRANS_ID");
 P   ALTER TABLE ONLY public."ACC_BANK_TRANS" DROP CONSTRAINT "ACC_BANK_TRANS_pkey";
       public            postgres    false    449            0           2606    76238 &   ACC_BGT_ALLOCATE ACC_BGT_ALLOCATE_pkey 
   CONSTRAINT     w   ALTER TABLE ONLY public."ACC_BGT_ALLOCATE"
    ADD CONSTRAINT "ACC_BGT_ALLOCATE_pkey" PRIMARY KEY ("BGT_ALLOCATE_ID");
 T   ALTER TABLE ONLY public."ACC_BGT_ALLOCATE" DROP CONSTRAINT "ACC_BGT_ALLOCATE_pkey";
       public            postgres    false    204            O           2606    78298 "   ACC_CASH_TRANS ACC_CASH_TRANS_pkey 
   CONSTRAINT     q   ALTER TABLE ONLY public."ACC_CASH_TRANS"
    ADD CONSTRAINT "ACC_CASH_TRANS_pkey" PRIMARY KEY ("CASH_TRANS_ID");
 P   ALTER TABLE ONLY public."ACC_CASH_TRANS" DROP CONSTRAINT "ACC_CASH_TRANS_pkey";
       public            postgres    false    450            2           2606    76243 &   ACC_CHEQUE_TYPES ACC_CHEQUE_TYPES_pkey 
   CONSTRAINT     v   ALTER TABLE ONLY public."ACC_CHEQUE_TYPES"
    ADD CONSTRAINT "ACC_CHEQUE_TYPES_pkey" PRIMARY KEY ("CHEQUE_TYPE_ID");
 T   ALTER TABLE ONLY public."ACC_CHEQUE_TYPES" DROP CONSTRAINT "ACC_CHEQUE_TYPES_pkey";
       public            postgres    false    205            �           2606    77737 *   ACC_DHRTI_BILL_DTL ACC_DHRTI_BILL_DTL_pkey 
   CONSTRAINT     x   ALTER TABLE ONLY public."ACC_DHRTI_BILL_DTL"
    ADD CONSTRAINT "ACC_DHRTI_BILL_DTL_pkey" PRIMARY KEY ("DHRTI_DTL_ID");
 X   ALTER TABLE ONLY public."ACC_DHRTI_BILL_DTL" DROP CONSTRAINT "ACC_DHRTI_BILL_DTL_pkey";
       public            postgres    false    420            �           2606    77760 0   ACC_DHRTI_BILL_MASTER ACC_DHRTI_BILL_MASTER_pkey 
   CONSTRAINT     �   ALTER TABLE ONLY public."ACC_DHRTI_BILL_MASTER"
    ADD CONSTRAINT "ACC_DHRTI_BILL_MASTER_pkey" PRIMARY KEY ("DHRTI_MASTER_ID");
 ^   ALTER TABLE ONLY public."ACC_DHRTI_BILL_MASTER" DROP CONSTRAINT "ACC_DHRTI_BILL_MASTER_pkey";
       public            postgres    false    421            �           2606    77607 .   ACC_EXPENSES_DETAILS ACC_EXPENSES_DETAILS_pkey 
   CONSTRAINT     z   ALTER TABLE ONLY public."ACC_EXPENSES_DETAILS"
    ADD CONSTRAINT "ACC_EXPENSES_DETAILS_pkey" PRIMARY KEY ("EXPENSE_ID");
 \   ALTER TABLE ONLY public."ACC_EXPENSES_DETAILS" DROP CONSTRAINT "ACC_EXPENSES_DETAILS_pkey";
       public            postgres    false    410            6           2606    76256 0   ACC_FUND_PROVIDR_MSTR ACC_FUND_PROVIDR_MSTR_pkey 
   CONSTRAINT     }   ALTER TABLE ONLY public."ACC_FUND_PROVIDR_MSTR"
    ADD CONSTRAINT "ACC_FUND_PROVIDR_MSTR_pkey" PRIMARY KEY ("PROVIDER_ID");
 ^   ALTER TABLE ONLY public."ACC_FUND_PROVIDR_MSTR" DROP CONSTRAINT "ACC_FUND_PROVIDR_MSTR_pkey";
       public            postgres    false    207            8           2606    76261 $   ACC_INCOME_RATE ACC_INCOME_RATE_pkey 
   CONSTRAINT     m   ALTER TABLE ONLY public."ACC_INCOME_RATE"
    ADD CONSTRAINT "ACC_INCOME_RATE_pkey" PRIMARY KEY ("RATE_ID");
 R   ALTER TABLE ONLY public."ACC_INCOME_RATE" DROP CONSTRAINT "ACC_INCOME_RATE_pkey";
       public            postgres    false    208            :           2606    76266 (   ACC_LAST_YR_PESKI ACC_LAST_YR_PESKI_pkey 
   CONSTRAINT     l   ALTER TABLE ONLY public."ACC_LAST_YR_PESKI"
    ADD CONSTRAINT "ACC_LAST_YR_PESKI_pkey" PRIMARY KEY ("SN");
 V   ALTER TABLE ONLY public."ACC_LAST_YR_PESKI" DROP CONSTRAINT "ACC_LAST_YR_PESKI_pkey";
       public            postgres    false    209            >           2606    76279 "   ACC_ORG_MASTER ACC_ORG_MASTER_pkey 
   CONSTRAINT     j   ALTER TABLE ONLY public."ACC_ORG_MASTER"
    ADD CONSTRAINT "ACC_ORG_MASTER_pkey" PRIMARY KEY ("ORG_ID");
 P   ALTER TABLE ONLY public."ACC_ORG_MASTER" DROP CONSTRAINT "ACC_ORG_MASTER_pkey";
       public            postgres    false    211            =           2606    77205 .   ACC_PADADHIKARI_MSTR ACC_PADADHIKARI_MSTR_pkey 
   CONSTRAINT     }   ALTER TABLE ONLY public."ACC_PADADHIKARI_MSTR"
    ADD CONSTRAINT "ACC_PADADHIKARI_MSTR_pkey" PRIMARY KEY ("PADADIKARI_ID");
 \   ALTER TABLE ONLY public."ACC_PADADHIKARI_MSTR" DROP CONSTRAINT "ACC_PADADHIKARI_MSTR_pkey";
       public            postgres    false    377            @           2606    76284 .   ACC_PADADHIKARI_POST ACC_PADADHIKARI_POST_pkey 
   CONSTRAINT     w   ALTER TABLE ONLY public."ACC_PADADHIKARI_POST"
    ADD CONSTRAINT "ACC_PADADHIKARI_POST_pkey" PRIMARY KEY ("POST_ID");
 \   ALTER TABLE ONLY public."ACC_PADADHIKARI_POST" DROP CONSTRAINT "ACC_PADADHIKARI_POST_pkey";
       public            postgres    false    212            A           2606    78234 ,   ACC_PAYMENT_DETAILS ACC_PAYMENT_DETAILS_pkey 
   CONSTRAINT        ALTER TABLE ONLY public."ACC_PAYMENT_DETAILS"
    ADD CONSTRAINT "ACC_PAYMENT_DETAILS_pkey" PRIMARY KEY ("PAYMENT_DETAIL_ID");
 Z   ALTER TABLE ONLY public."ACC_PAYMENT_DETAILS" DROP CONSTRAINT "ACC_PAYMENT_DETAILS_pkey";
       public            postgres    false    448            �           2606    77785 *   ACC_PAYMENT_MASTER ACC_PAYMENT_MASTER_pkey 
   CONSTRAINT     v   ALTER TABLE ONLY public."ACC_PAYMENT_MASTER"
    ADD CONSTRAINT "ACC_PAYMENT_MASTER_pkey" PRIMARY KEY ("PAYMENT_ID");
 X   ALTER TABLE ONLY public."ACC_PAYMENT_MASTER" DROP CONSTRAINT "ACC_PAYMENT_MASTER_pkey";
       public            postgres    false    422            B           2606    76295 ,   ACC_SUB_MODULE_TYPE ACC_SUB_MODULE_TYPE_pkey 
   CONSTRAINT     {   ALTER TABLE ONLY public."ACC_SUB_MODULE_TYPE"
    ADD CONSTRAINT "ACC_SUB_MODULE_TYPE_pkey" PRIMARY KEY ("SUB_MODULE_ID");
 Z   ALTER TABLE ONLY public."ACC_SUB_MODULE_TYPE" DROP CONSTRAINT "ACC_SUB_MODULE_TYPE_pkey";
       public            postgres    false    215            D           2606    76300 "   ACC_TRANS_TYPE ACC_TRANS_TYPE_pkey 
   CONSTRAINT     k   ALTER TABLE ONLY public."ACC_TRANS_TYPE"
    ADD CONSTRAINT "ACC_TRANS_TYPE_pkey" PRIMARY KEY ("TYPE_ID");
 P   ALTER TABLE ONLY public."ACC_TRANS_TYPE" DROP CONSTRAINT "ACC_TRANS_TYPE_pkey";
       public            postgres    false    216            F           2606    76305 &   ACC_UNAUTHORISED ACC_UNAUTHORISED_pkey 
   CONSTRAINT     w   ALTER TABLE ONLY public."ACC_UNAUTHORISED"
    ADD CONSTRAINT "ACC_UNAUTHORISED_pkey" PRIMARY KEY ("UNAUTHORISED_ID");
 T   ALTER TABLE ONLY public."ACC_UNAUTHORISED" DROP CONSTRAINT "ACC_UNAUTHORISED_pkey";
       public            postgres    false    217            �           2606    77817 &   ACC_VCHR_DETAILS ACC_VCHR_DETAILS_pkey 
   CONSTRAINT     v   ALTER TABLE ONLY public."ACC_VCHR_DETAILS"
    ADD CONSTRAINT "ACC_VCHR_DETAILS_pkey" PRIMARY KEY ("VCHR_DETAIL_ID");
 T   ALTER TABLE ONLY public."ACC_VCHR_DETAILS" DROP CONSTRAINT "ACC_VCHR_DETAILS_pkey";
       public            postgres    false    423            C           2606    77231 $   ACC_VCHR_MASTER ACC_VCHR_MASTER_pkey 
   CONSTRAINT     m   ALTER TABLE ONLY public."ACC_VCHR_MASTER"
    ADD CONSTRAINT "ACC_VCHR_MASTER_pkey" PRIMARY KEY ("VCHR_ID");
 R   ALTER TABLE ONLY public."ACC_VCHR_MASTER" DROP CONSTRAINT "ACC_VCHR_MASTER_pkey";
       public            postgres    false    379            J           2606    76318 .   ACC_VCHR_TYPE_MASTER ACC_VCHR_TYPE_MASTER_pkey 
   CONSTRAINT     |   ALTER TABLE ONLY public."ACC_VCHR_TYPE_MASTER"
    ADD CONSTRAINT "ACC_VCHR_TYPE_MASTER_pkey" PRIMARY KEY ("VCHR_TYPE_ID");
 \   ALTER TABLE ONLY public."ACC_VCHR_TYPE_MASTER" DROP CONSTRAINT "ACC_VCHR_TYPE_MASTER_pkey";
       public            postgres    false    219            K           2606    77261 0   ACC_WORK_FUNDS_DETAIL ACC_WORK_FUNDS_DETAIL_pkey 
   CONSTRAINT     �   ALTER TABLE ONLY public."ACC_WORK_FUNDS_DETAIL"
    ADD CONSTRAINT "ACC_WORK_FUNDS_DETAIL_pkey" PRIMARY KEY ("FUND_DETAIL_ID");
 ^   ALTER TABLE ONLY public."ACC_WORK_FUNDS_DETAIL" DROP CONSTRAINT "ACC_WORK_FUNDS_DETAIL_pkey";
       public            postgres    false    381            L           2606    76323 $   ACC_WORK_MASTER ACC_WORK_MASTER_pkey 
   CONSTRAINT     m   ALTER TABLE ONLY public."ACC_WORK_MASTER"
    ADD CONSTRAINT "ACC_WORK_MASTER_pkey" PRIMARY KEY ("WORK_ID");
 R   ALTER TABLE ONLY public."ACC_WORK_MASTER" DROP CONSTRAINT "ACC_WORK_MASTER_pkey";
       public            postgres    false    220            �           2606    77847 0   ACC_WORK_PAYMNT_TRANS ACC_WORK_PAYMNT_TRANS_pkey 
   CONSTRAINT     z   ALTER TABLE ONLY public."ACC_WORK_PAYMNT_TRANS"
    ADD CONSTRAINT "ACC_WORK_PAYMNT_TRANS_pkey" PRIMARY KEY ("TRANS_ID");
 ^   ALTER TABLE ONLY public."ACC_WORK_PAYMNT_TRANS" DROP CONSTRAINT "ACC_WORK_PAYMNT_TRANS_pkey";
       public            postgres    false    424            P           2606    76333 8   APPLICATION_CONFIGURATION APPLICATION_CONFIGURATION_pkey 
   CONSTRAINT     |   ALTER TABLE ONLY public."APPLICATION_CONFIGURATION"
    ADD CONSTRAINT "APPLICATION_CONFIGURATION_pkey" PRIMARY KEY ("SN");
 f   ALTER TABLE ONLY public."APPLICATION_CONFIGURATION" DROP CONSTRAINT "APPLICATION_CONFIGURATION_pkey";
       public            postgres    false    222            R           2606    76341    BANKMASTER BANKMASTER_pkey 
   CONSTRAINT     b   ALTER TABLE ONLY public."BANKMASTER"
    ADD CONSTRAINT "BANKMASTER_pkey" PRIMARY KEY ("BANKID");
 H   ALTER TABLE ONLY public."BANKMASTER" DROP CONSTRAINT "BANKMASTER_pkey";
       public            postgres    false    223            2           2606    78169 &   BANKTRANSACTIONS BANKTRANSACTIONS_pkey 
   CONSTRAINT     j   ALTER TABLE ONLY public."BANKTRANSACTIONS"
    ADD CONSTRAINT "BANKTRANSACTIONS_pkey" PRIMARY KEY ("SN");
 T   ALTER TABLE ONLY public."BANKTRANSACTIONS" DROP CONSTRAINT "BANKTRANSACTIONS_pkey";
       public            postgres    false    445            O           2606    77279    BANK_BRANCH BANK_BRANCH_pkey 
   CONSTRAINT     g   ALTER TABLE ONLY public."BANK_BRANCH"
    ADD CONSTRAINT "BANK_BRANCH_pkey" PRIMARY KEY ("BRANCH_ID");
 J   ALTER TABLE ONLY public."BANK_BRANCH" DROP CONSTRAINT "BANK_BRANCH_pkey";
       public            postgres    false    382            7           2606    78192 $   CASHTRANSACTION CASHTRANSACTION_pkey 
   CONSTRAINT     h   ALTER TABLE ONLY public."CASHTRANSACTION"
    ADD CONSTRAINT "CASHTRANSACTION_pkey" PRIMARY KEY ("SN");
 R   ALTER TABLE ONLY public."CASHTRANSACTION" DROP CONSTRAINT "CASHTRANSACTION_pkey";
       public            postgres    false    446            V           2606    76366 *   COLLECTIONCOUNTERS COLLECTIONCOUNTERS_pkey 
   CONSTRAINT     u   ALTER TABLE ONLY public."COLLECTIONCOUNTERS"
    ADD CONSTRAINT "COLLECTIONCOUNTERS_pkey" PRIMARY KEY ("COUNTERID");
 X   ALTER TABLE ONLY public."COLLECTIONCOUNTERS" DROP CONSTRAINT "COLLECTIONCOUNTERS_pkey";
       public            postgres    false    228            �           2606    77867 (   INCOMEBILLDETAILS INCOMEBILLDETAILS_pkey 
   CONSTRAINT     l   ALTER TABLE ONLY public."INCOMEBILLDETAILS"
    ADD CONSTRAINT "INCOMEBILLDETAILS_pkey" PRIMARY KEY ("SN");
 V   ALTER TABLE ONLY public."INCOMEBILLDETAILS" DROP CONSTRAINT "INCOMEBILLDETAILS_pkey";
       public            postgres    false    425            �           2606    77885 &   INCOMEBILLMASTER INCOMEBILLMASTER_pkey 
   CONSTRAINT     j   ALTER TABLE ONLY public."INCOMEBILLMASTER"
    ADD CONSTRAINT "INCOMEBILLMASTER_pkey" PRIMARY KEY ("SN");
 T   ALTER TABLE ONLY public."INCOMEBILLMASTER" DROP CONSTRAINT "INCOMEBILLMASTER_pkey";
       public            postgres    false    426            e           2606    76442    INV_BRAND INV_BRAND_pkey 
   CONSTRAINT     b   ALTER TABLE ONLY public."INV_BRAND"
    ADD CONSTRAINT "INV_BRAND_pkey" PRIMARY KEY ("BRAND_ID");
 F   ALTER TABLE ONLY public."INV_BRAND" DROP CONSTRAINT "INV_BRAND_pkey";
       public            postgres    false    243            k           2606    76457    INV_DEPT INV_DEPT_pkey 
   CONSTRAINT     _   ALTER TABLE ONLY public."INV_DEPT"
    ADD CONSTRAINT "INV_DEPT_pkey" PRIMARY KEY ("DEPT_ID");
 D   ALTER TABLE ONLY public."INV_DEPT" DROP CONSTRAINT "INV_DEPT_pkey";
       public            postgres    false    246            �           2606    78843 &   INV_ITEM_DETAILS INV_ITEM_DETAILS_pkey 
   CONSTRAINT     s   ALTER TABLE ONLY public."INV_ITEM_DETAILS"
    ADD CONSTRAINT "INV_ITEM_DETAILS_pkey" PRIMARY KEY ("ITEM_DTL_ID");
 T   ALTER TABLE ONLY public."INV_ITEM_DETAILS" DROP CONSTRAINT "INV_ITEM_DETAILS_pkey";
       public            postgres    false    477            _           2606    77342    INV_ITEM_MST INV_ITEM_MST_pkey 
   CONSTRAINT     g   ALTER TABLE ONLY public."INV_ITEM_MST"
    ADD CONSTRAINT "INV_ITEM_MST_pkey" PRIMARY KEY ("ITEM_ID");
 L   ALTER TABLE ONLY public."INV_ITEM_MST" DROP CONSTRAINT "INV_ITEM_MST_pkey";
       public            postgres    false    388            u           2606    76488     INV_ITEM_SPEC INV_ITEM_SPEC_pkey 
   CONSTRAINT     i   ALTER TABLE ONLY public."INV_ITEM_SPEC"
    ADD CONSTRAINT "INV_ITEM_SPEC_pkey" PRIMARY KEY ("SPEC_ID");
 N   ALTER TABLE ONLY public."INV_ITEM_SPEC" DROP CONSTRAINT "INV_ITEM_SPEC_pkey";
       public            postgres    false    251                       2606    76522    INV_PROJECT INV_PROJECT_pkey 
   CONSTRAINT     h   ALTER TABLE ONLY public."INV_PROJECT"
    ADD CONSTRAINT "INV_PROJECT_pkey" PRIMARY KEY ("PROJECT_ID");
 J   ALTER TABLE ONLY public."INV_PROJECT" DROP CONSTRAINT "INV_PROJECT_pkey";
       public            postgres    false    257            Y           2606    77319    INV_ROOM_MST INV_ROOM_MST_pkey 
   CONSTRAINT     g   ALTER TABLE ONLY public."INV_ROOM_MST"
    ADD CONSTRAINT "INV_ROOM_MST_pkey" PRIMARY KEY ("ROOM_ID");
 L   ALTER TABLE ONLY public."INV_ROOM_MST" DROP CONSTRAINT "INV_ROOM_MST_pkey";
       public            postgres    false    386            �           2606    76543    INV_SUPPLIER INV_SUPPLIER_pkey 
   CONSTRAINT     f   ALTER TABLE ONLY public."INV_SUPPLIER"
    ADD CONSTRAINT "INV_SUPPLIER_pkey" PRIMARY KEY ("SUP_ID");
 L   ALTER TABLE ONLY public."INV_SUPPLIER" DROP CONSTRAINT "INV_SUPPLIER_pkey";
       public            postgres    false    261            �           2606    76553    INV_TAX_RATE INV_TAX_RATE_pkey 
   CONSTRAINT     k   ALTER TABLE ONLY public."INV_TAX_RATE"
    ADD CONSTRAINT "INV_TAX_RATE_pkey" PRIMARY KEY ("TAX_RATE_ID");
 L   ALTER TABLE ONLY public."INV_TAX_RATE" DROP CONSTRAINT "INV_TAX_RATE_pkey";
       public            postgres    false    263            �           2606    76563    INV_UNIT INV_UNIT_pkey 
   CONSTRAINT     _   ALTER TABLE ONLY public."INV_UNIT"
    ADD CONSTRAINT "INV_UNIT_pkey" PRIMARY KEY ("UNIT_ID");
 D   ALTER TABLE ONLY public."INV_UNIT" DROP CONSTRAINT "INV_UNIT_pkey";
       public            postgres    false    265            �           2606    76568     INV_WAREHOUSE INV_WAREHOUSE_pkey 
   CONSTRAINT     n   ALTER TABLE ONLY public."INV_WAREHOUSE"
    ADD CONSTRAINT "INV_WAREHOUSE_pkey" PRIMARY KEY ("WAREHOUSE_ID");
 N   ALTER TABLE ONLY public."INV_WAREHOUSE" DROP CONSTRAINT "INV_WAREHOUSE_pkey";
       public            postgres    false    266            ^           2606    79250    Imis_Menu Imis_Menu_pkey 
   CONSTRAINT     \   ALTER TABLE ONLY public."Imis_Menu"
    ADD CONSTRAINT "Imis_Menu_pkey" PRIMARY KEY ("Id");
 F   ALTER TABLE ONLY public."Imis_Menu" DROP CONSTRAINT "Imis_Menu_pkey";
       public            postgres    false    239            �           2606    76637 "   MAP_HTSTANDARD MAP_HTSTANDARD_pkey 
   CONSTRAINT     f   ALTER TABLE ONLY public."MAP_HTSTANDARD"
    ADD CONSTRAINT "MAP_HTSTANDARD_pkey" PRIMARY KEY ("SN");
 P   ALTER TABLE ONLY public."MAP_HTSTANDARD" DROP CONSTRAINT "MAP_HTSTANDARD_pkey";
       public            postgres    false    280            �           2606    76667    MAP_SITE MAP_SITE_pkey 
   CONSTRAINT     Z   ALTER TABLE ONLY public."MAP_SITE"
    ADD CONSTRAINT "MAP_SITE_pkey" PRIMARY KEY ("SN");
 D   ALTER TABLE ONLY public."MAP_SITE" DROP CONSTRAINT "MAP_SITE_pkey";
       public            postgres    false    286            �           2606    76706 0   NEW_PROPERTY_TAXTABLE NEW_PROPERTY_TAXTABLE_pkey 
   CONSTRAINT     t   ALTER TABLE ONLY public."NEW_PROPERTY_TAXTABLE"
    ADD CONSTRAINT "NEW_PROPERTY_TAXTABLE_pkey" PRIMARY KEY ("SN");
 ^   ALTER TABLE ONLY public."NEW_PROPERTY_TAXTABLE" DROP CONSTRAINT "NEW_PROPERTY_TAXTABLE_pkey";
       public            postgres    false    294            �           2606    76716 ,   PAYMENT_SLIP_MASTER PAYMENT_SLIP_MASTER_pkey 
   CONSTRAINT     }   ALTER TABLE ONLY public."PAYMENT_SLIP_MASTER"
    ADD CONSTRAINT "PAYMENT_SLIP_MASTER_pkey" PRIMARY KEY ("PAYMENT_SLIP_ID");
 Z   ALTER TABLE ONLY public."PAYMENT_SLIP_MASTER" DROP CONSTRAINT "PAYMENT_SLIP_MASTER_pkey";
       public            postgres    false    296            �           2606    76724 *   PERSON_TYPE_MASTER PERSON_TYPE_MASTER_pkey 
   CONSTRAINT     z   ALTER TABLE ONLY public."PERSON_TYPE_MASTER"
    ADD CONSTRAINT "PERSON_TYPE_MASTER_pkey" PRIMARY KEY ("PERSON_TYPE_ID");
 X   ALTER TABLE ONLY public."PERSON_TYPE_MASTER" DROP CONSTRAINT "PERSON_TYPE_MASTER_pkey";
       public            postgres    false    297            �           2606    77950    PIS_AWARDS PIS_AWARDS_pkey 
   CONSTRAINT     ^   ALTER TABLE ONLY public."PIS_AWARDS"
    ADD CONSTRAINT "PIS_AWARDS_pkey" PRIMARY KEY ("SN");
 H   ALTER TABLE ONLY public."PIS_AWARDS" DROP CONSTRAINT "PIS_AWARDS_pkey";
       public            postgres    false    429            �           2606    78507 &   PIS_BANK_PAYROLL PIS_BANK_PAYROLL_pkey 
   CONSTRAINT     j   ALTER TABLE ONLY public."PIS_BANK_PAYROLL"
    ADD CONSTRAINT "PIS_BANK_PAYROLL_pkey" PRIMARY KEY ("SN");
 T   ALTER TABLE ONLY public."PIS_BANK_PAYROLL" DROP CONSTRAINT "PIS_BANK_PAYROLL_pkey";
       public            postgres    false    458            �           2606    77960    PIS_DARBANDI PIS_DARBANDI_pkey 
   CONSTRAINT     k   ALTER TABLE ONLY public."PIS_DARBANDI"
    ADD CONSTRAINT "PIS_DARBANDI_pkey" PRIMARY KEY ("DARBANDI_ID");
 L   ALTER TABLE ONLY public."PIS_DARBANDI" DROP CONSTRAINT "PIS_DARBANDI_pkey";
       public            postgres    false    430            �           2606    78767 <   PIS_DELETD_FRM_FULFILD_DARB PIS_DELETD_FRM_FULFILD_DARB_pkey 
   CONSTRAINT     �   ALTER TABLE ONLY public."PIS_DELETD_FRM_FULFILD_DARB"
    ADD CONSTRAINT "PIS_DELETD_FRM_FULFILD_DARB_pkey" PRIMARY KEY ("SN");
 j   ALTER TABLE ONLY public."PIS_DELETD_FRM_FULFILD_DARB" DROP CONSTRAINT "PIS_DELETD_FRM_FULFILD_DARB_pkey";
       public            postgres    false    474            q           2606    77400     PIS_EDUCATION PIS_EDUCATION_pkey 
   CONSTRAINT     d   ALTER TABLE ONLY public."PIS_EDUCATION"
    ADD CONSTRAINT "PIS_EDUCATION_pkey" PRIMARY KEY ("SN");
 N   ALTER TABLE ONLY public."PIS_EDUCATION" DROP CONSTRAINT "PIS_EDUCATION_pkey";
       public            postgres    false    393            �           2606    76744     PIS_EDU_LEVEL PIS_EDU_LEVEL_pkey 
   CONSTRAINT     h   ALTER TABLE ONLY public."PIS_EDU_LEVEL"
    ADD CONSTRAINT "PIS_EDU_LEVEL_pkey" PRIMARY KEY ("EDU_ID");
 N   ALTER TABLE ONLY public."PIS_EDU_LEVEL" DROP CONSTRAINT "PIS_EDU_LEVEL_pkey";
       public            postgres    false    301                       2606    77983 ,   PIS_EMPLOYEE_MASTER PIS_EMPLOYEE_MASTER_pkey 
   CONSTRAINT     t   ALTER TABLE ONLY public."PIS_EMPLOYEE_MASTER"
    ADD CONSTRAINT "PIS_EMPLOYEE_MASTER_pkey" PRIMARY KEY ("EMP_ID");
 Z   ALTER TABLE ONLY public."PIS_EMPLOYEE_MASTER" DROP CONSTRAINT "PIS_EMPLOYEE_MASTER_pkey";
       public            postgres    false    431            t           2606    77415 *   PIS_EMP_DEP_SOURCE PIS_EMP_DEP_SOURCE_pkey 
   CONSTRAINT     s   ALTER TABLE ONLY public."PIS_EMP_DEP_SOURCE"
    ADD CONSTRAINT "PIS_EMP_DEP_SOURCE_pkey" PRIMARY KEY ("DEPT_ID");
 X   ALTER TABLE ONLY public."PIS_EMP_DEP_SOURCE" DROP CONSTRAINT "PIS_EMP_DEP_SOURCE_pkey";
       public            postgres    false    394            �           2606    76754    PIS_EMP_DEP PIS_EMP_DEP_pkey 
   CONSTRAINT     e   ALTER TABLE ONLY public."PIS_EMP_DEP"
    ADD CONSTRAINT "PIS_EMP_DEP_pkey" PRIMARY KEY ("DEPT_ID");
 J   ALTER TABLE ONLY public."PIS_EMP_DEP" DROP CONSTRAINT "PIS_EMP_DEP_pkey";
       public            postgres    false    303            �           2606    78532     PIS_EMP_LOANS PIS_EMP_LOANS_pkey 
   CONSTRAINT     i   ALTER TABLE ONLY public."PIS_EMP_LOANS"
    ADD CONSTRAINT "PIS_EMP_LOANS_pkey" PRIMARY KEY ("LOAN_ID");
 N   ALTER TABLE ONLY public."PIS_EMP_LOANS" DROP CONSTRAINT "PIS_EMP_LOANS_pkey";
       public            postgres    false    460            �           2606    78542 ,   PIS_EMP_LONG_LEAVES PIS_EMP_LONG_LEAVES_pkey 
   CONSTRAINT     p   ALTER TABLE ONLY public."PIS_EMP_LONG_LEAVES"
    ADD CONSTRAINT "PIS_EMP_LONG_LEAVES_pkey" PRIMARY KEY ("SN");
 Z   ALTER TABLE ONLY public."PIS_EMP_LONG_LEAVES" DROP CONSTRAINT "PIS_EMP_LONG_LEAVES_pkey";
       public            postgres    false    461            �           2606    78557 ,   PIS_EMP_MED_EXPENSE PIS_EMP_MED_EXPENSE_pkey 
   CONSTRAINT     p   ALTER TABLE ONLY public."PIS_EMP_MED_EXPENSE"
    ADD CONSTRAINT "PIS_EMP_MED_EXPENSE_pkey" PRIMARY KEY ("SN");
 Z   ALTER TABLE ONLY public."PIS_EMP_MED_EXPENSE" DROP CONSTRAINT "PIS_EMP_MED_EXPENSE_pkey";
       public            postgres    false    462            �           2606    78572 *   PIS_EMP_PUNISHMNTS PIS_EMP_PUNISHMNTS_pkey 
   CONSTRAINT     n   ALTER TABLE ONLY public."PIS_EMP_PUNISHMNTS"
    ADD CONSTRAINT "PIS_EMP_PUNISHMNTS_pkey" PRIMARY KEY ("SN");
 X   ALTER TABLE ONLY public."PIS_EMP_PUNISHMNTS" DROP CONSTRAINT "PIS_EMP_PUNISHMNTS_pkey";
       public            postgres    false    463            �           2606    78587 (   PIS_EMP_SRVC_DTLS PIS_EMP_SRVC_DTLS_pkey 
   CONSTRAINT     l   ALTER TABLE ONLY public."PIS_EMP_SRVC_DTLS"
    ADD CONSTRAINT "PIS_EMP_SRVC_DTLS_pkey" PRIMARY KEY ("SN");
 V   ALTER TABLE ONLY public."PIS_EMP_SRVC_DTLS" DROP CONSTRAINT "PIS_EMP_SRVC_DTLS_pkey";
       public            postgres    false    464            �           2606    78602 &   PIS_EMP_SUSPENDS PIS_EMP_SUSPENDS_pkey 
   CONSTRAINT     j   ALTER TABLE ONLY public."PIS_EMP_SUSPENDS"
    ADD CONSTRAINT "PIS_EMP_SUSPENDS_pkey" PRIMARY KEY ("SN");
 T   ALTER TABLE ONLY public."PIS_EMP_SUSPENDS" DROP CONSTRAINT "PIS_EMP_SUSPENDS_pkey";
       public            postgres    false    465            �           2606    78617 *   PIS_EMP_TRNSFR_REC PIS_EMP_TRNSFR_REC_pkey 
   CONSTRAINT     n   ALTER TABLE ONLY public."PIS_EMP_TRNSFR_REC"
    ADD CONSTRAINT "PIS_EMP_TRNSFR_REC_pkey" PRIMARY KEY ("SN");
 X   ALTER TABLE ONLY public."PIS_EMP_TRNSFR_REC" DROP CONSTRAINT "PIS_EMP_TRNSFR_REC_pkey";
       public            postgres    false    466                       2606    78013 *   PIS_FOREIGN_VISITS PIS_FOREIGN_VISITS_pkey 
   CONSTRAINT     n   ALTER TABLE ONLY public."PIS_FOREIGN_VISITS"
    ADD CONSTRAINT "PIS_FOREIGN_VISITS_pkey" PRIMARY KEY ("SN");
 X   ALTER TABLE ONLY public."PIS_FOREIGN_VISITS" DROP CONSTRAINT "PIS_FOREIGN_VISITS_pkey";
       public            postgres    false    432            V           2606    78313 2   PIS_FULFILLED_DARBANDI PIS_FULFILLED_DARBANDI_pkey 
   CONSTRAINT     v   ALTER TABLE ONLY public."PIS_FULFILLED_DARBANDI"
    ADD CONSTRAINT "PIS_FULFILLED_DARBANDI_pkey" PRIMARY KEY ("SN");
 `   ALTER TABLE ONLY public."PIS_FULFILLED_DARBANDI" DROP CONSTRAINT "PIS_FULFILLED_DARBANDI_pkey";
       public            postgres    false    451            �           2606    76775    PIS_HAJIRI PIS_HAJIRI_pkey 
   CONSTRAINT     ^   ALTER TABLE ONLY public."PIS_HAJIRI"
    ADD CONSTRAINT "PIS_HAJIRI_pkey" PRIMARY KEY ("SN");
 H   ALTER TABLE ONLY public."PIS_HAJIRI" DROP CONSTRAINT "PIS_HAJIRI_pkey";
       public            postgres    false    306            �           2606    78632 0   PIS_INTERNAL_TRANSFER PIS_INTERNAL_TRANSFER_pkey 
   CONSTRAINT     t   ALTER TABLE ONLY public."PIS_INTERNAL_TRANSFER"
    ADD CONSTRAINT "PIS_INTERNAL_TRANSFER_pkey" PRIMARY KEY ("SN");
 ^   ALTER TABLE ONLY public."PIS_INTERNAL_TRANSFER" DROP CONSTRAINT "PIS_INTERNAL_TRANSFER_pkey";
       public            postgres    false    467            �           2606    76783 $   PIS_LAND_BLDNGS PIS_LAND_BLDNGS_pkey 
   CONSTRAINT     h   ALTER TABLE ONLY public."PIS_LAND_BLDNGS"
    ADD CONSTRAINT "PIS_LAND_BLDNGS_pkey" PRIMARY KEY ("SN");
 R   ALTER TABLE ONLY public."PIS_LAND_BLDNGS" DROP CONSTRAINT "PIS_LAND_BLDNGS_pkey";
       public            postgres    false    307            �           2606    76791 .   PIS_LOAN_DHITO_GIVEN PIS_LOAN_DHITO_GIVEN_pkey 
   CONSTRAINT     r   ALTER TABLE ONLY public."PIS_LOAN_DHITO_GIVEN"
    ADD CONSTRAINT "PIS_LOAN_DHITO_GIVEN_pkey" PRIMARY KEY ("SN");
 \   ALTER TABLE ONLY public."PIS_LOAN_DHITO_GIVEN" DROP CONSTRAINT "PIS_LOAN_DHITO_GIVEN_pkey";
       public            postgres    false    308            �           2606    76799 .   PIS_LOAN_DHITO_TAKEN PIS_LOAN_DHITO_TAKEN_pkey 
   CONSTRAINT     r   ALTER TABLE ONLY public."PIS_LOAN_DHITO_TAKEN"
    ADD CONSTRAINT "PIS_LOAN_DHITO_TAKEN_pkey" PRIMARY KEY ("SN");
 \   ALTER TABLE ONLY public."PIS_LOAN_DHITO_TAKEN" DROP CONSTRAINT "PIS_LOAN_DHITO_TAKEN_pkey";
       public            postgres    false    309            {           2606    77448 0   PIS_LOCAL_POST_MASTER PIS_LOCAL_POST_MASTER_pkey 
   CONSTRAINT        ALTER TABLE ONLY public."PIS_LOCAL_POST_MASTER"
    ADD CONSTRAINT "PIS_LOCAL_POST_MASTER_pkey" PRIMARY KEY ("LOCAL_POST_ID");
 ^   ALTER TABLE ONLY public."PIS_LOCAL_POST_MASTER" DROP CONSTRAINT "PIS_LOCAL_POST_MASTER_pkey";
       public            postgres    false    396            �           2606    76814     PIS_ORNAMENTS PIS_ORNAMENTS_pkey 
   CONSTRAINT     d   ALTER TABLE ONLY public."PIS_ORNAMENTS"
    ADD CONSTRAINT "PIS_ORNAMENTS_pkey" PRIMARY KEY ("SN");
 N   ALTER TABLE ONLY public."PIS_ORNAMENTS" DROP CONSTRAINT "PIS_ORNAMENTS_pkey";
       public            postgres    false    311            �           2606    76827 ,   PIS_PD_ORG_INVLVMNT PIS_PD_ORG_INVLVMNT_pkey 
   CONSTRAINT     p   ALTER TABLE ONLY public."PIS_PD_ORG_INVLVMNT"
    ADD CONSTRAINT "PIS_PD_ORG_INVLVMNT_pkey" PRIMARY KEY ("SN");
 Z   ALTER TABLE ONLY public."PIS_PD_ORG_INVLVMNT" DROP CONSTRAINT "PIS_PD_ORG_INVLVMNT_pkey";
       public            postgres    false    313            �           2606    76832 &   PIS_PD_SRVC_DTLS PIS_PD_SRVC_DTLS_pkey 
   CONSTRAINT     j   ALTER TABLE ONLY public."PIS_PD_SRVC_DTLS"
    ADD CONSTRAINT "PIS_PD_SRVC_DTLS_pkey" PRIMARY KEY ("SN");
 T   ALTER TABLE ONLY public."PIS_PD_SRVC_DTLS" DROP CONSTRAINT "PIS_PD_SRVC_DTLS_pkey";
       public            postgres    false    314            �           2606    76840 2   PIS_PERSON_VISIT_RECRD PIS_PERSON_VISIT_RECRD_pkey 
   CONSTRAINT     v   ALTER TABLE ONLY public."PIS_PERSON_VISIT_RECRD"
    ADD CONSTRAINT "PIS_PERSON_VISIT_RECRD_pkey" PRIMARY KEY ("SN");
 `   ALTER TABLE ONLY public."PIS_PERSON_VISIT_RECRD" DROP CONSTRAINT "PIS_PERSON_VISIT_RECRD_pkey";
       public            postgres    false    315            �           2606    76845 $   PIS_POST_MASTER PIS_POST_MASTER_pkey 
   CONSTRAINT     m   ALTER TABLE ONLY public."PIS_POST_MASTER"
    ADD CONSTRAINT "PIS_POST_MASTER_pkey" PRIMARY KEY ("POST_ID");
 R   ALTER TABLE ONLY public."PIS_POST_MASTER" DROP CONSTRAINT "PIS_POST_MASTER_pkey";
       public            postgres    false    316                       2606    78033    PIS_PRIZES PIS_PRIZES_pkey 
   CONSTRAINT     ^   ALTER TABLE ONLY public."PIS_PRIZES"
    ADD CONSTRAINT "PIS_PRIZES_pkey" PRIMARY KEY ("SN");
 H   ALTER TABLE ONLY public."PIS_PRIZES" DROP CONSTRAINT "PIS_PRIZES_pkey";
       public            postgres    false    434                       2606    78043 $   PIS_PUBLICATION PIS_PUBLICATION_pkey 
   CONSTRAINT     h   ALTER TABLE ONLY public."PIS_PUBLICATION"
    ADD CONSTRAINT "PIS_PUBLICATION_pkey" PRIMARY KEY ("SN");
 R   ALTER TABLE ONLY public."PIS_PUBLICATION" DROP CONSTRAINT "PIS_PUBLICATION_pkey";
       public            postgres    false    435            �           2606    78792 6   PIS_REPLACED_IN_DARBANDI PIS_REPLACED_IN_DARBANDI_pkey 
   CONSTRAINT     z   ALTER TABLE ONLY public."PIS_REPLACED_IN_DARBANDI"
    ADD CONSTRAINT "PIS_REPLACED_IN_DARBANDI_pkey" PRIMARY KEY ("SN");
 d   ALTER TABLE ONLY public."PIS_REPLACED_IN_DARBANDI" DROP CONSTRAINT "PIS_REPLACED_IN_DARBANDI_pkey";
       public            postgres    false    475                       2606    78053 &   PIS_SGNFCNT_WORK PIS_SGNFCNT_WORK_pkey 
   CONSTRAINT     j   ALTER TABLE ONLY public."PIS_SGNFCNT_WORK"
    ADD CONSTRAINT "PIS_SGNFCNT_WORK_pkey" PRIMARY KEY ("SN");
 T   ALTER TABLE ONLY public."PIS_SGNFCNT_WORK" DROP CONSTRAINT "PIS_SGNFCNT_WORK_pkey";
       public            postgres    false    436            �           2606    76855 0   PIS_SHARE_BANKBALANCE PIS_SHARE_BANKBALANCE_pkey 
   CONSTRAINT     t   ALTER TABLE ONLY public."PIS_SHARE_BANKBALANCE"
    ADD CONSTRAINT "PIS_SHARE_BANKBALANCE_pkey" PRIMARY KEY ("SN");
 ^   ALTER TABLE ONLY public."PIS_SHARE_BANKBALANCE" DROP CONSTRAINT "PIS_SHARE_BANKBALANCE_pkey";
       public            postgres    false    318                       2606    78063    PIS_TRAINING PIS_TRAINING_pkey 
   CONSTRAINT     b   ALTER TABLE ONLY public."PIS_TRAINING"
    ADD CONSTRAINT "PIS_TRAINING_pkey" PRIMARY KEY ("SN");
 L   ALTER TABLE ONLY public."PIS_TRAINING" DROP CONSTRAINT "PIS_TRAINING_pkey";
       public            postgres    false    437            �           2606    78707 0   PIS_VISITED_COUNTRIES PIS_VISITED_COUNTRIES_pkey 
   CONSTRAINT     t   ALTER TABLE ONLY public."PIS_VISITED_COUNTRIES"
    ADD CONSTRAINT "PIS_VISITED_COUNTRIES_pkey" PRIMARY KEY ("SN");
 ^   ALTER TABLE ONLY public."PIS_VISITED_COUNTRIES" DROP CONSTRAINT "PIS_VISITED_COUNTRIES_pkey";
       public            postgres    false    470                       2606    78073    PIS_WORKSHOP PIS_WORKSHOP_pkey 
   CONSTRAINT     b   ALTER TABLE ONLY public."PIS_WORKSHOP"
    ADD CONSTRAINT "PIS_WORKSHOP_pkey" PRIMARY KEY ("SN");
 L   ALTER TABLE ONLY public."PIS_WORKSHOP" DROP CONSTRAINT "PIS_WORKSHOP_pkey";
       public            postgres    false    438            5           2606    77169    ACC_BGT_RVSN PK_ACC_BGT_RVSN 
   CONSTRAINT     `   ALTER TABLE ONLY public."ACC_BGT_RVSN"
    ADD CONSTRAINT "PK_ACC_BGT_RVSN" PRIMARY KEY ("ID");
 J   ALTER TABLE ONLY public."ACC_BGT_RVSN" DROP CONSTRAINT "PK_ACC_BGT_RVSN";
       public            postgres    false    374            �           2606    77587 $   ACC_BGT_TRANSFER PK_ACC_BGT_TRANSFER 
   CONSTRAINT     h   ALTER TABLE ONLY public."ACC_BGT_TRANSFER"
    ADD CONSTRAINT "PK_ACC_BGT_TRANSFER" PRIMARY KEY ("ID");
 R   ALTER TABLE ONLY public."ACC_BGT_TRANSFER" DROP CONSTRAINT "PK_ACC_BGT_TRANSFER";
       public            postgres    false    409            j           2606    77372 &   ACC_BUDJET_SOURCE PK_ACC_BUDJET_SOURCE 
   CONSTRAINT     j   ALTER TABLE ONLY public."ACC_BUDJET_SOURCE"
    ADD CONSTRAINT "PK_ACC_BUDJET_SOURCE" PRIMARY KEY ("ID");
 T   ALTER TABLE ONLY public."ACC_BUDJET_SOURCE" DROP CONSTRAINT "PK_ACC_BUDJET_SOURCE";
       public            postgres    false    391            4           2606    76251    ACC_CURRENCTY PK_ACC_CURRENCTY 
   CONSTRAINT     b   ALTER TABLE ONLY public."ACC_CURRENCTY"
    ADD CONSTRAINT "PK_ACC_CURRENCTY" PRIMARY KEY ("ID");
 L   ALTER TABLE ONLY public."ACC_CURRENCTY" DROP CONSTRAINT "PK_ACC_CURRENCTY";
       public            postgres    false    206            8           2606    77179 (   ACC_CURRENCTY_RATE PK_ACC_CURRENCTY_RATE 
   CONSTRAINT     l   ALTER TABLE ONLY public."ACC_CURRENCTY_RATE"
    ADD CONSTRAINT "PK_ACC_CURRENCTY_RATE" PRIMARY KEY ("ID");
 V   ALTER TABLE ONLY public."ACC_CURRENCTY_RATE" DROP CONSTRAINT "PK_ACC_CURRENCTY_RATE";
       public            postgres    false    375            <           2606    76271 4   ACC_LASTYEAR_ADV_DETAILS PK_ACC_LASTYEAR_ADV_DETAILS 
   CONSTRAINT     x   ALTER TABLE ONLY public."ACC_LASTYEAR_ADV_DETAILS"
    ADD CONSTRAINT "PK_ACC_LASTYEAR_ADV_DETAILS" PRIMARY KEY ("ID");
 b   ALTER TABLE ONLY public."ACC_LASTYEAR_ADV_DETAILS" DROP CONSTRAINT "PK_ACC_LASTYEAR_ADV_DETAILS";
       public            postgres    false    210            �           2606    77637 .   ACC_PAYMENT_CLEARANCE PK_ACC_PAYMENT_CLEARANCE 
   CONSTRAINT     r   ALTER TABLE ONLY public."ACC_PAYMENT_CLEARANCE"
    ADD CONSTRAINT "PK_ACC_PAYMENT_CLEARANCE" PRIMARY KEY ("ID");
 \   ALTER TABLE ONLY public."ACC_PAYMENT_CLEARANCE" DROP CONSTRAINT "PK_ACC_PAYMENT_CLEARANCE";
       public            postgres    false    411            ?           2606    78212 .   ACC_PAYMENT_DEDUCTION PK_ACC_PAYMENT_DEDUCTION 
   CONSTRAINT     r   ALTER TABLE ONLY public."ACC_PAYMENT_DEDUCTION"
    ADD CONSTRAINT "PK_ACC_PAYMENT_DEDUCTION" PRIMARY KEY ("ID");
 \   ALTER TABLE ONLY public."ACC_PAYMENT_DEDUCTION" DROP CONSTRAINT "PK_ACC_PAYMENT_DEDUCTION";
       public            postgres    false    447            H           2606    76313 ,   ACC_USER_COMITE_MSTR PK_ACC_USER_COMITE_MSTR 
   CONSTRAINT     p   ALTER TABLE ONLY public."ACC_USER_COMITE_MSTR"
    ADD CONSTRAINT "PK_ACC_USER_COMITE_MSTR" PRIMARY KEY ("ID");
 Z   ALTER TABLE ONLY public."ACC_USER_COMITE_MSTR" DROP CONSTRAINT "PK_ACC_USER_COMITE_MSTR";
       public            postgres    false    218            T           2606    76349    BUDJET_SOURCE PK_BUDJET_SOURCE 
   CONSTRAINT     b   ALTER TABLE ONLY public."BUDJET_SOURCE"
    ADD CONSTRAINT "PK_BUDJET_SOURCE" PRIMARY KEY ("ID");
 L   ALTER TABLE ONLY public."BUDJET_SOURCE" DROP CONSTRAINT "PK_BUDJET_SOURCE";
       public            postgres    false    224            X           2606    76377    CONTACTS PK_CONTACTS 
   CONSTRAINT     X   ALTER TABLE ONLY public."CONTACTS"
    ADD CONSTRAINT "PK_CONTACTS" PRIMARY KEY ("ID");
 B   ALTER TABLE ONLY public."CONTACTS" DROP CONSTRAINT "PK_CONTACTS";
       public            postgres    false    230            Z           2606    76394    EMP_GRP PK_EMP_GRP 
   CONSTRAINT     V   ALTER TABLE ONLY public."EMP_GRP"
    ADD CONSTRAINT "PK_EMP_GRP" PRIMARY KEY ("ID");
 @   ALTER TABLE ONLY public."EMP_GRP" DROP CONSTRAINT "PK_EMP_GRP";
       public            postgres    false    235            �           2606    77652 $   FIREBRIGADESTATE PK_FIREBRIGADESTATE 
   CONSTRAINT     h   ALTER TABLE ONLY public."FIREBRIGADESTATE"
    ADD CONSTRAINT "PK_FIREBRIGADESTATE" PRIMARY KEY ("ID");
 R   ALTER TABLE ONLY public."FIREBRIGADESTATE" DROP CONSTRAINT "PK_FIREBRIGADESTATE";
       public            postgres    false    412            \           2606    76402 &   FYWISERENTDARRATE PK_FYWISERENTDARRATE 
   CONSTRAINT     j   ALTER TABLE ONLY public."FYWISERENTDARRATE"
    ADD CONSTRAINT "PK_FYWISERENTDARRATE" PRIMARY KEY ("ID");
 T   ALTER TABLE ONLY public."FYWISERENTDARRATE" DROP CONSTRAINT "PK_FYWISERENTDARRATE";
       public            postgres    false    237            `           2606    76426    IMISRole PK_IMISRole 
   CONSTRAINT     X   ALTER TABLE ONLY public."IMISRole"
    ADD CONSTRAINT "PK_IMISRole" PRIMARY KEY ("Id");
 B   ALTER TABLE ONLY public."IMISRole" DROP CONSTRAINT "PK_IMISRole";
       public            postgres    false    240            W           2606    77309    IMISRoleClaim PK_IMISRoleClaim 
   CONSTRAINT     b   ALTER TABLE ONLY public."IMISRoleClaim"
    ADD CONSTRAINT "PK_IMISRoleClaim" PRIMARY KEY ("Id");
 L   ALTER TABLE ONLY public."IMISRoleClaim" DROP CONSTRAINT "PK_IMISRoleClaim";
       public            postgres    false    385            �           2606    77523    IMISUserClaim PK_IMISUserClaim 
   CONSTRAINT     b   ALTER TABLE ONLY public."IMISUserClaim"
    ADD CONSTRAINT "PK_IMISUserClaim" PRIMARY KEY ("Id");
 L   ALTER TABLE ONLY public."IMISUserClaim" DROP CONSTRAINT "PK_IMISUserClaim";
       public            postgres    false    404            �           2606    77536    IMISUserLogin PK_IMISUserLogin 
   CONSTRAINT     |   ALTER TABLE ONLY public."IMISUserLogin"
    ADD CONSTRAINT "PK_IMISUserLogin" PRIMARY KEY ("LoginProvider", "ProviderKey");
 L   ALTER TABLE ONLY public."IMISUserLogin" DROP CONSTRAINT "PK_IMISUserLogin";
       public            postgres    false    405    405            �           2606    77549    IMISUserRole PK_IMISUserRole 
   CONSTRAINT     n   ALTER TABLE ONLY public."IMISUserRole"
    ADD CONSTRAINT "PK_IMISUserRole" PRIMARY KEY ("UserId", "RoleId");
 J   ALTER TABLE ONLY public."IMISUserRole" DROP CONSTRAINT "PK_IMISUserRole";
       public            postgres    false    406    406            �           2606    77567    IMISUserToken PK_IMISUserToken 
   CONSTRAINT        ALTER TABLE ONLY public."IMISUserToken"
    ADD CONSTRAINT "PK_IMISUserToken" PRIMARY KEY ("UserId", "LoginProvider", "Name");
 L   ALTER TABLE ONLY public."IMISUserToken" DROP CONSTRAINT "PK_IMISUserToken";
       public            postgres    false    407    407    407            c           2606    76437 (   INV_APPLICANT_RATE PK_INV_APPLICANT_RATE 
   CONSTRAINT     l   ALTER TABLE ONLY public."INV_APPLICANT_RATE"
    ADD CONSTRAINT "PK_INV_APPLICANT_RATE" PRIMARY KEY ("ID");
 V   ALTER TABLE ONLY public."INV_APPLICANT_RATE" DROP CONSTRAINT "PK_INV_APPLICANT_RATE";
       public            postgres    false    242            g           2606    76447    INV_DEPLIST PK_INV_DEPLIST 
   CONSTRAINT     ^   ALTER TABLE ONLY public."INV_DEPLIST"
    ADD CONSTRAINT "PK_INV_DEPLIST" PRIMARY KEY ("ID");
 H   ALTER TABLE ONLY public."INV_DEPLIST" DROP CONSTRAINT "PK_INV_DEPLIST";
       public            postgres    false    244            i           2606    76452 $   INV_DEPRECIATION PK_INV_DEPRECIATION 
   CONSTRAINT     h   ALTER TABLE ONLY public."INV_DEPRECIATION"
    ADD CONSTRAINT "PK_INV_DEPRECIATION" PRIMARY KEY ("ID");
 R   ALTER TABLE ONLY public."INV_DEPRECIATION" DROP CONSTRAINT "PK_INV_DEPRECIATION";
       public            postgres    false    245            ]           2606    78333 $   INV_GOODS_ADJUST PK_INV_GOODS_ADJUST 
   CONSTRAINT     h   ALTER TABLE ONLY public."INV_GOODS_ADJUST"
    ADD CONSTRAINT "PK_INV_GOODS_ADJUST" PRIMARY KEY ("ID");
 R   ALTER TABLE ONLY public."INV_GOODS_ADJUST" DROP CONSTRAINT "PK_INV_GOODS_ADJUST";
       public            postgres    false    452            �           2606    78813 (   INV_GOODS_REC_DETL PK_INV_GOODS_REC_DETL 
   CONSTRAINT     l   ALTER TABLE ONLY public."INV_GOODS_REC_DETL"
    ADD CONSTRAINT "PK_INV_GOODS_REC_DETL" PRIMARY KEY ("ID");
 V   ALTER TABLE ONLY public."INV_GOODS_REC_DETL" DROP CONSTRAINT "PK_INV_GOODS_REC_DETL";
       public            postgres    false    476            b           2606    78366 (   INV_GOODS_REC_MAST PK_INV_GOODS_REC_MAST 
   CONSTRAINT     l   ALTER TABLE ONLY public."INV_GOODS_REC_MAST"
    ADD CONSTRAINT "PK_INV_GOODS_REC_MAST" PRIMARY KEY ("ID");
 V   ALTER TABLE ONLY public."INV_GOODS_REC_MAST" DROP CONSTRAINT "PK_INV_GOODS_REC_MAST";
       public            postgres    false    453            m           2606    76462 .   INV_INCREASE_DECREASE PK_INV_INCREASE_DECREASE 
   CONSTRAINT     r   ALTER TABLE ONLY public."INV_INCREASE_DECREASE"
    ADD CONSTRAINT "PK_INV_INCREASE_DECREASE" PRIMARY KEY ("ID");
 \   ALTER TABLE ONLY public."INV_INCREASE_DECREASE" DROP CONSTRAINT "PK_INV_INCREASE_DECREASE";
       public            postgres    false    247            o           2606    76470 &   INV_ISSUE_DAKHILA PK_INV_ISSUE_DAKHILA 
   CONSTRAINT     j   ALTER TABLE ONLY public."INV_ISSUE_DAKHILA"
    ADD CONSTRAINT "PK_INV_ISSUE_DAKHILA" PRIMARY KEY ("ID");
 T   ALTER TABLE ONLY public."INV_ISSUE_DAKHILA" DROP CONSTRAINT "PK_INV_ISSUE_DAKHILA";
       public            postgres    false    248            �           2606    77925 $   INV_ISSUE_DETAIL PK_INV_ISSUE_DETAIL 
   CONSTRAINT     h   ALTER TABLE ONLY public."INV_ISSUE_DETAIL"
    ADD CONSTRAINT "PK_INV_ISSUE_DETAIL" PRIMARY KEY ("ID");
 R   ALTER TABLE ONLY public."INV_ISSUE_DETAIL" DROP CONSTRAINT "PK_INV_ISSUE_DETAIL";
       public            postgres    false    428            �           2606    78923 $   INV_ISSUE_MASTER PK_INV_ISSUE_MASTER 
   CONSTRAINT     h   ALTER TABLE ONLY public."INV_ISSUE_MASTER"
    ADD CONSTRAINT "PK_INV_ISSUE_MASTER" PRIMARY KEY ("ID");
 R   ALTER TABLE ONLY public."INV_ISSUE_MASTER" DROP CONSTRAINT "PK_INV_ISSUE_MASTER";
       public            postgres    false    479            q           2606    76475 &   INV_ITEM_ADJ_TYPE PK_INV_ITEM_ADJ_TYPE 
   CONSTRAINT     j   ALTER TABLE ONLY public."INV_ITEM_ADJ_TYPE"
    ADD CONSTRAINT "PK_INV_ITEM_ADJ_TYPE" PRIMARY KEY ("ID");
 T   ALTER TABLE ONLY public."INV_ITEM_ADJ_TYPE" DROP CONSTRAINT "PK_INV_ITEM_ADJ_TYPE";
       public            postgres    false    249            s           2606    76483 &   INV_ITEM_CATEGORY PK_INV_ITEM_CATEGORY 
   CONSTRAINT     j   ALTER TABLE ONLY public."INV_ITEM_CATEGORY"
    ADD CONSTRAINT "PK_INV_ITEM_CATEGORY" PRIMARY KEY ("ID");
 T   ALTER TABLE ONLY public."INV_ITEM_CATEGORY" DROP CONSTRAINT "PK_INV_ITEM_CATEGORY";
       public            postgres    false    250            j           2606    78386 ,   INV_ITEM_STATUSCHECK PK_INV_ITEM_STATUSCHECK 
   CONSTRAINT     p   ALTER TABLE ONLY public."INV_ITEM_STATUSCHECK"
    ADD CONSTRAINT "PK_INV_ITEM_STATUSCHECK" PRIMARY KEY ("ID");
 Z   ALTER TABLE ONLY public."INV_ITEM_STATUSCHECK" DROP CONSTRAINT "PK_INV_ITEM_STATUSCHECK";
       public            postgres    false    454            ]           2606    77329 *   INV_LILAMAPPDETAILS PK_INV_LILAMAPPDETAILS 
   CONSTRAINT     n   ALTER TABLE ONLY public."INV_LILAMAPPDETAILS"
    ADD CONSTRAINT "PK_INV_LILAMAPPDETAILS" PRIMARY KEY ("ID");
 X   ALTER TABLE ONLY public."INV_LILAMAPPDETAILS" DROP CONSTRAINT "PK_INV_LILAMAPPDETAILS";
       public            postgres    false    387            w           2606    76493 *   INV_LILAM_APPMASTER PK_INV_LILAM_APPMASTER 
   CONSTRAINT     n   ALTER TABLE ONLY public."INV_LILAM_APPMASTER"
    ADD CONSTRAINT "PK_INV_LILAM_APPMASTER" PRIMARY KEY ("ID");
 X   ALTER TABLE ONLY public."INV_LILAM_APPMASTER" DROP CONSTRAINT "PK_INV_LILAM_APPMASTER";
       public            postgres    false    252            y           2606    76501 $   INV_LILAM_DETAIL PK_INV_LILAM_DETAIL 
   CONSTRAINT     h   ALTER TABLE ONLY public."INV_LILAM_DETAIL"
    ADD CONSTRAINT "PK_INV_LILAM_DETAIL" PRIMARY KEY ("ID");
 R   ALTER TABLE ONLY public."INV_LILAM_DETAIL" DROP CONSTRAINT "PK_INV_LILAM_DETAIL";
       public            postgres    false    253            {           2606    76509     INV_LILAM_MAST PK_INV_LILAM_MAST 
   CONSTRAINT     d   ALTER TABLE ONLY public."INV_LILAM_MAST"
    ADD CONSTRAINT "PK_INV_LILAM_MAST" PRIMARY KEY ("ID");
 N   ALTER TABLE ONLY public."INV_LILAM_MAST" DROP CONSTRAINT "PK_INV_LILAM_MAST";
       public            postgres    false    254            }           2606    76517    INV_ORG_TYPE PK_INV_ORG_TYPE 
   CONSTRAINT     `   ALTER TABLE ONLY public."INV_ORG_TYPE"
    ADD CONSTRAINT "PK_INV_ORG_TYPE" PRIMARY KEY ("ID");
 J   ALTER TABLE ONLY public."INV_ORG_TYPE" DROP CONSTRAINT "PK_INV_ORG_TYPE";
       public            postgres    false    256            �           2606    76527 &   INV_PUR_MAST_PLAN PK_INV_PUR_MAST_PLAN 
   CONSTRAINT     j   ALTER TABLE ONLY public."INV_PUR_MAST_PLAN"
    ADD CONSTRAINT "PK_INV_PUR_MAST_PLAN" PRIMARY KEY ("ID");
 T   ALTER TABLE ONLY public."INV_PUR_MAST_PLAN" DROP CONSTRAINT "PK_INV_PUR_MAST_PLAN";
       public            postgres    false    258            �           2606    78888 (   INV_PUR_ORDER_DETL PK_INV_PUR_ORDER_DETL 
   CONSTRAINT     l   ALTER TABLE ONLY public."INV_PUR_ORDER_DETL"
    ADD CONSTRAINT "PK_INV_PUR_ORDER_DETL" PRIMARY KEY ("ID");
 V   ALTER TABLE ONLY public."INV_PUR_ORDER_DETL" DROP CONSTRAINT "PK_INV_PUR_ORDER_DETL";
       public            postgres    false    478            p           2606    78424 (   INV_PUR_ORDER_MAST PK_INV_PUR_ORDER_MAST 
   CONSTRAINT     l   ALTER TABLE ONLY public."INV_PUR_ORDER_MAST"
    ADD CONSTRAINT "PK_INV_PUR_ORDER_MAST" PRIMARY KEY ("ID");
 V   ALTER TABLE ONLY public."INV_PUR_ORDER_MAST" DROP CONSTRAINT "PK_INV_PUR_ORDER_MAST";
       public            postgres    false    455            x           2606    78452 ,   INV_REQUISITION_MAST PK_INV_REQUISITION_MAST 
   CONSTRAINT     p   ALTER TABLE ONLY public."INV_REQUISITION_MAST"
    ADD CONSTRAINT "PK_INV_REQUISITION_MAST" PRIMARY KEY ("ID");
 Z   ALTER TABLE ONLY public."INV_REQUISITION_MAST" DROP CONSTRAINT "PK_INV_REQUISITION_MAST";
       public            postgres    false    456            �           2606    78953     INV_REQ_DETAIL PK_INV_REQ_DETAIL 
   CONSTRAINT     d   ALTER TABLE ONLY public."INV_REQ_DETAIL"
    ADD CONSTRAINT "PK_INV_REQ_DETAIL" PRIMARY KEY ("ID");
 N   ALTER TABLE ONLY public."INV_REQ_DETAIL" DROP CONSTRAINT "PK_INV_REQ_DETAIL";
       public            postgres    false    480            }           2606    78487 &   INV_STATUS_DETAIL PK_INV_STATUS_DETAIL 
   CONSTRAINT     j   ALTER TABLE ONLY public."INV_STATUS_DETAIL"
    ADD CONSTRAINT "PK_INV_STATUS_DETAIL" PRIMARY KEY ("ID");
 T   ALTER TABLE ONLY public."INV_STATUS_DETAIL" DROP CONSTRAINT "PK_INV_STATUS_DETAIL";
       public            postgres    false    457            �           2606    76548 2   INV_SUPPLIER_FISCALYEAR PK_INV_SUPPLIER_FISCALYEAR 
   CONSTRAINT     v   ALTER TABLE ONLY public."INV_SUPPLIER_FISCALYEAR"
    ADD CONSTRAINT "PK_INV_SUPPLIER_FISCALYEAR" PRIMARY KEY ("ID");
 `   ALTER TABLE ONLY public."INV_SUPPLIER_FISCALYEAR" DROP CONSTRAINT "PK_INV_SUPPLIER_FISCALYEAR";
       public            postgres    false    262            �           2606    76535 "   INV_SUP_ITM_DET PK_INV_SUP_ITM_DET 
   CONSTRAINT     f   ALTER TABLE ONLY public."INV_SUP_ITM_DET"
    ADD CONSTRAINT "PK_INV_SUP_ITM_DET" PRIMARY KEY ("ID");
 P   ALTER TABLE ONLY public."INV_SUP_ITM_DET" DROP CONSTRAINT "PK_INV_SUP_ITM_DET";
       public            postgres    false    260            �           2606    76558     INV_TYPE_SETUP PK_INV_TYPE_SETUP 
   CONSTRAINT     d   ALTER TABLE ONLY public."INV_TYPE_SETUP"
    ADD CONSTRAINT "PK_INV_TYPE_SETUP" PRIMARY KEY ("ID");
 N   ALTER TABLE ONLY public."INV_TYPE_SETUP" DROP CONSTRAINT "PK_INV_TYPE_SETUP";
       public            postgres    false    264            �           2606    76573 &   INV_YRLY_PUR_PLAN PK_INV_YRLY_PUR_PLAN 
   CONSTRAINT     j   ALTER TABLE ONLY public."INV_YRLY_PUR_PLAN"
    ADD CONSTRAINT "PK_INV_YRLY_PUR_PLAN" PRIMARY KEY ("ID");
 T   ALTER TABLE ONLY public."INV_YRLY_PUR_PLAN" DROP CONSTRAINT "PK_INV_YRLY_PUR_PLAN";
       public            postgres    false    267            �           2606    76599    MALPOT_LANDS PK_MALPOT_LANDS 
   CONSTRAINT     `   ALTER TABLE ONLY public."MALPOT_LANDS"
    ADD CONSTRAINT "PK_MALPOT_LANDS" PRIMARY KEY ("ID");
 J   ALTER TABLE ONLY public."MALPOT_LANDS" DROP CONSTRAINT "PK_MALPOT_LANDS";
       public            postgres    false    273            c           2606    77352 $   MAP_AREA_GND_COV PK_MAP_AREA_GND_COV 
   CONSTRAINT     h   ALTER TABLE ONLY public."MAP_AREA_GND_COV"
    ADD CONSTRAINT "PK_MAP_AREA_GND_COV" PRIMARY KEY ("ID");
 R   ALTER TABLE ONLY public."MAP_AREA_GND_COV" DROP CONSTRAINT "PK_MAP_AREA_GND_COV";
       public            postgres    false    389            �           2606    76604 ,   MAP_CONSTRCTION_KIND PK_MAP_CONSTRCTION_KIND 
   CONSTRAINT     p   ALTER TABLE ONLY public."MAP_CONSTRCTION_KIND"
    ADD CONSTRAINT "PK_MAP_CONSTRCTION_KIND" PRIMARY KEY ("ID");
 Z   ALTER TABLE ONLY public."MAP_CONSTRCTION_KIND" DROP CONSTRAINT "PK_MAP_CONSTRCTION_KIND";
       public            postgres    false    274            �           2606    76612 $   MAP_DESIGNER_DTL PK_MAP_DESIGNER_DTL 
   CONSTRAINT     h   ALTER TABLE ONLY public."MAP_DESIGNER_DTL"
    ADD CONSTRAINT "PK_MAP_DESIGNER_DTL" PRIMARY KEY ("ID");
 R   ALTER TABLE ONLY public."MAP_DESIGNER_DTL" DROP CONSTRAINT "PK_MAP_DESIGNER_DTL";
       public            postgres    false    275            �           2606    76617    MAP_DIRECTION PK_MAP_DIRECTION 
   CONSTRAINT     b   ALTER TABLE ONLY public."MAP_DIRECTION"
    ADD CONSTRAINT "PK_MAP_DIRECTION" PRIMARY KEY ("ID");
 L   ALTER TABLE ONLY public."MAP_DIRECTION" DROP CONSTRAINT "PK_MAP_DIRECTION";
       public            postgres    false    276            �           2606    76622     MAP_DRAIN_TYPE PK_MAP_DRAIN_TYPE 
   CONSTRAINT     d   ALTER TABLE ONLY public."MAP_DRAIN_TYPE"
    ADD CONSTRAINT "PK_MAP_DRAIN_TYPE" PRIMARY KEY ("ID");
 N   ALTER TABLE ONLY public."MAP_DRAIN_TYPE" DROP CONSTRAINT "PK_MAP_DRAIN_TYPE";
       public            postgres    false    277            �           2606    76627    MAP_FLOOR PK_MAP_FLOOR 
   CONSTRAINT     Z   ALTER TABLE ONLY public."MAP_FLOOR"
    ADD CONSTRAINT "PK_MAP_FLOOR" PRIMARY KEY ("ID");
 D   ALTER TABLE ONLY public."MAP_FLOOR" DROP CONSTRAINT "PK_MAP_FLOOR";
       public            postgres    false    278            �           2606    76632 &   MAP_HOUSEUSE_TYPE PK_MAP_HOUSEUSE_TYPE 
   CONSTRAINT     j   ALTER TABLE ONLY public."MAP_HOUSEUSE_TYPE"
    ADD CONSTRAINT "PK_MAP_HOUSEUSE_TYPE" PRIMARY KEY ("ID");
 T   ALTER TABLE ONLY public."MAP_HOUSEUSE_TYPE" DROP CONSTRAINT "PK_MAP_HOUSEUSE_TYPE";
       public            postgres    false    279            �           2606    77662 "   MAP_INCOME_TYPE PK_MAP_INCOME_TYPE 
   CONSTRAINT     f   ALTER TABLE ONLY public."MAP_INCOME_TYPE"
    ADD CONSTRAINT "PK_MAP_INCOME_TYPE" PRIMARY KEY ("ID");
 P   ALTER TABLE ONLY public."MAP_INCOME_TYPE" DROP CONSTRAINT "PK_MAP_INCOME_TYPE";
       public            postgres    false    413            �           2606    76642 *   MAP_LAND_OWNER_TYPE PK_MAP_LAND_OWNER_TYPE 
   CONSTRAINT     n   ALTER TABLE ONLY public."MAP_LAND_OWNER_TYPE"
    ADD CONSTRAINT "PK_MAP_LAND_OWNER_TYPE" PRIMARY KEY ("ID");
 X   ALTER TABLE ONLY public."MAP_LAND_OWNER_TYPE" DROP CONSTRAINT "PK_MAP_LAND_OWNER_TYPE";
       public            postgres    false    281            �           2606    76647 (   MAP_NEIGHBOUR_TYPE PK_MAP_NEIGHBOUR_TYPE 
   CONSTRAINT     l   ALTER TABLE ONLY public."MAP_NEIGHBOUR_TYPE"
    ADD CONSTRAINT "PK_MAP_NEIGHBOUR_TYPE" PRIMARY KEY ("ID");
 V   ALTER TABLE ONLY public."MAP_NEIGHBOUR_TYPE" DROP CONSTRAINT "PK_MAP_NEIGHBOUR_TYPE";
       public            postgres    false    282            �           2606    76652    MAP_RATE PK_MAP_RATE 
   CONSTRAINT     X   ALTER TABLE ONLY public."MAP_RATE"
    ADD CONSTRAINT "PK_MAP_RATE" PRIMARY KEY ("ID");
 B   ALTER TABLE ONLY public."MAP_RATE" DROP CONSTRAINT "PK_MAP_RATE";
       public            postgres    false    283            f           2606    77362     MAP_REGION_FAR PK_MAP_REGION_FAR 
   CONSTRAINT     d   ALTER TABLE ONLY public."MAP_REGION_FAR"
    ADD CONSTRAINT "PK_MAP_REGION_FAR" PRIMARY KEY ("ID");
 N   ALTER TABLE ONLY public."MAP_REGION_FAR" DROP CONSTRAINT "PK_MAP_REGION_FAR";
       public            postgres    false    390            �           2606    76657 .   MAP_ROOF_CNSTRCT_TYPE PK_MAP_ROOF_CNSTRCT_TYPE 
   CONSTRAINT     r   ALTER TABLE ONLY public."MAP_ROOF_CNSTRCT_TYPE"
    ADD CONSTRAINT "PK_MAP_ROOF_CNSTRCT_TYPE" PRIMARY KEY ("ID");
 \   ALTER TABLE ONLY public."MAP_ROOF_CNSTRCT_TYPE" DROP CONSTRAINT "PK_MAP_ROOF_CNSTRCT_TYPE";
       public            postgres    false    284            �           2606    76662    MAP_ROOF_TYPE PK_MAP_ROOF_TYPE 
   CONSTRAINT     b   ALTER TABLE ONLY public."MAP_ROOF_TYPE"
    ADD CONSTRAINT "PK_MAP_ROOF_TYPE" PRIMARY KEY ("ID");
 L   ALTER TABLE ONLY public."MAP_ROOF_TYPE" DROP CONSTRAINT "PK_MAP_ROOF_TYPE";
       public            postgres    false    285            �           2606    76672 $   MAP_STDHEIGHT_RW PK_MAP_STDHEIGHT_RW 
   CONSTRAINT     h   ALTER TABLE ONLY public."MAP_STDHEIGHT_RW"
    ADD CONSTRAINT "PK_MAP_STDHEIGHT_RW" PRIMARY KEY ("ID");
 R   ALTER TABLE ONLY public."MAP_STDHEIGHT_RW" DROP CONSTRAINT "PK_MAP_STDHEIGHT_RW";
       public            postgres    false    287            �           2606    76677    MAP_STOREYS PK_MAP_STOREYS 
   CONSTRAINT     ^   ALTER TABLE ONLY public."MAP_STOREYS"
    ADD CONSTRAINT "PK_MAP_STOREYS" PRIMARY KEY ("ID");
 H   ALTER TABLE ONLY public."MAP_STOREYS" DROP CONSTRAINT "PK_MAP_STOREYS";
       public            postgres    false    288            �           2606    76682 (   MAP_STRUCTURE_TYPE PK_MAP_STRUCTURE_TYPE 
   CONSTRAINT     l   ALTER TABLE ONLY public."MAP_STRUCTURE_TYPE"
    ADD CONSTRAINT "PK_MAP_STRUCTURE_TYPE" PRIMARY KEY ("ID");
 V   ALTER TABLE ONLY public."MAP_STRUCTURE_TYPE" DROP CONSTRAINT "PK_MAP_STRUCTURE_TYPE";
       public            postgres    false    289            �           2606    76687    MAP_ZONE PK_MAP_ZONE 
   CONSTRAINT     X   ALTER TABLE ONLY public."MAP_ZONE"
    ADD CONSTRAINT "PK_MAP_ZONE" PRIMARY KEY ("ID");
 B   ALTER TABLE ONLY public."MAP_ZONE" DROP CONSTRAINT "PK_MAP_ZONE";
       public            postgres    false    290            �           2606    76698 &   MINISTRY_ACC_HEAD PK_MINISTRY_ACC_HEAD 
   CONSTRAINT     j   ALTER TABLE ONLY public."MINISTRY_ACC_HEAD"
    ADD CONSTRAINT "PK_MINISTRY_ACC_HEAD" PRIMARY KEY ("ID");
 T   ALTER TABLE ONLY public."MINISTRY_ACC_HEAD" DROP CONSTRAINT "PK_MINISTRY_ACC_HEAD";
       public            postgres    false    292            �           2606    76711    OFFICE_TYPE PK_OFFICE_TYPE 
   CONSTRAINT     j   ALTER TABLE ONLY public."OFFICE_TYPE"
    ADD CONSTRAINT "PK_OFFICE_TYPE" PRIMARY KEY ("OFFICE_TYPE_ID");
 H   ALTER TABLE ONLY public."OFFICE_TYPE" DROP CONSTRAINT "PK_OFFICE_TYPE";
       public            postgres    false    295            x           2606    77430 &   ORGANIZATION_TREE PK_ORGANIZATION_TREE 
   CONSTRAINT     j   ALTER TABLE ONLY public."ORGANIZATION_TREE"
    ADD CONSTRAINT "PK_ORGANIZATION_TREE" PRIMARY KEY ("ID");
 T   ALTER TABLE ONLY public."ORGANIZATION_TREE" DROP CONSTRAINT "PK_ORGANIZATION_TREE";
       public            postgres    false    395            �           2606    77905 $   ORG_BANK_ACCOUNT PK_ORG_BANK_ACCOUNT 
   CONSTRAINT     h   ALTER TABLE ONLY public."ORG_BANK_ACCOUNT"
    ADD CONSTRAINT "PK_ORG_BANK_ACCOUNT" PRIMARY KEY ("ID");
 R   ALTER TABLE ONLY public."ORG_BANK_ACCOUNT" DROP CONSTRAINT "PK_ORG_BANK_ACCOUNT";
       public            postgres    false    427            �           2606    76729 ,   PIS_APPOINTMENT_TYPE PK_PIS_APPOINTMENT_TYPE 
   CONSTRAINT     p   ALTER TABLE ONLY public."PIS_APPOINTMENT_TYPE"
    ADD CONSTRAINT "PK_PIS_APPOINTMENT_TYPE" PRIMARY KEY ("ID");
 Z   ALTER TABLE ONLY public."PIS_APPOINTMENT_TYPE" DROP CONSTRAINT "PK_PIS_APPOINTMENT_TYPE";
       public            postgres    false    298            �           2606    76734     PIS_ATTRIBUTES PK_PIS_ATTRIBUTES 
   CONSTRAINT     d   ALTER TABLE ONLY public."PIS_ATTRIBUTES"
    ADD CONSTRAINT "PK_PIS_ATTRIBUTES" PRIMARY KEY ("ID");
 N   ALTER TABLE ONLY public."PIS_ATTRIBUTES" DROP CONSTRAINT "PK_PIS_ATTRIBUTES";
       public            postgres    false    299            �           2606    76739    PIS_EDU_BOARD PK_PIS_EDU_BOARD 
   CONSTRAINT     b   ALTER TABLE ONLY public."PIS_EDU_BOARD"
    ADD CONSTRAINT "PK_PIS_EDU_BOARD" PRIMARY KEY ("ID");
 L   ALTER TABLE ONLY public."PIS_EDU_BOARD" DROP CONSTRAINT "PK_PIS_EDU_BOARD";
       public            postgres    false    300            �           2606    78522 *   PIS_EMP_ADV_DED_DTL PK_PIS_EMP_ADV_DED_DTL 
   CONSTRAINT     n   ALTER TABLE ONLY public."PIS_EMP_ADV_DED_DTL"
    ADD CONSTRAINT "PK_PIS_EMP_ADV_DED_DTL" PRIMARY KEY ("ID");
 X   ALTER TABLE ONLY public."PIS_EMP_ADV_DED_DTL" DROP CONSTRAINT "PK_PIS_EMP_ADV_DED_DTL";
       public            postgres    false    459            �           2606    76749    PIS_EMP_BARGA PK_PIS_EMP_BARGA 
   CONSTRAINT     b   ALTER TABLE ONLY public."PIS_EMP_BARGA"
    ADD CONSTRAINT "PK_PIS_EMP_BARGA" PRIMARY KEY ("ID");
 L   ALTER TABLE ONLY public."PIS_EMP_BARGA" DROP CONSTRAINT "PK_PIS_EMP_BARGA";
       public            postgres    false    302            �           2606    76762 0   PIS_EMP_INSURANCE_PAID PK_PIS_EMP_INSURANCE_PAID 
   CONSTRAINT     t   ALTER TABLE ONLY public."PIS_EMP_INSURANCE_PAID"
    ADD CONSTRAINT "PK_PIS_EMP_INSURANCE_PAID" PRIMARY KEY ("ID");
 ^   ALTER TABLE ONLY public."PIS_EMP_INSURANCE_PAID" DROP CONSTRAINT "PK_PIS_EMP_INSURANCE_PAID";
       public            postgres    false    304            �           2606    76770     PIS_GEO_REGION PK_PIS_GEO_REGION 
   CONSTRAINT     d   ALTER TABLE ONLY public."PIS_GEO_REGION"
    ADD CONSTRAINT "PK_PIS_GEO_REGION" PRIMARY KEY ("ID");
 N   ALTER TABLE ONLY public."PIS_GEO_REGION" DROP CONSTRAINT "PK_PIS_GEO_REGION";
       public            postgres    false    305            �           2606    76804 4   PIS_NIJAMATI_SEWA_SAMUHA PK_PIS_NIJAMATI_SEWA_SAMUHA 
   CONSTRAINT     x   ALTER TABLE ONLY public."PIS_NIJAMATI_SEWA_SAMUHA"
    ADD CONSTRAINT "PK_PIS_NIJAMATI_SEWA_SAMUHA" PRIMARY KEY ("ID");
 b   ALTER TABLE ONLY public."PIS_NIJAMATI_SEWA_SAMUHA" DROP CONSTRAINT "PK_PIS_NIJAMATI_SEWA_SAMUHA";
       public            postgres    false    310                       2606    78023 &   PIS_OTHER_ADD_SUB PK_PIS_OTHER_ADD_SUB 
   CONSTRAINT     j   ALTER TABLE ONLY public."PIS_OTHER_ADD_SUB"
    ADD CONSTRAINT "PK_PIS_OTHER_ADD_SUB" PRIMARY KEY ("ID");
 T   ALTER TABLE ONLY public."PIS_OTHER_ADD_SUB" DROP CONSTRAINT "PK_PIS_OTHER_ADD_SUB";
       public            postgres    false    433            �           2606    76819    PIS_PAYROLLS PK_PIS_PAYROLLS 
   CONSTRAINT     `   ALTER TABLE ONLY public."PIS_PAYROLLS"
    ADD CONSTRAINT "PK_PIS_PAYROLLS" PRIMARY KEY ("ID");
 J   ALTER TABLE ONLY public."PIS_PAYROLLS" DROP CONSTRAINT "PK_PIS_PAYROLLS";
       public            postgres    false    312            �           2606    78978 ,   PIS_PYROLL_LOAN_DTLS PK_PIS_PYROLL_LOAN_DTLS 
   CONSTRAINT     p   ALTER TABLE ONLY public."PIS_PYROLL_LOAN_DTLS"
    ADD CONSTRAINT "PK_PIS_PYROLL_LOAN_DTLS" PRIMARY KEY ("ID");
 Z   ALTER TABLE ONLY public."PIS_PYROLL_LOAN_DTLS" DROP CONSTRAINT "PK_PIS_PYROLL_LOAN_DTLS";
       public            postgres    false    481            �           2606    78672 ,   PIS_PYROLL_OTHR_DTLS PK_PIS_PYROLL_OTHR_DTLS 
   CONSTRAINT     p   ALTER TABLE ONLY public."PIS_PYROLL_OTHR_DTLS"
    ADD CONSTRAINT "PK_PIS_PYROLL_OTHR_DTLS" PRIMARY KEY ("ID");
 Z   ALTER TABLE ONLY public."PIS_PYROLL_OTHR_DTLS" DROP CONSTRAINT "PK_PIS_PYROLL_OTHR_DTLS";
       public            postgres    false    468            �           2606    76850 (   PIS_SERVICE_STATUS PK_PIS_SERVICE_STATUS 
   CONSTRAINT     l   ALTER TABLE ONLY public."PIS_SERVICE_STATUS"
    ADD CONSTRAINT "PK_PIS_SERVICE_STATUS" PRIMARY KEY ("ID");
 V   ALTER TABLE ONLY public."PIS_SERVICE_STATUS" DROP CONSTRAINT "PK_PIS_SERVICE_STATUS";
       public            postgres    false    317            �           2606    76860    PMS_YOJTYPE PK_PMS_YOJTYPE 
   CONSTRAINT     ^   ALTER TABLE ONLY public."PMS_YOJTYPE"
    ADD CONSTRAINT "PK_PMS_YOJTYPE" PRIMARY KEY ("ID");
 H   ALTER TABLE ONLY public."PMS_YOJTYPE" DROP CONSTRAINT "PK_PMS_YOJTYPE";
       public            postgres    false    319            �           2606    76865    RENT_DAR_RATE PK_RENT_DAR_RATE 
   CONSTRAINT     b   ALTER TABLE ONLY public."RENT_DAR_RATE"
    ADD CONSTRAINT "PK_RENT_DAR_RATE" PRIMARY KEY ("ID");
 L   ALTER TABLE ONLY public."RENT_DAR_RATE" DROP CONSTRAINT "PK_RENT_DAR_RATE";
       public            postgres    false    320            �           2606    76879 $   SANITATION_GROUP PK_SANITATION_GROUP 
   CONSTRAINT     h   ALTER TABLE ONLY public."SANITATION_GROUP"
    ADD CONSTRAINT "PK_SANITATION_GROUP" PRIMARY KEY ("ID");
 R   ALTER TABLE ONLY public."SANITATION_GROUP" DROP CONSTRAINT "PK_SANITATION_GROUP";
       public            postgres    false    323                       2606    78086 "   SANITATION_RATE PK_SANITATION_RATE 
   CONSTRAINT     f   ALTER TABLE ONLY public."SANITATION_RATE"
    ADD CONSTRAINT "PK_SANITATION_RATE" PRIMARY KEY ("ID");
 P   ALTER TABLE ONLY public."SANITATION_RATE" DROP CONSTRAINT "PK_SANITATION_RATE";
       public            postgres    false    439            ~           2606    77458 *   SANITATION_SUBGROUP PK_SANITATION_SUBGROUP 
   CONSTRAINT     n   ALTER TABLE ONLY public."SANITATION_SUBGROUP"
    ADD CONSTRAINT "PK_SANITATION_SUBGROUP" PRIMARY KEY ("ID");
 X   ALTER TABLE ONLY public."SANITATION_SUBGROUP" DROP CONSTRAINT "PK_SANITATION_SUBGROUP";
       public            postgres    false    397            �           2606    77672 .   SERVICE_CHARGE_MASTER PK_SERVICE_CHARGE_MASTER 
   CONSTRAINT     r   ALTER TABLE ONLY public."SERVICE_CHARGE_MASTER"
    ADD CONSTRAINT "PK_SERVICE_CHARGE_MASTER" PRIMARY KEY ("ID");
 \   ALTER TABLE ONLY public."SERVICE_CHARGE_MASTER" DROP CONSTRAINT "PK_SERVICE_CHARGE_MASTER";
       public            postgres    false    414            �           2606    76890    SUBJECT_AREA PK_SUBJECT_AREA 
   CONSTRAINT     `   ALTER TABLE ONLY public."SUBJECT_AREA"
    ADD CONSTRAINT "PK_SUBJECT_AREA" PRIMARY KEY ("ID");
 J   ALTER TABLE ONLY public."SUBJECT_AREA" DROP CONSTRAINT "PK_SUBJECT_AREA";
       public            postgres    false    325            �           2606    76898 &   SV_BUSINESSMASTER PK_SV_BUSINESSMASTER 
   CONSTRAINT     j   ALTER TABLE ONLY public."SV_BUSINESSMASTER"
    ADD CONSTRAINT "PK_SV_BUSINESSMASTER" PRIMARY KEY ("ID");
 T   ALTER TABLE ONLY public."SV_BUSINESSMASTER" DROP CONSTRAINT "PK_SV_BUSINESSMASTER";
       public            postgres    false    326            �           2606    76903 $   SV_CONSTRUCTIONS PK_SV_CONSTRUCTIONS 
   CONSTRAINT     h   ALTER TABLE ONLY public."SV_CONSTRUCTIONS"
    ADD CONSTRAINT "PK_SV_CONSTRUCTIONS" PRIMARY KEY ("ID");
 R   ALTER TABLE ONLY public."SV_CONSTRUCTIONS" DROP CONSTRAINT "PK_SV_CONSTRUCTIONS";
       public            postgres    false    327            �           2606    76911    SV_HOUSES PK_SV_HOUSES 
   CONSTRAINT     Z   ALTER TABLE ONLY public."SV_HOUSES"
    ADD CONSTRAINT "PK_SV_HOUSES" PRIMARY KEY ("ID");
 D   ALTER TABLE ONLY public."SV_HOUSES" DROP CONSTRAINT "PK_SV_HOUSES";
       public            postgres    false    328            �           2606    76919    SV_LANDS PK_SV_LANDS 
   CONSTRAINT     X   ALTER TABLE ONLY public."SV_LANDS"
    ADD CONSTRAINT "PK_SV_LANDS" PRIMARY KEY ("ID");
 B   ALTER TABLE ONLY public."SV_LANDS" DROP CONSTRAINT "PK_SV_LANDS";
       public            postgres    false    329                        2606    76958 $   TAX_RATE_CEILING PK_TAX_RATE_CEILING 
   CONSTRAINT     h   ALTER TABLE ONLY public."TAX_RATE_CEILING"
    ADD CONSTRAINT "PK_TAX_RATE_CEILING" PRIMARY KEY ("ID");
 R   ALTER TABLE ONLY public."TAX_RATE_CEILING" DROP CONSTRAINT "PK_TAX_RATE_CEILING";
       public            postgres    false    336            )           2606    78126 ,   TAX_THLI_ISSUED_CNTR PK_TAX_THLI_ISSUED_CNTR 
   CONSTRAINT     p   ALTER TABLE ONLY public."TAX_THLI_ISSUED_CNTR"
    ADD CONSTRAINT "PK_TAX_THLI_ISSUED_CNTR" PRIMARY KEY ("ID");
 Z   ALTER TABLE ONLY public."TAX_THLI_ISSUED_CNTR" DROP CONSTRAINT "PK_TAX_THLI_ISSUED_CNTR";
       public            postgres    false    442            &           2606    77107    TBLBILLTYPE PK_TBLBILLTYPE 
   CONSTRAINT     ^   ALTER TABLE ONLY public."TBLBILLTYPE"
    ADD CONSTRAINT "PK_TBLBILLTYPE" PRIMARY KEY ("ID");
 H   ALTER TABLE ONLY public."TBLBILLTYPE" DROP CONSTRAINT "PK_TBLBILLTYPE";
       public            postgres    false    360            �           2606    77717 8   TBLBUSINESS_SERVICE_CH_MST PK_TBLBUSINESS_SERVICE_CH_MST 
   CONSTRAINT     |   ALTER TABLE ONLY public."TBLBUSINESS_SERVICE_CH_MST"
    ADD CONSTRAINT "PK_TBLBUSINESS_SERVICE_CH_MST" PRIMARY KEY ("ID");
 f   ALTER TABLE ONLY public."TBLBUSINESS_SERVICE_CH_MST" DROP CONSTRAINT "PK_TBLBUSINESS_SERVICE_CH_MST";
       public            postgres    false    418            �           2606    78732 ,   TBLFYWISEMPOTASSRATE PK_TBLFYWISEMPOTASSRATE 
   CONSTRAINT     p   ALTER TABLE ONLY public."TBLFYWISEMPOTASSRATE"
    ADD CONSTRAINT "PK_TBLFYWISEMPOTASSRATE" PRIMARY KEY ("ID");
 Z   ALTER TABLE ONLY public."TBLFYWISEMPOTASSRATE" DROP CONSTRAINT "PK_TBLFYWISEMPOTASSRATE";
       public            postgres    false    472            *           2606    77123 &   TBLLAND_TYPE_AREA PK_TBLLAND_TYPE_AREA 
   CONSTRAINT     j   ALTER TABLE ONLY public."TBLLAND_TYPE_AREA"
    ADD CONSTRAINT "PK_TBLLAND_TYPE_AREA" PRIMARY KEY ("ID");
 T   ALTER TABLE ONLY public."TBLLAND_TYPE_AREA" DROP CONSTRAINT "PK_TBLLAND_TYPE_AREA";
       public            postgres    false    364            ,           2606    77128     TBLMALPOTGROUP PK_TBLMALPOTGROUP 
   CONSTRAINT     d   ALTER TABLE ONLY public."TBLMALPOTGROUP"
    ADD CONSTRAINT "PK_TBLMALPOTGROUP" PRIMARY KEY ("ID");
 N   ALTER TABLE ONLY public."TBLMALPOTGROUP" DROP CONSTRAINT "PK_TBLMALPOTGROUP";
       public            postgres    false    365            -           2606    78141     TBLMALPOTRATES PK_TBLMALPOTRATES 
   CONSTRAINT     d   ALTER TABLE ONLY public."TBLMALPOTRATES"
    ADD CONSTRAINT "PK_TBLMALPOTRATES" PRIMARY KEY ("ID");
 N   ALTER TABLE ONLY public."TBLMALPOTRATES" DROP CONSTRAINT "PK_TBLMALPOTRATES";
       public            postgres    false    443            �           2606    77508 &   TBLMALPOTSUBGROUP PK_TBLMALPOTSUBGROUP 
   CONSTRAINT     j   ALTER TABLE ONLY public."TBLMALPOTSUBGROUP"
    ADD CONSTRAINT "PK_TBLMALPOTSUBGROUP" PRIMARY KEY ("ID");
 T   ALTER TABLE ONLY public."TBLMALPOTSUBGROUP" DROP CONSTRAINT "PK_TBLMALPOTSUBGROUP";
       public            postgres    false    402            �           2606    77727 (   TBLVEH_SER_CH_MSTR PK_TBLVEH_SER_CH_MSTR 
   CONSTRAINT     l   ALTER TABLE ONLY public."TBLVEH_SER_CH_MSTR"
    ADD CONSTRAINT "PK_TBLVEH_SER_CH_MSTR" PRIMARY KEY ("ID");
 V   ALTER TABLE ONLY public."TBLVEH_SER_CH_MSTR" DROP CONSTRAINT "PK_TBLVEH_SER_CH_MSTR";
       public            postgres    false    419                       2606    76984 *   TBL_BANK_ACCNT_TYPE PK_TBL_BANK_ACCNT_TYPE 
   CONSTRAINT     n   ALTER TABLE ONLY public."TBL_BANK_ACCNT_TYPE"
    ADD CONSTRAINT "PK_TBL_BANK_ACCNT_TYPE" PRIMARY KEY ("ID");
 X   ALTER TABLE ONLY public."TBL_BANK_ACCNT_TYPE" DROP CONSTRAINT "PK_TBL_BANK_ACCNT_TYPE";
       public            postgres    false    341                       2606    76992 :   TBL_BANK_FINANCE_INSTITUTUE PK_TBL_BANK_FINANCE_INSTITUTUE 
   CONSTRAINT     ~   ALTER TABLE ONLY public."TBL_BANK_FINANCE_INSTITUTUE"
    ADD CONSTRAINT "PK_TBL_BANK_FINANCE_INSTITUTUE" PRIMARY KEY ("ID");
 h   ALTER TABLE ONLY public."TBL_BANK_FINANCE_INSTITUTUE" DROP CONSTRAINT "PK_TBL_BANK_FINANCE_INSTITUTUE";
       public            postgres    false    342                       2606    76997    TBL_BGT_MGMT PK_TBL_BGT_MGMT 
   CONSTRAINT     `   ALTER TABLE ONLY public."TBL_BGT_MGMT"
    ADD CONSTRAINT "PK_TBL_BGT_MGMT" PRIMARY KEY ("ID");
 J   ALTER TABLE ONLY public."TBL_BGT_MGMT" DROP CONSTRAINT "PK_TBL_BGT_MGMT";
       public            postgres    false    343            �           2606    77468 $   TBL_BGT_MGMT_EXP PK_TBL_BGT_MGMT_EXP 
   CONSTRAINT     h   ALTER TABLE ONLY public."TBL_BGT_MGMT_EXP"
    ADD CONSTRAINT "PK_TBL_BGT_MGMT_EXP" PRIMARY KEY ("ID");
 R   ALTER TABLE ONLY public."TBL_BGT_MGMT_EXP" DROP CONSTRAINT "PK_TBL_BGT_MGMT_EXP";
       public            postgres    false    398            �           2606    77478 ,   TBL_BGT_MGMT_EXP_ORG PK_TBL_BGT_MGMT_EXP_ORG 
   CONSTRAINT     p   ALTER TABLE ONLY public."TBL_BGT_MGMT_EXP_ORG"
    ADD CONSTRAINT "PK_TBL_BGT_MGMT_EXP_ORG" PRIMARY KEY ("ID");
 Z   ALTER TABLE ONLY public."TBL_BGT_MGMT_EXP_ORG" DROP CONSTRAINT "PK_TBL_BGT_MGMT_EXP_ORG";
       public            postgres    false    399            0           2606    78156 4   TBL_BGT_MGMT_EXP_RELEASE PK_TBL_BGT_MGMT_EXP_RELEASE 
   CONSTRAINT     x   ALTER TABLE ONLY public."TBL_BGT_MGMT_EXP_RELEASE"
    ADD CONSTRAINT "PK_TBL_BGT_MGMT_EXP_RELEASE" PRIMARY KEY ("ID");
 b   ALTER TABLE ONLY public."TBL_BGT_MGMT_EXP_RELEASE" DROP CONSTRAINT "PK_TBL_BGT_MGMT_EXP_RELEASE";
       public            postgres    false    444                       2606    77002 $   TBL_BGT_MGMT_ORG PK_TBL_BGT_MGMT_ORG 
   CONSTRAINT     h   ALTER TABLE ONLY public."TBL_BGT_MGMT_ORG"
    ADD CONSTRAINT "PK_TBL_BGT_MGMT_ORG" PRIMARY KEY ("ID");
 R   ALTER TABLE ONLY public."TBL_BGT_MGMT_ORG" DROP CONSTRAINT "PK_TBL_BGT_MGMT_ORG";
       public            postgres    false    344            �           2606    77577 ,   TBL_BGT_MGMT_RELEASE PK_TBL_BGT_MGMT_RELEASE 
   CONSTRAINT     p   ALTER TABLE ONLY public."TBL_BGT_MGMT_RELEASE"
    ADD CONSTRAINT "PK_TBL_BGT_MGMT_RELEASE" PRIMARY KEY ("ID");
 Z   ALTER TABLE ONLY public."TBL_BGT_MGMT_RELEASE" DROP CONSTRAINT "PK_TBL_BGT_MGMT_RELEASE";
       public            postgres    false    408            !           2606    78101 $   TBL_BGT_MGMT_SRC PK_TBL_BGT_MGMT_SRC 
   CONSTRAINT     h   ALTER TABLE ONLY public."TBL_BGT_MGMT_SRC"
    ADD CONSTRAINT "PK_TBL_BGT_MGMT_SRC" PRIMARY KEY ("ID");
 R   ALTER TABLE ONLY public."TBL_BGT_MGMT_SRC" DROP CONSTRAINT "PK_TBL_BGT_MGMT_SRC";
       public            postgres    false    440            %           2606    78111 ,   TBL_BGT_MGMT_SRC_ORG PK_TBL_BGT_MGMT_SRC_ORG 
   CONSTRAINT     p   ALTER TABLE ONLY public."TBL_BGT_MGMT_SRC_ORG"
    ADD CONSTRAINT "PK_TBL_BGT_MGMT_SRC_ORG" PRIMARY KEY ("ID");
 Z   ALTER TABLE ONLY public."TBL_BGT_MGMT_SRC_ORG" DROP CONSTRAINT "PK_TBL_BGT_MGMT_SRC_ORG";
       public            postgres    false    441            �           2606    78752 4   TBL_BGT_MGMT_SRC_RELEASE PK_TBL_BGT_MGMT_SRC_RELEASE 
   CONSTRAINT     x   ALTER TABLE ONLY public."TBL_BGT_MGMT_SRC_RELEASE"
    ADD CONSTRAINT "PK_TBL_BGT_MGMT_SRC_RELEASE" PRIMARY KEY ("ID");
 b   ALTER TABLE ONLY public."TBL_BGT_MGMT_SRC_RELEASE" DROP CONSTRAINT "PK_TBL_BGT_MGMT_SRC_RELEASE";
       public            postgres    false    473            ;           2606    77192 "   TBL_BGT_RELEASE PK_TBL_BGT_RELEASE 
   CONSTRAINT     f   ALTER TABLE ONLY public."TBL_BGT_RELEASE"
    ADD CONSTRAINT "PK_TBL_BGT_RELEASE" PRIMARY KEY ("ID");
 P   ALTER TABLE ONLY public."TBL_BGT_RELEASE" DROP CONSTRAINT "PK_TBL_BGT_RELEASE";
       public            postgres    false    376            �           2606    77697 @   TBL_CONSTRUCTION_OTHER_CHARGES PK_TBL_CONSTRUCTION_OTHER_CHARGES 
   CONSTRAINT     �   ALTER TABLE ONLY public."TBL_CONSTRUCTION_OTHER_CHARGES"
    ADD CONSTRAINT "PK_TBL_CONSTRUCTION_OTHER_CHARGES" PRIMARY KEY ("ID");
 n   ALTER TABLE ONLY public."TBL_CONSTRUCTION_OTHER_CHARGES" DROP CONSTRAINT "PK_TBL_CONSTRUCTION_OTHER_CHARGES";
       public            postgres    false    416            
           2606    77010 $   TBL_DATA_HISTORY PK_TBL_DATA_HISTORY 
   CONSTRAINT     h   ALTER TABLE ONLY public."TBL_DATA_HISTORY"
    ADD CONSTRAINT "PK_TBL_DATA_HISTORY" PRIMARY KEY ("ID");
 R   ALTER TABLE ONLY public."TBL_DATA_HISTORY" DROP CONSTRAINT "PK_TBL_DATA_HISTORY";
       public            postgres    false    345                       2606    77018    TBL_DEGISTER PK_TBL_DEGISTER 
   CONSTRAINT     `   ALTER TABLE ONLY public."TBL_DEGISTER"
    ADD CONSTRAINT "PK_TBL_DEGISTER" PRIMARY KEY ("ID");
 J   ALTER TABLE ONLY public."TBL_DEGISTER" DROP CONSTRAINT "PK_TBL_DEGISTER";
       public            postgres    false    346                       2606    77023 (   TBL_KHARIDA_AADASH PK_TBL_KHARIDA_AADASH 
   CONSTRAINT     l   ALTER TABLE ONLY public."TBL_KHARIDA_AADASH"
    ADD CONSTRAINT "PK_TBL_KHARIDA_AADASH" PRIMARY KEY ("ID");
 V   ALTER TABLE ONLY public."TBL_KHARIDA_AADASH" DROP CONSTRAINT "PK_TBL_KHARIDA_AADASH";
       public            postgres    false    347            �           2606    77707 0   TBL_LAND_OTHER_CHARGES PK_TBL_LAND_OTHER_CHARGES 
   CONSTRAINT     t   ALTER TABLE ONLY public."TBL_LAND_OTHER_CHARGES"
    ADD CONSTRAINT "PK_TBL_LAND_OTHER_CHARGES" PRIMARY KEY ("ID");
 ^   ALTER TABLE ONLY public."TBL_LAND_OTHER_CHARGES" DROP CONSTRAINT "PK_TBL_LAND_OTHER_CHARGES";
       public            postgres    false    417            �           2606    78717 4   TBL_MALPOT_OTHER_CHARGES PK_TBL_MALPOT_OTHER_CHARGES 
   CONSTRAINT     x   ALTER TABLE ONLY public."TBL_MALPOT_OTHER_CHARGES"
    ADD CONSTRAINT "PK_TBL_MALPOT_OTHER_CHARGES" PRIMARY KEY ("ID");
 b   ALTER TABLE ONLY public."TBL_MALPOT_OTHER_CHARGES" DROP CONSTRAINT "PK_TBL_MALPOT_OTHER_CHARGES";
       public            postgres    false    471                       2606    77028    TBL_NALI_TYPE PK_TBL_NALI_TYPE 
   CONSTRAINT     b   ALTER TABLE ONLY public."TBL_NALI_TYPE"
    ADD CONSTRAINT "PK_TBL_NALI_TYPE" PRIMARY KEY ("ID");
 L   ALTER TABLE ONLY public."TBL_NALI_TYPE" DROP CONSTRAINT "PK_TBL_NALI_TYPE";
       public            postgres    false    348                       2606    77036 0   TBL_ORGANIZATIONMASTER PK_TBL_ORGANIZATIONMASTER 
   CONSTRAINT     t   ALTER TABLE ONLY public."TBL_ORGANIZATIONMASTER"
    ADD CONSTRAINT "PK_TBL_ORGANIZATIONMASTER" PRIMARY KEY ("ID");
 ^   ALTER TABLE ONLY public."TBL_ORGANIZATIONMASTER" DROP CONSTRAINT "PK_TBL_ORGANIZATIONMASTER";
       public            postgres    false    349                       2606    77044 &   TBL_PAYMENT_ORDER PK_TBL_PAYMENT_ORDER 
   CONSTRAINT     j   ALTER TABLE ONLY public."TBL_PAYMENT_ORDER"
    ADD CONSTRAINT "PK_TBL_PAYMENT_ORDER" PRIMARY KEY ("ID");
 T   ALTER TABLE ONLY public."TBL_PAYMENT_ORDER" DROP CONSTRAINT "PK_TBL_PAYMENT_ORDER";
       public            postgres    false    350            �           2606    77488 6   TBL_PAYMENT_ORDER_DETAILS PK_TBL_PAYMENT_ORDER_DETAILS 
   CONSTRAINT     z   ALTER TABLE ONLY public."TBL_PAYMENT_ORDER_DETAILS"
    ADD CONSTRAINT "PK_TBL_PAYMENT_ORDER_DETAILS" PRIMARY KEY ("ID");
 d   ALTER TABLE ONLY public."TBL_PAYMENT_ORDER_DETAILS" DROP CONSTRAINT "PK_TBL_PAYMENT_ORDER_DETAILS";
       public            postgres    false    400                       2606    77049 *   TBL_PAYMENT_PROCESS PK_TBL_PAYMENT_PROCESS 
   CONSTRAINT     n   ALTER TABLE ONLY public."TBL_PAYMENT_PROCESS"
    ADD CONSTRAINT "PK_TBL_PAYMENT_PROCESS" PRIMARY KEY ("ID");
 X   ALTER TABLE ONLY public."TBL_PAYMENT_PROCESS" DROP CONSTRAINT "PK_TBL_PAYMENT_PROCESS";
       public            postgres    false    351                       2606    77054 $   TBL_PAYMENT_TYPE PK_TBL_PAYMENT_TYPE 
   CONSTRAINT     h   ALTER TABLE ONLY public."TBL_PAYMENT_TYPE"
    ADD CONSTRAINT "PK_TBL_PAYMENT_TYPE" PRIMARY KEY ("ID");
 R   ALTER TABLE ONLY public."TBL_PAYMENT_TYPE" DROP CONSTRAINT "PK_TBL_PAYMENT_TYPE";
       public            postgres    false    352                       2606    77062 $   TBL_PROPERTY_TAX PK_TBL_PROPERTY_TAX 
   CONSTRAINT     h   ALTER TABLE ONLY public."TBL_PROPERTY_TAX"
    ADD CONSTRAINT "PK_TBL_PROPERTY_TAX" PRIMARY KEY ("ID");
 R   ALTER TABLE ONLY public."TBL_PROPERTY_TAX" DROP CONSTRAINT "PK_TBL_PROPERTY_TAX";
       public            postgres    false    353                       2606    77073 (   TBL_STATUS_DETAILS PK_TBL_STATUS_DETAILS 
   CONSTRAINT     l   ALTER TABLE ONLY public."TBL_STATUS_DETAILS"
    ADD CONSTRAINT "PK_TBL_STATUS_DETAILS" PRIMARY KEY ("ID");
 V   ALTER TABLE ONLY public."TBL_STATUS_DETAILS" DROP CONSTRAINT "PK_TBL_STATUS_DETAILS";
       public            postgres    false    355                       2606    77081    TBL_TAX_TYPE PK_TBL_TAX_TYPE 
   CONSTRAINT     `   ALTER TABLE ONLY public."TBL_TAX_TYPE"
    ADD CONSTRAINT "PK_TBL_TAX_TYPE" PRIMARY KEY ("ID");
 J   ALTER TABLE ONLY public."TBL_TAX_TYPE" DROP CONSTRAINT "PK_TBL_TAX_TYPE";
       public            postgres    false    356            "           2606    77094 (   TBL_TOLABIKASA_ORG PK_TBL_TOLABIKASA_ORG 
   CONSTRAINT     l   ALTER TABLE ONLY public."TBL_TOLABIKASA_ORG"
    ADD CONSTRAINT "PK_TBL_TOLABIKASA_ORG" PRIMARY KEY ("ID");
 V   ALTER TABLE ONLY public."TBL_TOLABIKASA_ORG" DROP CONSTRAINT "PK_TBL_TOLABIKASA_ORG";
       public            postgres    false    358            1           2606    77158    Usermaster PK_Usermaster 
   CONSTRAINT     \   ALTER TABLE ONLY public."Usermaster"
    ADD CONSTRAINT "PK_Usermaster" PRIMARY KEY ("Id");
 F   ALTER TABLE ONLY public."Usermaster" DROP CONSTRAINT "PK_Usermaster";
       public            postgres    false    371            �           2606    78687    WARD_MASTER PK_WARD_MASTER 
   CONSTRAINT     ^   ALTER TABLE ONLY public."WARD_MASTER"
    ADD CONSTRAINT "PK_WARD_MASTER" PRIMARY KEY ("ID");
 H   ALTER TABLE ONLY public."WARD_MASTER" DROP CONSTRAINT "PK_WARD_MASTER";
       public            postgres    false    469            .           2606    76230 .   __EFMigrationsHistory PK___EFMigrationsHistory 
   CONSTRAINT     {   ALTER TABLE ONLY public."__EFMigrationsHistory"
    ADD CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId");
 \   ALTER TABLE ONLY public."__EFMigrationsHistory" DROP CONSTRAINT "PK___EFMigrationsHistory";
       public            postgres    false    202            �           2606    77498    STOREDBILLS STOREDBILLS_pkey 
   CONSTRAINT     `   ALTER TABLE ONLY public."STOREDBILLS"
    ADD CONSTRAINT "STOREDBILLS_pkey" PRIMARY KEY ("SN");
 J   ALTER TABLE ONLY public."STOREDBILLS" DROP CONSTRAINT "STOREDBILLS_pkey";
       public            postgres    false    401            T           2606    77289 (   SUB_MODULE_SOURCE SUB_MODULE_SOURCE_pkey 
   CONSTRAINT     �   ALTER TABLE ONLY public."SUB_MODULE_SOURCE"
    ADD CONSTRAINT "SUB_MODULE_SOURCE_pkey" PRIMARY KEY ("BUDJET_SOURCE_ID", "SUB_MODULE_ID");
 V   ALTER TABLE ONLY public."SUB_MODULE_SOURCE" DROP CONSTRAINT "SUB_MODULE_SOURCE_pkey";
       public            postgres    false    383    383            �           2606    76930    SV_PEOPLE SV_PEOPLE_pkey 
   CONSTRAINT     ]   ALTER TABLE ONLY public."SV_PEOPLE"
    ADD CONSTRAINT "SV_PEOPLE_pkey" PRIMARY KEY ("IID");
 F   ALTER TABLE ONLY public."SV_PEOPLE" DROP CONSTRAINT "SV_PEOPLE_pkey";
       public            postgres    false    331            �           2606    76941 &   SV_VEHICLEMASTER SV_VEHICLEMASTER_pkey 
   CONSTRAINT     j   ALTER TABLE ONLY public."SV_VEHICLEMASTER"
    ADD CONSTRAINT "SV_VEHICLEMASTER_pkey" PRIMARY KEY ("SN");
 T   ALTER TABLE ONLY public."SV_VEHICLEMASTER" DROP CONSTRAINT "SV_VEHICLEMASTER_pkey";
       public            postgres    false    333            �           2606    77682 .   TAX_ADDTNL_CHRG_DTLS TAX_ADDTNL_CHRG_DTLS_pkey 
   CONSTRAINT     r   ALTER TABLE ONLY public."TAX_ADDTNL_CHRG_DTLS"
    ADD CONSTRAINT "TAX_ADDTNL_CHRG_DTLS_pkey" PRIMARY KEY ("SN");
 \   ALTER TABLE ONLY public."TAX_ADDTNL_CHRG_DTLS" DROP CONSTRAINT "TAX_ADDTNL_CHRG_DTLS_pkey";
       public            postgres    false    415            (           2606    77118 *   TBLHL_ADD_SUBTRACT TBLHL_ADD_SUBTRACT_pkey 
   CONSTRAINT     n   ALTER TABLE ONLY public."TBLHL_ADD_SUBTRACT"
    ADD CONSTRAINT "TBLHL_ADD_SUBTRACT_pkey" PRIMARY KEY ("SN");
 X   ALTER TABLE ONLY public."TBLHL_ADD_SUBTRACT" DROP CONSTRAINT "TBLHL_ADD_SUBTRACT_pkey";
       public            postgres    false    363            .           2606    77133 *   TBLTAX_FINE_REBATE TBLTAX_FINE_REBATE_pkey 
   CONSTRAINT     n   ALTER TABLE ONLY public."TBLTAX_FINE_REBATE"
    ADD CONSTRAINT "TBLTAX_FINE_REBATE_pkey" PRIMARY KEY ("SN");
 X   ALTER TABLE ONLY public."TBLTAX_FINE_REBATE" DROP CONSTRAINT "TBLTAX_FINE_REBATE_pkey";
       public            postgres    false    366                        2606    77086 2   TBL_TAXSOURCERECORDNEW TBL_TAXSOURCERECORDNEW_pkey 
   CONSTRAINT     |   ALTER TABLE ONLY public."TBL_TAXSOURCERECORDNEW"
    ADD CONSTRAINT "TBL_TAXSOURCERECORDNEW_pkey" PRIMARY KEY ("TAXSRCID");
 `   ALTER TABLE ONLY public."TBL_TAXSOURCERECORDNEW" DROP CONSTRAINT "TBL_TAXSOURCERECORDNEW_pkey";
       public            postgres    false    357            $           2606    77102 (   TBL_VEHICLE_PARTS TBL_VEHICLE_PARTS_pkey 
   CONSTRAINT     l   ALTER TABLE ONLY public."TBL_VEHICLE_PARTS"
    ADD CONSTRAINT "TBL_VEHICLE_PARTS_pkey" PRIMARY KEY ("SN");
 V   ALTER TABLE ONLY public."TBL_VEHICLE_PARTS" DROP CONSTRAINT "TBL_VEHICLE_PARTS_pkey";
       public            postgres    false    359            /           1259    79240 
   EmailIndex    INDEX     R   CREATE INDEX "EmailIndex" ON public."Usermaster" USING btree ("NormalizedEmail");
     DROP INDEX public."EmailIndex";
       public            postgres    false    371            A           1259    78999    IX_ACC_ACC_MASTER_TYPE_ID    INDEX     ]   CREATE INDEX "IX_ACC_ACC_MASTER_TYPE_ID" ON public."ACC_ACC_MASTER" USING btree ("TYPE_ID");
 /   DROP INDEX public."IX_ACC_ACC_MASTER_TYPE_ID";
       public            postgres    false    378            m           1259    79000 #   IX_ACC_ASULI_BIBARAN_PERSON_TYPE_ID    INDEX     q   CREATE INDEX "IX_ACC_ASULI_BIBARAN_PERSON_TYPE_ID" ON public."ACC_ASULI_BIBARAN" USING btree ("PERSON_TYPE_ID");
 9   DROP INDEX public."IX_ACC_ASULI_BIBARAN_PERSON_TYPE_ID";
       public            postgres    false    392            H           1259    79001    IX_ACC_BANK_GRNTY_PERSON_ID    INDEX     a   CREATE INDEX "IX_ACC_BANK_GRNTY_PERSON_ID" ON public."ACC_BANK_GRNTY" USING btree ("PERSON_ID");
 1   DROP INDEX public."IX_ACC_BANK_GRNTY_PERSON_ID";
       public            postgres    false    380            I           1259    79002    IX_ACC_BANK_GRNTY_WORK_ID    INDEX     ]   CREATE INDEX "IX_ACC_BANK_GRNTY_WORK_ID" ON public."ACC_BANK_GRNTY" USING btree ("WORK_ID");
 /   DROP INDEX public."IX_ACC_BANK_GRNTY_WORK_ID";
       public            postgres    false    380            K           1259    79003    IX_ACC_BANK_TRANS_BANK_ID    INDEX     ]   CREATE INDEX "IX_ACC_BANK_TRANS_BANK_ID" ON public."ACC_BANK_TRANS" USING btree ("BANK_ID");
 /   DROP INDEX public."IX_ACC_BANK_TRANS_BANK_ID";
       public            postgres    false    449            L           1259    79004    IX_ACC_BANK_TRANS_BILL_ID    INDEX     ]   CREATE INDEX "IX_ACC_BANK_TRANS_BILL_ID" ON public."ACC_BANK_TRANS" USING btree ("BILL_ID");
 /   DROP INDEX public."IX_ACC_BANK_TRANS_BILL_ID";
       public            postgres    false    449            M           1259    79005    IX_ACC_BANK_TRANS_VCHR_ID    INDEX     ]   CREATE INDEX "IX_ACC_BANK_TRANS_VCHR_ID" ON public."ACC_BANK_TRANS" USING btree ("VCHR_ID");
 /   DROP INDEX public."IX_ACC_BANK_TRANS_VCHR_ID";
       public            postgres    false    449            3           1259    79006    IX_ACC_BGT_RVSN_BGT_ALCTN_ID    INDEX     c   CREATE INDEX "IX_ACC_BGT_RVSN_BGT_ALCTN_ID" ON public."ACC_BGT_RVSN" USING btree ("BGT_ALCTN_ID");
 2   DROP INDEX public."IX_ACC_BGT_RVSN_BGT_ALCTN_ID";
       public            postgres    false    374            �           1259    79007     IX_ACC_BGT_TRANSFER_BGT_ALCTN_ID    INDEX     k   CREATE INDEX "IX_ACC_BGT_TRANSFER_BGT_ALCTN_ID" ON public."ACC_BGT_TRANSFER" USING btree ("BGT_ALCTN_ID");
 6   DROP INDEX public."IX_ACC_BGT_TRANSFER_BGT_ALCTN_ID";
       public            postgres    false    409            �           1259    79008    IX_ACC_BGT_TRANSFER_FROM_ACC_ID    INDEX     i   CREATE INDEX "IX_ACC_BGT_TRANSFER_FROM_ACC_ID" ON public."ACC_BGT_TRANSFER" USING btree ("FROM_ACC_ID");
 5   DROP INDEX public."IX_ACC_BGT_TRANSFER_FROM_ACC_ID";
       public            postgres    false    409            �           1259    79009    IX_ACC_BGT_TRANSFER_TO_ACC_ID    INDEX     e   CREATE INDEX "IX_ACC_BGT_TRANSFER_TO_ACC_ID" ON public."ACC_BGT_TRANSFER" USING btree ("TO_ACC_ID");
 3   DROP INDEX public."IX_ACC_BGT_TRANSFER_TO_ACC_ID";
       public            postgres    false    409            g           1259    79010    IX_ACC_BUDJET_SOURCE_MIN_ACC_ID    INDEX     i   CREATE INDEX "IX_ACC_BUDJET_SOURCE_MIN_ACC_ID" ON public."ACC_BUDJET_SOURCE" USING btree ("MIN_ACC_ID");
 5   DROP INDEX public."IX_ACC_BUDJET_SOURCE_MIN_ACC_ID";
       public            postgres    false    391            h           1259    79011    IX_ACC_BUDJET_SOURCE_SOURCE_ID    INDEX     g   CREATE INDEX "IX_ACC_BUDJET_SOURCE_SOURCE_ID" ON public."ACC_BUDJET_SOURCE" USING btree ("SOURCE_ID");
 4   DROP INDEX public."IX_ACC_BUDJET_SOURCE_SOURCE_ID";
       public            postgres    false    391            P           1259    79012    IX_ACC_CASH_TRANS_BILL_ID    INDEX     ]   CREATE INDEX "IX_ACC_CASH_TRANS_BILL_ID" ON public."ACC_CASH_TRANS" USING btree ("BILL_ID");
 /   DROP INDEX public."IX_ACC_CASH_TRANS_BILL_ID";
       public            postgres    false    450            Q           1259    79013    IX_ACC_CASH_TRANS_VCHR_ID    INDEX     ]   CREATE INDEX "IX_ACC_CASH_TRANS_VCHR_ID" ON public."ACC_CASH_TRANS" USING btree ("VCHR_ID");
 /   DROP INDEX public."IX_ACC_CASH_TRANS_VCHR_ID";
       public            postgres    false    450            6           1259    79014 !   IX_ACC_CURRENCTY_RATE_CURRENCY_ID    INDEX     m   CREATE INDEX "IX_ACC_CURRENCTY_RATE_CURRENCY_ID" ON public."ACC_CURRENCTY_RATE" USING btree ("CURRENCY_ID");
 7   DROP INDEX public."IX_ACC_CURRENCTY_RATE_CURRENCY_ID";
       public            postgres    false    375            �           1259    79015    IX_ACC_DHRTI_BILL_DTL_ACC_ID    INDEX     c   CREATE INDEX "IX_ACC_DHRTI_BILL_DTL_ACC_ID" ON public."ACC_DHRTI_BILL_DTL" USING btree ("ACC_ID");
 2   DROP INDEX public."IX_ACC_DHRTI_BILL_DTL_ACC_ID";
       public            postgres    false    420            �           1259    79016    IX_ACC_DHRTI_BILL_DTL_VCHR_ID    INDEX     e   CREATE INDEX "IX_ACC_DHRTI_BILL_DTL_VCHR_ID" ON public."ACC_DHRTI_BILL_DTL" USING btree ("VCHR_ID");
 3   DROP INDEX public."IX_ACC_DHRTI_BILL_DTL_VCHR_ID";
       public            postgres    false    420            �           1259    79017    IX_ACC_DHRTI_BILL_DTL_WORK_ID    INDEX     e   CREATE INDEX "IX_ACC_DHRTI_BILL_DTL_WORK_ID" ON public."ACC_DHRTI_BILL_DTL" USING btree ("WORK_ID");
 3   DROP INDEX public."IX_ACC_DHRTI_BILL_DTL_WORK_ID";
       public            postgres    false    420            �           1259    79018 #   IX_ACC_DHRTI_BILL_MASTER_BILLTYPEID    INDEX     q   CREATE INDEX "IX_ACC_DHRTI_BILL_MASTER_BILLTYPEID" ON public."ACC_DHRTI_BILL_MASTER" USING btree ("BILLTYPEID");
 9   DROP INDEX public."IX_ACC_DHRTI_BILL_MASTER_BILLTYPEID";
       public            postgres    false    421            �           1259    79019 &   IX_ACC_DHRTI_BILL_MASTER_SUB_MODULE_ID    INDEX     w   CREATE INDEX "IX_ACC_DHRTI_BILL_MASTER_SUB_MODULE_ID" ON public."ACC_DHRTI_BILL_MASTER" USING btree ("SUB_MODULE_ID");
 <   DROP INDEX public."IX_ACC_DHRTI_BILL_MASTER_SUB_MODULE_ID";
       public            postgres    false    421            �           1259    79020     IX_ACC_DHRTI_BILL_MASTER_VCHR_ID    INDEX     k   CREATE INDEX "IX_ACC_DHRTI_BILL_MASTER_VCHR_ID" ON public."ACC_DHRTI_BILL_MASTER" USING btree ("VCHR_ID");
 6   DROP INDEX public."IX_ACC_DHRTI_BILL_MASTER_VCHR_ID";
       public            postgres    false    421            �           1259    79021     IX_ACC_DHRTI_BILL_MASTER_WORK_ID    INDEX     k   CREATE INDEX "IX_ACC_DHRTI_BILL_MASTER_WORK_ID" ON public."ACC_DHRTI_BILL_MASTER" USING btree ("WORK_ID");
 6   DROP INDEX public."IX_ACC_DHRTI_BILL_MASTER_WORK_ID";
       public            postgres    false    421            �           1259    79022    IX_ACC_EXPENSES_DETAILS_ACC_ID    INDEX     g   CREATE INDEX "IX_ACC_EXPENSES_DETAILS_ACC_ID" ON public."ACC_EXPENSES_DETAILS" USING btree ("ACC_ID");
 4   DROP INDEX public."IX_ACC_EXPENSES_DETAILS_ACC_ID";
       public            postgres    false    410            �           1259    79023 '   IX_ACC_EXPENSES_DETAILS_PAYMENT_SLIP_ID    INDEX     y   CREATE INDEX "IX_ACC_EXPENSES_DETAILS_PAYMENT_SLIP_ID" ON public."ACC_EXPENSES_DETAILS" USING btree ("PAYMENT_SLIP_ID");
 =   DROP INDEX public."IX_ACC_EXPENSES_DETAILS_PAYMENT_SLIP_ID";
       public            postgres    false    410            �           1259    79024 &   IX_ACC_EXPENSES_DETAILS_PERSON_TYPE_ID    INDEX     w   CREATE INDEX "IX_ACC_EXPENSES_DETAILS_PERSON_TYPE_ID" ON public."ACC_EXPENSES_DETAILS" USING btree ("PERSON_TYPE_ID");
 <   DROP INDEX public."IX_ACC_EXPENSES_DETAILS_PERSON_TYPE_ID";
       public            postgres    false    410            �           1259    79025 %   IX_ACC_EXPENSES_DETAILS_TRANS_TYPE_ID    INDEX     u   CREATE INDEX "IX_ACC_EXPENSES_DETAILS_TRANS_TYPE_ID" ON public."ACC_EXPENSES_DETAILS" USING btree ("TRANS_TYPE_ID");
 ;   DROP INDEX public."IX_ACC_EXPENSES_DETAILS_TRANS_TYPE_ID";
       public            postgres    false    410            �           1259    79026    IX_ACC_EXPENSES_DETAILS_WORK_ID    INDEX     i   CREATE INDEX "IX_ACC_EXPENSES_DETAILS_WORK_ID" ON public."ACC_EXPENSES_DETAILS" USING btree ("WORK_ID");
 5   DROP INDEX public."IX_ACC_EXPENSES_DETAILS_WORK_ID";
       public            postgres    false    410            >           1259    79027    IX_ACC_PADADHIKARI_MSTR_POST_ID    INDEX     i   CREATE INDEX "IX_ACC_PADADHIKARI_MSTR_POST_ID" ON public."ACC_PADADHIKARI_MSTR" USING btree ("POST_ID");
 5   DROP INDEX public."IX_ACC_PADADHIKARI_MSTR_POST_ID";
       public            postgres    false    377            �           1259    79028    IX_ACC_PAYMENT_CLEARANCE_ACC_ID    INDEX     i   CREATE INDEX "IX_ACC_PAYMENT_CLEARANCE_ACC_ID" ON public."ACC_PAYMENT_CLEARANCE" USING btree ("ACC_ID");
 5   DROP INDEX public."IX_ACC_PAYMENT_CLEARANCE_ACC_ID";
       public            postgres    false    411            �           1259    79029 &   IX_ACC_PAYMENT_CLEARANCE_BUDGET_ACC_ID    INDEX     w   CREATE INDEX "IX_ACC_PAYMENT_CLEARANCE_BUDGET_ACC_ID" ON public."ACC_PAYMENT_CLEARANCE" USING btree ("BUDGET_ACC_ID");
 <   DROP INDEX public."IX_ACC_PAYMENT_CLEARANCE_BUDGET_ACC_ID";
       public            postgres    false    411            ;           1259    79030    IX_ACC_PAYMENT_DEDUCTION_ACC_ID    INDEX     i   CREATE INDEX "IX_ACC_PAYMENT_DEDUCTION_ACC_ID" ON public."ACC_PAYMENT_DEDUCTION" USING btree ("ACC_ID");
 5   DROP INDEX public."IX_ACC_PAYMENT_DEDUCTION_ACC_ID";
       public            postgres    false    447            <           1259    79031 &   IX_ACC_PAYMENT_DEDUCTION_BUDGET_ACC_ID    INDEX     w   CREATE INDEX "IX_ACC_PAYMENT_DEDUCTION_BUDGET_ACC_ID" ON public."ACC_PAYMENT_DEDUCTION" USING btree ("BUDGET_ACC_ID");
 <   DROP INDEX public."IX_ACC_PAYMENT_DEDUCTION_BUDGET_ACC_ID";
       public            postgres    false    447            =           1259    79032 #   IX_ACC_PAYMENT_DEDUCTION_PAYMENT_ID    INDEX     q   CREATE INDEX "IX_ACC_PAYMENT_DEDUCTION_PAYMENT_ID" ON public."ACC_PAYMENT_DEDUCTION" USING btree ("PAYMENT_ID");
 9   DROP INDEX public."IX_ACC_PAYMENT_DEDUCTION_PAYMENT_ID";
       public            postgres    false    447            B           1259    79033    IX_ACC_PAYMENT_DETAILS_ACC_ID    INDEX     e   CREATE INDEX "IX_ACC_PAYMENT_DETAILS_ACC_ID" ON public."ACC_PAYMENT_DETAILS" USING btree ("ACC_ID");
 3   DROP INDEX public."IX_ACC_PAYMENT_DETAILS_ACC_ID";
       public            postgres    false    448            C           1259    79034 $   IX_ACC_PAYMENT_DETAILS_BUDGET_ACC_ID    INDEX     s   CREATE INDEX "IX_ACC_PAYMENT_DETAILS_BUDGET_ACC_ID" ON public."ACC_PAYMENT_DETAILS" USING btree ("BUDGET_ACC_ID");
 :   DROP INDEX public."IX_ACC_PAYMENT_DETAILS_BUDGET_ACC_ID";
       public            postgres    false    448            D           1259    79035 !   IX_ACC_PAYMENT_DETAILS_PAYMENT_ID    INDEX     m   CREATE INDEX "IX_ACC_PAYMENT_DETAILS_PAYMENT_ID" ON public."ACC_PAYMENT_DETAILS" USING btree ("PAYMENT_ID");
 7   DROP INDEX public."IX_ACC_PAYMENT_DETAILS_PAYMENT_ID";
       public            postgres    false    448            E           1259    79036 %   IX_ACC_PAYMENT_DETAILS_PERSON_TYPE_ID    INDEX     u   CREATE INDEX "IX_ACC_PAYMENT_DETAILS_PERSON_TYPE_ID" ON public."ACC_PAYMENT_DETAILS" USING btree ("PERSON_TYPE_ID");
 ;   DROP INDEX public."IX_ACC_PAYMENT_DETAILS_PERSON_TYPE_ID";
       public            postgres    false    448            F           1259    79037 $   IX_ACC_PAYMENT_DETAILS_TRANS_TYPE_ID    INDEX     s   CREATE INDEX "IX_ACC_PAYMENT_DETAILS_TRANS_TYPE_ID" ON public."ACC_PAYMENT_DETAILS" USING btree ("TRANS_TYPE_ID");
 :   DROP INDEX public."IX_ACC_PAYMENT_DETAILS_TRANS_TYPE_ID";
       public            postgres    false    448            G           1259    79038    IX_ACC_PAYMENT_DETAILS_VCHR_ID    INDEX     g   CREATE INDEX "IX_ACC_PAYMENT_DETAILS_VCHR_ID" ON public."ACC_PAYMENT_DETAILS" USING btree ("VCHR_ID");
 4   DROP INDEX public."IX_ACC_PAYMENT_DETAILS_VCHR_ID";
       public            postgres    false    448            H           1259    79039    IX_ACC_PAYMENT_DETAILS_WORK_ID    INDEX     g   CREATE INDEX "IX_ACC_PAYMENT_DETAILS_WORK_ID" ON public."ACC_PAYMENT_DETAILS" USING btree ("WORK_ID");
 4   DROP INDEX public."IX_ACC_PAYMENT_DETAILS_WORK_ID";
       public            postgres    false    448            �           1259    79040 $   IX_ACC_PAYMENT_MASTER_PERSON_TYPE_ID    INDEX     s   CREATE INDEX "IX_ACC_PAYMENT_MASTER_PERSON_TYPE_ID" ON public."ACC_PAYMENT_MASTER" USING btree ("PERSON_TYPE_ID");
 :   DROP INDEX public."IX_ACC_PAYMENT_MASTER_PERSON_TYPE_ID";
       public            postgres    false    422            �           1259    79041 #   IX_ACC_PAYMENT_MASTER_SUB_MODULE_ID    INDEX     q   CREATE INDEX "IX_ACC_PAYMENT_MASTER_SUB_MODULE_ID" ON public."ACC_PAYMENT_MASTER" USING btree ("SUB_MODULE_ID");
 9   DROP INDEX public."IX_ACC_PAYMENT_MASTER_SUB_MODULE_ID";
       public            postgres    false    422            �           1259    79042 #   IX_ACC_PAYMENT_MASTER_TRANS_TYPE_ID    INDEX     q   CREATE INDEX "IX_ACC_PAYMENT_MASTER_TRANS_TYPE_ID" ON public."ACC_PAYMENT_MASTER" USING btree ("TRANS_TYPE_ID");
 9   DROP INDEX public."IX_ACC_PAYMENT_MASTER_TRANS_TYPE_ID";
       public            postgres    false    422            �           1259    79043    IX_ACC_PAYMENT_MASTER_VCHR_ID    INDEX     e   CREATE INDEX "IX_ACC_PAYMENT_MASTER_VCHR_ID" ON public."ACC_PAYMENT_MASTER" USING btree ("VCHR_ID");
 3   DROP INDEX public."IX_ACC_PAYMENT_MASTER_VCHR_ID";
       public            postgres    false    422            �           1259    79044    IX_ACC_PAYMENT_MASTER_WORK_ID    INDEX     e   CREATE INDEX "IX_ACC_PAYMENT_MASTER_WORK_ID" ON public."ACC_PAYMENT_MASTER" USING btree ("WORK_ID");
 3   DROP INDEX public."IX_ACC_PAYMENT_MASTER_WORK_ID";
       public            postgres    false    422            �           1259    79045 !   IX_ACC_VCHR_DETAILS_SUB_MODULE_ID    INDEX     m   CREATE INDEX "IX_ACC_VCHR_DETAILS_SUB_MODULE_ID" ON public."ACC_VCHR_DETAILS" USING btree ("SUB_MODULE_ID");
 7   DROP INDEX public."IX_ACC_VCHR_DETAILS_SUB_MODULE_ID";
       public            postgres    false    423            �           1259    79046 !   IX_ACC_VCHR_DETAILS_TRANS_TYPE_ID    INDEX     m   CREATE INDEX "IX_ACC_VCHR_DETAILS_TRANS_TYPE_ID" ON public."ACC_VCHR_DETAILS" USING btree ("TRANS_TYPE_ID");
 7   DROP INDEX public."IX_ACC_VCHR_DETAILS_TRANS_TYPE_ID";
       public            postgres    false    423            �           1259    79047    IX_ACC_VCHR_DETAILS_VCHR_ID    INDEX     a   CREATE INDEX "IX_ACC_VCHR_DETAILS_VCHR_ID" ON public."ACC_VCHR_DETAILS" USING btree ("VCHR_ID");
 1   DROP INDEX public."IX_ACC_VCHR_DETAILS_VCHR_ID";
       public            postgres    false    423            �           1259    79048     IX_ACC_VCHR_DETAILS_VCHR_TYPE_ID    INDEX     k   CREATE INDEX "IX_ACC_VCHR_DETAILS_VCHR_TYPE_ID" ON public."ACC_VCHR_DETAILS" USING btree ("VCHR_TYPE_ID");
 6   DROP INDEX public."IX_ACC_VCHR_DETAILS_VCHR_TYPE_ID";
       public            postgres    false    423            �           1259    79049    IX_ACC_VCHR_DETAILS_WORK_ID    INDEX     a   CREATE INDEX "IX_ACC_VCHR_DETAILS_WORK_ID" ON public."ACC_VCHR_DETAILS" USING btree ("WORK_ID");
 1   DROP INDEX public."IX_ACC_VCHR_DETAILS_WORK_ID";
       public            postgres    false    423            D           1259    79050     IX_ACC_VCHR_MASTER_SUB_MODULE_ID    INDEX     k   CREATE INDEX "IX_ACC_VCHR_MASTER_SUB_MODULE_ID" ON public."ACC_VCHR_MASTER" USING btree ("SUB_MODULE_ID");
 6   DROP INDEX public."IX_ACC_VCHR_MASTER_SUB_MODULE_ID";
       public            postgres    false    379            E           1259    79051    IX_ACC_VCHR_MASTER_VCHR_TYPE_ID    INDEX     i   CREATE INDEX "IX_ACC_VCHR_MASTER_VCHR_TYPE_ID" ON public."ACC_VCHR_MASTER" USING btree ("VCHR_TYPE_ID");
 5   DROP INDEX public."IX_ACC_VCHR_MASTER_VCHR_TYPE_ID";
       public            postgres    false    379            L           1259    79052 $   IX_ACC_WORK_FUNDS_DETAIL_PROVIDER_ID    INDEX     s   CREATE INDEX "IX_ACC_WORK_FUNDS_DETAIL_PROVIDER_ID" ON public."ACC_WORK_FUNDS_DETAIL" USING btree ("PROVIDER_ID");
 :   DROP INDEX public."IX_ACC_WORK_FUNDS_DETAIL_PROVIDER_ID";
       public            postgres    false    381            M           1259    79053     IX_ACC_WORK_FUNDS_DETAIL_WORK_ID    INDEX     k   CREATE INDEX "IX_ACC_WORK_FUNDS_DETAIL_WORK_ID" ON public."ACC_WORK_FUNDS_DETAIL" USING btree ("WORK_ID");
 6   DROP INDEX public."IX_ACC_WORK_FUNDS_DETAIL_WORK_ID";
       public            postgres    false    381            �           1259    79054 '   IX_ACC_WORK_PAYMNT_TRANS_PERSON_TYPE_ID    INDEX     y   CREATE INDEX "IX_ACC_WORK_PAYMNT_TRANS_PERSON_TYPE_ID" ON public."ACC_WORK_PAYMNT_TRANS" USING btree ("PERSON_TYPE_ID");
 =   DROP INDEX public."IX_ACC_WORK_PAYMNT_TRANS_PERSON_TYPE_ID";
       public            postgres    false    424            �           1259    79055     IX_ACC_WORK_PAYMNT_TRANS_VCHR_ID    INDEX     k   CREATE INDEX "IX_ACC_WORK_PAYMNT_TRANS_VCHR_ID" ON public."ACC_WORK_PAYMNT_TRANS" USING btree ("VCHR_ID");
 6   DROP INDEX public."IX_ACC_WORK_PAYMNT_TRANS_VCHR_ID";
       public            postgres    false    424            �           1259    79056     IX_ACC_WORK_PAYMNT_TRANS_WORK_ID    INDEX     k   CREATE INDEX "IX_ACC_WORK_PAYMNT_TRANS_WORK_ID" ON public."ACC_WORK_PAYMNT_TRANS" USING btree ("WORK_ID");
 6   DROP INDEX public."IX_ACC_WORK_PAYMNT_TRANS_WORK_ID";
       public            postgres    false    424            3           1259    79058 #   IX_BANKTRANSACTIONS_DHRTI_MASTER_ID    INDEX     q   CREATE INDEX "IX_BANKTRANSACTIONS_DHRTI_MASTER_ID" ON public."BANKTRANSACTIONS" USING btree ("DHRTI_MASTER_ID");
 9   DROP INDEX public."IX_BANKTRANSACTIONS_DHRTI_MASTER_ID";
       public            postgres    false    445            4           1259    79059 %   IX_BANKTRANSACTIONS_SUBMODULE_TYPE_ID    INDEX     u   CREATE INDEX "IX_BANKTRANSACTIONS_SUBMODULE_TYPE_ID" ON public."BANKTRANSACTIONS" USING btree ("SUBMODULE_TYPE_ID");
 ;   DROP INDEX public."IX_BANKTRANSACTIONS_SUBMODULE_TYPE_ID";
       public            postgres    false    445            5           1259    79060    IX_BANKTRANSACTIONS_VCHR_ID    INDEX     a   CREATE INDEX "IX_BANKTRANSACTIONS_VCHR_ID" ON public."BANKTRANSACTIONS" USING btree ("VCHR_ID");
 1   DROP INDEX public."IX_BANKTRANSACTIONS_VCHR_ID";
       public            postgres    false    445            P           1259    79057    IX_BANK_BRANCH_BANKID    INDEX     U   CREATE INDEX "IX_BANK_BRANCH_BANKID" ON public."BANK_BRANCH" USING btree ("BANKID");
 +   DROP INDEX public."IX_BANK_BRANCH_BANKID";
       public            postgres    false    382            8           1259    79061 "   IX_CASHTRANSACTION_DHRTI_MASTER_ID    INDEX     o   CREATE INDEX "IX_CASHTRANSACTION_DHRTI_MASTER_ID" ON public."CASHTRANSACTION" USING btree ("DHRTI_MASTER_ID");
 8   DROP INDEX public."IX_CASHTRANSACTION_DHRTI_MASTER_ID";
       public            postgres    false    446            9           1259    79062 $   IX_CASHTRANSACTION_SUBMODULE_TYPE_ID    INDEX     s   CREATE INDEX "IX_CASHTRANSACTION_SUBMODULE_TYPE_ID" ON public."CASHTRANSACTION" USING btree ("SUBMODULE_TYPE_ID");
 :   DROP INDEX public."IX_CASHTRANSACTION_SUBMODULE_TYPE_ID";
       public            postgres    false    446            :           1259    79063    IX_CASHTRANSACTION_VCHR_ID    INDEX     _   CREATE INDEX "IX_CASHTRANSACTION_VCHR_ID" ON public."CASHTRANSACTION" USING btree ("VCHR_ID");
 0   DROP INDEX public."IX_CASHTRANSACTION_VCHR_ID";
       public            postgres    false    446            �           1259    79064    IX_FIREBRIGADESTATE_ACC_ID    INDEX     _   CREATE INDEX "IX_FIREBRIGADESTATE_ACC_ID" ON public."FIREBRIGADESTATE" USING btree ("ACC_ID");
 0   DROP INDEX public."IX_FIREBRIGADESTATE_ACC_ID";
       public            postgres    false    412            U           1259    79066    IX_IMISRoleClaim_RoleId    INDEX     Y   CREATE INDEX "IX_IMISRoleClaim_RoleId" ON public."IMISRoleClaim" USING btree ("RoleId");
 -   DROP INDEX public."IX_IMISRoleClaim_RoleId";
       public            postgres    false    385            �           1259    79067    IX_IMISUserClaim_UserId    INDEX     Y   CREATE INDEX "IX_IMISUserClaim_UserId" ON public."IMISUserClaim" USING btree ("UserId");
 -   DROP INDEX public."IX_IMISUserClaim_UserId";
       public            postgres    false    404            �           1259    79068    IX_IMISUserLogin_UserId    INDEX     Y   CREATE INDEX "IX_IMISUserLogin_UserId" ON public."IMISUserLogin" USING btree ("UserId");
 -   DROP INDEX public."IX_IMISUserLogin_UserId";
       public            postgres    false    405            �           1259    79069    IX_IMISUserRole_RoleId    INDEX     W   CREATE INDEX "IX_IMISUserRole_RoleId" ON public."IMISUserRole" USING btree ("RoleId");
 ,   DROP INDEX public."IX_IMISUserRole_RoleId";
       public            postgres    false    406            �           1259    79070    IX_INCOMEBILLDETAILS_ACC_ID    INDEX     a   CREATE INDEX "IX_INCOMEBILLDETAILS_ACC_ID" ON public."INCOMEBILLDETAILS" USING btree ("ACC_ID");
 1   DROP INDEX public."IX_INCOMEBILLDETAILS_ACC_ID";
       public            postgres    false    425            �           1259    79071    IX_INCOMEBILLDETAILS_VCHR_ID    INDEX     c   CREATE INDEX "IX_INCOMEBILLDETAILS_VCHR_ID" ON public."INCOMEBILLDETAILS" USING btree ("VCHR_ID");
 2   DROP INDEX public."IX_INCOMEBILLDETAILS_VCHR_ID";
       public            postgres    false    425            �           1259    79072    IX_INCOMEBILLMASTER_BILLTYPEID    INDEX     g   CREATE INDEX "IX_INCOMEBILLMASTER_BILLTYPEID" ON public."INCOMEBILLMASTER" USING btree ("BILLTYPEID");
 4   DROP INDEX public."IX_INCOMEBILLMASTER_BILLTYPEID";
       public            postgres    false    426            �           1259    79073 !   IX_INCOMEBILLMASTER_SUB_MODULE_ID    INDEX     m   CREATE INDEX "IX_INCOMEBILLMASTER_SUB_MODULE_ID" ON public."INCOMEBILLMASTER" USING btree ("SUB_MODULE_ID");
 7   DROP INDEX public."IX_INCOMEBILLMASTER_SUB_MODULE_ID";
       public            postgres    false    426            �           1259    79074    IX_INCOMEBILLMASTER_VCHR_ID    INDEX     a   CREATE INDEX "IX_INCOMEBILLMASTER_VCHR_ID" ON public."INCOMEBILLMASTER" USING btree ("VCHR_ID");
 1   DROP INDEX public."IX_INCOMEBILLMASTER_VCHR_ID";
       public            postgres    false    426            W           1259    79075    IX_INV_GOODS_ADJUST_ACCEPT_BY    INDEX     e   CREATE INDEX "IX_INV_GOODS_ADJUST_ACCEPT_BY" ON public."INV_GOODS_ADJUST" USING btree ("ACCEPT_BY");
 3   DROP INDEX public."IX_INV_GOODS_ADJUST_ACCEPT_BY";
       public            postgres    false    452            X           1259    79076    IX_INV_GOODS_ADJUST_BRAND_ID    INDEX     c   CREATE INDEX "IX_INV_GOODS_ADJUST_BRAND_ID" ON public."INV_GOODS_ADJUST" USING btree ("BRAND_ID");
 2   DROP INDEX public."IX_INV_GOODS_ADJUST_BRAND_ID";
       public            postgres    false    452            Y           1259    79077    IX_INV_GOODS_ADJUST_ITEM_ID    INDEX     a   CREATE INDEX "IX_INV_GOODS_ADJUST_ITEM_ID" ON public."INV_GOODS_ADJUST" USING btree ("ITEM_ID");
 1   DROP INDEX public."IX_INV_GOODS_ADJUST_ITEM_ID";
       public            postgres    false    452            Z           1259    79078    IX_INV_GOODS_ADJUST_PREP_BY    INDEX     a   CREATE INDEX "IX_INV_GOODS_ADJUST_PREP_BY" ON public."INV_GOODS_ADJUST" USING btree ("PREP_BY");
 1   DROP INDEX public."IX_INV_GOODS_ADJUST_PREP_BY";
       public            postgres    false    452            [           1259    79079    IX_INV_GOODS_ADJUST_SPEC_ID    INDEX     a   CREATE INDEX "IX_INV_GOODS_ADJUST_SPEC_ID" ON public."INV_GOODS_ADJUST" USING btree ("SPEC_ID");
 1   DROP INDEX public."IX_INV_GOODS_ADJUST_SPEC_ID";
       public            postgres    false    452            �           1259    79080    IX_INV_GOODS_REC_DETL_BRAND_ID    INDEX     g   CREATE INDEX "IX_INV_GOODS_REC_DETL_BRAND_ID" ON public."INV_GOODS_REC_DETL" USING btree ("BRAND_ID");
 4   DROP INDEX public."IX_INV_GOODS_REC_DETL_BRAND_ID";
       public            postgres    false    476            �           1259    79081 %   IX_INV_GOODS_REC_DETL_GOODS_MASTER_ID    INDEX     u   CREATE INDEX "IX_INV_GOODS_REC_DETL_GOODS_MASTER_ID" ON public."INV_GOODS_REC_DETL" USING btree ("GOODS_MASTER_ID");
 ;   DROP INDEX public."IX_INV_GOODS_REC_DETL_GOODS_MASTER_ID";
       public            postgres    false    476            �           1259    79082    IX_INV_GOODS_REC_DETL_ITEM_ID    INDEX     e   CREATE INDEX "IX_INV_GOODS_REC_DETL_ITEM_ID" ON public."INV_GOODS_REC_DETL" USING btree ("ITEM_ID");
 3   DROP INDEX public."IX_INV_GOODS_REC_DETL_ITEM_ID";
       public            postgres    false    476            �           1259    79083    IX_INV_GOODS_REC_DETL_SPEC_ID    INDEX     e   CREATE INDEX "IX_INV_GOODS_REC_DETL_SPEC_ID" ON public."INV_GOODS_REC_DETL" USING btree ("SPEC_ID");
 3   DROP INDEX public."IX_INV_GOODS_REC_DETL_SPEC_ID";
       public            postgres    false    476            �           1259    79084    IX_INV_GOODS_REC_DETL_UNIT_ID    INDEX     e   CREATE INDEX "IX_INV_GOODS_REC_DETL_UNIT_ID" ON public."INV_GOODS_REC_DETL" USING btree ("UNIT_ID");
 3   DROP INDEX public."IX_INV_GOODS_REC_DETL_UNIT_ID";
       public            postgres    false    476            ^           1259    79085    IX_INV_GOODS_REC_MAST_ACCEPT_BY    INDEX     i   CREATE INDEX "IX_INV_GOODS_REC_MAST_ACCEPT_BY" ON public."INV_GOODS_REC_MAST" USING btree ("ACCEPT_BY");
 5   DROP INDEX public."IX_INV_GOODS_REC_MAST_ACCEPT_BY";
       public            postgres    false    453            _           1259    79086    IX_INV_GOODS_REC_MAST_CHECK_BY    INDEX     g   CREATE INDEX "IX_INV_GOODS_REC_MAST_CHECK_BY" ON public."INV_GOODS_REC_MAST" USING btree ("CHECK_BY");
 4   DROP INDEX public."IX_INV_GOODS_REC_MAST_CHECK_BY";
       public            postgres    false    453            `           1259    79087    IX_INV_GOODS_REC_MAST_PREP_BY    INDEX     e   CREATE INDEX "IX_INV_GOODS_REC_MAST_PREP_BY" ON public."INV_GOODS_REC_MAST" USING btree ("PREP_BY");
 3   DROP INDEX public."IX_INV_GOODS_REC_MAST_PREP_BY";
       public            postgres    false    453            �           1259    79088    IX_INV_ISSUE_DETAIL_BRAND_ID    INDEX     c   CREATE INDEX "IX_INV_ISSUE_DETAIL_BRAND_ID" ON public."INV_ISSUE_DETAIL" USING btree ("BRAND_ID");
 2   DROP INDEX public."IX_INV_ISSUE_DETAIL_BRAND_ID";
       public            postgres    false    428            �           1259    79089    IX_INV_ISSUE_DETAIL_ITEM_ID    INDEX     a   CREATE INDEX "IX_INV_ISSUE_DETAIL_ITEM_ID" ON public."INV_ISSUE_DETAIL" USING btree ("ITEM_ID");
 1   DROP INDEX public."IX_INV_ISSUE_DETAIL_ITEM_ID";
       public            postgres    false    428            �           1259    79090    IX_INV_ISSUE_DETAIL_ITEM_TYPE    INDEX     e   CREATE INDEX "IX_INV_ISSUE_DETAIL_ITEM_TYPE" ON public."INV_ISSUE_DETAIL" USING btree ("ITEM_TYPE");
 3   DROP INDEX public."IX_INV_ISSUE_DETAIL_ITEM_TYPE";
       public            postgres    false    428            �           1259    79091    IX_INV_ISSUE_DETAIL_SPEC_ID    INDEX     a   CREATE INDEX "IX_INV_ISSUE_DETAIL_SPEC_ID" ON public."INV_ISSUE_DETAIL" USING btree ("SPEC_ID");
 1   DROP INDEX public."IX_INV_ISSUE_DETAIL_SPEC_ID";
       public            postgres    false    428            �           1259    79092    IX_INV_ISSUE_MASTER_ACCEPT_BY    INDEX     e   CREATE INDEX "IX_INV_ISSUE_MASTER_ACCEPT_BY" ON public."INV_ISSUE_MASTER" USING btree ("ACCEPT_BY");
 3   DROP INDEX public."IX_INV_ISSUE_MASTER_ACCEPT_BY";
       public            postgres    false    479            �           1259    79093    IX_INV_ISSUE_MASTER_CHECK_BY    INDEX     c   CREATE INDEX "IX_INV_ISSUE_MASTER_CHECK_BY" ON public."INV_ISSUE_MASTER" USING btree ("CHECK_BY");
 2   DROP INDEX public."IX_INV_ISSUE_MASTER_CHECK_BY";
       public            postgres    false    479            �           1259    79094    IX_INV_ISSUE_MASTER_ISSUE_BY    INDEX     c   CREATE INDEX "IX_INV_ISSUE_MASTER_ISSUE_BY" ON public."INV_ISSUE_MASTER" USING btree ("ISSUE_BY");
 2   DROP INDEX public."IX_INV_ISSUE_MASTER_ISSUE_BY";
       public            postgres    false    479            �           1259    79095    IX_INV_ISSUE_MASTER_PREP_BY    INDEX     a   CREATE INDEX "IX_INV_ISSUE_MASTER_PREP_BY" ON public."INV_ISSUE_MASTER" USING btree ("PREP_BY");
 1   DROP INDEX public."IX_INV_ISSUE_MASTER_PREP_BY";
       public            postgres    false    479            �           1259    79096    IX_INV_ISSUE_MASTER_REQUEST_ID    INDEX     g   CREATE INDEX "IX_INV_ISSUE_MASTER_REQUEST_ID" ON public."INV_ISSUE_MASTER" USING btree ("REQUEST_ID");
 4   DROP INDEX public."IX_INV_ISSUE_MASTER_REQUEST_ID";
       public            postgres    false    479            �           1259    79097    IX_INV_ITEM_DETAILS_ACCEPT_BY    INDEX     e   CREATE INDEX "IX_INV_ITEM_DETAILS_ACCEPT_BY" ON public."INV_ITEM_DETAILS" USING btree ("ACCEPT_BY");
 3   DROP INDEX public."IX_INV_ITEM_DETAILS_ACCEPT_BY";
       public            postgres    false    477            �           1259    79098    IX_INV_ITEM_DETAILS_BRAND_ID    INDEX     c   CREATE INDEX "IX_INV_ITEM_DETAILS_BRAND_ID" ON public."INV_ITEM_DETAILS" USING btree ("BRAND_ID");
 2   DROP INDEX public."IX_INV_ITEM_DETAILS_BRAND_ID";
       public            postgres    false    477            �           1259    79099    IX_INV_ITEM_DETAILS_CHECK_BY    INDEX     c   CREATE INDEX "IX_INV_ITEM_DETAILS_CHECK_BY" ON public."INV_ITEM_DETAILS" USING btree ("CHECK_BY");
 2   DROP INDEX public."IX_INV_ITEM_DETAILS_CHECK_BY";
       public            postgres    false    477            �           1259    79100    IX_INV_ITEM_DETAILS_DAKHILA_ID    INDEX     g   CREATE INDEX "IX_INV_ITEM_DETAILS_DAKHILA_ID" ON public."INV_ITEM_DETAILS" USING btree ("DAKHILA_ID");
 4   DROP INDEX public."IX_INV_ITEM_DETAILS_DAKHILA_ID";
       public            postgres    false    477            �           1259    79101    IX_INV_ITEM_DETAILS_GD_ADJ_ID    INDEX     e   CREATE INDEX "IX_INV_ITEM_DETAILS_GD_ADJ_ID" ON public."INV_ITEM_DETAILS" USING btree ("GD_ADJ_ID");
 3   DROP INDEX public."IX_INV_ITEM_DETAILS_GD_ADJ_ID";
       public            postgres    false    477            �           1259    79102    IX_INV_ITEM_DETAILS_ITEM_ID    INDEX     a   CREATE INDEX "IX_INV_ITEM_DETAILS_ITEM_ID" ON public."INV_ITEM_DETAILS" USING btree ("ITEM_ID");
 1   DROP INDEX public."IX_INV_ITEM_DETAILS_ITEM_ID";
       public            postgres    false    477            �           1259    79103    IX_INV_ITEM_DETAILS_PREP_BY    INDEX     a   CREATE INDEX "IX_INV_ITEM_DETAILS_PREP_BY" ON public."INV_ITEM_DETAILS" USING btree ("PREP_BY");
 1   DROP INDEX public."IX_INV_ITEM_DETAILS_PREP_BY";
       public            postgres    false    477            �           1259    79104    IX_INV_ITEM_DETAILS_SPEC_ID    INDEX     a   CREATE INDEX "IX_INV_ITEM_DETAILS_SPEC_ID" ON public."INV_ITEM_DETAILS" USING btree ("SPEC_ID");
 1   DROP INDEX public."IX_INV_ITEM_DETAILS_SPEC_ID";
       public            postgres    false    477            `           1259    79105    IX_INV_ITEM_MST_UNIT_ID    INDEX     Y   CREATE INDEX "IX_INV_ITEM_MST_UNIT_ID" ON public."INV_ITEM_MST" USING btree ("UNIT_ID");
 -   DROP INDEX public."IX_INV_ITEM_MST_UNIT_ID";
       public            postgres    false    388            c           1259    79106 #   IX_INV_ITEM_STATUSCHECK_ACCEPTED_BY    INDEX     q   CREATE INDEX "IX_INV_ITEM_STATUSCHECK_ACCEPTED_BY" ON public."INV_ITEM_STATUSCHECK" USING btree ("ACCEPTED_BY");
 9   DROP INDEX public."IX_INV_ITEM_STATUSCHECK_ACCEPTED_BY";
       public            postgres    false    454            d           1259    79107     IX_INV_ITEM_STATUSCHECK_BRAND_ID    INDEX     k   CREATE INDEX "IX_INV_ITEM_STATUSCHECK_BRAND_ID" ON public."INV_ITEM_STATUSCHECK" USING btree ("BRAND_ID");
 6   DROP INDEX public."IX_INV_ITEM_STATUSCHECK_BRAND_ID";
       public            postgres    false    454            e           1259    79108    IX_INV_ITEM_STATUSCHECK_ITEM_ID    INDEX     i   CREATE INDEX "IX_INV_ITEM_STATUSCHECK_ITEM_ID" ON public."INV_ITEM_STATUSCHECK" USING btree ("ITEM_ID");
 5   DROP INDEX public."IX_INV_ITEM_STATUSCHECK_ITEM_ID";
       public            postgres    false    454            f           1259    79109    IX_INV_ITEM_STATUSCHECK_PREP_BY    INDEX     i   CREATE INDEX "IX_INV_ITEM_STATUSCHECK_PREP_BY" ON public."INV_ITEM_STATUSCHECK" USING btree ("PREP_BY");
 5   DROP INDEX public."IX_INV_ITEM_STATUSCHECK_PREP_BY";
       public            postgres    false    454            g           1259    79110    IX_INV_ITEM_STATUSCHECK_SPEC_ID    INDEX     i   CREATE INDEX "IX_INV_ITEM_STATUSCHECK_SPEC_ID" ON public."INV_ITEM_STATUSCHECK" USING btree ("SPEC_ID");
 5   DROP INDEX public."IX_INV_ITEM_STATUSCHECK_SPEC_ID";
       public            postgres    false    454            h           1259    79111     IX_INV_ITEM_STATUSCHECK_TALLY_BY    INDEX     k   CREATE INDEX "IX_INV_ITEM_STATUSCHECK_TALLY_BY" ON public."INV_ITEM_STATUSCHECK" USING btree ("TALLY_BY");
 6   DROP INDEX public."IX_INV_ITEM_STATUSCHECK_TALLY_BY";
       public            postgres    false    454            [           1259    79112 #   IX_INV_LILAMAPPDETAILS_LILAMAPPLIID    INDEX     q   CREATE INDEX "IX_INV_LILAMAPPDETAILS_LILAMAPPLIID" ON public."INV_LILAMAPPDETAILS" USING btree ("LILAMAPPLIID");
 9   DROP INDEX public."IX_INV_LILAMAPPDETAILS_LILAMAPPLIID";
       public            postgres    false    387            �           1259    79113    IX_INV_PUR_ORDER_DETL_BRAND_ID    INDEX     g   CREATE INDEX "IX_INV_PUR_ORDER_DETL_BRAND_ID" ON public."INV_PUR_ORDER_DETL" USING btree ("BRAND_ID");
 4   DROP INDEX public."IX_INV_PUR_ORDER_DETL_BRAND_ID";
       public            postgres    false    478            �           1259    79114    IX_INV_PUR_ORDER_DETL_ITEM_ID    INDEX     e   CREATE INDEX "IX_INV_PUR_ORDER_DETL_ITEM_ID" ON public."INV_PUR_ORDER_DETL" USING btree ("ITEM_ID");
 3   DROP INDEX public."IX_INV_PUR_ORDER_DETL_ITEM_ID";
       public            postgres    false    478            �           1259    79115    IX_INV_PUR_ORDER_DETL_ITEM_TYPE    INDEX     i   CREATE INDEX "IX_INV_PUR_ORDER_DETL_ITEM_TYPE" ON public."INV_PUR_ORDER_DETL" USING btree ("ITEM_TYPE");
 5   DROP INDEX public."IX_INV_PUR_ORDER_DETL_ITEM_TYPE";
       public            postgres    false    478            �           1259    79116     IX_INV_PUR_ORDER_DETL_PUR_MST_ID    INDEX     k   CREATE INDEX "IX_INV_PUR_ORDER_DETL_PUR_MST_ID" ON public."INV_PUR_ORDER_DETL" USING btree ("PUR_MST_ID");
 6   DROP INDEX public."IX_INV_PUR_ORDER_DETL_PUR_MST_ID";
       public            postgres    false    478            �           1259    79117    IX_INV_PUR_ORDER_DETL_SPEC_ID    INDEX     e   CREATE INDEX "IX_INV_PUR_ORDER_DETL_SPEC_ID" ON public."INV_PUR_ORDER_DETL" USING btree ("SPEC_ID");
 3   DROP INDEX public."IX_INV_PUR_ORDER_DETL_SPEC_ID";
       public            postgres    false    478            �           1259    79118    IX_INV_PUR_ORDER_DETL_UNIT_ID    INDEX     e   CREATE INDEX "IX_INV_PUR_ORDER_DETL_UNIT_ID" ON public."INV_PUR_ORDER_DETL" USING btree ("UNIT_ID");
 3   DROP INDEX public."IX_INV_PUR_ORDER_DETL_UNIT_ID";
       public            postgres    false    478            k           1259    79119 !   IX_INV_PUR_ORDER_MAST_ACCEPTED_BY    INDEX     m   CREATE INDEX "IX_INV_PUR_ORDER_MAST_ACCEPTED_BY" ON public."INV_PUR_ORDER_MAST" USING btree ("ACCEPTED_BY");
 7   DROP INDEX public."IX_INV_PUR_ORDER_MAST_ACCEPTED_BY";
       public            postgres    false    455            l           1259    79120     IX_INV_PUR_ORDER_MAST_CHECKED_BY    INDEX     k   CREATE INDEX "IX_INV_PUR_ORDER_MAST_CHECKED_BY" ON public."INV_PUR_ORDER_MAST" USING btree ("CHECKED_BY");
 6   DROP INDEX public."IX_INV_PUR_ORDER_MAST_CHECKED_BY";
       public            postgres    false    455            m           1259    79121 !   IX_INV_PUR_ORDER_MAST_PREPARED_BY    INDEX     m   CREATE INDEX "IX_INV_PUR_ORDER_MAST_PREPARED_BY" ON public."INV_PUR_ORDER_MAST" USING btree ("PREPARED_BY");
 7   DROP INDEX public."IX_INV_PUR_ORDER_MAST_PREPARED_BY";
       public            postgres    false    455            n           1259    79122    IX_INV_PUR_ORDER_MAST_SUPP_ID    INDEX     e   CREATE INDEX "IX_INV_PUR_ORDER_MAST_SUPP_ID" ON public."INV_PUR_ORDER_MAST" USING btree ("SUPP_ID");
 3   DROP INDEX public."IX_INV_PUR_ORDER_MAST_SUPP_ID";
       public            postgres    false    455            q           1259    79127 !   IX_INV_REQUISITION_MAST_ACCEPT_BY    INDEX     m   CREATE INDEX "IX_INV_REQUISITION_MAST_ACCEPT_BY" ON public."INV_REQUISITION_MAST" USING btree ("ACCEPT_BY");
 7   DROP INDEX public."IX_INV_REQUISITION_MAST_ACCEPT_BY";
       public            postgres    false    456            r           1259    79128     IX_INV_REQUISITION_MAST_CHECK_BY    INDEX     k   CREATE INDEX "IX_INV_REQUISITION_MAST_CHECK_BY" ON public."INV_REQUISITION_MAST" USING btree ("CHECK_BY");
 6   DROP INDEX public."IX_INV_REQUISITION_MAST_CHECK_BY";
       public            postgres    false    456            s           1259    79129    IX_INV_REQUISITION_MAST_ITEM_ID    INDEX     i   CREATE INDEX "IX_INV_REQUISITION_MAST_ITEM_ID" ON public."INV_REQUISITION_MAST" USING btree ("ITEM_ID");
 5   DROP INDEX public."IX_INV_REQUISITION_MAST_ITEM_ID";
       public            postgres    false    456            t           1259    79130    IX_INV_REQUISITION_MAST_PREP_BY    INDEX     i   CREATE INDEX "IX_INV_REQUISITION_MAST_PREP_BY" ON public."INV_REQUISITION_MAST" USING btree ("PREP_BY");
 5   DROP INDEX public."IX_INV_REQUISITION_MAST_PREP_BY";
       public            postgres    false    456            u           1259    79131    IX_INV_REQUISITION_MAST_PROJ_ID    INDEX     i   CREATE INDEX "IX_INV_REQUISITION_MAST_PROJ_ID" ON public."INV_REQUISITION_MAST" USING btree ("PROJ_ID");
 5   DROP INDEX public."IX_INV_REQUISITION_MAST_PROJ_ID";
       public            postgres    false    456            v           1259    79132    IX_INV_REQUISITION_MAST_REQ_BY    INDEX     g   CREATE INDEX "IX_INV_REQUISITION_MAST_REQ_BY" ON public."INV_REQUISITION_MAST" USING btree ("REQ_BY");
 4   DROP INDEX public."IX_INV_REQUISITION_MAST_REQ_BY";
       public            postgres    false    456            �           1259    79123    IX_INV_REQ_DETAIL_BRAND_ID    INDEX     _   CREATE INDEX "IX_INV_REQ_DETAIL_BRAND_ID" ON public."INV_REQ_DETAIL" USING btree ("BRAND_ID");
 0   DROP INDEX public."IX_INV_REQ_DETAIL_BRAND_ID";
       public            postgres    false    480            �           1259    79124    IX_INV_REQ_DETAIL_ITEM_ID    INDEX     ]   CREATE INDEX "IX_INV_REQ_DETAIL_ITEM_ID" ON public."INV_REQ_DETAIL" USING btree ("ITEM_ID");
 /   DROP INDEX public."IX_INV_REQ_DETAIL_ITEM_ID";
       public            postgres    false    480            �           1259    79125    IX_INV_REQ_DETAIL_REQ_MAST_ID    INDEX     e   CREATE INDEX "IX_INV_REQ_DETAIL_REQ_MAST_ID" ON public."INV_REQ_DETAIL" USING btree ("REQ_MAST_ID");
 3   DROP INDEX public."IX_INV_REQ_DETAIL_REQ_MAST_ID";
       public            postgres    false    480            �           1259    79126    IX_INV_REQ_DETAIL_SPEC_ID    INDEX     ]   CREATE INDEX "IX_INV_REQ_DETAIL_SPEC_ID" ON public."INV_REQ_DETAIL" USING btree ("SPEC_ID");
 /   DROP INDEX public."IX_INV_REQ_DETAIL_SPEC_ID";
       public            postgres    false    480            Z           1259    79133    IX_INV_ROOM_MST_DEPT_ID    INDEX     Y   CREATE INDEX "IX_INV_ROOM_MST_DEPT_ID" ON public."INV_ROOM_MST" USING btree ("DEPT_ID");
 -   DROP INDEX public."IX_INV_ROOM_MST_DEPT_ID";
       public            postgres    false    386            y           1259    79134    IX_INV_STATUS_DETAIL_ACCEPTBY    INDEX     e   CREATE INDEX "IX_INV_STATUS_DETAIL_ACCEPTBY" ON public."INV_STATUS_DETAIL" USING btree ("ACCEPTBY");
 3   DROP INDEX public."IX_INV_STATUS_DETAIL_ACCEPTBY";
       public            postgres    false    457            z           1259    79135    IX_INV_STATUS_DETAIL_CHECKEDBY    INDEX     g   CREATE INDEX "IX_INV_STATUS_DETAIL_CHECKEDBY" ON public."INV_STATUS_DETAIL" USING btree ("CHECKEDBY");
 4   DROP INDEX public."IX_INV_STATUS_DETAIL_CHECKEDBY";
       public            postgres    false    457            {           1259    79136    IX_INV_STATUS_DETAIL_PREBY    INDEX     _   CREATE INDEX "IX_INV_STATUS_DETAIL_PREBY" ON public."INV_STATUS_DETAIL" USING btree ("PREBY");
 0   DROP INDEX public."IX_INV_STATUS_DETAIL_PREBY";
       public            postgres    false    457            a           1259    79137    IX_MAP_AREA_GND_COV_REGIONID    INDEX     c   CREATE INDEX "IX_MAP_AREA_GND_COV_REGIONID" ON public."MAP_AREA_GND_COV" USING btree ("REGIONID");
 2   DROP INDEX public."IX_MAP_AREA_GND_COV_REGIONID";
       public            postgres    false    389            �           1259    79138    IX_MAP_INCOME_TYPE_ACC_ID    INDEX     ]   CREATE INDEX "IX_MAP_INCOME_TYPE_ACC_ID" ON public."MAP_INCOME_TYPE" USING btree ("ACC_ID");
 /   DROP INDEX public."IX_MAP_INCOME_TYPE_ACC_ID";
       public            postgres    false    413            d           1259    79139    IX_MAP_REGION_FAR_REGIONID    INDEX     _   CREATE INDEX "IX_MAP_REGION_FAR_REGIONID" ON public."MAP_REGION_FAR" USING btree ("REGIONID");
 0   DROP INDEX public."IX_MAP_REGION_FAR_REGIONID";
       public            postgres    false    390            u           1259    79143    IX_ORGANIZATION_TREE_GEO_REGION    INDEX     i   CREATE INDEX "IX_ORGANIZATION_TREE_GEO_REGION" ON public."ORGANIZATION_TREE" USING btree ("GEO_REGION");
 5   DROP INDEX public."IX_ORGANIZATION_TREE_GEO_REGION";
       public            postgres    false    395            v           1259    79144    IX_ORGANIZATION_TREE_PARENT_ID    INDEX     g   CREATE INDEX "IX_ORGANIZATION_TREE_PARENT_ID" ON public."ORGANIZATION_TREE" USING btree ("PARENT_ID");
 4   DROP INDEX public."IX_ORGANIZATION_TREE_PARENT_ID";
       public            postgres    false    395            �           1259    79140 &   IX_ORG_BANK_ACCOUNT_BANK_ACCNT_TYPE_ID    INDEX     w   CREATE INDEX "IX_ORG_BANK_ACCOUNT_BANK_ACCNT_TYPE_ID" ON public."ORG_BANK_ACCOUNT" USING btree ("BANK_ACCNT_TYPE_ID");
 <   DROP INDEX public."IX_ORG_BANK_ACCOUNT_BANK_ACCNT_TYPE_ID";
       public            postgres    false    427            �           1259    79141    IX_ORG_BANK_ACCOUNT_BRANCH_ID    INDEX     e   CREATE INDEX "IX_ORG_BANK_ACCOUNT_BRANCH_ID" ON public."ORG_BANK_ACCOUNT" USING btree ("BRANCH_ID");
 3   DROP INDEX public."IX_ORG_BANK_ACCOUNT_BRANCH_ID";
       public            postgres    false    427            �           1259    79142    IX_ORG_BANK_ACCOUNT_ORG_ID    INDEX     _   CREATE INDEX "IX_ORG_BANK_ACCOUNT_ORG_ID" ON public."ORG_BANK_ACCOUNT" USING btree ("ORG_ID");
 0   DROP INDEX public."IX_ORG_BANK_ACCOUNT_ORG_ID";
       public            postgres    false    427            �           1259    79145    IX_PIS_AWARDS_LOCAL_POST_ID    INDEX     a   CREATE INDEX "IX_PIS_AWARDS_LOCAL_POST_ID" ON public."PIS_AWARDS" USING btree ("LOCAL_POST_ID");
 1   DROP INDEX public."IX_PIS_AWARDS_LOCAL_POST_ID";
       public            postgres    false    429            ~           1259    79146    IX_PIS_BANK_PAYROLL_BANK_ID    INDEX     a   CREATE INDEX "IX_PIS_BANK_PAYROLL_BANK_ID" ON public."PIS_BANK_PAYROLL" USING btree ("BANK_ID");
 1   DROP INDEX public."IX_PIS_BANK_PAYROLL_BANK_ID";
       public            postgres    false    458                       1259    79147    IX_PIS_BANK_PAYROLL_EMP_ID    INDEX     _   CREATE INDEX "IX_PIS_BANK_PAYROLL_EMP_ID" ON public."PIS_BANK_PAYROLL" USING btree ("EMP_ID");
 0   DROP INDEX public."IX_PIS_BANK_PAYROLL_EMP_ID";
       public            postgres    false    458            �           1259    79148    IX_PIS_DARBANDI_LOCAL_POST_ID    INDEX     e   CREATE INDEX "IX_PIS_DARBANDI_LOCAL_POST_ID" ON public."PIS_DARBANDI" USING btree ("LOCAL_POST_ID");
 3   DROP INDEX public."IX_PIS_DARBANDI_LOCAL_POST_ID";
       public            postgres    false    430            �           1259    79149    IX_PIS_DARBANDI_OFFICE_ID    INDEX     ]   CREATE INDEX "IX_PIS_DARBANDI_OFFICE_ID" ON public."PIS_DARBANDI" USING btree ("OFFICE_ID");
 /   DROP INDEX public."IX_PIS_DARBANDI_OFFICE_ID";
       public            postgres    false    430            �           1259    79150    IX_PIS_DARBANDI_POST_ID    INDEX     Y   CREATE INDEX "IX_PIS_DARBANDI_POST_ID" ON public."PIS_DARBANDI" USING btree ("POST_ID");
 -   DROP INDEX public."IX_PIS_DARBANDI_POST_ID";
       public            postgres    false    430            �           1259    79151 .   IX_PIS_DELETD_FRM_FULFILD_DARB_FRM_DARBANDI_ID    INDEX     �   CREATE INDEX "IX_PIS_DELETD_FRM_FULFILD_DARB_FRM_DARBANDI_ID" ON public."PIS_DELETD_FRM_FULFILD_DARB" USING btree ("FRM_DARBANDI_ID");
 D   DROP INDEX public."IX_PIS_DELETD_FRM_FULFILD_DARB_FRM_DARBANDI_ID";
       public            postgres    false    474            �           1259    79152 ,   IX_PIS_DELETD_FRM_FULFILD_DARB_FRM_OFFICE_ID    INDEX     �   CREATE INDEX "IX_PIS_DELETD_FRM_FULFILD_DARB_FRM_OFFICE_ID" ON public."PIS_DELETD_FRM_FULFILD_DARB" USING btree ("FRM_OFFICE_ID");
 B   DROP INDEX public."IX_PIS_DELETD_FRM_FULFILD_DARB_FRM_OFFICE_ID";
       public            postgres    false    474            �           1259    79153 +   IX_PIS_DELETD_FRM_FULFILD_DARB_FRM_SN_IN_FD    INDEX     �   CREATE INDEX "IX_PIS_DELETD_FRM_FULFILD_DARB_FRM_SN_IN_FD" ON public."PIS_DELETD_FRM_FULFILD_DARB" USING btree ("FRM_SN_IN_FD");
 A   DROP INDEX public."IX_PIS_DELETD_FRM_FULFILD_DARB_FRM_SN_IN_FD";
       public            postgres    false    474            �           1259    79154 *   IX_PIS_DELETD_FRM_FULFILD_DARB_TO_SN_IN_FD    INDEX        CREATE INDEX "IX_PIS_DELETD_FRM_FULFILD_DARB_TO_SN_IN_FD" ON public."PIS_DELETD_FRM_FULFILD_DARB" USING btree ("TO_SN_IN_FD");
 @   DROP INDEX public."IX_PIS_DELETD_FRM_FULFILD_DARB_TO_SN_IN_FD";
       public            postgres    false    474            n           1259    79155    IX_PIS_EDUCATION_BOARD_ID    INDEX     ]   CREATE INDEX "IX_PIS_EDUCATION_BOARD_ID" ON public."PIS_EDUCATION" USING btree ("BOARD_ID");
 /   DROP INDEX public."IX_PIS_EDUCATION_BOARD_ID";
       public            postgres    false    393            o           1259    79156    IX_PIS_EDUCATION_EDU_LEVEL_ID    INDEX     e   CREATE INDEX "IX_PIS_EDUCATION_EDU_LEVEL_ID" ON public."PIS_EDUCATION" USING btree ("EDU_LEVEL_ID");
 3   DROP INDEX public."IX_PIS_EDUCATION_EDU_LEVEL_ID";
       public            postgres    false    393            �           1259    79172    IX_PIS_EMPLOYEE_MASTER_DEPT_ID    INDEX     g   CREATE INDEX "IX_PIS_EMPLOYEE_MASTER_DEPT_ID" ON public."PIS_EMPLOYEE_MASTER" USING btree ("DEPT_ID");
 4   DROP INDEX public."IX_PIS_EMPLOYEE_MASTER_DEPT_ID";
       public            postgres    false    431                        1259    79173 ,   IX_PIS_EMPLOYEE_MASTER_FIRST_APPOINT_POST_ID    INDEX     �   CREATE INDEX "IX_PIS_EMPLOYEE_MASTER_FIRST_APPOINT_POST_ID" ON public."PIS_EMPLOYEE_MASTER" USING btree ("FIRST_APPOINT_POST_ID");
 B   DROP INDEX public."IX_PIS_EMPLOYEE_MASTER_FIRST_APPOINT_POST_ID";
       public            postgres    false    431                       1259    79174 $   IX_PIS_EMPLOYEE_MASTER_LOCAL_POST_ID    INDEX     s   CREATE INDEX "IX_PIS_EMPLOYEE_MASTER_LOCAL_POST_ID" ON public."PIS_EMPLOYEE_MASTER" USING btree ("LOCAL_POST_ID");
 :   DROP INDEX public."IX_PIS_EMPLOYEE_MASTER_LOCAL_POST_ID";
       public            postgres    false    431                       1259    79175 '   IX_PIS_EMPLOYEE_MASTER_PAYEMENT_BANK_ID    INDEX     y   CREATE INDEX "IX_PIS_EMPLOYEE_MASTER_PAYEMENT_BANK_ID" ON public."PIS_EMPLOYEE_MASTER" USING btree ("PAYEMENT_BANK_ID");
 =   DROP INDEX public."IX_PIS_EMPLOYEE_MASTER_PAYEMENT_BANK_ID";
       public            postgres    false    431                       1259    79176    IX_PIS_EMPLOYEE_MASTER_POST_ID    INDEX     g   CREATE INDEX "IX_PIS_EMPLOYEE_MASTER_POST_ID" ON public."PIS_EMPLOYEE_MASTER" USING btree ("POST_ID");
 4   DROP INDEX public."IX_PIS_EMPLOYEE_MASTER_POST_ID";
       public            postgres    false    431            �           1259    79157    IX_PIS_EMP_ADV_DED_DTL_EMP_ID    INDEX     e   CREATE INDEX "IX_PIS_EMP_ADV_DED_DTL_EMP_ID" ON public."PIS_EMP_ADV_DED_DTL" USING btree ("EMP_ID");
 3   DROP INDEX public."IX_PIS_EMP_ADV_DED_DTL_EMP_ID";
       public            postgres    false    459            r           1259    79158 &   IX_PIS_EMP_DEP_SOURCE_BUDJET_SOURCE_ID    INDEX     w   CREATE INDEX "IX_PIS_EMP_DEP_SOURCE_BUDJET_SOURCE_ID" ON public."PIS_EMP_DEP_SOURCE" USING btree ("BUDJET_SOURCE_ID");
 <   DROP INDEX public."IX_PIS_EMP_DEP_SOURCE_BUDJET_SOURCE_ID";
       public            postgres    false    394            �           1259    79159    IX_PIS_EMP_LOANS_EMP_ID    INDEX     Y   CREATE INDEX "IX_PIS_EMP_LOANS_EMP_ID" ON public."PIS_EMP_LOANS" USING btree ("EMP_ID");
 -   DROP INDEX public."IX_PIS_EMP_LOANS_EMP_ID";
       public            postgres    false    460            �           1259    79160    IX_PIS_EMP_LONG_LEAVES_EMP_ID    INDEX     e   CREATE INDEX "IX_PIS_EMP_LONG_LEAVES_EMP_ID" ON public."PIS_EMP_LONG_LEAVES" USING btree ("EMP_ID");
 3   DROP INDEX public."IX_PIS_EMP_LONG_LEAVES_EMP_ID";
       public            postgres    false    461            �           1259    79161 $   IX_PIS_EMP_LONG_LEAVES_LOCAL_POST_ID    INDEX     s   CREATE INDEX "IX_PIS_EMP_LONG_LEAVES_LOCAL_POST_ID" ON public."PIS_EMP_LONG_LEAVES" USING btree ("LOCAL_POST_ID");
 :   DROP INDEX public."IX_PIS_EMP_LONG_LEAVES_LOCAL_POST_ID";
       public            postgres    false    461            �           1259    79162    IX_PIS_EMP_MED_EXPENSE_EMP_ID    INDEX     e   CREATE INDEX "IX_PIS_EMP_MED_EXPENSE_EMP_ID" ON public."PIS_EMP_MED_EXPENSE" USING btree ("EMP_ID");
 3   DROP INDEX public."IX_PIS_EMP_MED_EXPENSE_EMP_ID";
       public            postgres    false    462            �           1259    79163 $   IX_PIS_EMP_MED_EXPENSE_LOCAL_POST_ID    INDEX     s   CREATE INDEX "IX_PIS_EMP_MED_EXPENSE_LOCAL_POST_ID" ON public."PIS_EMP_MED_EXPENSE" USING btree ("LOCAL_POST_ID");
 :   DROP INDEX public."IX_PIS_EMP_MED_EXPENSE_LOCAL_POST_ID";
       public            postgres    false    462            �           1259    79164    IX_PIS_EMP_PUNISHMNTS_EMP_ID    INDEX     c   CREATE INDEX "IX_PIS_EMP_PUNISHMNTS_EMP_ID" ON public."PIS_EMP_PUNISHMNTS" USING btree ("EMP_ID");
 2   DROP INDEX public."IX_PIS_EMP_PUNISHMNTS_EMP_ID";
       public            postgres    false    463            �           1259    79165 #   IX_PIS_EMP_PUNISHMNTS_LOCAL_POST_ID    INDEX     q   CREATE INDEX "IX_PIS_EMP_PUNISHMNTS_LOCAL_POST_ID" ON public."PIS_EMP_PUNISHMNTS" USING btree ("LOCAL_POST_ID");
 9   DROP INDEX public."IX_PIS_EMP_PUNISHMNTS_LOCAL_POST_ID";
       public            postgres    false    463            �           1259    79166    IX_PIS_EMP_SRVC_DTLS_EMP_ID    INDEX     a   CREATE INDEX "IX_PIS_EMP_SRVC_DTLS_EMP_ID" ON public."PIS_EMP_SRVC_DTLS" USING btree ("EMP_ID");
 1   DROP INDEX public."IX_PIS_EMP_SRVC_DTLS_EMP_ID";
       public            postgres    false    464            �           1259    79167 "   IX_PIS_EMP_SRVC_DTLS_LOCAL_POST_ID    INDEX     o   CREATE INDEX "IX_PIS_EMP_SRVC_DTLS_LOCAL_POST_ID" ON public."PIS_EMP_SRVC_DTLS" USING btree ("LOCAL_POST_ID");
 8   DROP INDEX public."IX_PIS_EMP_SRVC_DTLS_LOCAL_POST_ID";
       public            postgres    false    464            �           1259    79168    IX_PIS_EMP_SUSPENDS_EMP_ID    INDEX     _   CREATE INDEX "IX_PIS_EMP_SUSPENDS_EMP_ID" ON public."PIS_EMP_SUSPENDS" USING btree ("EMP_ID");
 0   DROP INDEX public."IX_PIS_EMP_SUSPENDS_EMP_ID";
       public            postgres    false    465            �           1259    79169 !   IX_PIS_EMP_SUSPENDS_LOCAL_POST_ID    INDEX     m   CREATE INDEX "IX_PIS_EMP_SUSPENDS_LOCAL_POST_ID" ON public."PIS_EMP_SUSPENDS" USING btree ("LOCAL_POST_ID");
 7   DROP INDEX public."IX_PIS_EMP_SUSPENDS_LOCAL_POST_ID";
       public            postgres    false    465            �           1259    79170    IX_PIS_EMP_TRNSFR_REC_EMP_ID    INDEX     c   CREATE INDEX "IX_PIS_EMP_TRNSFR_REC_EMP_ID" ON public."PIS_EMP_TRNSFR_REC" USING btree ("EMP_ID");
 2   DROP INDEX public."IX_PIS_EMP_TRNSFR_REC_EMP_ID";
       public            postgres    false    466            �           1259    79171 #   IX_PIS_EMP_TRNSFR_REC_LOCAL_POST_ID    INDEX     q   CREATE INDEX "IX_PIS_EMP_TRNSFR_REC_LOCAL_POST_ID" ON public."PIS_EMP_TRNSFR_REC" USING btree ("LOCAL_POST_ID");
 9   DROP INDEX public."IX_PIS_EMP_TRNSFR_REC_LOCAL_POST_ID";
       public            postgres    false    466                       1259    79177 #   IX_PIS_FOREIGN_VISITS_LOCAL_POST_ID    INDEX     q   CREATE INDEX "IX_PIS_FOREIGN_VISITS_LOCAL_POST_ID" ON public."PIS_FOREIGN_VISITS" USING btree ("LOCAL_POST_ID");
 9   DROP INDEX public."IX_PIS_FOREIGN_VISITS_LOCAL_POST_ID";
       public            postgres    false    432            R           1259    79178 %   IX_PIS_FULFILLED_DARBANDI_DARBANDI_ID    INDEX     u   CREATE INDEX "IX_PIS_FULFILLED_DARBANDI_DARBANDI_ID" ON public."PIS_FULFILLED_DARBANDI" USING btree ("DARBANDI_ID");
 ;   DROP INDEX public."IX_PIS_FULFILLED_DARBANDI_DARBANDI_ID";
       public            postgres    false    451            S           1259    79179 '   IX_PIS_FULFILLED_DARBANDI_LOCAL_POST_ID    INDEX     y   CREATE INDEX "IX_PIS_FULFILLED_DARBANDI_LOCAL_POST_ID" ON public."PIS_FULFILLED_DARBANDI" USING btree ("LOCAL_POST_ID");
 =   DROP INDEX public."IX_PIS_FULFILLED_DARBANDI_LOCAL_POST_ID";
       public            postgres    false    451            T           1259    79180 #   IX_PIS_FULFILLED_DARBANDI_OFFICE_ID    INDEX     q   CREATE INDEX "IX_PIS_FULFILLED_DARBANDI_OFFICE_ID" ON public."PIS_FULFILLED_DARBANDI" USING btree ("OFFICE_ID");
 9   DROP INDEX public."IX_PIS_FULFILLED_DARBANDI_OFFICE_ID";
       public            postgres    false    451            �           1259    79181 (   IX_PIS_INTERNAL_TRANSFER_APPOINTMNT_TYPE    INDEX     {   CREATE INDEX "IX_PIS_INTERNAL_TRANSFER_APPOINTMNT_TYPE" ON public."PIS_INTERNAL_TRANSFER" USING btree ("APPOINTMNT_TYPE");
 >   DROP INDEX public."IX_PIS_INTERNAL_TRANSFER_APPOINTMNT_TYPE";
       public            postgres    false    467            �           1259    79182 $   IX_PIS_INTERNAL_TRANSFER_DARBANDI_ID    INDEX     s   CREATE INDEX "IX_PIS_INTERNAL_TRANSFER_DARBANDI_ID" ON public."PIS_INTERNAL_TRANSFER" USING btree ("DARBANDI_ID");
 :   DROP INDEX public."IX_PIS_INTERNAL_TRANSFER_DARBANDI_ID";
       public            postgres    false    467            �           1259    79183    IX_PIS_INTERNAL_TRANSFER_EMP_ID    INDEX     i   CREATE INDEX "IX_PIS_INTERNAL_TRANSFER_EMP_ID" ON public."PIS_INTERNAL_TRANSFER" USING btree ("EMP_ID");
 5   DROP INDEX public."IX_PIS_INTERNAL_TRANSFER_EMP_ID";
       public            postgres    false    467            �           1259    79184 "   IX_PIS_INTERNAL_TRANSFER_OFFICE_ID    INDEX     o   CREATE INDEX "IX_PIS_INTERNAL_TRANSFER_OFFICE_ID" ON public."PIS_INTERNAL_TRANSFER" USING btree ("OFFICE_ID");
 8   DROP INDEX public."IX_PIS_INTERNAL_TRANSFER_OFFICE_ID";
       public            postgres    false    467            �           1259    79185 +   IX_PIS_INTERNAL_TRANSFER_TO_APPOINTMNT_TYPE    INDEX     �   CREATE INDEX "IX_PIS_INTERNAL_TRANSFER_TO_APPOINTMNT_TYPE" ON public."PIS_INTERNAL_TRANSFER" USING btree ("TO_APPOINTMNT_TYPE");
 A   DROP INDEX public."IX_PIS_INTERNAL_TRANSFER_TO_APPOINTMNT_TYPE";
       public            postgres    false    467            �           1259    79186 )   IX_PIS_INTERNAL_TRANSFER_TO_LOCAL_POST_ID    INDEX     }   CREATE INDEX "IX_PIS_INTERNAL_TRANSFER_TO_LOCAL_POST_ID" ON public."PIS_INTERNAL_TRANSFER" USING btree ("TO_LOCAL_POST_ID");
 ?   DROP INDEX public."IX_PIS_INTERNAL_TRANSFER_TO_LOCAL_POST_ID";
       public            postgres    false    467            �           1259    79187 %   IX_PIS_INTERNAL_TRANSFER_TO_OFFICE_ID    INDEX     u   CREATE INDEX "IX_PIS_INTERNAL_TRANSFER_TO_OFFICE_ID" ON public."PIS_INTERNAL_TRANSFER" USING btree ("TO_OFFICE_ID");
 ;   DROP INDEX public."IX_PIS_INTERNAL_TRANSFER_TO_OFFICE_ID";
       public            postgres    false    467            y           1259    79188     IX_PIS_LOCAL_POST_MASTER_POST_ID    INDEX     k   CREATE INDEX "IX_PIS_LOCAL_POST_MASTER_POST_ID" ON public."PIS_LOCAL_POST_MASTER" USING btree ("POST_ID");
 6   DROP INDEX public."IX_PIS_LOCAL_POST_MASTER_POST_ID";
       public            postgres    false    396            �           1259    79189 %   IX_PIS_NIJAMATI_SEWA_SAMUHA_PARENT_ID    INDEX     u   CREATE INDEX "IX_PIS_NIJAMATI_SEWA_SAMUHA_PARENT_ID" ON public."PIS_NIJAMATI_SEWA_SAMUHA" USING btree ("PARENT_ID");
 ;   DROP INDEX public."IX_PIS_NIJAMATI_SEWA_SAMUHA_PARENT_ID";
       public            postgres    false    310            	           1259    79190 "   IX_PIS_OTHER_ADD_SUB_LOCAL_POST_ID    INDEX     o   CREATE INDEX "IX_PIS_OTHER_ADD_SUB_LOCAL_POST_ID" ON public."PIS_OTHER_ADD_SUB" USING btree ("LOCAL_POST_ID");
 8   DROP INDEX public."IX_PIS_OTHER_ADD_SUB_LOCAL_POST_ID";
       public            postgres    false    433                       1259    79191    IX_PIS_PRIZES_LOCAL_POST_ID    INDEX     a   CREATE INDEX "IX_PIS_PRIZES_LOCAL_POST_ID" ON public."PIS_PRIZES" USING btree ("LOCAL_POST_ID");
 1   DROP INDEX public."IX_PIS_PRIZES_LOCAL_POST_ID";
       public            postgres    false    434                       1259    79192     IX_PIS_PUBLICATION_LOCAL_POST_ID    INDEX     k   CREATE INDEX "IX_PIS_PUBLICATION_LOCAL_POST_ID" ON public."PIS_PUBLICATION" USING btree ("LOCAL_POST_ID");
 6   DROP INDEX public."IX_PIS_PUBLICATION_LOCAL_POST_ID";
       public            postgres    false    435            �           1259    79193    IX_PIS_PYROLL_LOAN_DTLS_ACC_ID    INDEX     g   CREATE INDEX "IX_PIS_PYROLL_LOAN_DTLS_ACC_ID" ON public."PIS_PYROLL_LOAN_DTLS" USING btree ("ACC_ID");
 4   DROP INDEX public."IX_PIS_PYROLL_LOAN_DTLS_ACC_ID";
       public            postgres    false    481            �           1259    79194    IX_PIS_PYROLL_LOAN_DTLS_EMP_ID    INDEX     g   CREATE INDEX "IX_PIS_PYROLL_LOAN_DTLS_EMP_ID" ON public."PIS_PYROLL_LOAN_DTLS" USING btree ("EMP_ID");
 4   DROP INDEX public."IX_PIS_PYROLL_LOAN_DTLS_EMP_ID";
       public            postgres    false    481            �           1259    79195     IX_PIS_PYROLL_LOAN_DTLS_LOAND_ID    INDEX     k   CREATE INDEX "IX_PIS_PYROLL_LOAN_DTLS_LOAND_ID" ON public."PIS_PYROLL_LOAN_DTLS" USING btree ("LOAND_ID");
 6   DROP INDEX public."IX_PIS_PYROLL_LOAN_DTLS_LOAND_ID";
       public            postgres    false    481            �           1259    79196 "   IX_PIS_PYROLL_LOAN_DTLS_PAYROLL_ID    INDEX     o   CREATE INDEX "IX_PIS_PYROLL_LOAN_DTLS_PAYROLL_ID" ON public."PIS_PYROLL_LOAN_DTLS" USING btree ("PAYROLL_ID");
 8   DROP INDEX public."IX_PIS_PYROLL_LOAN_DTLS_PAYROLL_ID";
       public            postgres    false    481            �           1259    79197 #   IX_PIS_PYROLL_OTHR_DTLS_EMPLOYEE_ID    INDEX     q   CREATE INDEX "IX_PIS_PYROLL_OTHR_DTLS_EMPLOYEE_ID" ON public."PIS_PYROLL_OTHR_DTLS" USING btree ("EMPLOYEE_ID");
 9   DROP INDEX public."IX_PIS_PYROLL_OTHR_DTLS_EMPLOYEE_ID";
       public            postgres    false    468            �           1259    79198 "   IX_PIS_PYROLL_OTHR_DTLS_PAYROLL_ID    INDEX     o   CREATE INDEX "IX_PIS_PYROLL_OTHR_DTLS_PAYROLL_ID" ON public."PIS_PYROLL_OTHR_DTLS" USING btree ("PAYROLL_ID");
 8   DROP INDEX public."IX_PIS_PYROLL_OTHR_DTLS_PAYROLL_ID";
       public            postgres    false    468            �           1259    79199 '   IX_PIS_REPLACED_IN_DARBANDI_DARBANDI_ID    INDEX     y   CREATE INDEX "IX_PIS_REPLACED_IN_DARBANDI_DARBANDI_ID" ON public."PIS_REPLACED_IN_DARBANDI" USING btree ("DARBANDI_ID");
 =   DROP INDEX public."IX_PIS_REPLACED_IN_DARBANDI_DARBANDI_ID";
       public            postgres    false    475            �           1259    79200 *   IX_PIS_REPLACED_IN_DARBANDI_ENTRY_SN_IN_FD    INDEX        CREATE INDEX "IX_PIS_REPLACED_IN_DARBANDI_ENTRY_SN_IN_FD" ON public."PIS_REPLACED_IN_DARBANDI" USING btree ("ENTRY_SN_IN_FD");
 @   DROP INDEX public."IX_PIS_REPLACED_IN_DARBANDI_ENTRY_SN_IN_FD";
       public            postgres    false    475            �           1259    79201 %   IX_PIS_REPLACED_IN_DARBANDI_OFFICE_ID    INDEX     u   CREATE INDEX "IX_PIS_REPLACED_IN_DARBANDI_OFFICE_ID" ON public."PIS_REPLACED_IN_DARBANDI" USING btree ("OFFICE_ID");
 ;   DROP INDEX public."IX_PIS_REPLACED_IN_DARBANDI_OFFICE_ID";
       public            postgres    false    475                       1259    79202 !   IX_PIS_SGNFCNT_WORK_LOCAL_POST_ID    INDEX     m   CREATE INDEX "IX_PIS_SGNFCNT_WORK_LOCAL_POST_ID" ON public."PIS_SGNFCNT_WORK" USING btree ("LOCAL_POST_ID");
 7   DROP INDEX public."IX_PIS_SGNFCNT_WORK_LOCAL_POST_ID";
       public            postgres    false    436                       1259    79203    IX_PIS_TRAINING_LOCAL_POST_ID    INDEX     e   CREATE INDEX "IX_PIS_TRAINING_LOCAL_POST_ID" ON public."PIS_TRAINING" USING btree ("LOCAL_POST_ID");
 3   DROP INDEX public."IX_PIS_TRAINING_LOCAL_POST_ID";
       public            postgres    false    437            �           1259    79204 !   IX_PIS_VISITED_COUNTRIES_VISIT_ID    INDEX     m   CREATE INDEX "IX_PIS_VISITED_COUNTRIES_VISIT_ID" ON public."PIS_VISITED_COUNTRIES" USING btree ("VISIT_ID");
 7   DROP INDEX public."IX_PIS_VISITED_COUNTRIES_VISIT_ID";
       public            postgres    false    470                       1259    79205    IX_PIS_WORKSHOP_LOCAL_POST_ID    INDEX     e   CREATE INDEX "IX_PIS_WORKSHOP_LOCAL_POST_ID" ON public."PIS_WORKSHOP" USING btree ("LOCAL_POST_ID");
 3   DROP INDEX public."IX_PIS_WORKSHOP_LOCAL_POST_ID";
       public            postgres    false    438                       1259    79206    IX_SANITATION_RATE_GROUPID    INDEX     _   CREATE INDEX "IX_SANITATION_RATE_GROUPID" ON public."SANITATION_RATE" USING btree ("GROUPID");
 0   DROP INDEX public."IX_SANITATION_RATE_GROUPID";
       public            postgres    false    439                       1259    79207    IX_SANITATION_RATE_SUBGROUPID    INDEX     e   CREATE INDEX "IX_SANITATION_RATE_SUBGROUPID" ON public."SANITATION_RATE" USING btree ("SUBGROUPID");
 3   DROP INDEX public."IX_SANITATION_RATE_SUBGROUPID";
       public            postgres    false    439            |           1259    79208    IX_SANITATION_SUBGROUP_GROUPID    INDEX     g   CREATE INDEX "IX_SANITATION_SUBGROUP_GROUPID" ON public."SANITATION_SUBGROUP" USING btree ("GROUPID");
 4   DROP INDEX public."IX_SANITATION_SUBGROUP_GROUPID";
       public            postgres    false    397            �           1259    79209    IX_SERVICE_CHARGE_MASTER_ACC_ID    INDEX     i   CREATE INDEX "IX_SERVICE_CHARGE_MASTER_ACC_ID" ON public."SERVICE_CHARGE_MASTER" USING btree ("ACC_ID");
 5   DROP INDEX public."IX_SERVICE_CHARGE_MASTER_ACC_ID";
       public            postgres    false    414            �           1259    79210    IX_STOREDBILLS_BILLTYPEID    INDEX     ]   CREATE INDEX "IX_STOREDBILLS_BILLTYPEID" ON public."STOREDBILLS" USING btree ("BILLTYPEID");
 /   DROP INDEX public."IX_STOREDBILLS_BILLTYPEID";
       public            postgres    false    401            Q           1259    79211 %   IX_SUB_MODULE_SOURCE_BUDJET_SOURCE_ID    INDEX     u   CREATE INDEX "IX_SUB_MODULE_SOURCE_BUDJET_SOURCE_ID" ON public."SUB_MODULE_SOURCE" USING btree ("BUDJET_SOURCE_ID");
 ;   DROP INDEX public."IX_SUB_MODULE_SOURCE_BUDJET_SOURCE_ID";
       public            postgres    false    383            R           1259    79212 "   IX_SUB_MODULE_SOURCE_SUB_MODULE_ID    INDEX     o   CREATE INDEX "IX_SUB_MODULE_SOURCE_SUB_MODULE_ID" ON public."SUB_MODULE_SOURCE" USING btree ("SUB_MODULE_ID");
 8   DROP INDEX public."IX_SUB_MODULE_SOURCE_SUB_MODULE_ID";
       public            postgres    false    383            �           1259    79214    IX_TAX_ADDTNL_CHRG_DTLS_ACCODE    INDEX     g   CREATE INDEX "IX_TAX_ADDTNL_CHRG_DTLS_ACCODE" ON public."TAX_ADDTNL_CHRG_DTLS" USING btree ("ACCODE");
 4   DROP INDEX public."IX_TAX_ADDTNL_CHRG_DTLS_ACCODE";
       public            postgres    false    415            �           1259    79213    IX_TAX_ADDTNL_CHRG_DTLS_ACC_ID    INDEX     g   CREATE INDEX "IX_TAX_ADDTNL_CHRG_DTLS_ACC_ID" ON public."TAX_ADDTNL_CHRG_DTLS" USING btree ("ACC_ID");
 4   DROP INDEX public."IX_TAX_ADDTNL_CHRG_DTLS_ACC_ID";
       public            postgres    false    415            &           1259    79215    IX_TAX_THLI_ISSUED_CNTR_CNTR_ID    INDEX     i   CREATE INDEX "IX_TAX_THLI_ISSUED_CNTR_CNTR_ID" ON public."TAX_THLI_ISSUED_CNTR" USING btree ("CNTR_ID");
 5   DROP INDEX public."IX_TAX_THLI_ISSUED_CNTR_CNTR_ID";
       public            postgres    false    442            '           1259    79216     IX_TAX_THLI_ISSUED_CNTR_THELI_ID    INDEX     k   CREATE INDEX "IX_TAX_THLI_ISSUED_CNTR_THELI_ID" ON public."TAX_THLI_ISSUED_CNTR" USING btree ("THELI_ID");
 6   DROP INDEX public."IX_TAX_THLI_ISSUED_CNTR_THELI_ID";
       public            postgres    false    442            �           1259    79232 $   IX_TBLBUSINESS_SERVICE_CH_MST_ACC_ID    INDEX     s   CREATE INDEX "IX_TBLBUSINESS_SERVICE_CH_MST_ACC_ID" ON public."TBLBUSINESS_SERVICE_CH_MST" USING btree ("ACC_ID");
 :   DROP INDEX public."IX_TBLBUSINESS_SERVICE_CH_MST_ACC_ID";
       public            postgres    false    418            �           1259    79233    IX_TBLFYWISEMPOTASSRATE_GROUPID    INDEX     i   CREATE INDEX "IX_TBLFYWISEMPOTASSRATE_GROUPID" ON public."TBLFYWISEMPOTASSRATE" USING btree ("GROUPID");
 5   DROP INDEX public."IX_TBLFYWISEMPOTASSRATE_GROUPID";
       public            postgres    false    472            �           1259    79234    IX_TBLFYWISEMPOTASSRATE_RATEID    INDEX     g   CREATE INDEX "IX_TBLFYWISEMPOTASSRATE_RATEID" ON public."TBLFYWISEMPOTASSRATE" USING btree ("RATEID");
 4   DROP INDEX public."IX_TBLFYWISEMPOTASSRATE_RATEID";
       public            postgres    false    472            �           1259    79235 "   IX_TBLFYWISEMPOTASSRATE_SUBGROUPID    INDEX     o   CREATE INDEX "IX_TBLFYWISEMPOTASSRATE_SUBGROUPID" ON public."TBLFYWISEMPOTASSRATE" USING btree ("SUBGROUPID");
 8   DROP INDEX public."IX_TBLFYWISEMPOTASSRATE_SUBGROUPID";
       public            postgres    false    472            *           1259    79236    IX_TBLMALPOTRATES_GROUPID    INDEX     ]   CREATE INDEX "IX_TBLMALPOTRATES_GROUPID" ON public."TBLMALPOTRATES" USING btree ("GROUPID");
 /   DROP INDEX public."IX_TBLMALPOTRATES_GROUPID";
       public            postgres    false    443            +           1259    79237    IX_TBLMALPOTRATES_SUBGROUPID    INDEX     c   CREATE INDEX "IX_TBLMALPOTRATES_SUBGROUPID" ON public."TBLMALPOTRATES" USING btree ("SUBGROUPID");
 2   DROP INDEX public."IX_TBLMALPOTRATES_SUBGROUPID";
       public            postgres    false    443            �           1259    79238    IX_TBLMALPOTSUBGROUP_GROUPID    INDEX     c   CREATE INDEX "IX_TBLMALPOTSUBGROUP_GROUPID" ON public."TBLMALPOTSUBGROUP" USING btree ("GROUPID");
 2   DROP INDEX public."IX_TBLMALPOTSUBGROUP_GROUPID";
       public            postgres    false    402            �           1259    79239    IX_TBLVEH_SER_CH_MSTR_ACC_ID    INDEX     c   CREATE INDEX "IX_TBLVEH_SER_CH_MSTR_ACC_ID" ON public."TBLVEH_SER_CH_MSTR" USING btree ("ACC_ID");
 2   DROP INDEX public."IX_TBLVEH_SER_CH_MSTR_ACC_ID";
       public            postgres    false    419                       1259    79217    IX_TBL_BGT_MGMT_EXP_BGT_MGMT_ID    INDEX     i   CREATE INDEX "IX_TBL_BGT_MGMT_EXP_BGT_MGMT_ID" ON public."TBL_BGT_MGMT_EXP" USING btree ("BGT_MGMT_ID");
 5   DROP INDEX public."IX_TBL_BGT_MGMT_EXP_BGT_MGMT_ID";
       public            postgres    false    398            �           1259    79218 '   IX_TBL_BGT_MGMT_EXP_ORG_BGT_MGMT_ORG_ID    INDEX     y   CREATE INDEX "IX_TBL_BGT_MGMT_EXP_ORG_BGT_MGMT_ORG_ID" ON public."TBL_BGT_MGMT_EXP_ORG" USING btree ("BGT_MGMT_ORG_ID");
 =   DROP INDEX public."IX_TBL_BGT_MGMT_EXP_ORG_BGT_MGMT_ORG_ID";
       public            postgres    false    399            .           1259    79219 /   IX_TBL_BGT_MGMT_EXP_RELEASE_BGT_MGMT_RELEASE_ID    INDEX     �   CREATE INDEX "IX_TBL_BGT_MGMT_EXP_RELEASE_BGT_MGMT_RELEASE_ID" ON public."TBL_BGT_MGMT_EXP_RELEASE" USING btree ("BGT_MGMT_RELEASE_ID");
 E   DROP INDEX public."IX_TBL_BGT_MGMT_EXP_RELEASE_BGT_MGMT_RELEASE_ID";
       public            postgres    false    444            �           1259    79220 &   IX_TBL_BGT_MGMT_RELEASE_BGT_RELEASE_ID    INDEX     w   CREATE INDEX "IX_TBL_BGT_MGMT_RELEASE_BGT_RELEASE_ID" ON public."TBL_BGT_MGMT_RELEASE" USING btree ("BGT_RELEASE_ID");
 <   DROP INDEX public."IX_TBL_BGT_MGMT_RELEASE_BGT_RELEASE_ID";
       public            postgres    false    408                       1259    79221 #   IX_TBL_BGT_MGMT_SRC_BGT_MGMT_EXP_ID    INDEX     q   CREATE INDEX "IX_TBL_BGT_MGMT_SRC_BGT_MGMT_EXP_ID" ON public."TBL_BGT_MGMT_SRC" USING btree ("BGT_MGMT_EXP_ID");
 9   DROP INDEX public."IX_TBL_BGT_MGMT_SRC_BGT_MGMT_EXP_ID";
       public            postgres    false    440            "           1259    79222 +   IX_TBL_BGT_MGMT_SRC_ORG_BGT_MGMT_EXP_ORG_ID    INDEX     �   CREATE INDEX "IX_TBL_BGT_MGMT_SRC_ORG_BGT_MGMT_EXP_ORG_ID" ON public."TBL_BGT_MGMT_SRC_ORG" USING btree ("BGT_MGMT_EXP_ORG_ID");
 A   DROP INDEX public."IX_TBL_BGT_MGMT_SRC_ORG_BGT_MGMT_EXP_ORG_ID";
       public            postgres    false    441            #           1259    79223    IX_TBL_BGT_MGMT_SRC_ORG_CC_ID    INDEX     e   CREATE INDEX "IX_TBL_BGT_MGMT_SRC_ORG_CC_ID" ON public."TBL_BGT_MGMT_SRC_ORG" USING btree ("CC_ID");
 3   DROP INDEX public."IX_TBL_BGT_MGMT_SRC_ORG_CC_ID";
       public            postgres    false    441            �           1259    79224 3   IX_TBL_BGT_MGMT_SRC_RELEASE_BGT_MGMT_EXP_RELEASE_ID    INDEX     �   CREATE INDEX "IX_TBL_BGT_MGMT_SRC_RELEASE_BGT_MGMT_EXP_RELEASE_ID" ON public."TBL_BGT_MGMT_SRC_RELEASE" USING btree ("BGT_MGMT_EXP_RELEASE_ID");
 I   DROP INDEX public."IX_TBL_BGT_MGMT_SRC_RELEASE_BGT_MGMT_EXP_RELEASE_ID";
       public            postgres    false    473            �           1259    79225 !   IX_TBL_BGT_MGMT_SRC_RELEASE_CC_ID    INDEX     m   CREATE INDEX "IX_TBL_BGT_MGMT_SRC_RELEASE_CC_ID" ON public."TBL_BGT_MGMT_SRC_RELEASE" USING btree ("CC_ID");
 7   DROP INDEX public."IX_TBL_BGT_MGMT_SRC_RELEASE_CC_ID";
       public            postgres    false    473            9           1259    79226    IX_TBL_BGT_RELEASE_ORG_ID    INDEX     ]   CREATE INDEX "IX_TBL_BGT_RELEASE_ORG_ID" ON public."TBL_BGT_RELEASE" USING btree ("ORG_ID");
 /   DROP INDEX public."IX_TBL_BGT_RELEASE_ORG_ID";
       public            postgres    false    376            �           1259    79227 (   IX_TBL_CONSTRUCTION_OTHER_CHARGES_ACC_ID    INDEX     {   CREATE INDEX "IX_TBL_CONSTRUCTION_OTHER_CHARGES_ACC_ID" ON public."TBL_CONSTRUCTION_OTHER_CHARGES" USING btree ("ACC_ID");
 >   DROP INDEX public."IX_TBL_CONSTRUCTION_OTHER_CHARGES_ACC_ID";
       public            postgres    false    416            �           1259    79228     IX_TBL_LAND_OTHER_CHARGES_ACC_ID    INDEX     k   CREATE INDEX "IX_TBL_LAND_OTHER_CHARGES_ACC_ID" ON public."TBL_LAND_OTHER_CHARGES" USING btree ("ACC_ID");
 6   DROP INDEX public."IX_TBL_LAND_OTHER_CHARGES_ACC_ID";
       public            postgres    false    417            �           1259    79229 "   IX_TBL_MALPOT_OTHER_CHARGES_ACC_ID    INDEX     o   CREATE INDEX "IX_TBL_MALPOT_OTHER_CHARGES_ACC_ID" ON public."TBL_MALPOT_OTHER_CHARGES" USING btree ("ACC_ID");
 8   DROP INDEX public."IX_TBL_MALPOT_OTHER_CHARGES_ACC_ID";
       public            postgres    false    471            �           1259    79230 "   IX_TBL_MALPOT_OTHER_CHARGES_RATEID    INDEX     o   CREATE INDEX "IX_TBL_MALPOT_OTHER_CHARGES_RATEID" ON public."TBL_MALPOT_OTHER_CHARGES" USING btree ("RATEID");
 8   DROP INDEX public."IX_TBL_MALPOT_OTHER_CHARGES_RATEID";
       public            postgres    false    471            �           1259    79231 -   IX_TBL_PAYMENT_ORDER_DETAILS_PAYMENT_ORDER_ID    INDEX     �   CREATE INDEX "IX_TBL_PAYMENT_ORDER_DETAILS_PAYMENT_ORDER_ID" ON public."TBL_PAYMENT_ORDER_DETAILS" USING btree ("PAYMENT_ORDER_ID");
 C   DROP INDEX public."IX_TBL_PAYMENT_ORDER_DETAILS_PAYMENT_ORDER_ID";
       public            postgres    false    400            �           1259    79242    IX_WARD_MASTER_PRAMUKH_ID    INDEX     ]   CREATE INDEX "IX_WARD_MASTER_PRAMUKH_ID" ON public."WARD_MASTER" USING btree ("PRAMUKH_ID");
 /   DROP INDEX public."IX_WARD_MASTER_PRAMUKH_ID";
       public            postgres    false    469            �           1259    79243    IX_WARD_MASTER_UPPRAMUKH_ID    INDEX     a   CREATE INDEX "IX_WARD_MASTER_UPPRAMUKH_ID" ON public."WARD_MASTER" USING btree ("UPPRAMUKH_ID");
 1   DROP INDEX public."IX_WARD_MASTER_UPPRAMUKH_ID";
       public            postgres    false    469            �           1259    79244     IX_WARD_MASTER_WARD_SECRETARY_ID    INDEX     k   CREATE INDEX "IX_WARD_MASTER_WARD_SECRETARY_ID" ON public."WARD_MASTER" USING btree ("WARD_SECRETARY_ID");
 6   DROP INDEX public."IX_WARD_MASTER_WARD_SECRETARY_ID";
       public            postgres    false    469            a           1259    79065    RoleNameIndex    INDEX     Y   CREATE UNIQUE INDEX "RoleNameIndex" ON public."IMISRole" USING btree ("NormalizedName");
 #   DROP INDEX public."RoleNameIndex";
       public            postgres    false    240            2           1259    79241    UserNameIndex    INDEX     _   CREATE UNIQUE INDEX "UserNameIndex" ON public."Usermaster" USING btree ("NormalizedUserName");
 #   DROP INDEX public."UserNameIndex";
       public            postgres    false    371            �           2606    78425 %   INV_PUR_ORDER_MAST FK_ACCEPTED_BY_USR    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_PUR_ORDER_MAST"
    ADD CONSTRAINT "FK_ACCEPTED_BY_USR" FOREIGN KEY ("ACCEPTED_BY") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 S   ALTER TABLE ONLY public."INV_PUR_ORDER_MAST" DROP CONSTRAINT "FK_ACCEPTED_BY_USR";
       public          postgres    false    455    431    4357            �           2606    78334 &   INV_GOODS_ADJUST FK_ACCEPT_BY_GOOD_ADJ    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_GOODS_ADJUST"
    ADD CONSTRAINT "FK_ACCEPT_BY_GOOD_ADJ" FOREIGN KEY ("ACCEPT_BY") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 T   ALTER TABLE ONLY public."INV_GOODS_ADJUST" DROP CONSTRAINT "FK_ACCEPT_BY_GOOD_ADJ";
       public          postgres    false    4357    452    431            �           2606    78367 (   INV_GOODS_REC_MAST FK_ACCEPT_BY_GOOD_EMP    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_GOODS_REC_MAST"
    ADD CONSTRAINT "FK_ACCEPT_BY_GOOD_EMP" FOREIGN KEY ("ACCEPT_BY") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 V   ALTER TABLE ONLY public."INV_GOODS_REC_MAST" DROP CONSTRAINT "FK_ACCEPT_BY_GOOD_EMP";
       public          postgres    false    431    4357    453            �           2606    77219 &   ACC_ACC_MASTER FK_ACC_ACC_MASTER_TYPID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_ACC_MASTER"
    ADD CONSTRAINT "FK_ACC_ACC_MASTER_TYPID" FOREIGN KEY ("TYPE_ID") REFERENCES public."ACC_TRANS_TYPE"("TYPE_ID") ON DELETE RESTRICT;
 T   ALTER TABLE ONLY public."ACC_ACC_MASTER" DROP CONSTRAINT "FK_ACC_ACC_MASTER_TYPID";
       public          postgres    false    3908    216    378            �           2606    77170 #   ACC_BGT_RVSN FK_ACC_BGT_RVSN_BGT_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_BGT_RVSN"
    ADD CONSTRAINT "FK_ACC_BGT_RVSN_BGT_ID" FOREIGN KEY ("BGT_ALCTN_ID") REFERENCES public."ACC_BGT_ALLOCATE"("BGT_ALLOCATE_ID") ON DELETE RESTRICT;
 Q   ALTER TABLE ONLY public."ACC_BGT_RVSN" DROP CONSTRAINT "FK_ACC_BGT_RVSN_BGT_ID";
       public          postgres    false    3888    374    204            �           2606    77180 (   ACC_CURRENCTY_RATE FK_ACC_CURRENCTY_RATE    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_CURRENCTY_RATE"
    ADD CONSTRAINT "FK_ACC_CURRENCTY_RATE" FOREIGN KEY ("CURRENCY_ID") REFERENCES public."ACC_CURRENCTY"("ID") ON DELETE RESTRICT;
 V   ALTER TABLE ONLY public."ACC_CURRENCTY_RATE" DROP CONSTRAINT "FK_ACC_CURRENCTY_RATE";
       public          postgres    false    3892    206    375            >           2606    77791 +   ACC_PAYMENT_MASTER FK_ACC_PAMT_MST_SUB_MODL    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_PAYMENT_MASTER"
    ADD CONSTRAINT "FK_ACC_PAMT_MST_SUB_MODL" FOREIGN KEY ("SUB_MODULE_ID") REFERENCES public."ACC_SUB_MODULE_TYPE"("SUB_MODULE_ID") ON DELETE RESTRICT;
 Y   ALTER TABLE ONLY public."ACC_PAYMENT_MASTER" DROP CONSTRAINT "FK_ACC_PAMT_MST_SUB_MODL";
       public          postgres    false    422    215    3906            ?           2606    77801 *   ACC_PAYMENT_MASTER FK_ACC_PAMT_MST_VCHR_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_PAYMENT_MASTER"
    ADD CONSTRAINT "FK_ACC_PAMT_MST_VCHR_ID" FOREIGN KEY ("VCHR_ID") REFERENCES public."ACC_VCHR_MASTER"("VCHR_ID") ON DELETE RESTRICT;
 X   ALTER TABLE ONLY public."ACC_PAYMENT_MASTER" DROP CONSTRAINT "FK_ACC_PAMT_MST_VCHR_ID";
       public          postgres    false    422    379    4163            @           2606    77786 *   ACC_PAYMENT_MASTER FK_ACC_PAMT_PER_TYPE_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_PAYMENT_MASTER"
    ADD CONSTRAINT "FK_ACC_PAMT_PER_TYPE_ID" FOREIGN KEY ("PERSON_TYPE_ID") REFERENCES public."PERSON_TYPE_MASTER"("PERSON_TYPE_ID") ON DELETE RESTRICT;
 X   ALTER TABLE ONLY public."ACC_PAYMENT_MASTER" DROP CONSTRAINT "FK_ACC_PAMT_PER_TYPE_ID";
       public          postgres    false    422    4031    297            A           2606    77796 '   ACC_PAYMENT_MASTER FK_ACC_PAMT_TRANS_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_PAYMENT_MASTER"
    ADD CONSTRAINT "FK_ACC_PAMT_TRANS_ID" FOREIGN KEY ("TRANS_TYPE_ID") REFERENCES public."ACC_TRANS_TYPE"("TYPE_ID") ON DELETE RESTRICT;
 U   ALTER TABLE ONLY public."ACC_PAYMENT_MASTER" DROP CONSTRAINT "FK_ACC_PAMT_TRANS_ID";
       public          postgres    false    3908    216    422            B           2606    77806 &   ACC_PAYMENT_MASTER FK_ACC_PAMT_WORK_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_PAYMENT_MASTER"
    ADD CONSTRAINT "FK_ACC_PAMT_WORK_ID" FOREIGN KEY ("WORK_ID") REFERENCES public."ACC_WORK_MASTER"("WORK_ID") ON DELETE RESTRICT;
 T   ALTER TABLE ONLY public."ACC_PAYMENT_MASTER" DROP CONSTRAINT "FK_ACC_PAMT_WORK_ID";
       public          postgres    false    422    220    3916                       2606    77391 $   ACC_ASULI_BIBARAN FK_ACC_PERSON_TYPE    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_ASULI_BIBARAN"
    ADD CONSTRAINT "FK_ACC_PERSON_TYPE" FOREIGN KEY ("PERSON_TYPE_ID") REFERENCES public."PERSON_TYPE_MASTER"("PERSON_TYPE_ID") ON DELETE RESTRICT;
 R   ALTER TABLE ONLY public."ACC_ASULI_BIBARAN" DROP CONSTRAINT "FK_ACC_PERSON_TYPE";
       public          postgres    false    4031    392    297                       2606    77262 (   ACC_WORK_FUNDS_DETAIL FK_ACC_PROVIDER_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_WORK_FUNDS_DETAIL"
    ADD CONSTRAINT "FK_ACC_PROVIDER_ID" FOREIGN KEY ("PROVIDER_ID") REFERENCES public."ACC_FUND_PROVIDR_MSTR"("PROVIDER_ID") ON DELETE RESTRICT;
 V   ALTER TABLE ONLY public."ACC_WORK_FUNDS_DETAIL" DROP CONSTRAINT "FK_ACC_PROVIDER_ID";
       public          postgres    false    381    207    3894            �           2606    77232 &   ACC_VCHR_MASTER FK_ACC_SUB_MODULE_TYPE    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_VCHR_MASTER"
    ADD CONSTRAINT "FK_ACC_SUB_MODULE_TYPE" FOREIGN KEY ("SUB_MODULE_ID") REFERENCES public."ACC_SUB_MODULE_TYPE"("SUB_MODULE_ID") ON DELETE RESTRICT;
 T   ALTER TABLE ONLY public."ACC_VCHR_MASTER" DROP CONSTRAINT "FK_ACC_SUB_MODULE_TYPE";
       public          postgres    false    3906    379    215            '           2606    77623 &   ACC_EXPENSES_DETAILS FK_ACC_TRANS_TYPE    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_EXPENSES_DETAILS"
    ADD CONSTRAINT "FK_ACC_TRANS_TYPE" FOREIGN KEY ("TRANS_TYPE_ID") REFERENCES public."ACC_TRANS_TYPE"("TYPE_ID") ON DELETE RESTRICT;
 T   ALTER TABLE ONLY public."ACC_EXPENSES_DETAILS" DROP CONSTRAINT "FK_ACC_TRANS_TYPE";
       public          postgres    false    3908    410    216            ~           2606    78255 &   ACC_PAYMENT_DETAILS FK_ACC_TRANS_TYPE1    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_PAYMENT_DETAILS"
    ADD CONSTRAINT "FK_ACC_TRANS_TYPE1" FOREIGN KEY ("TRANS_TYPE_ID") REFERENCES public."ACC_TRANS_TYPE"("TYPE_ID") ON DELETE RESTRICT;
 T   ALTER TABLE ONLY public."ACC_PAYMENT_DETAILS" DROP CONSTRAINT "FK_ACC_TRANS_TYPE1";
       public          postgres    false    3908    216    448            w           2606    78213 &   ACC_PAYMENT_DEDUCTION FK_ACID_PAY_DEDU    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_PAYMENT_DEDUCTION"
    ADD CONSTRAINT "FK_ACID_PAY_DEDU" FOREIGN KEY ("ACC_ID") REFERENCES public."ACC_ACC_MASTER"("ACC_ID") ON DELETE RESTRICT;
 T   ALTER TABLE ONLY public."ACC_PAYMENT_DEDUCTION" DROP CONSTRAINT "FK_ACID_PAY_DEDU";
       public          postgres    false    447    378    4160            ,           2606    77638 )   ACC_PAYMENT_CLEARANCE FK_ACPAYCLEAR_ACCID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_PAYMENT_CLEARANCE"
    ADD CONSTRAINT "FK_ACPAYCLEAR_ACCID" FOREIGN KEY ("ACC_ID") REFERENCES public."ACC_ACC_MASTER"("ACC_ID") ON DELETE RESTRICT;
 W   ALTER TABLE ONLY public."ACC_PAYMENT_CLEARANCE" DROP CONSTRAINT "FK_ACPAYCLEAR_ACCID";
       public          postgres    false    411    4160    378            -           2606    77643 *   ACC_PAYMENT_CLEARANCE FK_ACPAYCLEAR_BUDGET    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_PAYMENT_CLEARANCE"
    ADD CONSTRAINT "FK_ACPAYCLEAR_BUDGET" FOREIGN KEY ("BUDGET_ACC_ID") REFERENCES public."ACC_ACC_MASTER"("ACC_ID") ON DELETE RESTRICT;
 X   ALTER TABLE ONLY public."ACC_PAYMENT_CLEARANCE" DROP CONSTRAINT "FK_ACPAYCLEAR_BUDGET";
       public          postgres    false    4160    378    411            7           2606    77738 )   ACC_DHRTI_BILL_DTL FK_AC_DHRTI_DTL_ACC_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_DHRTI_BILL_DTL"
    ADD CONSTRAINT "FK_AC_DHRTI_DTL_ACC_ID" FOREIGN KEY ("ACC_ID") REFERENCES public."ACC_ACC_MASTER"("ACC_ID") ON DELETE RESTRICT;
 W   ALTER TABLE ONLY public."ACC_DHRTI_BILL_DTL" DROP CONSTRAINT "FK_AC_DHRTI_DTL_ACC_ID";
       public          postgres    false    4160    420    378            8           2606    77743 *   ACC_DHRTI_BILL_DTL FK_AC_DHRTI_DTL_VCHR_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_DHRTI_BILL_DTL"
    ADD CONSTRAINT "FK_AC_DHRTI_DTL_VCHR_ID" FOREIGN KEY ("VCHR_ID") REFERENCES public."ACC_VCHR_MASTER"("VCHR_ID") ON DELETE RESTRICT;
 X   ALTER TABLE ONLY public."ACC_DHRTI_BILL_DTL" DROP CONSTRAINT "FK_AC_DHRTI_DTL_VCHR_ID";
       public          postgres    false    379    4163    420            :           2606    77771 ,   ACC_DHRTI_BILL_MASTER FK_AC_DHRTI_MST_VCHRID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_DHRTI_BILL_MASTER"
    ADD CONSTRAINT "FK_AC_DHRTI_MST_VCHRID" FOREIGN KEY ("VCHR_ID") REFERENCES public."ACC_VCHR_MASTER"("VCHR_ID") ON DELETE RESTRICT;
 Z   ALTER TABLE ONLY public."ACC_DHRTI_BILL_MASTER" DROP CONSTRAINT "FK_AC_DHRTI_MST_VCHRID";
       public          postgres    false    421    4163    379            a           2606    78024 *   PIS_OTHER_ADD_SUB FK_ADD_SUB_LOCAL_POST_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_OTHER_ADD_SUB"
    ADD CONSTRAINT "FK_ADD_SUB_LOCAL_POST_ID" FOREIGN KEY ("LOCAL_POST_ID") REFERENCES public."PIS_LOCAL_POST_MASTER"("LOCAL_POST_ID") ON DELETE RESTRICT;
 X   ALTER TABLE ONLY public."PIS_OTHER_ADD_SUB" DROP CONSTRAINT "FK_ADD_SUB_LOCAL_POST_ID";
       public          postgres    false    433    4219    396            �           2606    78523 %   PIS_EMP_ADV_DED_DTL FK_ADV_DED_EMP_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_EMP_ADV_DED_DTL"
    ADD CONSTRAINT "FK_ADV_DED_EMP_ID" FOREIGN KEY ("EMP_ID") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 S   ALTER TABLE ONLY public."PIS_EMP_ADV_DED_DTL" DROP CONSTRAINT "FK_ADV_DED_EMP_ID";
       public          postgres    false    4357    431    459            W           2606    77951     PIS_AWARDS FK_AWARDS_LOC_POST_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_AWARDS"
    ADD CONSTRAINT "FK_AWARDS_LOC_POST_ID" FOREIGN KEY ("LOCAL_POST_ID") REFERENCES public."PIS_LOCAL_POST_MASTER"("LOCAL_POST_ID") ON DELETE RESTRICT;
 N   ALTER TABLE ONLY public."PIS_AWARDS" DROP CONSTRAINT "FK_AWARDS_LOC_POST_ID";
       public          postgres    false    396    4219    429            q           2606    78180 $   BANKTRANSACTIONS FK_BANKTRAN_VCHR_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."BANKTRANSACTIONS"
    ADD CONSTRAINT "FK_BANKTRAN_VCHR_ID" FOREIGN KEY ("VCHR_ID") REFERENCES public."ACC_VCHR_MASTER"("VCHR_ID") ON DELETE RESTRICT;
 R   ALTER TABLE ONLY public."BANKTRANSACTIONS" DROP CONSTRAINT "FK_BANKTRAN_VCHR_ID";
       public          postgres    false    445    379    4163            P           2606    77906 #   ORG_BANK_ACCOUNT FK_BANK_ACCNT_TYPE    FK CONSTRAINT     �   ALTER TABLE ONLY public."ORG_BANK_ACCOUNT"
    ADD CONSTRAINT "FK_BANK_ACCNT_TYPE" FOREIGN KEY ("BANK_ACCNT_TYPE_ID") REFERENCES public."TBL_BANK_ACCNT_TYPE"("ID") ON DELETE RESTRICT;
 Q   ALTER TABLE ONLY public."ORG_BANK_ACCOUNT" DROP CONSTRAINT "FK_BANK_ACCNT_TYPE";
       public          postgres    false    4098    341    427            �           2606    78277    ACC_BANK_TRANS FK_BANK_BANK_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_BANK_TRANS"
    ADD CONSTRAINT "FK_BANK_BANK_ID" FOREIGN KEY ("BANK_ID") REFERENCES public."BANKMASTER"("BANKID") ON DELETE RESTRICT;
 L   ALTER TABLE ONLY public."ACC_BANK_TRANS" DROP CONSTRAINT "FK_BANK_BANK_ID";
       public          postgres    false    3922    223    449            �           2606    78282    ACC_BANK_TRANS FK_BANK_BILL_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_BANK_TRANS"
    ADD CONSTRAINT "FK_BANK_BILL_ID" FOREIGN KEY ("BILL_ID") REFERENCES public."INCOMEBILLMASTER"("SN") ON DELETE RESTRICT;
 L   ALTER TABLE ONLY public."ACC_BANK_TRANS" DROP CONSTRAINT "FK_BANK_BILL_ID";
       public          postgres    false    449    4328    426            Q           2606    77911    ORG_BANK_ACCOUNT FK_BANK_BRANCH    FK CONSTRAINT     �   ALTER TABLE ONLY public."ORG_BANK_ACCOUNT"
    ADD CONSTRAINT "FK_BANK_BRANCH" FOREIGN KEY ("BRANCH_ID") REFERENCES public."BANK_BRANCH"("BRANCH_ID") ON DELETE RESTRICT;
 M   ALTER TABLE ONLY public."ORG_BANK_ACCOUNT" DROP CONSTRAINT "FK_BANK_BRANCH";
       public          postgres    false    4175    427    382                       2606    77280    BANK_BRANCH FK_BANK_MSTR    FK CONSTRAINT     �   ALTER TABLE ONLY public."BANK_BRANCH"
    ADD CONSTRAINT "FK_BANK_MSTR" FOREIGN KEY ("BANKID") REFERENCES public."BANKMASTER"("BANKID") ON DELETE RESTRICT;
 F   ALTER TABLE ONLY public."BANK_BRANCH" DROP CONSTRAINT "FK_BANK_MSTR";
       public          postgres    false    223    382    3922                       2606    77469    TBL_BGT_MGMT_EXP FK_BGT_MGMT    FK CONSTRAINT     �   ALTER TABLE ONLY public."TBL_BGT_MGMT_EXP"
    ADD CONSTRAINT "FK_BGT_MGMT" FOREIGN KEY ("BGT_MGMT_ID") REFERENCES public."TBL_BGT_MGMT"("ID") ON DELETE RESTRICT;
 J   ALTER TABLE ONLY public."TBL_BGT_MGMT_EXP" DROP CONSTRAINT "FK_BGT_MGMT";
       public          postgres    false    398    343    4102            i           2606    78102     TBL_BGT_MGMT_SRC FK_BGT_MGMT_EXP    FK CONSTRAINT     �   ALTER TABLE ONLY public."TBL_BGT_MGMT_SRC"
    ADD CONSTRAINT "FK_BGT_MGMT_EXP" FOREIGN KEY ("BGT_MGMT_EXP_ID") REFERENCES public."TBL_BGT_MGMT_EXP"("ID") ON DELETE RESTRICT;
 N   ALTER TABLE ONLY public."TBL_BGT_MGMT_SRC" DROP CONSTRAINT "FK_BGT_MGMT_EXP";
       public          postgres    false    440    398    4225                       2606    77479 $   TBL_BGT_MGMT_EXP_ORG FK_BGT_MGMT_ORG    FK CONSTRAINT     �   ALTER TABLE ONLY public."TBL_BGT_MGMT_EXP_ORG"
    ADD CONSTRAINT "FK_BGT_MGMT_ORG" FOREIGN KEY ("BGT_MGMT_ORG_ID") REFERENCES public."TBL_BGT_MGMT_ORG"("ID") ON DELETE RESTRICT;
 R   ALTER TABLE ONLY public."TBL_BGT_MGMT_EXP_ORG" DROP CONSTRAINT "FK_BGT_MGMT_ORG";
       public          postgres    false    4104    399    344            j           2606    78112 (   TBL_BGT_MGMT_SRC_ORG FK_BGT_MGMT_ORG_EXP    FK CONSTRAINT     �   ALTER TABLE ONLY public."TBL_BGT_MGMT_SRC_ORG"
    ADD CONSTRAINT "FK_BGT_MGMT_ORG_EXP" FOREIGN KEY ("BGT_MGMT_EXP_ORG_ID") REFERENCES public."TBL_BGT_MGMT_EXP_ORG"("ID") ON DELETE RESTRICT;
 V   ALTER TABLE ONLY public."TBL_BGT_MGMT_SRC_ORG" DROP CONSTRAINT "FK_BGT_MGMT_ORG_EXP";
       public          postgres    false    441    399    4228            #           2606    77578 $   TBL_BGT_MGMT_RELEASE FK_BGT_MGMT_REL    FK CONSTRAINT     �   ALTER TABLE ONLY public."TBL_BGT_MGMT_RELEASE"
    ADD CONSTRAINT "FK_BGT_MGMT_REL" FOREIGN KEY ("BGT_RELEASE_ID") REFERENCES public."TBL_BGT_RELEASE"("ID") ON DELETE RESTRICT;
 R   ALTER TABLE ONLY public."TBL_BGT_MGMT_RELEASE" DROP CONSTRAINT "FK_BGT_MGMT_REL";
       public          postgres    false    408    4155    376            p           2606    78157 ,   TBL_BGT_MGMT_EXP_RELEASE FK_BGT_MGMT_RELEASE    FK CONSTRAINT     �   ALTER TABLE ONLY public."TBL_BGT_MGMT_EXP_RELEASE"
    ADD CONSTRAINT "FK_BGT_MGMT_RELEASE" FOREIGN KEY ("BGT_MGMT_RELEASE_ID") REFERENCES public."TBL_BGT_MGMT_RELEASE"("ID") ON DELETE RESTRICT;
 Z   ALTER TABLE ONLY public."TBL_BGT_MGMT_EXP_RELEASE" DROP CONSTRAINT "FK_BGT_MGMT_RELEASE";
       public          postgres    false    444    408    4251            �           2606    78753 ,   TBL_BGT_MGMT_SRC_RELEASE FK_BGT_MGMT_REL_EXP    FK CONSTRAINT     �   ALTER TABLE ONLY public."TBL_BGT_MGMT_SRC_RELEASE"
    ADD CONSTRAINT "FK_BGT_MGMT_REL_EXP" FOREIGN KEY ("BGT_MGMT_EXP_RELEASE_ID") REFERENCES public."TBL_BGT_MGMT_EXP_RELEASE"("ID") ON DELETE RESTRICT;
 Z   ALTER TABLE ONLY public."TBL_BGT_MGMT_SRC_RELEASE" DROP CONSTRAINT "FK_BGT_MGMT_REL_EXP";
       public          postgres    false    4400    473    444            �           2606    77193    TBL_BGT_RELEASE FK_BGT_REL_ORG    FK CONSTRAINT     �   ALTER TABLE ONLY public."TBL_BGT_RELEASE"
    ADD CONSTRAINT "FK_BGT_REL_ORG" FOREIGN KEY ("ORG_ID") REFERENCES public."ACC_ORG_MASTER"("ORG_ID") ON DELETE RESTRICT;
 L   ALTER TABLE ONLY public."TBL_BGT_RELEASE" DROP CONSTRAINT "FK_BGT_REL_ORG";
       public          postgres    false    3902    376    211            �           2606    78508 $   PIS_BANK_PAYROLL FK_BNK_PYRL_BANK_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_BANK_PAYROLL"
    ADD CONSTRAINT "FK_BNK_PYRL_BANK_ID" FOREIGN KEY ("BANK_ID") REFERENCES public."BANKMASTER"("BANKID") ON DELETE RESTRICT;
 R   ALTER TABLE ONLY public."PIS_BANK_PAYROLL" DROP CONSTRAINT "FK_BNK_PYRL_BANK_ID";
       public          postgres    false    223    458    3922            �           2606    78513 #   PIS_BANK_PAYROLL FK_BNK_PYRL_EMP_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_BANK_PAYROLL"
    ADD CONSTRAINT "FK_BNK_PYRL_EMP_ID" FOREIGN KEY ("EMP_ID") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 Q   ALTER TABLE ONLY public."PIS_BANK_PAYROLL" DROP CONSTRAINT "FK_BNK_PYRL_EMP_ID";
       public          postgres    false    458    431    4357            x           2606    78218 *   ACC_PAYMENT_DEDUCTION FK_BUDGETID_PAY_DEDU    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_PAYMENT_DEDUCTION"
    ADD CONSTRAINT "FK_BUDGETID_PAY_DEDU" FOREIGN KEY ("BUDGET_ACC_ID") REFERENCES public."ACC_ACC_MASTER"("ACC_ID") ON DELETE RESTRICT;
 X   ALTER TABLE ONLY public."ACC_PAYMENT_DEDUCTION" DROP CONSTRAINT "FK_BUDGETID_PAY_DEDU";
       public          postgres    false    4160    447    378                       2606    77378    ACC_BUDJET_SOURCE FK_BUD_SOURCE    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_BUDJET_SOURCE"
    ADD CONSTRAINT "FK_BUD_SOURCE" FOREIGN KEY ("SOURCE_ID") REFERENCES public."BUDJET_SOURCE"("ID") ON DELETE RESTRICT;
 M   ALTER TABLE ONLY public."ACC_BUDJET_SOURCE" DROP CONSTRAINT "FK_BUD_SOURCE";
       public          postgres    false    391    224    3924            5           2606    77718 .   TBLBUSINESS_SERVICE_CH_MST FK_BUS_SERCH_ACC_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."TBLBUSINESS_SERVICE_CH_MST"
    ADD CONSTRAINT "FK_BUS_SERCH_ACC_ID" FOREIGN KEY ("ACC_ID") REFERENCES public."ACC_ACC_MASTER"("ACC_ID") ON DELETE RESTRICT;
 \   ALTER TABLE ONLY public."TBLBUSINESS_SERVICE_CH_MST" DROP CONSTRAINT "FK_BUS_SERCH_ACC_ID";
       public          postgres    false    378    418    4160            t           2606    78203 #   CASHTRANSACTION FK_CASHTRAN_VCHR_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."CASHTRANSACTION"
    ADD CONSTRAINT "FK_CASHTRAN_VCHR_ID" FOREIGN KEY ("VCHR_ID") REFERENCES public."ACC_VCHR_MASTER"("VCHR_ID") ON DELETE RESTRICT;
 Q   ALTER TABLE ONLY public."CASHTRANSACTION" DROP CONSTRAINT "FK_CASHTRAN_VCHR_ID";
       public          postgres    false    4163    446    379            �           2606    78299    ACC_CASH_TRANS FK_CASH_BILL_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_CASH_TRANS"
    ADD CONSTRAINT "FK_CASH_BILL_ID" FOREIGN KEY ("BILL_ID") REFERENCES public."INCOMEBILLMASTER"("SN") ON DELETE RESTRICT;
 L   ALTER TABLE ONLY public."ACC_CASH_TRANS" DROP CONSTRAINT "FK_CASH_BILL_ID";
       public          postgres    false    450    426    4328            �           2606    78304    ACC_CASH_TRANS FK_CASH_VCHR_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_CASH_TRANS"
    ADD CONSTRAINT "FK_CASH_VCHR_ID" FOREIGN KEY ("VCHR_ID") REFERENCES public."ACC_VCHR_MASTER"("VCHR_ID") ON DELETE RESTRICT;
 L   ALTER TABLE ONLY public."ACC_CASH_TRANS" DROP CONSTRAINT "FK_CASH_VCHR_ID";
       public          postgres    false    450    379    4163            k           2606    78117    TBL_BGT_MGMT_SRC_ORG FK_CC    FK CONSTRAINT     �   ALTER TABLE ONLY public."TBL_BGT_MGMT_SRC_ORG"
    ADD CONSTRAINT "FK_CC" FOREIGN KEY ("CC_ID") REFERENCES public."CONTACTS"("ID") ON DELETE RESTRICT;
 H   ALTER TABLE ONLY public."TBL_BGT_MGMT_SRC_ORG" DROP CONSTRAINT "FK_CC";
       public          postgres    false    441    230    3928            �           2606    78758 &   TBL_BGT_MGMT_SRC_RELEASE FK_CC_RELEASE    FK CONSTRAINT     �   ALTER TABLE ONLY public."TBL_BGT_MGMT_SRC_RELEASE"
    ADD CONSTRAINT "FK_CC_RELEASE" FOREIGN KEY ("CC_ID") REFERENCES public."CONTACTS"("ID") ON DELETE RESTRICT;
 T   ALTER TABLE ONLY public."TBL_BGT_MGMT_SRC_RELEASE" DROP CONSTRAINT "FK_CC_RELEASE";
       public          postgres    false    473    230    3928            �           2606    78430 $   INV_PUR_ORDER_MAST FK_CHECKED_BY_USR    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_PUR_ORDER_MAST"
    ADD CONSTRAINT "FK_CHECKED_BY_USR" FOREIGN KEY ("CHECKED_BY") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 R   ALTER TABLE ONLY public."INV_PUR_ORDER_MAST" DROP CONSTRAINT "FK_CHECKED_BY_USR";
       public          postgres    false    455    431    4357            �           2606    78372 '   INV_GOODS_REC_MAST FK_CHECK_BY_GOOD_EMP    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_GOODS_REC_MAST"
    ADD CONSTRAINT "FK_CHECK_BY_GOOD_EMP" FOREIGN KEY ("CHECK_BY") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 U   ALTER TABLE ONLY public."INV_GOODS_REC_MAST" DROP CONSTRAINT "FK_CHECK_BY_GOOD_EMP";
       public          postgres    false    4357    453    431            3           2606    77698 5   TBL_CONSTRUCTION_OTHER_CHARGES FK_CONST_OTH_CH_ACC_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."TBL_CONSTRUCTION_OTHER_CHARGES"
    ADD CONSTRAINT "FK_CONST_OTH_CH_ACC_ID" FOREIGN KEY ("ACC_ID") REFERENCES public."ACC_ACC_MASTER"("ACC_ID") ON DELETE RESTRICT;
 c   ALTER TABLE ONLY public."TBL_CONSTRUCTION_OTHER_CHARGES" DROP CONSTRAINT "FK_CONST_OTH_CH_ACC_ID";
       public          postgres    false    4160    416    378            X           2606    77961 $   PIS_DARBANDI FK_DARBANDI_LOC_POST_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_DARBANDI"
    ADD CONSTRAINT "FK_DARBANDI_LOC_POST_ID" FOREIGN KEY ("LOCAL_POST_ID") REFERENCES public."PIS_LOCAL_POST_MASTER"("LOCAL_POST_ID") ON DELETE RESTRICT;
 R   ALTER TABLE ONLY public."PIS_DARBANDI" DROP CONSTRAINT "FK_DARBANDI_LOC_POST_ID";
       public          postgres    false    4219    396    430            Y           2606    77966 "   PIS_DARBANDI FK_DARBANDI_OFFICE_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_DARBANDI"
    ADD CONSTRAINT "FK_DARBANDI_OFFICE_ID" FOREIGN KEY ("OFFICE_ID") REFERENCES public."ORGANIZATION_TREE"("ID") ON DELETE RESTRICT;
 P   ALTER TABLE ONLY public."PIS_DARBANDI" DROP CONSTRAINT "FK_DARBANDI_OFFICE_ID";
       public          postgres    false    430    395    4216            Z           2606    77971     PIS_DARBANDI FK_DARBANDI_POST_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_DARBANDI"
    ADD CONSTRAINT "FK_DARBANDI_POST_ID" FOREIGN KEY ("POST_ID") REFERENCES public."PIS_POST_MASTER"("POST_ID") ON DELETE RESTRICT;
 N   ALTER TABLE ONLY public."PIS_DARBANDI" DROP CONSTRAINT "FK_DARBANDI_POST_ID";
       public          postgres    false    4070    316    430            �           2606    78768 1   PIS_DELETD_FRM_FULFILD_DARB FK_DEL_FD_DARBANDI_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_DELETD_FRM_FULFILD_DARB"
    ADD CONSTRAINT "FK_DEL_FD_DARBANDI_ID" FOREIGN KEY ("FRM_DARBANDI_ID") REFERENCES public."PIS_DARBANDI"("DARBANDI_ID") ON DELETE RESTRICT;
 _   ALTER TABLE ONLY public."PIS_DELETD_FRM_FULFILD_DARB" DROP CONSTRAINT "FK_DEL_FD_DARBANDI_ID";
       public          postgres    false    430    474    4350            �           2606    78773 /   PIS_DELETD_FRM_FULFILD_DARB FK_DEL_FD_OFFICE_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_DELETD_FRM_FULFILD_DARB"
    ADD CONSTRAINT "FK_DEL_FD_OFFICE_ID" FOREIGN KEY ("FRM_OFFICE_ID") REFERENCES public."ORGANIZATION_TREE"("ID") ON DELETE RESTRICT;
 ]   ALTER TABLE ONLY public."PIS_DELETD_FRM_FULFILD_DARB" DROP CONSTRAINT "FK_DEL_FD_OFFICE_ID";
       public          postgres    false    4216    474    395                       2606    77489 6   TBL_PAYMENT_ORDER_DETAILS FK_DETAILS_TBL_PAYMENT_ORDER    FK CONSTRAINT     �   ALTER TABLE ONLY public."TBL_PAYMENT_ORDER_DETAILS"
    ADD CONSTRAINT "FK_DETAILS_TBL_PAYMENT_ORDER" FOREIGN KEY ("PAYMENT_ORDER_ID") REFERENCES public."TBL_PAYMENT_ORDER"("ID") ON DELETE RESTRICT;
 d   ALTER TABLE ONLY public."TBL_PAYMENT_ORDER_DETAILS" DROP CONSTRAINT "FK_DETAILS_TBL_PAYMENT_ORDER";
       public          postgres    false    350    4116    400            (           2606    77608 %   ACC_EXPENSES_DETAILS FK_DETAIL_ACC_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_EXPENSES_DETAILS"
    ADD CONSTRAINT "FK_DETAIL_ACC_ID" FOREIGN KEY ("ACC_ID") REFERENCES public."ACC_ACC_MASTER"("ACC_ID") ON DELETE RESTRICT;
 S   ALTER TABLE ONLY public."ACC_EXPENSES_DETAILS" DROP CONSTRAINT "FK_DETAIL_ACC_ID";
       public          postgres    false    4160    410    378            z           2606    78235 %   ACC_PAYMENT_DETAILS FK_DETAIL_ACC_ID1    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_PAYMENT_DETAILS"
    ADD CONSTRAINT "FK_DETAIL_ACC_ID1" FOREIGN KEY ("ACC_ID") REFERENCES public."ACC_ACC_MASTER"("ACC_ID") ON DELETE RESTRICT;
 S   ALTER TABLE ONLY public."ACC_PAYMENT_DETAILS" DROP CONSTRAINT "FK_DETAIL_ACC_ID1";
       public          postgres    false    448    4160    378            C           2606    77828 &   ACC_VCHR_DETAILS FK_DETAIL_ACC_VCHR_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_VCHR_DETAILS"
    ADD CONSTRAINT "FK_DETAIL_ACC_VCHR_ID" FOREIGN KEY ("VCHR_ID") REFERENCES public."ACC_VCHR_MASTER"("VCHR_ID") ON DELETE RESTRICT;
 T   ALTER TABLE ONLY public."ACC_VCHR_DETAILS" DROP CONSTRAINT "FK_DETAIL_ACC_VCHR_ID";
       public          postgres    false    4163    379    423            )           2606    77613 ,   ACC_EXPENSES_DETAILS FK_DETAIL_PAMENT_SLIPID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_EXPENSES_DETAILS"
    ADD CONSTRAINT "FK_DETAIL_PAMENT_SLIPID" FOREIGN KEY ("PAYMENT_SLIP_ID") REFERENCES public."PAYMENT_SLIP_MASTER"("PAYMENT_SLIP_ID") ON DELETE RESTRICT;
 Z   ALTER TABLE ONLY public."ACC_EXPENSES_DETAILS" DROP CONSTRAINT "FK_DETAIL_PAMENT_SLIPID";
       public          postgres    false    410    296    4029            *           2606    77618 -   ACC_EXPENSES_DETAILS FK_DETAIL_PERSON_TYPE_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_EXPENSES_DETAILS"
    ADD CONSTRAINT "FK_DETAIL_PERSON_TYPE_ID" FOREIGN KEY ("PERSON_TYPE_ID") REFERENCES public."PERSON_TYPE_MASTER"("PERSON_TYPE_ID") ON DELETE RESTRICT;
 [   ALTER TABLE ONLY public."ACC_EXPENSES_DETAILS" DROP CONSTRAINT "FK_DETAIL_PERSON_TYPE_ID";
       public          postgres    false    410    4031    297            }           2606    78250 -   ACC_PAYMENT_DETAILS FK_DETAIL_PERSON_TYPE_ID1    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_PAYMENT_DETAILS"
    ADD CONSTRAINT "FK_DETAIL_PERSON_TYPE_ID1" FOREIGN KEY ("PERSON_TYPE_ID") REFERENCES public."PERSON_TYPE_MASTER"("PERSON_TYPE_ID") ON DELETE RESTRICT;
 [   ALTER TABLE ONLY public."ACC_PAYMENT_DETAILS" DROP CONSTRAINT "FK_DETAIL_PERSON_TYPE_ID1";
       public          postgres    false    4031    448    297            D           2606    77823 (   ACC_VCHR_DETAILS FK_DETAIL_TRANS_TYPE_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_VCHR_DETAILS"
    ADD CONSTRAINT "FK_DETAIL_TRANS_TYPE_ID" FOREIGN KEY ("TRANS_TYPE_ID") REFERENCES public."ACC_TRANS_TYPE"("TYPE_ID") ON DELETE RESTRICT;
 V   ALTER TABLE ONLY public."ACC_VCHR_DETAILS" DROP CONSTRAINT "FK_DETAIL_TRANS_TYPE_ID";
       public          postgres    false    216    423    3908            E           2606    77833 '   ACC_VCHR_DETAILS FK_DETAIL_VCHR_TYPE_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_VCHR_DETAILS"
    ADD CONSTRAINT "FK_DETAIL_VCHR_TYPE_ID" FOREIGN KEY ("VCHR_TYPE_ID") REFERENCES public."ACC_VCHR_TYPE_MASTER"("VCHR_TYPE_ID") ON DELETE RESTRICT;
 U   ALTER TABLE ONLY public."ACC_VCHR_DETAILS" DROP CONSTRAINT "FK_DETAIL_VCHR_TYPE_ID";
       public          postgres    false    219    3914    423            �           2606    78265 &   ACC_PAYMENT_DETAILS FK_DETAIL_WORK_ID1    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_PAYMENT_DETAILS"
    ADD CONSTRAINT "FK_DETAIL_WORK_ID1" FOREIGN KEY ("WORK_ID") REFERENCES public."ACC_WORK_MASTER"("WORK_ID") ON DELETE RESTRICT;
 T   ALTER TABLE ONLY public."ACC_PAYMENT_DETAILS" DROP CONSTRAINT "FK_DETAIL_WORK_ID1";
       public          postgres    false    448    3916    220            +           2606    77628 '   ACC_EXPENSES_DETAILS FK_DETAIL_WWORK_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_EXPENSES_DETAILS"
    ADD CONSTRAINT "FK_DETAIL_WWORK_ID" FOREIGN KEY ("WORK_ID") REFERENCES public."ACC_WORK_MASTER"("WORK_ID") ON DELETE RESTRICT;
 U   ALTER TABLE ONLY public."ACC_EXPENSES_DETAILS" DROP CONSTRAINT "FK_DETAIL_WWORK_ID";
       public          postgres    false    3916    220    410            {           2606    78240 )   ACC_PAYMENT_DETAILS FK_DTL_BUDGET_ACC_ID1    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_PAYMENT_DETAILS"
    ADD CONSTRAINT "FK_DTL_BUDGET_ACC_ID1" FOREIGN KEY ("BUDGET_ACC_ID") REFERENCES public."ACC_ACC_MASTER"("ACC_ID") ON DELETE RESTRICT;
 W   ALTER TABLE ONLY public."ACC_PAYMENT_DETAILS" DROP CONSTRAINT "FK_DTL_BUDGET_ACC_ID1";
       public          postgres    false    378    4160    448            F           2606    77818 $   ACC_VCHR_DETAILS FK_DTL_SUB_MODULEID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_VCHR_DETAILS"
    ADD CONSTRAINT "FK_DTL_SUB_MODULEID" FOREIGN KEY ("SUB_MODULE_ID") REFERENCES public."ACC_SUB_MODULE_TYPE"("SUB_MODULE_ID") ON DELETE RESTRICT;
 R   ALTER TABLE ONLY public."ACC_VCHR_DETAILS" DROP CONSTRAINT "FK_DTL_SUB_MODULEID";
       public          postgres    false    423    215    3906                       2606    77401    PIS_EDUCATION FK_EDU_BRD    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_EDUCATION"
    ADD CONSTRAINT "FK_EDU_BRD" FOREIGN KEY ("BOARD_ID") REFERENCES public."PIS_EDU_BOARD"("ID") ON DELETE RESTRICT;
 F   ALTER TABLE ONLY public."PIS_EDUCATION" DROP CONSTRAINT "FK_EDU_BRD";
       public          postgres    false    4037    300    393                       2606    77406    PIS_EDUCATION FK_EDU_LVL    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_EDUCATION"
    ADD CONSTRAINT "FK_EDU_LVL" FOREIGN KEY ("EDU_LEVEL_ID") REFERENCES public."PIS_EDU_LEVEL"("EDU_ID") ON DELETE RESTRICT;
 F   ALTER TABLE ONLY public."PIS_EDUCATION" DROP CONSTRAINT "FK_EDU_LVL";
       public          postgres    false    393    4039    301            �           2606    78533 !   PIS_EMP_LOANS FK_EMP_LOANS_EMP_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_EMP_LOANS"
    ADD CONSTRAINT "FK_EMP_LOANS_EMP_ID" FOREIGN KEY ("EMP_ID") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 O   ALTER TABLE ONLY public."PIS_EMP_LOANS" DROP CONSTRAINT "FK_EMP_LOANS_EMP_ID";
       public          postgres    false    460    4357    431            �           2606    78798 *   PIS_REPLACED_IN_DARBANDI FK_ENTRY_SN_IN_FD    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_REPLACED_IN_DARBANDI"
    ADD CONSTRAINT "FK_ENTRY_SN_IN_FD" FOREIGN KEY ("ENTRY_SN_IN_FD") REFERENCES public."PIS_FULFILLED_DARBANDI"("SN") ON DELETE RESTRICT;
 X   ALTER TABLE ONLY public."PIS_REPLACED_IN_DARBANDI" DROP CONSTRAINT "FK_ENTRY_SN_IN_FD";
       public          postgres    false    451    475    4438            .           2606    77653 #   FIREBRIGADESTATE FK_FIREBRIG_ACC_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."FIREBRIGADESTATE"
    ADD CONSTRAINT "FK_FIREBRIG_ACC_ID" FOREIGN KEY ("ACC_ID") REFERENCES public."ACC_ACC_MASTER"("ACC_ID") ON DELETE RESTRICT;
 Q   ALTER TABLE ONLY public."FIREBRIGADESTATE" DROP CONSTRAINT "FK_FIREBRIG_ACC_ID";
       public          postgres    false    4160    378    412            [           2606    77989 )   PIS_EMPLOYEE_MASTER FK_FIRST_APMT_POST_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_EMPLOYEE_MASTER"
    ADD CONSTRAINT "FK_FIRST_APMT_POST_ID" FOREIGN KEY ("FIRST_APPOINT_POST_ID") REFERENCES public."PIS_POST_MASTER"("POST_ID") ON DELETE RESTRICT;
 W   ALTER TABLE ONLY public."PIS_EMPLOYEE_MASTER" DROP CONSTRAINT "FK_FIRST_APMT_POST_ID";
       public          postgres    false    431    4070    316            `           2606    78014 '   PIS_FOREIGN_VISITS FK_FORGN_LOC_POST_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_FOREIGN_VISITS"
    ADD CONSTRAINT "FK_FORGN_LOC_POST_ID" FOREIGN KEY ("LOCAL_POST_ID") REFERENCES public."PIS_LOCAL_POST_MASTER"("LOCAL_POST_ID") ON DELETE RESTRICT;
 U   ALTER TABLE ONLY public."PIS_FOREIGN_VISITS" DROP CONSTRAINT "FK_FORGN_LOC_POST_ID";
       public          postgres    false    4219    396    432            $           2606    77593    ACC_BGT_TRANSFER FK_FROM_ACC_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_BGT_TRANSFER"
    ADD CONSTRAINT "FK_FROM_ACC_ID" FOREIGN KEY ("FROM_ACC_ID") REFERENCES public."ACC_ACC_MASTER"("ACC_ID") ON DELETE RESTRICT;
 M   ALTER TABLE ONLY public."ACC_BGT_TRANSFER" DROP CONSTRAINT "FK_FROM_ACC_ID";
       public          postgres    false    409    378    4160            �           2606    78778 ,   PIS_DELETD_FRM_FULFILD_DARB FK_FROM_SN_IN_FD    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_DELETD_FRM_FULFILD_DARB"
    ADD CONSTRAINT "FK_FROM_SN_IN_FD" FOREIGN KEY ("FRM_SN_IN_FD") REFERENCES public."PIS_FULFILLED_DARBANDI"("SN") ON DELETE RESTRICT;
 Z   ALTER TABLE ONLY public."PIS_DELETD_FRM_FULFILD_DARB" DROP CONSTRAINT "FK_FROM_SN_IN_FD";
       public          postgres    false    451    4438    474            �           2606    78314 ,   PIS_FULFILLED_DARBANDI FK_FULFIL_DARBANDI_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_FULFILLED_DARBANDI"
    ADD CONSTRAINT "FK_FULFIL_DARBANDI_ID" FOREIGN KEY ("DARBANDI_ID") REFERENCES public."PIS_DARBANDI"("DARBANDI_ID") ON DELETE RESTRICT;
 Z   ALTER TABLE ONLY public."PIS_FULFILLED_DARBANDI" DROP CONSTRAINT "FK_FULFIL_DARBANDI_ID";
       public          postgres    false    451    430    4350            �           2606    78319 1   PIS_FULFILLED_DARBANDI FK_FULFIL_DARB_LOC_POST_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_FULFILLED_DARBANDI"
    ADD CONSTRAINT "FK_FULFIL_DARB_LOC_POST_ID" FOREIGN KEY ("LOCAL_POST_ID") REFERENCES public."PIS_LOCAL_POST_MASTER"("LOCAL_POST_ID") ON DELETE RESTRICT;
 _   ALTER TABLE ONLY public."PIS_FULFILLED_DARBANDI" DROP CONSTRAINT "FK_FULFIL_DARB_LOC_POST_ID";
       public          postgres    false    451    396    4219            �           2606    78324 /   PIS_FULFILLED_DARBANDI FK_FULFIL_DARB_OFFICE_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_FULFILLED_DARBANDI"
    ADD CONSTRAINT "FK_FULFIL_DARB_OFFICE_ID" FOREIGN KEY ("OFFICE_ID") REFERENCES public."ORGANIZATION_TREE"("ID") ON DELETE RESTRICT;
 ]   ALTER TABLE ONLY public."PIS_FULFILLED_DARBANDI" DROP CONSTRAINT "FK_FULFIL_DARB_OFFICE_ID";
       public          postgres    false    451    395    4216            �           2606    78339 )   INV_GOODS_ADJUST FK_GOODS_ADJUST_BRAND_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_GOODS_ADJUST"
    ADD CONSTRAINT "FK_GOODS_ADJUST_BRAND_ID" FOREIGN KEY ("BRAND_ID") REFERENCES public."INV_BRAND"("BRAND_ID") ON DELETE RESTRICT;
 W   ALTER TABLE ONLY public."INV_GOODS_ADJUST" DROP CONSTRAINT "FK_GOODS_ADJUST_BRAND_ID";
       public          postgres    false    452    3941    243            �           2606    78344 (   INV_GOODS_ADJUST FK_GOODS_ADJUST_ITEM_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_GOODS_ADJUST"
    ADD CONSTRAINT "FK_GOODS_ADJUST_ITEM_ID" FOREIGN KEY ("ITEM_ID") REFERENCES public."INV_ITEM_MST"("ITEM_ID") ON DELETE RESTRICT;
 V   ALTER TABLE ONLY public."INV_GOODS_ADJUST" DROP CONSTRAINT "FK_GOODS_ADJUST_ITEM_ID";
       public          postgres    false    4191    452    388            �           2606    78354 (   INV_GOODS_ADJUST FK_GOODS_ADJUST_SPEC_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_GOODS_ADJUST"
    ADD CONSTRAINT "FK_GOODS_ADJUST_SPEC_ID" FOREIGN KEY ("SPEC_ID") REFERENCES public."INV_ITEM_SPEC"("SPEC_ID") ON DELETE RESTRICT;
 V   ALTER TABLE ONLY public."INV_GOODS_ADJUST" DROP CONSTRAINT "FK_GOODS_ADJUST_SPEC_ID";
       public          postgres    false    452    3957    251            �           2606    78814 $   INV_GOODS_REC_DETL FK_GOODS_BRAND_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_GOODS_REC_DETL"
    ADD CONSTRAINT "FK_GOODS_BRAND_ID" FOREIGN KEY ("BRAND_ID") REFERENCES public."INV_BRAND"("BRAND_ID") ON DELETE RESTRICT;
 R   ALTER TABLE ONLY public."INV_GOODS_REC_DETL" DROP CONSTRAINT "FK_GOODS_BRAND_ID";
       public          postgres    false    243    476    3941            �           2606    78819 (   INV_GOODS_REC_DETL FK_GOODS_DTL_MASTERID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_GOODS_REC_DETL"
    ADD CONSTRAINT "FK_GOODS_DTL_MASTERID" FOREIGN KEY ("GOODS_MASTER_ID") REFERENCES public."INV_GOODS_REC_MAST"("ID") ON DELETE RESTRICT;
 V   ALTER TABLE ONLY public."INV_GOODS_REC_DETL" DROP CONSTRAINT "FK_GOODS_DTL_MASTERID";
       public          postgres    false    453    476    4450            �           2606    78824 #   INV_GOODS_REC_DETL FK_GOODS_ITEM_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_GOODS_REC_DETL"
    ADD CONSTRAINT "FK_GOODS_ITEM_ID" FOREIGN KEY ("ITEM_ID") REFERENCES public."INV_ITEM_MST"("ITEM_ID") ON DELETE RESTRICT;
 Q   ALTER TABLE ONLY public."INV_GOODS_REC_DETL" DROP CONSTRAINT "FK_GOODS_ITEM_ID";
       public          postgres    false    388    476    4191            �           2606    78829 #   INV_GOODS_REC_DETL FK_GOODS_SPEC_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_GOODS_REC_DETL"
    ADD CONSTRAINT "FK_GOODS_SPEC_ID" FOREIGN KEY ("SPEC_ID") REFERENCES public."INV_ITEM_SPEC"("SPEC_ID") ON DELETE RESTRICT;
 Q   ALTER TABLE ONLY public."INV_GOODS_REC_DETL" DROP CONSTRAINT "FK_GOODS_SPEC_ID";
       public          postgres    false    3957    251    476            �           2606    78834 #   INV_GOODS_REC_DETL FK_GOODS_UNIT_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_GOODS_REC_DETL"
    ADD CONSTRAINT "FK_GOODS_UNIT_ID" FOREIGN KEY ("UNIT_ID") REFERENCES public."INV_UNIT"("UNIT_ID") ON DELETE RESTRICT;
 Q   ALTER TABLE ONLY public."INV_GOODS_REC_DETL" DROP CONSTRAINT "FK_GOODS_UNIT_ID";
       public          postgres    false    3981    476    265                       2606    77247 %   ACC_BANK_GRNTY FK_GRNTY_PERSON_ORG_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_BANK_GRNTY"
    ADD CONSTRAINT "FK_GRNTY_PERSON_ORG_ID" FOREIGN KEY ("PERSON_ID") REFERENCES public."ACC_ORG_MASTER"("ORG_ID") ON DELETE RESTRICT;
 S   ALTER TABLE ONLY public."ACC_BANK_GRNTY" DROP CONSTRAINT "FK_GRNTY_PERSON_ORG_ID";
       public          postgres    false    211    380    3902                       2606    77252    ACC_BANK_GRNTY FK_GRNTY_WORK_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_BANK_GRNTY"
    ADD CONSTRAINT "FK_GRNTY_WORK_ID" FOREIGN KEY ("WORK_ID") REFERENCES public."ACC_WORK_MASTER"("WORK_ID") ON DELETE RESTRICT;
 M   ALTER TABLE ONLY public."ACC_BANK_GRNTY" DROP CONSTRAINT "FK_GRNTY_WORK_ID";
       public          postgres    false    3916    380    220                       2606    77310 .   IMISRoleClaim FK_IMISRoleClaim_IMISRole_RoleId    FK CONSTRAINT     �   ALTER TABLE ONLY public."IMISRoleClaim"
    ADD CONSTRAINT "FK_IMISRoleClaim_IMISRole_RoleId" FOREIGN KEY ("RoleId") REFERENCES public."IMISRole"("Id") ON DELETE CASCADE;
 \   ALTER TABLE ONLY public."IMISRoleClaim" DROP CONSTRAINT "FK_IMISRoleClaim_IMISRole_RoleId";
       public          postgres    false    385    240    3936                       2606    77524 0   IMISUserClaim FK_IMISUserClaim_Usermaster_UserId    FK CONSTRAINT     �   ALTER TABLE ONLY public."IMISUserClaim"
    ADD CONSTRAINT "FK_IMISUserClaim_Usermaster_UserId" FOREIGN KEY ("UserId") REFERENCES public."Usermaster"("Id") ON DELETE CASCADE;
 ^   ALTER TABLE ONLY public."IMISUserClaim" DROP CONSTRAINT "FK_IMISUserClaim_Usermaster_UserId";
       public          postgres    false    4145    404    371                       2606    77537 0   IMISUserLogin FK_IMISUserLogin_Usermaster_UserId    FK CONSTRAINT     �   ALTER TABLE ONLY public."IMISUserLogin"
    ADD CONSTRAINT "FK_IMISUserLogin_Usermaster_UserId" FOREIGN KEY ("UserId") REFERENCES public."Usermaster"("Id") ON DELETE CASCADE;
 ^   ALTER TABLE ONLY public."IMISUserLogin" DROP CONSTRAINT "FK_IMISUserLogin_Usermaster_UserId";
       public          postgres    false    371    405    4145                        2606    77550 ,   IMISUserRole FK_IMISUserRole_IMISRole_RoleId    FK CONSTRAINT     �   ALTER TABLE ONLY public."IMISUserRole"
    ADD CONSTRAINT "FK_IMISUserRole_IMISRole_RoleId" FOREIGN KEY ("RoleId") REFERENCES public."IMISRole"("Id") ON DELETE CASCADE;
 Z   ALTER TABLE ONLY public."IMISUserRole" DROP CONSTRAINT "FK_IMISUserRole_IMISRole_RoleId";
       public          postgres    false    240    3936    406            !           2606    77555 .   IMISUserRole FK_IMISUserRole_Usermaster_UserId    FK CONSTRAINT     �   ALTER TABLE ONLY public."IMISUserRole"
    ADD CONSTRAINT "FK_IMISUserRole_Usermaster_UserId" FOREIGN KEY ("UserId") REFERENCES public."Usermaster"("Id") ON DELETE CASCADE;
 \   ALTER TABLE ONLY public."IMISUserRole" DROP CONSTRAINT "FK_IMISUserRole_Usermaster_UserId";
       public          postgres    false    371    4145    406            "           2606    77568 0   IMISUserToken FK_IMISUserToken_Usermaster_UserId    FK CONSTRAINT     �   ALTER TABLE ONLY public."IMISUserToken"
    ADD CONSTRAINT "FK_IMISUserToken_Usermaster_UserId" FOREIGN KEY ("UserId") REFERENCES public."Usermaster"("Id") ON DELETE CASCADE;
 ^   ALTER TABLE ONLY public."IMISUserToken" DROP CONSTRAINT "FK_IMISUserToken_Usermaster_UserId";
       public          postgres    false    4145    407    371            K           2606    77868 '   INCOMEBILLDETAILS FK_INBILL_DETL_ACC_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INCOMEBILLDETAILS"
    ADD CONSTRAINT "FK_INBILL_DETL_ACC_ID" FOREIGN KEY ("ACC_ID") REFERENCES public."ACC_ACC_MASTER"("ACC_ID") ON DELETE RESTRICT;
 U   ALTER TABLE ONLY public."INCOMEBILLDETAILS" DROP CONSTRAINT "FK_INBILL_DETL_ACC_ID";
       public          postgres    false    425    4160    378            L           2606    77873 '   INCOMEBILLDETAILS FK_INBILL_DET_VCHR_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INCOMEBILLDETAILS"
    ADD CONSTRAINT "FK_INBILL_DET_VCHR_ID" FOREIGN KEY ("VCHR_ID") REFERENCES public."ACC_VCHR_MASTER"("VCHR_ID") ON DELETE RESTRICT;
 U   ALTER TABLE ONLY public."INCOMEBILLDETAILS" DROP CONSTRAINT "FK_INBILL_DET_VCHR_ID";
       public          postgres    false    4163    379    425            M           2606    77896 '   INCOMEBILLMASTER FK_INBILL_MAST_VCHR_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INCOMEBILLMASTER"
    ADD CONSTRAINT "FK_INBILL_MAST_VCHR_ID" FOREIGN KEY ("VCHR_ID") REFERENCES public."ACC_VCHR_MASTER"("VCHR_ID") ON DELETE RESTRICT;
 U   ALTER TABLE ONLY public."INCOMEBILLMASTER" DROP CONSTRAINT "FK_INBILL_MAST_VCHR_ID";
       public          postgres    false    426    379    4163            �           2606    78633 (   PIS_INTERNAL_TRANSFER FK_INT_APNTMT_TYPE    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_INTERNAL_TRANSFER"
    ADD CONSTRAINT "FK_INT_APNTMT_TYPE" FOREIGN KEY ("APPOINTMNT_TYPE") REFERENCES public."PIS_APPOINTMENT_TYPE"("ID") ON DELETE RESTRICT;
 V   ALTER TABLE ONLY public."PIS_INTERNAL_TRANSFER" DROP CONSTRAINT "FK_INT_APNTMT_TYPE";
       public          postgres    false    4033    298    467            �           2606    78658 (   PIS_INTERNAL_TRANSFER FK_INT_LOC_POST_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_INTERNAL_TRANSFER"
    ADD CONSTRAINT "FK_INT_LOC_POST_ID" FOREIGN KEY ("TO_LOCAL_POST_ID") REFERENCES public."PIS_LOCAL_POST_MASTER"("LOCAL_POST_ID") ON DELETE RESTRICT;
 V   ALTER TABLE ONLY public."PIS_INTERNAL_TRANSFER" DROP CONSTRAINT "FK_INT_LOC_POST_ID";
       public          postgres    false    4219    467    396            �           2606    78653 +   PIS_INTERNAL_TRANSFER FK_INT_TO_APNTMT_TYPE    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_INTERNAL_TRANSFER"
    ADD CONSTRAINT "FK_INT_TO_APNTMT_TYPE" FOREIGN KEY ("TO_APPOINTMNT_TYPE") REFERENCES public."PIS_APPOINTMENT_TYPE"("ID") ON DELETE RESTRICT;
 Y   ALTER TABLE ONLY public."PIS_INTERNAL_TRANSFER" DROP CONSTRAINT "FK_INT_TO_APNTMT_TYPE";
       public          postgres    false    467    4033    298            �           2606    78638 /   PIS_INTERNAL_TRANSFER FK_INT_TRNSFR_DARBANDI_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_INTERNAL_TRANSFER"
    ADD CONSTRAINT "FK_INT_TRNSFR_DARBANDI_ID" FOREIGN KEY ("DARBANDI_ID") REFERENCES public."PIS_DARBANDI"("DARBANDI_ID") ON DELETE RESTRICT;
 ]   ALTER TABLE ONLY public."PIS_INTERNAL_TRANSFER" DROP CONSTRAINT "FK_INT_TRNSFR_DARBANDI_ID";
       public          postgres    false    467    4350    430            �           2606    78643 *   PIS_INTERNAL_TRANSFER FK_INT_TRNSFR_EMP_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_INTERNAL_TRANSFER"
    ADD CONSTRAINT "FK_INT_TRNSFR_EMP_ID" FOREIGN KEY ("EMP_ID") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 X   ALTER TABLE ONLY public."PIS_INTERNAL_TRANSFER" DROP CONSTRAINT "FK_INT_TRNSFR_EMP_ID";
       public          postgres    false    431    467    4357            �           2606    78648 -   PIS_INTERNAL_TRANSFER FK_INT_TRNSFR_OFFICE_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_INTERNAL_TRANSFER"
    ADD CONSTRAINT "FK_INT_TRNSFR_OFFICE_ID" FOREIGN KEY ("OFFICE_ID") REFERENCES public."ORGANIZATION_TREE"("ID") ON DELETE RESTRICT;
 [   ALTER TABLE ONLY public."PIS_INTERNAL_TRANSFER" DROP CONSTRAINT "FK_INT_TRNSFR_OFFICE_ID";
       public          postgres    false    395    467    4216            �           2606    78663 0   PIS_INTERNAL_TRANSFER FK_INT_TRNSFR_TO_OFFICE_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_INTERNAL_TRANSFER"
    ADD CONSTRAINT "FK_INT_TRNSFR_TO_OFFICE_ID" FOREIGN KEY ("TO_OFFICE_ID") REFERENCES public."ORGANIZATION_TREE"("ID") ON DELETE RESTRICT;
 ^   ALTER TABLE ONLY public."PIS_INTERNAL_TRANSFER" DROP CONSTRAINT "FK_INT_TRNSFR_TO_OFFICE_ID";
       public          postgres    false    395    4216    467            
           2606    77330 &   INV_LILAMAPPDETAILS FK_INV_APPLIMASTID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_LILAMAPPDETAILS"
    ADD CONSTRAINT "FK_INV_APPLIMASTID" FOREIGN KEY ("LILAMAPPLIID") REFERENCES public."INV_LILAM_APPMASTER"("ID") ON DELETE RESTRICT;
 T   ALTER TABLE ONLY public."INV_LILAMAPPDETAILS" DROP CONSTRAINT "FK_INV_APPLIMASTID";
       public          postgres    false    252    387    3959            S           2606    77926 (   INV_ISSUE_DETAIL FK_INV_ISS_DTL_BRAND_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_ISSUE_DETAIL"
    ADD CONSTRAINT "FK_INV_ISS_DTL_BRAND_ID" FOREIGN KEY ("BRAND_ID") REFERENCES public."INV_BRAND"("BRAND_ID") ON DELETE RESTRICT;
 V   ALTER TABLE ONLY public."INV_ISSUE_DETAIL" DROP CONSTRAINT "FK_INV_ISS_DTL_BRAND_ID";
       public          postgres    false    243    3941    428            T           2606    77931 '   INV_ISSUE_DETAIL FK_INV_ISS_DTL_ITEM_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_ISSUE_DETAIL"
    ADD CONSTRAINT "FK_INV_ISS_DTL_ITEM_ID" FOREIGN KEY ("ITEM_ID") REFERENCES public."INV_ITEM_MST"("ITEM_ID") ON DELETE RESTRICT;
 U   ALTER TABLE ONLY public."INV_ISSUE_DETAIL" DROP CONSTRAINT "FK_INV_ISS_DTL_ITEM_ID";
       public          postgres    false    388    4191    428            U           2606    77936 )   INV_ISSUE_DETAIL FK_INV_ISS_DTL_ITEM_TYPE    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_ISSUE_DETAIL"
    ADD CONSTRAINT "FK_INV_ISS_DTL_ITEM_TYPE" FOREIGN KEY ("ITEM_TYPE") REFERENCES public."INV_ITEM_CATEGORY"("ID") ON DELETE RESTRICT;
 W   ALTER TABLE ONLY public."INV_ISSUE_DETAIL" DROP CONSTRAINT "FK_INV_ISS_DTL_ITEM_TYPE";
       public          postgres    false    428    250    3955            V           2606    77941 '   INV_ISSUE_DETAIL FK_INV_ISS_DTL_SPEC_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_ISSUE_DETAIL"
    ADD CONSTRAINT "FK_INV_ISS_DTL_SPEC_ID" FOREIGN KEY ("SPEC_ID") REFERENCES public."INV_ITEM_SPEC"("SPEC_ID") ON DELETE RESTRICT;
 U   ALTER TABLE ONLY public."INV_ISSUE_DETAIL" DROP CONSTRAINT "FK_INV_ISS_DTL_SPEC_ID";
       public          postgres    false    3957    251    428            �           2606    78904 %   INV_PUR_ORDER_DETL FK_INV_PUR_MAST_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_PUR_ORDER_DETL"
    ADD CONSTRAINT "FK_INV_PUR_MAST_ID" FOREIGN KEY ("PUR_MST_ID") REFERENCES public."INV_PUR_ORDER_MAST"("ID") ON DELETE RESTRICT;
 S   ALTER TABLE ONLY public."INV_PUR_ORDER_DETL" DROP CONSTRAINT "FK_INV_PUR_MAST_ID";
       public          postgres    false    478    4464    455            �           2606    78488 (   INV_STATUS_DETAIL FK_INV_STADEL_ACCEPTBY    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_STATUS_DETAIL"
    ADD CONSTRAINT "FK_INV_STADEL_ACCEPTBY" FOREIGN KEY ("ACCEPTBY") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 V   ALTER TABLE ONLY public."INV_STATUS_DETAIL" DROP CONSTRAINT "FK_INV_STADEL_ACCEPTBY";
       public          postgres    false    431    457    4357            �           2606    78493 )   INV_STATUS_DETAIL FK_INV_STADEL_CHECKEDBY    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_STATUS_DETAIL"
    ADD CONSTRAINT "FK_INV_STADEL_CHECKEDBY" FOREIGN KEY ("CHECKEDBY") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 W   ALTER TABLE ONLY public."INV_STATUS_DETAIL" DROP CONSTRAINT "FK_INV_STADEL_CHECKEDBY";
       public          postgres    false    431    457    4357            �           2606    78498 %   INV_STATUS_DETAIL FK_INV_STADEL_PREBY    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_STATUS_DETAIL"
    ADD CONSTRAINT "FK_INV_STADEL_PREBY" FOREIGN KEY ("PREBY") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 S   ALTER TABLE ONLY public."INV_STATUS_DETAIL" DROP CONSTRAINT "FK_INV_STADEL_PREBY";
       public          postgres    false    4357    431    457            �           2606    78954 &   INV_REQ_DETAIL FK_IN_REQ_DETL_BRAND_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_REQ_DETAIL"
    ADD CONSTRAINT "FK_IN_REQ_DETL_BRAND_ID" FOREIGN KEY ("BRAND_ID") REFERENCES public."INV_BRAND"("BRAND_ID") ON DELETE RESTRICT;
 T   ALTER TABLE ONLY public."INV_REQ_DETAIL" DROP CONSTRAINT "FK_IN_REQ_DETL_BRAND_ID";
       public          postgres    false    3941    480    243            �           2606    78959 %   INV_REQ_DETAIL FK_IN_REQ_DETL_ITEM_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_REQ_DETAIL"
    ADD CONSTRAINT "FK_IN_REQ_DETL_ITEM_ID" FOREIGN KEY ("ITEM_ID") REFERENCES public."INV_ITEM_MST"("ITEM_ID") ON DELETE RESTRICT;
 S   ALTER TABLE ONLY public."INV_REQ_DETAIL" DROP CONSTRAINT "FK_IN_REQ_DETL_ITEM_ID";
       public          postgres    false    4191    480    388            �           2606    78964 '   INV_REQ_DETAIL FK_IN_REQ_DETL_MASTER_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_REQ_DETAIL"
    ADD CONSTRAINT "FK_IN_REQ_DETL_MASTER_ID" FOREIGN KEY ("REQ_MAST_ID") REFERENCES public."INV_REQUISITION_MAST"("ID") ON DELETE RESTRICT;
 U   ALTER TABLE ONLY public."INV_REQ_DETAIL" DROP CONSTRAINT "FK_IN_REQ_DETL_MASTER_ID";
       public          postgres    false    480    456    4472            �           2606    78969 %   INV_REQ_DETAIL FK_IN_REQ_DETL_SPEC_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_REQ_DETAIL"
    ADD CONSTRAINT "FK_IN_REQ_DETL_SPEC_ID" FOREIGN KEY ("SPEC_ID") REFERENCES public."INV_ITEM_SPEC"("SPEC_ID") ON DELETE RESTRICT;
 S   ALTER TABLE ONLY public."INV_REQ_DETAIL" DROP CONSTRAINT "FK_IN_REQ_DETL_SPEC_ID";
       public          postgres    false    3957    251    480            �           2606    78924 &   INV_ISSUE_MASTER FK_ISS_MAST_ACCEPT_BY    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_ISSUE_MASTER"
    ADD CONSTRAINT "FK_ISS_MAST_ACCEPT_BY" FOREIGN KEY ("ACCEPT_BY") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 T   ALTER TABLE ONLY public."INV_ISSUE_MASTER" DROP CONSTRAINT "FK_ISS_MAST_ACCEPT_BY";
       public          postgres    false    431    4357    479            �           2606    78929 %   INV_ISSUE_MASTER FK_ISS_MAST_CHECK_BY    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_ISSUE_MASTER"
    ADD CONSTRAINT "FK_ISS_MAST_CHECK_BY" FOREIGN KEY ("CHECK_BY") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 S   ALTER TABLE ONLY public."INV_ISSUE_MASTER" DROP CONSTRAINT "FK_ISS_MAST_CHECK_BY";
       public          postgres    false    479    431    4357            �           2606    78934 %   INV_ISSUE_MASTER FK_ISS_MAST_ISSUE_BY    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_ISSUE_MASTER"
    ADD CONSTRAINT "FK_ISS_MAST_ISSUE_BY" FOREIGN KEY ("ISSUE_BY") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 S   ALTER TABLE ONLY public."INV_ISSUE_MASTER" DROP CONSTRAINT "FK_ISS_MAST_ISSUE_BY";
       public          postgres    false    4357    479    431            �           2606    78939 $   INV_ISSUE_MASTER FK_ISS_MAST_PREP_BY    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_ISSUE_MASTER"
    ADD CONSTRAINT "FK_ISS_MAST_PREP_BY" FOREIGN KEY ("PREP_BY") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 R   ALTER TABLE ONLY public."INV_ISSUE_MASTER" DROP CONSTRAINT "FK_ISS_MAST_PREP_BY";
       public          postgres    false    479    4357    431            �           2606    78944 '   INV_ISSUE_MASTER FK_ISS_MAST_REQUEST_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_ISSUE_MASTER"
    ADD CONSTRAINT "FK_ISS_MAST_REQUEST_ID" FOREIGN KEY ("REQUEST_ID") REFERENCES public."INV_REQUISITION_MAST"("ID") ON DELETE RESTRICT;
 U   ALTER TABLE ONLY public."INV_ISSUE_MASTER" DROP CONSTRAINT "FK_ISS_MAST_REQUEST_ID";
       public          postgres    false    479    456    4472            �           2606    78844 '   INV_ITEM_DETAILS FK_ITEM_DETL_ACCEPT_BY    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_ITEM_DETAILS"
    ADD CONSTRAINT "FK_ITEM_DETL_ACCEPT_BY" FOREIGN KEY ("ACCEPT_BY") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 U   ALTER TABLE ONLY public."INV_ITEM_DETAILS" DROP CONSTRAINT "FK_ITEM_DETL_ACCEPT_BY";
       public          postgres    false    477    431    4357            �           2606    78849 &   INV_ITEM_DETAILS FK_ITEM_DETL_BRAND_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_ITEM_DETAILS"
    ADD CONSTRAINT "FK_ITEM_DETL_BRAND_ID" FOREIGN KEY ("BRAND_ID") REFERENCES public."INV_BRAND"("BRAND_ID") ON DELETE RESTRICT;
 T   ALTER TABLE ONLY public."INV_ITEM_DETAILS" DROP CONSTRAINT "FK_ITEM_DETL_BRAND_ID";
       public          postgres    false    3941    477    243            �           2606    78854 &   INV_ITEM_DETAILS FK_ITEM_DETL_CHECK_BY    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_ITEM_DETAILS"
    ADD CONSTRAINT "FK_ITEM_DETL_CHECK_BY" FOREIGN KEY ("CHECK_BY") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 T   ALTER TABLE ONLY public."INV_ITEM_DETAILS" DROP CONSTRAINT "FK_ITEM_DETL_CHECK_BY";
       public          postgres    false    477    4357    431            �           2606    78859 (   INV_ITEM_DETAILS FK_ITEM_DETL_DAKHILA_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_ITEM_DETAILS"
    ADD CONSTRAINT "FK_ITEM_DETL_DAKHILA_ID" FOREIGN KEY ("DAKHILA_ID") REFERENCES public."INV_GOODS_REC_MAST"("ID") ON DELETE RESTRICT;
 V   ALTER TABLE ONLY public."INV_ITEM_DETAILS" DROP CONSTRAINT "FK_ITEM_DETL_DAKHILA_ID";
       public          postgres    false    453    477    4450            �           2606    78864 '   INV_ITEM_DETAILS FK_ITEM_DETL_GD_ADJ_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_ITEM_DETAILS"
    ADD CONSTRAINT "FK_ITEM_DETL_GD_ADJ_ID" FOREIGN KEY ("GD_ADJ_ID") REFERENCES public."INV_GOODS_ADJUST"("ID") ON DELETE RESTRICT;
 U   ALTER TABLE ONLY public."INV_ITEM_DETAILS" DROP CONSTRAINT "FK_ITEM_DETL_GD_ADJ_ID";
       public          postgres    false    4445    477    452            �           2606    78869 %   INV_ITEM_DETAILS FK_ITEM_DETL_ITEM_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_ITEM_DETAILS"
    ADD CONSTRAINT "FK_ITEM_DETL_ITEM_ID" FOREIGN KEY ("ITEM_ID") REFERENCES public."INV_ITEM_MST"("ITEM_ID") ON DELETE RESTRICT;
 S   ALTER TABLE ONLY public."INV_ITEM_DETAILS" DROP CONSTRAINT "FK_ITEM_DETL_ITEM_ID";
       public          postgres    false    477    388    4191            �           2606    78874 %   INV_ITEM_DETAILS FK_ITEM_DETL_PREP_BY    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_ITEM_DETAILS"
    ADD CONSTRAINT "FK_ITEM_DETL_PREP_BY" FOREIGN KEY ("PREP_BY") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 S   ALTER TABLE ONLY public."INV_ITEM_DETAILS" DROP CONSTRAINT "FK_ITEM_DETL_PREP_BY";
       public          postgres    false    4357    431    477            �           2606    78879 %   INV_ITEM_DETAILS FK_ITEM_DETL_SPEC_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_ITEM_DETAILS"
    ADD CONSTRAINT "FK_ITEM_DETL_SPEC_ID" FOREIGN KEY ("SPEC_ID") REFERENCES public."INV_ITEM_SPEC"("SPEC_ID") ON DELETE RESTRICT;
 S   ALTER TABLE ONLY public."INV_ITEM_DETAILS" DROP CONSTRAINT "FK_ITEM_DETL_SPEC_ID";
       public          postgres    false    251    3957    477            �           2606    78397 )   INV_ITEM_STATUSCHECK FK_ITEM_STATUS_CHECK    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_ITEM_STATUSCHECK"
    ADD CONSTRAINT "FK_ITEM_STATUS_CHECK" FOREIGN KEY ("ITEM_ID") REFERENCES public."INV_ITEM_MST"("ITEM_ID") ON DELETE RESTRICT;
 W   ALTER TABLE ONLY public."INV_ITEM_STATUSCHECK" DROP CONSTRAINT "FK_ITEM_STATUS_CHECK";
       public          postgres    false    388    454    4191                       2606    77343    INV_ITEM_MST FK_ITEM_UNIT_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_ITEM_MST"
    ADD CONSTRAINT "FK_ITEM_UNIT_ID" FOREIGN KEY ("UNIT_ID") REFERENCES public."INV_UNIT"("UNIT_ID") ON DELETE RESTRICT;
 J   ALTER TABLE ONLY public."INV_ITEM_MST" DROP CONSTRAINT "FK_ITEM_UNIT_ID";
       public          postgres    false    388    3981    265            6           2606    77728 '   TBLVEH_SER_CH_MSTR FK_LAND_SERCH_ACC_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."TBLVEH_SER_CH_MSTR"
    ADD CONSTRAINT "FK_LAND_SERCH_ACC_ID" FOREIGN KEY ("ACC_ID") REFERENCES public."ACC_ACC_MASTER"("ACC_ID") ON DELETE RESTRICT;
 U   ALTER TABLE ONLY public."TBLVEH_SER_CH_MSTR" DROP CONSTRAINT "FK_LAND_SERCH_ACC_ID";
       public          postgres    false    4160    419    378            4           2606    77708 ,   TBL_LAND_OTHER_CHARGES FK_LAN_OTH_CHA_ACC_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."TBL_LAND_OTHER_CHARGES"
    ADD CONSTRAINT "FK_LAN_OTH_CHA_ACC_ID" FOREIGN KEY ("ACC_ID") REFERENCES public."ACC_ACC_MASTER"("ACC_ID") ON DELETE RESTRICT;
 Z   ALTER TABLE ONLY public."TBL_LAND_OTHER_CHARGES" DROP CONSTRAINT "FK_LAN_OTH_CHA_ACC_ID";
       public          postgres    false    4160    417    378            �           2606    78543 $   PIS_EMP_LONG_LEAVES FK_LEAVES_EMP_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_EMP_LONG_LEAVES"
    ADD CONSTRAINT "FK_LEAVES_EMP_ID" FOREIGN KEY ("EMP_ID") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 R   ALTER TABLE ONLY public."PIS_EMP_LONG_LEAVES" DROP CONSTRAINT "FK_LEAVES_EMP_ID";
       public          postgres    false    4357    431    461            �           2606    78548 )   PIS_EMP_LONG_LEAVES FK_LEAVES_LOC_POST_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_EMP_LONG_LEAVES"
    ADD CONSTRAINT "FK_LEAVES_LOC_POST_ID" FOREIGN KEY ("LOCAL_POST_ID") REFERENCES public."PIS_LOCAL_POST_MASTER"("LOCAL_POST_ID") ON DELETE RESTRICT;
 W   ALTER TABLE ONLY public."PIS_EMP_LONG_LEAVES" DROP CONSTRAINT "FK_LEAVES_LOC_POST_ID";
       public          postgres    false    461    396    4219            \           2606    77994 $   PIS_EMPLOYEE_MASTER FK_LOCAL_POST_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_EMPLOYEE_MASTER"
    ADD CONSTRAINT "FK_LOCAL_POST_ID" FOREIGN KEY ("LOCAL_POST_ID") REFERENCES public."PIS_LOCAL_POST_MASTER"("LOCAL_POST_ID") ON DELETE RESTRICT;
 R   ALTER TABLE ONLY public."PIS_EMPLOYEE_MASTER" DROP CONSTRAINT "FK_LOCAL_POST_ID";
       public          postgres    false    4219    396    431                       2606    77449 +   PIS_LOCAL_POST_MASTER FK_LO_PIS_POST_MASTER    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_LOCAL_POST_MASTER"
    ADD CONSTRAINT "FK_LO_PIS_POST_MASTER" FOREIGN KEY ("POST_ID") REFERENCES public."PIS_POST_MASTER"("POST_ID") ON DELETE RESTRICT;
 Y   ALTER TABLE ONLY public."PIS_LOCAL_POST_MASTER" DROP CONSTRAINT "FK_LO_PIS_POST_MASTER";
       public          postgres    false    4070    396    316            �           2606    78718 -   TBL_MALPOT_OTHER_CHARGES FK_MAL_OTH_CH_ACC_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."TBL_MALPOT_OTHER_CHARGES"
    ADD CONSTRAINT "FK_MAL_OTH_CH_ACC_ID" FOREIGN KEY ("ACC_ID") REFERENCES public."ACC_ACC_MASTER"("ACC_ID") ON DELETE RESTRICT;
 [   ALTER TABLE ONLY public."TBL_MALPOT_OTHER_CHARGES" DROP CONSTRAINT "FK_MAL_OTH_CH_ACC_ID";
       public          postgres    false    4160    378    471                        2606    77237 $   ACC_VCHR_MASTER FK_MAST_VCHR_TYPE_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_VCHR_MASTER"
    ADD CONSTRAINT "FK_MAST_VCHR_TYPE_ID" FOREIGN KEY ("VCHR_TYPE_ID") REFERENCES public."ACC_VCHR_TYPE_MASTER"("VCHR_TYPE_ID") ON DELETE RESTRICT;
 R   ALTER TABLE ONLY public."ACC_VCHR_MASTER" DROP CONSTRAINT "FK_MAST_VCHR_TYPE_ID";
       public          postgres    false    3914    219    379            �           2606    78558 !   PIS_EMP_MED_EXPENSE FK_MED_EMP_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_EMP_MED_EXPENSE"
    ADD CONSTRAINT "FK_MED_EMP_ID" FOREIGN KEY ("EMP_ID") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 O   ALTER TABLE ONLY public."PIS_EMP_MED_EXPENSE" DROP CONSTRAINT "FK_MED_EMP_ID";
       public          postgres    false    462    4357    431            �           2606    78563 &   PIS_EMP_MED_EXPENSE FK_MED_LOC_POST_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_EMP_MED_EXPENSE"
    ADD CONSTRAINT "FK_MED_LOC_POST_ID" FOREIGN KEY ("LOCAL_POST_ID") REFERENCES public."PIS_LOCAL_POST_MASTER"("LOCAL_POST_ID") ON DELETE RESTRICT;
 T   ALTER TABLE ONLY public."PIS_EMP_MED_EXPENSE" DROP CONSTRAINT "FK_MED_LOC_POST_ID";
       public          postgres    false    462    4219    396            /           2606    77663 %   MAP_INCOME_TYPE FK_MINCOME_TYPE_ACCID    FK CONSTRAINT     �   ALTER TABLE ONLY public."MAP_INCOME_TYPE"
    ADD CONSTRAINT "FK_MINCOME_TYPE_ACCID" FOREIGN KEY ("ACC_ID") REFERENCES public."ACC_ACC_MASTER"("ACC_ID") ON DELETE RESTRICT;
 S   ALTER TABLE ONLY public."MAP_INCOME_TYPE" DROP CONSTRAINT "FK_MINCOME_TYPE_ACCID";
       public          postgres    false    378    413    4160                       2606    77373    ACC_BUDJET_SOURCE FK_MIN_ACC    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_BUDJET_SOURCE"
    ADD CONSTRAINT "FK_MIN_ACC" FOREIGN KEY ("MIN_ACC_ID") REFERENCES public."MINISTRY_ACC_HEAD"("ID") ON DELETE CASCADE;
 J   ALTER TABLE ONLY public."ACC_BUDJET_SOURCE" DROP CONSTRAINT "FK_MIN_ACC";
       public          postgres    false    292    391    4023            �           2606    76805 .   PIS_NIJAMATI_SEWA_SAMUHA FK_NIJAMATI_PARENT_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_NIJAMATI_SEWA_SAMUHA"
    ADD CONSTRAINT "FK_NIJAMATI_PARENT_ID" FOREIGN KEY ("PARENT_ID") REFERENCES public."PIS_NIJAMATI_SEWA_SAMUHA"("ID") ON DELETE RESTRICT;
 \   ALTER TABLE ONLY public."PIS_NIJAMATI_SEWA_SAMUHA" DROP CONSTRAINT "FK_NIJAMATI_PARENT_ID";
       public          postgres    false    4058    310    310                       2606    77431    ORGANIZATION_TREE FK_ORG_GEO_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ORGANIZATION_TREE"
    ADD CONSTRAINT "FK_ORG_GEO_ID" FOREIGN KEY ("GEO_REGION") REFERENCES public."PIS_GEO_REGION"("ID") ON DELETE RESTRICT;
 M   ALTER TABLE ONLY public."ORGANIZATION_TREE" DROP CONSTRAINT "FK_ORG_GEO_ID";
       public          postgres    false    4047    305    395            R           2606    77916    ORG_BANK_ACCOUNT FK_ORG_MASTER    FK CONSTRAINT     �   ALTER TABLE ONLY public."ORG_BANK_ACCOUNT"
    ADD CONSTRAINT "FK_ORG_MASTER" FOREIGN KEY ("ORG_ID") REFERENCES public."ACC_ORG_MASTER"("ORG_ID") ON DELETE RESTRICT;
 L   ALTER TABLE ONLY public."ORG_BANK_ACCOUNT" DROP CONSTRAINT "FK_ORG_MASTER";
       public          postgres    false    427    211    3902                       2606    77436 "   ORGANIZATION_TREE FK_ORG_PARENT_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ORGANIZATION_TREE"
    ADD CONSTRAINT "FK_ORG_PARENT_ID" FOREIGN KEY ("PARENT_ID") REFERENCES public."ORGANIZATION_TREE"("ID") ON DELETE RESTRICT;
 P   ALTER TABLE ONLY public."ORGANIZATION_TREE" DROP CONSTRAINT "FK_ORG_PARENT_ID";
       public          postgres    false    395    4216    395            |           2606    78245 -   ACC_PAYMENT_DETAILS FK_PAM_DETAIL_PAYMENT_ID1    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_PAYMENT_DETAILS"
    ADD CONSTRAINT "FK_PAM_DETAIL_PAYMENT_ID1" FOREIGN KEY ("PAYMENT_ID") REFERENCES public."ACC_PAYMENT_MASTER"("PAYMENT_ID") ON DELETE RESTRICT;
 [   ALTER TABLE ONLY public."ACC_PAYMENT_DETAILS" DROP CONSTRAINT "FK_PAM_DETAIL_PAYMENT_ID1";
       public          postgres    false    422    4305    448            ]           2606    77999 !   PIS_EMPLOYEE_MASTER FK_PAYBANK_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_EMPLOYEE_MASTER"
    ADD CONSTRAINT "FK_PAYBANK_ID" FOREIGN KEY ("PAYEMENT_BANK_ID") REFERENCES public."BANKMASTER"("BANKID") ON DELETE RESTRICT;
 O   ALTER TABLE ONLY public."PIS_EMPLOYEE_MASTER" DROP CONSTRAINT "FK_PAYBANK_ID";
       public          postgres    false    223    431    3922            y           2606    78223 $   ACC_PAYMENT_DEDUCTION FK_PAYID_DEDUC    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_PAYMENT_DEDUCTION"
    ADD CONSTRAINT "FK_PAYID_DEDUC" FOREIGN KEY ("PAYMENT_ID") REFERENCES public."ACC_PAYMENT_MASTER"("PAYMENT_ID") ON DELETE RESTRICT;
 R   ALTER TABLE ONLY public."ACC_PAYMENT_DEDUCTION" DROP CONSTRAINT "FK_PAYID_DEDUC";
       public          postgres    false    4305    447    422            H           2606    77848 .   ACC_WORK_PAYMNT_TRANS FK_PAYMENT_PERSON_TYP_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_WORK_PAYMNT_TRANS"
    ADD CONSTRAINT "FK_PAYMENT_PERSON_TYP_ID" FOREIGN KEY ("PERSON_TYPE_ID") REFERENCES public."PERSON_TYPE_MASTER"("PERSON_TYPE_ID") ON DELETE RESTRICT;
 \   ALTER TABLE ONLY public."ACC_WORK_PAYMNT_TRANS" DROP CONSTRAINT "FK_PAYMENT_PERSON_TYP_ID";
       public          postgres    false    4031    297    424            I           2606    77853 (   ACC_WORK_PAYMNT_TRANS FK_PAYMENT_VCHR_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_WORK_PAYMNT_TRANS"
    ADD CONSTRAINT "FK_PAYMENT_VCHR_ID" FOREIGN KEY ("VCHR_ID") REFERENCES public."ACC_VCHR_MASTER"("VCHR_ID") ON DELETE RESTRICT;
 V   ALTER TABLE ONLY public."ACC_WORK_PAYMNT_TRANS" DROP CONSTRAINT "FK_PAYMENT_VCHR_ID";
       public          postgres    false    4163    379    424            J           2606    77858 '   ACC_WORK_PAYMNT_TRANS FK_PAYMENT_WORKID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_WORK_PAYMNT_TRANS"
    ADD CONSTRAINT "FK_PAYMENT_WORKID" FOREIGN KEY ("WORK_ID") REFERENCES public."ACC_WORK_MASTER"("WORK_ID") ON DELETE RESTRICT;
 U   ALTER TABLE ONLY public."ACC_WORK_PAYMNT_TRANS" DROP CONSTRAINT "FK_PAYMENT_WORKID";
       public          postgres    false    3916    424    220                       2606    78260 +   ACC_PAYMENT_DETAILS FK_PAYMNT_DETL_VCHR_ID1    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_PAYMENT_DETAILS"
    ADD CONSTRAINT "FK_PAYMNT_DETL_VCHR_ID1" FOREIGN KEY ("VCHR_ID") REFERENCES public."ACC_VCHR_MASTER"("VCHR_ID") ON DELETE RESTRICT;
 Y   ALTER TABLE ONLY public."ACC_PAYMENT_DETAILS" DROP CONSTRAINT "FK_PAYMNT_DETL_VCHR_ID1";
       public          postgres    false    4163    379    448            c           2606    78044 $   PIS_PUBLICATION FK_PBLCN_LOC_POST_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_PUBLICATION"
    ADD CONSTRAINT "FK_PBLCN_LOC_POST_ID" FOREIGN KEY ("LOCAL_POST_ID") REFERENCES public."PIS_LOCAL_POST_MASTER"("LOCAL_POST_ID") ON DELETE RESTRICT;
 R   ALTER TABLE ONLY public."PIS_PUBLICATION" DROP CONSTRAINT "FK_PBLCN_LOC_POST_ID";
       public          postgres    false    396    435    4219            �           2606    77206    ACC_PADADHIKARI_MSTR FK_POST_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_PADADHIKARI_MSTR"
    ADD CONSTRAINT "FK_POST_ID" FOREIGN KEY ("POST_ID") REFERENCES public."ACC_PADADHIKARI_POST"("POST_ID") ON DELETE RESTRICT;
 M   ALTER TABLE ONLY public."ACC_PADADHIKARI_MSTR" DROP CONSTRAINT "FK_POST_ID";
       public          postgres    false    3904    377    212            ^           2606    78004 '   PIS_EMPLOYEE_MASTER FK_POST_MST_POST_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_EMPLOYEE_MASTER"
    ADD CONSTRAINT "FK_POST_MST_POST_ID" FOREIGN KEY ("POST_ID") REFERENCES public."PIS_POST_MASTER"("POST_ID") ON DELETE RESTRICT;
 U   ALTER TABLE ONLY public."PIS_EMPLOYEE_MASTER" DROP CONSTRAINT "FK_POST_MST_POST_ID";
       public          postgres    false    316    4070    431            �           2606    78435 %   INV_PUR_ORDER_MAST FK_PREPARED_BY_USR    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_PUR_ORDER_MAST"
    ADD CONSTRAINT "FK_PREPARED_BY_USR" FOREIGN KEY ("PREPARED_BY") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 S   ALTER TABLE ONLY public."INV_PUR_ORDER_MAST" DROP CONSTRAINT "FK_PREPARED_BY_USR";
       public          postgres    false    4357    455    431            �           2606    78349 $   INV_GOODS_ADJUST FK_PREP_BY_GOOD_ADJ    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_GOODS_ADJUST"
    ADD CONSTRAINT "FK_PREP_BY_GOOD_ADJ" FOREIGN KEY ("PREP_BY") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 R   ALTER TABLE ONLY public."INV_GOODS_ADJUST" DROP CONSTRAINT "FK_PREP_BY_GOOD_ADJ";
       public          postgres    false    452    431    4357            �           2606    78377 &   INV_GOODS_REC_MAST FK_PREP_BY_GOOD_EMP    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_GOODS_REC_MAST"
    ADD CONSTRAINT "FK_PREP_BY_GOOD_EMP" FOREIGN KEY ("PREP_BY") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 T   ALTER TABLE ONLY public."INV_GOODS_REC_MAST" DROP CONSTRAINT "FK_PREP_BY_GOOD_EMP";
       public          postgres    false    453    4357    431            b           2606    78034    PIS_PRIZES FK_PRIZE_LOC_POST_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_PRIZES"
    ADD CONSTRAINT "FK_PRIZE_LOC_POST_ID" FOREIGN KEY ("LOCAL_POST_ID") REFERENCES public."PIS_LOCAL_POST_MASTER"("LOCAL_POST_ID") ON DELETE RESTRICT;
 M   ALTER TABLE ONLY public."PIS_PRIZES" DROP CONSTRAINT "FK_PRIZE_LOC_POST_ID";
       public          postgres    false    4219    434    396            �           2606    78573 #   PIS_EMP_PUNISHMNTS FK_PUNISH_EMP_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_EMP_PUNISHMNTS"
    ADD CONSTRAINT "FK_PUNISH_EMP_ID" FOREIGN KEY ("EMP_ID") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 Q   ALTER TABLE ONLY public."PIS_EMP_PUNISHMNTS" DROP CONSTRAINT "FK_PUNISH_EMP_ID";
       public          postgres    false    4357    431    463            �           2606    78578 (   PIS_EMP_PUNISHMNTS FK_PUNISH_LOC_POST_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_EMP_PUNISHMNTS"
    ADD CONSTRAINT "FK_PUNISH_LOC_POST_ID" FOREIGN KEY ("LOCAL_POST_ID") REFERENCES public."PIS_LOCAL_POST_MASTER"("LOCAL_POST_ID") ON DELETE RESTRICT;
 V   ALTER TABLE ONLY public."PIS_EMP_PUNISHMNTS" DROP CONSTRAINT "FK_PUNISH_LOC_POST_ID";
       public          postgres    false    463    4219    396            �           2606    78889 (   INV_PUR_ORDER_DETL FK_PUR_ORDER_BRAND_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_PUR_ORDER_DETL"
    ADD CONSTRAINT "FK_PUR_ORDER_BRAND_ID" FOREIGN KEY ("BRAND_ID") REFERENCES public."INV_BRAND"("BRAND_ID") ON DELETE RESTRICT;
 V   ALTER TABLE ONLY public."INV_PUR_ORDER_DETL" DROP CONSTRAINT "FK_PUR_ORDER_BRAND_ID";
       public          postgres    false    478    243    3941            �           2606    78894 '   INV_PUR_ORDER_DETL FK_PUR_ORDER_ITEM_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_PUR_ORDER_DETL"
    ADD CONSTRAINT "FK_PUR_ORDER_ITEM_ID" FOREIGN KEY ("ITEM_ID") REFERENCES public."INV_ITEM_MST"("ITEM_ID") ON DELETE RESTRICT;
 U   ALTER TABLE ONLY public."INV_PUR_ORDER_DETL" DROP CONSTRAINT "FK_PUR_ORDER_ITEM_ID";
       public          postgres    false    478    4191    388            �           2606    78899 )   INV_PUR_ORDER_DETL FK_PUR_ORDER_ITEM_TYPE    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_PUR_ORDER_DETL"
    ADD CONSTRAINT "FK_PUR_ORDER_ITEM_TYPE" FOREIGN KEY ("ITEM_TYPE") REFERENCES public."INV_ITEM_CATEGORY"("ID") ON DELETE RESTRICT;
 W   ALTER TABLE ONLY public."INV_PUR_ORDER_DETL" DROP CONSTRAINT "FK_PUR_ORDER_ITEM_TYPE";
       public          postgres    false    478    250    3955            �           2606    78909 '   INV_PUR_ORDER_DETL FK_PUR_ORDER_SPEC_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_PUR_ORDER_DETL"
    ADD CONSTRAINT "FK_PUR_ORDER_SPEC_ID" FOREIGN KEY ("SPEC_ID") REFERENCES public."INV_ITEM_SPEC"("SPEC_ID") ON DELETE RESTRICT;
 U   ALTER TABLE ONLY public."INV_PUR_ORDER_DETL" DROP CONSTRAINT "FK_PUR_ORDER_SPEC_ID";
       public          postgres    false    3957    478    251            �           2606    78914 '   INV_PUR_ORDER_DETL FK_PUR_ORDER_UNIT_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_PUR_ORDER_DETL"
    ADD CONSTRAINT "FK_PUR_ORDER_UNIT_ID" FOREIGN KEY ("UNIT_ID") REFERENCES public."INV_UNIT"("UNIT_ID") ON DELETE RESTRICT;
 U   ALTER TABLE ONLY public."INV_PUR_ORDER_DETL" DROP CONSTRAINT "FK_PUR_ORDER_UNIT_ID";
       public          postgres    false    265    3981    478            �           2606    78979 .   PIS_PYROLL_LOAN_DTLS FK_PYROLL_LOAN_DTLS_ACCID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_PYROLL_LOAN_DTLS"
    ADD CONSTRAINT "FK_PYROLL_LOAN_DTLS_ACCID" FOREIGN KEY ("ACC_ID") REFERENCES public."ACC_ACC_MASTER"("ACC_ID") ON DELETE RESTRICT;
 \   ALTER TABLE ONLY public."PIS_PYROLL_LOAN_DTLS" DROP CONSTRAINT "FK_PYROLL_LOAN_DTLS_ACCID";
       public          postgres    false    4160    481    378            �           2606    78984 .   PIS_PYROLL_LOAN_DTLS FK_PYROLL_LOAN_DTLS_EMPID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_PYROLL_LOAN_DTLS"
    ADD CONSTRAINT "FK_PYROLL_LOAN_DTLS_EMPID" FOREIGN KEY ("EMP_ID") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 \   ALTER TABLE ONLY public."PIS_PYROLL_LOAN_DTLS" DROP CONSTRAINT "FK_PYROLL_LOAN_DTLS_EMPID";
       public          postgres    false    481    4357    431            �           2606    78989 ,   PIS_PYROLL_LOAN_DTLS FK_PYROLL_LOAN_DTLS_LID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_PYROLL_LOAN_DTLS"
    ADD CONSTRAINT "FK_PYROLL_LOAN_DTLS_LID" FOREIGN KEY ("LOAND_ID") REFERENCES public."PIS_EMP_LOANS"("LOAN_ID") ON DELETE RESTRICT;
 Z   ALTER TABLE ONLY public."PIS_PYROLL_LOAN_DTLS" DROP CONSTRAINT "FK_PYROLL_LOAN_DTLS_LID";
       public          postgres    false    4487    460    481            �           2606    78994 -   PIS_PYROLL_LOAN_DTLS FK_PYROLL_LOAN_DTLS_PRID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_PYROLL_LOAN_DTLS"
    ADD CONSTRAINT "FK_PYROLL_LOAN_DTLS_PRID" FOREIGN KEY ("PAYROLL_ID") REFERENCES public."PIS_PAYROLLS"("ID") ON DELETE RESTRICT;
 [   ALTER TABLE ONLY public."PIS_PYROLL_LOAN_DTLS" DROP CONSTRAINT "FK_PYROLL_LOAN_DTLS_PRID";
       public          postgres    false    481    4062    312            �           2606    78678 +   PIS_PYROLL_OTHR_DTLS FK_PYROLL_OTHR_DTLS_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_PYROLL_OTHR_DTLS"
    ADD CONSTRAINT "FK_PYROLL_OTHR_DTLS_ID" FOREIGN KEY ("PAYROLL_ID") REFERENCES public."PIS_PAYROLLS"("ID") ON DELETE RESTRICT;
 Y   ALTER TABLE ONLY public."PIS_PYROLL_OTHR_DTLS" DROP CONSTRAINT "FK_PYROLL_OTHR_DTLS_ID";
       public          postgres    false    312    4062    468            �           2606    78673 -   PIS_PYROLL_OTHR_DTLS FK_PYROL_OTHR_DTLS_EMPID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_PYROLL_OTHR_DTLS"
    ADD CONSTRAINT "FK_PYROL_OTHR_DTLS_EMPID" FOREIGN KEY ("EMPLOYEE_ID") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 [   ALTER TABLE ONLY public."PIS_PYROLL_OTHR_DTLS" DROP CONSTRAINT "FK_PYROL_OTHR_DTLS_EMPID";
       public          postgres    false    468    431    4357                       2606    77363    MAP_REGION_FAR FK_REGIONID    FK CONSTRAINT     �   ALTER TABLE ONLY public."MAP_REGION_FAR"
    ADD CONSTRAINT "FK_REGIONID" FOREIGN KEY ("REGIONID") REFERENCES public."MAP_ZONE"("ID") ON DELETE RESTRICT;
 H   ALTER TABLE ONLY public."MAP_REGION_FAR" DROP CONSTRAINT "FK_REGIONID";
       public          postgres    false    390    290    4021                       2606    77353 &   MAP_AREA_GND_COV FK_REGN_ID_AP_GND_COV    FK CONSTRAINT     �   ALTER TABLE ONLY public."MAP_AREA_GND_COV"
    ADD CONSTRAINT "FK_REGN_ID_AP_GND_COV" FOREIGN KEY ("REGIONID") REFERENCES public."MAP_ZONE"("ID") ON DELETE RESTRICT;
 T   ALTER TABLE ONLY public."MAP_AREA_GND_COV" DROP CONSTRAINT "FK_REGN_ID_AP_GND_COV";
       public          postgres    false    4021    290    389            �           2606    78793 /   PIS_REPLACED_IN_DARBANDI FK_REPL_FD_DARBANDI_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_REPLACED_IN_DARBANDI"
    ADD CONSTRAINT "FK_REPL_FD_DARBANDI_ID" FOREIGN KEY ("DARBANDI_ID") REFERENCES public."PIS_DARBANDI"("DARBANDI_ID") ON DELETE RESTRICT;
 ]   ALTER TABLE ONLY public."PIS_REPLACED_IN_DARBANDI" DROP CONSTRAINT "FK_REPL_FD_DARBANDI_ID";
       public          postgres    false    4350    475    430            �           2606    78803 -   PIS_REPLACED_IN_DARBANDI FK_REPL_FD_OFFICE_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_REPLACED_IN_DARBANDI"
    ADD CONSTRAINT "FK_REPL_FD_OFFICE_ID" FOREIGN KEY ("OFFICE_ID") REFERENCES public."ORGANIZATION_TREE"("ID") ON DELETE RESTRICT;
 [   ALTER TABLE ONLY public."PIS_REPLACED_IN_DARBANDI" DROP CONSTRAINT "FK_REPL_FD_OFFICE_ID";
       public          postgres    false    4216    475    395            �           2606    78453 )   INV_REQUISITION_MAST FK_REQ_ACCEPT_BY_EMP    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_REQUISITION_MAST"
    ADD CONSTRAINT "FK_REQ_ACCEPT_BY_EMP" FOREIGN KEY ("ACCEPT_BY") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 W   ALTER TABLE ONLY public."INV_REQUISITION_MAST" DROP CONSTRAINT "FK_REQ_ACCEPT_BY_EMP";
       public          postgres    false    4357    456    431            �           2606    78458 (   INV_REQUISITION_MAST FK_REQ_CHECK_BY_EMP    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_REQUISITION_MAST"
    ADD CONSTRAINT "FK_REQ_CHECK_BY_EMP" FOREIGN KEY ("CHECK_BY") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 V   ALTER TABLE ONLY public."INV_REQUISITION_MAST" DROP CONSTRAINT "FK_REQ_CHECK_BY_EMP";
       public          postgres    false    431    4357    456            �           2606    78463 #   INV_REQUISITION_MAST FK_REQ_ITEM_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_REQUISITION_MAST"
    ADD CONSTRAINT "FK_REQ_ITEM_ID" FOREIGN KEY ("ITEM_ID") REFERENCES public."INV_ITEM_MST"("ITEM_ID") ON DELETE RESTRICT;
 Q   ALTER TABLE ONLY public."INV_REQUISITION_MAST" DROP CONSTRAINT "FK_REQ_ITEM_ID";
       public          postgres    false    456    4191    388            �           2606    78468 '   INV_REQUISITION_MAST FK_REQ_PREP_BY_EMP    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_REQUISITION_MAST"
    ADD CONSTRAINT "FK_REQ_PREP_BY_EMP" FOREIGN KEY ("PREP_BY") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 U   ALTER TABLE ONLY public."INV_REQUISITION_MAST" DROP CONSTRAINT "FK_REQ_PREP_BY_EMP";
       public          postgres    false    4357    456    431            �           2606    78473 &   INV_REQUISITION_MAST FK_REQ_PROJECT_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_REQUISITION_MAST"
    ADD CONSTRAINT "FK_REQ_PROJECT_ID" FOREIGN KEY ("PROJ_ID") REFERENCES public."INV_PROJECT"("PROJECT_ID") ON DELETE RESTRICT;
 T   ALTER TABLE ONLY public."INV_REQUISITION_MAST" DROP CONSTRAINT "FK_REQ_PROJECT_ID";
       public          postgres    false    3967    257    456            �           2606    78478 "   INV_REQUISITION_MAST FK_REQ_REQ_BY    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_REQUISITION_MAST"
    ADD CONSTRAINT "FK_REQ_REQ_BY" FOREIGN KEY ("REQ_BY") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 P   ALTER TABLE ONLY public."INV_REQUISITION_MAST" DROP CONSTRAINT "FK_REQ_REQ_BY";
       public          postgres    false    431    4357    456            	           2606    77320    INV_ROOM_MST FK_ROOM_DEP_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_ROOM_MST"
    ADD CONSTRAINT "FK_ROOM_DEP_ID" FOREIGN KEY ("DEPT_ID") REFERENCES public."INV_DEPT"("DEPT_ID") ON DELETE RESTRICT;
 I   ALTER TABLE ONLY public."INV_ROOM_MST" DROP CONSTRAINT "FK_ROOM_DEP_ID";
       public          postgres    false    246    386    3947            0           2606    77673 +   SERVICE_CHARGE_MASTER FK_SERVICE_CHR_ACC_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."SERVICE_CHARGE_MASTER"
    ADD CONSTRAINT "FK_SERVICE_CHR_ACC_ID" FOREIGN KEY ("ACC_ID") REFERENCES public."ACC_ACC_MASTER"("ACC_ID") ON DELETE RESTRICT;
 Y   ALTER TABLE ONLY public."SERVICE_CHARGE_MASTER" DROP CONSTRAINT "FK_SERVICE_CHR_ACC_ID";
       public          postgres    false    4160    414    378            d           2606    78054 &   PIS_SGNFCNT_WORK FK_SGNWRK_LOC_POST_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_SGNFCNT_WORK"
    ADD CONSTRAINT "FK_SGNWRK_LOC_POST_ID" FOREIGN KEY ("LOCAL_POST_ID") REFERENCES public."PIS_LOCAL_POST_MASTER"("LOCAL_POST_ID") ON DELETE RESTRICT;
 T   ALTER TABLE ONLY public."PIS_SGNFCNT_WORK" DROP CONSTRAINT "FK_SGNWRK_LOC_POST_ID";
       public          postgres    false    436    396    4219            �           2606    78588     PIS_EMP_SRVC_DTLS FK_SRVC_EMP_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_EMP_SRVC_DTLS"
    ADD CONSTRAINT "FK_SRVC_EMP_ID" FOREIGN KEY ("EMP_ID") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 N   ALTER TABLE ONLY public."PIS_EMP_SRVC_DTLS" DROP CONSTRAINT "FK_SRVC_EMP_ID";
       public          postgres    false    4357    464    431            �           2606    78593 %   PIS_EMP_SRVC_DTLS FK_SRVC_LOC_POST_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_EMP_SRVC_DTLS"
    ADD CONSTRAINT "FK_SRVC_LOC_POST_ID" FOREIGN KEY ("LOCAL_POST_ID") REFERENCES public."PIS_LOCAL_POST_MASTER"("LOCAL_POST_ID") ON DELETE RESTRICT;
 S   ALTER TABLE ONLY public."PIS_EMP_SRVC_DTLS" DROP CONSTRAINT "FK_SRVC_LOC_POST_ID";
       public          postgres    false    464    4219    396            �           2606    78387 -   INV_ITEM_STATUSCHECK FK_STATUSCHECK_ACCEPT_BY    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_ITEM_STATUSCHECK"
    ADD CONSTRAINT "FK_STATUSCHECK_ACCEPT_BY" FOREIGN KEY ("ACCEPTED_BY") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 [   ALTER TABLE ONLY public."INV_ITEM_STATUSCHECK" DROP CONSTRAINT "FK_STATUSCHECK_ACCEPT_BY";
       public          postgres    false    4357    431    454            �           2606    78392 ,   INV_ITEM_STATUSCHECK FK_STATUSCHECK_BRAND_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_ITEM_STATUSCHECK"
    ADD CONSTRAINT "FK_STATUSCHECK_BRAND_ID" FOREIGN KEY ("BRAND_ID") REFERENCES public."INV_BRAND"("BRAND_ID") ON DELETE RESTRICT;
 Z   ALTER TABLE ONLY public."INV_ITEM_STATUSCHECK" DROP CONSTRAINT "FK_STATUSCHECK_BRAND_ID";
       public          postgres    false    454    3941    243            �           2606    78412 ,   INV_ITEM_STATUSCHECK FK_STATUSCHECK_CHECK_BY    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_ITEM_STATUSCHECK"
    ADD CONSTRAINT "FK_STATUSCHECK_CHECK_BY" FOREIGN KEY ("TALLY_BY") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 Z   ALTER TABLE ONLY public."INV_ITEM_STATUSCHECK" DROP CONSTRAINT "FK_STATUSCHECK_CHECK_BY";
       public          postgres    false    431    4357    454            �           2606    78402 +   INV_ITEM_STATUSCHECK FK_STATUSCHECK_PREP_BY    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_ITEM_STATUSCHECK"
    ADD CONSTRAINT "FK_STATUSCHECK_PREP_BY" FOREIGN KEY ("PREP_BY") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 Y   ALTER TABLE ONLY public."INV_ITEM_STATUSCHECK" DROP CONSTRAINT "FK_STATUSCHECK_PREP_BY";
       public          postgres    false    454    431    4357            �           2606    78407 +   INV_ITEM_STATUSCHECK FK_STATUSCHECK_SPEC_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_ITEM_STATUSCHECK"
    ADD CONSTRAINT "FK_STATUSCHECK_SPEC_ID" FOREIGN KEY ("SPEC_ID") REFERENCES public."INV_ITEM_SPEC"("SPEC_ID") ON DELETE RESTRICT;
 Y   ALTER TABLE ONLY public."INV_ITEM_STATUSCHECK" DROP CONSTRAINT "FK_STATUSCHECK_SPEC_ID";
       public          postgres    false    454    3957    251            �           2606    78440 %   INV_PUR_ORDER_MAST FK_SUPP_ID_SPPLIER    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_PUR_ORDER_MAST"
    ADD CONSTRAINT "FK_SUPP_ID_SPPLIER" FOREIGN KEY ("SUPP_ID") REFERENCES public."INV_SUPPLIER"("SUP_ID") ON DELETE RESTRICT;
 S   ALTER TABLE ONLY public."INV_PUR_ORDER_MAST" DROP CONSTRAINT "FK_SUPP_ID_SPPLIER";
       public          postgres    false    3973    455    261            �           2606    78603 !   PIS_EMP_SUSPENDS FK_SUSPND_EMP_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_EMP_SUSPENDS"
    ADD CONSTRAINT "FK_SUSPND_EMP_ID" FOREIGN KEY ("EMP_ID") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 O   ALTER TABLE ONLY public."PIS_EMP_SUSPENDS" DROP CONSTRAINT "FK_SUSPND_EMP_ID";
       public          postgres    false    4357    431    465            �           2606    78608 &   PIS_EMP_SUSPENDS FK_SUSPND_LOC_POST_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_EMP_SUSPENDS"
    ADD CONSTRAINT "FK_SUSPND_LOC_POST_ID" FOREIGN KEY ("LOCAL_POST_ID") REFERENCES public."PIS_LOCAL_POST_MASTER"("LOCAL_POST_ID") ON DELETE RESTRICT;
 T   ALTER TABLE ONLY public."PIS_EMP_SUSPENDS" DROP CONSTRAINT "FK_SUSPND_LOC_POST_ID";
       public          postgres    false    465    4219    396            1           2606    77688 3   TAX_ADDTNL_CHRG_DTLS FK_TAX_ADDTNL_CHRG_DTLS_ACCODE    FK CONSTRAINT     �   ALTER TABLE ONLY public."TAX_ADDTNL_CHRG_DTLS"
    ADD CONSTRAINT "FK_TAX_ADDTNL_CHRG_DTLS_ACCODE" FOREIGN KEY ("ACCODE") REFERENCES public."ACCODE"("ACCODE") ON DELETE RESTRICT;
 a   ALTER TABLE ONLY public."TAX_ADDTNL_CHRG_DTLS" DROP CONSTRAINT "FK_TAX_ADDTNL_CHRG_DTLS_ACCODE";
       public          postgres    false    3918    415    221            2           2606    77683 *   TAX_ADDTNL_CHRG_DTLS FK_TAX_ADD_DTL_ACC_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."TAX_ADDTNL_CHRG_DTLS"
    ADD CONSTRAINT "FK_TAX_ADD_DTL_ACC_ID" FOREIGN KEY ("ACC_ID") REFERENCES public."ACC_ACC_MASTER"("ACC_ID") ON DELETE RESTRICT;
 X   ALTER TABLE ONLY public."TAX_ADDTNL_CHRG_DTLS" DROP CONSTRAINT "FK_TAX_ADD_DTL_ACC_ID";
       public          postgres    false    378    415    4160            %           2606    77598    ACC_BGT_TRANSFER FK_TO_ACC_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_BGT_TRANSFER"
    ADD CONSTRAINT "FK_TO_ACC_ID" FOREIGN KEY ("TO_ACC_ID") REFERENCES public."ACC_ACC_MASTER"("ACC_ID") ON DELETE RESTRICT;
 K   ALTER TABLE ONLY public."ACC_BGT_TRANSFER" DROP CONSTRAINT "FK_TO_ACC_ID";
       public          postgres    false    409    4160    378            �           2606    78783 *   PIS_DELETD_FRM_FULFILD_DARB FK_TO_SN_IN_FD    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_DELETD_FRM_FULFILD_DARB"
    ADD CONSTRAINT "FK_TO_SN_IN_FD" FOREIGN KEY ("TO_SN_IN_FD") REFERENCES public."PIS_FULFILLED_DARBANDI"("SN") ON DELETE RESTRICT;
 X   ALTER TABLE ONLY public."PIS_DELETD_FRM_FULFILD_DARB" DROP CONSTRAINT "FK_TO_SN_IN_FD";
       public          postgres    false    4438    474    451            e           2606    78064     PIS_TRAINING FK_TRNG_LOC_POST_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_TRAINING"
    ADD CONSTRAINT "FK_TRNG_LOC_POST_ID" FOREIGN KEY ("LOCAL_POST_ID") REFERENCES public."PIS_LOCAL_POST_MASTER"("LOCAL_POST_ID") ON DELETE RESTRICT;
 N   ALTER TABLE ONLY public."PIS_TRAINING" DROP CONSTRAINT "FK_TRNG_LOC_POST_ID";
       public          postgres    false    437    396    4219            &           2606    77588 '   ACC_BGT_TRANSFER FK_TRNSFR_BGT_ALCTN_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_BGT_TRANSFER"
    ADD CONSTRAINT "FK_TRNSFR_BGT_ALCTN_ID" FOREIGN KEY ("BGT_ALCTN_ID") REFERENCES public."ACC_BGT_ALLOCATE"("BGT_ALLOCATE_ID") ON DELETE RESTRICT;
 U   ALTER TABLE ONLY public."ACC_BGT_TRANSFER" DROP CONSTRAINT "FK_TRNSFR_BGT_ALCTN_ID";
       public          postgres    false    409    204    3888            �           2606    78618 #   PIS_EMP_TRNSFR_REC FK_TRNSFR_EMP_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_EMP_TRNSFR_REC"
    ADD CONSTRAINT "FK_TRNSFR_EMP_ID" FOREIGN KEY ("EMP_ID") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 Q   ALTER TABLE ONLY public."PIS_EMP_TRNSFR_REC" DROP CONSTRAINT "FK_TRNSFR_EMP_ID";
       public          postgres    false    4357    466    431            �           2606    78623 (   PIS_EMP_TRNSFR_REC FK_TRNSFR_LOC_POST_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_EMP_TRNSFR_REC"
    ADD CONSTRAINT "FK_TRNSFR_LOC_POST_ID" FOREIGN KEY ("LOCAL_POST_ID") REFERENCES public."PIS_LOCAL_POST_MASTER"("LOCAL_POST_ID") ON DELETE RESTRICT;
 V   ALTER TABLE ONLY public."PIS_EMP_TRNSFR_REC" DROP CONSTRAINT "FK_TRNSFR_LOC_POST_ID";
       public          postgres    false    396    466    4219            �           2606    78708 !   PIS_VISITED_COUNTRIES FK_VISIT_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_VISITED_COUNTRIES"
    ADD CONSTRAINT "FK_VISIT_ID" FOREIGN KEY ("VISIT_ID") REFERENCES public."PIS_FOREIGN_VISITS"("SN") ON DELETE RESTRICT;
 O   ALTER TABLE ONLY public."PIS_VISITED_COUNTRIES" DROP CONSTRAINT "FK_VISIT_ID";
       public          postgres    false    4360    432    470            �           2606    78688    WARD_MASTER FK_WARD_PRAMUKH_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."WARD_MASTER"
    ADD CONSTRAINT "FK_WARD_PRAMUKH_ID" FOREIGN KEY ("PRAMUKH_ID") REFERENCES public."ACC_PADADHIKARI_MSTR"("PADADIKARI_ID") ON DELETE RESTRICT;
 L   ALTER TABLE ONLY public."WARD_MASTER" DROP CONSTRAINT "FK_WARD_PRAMUKH_ID";
       public          postgres    false    4157    469    377            �           2606    78698     WARD_MASTER FK_WARD_SECRETARY_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."WARD_MASTER"
    ADD CONSTRAINT "FK_WARD_SECRETARY_ID" FOREIGN KEY ("WARD_SECRETARY_ID") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 N   ALTER TABLE ONLY public."WARD_MASTER" DROP CONSTRAINT "FK_WARD_SECRETARY_ID";
       public          postgres    false    4357    469    431            �           2606    78693 !   WARD_MASTER FK_WARD_UPAPRAMUKH_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."WARD_MASTER"
    ADD CONSTRAINT "FK_WARD_UPAPRAMUKH_ID" FOREIGN KEY ("UPPRAMUKH_ID") REFERENCES public."ACC_PADADHIKARI_MSTR"("PADADIKARI_ID") ON DELETE RESTRICT;
 O   ALTER TABLE ONLY public."WARD_MASTER" DROP CONSTRAINT "FK_WARD_UPAPRAMUKH_ID";
       public          postgres    false    469    4157    377                       2606    77267 '   ACC_WORK_FUNDS_DETAIL FK_WORK_MASTER_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_WORK_FUNDS_DETAIL"
    ADD CONSTRAINT "FK_WORK_MASTER_ID" FOREIGN KEY ("WORK_ID") REFERENCES public."ACC_WORK_MASTER"("WORK_ID") ON DELETE RESTRICT;
 U   ALTER TABLE ONLY public."ACC_WORK_FUNDS_DETAIL" DROP CONSTRAINT "FK_WORK_MASTER_ID";
       public          postgres    false    381    3916    220            f           2606    78074 "   PIS_WORKSHOP FK_WRKSHP_LOC_POST_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_WORKSHOP"
    ADD CONSTRAINT "FK_WRKSHP_LOC_POST_ID" FOREIGN KEY ("LOCAL_POST_ID") REFERENCES public."PIS_LOCAL_POST_MASTER"("LOCAL_POST_ID") ON DELETE RESTRICT;
 P   ALTER TABLE ONLY public."PIS_WORKSHOP" DROP CONSTRAINT "FK_WRKSHP_LOC_POST_ID";
       public          postgres    false    438    396    4219            �           2606    78287    ACC_BANK_TRANS FK__BANK_VCHR_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_BANK_TRANS"
    ADD CONSTRAINT "FK__BANK_VCHR_ID" FOREIGN KEY ("VCHR_ID") REFERENCES public."ACC_VCHR_MASTER"("VCHR_ID") ON DELETE RESTRICT;
 M   ALTER TABLE ONLY public."ACC_BANK_TRANS" DROP CONSTRAINT "FK__BANK_VCHR_ID";
       public          postgres    false    449    4163    379            ;           2606    77766 !   ACC_DHRTI_BILL_MASTER SYS_C004315    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_DHRTI_BILL_MASTER"
    ADD CONSTRAINT "SYS_C004315" FOREIGN KEY ("SUB_MODULE_ID") REFERENCES public."ACC_SUB_MODULE_TYPE"("SUB_MODULE_ID") ON DELETE RESTRICT;
 O   ALTER TABLE ONLY public."ACC_DHRTI_BILL_MASTER" DROP CONSTRAINT "SYS_C004315";
       public          postgres    false    215    421    3906            N           2606    77891    INCOMEBILLMASTER SYS_C004316    FK CONSTRAINT     �   ALTER TABLE ONLY public."INCOMEBILLMASTER"
    ADD CONSTRAINT "SYS_C004316" FOREIGN KEY ("SUB_MODULE_ID") REFERENCES public."ACC_SUB_MODULE_TYPE"("SUB_MODULE_ID") ON DELETE RESTRICT;
 J   ALTER TABLE ONLY public."INCOMEBILLMASTER" DROP CONSTRAINT "SYS_C004316";
       public          postgres    false    215    3906    426                       2606    77295    SUB_MODULE_SOURCE SYS_C004317    FK CONSTRAINT     �   ALTER TABLE ONLY public."SUB_MODULE_SOURCE"
    ADD CONSTRAINT "SYS_C004317" FOREIGN KEY ("SUB_MODULE_ID") REFERENCES public."ACC_SUB_MODULE_TYPE"("SUB_MODULE_ID") ON DELETE RESTRICT;
 K   ALTER TABLE ONLY public."SUB_MODULE_SOURCE" DROP CONSTRAINT "SYS_C004317";
       public          postgres    false    383    3906    215            u           2606    78198    CASHTRANSACTION SYS_C004318    FK CONSTRAINT     �   ALTER TABLE ONLY public."CASHTRANSACTION"
    ADD CONSTRAINT "SYS_C004318" FOREIGN KEY ("SUBMODULE_TYPE_ID") REFERENCES public."ACC_SUB_MODULE_TYPE"("SUB_MODULE_ID") ON DELETE RESTRICT;
 I   ALTER TABLE ONLY public."CASHTRANSACTION" DROP CONSTRAINT "SYS_C004318";
       public          postgres    false    3906    446    215            r           2606    78175    BANKTRANSACTIONS SYS_C004319    FK CONSTRAINT     �   ALTER TABLE ONLY public."BANKTRANSACTIONS"
    ADD CONSTRAINT "SYS_C004319" FOREIGN KEY ("SUBMODULE_TYPE_ID") REFERENCES public."ACC_SUB_MODULE_TYPE"("SUB_MODULE_ID") ON DELETE RESTRICT;
 J   ALTER TABLE ONLY public."BANKTRANSACTIONS" DROP CONSTRAINT "SYS_C004319";
       public          postgres    false    445    215    3906            <           2606    77776 !   ACC_DHRTI_BILL_MASTER SYS_C004344    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_DHRTI_BILL_MASTER"
    ADD CONSTRAINT "SYS_C004344" FOREIGN KEY ("WORK_ID") REFERENCES public."ACC_WORK_MASTER"("WORK_ID") ON DELETE RESTRICT;
 O   ALTER TABLE ONLY public."ACC_DHRTI_BILL_MASTER" DROP CONSTRAINT "SYS_C004344";
       public          postgres    false    421    220    3916            9           2606    77748    ACC_DHRTI_BILL_DTL SYS_C004345    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_DHRTI_BILL_DTL"
    ADD CONSTRAINT "SYS_C004345" FOREIGN KEY ("WORK_ID") REFERENCES public."ACC_WORK_MASTER"("WORK_ID") ON DELETE RESTRICT;
 L   ALTER TABLE ONLY public."ACC_DHRTI_BILL_DTL" DROP CONSTRAINT "SYS_C004345";
       public          postgres    false    420    3916    220            G           2606    77838    ACC_VCHR_DETAILS SYS_C004349    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_VCHR_DETAILS"
    ADD CONSTRAINT "SYS_C004349" FOREIGN KEY ("WORK_ID") REFERENCES public."ACC_WORK_MASTER"("WORK_ID") ON DELETE RESTRICT;
 J   ALTER TABLE ONLY public."ACC_VCHR_DETAILS" DROP CONSTRAINT "SYS_C004349";
       public          postgres    false    3916    220    423                       2606    77416    PIS_EMP_DEP_SOURCE SYS_C004356    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_EMP_DEP_SOURCE"
    ADD CONSTRAINT "SYS_C004356" FOREIGN KEY ("BUDJET_SOURCE_ID") REFERENCES public."BUDJET_SOURCE"("ID") ON DELETE RESTRICT;
 L   ALTER TABLE ONLY public."PIS_EMP_DEP_SOURCE" DROP CONSTRAINT "SYS_C004356";
       public          postgres    false    3924    394    224                       2606    77290    SUB_MODULE_SOURCE SYS_C004357    FK CONSTRAINT     �   ALTER TABLE ONLY public."SUB_MODULE_SOURCE"
    ADD CONSTRAINT "SYS_C004357" FOREIGN KEY ("BUDJET_SOURCE_ID") REFERENCES public."BUDJET_SOURCE"("ID") ON DELETE RESTRICT;
 K   ALTER TABLE ONLY public."SUB_MODULE_SOURCE" DROP CONSTRAINT "SYS_C004357";
       public          postgres    false    3924    224    383            l           2606    78127     TAX_THLI_ISSUED_CNTR SYS_C004358    FK CONSTRAINT     �   ALTER TABLE ONLY public."TAX_THLI_ISSUED_CNTR"
    ADD CONSTRAINT "SYS_C004358" FOREIGN KEY ("CNTR_ID") REFERENCES public."COLLECTIONCOUNTERS"("COUNTERID") ON DELETE RESTRICT;
 N   ALTER TABLE ONLY public."TAX_THLI_ISSUED_CNTR" DROP CONSTRAINT "SYS_C004358";
       public          postgres    false    442    228    3926                       2606    77459    SANITATION_SUBGROUP SYS_C004385    FK CONSTRAINT     �   ALTER TABLE ONLY public."SANITATION_SUBGROUP"
    ADD CONSTRAINT "SYS_C004385" FOREIGN KEY ("GROUPID") REFERENCES public."SANITATION_GROUP"("ID") ON DELETE RESTRICT;
 M   ALTER TABLE ONLY public."SANITATION_SUBGROUP" DROP CONSTRAINT "SYS_C004385";
       public          postgres    false    323    397    4080            g           2606    78087    SANITATION_RATE SYS_C004386    FK CONSTRAINT     �   ALTER TABLE ONLY public."SANITATION_RATE"
    ADD CONSTRAINT "SYS_C004386" FOREIGN KEY ("GROUPID") REFERENCES public."SANITATION_GROUP"("ID") ON DELETE RESTRICT;
 I   ALTER TABLE ONLY public."SANITATION_RATE" DROP CONSTRAINT "SYS_C004386";
       public          postgres    false    439    323    4080            h           2606    78092    SANITATION_RATE SYS_C004387    FK CONSTRAINT     �   ALTER TABLE ONLY public."SANITATION_RATE"
    ADD CONSTRAINT "SYS_C004387" FOREIGN KEY ("SUBGROUPID") REFERENCES public."SANITATION_SUBGROUP"("ID") ON DELETE RESTRICT;
 I   ALTER TABLE ONLY public."SANITATION_RATE" DROP CONSTRAINT "SYS_C004387";
       public          postgres    false    439    397    4222            m           2606    78132     TAX_THLI_ISSUED_CNTR SYS_C004388    FK CONSTRAINT     �   ALTER TABLE ONLY public."TAX_THLI_ISSUED_CNTR"
    ADD CONSTRAINT "SYS_C004388" FOREIGN KEY ("THELI_ID") REFERENCES public."STOREDBILLS"("SN") ON DELETE RESTRICT;
 N   ALTER TABLE ONLY public."TAX_THLI_ISSUED_CNTR" DROP CONSTRAINT "SYS_C004388";
       public          postgres    false    442    401    4234            =           2606    77761 !   ACC_DHRTI_BILL_MASTER SYS_C004389    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_DHRTI_BILL_MASTER"
    ADD CONSTRAINT "SYS_C004389" FOREIGN KEY ("BILLTYPEID") REFERENCES public."TBLBILLTYPE"("ID") ON DELETE RESTRICT;
 O   ALTER TABLE ONLY public."ACC_DHRTI_BILL_MASTER" DROP CONSTRAINT "SYS_C004389";
       public          postgres    false    421    360    4134            O           2606    77886    INCOMEBILLMASTER SYS_C004390    FK CONSTRAINT     �   ALTER TABLE ONLY public."INCOMEBILLMASTER"
    ADD CONSTRAINT "SYS_C004390" FOREIGN KEY ("BILLTYPEID") REFERENCES public."TBLBILLTYPE"("ID") ON DELETE RESTRICT;
 J   ALTER TABLE ONLY public."INCOMEBILLMASTER" DROP CONSTRAINT "SYS_C004390";
       public          postgres    false    426    360    4134                       2606    77499    STOREDBILLS SYS_C004391    FK CONSTRAINT     �   ALTER TABLE ONLY public."STOREDBILLS"
    ADD CONSTRAINT "SYS_C004391" FOREIGN KEY ("BILLTYPEID") REFERENCES public."TBLBILLTYPE"("ID") ON DELETE RESTRICT;
 E   ALTER TABLE ONLY public."STOREDBILLS" DROP CONSTRAINT "SYS_C004391";
       public          postgres    false    360    401    4134                       2606    77509    TBLMALPOTSUBGROUP SYS_C004392    FK CONSTRAINT     �   ALTER TABLE ONLY public."TBLMALPOTSUBGROUP"
    ADD CONSTRAINT "SYS_C004392" FOREIGN KEY ("GROUPID") REFERENCES public."TBLMALPOTGROUP"("ID") ON DELETE RESTRICT;
 K   ALTER TABLE ONLY public."TBLMALPOTSUBGROUP" DROP CONSTRAINT "SYS_C004392";
       public          postgres    false    402    365    4140            n           2606    78142    TBLMALPOTRATES SYS_C004393    FK CONSTRAINT     �   ALTER TABLE ONLY public."TBLMALPOTRATES"
    ADD CONSTRAINT "SYS_C004393" FOREIGN KEY ("GROUPID") REFERENCES public."TBLMALPOTGROUP"("ID") ON DELETE RESTRICT;
 H   ALTER TABLE ONLY public."TBLMALPOTRATES" DROP CONSTRAINT "SYS_C004393";
       public          postgres    false    443    365    4140            �           2606    78733     TBLFYWISEMPOTASSRATE SYS_C004394    FK CONSTRAINT     �   ALTER TABLE ONLY public."TBLFYWISEMPOTASSRATE"
    ADD CONSTRAINT "SYS_C004394" FOREIGN KEY ("GROUPID") REFERENCES public."TBLMALPOTGROUP"("ID") ON DELETE RESTRICT;
 N   ALTER TABLE ONLY public."TBLFYWISEMPOTASSRATE" DROP CONSTRAINT "SYS_C004394";
       public          postgres    false    365    472    4140            �           2606    78738     TBLFYWISEMPOTASSRATE SYS_C004395    FK CONSTRAINT     �   ALTER TABLE ONLY public."TBLFYWISEMPOTASSRATE"
    ADD CONSTRAINT "SYS_C004395" FOREIGN KEY ("RATEID") REFERENCES public."TBLMALPOTRATES"("ID") ON DELETE RESTRICT;
 N   ALTER TABLE ONLY public."TBLFYWISEMPOTASSRATE" DROP CONSTRAINT "SYS_C004395";
       public          postgres    false    472    443    4397            �           2606    78723 $   TBL_MALPOT_OTHER_CHARGES SYS_C004396    FK CONSTRAINT     �   ALTER TABLE ONLY public."TBL_MALPOT_OTHER_CHARGES"
    ADD CONSTRAINT "SYS_C004396" FOREIGN KEY ("RATEID") REFERENCES public."TBLMALPOTRATES"("ID") ON DELETE RESTRICT;
 R   ALTER TABLE ONLY public."TBL_MALPOT_OTHER_CHARGES" DROP CONSTRAINT "SYS_C004396";
       public          postgres    false    4397    443    471            o           2606    78147    TBLMALPOTRATES SYS_C004397    FK CONSTRAINT     �   ALTER TABLE ONLY public."TBLMALPOTRATES"
    ADD CONSTRAINT "SYS_C004397" FOREIGN KEY ("SUBGROUPID") REFERENCES public."TBLMALPOTSUBGROUP"("ID") ON DELETE RESTRICT;
 H   ALTER TABLE ONLY public."TBLMALPOTRATES" DROP CONSTRAINT "SYS_C004397";
       public          postgres    false    443    402    4237            �           2606    78743     TBLFYWISEMPOTASSRATE SYS_C004398    FK CONSTRAINT     �   ALTER TABLE ONLY public."TBLFYWISEMPOTASSRATE"
    ADD CONSTRAINT "SYS_C004398" FOREIGN KEY ("SUBGROUPID") REFERENCES public."TBLMALPOTSUBGROUP"("ID") ON DELETE RESTRICT;
 N   ALTER TABLE ONLY public."TBLFYWISEMPOTASSRATE" DROP CONSTRAINT "SYS_C004398";
       public          postgres    false    402    472    4237                       2606    77421    PIS_EMP_DEP_SOURCE SYS_C004447    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_EMP_DEP_SOURCE"
    ADD CONSTRAINT "SYS_C004447" FOREIGN KEY ("DEPT_ID") REFERENCES public."PIS_EMP_DEP"("DEPT_ID") ON DELETE CASCADE;
 L   ALTER TABLE ONLY public."PIS_EMP_DEP_SOURCE" DROP CONSTRAINT "SYS_C004447";
       public          postgres    false    394    4043    303            _           2606    77984    PIS_EMPLOYEE_MASTER SYS_C004448    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_EMPLOYEE_MASTER"
    ADD CONSTRAINT "SYS_C004448" FOREIGN KEY ("DEPT_ID") REFERENCES public."PIS_EMP_DEP"("DEPT_ID") ON DELETE RESTRICT;
 M   ALTER TABLE ONLY public."PIS_EMPLOYEE_MASTER" DROP CONSTRAINT "SYS_C004448";
       public          postgres    false    303    431    4043            v           2606    78193    CASHTRANSACTION SYS_C004544    FK CONSTRAINT     �   ALTER TABLE ONLY public."CASHTRANSACTION"
    ADD CONSTRAINT "SYS_C004544" FOREIGN KEY ("DHRTI_MASTER_ID") REFERENCES public."ACC_DHRTI_BILL_MASTER"("DHRTI_MASTER_ID") ON DELETE RESTRICT;
 I   ALTER TABLE ONLY public."CASHTRANSACTION" DROP CONSTRAINT "SYS_C004544";
       public          postgres    false    446    4299    421            s           2606    78170    BANKTRANSACTIONS SYS_C004545    FK CONSTRAINT     �   ALTER TABLE ONLY public."BANKTRANSACTIONS"
    ADD CONSTRAINT "SYS_C004545" FOREIGN KEY ("DHRTI_MASTER_ID") REFERENCES public."ACC_DHRTI_BILL_MASTER"("DHRTI_MASTER_ID") ON DELETE RESTRICT;
 J   ALTER TABLE ONLY public."BANKTRANSACTIONS" DROP CONSTRAINT "SYS_C004545";
       public          postgres    false    445    421    4299            �      x������ � �            x������ � �      +      x������ � �            x������ � �      n      x������ � �      d      x������ � �      o      x������ � �            x������ � �      <      x������ � �      *      x������ � �      e      x������ � �      p      x������ � �      q      x������ � �            x������ � �      G      x������ � �      H      x������ � �      =      x������ � �      r      x������ � �      s      x������ � �      u      x������ � �      t      x������ � �      v      x������ � �            x������ � �      w      x������ � �      >      x������ � �      x      x������ � �      b      x������ � �      c      x������ � �      I      x������ � �      y      x������ � �      z      x������ � �      {      x������ � �      |      x������ � �      }      x������ � �      J      x������ � �            x������ � �      ~      x������ � �             x������ � �            x������ � �      K      x������ � �      �      x������ � �      �      x������ � �      `      x������ � �      !      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      a      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      ?      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      $      x������ � �      7      x������ � �      8      x������ � �      9      x������ � �      :      x������ � �      L      x������ � �      �      x������ � �      M      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      g      x������ � �            x������ � �      h      x������ � �      �      x������ � �      �      x������ � �      O      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      '      x������ � �      �      x������ � �      i      x������ � �      &      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      j      x������ � �      �      x������ � �      k      x������ � �      �      x������ � �      %      x������ � �      l      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �   J  x����j�@���S�(�dYvz��B��:����V�����>��J
�G��K	]��u�R�)}�}�H�� �Ĳ;#��?3;sp��g�e@�Y�����b�I�Q��rÎg�=X'��-���v0%^����"?��������7H�%���<�S䧆��v,l�a� ^�̈́_?ctr8K����|J�Q�vFl2�\H�������踐
��o�?!eS�kX�HCmk�8�Xi�%1�}�ƬM��N�Xb�ry<��W`����M���t�Н�QJ��,J▴��b߬�U]u� ����m����$m�[<+�����C�jy�u�>&��4�ٝ�-�-��*�w `Q\@iWK���)��0���8��6|[PQ���_ܸ���Ңˇ�U�+=g#�(�M7��8�w�WJ�"������^��j���9�#v��ɋl��J!7��K]_K�k�в(fմ)O�`�����i���&C,?�-������/v���� ��xf�<#!e����߮(�i�o�(�qv?,�/����S��D�5��[��y՜_kh�C�v̗;�i����      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      (      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      @      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      )      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      .      x������ � �      N      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      P      x������ � �      m      x������ � �      Q      x������ � �      }      x������ � �      ,      x������ � �      �      x������ � �      �      x������ � �      R      x������ � �      n      x������ � �      �      x������ � �      �      x������ � �      -      x������ � �      �      x������ � �      o      x������ � �      p      x������ � �      q      x������ � �      r      x������ � �      s      x������ � �      t      x������ � �      u      x������ � �      S      x������ � �      f      x������ � �      �      x������ � �      �      x������ � �      v      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      /      x������ � �      �      x������ � �      �      x������ � �      T      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      U      x������ � �      V      x������ � �      �      x������ � �      w      x������ � �      ~      x������ � �      �      x������ � �      W      x������ � �      �      x������ � �      X      x������ � �      y      x������ � �      Y      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      Z      x������ � �      0      x������ � �      A      x������ � �      �      x������ � �      4      x������ � �      �      x������ � �      "      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      B      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      ]      x������ � �      �      x������ � �            x������ � �      E      x������ � �            x������ � �            x������ � �      {      x������ � �            x������ � �            x������ � �            x������ � �      ^      x������ � �      5      x������ � �            x������ � �            x������ � �      F      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      1      x������ � �      2      x������ � �      _      x������ � �      �      x������ � �      ;      x������ � �      [      x������ � �      \      x������ � �      |      x������ � �            x������ � �      C      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      D      x������ � �      z      x������ � �      �      x������ � �             x������ � �            x������ � �      3      x������ � �            x������ � �            x������ � �            x������ � �            x������ � �            x������ � �            x������ � �            x������ � �      	      x������ � �      
      x������ � �            x������ � �            x������ � �            x������ � �         �   x����n�0 ��˻���\��Պ�# ��ś���CQ���f/0ON�}��H,"\��=�`(�14H�PK�_��Y|M�'q8�Mw3��L��.S���?В>�)e͟��Pw7��I$�������5o~R/B�kߊ�<r�mr�]ޒ�}�]��_U���d�MM׼�K�QJ�,��$ڬ�<��h��B����*�c`�
"%��B��n��g�� �Wj�l˲~�\l            x������ � �      x      x������ � �            x������ � �      m   )   x�320�4422003110��H,N5�4�3�3������ }Q�     