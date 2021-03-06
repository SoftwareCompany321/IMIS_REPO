PGDMP         /                w            IMIS    12.1    12.1    �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            �           1262    33013    IMIS    DATABASE     �   CREATE DATABASE "IMIS" WITH TEMPLATE = template0 ENCODING = 'UTF8' LC_COLLATE = 'English_United States.1252' LC_CTYPE = 'English_United States.1252';
    DROP DATABASE "IMIS";
                postgres    false            �            1259    33115    ACCODE    TABLE     `  CREATE TABLE public."ACCODE" (
    "ACCODE" numeric(22,0) NOT NULL,
    "SBCODE" numeric(22,0),
    "GRCODE" numeric(22,0),
    "TRANTYPE" character varying(1),
    "NEPNAME" character varying(70),
    "ENGNAME" character varying(50),
    "ISDOLLAR" character varying(2),
    "LOCALCODE" character varying(20),
    "ISASSIGNED" character varying(2)
);
    DROP TABLE public."ACCODE";
       public         heap    postgres    false            y           1259    33987    ACC_ACC_MASTER    TABLE     �  CREATE TABLE public."ACC_ACC_MASTER" (
    "ACC_ID" numeric(22,0) NOT NULL,
    "CODE" character varying(100) NOT NULL,
    "NEP_NAME" character varying(200),
    "ENG_NAME" character varying(70),
    "PARENT_ACC_ID" numeric(22,0),
    "GRP_LEVEL" integer,
    "IS_FIXED" character varying(1),
    "IS_TRANSACTABLE" character varying(1),
    "IS_BUDGETABLE" character varying(1),
    "DISP_CODE" character varying(100),
    "DISP_NAME" character varying(200),
    "ACC_TYPE" character varying(1),
    "TYPE_ID" numeric(22,0),
    "ACC_CODE" character varying(200),
    "SUB_MODULE_ID" numeric(22,0),
    "FISCAL_YEAR" character varying(10),
    "IS_HIDE" character varying(1),
    "ISCAPITALCURRENT" numeric(22,0)
);
 $   DROP TABLE public."ACC_ACC_MASTER";
       public         heap    postgres    false            �           1259    34159    ACC_ASULI_BIBARAN    TABLE     ;  CREATE TABLE public."ACC_ASULI_BIBARAN" (
    "ASULI_ID" numeric(22,0) NOT NULL,
    "PERSON_TYPE_ID" numeric(22,0),
    "PAYMENT_PERSON_ID" numeric(22,0),
    "PERSON_NAME" character varying(90),
    "WORK_NAME" character varying(100),
    "AMT_TAKEN" double precision,
    "RESPONSIVE_TAKEN" character varying(100),
    "COLLECT_REASON" character varying(200),
    "PESKI_AMT" double precision,
    "PESKI_EMPLOYEE_ID" numeric(22,0),
    "PROPERTY_DETAILS" character varying(200),
    "PROPERTY_EMPLOYEE_ID" numeric(22,0),
    "PROPERTY_ROKA" character varying(200)
);
 '   DROP TABLE public."ACC_ASULI_BIBARAN";
       public         heap    postgres    false            {           1259    34018    ACC_BANK_GRNTY    TABLE     �  CREATE TABLE public."ACC_BANK_GRNTY" (
    "GRNTY_ID" numeric(22,0) NOT NULL,
    "GRNTY_NO" character varying(25),
    "GRNTY_VS_DATE" character varying(10),
    "BANK_NAME" character varying(200),
    "GRNTY_AMOUNT" double precision,
    "GRNTY_TYPE" character varying(2),
    "WORK_ID" numeric(22,0),
    "PERSON_ID" numeric(22,0),
    "PHUKUWA_PS" character varying(15),
    "PHUKUWA_CN" character varying(15),
    "PHUKUWA_VS_DATE" character varying(10),
    "MAG_PS" character varying(15),
    "MAG_CN" character varying(15),
    "MAG_VS_DATE" character varying(10),
    "ENTRY_DATETIME" date,
    "EXPRY_VS_DATE" character varying(10)
);
 $   DROP TABLE public."ACC_BANK_GRNTY";
       public         heap    postgres    false            �            1259    33019    ACC_BANK_STATEMENT    TABLE     �  CREATE TABLE public."ACC_BANK_STATEMENT" (
    "ID" numeric(22,0),
    "BANK_ID" integer,
    "TRANSACTION_DATE" character varying(10),
    "TRANSACTION_DATE_EN" date,
    "CHEQUE_NO" character varying(30),
    "DESCRIPTION" character varying(100),
    "DR_AMT" double precision,
    "CR_AMT" double precision,
    "BANK_TRANSACTION_ID" numeric(22,0),
    "BALANCE" double precision
);
 (   DROP TABLE public."ACC_BANK_STATEMENT";
       public         heap    postgres    false            �           1259    35049    ACC_BANK_TRANS    TABLE     �  CREATE TABLE public."ACC_BANK_TRANS" (
    "BANK_TRANS_ID" numeric(22,0) NOT NULL,
    "VCHR_ID" numeric(22,0),
    "VCHR_DATE_NEP" character varying(10),
    "DESCRIPTION" character varying(200),
    "DR_AMT" double precision DEFAULT '0'::double precision,
    "CR_AMT" double precision DEFAULT '0'::double precision,
    "IS_OF_LASTYEAR" character varying(2),
    "TRANS_TYPE_ID" numeric(22,0),
    "BILL_ID" numeric(22,0),
    "BANK_ID" numeric(22,0)
);
 $   DROP TABLE public."ACC_BANK_TRANS";
       public         heap    postgres    false            �            1259    33022    ACC_BGT_ALLOCATE    TABLE     �  CREATE TABLE public."ACC_BGT_ALLOCATE" (
    "BGT_ALLOCATE_ID" numeric(22,0) NOT NULL,
    "ACC_ID" numeric(22,0),
    "REVISED_AMOUNT" double precision,
    "AMOUNT" double precision,
    "FISCAL_YEAR" character varying(10),
    "ALLOCATED_DATE_NP" character varying(10),
    "ENTRY_USER_ID" numeric(22,0),
    "ENTRY_DATETIME" date,
    "UPDATE_USER_ID" numeric(22,0),
    "UPDATE_DATETIME" date,
    "SUB_MODULE_ID" numeric(22,0),
    "BUDGET_SOURCE_ID" numeric(22,0)
);
 &   DROP TABLE public."ACC_BGT_ALLOCATE";
       public         heap    postgres    false            u           1259    33941    ACC_BGT_RVSN    TABLE       CREATE TABLE public."ACC_BGT_RVSN" (
    "ID" numeric(22,0) NOT NULL,
    "BGT_ALCTN_ID" numeric(22,0),
    "RVSN_DATE_NP" character varying(10),
    "AMOUNT" double precision,
    "RVSN_REASON" character varying(200),
    "UPDATE_USER_ID" numeric(22,0),
    "UPDATE_DATETIME" date
);
 "   DROP TABLE public."ACC_BGT_RVSN";
       public         heap    postgres    false            �           1259    34359    ACC_BGT_TRANSFER    TABLE     e  CREATE TABLE public."ACC_BGT_TRANSFER" (
    "ID" numeric(22,0) NOT NULL,
    "FROM_ACC_ID" numeric(22,0),
    "TO_ACC_ID" numeric(22,0),
    "BGT_ALCTN_ID" numeric(22,0),
    "TRNSFR_DATE_NP" character varying(10),
    "TRNSFR_REASON" character varying(200),
    "UPDATE_USER_ID" numeric(22,0),
    "UPDATE_DATETIME" date,
    "AMOUNT" double precision
);
 &   DROP TABLE public."ACC_BGT_TRANSFER";
       public         heap    postgres    false            �           1259    34144    ACC_BUDJET_SOURCE    TABLE     �   CREATE TABLE public."ACC_BUDJET_SOURCE" (
    "ID" numeric(22,0) NOT NULL,
    "MIN_ACC_ID" numeric(22,0),
    "SOURCE_ID" numeric(22,0),
    "AMOUNT" numeric(22,0),
    "REMARKS" character varying(200)
);
 '   DROP TABLE public."ACC_BUDJET_SOURCE";
       public         heap    postgres    false            �           1259    35071    ACC_CASH_TRANS    TABLE     �  CREATE TABLE public."ACC_CASH_TRANS" (
    "CASH_TRANS_ID" numeric(22,0) NOT NULL,
    "VCHR_ID" numeric(22,0),
    "VCHR_DATE_NEP" character varying(10),
    "DESCRIPTION" character varying(200),
    "DR_AMT" double precision DEFAULT '0'::double precision,
    "CR_AMT" double precision DEFAULT '0'::double precision,
    "IS_OF_LASTYEAR" character varying(2),
    "INCOME_EXP_TYPE_ID" numeric(22,0),
    "BILL_ID" numeric(22,0)
);
 $   DROP TABLE public."ACC_CASH_TRANS";
       public         heap    postgres    false            �            1259    33027    ACC_CHEQUE_TYPES    TABLE     |   CREATE TABLE public."ACC_CHEQUE_TYPES" (
    "CHEQUE_TYPE_ID" smallint NOT NULL,
    "CHEQUE_TYPE" character varying(30)
);
 &   DROP TABLE public."ACC_CHEQUE_TYPES";
       public         heap    postgres    false            �            1259    33032    ACC_CURRENCTY    TABLE     �   CREATE TABLE public."ACC_CURRENCTY" (
    "ID" numeric(22,0) NOT NULL,
    "NP_NAME" text,
    "ENG_NAME" text,
    "SYMBOL" character varying(40)
);
 #   DROP TABLE public."ACC_CURRENCTY";
       public         heap    postgres    false            v           1259    33951    ACC_CURRENCTY_RATE    TABLE     �   CREATE TABLE public."ACC_CURRENCTY_RATE" (
    "ID" numeric(22,0) NOT NULL,
    "CURRENCY_ID" numeric(22,0),
    "NP_DATE" character varying(15),
    "RATE" double precision
);
 (   DROP TABLE public."ACC_CURRENCTY_RATE";
       public         heap    postgres    false            �           1259    34509    ACC_DHRTI_BILL_DTL    TABLE       CREATE TABLE public."ACC_DHRTI_BILL_DTL" (
    "DHRTI_DTL_ID" numeric(22,0) NOT NULL,
    "DHRTI_MASTER_ID" numeric(22,0),
    "BILL_NO" character varying(25),
    "BILL_DATE_NP" character varying(10),
    "COUNTER_ID" numeric(22,0),
    "PERSON_ID" numeric(22,0),
    "AMOUNT" double precision,
    "VCHR_ID" numeric(22,0),
    "ACC_ID" numeric(22,0),
    "VCHR_DATE_NP" character varying(10),
    "ORDER_IN_BILL" numeric(22,0),
    "REMARKS" character varying(200),
    "BUDGET_SOURCE_ID" numeric(22,0),
    "WORK_ID" numeric(22,0)
);
 (   DROP TABLE public."ACC_DHRTI_BILL_DTL";
       public         heap    postgres    false            �           1259    34529    ACC_DHRTI_BILL_MASTER    TABLE     �  CREATE TABLE public."ACC_DHRTI_BILL_MASTER" (
    "DHRTI_MASTER_ID" numeric(22,0) NOT NULL,
    "BILL_NO" character varying(25),
    "DESCRIPTION" character varying(200),
    "COUNTER_ID" numeric(22,0),
    "PERSON_ID" numeric(22,0),
    "BLL_DATE_NP" character varying(10),
    "CASH_AMT" double precision,
    "BANK_AMT" double precision,
    "VCHR_ID" numeric(22,0),
    "VCHR_DATE_NP" character varying(10),
    "USERID" numeric(22,0),
    "USERIDE" numeric(22,0),
    "DATE_ENTRY_VS_DATE" character varying(10),
    "DATE_ENTRY_TIME" date,
    "DATE_EDIT_TIME" date,
    "NAME" character varying(100),
    "ADDRESS" character varying(100),
    "WARD_NO" smallint,
    "CANCEL_DATE" character varying(10),
    "CANCEL_REASON" character varying(200),
    "BILL_NO_MANUAL" character varying(25),
    "FISCAL_YEAR" character varying(10),
    "BILLTYPEID" numeric(22,0),
    "SUB_MODULE_ID" numeric(22,0),
    "WORK_ID" numeric(22,0)
);
 +   DROP TABLE public."ACC_DHRTI_BILL_MASTER";
       public         heap    postgres    false            �           1259    34379    ACC_EXPENSES_DETAILS    TABLE     �  CREATE TABLE public."ACC_EXPENSES_DETAILS" (
    "EXPENSE_ID" numeric(22,0) NOT NULL,
    "TRANS_TYPE_ID" numeric(22,0),
    "PERSON_TYPE_ID" numeric(22,0),
    "EMP_ID" numeric(22,0),
    "PADADHIKARI_ID" numeric(22,0),
    "ORG_ID" numeric(22,0),
    "UC_ID" numeric(22,0),
    "WARD_ID" numeric(22,0),
    "WORK_ID" numeric(22,0),
    "ACC_ID" numeric(22,0),
    "DR_AMT" double precision,
    "CR_AMT" double precision,
    "VAT_AMT" double precision,
    "PAYMENT_SLIP_ID" numeric(22,0),
    "VCHR_ID" numeric(22,0),
    "VCHR_DATE_NP" character varying(10),
    "ORDER_IN_PAYMENT_SLIP" numeric(22,0),
    "ADVEXPTYPE" character varying(1),
    "IS_OF_LAST_YEAR" character varying(1)
);
 *   DROP TABLE public."ACC_EXPENSES_DETAILS";
       public         heap    postgres    false            �            1259    33040    ACC_FUND_PROVIDR_MSTR    TABLE     P  CREATE TABLE public."ACC_FUND_PROVIDR_MSTR" (
    "PROVIDER_ID" numeric(22,0) NOT NULL,
    "NAME_NP" character varying(70) NOT NULL,
    "NAME_EN" character varying(50) NOT NULL,
    "PHONES" character varying(50),
    "EMAILS" character varying(50),
    "CHAIRMAN" character varying(70),
    "CONTACT_PERSON" character varying(70)
);
 +   DROP TABLE public."ACC_FUND_PROVIDR_MSTR";
       public         heap    postgres    false            �            1259    33045    ACC_INCOME_RATE    TABLE     �   CREATE TABLE public."ACC_INCOME_RATE" (
    "RATE_ID" numeric(22,0) NOT NULL,
    "ACC_ID" numeric(22,0),
    "RATE" numeric(22,0),
    "FISCAL_YEAR" character varying(10)
);
 %   DROP TABLE public."ACC_INCOME_RATE";
       public         heap    postgres    false            �            1259    33055    ACC_LASTYEAR_ADV_DETAILS    TABLE     �  CREATE TABLE public."ACC_LASTYEAR_ADV_DETAILS" (
    "ID" numeric(22,0) NOT NULL,
    "PAYMENT_ID" numeric(22,0),
    "FISCAL_YEAR" character varying(15),
    "WORK_ID" numeric(22,0),
    "VHCR_ID" numeric(22,0),
    "ACC_ID" numeric(22,0),
    "BUDGET_ACC_ID" numeric(22,0),
    "BUDGET_SOURCE_ID" numeric(22,0),
    "PAYMENT_TYPE_ID" numeric(22,0),
    "PERSON_ID" numeric(22,0),
    "DR_AMOUNT" double precision,
    "STATUS" character varying(2),
    "REMARKS" character varying(255),
    "ADD_USER_ID" numeric(22,0),
    "ADD_DATE" character varying(15),
    "VOUCHER_NO" character varying(50),
    "VOUCHER_DATE" character varying(15),
    "LAST_YR_PESKI_ID" numeric(22,0)
);
 .   DROP TABLE public."ACC_LASTYEAR_ADV_DETAILS";
       public         heap    postgres    false            �            1259    33050    ACC_LAST_YR_PESKI    TABLE       CREATE TABLE public."ACC_LAST_YR_PESKI" (
    "SN" numeric(22,0) NOT NULL,
    "PERSON_TYPE_ID" numeric(22,0),
    "PERSON_ID" numeric(22,0),
    "ADVANCE_TYPE" character varying(1),
    "SUB_MODULE_ID" numeric(22,0),
    "TOTAL_PES_REM" double precision
);
 '   DROP TABLE public."ACC_LAST_YR_PESKI";
       public         heap    postgres    false            �            1259    33060    ACC_ORG_MASTER    TABLE     �  CREATE TABLE public."ACC_ORG_MASTER" (
    "ORG_ID" numeric(22,0) NOT NULL,
    "NAME_NP" character varying(90),
    "NAME_EN" character varying(90),
    "ADDRESS" character varying(90),
    "PHONES" character varying(40),
    "EMAILS" character varying(100),
    "REG_NO" character varying(25),
    "VAT_NO" character varying(25),
    "PAN_NO" character varying(25),
    "ZONE" numeric(22,0),
    "DISTRICT" numeric(22,0),
    "VDC" numeric(22,0),
    "MINISTRY" numeric(22,0),
    "CODE" character varying(30),
    "HEAD" character varying(50),
    "MOBILE_NO" character varying(20),
    "RELATED_PERSON" character varying(100),
    "ORG_MASTER_ID" numeric(22,0),
    "SAPATI" character varying(2),
    "ORC_ACC_TYPE_ID" numeric(22,0)
);
 $   DROP TABLE public."ACC_ORG_MASTER";
       public         heap    postgres    false            x           1259    33974    ACC_PADADHIKARI_MSTR    TABLE     t  CREATE TABLE public."ACC_PADADHIKARI_MSTR" (
    "PADADIKARI_ID" numeric(22,0) NOT NULL,
    "NAME_NP" character varying(70),
    "NAME_EN" character varying(50),
    "POST_ID" numeric(22,0),
    "ADDRESS" character varying(50),
    "WARD_NO" numeric(22,0),
    "ELECTED_DATE_NP" character varying(10),
    "QUALIFICATION" character varying(100),
    "MOBILE_NO" character varying(20),
    "LAST_NAME_NP" character varying(50),
    "LAST_NAME_EN" character varying(50),
    "TITLE" character varying(10),
    "GENDER" character varying(1),
    "RELIGION_ID" numeric(22,0),
    "MOTHER_LANG_ID" numeric(22,0),
    "DATE_OF_BIRTH" character varying(10),
    "PARENT_NAME" character varying(70),
    "P_OCUPATION" numeric(22,0),
    "SPOUSE_NAME" character varying(70),
    "S_OCUPATION" numeric(22,0),
    "GRANDFATHER_NAME" character varying(70),
    "GF_OCUPATION" numeric(22,0),
    "MARRIED_STATUS" character varying(1),
    "NO_OF_SON" numeric(22,0),
    "NO_OF_DAUGHTER" numeric(22,0),
    "FIRST_APPOINT_DATE" character varying(10),
    "FIRST_APPOINT_POST_ID" numeric(22,0),
    "CURRENT_POST_APPOINT_DATE" character varying(10),
    "RETIRE_DATE" character varying(10),
    "PRE_EXPERIENCE" character varying(50),
    "ZONE_ID" numeric(22,0),
    "DISTRICT_ID" numeric(22,0),
    "VDC_ID" numeric(22,0),
    "TRACK_ID" numeric(22,0),
    "STREET" character varying(70),
    "PHONES" character varying(50),
    "EMAILS" character varying(50),
    "MOBILE" character varying(50),
    "CITIZENSHIP_NO" character varying(25),
    "CITZN_ISSUED_DATE" character varying(10),
    "CITZN_ISSUED_DISTR_ID" numeric(22,0),
    "IS_TOILET_IN_HOME" character varying(1),
    "SPECIAL_NOTES" character varying(150),
    "USER_ID" numeric(22,0),
    "USER_IDE" numeric(22,0),
    "DATA_ENTRY_VS_DATE" character varying(10),
    "DATA_ENTRY_AD_DATE" date,
    "DATA_EDIT_AD_DATE" date,
    "DATE_OF_BIRTH_AD" date
);
 *   DROP TABLE public."ACC_PADADHIKARI_MSTR";
       public         heap    postgres    false            �            1259    33068    ACC_PADADHIKARI_POST    TABLE     �   CREATE TABLE public."ACC_PADADHIKARI_POST" (
    "POST_ID" numeric(22,0) NOT NULL,
    "NAME_NP" character varying(70),
    "NAME_EN" character varying(50),
    "DURATION_IN_YRS" numeric(22,0),
    "POST_LEVEL" numeric(22,0)
);
 *   DROP TABLE public."ACC_PADADHIKARI_POST";
       public         heap    postgres    false            �           1259    34409    ACC_PAYMENT_CLEARANCE    TABLE     !  CREATE TABLE public."ACC_PAYMENT_CLEARANCE" (
    "ID" numeric(22,0) NOT NULL,
    "PAYMENT_ID" numeric(22,0),
    "IS_OF_LAST_YEAR" character varying(1),
    "ACC_ID" numeric(22,0),
    "BUDGET_ACC_ID" numeric(22,0),
    "AMOUNT" double precision,
    "BUDGET_SOURCE_ID" numeric(22,0)
);
 +   DROP TABLE public."ACC_PAYMENT_CLEARANCE";
       public         heap    postgres    false            �            1259    33073    ACC_PAYMENT_CREDIT    TABLE       CREATE TABLE public."ACC_PAYMENT_CREDIT" (
    "ID" numeric(22,0) NOT NULL,
    "PAYMENT_ID" numeric(22,0),
    "IS_OF_LAST_YEAR" character varying(1),
    "ACC_ID" numeric(22,0),
    "BUDGET_ACC_ID" numeric(22,0),
    "BUDGET_SOURCE_ID" numeric(22,0),
    "AMOUNT" double precision
);
 (   DROP TABLE public."ACC_PAYMENT_CREDIT";
       public         heap    postgres    false            �           1259    34987    ACC_PAYMENT_DEDUCTION    TABLE     B  CREATE TABLE public."ACC_PAYMENT_DEDUCTION" (
    "ID" numeric(22,0) NOT NULL,
    "PAYMENT_ID" numeric(22,0),
    "ACC_ID" numeric(22,0),
    "BUDGET_ACC_ID" numeric(22,0),
    "AMOUNT" double precision,
    "STATUS" character varying(1),
    "DEDUCTIONTYPE" character varying(5),
    "BUDGET_SOURCE_ID" numeric(22,0)
);
 +   DROP TABLE public."ACC_PAYMENT_DEDUCTION";
       public         heap    postgres    false            �           1259    35007    ACC_PAYMENT_DETAILS    TABLE     !  CREATE TABLE public."ACC_PAYMENT_DETAILS" (
    "PAYMENT_DETAIL_ID" numeric(22,0) NOT NULL,
    "PAYMENT_ID" numeric(22,0),
    "TRANS_TYPE_ID" numeric(22,0),
    "PERSON_TYPE_ID" numeric(22,0),
    "EMP_ID" numeric(22,0),
    "PADADHIKARI_ID" numeric(22,0),
    "ORG_ID" numeric(22,0),
    "UC_ID" numeric(22,0),
    "WARD_ID" numeric(22,0),
    "WORK_ID" numeric(22,0),
    "ACC_ID" numeric(22,0),
    "BUDGET_ACC_ID" numeric(22,0),
    "DR_AMT" double precision DEFAULT '0'::double precision,
    "CR_AMT" double precision DEFAULT '0'::double precision,
    "VAT_AMT" double precision,
    "PAYMENT_SLIP_ID" numeric(22,0),
    "VCHR_ID" numeric(22,0),
    "VCHR_DATE_NP" character varying(10),
    "ORDER_IN_PAYMENT_SLIP" numeric(22,0),
    "ADVEXPTYPE" character varying(1),
    "IS_OF_LAST_YEAR" character varying(1),
    "FISCAL_YEAR" character varying(10),
    "BUDGET_SOURCE_ID" numeric(22,0),
    "SUB_MODULE_ID" numeric(22,0),
    "ADVANCE_TYPE" character varying(1),
    "EXPIRE_DATE_NP" character varying(10),
    "SUPPLIER_ID" numeric(22,0)
);
 )   DROP TABLE public."ACC_PAYMENT_DETAILS";
       public         heap    postgres    false            �           1259    34557    ACC_PAYMENT_MASTER    TABLE     �  CREATE TABLE public."ACC_PAYMENT_MASTER" (
    "PAYMENT_ID" numeric(22,0) NOT NULL,
    "TRANS_TYPE_ID" numeric(22,0),
    "PERSON_TYPE_ID" numeric(22,0),
    "PERSON_ID" numeric(22,0),
    "WORK_ID" numeric(22,0),
    "BILL_NO" character varying(50),
    "BILL_AMT" double precision,
    "VAT_AMT" double precision,
    "PAYMENT_DESCRIPTION" character varying(100),
    "RETENTION_MONEY_EDUCTION" double precision,
    "CONTRACT_TAX_DEDUCTION" double precision,
    "INCOME_TAX_DEDUCTION" double precision,
    "LAST_YEARS_ADV_DEDUCTION" double precision,
    "VAT_DEDUCTION" double precision,
    "OTHER_DEDUCTION" double precision,
    "CHEQUE_PAYMENT" double precision,
    "CASH_PAYMENT" double precision,
    "ADV_CLEARED_FROM_BILL" double precision,
    "ADV_CLEARED_FROM_BANK" double precision,
    "ADV_CLEARED_FROM_CASH" double precision,
    "LY_ADV_CLEARED_FROM_BILL" double precision,
    "LY_ADV_CLEARED_FROM_BANK" double precision,
    "LY_ADV_CLEARED_FROM_CASH" double precision,
    "ADVEXPTYPE" character varying(1),
    "VCHR_ID" numeric(22,0),
    "VCHR_DATE_NP" character varying(10),
    "FISCAL_YEAR" character varying(10),
    "SUB_MODULE_ID" numeric(22,0),
    "ISPESKI" character varying(1),
    "DEDUCT_DEP_VCHR_ID" numeric(22,0),
    "DEDUCT_DEP_VCHR_DATE_NEP" character varying(10),
    "ACC_DEDUCT_DEP_VCHR_ID" numeric(22,0),
    "ACC_DEDUCT_DEP_VCHR_DATE" character varying(10),
    "EXPIRE_DATE_NP" character varying(10),
    "CR_AMOUNT" double precision,
    "SUBJECT_AREA_ID" numeric(22,0)
);
 (   DROP TABLE public."ACC_PAYMENT_MASTER";
       public         heap    postgres    false            �            1259    33076    ACC_RECEIVABLE    TABLE     �  CREATE TABLE public."ACC_RECEIVABLE" (
    "SN" numeric(22,0),
    "TAXPAYERID" numeric(22,0),
    "FISCALYEAR" character varying(10),
    "NETTAXAMOUNT" double precision,
    "FINEAMOUNT" double precision,
    "ADDITIONALCHARGES" double precision,
    "REDUCTIONALCHARGES" double precision,
    "TAXTYPE" character varying(5),
    "TYPE" integer,
    "VCHRID" numeric(22,0),
    "VCHR_DATE" character varying(12)
);
 $   DROP TABLE public."ACC_RECEIVABLE";
       public         heap    postgres    false            �            1259    33079    ACC_SUB_MODULE_TYPE    TABLE     �  CREATE TABLE public."ACC_SUB_MODULE_TYPE" (
    "SUB_MODULE_ID" numeric(22,0) NOT NULL,
    "NAME_NP" character varying(70) NOT NULL,
    "NAME_EN" character varying(50) NOT NULL,
    "MODULE" character varying(2) NOT NULL,
    "CODE" character varying(50),
    "ISCAPITAL" numeric(22,0),
    "BUDGET_ACC_NO" character varying(50),
    "ISEXPENCES" numeric(22,0),
    "ACC_EXPENCES_CODE" character varying(50)
);
 )   DROP TABLE public."ACC_SUB_MODULE_TYPE";
       public         heap    postgres    false            �            1259    33084    ACC_TRANS_TYPE    TABLE        CREATE TABLE public."ACC_TRANS_TYPE" (
    "TYPE_ID" numeric(22,0) NOT NULL,
    "TYPE_CODE" character varying(10) NOT NULL,
    "NEP_NAME" character varying(70) NOT NULL,
    "ENG_NAME" character varying(50),
    "MODULE" character varying(2) NOT NULL
);
 $   DROP TABLE public."ACC_TRANS_TYPE";
       public         heap    postgres    false            �            1259    33089    ACC_UNAUTHORISED    TABLE     �  CREATE TABLE public."ACC_UNAUTHORISED" (
    "UNAUTHORISED_ID" numeric(22,0) NOT NULL,
    "SUB_MODULE_ID" numeric(22,0),
    "WORK_ID" numeric(22,0),
    "UNAUTHORISED_DAFA_ID" numeric(22,0),
    "UNAUTHORISED_AMT" numeric(22,0),
    "INSPECT_DATE" character varying(20),
    "INSPECT_DETAILS" character varying(200),
    "INSPECT_AMT" numeric(22,0),
    "FILLEDBY_EMPID" numeric(22,0),
    "VERIFIEDBY_EMPID" numeric(22,0)
);
 &   DROP TABLE public."ACC_UNAUTHORISED";
       public         heap    postgres    false            �            1259    33094    ACC_USER_COMITE_MSTR    TABLE     �  CREATE TABLE public."ACC_USER_COMITE_MSTR" (
    "ID" numeric(22,0) NOT NULL,
    "NEP_NAME" character varying(150),
    "ENG_NAME" character varying(70),
    "WARD" numeric(22,0),
    "ADDRESS" character varying(90),
    "EMAIL" character varying(50),
    "PHONES" character varying(50),
    "CHAIRMAN" character varying(70),
    "CONCERN_PERSON" character varying(70),
    "MOBILE_NO" character varying(20)
);
 *   DROP TABLE public."ACC_USER_COMITE_MSTR";
       public         heap    postgres    false            �           1259    34587    ACC_VCHR_DETAILS    TABLE     �  CREATE TABLE public."ACC_VCHR_DETAILS" (
    "VCHR_DETAIL_ID" numeric(22,0) NOT NULL,
    "VCHR_ID" numeric(22,0),
    "ACC_ID" numeric(22,0),
    "DR_AMT" double precision DEFAULT '0'::double precision,
    "CR_AMT" double precision DEFAULT '0'::double precision,
    "VCHR_TYPE_ID" numeric(22,0),
    "ID_FROM_SRC" integer,
    "ACC_TYPE" character varying(1) NOT NULL,
    "TRANS_TYPE_ID" numeric(22,0),
    "VCHR_DATE_ENG" date,
    "VCHR_DATE_NEP" character varying(10),
    "REMARKS" character varying(100),
    "IS_POSTED" character varying(1),
    "MODULE" character varying(2) NOT NULL,
    "SUB_MODULE_ID" numeric(22,0) NOT NULL,
    "BUDGET_SOURCE_ID" numeric(22,0),
    "BANKID" numeric(22,0),
    "BILL_ID" numeric(22,0),
    "BUDGET_ACC_ID" numeric(22,0),
    "ORG_ID" numeric(22,0),
    "WORK_ID" numeric(22,0),
    "IS_JAFAT" character varying(1),
    "EXPIRE_DATE_NP" character varying(20),
    "IS_GROUP" character varying(1)
);
 &   DROP TABLE public."ACC_VCHR_DETAILS";
       public         heap    postgres    false            z           1259    34000    ACC_VCHR_MASTER    TABLE     4  CREATE TABLE public."ACC_VCHR_MASTER" (
    "VCHR_ID" numeric(22,0) NOT NULL,
    "VCHR_NO" numeric(22,0),
    "VCHR_DATE_NEP" character varying(10),
    "VCHR_TYPE_ID" numeric(22,0),
    "NARRATION" character varying(200),
    "USER_ID" numeric(22,0),
    "UPDATE_DATE" date,
    "FISCALYEAR" character varying(10),
    "MODULE" character varying(2) NOT NULL,
    "IS_POSTED" character varying(1),
    "SUB_MODULE_ID" numeric(22,0),
    "NAME_CHEQUE_PAYEE" character varying(100),
    "IS_OF_LAST_YEAR" character varying(1),
    "REMARKS" character varying(200),
    "CHEQUE_TYPE_ID" smallint,
    "FATHER_NAME" character varying(50),
    "GRAND_FATHER_NAME" character varying(50),
    "CONTACT_PHONE" character varying(50),
    "IS_NIKASH" character varying(1),
    "WARDNO" character varying(10),
    "PREP_BY" numeric(22,0),
    "CHECK_BY" numeric(22,0),
    "ACCEPT_BY" numeric(22,0),
    "INTERNAL_LEKHA" character varying(50),
    "NIYAMIT_AMT" double precision,
    "ASULI_AMT" double precision,
    "VALID_AMT" double precision,
    "N_VALID_AMT" double precision
);
 %   DROP TABLE public."ACC_VCHR_MASTER";
       public         heap    postgres    false            �            1259    33102    ACC_VCHR_TYPE_MASTER    TABLE        CREATE TABLE public."ACC_VCHR_TYPE_MASTER" (
    "VCHR_TYPE_ID" numeric(22,0) NOT NULL,
    "NEP_NAME" character varying(100),
    "ENG_NAME" character varying(100),
    "MODULE" character varying(2) NOT NULL,
    "ISAUTOMATIC" character varying(1),
    "ISFIXED" character varying(1)
);
 *   DROP TABLE public."ACC_VCHR_TYPE_MASTER";
       public         heap    postgres    false            |           1259    34033    ACC_WORK_FUNDS_DETAIL    TABLE     *  CREATE TABLE public."ACC_WORK_FUNDS_DETAIL" (
    "FUND_DETAIL_ID" numeric(22,0) NOT NULL,
    "WORK_ID" numeric(22,0),
    "PROVIDER_ID" numeric(22,0),
    "FUNDED_AMT" double precision,
    "FUNDED_PERCENT" double precision,
    "ISJANASARAMDHA" numeric(22,0),
    "ISOWNOFFICE" numeric(22,0)
);
 +   DROP TABLE public."ACC_WORK_FUNDS_DETAIL";
       public         heap    postgres    false            �            1259    33107    ACC_WORK_MASTER    TABLE     [  CREATE TABLE public."ACC_WORK_MASTER" (
    "WORK_ID" numeric(22,0) NOT NULL,
    "NAME_NP" character varying(90),
    "NAME_EN" character varying(50),
    "ESTIMATED_AMT" double precision,
    "VARIATION_AMT" double precision,
    "CORRECTED_AMT" double precision,
    "FINAL_ACTUAL_AMT_TOBE_PAID" double precision,
    "TOTAL_ACTUAL_COST" double precision,
    "AGREEMENT_PARTY" character varying(70),
    "AGREEMENT_AMT" double precision,
    "AGREEMENT_DATE" character varying(10),
    "AGREEMENT_EXPIRY_DATE" character varying(10),
    "WORK_COMPLETE_DATE" character varying(10),
    "MEASURE_BOOK_NO" character varying(70),
    "DEPOSIT_AMT" double precision,
    "BANK_GUARANTEE_AMT" double precision,
    "DEPOSIT_RELEASE_DATE" character varying(10),
    "DEPOSIT_RELEASED_DATE" character varying(10),
    "WARD_NO" numeric(22,0),
    "IS_COMPLETED" character varying(1),
    "DEADLINE_DATE" character varying(10),
    "TP_NO" character varying(25),
    "BANKID" numeric(22,0),
    "EMP_ID" numeric(22,0),
    "PARTY_PERSONTYPEID" numeric(22,0),
    "PARTY_ID" numeric(22,0),
    "PERSON_PERSONTYPEID" numeric(22,0),
    "PERSON_ID" numeric(22,0),
    "DEPOSITS_ACC_ID" numeric(22,0),
    "DEPOSITS_FORFEIT_ACC_ID" numeric(22,0),
    "IS_KRAMAGAT" character varying(1),
    "YOJANA_NATUR_ID" numeric(22,0),
    "AGREEMENT_SIGNING_PERSON" character varying(70)
);
 %   DROP TABLE public."ACC_WORK_MASTER";
       public         heap    postgres    false            �           1259    34619    ACC_WORK_PAYMNT_TRANS    TABLE       CREATE TABLE public."ACC_WORK_PAYMNT_TRANS" (
    "TRANS_ID" numeric(22,0) NOT NULL,
    "WORK_ID" numeric(22,0),
    "PAYMENT_SLIP_ID" numeric(22,0),
    "PERSON_TYPE_ID" numeric(22,0),
    "EMP_ID" numeric(22,0),
    "PADADHIKARI_ID" numeric(22,0),
    "ORG_ID" numeric(22,0),
    "UC_ID" numeric(22,0),
    "BILL_AMT" double precision,
    "VAT_AMT" double precision,
    "VCHR_ID" numeric(22,0),
    "VCHR_DATE_NP" character varying(10),
    "IS_OF_LAST_YEAR" character varying(1),
    "FISCAL_YEAR" character varying(10)
);
 +   DROP TABLE public."ACC_WORK_PAYMNT_TRANS";
       public         heap    postgres    false            �            1259    33120    APPLICATION_CONFIGURATION    TABLE     �   CREATE TABLE public."APPLICATION_CONFIGURATION" (
    "SN" smallint NOT NULL,
    "NAME_CONFIG" character varying(70),
    "VALUE_CONFIG" character varying(30)
);
 /   DROP TABLE public."APPLICATION_CONFIGURATION";
       public         heap    postgres    false            ~           1259    34050    AspNetRoleClaims    TABLE     �   CREATE TABLE public."AspNetRoleClaims" (
    "Id" integer NOT NULL,
    "RoleId" text NOT NULL,
    "ClaimType" text,
    "ClaimValue" text
);
 &   DROP TABLE public."AspNetRoleClaims";
       public         heap    postgres    false            }           1259    34048    AspNetRoleClaims_Id_seq    SEQUENCE     �   ALTER TABLE public."AspNetRoleClaims" ALTER COLUMN "Id" ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public."AspNetRoleClaims_Id_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    382            �            1259    33125    AspNetRoles    TABLE     �   CREATE TABLE public."AspNetRoles" (
    "Id" text NOT NULL,
    "Name" character varying(256),
    "NormalizedName" character varying(256),
    "ConcurrencyStamp" text
);
 !   DROP TABLE public."AspNetRoles";
       public         heap    postgres    false            �           1259    34292    AspNetUserClaims    TABLE     �   CREATE TABLE public."AspNetUserClaims" (
    "Id" integer NOT NULL,
    "UserId" text NOT NULL,
    "ClaimType" text,
    "ClaimValue" text
);
 &   DROP TABLE public."AspNetUserClaims";
       public         heap    postgres    false            �           1259    34290    AspNetUserClaims_Id_seq    SEQUENCE     �   ALTER TABLE public."AspNetUserClaims" ALTER COLUMN "Id" ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public."AspNetUserClaims_Id_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    403            �           1259    34305    AspNetUserLogins    TABLE     �   CREATE TABLE public."AspNetUserLogins" (
    "LoginProvider" character varying(128) NOT NULL,
    "ProviderKey" character varying(128) NOT NULL,
    "ProviderDisplayName" text,
    "UserId" text NOT NULL
);
 &   DROP TABLE public."AspNetUserLogins";
       public         heap    postgres    false            �           1259    34318    AspNetUserRoles    TABLE     b   CREATE TABLE public."AspNetUserRoles" (
    "UserId" text NOT NULL,
    "RoleId" text NOT NULL
);
 %   DROP TABLE public."AspNetUserRoles";
       public         heap    postgres    false            �           1259    34336    AspNetUserTokens    TABLE     �   CREATE TABLE public."AspNetUserTokens" (
    "UserId" text NOT NULL,
    "LoginProvider" character varying(128) NOT NULL,
    "Name" character varying(128) NOT NULL,
    "Value" text
);
 &   DROP TABLE public."AspNetUserTokens";
       public         heap    postgres    false            �            1259    33133 
   BANKMASTER    TABLE     R  CREATE TABLE public."BANKMASTER" (
    "BANKID" numeric(22,0) NOT NULL,
    "ENGNAME" character varying(100),
    "NEPNAME" character varying(100),
    "BANKCODE" character varying(50),
    "SUB_MODULE_ID" numeric(22,0),
    "ADDRESS" character varying(100),
    "PHONES" character varying(40),
    "EMAILS" character varying(100),
    "ACCOUNTNUMBER" character varying(25),
    "BRANCHCODE" character varying(200),
    "TRANCODE" character varying(200),
    "CYCODE" character varying(200),
    "FINANCEL_INSTITUTE_ID" numeric(22,0),
    "BRANCH" character varying(50),
    "BANKNAME" text
);
     DROP TABLE public."BANKMASTER";
       public         heap    postgres    false            �           1259    34941    BANKTRANSACTIONS    TABLE     �  CREATE TABLE public."BANKTRANSACTIONS" (
    "SN" numeric(22,0) NOT NULL,
    "BANKID" numeric(22,0),
    "DESCRIPTION" text,
    "DRAMOUNT" double precision,
    "CRAMOUNT" double precision,
    "INCOMEEXPTYPEID" numeric(22,0),
    "ISOFLASTYEAR" character varying(1),
    "VCHR_DATE_NP" character varying(10),
    "ORDERINPAYMENTSLIP" numeric(22,0),
    "VCHR_ID" numeric(22,0),
    "BILLID" numeric(22,0),
    "MODULE" character varying(2),
    "SUBMODULE_TYPE_ID" numeric(22,0),
    "DHRTI_MASTER_ID" numeric(22,0),
    "EXP_SLIP_ID" numeric(22,0),
    "PAYMENT_ORDER_NO" character varying(50),
    "CHEQUE_TYPE_ID" numeric(22,0),
    "PAYEENAME" text,
    "BUDGET_SOURCE_ID" numeric(22,0),
    "PAYEENAME_ENG" text
);
 &   DROP TABLE public."BANKTRANSACTIONS";
       public         heap    postgres    false                       1259    34063    BANK_BRANCH    TABLE     u  CREATE TABLE public."BANK_BRANCH" (
    "BRANCH_ID" numeric(22,0) NOT NULL,
    "BANKID" numeric(22,0),
    "NEPNAME" character varying(200),
    "ENGNAME" character varying(200),
    "BRANCH_CODE" character varying(50),
    "ADDRESS" character varying(200),
    "EMAIL" character varying(100),
    "PHONE" character varying(25),
    "IS_PERMITTED" character varying(2)
);
 !   DROP TABLE public."BANK_BRANCH";
       public         heap    postgres    false            �            1259    33141    BUDJET_SOURCE    TABLE     �  CREATE TABLE public."BUDJET_SOURCE" (
    "ID" numeric(22,0) NOT NULL,
    "PARENT_ID" numeric(22,0),
    "COUNTRY_ID" numeric(22,0),
    "CODE" character varying(70),
    "EMAIL" character varying(50),
    "PHONE" character varying(50),
    "ADDRESS" character varying(100),
    "NEP_NAME" character varying(100),
    "ENG_NAME" character varying(100),
    "REMARKS" character varying(200)
);
 #   DROP TABLE public."BUDJET_SOURCE";
       public         heap    postgres    false            �            1259    33149    BUDJET_SUB_HEAD    TABLE     j  CREATE TABLE public."BUDJET_SUB_HEAD" (
    "ID" numeric(22,0),
    "CODE" character varying(70),
    "MINISTRY_ID" numeric(22,0),
    "MINISTRY_CODE" character varying(70),
    "PARENT_CODE" numeric(22,0),
    "FISCAL_YEAR" character varying(70),
    "NEPNAME" character varying(70),
    "ENGNAME" character varying(70),
    "REMARKS" character varying(200)
);
 %   DROP TABLE public."BUDJET_SUB_HEAD";
       public         heap    postgres    false            �            1259    33155    BUSINESSMASTER_HISTORY    TABLE     �  CREATE TABLE public."BUSINESSMASTER_HISTORY" (
    "ID" numeric(22,0),
    "BIZ_ID" numeric(22,0),
    "NEPNAME" character varying(70),
    "BUSINESSGROUPID" numeric(22,0),
    "TAXPAYERID" numeric(22,0),
    "ADD_DATE" date,
    "COMPUTER_NAME" character varying(100),
    "DATA_STATUS" character varying(20),
    "WINDOWS_USER" character varying(100),
    "TRAN_TIME" character varying(20)
);
 ,   DROP TABLE public."BUSINESSMASTER_HISTORY";
       public         heap    postgres    false            �           1259    34964    CASHTRANSACTION    TABLE       CREATE TABLE public."CASHTRANSACTION" (
    "SN" numeric(22,0) NOT NULL,
    "DESCRIPTION" text,
    "DRAMOUNT" numeric(22,0),
    "CRAMOUNT" numeric(22,0),
    "INCOMEEXPTYPEID" numeric(22,0),
    "ISOFLASTYEAR" character varying(1),
    "VCHR_DATE_NP" character varying(10),
    "VCHR_ID" numeric(22,0),
    "BILLID" numeric(22,0),
    "MODULE" character varying(2),
    "SUBMODULE_TYPE_ID" numeric(22,0),
    "DHRTI_MASTER_ID" numeric(22,0),
    "EXP_SLIP_ID" numeric(22,0),
    "BUDGET_SOURCE_ID" numeric(22,0)
);
 %   DROP TABLE public."CASHTRANSACTION";
       public         heap    postgres    false            �            1259    33158    CELEDGER20682069    TABLE     V  CREATE TABLE public."CELEDGER20682069" (
    "SN" numeric(22,0),
    "IID" numeric(22,0),
    "HOUSEID" numeric(22,0),
    "CONSTRUCTIONTYPEID" numeric(22,0),
    "CONSTRUCTIONID" numeric(22,0),
    "TALANUMBER" numeric(22,0),
    "TOTALAREA" numeric(22,0),
    "RATEID" numeric(22,0),
    "RATEPERUNIT" numeric(22,0),
    "CALCULATEDVALUE" numeric(22,0),
    "VSDATEOFMADE" character varying(10),
    "DEPPERCENT" numeric(22,0),
    "DEPRECIATIONAMOUNT" numeric(22,0),
    "OTHERPLUSINEVALUATIONS" numeric(22,0),
    "OTHERMINUSINEVALUATIONS" numeric(22,0),
    "OTHERPLUSMINUSDESCRIPTIONS" character varying(90),
    "NETCALCULATEDVALUE" numeric(22,0),
    "NONCOMPLETIONREASONID" numeric(22,0),
    "NONCOMPLETIONREASONS" character varying(90),
    "REMARKS" character varying(90),
    "SPACEMEASURINGUNIT" numeric(22,0),
    "TAXED" numeric(22,0)
);
 &   DROP TABLE public."CELEDGER20682069";
       public         heap    postgres    false            �            1259    33161    COLLECTIONCOUNTERS    TABLE     Z  CREATE TABLE public."COLLECTIONCOUNTERS" (
    "COUNTERID" numeric(22,0) NOT NULL,
    "NEPNAME" character varying(50),
    "COUNTERHEADID" numeric(22,0),
    "WARDNO" numeric(22,0),
    "LOCATION" character varying(50),
    "SPECIALNOTES" character varying(90),
    "CMPTR_NAME" character varying(50),
    "MACADDRESS" character varying(200)
);
 (   DROP TABLE public."COLLECTIONCOUNTERS";
       public         heap    postgres    false            �            1259    33166    CONSTANTVALUES    TABLE     {   CREATE TABLE public."CONSTANTVALUES" (
    "SN" numeric(22,0),
    "VARNAME" character varying(50),
    "STRVALUE" text
);
 $   DROP TABLE public."CONSTANTVALUES";
       public         heap    postgres    false            �            1259    33172    CONTACTS    TABLE     �   CREATE TABLE public."CONTACTS" (
    "ID" numeric(22,0) NOT NULL,
    "NEPNAME" character varying(100),
    "ENGNAME" character varying(100),
    "CODE" character varying(50),
    "DISTRICTID" numeric(22,0),
    "REMARKS" character varying(150)
);
    DROP TABLE public."CONTACTS";
       public         heap    postgres    false            �            1259    33177    COUNTRY    TABLE     �   CREATE TABLE public."COUNTRY" (
    "ID" numeric(22,0),
    "NEPNAME" character varying(50) NOT NULL,
    "ENGNAME" character varying(50) NOT NULL,
    "CODE" character varying(50),
    "REMARKS" character varying(100)
);
    DROP TABLE public."COUNTRY";
       public         heap    postgres    false            �            1259    33180    DDC    TABLE     �   CREATE TABLE public."DDC" (
    "ID" numeric(22,0),
    "NEPNAME" character varying(50) NOT NULL,
    "ENGNAME" character varying(50) NOT NULL,
    "CODE" character varying(50),
    "REMARKS" character varying(100),
    "DISTRICTID" numeric(22,0)
);
    DROP TABLE public."DDC";
       public         heap    postgres    false            �            1259    33183 
   DEV_REGION    TABLE     �   CREATE TABLE public."DEV_REGION" (
    "ID" numeric(22,0),
    "NEPNAME" character varying(50) NOT NULL,
    "ENGNAME" character varying(50) NOT NULL,
    "CODE" character varying(50),
    "REMARKS" character varying(100)
);
     DROP TABLE public."DEV_REGION";
       public         heap    postgres    false            �            1259    33186    DISTRICT    TABLE       CREATE TABLE public."DISTRICT" (
    "DISTRICTID" numeric(22,0),
    "NEPNAME" character varying(50) NOT NULL,
    "ENGNAME" character varying(50) NOT NULL,
    "CODE" character varying(50),
    "REMARKS" character varying(100),
    "ZONEID" numeric(22,0)
);
    DROP TABLE public."DISTRICT";
       public         heap    postgres    false            �            1259    33189    EMP_GRP    TABLE     �   CREATE TABLE public."EMP_GRP" (
    "ID" numeric(22,0) NOT NULL,
    "NEPNAME" character varying(80),
    "ENGNAME" character varying(80)
);
    DROP TABLE public."EMP_GRP";
       public         heap    postgres    false            �           1259    34424    FIREBRIGADESTATE    TABLE     8  CREATE TABLE public."FIREBRIGADESTATE" (
    "ID" numeric(22,0) NOT NULL,
    "NEPNAME" character varying(50),
    "SERVICECHARGERATE" numeric(22,0),
    "MINIMUMSERVICECHARGE" numeric(22,0),
    "ACC_ID" numeric(22,0),
    "TYPE" smallint,
    "FISCAL_YEAR" character varying(10),
    "RATEID" numeric(22,0)
);
 &   DROP TABLE public."FIREBRIGADESTATE";
       public         heap    postgres    false            �            1259    33194    FISCALYEARS    TABLE     �   CREATE TABLE public."FISCALYEARS" (
    "SN" numeric(22,0),
    "FISCALYEAR" character varying(9),
    "DATEFROM" character varying(10),
    "DATETO" character varying(10)
);
 !   DROP TABLE public."FISCALYEARS";
       public         heap    postgres    false            �            1259    33197    FYWISERENTDARRATE    TABLE     �   CREATE TABLE public."FYWISERENTDARRATE" (
    "ID" numeric(22,0) NOT NULL,
    "RATEID" numeric(22,0),
    "RATENAME" character varying(100),
    "RENT_PER" double precision,
    "RENT_TYPEID" numeric(22,0),
    "FISCAL_YEAR" character varying(10)
);
 '   DROP TABLE public."FYWISERENTDARRATE";
       public         heap    postgres    false            �            1259    33202    FYWISESANITATION_RATE    TABLE     �  CREATE TABLE public."FYWISESANITATION_RATE" (
    "ID" numeric(22,0) NOT NULL,
    "RATEID" numeric(22,0),
    "GROUPID" numeric(22,0),
    "SUBGROUPID" numeric(22,0),
    "ROAD_TYPEID" numeric(22,0),
    "RATENAME" text,
    "RATE" double precision,
    "FISCAL_YEAR" character varying(10),
    "AREA_UPTO" numeric(22,0),
    "FOR_EACH_AREA" numeric(22,0),
    "EACH_AREA_RATE" numeric(22,0)
);
 +   DROP TABLE public."FYWISESANITATION_RATE";
       public         heap    postgres    false            �           1259    34639    INCOMEBILLDETAILS    TABLE     �  CREATE TABLE public."INCOMEBILLDETAILS" (
    "SN" numeric(22,0) NOT NULL,
    "BILLID" numeric(22,0),
    "BILLNO" character varying(25),
    "BILLDATE" character varying(10),
    "COUNTERID" numeric(22,0),
    "PERSONID" numeric(22,0),
    "ACCODE" numeric(22,0),
    "AMOUNT" numeric(22,0),
    "VCHR_DATE_NP" character varying(10),
    "ORDERINBILL" numeric(22,0),
    "REMARKS" character varying(200),
    "VCHR_ID" numeric(22,0),
    "ACC_ID" numeric(22,0),
    "FISCAL_YEAR" character varying(10),
    "PROJECT" character varying(10),
    "TAXADDTNLID" numeric(22,0),
    "TAX_TYPE" character varying(5),
    "QTY" numeric(22,0),
    "BUDGET_SOURCE_ID" numeric(22,0),
    "BACKUP_PERSONID" numeric(22,0)
);
 '   DROP TABLE public."INCOMEBILLDETAILS";
       public         heap    postgres    false            �            1259    33208    INCOMEBILLDETAILS_HISTORY    TABLE     �  CREATE TABLE public."INCOMEBILLDETAILS_HISTORY" (
    "SN" numeric(22,0),
    "SN_INCOMEBILLDTL" numeric(22,0),
    "BILLID" numeric(22,0),
    "BILLNO" character varying(25),
    "BILLDATE" character varying(10),
    "COUNTERID" numeric(22,0),
    "PERSONID" numeric(22,0),
    "ACCODE" numeric(22,0),
    "AMOUNT" numeric(22,0),
    "VRNO" numeric(22,0),
    "VCHR_DATE_NP" character varying(10),
    "ORDERINBILL" numeric(22,0),
    "REMARKS" character varying(200),
    "VCHR_ID" numeric(22,0),
    "ACC_ID" numeric(22,0),
    "FISCAL_YEAR" character varying(10),
    "PROJECT" character varying(10),
    "TAXADDTNLID" numeric(22,0),
    "QTY" numeric(22,0),
    "BUDGET_SOURCE_ID" numeric(22,0),
    "TAX_TYPE" character varying(5),
    "BACKUP_PERSONID" numeric(22,0),
    "ADD_DATE" date,
    "COMPUTER_NAME" character varying(100),
    "DATA_STATUS" character varying(20),
    "WINDOWS_USER" character varying(100),
    "TRAN_TIME" character varying(20)
);
 /   DROP TABLE public."INCOMEBILLDETAILS_HISTORY";
       public         heap    postgres    false            �           1259    34654    INCOMEBILLMASTER    TABLE     �  CREATE TABLE public."INCOMEBILLMASTER" (
    "SN" numeric(22,0) NOT NULL,
    "BILLNO" character varying(25),
    "DESCRIPTION" text,
    "COUNTERID" numeric(22,0),
    "PERSONID" numeric(22,0),
    "BILLDATE" character varying(10),
    "CASHAMOUNT" numeric(22,0),
    "BANKAMOUNT" numeric(22,0),
    "VCHR_ID" numeric(22,0),
    "VCHR_DATE_NP" character varying(10),
    "USERID" numeric(22,0),
    "USERIDE" numeric(22,0),
    "DATAENTRYVSDATE" character varying(10),
    "DATAENTRYADDATETIME" date,
    "DATAEDITADDATETIME" date,
    "BILLTYPEID" numeric(22,0),
    "TAXINCOMETYPE" character varying(10),
    "NAME" text,
    "ADDRESS" character varying(100),
    "WARD_NO" smallint,
    "CANCEL_DATE" character varying(10),
    "CANCEL_REASON" character varying(200),
    "BILL_NO_MANUAL" character varying(25),
    "FISCAL_YEAR" character varying(10),
    "PROJECT" character varying(10),
    "SUB_MODULE_ID" numeric(22,0),
    "CURRENCY_ID" numeric(22,0),
    "BACKUP_PERSONID" numeric(22,0)
);
 &   DROP TABLE public."INCOMEBILLMASTER";
       public         heap    postgres    false            �            1259    33214    INV_APPLICANT_RATE    TABLE     �   CREATE TABLE public."INV_APPLICANT_RATE" (
    "ID" numeric(22,0) NOT NULL,
    "APPLICANTID" numeric(22,0),
    "ITEM_DETAIL_ID" numeric(22,0),
    "AMOUNT" double precision
);
 (   DROP TABLE public."INV_APPLICANT_RATE";
       public         heap    postgres    false            �            1259    33219 	   INV_BRAND    TABLE     �   CREATE TABLE public."INV_BRAND" (
    "BRAND_ID" numeric(22,0) NOT NULL,
    "NAME_NP" character varying(50) NOT NULL,
    "NAME_EN" character varying(50),
    "IS_ACTIVE" character varying(1)
);
    DROP TABLE public."INV_BRAND";
       public         heap    postgres    false            �            1259    33224    INV_DEPLIST    TABLE     f  CREATE TABLE public."INV_DEPLIST" (
    "ID" numeric(22,0) NOT NULL,
    "FISCALYEAR" character varying(10),
    "DAKHILA_ID" numeric(22,0),
    "ITEM_ID" numeric(22,0),
    "QTY" double precision,
    "PURCHASE_DATE" character varying(15),
    "PURCHASE_AMT" double precision,
    "BRAND_ID" numeric(22,0),
    "SPEC_ID" numeric(22,0),
    "UNIT_ID" numeric(22,0),
    "DEPRE_DURATON" double precision,
    "DEPRE_PER" numeric(22,0),
    "DEPRE_AMT" double precision,
    "MAX_DEPRE_AMT" double precision,
    "MIN_DEPRE_AMT" double precision,
    "DEDUCT_AMT" double precision,
    "NET_AMT" double precision
);
 !   DROP TABLE public."INV_DEPLIST";
       public         heap    postgres    false            �            1259    33229    INV_DEPRECIATION    TABLE     �  CREATE TABLE public."INV_DEPRECIATION" (
    "ID" numeric(22,0) NOT NULL,
    "FISCALYEAR" character varying(10),
    "DAKHILA_ID" numeric(22,0),
    "ITEM_ID" numeric(22,0),
    "BRAND_ID" numeric(22,0),
    "SPEC_ID" numeric(22,0),
    "UNIT_ID" numeric(22,0),
    "QTY" double precision,
    "ORGINAL_RATE" double precision,
    "DEPRE_RATE" double precision,
    "DEPRE_PER" numeric(22,0)
);
 &   DROP TABLE public."INV_DEPRECIATION";
       public         heap    postgres    false            �            1259    33234    INV_DEPT    TABLE     �   CREATE TABLE public."INV_DEPT" (
    "DEPT_ID" numeric(22,0) NOT NULL,
    "NAME_NP" character varying(50) NOT NULL,
    "NAME_EN" character varying(50),
    "OFFICE_ID" numeric(22,0),
    "IS_ACTIVE" character varying(1)
);
    DROP TABLE public."INV_DEPT";
       public         heap    postgres    false            �           1259    35108    INV_GOODS_ADJUST    TABLE     �  CREATE TABLE public."INV_GOODS_ADJUST" (
    "ID" numeric(22,0) NOT NULL,
    "DAKHILA_ID" numeric(22,0),
    "GD_ADJ_ID" character varying(10) NOT NULL,
    "BUDGET_YEAR" character varying(10),
    "MONTH" character varying(10),
    "ITEM_ID" numeric(22,0),
    "ITEM_TYPE" numeric(22,0),
    "SPEC_ID" numeric(22,0),
    "BRAND_ID" numeric(22,0),
    "ADJ_QTY" double precision,
    "ADJ_TYPE_ID" numeric(22,0),
    "ITEM_ADJ_RATE" double precision,
    "ADJ_DT_NP" character varying(10),
    "ADJ_DT_ENG" date,
    "REMARKS" character varying(100),
    "PREP_BY" numeric(22,0),
    "PREP_DT_NP" character varying(10),
    "PREP_DT_ENG" date,
    "ACCEPT_BY" numeric(22,0),
    "ACCEPT_DT_NP" character varying(10),
    "ACCEPT_DT_ENG" date
);
 &   DROP TABLE public."INV_GOODS_ADJUST";
       public         heap    postgres    false            �           1259    35587    INV_GOODS_REC_DETL    TABLE     �  CREATE TABLE public."INV_GOODS_REC_DETL" (
    "ID" numeric(22,0) NOT NULL,
    "GOODS_MASTER_ID" numeric(22,0),
    "ITEM_ID" numeric(22,0),
    "UNIT_ID" numeric(22,0),
    "BRAND_ID" numeric(22,0),
    "SPEC_ID" numeric(22,0),
    "PUR_QTY" double precision,
    "RECV_QTY" double precision,
    "RATE" double precision,
    "WHETHER_TAX" character varying(1),
    "TAX_PER_UNIT_AMT" double precision,
    "DISC_AMT" double precision,
    "OTHER_EXPENCES_AMT" double precision,
    "NET_AMT" double precision,
    "REMARKS" character varying(100),
    "ISNUMBERED" character varying(1) DEFAULT '0'::character varying,
    "DAKHILA_DT_ENG" date
);
 (   DROP TABLE public."INV_GOODS_REC_DETL";
       public         heap    postgres    false            �           1259    35138    INV_GOODS_REC_MAST    TABLE     B  CREATE TABLE public."INV_GOODS_REC_MAST" (
    "ID" numeric(22,0) NOT NULL,
    "DAKHILA_ID" character varying(10) NOT NULL,
    "PUR_MASTER_ID" numeric(22,0),
    "REPAIR_ID" numeric(22,0),
    "DAKHILA_DT" character varying(10),
    "WAREHOUSE_ID" numeric(22,0),
    "INV_BILL_NO" character varying(10),
    "INV_DATE" character varying(10),
    "DETAILS_NEP" character varying(200),
    "DETAILS_ENG" character varying(200),
    "PREP_BY" numeric(22,0),
    "PREP_DT" character varying(10),
    "CHECK_BY" numeric(22,0),
    "CHECK_DT" character varying(10),
    "ACCEPT_BY" numeric(22,0),
    "ACCEPT_DT" character varying(10),
    "DAKHILA_DT_ENG" date,
    "INV_DATE_ENG" date,
    "PREP_DT_ENG" date,
    "CHECK_DT_ENG" date,
    "ACCEPT_DT_ENG" date,
    "FISCAL_YEAR" character varying(10),
    "PAYMENT_ID" numeric(22,0)
);
 (   DROP TABLE public."INV_GOODS_REC_MAST";
       public         heap    postgres    false            �            1259    33239    INV_INCREASE_DECREASE    TABLE     �  CREATE TABLE public."INV_INCREASE_DECREASE" (
    "ID" numeric(22,0) NOT NULL,
    "NUM_ID" numeric(22,0),
    "DAKHILA_ID" numeric(22,0),
    "ITEM_ID" numeric(22,0),
    "BRAND_ID" numeric(22,0),
    "SPEC_ID" numeric(22,0),
    "UNIT_ID" numeric(22,0),
    "PURCHASE_DATE" character varying(30),
    "STOCK_QTY" double precision,
    "AMOUNT" double precision,
    "SCAP_AMOUNT" double precision,
    "FISCALYEAR" character varying(30)
);
 +   DROP TABLE public."INV_INCREASE_DECREASE";
       public         heap    postgres    false            �            1259    33244    INV_ISSUE_DAKHILA    TABLE     `  CREATE TABLE public."INV_ISSUE_DAKHILA" (
    "ID" numeric(22,0) NOT NULL,
    "ITEM_ID" numeric(22,0),
    "SPEC_ID" numeric(22,0),
    "BRAND_ID" numeric(22,0),
    "UNIT_ID" numeric(22,0),
    "ISSUE_DETAIL_ID" numeric(22,0),
    "ISSU_MASTER_ID" numeric(22,0),
    "DAKHILA_ID" numeric(22,0),
    "ISSUE_NO" double precision,
    "REMARKS" text
);
 '   DROP TABLE public."INV_ISSUE_DAKHILA";
       public         heap    postgres    false            �           1259    34697    INV_ISSUE_DETAIL    TABLE     �  CREATE TABLE public."INV_ISSUE_DETAIL" (
    "ID" numeric(22,0) NOT NULL,
    "ISSUE_MAST_ID" numeric(22,0),
    "ITEM_ID" numeric(22,0),
    "SPEC_ID" numeric(22,0),
    "BRAND_ID" numeric(22,0),
    "ITEM_TYPE" numeric(22,0),
    "ITEM_REQ_NO" double precision,
    "ITEM_ISSUE_NO" double precision,
    "ISSUE_DT" character varying(10),
    "DELIVERY_STATUS" character varying(1),
    "REMARKS" character varying(100),
    "ISSUE_DT_ENG" date
);
 &   DROP TABLE public."INV_ISSUE_DETAIL";
       public         heap    postgres    false            �           1259    35698    INV_ISSUE_MASTER    TABLE     5  CREATE TABLE public."INV_ISSUE_MASTER" (
    "ID" numeric(22,0) NOT NULL,
    "ISSUE_NO" character varying(10) NOT NULL,
    "REQUEST_ID" numeric(22,0),
    "ISSUE_BY" numeric(22,0),
    "ISSUE_RECEIVE" numeric(22,0),
    "RECEIVE_EMP_ID" numeric(22,0),
    "ISSUE_DT" character varying(10),
    "REMARKS" character varying(100),
    "ISSUE_BY_CAT" character varying(30),
    "HO_NAME" character varying(30),
    "HO_POST" character varying(30),
    "PREP_BY" numeric(22,0),
    "PREP_DT" character varying(10),
    "CHECK_BY" numeric(22,0),
    "CHECK_DT" character varying(10),
    "ACCEPT_BY" numeric(22,0),
    "ACCEPT_DT" character varying(10),
    "BUDGET_YEAR" character varying(10),
    "TYPE" numeric(22,0),
    "TRANSFER_DECISION_NO" character varying(50),
    "TRANSFER_DECISION_DATE" character varying(12)
);
 &   DROP TABLE public."INV_ISSUE_MASTER";
       public         heap    postgres    false            �            1259    33252    INV_ITEM_ADJ_TYPE    TABLE     �   CREATE TABLE public."INV_ITEM_ADJ_TYPE" (
    "ID" numeric(22,0) NOT NULL,
    "NAME_NP" character varying(50) NOT NULL,
    "NAME_EN" character varying(50),
    "ADD_SUB" character varying(15),
    "ADJ_TYPE" character varying(30)
);
 '   DROP TABLE public."INV_ITEM_ADJ_TYPE";
       public         heap    postgres    false            �            1259    33257    INV_ITEM_CATEGORY    TABLE     �  CREATE TABLE public."INV_ITEM_CATEGORY" (
    "ID" numeric(22,0) NOT NULL,
    "NAME_NP" character varying(50) NOT NULL,
    "NAME_EN" character varying(50),
    "PARENT_ID" numeric(22,0),
    "GRP_LEVEL" numeric(22,0),
    "IS_HEADER" numeric(22,0),
    "ISEXP" smallint,
    "ISLAST" smallint,
    "CODE" character varying(10),
    "UNIT" numeric(22,0),
    "MINL" numeric(22,0),
    "MAXL" numeric(22,0),
    "RMINL" numeric(22,0),
    "RMAXL" numeric(22,0),
    "DEPRECIATION_PER" double precision,
    "DEPRECIATION_MIN" double precision,
    "DEPRECIATION_MAX" double precision,
    "REMARKS" character varying(100),
    "ITEM_ID" numeric(22,0)
);
 '   DROP TABLE public."INV_ITEM_CATEGORY";
       public         heap    postgres    false            �           1259    35618    INV_ITEM_DETAILS    TABLE     �  CREATE TABLE public."INV_ITEM_DETAILS" (
    "ITEM_DTL_ID" numeric(22,0) NOT NULL,
    "ITEM_ID" numeric(22,0) NOT NULL,
    "BRAND_ID" numeric(22,0) NOT NULL,
    "SPEC_ID" numeric(22,0) NOT NULL,
    "QTY" double precision,
    "ITEM_RATE" double precision,
    "ITEM_STATUS" character varying(10),
    "BUDGET_YEAR" character varying(10),
    "DAKHILA_ID" numeric(22,0),
    "ENTRY_DT" character varying(10),
    "ISSUE_ID" numeric(22,0),
    "ISSUE_DT" character varying(10),
    "GD_ADJ_ID" numeric(22,0),
    "ADJ_TYPE" numeric(22,0),
    "LILAM_ID" numeric(22,0),
    "LILAM_DT" character varying(10),
    "STOK_RT_ID" numeric(22,0),
    "STOK_RT_DT" character varying(10),
    "ENGINE_NO" character varying(20),
    "CHASIS_NO" character varying(20),
    "MODEL_NO" character varying(20),
    "REG_NO" character varying(20),
    "WEIGHT_VEH" numeric(22,0),
    "PREP_BY" numeric(22,0),
    "PREP_DT" character varying(10),
    "CHECK_BY" numeric(22,0),
    "CHECK_DT" character varying(10),
    "ACCEPT_BY" numeric(22,0),
    "ACCEPT_DT" character varying(10),
    "UNIT" numeric(22,0),
    "REL_UNIT" character varying(20),
    "REL_QTY" double precision
);
 &   DROP TABLE public."INV_ITEM_DETAILS";
       public         heap    postgres    false            �           1259    34111    INV_ITEM_MST    TABLE     �  CREATE TABLE public."INV_ITEM_MST" (
    "ITEM_ID" numeric(22,0) NOT NULL,
    "NAME_NP" character varying(50) NOT NULL,
    "NAME_EN" character varying(50),
    "UNIT_ID" numeric(22,0),
    "ITEM_MAIN_CLASS" numeric(22,0),
    "ITEM_TYPE" numeric(22,0),
    "ITEM_NATURE" numeric(22,0),
    "MAXL" numeric(22,0),
    "MINL" numeric(22,0),
    "RMAXL" numeric(22,0),
    "RMINL" numeric(22,0),
    "GUSSAGE" numeric(22,0),
    "SIZES" numeric(22,0),
    "COUNTRYID" numeric(22,0),
    "COMPANYNAME" character varying(50),
    "SOURCE" character varying(50),
    "REMARKS" character varying(100),
    "CODE" character varying(50),
    "KITTA_NO" character varying(150),
    "LAND_LOCATION" character varying(150),
    "CONSTRUCTONTYPE" character varying(150),
    "DEPRECIATION" double precision,
    "MINRATE" double precision,
    "DEPMAXRATE" double precision,
    "PROPERTYTYPE" numeric(22,0),
    "LAND_AREA_INSQ_FEETS" numeric(22,0),
    "AREA_INSQ_FEETS" numeric(22,0),
    "LAND_UNIT_RATE" numeric(22,0),
    "LAND_MARKET_RATE" numeric(22,0),
    "LANDID" numeric(22,0),
    "ACC_ID" numeric(22,0),
    "BUDGET_ACC_ID" numeric(22,0),
    "VEHICLE_PARTS_ID" numeric(22,0)
);
 "   DROP TABLE public."INV_ITEM_MST";
       public         heap    postgres    false            �            1259    33262    INV_ITEM_SPEC    TABLE     �   CREATE TABLE public."INV_ITEM_SPEC" (
    "SPEC_ID" numeric(22,0) NOT NULL,
    "NAME_NP" character varying(50) NOT NULL,
    "NAME_EN" character varying(50),
    "IS_ACTIVE" character varying(1)
);
 #   DROP TABLE public."INV_ITEM_SPEC";
       public         heap    postgres    false            �           1259    35161    INV_ITEM_STATUSCHECK    TABLE     g  CREATE TABLE public."INV_ITEM_STATUSCHECK" (
    "ID" numeric(22,0) NOT NULL,
    "ITEM_ID" numeric(22,0),
    "SPEC_ID" numeric(22,0),
    "BRAND_ID" numeric(22,0),
    "INSP_ST_DATE" character varying(10),
    "INSP_ST_DATE_ENG" date,
    "INSP_ED_DATE" character varying(10),
    "INSP_ED_DATE_ENG" date,
    "STK_MST_COUNT" numeric(22,0),
    "COUNT_YES_NO" character varying(2),
    "STK_CUR_COUNT" numeric(22,0),
    "COUNT_UP_DOWN" character varying(2),
    "INSPECT_DATE" character varying(10),
    "INSPECT_DATE_ENG" date,
    "UP_DOWN_DETAIL" character varying(30),
    "REMARKS" character varying(100),
    "PREP_BY" numeric(22,0),
    "PREP_DATE" character varying(10),
    "PREP_DATE_ENG" date,
    "TALLY_BY" numeric(22,0),
    "CHECKED_DATE" character varying(10),
    "CHECK_QTY" numeric(22,0),
    "RATE" numeric(22,0),
    "CHECKED_DATE_ENG" date,
    "ACCEPTED_BY" numeric(22,0),
    "ACCEPTED_DATE" character varying(10),
    "ACCEPTED_DATE_ENG" date,
    "FISICAL_YEAR" character varying(10),
    "IS_ACTIVE" character varying(2),
    "UP_DOWN_NO" numeric(22,0),
    "CHECK_STATUS" character varying(1)
);
 *   DROP TABLE public."INV_ITEM_STATUSCHECK";
       public         heap    postgres    false            �           1259    34101    INV_LILAMAPPDETAILS    TABLE     d  CREATE TABLE public."INV_LILAMAPPDETAILS" (
    "ID" numeric(22,0) NOT NULL,
    "LILAMAPPLIID" numeric(22,0),
    "DAKHILAID" numeric(22,0),
    "NIKASHAID" numeric(22,0),
    "ITEMID" numeric(22,0),
    "UNITID" numeric(22,0),
    "BRANDID" numeric(22,0),
    "SPECID" numeric(22,0),
    "LILAMQTY" numeric(22,0),
    "LILAMTOTALAMT" double precision
);
 )   DROP TABLE public."INV_LILAMAPPDETAILS";
       public         heap    postgres    false            �            1259    33267    INV_LILAM_APPMASTER    TABLE     j  CREATE TABLE public."INV_LILAM_APPMASTER" (
    "ID" numeric(22,0) NOT NULL,
    "APPNO" numeric(22,0),
    "PROJID" numeric(22,0),
    "APPLYLILAMID" numeric(22,0),
    "ORGAPPLICANTNAME" character varying(50),
    "ORGAPPLICANTPOST" character varying(50),
    "APPLYDATE" character varying(10),
    "APPLYENGDATE" date,
    "REMARKS" character varying(150)
);
 )   DROP TABLE public."INV_LILAM_APPMASTER";
       public         heap    postgres    false            �            1259    33272    INV_LILAM_DETAIL    TABLE     L  CREATE TABLE public."INV_LILAM_DETAIL" (
    "ID" numeric(22,0) NOT NULL,
    "MINIMUMRATE" double precision,
    "LILAM_ID" numeric(22,0),
    "DAKHILAID" numeric(22,0),
    "NIKASHAID" numeric(22,0),
    "ITEM_ID" numeric(22,0),
    "UNIT_ID" numeric(22,0),
    "SPEC_ID" numeric(22,0),
    "BRAND_ID" numeric(22,0),
    "ITEM_TYPE" numeric(22,0),
    "ITEM_ISSUE_NO" double precision,
    "TOTAL_IN_STOCK" double precision,
    "DEP_AMT" double precision,
    "ISSUE_DT" character varying(10),
    "DELIVERY_STATUS" character varying(1),
    "REMARKS" text,
    "ISSUE_DT_ENG" date
);
 &   DROP TABLE public."INV_LILAM_DETAIL";
       public         heap    postgres    false            �            1259    33280    INV_LILAM_MAST    TABLE     P  CREATE TABLE public."INV_LILAM_MAST" (
    "ID" numeric(22,0) NOT NULL,
    "LILAM_NO" character varying(50) NOT NULL,
    "ISSUE_BY" numeric(22,0),
    "LILAMTYPE" numeric(22,0),
    "RECEIVE_BY" numeric(22,0),
    "RECEIVE_PERSON_NAME" character varying(50),
    "RECIVE_PERSON_POST" character varying(50),
    "REMARKS" text,
    "PREP_BY" numeric(22,0),
    "CHECK_BY" numeric(22,0),
    "ISSUE_DT" character varying(10),
    "ACCEPT_BY" numeric(22,0),
    "ACCEPT_DT" character varying(10),
    "PREP_DT" character varying(10),
    "CHECK_DT" character varying(10),
    "ISSUE_DT_ENG" date,
    "PREP_DT_ENG" date,
    "CHECK_DT_ENG" date,
    "FISCAL_YEAR" character varying(10),
    "ACCEPT_DT_ENG" date,
    "PAGENO" character varying(200),
    "REGISTERNO" character varying(200),
    "PUBLISH_DATE" character varying(20),
    "DESCRIPTION" character varying(200),
    "NEWSPAPER_NAME" character varying(200),
    "PERNEWS_RATE" double precision,
    "ACCEPT_PERCENT" double precision,
    "BANKID" numeric(22,0),
    "VALID_DAYS" numeric(22,0),
    "FISCALYEAR_CHUKTA" character varying(10)
);
 $   DROP TABLE public."INV_LILAM_MAST";
       public         heap    postgres    false            �            1259    33288    INV_LILAM_REC_LIST    TABLE     �   CREATE TABLE public."INV_LILAM_REC_LIST" (
    "ID" numeric(22,0),
    "REC_DATE_NP" character varying(10),
    "APPLICANTID" numeric(22,0),
    "EMP_ID" numeric(22,0),
    "USER_ID" numeric(22,0)
);
 (   DROP TABLE public."INV_LILAM_REC_LIST";
       public         heap    postgres    false            �            1259    33291    INV_ORG_TYPE    TABLE     �   CREATE TABLE public."INV_ORG_TYPE" (
    "ID" numeric(22,0) NOT NULL,
    "NAME_NP" character varying(50) NOT NULL,
    "NAME_EN" character varying(50),
    "IS_ACTIVE" character varying(1)
);
 "   DROP TABLE public."INV_ORG_TYPE";
       public         heap    postgres    false                        1259    33296    INV_PROJECT    TABLE     �   CREATE TABLE public."INV_PROJECT" (
    "PROJECT_ID" numeric(22,0) NOT NULL,
    "NAME_NP" character varying(50) NOT NULL,
    "NAME_EN" character varying(50),
    "IS_ACTIVE" character varying(1)
);
 !   DROP TABLE public."INV_PROJECT";
       public         heap    postgres    false                       1259    33301    INV_PUR_MAST_PLAN    TABLE     �  CREATE TABLE public."INV_PUR_MAST_PLAN" (
    "ID" numeric(22,0) NOT NULL,
    "NAME_NP" character varying(70) NOT NULL,
    "NAME_EN" character varying(50),
    "PKG_NO" character varying(20),
    "APPROX_AMT" double precision,
    "BUDGET1YEAR" double precision,
    "BUDGET2YEAR" double precision,
    "BUDGET3YEAR" double precision,
    "PUR_TYPE" character varying(10),
    "AGREEMENT_TYPE" character varying(10),
    "BUDGET_RESOURCE" character varying(30),
    "WORK_ST_DATE" character varying(10),
    "WORK_END_DATE" character varying(10),
    "WORK_ST_DATE_AD" date,
    "WORK_END_DATE_AD" date,
    "BUDGET_YEAR" character varying(10),
    "REMARKS" character varying(100)
);
 '   DROP TABLE public."INV_PUR_MAST_PLAN";
       public         heap    postgres    false            �           1259    35663    INV_PUR_ORDER_DETL    TABLE     �  CREATE TABLE public."INV_PUR_ORDER_DETL" (
    "ID" numeric(22,0) NOT NULL,
    "PUR_MST_ID" numeric(22,0),
    "ITEM_ID" numeric(22,0),
    "UNIT_ID" numeric(22,0),
    "SPEC_ID" numeric(22,0),
    "BRAND_ID" numeric(22,0),
    "ITEM_TYPE" numeric(22,0),
    "QTY" double precision,
    "ITEM_RATE" double precision,
    "TOTAL_AMT" double precision,
    "TAX_AMT" double precision,
    "REMARKS" character varying(100),
    "ISDAKHILA" character varying(1)
);
 (   DROP TABLE public."INV_PUR_ORDER_DETL";
       public         heap    postgres    false            �           1259    35196    INV_PUR_ORDER_MAST    TABLE     h  CREATE TABLE public."INV_PUR_ORDER_MAST" (
    "ID" numeric(22,0) NOT NULL,
    "PUR_ORDER_NO" character varying(50),
    "REPAIR_ORDER_NO" character varying(50),
    "LETTER_ORDER_NO" character varying(50),
    "CUSTOM_ORDER_NO" character varying(50),
    "PUR_TYPE" numeric(22,0),
    "PUR_ORDER_TYPE" numeric(22,0),
    "SUPP_ID" numeric(22,0),
    "REQ_ID" numeric(22,0),
    "BUDGET_YEAR" character varying(10),
    "RETURN_ITEM_DT" character varying(10),
    "RETURN_ITEM_DT_ENG" date,
    "PREPARED_BY" numeric(22,0),
    "PREPARED_DT" character varying(10),
    "PREPARED_DT_ENG" date,
    "CHECKED_BY" numeric(22,0),
    "CHECKED_DT" character varying(10),
    "CHECKED_DT_ENG" date,
    "ACCEPTED_BY" numeric(22,0),
    "ACCEPTED_DT" character varying(10),
    "ACCEPTED_DT_ENG" date,
    "PUR_ORDER_DT" character varying(10),
    "DAKHILA_LAST_ENTRY_DT" character varying(12),
    "PUR_ORDER_DT_ENG" date,
    "ISDAKHILA" character varying(1),
    "REMARKS" character varying(255),
    "ACCOUNTID" numeric(22,0),
    "PURCHASE_DECISION_NO" character varying(50),
    "PURCHASE_DECISION_DATE" character varying(12)
);
 (   DROP TABLE public."INV_PUR_ORDER_MAST";
       public         heap    postgres    false                       1259    33306    INV_PUR_TYPE    TABLE     �   CREATE TABLE public."INV_PUR_TYPE" (
    "ID" numeric(22,0),
    "NEP_NAME" character varying(50),
    "NEP_ENG" character varying(50),
    "REMARKS" character varying(50),
    "ISDEFAULT" character varying(1)
);
 "   DROP TABLE public."INV_PUR_TYPE";
       public         heap    postgres    false            �           1259    35224    INV_REQUISITION_MAST    TABLE       CREATE TABLE public."INV_REQUISITION_MAST" (
    "ID" numeric(22,0) NOT NULL,
    "REQ_ID" character varying(10),
    "REQ_DATE_NEP" character varying(10),
    "REQ_BY" numeric(22,0),
    "TYPE_ID" numeric(22,0),
    "ITEM_ID" numeric(22,0),
    "MAINTAIN_ITEM_ID" numeric(22,0),
    "PROJ_ID" numeric(22,0),
    "HANDOVER_ID" numeric(22,0),
    "HANDOVER_ROOM_ID" numeric(22,0),
    "FISCAL_YEAR" character varying(10),
    "REMARKS" character varying(100),
    "PREP_BY" numeric(22,0),
    "PREP_DT" character varying(10),
    "CHECK_BY" numeric(22,0),
    "CHECK_DT" character varying(10),
    "ACCEPT_BY" numeric(22,0),
    "ACCEPT_DT" character varying(10),
    "ORGSTAFFNAME" character varying(60),
    "ORGSTAFFPOST" character varying(100),
    "REQ_TYPE" numeric(22,0),
    "USERID" numeric(22,0),
    "VEHICLE_ID" numeric(22,0),
    "REASION" text,
    "REQ_DATE_ENG" date,
    "PREP_DT_ENG" date,
    "CHECK_DT_ENG" date,
    "ACCEPT_DT_ENG" date,
    "PURCHASE_GIVE" character varying(1),
    "STOCK_GIVE" character varying(1)
);
 *   DROP TABLE public."INV_REQUISITION_MAST";
       public         heap    postgres    false            �           1259    35728    INV_REQ_DETAIL    TABLE     ,  CREATE TABLE public."INV_REQ_DETAIL" (
    "ID" numeric(22,0) NOT NULL,
    "REQ_MAST_ID" numeric(22,0),
    "ITEM_ID" numeric(22,0),
    "SPEC_ID" numeric(22,0),
    "BRAND_ID" numeric(22,0),
    "QTY" double precision,
    "REMARKS" character varying(100),
    "IS_ACTIVE" character varying(10)
);
 $   DROP TABLE public."INV_REQ_DETAIL";
       public         heap    postgres    false            �           1259    34091    INV_ROOM_MST    TABLE     �   CREATE TABLE public."INV_ROOM_MST" (
    "ROOM_ID" numeric(22,0) NOT NULL,
    "FLOOR_NO" numeric(22,0),
    "BLOCK_NO" character varying(10),
    "DESC_NP" character varying(50),
    "DESC_EN" character varying(50),
    "DEPT_ID" numeric(22,0)
);
 "   DROP TABLE public."INV_ROOM_MST";
       public         heap    postgres    false            �           1259    35262    INV_STATUS_DETAIL    TABLE     �  CREATE TABLE public."INV_STATUS_DETAIL" (
    "ID" numeric(22,0) NOT NULL,
    "CODE" character varying(50),
    "STATUSDATEAD" date,
    "STATUSDATEVS" character varying(10),
    "FISCAL_YEAR" character varying(10),
    "TOTALQTY" numeric(22,0),
    "ITEM_ID" numeric(22,0),
    "BRAND_ID" numeric(22,0),
    "SPEC_ID" numeric(22,0),
    "ITEM_STATUS_ID" numeric(22,0),
    "REMARKS" character varying(255),
    "PREBY" numeric(22,0),
    "PREVSDATE" character varying(10),
    "CHECKEDBY" numeric(22,0),
    "CHECKVSDATE" character varying(10),
    "ACCEPTBY" numeric(22,0),
    "MAIN_ID" numeric(22,0),
    "ACCEPTVSDATE" character varying(10)
);
 '   DROP TABLE public."INV_STATUS_DETAIL";
       public         heap    postgres    false                       1259    33314    INV_SUPPLIER    TABLE     �  CREATE TABLE public."INV_SUPPLIER" (
    "SUP_ID" numeric(22,0) NOT NULL,
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
    "DATE_AD" date,
    "ORG_TYPE" character varying(50),
    "ORG_ID" numeric(22,0),
    "IS_SELECTED" character varying(5),
    "REG_NO" character varying(30),
    "SUP_TYPE" character varying(1)
);
 "   DROP TABLE public."INV_SUPPLIER";
       public         heap    postgres    false                       1259    33322    INV_SUPPLIER_FISCALYEAR    TABLE     �   CREATE TABLE public."INV_SUPPLIER_FISCALYEAR" (
    "ID" numeric(22,0) NOT NULL,
    "SUP_ID" numeric(22,0),
    "FISCAL_YEAR" character varying(15)
);
 -   DROP TABLE public."INV_SUPPLIER_FISCALYEAR";
       public         heap    postgres    false                       1259    33309    INV_SUP_ITM_DET    TABLE     �   CREATE TABLE public."INV_SUP_ITM_DET" (
    "ID" numeric(22,0) NOT NULL,
    "ITEM_ID" numeric(22,0),
    "SUP_ID" numeric(22,0),
    "QTY" numeric(22,0),
    "RATE" numeric(22,0),
    "ACC_ID" numeric(22,0),
    "FISCAL_YEAR" character varying(10)
);
 %   DROP TABLE public."INV_SUP_ITM_DET";
       public         heap    postgres    false                       1259    33327    INV_TAX_RATE    TABLE     �   CREATE TABLE public."INV_TAX_RATE" (
    "TAX_RATE_ID" numeric(22,0) NOT NULL,
    "NAME_NP" character varying(50) NOT NULL,
    "NAME_EN" character varying(50),
    "TAX_RATE" double precision NOT NULL
);
 "   DROP TABLE public."INV_TAX_RATE";
       public         heap    postgres    false                       1259    33332    INV_TYPE_SETUP    TABLE     �   CREATE TABLE public."INV_TYPE_SETUP" (
    "ID" numeric(22,0) NOT NULL,
    "DESC_NP" character varying(50) NOT NULL,
    "DESC_EN" character varying(50),
    "TYPE_ID" numeric(22,0),
    "IS_ACTIVE" character varying(1)
);
 $   DROP TABLE public."INV_TYPE_SETUP";
       public         heap    postgres    false                       1259    33337    INV_UNIT    TABLE     +  CREATE TABLE public."INV_UNIT" (
    "UNIT_ID" numeric(22,0) NOT NULL,
    "DESC_NP" character varying(50) NOT NULL,
    "DESC_EN" character varying(50),
    "MUL_FACTOR" numeric(22,0),
    "RELATED_TO" character varying(10),
    "NO_OF_UNITS" numeric(22,0),
    "IS_ACTIVE" character varying(1)
);
    DROP TABLE public."INV_UNIT";
       public         heap    postgres    false            	           1259    33342    INV_WAREHOUSE    TABLE     �   CREATE TABLE public."INV_WAREHOUSE" (
    "WAREHOUSE_ID" numeric(22,0) NOT NULL,
    "NAME_NP" character varying(50) NOT NULL,
    "NAME_EN" character varying(50),
    "IS_ACTIVE" character varying(1)
);
 #   DROP TABLE public."INV_WAREHOUSE";
       public         heap    postgres    false            
           1259    33347    INV_YRLY_PUR_PLAN    TABLE     �  CREATE TABLE public."INV_YRLY_PUR_PLAN" (
    "ID" numeric(22,0) NOT NULL,
    "NAME_NP" character varying(70) NOT NULL,
    "NAME_EN" character varying(50),
    "APPROX_AMT" double precision,
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
    "ANLYSIS_DSGN_DT_AD" date,
    "APRX_AMT_ACPT_DT_AD" date,
    "TENDR_ACCEPT_DT_AD" date,
    "TENDR_CALL_DT_AD" date,
    "TENDR_OPEN_DT_AD" date,
    "AGREEMENT_DT_AD" date,
    "WRK_2_FIN_DT_AD" date,
    "WRK_ACMPLSH_DT_AD" date,
    "REMARKS" character varying(100)
);
 '   DROP TABLE public."INV_YRLY_PUR_PLAN";
       public         heap    postgres    false                       1259    33352    IPTTAXSUMMARY_HISTORY    TABLE     �  CREATE TABLE public."IPTTAXSUMMARY_HISTORY" (
    "SN" numeric(22,0),
    "IID" numeric(22,0),
    "FISCALYEAR" character varying(9),
    "NETTAXAMOUNT" numeric(22,0),
    "FINEAMOUNT" numeric(22,0),
    "ADDITIONALCHARGES" numeric(22,0),
    "REDUCTIONALCHARGES" numeric(22,0),
    "ISTHISFROMREVENUEACCOUNT" numeric(22,0),
    "TAXPAIDAMOUNT" numeric(22,0),
    "DATEPAID" character varying(10),
    "SPECIALNOTES" text,
    "USERID" numeric(22,0),
    "USERIDE" numeric(22,0),
    "DATAENTRYVSDATE" character varying(10),
    "DATAENTRYADDATETIME" date,
    "DATAEDITADDATETIME" date,
    "BILLID" numeric(22,0),
    "BILLNO" character varying(25),
    "LAST_TAX_PAID_AMOUNT" double precision,
    "TAX_TYPE" character varying(2),
    "REM_IPT_PAID_AMOUNT" double precision,
    "REM_HL_PAID_AMOUNT" double precision,
    "REM_IPT_FINE_AMOUNT" double precision,
    "REM_HL_FINE_AMOUNT" double precision,
    "REM_HL_FINE_STATUS" character varying(1),
    "REM_IPT_FINE_STATUS" character varying(1),
    "YEAR" numeric(22,0),
    "MONTH" numeric(22,0),
    "ADD_DATE" date,
    "COMPUTER_NAME" character varying(100),
    "DATA_STATUS" character varying(20),
    "WINDOWS_USER" character varying(100),
    "TRAN_TIME" character varying(20)
);
 +   DROP TABLE public."IPTTAXSUMMARY_HISTORY";
       public         heap    postgres    false                       1259    33358    ISSUEDBILLS    TABLE     6  CREATE TABLE public."ISSUEDBILLS" (
    "SN" numeric(22,0),
    "DATEISSUED" character varying(10),
    "THELINO" numeric(22,0),
    "BILLNOFROM" character varying(25),
    "BILLNOTO" character varying(25),
    "COUNTERID" numeric(22,0),
    "USERID" numeric(22,0),
    "SPECIALNOTES" character varying(90)
);
 !   DROP TABLE public."ISSUEDBILLS";
       public         heap    postgres    false                       1259    33361    LANDMEASURINGUNITS    TABLE     �   CREATE TABLE public."LANDMEASURINGUNITS" (
    "UNITID" numeric(22,0),
    "UNITNAME" character varying(50),
    "SQFTPERUNIT" numeric(22,0)
);
 (   DROP TABLE public."LANDMEASURINGUNITS";
       public         heap    postgres    false                       1259    33364    LANDSMULTIEVALUATIONDETAIL    TABLE     �   CREATE TABLE public."LANDSMULTIEVALUATIONDETAIL" (
    "SN" numeric(22,0),
    "IID" numeric(22,0),
    "LANDID" numeric(22,0),
    "KITTANUMBER" character varying(50),
    "GENERALRATEID" numeric(22,0),
    "AREAINSQFT" numeric(22,0)
);
 0   DROP TABLE public."LANDSMULTIEVALUATIONDETAIL";
       public         heap    postgres    false                       1259    33367    LELEDGER20682069    TABLE     n  CREATE TABLE public."LELEDGER20682069" (
    "SN" numeric(22,0),
    "IID" numeric(22,0),
    "LANDID" numeric(22,0),
    "WARDNO" numeric(22,0),
    "TRACKID" numeric(22,0),
    "KITTANUMBER" character varying(50),
    "TOTALAREA" numeric(22,0),
    "NONEVALUATEDAREA" numeric(22,0),
    "NETEVALUATINGAREA" numeric(22,0),
    "RATEID" numeric(22,0),
    "RATEPERUNIT" numeric(22,0),
    "CALCULATEDVALUE" numeric(22,0),
    "OTHERPLUSINEVALUATIONS" numeric(22,0),
    "OTHERMINUSINEVALUATIONS" numeric(22,0),
    "OTHERPLUSMINUSDESCRIPTIONS" character varying(90),
    "NETCALCULATEDVALUE" numeric(22,0),
    "SELFDECLAREDVALUE" numeric(22,0),
    "APPLIEDVALUE" numeric(22,0),
    "NONCOMPLETIONREASONID" numeric(22,0),
    "NONCOMPLETIONREASONS" character varying(90),
    "REMARKS" character varying(90),
    "LANDMEASURINGUNIT" numeric(22,0),
    "TAXED" numeric(22,0)
);
 &   DROP TABLE public."LELEDGER20682069";
       public         heap    postgres    false                       1259    33370    MALPOT_LANDS    TABLE     �  CREATE TABLE public."MALPOT_LANDS" (
    "ID" numeric(22,0) NOT NULL,
    "IID" numeric(22,0),
    "EID" character varying(200),
    "NP_FIRSTNAME" character varying(200),
    "NP_LASTNAME" character varying(200),
    "OLDVDCID" numeric(22,0),
    "OLDWORDNO" character varying(100),
    "MOTHNUMBER" character varying(200),
    "KITTANUMBER" character varying(200),
    "VDCID" numeric(22,0),
    "WORDNO" numeric(22,0),
    "AREAINSQFT" double precision,
    "NONFUNCTIONALAREAINSQFT" double precision,
    "ADD_USERID" numeric(22,0),
    "EDIT_USERID" numeric(22,0),
    "ADD_DATE" character varying(30),
    "EDIT_DATE" character varying(30),
    "IS_IPT" numeric(22,0)
);
 "   DROP TABLE public."MALPOT_LANDS";
       public         heap    postgres    false            �           1259    34124    MAP_AREA_GND_COV    TABLE     �   CREATE TABLE public."MAP_AREA_GND_COV" (
    "ID" integer NOT NULL,
    "REGIONID" numeric(22,0),
    "GROUND_COV" double precision,
    "AREA" bigint,
    "REMARKS" character varying(150)
);
 &   DROP TABLE public."MAP_AREA_GND_COV";
       public         heap    postgres    false                       1259    33378    MAP_CONSTRCTION_KIND    TABLE     �   CREATE TABLE public."MAP_CONSTRCTION_KIND" (
    "ID" smallint NOT NULL,
    "NAME_NP" character varying(70) NOT NULL,
    "NAME_EN" character varying(70),
    "DESCRIPTION" character varying(100)
);
 *   DROP TABLE public."MAP_CONSTRCTION_KIND";
       public         heap    postgres    false                       1259    33383    MAP_DESIGNER_DTL    TABLE     �  CREATE TABLE public."MAP_DESIGNER_DTL" (
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
       public         heap    postgres    false                       1259    33391    MAP_DIRECTION    TABLE     �   CREATE TABLE public."MAP_DIRECTION" (
    "ID" smallint NOT NULL,
    "NAME_NP" character varying(70),
    "NAME_EN" character varying(70) NOT NULL,
    "DESCRIPTION" character varying(100)
);
 #   DROP TABLE public."MAP_DIRECTION";
       public         heap    postgres    false                       1259    33396    MAP_DRAIN_TYPE    TABLE     �   CREATE TABLE public."MAP_DRAIN_TYPE" (
    "ID" smallint NOT NULL,
    "NAME_NP" character varying(70) NOT NULL,
    "NAME_EN" character varying(70),
    "DESCRIPTION" character varying(100)
);
 $   DROP TABLE public."MAP_DRAIN_TYPE";
       public         heap    postgres    false                       1259    33401 	   MAP_FLOOR    TABLE     �   CREATE TABLE public."MAP_FLOOR" (
    "ID" smallint NOT NULL,
    "NAME_NP" character varying(70) NOT NULL,
    "NAME_EN" character varying(70),
    "DESCRIPTION" character varying(100)
);
    DROP TABLE public."MAP_FLOOR";
       public         heap    postgres    false                       1259    33406    MAP_HOUSEUSE_TYPE    TABLE     �   CREATE TABLE public."MAP_HOUSEUSE_TYPE" (
    "ID" smallint NOT NULL,
    "NAME_NP" character varying(70) NOT NULL,
    "NAME_EN" character varying(70),
    "DESCRIPTION" character varying(100)
);
 '   DROP TABLE public."MAP_HOUSEUSE_TYPE";
       public         heap    postgres    false                       1259    33411    MAP_HTSTANDARD    TABLE     �   CREATE TABLE public."MAP_HTSTANDARD" (
    "SN" smallint NOT NULL,
    "KV" integer,
    "DISTANCEFT" numeric(22,0),
    "REMARKS" character varying(150)
);
 $   DROP TABLE public."MAP_HTSTANDARD";
       public         heap    postgres    false            �           1259    34434    MAP_INCOME_TYPE    TABLE     �   CREATE TABLE public."MAP_INCOME_TYPE" (
    "ID" smallint NOT NULL,
    "NAME_NP" character varying(70) NOT NULL,
    "NAME_EN" character varying(70),
    "ACC_ID" numeric(22,0),
    "DESCRIPTION" character varying(100)
);
 %   DROP TABLE public."MAP_INCOME_TYPE";
       public         heap    postgres    false                       1259    33416    MAP_LAND_OWNER_TYPE    TABLE     �   CREATE TABLE public."MAP_LAND_OWNER_TYPE" (
    "ID" smallint NOT NULL,
    "NAME_NP" character varying(70) NOT NULL,
    "NAME_EN" character varying(70),
    "DESCRIPTION" character varying(100)
);
 )   DROP TABLE public."MAP_LAND_OWNER_TYPE";
       public         heap    postgres    false                       1259    33421    MAP_NEIGHBOUR_TYPE    TABLE     �   CREATE TABLE public."MAP_NEIGHBOUR_TYPE" (
    "ID" smallint NOT NULL,
    "NAME_NP" character varying(70) NOT NULL,
    "NAME_EN" character varying(70),
    "DESCRIPTION" character varying(100)
);
 (   DROP TABLE public."MAP_NEIGHBOUR_TYPE";
       public         heap    postgres    false                       1259    33426    MAP_RATE    TABLE       CREATE TABLE public."MAP_RATE" (
    "ID" numeric(22,0) NOT NULL,
    "DESCRIPTION" character varying(150),
    "RATE_PERMIT" double precision,
    "DEPOSITE_RATE_PERMIT" double precision,
    "USERID" numeric(22,0),
    "ENTRY_DATE" character varying(10)
);
    DROP TABLE public."MAP_RATE";
       public         heap    postgres    false            �           1259    34134    MAP_REGION_FAR    TABLE     
  CREATE TABLE public."MAP_REGION_FAR" (
    "ID" smallint NOT NULL,
    "REGIONID" numeric(22,0),
    "AREA_FROM" numeric(22,0),
    "AREA_TO" numeric(22,0),
    "FISCAL_YEAR" character varying(10),
    "FAR" double precision,
    "REMARKS" character varying(150)
);
 $   DROP TABLE public."MAP_REGION_FAR";
       public         heap    postgres    false                       1259    33431    MAP_ROOF_CNSTRCT_TYPE    TABLE     �   CREATE TABLE public."MAP_ROOF_CNSTRCT_TYPE" (
    "ID" smallint NOT NULL,
    "NAME_NP" character varying(70) NOT NULL,
    "NAME_EN" character varying(70),
    "DESCRIPTION" character varying(100)
);
 +   DROP TABLE public."MAP_ROOF_CNSTRCT_TYPE";
       public         heap    postgres    false                       1259    33436    MAP_ROOF_TYPE    TABLE     �   CREATE TABLE public."MAP_ROOF_TYPE" (
    "ID" smallint NOT NULL,
    "NAME_NP" character varying(70),
    "NAME_EN" character varying(70) NOT NULL,
    "DESCRIPTION" character varying(100)
);
 #   DROP TABLE public."MAP_ROOF_TYPE";
       public         heap    postgres    false                       1259    33441    MAP_SITE    TABLE     �   CREATE TABLE public."MAP_SITE" (
    "SN" numeric(22,0) NOT NULL,
    "PERMITID" numeric(22,0),
    "LANDSHAPE" smallint,
    "SIDE_A" double precision,
    "SIDE_B" double precision,
    "SIDE_C" double precision,
    "AREA" double precision
);
    DROP TABLE public."MAP_SITE";
       public         heap    postgres    false                       1259    33446    MAP_STDHEIGHT_RW    TABLE     �   CREATE TABLE public."MAP_STDHEIGHT_RW" (
    "ID" smallint NOT NULL,
    "ROAD_WIDTH" double precision,
    "HOUSE_HEIGHT" double precision,
    "FISCAL_YEAR" character varying(10),
    "REMARKS" character varying(150)
);
 &   DROP TABLE public."MAP_STDHEIGHT_RW";
       public         heap    postgres    false                       1259    33451    MAP_STOREYS    TABLE     �   CREATE TABLE public."MAP_STOREYS" (
    "ID" numeric(22,0) NOT NULL,
    "NAME_NP" character varying(70) NOT NULL,
    "NAME_EN" character varying(70),
    "DESCRIPTION" character varying(100)
);
 !   DROP TABLE public."MAP_STOREYS";
       public         heap    postgres    false                        1259    33456    MAP_STRUCTURE_TYPE    TABLE     �   CREATE TABLE public."MAP_STRUCTURE_TYPE" (
    "ID" numeric(22,0) NOT NULL,
    "NAME_NP" character varying(70) NOT NULL,
    "NAME_EN" character varying(70),
    "DESCRIPTION" character varying(100)
);
 (   DROP TABLE public."MAP_STRUCTURE_TYPE";
       public         heap    postgres    false            !           1259    33461    MAP_ZONE    TABLE     �   CREATE TABLE public."MAP_ZONE" (
    "ID" numeric(22,0) NOT NULL,
    "NAME_NP" character varying(70) NOT NULL,
    "NAME_EN" character varying(70),
    "DESCRIPTION" character varying(100)
);
    DROP TABLE public."MAP_ZONE";
       public         heap    postgres    false            "           1259    33466    MINISTRY    TABLE     g  CREATE TABLE public."MINISTRY" (
    "ID" numeric(22,0),
    "CODE" character varying(70),
    "ZONE" numeric(22,0),
    "DISTRICT" numeric(22,0),
    "VDC" numeric(22,0),
    "PHONE" character varying(70),
    "ADDRESS" character varying(150),
    "NEPNAME" character varying(70),
    "ENGNAME" character varying(70),
    "REMARKS" character varying(200)
);
    DROP TABLE public."MINISTRY";
       public         heap    postgres    false            #           1259    33472    MINISTRY_ACC_HEAD    TABLE     �   CREATE TABLE public."MINISTRY_ACC_HEAD" (
    "ID" numeric(22,0) NOT NULL,
    "MINISTRY_ID" numeric(22,0),
    "ACC_ID" numeric(22,0),
    "SUB_HEAD_ID" numeric(22,0),
    "FISCAL_YEAR" character varying(70),
    "REMARKS" character varying(200)
);
 '   DROP TABLE public."MINISTRY_ACC_HEAD";
       public         heap    postgres    false            $           1259    33477    NATIONALITIES    TABLE     �   CREATE TABLE public."NATIONALITIES" (
    "NATIONALITYID" numeric(22,0),
    "CODE" character varying(50),
    "NEPNAME" character varying(50),
    "ENGNAME" character varying(25),
    "DESCRIPTION" character varying(70)
);
 #   DROP TABLE public."NATIONALITIES";
       public         heap    postgres    false            %           1259    33480    NEW_PROPERTY_TAXTABLE    TABLE     {  CREATE TABLE public."NEW_PROPERTY_TAXTABLE" (
    "SN" numeric(22,0) NOT NULL,
    "RATESN" numeric(22,0),
    "FROMPROPERTYVALUE" double precision,
    "TOPROPERTYVALUE" double precision,
    "FROMTAXAMOUNT" double precision,
    "TOTAXAMOUNT" double precision,
    "REMARKS" character varying(190),
    "FISCALYEAR" character varying(10),
    "TAX_PERCENT" double precision
);
 +   DROP TABLE public."NEW_PROPERTY_TAXTABLE";
       public         heap    postgres    false            &           1259    33485    OFFICE_TYPE    TABLE     �   CREATE TABLE public."OFFICE_TYPE" (
    "OFFICE_TYPE_ID" numeric(22,0) NOT NULL,
    "OFFICE_TYPE" character varying(30) NOT NULL
);
 !   DROP TABLE public."OFFICE_TYPE";
       public         heap    postgres    false            �           1259    34202    ORGANIZATION_TREE    TABLE       CREATE TABLE public."ORGANIZATION_TREE" (
    "ID" numeric(22,0) NOT NULL,
    "PARENT_ID" numeric(22,0),
    "NEP_NAME" character varying(70),
    "ENG_NAME" character varying(70),
    "CONTAINS_DARBANDI" numeric(22,0),
    "GEO_REGION" numeric(22,0),
    "GRP_LEVEL" integer
);
 '   DROP TABLE public."ORGANIZATION_TREE";
       public         heap    postgres    false            �           1259    34677    ORG_BANK_ACCOUNT    TABLE       CREATE TABLE public."ORG_BANK_ACCOUNT" (
    "ID" numeric(22,0) NOT NULL,
    "ORG_ID" numeric(22,0),
    "BANKID" numeric(22,0),
    "BRANCH_ID" numeric(22,0),
    "BANK_ACCNT_TYPE_ID" numeric(22,0),
    "ACC_NO" character varying(50),
    "ACC_NAME" character varying(150)
);
 &   DROP TABLE public."ORG_BANK_ACCOUNT";
       public         heap    postgres    false            '           1259    33490    PAYMENT_SLIP_MASTER    TABLE     1  CREATE TABLE public."PAYMENT_SLIP_MASTER" (
    "PAYMENT_SLIP_ID" numeric(22,0) NOT NULL,
    "PAYMENT_DESCRIPTION" character varying(100),
    "TRANSACTION_TYPEID" numeric(22,0),
    "PERSON_TYPE_ID" numeric(22,0),
    "PERSON_ID" numeric(22,0),
    "WORK_ID" numeric(22,0),
    "BILL_AMT" double precision,
    "VAT_AMT" double precision,
    "RETENTION_MONEY_EDUCTION" double precision,
    "CONTRACT_TAX_DEDUCTION" double precision,
    "INCOME_TAX_DEDUCTION" double precision,
    "LAST_YEARS_ADV_DEDUCTION" double precision,
    "VAT_DEDUCTION" double precision,
    "OTHER_DEDUCTION" double precision,
    "CHEQUE_PAYMENT" double precision,
    "CASH_PAYMENT" double precision,
    "ADV_CLEARED_FROM_BILL" double precision,
    "ADV_CLEARED_FROM_BANK" double precision,
    "ADV_CLEARED_FROM_CASH" double precision,
    "LY_ADV_CLEARED_FROM_BILL" double precision,
    "LY_ADV_CLEARED_FROM_BANK" double precision,
    "LY_ADV_CLEARED_FROM_CASH" double precision,
    "IS_PESKI" character varying(1),
    "VR_NO" numeric(22,0),
    "VR_DATE" character varying(10)
);
 )   DROP TABLE public."PAYMENT_SLIP_MASTER";
       public         heap    postgres    false            (           1259    33495    PERSON_TYPE_MASTER    TABLE     �   CREATE TABLE public."PERSON_TYPE_MASTER" (
    "PERSON_TYPE_ID" numeric(22,0) NOT NULL,
    "NAME_NP" text,
    "NAME_EN" text,
    "ISFIXED" character varying(1)
);
 (   DROP TABLE public."PERSON_TYPE_MASTER";
       public         heap    postgres    false            )           1259    33503    PIS_APPOINTMENT_TYPE    TABLE     �   CREATE TABLE public."PIS_APPOINTMENT_TYPE" (
    "ID" numeric(22,0) NOT NULL,
    "NAME_NP" character varying(50),
    "NAME_EN" character varying(50),
    "DESCRIPTION" character varying(70)
);
 *   DROP TABLE public."PIS_APPOINTMENT_TYPE";
       public         heap    postgres    false            *           1259    33508    PIS_ATTRIBUTES    TABLE     �   CREATE TABLE public."PIS_ATTRIBUTES" (
    "ID" numeric(22,0) NOT NULL,
    "NAME_NEP" character varying(70),
    "DESCRIPTION" character varying(90),
    "APPLY_TO" character varying(2)
);
 $   DROP TABLE public."PIS_ATTRIBUTES";
       public         heap    postgres    false            �           1259    34722 
   PIS_AWARDS    TABLE     �  CREATE TABLE public."PIS_AWARDS" (
    "SN" numeric(22,0) NOT NULL,
    "EMP_ID" numeric(22,0),
    "LOCAL_POST_ID" numeric(22,0),
    "NEP_NAME" character varying(70),
    "LEVEL_DESC" character varying(50),
    "DESCRIPTION" character varying(100),
    "WORKING_OFFICE" character varying(70),
    "RVCD_DATE_VS" character varying(10),
    "RCVD_DATE_AD" date,
    "REMARKS" character varying(90),
    "APPLY_TO" character varying(2)
);
     DROP TABLE public."PIS_AWARDS";
       public         heap    postgres    false            �           1259    35282    PIS_BANK_PAYROLL    TABLE     �   CREATE TABLE public."PIS_BANK_PAYROLL" (
    "SN" numeric(22,0) NOT NULL,
    "EMP_ID" numeric(22,0),
    "BANK_ID" numeric(22,0),
    "BANK_FOLIO" character varying(25),
    "ACCOUNT_NO" character varying(25)
);
 &   DROP TABLE public."PIS_BANK_PAYROLL";
       public         heap    postgres    false            �           1259    34732    PIS_DARBANDI    TABLE     $  CREATE TABLE public."PIS_DARBANDI" (
    "DARBANDI_ID" numeric(22,0) NOT NULL,
    "OFFICE_ID" numeric(22,0),
    "POST_ID" numeric(22,0),
    "POST_LEVEL" numeric(22,0),
    "LOCAL_POST_ID" numeric(22,0),
    "SEWA_SAMUHA_UPASAMUHA" character varying(100),
    "NO_OF_POST" numeric(22,0)
);
 "   DROP TABLE public."PIS_DARBANDI";
       public         heap    postgres    false            �           1259    35542    PIS_DELETD_FRM_FULFILD_DARB    TABLE     W  CREATE TABLE public."PIS_DELETD_FRM_FULFILD_DARB" (
    "SN" numeric(22,0) NOT NULL,
    "EMP_ID" numeric(22,0),
    "FRM_SN_IN_FD" numeric(22,0),
    "FRM_OFFICE_ID" numeric(22,0),
    "FRM_DARBANDI_ID" numeric(22,0),
    "FRM_DATE_FULFILLED" character varying(10),
    "FRM_APPOINTMNT_TYPE" numeric(22,0),
    "TO_SN_IN_FD" numeric(22,0)
);
 1   DROP TABLE public."PIS_DELETD_FRM_FULFILD_DARB";
       public         heap    postgres    false            �           1259    34172    PIS_EDUCATION    TABLE       CREATE TABLE public."PIS_EDUCATION" (
    "SN" numeric(22,0) NOT NULL,
    "EMP_ID" numeric(22,0),
    "EDU_NAME" character varying(70),
    "EDU_LEVEL_ID" numeric(22,0),
    "INSTITUTE" character varying(70),
    "BOARD_ID" numeric(22,0),
    "MARKS_PERCNT" double precision,
    "MARKS_GRADE" double precision,
    "DIVISION" character varying(25),
    "COMPLETION_YR_VS" character varying(10),
    "COMPLETION_YR_AD" date,
    "SUBJECTS" character varying(100),
    "VALID_FOR_EVAL" numeric(22,0),
    "APPLY_TO" character varying(2)
);
 #   DROP TABLE public."PIS_EDUCATION";
       public         heap    postgres    false            +           1259    33513    PIS_EDU_BOARD    TABLE     �   CREATE TABLE public."PIS_EDU_BOARD" (
    "ID" numeric(22,0) NOT NULL,
    "NAME_NEP" character varying(100),
    "NAME_ENG" character varying(100),
    "COUNTRY_ID" numeric(22,0),
    "PLACE" character varying(70)
);
 #   DROP TABLE public."PIS_EDU_BOARD";
       public         heap    postgres    false            ,           1259    33518    PIS_EDU_LEVEL    TABLE     t   CREATE TABLE public."PIS_EDU_LEVEL" (
    "EDU_ID" numeric(22,0) NOT NULL,
    "EDU_NAME" character varying(100)
);
 #   DROP TABLE public."PIS_EDU_LEVEL";
       public         heap    postgres    false            �           1259    34752    PIS_EMPLOYEE_MASTER    TABLE     �  CREATE TABLE public."PIS_EMPLOYEE_MASTER" (
    "EMP_ID" numeric(22,0) NOT NULL,
    "FIRST_NAME_NP" character varying(70),
    "LAST_NAME_NP" character varying(50),
    "FIRST_NAME_EN" character varying(70),
    "LAST_NAME_EN" character varying(50),
    "POST_ID" numeric(22,0),
    "SERVICE_GROUP" character varying(30),
    "TITLE" character varying(30),
    "GENDER" character varying(1),
    "FATHER_NAME" character varying(70),
    "HUSBAND_NAME" character varying(70),
    "WILL_PERSON" character varying(70),
    "ADDRESS" character varying(100),
    "DATE_OF_BIRTH" character varying(25),
    "FIRST_APPOINT_DATE" character varying(10),
    "FIRST_APPOINT_POST_ID" numeric(22,0),
    "CURRENT_POST_APPOINT_DATE" character varying(10),
    "SERVICE_STATUS" character varying(40),
    "POST_STATUS" character varying(40),
    "GRADES" numeric(22,0),
    "CIT_PERCENT" numeric(22,0),
    "PAYMODE" character varying(30),
    "GOVT_EMP_ID" character varying(50),
    "PF_ID" character varying(50),
    "CIT_ID" character varying(50),
    "POST_LEVEL" numeric(22,0),
    "RETIRE_DATE" character varying(10),
    "LOCAL_POST_ID" numeric(22,0),
    "PHONES" character varying(50),
    "EMAILS" character varying(50),
    "PAYEMENT_BANK_ID" numeric(22,0),
    "MARRIED_STATUS" character varying(1),
    "INSURANCE_NO" character varying(50),
    "MOBILE_NO" character varying(20),
    "RELIGION" numeric(22,0),
    "PARENT_OCUPATION" numeric(22,0),
    "SPOUSE_OCUPATION" numeric(22,0),
    "GF_NAME" character varying(70),
    "GF_OCUPATION" numeric(22,0),
    "REL_WITH_WILL_PERSON" character varying(25),
    "ZONE_ID" numeric(22,0),
    "DISTRICT_ID" numeric(22,0),
    "VDC_ID" numeric(22,0),
    "WARD_NO" numeric(22,0),
    "MAIL_ADDRESS" character varying(100),
    "APPOINMENT_TYPE" numeric(22,0),
    "CITIZENSHIP_NO" character varying(25),
    "CS_ISSUED_DATE" character varying(10),
    "CS_ISSUED_DISTRICT" numeric(22,0),
    "DATE_OF_BIRTH_AD" date,
    "INSURANCE_FACILITY" character varying(1),
    "DEDUCT_ABSENT" character varying(1),
    "LEKHA_NO" character varying(50),
    "DEPT_ID" numeric(22,0),
    "PENSION_KOSH" character varying(2),
    "CIT_CODE" character varying(20),
    "ROOM_ID" numeric(22,0),
    "CODE" character varying(70)
);
 )   DROP TABLE public."PIS_EMPLOYEE_MASTER";
       public         heap    postgres    false            �           1259    35297    PIS_EMP_ADV_DED_DTL    TABLE     �   CREATE TABLE public."PIS_EMP_ADV_DED_DTL" (
    "ID" numeric(22,0) NOT NULL,
    "EMP_ID" numeric(22,0),
    "ACC_ID" numeric(22,0),
    "AMOUNT_CUR" double precision,
    "AMOUNT_PREV" double precision
);
 )   DROP TABLE public."PIS_EMP_ADV_DED_DTL";
       public         heap    postgres    false            -           1259    33523    PIS_EMP_BARGA    TABLE     �   CREATE TABLE public."PIS_EMP_BARGA" (
    "ID" numeric(22,0) NOT NULL,
    "NAME_NP" character varying(25),
    "NAME_EN" character varying(25),
    "DESCRIPTION" character varying(100)
);
 #   DROP TABLE public."PIS_EMP_BARGA";
       public         heap    postgres    false            .           1259    33528    PIS_EMP_DEP    TABLE     �  CREATE TABLE public."PIS_EMP_DEP" (
    "DEPT_ID" numeric(22,0) NOT NULL,
    "NAME_NP" character varying(70) NOT NULL,
    "NAME_EN" character varying(70),
    "DESCRIPTION" character varying(70),
    "SALARY_ACC_ID" numeric(22,0) NOT NULL,
    "ALLOWANCE_ACC_ID" numeric(22,0),
    "ADD_PF_ACC_ID" numeric(22,0),
    "ADD_INSRNCE_ACC_ID" numeric(22,0),
    "SUB_PF_ACC_ID" numeric(22,0),
    "SUB_INSRNCE_ACC_ID" numeric(22,0),
    "CIT_ACC_ID" numeric(22,0),
    "INCME_TAX_ACC_ID" numeric(22,0),
    "LEND_PF_D_ACC_ID" numeric(22,0),
    "SOC_SEC_TAX" numeric(22,0),
    "BHATTA_ACC_ID" numeric(22,0),
    "PESKI_KATTI_ACC_ID" numeric(22,0),
    "OTHR_KATTI_ACC_ID" numeric(22,0),
    "ABSNT_KATTI_ACC_ID" numeric(22,0),
    "SAPATI_KATTI_ACC_ID" numeric(22,0),
    "BUDGET_SOURCE_ID" numeric(22,0),
    "TDS_ACC_ID" numeric(22,0),
    "WORK_ID" numeric(22,0),
    "BUDJET_SOURCE_ID" numeric(22,0)
);
 !   DROP TABLE public."PIS_EMP_DEP";
       public         heap    postgres    false            �           1259    34187    PIS_EMP_DEP_SOURCE    TABLE     �   CREATE TABLE public."PIS_EMP_DEP_SOURCE" (
    "DEPT_ID" numeric(22,0) NOT NULL,
    "BUDJET_SOURCE_ID" numeric(22,0) NOT NULL
);
 (   DROP TABLE public."PIS_EMP_DEP_SOURCE";
       public         heap    postgres    false            /           1259    33533    PIS_EMP_INSURANCE_PAID    TABLE     �   CREATE TABLE public."PIS_EMP_INSURANCE_PAID" (
    "ID" numeric(22,0) NOT NULL,
    "EMP_ID" numeric(22,0),
    "AMOUNT" double precision,
    "FISCAL_YEAR" character varying(10),
    "REMARKS" text
);
 ,   DROP TABLE public."PIS_EMP_INSURANCE_PAID";
       public         heap    postgres    false            �           1259    35307    PIS_EMP_LOANS    TABLE     a  CREATE TABLE public."PIS_EMP_LOANS" (
    "LOAN_ID" numeric(22,0) NOT NULL,
    "NAME_NP" character varying(70),
    "NAME_EN" character varying(70),
    "EMP_ID" numeric(22,0),
    "ACC_ID" numeric(22,0),
    "LOAN_AMT" double precision,
    "INSTALLMENT_AMT" double precision,
    "PAID_AMOUNT" double precision,
    "CLEARED" character varying(1)
);
 #   DROP TABLE public."PIS_EMP_LOANS";
       public         heap    postgres    false            �           1259    35317    PIS_EMP_LONG_LEAVES    TABLE     Z  CREATE TABLE public."PIS_EMP_LONG_LEAVES" (
    "SN" numeric(22,0) NOT NULL,
    "EMP_ID" numeric(22,0),
    "LOCAL_POST_ID" numeric(22,0),
    "LEAVE_NAME" character varying(70),
    "WORKING_OFFICE" character varying(70),
    "FROM_DATE_VS" character varying(10),
    "TO_DATE_VS" character varying(10),
    "REMARKS" character varying(100)
);
 )   DROP TABLE public."PIS_EMP_LONG_LEAVES";
       public         heap    postgres    false            �           1259    35332    PIS_EMP_MED_EXPENSE    TABLE     Q  CREATE TABLE public."PIS_EMP_MED_EXPENSE" (
    "SN" numeric(22,0) NOT NULL,
    "EMP_ID" numeric(22,0),
    "LOCAL_POST_ID" numeric(22,0),
    "WORKING_OFFICE" character varying(70),
    "ISSUED_DATE" character varying(10),
    "REGULAR_AMT" double precision,
    "SPECIAL_AMT" double precision,
    "REMARKS" character varying(100)
);
 )   DROP TABLE public."PIS_EMP_MED_EXPENSE";
       public         heap    postgres    false            �           1259    35347    PIS_EMP_PUNISHMNTS    TABLE     1  CREATE TABLE public."PIS_EMP_PUNISHMNTS" (
    "SN" numeric(22,0) NOT NULL,
    "EMP_ID" numeric(22,0),
    "LOCAL_POST_ID" numeric(22,0),
    "WORKING_OFFICE" character varying(70),
    "PUNISH_TYPE" character varying(90),
    "PUNISH_DATE" character varying(10),
    "REMARKS" character varying(100)
);
 (   DROP TABLE public."PIS_EMP_PUNISHMNTS";
       public         heap    postgres    false            �           1259    35362    PIS_EMP_SRVC_DTLS    TABLE     n  CREATE TABLE public."PIS_EMP_SRVC_DTLS" (
    "SN" numeric(22,0) NOT NULL,
    "EMP_ID" numeric(22,0),
    "LOCAL_POST_ID" numeric(22,0),
    "OFFICE_DETAIL" character varying(70),
    "GEO_REGION" numeric(22,0),
    "APPOINTMENT_TYPE" numeric(22,0),
    "DATE_FROM" character varying(10),
    "DATE_TO" character varying(10),
    "REMARKS" character varying(90)
);
 '   DROP TABLE public."PIS_EMP_SRVC_DTLS";
       public         heap    postgres    false            �           1259    35377    PIS_EMP_SUSPENDS    TABLE     U  CREATE TABLE public."PIS_EMP_SUSPENDS" (
    "SN" numeric(22,0) NOT NULL,
    "EMP_ID" numeric(22,0),
    "LOCAL_POST_ID" numeric(22,0),
    "NAME_NP" character varying(100),
    "WORKING_OFFICE" character varying(70),
    "FROM_DATE_VS" character varying(10),
    "TO_DATE_VS" character varying(10),
    "REMARKS" character varying(100)
);
 &   DROP TABLE public."PIS_EMP_SUSPENDS";
       public         heap    postgres    false            �           1259    35392    PIS_EMP_TRNSFR_REC    TABLE       CREATE TABLE public."PIS_EMP_TRNSFR_REC" (
    "SN" numeric(22,0) NOT NULL,
    "EMP_ID" numeric(22,0),
    "LOCAL_POST_ID" numeric(22,0),
    "REF_NO" character varying(50),
    "TRNSFR_DATE" character varying(10),
    "AMT_TAKEN" double precision,
    "TRNSFRD_OFFICE" character varying(70),
    "MOVED_DATE" character varying(10),
    "REMARKS" character varying(100),
    "USER_ID" numeric(22,0),
    "USER_IDE" numeric(22,0),
    "DATA_ENTRY_VS_DATE" character varying(10),
    "DATA_ENTRY_AD_DATE" date,
    "DATA_EDIT_AD_DATE" date
);
 (   DROP TABLE public."PIS_EMP_TRNSFR_REC";
       public         heap    postgres    false            �           1259    34785    PIS_FOREIGN_VISITS    TABLE     �  CREATE TABLE public."PIS_FOREIGN_VISITS" (
    "SN" numeric(22,0) NOT NULL,
    "EMP_ID" numeric(22,0),
    "LOCAL_POST_ID" numeric(22,0),
    "WORKING_OFFICE" character varying(70),
    "FROM_DATE_VS" character varying(10),
    "TO_DATE_VS" character varying(10),
    "FROM_DATE_AD" date,
    "TO_DATE_AD" date,
    "VISITING_PRPSE" character varying(100),
    "FUNDED_BY" character varying(70),
    "REMARKS" character varying(90),
    "APPLY_TO" character varying(2)
);
 (   DROP TABLE public."PIS_FOREIGN_VISITS";
       public         heap    postgres    false            �           1259    35088    PIS_FULFILLED_DARBANDI    TABLE     F  CREATE TABLE public."PIS_FULFILLED_DARBANDI" (
    "SN" numeric(22,0) NOT NULL,
    "OFFICE_ID" numeric(22,0),
    "DARBANDI_ID" numeric(22,0),
    "PERSON_TYPE_ID" numeric(22,0),
    "EMP_ID" numeric(22,0),
    "DATE_FULFILLED" character varying(10),
    "APPOINTMNT_TYPE" numeric(22,0),
    "LOCAL_POST_ID" numeric(22,0)
);
 ,   DROP TABLE public."PIS_FULFILLED_DARBANDI";
       public         heap    postgres    false            0           1259    33541    PIS_GEO_REGION    TABLE     �   CREATE TABLE public."PIS_GEO_REGION" (
    "ID" numeric(22,0) NOT NULL,
    "GR_ID" character varying(2),
    "GR_NAME" character varying(50),
    "MARKS_PER_YEAR" double precision,
    "DETAILS" text
);
 $   DROP TABLE public."PIS_GEO_REGION";
       public         heap    postgres    false            1           1259    33549 
   PIS_HAJIRI    TABLE     �  CREATE TABLE public."PIS_HAJIRI" (
    "SN" numeric(22,0) NOT NULL,
    "YEAR" numeric(22,0),
    "MONTH" numeric(22,0),
    "EMP_ID" numeric(22,0),
    "LOCAL_POST" numeric(22,0),
    "TOTAL_DAYS" numeric(22,0),
    "PUBLIC_HOLIDAYS" numeric(22,0),
    "HAJIRI_DAYS" numeric(22,0),
    "GHABIS" numeric(22,0),
    "BIBIS" numeric(22,0),
    "CABIS" numeric(22,0),
    "BETALABIS" numeric(22,0),
    "OTHER" numeric(22,0),
    "GAYAL" numeric(22,0)
);
     DROP TABLE public."PIS_HAJIRI";
       public         heap    postgres    false            �           1259    35407    PIS_INTERNAL_TRANSFER    TABLE     7  CREATE TABLE public."PIS_INTERNAL_TRANSFER" (
    "SN" numeric(22,0) NOT NULL,
    "EMP_ID" numeric(22,0),
    "OFFICE_ID" numeric(22,0),
    "DARBANDI_ID" numeric(22,0),
    "DATE_FROM" character varying(10),
    "DATE_TO" character varying(10),
    "APPOINTMNT_TYPE" numeric(22,0),
    "DATE_OF_DECISION" character varying(10),
    "DECISION_REFERENCE" character varying(50),
    "REMARKS" character varying(100),
    "TO_OFFICE_ID" numeric(22,0),
    "TO_LOCAL_POST_ID" numeric(22,0),
    "TO_APPOINTMNT_TYPE" numeric(22,0),
    "REPLACED_EMP_ID" numeric(22,0)
);
 +   DROP TABLE public."PIS_INTERNAL_TRANSFER";
       public         heap    postgres    false            2           1259    33554    PIS_LAND_BLDNGS    TABLE     �  CREATE TABLE public."PIS_LAND_BLDNGS" (
    "SN" numeric(22,0) NOT NULL,
    "EMP_ID" numeric(22,0),
    "DESCRIPTION" character varying(150),
    "UNIT_DESC" character varying(100),
    "ZONE_ID" numeric(22,0),
    "DISTRICT_ID" numeric(22,0),
    "VDC_ID" numeric(22,0),
    "WARD_NO" character varying(10),
    "ROAD_ID" numeric(22,0),
    "STREET" character varying(70),
    "OWNERSHIP_DETAILS" character varying(100),
    "AQUISITION_TYPE_ID" numeric(22,0),
    "SPECIAL_NOTES" character varying(150),
    "APPLY_TO" character varying(2),
    "USER_ID" numeric(22,0),
    "USER_IDE" numeric(22,0),
    "DATA_ENTRY_VS_DATE" character varying(10),
    "DATA_ENTRY_AD_DATE" date,
    "DATA_EDIT_AD_DATE" date
);
 %   DROP TABLE public."PIS_LAND_BLDNGS";
       public         heap    postgres    false            3           1259    33562    PIS_LOAN_DHITO_GIVEN    TABLE     :  CREATE TABLE public."PIS_LOAN_DHITO_GIVEN" (
    "SN" numeric(22,0) NOT NULL,
    "EMP_ID" numeric(22,0),
    "DESCRIPTION" character varying(150),
    "TRANS_DESC" character varying(100),
    "REASON_TO_TAKE" character varying(100),
    "VALUE_IN_NRS" double precision,
    "RETURNING_DURATION" character varying(50),
    "SPECIAL_NOTES" character varying(150),
    "APPLY_TO" character varying(2),
    "USER_ID" numeric(22,0),
    "USER_IDE" numeric(22,0),
    "DATA_ENTRY_VS_DATE" character varying(10),
    "DATA_ENTRY_AD_DATE" date,
    "DATA_EDIT_AD_DATE" date
);
 *   DROP TABLE public."PIS_LOAN_DHITO_GIVEN";
       public         heap    postgres    false            4           1259    33570    PIS_LOAN_DHITO_TAKEN    TABLE     :  CREATE TABLE public."PIS_LOAN_DHITO_TAKEN" (
    "SN" numeric(22,0) NOT NULL,
    "EMP_ID" numeric(22,0),
    "DESCRIPTION" character varying(150),
    "TRANS_DESC" character varying(100),
    "REASON_TO_TAKE" character varying(100),
    "VALUE_IN_NRS" double precision,
    "RETURNING_DURATION" character varying(50),
    "SPECIAL_NOTES" character varying(150),
    "APPLY_TO" character varying(2),
    "USER_ID" numeric(22,0),
    "USER_IDE" numeric(22,0),
    "DATA_ENTRY_VS_DATE" character varying(10),
    "DATA_ENTRY_AD_DATE" date,
    "DATA_EDIT_AD_DATE" date
);
 *   DROP TABLE public."PIS_LOAN_DHITO_TAKEN";
       public         heap    postgres    false            �           1259    34217    PIS_LOCAL_POST_MASTER    TABLE     �  CREATE TABLE public."PIS_LOCAL_POST_MASTER" (
    "LOCAL_POST_ID" numeric(22,0) NOT NULL,
    "LOCAL_POST_NAME" character varying(70),
    "LOCAL_POST_NAME_EN" character varying(50),
    "POST_ID" numeric(22,0),
    "POST_DUTIES" text,
    "BASIC_SALARY" double precision,
    "GRADE_RATE" double precision,
    "ALLWANCE" double precision,
    "INSURANCE_ADD_AMT" double precision,
    "PAYROLL_ORDER" numeric(22,0),
    "ALLLWANCE" double precision,
    "ALLOWANCE" double precision
);
 +   DROP TABLE public."PIS_LOCAL_POST_MASTER";
       public         heap    postgres    false            5           1259    33578    PIS_NIJAMATI_SEWA_SAMUHA    TABLE     �   CREATE TABLE public."PIS_NIJAMATI_SEWA_SAMUHA" (
    "ID" numeric(22,0) NOT NULL,
    "PARENT_ID" numeric(22,0),
    "NAME_NP" character varying(100),
    "NAME_EN" character varying(100),
    "GRP_LEVEL" numeric(22,0)
);
 .   DROP TABLE public."PIS_NIJAMATI_SEWA_SAMUHA";
       public         heap    postgres    false            6           1259    33588    PIS_ORNAMENTS    TABLE     �  CREATE TABLE public."PIS_ORNAMENTS" (
    "SN" numeric(22,0) NOT NULL,
    "EMP_ID" numeric(22,0),
    "DESCRIPTION" character varying(150),
    "UNIT_DESC" character varying(100),
    "AQUISITION_TYPE_ID" numeric(22,0),
    "SPECIAL_NOTES" character varying(150),
    "APPLY_TO" character varying(2),
    "USER_ID" numeric(22,0),
    "USER_IDE" numeric(22,0),
    "DATA_ENTRY_VS_DATE" character varying(10),
    "DATA_ENTRY_AD_DATE" date,
    "DATA_EDIT_AD_DATE" date
);
 #   DROP TABLE public."PIS_ORNAMENTS";
       public         heap    postgres    false            �           1259    34795    PIS_OTHER_ADD_SUB    TABLE     �   CREATE TABLE public."PIS_OTHER_ADD_SUB" (
    "ID" numeric(22,0) NOT NULL,
    "ACC_ID" numeric(22,0),
    "LOCAL_POST_ID" numeric(22,0),
    "AMOUNT" double precision,
    "ADD_SUB" character varying(1),
    "DESCRIPTION" character varying(80)
);
 '   DROP TABLE public."PIS_OTHER_ADD_SUB";
       public         heap    postgres    false            7           1259    33593    PIS_PAYROLLS    TABLE     �  CREATE TABLE public."PIS_PAYROLLS" (
    "ID" numeric(22,0) NOT NULL,
    "MONTH" smallint,
    "EMP_ID" integer NOT NULL,
    "LOCAL_POST_ID" numeric(22,0),
    "POST_IN_SHORT" character varying(40),
    "LOCAL_POST" character varying(70),
    "EMP_NAME_NP" character varying(70),
    "BASIC_SALARY" double precision,
    "GRADE_INC_MONTH" smallint,
    "RATE_OF_GRADE" double precision,
    "GRADE_AMOUNT" double precision,
    "GRADE_SALARY_TOTAL" double precision,
    "ALLOWANCE_AMT" double precision,
    "OTHER_ALLOWANCE_AMT" double precision,
    "PF_ADD_AMT" double precision,
    "INSURANCE_ADD_AMT" double precision,
    "NET_SALARY" double precision,
    "PF_DEDUCT_AMT" double precision,
    "INSURANCE_DEDUCT_AMT" double precision,
    "CIT_PERCENT" double precision,
    "CIT_AMT" double precision,
    "TAX_AMT" double precision,
    "ADVANCE_DEDUCT_AMT" double precision,
    "LOAN_DEDUCT_AMT" double precision,
    "ABSENT_DAYS" numeric(22,0),
    "ABSENT_DEDUCT_AMT" double precision,
    "OTHER_DEDUCT_TOTAL" double precision,
    "TOTAL_PAYABLE_SALARY" double precision,
    "PAYMODE" character varying(30),
    "POST_LEVEL" numeric(22,0),
    "VCHR_ID" numeric(22,0),
    "VCHR_DATE_NP" character varying(10),
    "PAY_BANK_ID" numeric(22,0),
    "TRANS_TPE_ID" numeric(22,0),
    "DEDUCT_DEP_VCHR_ID" numeric(22,0),
    "DEDUCT_DEP_VCHR_DATE_NEP" character varying(10),
    "REMARKS" character varying(100),
    "FISCAL_YEAR" character varying(9),
    "FESTIVE_VCHR_ID" numeric(22,0),
    "FESTIVE_VCHR_DATE_NEP" character varying(10),
    "PENSIONKOSH_ADD_AMT" numeric(22,0),
    "PENSIONKOSH_DED_AMT" numeric(22,0),
    "TDS_AMT" double precision
);
 "   DROP TABLE public."PIS_PAYROLLS";
       public         heap    postgres    false            8           1259    33598    PIS_PD_ORG_INVLVMNT    TABLE     �  CREATE TABLE public."PIS_PD_ORG_INVLVMNT" (
    "SN" numeric(22,0) NOT NULL,
    "EMP_ID" numeric(22,0),
    "ORG_NAME" character varying(70),
    "ORG_ADD" character varying(100),
    "ORG_FORMED_DATE" character varying(10),
    "ORG_AIMS" character varying(150),
    "ORG_ACHEIVMNTS" character varying(150),
    "NO_OF_BENIFIC_POPLN" numeric(22,0),
    "POST_IN_ORG" character varying(50),
    "RESPNSBLTY_IN_ORG" character varying(90),
    "ORG_JOINED_DATE" character varying(10),
    "ORG_LEFT_DATE" character varying(10),
    "REMARKS" character varying(100),
    "USER_ID" numeric(22,0),
    "USER_IDE" numeric(22,0),
    "DATA_ENTRY_VS_DATE" character varying(10),
    "DATA_ENTRY_AD_DATE" date,
    "DATA_EDIT_AD_DATE" date
);
 )   DROP TABLE public."PIS_PD_ORG_INVLVMNT";
       public         heap    postgres    false            9           1259    33606    PIS_PD_SRVC_DTLS    TABLE     {  CREATE TABLE public."PIS_PD_SRVC_DTLS" (
    "SN" numeric(22,0) NOT NULL,
    "EMP_ID" numeric(22,0),
    "LOCAL_POST_ID" numeric(22,0),
    "APPOINTMNT_LEVEL" character varying(50),
    "APPOINTMNT_TYPE" numeric(22,0),
    "OFFICE_DETAIL" character varying(70),
    "DATE_FROM" character varying(10),
    "DATE_TO" character varying(10),
    "REMARKS" character varying(100)
);
 &   DROP TABLE public."PIS_PD_SRVC_DTLS";
       public         heap    postgres    false            :           1259    33611    PIS_PERSON_VISIT_RECRD    TABLE     �  CREATE TABLE public."PIS_PERSON_VISIT_RECRD" (
    "SN" numeric(22,0) NOT NULL,
    "PERSON_TYPE_ID" numeric(22,0),
    "PERSON_ID" numeric(22,0),
    "PERSON_NAME" character varying(100),
    "PERSON_POST" character varying(70),
    "REF_NO" character varying(50),
    "FROM_DATE" character varying(10),
    "TO_DATE" character varying(10),
    "AMOUNT_TAKEN" double precision,
    "VISIT_LOCATION" character varying(100),
    "JOB_DETAILS" character varying(70),
    "REMARKS" character varying(100),
    "USER_ID" numeric(22,0),
    "USER_IDE" numeric(22,0),
    "DATA_ENTRY_VS_DATE" character varying(10),
    "DATA_ENTRY_AD_DATE" date,
    "DATA_EDIT_AD_DATE" date
);
 ,   DROP TABLE public."PIS_PERSON_VISIT_RECRD";
       public         heap    postgres    false            ;           1259    33619    PIS_POST_MASTER    TABLE     `  CREATE TABLE public."PIS_POST_MASTER" (
    "POST_ID" numeric(22,0) NOT NULL,
    "GENERAL_POST" character varying(70),
    "GENERAL_POST_SHORT" character varying(40),
    "POST_LEVEL" numeric(22,0),
    "BASIC_SALARY" double precision,
    "RATE_OF_GRADE" numeric(22,0),
    "MAX_GRADE_RATE" numeric(22,0),
    "PRABIDIK_OR_PRASASAN" numeric(22,0)
);
 %   DROP TABLE public."PIS_POST_MASTER";
       public         heap    postgres    false            �           1259    34805 
   PIS_PRIZES    TABLE     �  CREATE TABLE public."PIS_PRIZES" (
    "SN" numeric(22,0) NOT NULL,
    "EMP_ID" numeric(22,0),
    "LOCAL_POST_ID" numeric(22,0),
    "NAME_NP" character varying(70),
    "DESCRIPTION" character varying(100),
    "AWARD_TYPE" character varying(30),
    "AMOUNT" double precision,
    "AWARDED_BY" character varying(70),
    "WORKING_OFFICE" character varying(70),
    "ISSUED_DATE" character varying(10),
    "REMARKS" character varying(100),
    "APPLY_TO" character varying(2)
);
     DROP TABLE public."PIS_PRIZES";
       public         heap    postgres    false            �           1259    34815    PIS_PUBLICATION    TABLE     �  CREATE TABLE public."PIS_PUBLICATION" (
    "SN" numeric(22,0) NOT NULL,
    "EMP_ID" numeric(22,0),
    "LOCAL_POST_ID" numeric(22,0),
    "NEP_NAME" character varying(70),
    "DESCRIPTION" character varying(100),
    "WORKING_OFFICE" character varying(70),
    "PUBLSH_DATE_VS" character varying(10),
    "PUBLSH_DATE_AD" date,
    "PUBLISHER" character varying(100),
    "REMARKS" character varying(90),
    "APPLY_TO" character varying(2)
);
 %   DROP TABLE public."PIS_PUBLICATION";
       public         heap    postgres    false            �           1259    35753    PIS_PYROLL_LOAN_DTLS    TABLE     p  CREATE TABLE public."PIS_PYROLL_LOAN_DTLS" (
    "ID" numeric(22,0) NOT NULL,
    "LOAND_ID" numeric(22,0),
    "MONTH" smallint,
    "NAME_NP" character varying(100),
    "EMP_ID" numeric(22,0),
    "ACC_ID" numeric(22,0),
    "LOAND_AMT" double precision,
    "INSTALLMENT_AMT" double precision,
    "CLEARED" character varying(1),
    "PAYROLL_ID" numeric(22,0)
);
 *   DROP TABLE public."PIS_PYROLL_LOAN_DTLS";
       public         heap    postgres    false            �           1259    35447    PIS_PYROLL_OTHR_DTLS    TABLE     X  CREATE TABLE public."PIS_PYROLL_OTHR_DTLS" (
    "ID" numeric(22,0) NOT NULL,
    "MONTH" smallint,
    "EMPLOYEE_ID" numeric(22,0),
    "PAYROLL_ID" numeric(22,0),
    "AMOUNT" double precision,
    "ADD_SUB" character varying(1),
    "DESCRIPTION" character varying(100),
    "ACC_ID" numeric(22,0),
    "SOURCE_TYPE" character varying(2)
);
 *   DROP TABLE public."PIS_PYROLL_OTHR_DTLS";
       public         heap    postgres    false            �           1259    35567    PIS_REPLACED_IN_DARBANDI    TABLE        CREATE TABLE public."PIS_REPLACED_IN_DARBANDI" (
    "SN" numeric(22,0) NOT NULL,
    "EMP_ID" numeric(22,0),
    "ENTRY_SN_IN_FD" numeric(22,0),
    "OFFICE_ID" numeric(22,0),
    "DARBANDI_ID" numeric(22,0),
    "DATE_FULFILLED" character varying(10),
    "APPOINTMNT_TYPE" numeric(22,0),
    "REPLACED_BY" numeric(22,0),
    "DATE_REPLACED" character varying(10),
    "DATE_OF_DECISION" character varying(10),
    "DECISION_REFERENCE" character varying(50),
    "IS_PLACED_IN_DARBANDI" numeric(22,0),
    "REMARKS" character varying(100)
);
 .   DROP TABLE public."PIS_REPLACED_IN_DARBANDI";
       public         heap    postgres    false            <           1259    33624    PIS_SERVICE_STATUS    TABLE     �   CREATE TABLE public."PIS_SERVICE_STATUS" (
    "ID" numeric(22,0) NOT NULL,
    "NAME_NP" character varying(50),
    "NAME_EN" character varying(50),
    "DESCRIPTION" character varying(70)
);
 (   DROP TABLE public."PIS_SERVICE_STATUS";
       public         heap    postgres    false            �           1259    34825    PIS_SGNFCNT_WORK    TABLE     �  CREATE TABLE public."PIS_SGNFCNT_WORK" (
    "SN" numeric(22,0) NOT NULL,
    "EMP_ID" numeric(22,0),
    "LOCAL_POST_ID" numeric(22,0),
    "NAME_NP" character varying(70),
    "DESCRIPTION" character varying(100),
    "WORKING_OFFICE" character varying(70),
    "FROM_DATE_VS" character varying(10),
    "TO_DATE_VS" character varying(10),
    "FROM_DATE_AD" date,
    "TO_DATE_AD" date,
    "DURATION" character varying(25),
    "REMARKS" character varying(100),
    "APPLY_TO" character varying(2)
);
 &   DROP TABLE public."PIS_SGNFCNT_WORK";
       public         heap    postgres    false            =           1259    33629    PIS_SHARE_BANKBALANCE    TABLE     :  CREATE TABLE public."PIS_SHARE_BANKBALANCE" (
    "SN" numeric(22,0) NOT NULL,
    "EMP_ID" numeric(22,0),
    "DESCRIPTION" character varying(150),
    "COMPANY_OR_BANK" character varying(70),
    "VALUE_IN_NRS" double precision,
    "OWNERSHIP_DETAILS" character varying(100),
    "AQUISITION_TYPE_ID" numeric(22,0),
    "SPECIAL_NOTES" character varying(150),
    "APPLY_TO" character varying(2),
    "USER_ID" numeric(22,0),
    "USER_IDE" numeric(22,0),
    "DATA_ENTRY_VS_DATE" character varying(10),
    "DATA_ENTRY_AD_DATE" date,
    "DATA_EDIT_AD_DATE" date
);
 +   DROP TABLE public."PIS_SHARE_BANKBALANCE";
       public         heap    postgres    false            �           1259    34835    PIS_TRAINING    TABLE     ]  CREATE TABLE public."PIS_TRAINING" (
    "SN" numeric(22,0) NOT NULL,
    "EMP_ID" numeric(22,0),
    "LOCAL_POST_ID" numeric(22,0),
    "TRAINING_TYPE" character varying(70),
    "TRAINING_NAME" character varying(70),
    "INSTITUTE" character varying(70),
    "COUNTRY_ID" numeric(22,0),
    "FRM_DATE_VS" character varying(10),
    "TO_DATE_VS" character varying(10),
    "FRM_DATE_AD" date,
    "TO_DATE_AD" date,
    "DURATION" character varying(25),
    "DIVISION" character varying(15),
    "MARKS_OBTND" double precision,
    "VALID_FOR_EVAL" numeric(22,0),
    "APPLY_TO" character varying(2)
);
 "   DROP TABLE public."PIS_TRAINING";
       public         heap    postgres    false            �           1259    35482    PIS_VISITED_COUNTRIES    TABLE     �   CREATE TABLE public."PIS_VISITED_COUNTRIES" (
    "SN" numeric(22,0) NOT NULL,
    "VISIT_ID" numeric(22,0),
    "EMP_ID" numeric(22,0),
    "COUNTRY_ID" numeric(22,0),
    "APPLY_TO" character varying(2)
);
 +   DROP TABLE public."PIS_VISITED_COUNTRIES";
       public         heap    postgres    false            �           1259    34845    PIS_WORKSHOP    TABLE     =  CREATE TABLE public."PIS_WORKSHOP" (
    "SN" numeric(22,0) NOT NULL,
    "EMP_ID" numeric(22,0),
    "LOCAL_POST_ID" numeric(22,0),
    "NEP_NAME" character varying(70),
    "DESCRIPTION" character varying(100),
    "WORKING_OFFICE" character varying(70),
    "DURATION" character varying(25),
    "FROM_DATE_VS" character varying(10),
    "TO_DATE_VS" character varying(10),
    "FROM_DATE_AD" date,
    "TO_DATE_AD" date,
    "ORGANIZER" character varying(100),
    "COUNTRY_ID" numeric(22,0),
    "REMARKS" character varying(90),
    "APPLY_TO" character varying(2)
);
 "   DROP TABLE public."PIS_WORKSHOP";
       public         heap    postgres    false            >           1259    33637    PMS_YOJTYPE    TABLE     �   CREATE TABLE public."PMS_YOJTYPE" (
    "ID" numeric(22,0) NOT NULL,
    "YOJTYPE_NAME_NP" character varying(150) NOT NULL,
    "YOJTYPE_NAME_ENG" character varying(150),
    "YOJTYPE_REMARKS" character varying(100)
);
 !   DROP TABLE public."PMS_YOJTYPE";
       public         heap    postgres    false            @           1259    33647    RENTTYPE    TABLE     �   CREATE TABLE public."RENTTYPE" (
    "ID" numeric(22,0),
    "NEPNAME" character varying(50),
    "ENGNAME" character varying(50),
    "REMARKS" character varying(255)
);
    DROP TABLE public."RENTTYPE";
       public         heap    postgres    false            ?           1259    33642    RENT_DAR_RATE    TABLE     �   CREATE TABLE public."RENT_DAR_RATE" (
    "ID" numeric(22,0) NOT NULL,
    "RATENAME" character varying(100),
    "RENT_PER" double precision,
    "RENT_TYPEID" numeric(22,0)
);
 #   DROP TABLE public."RENT_DAR_RATE";
       public         heap    postgres    false            A           1259    33650    REPORT_GENERAL    TABLE     D  CREATE TABLE public."REPORT_GENERAL" (
    "REPORT_ID" numeric(22,0),
    "OFFICE_TYPE_ID" numeric(22,0),
    "REPORT_NAME" character varying(60),
    "REPORT_FOR" character varying(50),
    "ANUSUCHI_HEAD" character varying(30),
    "ANUSUCHI_DETAILS" character varying(200),
    "REPORT_HEADING" character varying(200)
);
 $   DROP TABLE public."REPORT_GENERAL";
       public         heap    postgres    false            B           1259    33656    SANITATION_GROUP    TABLE     t   CREATE TABLE public."SANITATION_GROUP" (
    "ID" numeric(22,0) NOT NULL,
    "GROUPNAME" character varying(200)
);
 &   DROP TABLE public."SANITATION_GROUP";
       public         heap    postgres    false            �           1259    34858    SANITATION_RATE    TABLE     j  CREATE TABLE public."SANITATION_RATE" (
    "ID" numeric(22,0) NOT NULL,
    "GROUPID" numeric(22,0),
    "SUBGROUPID" numeric(22,0),
    "ROAD_TYPEID" numeric(22,0),
    "RATENAME" text,
    "RATE" double precision,
    "FISCAL_YEAR" character varying(10),
    "AREA_UPTO" numeric(22,0),
    "FOR_EACH_AREA" numeric(22,0),
    "EACH_AREA_RATE" numeric(22,0)
);
 %   DROP TABLE public."SANITATION_RATE";
       public         heap    postgres    false            �           1259    34230    SANITATION_SUBGROUP    TABLE     �   CREATE TABLE public."SANITATION_SUBGROUP" (
    "ID" numeric(22,0) NOT NULL,
    "GROUPID" numeric(22,0),
    "SUBGROUPNAME" character varying(200),
    "REMARKS" character varying(255)
);
 )   DROP TABLE public."SANITATION_SUBGROUP";
       public         heap    postgres    false            �           1259    34444    SERVICE_CHARGE_MASTER    TABLE       CREATE TABLE public."SERVICE_CHARGE_MASTER" (
    "ID" integer NOT NULL,
    "RATEID" integer,
    "ACCODE" integer,
    "ACC_ID" numeric(22,0),
    "SERVICE_CHARGE_PERCENT" double precision,
    "FLAT_CHARGE_RATE" double precision,
    "ISAPPLICABLEFORHOUSE" smallint
);
 +   DROP TABLE public."SERVICE_CHARGE_MASTER";
       public         heap    postgres    false            C           1259    33661    SPACEMEASURINGUNITS    TABLE     �   CREATE TABLE public."SPACEMEASURINGUNITS" (
    "UNITID" numeric(22,0),
    "UNITNAME" character varying(50),
    "SQFTPERUNIT" numeric(22,0)
);
 )   DROP TABLE public."SPACEMEASURINGUNITS";
       public         heap    postgres    false            �           1259    34270    STOREDBILLS    TABLE        CREATE TABLE public."STOREDBILLS" (
    "SN" numeric(22,0) NOT NULL,
    "DATEISSUED" character varying(10),
    "DESCRIPTION" character varying(70),
    "BILLNOFROM" character varying(25),
    "BILLNOTO" character varying(25),
    "CODE" numeric(22,0),
    "BILLTYPEID" numeric(22,0)
);
 !   DROP TABLE public."STOREDBILLS";
       public         heap    postgres    false            D           1259    33664    SUBJECT_AREA    TABLE     �   CREATE TABLE public."SUBJECT_AREA" (
    "ID" numeric(22,0) NOT NULL,
    "PARENT_ID" numeric(22,0),
    "CODE" character varying(70),
    "NEP_NAME" text,
    "ENG_NAME" character varying(100),
    "REMARKS" character varying(200)
);
 "   DROP TABLE public."SUBJECT_AREA";
       public         heap    postgres    false            �           1259    34076    SUB_MODULE_SOURCE    TABLE     �   CREATE TABLE public."SUB_MODULE_SOURCE" (
    "SUB_MODULE_ID" numeric(22,0) NOT NULL,
    "BUDJET_SOURCE_ID" numeric(22,0) NOT NULL
);
 '   DROP TABLE public."SUB_MODULE_SOURCE";
       public         heap    postgres    false            E           1259    33672    SV_BUSINESSMASTER    TABLE     }  CREATE TABLE public."SV_BUSINESSMASTER" (
    "ID" numeric(22,0) NOT NULL,
    "NEPNAME" character varying(70),
    "DESCRIPTION" character varying(70),
    "BUSINESSGROUPID" numeric(22,0),
    "TYPEID" numeric(22,0),
    "TAXPAYERID" numeric(22,0),
    "INITIALCAPITAL" numeric(22,0),
    "ZONEID" numeric(22,0),
    "DISTRICTID" numeric(22,0),
    "VDCID" numeric(22,0),
    "WARDNO" numeric(22,0),
    "STREET" character varying(70),
    "TRACKID" numeric(22,0),
    "HOUSENO" character varying(50),
    "PHONES" character varying(50),
    "EMAILS" character varying(100),
    "HOUSEOWNER" character varying(70),
    "ISINRENT" smallint,
    "MONTHLYRENT" numeric(22,0),
    "AREAINSQUAREFEETS" numeric(22,0),
    "INITIALREGISTEREDOFFICE" character varying(70),
    "INITIALREGNO" character varying(30),
    "INITIALREGDATE" character varying(10),
    "MUNICIPALREGNO" character varying(30),
    "MUNICIPALLREGDATE" character varying(10),
    "SQFEETSOFSIGNBOARD" numeric(22,0),
    "LENGTHOFSIGNBOARD" numeric(22,0),
    "WIDTHOFSIGNBOARD" numeric(22,0),
    "CONTENTOFSIGNBOARD" character varying(90),
    "BUSINESSSTARTINGDATE" character varying(10),
    "SPECIALNOTES" character varying(100),
    "USERID" numeric(22,0),
    "USERIDE" numeric(22,0),
    "DATAENTRYVSDATE" character varying(10),
    "DATAENTRYADDATETIME" date,
    "DATAEDITADDATETIME" date,
    "GENERALRATEID" numeric(22,0),
    "MAIL_ADDRESS" character varying(200),
    "BUSINESS_STATUS" smallint,
    "CLOSED_VS_DATE" character varying(10),
    "CLOSE_REASON" character varying(200),
    "PAID_LAST_FISCALYEAR" character varying(10),
    "SANITATIONID" numeric(22,0),
    "MAXCAPITAL" double precision,
    "YEARLY_TRAN_AMOUNT" double precision,
    "SHIFTDATE" character varying(12),
    "SHIFTTAXPAYERID" numeric(22,0),
    "ADDRESSCHANGE" character varying(12),
    "HOUSEID" numeric(22,0),
    "BUSINESSOWNERTAX_IID" numeric(22,0)
);
 '   DROP TABLE public."SV_BUSINESSMASTER";
       public         heap    postgres    false            F           1259    33680    SV_CONSTRUCTIONS    TABLE     2  CREATE TABLE public."SV_CONSTRUCTIONS" (
    "ID" numeric(22,0) NOT NULL,
    "IID" numeric(22,0),
    "HOUSEID" numeric(22,0),
    "TALANUMBER" numeric(22,0),
    "CONSTRUCTIONTYPEID" numeric(22,0),
    "LENGTHINFEET" numeric(22,0),
    "WIDTHTHINFEET" numeric(22,0),
    "HEIGHTINFEET" numeric(22,0),
    "AREAINSQFEET" numeric(22,0),
    "VSDATEOFMADE" character varying(10),
    "CONSTRUCTIONUSESTYPEID" numeric(22,0),
    "SELFUSEORINRENT" smallint,
    "GENERALRATEID" numeric(22,0),
    "INCLUDEINEVALUATION" smallint,
    "SPECIALNOTE" character varying(90),
    "USERID" numeric(22,0),
    "USERIDE" numeric(22,0),
    "DATAENTRYVSDATE" character varying(10),
    "DATAENTRYADDATETIME" date,
    "DATAEDITADDATETIME" date,
    "TAXPAYER_DEFINE_AMOUNT" numeric(22,0),
    "VSMAPPDATE" character varying(10)
);
 &   DROP TABLE public."SV_CONSTRUCTIONS";
       public         heap    postgres    false            G           1259    33685 	   SV_HOUSES    TABLE     +  CREATE TABLE public."SV_HOUSES" (
    "ID" numeric(22,0) NOT NULL,
    "IID" numeric(22,0),
    "LANDID" numeric(22,0),
    "HOUSENUMBER" character varying(50),
    "HOUSETYPEID" numeric(22,0),
    "HOUSECONSTRUCTIONTYPEID" numeric(22,0),
    "SALES_DT" character varying(10),
    "VSDATEOFMADE" character varying(10),
    "AQUISITIONDATE" character varying(10),
    "USESTYPEID" numeric(22,0),
    "HASMAPREGISTERED" smallint,
    "MAPREGISTEREDDATE" character varying(10),
    "NUMOFTALAS" numeric(22,0),
    "HEIGHTINFEETS" numeric(22,0),
    "LENGTHINFEETS" numeric(22,0),
    "WIDTHINFEETS" numeric(22,0),
    "AREAINSQFEETS" numeric(22,0),
    "SPECIALNOTE" text,
    "INCLUDEINEVALUATION" smallint,
    "AREAOFCONSTRUCTIONSINSQFEETS" numeric(22,0),
    "USERID" numeric(22,0),
    "USERIDE" numeric(22,0),
    "DATAENTRYVSDATE" character varying(10),
    "DATAENTRYADDATETIME" date,
    "DATAEDITADDATETIME" date,
    "DEFINE_AMT" double precision,
    "SANITATIONRATEID" numeric(22,0),
    "BUILDINGCODE" character varying(30),
    "BIN_GIS" numeric(22,0)
);
    DROP TABLE public."SV_HOUSES";
       public         heap    postgres    false            H           1259    33693    SV_LANDS    TABLE     �  CREATE TABLE public."SV_LANDS" (
    "ID" numeric(22,0) NOT NULL,
    "IID" numeric(22,0),
    "OLDVDCID" numeric(22,0),
    "OLDWARDNO" character varying(30),
    "LAND_RULES" text,
    "WARDNO" numeric(22,0),
    "MOTHNUMBER" character varying(50),
    "MAPNUMBER" character varying(50),
    "KITTANUMBER" text,
    "STREETNAME" character varying(70),
    "HASTRACK" smallint,
    "TRACKID" numeric(22,0),
    "TRACKRELATIONID" numeric(22,0),
    "AQUISITIONDATE" character varying(10),
    "AQUISITIONTYPEID" numeric(22,0),
    "USESTYPEID" numeric(22,0),
    "VALUEINRSONAQUISITION" numeric(22,0),
    "AREAINSQFT" numeric(22,0),
    "NONFUNCTIONALAREAINSQFT" numeric(22,0),
    "EASTBOUNDARY" character varying(70),
    "WESTBOUNDARY" character varying(70),
    "NORTHTBOUNDARY" character varying(70),
    "SOUTHTBOUNDARY" character varying(70),
    "LQTYPEID" numeric(22,0),
    "LANDNATUREID" numeric(22,0),
    "LOCATIONFACTORID" numeric(22,0),
    "SELFDECLAREDVALUEINRS" numeric(22,0),
    "SPECIALNOTE" character varying(90),
    "GENERALRATEID" numeric(22,0),
    "INCLUDEINEVALUATION" smallint,
    "USERID" numeric(22,0),
    "USERIDE" numeric(22,0),
    "DATAENTRYVSDATE" character varying(10),
    "SALES_DT" character varying(10),
    "DATAENTRYADDATETIME" date,
    "DATAEDITADDATETIME" date,
    "EVALEXCLUSIONREASONID" numeric(22,0),
    "MALPOTRATE" numeric(22,0),
    "AREA_TYPE_ID" numeric(22,0),
    "NOMINATION_DIRECTION" numeric(22,0),
    "NOMINATION_AREA" numeric(22,0),
    "NOMINATION_LENGTH" numeric(22,0),
    "NOMINATION_BREADTH" numeric(22,0),
    "NOMINATION_TF" numeric(22,0),
    "LANDTYPE" numeric(22,0),
    "EASTBOUNDARY_KITTA" character varying(50),
    "WESTBOUNDARY_KITTA" character varying(50),
    "NORTHBOUNDARY_KITTA" character varying(50),
    "SOUTHBOUNDARY_KITTA" character varying(50),
    "TOLENAME" character varying(50),
    "LANDMEASURINGUNITID" numeric(22,0),
    "GRID_NO" character varying(100),
    "SHEET_NO" character varying(100),
    "EASTRUNFT" character varying(5),
    "WESTRUNFT" character varying(5),
    "NORTHRUNFT" character varying(5),
    "SOUTHRUNFT" character varying(5),
    "AREAINSQFT_FIELD" numeric(22,0),
    "IS_LRMIS_ADD" character varying(2),
    "DEIGSTERTYPEID" character varying(2)
);
    DROP TABLE public."SV_LANDS";
       public         heap    postgres    false            I           1259    33701    SV_LANDSMULTIEVALUATIONDETAIL    TABLE     �   CREATE TABLE public."SV_LANDSMULTIEVALUATIONDETAIL" (
    "SN" numeric(22,0),
    "IID" numeric(22,0),
    "LANDID" numeric(22,0),
    "KITTANUMBER" character varying(50),
    "GENERALRATEID" numeric(22,0),
    "AREAINSQFT" numeric(22,0)
);
 3   DROP TABLE public."SV_LANDSMULTIEVALUATIONDETAIL";
       public         heap    postgres    false            J           1259    33704 	   SV_PEOPLE    TABLE     T  CREATE TABLE public."SV_PEOPLE" (
    "IID" numeric(22,0) NOT NULL,
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
    "OCUPATIONID" numeric(22,0),
    "RELIGIONID" numeric(22,0),
    "MOTHERLANGUAGEID" numeric(22,0),
    "NATIONALITYID" numeric(22,0),
    "HASCC" smallint,
    "CCNUMBER" character varying(50),
    "CCISSUEDDRISTICTID" numeric(22,0),
    "CCISSUEDDATE" character varying(10),
    "COUNTRYID" numeric(22,0),
    "ZONEID" numeric(22,0),
    "DISTRICTID" numeric(22,0),
    "VDCID" numeric(22,0),
    "WARDNO" numeric(22,0),
    "STREETNAME" character varying(60),
    "TRACKID" numeric(22,0),
    "HOUSENO" character varying(50),
    "CORESPADDRESSLINE1" character varying(50),
    "CORESPADDRESSLINE2" character varying(50),
    "CORESPADDRESSLINE3" character varying(50),
    "CORESPADDRESSLINE4" character varying(50),
    "OTHERDETAILS" character varying(180),
    "INDIVIDUALTYPE" numeric(22,0),
    "PHOTO" text,
    "USERID" numeric(22,0),
    "USERIDE" numeric(22,0),
    "DATAENTRYVSDATE" character varying(10),
    "DATAENTRYADDATETIME" date,
    "DATAEDITADDATETIME" date,
    "IPT_UNPAID_FISCAL_YEAR" character varying(9),
    "IPT_UNPAID_AMOUNT" double precision,
    "HLT_UNPAID_FISCAL_YEAR" character varying(9),
    "HLT_UNPAID_AMOUNT" double precision,
    "IS_UNPAID_CLEARED" character varying(1),
    "CANCEL_DATE" character varying(12),
    "CANCEL_REASON" text,
    "TOLBIKASHID" numeric(22,0),
    "IS_LRMIS_ADD" character varying(2)
);
    DROP TABLE public."SV_PEOPLE";
       public         heap    postgres    false            K           1259    33712    SV_TBHOUSEKITTANUMBER    TABLE     �   CREATE TABLE public."SV_TBHOUSEKITTANUMBER" (
    "IID" numeric(22,0),
    "HOUSEID" numeric(22,0),
    "LANDID" numeric(22,0)
);
 +   DROP TABLE public."SV_TBHOUSEKITTANUMBER";
       public         heap    postgres    false            L           1259    33715    SV_VEHICLEMASTER    TABLE     W  CREATE TABLE public."SV_VEHICLEMASTER" (
    "SN" numeric(22,0) NOT NULL,
    "TAXPAYERID" numeric(22,0),
    "VEHICLENAME" character varying(70),
    "VEHICLETYPE" numeric(22,0),
    "VEHICLENO" character varying(50),
    "REGISTEREDOFFICE" character varying(70),
    "REGISTEREDDATE" character varying(10),
    "MUNICIPALTYREGNO" character varying(30),
    "MUNICIPALTYREGDATE" character varying(10),
    "AQUISITIONTYPE" numeric(22,0),
    "AQUISITIONDATE" character varying(10),
    "AQUIREDFROM" character varying(70),
    "USESTYPE" numeric(22,0),
    "COLOR" character varying(30),
    "NUMBEROFSEATES" character varying(50),
    "CCORHPRSPOWER" character varying(50),
    "MADEOF" character varying(90),
    "ENGINENO" character varying(50),
    "CHESISNO" character varying(50),
    "MODELDESCRIPTION" character varying(70),
    "NOOFCILENDERS" character varying(50),
    "USEDFUEL" numeric(22,0),
    "SPECIALNOTES" character varying(100),
    "USERID" numeric(22,0),
    "USERIDE" numeric(22,0),
    "DATAENTRYVSDATE" character varying(10),
    "DATAENTRYADDATETIME" date,
    "DATAEDITADDATETIME" date,
    "VEHICLE_STATUS" smallint,
    "CLOSED_VS_DATE" character varying(10),
    "CLOSE_REASON" character varying(200),
    "PAID_LAST_FISCALYEAR" character varying(10),
    "NAMASARIMITI" character varying(12),
    "NAMASARITAXPAYERID" numeric(22,0)
);
 &   DROP TABLE public."SV_VEHICLEMASTER";
       public         heap    postgres    false            �           1259    34454    TAX_ADDTNL_CHRG_DTLS    TABLE     X  CREATE TABLE public."TAX_ADDTNL_CHRG_DTLS" (
    "SN" numeric(22,0) NOT NULL,
    "FISCAL_YEAR" character varying(9),
    "IID" numeric(22,0),
    "ACCODE" numeric(22,0),
    "ACC_ID" numeric(22,0),
    "AMOUNT" numeric(22,0),
    "LAND_ID" numeric(22,0),
    "RENT_ID" numeric(22,0),
    "SERVICE_CHARGE_PERCENT" double precision,
    "FLAT_CHARGE_RATE" double precision,
    "ISAPPLICABLEFORHOUSE" smallint,
    "TAX_TYPE" character varying(3),
    "SERVICE_CHARGE_TYPE" character varying(2),
    "ISREGISTATIONFEE" character varying(2),
    "BILL_ID" numeric(22,0),
    "BILL_NO" numeric(22,0)
);
 *   DROP TABLE public."TAX_ADDTNL_CHRG_DTLS";
       public         heap    postgres    false            M           1259    33723 
   TAX_MALPOT    TABLE     �  CREATE TABLE public."TAX_MALPOT" (
    "SN" bigint,
    "FISCALYEAR" character varying(9),
    "TAXPAYERID" numeric(22,0),
    "LANDID" numeric(22,0),
    "KITTANUMBER" text,
    "GENERALRATEID" numeric(22,0),
    "RATEPERUNIT" double precision,
    "SPECIALNOTES" text,
    "NETTAXAMOUNT" double precision,
    "FINEAMOUNT" double precision,
    "ADDITIONALCHARGES" double precision,
    "REDUCTIONALCHARGES" double precision,
    "TAXPAIDAMOUNT" double precision,
    "LAST_TAX_PAID_AMOUNT" double precision,
    "TOTALAREA" numeric(22,0),
    "NONEVALUATEDAREA" numeric(22,0),
    "NETEVALUATINGAREA" numeric(22,0),
    "BILLID" numeric(22,0),
    "BILLDATE" character varying(10),
    "BILLNO" character varying(25),
    "COUNTERID" numeric(22,0),
    "USERID" numeric(22,0),
    "USERIDE" numeric(22,0),
    "DATAENTRYVSDATE" character varying(10),
    "DATAENTRYADDATETIME" date,
    "DATAEDITADDATETIME" date
);
     DROP TABLE public."TAX_MALPOT";
       public         heap    postgres    false            N           1259    33729    TAX_MALPOT_HISTORY    TABLE     �  CREATE TABLE public."TAX_MALPOT_HISTORY" (
    "SN" bigint,
    "MALPOT_ID" bigint,
    "FISCALYEAR" character varying(9),
    "TAXPAYERID" numeric(22,0),
    "LANDID" numeric(22,0),
    "KITTANUMBER" text,
    "GENERALRATEID" numeric(22,0),
    "RATEPERUNIT" double precision,
    "SPECIALNOTES" text,
    "NETTAXAMOUNT" double precision,
    "FINEAMOUNT" double precision,
    "ADDITIONALCHARGES" double precision,
    "REDUCTIONALCHARGES" double precision,
    "TAXPAIDAMOUNT" double precision,
    "LAST_TAX_PAID_AMOUNT" double precision,
    "TOTALAREA" numeric(22,0),
    "NONEVALUATEDAREA" numeric(22,0),
    "NETEVALUATINGAREA" numeric(22,0),
    "BILLID" numeric(22,0),
    "BILLDATE" character varying(10),
    "BILLNO" character varying(25),
    "COUNTERID" numeric(22,0),
    "USERID" numeric(22,0),
    "USERIDE" numeric(22,0),
    "DATAENTRYVSDATE" character varying(10),
    "DATAENTRYADDATETIME" date,
    "DATAEDITADDATETIME" date
);
 (   DROP TABLE public."TAX_MALPOT_HISTORY";
       public         heap    postgres    false            O           1259    33735    TAX_RATE_CEILING    TABLE     �   CREATE TABLE public."TAX_RATE_CEILING" (
    "ID" numeric(22,0) NOT NULL,
    "NP_FROM" character varying(15),
    "NP_TO" character varying(15),
    "MARRIED_STATUS" character varying(50),
    "TAX_RATE" double precision
);
 &   DROP TABLE public."TAX_RATE_CEILING";
       public         heap    postgres    false            P           1259    33740 
   TAX_RENTAL    TABLE       CREATE TABLE public."TAX_RENTAL" (
    "ID" numeric(22,0),
    "FISCALYEAR" character varying(10),
    "TAXPAYERID" numeric(22,0),
    "CONSTRUCTIONID" numeric(22,0),
    "RENTID" numeric(22,0),
    "RATEID" numeric(22,0),
    "REMARKS" text,
    "NETTAXAMOUNT" double precision,
    "FINEAMOUNT" double precision,
    "ADDITIONALCHARGES" double precision,
    "REDUCTIONALCHARGES" double precision,
    "TAXPAIDAMOUNT" double precision,
    "LAST_TAX_PAID_AMOUNT" double precision,
    "BILLID" numeric(22,0),
    "BILLNO" character varying(50),
    "BILLDATE" character varying(12),
    "COUNTERID" numeric(22,0),
    "USERID" numeric(22,0),
    "DATEENTRYVSDATE" character varying(12),
    "DATAENTRYADDATE" date,
    "YEAR" numeric(22,0),
    "MONTH" numeric(22,0)
);
     DROP TABLE public."TAX_RENTAL";
       public         heap    postgres    false            Q           1259    33746    TAX_RT_RENTDTL    TABLE     �  CREATE TABLE public."TAX_RT_RENTDTL" (
    "ID" numeric(22,0),
    "CONSTRUCTION_ID" numeric(22,0),
    "RNAME" character varying(100),
    "RENT_TYPE_ID" numeric(22,0),
    "RENT_INSQFEET" numeric(22,0),
    "ANUAL_RENT_INCOME" double precision,
    "FISCAL_YEAR" character varying(10),
    "AGREEMENT_DATE" character varying(10),
    "VALID_UNTIL" character varying(10),
    "RENT_STATUS" character varying(5),
    "RATEID" numeric(22,0),
    "TAXPAYERID" numeric(22,0),
    "BUSINESSID" numeric(22,0),
    "REMARKS" text,
    "DATAENTRYADDATETIME" date,
    "DATAEDITADDATETIME" date,
    "USERID" numeric(22,0),
    "USERIDE" numeric(22,0),
    "DATAENTRYVSDATE" character varying(12),
    "IS_TAX_PAID_BUSINESS_PERSON" character varying(2)
);
 $   DROP TABLE public."TAX_RT_RENTDTL";
       public         heap    postgres    false            R           1259    33752    TAX_SANITATION    TABLE     (  CREATE TABLE public."TAX_SANITATION" (
    "SN" numeric(22,0),
    "FISCALYEAR" character varying(10),
    "YEAR" numeric(22,0),
    "MONTH" numeric(22,0),
    "TAXPAYERID" numeric(22,0),
    "HOUSEID" numeric(22,0),
    "RATEID" numeric(22,0),
    "SPECIALNOTES" text,
    "NETTAXAMOUNT" double precision,
    "FINEAMOUNT" double precision,
    "REDUCTIONALCHARGES" double precision,
    "TAXPAIDAMOUNT" double precision,
    "LAST_TAX_PAID_AMOUNT" double precision,
    "BILLID" numeric(22,0),
    "BILLNO" character varying(25),
    "BILLDATE" character varying(10),
    "COUNTERID" numeric(22,0),
    "USERID" numeric(22,0),
    "USERIDE" numeric(22,0),
    "DATAENTRYVSDATE" character varying(10),
    "DATAENTRYADDATETIME" date,
    "DATAEDITADDATETIME" date,
    "SERVICETYPE" character varying(5)
);
 $   DROP TABLE public."TAX_SANITATION";
       public         heap    postgres    false            �           1259    34901    TAX_THLI_ISSUED_CNTR    TABLE     �   CREATE TABLE public."TAX_THLI_ISSUED_CNTR" (
    "ID" numeric(22,0) NOT NULL,
    "THELI_ID" numeric(22,0),
    "CNTR_ID" numeric(22,0)
);
 *   DROP TABLE public."TAX_THLI_ISSUED_CNTR";
       public         heap    postgres    false            S           1259    33758    TBHOUSEKITTANUMBER    TABLE        CREATE TABLE public."TBHOUSEKITTANUMBER" (
    "IID" numeric(22,0),
    "HOUSEID" numeric(22,0),
    "LANDID" numeric(22,0)
);
 (   DROP TABLE public."TBHOUSEKITTANUMBER";
       public         heap    postgres    false            g           1259    33884    TBLBILLTYPE    TABLE     �   CREATE TABLE public."TBLBILLTYPE" (
    "ID" numeric(22,0) NOT NULL,
    "NEPNAME" character varying(100),
    "ISINCOME" character varying(1),
    "DESCRIPTION" character varying(150)
);
 !   DROP TABLE public."TBLBILLTYPE";
       public         heap    postgres    false            �           1259    34489    TBLBUSINESS_SERVICE_CH_MST    TABLE     '  CREATE TABLE public."TBLBUSINESS_SERVICE_CH_MST" (
    "ID" numeric(22,0) NOT NULL,
    "RATEID" numeric(22,0),
    "ACCODE" numeric(22,0),
    "ACC_ID" numeric(22,0),
    "SERVICECHARGEPERCENT" double precision,
    "FLATCHARGERATE" double precision,
    "FISCAL_YEAR" character varying(10)
);
 0   DROP TABLE public."TBLBUSINESS_SERVICE_CH_MST";
       public         heap    postgres    false            h           1259    33889    TBLEXEVERSION    TABLE     W   CREATE TABLE public."TBLEXEVERSION" (
    "EXEID" numeric(22,0),
    "EXEDATE" date
);
 #   DROP TABLE public."TBLEXEVERSION";
       public         heap    postgres    false            i           1259    33892    TBLFYWISEBTRATES    TABLE     S  CREATE TABLE public."TBLFYWISEBTRATES" (
    "ID" numeric(22,0),
    "GROUPID" numeric(22,0),
    "SUBGROUPID" numeric(22,0),
    "SNSUBGROUP" numeric(22,0),
    "RATEID" numeric(22,0),
    "NEPNAME" character varying(100),
    "DESCRIPTION" character varying(20),
    "FISCALYEAR" character varying(9),
    "RATEPERUNIT" numeric(22,0)
);
 &   DROP TABLE public."TBLFYWISEBTRATES";
       public         heap    postgres    false            �           1259    35507    TBLFYWISEMPOTASSRATE    TABLE     }  CREATE TABLE public."TBLFYWISEMPOTASSRATE" (
    "ID" numeric(22,0) NOT NULL,
    "GROUPID" numeric(22,0),
    "SUBGROUPID" numeric(22,0),
    "RATEID" numeric(22,0),
    "NEPNAME" character varying(100),
    "FISCALYEAR" character varying(9),
    "RATEPERUNIT" numeric(22,0),
    "AREA_UPTO" numeric(22,0),
    "FOR_EACH_AREA" numeric(22,0),
    "EACH_AREA_RATE" numeric(22,0)
);
 *   DROP TABLE public."TBLFYWISEMPOTASSRATE";
       public         heap    postgres    false            j           1259    33895    TBLHL_ADD_SUBTRACT    TABLE     +  CREATE TABLE public."TBLHL_ADD_SUBTRACT" (
    "SN" numeric(22,0) NOT NULL,
    "FISCAL_YEAR" character varying(10),
    "RATEID" numeric(22,0),
    "FLAT_RATE" numeric(22,0),
    "RATE_PERCENT" double precision,
    "ADD_FLAG" character varying(1),
    "ADD_SUB_TRACT_TYPE" character varying(2)
);
 (   DROP TABLE public."TBLHL_ADD_SUBTRACT";
       public         heap    postgres    false            k           1259    33900    TBLLAND_TYPE_AREA    TABLE     �   CREATE TABLE public."TBLLAND_TYPE_AREA" (
    "ID" numeric(22,0) NOT NULL,
    "CODE" character varying(50) NOT NULL,
    "NEP_NAME" character varying(50),
    "REMARKS" character varying(100)
);
 '   DROP TABLE public."TBLLAND_TYPE_AREA";
       public         heap    postgres    false            l           1259    33905    TBLMALPOTGROUP    TABLE     �   CREATE TABLE public."TBLMALPOTGROUP" (
    "ID" numeric(22,0) NOT NULL,
    "NEPNAME" character varying(100),
    "DESCRIPTION" character varying(150)
);
 $   DROP TABLE public."TBLMALPOTGROUP";
       public         heap    postgres    false            �           1259    34916    TBLMALPOTRATES    TABLE     ^  CREATE TABLE public."TBLMALPOTRATES" (
    "ID" numeric(22,0) NOT NULL,
    "GROUPID" numeric(22,0),
    "SUBGROUPID" numeric(22,0),
    "NEPNAME" character varying(100),
    "RATEPERUNIT" numeric(22,0),
    "DESCRIPTION" character varying(150),
    "AREA_UPTO" numeric(22,0),
    "FOR_EACH_AREA" numeric(22,0),
    "EACH_AREA_RATE" numeric(22,0)
);
 $   DROP TABLE public."TBLMALPOTRATES";
       public         heap    postgres    false            �           1259    34280    TBLMALPOTSUBGROUP    TABLE     �   CREATE TABLE public."TBLMALPOTSUBGROUP" (
    "ID" numeric(22,0) NOT NULL,
    "GROUPID" numeric(22,0),
    "NEPNAME" character varying(100),
    "DESCRIPTION" character varying(150),
    "WORDA" numeric(22,0)
);
 '   DROP TABLE public."TBLMALPOTSUBGROUP";
       public         heap    postgres    false            n           1259    33915    TBLTAXCALCULATIONROKA    TABLE     �   CREATE TABLE public."TBLTAXCALCULATIONROKA" (
    "ID" numeric(22,0),
    "IID" numeric(22,0),
    "REASON" character varying(255),
    "ROKA_DATE" character varying(12)
);
 +   DROP TABLE public."TBLTAXCALCULATIONROKA";
       public         heap    postgres    false            m           1259    33910    TBLTAX_FINE_REBATE    TABLE     2  CREATE TABLE public."TBLTAX_FINE_REBATE" (
    "SN" numeric(22,0) NOT NULL,
    "FISCAL_YEAR" character varying(10),
    "DURATION_IN_YEARS" double precision,
    "TAX_TYPE" character varying(3),
    "FLAT_RATE" numeric(22,0),
    "RATE_PERCENT" double precision,
    "REBATE_FLAG" character varying(1)
);
 (   DROP TABLE public."TBLTAX_FINE_REBATE";
       public         heap    postgres    false            �           1259    34499    TBLVEH_SER_CH_MSTR    TABLE     #  CREATE TABLE public."TBLVEH_SER_CH_MSTR" (
    "ID" numeric(22,0) NOT NULL,
    "RATEID" numeric(22,0),
    "ACCODE" numeric(22,0),
    "ACC_ID" numeric(22,0),
    "SERVICE_CHARGE_PERCENT" double precision,
    "FLAT_CHARGE_RATE" double precision,
    "FISCAL_YEAR" character varying(10)
);
 (   DROP TABLE public."TBLVEH_SER_CH_MSTR";
       public         heap    postgres    false            T           1259    33761    TBL_BANK_ACCNT_TYPE    TABLE     �   CREATE TABLE public."TBL_BANK_ACCNT_TYPE" (
    "ID" numeric(22,0) NOT NULL,
    "NEPNAME" character varying(100),
    "ENGNAME" character varying(100),
    "REMARKS" character varying(150)
);
 )   DROP TABLE public."TBL_BANK_ACCNT_TYPE";
       public         heap    postgres    false            U           1259    33766    TBL_BANK_FINANCE_INSTITUTUE    TABLE     �   CREATE TABLE public."TBL_BANK_FINANCE_INSTITUTUE" (
    "ID" numeric(22,0) NOT NULL,
    "NP_NAME" text,
    "ENG_NAME" character varying(200),
    "DESCRIPTIONG" text,
    "ACCOUNT_NAME" text
);
 1   DROP TABLE public."TBL_BANK_FINANCE_INSTITUTUE";
       public         heap    postgres    false            V           1259    33774    TBL_BGT_MGMT    TABLE       CREATE TABLE public."TBL_BGT_MGMT" (
    "ID" numeric(22,0) NOT NULL,
    "FISCAL_YEAR" character varying(10),
    "MINISTRY_ID" numeric(22,0),
    "BGT_SUB_HEAD_ID" numeric(22,0),
    "TOTAL_BGT_AMT" double precision,
    "REMARKS" character varying(200)
);
 "   DROP TABLE public."TBL_BGT_MGMT";
       public         heap    postgres    false            �           1259    34240    TBL_BGT_MGMT_EXP    TABLE     �   CREATE TABLE public."TBL_BGT_MGMT_EXP" (
    "ID" numeric(22,0) NOT NULL,
    "BGT_MGMT_ID" numeric(22,0),
    "ACC_ID" numeric(22,0),
    "BGT_AMT" double precision,
    "REMARKS" character varying(200)
);
 &   DROP TABLE public."TBL_BGT_MGMT_EXP";
       public         heap    postgres    false            �           1259    34250    TBL_BGT_MGMT_EXP_ORG    TABLE     �   CREATE TABLE public."TBL_BGT_MGMT_EXP_ORG" (
    "ID" numeric(22,0) NOT NULL,
    "BGT_MGMT_ORG_ID" numeric(22,0),
    "ACC_ID" numeric(22,0),
    "BGT_AMT_ORG" double precision,
    "REMARKS" character varying(200)
);
 *   DROP TABLE public."TBL_BGT_MGMT_EXP_ORG";
       public         heap    postgres    false            �           1259    34931    TBL_BGT_MGMT_EXP_RELEASE    TABLE     �   CREATE TABLE public."TBL_BGT_MGMT_EXP_RELEASE" (
    "ID" numeric(22,0) NOT NULL,
    "BGT_MGMT_RELEASE_ID" numeric(22,0),
    "ACC_ID" numeric(22,0),
    "AMT" double precision,
    "REMARKS" character varying(200)
);
 .   DROP TABLE public."TBL_BGT_MGMT_EXP_RELEASE";
       public         heap    postgres    false            W           1259    33779    TBL_BGT_MGMT_ORG    TABLE     '  CREATE TABLE public."TBL_BGT_MGMT_ORG" (
    "ID" numeric(22,0) NOT NULL,
    "FISCAL_YEAR" character varying(10),
    "MINISTRY_ID" numeric(22,0),
    "ORG_ID" numeric(22,0),
    "BGT_SUB_HEAD_ID" numeric(22,0),
    "TOTAL_BGT_AMT_ORG" double precision,
    "REMARKS" character varying(200)
);
 &   DROP TABLE public."TBL_BGT_MGMT_ORG";
       public         heap    postgres    false            �           1259    34349    TBL_BGT_MGMT_RELEASE    TABLE     A  CREATE TABLE public."TBL_BGT_MGMT_RELEASE" (
    "ID" numeric(22,0) NOT NULL,
    "BGT_RELEASE_ID" numeric(22,0),
    "FISCAL_YEAR" character varying(10),
    "MINISTRY_ID" numeric(22,0),
    "ORG_ID" numeric(22,0),
    "BGT_SUB_HEAD_ID" numeric(22,0),
    "AMT" double precision,
    "REMARKS" character varying(200)
);
 *   DROP TABLE public."TBL_BGT_MGMT_RELEASE";
       public         heap    postgres    false            �           1259    34876    TBL_BGT_MGMT_SRC    TABLE       CREATE TABLE public."TBL_BGT_MGMT_SRC" (
    "ID" numeric(22,0) NOT NULL,
    "BGT_MGMT_EXP_ID" numeric(22,0),
    "SOURCE_ID" numeric(22,0),
    "AMT" double precision,
    "PAYMENT_TYPE_ID" numeric(22,0),
    "PAYMENT_PROCESS_ID" numeric(22,0),
    "REMARKS" character varying(200)
);
 &   DROP TABLE public."TBL_BGT_MGMT_SRC";
       public         heap    postgres    false            �           1259    34886    TBL_BGT_MGMT_SRC_ORG    TABLE     h  CREATE TABLE public."TBL_BGT_MGMT_SRC_ORG" (
    "ID" numeric(22,0) NOT NULL,
    "BGT_MGMT_EXP_ORG_ID" numeric(22,0),
    "SOURCE_ID" numeric(22,0),
    "AMT" double precision,
    "CC_ID" numeric(22,0),
    "CC_ACTIVE" character varying(2),
    "PAYMENT_TYPE_ID" numeric(22,0),
    "PAYMENT_PROCESS_ID" numeric(22,0),
    "REMARKS" character varying(200)
);
 *   DROP TABLE public."TBL_BGT_MGMT_SRC_ORG";
       public         heap    postgres    false            �           1259    35527    TBL_BGT_MGMT_SRC_RELEASE    TABLE     p  CREATE TABLE public."TBL_BGT_MGMT_SRC_RELEASE" (
    "ID" numeric(22,0) NOT NULL,
    "BGT_MGMT_EXP_RELEASE_ID" numeric(22,0),
    "SOURCE_ID" numeric(22,0),
    "AMT" double precision,
    "CC_ID" numeric(22,0),
    "CC_ACTIVE" character varying(2),
    "PAYMENT_TYPE_ID" numeric(22,0),
    "PAYMENT_PROCESS_ID" numeric(22,0),
    "REMARKS" character varying(200)
);
 .   DROP TABLE public."TBL_BGT_MGMT_SRC_RELEASE";
       public         heap    postgres    false            w           1259    33961    TBL_BGT_RELEASE    TABLE     �  CREATE TABLE public."TBL_BGT_RELEASE" (
    "ID" numeric(22,0) NOT NULL,
    "FISCAL_YEAR" character varying(10),
    "MINISTRY_ID" numeric(22,0),
    "ORG_ID" numeric(22,0),
    "RELEASE_TYPE" numeric(22,0),
    "RELEASE_DATE" character varying(10),
    "CHALANI_NO" character varying(50),
    "LETTER_SN" character varying(50),
    "APPROVED_BGT_YEARLY" double precision,
    "PREVIOUS_RELEASE_AMT" double precision,
    "RELEASE_AMOUNT" double precision,
    "SPECIAL_TIPPANI" text
);
 %   DROP TABLE public."TBL_BGT_RELEASE";
       public         heap    postgres    false            �           1259    34469    TBL_CONSTRUCTION_OTHER_CHARGES    TABLE     T  CREATE TABLE public."TBL_CONSTRUCTION_OTHER_CHARGES" (
    "ID" numeric(22,0) NOT NULL,
    "RATEID" numeric(22,0),
    "ACCODE" numeric(22,0),
    "ACC_ID" numeric(22,0),
    "PERCENT_OF_TAX" double precision,
    "FLAT_CHARGE_RATE" numeric(22,0),
    "FISCAL_YEAR" character varying(10),
    "SERVICE_CHARGE_CALCULATION" numeric(22,0)
);
 4   DROP TABLE public."TBL_CONSTRUCTION_OTHER_CHARGES";
       public         heap    postgres    false            X           1259    33784    TBL_DATA_HISTORY    TABLE     �  CREATE TABLE public."TBL_DATA_HISTORY" (
    "ID" numeric(22,0) NOT NULL,
    "TABLE_NAME" character varying(100),
    "FIELD_NAME" character varying(100),
    "NEW_VALUE" text,
    "OLD_VALUE" character varying(100),
    "USER_ID_A" numeric(22,0),
    "ADD_DATE" date,
    "COMPUTER_NAME" character varying(100),
    "DATA_STATUS" character varying(20),
    "WINDOWS_USER" character varying(100),
    "TRAN_TIME" character varying(20)
);
 &   DROP TABLE public."TBL_DATA_HISTORY";
       public         heap    postgres    false            Y           1259    33792    TBL_DEGISTER    TABLE     �   CREATE TABLE public."TBL_DEGISTER" (
    "ID" numeric(22,0) NOT NULL,
    "NP_NAME" character varying(100),
    "ENG_NAME" character varying(100),
    "REMARKS" text,
    "IS_FULL_DEGISTER" numeric(22,0)
);
 "   DROP TABLE public."TBL_DEGISTER";
       public         heap    postgres    false            Z           1259    33800    TBL_KHARIDA_AADASH    TABLE     �   CREATE TABLE public."TBL_KHARIDA_AADASH" (
    "ID" numeric(22,0) NOT NULL,
    "NP_NAME" character varying(200),
    "ENG_NAME" character varying(100)
);
 (   DROP TABLE public."TBL_KHARIDA_AADASH";
       public         heap    postgres    false            �           1259    34479    TBL_LAND_OTHER_CHARGES    TABLE     L  CREATE TABLE public."TBL_LAND_OTHER_CHARGES" (
    "ID" numeric(22,0) NOT NULL,
    "RATEID" numeric(22,0),
    "ACCODE" numeric(22,0),
    "ACC_ID" numeric(22,0),
    "PERCENT_OF_TAX" double precision,
    "FLAT_CHARGE_RATE" numeric(22,0),
    "FISCAL_YEAR" character varying(10),
    "SERVICE_CHARGE_CALCULATION" numeric(22,0)
);
 ,   DROP TABLE public."TBL_LAND_OTHER_CHARGES";
       public         heap    postgres    false            �           1259    35492    TBL_MALPOT_OTHER_CHARGES    TABLE       CREATE TABLE public."TBL_MALPOT_OTHER_CHARGES" (
    "ID" numeric(22,0) NOT NULL,
    "RATEID" numeric(22,0),
    "ACCODE" numeric(22,0),
    "ACC_ID" numeric(22,0),
    "PERCENT_OF_TAX" double precision,
    "FLAT_CHARGE_RATE" numeric(22,0),
    "FISCAL_YEAR" character varying(10)
);
 .   DROP TABLE public."TBL_MALPOT_OTHER_CHARGES";
       public         heap    postgres    false            [           1259    33805    TBL_NALI_TYPE    TABLE     �   CREATE TABLE public."TBL_NALI_TYPE" (
    "ID" numeric(22,0) NOT NULL,
    "NEPNAME" character varying(50),
    "ENGNAME" character varying(50),
    "DESCRIPTION" character varying(50)
);
 #   DROP TABLE public."TBL_NALI_TYPE";
       public         heap    postgres    false            \           1259    33810    TBL_ORGANIZATIONMASTER    TABLE     �   CREATE TABLE public."TBL_ORGANIZATIONMASTER" (
    "ID" numeric(22,0) NOT NULL,
    "NP_NAME" text,
    "ENG_NAME" character varying(200),
    "DESCRIPTIONG" text
);
 ,   DROP TABLE public."TBL_ORGANIZATIONMASTER";
       public         heap    postgres    false            ]           1259    33818    TBL_PAYMENT_ORDER    TABLE     �   CREATE TABLE public."TBL_PAYMENT_ORDER" (
    "ID" numeric(22,0) NOT NULL,
    "ORDER_CODE" character varying(100),
    "DATE_BS" character varying(15),
    "TOKEN_NO" character varying(100),
    "REMARKS" text
);
 '   DROP TABLE public."TBL_PAYMENT_ORDER";
       public         heap    postgres    false            �           1259    34260    TBL_PAYMENT_ORDER_DETAILS    TABLE     �   CREATE TABLE public."TBL_PAYMENT_ORDER_DETAILS" (
    "ID" numeric(22,0) NOT NULL,
    "PAYMENT_ORDER_ID" numeric(22,0),
    "VOUCHER_ID" numeric(22,0),
    "LINK_VOUCHER_ID" numeric(22,0),
    "PAYMENT_PERMISS_NO" character varying(200)
);
 /   DROP TABLE public."TBL_PAYMENT_ORDER_DETAILS";
       public         heap    postgres    false            ^           1259    33826    TBL_PAYMENT_PROCESS    TABLE     �   CREATE TABLE public."TBL_PAYMENT_PROCESS" (
    "ID" numeric(22,0) NOT NULL,
    "PAYMENT_PROCESS" character varying(100),
    "PAYMENT_PROCESS_ENG" character varying(100),
    "REMARKS" character varying(200)
);
 )   DROP TABLE public."TBL_PAYMENT_PROCESS";
       public         heap    postgres    false            _           1259    33831    TBL_PAYMENT_TYPE    TABLE     �   CREATE TABLE public."TBL_PAYMENT_TYPE" (
    "ID" numeric(22,0) NOT NULL,
    "PAYMENT_TYPE" character varying(100),
    "PAYMENT_TYPE_ENG" character varying(100),
    "REMARKS" character varying(200)
);
 &   DROP TABLE public."TBL_PAYMENT_TYPE";
       public         heap    postgres    false            `           1259    33836    TBL_PROPERTY_TAX    TABLE     ?  CREATE TABLE public."TBL_PROPERTY_TAX" (
    "ID" numeric(22,0) NOT NULL,
    "IID" numeric(22,0),
    "NP_ENTRY_DATE" character varying(12),
    "FISCAL_YEAR" character varying(12),
    "HOUSE_LAND_AMOUNT" double precision,
    "MALPOT_AMOUNT" double precision,
    "TOTAL_TAX" double precision,
    "REMARKS" text
);
 &   DROP TABLE public."TBL_PROPERTY_TAX";
       public         heap    postgres    false            a           1259    33844    TBL_SANITAION_TAX    TABLE     '  CREATE TABLE public."TBL_SANITAION_TAX" (
    "ID" numeric(22,0),
    "FROM_AREA" double precision,
    "TO_AREA" double precision,
    "AMOUNT" double precision,
    "REMARKS" text,
    "FISCAL_YEAR" character varying(15),
    "ACC_ID" numeric(22,0),
    "IS_APARTMENT" character varying(2)
);
 '   DROP TABLE public."TBL_SANITAION_TAX";
       public         heap    postgres    false            b           1259    33850    TBL_STATUS_DETAILS    TABLE     �  CREATE TABLE public."TBL_STATUS_DETAILS" (
    "ID" numeric(22,0) NOT NULL,
    "MASTERID" numeric(22,0),
    "ITEM_ID" numeric(22,0),
    "BRAND_ID" numeric(22,0),
    "SPEC_ID" numeric(22,0),
    "UNIT_ID" numeric(22,0),
    "RATE" double precision,
    "STOCK_QTY" double precision,
    "USE_IN_QTY" double precision,
    "NOT_USE_IN_QTY" double precision,
    "REPAIR_QTY" double precision,
    "NOT_REPAIR_QTY" double precision
);
 (   DROP TABLE public."TBL_STATUS_DETAILS";
       public         heap    postgres    false            d           1259    33863    TBL_TAXSOURCERECORDNEW    TABLE     �  CREATE TABLE public."TBL_TAXSOURCERECORDNEW" (
    "TAXSRCID" numeric(22,0) NOT NULL,
    "FISCALYEAR" character varying(10),
    "RECORDTYPE" numeric(22,0),
    "NETINCOME_CURFY" numeric(22,0),
    "TAXPAIDTAXPAYERCNT_CURFY" numeric(22,0),
    "NETINCOME_LASTFY" numeric(22,0),
    "TAXPAIDTAXPAYERCNT_LASTFY" numeric(22,0),
    "TAXNOTPAIDTAXPAYERCNT" numeric(22,0),
    "AMOUNTNOTCOLLECTED" numeric(22,0),
    "TOTALTAXPAYERCNT" numeric(22,0)
);
 ,   DROP TABLE public."TBL_TAXSOURCERECORDNEW";
       public         heap    postgres    false            c           1259    33855    TBL_TAX_TYPE    TABLE     �   CREATE TABLE public."TBL_TAX_TYPE" (
    "ID" numeric(22,0) NOT NULL,
    "CODE" character varying(200),
    "NP_NAME" text,
    "ENG_NAME" character varying(200),
    "DESCRIPTIONG" text,
    "ACC_ID" numeric(22,0)
);
 "   DROP TABLE public."TBL_TAX_TYPE";
       public         heap    postgres    false            e           1259    33868    TBL_TOLABIKASA_ORG    TABLE     r  CREATE TABLE public."TBL_TOLABIKASA_ORG" (
    "ID" numeric(22,0) NOT NULL,
    "NP_NAME" character varying(150),
    "ENG_NAME" character varying(150),
    "ADDRESS" character varying(150),
    "CHAIRMAN" character varying(50),
    "SACHIBA" character varying(50),
    "CONTACTNO" character varying(50),
    "EMAIL" character varying(50),
    "WARDNO" numeric(22,0)
);
 (   DROP TABLE public."TBL_TOLABIKASA_ORG";
       public         heap    postgres    false            f           1259    33876    TBL_VEHICLE_PARTS    TABLE     �   CREATE TABLE public."TBL_VEHICLE_PARTS" (
    "SN" numeric(22,0) NOT NULL,
    "NP_NAME" character varying(200),
    "ENG_NAME" character varying(100),
    "REMARKS" text
);
 '   DROP TABLE public."TBL_VEHICLE_PARTS";
       public         heap    postgres    false            o           1259    33918    TBUSERSECURITYRIGHTS    TABLE     i   CREATE TABLE public."TBUSERSECURITYRIGHTS" (
    "USERID" numeric(22,0),
    "RIGHTSID" numeric(22,0)
);
 *   DROP TABLE public."TBUSERSECURITYRIGHTS";
       public         heap    postgres    false            p           1259    33921    TYPES    TABLE     �   CREATE TABLE public."TYPES" (
    "ID" numeric(22,0),
    "NEPNAME" character varying(50) NOT NULL,
    "ENGNAME" character varying(50) NOT NULL,
    "CODE" character varying(50),
    "REMARKS" character varying(100)
);
    DROP TABLE public."TYPES";
       public         heap    postgres    false            q           1259    33924    USERASSIGNMENTS    TABLE     �   CREATE TABLE public."USERASSIGNMENTS" (
    "SN" numeric(22,0),
    "NEPNAME" character varying(90),
    "RIGHTSNAME" character varying(200),
    "MODULE" character varying(5)
);
 %   DROP TABLE public."USERASSIGNMENTS";
       public         heap    postgres    false            r           1259    33927 
   Usermaster    TABLE     j  CREATE TABLE public."Usermaster" (
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
    "USERID" character varying(20),
    "USERPASSWORD" character varying(200),
    "NEPNAME" character varying(70),
    "ENGNAME" character varying(60),
    "USERSTATUS" smallint,
    "LASTLOGGEDON" date,
    "LASTLOGGEDOUT" date,
    "GRANTS" character varying(20),
    "UPDATEDBY" numeric(22,0),
    "EMP_ID" numeric(22,0),
    "ORG_CODE" character varying(10),
    "CODE" character varying(10),
    "FROM_CENTRAL" character varying(1),
    "WARD_NO" character varying(10),
    "PWD_CHANGED_DATE" date,
    "FISCAL_YEAR" character varying(12)
);
     DROP TABLE public."Usermaster";
       public         heap    postgres    false            s           1259    33935    VDC    TABLE       CREATE TABLE public."VDC" (
    "VDCID" numeric(22,0),
    "NEPNAME" character varying(50) NOT NULL,
    "ENGNAME" character varying(50) NOT NULL,
    "CODE" character varying(50),
    "REMARKS" character varying(100),
    "DISTRICTID" numeric(22,0),
    "TYPEID" numeric(22,0)
);
    DROP TABLE public."VDC";
       public         heap    postgres    false            �           1259    35462    WARD_MASTER    TABLE     p  CREATE TABLE public."WARD_MASTER" (
    "ID" numeric(22,0) NOT NULL,
    "NEP_NAME" character varying(100),
    "ENG_NAME" character varying(50),
    "ADDRESS" character varying(50),
    "PRAMUKH_ID" numeric(22,0),
    "UPPRAMUKH_ID" numeric(22,0),
    "NUMBER_OF_MEMBERS" numeric(22,0),
    "WARD_SECRETARY_ID" numeric(22,0),
    "MOBILE_NO" character varying(20)
);
 !   DROP TABLE public."WARD_MASTER";
       public         heap    postgres    false            t           1259    33938    ZONE    TABLE     �   CREATE TABLE public."ZONE" (
    "ZONEID" numeric(22,0),
    "NEPNAME" character varying(50) NOT NULL,
    "ENGNAME" character varying(50) NOT NULL,
    "CODE" character varying(50),
    "REMARKS" character varying(100),
    "REGIONID" numeric(22,0)
);
    DROP TABLE public."ZONE";
       public         heap    postgres    false            �            1259    33014    __EFMigrationsHistory    TABLE     �   CREATE TABLE public."__EFMigrationsHistory" (
    "MigrationId" character varying(150) NOT NULL,
    "ProductVersion" character varying(32) NOT NULL
);
 +   DROP TABLE public."__EFMigrationsHistory";
       public         heap    postgres    false            �          0    33115    ACCODE 
   TABLE DATA           �   COPY public."ACCODE" ("ACCODE", "SBCODE", "GRCODE", "TRANTYPE", "NEPNAME", "ENGNAME", "ISDOLLAR", "LOCALCODE", "ISASSIGNED") FROM stdin;
    public          postgres    false    221   \                 0    33987    ACC_ACC_MASTER 
   TABLE DATA             COPY public."ACC_ACC_MASTER" ("ACC_ID", "CODE", "NEP_NAME", "ENG_NAME", "PARENT_ACC_ID", "GRP_LEVEL", "IS_FIXED", "IS_TRANSACTABLE", "IS_BUDGETABLE", "DISP_CODE", "DISP_NAME", "ACC_TYPE", "TYPE_ID", "ACC_CODE", "SUB_MODULE_ID", "FISCAL_YEAR", "IS_HIDE", "ISCAPITALCURRENT") FROM stdin;
    public          postgres    false    377   $\      .          0    34159    ACC_ASULI_BIBARAN 
   TABLE DATA             COPY public."ACC_ASULI_BIBARAN" ("ASULI_ID", "PERSON_TYPE_ID", "PAYMENT_PERSON_ID", "PERSON_NAME", "WORK_NAME", "AMT_TAKEN", "RESPONSIVE_TAKEN", "COLLECT_REASON", "PESKI_AMT", "PESKI_EMPLOYEE_ID", "PROPERTY_DETAILS", "PROPERTY_EMPLOYEE_ID", "PROPERTY_ROKA") FROM stdin;
    public          postgres    false    391   A\      "          0    34018    ACC_BANK_GRNTY 
   TABLE DATA             COPY public."ACC_BANK_GRNTY" ("GRNTY_ID", "GRNTY_NO", "GRNTY_VS_DATE", "BANK_NAME", "GRNTY_AMOUNT", "GRNTY_TYPE", "WORK_ID", "PERSON_ID", "PHUKUWA_PS", "PHUKUWA_CN", "PHUKUWA_VS_DATE", "MAG_PS", "MAG_CN", "MAG_VS_DATE", "ENTRY_DATETIME", "EXPRY_VS_DATE") FROM stdin;
    public          postgres    false    379   ^\      r          0    33019    ACC_BANK_STATEMENT 
   TABLE DATA           �   COPY public."ACC_BANK_STATEMENT" ("ID", "BANK_ID", "TRANSACTION_DATE", "TRANSACTION_DATE_EN", "CHEQUE_NO", "DESCRIPTION", "DR_AMT", "CR_AMT", "BANK_TRANSACTION_ID", "BALANCE") FROM stdin;
    public          postgres    false    203   {\      g          0    35049    ACC_BANK_TRANS 
   TABLE DATA           �   COPY public."ACC_BANK_TRANS" ("BANK_TRANS_ID", "VCHR_ID", "VCHR_DATE_NEP", "DESCRIPTION", "DR_AMT", "CR_AMT", "IS_OF_LASTYEAR", "TRANS_TYPE_ID", "BILL_ID", "BANK_ID") FROM stdin;
    public          postgres    false    448   �\      s          0    33022    ACC_BGT_ALLOCATE 
   TABLE DATA           �   COPY public."ACC_BGT_ALLOCATE" ("BGT_ALLOCATE_ID", "ACC_ID", "REVISED_AMOUNT", "AMOUNT", "FISCAL_YEAR", "ALLOCATED_DATE_NP", "ENTRY_USER_ID", "ENTRY_DATETIME", "UPDATE_USER_ID", "UPDATE_DATETIME", "SUB_MODULE_ID", "BUDGET_SOURCE_ID") FROM stdin;
    public          postgres    false    204   �\                0    33941    ACC_BGT_RVSN 
   TABLE DATA           �   COPY public."ACC_BGT_RVSN" ("ID", "BGT_ALCTN_ID", "RVSN_DATE_NP", "AMOUNT", "RVSN_REASON", "UPDATE_USER_ID", "UPDATE_DATETIME") FROM stdin;
    public          postgres    false    373   �\      ?          0    34359    ACC_BGT_TRANSFER 
   TABLE DATA           �   COPY public."ACC_BGT_TRANSFER" ("ID", "FROM_ACC_ID", "TO_ACC_ID", "BGT_ALCTN_ID", "TRNSFR_DATE_NP", "TRNSFR_REASON", "UPDATE_USER_ID", "UPDATE_DATETIME", "AMOUNT") FROM stdin;
    public          postgres    false    408   �\      -          0    34144    ACC_BUDJET_SOURCE 
   TABLE DATA           c   COPY public."ACC_BUDJET_SOURCE" ("ID", "MIN_ACC_ID", "SOURCE_ID", "AMOUNT", "REMARKS") FROM stdin;
    public          postgres    false    390   ]      h          0    35071    ACC_CASH_TRANS 
   TABLE DATA           �   COPY public."ACC_CASH_TRANS" ("CASH_TRANS_ID", "VCHR_ID", "VCHR_DATE_NEP", "DESCRIPTION", "DR_AMT", "CR_AMT", "IS_OF_LASTYEAR", "INCOME_EXP_TYPE_ID", "BILL_ID") FROM stdin;
    public          postgres    false    449   )]      t          0    33027    ACC_CHEQUE_TYPES 
   TABLE DATA           M   COPY public."ACC_CHEQUE_TYPES" ("CHEQUE_TYPE_ID", "CHEQUE_TYPE") FROM stdin;
    public          postgres    false    205   F]      u          0    33032    ACC_CURRENCTY 
   TABLE DATA           P   COPY public."ACC_CURRENCTY" ("ID", "NP_NAME", "ENG_NAME", "SYMBOL") FROM stdin;
    public          postgres    false    206   c]                0    33951    ACC_CURRENCTY_RATE 
   TABLE DATA           V   COPY public."ACC_CURRENCTY_RATE" ("ID", "CURRENCY_ID", "NP_DATE", "RATE") FROM stdin;
    public          postgres    false    374   �]      J          0    34509    ACC_DHRTI_BILL_DTL 
   TABLE DATA           �   COPY public."ACC_DHRTI_BILL_DTL" ("DHRTI_DTL_ID", "DHRTI_MASTER_ID", "BILL_NO", "BILL_DATE_NP", "COUNTER_ID", "PERSON_ID", "AMOUNT", "VCHR_ID", "ACC_ID", "VCHR_DATE_NP", "ORDER_IN_BILL", "REMARKS", "BUDGET_SOURCE_ID", "WORK_ID") FROM stdin;
    public          postgres    false    419   �]      K          0    34529    ACC_DHRTI_BILL_MASTER 
   TABLE DATA           �  COPY public."ACC_DHRTI_BILL_MASTER" ("DHRTI_MASTER_ID", "BILL_NO", "DESCRIPTION", "COUNTER_ID", "PERSON_ID", "BLL_DATE_NP", "CASH_AMT", "BANK_AMT", "VCHR_ID", "VCHR_DATE_NP", "USERID", "USERIDE", "DATE_ENTRY_VS_DATE", "DATE_ENTRY_TIME", "DATE_EDIT_TIME", "NAME", "ADDRESS", "WARD_NO", "CANCEL_DATE", "CANCEL_REASON", "BILL_NO_MANUAL", "FISCAL_YEAR", "BILLTYPEID", "SUB_MODULE_ID", "WORK_ID") FROM stdin;
    public          postgres    false    420   �]      @          0    34379    ACC_EXPENSES_DETAILS 
   TABLE DATA           7  COPY public."ACC_EXPENSES_DETAILS" ("EXPENSE_ID", "TRANS_TYPE_ID", "PERSON_TYPE_ID", "EMP_ID", "PADADHIKARI_ID", "ORG_ID", "UC_ID", "WARD_ID", "WORK_ID", "ACC_ID", "DR_AMT", "CR_AMT", "VAT_AMT", "PAYMENT_SLIP_ID", "VCHR_ID", "VCHR_DATE_NP", "ORDER_IN_PAYMENT_SLIP", "ADVEXPTYPE", "IS_OF_LAST_YEAR") FROM stdin;
    public          postgres    false    409   �]      v          0    33040    ACC_FUND_PROVIDR_MSTR 
   TABLE DATA           �   COPY public."ACC_FUND_PROVIDR_MSTR" ("PROVIDER_ID", "NAME_NP", "NAME_EN", "PHONES", "EMAILS", "CHAIRMAN", "CONTACT_PERSON") FROM stdin;
    public          postgres    false    207   �]      w          0    33045    ACC_INCOME_RATE 
   TABLE DATA           W   COPY public."ACC_INCOME_RATE" ("RATE_ID", "ACC_ID", "RATE", "FISCAL_YEAR") FROM stdin;
    public          postgres    false    208   ^      y          0    33055    ACC_LASTYEAR_ADV_DETAILS 
   TABLE DATA           +  COPY public."ACC_LASTYEAR_ADV_DETAILS" ("ID", "PAYMENT_ID", "FISCAL_YEAR", "WORK_ID", "VHCR_ID", "ACC_ID", "BUDGET_ACC_ID", "BUDGET_SOURCE_ID", "PAYMENT_TYPE_ID", "PERSON_ID", "DR_AMOUNT", "STATUS", "REMARKS", "ADD_USER_ID", "ADD_DATE", "VOUCHER_NO", "VOUCHER_DATE", "LAST_YR_PESKI_ID") FROM stdin;
    public          postgres    false    210   .^      x          0    33050    ACC_LAST_YR_PESKI 
   TABLE DATA           �   COPY public."ACC_LAST_YR_PESKI" ("SN", "PERSON_TYPE_ID", "PERSON_ID", "ADVANCE_TYPE", "SUB_MODULE_ID", "TOTAL_PES_REM") FROM stdin;
    public          postgres    false    209   K^      z          0    33060    ACC_ORG_MASTER 
   TABLE DATA             COPY public."ACC_ORG_MASTER" ("ORG_ID", "NAME_NP", "NAME_EN", "ADDRESS", "PHONES", "EMAILS", "REG_NO", "VAT_NO", "PAN_NO", "ZONE", "DISTRICT", "VDC", "MINISTRY", "CODE", "HEAD", "MOBILE_NO", "RELATED_PERSON", "ORG_MASTER_ID", "SAPATI", "ORC_ACC_TYPE_ID") FROM stdin;
    public          postgres    false    211   h^                0    33974    ACC_PADADHIKARI_MSTR 
   TABLE DATA           6  COPY public."ACC_PADADHIKARI_MSTR" ("PADADIKARI_ID", "NAME_NP", "NAME_EN", "POST_ID", "ADDRESS", "WARD_NO", "ELECTED_DATE_NP", "QUALIFICATION", "MOBILE_NO", "LAST_NAME_NP", "LAST_NAME_EN", "TITLE", "GENDER", "RELIGION_ID", "MOTHER_LANG_ID", "DATE_OF_BIRTH", "PARENT_NAME", "P_OCUPATION", "SPOUSE_NAME", "S_OCUPATION", "GRANDFATHER_NAME", "GF_OCUPATION", "MARRIED_STATUS", "NO_OF_SON", "NO_OF_DAUGHTER", "FIRST_APPOINT_DATE", "FIRST_APPOINT_POST_ID", "CURRENT_POST_APPOINT_DATE", "RETIRE_DATE", "PRE_EXPERIENCE", "ZONE_ID", "DISTRICT_ID", "VDC_ID", "TRACK_ID", "STREET", "PHONES", "EMAILS", "MOBILE", "CITIZENSHIP_NO", "CITZN_ISSUED_DATE", "CITZN_ISSUED_DISTR_ID", "IS_TOILET_IN_HOME", "SPECIAL_NOTES", "USER_ID", "USER_IDE", "DATA_ENTRY_VS_DATE", "DATA_ENTRY_AD_DATE", "DATA_EDIT_AD_DATE", "DATE_OF_BIRTH_AD") FROM stdin;
    public          postgres    false    376   �^      {          0    33068    ACC_PADADHIKARI_POST 
   TABLE DATA           r   COPY public."ACC_PADADHIKARI_POST" ("POST_ID", "NAME_NP", "NAME_EN", "DURATION_IN_YRS", "POST_LEVEL") FROM stdin;
    public          postgres    false    212   �^      A          0    34409    ACC_PAYMENT_CLEARANCE 
   TABLE DATA           �   COPY public."ACC_PAYMENT_CLEARANCE" ("ID", "PAYMENT_ID", "IS_OF_LAST_YEAR", "ACC_ID", "BUDGET_ACC_ID", "AMOUNT", "BUDGET_SOURCE_ID") FROM stdin;
    public          postgres    false    410   �^      |          0    33073    ACC_PAYMENT_CREDIT 
   TABLE DATA           �   COPY public."ACC_PAYMENT_CREDIT" ("ID", "PAYMENT_ID", "IS_OF_LAST_YEAR", "ACC_ID", "BUDGET_ACC_ID", "BUDGET_SOURCE_ID", "AMOUNT") FROM stdin;
    public          postgres    false    213   �^      e          0    34987    ACC_PAYMENT_DEDUCTION 
   TABLE DATA           �   COPY public."ACC_PAYMENT_DEDUCTION" ("ID", "PAYMENT_ID", "ACC_ID", "BUDGET_ACC_ID", "AMOUNT", "STATUS", "DEDUCTIONTYPE", "BUDGET_SOURCE_ID") FROM stdin;
    public          postgres    false    446   �^      f          0    35007    ACC_PAYMENT_DETAILS 
   TABLE DATA           �  COPY public."ACC_PAYMENT_DETAILS" ("PAYMENT_DETAIL_ID", "PAYMENT_ID", "TRANS_TYPE_ID", "PERSON_TYPE_ID", "EMP_ID", "PADADHIKARI_ID", "ORG_ID", "UC_ID", "WARD_ID", "WORK_ID", "ACC_ID", "BUDGET_ACC_ID", "DR_AMT", "CR_AMT", "VAT_AMT", "PAYMENT_SLIP_ID", "VCHR_ID", "VCHR_DATE_NP", "ORDER_IN_PAYMENT_SLIP", "ADVEXPTYPE", "IS_OF_LAST_YEAR", "FISCAL_YEAR", "BUDGET_SOURCE_ID", "SUB_MODULE_ID", "ADVANCE_TYPE", "EXPIRE_DATE_NP", "SUPPLIER_ID") FROM stdin;
    public          postgres    false    447   _      L          0    34557    ACC_PAYMENT_MASTER 
   TABLE DATA           �  COPY public."ACC_PAYMENT_MASTER" ("PAYMENT_ID", "TRANS_TYPE_ID", "PERSON_TYPE_ID", "PERSON_ID", "WORK_ID", "BILL_NO", "BILL_AMT", "VAT_AMT", "PAYMENT_DESCRIPTION", "RETENTION_MONEY_EDUCTION", "CONTRACT_TAX_DEDUCTION", "INCOME_TAX_DEDUCTION", "LAST_YEARS_ADV_DEDUCTION", "VAT_DEDUCTION", "OTHER_DEDUCTION", "CHEQUE_PAYMENT", "CASH_PAYMENT", "ADV_CLEARED_FROM_BILL", "ADV_CLEARED_FROM_BANK", "ADV_CLEARED_FROM_CASH", "LY_ADV_CLEARED_FROM_BILL", "LY_ADV_CLEARED_FROM_BANK", "LY_ADV_CLEARED_FROM_CASH", "ADVEXPTYPE", "VCHR_ID", "VCHR_DATE_NP", "FISCAL_YEAR", "SUB_MODULE_ID", "ISPESKI", "DEDUCT_DEP_VCHR_ID", "DEDUCT_DEP_VCHR_DATE_NEP", "ACC_DEDUCT_DEP_VCHR_ID", "ACC_DEDUCT_DEP_VCHR_DATE", "EXPIRE_DATE_NP", "CR_AMOUNT", "SUBJECT_AREA_ID") FROM stdin;
    public          postgres    false    421   3_      }          0    33076    ACC_RECEIVABLE 
   TABLE DATA           �   COPY public."ACC_RECEIVABLE" ("SN", "TAXPAYERID", "FISCALYEAR", "NETTAXAMOUNT", "FINEAMOUNT", "ADDITIONALCHARGES", "REDUCTIONALCHARGES", "TAXTYPE", "TYPE", "VCHRID", "VCHR_DATE") FROM stdin;
    public          postgres    false    214   P_      ~          0    33079    ACC_SUB_MODULE_TYPE 
   TABLE DATA           �   COPY public."ACC_SUB_MODULE_TYPE" ("SUB_MODULE_ID", "NAME_NP", "NAME_EN", "MODULE", "CODE", "ISCAPITAL", "BUDGET_ACC_NO", "ISEXPENCES", "ACC_EXPENCES_CODE") FROM stdin;
    public          postgres    false    215   m_                0    33084    ACC_TRANS_TYPE 
   TABLE DATA           d   COPY public."ACC_TRANS_TYPE" ("TYPE_ID", "TYPE_CODE", "NEP_NAME", "ENG_NAME", "MODULE") FROM stdin;
    public          postgres    false    216   �_      �          0    33089    ACC_UNAUTHORISED 
   TABLE DATA           �   COPY public."ACC_UNAUTHORISED" ("UNAUTHORISED_ID", "SUB_MODULE_ID", "WORK_ID", "UNAUTHORISED_DAFA_ID", "UNAUTHORISED_AMT", "INSPECT_DATE", "INSPECT_DETAILS", "INSPECT_AMT", "FILLEDBY_EMPID", "VERIFIEDBY_EMPID") FROM stdin;
    public          postgres    false    217   �_      �          0    33094    ACC_USER_COMITE_MSTR 
   TABLE DATA           �   COPY public."ACC_USER_COMITE_MSTR" ("ID", "NEP_NAME", "ENG_NAME", "WARD", "ADDRESS", "EMAIL", "PHONES", "CHAIRMAN", "CONCERN_PERSON", "MOBILE_NO") FROM stdin;
    public          postgres    false    218   �_      M          0    34587    ACC_VCHR_DETAILS 
   TABLE DATA           q  COPY public."ACC_VCHR_DETAILS" ("VCHR_DETAIL_ID", "VCHR_ID", "ACC_ID", "DR_AMT", "CR_AMT", "VCHR_TYPE_ID", "ID_FROM_SRC", "ACC_TYPE", "TRANS_TYPE_ID", "VCHR_DATE_ENG", "VCHR_DATE_NEP", "REMARKS", "IS_POSTED", "MODULE", "SUB_MODULE_ID", "BUDGET_SOURCE_ID", "BANKID", "BILL_ID", "BUDGET_ACC_ID", "ORG_ID", "WORK_ID", "IS_JAFAT", "EXPIRE_DATE_NP", "IS_GROUP") FROM stdin;
    public          postgres    false    422   �_      !          0    34000    ACC_VCHR_MASTER 
   TABLE DATA           �  COPY public."ACC_VCHR_MASTER" ("VCHR_ID", "VCHR_NO", "VCHR_DATE_NEP", "VCHR_TYPE_ID", "NARRATION", "USER_ID", "UPDATE_DATE", "FISCALYEAR", "MODULE", "IS_POSTED", "SUB_MODULE_ID", "NAME_CHEQUE_PAYEE", "IS_OF_LAST_YEAR", "REMARKS", "CHEQUE_TYPE_ID", "FATHER_NAME", "GRAND_FATHER_NAME", "CONTACT_PHONE", "IS_NIKASH", "WARDNO", "PREP_BY", "CHECK_BY", "ACCEPT_BY", "INTERNAL_LEKHA", "NIYAMIT_AMT", "ASULI_AMT", "VALID_AMT", "N_VALID_AMT") FROM stdin;
    public          postgres    false    378   �_      �          0    33102    ACC_VCHR_TYPE_MASTER 
   TABLE DATA           |   COPY public."ACC_VCHR_TYPE_MASTER" ("VCHR_TYPE_ID", "NEP_NAME", "ENG_NAME", "MODULE", "ISAUTOMATIC", "ISFIXED") FROM stdin;
    public          postgres    false    219   `      #          0    34033    ACC_WORK_FUNDS_DETAIL 
   TABLE DATA           �   COPY public."ACC_WORK_FUNDS_DETAIL" ("FUND_DETAIL_ID", "WORK_ID", "PROVIDER_ID", "FUNDED_AMT", "FUNDED_PERCENT", "ISJANASARAMDHA", "ISOWNOFFICE") FROM stdin;
    public          postgres    false    380   8`      �          0    33107    ACC_WORK_MASTER 
   TABLE DATA           {  COPY public."ACC_WORK_MASTER" ("WORK_ID", "NAME_NP", "NAME_EN", "ESTIMATED_AMT", "VARIATION_AMT", "CORRECTED_AMT", "FINAL_ACTUAL_AMT_TOBE_PAID", "TOTAL_ACTUAL_COST", "AGREEMENT_PARTY", "AGREEMENT_AMT", "AGREEMENT_DATE", "AGREEMENT_EXPIRY_DATE", "WORK_COMPLETE_DATE", "MEASURE_BOOK_NO", "DEPOSIT_AMT", "BANK_GUARANTEE_AMT", "DEPOSIT_RELEASE_DATE", "DEPOSIT_RELEASED_DATE", "WARD_NO", "IS_COMPLETED", "DEADLINE_DATE", "TP_NO", "BANKID", "EMP_ID", "PARTY_PERSONTYPEID", "PARTY_ID", "PERSON_PERSONTYPEID", "PERSON_ID", "DEPOSITS_ACC_ID", "DEPOSITS_FORFEIT_ACC_ID", "IS_KRAMAGAT", "YOJANA_NATUR_ID", "AGREEMENT_SIGNING_PERSON") FROM stdin;
    public          postgres    false    220   U`      N          0    34619    ACC_WORK_PAYMNT_TRANS 
   TABLE DATA           �   COPY public."ACC_WORK_PAYMNT_TRANS" ("TRANS_ID", "WORK_ID", "PAYMENT_SLIP_ID", "PERSON_TYPE_ID", "EMP_ID", "PADADHIKARI_ID", "ORG_ID", "UC_ID", "BILL_AMT", "VAT_AMT", "VCHR_ID", "VCHR_DATE_NP", "IS_OF_LAST_YEAR", "FISCAL_YEAR") FROM stdin;
    public          postgres    false    423   r`      �          0    33120    APPLICATION_CONFIGURATION 
   TABLE DATA           Z   COPY public."APPLICATION_CONFIGURATION" ("SN", "NAME_CONFIG", "VALUE_CONFIG") FROM stdin;
    public          postgres    false    222   �`      %          0    34050    AspNetRoleClaims 
   TABLE DATA           W   COPY public."AspNetRoleClaims" ("Id", "RoleId", "ClaimType", "ClaimValue") FROM stdin;
    public          postgres    false    382   �`      �          0    33125    AspNetRoles 
   TABLE DATA           [   COPY public."AspNetRoles" ("Id", "Name", "NormalizedName", "ConcurrencyStamp") FROM stdin;
    public          postgres    false    223   �`      :          0    34292    AspNetUserClaims 
   TABLE DATA           W   COPY public."AspNetUserClaims" ("Id", "UserId", "ClaimType", "ClaimValue") FROM stdin;
    public          postgres    false    403   �`      ;          0    34305    AspNetUserLogins 
   TABLE DATA           m   COPY public."AspNetUserLogins" ("LoginProvider", "ProviderKey", "ProviderDisplayName", "UserId") FROM stdin;
    public          postgres    false    404   a      <          0    34318    AspNetUserRoles 
   TABLE DATA           ?   COPY public."AspNetUserRoles" ("UserId", "RoleId") FROM stdin;
    public          postgres    false    405    a      =          0    34336    AspNetUserTokens 
   TABLE DATA           X   COPY public."AspNetUserTokens" ("UserId", "LoginProvider", "Name", "Value") FROM stdin;
    public          postgres    false    406   =a      �          0    33133 
   BANKMASTER 
   TABLE DATA           �   COPY public."BANKMASTER" ("BANKID", "ENGNAME", "NEPNAME", "BANKCODE", "SUB_MODULE_ID", "ADDRESS", "PHONES", "EMAILS", "ACCOUNTNUMBER", "BRANCHCODE", "TRANCODE", "CYCODE", "FINANCEL_INSTITUTE_ID", "BRANCH", "BANKNAME") FROM stdin;
    public          postgres    false    224   Za      c          0    34941    BANKTRANSACTIONS 
   TABLE DATA           Z  COPY public."BANKTRANSACTIONS" ("SN", "BANKID", "DESCRIPTION", "DRAMOUNT", "CRAMOUNT", "INCOMEEXPTYPEID", "ISOFLASTYEAR", "VCHR_DATE_NP", "ORDERINPAYMENTSLIP", "VCHR_ID", "BILLID", "MODULE", "SUBMODULE_TYPE_ID", "DHRTI_MASTER_ID", "EXP_SLIP_ID", "PAYMENT_ORDER_NO", "CHEQUE_TYPE_ID", "PAYEENAME", "BUDGET_SOURCE_ID", "PAYEENAME_ENG") FROM stdin;
    public          postgres    false    444   wa      &          0    34063    BANK_BRANCH 
   TABLE DATA           �   COPY public."BANK_BRANCH" ("BRANCH_ID", "BANKID", "NEPNAME", "ENGNAME", "BRANCH_CODE", "ADDRESS", "EMAIL", "PHONE", "IS_PERMITTED") FROM stdin;
    public          postgres    false    383   �a      �          0    33141    BUDJET_SOURCE 
   TABLE DATA           �   COPY public."BUDJET_SOURCE" ("ID", "PARENT_ID", "COUNTRY_ID", "CODE", "EMAIL", "PHONE", "ADDRESS", "NEP_NAME", "ENG_NAME", "REMARKS") FROM stdin;
    public          postgres    false    225   �a      �          0    33149    BUDJET_SUB_HEAD 
   TABLE DATA           �   COPY public."BUDJET_SUB_HEAD" ("ID", "CODE", "MINISTRY_ID", "MINISTRY_CODE", "PARENT_CODE", "FISCAL_YEAR", "NEPNAME", "ENGNAME", "REMARKS") FROM stdin;
    public          postgres    false    226   �a      �          0    33155    BUSINESSMASTER_HISTORY 
   TABLE DATA           �   COPY public."BUSINESSMASTER_HISTORY" ("ID", "BIZ_ID", "NEPNAME", "BUSINESSGROUPID", "TAXPAYERID", "ADD_DATE", "COMPUTER_NAME", "DATA_STATUS", "WINDOWS_USER", "TRAN_TIME") FROM stdin;
    public          postgres    false    227   �a      d          0    34964    CASHTRANSACTION 
   TABLE DATA           �   COPY public."CASHTRANSACTION" ("SN", "DESCRIPTION", "DRAMOUNT", "CRAMOUNT", "INCOMEEXPTYPEID", "ISOFLASTYEAR", "VCHR_DATE_NP", "VCHR_ID", "BILLID", "MODULE", "SUBMODULE_TYPE_ID", "DHRTI_MASTER_ID", "EXP_SLIP_ID", "BUDGET_SOURCE_ID") FROM stdin;
    public          postgres    false    445   b      �          0    33158    CELEDGER20682069 
   TABLE DATA           �  COPY public."CELEDGER20682069" ("SN", "IID", "HOUSEID", "CONSTRUCTIONTYPEID", "CONSTRUCTIONID", "TALANUMBER", "TOTALAREA", "RATEID", "RATEPERUNIT", "CALCULATEDVALUE", "VSDATEOFMADE", "DEPPERCENT", "DEPRECIATIONAMOUNT", "OTHERPLUSINEVALUATIONS", "OTHERMINUSINEVALUATIONS", "OTHERPLUSMINUSDESCRIPTIONS", "NETCALCULATEDVALUE", "NONCOMPLETIONREASONID", "NONCOMPLETIONREASONS", "REMARKS", "SPACEMEASURINGUNIT", "TAXED") FROM stdin;
    public          postgres    false    228   %b      �          0    33161    COLLECTIONCOUNTERS 
   TABLE DATA           �   COPY public."COLLECTIONCOUNTERS" ("COUNTERID", "NEPNAME", "COUNTERHEADID", "WARDNO", "LOCATION", "SPECIALNOTES", "CMPTR_NAME", "MACADDRESS") FROM stdin;
    public          postgres    false    229   Bb      �          0    33166    CONSTANTVALUES 
   TABLE DATA           G   COPY public."CONSTANTVALUES" ("SN", "VARNAME", "STRVALUE") FROM stdin;
    public          postgres    false    230   _b      �          0    33172    CONTACTS 
   TABLE DATA           a   COPY public."CONTACTS" ("ID", "NEPNAME", "ENGNAME", "CODE", "DISTRICTID", "REMARKS") FROM stdin;
    public          postgres    false    231   |b      �          0    33177    COUNTRY 
   TABLE DATA           R   COPY public."COUNTRY" ("ID", "NEPNAME", "ENGNAME", "CODE", "REMARKS") FROM stdin;
    public          postgres    false    232   �b      �          0    33180    DDC 
   TABLE DATA           \   COPY public."DDC" ("ID", "NEPNAME", "ENGNAME", "CODE", "REMARKS", "DISTRICTID") FROM stdin;
    public          postgres    false    233   �b      �          0    33183 
   DEV_REGION 
   TABLE DATA           U   COPY public."DEV_REGION" ("ID", "NEPNAME", "ENGNAME", "CODE", "REMARKS") FROM stdin;
    public          postgres    false    234   �b      �          0    33186    DISTRICT 
   TABLE DATA           e   COPY public."DISTRICT" ("DISTRICTID", "NEPNAME", "ENGNAME", "CODE", "REMARKS", "ZONEID") FROM stdin;
    public          postgres    false    235   �b      �          0    33189    EMP_GRP 
   TABLE DATA           ?   COPY public."EMP_GRP" ("ID", "NEPNAME", "ENGNAME") FROM stdin;
    public          postgres    false    236   c      B          0    34424    FIREBRIGADESTATE 
   TABLE DATA           �   COPY public."FIREBRIGADESTATE" ("ID", "NEPNAME", "SERVICECHARGERATE", "MINIMUMSERVICECHARGE", "ACC_ID", "TYPE", "FISCAL_YEAR", "RATEID") FROM stdin;
    public          postgres    false    411   *c      �          0    33194    FISCALYEARS 
   TABLE DATA           Q   COPY public."FISCALYEARS" ("SN", "FISCALYEAR", "DATEFROM", "DATETO") FROM stdin;
    public          postgres    false    237   Gc      �          0    33197    FYWISERENTDARRATE 
   TABLE DATA           s   COPY public."FYWISERENTDARRATE" ("ID", "RATEID", "RATENAME", "RENT_PER", "RENT_TYPEID", "FISCAL_YEAR") FROM stdin;
    public          postgres    false    238   dc      �          0    33202    FYWISESANITATION_RATE 
   TABLE DATA           �   COPY public."FYWISESANITATION_RATE" ("ID", "RATEID", "GROUPID", "SUBGROUPID", "ROAD_TYPEID", "RATENAME", "RATE", "FISCAL_YEAR", "AREA_UPTO", "FOR_EACH_AREA", "EACH_AREA_RATE") FROM stdin;
    public          postgres    false    239   �c      O          0    34639    INCOMEBILLDETAILS 
   TABLE DATA           "  COPY public."INCOMEBILLDETAILS" ("SN", "BILLID", "BILLNO", "BILLDATE", "COUNTERID", "PERSONID", "ACCODE", "AMOUNT", "VCHR_DATE_NP", "ORDERINBILL", "REMARKS", "VCHR_ID", "ACC_ID", "FISCAL_YEAR", "PROJECT", "TAXADDTNLID", "TAX_TYPE", "QTY", "BUDGET_SOURCE_ID", "BACKUP_PERSONID") FROM stdin;
    public          postgres    false    424   �c      �          0    33208    INCOMEBILLDETAILS_HISTORY 
   TABLE DATA           �  COPY public."INCOMEBILLDETAILS_HISTORY" ("SN", "SN_INCOMEBILLDTL", "BILLID", "BILLNO", "BILLDATE", "COUNTERID", "PERSONID", "ACCODE", "AMOUNT", "VRNO", "VCHR_DATE_NP", "ORDERINBILL", "REMARKS", "VCHR_ID", "ACC_ID", "FISCAL_YEAR", "PROJECT", "TAXADDTNLID", "QTY", "BUDGET_SOURCE_ID", "TAX_TYPE", "BACKUP_PERSONID", "ADD_DATE", "COMPUTER_NAME", "DATA_STATUS", "WINDOWS_USER", "TRAN_TIME") FROM stdin;
    public          postgres    false    240   �c      P          0    34654    INCOMEBILLMASTER 
   TABLE DATA           �  COPY public."INCOMEBILLMASTER" ("SN", "BILLNO", "DESCRIPTION", "COUNTERID", "PERSONID", "BILLDATE", "CASHAMOUNT", "BANKAMOUNT", "VCHR_ID", "VCHR_DATE_NP", "USERID", "USERIDE", "DATAENTRYVSDATE", "DATAENTRYADDATETIME", "DATAEDITADDATETIME", "BILLTYPEID", "TAXINCOMETYPE", "NAME", "ADDRESS", "WARD_NO", "CANCEL_DATE", "CANCEL_REASON", "BILL_NO_MANUAL", "FISCAL_YEAR", "PROJECT", "SUB_MODULE_ID", "CURRENCY_ID", "BACKUP_PERSONID") FROM stdin;
    public          postgres    false    425   �c      �          0    33214    INV_APPLICANT_RATE 
   TABLE DATA           _   COPY public."INV_APPLICANT_RATE" ("ID", "APPLICANTID", "ITEM_DETAIL_ID", "AMOUNT") FROM stdin;
    public          postgres    false    241   �c      �          0    33219 	   INV_BRAND 
   TABLE DATA           T   COPY public."INV_BRAND" ("BRAND_ID", "NAME_NP", "NAME_EN", "IS_ACTIVE") FROM stdin;
    public          postgres    false    242   d      �          0    33224    INV_DEPLIST 
   TABLE DATA             COPY public."INV_DEPLIST" ("ID", "FISCALYEAR", "DAKHILA_ID", "ITEM_ID", "QTY", "PURCHASE_DATE", "PURCHASE_AMT", "BRAND_ID", "SPEC_ID", "UNIT_ID", "DEPRE_DURATON", "DEPRE_PER", "DEPRE_AMT", "MAX_DEPRE_AMT", "MIN_DEPRE_AMT", "DEDUCT_AMT", "NET_AMT") FROM stdin;
    public          postgres    false    243   /d      �          0    33229    INV_DEPRECIATION 
   TABLE DATA           �   COPY public."INV_DEPRECIATION" ("ID", "FISCALYEAR", "DAKHILA_ID", "ITEM_ID", "BRAND_ID", "SPEC_ID", "UNIT_ID", "QTY", "ORGINAL_RATE", "DEPRE_RATE", "DEPRE_PER") FROM stdin;
    public          postgres    false    244   Ld      �          0    33234    INV_DEPT 
   TABLE DATA           _   COPY public."INV_DEPT" ("DEPT_ID", "NAME_NP", "NAME_EN", "OFFICE_ID", "IS_ACTIVE") FROM stdin;
    public          postgres    false    245   id      j          0    35108    INV_GOODS_ADJUST 
   TABLE DATA           ;  COPY public."INV_GOODS_ADJUST" ("ID", "DAKHILA_ID", "GD_ADJ_ID", "BUDGET_YEAR", "MONTH", "ITEM_ID", "ITEM_TYPE", "SPEC_ID", "BRAND_ID", "ADJ_QTY", "ADJ_TYPE_ID", "ITEM_ADJ_RATE", "ADJ_DT_NP", "ADJ_DT_ENG", "REMARKS", "PREP_BY", "PREP_DT_NP", "PREP_DT_ENG", "ACCEPT_BY", "ACCEPT_DT_NP", "ACCEPT_DT_ENG") FROM stdin;
    public          postgres    false    451   �d      �          0    35587    INV_GOODS_REC_DETL 
   TABLE DATA             COPY public."INV_GOODS_REC_DETL" ("ID", "GOODS_MASTER_ID", "ITEM_ID", "UNIT_ID", "BRAND_ID", "SPEC_ID", "PUR_QTY", "RECV_QTY", "RATE", "WHETHER_TAX", "TAX_PER_UNIT_AMT", "DISC_AMT", "OTHER_EXPENCES_AMT", "NET_AMT", "REMARKS", "ISNUMBERED", "DAKHILA_DT_ENG") FROM stdin;
    public          postgres    false    475   �d      k          0    35138    INV_GOODS_REC_MAST 
   TABLE DATA           n  COPY public."INV_GOODS_REC_MAST" ("ID", "DAKHILA_ID", "PUR_MASTER_ID", "REPAIR_ID", "DAKHILA_DT", "WAREHOUSE_ID", "INV_BILL_NO", "INV_DATE", "DETAILS_NEP", "DETAILS_ENG", "PREP_BY", "PREP_DT", "CHECK_BY", "CHECK_DT", "ACCEPT_BY", "ACCEPT_DT", "DAKHILA_DT_ENG", "INV_DATE_ENG", "PREP_DT_ENG", "CHECK_DT_ENG", "ACCEPT_DT_ENG", "FISCAL_YEAR", "PAYMENT_ID") FROM stdin;
    public          postgres    false    452   �d      �          0    33239    INV_INCREASE_DECREASE 
   TABLE DATA           �   COPY public."INV_INCREASE_DECREASE" ("ID", "NUM_ID", "DAKHILA_ID", "ITEM_ID", "BRAND_ID", "SPEC_ID", "UNIT_ID", "PURCHASE_DATE", "STOCK_QTY", "AMOUNT", "SCAP_AMOUNT", "FISCALYEAR") FROM stdin;
    public          postgres    false    246   �d      �          0    33244    INV_ISSUE_DAKHILA 
   TABLE DATA           �   COPY public."INV_ISSUE_DAKHILA" ("ID", "ITEM_ID", "SPEC_ID", "BRAND_ID", "UNIT_ID", "ISSUE_DETAIL_ID", "ISSU_MASTER_ID", "DAKHILA_ID", "ISSUE_NO", "REMARKS") FROM stdin;
    public          postgres    false    247   �d      R          0    34697    INV_ISSUE_DETAIL 
   TABLE DATA           �   COPY public."INV_ISSUE_DETAIL" ("ID", "ISSUE_MAST_ID", "ITEM_ID", "SPEC_ID", "BRAND_ID", "ITEM_TYPE", "ITEM_REQ_NO", "ITEM_ISSUE_NO", "ISSUE_DT", "DELIVERY_STATUS", "REMARKS", "ISSUE_DT_ENG") FROM stdin;
    public          postgres    false    427   e      �          0    35698    INV_ISSUE_MASTER 
   TABLE DATA           I  COPY public."INV_ISSUE_MASTER" ("ID", "ISSUE_NO", "REQUEST_ID", "ISSUE_BY", "ISSUE_RECEIVE", "RECEIVE_EMP_ID", "ISSUE_DT", "REMARKS", "ISSUE_BY_CAT", "HO_NAME", "HO_POST", "PREP_BY", "PREP_DT", "CHECK_BY", "CHECK_DT", "ACCEPT_BY", "ACCEPT_DT", "BUDGET_YEAR", "TYPE", "TRANSFER_DECISION_NO", "TRANSFER_DECISION_DATE") FROM stdin;
    public          postgres    false    478   4e      �          0    33252    INV_ITEM_ADJ_TYPE 
   TABLE DATA           `   COPY public."INV_ITEM_ADJ_TYPE" ("ID", "NAME_NP", "NAME_EN", "ADD_SUB", "ADJ_TYPE") FROM stdin;
    public          postgres    false    248   Qe      �          0    33257    INV_ITEM_CATEGORY 
   TABLE DATA             COPY public."INV_ITEM_CATEGORY" ("ID", "NAME_NP", "NAME_EN", "PARENT_ID", "GRP_LEVEL", "IS_HEADER", "ISEXP", "ISLAST", "CODE", "UNIT", "MINL", "MAXL", "RMINL", "RMAXL", "DEPRECIATION_PER", "DEPRECIATION_MIN", "DEPRECIATION_MAX", "REMARKS", "ITEM_ID") FROM stdin;
    public          postgres    false    249   ne      �          0    35618    INV_ITEM_DETAILS 
   TABLE DATA           �  COPY public."INV_ITEM_DETAILS" ("ITEM_DTL_ID", "ITEM_ID", "BRAND_ID", "SPEC_ID", "QTY", "ITEM_RATE", "ITEM_STATUS", "BUDGET_YEAR", "DAKHILA_ID", "ENTRY_DT", "ISSUE_ID", "ISSUE_DT", "GD_ADJ_ID", "ADJ_TYPE", "LILAM_ID", "LILAM_DT", "STOK_RT_ID", "STOK_RT_DT", "ENGINE_NO", "CHASIS_NO", "MODEL_NO", "REG_NO", "WEIGHT_VEH", "PREP_BY", "PREP_DT", "CHECK_BY", "CHECK_DT", "ACCEPT_BY", "ACCEPT_DT", "UNIT", "REL_UNIT", "REL_QTY") FROM stdin;
    public          postgres    false    476   �e      *          0    34111    INV_ITEM_MST 
   TABLE DATA           �  COPY public."INV_ITEM_MST" ("ITEM_ID", "NAME_NP", "NAME_EN", "UNIT_ID", "ITEM_MAIN_CLASS", "ITEM_TYPE", "ITEM_NATURE", "MAXL", "MINL", "RMAXL", "RMINL", "GUSSAGE", "SIZES", "COUNTRYID", "COMPANYNAME", "SOURCE", "REMARKS", "CODE", "KITTA_NO", "LAND_LOCATION", "CONSTRUCTONTYPE", "DEPRECIATION", "MINRATE", "DEPMAXRATE", "PROPERTYTYPE", "LAND_AREA_INSQ_FEETS", "AREA_INSQ_FEETS", "LAND_UNIT_RATE", "LAND_MARKET_RATE", "LANDID", "ACC_ID", "BUDGET_ACC_ID", "VEHICLE_PARTS_ID") FROM stdin;
    public          postgres    false    387   �e      �          0    33262    INV_ITEM_SPEC 
   TABLE DATA           W   COPY public."INV_ITEM_SPEC" ("SPEC_ID", "NAME_NP", "NAME_EN", "IS_ACTIVE") FROM stdin;
    public          postgres    false    250   �e      l          0    35161    INV_ITEM_STATUSCHECK 
   TABLE DATA             COPY public."INV_ITEM_STATUSCHECK" ("ID", "ITEM_ID", "SPEC_ID", "BRAND_ID", "INSP_ST_DATE", "INSP_ST_DATE_ENG", "INSP_ED_DATE", "INSP_ED_DATE_ENG", "STK_MST_COUNT", "COUNT_YES_NO", "STK_CUR_COUNT", "COUNT_UP_DOWN", "INSPECT_DATE", "INSPECT_DATE_ENG", "UP_DOWN_DETAIL", "REMARKS", "PREP_BY", "PREP_DATE", "PREP_DATE_ENG", "TALLY_BY", "CHECKED_DATE", "CHECK_QTY", "RATE", "CHECKED_DATE_ENG", "ACCEPTED_BY", "ACCEPTED_DATE", "ACCEPTED_DATE_ENG", "FISICAL_YEAR", "IS_ACTIVE", "UP_DOWN_NO", "CHECK_STATUS") FROM stdin;
    public          postgres    false    453   �e      )          0    34101    INV_LILAMAPPDETAILS 
   TABLE DATA           �   COPY public."INV_LILAMAPPDETAILS" ("ID", "LILAMAPPLIID", "DAKHILAID", "NIKASHAID", "ITEMID", "UNITID", "BRANDID", "SPECID", "LILAMQTY", "LILAMTOTALAMT") FROM stdin;
    public          postgres    false    386   �e      �          0    33267    INV_LILAM_APPMASTER 
   TABLE DATA           �   COPY public."INV_LILAM_APPMASTER" ("ID", "APPNO", "PROJID", "APPLYLILAMID", "ORGAPPLICANTNAME", "ORGAPPLICANTPOST", "APPLYDATE", "APPLYENGDATE", "REMARKS") FROM stdin;
    public          postgres    false    251   f      �          0    33272    INV_LILAM_DETAIL 
   TABLE DATA           	  COPY public."INV_LILAM_DETAIL" ("ID", "MINIMUMRATE", "LILAM_ID", "DAKHILAID", "NIKASHAID", "ITEM_ID", "UNIT_ID", "SPEC_ID", "BRAND_ID", "ITEM_TYPE", "ITEM_ISSUE_NO", "TOTAL_IN_STOCK", "DEP_AMT", "ISSUE_DT", "DELIVERY_STATUS", "REMARKS", "ISSUE_DT_ENG") FROM stdin;
    public          postgres    false    252   9f      �          0    33280    INV_LILAM_MAST 
   TABLE DATA           �  COPY public."INV_LILAM_MAST" ("ID", "LILAM_NO", "ISSUE_BY", "LILAMTYPE", "RECEIVE_BY", "RECEIVE_PERSON_NAME", "RECIVE_PERSON_POST", "REMARKS", "PREP_BY", "CHECK_BY", "ISSUE_DT", "ACCEPT_BY", "ACCEPT_DT", "PREP_DT", "CHECK_DT", "ISSUE_DT_ENG", "PREP_DT_ENG", "CHECK_DT_ENG", "FISCAL_YEAR", "ACCEPT_DT_ENG", "PAGENO", "REGISTERNO", "PUBLISH_DATE", "DESCRIPTION", "NEWSPAPER_NAME", "PERNEWS_RATE", "ACCEPT_PERCENT", "BANKID", "VALID_DAYS", "FISCALYEAR_CHUKTA") FROM stdin;
    public          postgres    false    253   Vf      �          0    33288    INV_LILAM_REC_LIST 
   TABLE DATA           g   COPY public."INV_LILAM_REC_LIST" ("ID", "REC_DATE_NP", "APPLICANTID", "EMP_ID", "USER_ID") FROM stdin;
    public          postgres    false    254   sf      �          0    33291    INV_ORG_TYPE 
   TABLE DATA           Q   COPY public."INV_ORG_TYPE" ("ID", "NAME_NP", "NAME_EN", "IS_ACTIVE") FROM stdin;
    public          postgres    false    255   �f      �          0    33296    INV_PROJECT 
   TABLE DATA           X   COPY public."INV_PROJECT" ("PROJECT_ID", "NAME_NP", "NAME_EN", "IS_ACTIVE") FROM stdin;
    public          postgres    false    256   �f      �          0    33301    INV_PUR_MAST_PLAN 
   TABLE DATA           !  COPY public."INV_PUR_MAST_PLAN" ("ID", "NAME_NP", "NAME_EN", "PKG_NO", "APPROX_AMT", "BUDGET1YEAR", "BUDGET2YEAR", "BUDGET3YEAR", "PUR_TYPE", "AGREEMENT_TYPE", "BUDGET_RESOURCE", "WORK_ST_DATE", "WORK_END_DATE", "WORK_ST_DATE_AD", "WORK_END_DATE_AD", "BUDGET_YEAR", "REMARKS") FROM stdin;
    public          postgres    false    257   �f      �          0    35663    INV_PUR_ORDER_DETL 
   TABLE DATA           �   COPY public."INV_PUR_ORDER_DETL" ("ID", "PUR_MST_ID", "ITEM_ID", "UNIT_ID", "SPEC_ID", "BRAND_ID", "ITEM_TYPE", "QTY", "ITEM_RATE", "TOTAL_AMT", "TAX_AMT", "REMARKS", "ISDAKHILA") FROM stdin;
    public          postgres    false    477   �f      m          0    35196    INV_PUR_ORDER_MAST 
   TABLE DATA             COPY public."INV_PUR_ORDER_MAST" ("ID", "PUR_ORDER_NO", "REPAIR_ORDER_NO", "LETTER_ORDER_NO", "CUSTOM_ORDER_NO", "PUR_TYPE", "PUR_ORDER_TYPE", "SUPP_ID", "REQ_ID", "BUDGET_YEAR", "RETURN_ITEM_DT", "RETURN_ITEM_DT_ENG", "PREPARED_BY", "PREPARED_DT", "PREPARED_DT_ENG", "CHECKED_BY", "CHECKED_DT", "CHECKED_DT_ENG", "ACCEPTED_BY", "ACCEPTED_DT", "ACCEPTED_DT_ENG", "PUR_ORDER_DT", "DAKHILA_LAST_ENTRY_DT", "PUR_ORDER_DT_ENG", "ISDAKHILA", "REMARKS", "ACCOUNTID", "PURCHASE_DECISION_NO", "PURCHASE_DECISION_DATE") FROM stdin;
    public          postgres    false    454   g      �          0    33306    INV_PUR_TYPE 
   TABLE DATA           ]   COPY public."INV_PUR_TYPE" ("ID", "NEP_NAME", "NEP_ENG", "REMARKS", "ISDEFAULT") FROM stdin;
    public          postgres    false    258   !g      n          0    35224    INV_REQUISITION_MAST 
   TABLE DATA           �  COPY public."INV_REQUISITION_MAST" ("ID", "REQ_ID", "REQ_DATE_NEP", "REQ_BY", "TYPE_ID", "ITEM_ID", "MAINTAIN_ITEM_ID", "PROJ_ID", "HANDOVER_ID", "HANDOVER_ROOM_ID", "FISCAL_YEAR", "REMARKS", "PREP_BY", "PREP_DT", "CHECK_BY", "CHECK_DT", "ACCEPT_BY", "ACCEPT_DT", "ORGSTAFFNAME", "ORGSTAFFPOST", "REQ_TYPE", "USERID", "VEHICLE_ID", "REASION", "REQ_DATE_ENG", "PREP_DT_ENG", "CHECK_DT_ENG", "ACCEPT_DT_ENG", "PURCHASE_GIVE", "STOCK_GIVE") FROM stdin;
    public          postgres    false    455   >g      �          0    35728    INV_REQ_DETAIL 
   TABLE DATA           �   COPY public."INV_REQ_DETAIL" ("ID", "REQ_MAST_ID", "ITEM_ID", "SPEC_ID", "BRAND_ID", "QTY", "REMARKS", "IS_ACTIVE") FROM stdin;
    public          postgres    false    479   [g      (          0    34091    INV_ROOM_MST 
   TABLE DATA           l   COPY public."INV_ROOM_MST" ("ROOM_ID", "FLOOR_NO", "BLOCK_NO", "DESC_NP", "DESC_EN", "DEPT_ID") FROM stdin;
    public          postgres    false    385   xg      o          0    35262    INV_STATUS_DETAIL 
   TABLE DATA             COPY public."INV_STATUS_DETAIL" ("ID", "CODE", "STATUSDATEAD", "STATUSDATEVS", "FISCAL_YEAR", "TOTALQTY", "ITEM_ID", "BRAND_ID", "SPEC_ID", "ITEM_STATUS_ID", "REMARKS", "PREBY", "PREVSDATE", "CHECKEDBY", "CHECKVSDATE", "ACCEPTBY", "MAIN_ID", "ACCEPTVSDATE") FROM stdin;
    public          postgres    false    456   �g      �          0    33314    INV_SUPPLIER 
   TABLE DATA           �   COPY public."INV_SUPPLIER" ("SUP_ID", "NAME_NP", "NAME_EN", "COMPANY_NAME_NP", "COMPANY_NAME_EN", "REGI_TYPE", "TPIN_PAN_NO", "ADDRESS", "PHONE_NO", "EMAIL", "DATE_VS", "DATE_AD", "ORG_TYPE", "ORG_ID", "IS_SELECTED", "REG_NO", "SUP_TYPE") FROM stdin;
    public          postgres    false    260   �g      �          0    33322    INV_SUPPLIER_FISCALYEAR 
   TABLE DATA           R   COPY public."INV_SUPPLIER_FISCALYEAR" ("ID", "SUP_ID", "FISCAL_YEAR") FROM stdin;
    public          postgres    false    261   �g      �          0    33309    INV_SUP_ITM_DET 
   TABLE DATA           n   COPY public."INV_SUP_ITM_DET" ("ID", "ITEM_ID", "SUP_ID", "QTY", "RATE", "ACC_ID", "FISCAL_YEAR") FROM stdin;
    public          postgres    false    259   �g      �          0    33327    INV_TAX_RATE 
   TABLE DATA           Y   COPY public."INV_TAX_RATE" ("TAX_RATE_ID", "NAME_NP", "NAME_EN", "TAX_RATE") FROM stdin;
    public          postgres    false    262   	h      �          0    33332    INV_TYPE_SETUP 
   TABLE DATA           ^   COPY public."INV_TYPE_SETUP" ("ID", "DESC_NP", "DESC_EN", "TYPE_ID", "IS_ACTIVE") FROM stdin;
    public          postgres    false    263   &h      �          0    33337    INV_UNIT 
   TABLE DATA           }   COPY public."INV_UNIT" ("UNIT_ID", "DESC_NP", "DESC_EN", "MUL_FACTOR", "RELATED_TO", "NO_OF_UNITS", "IS_ACTIVE") FROM stdin;
    public          postgres    false    264   Ch      �          0    33342    INV_WAREHOUSE 
   TABLE DATA           \   COPY public."INV_WAREHOUSE" ("WAREHOUSE_ID", "NAME_NP", "NAME_EN", "IS_ACTIVE") FROM stdin;
    public          postgres    false    265   `h      �          0    33347    INV_YRLY_PUR_PLAN 
   TABLE DATA           �  COPY public."INV_YRLY_PUR_PLAN" ("ID", "NAME_NP", "NAME_EN", "APPROX_AMT", "PUR_TYPE", "AGREEMENT_TYPE", "APRX_AMT_ACPT_DATE", "INFO_PUBLISH_DATE", "TENDR_SALE_DATE", "FORM_ENTRY_DATE", "TENDR_OPEN_DATE", "TENDR_ACCEPT_DATE", "WRK_ORDER_DATE", "WRK_ACMPLSH_DATE", "ANLYSIS_DSGN_DT_AD", "APRX_AMT_ACPT_DT_AD", "TENDR_ACCEPT_DT_AD", "TENDR_CALL_DT_AD", "TENDR_OPEN_DT_AD", "AGREEMENT_DT_AD", "WRK_2_FIN_DT_AD", "WRK_ACMPLSH_DT_AD", "REMARKS") FROM stdin;
    public          postgres    false    266   }h      �          0    33352    IPTTAXSUMMARY_HISTORY 
   TABLE DATA           L  COPY public."IPTTAXSUMMARY_HISTORY" ("SN", "IID", "FISCALYEAR", "NETTAXAMOUNT", "FINEAMOUNT", "ADDITIONALCHARGES", "REDUCTIONALCHARGES", "ISTHISFROMREVENUEACCOUNT", "TAXPAIDAMOUNT", "DATEPAID", "SPECIALNOTES", "USERID", "USERIDE", "DATAENTRYVSDATE", "DATAENTRYADDATETIME", "DATAEDITADDATETIME", "BILLID", "BILLNO", "LAST_TAX_PAID_AMOUNT", "TAX_TYPE", "REM_IPT_PAID_AMOUNT", "REM_HL_PAID_AMOUNT", "REM_IPT_FINE_AMOUNT", "REM_HL_FINE_AMOUNT", "REM_HL_FINE_STATUS", "REM_IPT_FINE_STATUS", "YEAR", "MONTH", "ADD_DATE", "COMPUTER_NAME", "DATA_STATUS", "WINDOWS_USER", "TRAN_TIME") FROM stdin;
    public          postgres    false    267   �h      �          0    33358    ISSUEDBILLS 
   TABLE DATA           �   COPY public."ISSUEDBILLS" ("SN", "DATEISSUED", "THELINO", "BILLNOFROM", "BILLNOTO", "COUNTERID", "USERID", "SPECIALNOTES") FROM stdin;
    public          postgres    false    268   �h      �          0    33361    LANDMEASURINGUNITS 
   TABLE DATA           S   COPY public."LANDMEASURINGUNITS" ("UNITID", "UNITNAME", "SQFTPERUNIT") FROM stdin;
    public          postgres    false    269   �h      �          0    33364    LANDSMULTIEVALUATIONDETAIL 
   TABLE DATA           {   COPY public."LANDSMULTIEVALUATIONDETAIL" ("SN", "IID", "LANDID", "KITTANUMBER", "GENERALRATEID", "AREAINSQFT") FROM stdin;
    public          postgres    false    270   �h      �          0    33367    LELEDGER20682069 
   TABLE DATA           �  COPY public."LELEDGER20682069" ("SN", "IID", "LANDID", "WARDNO", "TRACKID", "KITTANUMBER", "TOTALAREA", "NONEVALUATEDAREA", "NETEVALUATINGAREA", "RATEID", "RATEPERUNIT", "CALCULATEDVALUE", "OTHERPLUSINEVALUATIONS", "OTHERMINUSINEVALUATIONS", "OTHERPLUSMINUSDESCRIPTIONS", "NETCALCULATEDVALUE", "SELFDECLAREDVALUE", "APPLIEDVALUE", "NONCOMPLETIONREASONID", "NONCOMPLETIONREASONS", "REMARKS", "LANDMEASURINGUNIT", "TAXED") FROM stdin;
    public          postgres    false    271   i      �          0    33370    MALPOT_LANDS 
   TABLE DATA             COPY public."MALPOT_LANDS" ("ID", "IID", "EID", "NP_FIRSTNAME", "NP_LASTNAME", "OLDVDCID", "OLDWORDNO", "MOTHNUMBER", "KITTANUMBER", "VDCID", "WORDNO", "AREAINSQFT", "NONFUNCTIONALAREAINSQFT", "ADD_USERID", "EDIT_USERID", "ADD_DATE", "EDIT_DATE", "IS_IPT") FROM stdin;
    public          postgres    false    272   +i      +          0    34124    MAP_AREA_GND_COV 
   TABLE DATA           _   COPY public."MAP_AREA_GND_COV" ("ID", "REGIONID", "GROUND_COV", "AREA", "REMARKS") FROM stdin;
    public          postgres    false    388   Hi      �          0    33378    MAP_CONSTRCTION_KIND 
   TABLE DATA           [   COPY public."MAP_CONSTRCTION_KIND" ("ID", "NAME_NP", "NAME_EN", "DESCRIPTION") FROM stdin;
    public          postgres    false    273   ei      �          0    33383    MAP_DESIGNER_DTL 
   TABLE DATA           �   COPY public."MAP_DESIGNER_DTL" ("ID", "REG_NO", "ENGCOUNCILREG_NO", "FIRM_NAME", "DESIGNER_NAME", "ADDRESS", "PHONE_NO", "CLASS", "STATUS_ID", "REMARKS") FROM stdin;
    public          postgres    false    274   �i      �          0    33391    MAP_DIRECTION 
   TABLE DATA           T   COPY public."MAP_DIRECTION" ("ID", "NAME_NP", "NAME_EN", "DESCRIPTION") FROM stdin;
    public          postgres    false    275   �i      �          0    33396    MAP_DRAIN_TYPE 
   TABLE DATA           U   COPY public."MAP_DRAIN_TYPE" ("ID", "NAME_NP", "NAME_EN", "DESCRIPTION") FROM stdin;
    public          postgres    false    276   �i      �          0    33401 	   MAP_FLOOR 
   TABLE DATA           P   COPY public."MAP_FLOOR" ("ID", "NAME_NP", "NAME_EN", "DESCRIPTION") FROM stdin;
    public          postgres    false    277   �i      �          0    33406    MAP_HOUSEUSE_TYPE 
   TABLE DATA           X   COPY public."MAP_HOUSEUSE_TYPE" ("ID", "NAME_NP", "NAME_EN", "DESCRIPTION") FROM stdin;
    public          postgres    false    278   �i      �          0    33411    MAP_HTSTANDARD 
   TABLE DATA           O   COPY public."MAP_HTSTANDARD" ("SN", "KV", "DISTANCEFT", "REMARKS") FROM stdin;
    public          postgres    false    279   j      C          0    34434    MAP_INCOME_TYPE 
   TABLE DATA           `   COPY public."MAP_INCOME_TYPE" ("ID", "NAME_NP", "NAME_EN", "ACC_ID", "DESCRIPTION") FROM stdin;
    public          postgres    false    412   0j      �          0    33416    MAP_LAND_OWNER_TYPE 
   TABLE DATA           Z   COPY public."MAP_LAND_OWNER_TYPE" ("ID", "NAME_NP", "NAME_EN", "DESCRIPTION") FROM stdin;
    public          postgres    false    280   Mj      �          0    33421    MAP_NEIGHBOUR_TYPE 
   TABLE DATA           Y   COPY public."MAP_NEIGHBOUR_TYPE" ("ID", "NAME_NP", "NAME_EN", "DESCRIPTION") FROM stdin;
    public          postgres    false    281   jj      �          0    33426    MAP_RATE 
   TABLE DATA           x   COPY public."MAP_RATE" ("ID", "DESCRIPTION", "RATE_PERMIT", "DEPOSITE_RATE_PERMIT", "USERID", "ENTRY_DATE") FROM stdin;
    public          postgres    false    282   �j      ,          0    34134    MAP_REGION_FAR 
   TABLE DATA           u   COPY public."MAP_REGION_FAR" ("ID", "REGIONID", "AREA_FROM", "AREA_TO", "FISCAL_YEAR", "FAR", "REMARKS") FROM stdin;
    public          postgres    false    389   �j      �          0    33431    MAP_ROOF_CNSTRCT_TYPE 
   TABLE DATA           \   COPY public."MAP_ROOF_CNSTRCT_TYPE" ("ID", "NAME_NP", "NAME_EN", "DESCRIPTION") FROM stdin;
    public          postgres    false    283   �j      �          0    33436    MAP_ROOF_TYPE 
   TABLE DATA           T   COPY public."MAP_ROOF_TYPE" ("ID", "NAME_NP", "NAME_EN", "DESCRIPTION") FROM stdin;
    public          postgres    false    284   �j      �          0    33441    MAP_SITE 
   TABLE DATA           i   COPY public."MAP_SITE" ("SN", "PERMITID", "LANDSHAPE", "SIDE_A", "SIDE_B", "SIDE_C", "AREA") FROM stdin;
    public          postgres    false    285   �j      �          0    33446    MAP_STDHEIGHT_RW 
   TABLE DATA           j   COPY public."MAP_STDHEIGHT_RW" ("ID", "ROAD_WIDTH", "HOUSE_HEIGHT", "FISCAL_YEAR", "REMARKS") FROM stdin;
    public          postgres    false    286   k      �          0    33451    MAP_STOREYS 
   TABLE DATA           R   COPY public."MAP_STOREYS" ("ID", "NAME_NP", "NAME_EN", "DESCRIPTION") FROM stdin;
    public          postgres    false    287   5k      �          0    33456    MAP_STRUCTURE_TYPE 
   TABLE DATA           Y   COPY public."MAP_STRUCTURE_TYPE" ("ID", "NAME_NP", "NAME_EN", "DESCRIPTION") FROM stdin;
    public          postgres    false    288   Rk      �          0    33461    MAP_ZONE 
   TABLE DATA           O   COPY public."MAP_ZONE" ("ID", "NAME_NP", "NAME_EN", "DESCRIPTION") FROM stdin;
    public          postgres    false    289   ok      �          0    33466    MINISTRY 
   TABLE DATA           �   COPY public."MINISTRY" ("ID", "CODE", "ZONE", "DISTRICT", "VDC", "PHONE", "ADDRESS", "NEPNAME", "ENGNAME", "REMARKS") FROM stdin;
    public          postgres    false    290   �k      �          0    33472    MINISTRY_ACC_HEAD 
   TABLE DATA           u   COPY public."MINISTRY_ACC_HEAD" ("ID", "MINISTRY_ID", "ACC_ID", "SUB_HEAD_ID", "FISCAL_YEAR", "REMARKS") FROM stdin;
    public          postgres    false    291   �k      �          0    33477    NATIONALITIES 
   TABLE DATA           g   COPY public."NATIONALITIES" ("NATIONALITYID", "CODE", "NEPNAME", "ENGNAME", "DESCRIPTION") FROM stdin;
    public          postgres    false    292   �k      �          0    33480    NEW_PROPERTY_TAXTABLE 
   TABLE DATA           �   COPY public."NEW_PROPERTY_TAXTABLE" ("SN", "RATESN", "FROMPROPERTYVALUE", "TOPROPERTYVALUE", "FROMTAXAMOUNT", "TOTAXAMOUNT", "REMARKS", "FISCALYEAR", "TAX_PERCENT") FROM stdin;
    public          postgres    false    293   �k      �          0    33485    OFFICE_TYPE 
   TABLE DATA           H   COPY public."OFFICE_TYPE" ("OFFICE_TYPE_ID", "OFFICE_TYPE") FROM stdin;
    public          postgres    false    294    l      1          0    34202    ORGANIZATION_TREE 
   TABLE DATA           �   COPY public."ORGANIZATION_TREE" ("ID", "PARENT_ID", "NEP_NAME", "ENG_NAME", "CONTAINS_DARBANDI", "GEO_REGION", "GRP_LEVEL") FROM stdin;
    public          postgres    false    394   l      Q          0    34677    ORG_BANK_ACCOUNT 
   TABLE DATA              COPY public."ORG_BANK_ACCOUNT" ("ID", "ORG_ID", "BANKID", "BRANCH_ID", "BANK_ACCNT_TYPE_ID", "ACC_NO", "ACC_NAME") FROM stdin;
    public          postgres    false    426   :l      �          0    33490    PAYMENT_SLIP_MASTER 
   TABLE DATA             COPY public."PAYMENT_SLIP_MASTER" ("PAYMENT_SLIP_ID", "PAYMENT_DESCRIPTION", "TRANSACTION_TYPEID", "PERSON_TYPE_ID", "PERSON_ID", "WORK_ID", "BILL_AMT", "VAT_AMT", "RETENTION_MONEY_EDUCTION", "CONTRACT_TAX_DEDUCTION", "INCOME_TAX_DEDUCTION", "LAST_YEARS_ADV_DEDUCTION", "VAT_DEDUCTION", "OTHER_DEDUCTION", "CHEQUE_PAYMENT", "CASH_PAYMENT", "ADV_CLEARED_FROM_BILL", "ADV_CLEARED_FROM_BANK", "ADV_CLEARED_FROM_CASH", "LY_ADV_CLEARED_FROM_BILL", "LY_ADV_CLEARED_FROM_BANK", "LY_ADV_CLEARED_FROM_CASH", "IS_PESKI", "VR_NO", "VR_DATE") FROM stdin;
    public          postgres    false    295   Wl      �          0    33495    PERSON_TYPE_MASTER 
   TABLE DATA           a   COPY public."PERSON_TYPE_MASTER" ("PERSON_TYPE_ID", "NAME_NP", "NAME_EN", "ISFIXED") FROM stdin;
    public          postgres    false    296   tl      �          0    33503    PIS_APPOINTMENT_TYPE 
   TABLE DATA           [   COPY public."PIS_APPOINTMENT_TYPE" ("ID", "NAME_NP", "NAME_EN", "DESCRIPTION") FROM stdin;
    public          postgres    false    297   �l      �          0    33508    PIS_ATTRIBUTES 
   TABLE DATA           W   COPY public."PIS_ATTRIBUTES" ("ID", "NAME_NEP", "DESCRIPTION", "APPLY_TO") FROM stdin;
    public          postgres    false    298   �l      S          0    34722 
   PIS_AWARDS 
   TABLE DATA           �   COPY public."PIS_AWARDS" ("SN", "EMP_ID", "LOCAL_POST_ID", "NEP_NAME", "LEVEL_DESC", "DESCRIPTION", "WORKING_OFFICE", "RVCD_DATE_VS", "RCVD_DATE_AD", "REMARKS", "APPLY_TO") FROM stdin;
    public          postgres    false    428   �l      p          0    35282    PIS_BANK_PAYROLL 
   TABLE DATA           c   COPY public."PIS_BANK_PAYROLL" ("SN", "EMP_ID", "BANK_ID", "BANK_FOLIO", "ACCOUNT_NO") FROM stdin;
    public          postgres    false    457   �l      T          0    34732    PIS_DARBANDI 
   TABLE DATA           �   COPY public."PIS_DARBANDI" ("DARBANDI_ID", "OFFICE_ID", "POST_ID", "POST_LEVEL", "LOCAL_POST_ID", "SEWA_SAMUHA_UPASAMUHA", "NO_OF_POST") FROM stdin;
    public          postgres    false    429   m      �          0    35542    PIS_DELETD_FRM_FULFILD_DARB 
   TABLE DATA           �   COPY public."PIS_DELETD_FRM_FULFILD_DARB" ("SN", "EMP_ID", "FRM_SN_IN_FD", "FRM_OFFICE_ID", "FRM_DARBANDI_ID", "FRM_DATE_FULFILLED", "FRM_APPOINTMNT_TYPE", "TO_SN_IN_FD") FROM stdin;
    public          postgres    false    473   "m      /          0    34172    PIS_EDUCATION 
   TABLE DATA           �   COPY public."PIS_EDUCATION" ("SN", "EMP_ID", "EDU_NAME", "EDU_LEVEL_ID", "INSTITUTE", "BOARD_ID", "MARKS_PERCNT", "MARKS_GRADE", "DIVISION", "COMPLETION_YR_VS", "COMPLETION_YR_AD", "SUBJECTS", "VALID_FOR_EVAL", "APPLY_TO") FROM stdin;
    public          postgres    false    392   ?m      �          0    33513    PIS_EDU_BOARD 
   TABLE DATA           ^   COPY public."PIS_EDU_BOARD" ("ID", "NAME_NEP", "NAME_ENG", "COUNTRY_ID", "PLACE") FROM stdin;
    public          postgres    false    299   \m      �          0    33518    PIS_EDU_LEVEL 
   TABLE DATA           ?   COPY public."PIS_EDU_LEVEL" ("EDU_ID", "EDU_NAME") FROM stdin;
    public          postgres    false    300   ym      U          0    34752    PIS_EMPLOYEE_MASTER 
   TABLE DATA           �  COPY public."PIS_EMPLOYEE_MASTER" ("EMP_ID", "FIRST_NAME_NP", "LAST_NAME_NP", "FIRST_NAME_EN", "LAST_NAME_EN", "POST_ID", "SERVICE_GROUP", "TITLE", "GENDER", "FATHER_NAME", "HUSBAND_NAME", "WILL_PERSON", "ADDRESS", "DATE_OF_BIRTH", "FIRST_APPOINT_DATE", "FIRST_APPOINT_POST_ID", "CURRENT_POST_APPOINT_DATE", "SERVICE_STATUS", "POST_STATUS", "GRADES", "CIT_PERCENT", "PAYMODE", "GOVT_EMP_ID", "PF_ID", "CIT_ID", "POST_LEVEL", "RETIRE_DATE", "LOCAL_POST_ID", "PHONES", "EMAILS", "PAYEMENT_BANK_ID", "MARRIED_STATUS", "INSURANCE_NO", "MOBILE_NO", "RELIGION", "PARENT_OCUPATION", "SPOUSE_OCUPATION", "GF_NAME", "GF_OCUPATION", "REL_WITH_WILL_PERSON", "ZONE_ID", "DISTRICT_ID", "VDC_ID", "WARD_NO", "MAIL_ADDRESS", "APPOINMENT_TYPE", "CITIZENSHIP_NO", "CS_ISSUED_DATE", "CS_ISSUED_DISTRICT", "DATE_OF_BIRTH_AD", "INSURANCE_FACILITY", "DEDUCT_ABSENT", "LEKHA_NO", "DEPT_ID", "PENSION_KOSH", "CIT_CODE", "ROOM_ID", "CODE") FROM stdin;
    public          postgres    false    430   �m      q          0    35297    PIS_EMP_ADV_DED_DTL 
   TABLE DATA           f   COPY public."PIS_EMP_ADV_DED_DTL" ("ID", "EMP_ID", "ACC_ID", "AMOUNT_CUR", "AMOUNT_PREV") FROM stdin;
    public          postgres    false    458   �m      �          0    33523    PIS_EMP_BARGA 
   TABLE DATA           T   COPY public."PIS_EMP_BARGA" ("ID", "NAME_NP", "NAME_EN", "DESCRIPTION") FROM stdin;
    public          postgres    false    301   �m      �          0    33528    PIS_EMP_DEP 
   TABLE DATA           �  COPY public."PIS_EMP_DEP" ("DEPT_ID", "NAME_NP", "NAME_EN", "DESCRIPTION", "SALARY_ACC_ID", "ALLOWANCE_ACC_ID", "ADD_PF_ACC_ID", "ADD_INSRNCE_ACC_ID", "SUB_PF_ACC_ID", "SUB_INSRNCE_ACC_ID", "CIT_ACC_ID", "INCME_TAX_ACC_ID", "LEND_PF_D_ACC_ID", "SOC_SEC_TAX", "BHATTA_ACC_ID", "PESKI_KATTI_ACC_ID", "OTHR_KATTI_ACC_ID", "ABSNT_KATTI_ACC_ID", "SAPATI_KATTI_ACC_ID", "BUDGET_SOURCE_ID", "TDS_ACC_ID", "WORK_ID", "BUDJET_SOURCE_ID") FROM stdin;
    public          postgres    false    302   �m      0          0    34187    PIS_EMP_DEP_SOURCE 
   TABLE DATA           M   COPY public."PIS_EMP_DEP_SOURCE" ("DEPT_ID", "BUDJET_SOURCE_ID") FROM stdin;
    public          postgres    false    393   
n      �          0    33533    PIS_EMP_INSURANCE_PAID 
   TABLE DATA           f   COPY public."PIS_EMP_INSURANCE_PAID" ("ID", "EMP_ID", "AMOUNT", "FISCAL_YEAR", "REMARKS") FROM stdin;
    public          postgres    false    303   'n      r          0    35307    PIS_EMP_LOANS 
   TABLE DATA           �   COPY public."PIS_EMP_LOANS" ("LOAN_ID", "NAME_NP", "NAME_EN", "EMP_ID", "ACC_ID", "LOAN_AMT", "INSTALLMENT_AMT", "PAID_AMOUNT", "CLEARED") FROM stdin;
    public          postgres    false    459   Dn      s          0    35317    PIS_EMP_LONG_LEAVES 
   TABLE DATA           �   COPY public."PIS_EMP_LONG_LEAVES" ("SN", "EMP_ID", "LOCAL_POST_ID", "LEAVE_NAME", "WORKING_OFFICE", "FROM_DATE_VS", "TO_DATE_VS", "REMARKS") FROM stdin;
    public          postgres    false    460   an      t          0    35332    PIS_EMP_MED_EXPENSE 
   TABLE DATA           �   COPY public."PIS_EMP_MED_EXPENSE" ("SN", "EMP_ID", "LOCAL_POST_ID", "WORKING_OFFICE", "ISSUED_DATE", "REGULAR_AMT", "SPECIAL_AMT", "REMARKS") FROM stdin;
    public          postgres    false    461   ~n      u          0    35347    PIS_EMP_PUNISHMNTS 
   TABLE DATA           �   COPY public."PIS_EMP_PUNISHMNTS" ("SN", "EMP_ID", "LOCAL_POST_ID", "WORKING_OFFICE", "PUNISH_TYPE", "PUNISH_DATE", "REMARKS") FROM stdin;
    public          postgres    false    462   �n      v          0    35362    PIS_EMP_SRVC_DTLS 
   TABLE DATA           �   COPY public."PIS_EMP_SRVC_DTLS" ("SN", "EMP_ID", "LOCAL_POST_ID", "OFFICE_DETAIL", "GEO_REGION", "APPOINTMENT_TYPE", "DATE_FROM", "DATE_TO", "REMARKS") FROM stdin;
    public          postgres    false    463   �n      w          0    35377    PIS_EMP_SUSPENDS 
   TABLE DATA           �   COPY public."PIS_EMP_SUSPENDS" ("SN", "EMP_ID", "LOCAL_POST_ID", "NAME_NP", "WORKING_OFFICE", "FROM_DATE_VS", "TO_DATE_VS", "REMARKS") FROM stdin;
    public          postgres    false    464   �n      x          0    35392    PIS_EMP_TRNSFR_REC 
   TABLE DATA           �   COPY public."PIS_EMP_TRNSFR_REC" ("SN", "EMP_ID", "LOCAL_POST_ID", "REF_NO", "TRNSFR_DATE", "AMT_TAKEN", "TRNSFRD_OFFICE", "MOVED_DATE", "REMARKS", "USER_ID", "USER_IDE", "DATA_ENTRY_VS_DATE", "DATA_ENTRY_AD_DATE", "DATA_EDIT_AD_DATE") FROM stdin;
    public          postgres    false    465   �n      V          0    34785    PIS_FOREIGN_VISITS 
   TABLE DATA           �   COPY public."PIS_FOREIGN_VISITS" ("SN", "EMP_ID", "LOCAL_POST_ID", "WORKING_OFFICE", "FROM_DATE_VS", "TO_DATE_VS", "FROM_DATE_AD", "TO_DATE_AD", "VISITING_PRPSE", "FUNDED_BY", "REMARKS", "APPLY_TO") FROM stdin;
    public          postgres    false    431   o      i          0    35088    PIS_FULFILLED_DARBANDI 
   TABLE DATA           �   COPY public."PIS_FULFILLED_DARBANDI" ("SN", "OFFICE_ID", "DARBANDI_ID", "PERSON_TYPE_ID", "EMP_ID", "DATE_FULFILLED", "APPOINTMNT_TYPE", "LOCAL_POST_ID") FROM stdin;
    public          postgres    false    450   ,o      �          0    33541    PIS_GEO_REGION 
   TABLE DATA           a   COPY public."PIS_GEO_REGION" ("ID", "GR_ID", "GR_NAME", "MARKS_PER_YEAR", "DETAILS") FROM stdin;
    public          postgres    false    304   Io      �          0    33549 
   PIS_HAJIRI 
   TABLE DATA           �   COPY public."PIS_HAJIRI" ("SN", "YEAR", "MONTH", "EMP_ID", "LOCAL_POST", "TOTAL_DAYS", "PUBLIC_HOLIDAYS", "HAJIRI_DAYS", "GHABIS", "BIBIS", "CABIS", "BETALABIS", "OTHER", "GAYAL") FROM stdin;
    public          postgres    false    305   fo      y          0    35407    PIS_INTERNAL_TRANSFER 
   TABLE DATA           
  COPY public."PIS_INTERNAL_TRANSFER" ("SN", "EMP_ID", "OFFICE_ID", "DARBANDI_ID", "DATE_FROM", "DATE_TO", "APPOINTMNT_TYPE", "DATE_OF_DECISION", "DECISION_REFERENCE", "REMARKS", "TO_OFFICE_ID", "TO_LOCAL_POST_ID", "TO_APPOINTMNT_TYPE", "REPLACED_EMP_ID") FROM stdin;
    public          postgres    false    466   �o      �          0    33554    PIS_LAND_BLDNGS 
   TABLE DATA           ;  COPY public."PIS_LAND_BLDNGS" ("SN", "EMP_ID", "DESCRIPTION", "UNIT_DESC", "ZONE_ID", "DISTRICT_ID", "VDC_ID", "WARD_NO", "ROAD_ID", "STREET", "OWNERSHIP_DETAILS", "AQUISITION_TYPE_ID", "SPECIAL_NOTES", "APPLY_TO", "USER_ID", "USER_IDE", "DATA_ENTRY_VS_DATE", "DATA_ENTRY_AD_DATE", "DATA_EDIT_AD_DATE") FROM stdin;
    public          postgres    false    306   �o      �          0    33562    PIS_LOAN_DHITO_GIVEN 
   TABLE DATA           
  COPY public."PIS_LOAN_DHITO_GIVEN" ("SN", "EMP_ID", "DESCRIPTION", "TRANS_DESC", "REASON_TO_TAKE", "VALUE_IN_NRS", "RETURNING_DURATION", "SPECIAL_NOTES", "APPLY_TO", "USER_ID", "USER_IDE", "DATA_ENTRY_VS_DATE", "DATA_ENTRY_AD_DATE", "DATA_EDIT_AD_DATE") FROM stdin;
    public          postgres    false    307   �o      �          0    33570    PIS_LOAN_DHITO_TAKEN 
   TABLE DATA           
  COPY public."PIS_LOAN_DHITO_TAKEN" ("SN", "EMP_ID", "DESCRIPTION", "TRANS_DESC", "REASON_TO_TAKE", "VALUE_IN_NRS", "RETURNING_DURATION", "SPECIAL_NOTES", "APPLY_TO", "USER_ID", "USER_IDE", "DATA_ENTRY_VS_DATE", "DATA_ENTRY_AD_DATE", "DATA_EDIT_AD_DATE") FROM stdin;
    public          postgres    false    308   �o      2          0    34217    PIS_LOCAL_POST_MASTER 
   TABLE DATA           �   COPY public."PIS_LOCAL_POST_MASTER" ("LOCAL_POST_ID", "LOCAL_POST_NAME", "LOCAL_POST_NAME_EN", "POST_ID", "POST_DUTIES", "BASIC_SALARY", "GRADE_RATE", "ALLWANCE", "INSURANCE_ADD_AMT", "PAYROLL_ORDER", "ALLLWANCE", "ALLOWANCE") FROM stdin;
    public          postgres    false    395   �o      �          0    33578    PIS_NIJAMATI_SEWA_SAMUHA 
   TABLE DATA           j   COPY public."PIS_NIJAMATI_SEWA_SAMUHA" ("ID", "PARENT_ID", "NAME_NP", "NAME_EN", "GRP_LEVEL") FROM stdin;
    public          postgres    false    309   p      �          0    33588    PIS_ORNAMENTS 
   TABLE DATA           �   COPY public."PIS_ORNAMENTS" ("SN", "EMP_ID", "DESCRIPTION", "UNIT_DESC", "AQUISITION_TYPE_ID", "SPECIAL_NOTES", "APPLY_TO", "USER_ID", "USER_IDE", "DATA_ENTRY_VS_DATE", "DATA_ENTRY_AD_DATE", "DATA_EDIT_AD_DATE") FROM stdin;
    public          postgres    false    310   1p      W          0    34795    PIS_OTHER_ADD_SUB 
   TABLE DATA           r   COPY public."PIS_OTHER_ADD_SUB" ("ID", "ACC_ID", "LOCAL_POST_ID", "AMOUNT", "ADD_SUB", "DESCRIPTION") FROM stdin;
    public          postgres    false    432   Np      �          0    33593    PIS_PAYROLLS 
   TABLE DATA              COPY public."PIS_PAYROLLS" ("ID", "MONTH", "EMP_ID", "LOCAL_POST_ID", "POST_IN_SHORT", "LOCAL_POST", "EMP_NAME_NP", "BASIC_SALARY", "GRADE_INC_MONTH", "RATE_OF_GRADE", "GRADE_AMOUNT", "GRADE_SALARY_TOTAL", "ALLOWANCE_AMT", "OTHER_ALLOWANCE_AMT", "PF_ADD_AMT", "INSURANCE_ADD_AMT", "NET_SALARY", "PF_DEDUCT_AMT", "INSURANCE_DEDUCT_AMT", "CIT_PERCENT", "CIT_AMT", "TAX_AMT", "ADVANCE_DEDUCT_AMT", "LOAN_DEDUCT_AMT", "ABSENT_DAYS", "ABSENT_DEDUCT_AMT", "OTHER_DEDUCT_TOTAL", "TOTAL_PAYABLE_SALARY", "PAYMODE", "POST_LEVEL", "VCHR_ID", "VCHR_DATE_NP", "PAY_BANK_ID", "TRANS_TPE_ID", "DEDUCT_DEP_VCHR_ID", "DEDUCT_DEP_VCHR_DATE_NEP", "REMARKS", "FISCAL_YEAR", "FESTIVE_VCHR_ID", "FESTIVE_VCHR_DATE_NEP", "PENSIONKOSH_ADD_AMT", "PENSIONKOSH_DED_AMT", "TDS_AMT") FROM stdin;
    public          postgres    false    311   kp      �          0    33598    PIS_PD_ORG_INVLVMNT 
   TABLE DATA           I  COPY public."PIS_PD_ORG_INVLVMNT" ("SN", "EMP_ID", "ORG_NAME", "ORG_ADD", "ORG_FORMED_DATE", "ORG_AIMS", "ORG_ACHEIVMNTS", "NO_OF_BENIFIC_POPLN", "POST_IN_ORG", "RESPNSBLTY_IN_ORG", "ORG_JOINED_DATE", "ORG_LEFT_DATE", "REMARKS", "USER_ID", "USER_IDE", "DATA_ENTRY_VS_DATE", "DATA_ENTRY_AD_DATE", "DATA_EDIT_AD_DATE") FROM stdin;
    public          postgres    false    312   �p      �          0    33606    PIS_PD_SRVC_DTLS 
   TABLE DATA           �   COPY public."PIS_PD_SRVC_DTLS" ("SN", "EMP_ID", "LOCAL_POST_ID", "APPOINTMNT_LEVEL", "APPOINTMNT_TYPE", "OFFICE_DETAIL", "DATE_FROM", "DATE_TO", "REMARKS") FROM stdin;
    public          postgres    false    313   �p      �          0    33611    PIS_PERSON_VISIT_RECRD 
   TABLE DATA           +  COPY public."PIS_PERSON_VISIT_RECRD" ("SN", "PERSON_TYPE_ID", "PERSON_ID", "PERSON_NAME", "PERSON_POST", "REF_NO", "FROM_DATE", "TO_DATE", "AMOUNT_TAKEN", "VISIT_LOCATION", "JOB_DETAILS", "REMARKS", "USER_ID", "USER_IDE", "DATA_ENTRY_VS_DATE", "DATA_ENTRY_AD_DATE", "DATA_EDIT_AD_DATE") FROM stdin;
    public          postgres    false    314   �p      �          0    33619    PIS_POST_MASTER 
   TABLE DATA           �   COPY public."PIS_POST_MASTER" ("POST_ID", "GENERAL_POST", "GENERAL_POST_SHORT", "POST_LEVEL", "BASIC_SALARY", "RATE_OF_GRADE", "MAX_GRADE_RATE", "PRABIDIK_OR_PRASASAN") FROM stdin;
    public          postgres    false    315   �p      X          0    34805 
   PIS_PRIZES 
   TABLE DATA           �   COPY public."PIS_PRIZES" ("SN", "EMP_ID", "LOCAL_POST_ID", "NAME_NP", "DESCRIPTION", "AWARD_TYPE", "AMOUNT", "AWARDED_BY", "WORKING_OFFICE", "ISSUED_DATE", "REMARKS", "APPLY_TO") FROM stdin;
    public          postgres    false    433   �p      Y          0    34815    PIS_PUBLICATION 
   TABLE DATA           �   COPY public."PIS_PUBLICATION" ("SN", "EMP_ID", "LOCAL_POST_ID", "NEP_NAME", "DESCRIPTION", "WORKING_OFFICE", "PUBLSH_DATE_VS", "PUBLSH_DATE_AD", "PUBLISHER", "REMARKS", "APPLY_TO") FROM stdin;
    public          postgres    false    434   q      �          0    35753    PIS_PYROLL_LOAN_DTLS 
   TABLE DATA           �   COPY public."PIS_PYROLL_LOAN_DTLS" ("ID", "LOAND_ID", "MONTH", "NAME_NP", "EMP_ID", "ACC_ID", "LOAND_AMT", "INSTALLMENT_AMT", "CLEARED", "PAYROLL_ID") FROM stdin;
    public          postgres    false    480   6q      z          0    35447    PIS_PYROLL_OTHR_DTLS 
   TABLE DATA           �   COPY public."PIS_PYROLL_OTHR_DTLS" ("ID", "MONTH", "EMPLOYEE_ID", "PAYROLL_ID", "AMOUNT", "ADD_SUB", "DESCRIPTION", "ACC_ID", "SOURCE_TYPE") FROM stdin;
    public          postgres    false    467   Sq      �          0    35567    PIS_REPLACED_IN_DARBANDI 
   TABLE DATA             COPY public."PIS_REPLACED_IN_DARBANDI" ("SN", "EMP_ID", "ENTRY_SN_IN_FD", "OFFICE_ID", "DARBANDI_ID", "DATE_FULFILLED", "APPOINTMNT_TYPE", "REPLACED_BY", "DATE_REPLACED", "DATE_OF_DECISION", "DECISION_REFERENCE", "IS_PLACED_IN_DARBANDI", "REMARKS") FROM stdin;
    public          postgres    false    474   pq      �          0    33624    PIS_SERVICE_STATUS 
   TABLE DATA           Y   COPY public."PIS_SERVICE_STATUS" ("ID", "NAME_NP", "NAME_EN", "DESCRIPTION") FROM stdin;
    public          postgres    false    316   �q      Z          0    34825    PIS_SGNFCNT_WORK 
   TABLE DATA           �   COPY public."PIS_SGNFCNT_WORK" ("SN", "EMP_ID", "LOCAL_POST_ID", "NAME_NP", "DESCRIPTION", "WORKING_OFFICE", "FROM_DATE_VS", "TO_DATE_VS", "FROM_DATE_AD", "TO_DATE_AD", "DURATION", "REMARKS", "APPLY_TO") FROM stdin;
    public          postgres    false    435   �q      �          0    33629    PIS_SHARE_BANKBALANCE 
   TABLE DATA             COPY public."PIS_SHARE_BANKBALANCE" ("SN", "EMP_ID", "DESCRIPTION", "COMPANY_OR_BANK", "VALUE_IN_NRS", "OWNERSHIP_DETAILS", "AQUISITION_TYPE_ID", "SPECIAL_NOTES", "APPLY_TO", "USER_ID", "USER_IDE", "DATA_ENTRY_VS_DATE", "DATA_ENTRY_AD_DATE", "DATA_EDIT_AD_DATE") FROM stdin;
    public          postgres    false    317   �q      [          0    34835    PIS_TRAINING 
   TABLE DATA             COPY public."PIS_TRAINING" ("SN", "EMP_ID", "LOCAL_POST_ID", "TRAINING_TYPE", "TRAINING_NAME", "INSTITUTE", "COUNTRY_ID", "FRM_DATE_VS", "TO_DATE_VS", "FRM_DATE_AD", "TO_DATE_AD", "DURATION", "DIVISION", "MARKS_OBTND", "VALID_FOR_EVAL", "APPLY_TO") FROM stdin;
    public          postgres    false    436   �q      |          0    35482    PIS_VISITED_COUNTRIES 
   TABLE DATA           g   COPY public."PIS_VISITED_COUNTRIES" ("SN", "VISIT_ID", "EMP_ID", "COUNTRY_ID", "APPLY_TO") FROM stdin;
    public          postgres    false    469   r      \          0    34845    PIS_WORKSHOP 
   TABLE DATA           �   COPY public."PIS_WORKSHOP" ("SN", "EMP_ID", "LOCAL_POST_ID", "NEP_NAME", "DESCRIPTION", "WORKING_OFFICE", "DURATION", "FROM_DATE_VS", "TO_DATE_VS", "FROM_DATE_AD", "TO_DATE_AD", "ORGANIZER", "COUNTRY_ID", "REMARKS", "APPLY_TO") FROM stdin;
    public          postgres    false    437   r      �          0    33637    PMS_YOJTYPE 
   TABLE DATA           g   COPY public."PMS_YOJTYPE" ("ID", "YOJTYPE_NAME_NP", "YOJTYPE_NAME_ENG", "YOJTYPE_REMARKS") FROM stdin;
    public          postgres    false    318   ;r      �          0    33647    RENTTYPE 
   TABLE DATA           K   COPY public."RENTTYPE" ("ID", "NEPNAME", "ENGNAME", "REMARKS") FROM stdin;
    public          postgres    false    320   Xr      �          0    33642    RENT_DAR_RATE 
   TABLE DATA           V   COPY public."RENT_DAR_RATE" ("ID", "RATENAME", "RENT_PER", "RENT_TYPEID") FROM stdin;
    public          postgres    false    319   ur      �          0    33650    REPORT_GENERAL 
   TABLE DATA           �   COPY public."REPORT_GENERAL" ("REPORT_ID", "OFFICE_TYPE_ID", "REPORT_NAME", "REPORT_FOR", "ANUSUCHI_HEAD", "ANUSUCHI_DETAILS", "REPORT_HEADING") FROM stdin;
    public          postgres    false    321   �r      �          0    33656    SANITATION_GROUP 
   TABLE DATA           ?   COPY public."SANITATION_GROUP" ("ID", "GROUPNAME") FROM stdin;
    public          postgres    false    322   �r      ]          0    34858    SANITATION_RATE 
   TABLE DATA           �   COPY public."SANITATION_RATE" ("ID", "GROUPID", "SUBGROUPID", "ROAD_TYPEID", "RATENAME", "RATE", "FISCAL_YEAR", "AREA_UPTO", "FOR_EACH_AREA", "EACH_AREA_RATE") FROM stdin;
    public          postgres    false    438   �r      3          0    34230    SANITATION_SUBGROUP 
   TABLE DATA           [   COPY public."SANITATION_SUBGROUP" ("ID", "GROUPID", "SUBGROUPNAME", "REMARKS") FROM stdin;
    public          postgres    false    396   �r      D          0    34444    SERVICE_CHARGE_MASTER 
   TABLE DATA           �   COPY public."SERVICE_CHARGE_MASTER" ("ID", "RATEID", "ACCODE", "ACC_ID", "SERVICE_CHARGE_PERCENT", "FLAT_CHARGE_RATE", "ISAPPLICABLEFORHOUSE") FROM stdin;
    public          postgres    false    413   s      �          0    33661    SPACEMEASURINGUNITS 
   TABLE DATA           T   COPY public."SPACEMEASURINGUNITS" ("UNITID", "UNITNAME", "SQFTPERUNIT") FROM stdin;
    public          postgres    false    323   #s      7          0    34270    STOREDBILLS 
   TABLE DATA           z   COPY public."STOREDBILLS" ("SN", "DATEISSUED", "DESCRIPTION", "BILLNOFROM", "BILLNOTO", "CODE", "BILLTYPEID") FROM stdin;
    public          postgres    false    400   @s      �          0    33664    SUBJECT_AREA 
   TABLE DATA           f   COPY public."SUBJECT_AREA" ("ID", "PARENT_ID", "CODE", "NEP_NAME", "ENG_NAME", "REMARKS") FROM stdin;
    public          postgres    false    324   ]s      '          0    34076    SUB_MODULE_SOURCE 
   TABLE DATA           R   COPY public."SUB_MODULE_SOURCE" ("SUB_MODULE_ID", "BUDJET_SOURCE_ID") FROM stdin;
    public          postgres    false    384   zs      �          0    33672    SV_BUSINESSMASTER 
   TABLE DATA           S  COPY public."SV_BUSINESSMASTER" ("ID", "NEPNAME", "DESCRIPTION", "BUSINESSGROUPID", "TYPEID", "TAXPAYERID", "INITIALCAPITAL", "ZONEID", "DISTRICTID", "VDCID", "WARDNO", "STREET", "TRACKID", "HOUSENO", "PHONES", "EMAILS", "HOUSEOWNER", "ISINRENT", "MONTHLYRENT", "AREAINSQUAREFEETS", "INITIALREGISTEREDOFFICE", "INITIALREGNO", "INITIALREGDATE", "MUNICIPALREGNO", "MUNICIPALLREGDATE", "SQFEETSOFSIGNBOARD", "LENGTHOFSIGNBOARD", "WIDTHOFSIGNBOARD", "CONTENTOFSIGNBOARD", "BUSINESSSTARTINGDATE", "SPECIALNOTES", "USERID", "USERIDE", "DATAENTRYVSDATE", "DATAENTRYADDATETIME", "DATAEDITADDATETIME", "GENERALRATEID", "MAIL_ADDRESS", "BUSINESS_STATUS", "CLOSED_VS_DATE", "CLOSE_REASON", "PAID_LAST_FISCALYEAR", "SANITATIONID", "MAXCAPITAL", "YEARLY_TRAN_AMOUNT", "SHIFTDATE", "SHIFTTAXPAYERID", "ADDRESSCHANGE", "HOUSEID", "BUSINESSOWNERTAX_IID") FROM stdin;
    public          postgres    false    325   �s      �          0    33680    SV_CONSTRUCTIONS 
   TABLE DATA           �  COPY public."SV_CONSTRUCTIONS" ("ID", "IID", "HOUSEID", "TALANUMBER", "CONSTRUCTIONTYPEID", "LENGTHINFEET", "WIDTHTHINFEET", "HEIGHTINFEET", "AREAINSQFEET", "VSDATEOFMADE", "CONSTRUCTIONUSESTYPEID", "SELFUSEORINRENT", "GENERALRATEID", "INCLUDEINEVALUATION", "SPECIALNOTE", "USERID", "USERIDE", "DATAENTRYVSDATE", "DATAENTRYADDATETIME", "DATAEDITADDATETIME", "TAXPAYER_DEFINE_AMOUNT", "VSMAPPDATE") FROM stdin;
    public          postgres    false    326   �s      �          0    33685 	   SV_HOUSES 
   TABLE DATA             COPY public."SV_HOUSES" ("ID", "IID", "LANDID", "HOUSENUMBER", "HOUSETYPEID", "HOUSECONSTRUCTIONTYPEID", "SALES_DT", "VSDATEOFMADE", "AQUISITIONDATE", "USESTYPEID", "HASMAPREGISTERED", "MAPREGISTEREDDATE", "NUMOFTALAS", "HEIGHTINFEETS", "LENGTHINFEETS", "WIDTHINFEETS", "AREAINSQFEETS", "SPECIALNOTE", "INCLUDEINEVALUATION", "AREAOFCONSTRUCTIONSINSQFEETS", "USERID", "USERIDE", "DATAENTRYVSDATE", "DATAENTRYADDATETIME", "DATAEDITADDATETIME", "DEFINE_AMT", "SANITATIONRATEID", "BUILDINGCODE", "BIN_GIS") FROM stdin;
    public          postgres    false    327   �s      �          0    33693    SV_LANDS 
   TABLE DATA           	  COPY public."SV_LANDS" ("ID", "IID", "OLDVDCID", "OLDWARDNO", "LAND_RULES", "WARDNO", "MOTHNUMBER", "MAPNUMBER", "KITTANUMBER", "STREETNAME", "HASTRACK", "TRACKID", "TRACKRELATIONID", "AQUISITIONDATE", "AQUISITIONTYPEID", "USESTYPEID", "VALUEINRSONAQUISITION", "AREAINSQFT", "NONFUNCTIONALAREAINSQFT", "EASTBOUNDARY", "WESTBOUNDARY", "NORTHTBOUNDARY", "SOUTHTBOUNDARY", "LQTYPEID", "LANDNATUREID", "LOCATIONFACTORID", "SELFDECLAREDVALUEINRS", "SPECIALNOTE", "GENERALRATEID", "INCLUDEINEVALUATION", "USERID", "USERIDE", "DATAENTRYVSDATE", "SALES_DT", "DATAENTRYADDATETIME", "DATAEDITADDATETIME", "EVALEXCLUSIONREASONID", "MALPOTRATE", "AREA_TYPE_ID", "NOMINATION_DIRECTION", "NOMINATION_AREA", "NOMINATION_LENGTH", "NOMINATION_BREADTH", "NOMINATION_TF", "LANDTYPE", "EASTBOUNDARY_KITTA", "WESTBOUNDARY_KITTA", "NORTHBOUNDARY_KITTA", "SOUTHBOUNDARY_KITTA", "TOLENAME", "LANDMEASURINGUNITID", "GRID_NO", "SHEET_NO", "EASTRUNFT", "WESTRUNFT", "NORTHRUNFT", "SOUTHRUNFT", "AREAINSQFT_FIELD", "IS_LRMIS_ADD", "DEIGSTERTYPEID") FROM stdin;
    public          postgres    false    328   �s      �          0    33701    SV_LANDSMULTIEVALUATIONDETAIL 
   TABLE DATA           ~   COPY public."SV_LANDSMULTIEVALUATIONDETAIL" ("SN", "IID", "LANDID", "KITTANUMBER", "GENERALRATEID", "AREAINSQFT") FROM stdin;
    public          postgres    false    329   t      �          0    33704 	   SV_PEOPLE 
   TABLE DATA           !  COPY public."SV_PEOPLE" ("IID", "EID", "SEX", "FIRSTNEPNAME", "LASTNEPNAME", "FIRSTENGNAME", "LASTENGNAME", "DOB", "FATHERORHUSBAND", "GFORFINLAW", "PHONES", "MOBILES", "EMAIL", "OCUPATIONID", "RELIGIONID", "MOTHERLANGUAGEID", "NATIONALITYID", "HASCC", "CCNUMBER", "CCISSUEDDRISTICTID", "CCISSUEDDATE", "COUNTRYID", "ZONEID", "DISTRICTID", "VDCID", "WARDNO", "STREETNAME", "TRACKID", "HOUSENO", "CORESPADDRESSLINE1", "CORESPADDRESSLINE2", "CORESPADDRESSLINE3", "CORESPADDRESSLINE4", "OTHERDETAILS", "INDIVIDUALTYPE", "PHOTO", "USERID", "USERIDE", "DATAENTRYVSDATE", "DATAENTRYADDATETIME", "DATAEDITADDATETIME", "IPT_UNPAID_FISCAL_YEAR", "IPT_UNPAID_AMOUNT", "HLT_UNPAID_FISCAL_YEAR", "HLT_UNPAID_AMOUNT", "IS_UNPAID_CLEARED", "CANCEL_DATE", "CANCEL_REASON", "TOLBIKASHID", "IS_LRMIS_ADD") FROM stdin;
    public          postgres    false    330   (t      �          0    33712    SV_TBHOUSEKITTANUMBER 
   TABLE DATA           M   COPY public."SV_TBHOUSEKITTANUMBER" ("IID", "HOUSEID", "LANDID") FROM stdin;
    public          postgres    false    331   Et      �          0    33715    SV_VEHICLEMASTER 
   TABLE DATA           P  COPY public."SV_VEHICLEMASTER" ("SN", "TAXPAYERID", "VEHICLENAME", "VEHICLETYPE", "VEHICLENO", "REGISTEREDOFFICE", "REGISTEREDDATE", "MUNICIPALTYREGNO", "MUNICIPALTYREGDATE", "AQUISITIONTYPE", "AQUISITIONDATE", "AQUIREDFROM", "USESTYPE", "COLOR", "NUMBEROFSEATES", "CCORHPRSPOWER", "MADEOF", "ENGINENO", "CHESISNO", "MODELDESCRIPTION", "NOOFCILENDERS", "USEDFUEL", "SPECIALNOTES", "USERID", "USERIDE", "DATAENTRYVSDATE", "DATAENTRYADDATETIME", "DATAEDITADDATETIME", "VEHICLE_STATUS", "CLOSED_VS_DATE", "CLOSE_REASON", "PAID_LAST_FISCALYEAR", "NAMASARIMITI", "NAMASARITAXPAYERID") FROM stdin;
    public          postgres    false    332   bt      E          0    34454    TAX_ADDTNL_CHRG_DTLS 
   TABLE DATA             COPY public."TAX_ADDTNL_CHRG_DTLS" ("SN", "FISCAL_YEAR", "IID", "ACCODE", "ACC_ID", "AMOUNT", "LAND_ID", "RENT_ID", "SERVICE_CHARGE_PERCENT", "FLAT_CHARGE_RATE", "ISAPPLICABLEFORHOUSE", "TAX_TYPE", "SERVICE_CHARGE_TYPE", "ISREGISTATIONFEE", "BILL_ID", "BILL_NO") FROM stdin;
    public          postgres    false    414   t      �          0    33723 
   TAX_MALPOT 
   TABLE DATA           �  COPY public."TAX_MALPOT" ("SN", "FISCALYEAR", "TAXPAYERID", "LANDID", "KITTANUMBER", "GENERALRATEID", "RATEPERUNIT", "SPECIALNOTES", "NETTAXAMOUNT", "FINEAMOUNT", "ADDITIONALCHARGES", "REDUCTIONALCHARGES", "TAXPAIDAMOUNT", "LAST_TAX_PAID_AMOUNT", "TOTALAREA", "NONEVALUATEDAREA", "NETEVALUATINGAREA", "BILLID", "BILLDATE", "BILLNO", "COUNTERID", "USERID", "USERIDE", "DATAENTRYVSDATE", "DATAENTRYADDATETIME", "DATAEDITADDATETIME") FROM stdin;
    public          postgres    false    333   �t      �          0    33729    TAX_MALPOT_HISTORY 
   TABLE DATA           �  COPY public."TAX_MALPOT_HISTORY" ("SN", "MALPOT_ID", "FISCALYEAR", "TAXPAYERID", "LANDID", "KITTANUMBER", "GENERALRATEID", "RATEPERUNIT", "SPECIALNOTES", "NETTAXAMOUNT", "FINEAMOUNT", "ADDITIONALCHARGES", "REDUCTIONALCHARGES", "TAXPAIDAMOUNT", "LAST_TAX_PAID_AMOUNT", "TOTALAREA", "NONEVALUATEDAREA", "NETEVALUATINGAREA", "BILLID", "BILLDATE", "BILLNO", "COUNTERID", "USERID", "USERIDE", "DATAENTRYVSDATE", "DATAENTRYADDATETIME", "DATAEDITADDATETIME") FROM stdin;
    public          postgres    false    334   �t      �          0    33735    TAX_RATE_CEILING 
   TABLE DATA           d   COPY public."TAX_RATE_CEILING" ("ID", "NP_FROM", "NP_TO", "MARRIED_STATUS", "TAX_RATE") FROM stdin;
    public          postgres    false    335   �t      �          0    33740 
   TAX_RENTAL 
   TABLE DATA           Y  COPY public."TAX_RENTAL" ("ID", "FISCALYEAR", "TAXPAYERID", "CONSTRUCTIONID", "RENTID", "RATEID", "REMARKS", "NETTAXAMOUNT", "FINEAMOUNT", "ADDITIONALCHARGES", "REDUCTIONALCHARGES", "TAXPAIDAMOUNT", "LAST_TAX_PAID_AMOUNT", "BILLID", "BILLNO", "BILLDATE", "COUNTERID", "USERID", "DATEENTRYVSDATE", "DATAENTRYADDATE", "YEAR", "MONTH") FROM stdin;
    public          postgres    false    336   �t      �          0    33746    TAX_RT_RENTDTL 
   TABLE DATA           f  COPY public."TAX_RT_RENTDTL" ("ID", "CONSTRUCTION_ID", "RNAME", "RENT_TYPE_ID", "RENT_INSQFEET", "ANUAL_RENT_INCOME", "FISCAL_YEAR", "AGREEMENT_DATE", "VALID_UNTIL", "RENT_STATUS", "RATEID", "TAXPAYERID", "BUSINESSID", "REMARKS", "DATAENTRYADDATETIME", "DATAEDITADDATETIME", "USERID", "USERIDE", "DATAENTRYVSDATE", "IS_TAX_PAID_BUSINESS_PERSON") FROM stdin;
    public          postgres    false    337   u      �          0    33752    TAX_SANITATION 
   TABLE DATA           p  COPY public."TAX_SANITATION" ("SN", "FISCALYEAR", "YEAR", "MONTH", "TAXPAYERID", "HOUSEID", "RATEID", "SPECIALNOTES", "NETTAXAMOUNT", "FINEAMOUNT", "REDUCTIONALCHARGES", "TAXPAIDAMOUNT", "LAST_TAX_PAID_AMOUNT", "BILLID", "BILLNO", "BILLDATE", "COUNTERID", "USERID", "USERIDE", "DATAENTRYVSDATE", "DATAENTRYADDATETIME", "DATAEDITADDATETIME", "SERVICETYPE") FROM stdin;
    public          postgres    false    338   -u      `          0    34901    TAX_THLI_ISSUED_CNTR 
   TABLE DATA           M   COPY public."TAX_THLI_ISSUED_CNTR" ("ID", "THELI_ID", "CNTR_ID") FROM stdin;
    public          postgres    false    441   Ju      �          0    33758    TBHOUSEKITTANUMBER 
   TABLE DATA           J   COPY public."TBHOUSEKITTANUMBER" ("IID", "HOUSEID", "LANDID") FROM stdin;
    public          postgres    false    339   gu                0    33884    TBLBILLTYPE 
   TABLE DATA           S   COPY public."TBLBILLTYPE" ("ID", "NEPNAME", "ISINCOME", "DESCRIPTION") FROM stdin;
    public          postgres    false    359   �u      H          0    34489    TBLBUSINESS_SERVICE_CH_MST 
   TABLE DATA           �   COPY public."TBLBUSINESS_SERVICE_CH_MST" ("ID", "RATEID", "ACCODE", "ACC_ID", "SERVICECHARGEPERCENT", "FLATCHARGERATE", "FISCAL_YEAR") FROM stdin;
    public          postgres    false    417   �u                0    33889    TBLEXEVERSION 
   TABLE DATA           =   COPY public."TBLEXEVERSION" ("EXEID", "EXEDATE") FROM stdin;
    public          postgres    false    360   �u                0    33892    TBLFYWISEBTRATES 
   TABLE DATA           �   COPY public."TBLFYWISEBTRATES" ("ID", "GROUPID", "SUBGROUPID", "SNSUBGROUP", "RATEID", "NEPNAME", "DESCRIPTION", "FISCALYEAR", "RATEPERUNIT") FROM stdin;
    public          postgres    false    361   �u      ~          0    35507    TBLFYWISEMPOTASSRATE 
   TABLE DATA           �   COPY public."TBLFYWISEMPOTASSRATE" ("ID", "GROUPID", "SUBGROUPID", "RATEID", "NEPNAME", "FISCALYEAR", "RATEPERUNIT", "AREA_UPTO", "FOR_EACH_AREA", "EACH_AREA_RATE") FROM stdin;
    public          postgres    false    471   �u                0    33895    TBLHL_ADD_SUBTRACT 
   TABLE DATA           �   COPY public."TBLHL_ADD_SUBTRACT" ("SN", "FISCAL_YEAR", "RATEID", "FLAT_RATE", "RATE_PERCENT", "ADD_FLAG", "ADD_SUB_TRACT_TYPE") FROM stdin;
    public          postgres    false    362   v                0    33900    TBLLAND_TYPE_AREA 
   TABLE DATA           R   COPY public."TBLLAND_TYPE_AREA" ("ID", "CODE", "NEP_NAME", "REMARKS") FROM stdin;
    public          postgres    false    363   2v                0    33905    TBLMALPOTGROUP 
   TABLE DATA           J   COPY public."TBLMALPOTGROUP" ("ID", "NEPNAME", "DESCRIPTION") FROM stdin;
    public          postgres    false    364   Ov      a          0    34916    TBLMALPOTRATES 
   TABLE DATA           �   COPY public."TBLMALPOTRATES" ("ID", "GROUPID", "SUBGROUPID", "NEPNAME", "RATEPERUNIT", "DESCRIPTION", "AREA_UPTO", "FOR_EACH_AREA", "EACH_AREA_RATE") FROM stdin;
    public          postgres    false    442   lv      8          0    34280    TBLMALPOTSUBGROUP 
   TABLE DATA           a   COPY public."TBLMALPOTSUBGROUP" ("ID", "GROUPID", "NEPNAME", "DESCRIPTION", "WORDA") FROM stdin;
    public          postgres    false    401   �v                0    33915    TBLTAXCALCULATIONROKA 
   TABLE DATA           U   COPY public."TBLTAXCALCULATIONROKA" ("ID", "IID", "REASON", "ROKA_DATE") FROM stdin;
    public          postgres    false    366   �v                0    33910    TBLTAX_FINE_REBATE 
   TABLE DATA           �   COPY public."TBLTAX_FINE_REBATE" ("SN", "FISCAL_YEAR", "DURATION_IN_YEARS", "TAX_TYPE", "FLAT_RATE", "RATE_PERCENT", "REBATE_FLAG") FROM stdin;
    public          postgres    false    365   �v      I          0    34499    TBLVEH_SER_CH_MSTR 
   TABLE DATA           �   COPY public."TBLVEH_SER_CH_MSTR" ("ID", "RATEID", "ACCODE", "ACC_ID", "SERVICE_CHARGE_PERCENT", "FLAT_CHARGE_RATE", "FISCAL_YEAR") FROM stdin;
    public          postgres    false    418   �v      �          0    33761    TBL_BANK_ACCNT_TYPE 
   TABLE DATA           V   COPY public."TBL_BANK_ACCNT_TYPE" ("ID", "NEPNAME", "ENGNAME", "REMARKS") FROM stdin;
    public          postgres    false    340   �v      �          0    33766    TBL_BANK_FINANCE_INSTITUTUE 
   TABLE DATA           t   COPY public."TBL_BANK_FINANCE_INSTITUTUE" ("ID", "NP_NAME", "ENG_NAME", "DESCRIPTIONG", "ACCOUNT_NAME") FROM stdin;
    public          postgres    false    341   w      �          0    33774    TBL_BGT_MGMT 
   TABLE DATA           {   COPY public."TBL_BGT_MGMT" ("ID", "FISCAL_YEAR", "MINISTRY_ID", "BGT_SUB_HEAD_ID", "TOTAL_BGT_AMT", "REMARKS") FROM stdin;
    public          postgres    false    342   7w      4          0    34240    TBL_BGT_MGMT_EXP 
   TABLE DATA           a   COPY public."TBL_BGT_MGMT_EXP" ("ID", "BGT_MGMT_ID", "ACC_ID", "BGT_AMT", "REMARKS") FROM stdin;
    public          postgres    false    397   Tw      5          0    34250    TBL_BGT_MGMT_EXP_ORG 
   TABLE DATA           m   COPY public."TBL_BGT_MGMT_EXP_ORG" ("ID", "BGT_MGMT_ORG_ID", "ACC_ID", "BGT_AMT_ORG", "REMARKS") FROM stdin;
    public          postgres    false    398   qw      b          0    34931    TBL_BGT_MGMT_EXP_RELEASE 
   TABLE DATA           m   COPY public."TBL_BGT_MGMT_EXP_RELEASE" ("ID", "BGT_MGMT_RELEASE_ID", "ACC_ID", "AMT", "REMARKS") FROM stdin;
    public          postgres    false    443   �w      �          0    33779    TBL_BGT_MGMT_ORG 
   TABLE DATA           �   COPY public."TBL_BGT_MGMT_ORG" ("ID", "FISCAL_YEAR", "MINISTRY_ID", "ORG_ID", "BGT_SUB_HEAD_ID", "TOTAL_BGT_AMT_ORG", "REMARKS") FROM stdin;
    public          postgres    false    343   �w      >          0    34349    TBL_BGT_MGMT_RELEASE 
   TABLE DATA           �   COPY public."TBL_BGT_MGMT_RELEASE" ("ID", "BGT_RELEASE_ID", "FISCAL_YEAR", "MINISTRY_ID", "ORG_ID", "BGT_SUB_HEAD_ID", "AMT", "REMARKS") FROM stdin;
    public          postgres    false    407   �w      ^          0    34876    TBL_BGT_MGMT_SRC 
   TABLE DATA           �   COPY public."TBL_BGT_MGMT_SRC" ("ID", "BGT_MGMT_EXP_ID", "SOURCE_ID", "AMT", "PAYMENT_TYPE_ID", "PAYMENT_PROCESS_ID", "REMARKS") FROM stdin;
    public          postgres    false    439   �w      _          0    34886    TBL_BGT_MGMT_SRC_ORG 
   TABLE DATA           �   COPY public."TBL_BGT_MGMT_SRC_ORG" ("ID", "BGT_MGMT_EXP_ORG_ID", "SOURCE_ID", "AMT", "CC_ID", "CC_ACTIVE", "PAYMENT_TYPE_ID", "PAYMENT_PROCESS_ID", "REMARKS") FROM stdin;
    public          postgres    false    440   x                0    35527    TBL_BGT_MGMT_SRC_RELEASE 
   TABLE DATA           �   COPY public."TBL_BGT_MGMT_SRC_RELEASE" ("ID", "BGT_MGMT_EXP_RELEASE_ID", "SOURCE_ID", "AMT", "CC_ID", "CC_ACTIVE", "PAYMENT_TYPE_ID", "PAYMENT_PROCESS_ID", "REMARKS") FROM stdin;
    public          postgres    false    472   x                0    33961    TBL_BGT_RELEASE 
   TABLE DATA           �   COPY public."TBL_BGT_RELEASE" ("ID", "FISCAL_YEAR", "MINISTRY_ID", "ORG_ID", "RELEASE_TYPE", "RELEASE_DATE", "CHALANI_NO", "LETTER_SN", "APPROVED_BGT_YEARLY", "PREVIOUS_RELEASE_AMT", "RELEASE_AMOUNT", "SPECIAL_TIPPANI") FROM stdin;
    public          postgres    false    375   <x      F          0    34469    TBL_CONSTRUCTION_OTHER_CHARGES 
   TABLE DATA           �   COPY public."TBL_CONSTRUCTION_OTHER_CHARGES" ("ID", "RATEID", "ACCODE", "ACC_ID", "PERCENT_OF_TAX", "FLAT_CHARGE_RATE", "FISCAL_YEAR", "SERVICE_CHARGE_CALCULATION") FROM stdin;
    public          postgres    false    415   Yx      �          0    33784    TBL_DATA_HISTORY 
   TABLE DATA           �   COPY public."TBL_DATA_HISTORY" ("ID", "TABLE_NAME", "FIELD_NAME", "NEW_VALUE", "OLD_VALUE", "USER_ID_A", "ADD_DATE", "COMPUTER_NAME", "DATA_STATUS", "WINDOWS_USER", "TRAN_TIME") FROM stdin;
    public          postgres    false    344   vx                 0    33792    TBL_DEGISTER 
   TABLE DATA           d   COPY public."TBL_DEGISTER" ("ID", "NP_NAME", "ENG_NAME", "REMARKS", "IS_FULL_DEGISTER") FROM stdin;
    public          postgres    false    345   �x                0    33800    TBL_KHARIDA_AADASH 
   TABLE DATA           K   COPY public."TBL_KHARIDA_AADASH" ("ID", "NP_NAME", "ENG_NAME") FROM stdin;
    public          postgres    false    346   �x      G          0    34479    TBL_LAND_OTHER_CHARGES 
   TABLE DATA           �   COPY public."TBL_LAND_OTHER_CHARGES" ("ID", "RATEID", "ACCODE", "ACC_ID", "PERCENT_OF_TAX", "FLAT_CHARGE_RATE", "FISCAL_YEAR", "SERVICE_CHARGE_CALCULATION") FROM stdin;
    public          postgres    false    416   �x      }          0    35492    TBL_MALPOT_OTHER_CHARGES 
   TABLE DATA           �   COPY public."TBL_MALPOT_OTHER_CHARGES" ("ID", "RATEID", "ACCODE", "ACC_ID", "PERCENT_OF_TAX", "FLAT_CHARGE_RATE", "FISCAL_YEAR") FROM stdin;
    public          postgres    false    470   �x                0    33805    TBL_NALI_TYPE 
   TABLE DATA           T   COPY public."TBL_NALI_TYPE" ("ID", "NEPNAME", "ENGNAME", "DESCRIPTION") FROM stdin;
    public          postgres    false    347   y                0    33810    TBL_ORGANIZATIONMASTER 
   TABLE DATA           _   COPY public."TBL_ORGANIZATIONMASTER" ("ID", "NP_NAME", "ENG_NAME", "DESCRIPTIONG") FROM stdin;
    public          postgres    false    348   $y                0    33818    TBL_PAYMENT_ORDER 
   TABLE DATA           c   COPY public."TBL_PAYMENT_ORDER" ("ID", "ORDER_CODE", "DATE_BS", "TOKEN_NO", "REMARKS") FROM stdin;
    public          postgres    false    349   Ay      6          0    34260    TBL_PAYMENT_ORDER_DETAILS 
   TABLE DATA           �   COPY public."TBL_PAYMENT_ORDER_DETAILS" ("ID", "PAYMENT_ORDER_ID", "VOUCHER_ID", "LINK_VOUCHER_ID", "PAYMENT_PERMISS_NO") FROM stdin;
    public          postgres    false    399   ^y                0    33826    TBL_PAYMENT_PROCESS 
   TABLE DATA           j   COPY public."TBL_PAYMENT_PROCESS" ("ID", "PAYMENT_PROCESS", "PAYMENT_PROCESS_ENG", "REMARKS") FROM stdin;
    public          postgres    false    350   {y                0    33831    TBL_PAYMENT_TYPE 
   TABLE DATA           a   COPY public."TBL_PAYMENT_TYPE" ("ID", "PAYMENT_TYPE", "PAYMENT_TYPE_ENG", "REMARKS") FROM stdin;
    public          postgres    false    351   �y                0    33836    TBL_PROPERTY_TAX 
   TABLE DATA           �   COPY public."TBL_PROPERTY_TAX" ("ID", "IID", "NP_ENTRY_DATE", "FISCAL_YEAR", "HOUSE_LAND_AMOUNT", "MALPOT_AMOUNT", "TOTAL_TAX", "REMARKS") FROM stdin;
    public          postgres    false    352   �y                0    33844    TBL_SANITAION_TAX 
   TABLE DATA           �   COPY public."TBL_SANITAION_TAX" ("ID", "FROM_AREA", "TO_AREA", "AMOUNT", "REMARKS", "FISCAL_YEAR", "ACC_ID", "IS_APARTMENT") FROM stdin;
    public          postgres    false    353   �y      	          0    33850    TBL_STATUS_DETAILS 
   TABLE DATA           �   COPY public."TBL_STATUS_DETAILS" ("ID", "MASTERID", "ITEM_ID", "BRAND_ID", "SPEC_ID", "UNIT_ID", "RATE", "STOCK_QTY", "USE_IN_QTY", "NOT_USE_IN_QTY", "REPAIR_QTY", "NOT_REPAIR_QTY") FROM stdin;
    public          postgres    false    354   �y                0    33863    TBL_TAXSOURCERECORDNEW 
   TABLE DATA           �   COPY public."TBL_TAXSOURCERECORDNEW" ("TAXSRCID", "FISCALYEAR", "RECORDTYPE", "NETINCOME_CURFY", "TAXPAIDTAXPAYERCNT_CURFY", "NETINCOME_LASTFY", "TAXPAIDTAXPAYERCNT_LASTFY", "TAXNOTPAIDTAXPAYERCNT", "AMOUNTNOTCOLLECTED", "TOTALTAXPAYERCNT") FROM stdin;
    public          postgres    false    356   z      
          0    33855    TBL_TAX_TYPE 
   TABLE DATA           g   COPY public."TBL_TAX_TYPE" ("ID", "CODE", "NP_NAME", "ENG_NAME", "DESCRIPTIONG", "ACC_ID") FROM stdin;
    public          postgres    false    355   )z                0    33868    TBL_TOLABIKASA_ORG 
   TABLE DATA           �   COPY public."TBL_TOLABIKASA_ORG" ("ID", "NP_NAME", "ENG_NAME", "ADDRESS", "CHAIRMAN", "SACHIBA", "CONTACTNO", "EMAIL", "WARDNO") FROM stdin;
    public          postgres    false    357   Fz                0    33876    TBL_VEHICLE_PARTS 
   TABLE DATA           U   COPY public."TBL_VEHICLE_PARTS" ("SN", "NP_NAME", "ENG_NAME", "REMARKS") FROM stdin;
    public          postgres    false    358   cz                0    33918    TBUSERSECURITYRIGHTS 
   TABLE DATA           F   COPY public."TBUSERSECURITYRIGHTS" ("USERID", "RIGHTSID") FROM stdin;
    public          postgres    false    367   �z                0    33921    TYPES 
   TABLE DATA           P   COPY public."TYPES" ("ID", "NEPNAME", "ENGNAME", "CODE", "REMARKS") FROM stdin;
    public          postgres    false    368   �z                0    33924    USERASSIGNMENTS 
   TABLE DATA           T   COPY public."USERASSIGNMENTS" ("SN", "NEPNAME", "RIGHTSNAME", "MODULE") FROM stdin;
    public          postgres    false    369   �z                0    33927 
   Usermaster 
   TABLE DATA           �  COPY public."Usermaster" ("Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount", "USERID", "USERPASSWORD", "NEPNAME", "ENGNAME", "USERSTATUS", "LASTLOGGEDON", "LASTLOGGEDOUT", "GRANTS", "UPDATEDBY", "EMP_ID", "ORG_CODE", "CODE", "FROM_CENTRAL", "WARD_NO", "PWD_CHANGED_DATE", "FISCAL_YEAR") FROM stdin;
    public          postgres    false    370   �                0    33935    VDC 
   TABLE DATA           i   COPY public."VDC" ("VDCID", "NEPNAME", "ENGNAME", "CODE", "REMARKS", "DISTRICTID", "TYPEID") FROM stdin;
    public          postgres    false    371   ��      {          0    35462    WARD_MASTER 
   TABLE DATA           �   COPY public."WARD_MASTER" ("ID", "NEP_NAME", "ENG_NAME", "ADDRESS", "PRAMUKH_ID", "UPPRAMUKH_ID", "NUMBER_OF_MEMBERS", "WARD_SECRETARY_ID", "MOBILE_NO") FROM stdin;
    public          postgres    false    468   �                0    33938    ZONE 
   TABLE DATA           _   COPY public."ZONE" ("ZONEID", "NEPNAME", "ENGNAME", "CODE", "REMARKS", "REGIONID") FROM stdin;
    public          postgres    false    372   4�      q          0    33014    __EFMigrationsHistory 
   TABLE DATA           R   COPY public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") FROM stdin;
    public          postgres    false    202   Q�      �           0    0    AspNetRoleClaims_Id_seq    SEQUENCE SET     H   SELECT pg_catalog.setval('public."AspNetRoleClaims_Id_seq"', 1, false);
          public          postgres    false    381            �           0    0    AspNetUserClaims_Id_seq    SEQUENCE SET     H   SELECT pg_catalog.setval('public."AspNetUserClaims_Id_seq"', 1, false);
          public          postgres    false    402            E           2606    33119    ACCODE ACCODE_pkey 
   CONSTRAINT     Z   ALTER TABLE ONLY public."ACCODE"
    ADD CONSTRAINT "ACCODE_pkey" PRIMARY KEY ("ACCODE");
 @   ALTER TABLE ONLY public."ACCODE" DROP CONSTRAINT "ACCODE_pkey";
       public            postgres    false    221            D           2606    33994 "   ACC_ACC_MASTER ACC_ACC_MASTER_pkey 
   CONSTRAINT     j   ALTER TABLE ONLY public."ACC_ACC_MASTER"
    ADD CONSTRAINT "ACC_ACC_MASTER_pkey" PRIMARY KEY ("ACC_ID");
 P   ALTER TABLE ONLY public."ACC_ACC_MASTER" DROP CONSTRAINT "ACC_ACC_MASTER_pkey";
       public            postgres    false    377            o           2606    34166 (   ACC_ASULI_BIBARAN ACC_ASULI_BIBARAN_pkey 
   CONSTRAINT     r   ALTER TABLE ONLY public."ACC_ASULI_BIBARAN"
    ADD CONSTRAINT "ACC_ASULI_BIBARAN_pkey" PRIMARY KEY ("ASULI_ID");
 V   ALTER TABLE ONLY public."ACC_ASULI_BIBARAN" DROP CONSTRAINT "ACC_ASULI_BIBARAN_pkey";
       public            postgres    false    391            K           2606    34022 "   ACC_BANK_GRNTY ACC_BANK_GRNTY_pkey 
   CONSTRAINT     l   ALTER TABLE ONLY public."ACC_BANK_GRNTY"
    ADD CONSTRAINT "ACC_BANK_GRNTY_pkey" PRIMARY KEY ("GRNTY_ID");
 P   ALTER TABLE ONLY public."ACC_BANK_GRNTY" DROP CONSTRAINT "ACC_BANK_GRNTY_pkey";
       public            postgres    false    379            N           2606    35055 "   ACC_BANK_TRANS ACC_BANK_TRANS_pkey 
   CONSTRAINT     q   ALTER TABLE ONLY public."ACC_BANK_TRANS"
    ADD CONSTRAINT "ACC_BANK_TRANS_pkey" PRIMARY KEY ("BANK_TRANS_ID");
 P   ALTER TABLE ONLY public."ACC_BANK_TRANS" DROP CONSTRAINT "ACC_BANK_TRANS_pkey";
       public            postgres    false    448            '           2606    33026 &   ACC_BGT_ALLOCATE ACC_BGT_ALLOCATE_pkey 
   CONSTRAINT     w   ALTER TABLE ONLY public."ACC_BGT_ALLOCATE"
    ADD CONSTRAINT "ACC_BGT_ALLOCATE_pkey" PRIMARY KEY ("BGT_ALLOCATE_ID");
 T   ALTER TABLE ONLY public."ACC_BGT_ALLOCATE" DROP CONSTRAINT "ACC_BGT_ALLOCATE_pkey";
       public            postgres    false    204            k           2606    34148 (   ACC_BUDJET_SOURCE ACC_BUDJET_SOURCE_pkey 
   CONSTRAINT     l   ALTER TABLE ONLY public."ACC_BUDJET_SOURCE"
    ADD CONSTRAINT "ACC_BUDJET_SOURCE_pkey" PRIMARY KEY ("ID");
 V   ALTER TABLE ONLY public."ACC_BUDJET_SOURCE" DROP CONSTRAINT "ACC_BUDJET_SOURCE_pkey";
       public            postgres    false    390            S           2606    35077 "   ACC_CASH_TRANS ACC_CASH_TRANS_pkey 
   CONSTRAINT     q   ALTER TABLE ONLY public."ACC_CASH_TRANS"
    ADD CONSTRAINT "ACC_CASH_TRANS_pkey" PRIMARY KEY ("CASH_TRANS_ID");
 P   ALTER TABLE ONLY public."ACC_CASH_TRANS" DROP CONSTRAINT "ACC_CASH_TRANS_pkey";
       public            postgres    false    449            )           2606    33031 &   ACC_CHEQUE_TYPES ACC_CHEQUE_TYPES_pkey 
   CONSTRAINT     v   ALTER TABLE ONLY public."ACC_CHEQUE_TYPES"
    ADD CONSTRAINT "ACC_CHEQUE_TYPES_pkey" PRIMARY KEY ("CHEQUE_TYPE_ID");
 T   ALTER TABLE ONLY public."ACC_CHEQUE_TYPES" DROP CONSTRAINT "ACC_CHEQUE_TYPES_pkey";
       public            postgres    false    205            �           2606    34513 *   ACC_DHRTI_BILL_DTL ACC_DHRTI_BILL_DTL_pkey 
   CONSTRAINT     x   ALTER TABLE ONLY public."ACC_DHRTI_BILL_DTL"
    ADD CONSTRAINT "ACC_DHRTI_BILL_DTL_pkey" PRIMARY KEY ("DHRTI_DTL_ID");
 X   ALTER TABLE ONLY public."ACC_DHRTI_BILL_DTL" DROP CONSTRAINT "ACC_DHRTI_BILL_DTL_pkey";
       public            postgres    false    419            �           2606    34536 0   ACC_DHRTI_BILL_MASTER ACC_DHRTI_BILL_MASTER_pkey 
   CONSTRAINT     �   ALTER TABLE ONLY public."ACC_DHRTI_BILL_MASTER"
    ADD CONSTRAINT "ACC_DHRTI_BILL_MASTER_pkey" PRIMARY KEY ("DHRTI_MASTER_ID");
 ^   ALTER TABLE ONLY public."ACC_DHRTI_BILL_MASTER" DROP CONSTRAINT "ACC_DHRTI_BILL_MASTER_pkey";
       public            postgres    false    420            �           2606    34383 .   ACC_EXPENSES_DETAILS ACC_EXPENSES_DETAILS_pkey 
   CONSTRAINT     z   ALTER TABLE ONLY public."ACC_EXPENSES_DETAILS"
    ADD CONSTRAINT "ACC_EXPENSES_DETAILS_pkey" PRIMARY KEY ("EXPENSE_ID");
 \   ALTER TABLE ONLY public."ACC_EXPENSES_DETAILS" DROP CONSTRAINT "ACC_EXPENSES_DETAILS_pkey";
       public            postgres    false    409            -           2606    33044 0   ACC_FUND_PROVIDR_MSTR ACC_FUND_PROVIDR_MSTR_pkey 
   CONSTRAINT     }   ALTER TABLE ONLY public."ACC_FUND_PROVIDR_MSTR"
    ADD CONSTRAINT "ACC_FUND_PROVIDR_MSTR_pkey" PRIMARY KEY ("PROVIDER_ID");
 ^   ALTER TABLE ONLY public."ACC_FUND_PROVIDR_MSTR" DROP CONSTRAINT "ACC_FUND_PROVIDR_MSTR_pkey";
       public            postgres    false    207            /           2606    33049 $   ACC_INCOME_RATE ACC_INCOME_RATE_pkey 
   CONSTRAINT     m   ALTER TABLE ONLY public."ACC_INCOME_RATE"
    ADD CONSTRAINT "ACC_INCOME_RATE_pkey" PRIMARY KEY ("RATE_ID");
 R   ALTER TABLE ONLY public."ACC_INCOME_RATE" DROP CONSTRAINT "ACC_INCOME_RATE_pkey";
       public            postgres    false    208            1           2606    33054 (   ACC_LAST_YR_PESKI ACC_LAST_YR_PESKI_pkey 
   CONSTRAINT     l   ALTER TABLE ONLY public."ACC_LAST_YR_PESKI"
    ADD CONSTRAINT "ACC_LAST_YR_PESKI_pkey" PRIMARY KEY ("SN");
 V   ALTER TABLE ONLY public."ACC_LAST_YR_PESKI" DROP CONSTRAINT "ACC_LAST_YR_PESKI_pkey";
       public            postgres    false    209            5           2606    33067 "   ACC_ORG_MASTER ACC_ORG_MASTER_pkey 
   CONSTRAINT     j   ALTER TABLE ONLY public."ACC_ORG_MASTER"
    ADD CONSTRAINT "ACC_ORG_MASTER_pkey" PRIMARY KEY ("ORG_ID");
 P   ALTER TABLE ONLY public."ACC_ORG_MASTER" DROP CONSTRAINT "ACC_ORG_MASTER_pkey";
       public            postgres    false    211            A           2606    33981 .   ACC_PADADHIKARI_MSTR ACC_PADADHIKARI_MSTR_pkey 
   CONSTRAINT     }   ALTER TABLE ONLY public."ACC_PADADHIKARI_MSTR"
    ADD CONSTRAINT "ACC_PADADHIKARI_MSTR_pkey" PRIMARY KEY ("PADADIKARI_ID");
 \   ALTER TABLE ONLY public."ACC_PADADHIKARI_MSTR" DROP CONSTRAINT "ACC_PADADHIKARI_MSTR_pkey";
       public            postgres    false    376            7           2606    33072 .   ACC_PADADHIKARI_POST ACC_PADADHIKARI_POST_pkey 
   CONSTRAINT     w   ALTER TABLE ONLY public."ACC_PADADHIKARI_POST"
    ADD CONSTRAINT "ACC_PADADHIKARI_POST_pkey" PRIMARY KEY ("POST_ID");
 \   ALTER TABLE ONLY public."ACC_PADADHIKARI_POST" DROP CONSTRAINT "ACC_PADADHIKARI_POST_pkey";
       public            postgres    false    212            E           2606    35013 ,   ACC_PAYMENT_DETAILS ACC_PAYMENT_DETAILS_pkey 
   CONSTRAINT        ALTER TABLE ONLY public."ACC_PAYMENT_DETAILS"
    ADD CONSTRAINT "ACC_PAYMENT_DETAILS_pkey" PRIMARY KEY ("PAYMENT_DETAIL_ID");
 Z   ALTER TABLE ONLY public."ACC_PAYMENT_DETAILS" DROP CONSTRAINT "ACC_PAYMENT_DETAILS_pkey";
       public            postgres    false    447            �           2606    34561 *   ACC_PAYMENT_MASTER ACC_PAYMENT_MASTER_pkey 
   CONSTRAINT     v   ALTER TABLE ONLY public."ACC_PAYMENT_MASTER"
    ADD CONSTRAINT "ACC_PAYMENT_MASTER_pkey" PRIMARY KEY ("PAYMENT_ID");
 X   ALTER TABLE ONLY public."ACC_PAYMENT_MASTER" DROP CONSTRAINT "ACC_PAYMENT_MASTER_pkey";
       public            postgres    false    421            9           2606    33083 ,   ACC_SUB_MODULE_TYPE ACC_SUB_MODULE_TYPE_pkey 
   CONSTRAINT     {   ALTER TABLE ONLY public."ACC_SUB_MODULE_TYPE"
    ADD CONSTRAINT "ACC_SUB_MODULE_TYPE_pkey" PRIMARY KEY ("SUB_MODULE_ID");
 Z   ALTER TABLE ONLY public."ACC_SUB_MODULE_TYPE" DROP CONSTRAINT "ACC_SUB_MODULE_TYPE_pkey";
       public            postgres    false    215            ;           2606    33088 "   ACC_TRANS_TYPE ACC_TRANS_TYPE_pkey 
   CONSTRAINT     k   ALTER TABLE ONLY public."ACC_TRANS_TYPE"
    ADD CONSTRAINT "ACC_TRANS_TYPE_pkey" PRIMARY KEY ("TYPE_ID");
 P   ALTER TABLE ONLY public."ACC_TRANS_TYPE" DROP CONSTRAINT "ACC_TRANS_TYPE_pkey";
       public            postgres    false    216            =           2606    33093 &   ACC_UNAUTHORISED ACC_UNAUTHORISED_pkey 
   CONSTRAINT     w   ALTER TABLE ONLY public."ACC_UNAUTHORISED"
    ADD CONSTRAINT "ACC_UNAUTHORISED_pkey" PRIMARY KEY ("UNAUTHORISED_ID");
 T   ALTER TABLE ONLY public."ACC_UNAUTHORISED" DROP CONSTRAINT "ACC_UNAUTHORISED_pkey";
       public            postgres    false    217            �           2606    34593 &   ACC_VCHR_DETAILS ACC_VCHR_DETAILS_pkey 
   CONSTRAINT     v   ALTER TABLE ONLY public."ACC_VCHR_DETAILS"
    ADD CONSTRAINT "ACC_VCHR_DETAILS_pkey" PRIMARY KEY ("VCHR_DETAIL_ID");
 T   ALTER TABLE ONLY public."ACC_VCHR_DETAILS" DROP CONSTRAINT "ACC_VCHR_DETAILS_pkey";
       public            postgres    false    422            G           2606    34007 $   ACC_VCHR_MASTER ACC_VCHR_MASTER_pkey 
   CONSTRAINT     m   ALTER TABLE ONLY public."ACC_VCHR_MASTER"
    ADD CONSTRAINT "ACC_VCHR_MASTER_pkey" PRIMARY KEY ("VCHR_ID");
 R   ALTER TABLE ONLY public."ACC_VCHR_MASTER" DROP CONSTRAINT "ACC_VCHR_MASTER_pkey";
       public            postgres    false    378            A           2606    33106 .   ACC_VCHR_TYPE_MASTER ACC_VCHR_TYPE_MASTER_pkey 
   CONSTRAINT     |   ALTER TABLE ONLY public."ACC_VCHR_TYPE_MASTER"
    ADD CONSTRAINT "ACC_VCHR_TYPE_MASTER_pkey" PRIMARY KEY ("VCHR_TYPE_ID");
 \   ALTER TABLE ONLY public."ACC_VCHR_TYPE_MASTER" DROP CONSTRAINT "ACC_VCHR_TYPE_MASTER_pkey";
       public            postgres    false    219            O           2606    34037 0   ACC_WORK_FUNDS_DETAIL ACC_WORK_FUNDS_DETAIL_pkey 
   CONSTRAINT     �   ALTER TABLE ONLY public."ACC_WORK_FUNDS_DETAIL"
    ADD CONSTRAINT "ACC_WORK_FUNDS_DETAIL_pkey" PRIMARY KEY ("FUND_DETAIL_ID");
 ^   ALTER TABLE ONLY public."ACC_WORK_FUNDS_DETAIL" DROP CONSTRAINT "ACC_WORK_FUNDS_DETAIL_pkey";
       public            postgres    false    380            C           2606    33114 $   ACC_WORK_MASTER ACC_WORK_MASTER_pkey 
   CONSTRAINT     m   ALTER TABLE ONLY public."ACC_WORK_MASTER"
    ADD CONSTRAINT "ACC_WORK_MASTER_pkey" PRIMARY KEY ("WORK_ID");
 R   ALTER TABLE ONLY public."ACC_WORK_MASTER" DROP CONSTRAINT "ACC_WORK_MASTER_pkey";
       public            postgres    false    220            �           2606    34623 0   ACC_WORK_PAYMNT_TRANS ACC_WORK_PAYMNT_TRANS_pkey 
   CONSTRAINT     z   ALTER TABLE ONLY public."ACC_WORK_PAYMNT_TRANS"
    ADD CONSTRAINT "ACC_WORK_PAYMNT_TRANS_pkey" PRIMARY KEY ("TRANS_ID");
 ^   ALTER TABLE ONLY public."ACC_WORK_PAYMNT_TRANS" DROP CONSTRAINT "ACC_WORK_PAYMNT_TRANS_pkey";
       public            postgres    false    423            G           2606    33124 8   APPLICATION_CONFIGURATION APPLICATION_CONFIGURATION_pkey 
   CONSTRAINT     |   ALTER TABLE ONLY public."APPLICATION_CONFIGURATION"
    ADD CONSTRAINT "APPLICATION_CONFIGURATION_pkey" PRIMARY KEY ("SN");
 f   ALTER TABLE ONLY public."APPLICATION_CONFIGURATION" DROP CONSTRAINT "APPLICATION_CONFIGURATION_pkey";
       public            postgres    false    222            L           2606    33140    BANKMASTER BANKMASTER_pkey 
   CONSTRAINT     b   ALTER TABLE ONLY public."BANKMASTER"
    ADD CONSTRAINT "BANKMASTER_pkey" PRIMARY KEY ("BANKID");
 H   ALTER TABLE ONLY public."BANKMASTER" DROP CONSTRAINT "BANKMASTER_pkey";
       public            postgres    false    224            6           2606    34948 &   BANKTRANSACTIONS BANKTRANSACTIONS_pkey 
   CONSTRAINT     j   ALTER TABLE ONLY public."BANKTRANSACTIONS"
    ADD CONSTRAINT "BANKTRANSACTIONS_pkey" PRIMARY KEY ("SN");
 T   ALTER TABLE ONLY public."BANKTRANSACTIONS" DROP CONSTRAINT "BANKTRANSACTIONS_pkey";
       public            postgres    false    444            V           2606    34070    BANK_BRANCH BANK_BRANCH_pkey 
   CONSTRAINT     g   ALTER TABLE ONLY public."BANK_BRANCH"
    ADD CONSTRAINT "BANK_BRANCH_pkey" PRIMARY KEY ("BRANCH_ID");
 J   ALTER TABLE ONLY public."BANK_BRANCH" DROP CONSTRAINT "BANK_BRANCH_pkey";
       public            postgres    false    383            ;           2606    34971 $   CASHTRANSACTION CASHTRANSACTION_pkey 
   CONSTRAINT     h   ALTER TABLE ONLY public."CASHTRANSACTION"
    ADD CONSTRAINT "CASHTRANSACTION_pkey" PRIMARY KEY ("SN");
 R   ALTER TABLE ONLY public."CASHTRANSACTION" DROP CONSTRAINT "CASHTRANSACTION_pkey";
       public            postgres    false    445            Q           2606    33165 *   COLLECTIONCOUNTERS COLLECTIONCOUNTERS_pkey 
   CONSTRAINT     u   ALTER TABLE ONLY public."COLLECTIONCOUNTERS"
    ADD CONSTRAINT "COLLECTIONCOUNTERS_pkey" PRIMARY KEY ("COUNTERID");
 X   ALTER TABLE ONLY public."COLLECTIONCOUNTERS" DROP CONSTRAINT "COLLECTIONCOUNTERS_pkey";
       public            postgres    false    229            �           2606    34643 (   INCOMEBILLDETAILS INCOMEBILLDETAILS_pkey 
   CONSTRAINT     l   ALTER TABLE ONLY public."INCOMEBILLDETAILS"
    ADD CONSTRAINT "INCOMEBILLDETAILS_pkey" PRIMARY KEY ("SN");
 V   ALTER TABLE ONLY public."INCOMEBILLDETAILS" DROP CONSTRAINT "INCOMEBILLDETAILS_pkey";
       public            postgres    false    424            �           2606    34661 &   INCOMEBILLMASTER INCOMEBILLMASTER_pkey 
   CONSTRAINT     j   ALTER TABLE ONLY public."INCOMEBILLMASTER"
    ADD CONSTRAINT "INCOMEBILLMASTER_pkey" PRIMARY KEY ("SN");
 T   ALTER TABLE ONLY public."INCOMEBILLMASTER" DROP CONSTRAINT "INCOMEBILLMASTER_pkey";
       public            postgres    false    425            [           2606    33223    INV_BRAND INV_BRAND_pkey 
   CONSTRAINT     b   ALTER TABLE ONLY public."INV_BRAND"
    ADD CONSTRAINT "INV_BRAND_pkey" PRIMARY KEY ("BRAND_ID");
 F   ALTER TABLE ONLY public."INV_BRAND" DROP CONSTRAINT "INV_BRAND_pkey";
       public            postgres    false    242            a           2606    33238    INV_DEPT INV_DEPT_pkey 
   CONSTRAINT     _   ALTER TABLE ONLY public."INV_DEPT"
    ADD CONSTRAINT "INV_DEPT_pkey" PRIMARY KEY ("DEPT_ID");
 D   ALTER TABLE ONLY public."INV_DEPT" DROP CONSTRAINT "INV_DEPT_pkey";
       public            postgres    false    245            �           2606    35622 &   INV_ITEM_DETAILS INV_ITEM_DETAILS_pkey 
   CONSTRAINT     s   ALTER TABLE ONLY public."INV_ITEM_DETAILS"
    ADD CONSTRAINT "INV_ITEM_DETAILS_pkey" PRIMARY KEY ("ITEM_DTL_ID");
 T   ALTER TABLE ONLY public."INV_ITEM_DETAILS" DROP CONSTRAINT "INV_ITEM_DETAILS_pkey";
       public            postgres    false    476            b           2606    34118    INV_ITEM_MST INV_ITEM_MST_pkey 
   CONSTRAINT     g   ALTER TABLE ONLY public."INV_ITEM_MST"
    ADD CONSTRAINT "INV_ITEM_MST_pkey" PRIMARY KEY ("ITEM_ID");
 L   ALTER TABLE ONLY public."INV_ITEM_MST" DROP CONSTRAINT "INV_ITEM_MST_pkey";
       public            postgres    false    387            k           2606    33266     INV_ITEM_SPEC INV_ITEM_SPEC_pkey 
   CONSTRAINT     i   ALTER TABLE ONLY public."INV_ITEM_SPEC"
    ADD CONSTRAINT "INV_ITEM_SPEC_pkey" PRIMARY KEY ("SPEC_ID");
 N   ALTER TABLE ONLY public."INV_ITEM_SPEC" DROP CONSTRAINT "INV_ITEM_SPEC_pkey";
       public            postgres    false    250            u           2606    33300    INV_PROJECT INV_PROJECT_pkey 
   CONSTRAINT     h   ALTER TABLE ONLY public."INV_PROJECT"
    ADD CONSTRAINT "INV_PROJECT_pkey" PRIMARY KEY ("PROJECT_ID");
 J   ALTER TABLE ONLY public."INV_PROJECT" DROP CONSTRAINT "INV_PROJECT_pkey";
       public            postgres    false    256            \           2606    34095    INV_ROOM_MST INV_ROOM_MST_pkey 
   CONSTRAINT     g   ALTER TABLE ONLY public."INV_ROOM_MST"
    ADD CONSTRAINT "INV_ROOM_MST_pkey" PRIMARY KEY ("ROOM_ID");
 L   ALTER TABLE ONLY public."INV_ROOM_MST" DROP CONSTRAINT "INV_ROOM_MST_pkey";
       public            postgres    false    385            {           2606    33321    INV_SUPPLIER INV_SUPPLIER_pkey 
   CONSTRAINT     f   ALTER TABLE ONLY public."INV_SUPPLIER"
    ADD CONSTRAINT "INV_SUPPLIER_pkey" PRIMARY KEY ("SUP_ID");
 L   ALTER TABLE ONLY public."INV_SUPPLIER" DROP CONSTRAINT "INV_SUPPLIER_pkey";
       public            postgres    false    260                       2606    33331    INV_TAX_RATE INV_TAX_RATE_pkey 
   CONSTRAINT     k   ALTER TABLE ONLY public."INV_TAX_RATE"
    ADD CONSTRAINT "INV_TAX_RATE_pkey" PRIMARY KEY ("TAX_RATE_ID");
 L   ALTER TABLE ONLY public."INV_TAX_RATE" DROP CONSTRAINT "INV_TAX_RATE_pkey";
       public            postgres    false    262            �           2606    33341    INV_UNIT INV_UNIT_pkey 
   CONSTRAINT     _   ALTER TABLE ONLY public."INV_UNIT"
    ADD CONSTRAINT "INV_UNIT_pkey" PRIMARY KEY ("UNIT_ID");
 D   ALTER TABLE ONLY public."INV_UNIT" DROP CONSTRAINT "INV_UNIT_pkey";
       public            postgres    false    264            �           2606    33346     INV_WAREHOUSE INV_WAREHOUSE_pkey 
   CONSTRAINT     n   ALTER TABLE ONLY public."INV_WAREHOUSE"
    ADD CONSTRAINT "INV_WAREHOUSE_pkey" PRIMARY KEY ("WAREHOUSE_ID");
 N   ALTER TABLE ONLY public."INV_WAREHOUSE" DROP CONSTRAINT "INV_WAREHOUSE_pkey";
       public            postgres    false    265            �           2606    33415 "   MAP_HTSTANDARD MAP_HTSTANDARD_pkey 
   CONSTRAINT     f   ALTER TABLE ONLY public."MAP_HTSTANDARD"
    ADD CONSTRAINT "MAP_HTSTANDARD_pkey" PRIMARY KEY ("SN");
 P   ALTER TABLE ONLY public."MAP_HTSTANDARD" DROP CONSTRAINT "MAP_HTSTANDARD_pkey";
       public            postgres    false    279            �           2606    33445    MAP_SITE MAP_SITE_pkey 
   CONSTRAINT     Z   ALTER TABLE ONLY public."MAP_SITE"
    ADD CONSTRAINT "MAP_SITE_pkey" PRIMARY KEY ("SN");
 D   ALTER TABLE ONLY public."MAP_SITE" DROP CONSTRAINT "MAP_SITE_pkey";
       public            postgres    false    285            �           2606    33484 0   NEW_PROPERTY_TAXTABLE NEW_PROPERTY_TAXTABLE_pkey 
   CONSTRAINT     t   ALTER TABLE ONLY public."NEW_PROPERTY_TAXTABLE"
    ADD CONSTRAINT "NEW_PROPERTY_TAXTABLE_pkey" PRIMARY KEY ("SN");
 ^   ALTER TABLE ONLY public."NEW_PROPERTY_TAXTABLE" DROP CONSTRAINT "NEW_PROPERTY_TAXTABLE_pkey";
       public            postgres    false    293            �           2606    33494 ,   PAYMENT_SLIP_MASTER PAYMENT_SLIP_MASTER_pkey 
   CONSTRAINT     }   ALTER TABLE ONLY public."PAYMENT_SLIP_MASTER"
    ADD CONSTRAINT "PAYMENT_SLIP_MASTER_pkey" PRIMARY KEY ("PAYMENT_SLIP_ID");
 Z   ALTER TABLE ONLY public."PAYMENT_SLIP_MASTER" DROP CONSTRAINT "PAYMENT_SLIP_MASTER_pkey";
       public            postgres    false    295            �           2606    33502 *   PERSON_TYPE_MASTER PERSON_TYPE_MASTER_pkey 
   CONSTRAINT     z   ALTER TABLE ONLY public."PERSON_TYPE_MASTER"
    ADD CONSTRAINT "PERSON_TYPE_MASTER_pkey" PRIMARY KEY ("PERSON_TYPE_ID");
 X   ALTER TABLE ONLY public."PERSON_TYPE_MASTER" DROP CONSTRAINT "PERSON_TYPE_MASTER_pkey";
       public            postgres    false    296            �           2606    34726    PIS_AWARDS PIS_AWARDS_pkey 
   CONSTRAINT     ^   ALTER TABLE ONLY public."PIS_AWARDS"
    ADD CONSTRAINT "PIS_AWARDS_pkey" PRIMARY KEY ("SN");
 H   ALTER TABLE ONLY public."PIS_AWARDS" DROP CONSTRAINT "PIS_AWARDS_pkey";
       public            postgres    false    428            �           2606    35286 &   PIS_BANK_PAYROLL PIS_BANK_PAYROLL_pkey 
   CONSTRAINT     j   ALTER TABLE ONLY public."PIS_BANK_PAYROLL"
    ADD CONSTRAINT "PIS_BANK_PAYROLL_pkey" PRIMARY KEY ("SN");
 T   ALTER TABLE ONLY public."PIS_BANK_PAYROLL" DROP CONSTRAINT "PIS_BANK_PAYROLL_pkey";
       public            postgres    false    457                       2606    34736    PIS_DARBANDI PIS_DARBANDI_pkey 
   CONSTRAINT     k   ALTER TABLE ONLY public."PIS_DARBANDI"
    ADD CONSTRAINT "PIS_DARBANDI_pkey" PRIMARY KEY ("DARBANDI_ID");
 L   ALTER TABLE ONLY public."PIS_DARBANDI" DROP CONSTRAINT "PIS_DARBANDI_pkey";
       public            postgres    false    429            �           2606    35546 <   PIS_DELETD_FRM_FULFILD_DARB PIS_DELETD_FRM_FULFILD_DARB_pkey 
   CONSTRAINT     �   ALTER TABLE ONLY public."PIS_DELETD_FRM_FULFILD_DARB"
    ADD CONSTRAINT "PIS_DELETD_FRM_FULFILD_DARB_pkey" PRIMARY KEY ("SN");
 j   ALTER TABLE ONLY public."PIS_DELETD_FRM_FULFILD_DARB" DROP CONSTRAINT "PIS_DELETD_FRM_FULFILD_DARB_pkey";
       public            postgres    false    473            t           2606    34176     PIS_EDUCATION PIS_EDUCATION_pkey 
   CONSTRAINT     d   ALTER TABLE ONLY public."PIS_EDUCATION"
    ADD CONSTRAINT "PIS_EDUCATION_pkey" PRIMARY KEY ("SN");
 N   ALTER TABLE ONLY public."PIS_EDUCATION" DROP CONSTRAINT "PIS_EDUCATION_pkey";
       public            postgres    false    392            �           2606    33522     PIS_EDU_LEVEL PIS_EDU_LEVEL_pkey 
   CONSTRAINT     h   ALTER TABLE ONLY public."PIS_EDU_LEVEL"
    ADD CONSTRAINT "PIS_EDU_LEVEL_pkey" PRIMARY KEY ("EDU_ID");
 N   ALTER TABLE ONLY public."PIS_EDU_LEVEL" DROP CONSTRAINT "PIS_EDU_LEVEL_pkey";
       public            postgres    false    300            	           2606    34759 ,   PIS_EMPLOYEE_MASTER PIS_EMPLOYEE_MASTER_pkey 
   CONSTRAINT     t   ALTER TABLE ONLY public."PIS_EMPLOYEE_MASTER"
    ADD CONSTRAINT "PIS_EMPLOYEE_MASTER_pkey" PRIMARY KEY ("EMP_ID");
 Z   ALTER TABLE ONLY public."PIS_EMPLOYEE_MASTER" DROP CONSTRAINT "PIS_EMPLOYEE_MASTER_pkey";
       public            postgres    false    430            w           2606    34191 *   PIS_EMP_DEP_SOURCE PIS_EMP_DEP_SOURCE_pkey 
   CONSTRAINT     s   ALTER TABLE ONLY public."PIS_EMP_DEP_SOURCE"
    ADD CONSTRAINT "PIS_EMP_DEP_SOURCE_pkey" PRIMARY KEY ("DEPT_ID");
 X   ALTER TABLE ONLY public."PIS_EMP_DEP_SOURCE" DROP CONSTRAINT "PIS_EMP_DEP_SOURCE_pkey";
       public            postgres    false    393            �           2606    33532    PIS_EMP_DEP PIS_EMP_DEP_pkey 
   CONSTRAINT     e   ALTER TABLE ONLY public."PIS_EMP_DEP"
    ADD CONSTRAINT "PIS_EMP_DEP_pkey" PRIMARY KEY ("DEPT_ID");
 J   ALTER TABLE ONLY public."PIS_EMP_DEP" DROP CONSTRAINT "PIS_EMP_DEP_pkey";
       public            postgres    false    302            �           2606    35311     PIS_EMP_LOANS PIS_EMP_LOANS_pkey 
   CONSTRAINT     i   ALTER TABLE ONLY public."PIS_EMP_LOANS"
    ADD CONSTRAINT "PIS_EMP_LOANS_pkey" PRIMARY KEY ("LOAN_ID");
 N   ALTER TABLE ONLY public."PIS_EMP_LOANS" DROP CONSTRAINT "PIS_EMP_LOANS_pkey";
       public            postgres    false    459            �           2606    35321 ,   PIS_EMP_LONG_LEAVES PIS_EMP_LONG_LEAVES_pkey 
   CONSTRAINT     p   ALTER TABLE ONLY public."PIS_EMP_LONG_LEAVES"
    ADD CONSTRAINT "PIS_EMP_LONG_LEAVES_pkey" PRIMARY KEY ("SN");
 Z   ALTER TABLE ONLY public."PIS_EMP_LONG_LEAVES" DROP CONSTRAINT "PIS_EMP_LONG_LEAVES_pkey";
       public            postgres    false    460            �           2606    35336 ,   PIS_EMP_MED_EXPENSE PIS_EMP_MED_EXPENSE_pkey 
   CONSTRAINT     p   ALTER TABLE ONLY public."PIS_EMP_MED_EXPENSE"
    ADD CONSTRAINT "PIS_EMP_MED_EXPENSE_pkey" PRIMARY KEY ("SN");
 Z   ALTER TABLE ONLY public."PIS_EMP_MED_EXPENSE" DROP CONSTRAINT "PIS_EMP_MED_EXPENSE_pkey";
       public            postgres    false    461            �           2606    35351 *   PIS_EMP_PUNISHMNTS PIS_EMP_PUNISHMNTS_pkey 
   CONSTRAINT     n   ALTER TABLE ONLY public."PIS_EMP_PUNISHMNTS"
    ADD CONSTRAINT "PIS_EMP_PUNISHMNTS_pkey" PRIMARY KEY ("SN");
 X   ALTER TABLE ONLY public."PIS_EMP_PUNISHMNTS" DROP CONSTRAINT "PIS_EMP_PUNISHMNTS_pkey";
       public            postgres    false    462            �           2606    35366 (   PIS_EMP_SRVC_DTLS PIS_EMP_SRVC_DTLS_pkey 
   CONSTRAINT     l   ALTER TABLE ONLY public."PIS_EMP_SRVC_DTLS"
    ADD CONSTRAINT "PIS_EMP_SRVC_DTLS_pkey" PRIMARY KEY ("SN");
 V   ALTER TABLE ONLY public."PIS_EMP_SRVC_DTLS" DROP CONSTRAINT "PIS_EMP_SRVC_DTLS_pkey";
       public            postgres    false    463            �           2606    35381 &   PIS_EMP_SUSPENDS PIS_EMP_SUSPENDS_pkey 
   CONSTRAINT     j   ALTER TABLE ONLY public."PIS_EMP_SUSPENDS"
    ADD CONSTRAINT "PIS_EMP_SUSPENDS_pkey" PRIMARY KEY ("SN");
 T   ALTER TABLE ONLY public."PIS_EMP_SUSPENDS" DROP CONSTRAINT "PIS_EMP_SUSPENDS_pkey";
       public            postgres    false    464            �           2606    35396 *   PIS_EMP_TRNSFR_REC PIS_EMP_TRNSFR_REC_pkey 
   CONSTRAINT     n   ALTER TABLE ONLY public."PIS_EMP_TRNSFR_REC"
    ADD CONSTRAINT "PIS_EMP_TRNSFR_REC_pkey" PRIMARY KEY ("SN");
 X   ALTER TABLE ONLY public."PIS_EMP_TRNSFR_REC" DROP CONSTRAINT "PIS_EMP_TRNSFR_REC_pkey";
       public            postgres    false    465                       2606    34789 *   PIS_FOREIGN_VISITS PIS_FOREIGN_VISITS_pkey 
   CONSTRAINT     n   ALTER TABLE ONLY public."PIS_FOREIGN_VISITS"
    ADD CONSTRAINT "PIS_FOREIGN_VISITS_pkey" PRIMARY KEY ("SN");
 X   ALTER TABLE ONLY public."PIS_FOREIGN_VISITS" DROP CONSTRAINT "PIS_FOREIGN_VISITS_pkey";
       public            postgres    false    431            Z           2606    35092 2   PIS_FULFILLED_DARBANDI PIS_FULFILLED_DARBANDI_pkey 
   CONSTRAINT     v   ALTER TABLE ONLY public."PIS_FULFILLED_DARBANDI"
    ADD CONSTRAINT "PIS_FULFILLED_DARBANDI_pkey" PRIMARY KEY ("SN");
 `   ALTER TABLE ONLY public."PIS_FULFILLED_DARBANDI" DROP CONSTRAINT "PIS_FULFILLED_DARBANDI_pkey";
       public            postgres    false    450            �           2606    33553    PIS_HAJIRI PIS_HAJIRI_pkey 
   CONSTRAINT     ^   ALTER TABLE ONLY public."PIS_HAJIRI"
    ADD CONSTRAINT "PIS_HAJIRI_pkey" PRIMARY KEY ("SN");
 H   ALTER TABLE ONLY public."PIS_HAJIRI" DROP CONSTRAINT "PIS_HAJIRI_pkey";
       public            postgres    false    305            �           2606    35411 0   PIS_INTERNAL_TRANSFER PIS_INTERNAL_TRANSFER_pkey 
   CONSTRAINT     t   ALTER TABLE ONLY public."PIS_INTERNAL_TRANSFER"
    ADD CONSTRAINT "PIS_INTERNAL_TRANSFER_pkey" PRIMARY KEY ("SN");
 ^   ALTER TABLE ONLY public."PIS_INTERNAL_TRANSFER" DROP CONSTRAINT "PIS_INTERNAL_TRANSFER_pkey";
       public            postgres    false    466            �           2606    33561 $   PIS_LAND_BLDNGS PIS_LAND_BLDNGS_pkey 
   CONSTRAINT     h   ALTER TABLE ONLY public."PIS_LAND_BLDNGS"
    ADD CONSTRAINT "PIS_LAND_BLDNGS_pkey" PRIMARY KEY ("SN");
 R   ALTER TABLE ONLY public."PIS_LAND_BLDNGS" DROP CONSTRAINT "PIS_LAND_BLDNGS_pkey";
       public            postgres    false    306            �           2606    33569 .   PIS_LOAN_DHITO_GIVEN PIS_LOAN_DHITO_GIVEN_pkey 
   CONSTRAINT     r   ALTER TABLE ONLY public."PIS_LOAN_DHITO_GIVEN"
    ADD CONSTRAINT "PIS_LOAN_DHITO_GIVEN_pkey" PRIMARY KEY ("SN");
 \   ALTER TABLE ONLY public."PIS_LOAN_DHITO_GIVEN" DROP CONSTRAINT "PIS_LOAN_DHITO_GIVEN_pkey";
       public            postgres    false    307            �           2606    33577 .   PIS_LOAN_DHITO_TAKEN PIS_LOAN_DHITO_TAKEN_pkey 
   CONSTRAINT     r   ALTER TABLE ONLY public."PIS_LOAN_DHITO_TAKEN"
    ADD CONSTRAINT "PIS_LOAN_DHITO_TAKEN_pkey" PRIMARY KEY ("SN");
 \   ALTER TABLE ONLY public."PIS_LOAN_DHITO_TAKEN" DROP CONSTRAINT "PIS_LOAN_DHITO_TAKEN_pkey";
       public            postgres    false    308            ~           2606    34224 0   PIS_LOCAL_POST_MASTER PIS_LOCAL_POST_MASTER_pkey 
   CONSTRAINT        ALTER TABLE ONLY public."PIS_LOCAL_POST_MASTER"
    ADD CONSTRAINT "PIS_LOCAL_POST_MASTER_pkey" PRIMARY KEY ("LOCAL_POST_ID");
 ^   ALTER TABLE ONLY public."PIS_LOCAL_POST_MASTER" DROP CONSTRAINT "PIS_LOCAL_POST_MASTER_pkey";
       public            postgres    false    395            �           2606    33592     PIS_ORNAMENTS PIS_ORNAMENTS_pkey 
   CONSTRAINT     d   ALTER TABLE ONLY public."PIS_ORNAMENTS"
    ADD CONSTRAINT "PIS_ORNAMENTS_pkey" PRIMARY KEY ("SN");
 N   ALTER TABLE ONLY public."PIS_ORNAMENTS" DROP CONSTRAINT "PIS_ORNAMENTS_pkey";
       public            postgres    false    310            �           2606    33605 ,   PIS_PD_ORG_INVLVMNT PIS_PD_ORG_INVLVMNT_pkey 
   CONSTRAINT     p   ALTER TABLE ONLY public."PIS_PD_ORG_INVLVMNT"
    ADD CONSTRAINT "PIS_PD_ORG_INVLVMNT_pkey" PRIMARY KEY ("SN");
 Z   ALTER TABLE ONLY public."PIS_PD_ORG_INVLVMNT" DROP CONSTRAINT "PIS_PD_ORG_INVLVMNT_pkey";
       public            postgres    false    312            �           2606    33610 &   PIS_PD_SRVC_DTLS PIS_PD_SRVC_DTLS_pkey 
   CONSTRAINT     j   ALTER TABLE ONLY public."PIS_PD_SRVC_DTLS"
    ADD CONSTRAINT "PIS_PD_SRVC_DTLS_pkey" PRIMARY KEY ("SN");
 T   ALTER TABLE ONLY public."PIS_PD_SRVC_DTLS" DROP CONSTRAINT "PIS_PD_SRVC_DTLS_pkey";
       public            postgres    false    313            �           2606    33618 2   PIS_PERSON_VISIT_RECRD PIS_PERSON_VISIT_RECRD_pkey 
   CONSTRAINT     v   ALTER TABLE ONLY public."PIS_PERSON_VISIT_RECRD"
    ADD CONSTRAINT "PIS_PERSON_VISIT_RECRD_pkey" PRIMARY KEY ("SN");
 `   ALTER TABLE ONLY public."PIS_PERSON_VISIT_RECRD" DROP CONSTRAINT "PIS_PERSON_VISIT_RECRD_pkey";
       public            postgres    false    314            �           2606    33623 $   PIS_POST_MASTER PIS_POST_MASTER_pkey 
   CONSTRAINT     m   ALTER TABLE ONLY public."PIS_POST_MASTER"
    ADD CONSTRAINT "PIS_POST_MASTER_pkey" PRIMARY KEY ("POST_ID");
 R   ALTER TABLE ONLY public."PIS_POST_MASTER" DROP CONSTRAINT "PIS_POST_MASTER_pkey";
       public            postgres    false    315                       2606    34809    PIS_PRIZES PIS_PRIZES_pkey 
   CONSTRAINT     ^   ALTER TABLE ONLY public."PIS_PRIZES"
    ADD CONSTRAINT "PIS_PRIZES_pkey" PRIMARY KEY ("SN");
 H   ALTER TABLE ONLY public."PIS_PRIZES" DROP CONSTRAINT "PIS_PRIZES_pkey";
       public            postgres    false    433                       2606    34819 $   PIS_PUBLICATION PIS_PUBLICATION_pkey 
   CONSTRAINT     h   ALTER TABLE ONLY public."PIS_PUBLICATION"
    ADD CONSTRAINT "PIS_PUBLICATION_pkey" PRIMARY KEY ("SN");
 R   ALTER TABLE ONLY public."PIS_PUBLICATION" DROP CONSTRAINT "PIS_PUBLICATION_pkey";
       public            postgres    false    434            �           2606    35571 6   PIS_REPLACED_IN_DARBANDI PIS_REPLACED_IN_DARBANDI_pkey 
   CONSTRAINT     z   ALTER TABLE ONLY public."PIS_REPLACED_IN_DARBANDI"
    ADD CONSTRAINT "PIS_REPLACED_IN_DARBANDI_pkey" PRIMARY KEY ("SN");
 d   ALTER TABLE ONLY public."PIS_REPLACED_IN_DARBANDI" DROP CONSTRAINT "PIS_REPLACED_IN_DARBANDI_pkey";
       public            postgres    false    474                       2606    34829 &   PIS_SGNFCNT_WORK PIS_SGNFCNT_WORK_pkey 
   CONSTRAINT     j   ALTER TABLE ONLY public."PIS_SGNFCNT_WORK"
    ADD CONSTRAINT "PIS_SGNFCNT_WORK_pkey" PRIMARY KEY ("SN");
 T   ALTER TABLE ONLY public."PIS_SGNFCNT_WORK" DROP CONSTRAINT "PIS_SGNFCNT_WORK_pkey";
       public            postgres    false    435            �           2606    33636 0   PIS_SHARE_BANKBALANCE PIS_SHARE_BANKBALANCE_pkey 
   CONSTRAINT     t   ALTER TABLE ONLY public."PIS_SHARE_BANKBALANCE"
    ADD CONSTRAINT "PIS_SHARE_BANKBALANCE_pkey" PRIMARY KEY ("SN");
 ^   ALTER TABLE ONLY public."PIS_SHARE_BANKBALANCE" DROP CONSTRAINT "PIS_SHARE_BANKBALANCE_pkey";
       public            postgres    false    317                       2606    34839    PIS_TRAINING PIS_TRAINING_pkey 
   CONSTRAINT     b   ALTER TABLE ONLY public."PIS_TRAINING"
    ADD CONSTRAINT "PIS_TRAINING_pkey" PRIMARY KEY ("SN");
 L   ALTER TABLE ONLY public."PIS_TRAINING" DROP CONSTRAINT "PIS_TRAINING_pkey";
       public            postgres    false    436            �           2606    35486 0   PIS_VISITED_COUNTRIES PIS_VISITED_COUNTRIES_pkey 
   CONSTRAINT     t   ALTER TABLE ONLY public."PIS_VISITED_COUNTRIES"
    ADD CONSTRAINT "PIS_VISITED_COUNTRIES_pkey" PRIMARY KEY ("SN");
 ^   ALTER TABLE ONLY public."PIS_VISITED_COUNTRIES" DROP CONSTRAINT "PIS_VISITED_COUNTRIES_pkey";
       public            postgres    false    469                       2606    34852    PIS_WORKSHOP PIS_WORKSHOP_pkey 
   CONSTRAINT     b   ALTER TABLE ONLY public."PIS_WORKSHOP"
    ADD CONSTRAINT "PIS_WORKSHOP_pkey" PRIMARY KEY ("SN");
 L   ALTER TABLE ONLY public."PIS_WORKSHOP" DROP CONSTRAINT "PIS_WORKSHOP_pkey";
       public            postgres    false    437            9           2606    33945    ACC_BGT_RVSN PK_ACC_BGT_RVSN 
   CONSTRAINT     `   ALTER TABLE ONLY public."ACC_BGT_RVSN"
    ADD CONSTRAINT "PK_ACC_BGT_RVSN" PRIMARY KEY ("ID");
 J   ALTER TABLE ONLY public."ACC_BGT_RVSN" DROP CONSTRAINT "PK_ACC_BGT_RVSN";
       public            postgres    false    373            �           2606    34363 $   ACC_BGT_TRANSFER PK_ACC_BGT_TRANSFER 
   CONSTRAINT     h   ALTER TABLE ONLY public."ACC_BGT_TRANSFER"
    ADD CONSTRAINT "PK_ACC_BGT_TRANSFER" PRIMARY KEY ("ID");
 R   ALTER TABLE ONLY public."ACC_BGT_TRANSFER" DROP CONSTRAINT "PK_ACC_BGT_TRANSFER";
       public            postgres    false    408            +           2606    33039    ACC_CURRENCTY PK_ACC_CURRENCTY 
   CONSTRAINT     b   ALTER TABLE ONLY public."ACC_CURRENCTY"
    ADD CONSTRAINT "PK_ACC_CURRENCTY" PRIMARY KEY ("ID");
 L   ALTER TABLE ONLY public."ACC_CURRENCTY" DROP CONSTRAINT "PK_ACC_CURRENCTY";
       public            postgres    false    206            <           2606    33955 (   ACC_CURRENCTY_RATE PK_ACC_CURRENCTY_RATE 
   CONSTRAINT     l   ALTER TABLE ONLY public."ACC_CURRENCTY_RATE"
    ADD CONSTRAINT "PK_ACC_CURRENCTY_RATE" PRIMARY KEY ("ID");
 V   ALTER TABLE ONLY public."ACC_CURRENCTY_RATE" DROP CONSTRAINT "PK_ACC_CURRENCTY_RATE";
       public            postgres    false    374            3           2606    33059 4   ACC_LASTYEAR_ADV_DETAILS PK_ACC_LASTYEAR_ADV_DETAILS 
   CONSTRAINT     x   ALTER TABLE ONLY public."ACC_LASTYEAR_ADV_DETAILS"
    ADD CONSTRAINT "PK_ACC_LASTYEAR_ADV_DETAILS" PRIMARY KEY ("ID");
 b   ALTER TABLE ONLY public."ACC_LASTYEAR_ADV_DETAILS" DROP CONSTRAINT "PK_ACC_LASTYEAR_ADV_DETAILS";
       public            postgres    false    210            �           2606    34413 .   ACC_PAYMENT_CLEARANCE PK_ACC_PAYMENT_CLEARANCE 
   CONSTRAINT     r   ALTER TABLE ONLY public."ACC_PAYMENT_CLEARANCE"
    ADD CONSTRAINT "PK_ACC_PAYMENT_CLEARANCE" PRIMARY KEY ("ID");
 \   ALTER TABLE ONLY public."ACC_PAYMENT_CLEARANCE" DROP CONSTRAINT "PK_ACC_PAYMENT_CLEARANCE";
       public            postgres    false    410            C           2606    34991 .   ACC_PAYMENT_DEDUCTION PK_ACC_PAYMENT_DEDUCTION 
   CONSTRAINT     r   ALTER TABLE ONLY public."ACC_PAYMENT_DEDUCTION"
    ADD CONSTRAINT "PK_ACC_PAYMENT_DEDUCTION" PRIMARY KEY ("ID");
 \   ALTER TABLE ONLY public."ACC_PAYMENT_DEDUCTION" DROP CONSTRAINT "PK_ACC_PAYMENT_DEDUCTION";
       public            postgres    false    446            ?           2606    33101 ,   ACC_USER_COMITE_MSTR PK_ACC_USER_COMITE_MSTR 
   CONSTRAINT     p   ALTER TABLE ONLY public."ACC_USER_COMITE_MSTR"
    ADD CONSTRAINT "PK_ACC_USER_COMITE_MSTR" PRIMARY KEY ("ID");
 Z   ALTER TABLE ONLY public."ACC_USER_COMITE_MSTR" DROP CONSTRAINT "PK_ACC_USER_COMITE_MSTR";
       public            postgres    false    218            T           2606    34057 $   AspNetRoleClaims PK_AspNetRoleClaims 
   CONSTRAINT     h   ALTER TABLE ONLY public."AspNetRoleClaims"
    ADD CONSTRAINT "PK_AspNetRoleClaims" PRIMARY KEY ("Id");
 R   ALTER TABLE ONLY public."AspNetRoleClaims" DROP CONSTRAINT "PK_AspNetRoleClaims";
       public            postgres    false    382            I           2606    33132    AspNetRoles PK_AspNetRoles 
   CONSTRAINT     ^   ALTER TABLE ONLY public."AspNetRoles"
    ADD CONSTRAINT "PK_AspNetRoles" PRIMARY KEY ("Id");
 H   ALTER TABLE ONLY public."AspNetRoles" DROP CONSTRAINT "PK_AspNetRoles";
       public            postgres    false    223            �           2606    34299 $   AspNetUserClaims PK_AspNetUserClaims 
   CONSTRAINT     h   ALTER TABLE ONLY public."AspNetUserClaims"
    ADD CONSTRAINT "PK_AspNetUserClaims" PRIMARY KEY ("Id");
 R   ALTER TABLE ONLY public."AspNetUserClaims" DROP CONSTRAINT "PK_AspNetUserClaims";
       public            postgres    false    403            �           2606    34312 $   AspNetUserLogins PK_AspNetUserLogins 
   CONSTRAINT     �   ALTER TABLE ONLY public."AspNetUserLogins"
    ADD CONSTRAINT "PK_AspNetUserLogins" PRIMARY KEY ("LoginProvider", "ProviderKey");
 R   ALTER TABLE ONLY public."AspNetUserLogins" DROP CONSTRAINT "PK_AspNetUserLogins";
       public            postgres    false    404    404            �           2606    34325 "   AspNetUserRoles PK_AspNetUserRoles 
   CONSTRAINT     t   ALTER TABLE ONLY public."AspNetUserRoles"
    ADD CONSTRAINT "PK_AspNetUserRoles" PRIMARY KEY ("UserId", "RoleId");
 P   ALTER TABLE ONLY public."AspNetUserRoles" DROP CONSTRAINT "PK_AspNetUserRoles";
       public            postgres    false    405    405            �           2606    34343 $   AspNetUserTokens PK_AspNetUserTokens 
   CONSTRAINT     �   ALTER TABLE ONLY public."AspNetUserTokens"
    ADD CONSTRAINT "PK_AspNetUserTokens" PRIMARY KEY ("UserId", "LoginProvider", "Name");
 R   ALTER TABLE ONLY public."AspNetUserTokens" DROP CONSTRAINT "PK_AspNetUserTokens";
       public            postgres    false    406    406    406            N           2606    33148    BUDJET_SOURCE PK_BUDJET_SOURCE 
   CONSTRAINT     b   ALTER TABLE ONLY public."BUDJET_SOURCE"
    ADD CONSTRAINT "PK_BUDJET_SOURCE" PRIMARY KEY ("ID");
 L   ALTER TABLE ONLY public."BUDJET_SOURCE" DROP CONSTRAINT "PK_BUDJET_SOURCE";
       public            postgres    false    225            S           2606    33176    CONTACTS PK_CONTACTS 
   CONSTRAINT     X   ALTER TABLE ONLY public."CONTACTS"
    ADD CONSTRAINT "PK_CONTACTS" PRIMARY KEY ("ID");
 B   ALTER TABLE ONLY public."CONTACTS" DROP CONSTRAINT "PK_CONTACTS";
       public            postgres    false    231            U           2606    33193    EMP_GRP PK_EMP_GRP 
   CONSTRAINT     V   ALTER TABLE ONLY public."EMP_GRP"
    ADD CONSTRAINT "PK_EMP_GRP" PRIMARY KEY ("ID");
 @   ALTER TABLE ONLY public."EMP_GRP" DROP CONSTRAINT "PK_EMP_GRP";
       public            postgres    false    236            �           2606    34428 $   FIREBRIGADESTATE PK_FIREBRIGADESTATE 
   CONSTRAINT     h   ALTER TABLE ONLY public."FIREBRIGADESTATE"
    ADD CONSTRAINT "PK_FIREBRIGADESTATE" PRIMARY KEY ("ID");
 R   ALTER TABLE ONLY public."FIREBRIGADESTATE" DROP CONSTRAINT "PK_FIREBRIGADESTATE";
       public            postgres    false    411            W           2606    33201 &   FYWISERENTDARRATE PK_FYWISERENTDARRATE 
   CONSTRAINT     j   ALTER TABLE ONLY public."FYWISERENTDARRATE"
    ADD CONSTRAINT "PK_FYWISERENTDARRATE" PRIMARY KEY ("ID");
 T   ALTER TABLE ONLY public."FYWISERENTDARRATE" DROP CONSTRAINT "PK_FYWISERENTDARRATE";
       public            postgres    false    238            Y           2606    33218 (   INV_APPLICANT_RATE PK_INV_APPLICANT_RATE 
   CONSTRAINT     l   ALTER TABLE ONLY public."INV_APPLICANT_RATE"
    ADD CONSTRAINT "PK_INV_APPLICANT_RATE" PRIMARY KEY ("ID");
 V   ALTER TABLE ONLY public."INV_APPLICANT_RATE" DROP CONSTRAINT "PK_INV_APPLICANT_RATE";
       public            postgres    false    241            ]           2606    33228    INV_DEPLIST PK_INV_DEPLIST 
   CONSTRAINT     ^   ALTER TABLE ONLY public."INV_DEPLIST"
    ADD CONSTRAINT "PK_INV_DEPLIST" PRIMARY KEY ("ID");
 H   ALTER TABLE ONLY public."INV_DEPLIST" DROP CONSTRAINT "PK_INV_DEPLIST";
       public            postgres    false    243            _           2606    33233 $   INV_DEPRECIATION PK_INV_DEPRECIATION 
   CONSTRAINT     h   ALTER TABLE ONLY public."INV_DEPRECIATION"
    ADD CONSTRAINT "PK_INV_DEPRECIATION" PRIMARY KEY ("ID");
 R   ALTER TABLE ONLY public."INV_DEPRECIATION" DROP CONSTRAINT "PK_INV_DEPRECIATION";
       public            postgres    false    244            a           2606    35112 $   INV_GOODS_ADJUST PK_INV_GOODS_ADJUST 
   CONSTRAINT     h   ALTER TABLE ONLY public."INV_GOODS_ADJUST"
    ADD CONSTRAINT "PK_INV_GOODS_ADJUST" PRIMARY KEY ("ID");
 R   ALTER TABLE ONLY public."INV_GOODS_ADJUST" DROP CONSTRAINT "PK_INV_GOODS_ADJUST";
       public            postgres    false    451            �           2606    35592 (   INV_GOODS_REC_DETL PK_INV_GOODS_REC_DETL 
   CONSTRAINT     l   ALTER TABLE ONLY public."INV_GOODS_REC_DETL"
    ADD CONSTRAINT "PK_INV_GOODS_REC_DETL" PRIMARY KEY ("ID");
 V   ALTER TABLE ONLY public."INV_GOODS_REC_DETL" DROP CONSTRAINT "PK_INV_GOODS_REC_DETL";
       public            postgres    false    475            f           2606    35145 (   INV_GOODS_REC_MAST PK_INV_GOODS_REC_MAST 
   CONSTRAINT     l   ALTER TABLE ONLY public."INV_GOODS_REC_MAST"
    ADD CONSTRAINT "PK_INV_GOODS_REC_MAST" PRIMARY KEY ("ID");
 V   ALTER TABLE ONLY public."INV_GOODS_REC_MAST" DROP CONSTRAINT "PK_INV_GOODS_REC_MAST";
       public            postgres    false    452            c           2606    33243 .   INV_INCREASE_DECREASE PK_INV_INCREASE_DECREASE 
   CONSTRAINT     r   ALTER TABLE ONLY public."INV_INCREASE_DECREASE"
    ADD CONSTRAINT "PK_INV_INCREASE_DECREASE" PRIMARY KEY ("ID");
 \   ALTER TABLE ONLY public."INV_INCREASE_DECREASE" DROP CONSTRAINT "PK_INV_INCREASE_DECREASE";
       public            postgres    false    246            e           2606    33251 &   INV_ISSUE_DAKHILA PK_INV_ISSUE_DAKHILA 
   CONSTRAINT     j   ALTER TABLE ONLY public."INV_ISSUE_DAKHILA"
    ADD CONSTRAINT "PK_INV_ISSUE_DAKHILA" PRIMARY KEY ("ID");
 T   ALTER TABLE ONLY public."INV_ISSUE_DAKHILA" DROP CONSTRAINT "PK_INV_ISSUE_DAKHILA";
       public            postgres    false    247            �           2606    34701 $   INV_ISSUE_DETAIL PK_INV_ISSUE_DETAIL 
   CONSTRAINT     h   ALTER TABLE ONLY public."INV_ISSUE_DETAIL"
    ADD CONSTRAINT "PK_INV_ISSUE_DETAIL" PRIMARY KEY ("ID");
 R   ALTER TABLE ONLY public."INV_ISSUE_DETAIL" DROP CONSTRAINT "PK_INV_ISSUE_DETAIL";
       public            postgres    false    427            �           2606    35702 $   INV_ISSUE_MASTER PK_INV_ISSUE_MASTER 
   CONSTRAINT     h   ALTER TABLE ONLY public."INV_ISSUE_MASTER"
    ADD CONSTRAINT "PK_INV_ISSUE_MASTER" PRIMARY KEY ("ID");
 R   ALTER TABLE ONLY public."INV_ISSUE_MASTER" DROP CONSTRAINT "PK_INV_ISSUE_MASTER";
       public            postgres    false    478            g           2606    33256 &   INV_ITEM_ADJ_TYPE PK_INV_ITEM_ADJ_TYPE 
   CONSTRAINT     j   ALTER TABLE ONLY public."INV_ITEM_ADJ_TYPE"
    ADD CONSTRAINT "PK_INV_ITEM_ADJ_TYPE" PRIMARY KEY ("ID");
 T   ALTER TABLE ONLY public."INV_ITEM_ADJ_TYPE" DROP CONSTRAINT "PK_INV_ITEM_ADJ_TYPE";
       public            postgres    false    248            i           2606    33261 &   INV_ITEM_CATEGORY PK_INV_ITEM_CATEGORY 
   CONSTRAINT     j   ALTER TABLE ONLY public."INV_ITEM_CATEGORY"
    ADD CONSTRAINT "PK_INV_ITEM_CATEGORY" PRIMARY KEY ("ID");
 T   ALTER TABLE ONLY public."INV_ITEM_CATEGORY" DROP CONSTRAINT "PK_INV_ITEM_CATEGORY";
       public            postgres    false    249            n           2606    35165 ,   INV_ITEM_STATUSCHECK PK_INV_ITEM_STATUSCHECK 
   CONSTRAINT     p   ALTER TABLE ONLY public."INV_ITEM_STATUSCHECK"
    ADD CONSTRAINT "PK_INV_ITEM_STATUSCHECK" PRIMARY KEY ("ID");
 Z   ALTER TABLE ONLY public."INV_ITEM_STATUSCHECK" DROP CONSTRAINT "PK_INV_ITEM_STATUSCHECK";
       public            postgres    false    453            `           2606    34105 *   INV_LILAMAPPDETAILS PK_INV_LILAMAPPDETAILS 
   CONSTRAINT     n   ALTER TABLE ONLY public."INV_LILAMAPPDETAILS"
    ADD CONSTRAINT "PK_INV_LILAMAPPDETAILS" PRIMARY KEY ("ID");
 X   ALTER TABLE ONLY public."INV_LILAMAPPDETAILS" DROP CONSTRAINT "PK_INV_LILAMAPPDETAILS";
       public            postgres    false    386            m           2606    33271 *   INV_LILAM_APPMASTER PK_INV_LILAM_APPMASTER 
   CONSTRAINT     n   ALTER TABLE ONLY public."INV_LILAM_APPMASTER"
    ADD CONSTRAINT "PK_INV_LILAM_APPMASTER" PRIMARY KEY ("ID");
 X   ALTER TABLE ONLY public."INV_LILAM_APPMASTER" DROP CONSTRAINT "PK_INV_LILAM_APPMASTER";
       public            postgres    false    251            o           2606    33279 $   INV_LILAM_DETAIL PK_INV_LILAM_DETAIL 
   CONSTRAINT     h   ALTER TABLE ONLY public."INV_LILAM_DETAIL"
    ADD CONSTRAINT "PK_INV_LILAM_DETAIL" PRIMARY KEY ("ID");
 R   ALTER TABLE ONLY public."INV_LILAM_DETAIL" DROP CONSTRAINT "PK_INV_LILAM_DETAIL";
       public            postgres    false    252            q           2606    33287     INV_LILAM_MAST PK_INV_LILAM_MAST 
   CONSTRAINT     d   ALTER TABLE ONLY public."INV_LILAM_MAST"
    ADD CONSTRAINT "PK_INV_LILAM_MAST" PRIMARY KEY ("ID");
 N   ALTER TABLE ONLY public."INV_LILAM_MAST" DROP CONSTRAINT "PK_INV_LILAM_MAST";
       public            postgres    false    253            s           2606    33295    INV_ORG_TYPE PK_INV_ORG_TYPE 
   CONSTRAINT     `   ALTER TABLE ONLY public."INV_ORG_TYPE"
    ADD CONSTRAINT "PK_INV_ORG_TYPE" PRIMARY KEY ("ID");
 J   ALTER TABLE ONLY public."INV_ORG_TYPE" DROP CONSTRAINT "PK_INV_ORG_TYPE";
       public            postgres    false    255            w           2606    33305 &   INV_PUR_MAST_PLAN PK_INV_PUR_MAST_PLAN 
   CONSTRAINT     j   ALTER TABLE ONLY public."INV_PUR_MAST_PLAN"
    ADD CONSTRAINT "PK_INV_PUR_MAST_PLAN" PRIMARY KEY ("ID");
 T   ALTER TABLE ONLY public."INV_PUR_MAST_PLAN" DROP CONSTRAINT "PK_INV_PUR_MAST_PLAN";
       public            postgres    false    257            �           2606    35667 (   INV_PUR_ORDER_DETL PK_INV_PUR_ORDER_DETL 
   CONSTRAINT     l   ALTER TABLE ONLY public."INV_PUR_ORDER_DETL"
    ADD CONSTRAINT "PK_INV_PUR_ORDER_DETL" PRIMARY KEY ("ID");
 V   ALTER TABLE ONLY public."INV_PUR_ORDER_DETL" DROP CONSTRAINT "PK_INV_PUR_ORDER_DETL";
       public            postgres    false    477            t           2606    35203 (   INV_PUR_ORDER_MAST PK_INV_PUR_ORDER_MAST 
   CONSTRAINT     l   ALTER TABLE ONLY public."INV_PUR_ORDER_MAST"
    ADD CONSTRAINT "PK_INV_PUR_ORDER_MAST" PRIMARY KEY ("ID");
 V   ALTER TABLE ONLY public."INV_PUR_ORDER_MAST" DROP CONSTRAINT "PK_INV_PUR_ORDER_MAST";
       public            postgres    false    454            |           2606    35231 ,   INV_REQUISITION_MAST PK_INV_REQUISITION_MAST 
   CONSTRAINT     p   ALTER TABLE ONLY public."INV_REQUISITION_MAST"
    ADD CONSTRAINT "PK_INV_REQUISITION_MAST" PRIMARY KEY ("ID");
 Z   ALTER TABLE ONLY public."INV_REQUISITION_MAST" DROP CONSTRAINT "PK_INV_REQUISITION_MAST";
       public            postgres    false    455            �           2606    35732     INV_REQ_DETAIL PK_INV_REQ_DETAIL 
   CONSTRAINT     d   ALTER TABLE ONLY public."INV_REQ_DETAIL"
    ADD CONSTRAINT "PK_INV_REQ_DETAIL" PRIMARY KEY ("ID");
 N   ALTER TABLE ONLY public."INV_REQ_DETAIL" DROP CONSTRAINT "PK_INV_REQ_DETAIL";
       public            postgres    false    479            �           2606    35266 &   INV_STATUS_DETAIL PK_INV_STATUS_DETAIL 
   CONSTRAINT     j   ALTER TABLE ONLY public."INV_STATUS_DETAIL"
    ADD CONSTRAINT "PK_INV_STATUS_DETAIL" PRIMARY KEY ("ID");
 T   ALTER TABLE ONLY public."INV_STATUS_DETAIL" DROP CONSTRAINT "PK_INV_STATUS_DETAIL";
       public            postgres    false    456            }           2606    33326 2   INV_SUPPLIER_FISCALYEAR PK_INV_SUPPLIER_FISCALYEAR 
   CONSTRAINT     v   ALTER TABLE ONLY public."INV_SUPPLIER_FISCALYEAR"
    ADD CONSTRAINT "PK_INV_SUPPLIER_FISCALYEAR" PRIMARY KEY ("ID");
 `   ALTER TABLE ONLY public."INV_SUPPLIER_FISCALYEAR" DROP CONSTRAINT "PK_INV_SUPPLIER_FISCALYEAR";
       public            postgres    false    261            y           2606    33313 "   INV_SUP_ITM_DET PK_INV_SUP_ITM_DET 
   CONSTRAINT     f   ALTER TABLE ONLY public."INV_SUP_ITM_DET"
    ADD CONSTRAINT "PK_INV_SUP_ITM_DET" PRIMARY KEY ("ID");
 P   ALTER TABLE ONLY public."INV_SUP_ITM_DET" DROP CONSTRAINT "PK_INV_SUP_ITM_DET";
       public            postgres    false    259            �           2606    33336     INV_TYPE_SETUP PK_INV_TYPE_SETUP 
   CONSTRAINT     d   ALTER TABLE ONLY public."INV_TYPE_SETUP"
    ADD CONSTRAINT "PK_INV_TYPE_SETUP" PRIMARY KEY ("ID");
 N   ALTER TABLE ONLY public."INV_TYPE_SETUP" DROP CONSTRAINT "PK_INV_TYPE_SETUP";
       public            postgres    false    263            �           2606    33351 &   INV_YRLY_PUR_PLAN PK_INV_YRLY_PUR_PLAN 
   CONSTRAINT     j   ALTER TABLE ONLY public."INV_YRLY_PUR_PLAN"
    ADD CONSTRAINT "PK_INV_YRLY_PUR_PLAN" PRIMARY KEY ("ID");
 T   ALTER TABLE ONLY public."INV_YRLY_PUR_PLAN" DROP CONSTRAINT "PK_INV_YRLY_PUR_PLAN";
       public            postgres    false    266            �           2606    33377    MALPOT_LANDS PK_MALPOT_LANDS 
   CONSTRAINT     `   ALTER TABLE ONLY public."MALPOT_LANDS"
    ADD CONSTRAINT "PK_MALPOT_LANDS" PRIMARY KEY ("ID");
 J   ALTER TABLE ONLY public."MALPOT_LANDS" DROP CONSTRAINT "PK_MALPOT_LANDS";
       public            postgres    false    272            f           2606    34128 $   MAP_AREA_GND_COV PK_MAP_AREA_GND_COV 
   CONSTRAINT     h   ALTER TABLE ONLY public."MAP_AREA_GND_COV"
    ADD CONSTRAINT "PK_MAP_AREA_GND_COV" PRIMARY KEY ("ID");
 R   ALTER TABLE ONLY public."MAP_AREA_GND_COV" DROP CONSTRAINT "PK_MAP_AREA_GND_COV";
       public            postgres    false    388            �           2606    33382 ,   MAP_CONSTRCTION_KIND PK_MAP_CONSTRCTION_KIND 
   CONSTRAINT     p   ALTER TABLE ONLY public."MAP_CONSTRCTION_KIND"
    ADD CONSTRAINT "PK_MAP_CONSTRCTION_KIND" PRIMARY KEY ("ID");
 Z   ALTER TABLE ONLY public."MAP_CONSTRCTION_KIND" DROP CONSTRAINT "PK_MAP_CONSTRCTION_KIND";
       public            postgres    false    273            �           2606    33390 $   MAP_DESIGNER_DTL PK_MAP_DESIGNER_DTL 
   CONSTRAINT     h   ALTER TABLE ONLY public."MAP_DESIGNER_DTL"
    ADD CONSTRAINT "PK_MAP_DESIGNER_DTL" PRIMARY KEY ("ID");
 R   ALTER TABLE ONLY public."MAP_DESIGNER_DTL" DROP CONSTRAINT "PK_MAP_DESIGNER_DTL";
       public            postgres    false    274            �           2606    33395    MAP_DIRECTION PK_MAP_DIRECTION 
   CONSTRAINT     b   ALTER TABLE ONLY public."MAP_DIRECTION"
    ADD CONSTRAINT "PK_MAP_DIRECTION" PRIMARY KEY ("ID");
 L   ALTER TABLE ONLY public."MAP_DIRECTION" DROP CONSTRAINT "PK_MAP_DIRECTION";
       public            postgres    false    275            �           2606    33400     MAP_DRAIN_TYPE PK_MAP_DRAIN_TYPE 
   CONSTRAINT     d   ALTER TABLE ONLY public."MAP_DRAIN_TYPE"
    ADD CONSTRAINT "PK_MAP_DRAIN_TYPE" PRIMARY KEY ("ID");
 N   ALTER TABLE ONLY public."MAP_DRAIN_TYPE" DROP CONSTRAINT "PK_MAP_DRAIN_TYPE";
       public            postgres    false    276            �           2606    33405    MAP_FLOOR PK_MAP_FLOOR 
   CONSTRAINT     Z   ALTER TABLE ONLY public."MAP_FLOOR"
    ADD CONSTRAINT "PK_MAP_FLOOR" PRIMARY KEY ("ID");
 D   ALTER TABLE ONLY public."MAP_FLOOR" DROP CONSTRAINT "PK_MAP_FLOOR";
       public            postgres    false    277            �           2606    33410 &   MAP_HOUSEUSE_TYPE PK_MAP_HOUSEUSE_TYPE 
   CONSTRAINT     j   ALTER TABLE ONLY public."MAP_HOUSEUSE_TYPE"
    ADD CONSTRAINT "PK_MAP_HOUSEUSE_TYPE" PRIMARY KEY ("ID");
 T   ALTER TABLE ONLY public."MAP_HOUSEUSE_TYPE" DROP CONSTRAINT "PK_MAP_HOUSEUSE_TYPE";
       public            postgres    false    278            �           2606    34438 "   MAP_INCOME_TYPE PK_MAP_INCOME_TYPE 
   CONSTRAINT     f   ALTER TABLE ONLY public."MAP_INCOME_TYPE"
    ADD CONSTRAINT "PK_MAP_INCOME_TYPE" PRIMARY KEY ("ID");
 P   ALTER TABLE ONLY public."MAP_INCOME_TYPE" DROP CONSTRAINT "PK_MAP_INCOME_TYPE";
       public            postgres    false    412            �           2606    33420 *   MAP_LAND_OWNER_TYPE PK_MAP_LAND_OWNER_TYPE 
   CONSTRAINT     n   ALTER TABLE ONLY public."MAP_LAND_OWNER_TYPE"
    ADD CONSTRAINT "PK_MAP_LAND_OWNER_TYPE" PRIMARY KEY ("ID");
 X   ALTER TABLE ONLY public."MAP_LAND_OWNER_TYPE" DROP CONSTRAINT "PK_MAP_LAND_OWNER_TYPE";
       public            postgres    false    280            �           2606    33425 (   MAP_NEIGHBOUR_TYPE PK_MAP_NEIGHBOUR_TYPE 
   CONSTRAINT     l   ALTER TABLE ONLY public."MAP_NEIGHBOUR_TYPE"
    ADD CONSTRAINT "PK_MAP_NEIGHBOUR_TYPE" PRIMARY KEY ("ID");
 V   ALTER TABLE ONLY public."MAP_NEIGHBOUR_TYPE" DROP CONSTRAINT "PK_MAP_NEIGHBOUR_TYPE";
       public            postgres    false    281            �           2606    33430    MAP_RATE PK_MAP_RATE 
   CONSTRAINT     X   ALTER TABLE ONLY public."MAP_RATE"
    ADD CONSTRAINT "PK_MAP_RATE" PRIMARY KEY ("ID");
 B   ALTER TABLE ONLY public."MAP_RATE" DROP CONSTRAINT "PK_MAP_RATE";
       public            postgres    false    282            i           2606    34138     MAP_REGION_FAR PK_MAP_REGION_FAR 
   CONSTRAINT     d   ALTER TABLE ONLY public."MAP_REGION_FAR"
    ADD CONSTRAINT "PK_MAP_REGION_FAR" PRIMARY KEY ("ID");
 N   ALTER TABLE ONLY public."MAP_REGION_FAR" DROP CONSTRAINT "PK_MAP_REGION_FAR";
       public            postgres    false    389            �           2606    33435 .   MAP_ROOF_CNSTRCT_TYPE PK_MAP_ROOF_CNSTRCT_TYPE 
   CONSTRAINT     r   ALTER TABLE ONLY public."MAP_ROOF_CNSTRCT_TYPE"
    ADD CONSTRAINT "PK_MAP_ROOF_CNSTRCT_TYPE" PRIMARY KEY ("ID");
 \   ALTER TABLE ONLY public."MAP_ROOF_CNSTRCT_TYPE" DROP CONSTRAINT "PK_MAP_ROOF_CNSTRCT_TYPE";
       public            postgres    false    283            �           2606    33440    MAP_ROOF_TYPE PK_MAP_ROOF_TYPE 
   CONSTRAINT     b   ALTER TABLE ONLY public."MAP_ROOF_TYPE"
    ADD CONSTRAINT "PK_MAP_ROOF_TYPE" PRIMARY KEY ("ID");
 L   ALTER TABLE ONLY public."MAP_ROOF_TYPE" DROP CONSTRAINT "PK_MAP_ROOF_TYPE";
       public            postgres    false    284            �           2606    33450 $   MAP_STDHEIGHT_RW PK_MAP_STDHEIGHT_RW 
   CONSTRAINT     h   ALTER TABLE ONLY public."MAP_STDHEIGHT_RW"
    ADD CONSTRAINT "PK_MAP_STDHEIGHT_RW" PRIMARY KEY ("ID");
 R   ALTER TABLE ONLY public."MAP_STDHEIGHT_RW" DROP CONSTRAINT "PK_MAP_STDHEIGHT_RW";
       public            postgres    false    286            �           2606    33455    MAP_STOREYS PK_MAP_STOREYS 
   CONSTRAINT     ^   ALTER TABLE ONLY public."MAP_STOREYS"
    ADD CONSTRAINT "PK_MAP_STOREYS" PRIMARY KEY ("ID");
 H   ALTER TABLE ONLY public."MAP_STOREYS" DROP CONSTRAINT "PK_MAP_STOREYS";
       public            postgres    false    287            �           2606    33460 (   MAP_STRUCTURE_TYPE PK_MAP_STRUCTURE_TYPE 
   CONSTRAINT     l   ALTER TABLE ONLY public."MAP_STRUCTURE_TYPE"
    ADD CONSTRAINT "PK_MAP_STRUCTURE_TYPE" PRIMARY KEY ("ID");
 V   ALTER TABLE ONLY public."MAP_STRUCTURE_TYPE" DROP CONSTRAINT "PK_MAP_STRUCTURE_TYPE";
       public            postgres    false    288            �           2606    33465    MAP_ZONE PK_MAP_ZONE 
   CONSTRAINT     X   ALTER TABLE ONLY public."MAP_ZONE"
    ADD CONSTRAINT "PK_MAP_ZONE" PRIMARY KEY ("ID");
 B   ALTER TABLE ONLY public."MAP_ZONE" DROP CONSTRAINT "PK_MAP_ZONE";
       public            postgres    false    289            �           2606    33476 &   MINISTRY_ACC_HEAD PK_MINISTRY_ACC_HEAD 
   CONSTRAINT     j   ALTER TABLE ONLY public."MINISTRY_ACC_HEAD"
    ADD CONSTRAINT "PK_MINISTRY_ACC_HEAD" PRIMARY KEY ("ID");
 T   ALTER TABLE ONLY public."MINISTRY_ACC_HEAD" DROP CONSTRAINT "PK_MINISTRY_ACC_HEAD";
       public            postgres    false    291            �           2606    33489    OFFICE_TYPE PK_OFFICE_TYPE 
   CONSTRAINT     j   ALTER TABLE ONLY public."OFFICE_TYPE"
    ADD CONSTRAINT "PK_OFFICE_TYPE" PRIMARY KEY ("OFFICE_TYPE_ID");
 H   ALTER TABLE ONLY public."OFFICE_TYPE" DROP CONSTRAINT "PK_OFFICE_TYPE";
       public            postgres    false    294            {           2606    34206 &   ORGANIZATION_TREE PK_ORGANIZATION_TREE 
   CONSTRAINT     j   ALTER TABLE ONLY public."ORGANIZATION_TREE"
    ADD CONSTRAINT "PK_ORGANIZATION_TREE" PRIMARY KEY ("ID");
 T   ALTER TABLE ONLY public."ORGANIZATION_TREE" DROP CONSTRAINT "PK_ORGANIZATION_TREE";
       public            postgres    false    394            �           2606    34681 $   ORG_BANK_ACCOUNT PK_ORG_BANK_ACCOUNT 
   CONSTRAINT     h   ALTER TABLE ONLY public."ORG_BANK_ACCOUNT"
    ADD CONSTRAINT "PK_ORG_BANK_ACCOUNT" PRIMARY KEY ("ID");
 R   ALTER TABLE ONLY public."ORG_BANK_ACCOUNT" DROP CONSTRAINT "PK_ORG_BANK_ACCOUNT";
       public            postgres    false    426            �           2606    33507 ,   PIS_APPOINTMENT_TYPE PK_PIS_APPOINTMENT_TYPE 
   CONSTRAINT     p   ALTER TABLE ONLY public."PIS_APPOINTMENT_TYPE"
    ADD CONSTRAINT "PK_PIS_APPOINTMENT_TYPE" PRIMARY KEY ("ID");
 Z   ALTER TABLE ONLY public."PIS_APPOINTMENT_TYPE" DROP CONSTRAINT "PK_PIS_APPOINTMENT_TYPE";
       public            postgres    false    297            �           2606    33512     PIS_ATTRIBUTES PK_PIS_ATTRIBUTES 
   CONSTRAINT     d   ALTER TABLE ONLY public."PIS_ATTRIBUTES"
    ADD CONSTRAINT "PK_PIS_ATTRIBUTES" PRIMARY KEY ("ID");
 N   ALTER TABLE ONLY public."PIS_ATTRIBUTES" DROP CONSTRAINT "PK_PIS_ATTRIBUTES";
       public            postgres    false    298            �           2606    33517    PIS_EDU_BOARD PK_PIS_EDU_BOARD 
   CONSTRAINT     b   ALTER TABLE ONLY public."PIS_EDU_BOARD"
    ADD CONSTRAINT "PK_PIS_EDU_BOARD" PRIMARY KEY ("ID");
 L   ALTER TABLE ONLY public."PIS_EDU_BOARD" DROP CONSTRAINT "PK_PIS_EDU_BOARD";
       public            postgres    false    299            �           2606    35301 *   PIS_EMP_ADV_DED_DTL PK_PIS_EMP_ADV_DED_DTL 
   CONSTRAINT     n   ALTER TABLE ONLY public."PIS_EMP_ADV_DED_DTL"
    ADD CONSTRAINT "PK_PIS_EMP_ADV_DED_DTL" PRIMARY KEY ("ID");
 X   ALTER TABLE ONLY public."PIS_EMP_ADV_DED_DTL" DROP CONSTRAINT "PK_PIS_EMP_ADV_DED_DTL";
       public            postgres    false    458            �           2606    33527    PIS_EMP_BARGA PK_PIS_EMP_BARGA 
   CONSTRAINT     b   ALTER TABLE ONLY public."PIS_EMP_BARGA"
    ADD CONSTRAINT "PK_PIS_EMP_BARGA" PRIMARY KEY ("ID");
 L   ALTER TABLE ONLY public."PIS_EMP_BARGA" DROP CONSTRAINT "PK_PIS_EMP_BARGA";
       public            postgres    false    301            �           2606    33540 0   PIS_EMP_INSURANCE_PAID PK_PIS_EMP_INSURANCE_PAID 
   CONSTRAINT     t   ALTER TABLE ONLY public."PIS_EMP_INSURANCE_PAID"
    ADD CONSTRAINT "PK_PIS_EMP_INSURANCE_PAID" PRIMARY KEY ("ID");
 ^   ALTER TABLE ONLY public."PIS_EMP_INSURANCE_PAID" DROP CONSTRAINT "PK_PIS_EMP_INSURANCE_PAID";
       public            postgres    false    303            �           2606    33548     PIS_GEO_REGION PK_PIS_GEO_REGION 
   CONSTRAINT     d   ALTER TABLE ONLY public."PIS_GEO_REGION"
    ADD CONSTRAINT "PK_PIS_GEO_REGION" PRIMARY KEY ("ID");
 N   ALTER TABLE ONLY public."PIS_GEO_REGION" DROP CONSTRAINT "PK_PIS_GEO_REGION";
       public            postgres    false    304            �           2606    33582 4   PIS_NIJAMATI_SEWA_SAMUHA PK_PIS_NIJAMATI_SEWA_SAMUHA 
   CONSTRAINT     x   ALTER TABLE ONLY public."PIS_NIJAMATI_SEWA_SAMUHA"
    ADD CONSTRAINT "PK_PIS_NIJAMATI_SEWA_SAMUHA" PRIMARY KEY ("ID");
 b   ALTER TABLE ONLY public."PIS_NIJAMATI_SEWA_SAMUHA" DROP CONSTRAINT "PK_PIS_NIJAMATI_SEWA_SAMUHA";
       public            postgres    false    309                       2606    34799 &   PIS_OTHER_ADD_SUB PK_PIS_OTHER_ADD_SUB 
   CONSTRAINT     j   ALTER TABLE ONLY public."PIS_OTHER_ADD_SUB"
    ADD CONSTRAINT "PK_PIS_OTHER_ADD_SUB" PRIMARY KEY ("ID");
 T   ALTER TABLE ONLY public."PIS_OTHER_ADD_SUB" DROP CONSTRAINT "PK_PIS_OTHER_ADD_SUB";
       public            postgres    false    432            �           2606    33597    PIS_PAYROLLS PK_PIS_PAYROLLS 
   CONSTRAINT     `   ALTER TABLE ONLY public."PIS_PAYROLLS"
    ADD CONSTRAINT "PK_PIS_PAYROLLS" PRIMARY KEY ("ID");
 J   ALTER TABLE ONLY public."PIS_PAYROLLS" DROP CONSTRAINT "PK_PIS_PAYROLLS";
       public            postgres    false    311            �           2606    35757 ,   PIS_PYROLL_LOAN_DTLS PK_PIS_PYROLL_LOAN_DTLS 
   CONSTRAINT     p   ALTER TABLE ONLY public."PIS_PYROLL_LOAN_DTLS"
    ADD CONSTRAINT "PK_PIS_PYROLL_LOAN_DTLS" PRIMARY KEY ("ID");
 Z   ALTER TABLE ONLY public."PIS_PYROLL_LOAN_DTLS" DROP CONSTRAINT "PK_PIS_PYROLL_LOAN_DTLS";
       public            postgres    false    480            �           2606    35451 ,   PIS_PYROLL_OTHR_DTLS PK_PIS_PYROLL_OTHR_DTLS 
   CONSTRAINT     p   ALTER TABLE ONLY public."PIS_PYROLL_OTHR_DTLS"
    ADD CONSTRAINT "PK_PIS_PYROLL_OTHR_DTLS" PRIMARY KEY ("ID");
 Z   ALTER TABLE ONLY public."PIS_PYROLL_OTHR_DTLS" DROP CONSTRAINT "PK_PIS_PYROLL_OTHR_DTLS";
       public            postgres    false    467            �           2606    33628 (   PIS_SERVICE_STATUS PK_PIS_SERVICE_STATUS 
   CONSTRAINT     l   ALTER TABLE ONLY public."PIS_SERVICE_STATUS"
    ADD CONSTRAINT "PK_PIS_SERVICE_STATUS" PRIMARY KEY ("ID");
 V   ALTER TABLE ONLY public."PIS_SERVICE_STATUS" DROP CONSTRAINT "PK_PIS_SERVICE_STATUS";
       public            postgres    false    316            �           2606    33641    PMS_YOJTYPE PK_PMS_YOJTYPE 
   CONSTRAINT     ^   ALTER TABLE ONLY public."PMS_YOJTYPE"
    ADD CONSTRAINT "PK_PMS_YOJTYPE" PRIMARY KEY ("ID");
 H   ALTER TABLE ONLY public."PMS_YOJTYPE" DROP CONSTRAINT "PK_PMS_YOJTYPE";
       public            postgres    false    318            �           2606    33646    RENT_DAR_RATE PK_RENT_DAR_RATE 
   CONSTRAINT     b   ALTER TABLE ONLY public."RENT_DAR_RATE"
    ADD CONSTRAINT "PK_RENT_DAR_RATE" PRIMARY KEY ("ID");
 L   ALTER TABLE ONLY public."RENT_DAR_RATE" DROP CONSTRAINT "PK_RENT_DAR_RATE";
       public            postgres    false    319            �           2606    33660 $   SANITATION_GROUP PK_SANITATION_GROUP 
   CONSTRAINT     h   ALTER TABLE ONLY public."SANITATION_GROUP"
    ADD CONSTRAINT "PK_SANITATION_GROUP" PRIMARY KEY ("ID");
 R   ALTER TABLE ONLY public."SANITATION_GROUP" DROP CONSTRAINT "PK_SANITATION_GROUP";
       public            postgres    false    322            "           2606    34865 "   SANITATION_RATE PK_SANITATION_RATE 
   CONSTRAINT     f   ALTER TABLE ONLY public."SANITATION_RATE"
    ADD CONSTRAINT "PK_SANITATION_RATE" PRIMARY KEY ("ID");
 P   ALTER TABLE ONLY public."SANITATION_RATE" DROP CONSTRAINT "PK_SANITATION_RATE";
       public            postgres    false    438            �           2606    34234 *   SANITATION_SUBGROUP PK_SANITATION_SUBGROUP 
   CONSTRAINT     n   ALTER TABLE ONLY public."SANITATION_SUBGROUP"
    ADD CONSTRAINT "PK_SANITATION_SUBGROUP" PRIMARY KEY ("ID");
 X   ALTER TABLE ONLY public."SANITATION_SUBGROUP" DROP CONSTRAINT "PK_SANITATION_SUBGROUP";
       public            postgres    false    396            �           2606    34448 .   SERVICE_CHARGE_MASTER PK_SERVICE_CHARGE_MASTER 
   CONSTRAINT     r   ALTER TABLE ONLY public."SERVICE_CHARGE_MASTER"
    ADD CONSTRAINT "PK_SERVICE_CHARGE_MASTER" PRIMARY KEY ("ID");
 \   ALTER TABLE ONLY public."SERVICE_CHARGE_MASTER" DROP CONSTRAINT "PK_SERVICE_CHARGE_MASTER";
       public            postgres    false    413            �           2606    33671    SUBJECT_AREA PK_SUBJECT_AREA 
   CONSTRAINT     `   ALTER TABLE ONLY public."SUBJECT_AREA"
    ADD CONSTRAINT "PK_SUBJECT_AREA" PRIMARY KEY ("ID");
 J   ALTER TABLE ONLY public."SUBJECT_AREA" DROP CONSTRAINT "PK_SUBJECT_AREA";
       public            postgres    false    324            �           2606    33679 &   SV_BUSINESSMASTER PK_SV_BUSINESSMASTER 
   CONSTRAINT     j   ALTER TABLE ONLY public."SV_BUSINESSMASTER"
    ADD CONSTRAINT "PK_SV_BUSINESSMASTER" PRIMARY KEY ("ID");
 T   ALTER TABLE ONLY public."SV_BUSINESSMASTER" DROP CONSTRAINT "PK_SV_BUSINESSMASTER";
       public            postgres    false    325            �           2606    33684 $   SV_CONSTRUCTIONS PK_SV_CONSTRUCTIONS 
   CONSTRAINT     h   ALTER TABLE ONLY public."SV_CONSTRUCTIONS"
    ADD CONSTRAINT "PK_SV_CONSTRUCTIONS" PRIMARY KEY ("ID");
 R   ALTER TABLE ONLY public."SV_CONSTRUCTIONS" DROP CONSTRAINT "PK_SV_CONSTRUCTIONS";
       public            postgres    false    326            �           2606    33692    SV_HOUSES PK_SV_HOUSES 
   CONSTRAINT     Z   ALTER TABLE ONLY public."SV_HOUSES"
    ADD CONSTRAINT "PK_SV_HOUSES" PRIMARY KEY ("ID");
 D   ALTER TABLE ONLY public."SV_HOUSES" DROP CONSTRAINT "PK_SV_HOUSES";
       public            postgres    false    327            �           2606    33700    SV_LANDS PK_SV_LANDS 
   CONSTRAINT     X   ALTER TABLE ONLY public."SV_LANDS"
    ADD CONSTRAINT "PK_SV_LANDS" PRIMARY KEY ("ID");
 B   ALTER TABLE ONLY public."SV_LANDS" DROP CONSTRAINT "PK_SV_LANDS";
       public            postgres    false    328                       2606    33739 $   TAX_RATE_CEILING PK_TAX_RATE_CEILING 
   CONSTRAINT     h   ALTER TABLE ONLY public."TAX_RATE_CEILING"
    ADD CONSTRAINT "PK_TAX_RATE_CEILING" PRIMARY KEY ("ID");
 R   ALTER TABLE ONLY public."TAX_RATE_CEILING" DROP CONSTRAINT "PK_TAX_RATE_CEILING";
       public            postgres    false    335            *           2606    33888    TBLBILLTYPE PK_TBLBILLTYPE 
   CONSTRAINT     ^   ALTER TABLE ONLY public."TBLBILLTYPE"
    ADD CONSTRAINT "PK_TBLBILLTYPE" PRIMARY KEY ("ID");
 H   ALTER TABLE ONLY public."TBLBILLTYPE" DROP CONSTRAINT "PK_TBLBILLTYPE";
       public            postgres    false    359            �           2606    34493 8   TBLBUSINESS_SERVICE_CH_MST PK_TBLBUSINESS_SERVICE_CH_MST 
   CONSTRAINT     |   ALTER TABLE ONLY public."TBLBUSINESS_SERVICE_CH_MST"
    ADD CONSTRAINT "PK_TBLBUSINESS_SERVICE_CH_MST" PRIMARY KEY ("ID");
 f   ALTER TABLE ONLY public."TBLBUSINESS_SERVICE_CH_MST" DROP CONSTRAINT "PK_TBLBUSINESS_SERVICE_CH_MST";
       public            postgres    false    417            �           2606    35511 ,   TBLFYWISEMPOTASSRATE PK_TBLFYWISEMPOTASSRATE 
   CONSTRAINT     p   ALTER TABLE ONLY public."TBLFYWISEMPOTASSRATE"
    ADD CONSTRAINT "PK_TBLFYWISEMPOTASSRATE" PRIMARY KEY ("ID");
 Z   ALTER TABLE ONLY public."TBLFYWISEMPOTASSRATE" DROP CONSTRAINT "PK_TBLFYWISEMPOTASSRATE";
       public            postgres    false    471            .           2606    33904 &   TBLLAND_TYPE_AREA PK_TBLLAND_TYPE_AREA 
   CONSTRAINT     j   ALTER TABLE ONLY public."TBLLAND_TYPE_AREA"
    ADD CONSTRAINT "PK_TBLLAND_TYPE_AREA" PRIMARY KEY ("ID");
 T   ALTER TABLE ONLY public."TBLLAND_TYPE_AREA" DROP CONSTRAINT "PK_TBLLAND_TYPE_AREA";
       public            postgres    false    363            0           2606    33909     TBLMALPOTGROUP PK_TBLMALPOTGROUP 
   CONSTRAINT     d   ALTER TABLE ONLY public."TBLMALPOTGROUP"
    ADD CONSTRAINT "PK_TBLMALPOTGROUP" PRIMARY KEY ("ID");
 N   ALTER TABLE ONLY public."TBLMALPOTGROUP" DROP CONSTRAINT "PK_TBLMALPOTGROUP";
       public            postgres    false    364            1           2606    34920     TBLMALPOTRATES PK_TBLMALPOTRATES 
   CONSTRAINT     d   ALTER TABLE ONLY public."TBLMALPOTRATES"
    ADD CONSTRAINT "PK_TBLMALPOTRATES" PRIMARY KEY ("ID");
 N   ALTER TABLE ONLY public."TBLMALPOTRATES" DROP CONSTRAINT "PK_TBLMALPOTRATES";
       public            postgres    false    442            �           2606    34284 &   TBLMALPOTSUBGROUP PK_TBLMALPOTSUBGROUP 
   CONSTRAINT     j   ALTER TABLE ONLY public."TBLMALPOTSUBGROUP"
    ADD CONSTRAINT "PK_TBLMALPOTSUBGROUP" PRIMARY KEY ("ID");
 T   ALTER TABLE ONLY public."TBLMALPOTSUBGROUP" DROP CONSTRAINT "PK_TBLMALPOTSUBGROUP";
       public            postgres    false    401            �           2606    34503 (   TBLVEH_SER_CH_MSTR PK_TBLVEH_SER_CH_MSTR 
   CONSTRAINT     l   ALTER TABLE ONLY public."TBLVEH_SER_CH_MSTR"
    ADD CONSTRAINT "PK_TBLVEH_SER_CH_MSTR" PRIMARY KEY ("ID");
 V   ALTER TABLE ONLY public."TBLVEH_SER_CH_MSTR" DROP CONSTRAINT "PK_TBLVEH_SER_CH_MSTR";
       public            postgres    false    418                       2606    33765 *   TBL_BANK_ACCNT_TYPE PK_TBL_BANK_ACCNT_TYPE 
   CONSTRAINT     n   ALTER TABLE ONLY public."TBL_BANK_ACCNT_TYPE"
    ADD CONSTRAINT "PK_TBL_BANK_ACCNT_TYPE" PRIMARY KEY ("ID");
 X   ALTER TABLE ONLY public."TBL_BANK_ACCNT_TYPE" DROP CONSTRAINT "PK_TBL_BANK_ACCNT_TYPE";
       public            postgres    false    340                       2606    33773 :   TBL_BANK_FINANCE_INSTITUTUE PK_TBL_BANK_FINANCE_INSTITUTUE 
   CONSTRAINT     ~   ALTER TABLE ONLY public."TBL_BANK_FINANCE_INSTITUTUE"
    ADD CONSTRAINT "PK_TBL_BANK_FINANCE_INSTITUTUE" PRIMARY KEY ("ID");
 h   ALTER TABLE ONLY public."TBL_BANK_FINANCE_INSTITUTUE" DROP CONSTRAINT "PK_TBL_BANK_FINANCE_INSTITUTUE";
       public            postgres    false    341            
           2606    33778    TBL_BGT_MGMT PK_TBL_BGT_MGMT 
   CONSTRAINT     `   ALTER TABLE ONLY public."TBL_BGT_MGMT"
    ADD CONSTRAINT "PK_TBL_BGT_MGMT" PRIMARY KEY ("ID");
 J   ALTER TABLE ONLY public."TBL_BGT_MGMT" DROP CONSTRAINT "PK_TBL_BGT_MGMT";
       public            postgres    false    342            �           2606    34244 $   TBL_BGT_MGMT_EXP PK_TBL_BGT_MGMT_EXP 
   CONSTRAINT     h   ALTER TABLE ONLY public."TBL_BGT_MGMT_EXP"
    ADD CONSTRAINT "PK_TBL_BGT_MGMT_EXP" PRIMARY KEY ("ID");
 R   ALTER TABLE ONLY public."TBL_BGT_MGMT_EXP" DROP CONSTRAINT "PK_TBL_BGT_MGMT_EXP";
       public            postgres    false    397            �           2606    34254 ,   TBL_BGT_MGMT_EXP_ORG PK_TBL_BGT_MGMT_EXP_ORG 
   CONSTRAINT     p   ALTER TABLE ONLY public."TBL_BGT_MGMT_EXP_ORG"
    ADD CONSTRAINT "PK_TBL_BGT_MGMT_EXP_ORG" PRIMARY KEY ("ID");
 Z   ALTER TABLE ONLY public."TBL_BGT_MGMT_EXP_ORG" DROP CONSTRAINT "PK_TBL_BGT_MGMT_EXP_ORG";
       public            postgres    false    398            4           2606    34935 4   TBL_BGT_MGMT_EXP_RELEASE PK_TBL_BGT_MGMT_EXP_RELEASE 
   CONSTRAINT     x   ALTER TABLE ONLY public."TBL_BGT_MGMT_EXP_RELEASE"
    ADD CONSTRAINT "PK_TBL_BGT_MGMT_EXP_RELEASE" PRIMARY KEY ("ID");
 b   ALTER TABLE ONLY public."TBL_BGT_MGMT_EXP_RELEASE" DROP CONSTRAINT "PK_TBL_BGT_MGMT_EXP_RELEASE";
       public            postgres    false    443                       2606    33783 $   TBL_BGT_MGMT_ORG PK_TBL_BGT_MGMT_ORG 
   CONSTRAINT     h   ALTER TABLE ONLY public."TBL_BGT_MGMT_ORG"
    ADD CONSTRAINT "PK_TBL_BGT_MGMT_ORG" PRIMARY KEY ("ID");
 R   ALTER TABLE ONLY public."TBL_BGT_MGMT_ORG" DROP CONSTRAINT "PK_TBL_BGT_MGMT_ORG";
       public            postgres    false    343            �           2606    34353 ,   TBL_BGT_MGMT_RELEASE PK_TBL_BGT_MGMT_RELEASE 
   CONSTRAINT     p   ALTER TABLE ONLY public."TBL_BGT_MGMT_RELEASE"
    ADD CONSTRAINT "PK_TBL_BGT_MGMT_RELEASE" PRIMARY KEY ("ID");
 Z   ALTER TABLE ONLY public."TBL_BGT_MGMT_RELEASE" DROP CONSTRAINT "PK_TBL_BGT_MGMT_RELEASE";
       public            postgres    false    407            %           2606    34880 $   TBL_BGT_MGMT_SRC PK_TBL_BGT_MGMT_SRC 
   CONSTRAINT     h   ALTER TABLE ONLY public."TBL_BGT_MGMT_SRC"
    ADD CONSTRAINT "PK_TBL_BGT_MGMT_SRC" PRIMARY KEY ("ID");
 R   ALTER TABLE ONLY public."TBL_BGT_MGMT_SRC" DROP CONSTRAINT "PK_TBL_BGT_MGMT_SRC";
       public            postgres    false    439            )           2606    34890 ,   TBL_BGT_MGMT_SRC_ORG PK_TBL_BGT_MGMT_SRC_ORG 
   CONSTRAINT     p   ALTER TABLE ONLY public."TBL_BGT_MGMT_SRC_ORG"
    ADD CONSTRAINT "PK_TBL_BGT_MGMT_SRC_ORG" PRIMARY KEY ("ID");
 Z   ALTER TABLE ONLY public."TBL_BGT_MGMT_SRC_ORG" DROP CONSTRAINT "PK_TBL_BGT_MGMT_SRC_ORG";
       public            postgres    false    440            �           2606    35531 4   TBL_BGT_MGMT_SRC_RELEASE PK_TBL_BGT_MGMT_SRC_RELEASE 
   CONSTRAINT     x   ALTER TABLE ONLY public."TBL_BGT_MGMT_SRC_RELEASE"
    ADD CONSTRAINT "PK_TBL_BGT_MGMT_SRC_RELEASE" PRIMARY KEY ("ID");
 b   ALTER TABLE ONLY public."TBL_BGT_MGMT_SRC_RELEASE" DROP CONSTRAINT "PK_TBL_BGT_MGMT_SRC_RELEASE";
       public            postgres    false    472            ?           2606    33968 "   TBL_BGT_RELEASE PK_TBL_BGT_RELEASE 
   CONSTRAINT     f   ALTER TABLE ONLY public."TBL_BGT_RELEASE"
    ADD CONSTRAINT "PK_TBL_BGT_RELEASE" PRIMARY KEY ("ID");
 P   ALTER TABLE ONLY public."TBL_BGT_RELEASE" DROP CONSTRAINT "PK_TBL_BGT_RELEASE";
       public            postgres    false    375            �           2606    34473 @   TBL_CONSTRUCTION_OTHER_CHARGES PK_TBL_CONSTRUCTION_OTHER_CHARGES 
   CONSTRAINT     �   ALTER TABLE ONLY public."TBL_CONSTRUCTION_OTHER_CHARGES"
    ADD CONSTRAINT "PK_TBL_CONSTRUCTION_OTHER_CHARGES" PRIMARY KEY ("ID");
 n   ALTER TABLE ONLY public."TBL_CONSTRUCTION_OTHER_CHARGES" DROP CONSTRAINT "PK_TBL_CONSTRUCTION_OTHER_CHARGES";
       public            postgres    false    415                       2606    33791 $   TBL_DATA_HISTORY PK_TBL_DATA_HISTORY 
   CONSTRAINT     h   ALTER TABLE ONLY public."TBL_DATA_HISTORY"
    ADD CONSTRAINT "PK_TBL_DATA_HISTORY" PRIMARY KEY ("ID");
 R   ALTER TABLE ONLY public."TBL_DATA_HISTORY" DROP CONSTRAINT "PK_TBL_DATA_HISTORY";
       public            postgres    false    344                       2606    33799    TBL_DEGISTER PK_TBL_DEGISTER 
   CONSTRAINT     `   ALTER TABLE ONLY public."TBL_DEGISTER"
    ADD CONSTRAINT "PK_TBL_DEGISTER" PRIMARY KEY ("ID");
 J   ALTER TABLE ONLY public."TBL_DEGISTER" DROP CONSTRAINT "PK_TBL_DEGISTER";
       public            postgres    false    345                       2606    33804 (   TBL_KHARIDA_AADASH PK_TBL_KHARIDA_AADASH 
   CONSTRAINT     l   ALTER TABLE ONLY public."TBL_KHARIDA_AADASH"
    ADD CONSTRAINT "PK_TBL_KHARIDA_AADASH" PRIMARY KEY ("ID");
 V   ALTER TABLE ONLY public."TBL_KHARIDA_AADASH" DROP CONSTRAINT "PK_TBL_KHARIDA_AADASH";
       public            postgres    false    346            �           2606    34483 0   TBL_LAND_OTHER_CHARGES PK_TBL_LAND_OTHER_CHARGES 
   CONSTRAINT     t   ALTER TABLE ONLY public."TBL_LAND_OTHER_CHARGES"
    ADD CONSTRAINT "PK_TBL_LAND_OTHER_CHARGES" PRIMARY KEY ("ID");
 ^   ALTER TABLE ONLY public."TBL_LAND_OTHER_CHARGES" DROP CONSTRAINT "PK_TBL_LAND_OTHER_CHARGES";
       public            postgres    false    416            �           2606    35496 4   TBL_MALPOT_OTHER_CHARGES PK_TBL_MALPOT_OTHER_CHARGES 
   CONSTRAINT     x   ALTER TABLE ONLY public."TBL_MALPOT_OTHER_CHARGES"
    ADD CONSTRAINT "PK_TBL_MALPOT_OTHER_CHARGES" PRIMARY KEY ("ID");
 b   ALTER TABLE ONLY public."TBL_MALPOT_OTHER_CHARGES" DROP CONSTRAINT "PK_TBL_MALPOT_OTHER_CHARGES";
       public            postgres    false    470                       2606    33809    TBL_NALI_TYPE PK_TBL_NALI_TYPE 
   CONSTRAINT     b   ALTER TABLE ONLY public."TBL_NALI_TYPE"
    ADD CONSTRAINT "PK_TBL_NALI_TYPE" PRIMARY KEY ("ID");
 L   ALTER TABLE ONLY public."TBL_NALI_TYPE" DROP CONSTRAINT "PK_TBL_NALI_TYPE";
       public            postgres    false    347                       2606    33817 0   TBL_ORGANIZATIONMASTER PK_TBL_ORGANIZATIONMASTER 
   CONSTRAINT     t   ALTER TABLE ONLY public."TBL_ORGANIZATIONMASTER"
    ADD CONSTRAINT "PK_TBL_ORGANIZATIONMASTER" PRIMARY KEY ("ID");
 ^   ALTER TABLE ONLY public."TBL_ORGANIZATIONMASTER" DROP CONSTRAINT "PK_TBL_ORGANIZATIONMASTER";
       public            postgres    false    348                       2606    33825 &   TBL_PAYMENT_ORDER PK_TBL_PAYMENT_ORDER 
   CONSTRAINT     j   ALTER TABLE ONLY public."TBL_PAYMENT_ORDER"
    ADD CONSTRAINT "PK_TBL_PAYMENT_ORDER" PRIMARY KEY ("ID");
 T   ALTER TABLE ONLY public."TBL_PAYMENT_ORDER" DROP CONSTRAINT "PK_TBL_PAYMENT_ORDER";
       public            postgres    false    349            �           2606    34264 6   TBL_PAYMENT_ORDER_DETAILS PK_TBL_PAYMENT_ORDER_DETAILS 
   CONSTRAINT     z   ALTER TABLE ONLY public."TBL_PAYMENT_ORDER_DETAILS"
    ADD CONSTRAINT "PK_TBL_PAYMENT_ORDER_DETAILS" PRIMARY KEY ("ID");
 d   ALTER TABLE ONLY public."TBL_PAYMENT_ORDER_DETAILS" DROP CONSTRAINT "PK_TBL_PAYMENT_ORDER_DETAILS";
       public            postgres    false    399                       2606    33830 *   TBL_PAYMENT_PROCESS PK_TBL_PAYMENT_PROCESS 
   CONSTRAINT     n   ALTER TABLE ONLY public."TBL_PAYMENT_PROCESS"
    ADD CONSTRAINT "PK_TBL_PAYMENT_PROCESS" PRIMARY KEY ("ID");
 X   ALTER TABLE ONLY public."TBL_PAYMENT_PROCESS" DROP CONSTRAINT "PK_TBL_PAYMENT_PROCESS";
       public            postgres    false    350                       2606    33835 $   TBL_PAYMENT_TYPE PK_TBL_PAYMENT_TYPE 
   CONSTRAINT     h   ALTER TABLE ONLY public."TBL_PAYMENT_TYPE"
    ADD CONSTRAINT "PK_TBL_PAYMENT_TYPE" PRIMARY KEY ("ID");
 R   ALTER TABLE ONLY public."TBL_PAYMENT_TYPE" DROP CONSTRAINT "PK_TBL_PAYMENT_TYPE";
       public            postgres    false    351                       2606    33843 $   TBL_PROPERTY_TAX PK_TBL_PROPERTY_TAX 
   CONSTRAINT     h   ALTER TABLE ONLY public."TBL_PROPERTY_TAX"
    ADD CONSTRAINT "PK_TBL_PROPERTY_TAX" PRIMARY KEY ("ID");
 R   ALTER TABLE ONLY public."TBL_PROPERTY_TAX" DROP CONSTRAINT "PK_TBL_PROPERTY_TAX";
       public            postgres    false    352                        2606    33854 (   TBL_STATUS_DETAILS PK_TBL_STATUS_DETAILS 
   CONSTRAINT     l   ALTER TABLE ONLY public."TBL_STATUS_DETAILS"
    ADD CONSTRAINT "PK_TBL_STATUS_DETAILS" PRIMARY KEY ("ID");
 V   ALTER TABLE ONLY public."TBL_STATUS_DETAILS" DROP CONSTRAINT "PK_TBL_STATUS_DETAILS";
       public            postgres    false    354            "           2606    33862    TBL_TAX_TYPE PK_TBL_TAX_TYPE 
   CONSTRAINT     `   ALTER TABLE ONLY public."TBL_TAX_TYPE"
    ADD CONSTRAINT "PK_TBL_TAX_TYPE" PRIMARY KEY ("ID");
 J   ALTER TABLE ONLY public."TBL_TAX_TYPE" DROP CONSTRAINT "PK_TBL_TAX_TYPE";
       public            postgres    false    355            &           2606    33875 (   TBL_TOLABIKASA_ORG PK_TBL_TOLABIKASA_ORG 
   CONSTRAINT     l   ALTER TABLE ONLY public."TBL_TOLABIKASA_ORG"
    ADD CONSTRAINT "PK_TBL_TOLABIKASA_ORG" PRIMARY KEY ("ID");
 V   ALTER TABLE ONLY public."TBL_TOLABIKASA_ORG" DROP CONSTRAINT "PK_TBL_TOLABIKASA_ORG";
       public            postgres    false    357            5           2606    33934    Usermaster PK_Usermaster 
   CONSTRAINT     \   ALTER TABLE ONLY public."Usermaster"
    ADD CONSTRAINT "PK_Usermaster" PRIMARY KEY ("Id");
 F   ALTER TABLE ONLY public."Usermaster" DROP CONSTRAINT "PK_Usermaster";
       public            postgres    false    370            �           2606    35466    WARD_MASTER PK_WARD_MASTER 
   CONSTRAINT     ^   ALTER TABLE ONLY public."WARD_MASTER"
    ADD CONSTRAINT "PK_WARD_MASTER" PRIMARY KEY ("ID");
 H   ALTER TABLE ONLY public."WARD_MASTER" DROP CONSTRAINT "PK_WARD_MASTER";
       public            postgres    false    468            %           2606    33018 .   __EFMigrationsHistory PK___EFMigrationsHistory 
   CONSTRAINT     {   ALTER TABLE ONLY public."__EFMigrationsHistory"
    ADD CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId");
 \   ALTER TABLE ONLY public."__EFMigrationsHistory" DROP CONSTRAINT "PK___EFMigrationsHistory";
       public            postgres    false    202            �           2606    34274    STOREDBILLS STOREDBILLS_pkey 
   CONSTRAINT     `   ALTER TABLE ONLY public."STOREDBILLS"
    ADD CONSTRAINT "STOREDBILLS_pkey" PRIMARY KEY ("SN");
 J   ALTER TABLE ONLY public."STOREDBILLS" DROP CONSTRAINT "STOREDBILLS_pkey";
       public            postgres    false    400            Z           2606    34080 (   SUB_MODULE_SOURCE SUB_MODULE_SOURCE_pkey 
   CONSTRAINT     �   ALTER TABLE ONLY public."SUB_MODULE_SOURCE"
    ADD CONSTRAINT "SUB_MODULE_SOURCE_pkey" PRIMARY KEY ("SUB_MODULE_ID", "BUDJET_SOURCE_ID");
 V   ALTER TABLE ONLY public."SUB_MODULE_SOURCE" DROP CONSTRAINT "SUB_MODULE_SOURCE_pkey";
       public            postgres    false    384    384                        2606    33711    SV_PEOPLE SV_PEOPLE_pkey 
   CONSTRAINT     ]   ALTER TABLE ONLY public."SV_PEOPLE"
    ADD CONSTRAINT "SV_PEOPLE_pkey" PRIMARY KEY ("IID");
 F   ALTER TABLE ONLY public."SV_PEOPLE" DROP CONSTRAINT "SV_PEOPLE_pkey";
       public            postgres    false    330                       2606    33722 &   SV_VEHICLEMASTER SV_VEHICLEMASTER_pkey 
   CONSTRAINT     j   ALTER TABLE ONLY public."SV_VEHICLEMASTER"
    ADD CONSTRAINT "SV_VEHICLEMASTER_pkey" PRIMARY KEY ("SN");
 T   ALTER TABLE ONLY public."SV_VEHICLEMASTER" DROP CONSTRAINT "SV_VEHICLEMASTER_pkey";
       public            postgres    false    332            �           2606    34458 .   TAX_ADDTNL_CHRG_DTLS TAX_ADDTNL_CHRG_DTLS_pkey 
   CONSTRAINT     r   ALTER TABLE ONLY public."TAX_ADDTNL_CHRG_DTLS"
    ADD CONSTRAINT "TAX_ADDTNL_CHRG_DTLS_pkey" PRIMARY KEY ("SN");
 \   ALTER TABLE ONLY public."TAX_ADDTNL_CHRG_DTLS" DROP CONSTRAINT "TAX_ADDTNL_CHRG_DTLS_pkey";
       public            postgres    false    414            -           2606    34905 .   TAX_THLI_ISSUED_CNTR TAX_THLI_ISSUED_CNTR_pkey 
   CONSTRAINT     r   ALTER TABLE ONLY public."TAX_THLI_ISSUED_CNTR"
    ADD CONSTRAINT "TAX_THLI_ISSUED_CNTR_pkey" PRIMARY KEY ("ID");
 \   ALTER TABLE ONLY public."TAX_THLI_ISSUED_CNTR" DROP CONSTRAINT "TAX_THLI_ISSUED_CNTR_pkey";
       public            postgres    false    441            ,           2606    33899 *   TBLHL_ADD_SUBTRACT TBLHL_ADD_SUBTRACT_pkey 
   CONSTRAINT     n   ALTER TABLE ONLY public."TBLHL_ADD_SUBTRACT"
    ADD CONSTRAINT "TBLHL_ADD_SUBTRACT_pkey" PRIMARY KEY ("SN");
 X   ALTER TABLE ONLY public."TBLHL_ADD_SUBTRACT" DROP CONSTRAINT "TBLHL_ADD_SUBTRACT_pkey";
       public            postgres    false    362            2           2606    33914 *   TBLTAX_FINE_REBATE TBLTAX_FINE_REBATE_pkey 
   CONSTRAINT     n   ALTER TABLE ONLY public."TBLTAX_FINE_REBATE"
    ADD CONSTRAINT "TBLTAX_FINE_REBATE_pkey" PRIMARY KEY ("SN");
 X   ALTER TABLE ONLY public."TBLTAX_FINE_REBATE" DROP CONSTRAINT "TBLTAX_FINE_REBATE_pkey";
       public            postgres    false    365            $           2606    33867 2   TBL_TAXSOURCERECORDNEW TBL_TAXSOURCERECORDNEW_pkey 
   CONSTRAINT     |   ALTER TABLE ONLY public."TBL_TAXSOURCERECORDNEW"
    ADD CONSTRAINT "TBL_TAXSOURCERECORDNEW_pkey" PRIMARY KEY ("TAXSRCID");
 `   ALTER TABLE ONLY public."TBL_TAXSOURCERECORDNEW" DROP CONSTRAINT "TBL_TAXSOURCERECORDNEW_pkey";
       public            postgres    false    356            (           2606    33883 (   TBL_VEHICLE_PARTS TBL_VEHICLE_PARTS_pkey 
   CONSTRAINT     l   ALTER TABLE ONLY public."TBL_VEHICLE_PARTS"
    ADD CONSTRAINT "TBL_VEHICLE_PARTS_pkey" PRIMARY KEY ("SN");
 V   ALTER TABLE ONLY public."TBL_VEHICLE_PARTS" DROP CONSTRAINT "TBL_VEHICLE_PARTS_pkey";
       public            postgres    false    358            O           1259    35845    BUDJET_SUB_HEAD_CODE_key    INDEX     a   CREATE UNIQUE INDEX "BUDJET_SUB_HEAD_CODE_key" ON public."BUDJET_SUB_HEAD" USING btree ("CODE");
 .   DROP INDEX public."BUDJET_SUB_HEAD_CODE_key";
       public            postgres    false    226            3           1259    36034 
   EmailIndex    INDEX     R   CREATE INDEX "EmailIndex" ON public."Usermaster" USING btree ("NormalizedEmail");
     DROP INDEX public."EmailIndex";
       public            postgres    false    370            E           1259    35778    IX_ACC_ACC_MASTER_TYPE_ID    INDEX     ]   CREATE INDEX "IX_ACC_ACC_MASTER_TYPE_ID" ON public."ACC_ACC_MASTER" USING btree ("TYPE_ID");
 /   DROP INDEX public."IX_ACC_ACC_MASTER_TYPE_ID";
       public            postgres    false    377            p           1259    35779 #   IX_ACC_ASULI_BIBARAN_PERSON_TYPE_ID    INDEX     q   CREATE INDEX "IX_ACC_ASULI_BIBARAN_PERSON_TYPE_ID" ON public."ACC_ASULI_BIBARAN" USING btree ("PERSON_TYPE_ID");
 9   DROP INDEX public."IX_ACC_ASULI_BIBARAN_PERSON_TYPE_ID";
       public            postgres    false    391            L           1259    35780    IX_ACC_BANK_GRNTY_PERSON_ID    INDEX     a   CREATE INDEX "IX_ACC_BANK_GRNTY_PERSON_ID" ON public."ACC_BANK_GRNTY" USING btree ("PERSON_ID");
 1   DROP INDEX public."IX_ACC_BANK_GRNTY_PERSON_ID";
       public            postgres    false    379            M           1259    35781    IX_ACC_BANK_GRNTY_WORK_ID    INDEX     ]   CREATE INDEX "IX_ACC_BANK_GRNTY_WORK_ID" ON public."ACC_BANK_GRNTY" USING btree ("WORK_ID");
 /   DROP INDEX public."IX_ACC_BANK_GRNTY_WORK_ID";
       public            postgres    false    379            O           1259    35782    IX_ACC_BANK_TRANS_BANK_ID    INDEX     ]   CREATE INDEX "IX_ACC_BANK_TRANS_BANK_ID" ON public."ACC_BANK_TRANS" USING btree ("BANK_ID");
 /   DROP INDEX public."IX_ACC_BANK_TRANS_BANK_ID";
       public            postgres    false    448            P           1259    35783    IX_ACC_BANK_TRANS_BILL_ID    INDEX     ]   CREATE INDEX "IX_ACC_BANK_TRANS_BILL_ID" ON public."ACC_BANK_TRANS" USING btree ("BILL_ID");
 /   DROP INDEX public."IX_ACC_BANK_TRANS_BILL_ID";
       public            postgres    false    448            Q           1259    35784    IX_ACC_BANK_TRANS_VCHR_ID    INDEX     ]   CREATE INDEX "IX_ACC_BANK_TRANS_VCHR_ID" ON public."ACC_BANK_TRANS" USING btree ("VCHR_ID");
 /   DROP INDEX public."IX_ACC_BANK_TRANS_VCHR_ID";
       public            postgres    false    448            7           1259    35785    IX_ACC_BGT_RVSN_BGT_ALCTN_ID    INDEX     c   CREATE INDEX "IX_ACC_BGT_RVSN_BGT_ALCTN_ID" ON public."ACC_BGT_RVSN" USING btree ("BGT_ALCTN_ID");
 2   DROP INDEX public."IX_ACC_BGT_RVSN_BGT_ALCTN_ID";
       public            postgres    false    373            �           1259    35786     IX_ACC_BGT_TRANSFER_BGT_ALCTN_ID    INDEX     k   CREATE INDEX "IX_ACC_BGT_TRANSFER_BGT_ALCTN_ID" ON public."ACC_BGT_TRANSFER" USING btree ("BGT_ALCTN_ID");
 6   DROP INDEX public."IX_ACC_BGT_TRANSFER_BGT_ALCTN_ID";
       public            postgres    false    408            �           1259    35787    IX_ACC_BGT_TRANSFER_FROM_ACC_ID    INDEX     i   CREATE INDEX "IX_ACC_BGT_TRANSFER_FROM_ACC_ID" ON public."ACC_BGT_TRANSFER" USING btree ("FROM_ACC_ID");
 5   DROP INDEX public."IX_ACC_BGT_TRANSFER_FROM_ACC_ID";
       public            postgres    false    408            �           1259    35788    IX_ACC_BGT_TRANSFER_TO_ACC_ID    INDEX     e   CREATE INDEX "IX_ACC_BGT_TRANSFER_TO_ACC_ID" ON public."ACC_BGT_TRANSFER" USING btree ("TO_ACC_ID");
 3   DROP INDEX public."IX_ACC_BGT_TRANSFER_TO_ACC_ID";
       public            postgres    false    408            l           1259    35789    IX_ACC_BUDJET_SOURCE_MIN_ACC_ID    INDEX     i   CREATE INDEX "IX_ACC_BUDJET_SOURCE_MIN_ACC_ID" ON public."ACC_BUDJET_SOURCE" USING btree ("MIN_ACC_ID");
 5   DROP INDEX public."IX_ACC_BUDJET_SOURCE_MIN_ACC_ID";
       public            postgres    false    390            m           1259    35790    IX_ACC_BUDJET_SOURCE_SOURCE_ID    INDEX     g   CREATE INDEX "IX_ACC_BUDJET_SOURCE_SOURCE_ID" ON public."ACC_BUDJET_SOURCE" USING btree ("SOURCE_ID");
 4   DROP INDEX public."IX_ACC_BUDJET_SOURCE_SOURCE_ID";
       public            postgres    false    390            T           1259    35791    IX_ACC_CASH_TRANS_BILL_ID    INDEX     ]   CREATE INDEX "IX_ACC_CASH_TRANS_BILL_ID" ON public."ACC_CASH_TRANS" USING btree ("BILL_ID");
 /   DROP INDEX public."IX_ACC_CASH_TRANS_BILL_ID";
       public            postgres    false    449            U           1259    35792    IX_ACC_CASH_TRANS_VCHR_ID    INDEX     ]   CREATE INDEX "IX_ACC_CASH_TRANS_VCHR_ID" ON public."ACC_CASH_TRANS" USING btree ("VCHR_ID");
 /   DROP INDEX public."IX_ACC_CASH_TRANS_VCHR_ID";
       public            postgres    false    449            :           1259    35793 !   IX_ACC_CURRENCTY_RATE_CURRENCY_ID    INDEX     m   CREATE INDEX "IX_ACC_CURRENCTY_RATE_CURRENCY_ID" ON public."ACC_CURRENCTY_RATE" USING btree ("CURRENCY_ID");
 7   DROP INDEX public."IX_ACC_CURRENCTY_RATE_CURRENCY_ID";
       public            postgres    false    374            �           1259    35794    IX_ACC_DHRTI_BILL_DTL_ACC_ID    INDEX     c   CREATE INDEX "IX_ACC_DHRTI_BILL_DTL_ACC_ID" ON public."ACC_DHRTI_BILL_DTL" USING btree ("ACC_ID");
 2   DROP INDEX public."IX_ACC_DHRTI_BILL_DTL_ACC_ID";
       public            postgres    false    419            �           1259    35795    IX_ACC_DHRTI_BILL_DTL_VCHR_ID    INDEX     e   CREATE INDEX "IX_ACC_DHRTI_BILL_DTL_VCHR_ID" ON public."ACC_DHRTI_BILL_DTL" USING btree ("VCHR_ID");
 3   DROP INDEX public."IX_ACC_DHRTI_BILL_DTL_VCHR_ID";
       public            postgres    false    419            �           1259    35796    IX_ACC_DHRTI_BILL_DTL_WORK_ID    INDEX     e   CREATE INDEX "IX_ACC_DHRTI_BILL_DTL_WORK_ID" ON public."ACC_DHRTI_BILL_DTL" USING btree ("WORK_ID");
 3   DROP INDEX public."IX_ACC_DHRTI_BILL_DTL_WORK_ID";
       public            postgres    false    419            �           1259    35797 #   IX_ACC_DHRTI_BILL_MASTER_BILLTYPEID    INDEX     q   CREATE INDEX "IX_ACC_DHRTI_BILL_MASTER_BILLTYPEID" ON public."ACC_DHRTI_BILL_MASTER" USING btree ("BILLTYPEID");
 9   DROP INDEX public."IX_ACC_DHRTI_BILL_MASTER_BILLTYPEID";
       public            postgres    false    420            �           1259    35798 &   IX_ACC_DHRTI_BILL_MASTER_SUB_MODULE_ID    INDEX     w   CREATE INDEX "IX_ACC_DHRTI_BILL_MASTER_SUB_MODULE_ID" ON public."ACC_DHRTI_BILL_MASTER" USING btree ("SUB_MODULE_ID");
 <   DROP INDEX public."IX_ACC_DHRTI_BILL_MASTER_SUB_MODULE_ID";
       public            postgres    false    420            �           1259    35799     IX_ACC_DHRTI_BILL_MASTER_VCHR_ID    INDEX     k   CREATE INDEX "IX_ACC_DHRTI_BILL_MASTER_VCHR_ID" ON public."ACC_DHRTI_BILL_MASTER" USING btree ("VCHR_ID");
 6   DROP INDEX public."IX_ACC_DHRTI_BILL_MASTER_VCHR_ID";
       public            postgres    false    420            �           1259    35800     IX_ACC_DHRTI_BILL_MASTER_WORK_ID    INDEX     k   CREATE INDEX "IX_ACC_DHRTI_BILL_MASTER_WORK_ID" ON public."ACC_DHRTI_BILL_MASTER" USING btree ("WORK_ID");
 6   DROP INDEX public."IX_ACC_DHRTI_BILL_MASTER_WORK_ID";
       public            postgres    false    420            �           1259    35801    IX_ACC_EXPENSES_DETAILS_ACC_ID    INDEX     g   CREATE INDEX "IX_ACC_EXPENSES_DETAILS_ACC_ID" ON public."ACC_EXPENSES_DETAILS" USING btree ("ACC_ID");
 4   DROP INDEX public."IX_ACC_EXPENSES_DETAILS_ACC_ID";
       public            postgres    false    409            �           1259    35802 '   IX_ACC_EXPENSES_DETAILS_PAYMENT_SLIP_ID    INDEX     y   CREATE INDEX "IX_ACC_EXPENSES_DETAILS_PAYMENT_SLIP_ID" ON public."ACC_EXPENSES_DETAILS" USING btree ("PAYMENT_SLIP_ID");
 =   DROP INDEX public."IX_ACC_EXPENSES_DETAILS_PAYMENT_SLIP_ID";
       public            postgres    false    409            �           1259    35803 &   IX_ACC_EXPENSES_DETAILS_PERSON_TYPE_ID    INDEX     w   CREATE INDEX "IX_ACC_EXPENSES_DETAILS_PERSON_TYPE_ID" ON public."ACC_EXPENSES_DETAILS" USING btree ("PERSON_TYPE_ID");
 <   DROP INDEX public."IX_ACC_EXPENSES_DETAILS_PERSON_TYPE_ID";
       public            postgres    false    409            �           1259    35804 %   IX_ACC_EXPENSES_DETAILS_TRANS_TYPE_ID    INDEX     u   CREATE INDEX "IX_ACC_EXPENSES_DETAILS_TRANS_TYPE_ID" ON public."ACC_EXPENSES_DETAILS" USING btree ("TRANS_TYPE_ID");
 ;   DROP INDEX public."IX_ACC_EXPENSES_DETAILS_TRANS_TYPE_ID";
       public            postgres    false    409            �           1259    35805    IX_ACC_EXPENSES_DETAILS_WORK_ID    INDEX     i   CREATE INDEX "IX_ACC_EXPENSES_DETAILS_WORK_ID" ON public."ACC_EXPENSES_DETAILS" USING btree ("WORK_ID");
 5   DROP INDEX public."IX_ACC_EXPENSES_DETAILS_WORK_ID";
       public            postgres    false    409            B           1259    35806    IX_ACC_PADADHIKARI_MSTR_POST_ID    INDEX     i   CREATE INDEX "IX_ACC_PADADHIKARI_MSTR_POST_ID" ON public."ACC_PADADHIKARI_MSTR" USING btree ("POST_ID");
 5   DROP INDEX public."IX_ACC_PADADHIKARI_MSTR_POST_ID";
       public            postgres    false    376            �           1259    35807    IX_ACC_PAYMENT_CLEARANCE_ACC_ID    INDEX     i   CREATE INDEX "IX_ACC_PAYMENT_CLEARANCE_ACC_ID" ON public."ACC_PAYMENT_CLEARANCE" USING btree ("ACC_ID");
 5   DROP INDEX public."IX_ACC_PAYMENT_CLEARANCE_ACC_ID";
       public            postgres    false    410            �           1259    35808 &   IX_ACC_PAYMENT_CLEARANCE_BUDGET_ACC_ID    INDEX     w   CREATE INDEX "IX_ACC_PAYMENT_CLEARANCE_BUDGET_ACC_ID" ON public."ACC_PAYMENT_CLEARANCE" USING btree ("BUDGET_ACC_ID");
 <   DROP INDEX public."IX_ACC_PAYMENT_CLEARANCE_BUDGET_ACC_ID";
       public            postgres    false    410            ?           1259    35809    IX_ACC_PAYMENT_DEDUCTION_ACC_ID    INDEX     i   CREATE INDEX "IX_ACC_PAYMENT_DEDUCTION_ACC_ID" ON public."ACC_PAYMENT_DEDUCTION" USING btree ("ACC_ID");
 5   DROP INDEX public."IX_ACC_PAYMENT_DEDUCTION_ACC_ID";
       public            postgres    false    446            @           1259    35810 &   IX_ACC_PAYMENT_DEDUCTION_BUDGET_ACC_ID    INDEX     w   CREATE INDEX "IX_ACC_PAYMENT_DEDUCTION_BUDGET_ACC_ID" ON public."ACC_PAYMENT_DEDUCTION" USING btree ("BUDGET_ACC_ID");
 <   DROP INDEX public."IX_ACC_PAYMENT_DEDUCTION_BUDGET_ACC_ID";
       public            postgres    false    446            A           1259    35811 #   IX_ACC_PAYMENT_DEDUCTION_PAYMENT_ID    INDEX     q   CREATE INDEX "IX_ACC_PAYMENT_DEDUCTION_PAYMENT_ID" ON public."ACC_PAYMENT_DEDUCTION" USING btree ("PAYMENT_ID");
 9   DROP INDEX public."IX_ACC_PAYMENT_DEDUCTION_PAYMENT_ID";
       public            postgres    false    446            F           1259    35812    IX_ACC_PAYMENT_DETAILS_ACC_ID    INDEX     e   CREATE INDEX "IX_ACC_PAYMENT_DETAILS_ACC_ID" ON public."ACC_PAYMENT_DETAILS" USING btree ("ACC_ID");
 3   DROP INDEX public."IX_ACC_PAYMENT_DETAILS_ACC_ID";
       public            postgres    false    447            G           1259    35813 $   IX_ACC_PAYMENT_DETAILS_BUDGET_ACC_ID    INDEX     s   CREATE INDEX "IX_ACC_PAYMENT_DETAILS_BUDGET_ACC_ID" ON public."ACC_PAYMENT_DETAILS" USING btree ("BUDGET_ACC_ID");
 :   DROP INDEX public."IX_ACC_PAYMENT_DETAILS_BUDGET_ACC_ID";
       public            postgres    false    447            H           1259    35814 !   IX_ACC_PAYMENT_DETAILS_PAYMENT_ID    INDEX     m   CREATE INDEX "IX_ACC_PAYMENT_DETAILS_PAYMENT_ID" ON public."ACC_PAYMENT_DETAILS" USING btree ("PAYMENT_ID");
 7   DROP INDEX public."IX_ACC_PAYMENT_DETAILS_PAYMENT_ID";
       public            postgres    false    447            I           1259    35815 %   IX_ACC_PAYMENT_DETAILS_PERSON_TYPE_ID    INDEX     u   CREATE INDEX "IX_ACC_PAYMENT_DETAILS_PERSON_TYPE_ID" ON public."ACC_PAYMENT_DETAILS" USING btree ("PERSON_TYPE_ID");
 ;   DROP INDEX public."IX_ACC_PAYMENT_DETAILS_PERSON_TYPE_ID";
       public            postgres    false    447            J           1259    35816 $   IX_ACC_PAYMENT_DETAILS_TRANS_TYPE_ID    INDEX     s   CREATE INDEX "IX_ACC_PAYMENT_DETAILS_TRANS_TYPE_ID" ON public."ACC_PAYMENT_DETAILS" USING btree ("TRANS_TYPE_ID");
 :   DROP INDEX public."IX_ACC_PAYMENT_DETAILS_TRANS_TYPE_ID";
       public            postgres    false    447            K           1259    35817    IX_ACC_PAYMENT_DETAILS_VCHR_ID    INDEX     g   CREATE INDEX "IX_ACC_PAYMENT_DETAILS_VCHR_ID" ON public."ACC_PAYMENT_DETAILS" USING btree ("VCHR_ID");
 4   DROP INDEX public."IX_ACC_PAYMENT_DETAILS_VCHR_ID";
       public            postgres    false    447            L           1259    35818    IX_ACC_PAYMENT_DETAILS_WORK_ID    INDEX     g   CREATE INDEX "IX_ACC_PAYMENT_DETAILS_WORK_ID" ON public."ACC_PAYMENT_DETAILS" USING btree ("WORK_ID");
 4   DROP INDEX public."IX_ACC_PAYMENT_DETAILS_WORK_ID";
       public            postgres    false    447            �           1259    35819 $   IX_ACC_PAYMENT_MASTER_PERSON_TYPE_ID    INDEX     s   CREATE INDEX "IX_ACC_PAYMENT_MASTER_PERSON_TYPE_ID" ON public."ACC_PAYMENT_MASTER" USING btree ("PERSON_TYPE_ID");
 :   DROP INDEX public."IX_ACC_PAYMENT_MASTER_PERSON_TYPE_ID";
       public            postgres    false    421            �           1259    35820 #   IX_ACC_PAYMENT_MASTER_SUB_MODULE_ID    INDEX     q   CREATE INDEX "IX_ACC_PAYMENT_MASTER_SUB_MODULE_ID" ON public."ACC_PAYMENT_MASTER" USING btree ("SUB_MODULE_ID");
 9   DROP INDEX public."IX_ACC_PAYMENT_MASTER_SUB_MODULE_ID";
       public            postgres    false    421            �           1259    35821 #   IX_ACC_PAYMENT_MASTER_TRANS_TYPE_ID    INDEX     q   CREATE INDEX "IX_ACC_PAYMENT_MASTER_TRANS_TYPE_ID" ON public."ACC_PAYMENT_MASTER" USING btree ("TRANS_TYPE_ID");
 9   DROP INDEX public."IX_ACC_PAYMENT_MASTER_TRANS_TYPE_ID";
       public            postgres    false    421            �           1259    35822    IX_ACC_PAYMENT_MASTER_VCHR_ID    INDEX     e   CREATE INDEX "IX_ACC_PAYMENT_MASTER_VCHR_ID" ON public."ACC_PAYMENT_MASTER" USING btree ("VCHR_ID");
 3   DROP INDEX public."IX_ACC_PAYMENT_MASTER_VCHR_ID";
       public            postgres    false    421            �           1259    35823    IX_ACC_PAYMENT_MASTER_WORK_ID    INDEX     e   CREATE INDEX "IX_ACC_PAYMENT_MASTER_WORK_ID" ON public."ACC_PAYMENT_MASTER" USING btree ("WORK_ID");
 3   DROP INDEX public."IX_ACC_PAYMENT_MASTER_WORK_ID";
       public            postgres    false    421            �           1259    35824 !   IX_ACC_VCHR_DETAILS_SUB_MODULE_ID    INDEX     m   CREATE INDEX "IX_ACC_VCHR_DETAILS_SUB_MODULE_ID" ON public."ACC_VCHR_DETAILS" USING btree ("SUB_MODULE_ID");
 7   DROP INDEX public."IX_ACC_VCHR_DETAILS_SUB_MODULE_ID";
       public            postgres    false    422            �           1259    35825 !   IX_ACC_VCHR_DETAILS_TRANS_TYPE_ID    INDEX     m   CREATE INDEX "IX_ACC_VCHR_DETAILS_TRANS_TYPE_ID" ON public."ACC_VCHR_DETAILS" USING btree ("TRANS_TYPE_ID");
 7   DROP INDEX public."IX_ACC_VCHR_DETAILS_TRANS_TYPE_ID";
       public            postgres    false    422            �           1259    35826    IX_ACC_VCHR_DETAILS_VCHR_ID    INDEX     a   CREATE INDEX "IX_ACC_VCHR_DETAILS_VCHR_ID" ON public."ACC_VCHR_DETAILS" USING btree ("VCHR_ID");
 1   DROP INDEX public."IX_ACC_VCHR_DETAILS_VCHR_ID";
       public            postgres    false    422            �           1259    35827     IX_ACC_VCHR_DETAILS_VCHR_TYPE_ID    INDEX     k   CREATE INDEX "IX_ACC_VCHR_DETAILS_VCHR_TYPE_ID" ON public."ACC_VCHR_DETAILS" USING btree ("VCHR_TYPE_ID");
 6   DROP INDEX public."IX_ACC_VCHR_DETAILS_VCHR_TYPE_ID";
       public            postgres    false    422            �           1259    35828    IX_ACC_VCHR_DETAILS_WORK_ID    INDEX     a   CREATE INDEX "IX_ACC_VCHR_DETAILS_WORK_ID" ON public."ACC_VCHR_DETAILS" USING btree ("WORK_ID");
 1   DROP INDEX public."IX_ACC_VCHR_DETAILS_WORK_ID";
       public            postgres    false    422            H           1259    35829     IX_ACC_VCHR_MASTER_SUB_MODULE_ID    INDEX     k   CREATE INDEX "IX_ACC_VCHR_MASTER_SUB_MODULE_ID" ON public."ACC_VCHR_MASTER" USING btree ("SUB_MODULE_ID");
 6   DROP INDEX public."IX_ACC_VCHR_MASTER_SUB_MODULE_ID";
       public            postgres    false    378            I           1259    35830    IX_ACC_VCHR_MASTER_VCHR_TYPE_ID    INDEX     i   CREATE INDEX "IX_ACC_VCHR_MASTER_VCHR_TYPE_ID" ON public."ACC_VCHR_MASTER" USING btree ("VCHR_TYPE_ID");
 5   DROP INDEX public."IX_ACC_VCHR_MASTER_VCHR_TYPE_ID";
       public            postgres    false    378            P           1259    35831 $   IX_ACC_WORK_FUNDS_DETAIL_PROVIDER_ID    INDEX     s   CREATE INDEX "IX_ACC_WORK_FUNDS_DETAIL_PROVIDER_ID" ON public."ACC_WORK_FUNDS_DETAIL" USING btree ("PROVIDER_ID");
 :   DROP INDEX public."IX_ACC_WORK_FUNDS_DETAIL_PROVIDER_ID";
       public            postgres    false    380            Q           1259    35832     IX_ACC_WORK_FUNDS_DETAIL_WORK_ID    INDEX     k   CREATE INDEX "IX_ACC_WORK_FUNDS_DETAIL_WORK_ID" ON public."ACC_WORK_FUNDS_DETAIL" USING btree ("WORK_ID");
 6   DROP INDEX public."IX_ACC_WORK_FUNDS_DETAIL_WORK_ID";
       public            postgres    false    380            �           1259    35833 '   IX_ACC_WORK_PAYMNT_TRANS_PERSON_TYPE_ID    INDEX     y   CREATE INDEX "IX_ACC_WORK_PAYMNT_TRANS_PERSON_TYPE_ID" ON public."ACC_WORK_PAYMNT_TRANS" USING btree ("PERSON_TYPE_ID");
 =   DROP INDEX public."IX_ACC_WORK_PAYMNT_TRANS_PERSON_TYPE_ID";
       public            postgres    false    423            �           1259    35834     IX_ACC_WORK_PAYMNT_TRANS_VCHR_ID    INDEX     k   CREATE INDEX "IX_ACC_WORK_PAYMNT_TRANS_VCHR_ID" ON public."ACC_WORK_PAYMNT_TRANS" USING btree ("VCHR_ID");
 6   DROP INDEX public."IX_ACC_WORK_PAYMNT_TRANS_VCHR_ID";
       public            postgres    false    423            �           1259    35835     IX_ACC_WORK_PAYMNT_TRANS_WORK_ID    INDEX     k   CREATE INDEX "IX_ACC_WORK_PAYMNT_TRANS_WORK_ID" ON public."ACC_WORK_PAYMNT_TRANS" USING btree ("WORK_ID");
 6   DROP INDEX public."IX_ACC_WORK_PAYMNT_TRANS_WORK_ID";
       public            postgres    false    423            R           1259    35836    IX_AspNetRoleClaims_RoleId    INDEX     _   CREATE INDEX "IX_AspNetRoleClaims_RoleId" ON public."AspNetRoleClaims" USING btree ("RoleId");
 0   DROP INDEX public."IX_AspNetRoleClaims_RoleId";
       public            postgres    false    382            �           1259    35838    IX_AspNetUserClaims_UserId    INDEX     _   CREATE INDEX "IX_AspNetUserClaims_UserId" ON public."AspNetUserClaims" USING btree ("UserId");
 0   DROP INDEX public."IX_AspNetUserClaims_UserId";
       public            postgres    false    403            �           1259    35839    IX_AspNetUserLogins_UserId    INDEX     _   CREATE INDEX "IX_AspNetUserLogins_UserId" ON public."AspNetUserLogins" USING btree ("UserId");
 0   DROP INDEX public."IX_AspNetUserLogins_UserId";
       public            postgres    false    404            �           1259    35840    IX_AspNetUserRoles_RoleId    INDEX     ]   CREATE INDEX "IX_AspNetUserRoles_RoleId" ON public."AspNetUserRoles" USING btree ("RoleId");
 /   DROP INDEX public."IX_AspNetUserRoles_RoleId";
       public            postgres    false    405            7           1259    35842 #   IX_BANKTRANSACTIONS_DHRTI_MASTER_ID    INDEX     q   CREATE INDEX "IX_BANKTRANSACTIONS_DHRTI_MASTER_ID" ON public."BANKTRANSACTIONS" USING btree ("DHRTI_MASTER_ID");
 9   DROP INDEX public."IX_BANKTRANSACTIONS_DHRTI_MASTER_ID";
       public            postgres    false    444            8           1259    35843 %   IX_BANKTRANSACTIONS_SUBMODULE_TYPE_ID    INDEX     u   CREATE INDEX "IX_BANKTRANSACTIONS_SUBMODULE_TYPE_ID" ON public."BANKTRANSACTIONS" USING btree ("SUBMODULE_TYPE_ID");
 ;   DROP INDEX public."IX_BANKTRANSACTIONS_SUBMODULE_TYPE_ID";
       public            postgres    false    444            9           1259    35844    IX_BANKTRANSACTIONS_VCHR_ID    INDEX     a   CREATE INDEX "IX_BANKTRANSACTIONS_VCHR_ID" ON public."BANKTRANSACTIONS" USING btree ("VCHR_ID");
 1   DROP INDEX public."IX_BANKTRANSACTIONS_VCHR_ID";
       public            postgres    false    444            W           1259    35841    IX_BANK_BRANCH_BANKID    INDEX     U   CREATE INDEX "IX_BANK_BRANCH_BANKID" ON public."BANK_BRANCH" USING btree ("BANKID");
 +   DROP INDEX public."IX_BANK_BRANCH_BANKID";
       public            postgres    false    383            <           1259    35846 "   IX_CASHTRANSACTION_DHRTI_MASTER_ID    INDEX     o   CREATE INDEX "IX_CASHTRANSACTION_DHRTI_MASTER_ID" ON public."CASHTRANSACTION" USING btree ("DHRTI_MASTER_ID");
 8   DROP INDEX public."IX_CASHTRANSACTION_DHRTI_MASTER_ID";
       public            postgres    false    445            =           1259    35847 $   IX_CASHTRANSACTION_SUBMODULE_TYPE_ID    INDEX     s   CREATE INDEX "IX_CASHTRANSACTION_SUBMODULE_TYPE_ID" ON public."CASHTRANSACTION" USING btree ("SUBMODULE_TYPE_ID");
 :   DROP INDEX public."IX_CASHTRANSACTION_SUBMODULE_TYPE_ID";
       public            postgres    false    445            >           1259    35848    IX_CASHTRANSACTION_VCHR_ID    INDEX     _   CREATE INDEX "IX_CASHTRANSACTION_VCHR_ID" ON public."CASHTRANSACTION" USING btree ("VCHR_ID");
 0   DROP INDEX public."IX_CASHTRANSACTION_VCHR_ID";
       public            postgres    false    445            �           1259    35849    IX_FIREBRIGADESTATE_ACC_ID    INDEX     _   CREATE INDEX "IX_FIREBRIGADESTATE_ACC_ID" ON public."FIREBRIGADESTATE" USING btree ("ACC_ID");
 0   DROP INDEX public."IX_FIREBRIGADESTATE_ACC_ID";
       public            postgres    false    411            �           1259    35850    IX_INCOMEBILLDETAILS_ACC_ID    INDEX     a   CREATE INDEX "IX_INCOMEBILLDETAILS_ACC_ID" ON public."INCOMEBILLDETAILS" USING btree ("ACC_ID");
 1   DROP INDEX public."IX_INCOMEBILLDETAILS_ACC_ID";
       public            postgres    false    424            �           1259    35851    IX_INCOMEBILLDETAILS_VCHR_ID    INDEX     c   CREATE INDEX "IX_INCOMEBILLDETAILS_VCHR_ID" ON public."INCOMEBILLDETAILS" USING btree ("VCHR_ID");
 2   DROP INDEX public."IX_INCOMEBILLDETAILS_VCHR_ID";
       public            postgres    false    424            �           1259    35852    IX_INCOMEBILLMASTER_BILLTYPEID    INDEX     g   CREATE INDEX "IX_INCOMEBILLMASTER_BILLTYPEID" ON public."INCOMEBILLMASTER" USING btree ("BILLTYPEID");
 4   DROP INDEX public."IX_INCOMEBILLMASTER_BILLTYPEID";
       public            postgres    false    425            �           1259    35853 !   IX_INCOMEBILLMASTER_SUB_MODULE_ID    INDEX     m   CREATE INDEX "IX_INCOMEBILLMASTER_SUB_MODULE_ID" ON public."INCOMEBILLMASTER" USING btree ("SUB_MODULE_ID");
 7   DROP INDEX public."IX_INCOMEBILLMASTER_SUB_MODULE_ID";
       public            postgres    false    425            �           1259    35854    IX_INCOMEBILLMASTER_VCHR_ID    INDEX     a   CREATE INDEX "IX_INCOMEBILLMASTER_VCHR_ID" ON public."INCOMEBILLMASTER" USING btree ("VCHR_ID");
 1   DROP INDEX public."IX_INCOMEBILLMASTER_VCHR_ID";
       public            postgres    false    425            [           1259    35855    IX_INV_GOODS_ADJUST_ACCEPT_BY    INDEX     e   CREATE INDEX "IX_INV_GOODS_ADJUST_ACCEPT_BY" ON public."INV_GOODS_ADJUST" USING btree ("ACCEPT_BY");
 3   DROP INDEX public."IX_INV_GOODS_ADJUST_ACCEPT_BY";
       public            postgres    false    451            \           1259    35856    IX_INV_GOODS_ADJUST_BRAND_ID    INDEX     c   CREATE INDEX "IX_INV_GOODS_ADJUST_BRAND_ID" ON public."INV_GOODS_ADJUST" USING btree ("BRAND_ID");
 2   DROP INDEX public."IX_INV_GOODS_ADJUST_BRAND_ID";
       public            postgres    false    451            ]           1259    35857    IX_INV_GOODS_ADJUST_ITEM_ID    INDEX     a   CREATE INDEX "IX_INV_GOODS_ADJUST_ITEM_ID" ON public."INV_GOODS_ADJUST" USING btree ("ITEM_ID");
 1   DROP INDEX public."IX_INV_GOODS_ADJUST_ITEM_ID";
       public            postgres    false    451            ^           1259    35858    IX_INV_GOODS_ADJUST_PREP_BY    INDEX     a   CREATE INDEX "IX_INV_GOODS_ADJUST_PREP_BY" ON public."INV_GOODS_ADJUST" USING btree ("PREP_BY");
 1   DROP INDEX public."IX_INV_GOODS_ADJUST_PREP_BY";
       public            postgres    false    451            _           1259    35859    IX_INV_GOODS_ADJUST_SPEC_ID    INDEX     a   CREATE INDEX "IX_INV_GOODS_ADJUST_SPEC_ID" ON public."INV_GOODS_ADJUST" USING btree ("SPEC_ID");
 1   DROP INDEX public."IX_INV_GOODS_ADJUST_SPEC_ID";
       public            postgres    false    451            �           1259    35860    IX_INV_GOODS_REC_DETL_BRAND_ID    INDEX     g   CREATE INDEX "IX_INV_GOODS_REC_DETL_BRAND_ID" ON public."INV_GOODS_REC_DETL" USING btree ("BRAND_ID");
 4   DROP INDEX public."IX_INV_GOODS_REC_DETL_BRAND_ID";
       public            postgres    false    475            �           1259    35861 %   IX_INV_GOODS_REC_DETL_GOODS_MASTER_ID    INDEX     u   CREATE INDEX "IX_INV_GOODS_REC_DETL_GOODS_MASTER_ID" ON public."INV_GOODS_REC_DETL" USING btree ("GOODS_MASTER_ID");
 ;   DROP INDEX public."IX_INV_GOODS_REC_DETL_GOODS_MASTER_ID";
       public            postgres    false    475            �           1259    35862    IX_INV_GOODS_REC_DETL_ITEM_ID    INDEX     e   CREATE INDEX "IX_INV_GOODS_REC_DETL_ITEM_ID" ON public."INV_GOODS_REC_DETL" USING btree ("ITEM_ID");
 3   DROP INDEX public."IX_INV_GOODS_REC_DETL_ITEM_ID";
       public            postgres    false    475            �           1259    35863    IX_INV_GOODS_REC_DETL_SPEC_ID    INDEX     e   CREATE INDEX "IX_INV_GOODS_REC_DETL_SPEC_ID" ON public."INV_GOODS_REC_DETL" USING btree ("SPEC_ID");
 3   DROP INDEX public."IX_INV_GOODS_REC_DETL_SPEC_ID";
       public            postgres    false    475            �           1259    35864    IX_INV_GOODS_REC_DETL_UNIT_ID    INDEX     e   CREATE INDEX "IX_INV_GOODS_REC_DETL_UNIT_ID" ON public."INV_GOODS_REC_DETL" USING btree ("UNIT_ID");
 3   DROP INDEX public."IX_INV_GOODS_REC_DETL_UNIT_ID";
       public            postgres    false    475            b           1259    35865    IX_INV_GOODS_REC_MAST_ACCEPT_BY    INDEX     i   CREATE INDEX "IX_INV_GOODS_REC_MAST_ACCEPT_BY" ON public."INV_GOODS_REC_MAST" USING btree ("ACCEPT_BY");
 5   DROP INDEX public."IX_INV_GOODS_REC_MAST_ACCEPT_BY";
       public            postgres    false    452            c           1259    35866    IX_INV_GOODS_REC_MAST_CHECK_BY    INDEX     g   CREATE INDEX "IX_INV_GOODS_REC_MAST_CHECK_BY" ON public."INV_GOODS_REC_MAST" USING btree ("CHECK_BY");
 4   DROP INDEX public."IX_INV_GOODS_REC_MAST_CHECK_BY";
       public            postgres    false    452            d           1259    35867    IX_INV_GOODS_REC_MAST_PREP_BY    INDEX     e   CREATE INDEX "IX_INV_GOODS_REC_MAST_PREP_BY" ON public."INV_GOODS_REC_MAST" USING btree ("PREP_BY");
 3   DROP INDEX public."IX_INV_GOODS_REC_MAST_PREP_BY";
       public            postgres    false    452            �           1259    35868    IX_INV_ISSUE_DETAIL_BRAND_ID    INDEX     c   CREATE INDEX "IX_INV_ISSUE_DETAIL_BRAND_ID" ON public."INV_ISSUE_DETAIL" USING btree ("BRAND_ID");
 2   DROP INDEX public."IX_INV_ISSUE_DETAIL_BRAND_ID";
       public            postgres    false    427            �           1259    35869    IX_INV_ISSUE_DETAIL_ITEM_ID    INDEX     a   CREATE INDEX "IX_INV_ISSUE_DETAIL_ITEM_ID" ON public."INV_ISSUE_DETAIL" USING btree ("ITEM_ID");
 1   DROP INDEX public."IX_INV_ISSUE_DETAIL_ITEM_ID";
       public            postgres    false    427            �           1259    35870    IX_INV_ISSUE_DETAIL_ITEM_TYPE    INDEX     e   CREATE INDEX "IX_INV_ISSUE_DETAIL_ITEM_TYPE" ON public."INV_ISSUE_DETAIL" USING btree ("ITEM_TYPE");
 3   DROP INDEX public."IX_INV_ISSUE_DETAIL_ITEM_TYPE";
       public            postgres    false    427            �           1259    35871    IX_INV_ISSUE_DETAIL_SPEC_ID    INDEX     a   CREATE INDEX "IX_INV_ISSUE_DETAIL_SPEC_ID" ON public."INV_ISSUE_DETAIL" USING btree ("SPEC_ID");
 1   DROP INDEX public."IX_INV_ISSUE_DETAIL_SPEC_ID";
       public            postgres    false    427            �           1259    35872    IX_INV_ISSUE_MASTER_ACCEPT_BY    INDEX     e   CREATE INDEX "IX_INV_ISSUE_MASTER_ACCEPT_BY" ON public."INV_ISSUE_MASTER" USING btree ("ACCEPT_BY");
 3   DROP INDEX public."IX_INV_ISSUE_MASTER_ACCEPT_BY";
       public            postgres    false    478            �           1259    35873    IX_INV_ISSUE_MASTER_CHECK_BY    INDEX     c   CREATE INDEX "IX_INV_ISSUE_MASTER_CHECK_BY" ON public."INV_ISSUE_MASTER" USING btree ("CHECK_BY");
 2   DROP INDEX public."IX_INV_ISSUE_MASTER_CHECK_BY";
       public            postgres    false    478            �           1259    35874    IX_INV_ISSUE_MASTER_ISSUE_BY    INDEX     c   CREATE INDEX "IX_INV_ISSUE_MASTER_ISSUE_BY" ON public."INV_ISSUE_MASTER" USING btree ("ISSUE_BY");
 2   DROP INDEX public."IX_INV_ISSUE_MASTER_ISSUE_BY";
       public            postgres    false    478            �           1259    35875    IX_INV_ISSUE_MASTER_PREP_BY    INDEX     a   CREATE INDEX "IX_INV_ISSUE_MASTER_PREP_BY" ON public."INV_ISSUE_MASTER" USING btree ("PREP_BY");
 1   DROP INDEX public."IX_INV_ISSUE_MASTER_PREP_BY";
       public            postgres    false    478            �           1259    35876    IX_INV_ISSUE_MASTER_REQUEST_ID    INDEX     g   CREATE INDEX "IX_INV_ISSUE_MASTER_REQUEST_ID" ON public."INV_ISSUE_MASTER" USING btree ("REQUEST_ID");
 4   DROP INDEX public."IX_INV_ISSUE_MASTER_REQUEST_ID";
       public            postgres    false    478            �           1259    35877    IX_INV_ITEM_DETAILS_ACCEPT_BY    INDEX     e   CREATE INDEX "IX_INV_ITEM_DETAILS_ACCEPT_BY" ON public."INV_ITEM_DETAILS" USING btree ("ACCEPT_BY");
 3   DROP INDEX public."IX_INV_ITEM_DETAILS_ACCEPT_BY";
       public            postgres    false    476            �           1259    35878    IX_INV_ITEM_DETAILS_BRAND_ID    INDEX     c   CREATE INDEX "IX_INV_ITEM_DETAILS_BRAND_ID" ON public."INV_ITEM_DETAILS" USING btree ("BRAND_ID");
 2   DROP INDEX public."IX_INV_ITEM_DETAILS_BRAND_ID";
       public            postgres    false    476            �           1259    35879    IX_INV_ITEM_DETAILS_CHECK_BY    INDEX     c   CREATE INDEX "IX_INV_ITEM_DETAILS_CHECK_BY" ON public."INV_ITEM_DETAILS" USING btree ("CHECK_BY");
 2   DROP INDEX public."IX_INV_ITEM_DETAILS_CHECK_BY";
       public            postgres    false    476            �           1259    35880    IX_INV_ITEM_DETAILS_DAKHILA_ID    INDEX     g   CREATE INDEX "IX_INV_ITEM_DETAILS_DAKHILA_ID" ON public."INV_ITEM_DETAILS" USING btree ("DAKHILA_ID");
 4   DROP INDEX public."IX_INV_ITEM_DETAILS_DAKHILA_ID";
       public            postgres    false    476            �           1259    35881    IX_INV_ITEM_DETAILS_GD_ADJ_ID    INDEX     e   CREATE INDEX "IX_INV_ITEM_DETAILS_GD_ADJ_ID" ON public."INV_ITEM_DETAILS" USING btree ("GD_ADJ_ID");
 3   DROP INDEX public."IX_INV_ITEM_DETAILS_GD_ADJ_ID";
       public            postgres    false    476            �           1259    35882    IX_INV_ITEM_DETAILS_ITEM_ID    INDEX     a   CREATE INDEX "IX_INV_ITEM_DETAILS_ITEM_ID" ON public."INV_ITEM_DETAILS" USING btree ("ITEM_ID");
 1   DROP INDEX public."IX_INV_ITEM_DETAILS_ITEM_ID";
       public            postgres    false    476            �           1259    35883    IX_INV_ITEM_DETAILS_PREP_BY    INDEX     a   CREATE INDEX "IX_INV_ITEM_DETAILS_PREP_BY" ON public."INV_ITEM_DETAILS" USING btree ("PREP_BY");
 1   DROP INDEX public."IX_INV_ITEM_DETAILS_PREP_BY";
       public            postgres    false    476            �           1259    35884    IX_INV_ITEM_DETAILS_SPEC_ID    INDEX     a   CREATE INDEX "IX_INV_ITEM_DETAILS_SPEC_ID" ON public."INV_ITEM_DETAILS" USING btree ("SPEC_ID");
 1   DROP INDEX public."IX_INV_ITEM_DETAILS_SPEC_ID";
       public            postgres    false    476            c           1259    35885    IX_INV_ITEM_MST_UNIT_ID    INDEX     Y   CREATE INDEX "IX_INV_ITEM_MST_UNIT_ID" ON public."INV_ITEM_MST" USING btree ("UNIT_ID");
 -   DROP INDEX public."IX_INV_ITEM_MST_UNIT_ID";
       public            postgres    false    387            g           1259    35886 #   IX_INV_ITEM_STATUSCHECK_ACCEPTED_BY    INDEX     q   CREATE INDEX "IX_INV_ITEM_STATUSCHECK_ACCEPTED_BY" ON public."INV_ITEM_STATUSCHECK" USING btree ("ACCEPTED_BY");
 9   DROP INDEX public."IX_INV_ITEM_STATUSCHECK_ACCEPTED_BY";
       public            postgres    false    453            h           1259    35887     IX_INV_ITEM_STATUSCHECK_BRAND_ID    INDEX     k   CREATE INDEX "IX_INV_ITEM_STATUSCHECK_BRAND_ID" ON public."INV_ITEM_STATUSCHECK" USING btree ("BRAND_ID");
 6   DROP INDEX public."IX_INV_ITEM_STATUSCHECK_BRAND_ID";
       public            postgres    false    453            i           1259    35888    IX_INV_ITEM_STATUSCHECK_ITEM_ID    INDEX     i   CREATE INDEX "IX_INV_ITEM_STATUSCHECK_ITEM_ID" ON public."INV_ITEM_STATUSCHECK" USING btree ("ITEM_ID");
 5   DROP INDEX public."IX_INV_ITEM_STATUSCHECK_ITEM_ID";
       public            postgres    false    453            j           1259    35889    IX_INV_ITEM_STATUSCHECK_PREP_BY    INDEX     i   CREATE INDEX "IX_INV_ITEM_STATUSCHECK_PREP_BY" ON public."INV_ITEM_STATUSCHECK" USING btree ("PREP_BY");
 5   DROP INDEX public."IX_INV_ITEM_STATUSCHECK_PREP_BY";
       public            postgres    false    453            k           1259    35890    IX_INV_ITEM_STATUSCHECK_SPEC_ID    INDEX     i   CREATE INDEX "IX_INV_ITEM_STATUSCHECK_SPEC_ID" ON public."INV_ITEM_STATUSCHECK" USING btree ("SPEC_ID");
 5   DROP INDEX public."IX_INV_ITEM_STATUSCHECK_SPEC_ID";
       public            postgres    false    453            l           1259    35891     IX_INV_ITEM_STATUSCHECK_TALLY_BY    INDEX     k   CREATE INDEX "IX_INV_ITEM_STATUSCHECK_TALLY_BY" ON public."INV_ITEM_STATUSCHECK" USING btree ("TALLY_BY");
 6   DROP INDEX public."IX_INV_ITEM_STATUSCHECK_TALLY_BY";
       public            postgres    false    453            ^           1259    35892 #   IX_INV_LILAMAPPDETAILS_LILAMAPPLIID    INDEX     q   CREATE INDEX "IX_INV_LILAMAPPDETAILS_LILAMAPPLIID" ON public."INV_LILAMAPPDETAILS" USING btree ("LILAMAPPLIID");
 9   DROP INDEX public."IX_INV_LILAMAPPDETAILS_LILAMAPPLIID";
       public            postgres    false    386            �           1259    35893    IX_INV_PUR_ORDER_DETL_BRAND_ID    INDEX     g   CREATE INDEX "IX_INV_PUR_ORDER_DETL_BRAND_ID" ON public."INV_PUR_ORDER_DETL" USING btree ("BRAND_ID");
 4   DROP INDEX public."IX_INV_PUR_ORDER_DETL_BRAND_ID";
       public            postgres    false    477            �           1259    35894    IX_INV_PUR_ORDER_DETL_ITEM_ID    INDEX     e   CREATE INDEX "IX_INV_PUR_ORDER_DETL_ITEM_ID" ON public."INV_PUR_ORDER_DETL" USING btree ("ITEM_ID");
 3   DROP INDEX public."IX_INV_PUR_ORDER_DETL_ITEM_ID";
       public            postgres    false    477            �           1259    35895    IX_INV_PUR_ORDER_DETL_ITEM_TYPE    INDEX     i   CREATE INDEX "IX_INV_PUR_ORDER_DETL_ITEM_TYPE" ON public."INV_PUR_ORDER_DETL" USING btree ("ITEM_TYPE");
 5   DROP INDEX public."IX_INV_PUR_ORDER_DETL_ITEM_TYPE";
       public            postgres    false    477            �           1259    35896     IX_INV_PUR_ORDER_DETL_PUR_MST_ID    INDEX     k   CREATE INDEX "IX_INV_PUR_ORDER_DETL_PUR_MST_ID" ON public."INV_PUR_ORDER_DETL" USING btree ("PUR_MST_ID");
 6   DROP INDEX public."IX_INV_PUR_ORDER_DETL_PUR_MST_ID";
       public            postgres    false    477            �           1259    35897    IX_INV_PUR_ORDER_DETL_SPEC_ID    INDEX     e   CREATE INDEX "IX_INV_PUR_ORDER_DETL_SPEC_ID" ON public."INV_PUR_ORDER_DETL" USING btree ("SPEC_ID");
 3   DROP INDEX public."IX_INV_PUR_ORDER_DETL_SPEC_ID";
       public            postgres    false    477            �           1259    35898    IX_INV_PUR_ORDER_DETL_UNIT_ID    INDEX     e   CREATE INDEX "IX_INV_PUR_ORDER_DETL_UNIT_ID" ON public."INV_PUR_ORDER_DETL" USING btree ("UNIT_ID");
 3   DROP INDEX public."IX_INV_PUR_ORDER_DETL_UNIT_ID";
       public            postgres    false    477            o           1259    35899 !   IX_INV_PUR_ORDER_MAST_ACCEPTED_BY    INDEX     m   CREATE INDEX "IX_INV_PUR_ORDER_MAST_ACCEPTED_BY" ON public."INV_PUR_ORDER_MAST" USING btree ("ACCEPTED_BY");
 7   DROP INDEX public."IX_INV_PUR_ORDER_MAST_ACCEPTED_BY";
       public            postgres    false    454            p           1259    35900     IX_INV_PUR_ORDER_MAST_CHECKED_BY    INDEX     k   CREATE INDEX "IX_INV_PUR_ORDER_MAST_CHECKED_BY" ON public."INV_PUR_ORDER_MAST" USING btree ("CHECKED_BY");
 6   DROP INDEX public."IX_INV_PUR_ORDER_MAST_CHECKED_BY";
       public            postgres    false    454            q           1259    35901 !   IX_INV_PUR_ORDER_MAST_PREPARED_BY    INDEX     m   CREATE INDEX "IX_INV_PUR_ORDER_MAST_PREPARED_BY" ON public."INV_PUR_ORDER_MAST" USING btree ("PREPARED_BY");
 7   DROP INDEX public."IX_INV_PUR_ORDER_MAST_PREPARED_BY";
       public            postgres    false    454            r           1259    35902    IX_INV_PUR_ORDER_MAST_SUPP_ID    INDEX     e   CREATE INDEX "IX_INV_PUR_ORDER_MAST_SUPP_ID" ON public."INV_PUR_ORDER_MAST" USING btree ("SUPP_ID");
 3   DROP INDEX public."IX_INV_PUR_ORDER_MAST_SUPP_ID";
       public            postgres    false    454            u           1259    35907 !   IX_INV_REQUISITION_MAST_ACCEPT_BY    INDEX     m   CREATE INDEX "IX_INV_REQUISITION_MAST_ACCEPT_BY" ON public."INV_REQUISITION_MAST" USING btree ("ACCEPT_BY");
 7   DROP INDEX public."IX_INV_REQUISITION_MAST_ACCEPT_BY";
       public            postgres    false    455            v           1259    35908     IX_INV_REQUISITION_MAST_CHECK_BY    INDEX     k   CREATE INDEX "IX_INV_REQUISITION_MAST_CHECK_BY" ON public."INV_REQUISITION_MAST" USING btree ("CHECK_BY");
 6   DROP INDEX public."IX_INV_REQUISITION_MAST_CHECK_BY";
       public            postgres    false    455            w           1259    35909    IX_INV_REQUISITION_MAST_ITEM_ID    INDEX     i   CREATE INDEX "IX_INV_REQUISITION_MAST_ITEM_ID" ON public."INV_REQUISITION_MAST" USING btree ("ITEM_ID");
 5   DROP INDEX public."IX_INV_REQUISITION_MAST_ITEM_ID";
       public            postgres    false    455            x           1259    35910    IX_INV_REQUISITION_MAST_PREP_BY    INDEX     i   CREATE INDEX "IX_INV_REQUISITION_MAST_PREP_BY" ON public."INV_REQUISITION_MAST" USING btree ("PREP_BY");
 5   DROP INDEX public."IX_INV_REQUISITION_MAST_PREP_BY";
       public            postgres    false    455            y           1259    35911    IX_INV_REQUISITION_MAST_PROJ_ID    INDEX     i   CREATE INDEX "IX_INV_REQUISITION_MAST_PROJ_ID" ON public."INV_REQUISITION_MAST" USING btree ("PROJ_ID");
 5   DROP INDEX public."IX_INV_REQUISITION_MAST_PROJ_ID";
       public            postgres    false    455            z           1259    35912    IX_INV_REQUISITION_MAST_REQ_BY    INDEX     g   CREATE INDEX "IX_INV_REQUISITION_MAST_REQ_BY" ON public."INV_REQUISITION_MAST" USING btree ("REQ_BY");
 4   DROP INDEX public."IX_INV_REQUISITION_MAST_REQ_BY";
       public            postgres    false    455            �           1259    35903    IX_INV_REQ_DETAIL_BRAND_ID    INDEX     _   CREATE INDEX "IX_INV_REQ_DETAIL_BRAND_ID" ON public."INV_REQ_DETAIL" USING btree ("BRAND_ID");
 0   DROP INDEX public."IX_INV_REQ_DETAIL_BRAND_ID";
       public            postgres    false    479            �           1259    35904    IX_INV_REQ_DETAIL_ITEM_ID    INDEX     ]   CREATE INDEX "IX_INV_REQ_DETAIL_ITEM_ID" ON public."INV_REQ_DETAIL" USING btree ("ITEM_ID");
 /   DROP INDEX public."IX_INV_REQ_DETAIL_ITEM_ID";
       public            postgres    false    479            �           1259    35905    IX_INV_REQ_DETAIL_REQ_MAST_ID    INDEX     e   CREATE INDEX "IX_INV_REQ_DETAIL_REQ_MAST_ID" ON public."INV_REQ_DETAIL" USING btree ("REQ_MAST_ID");
 3   DROP INDEX public."IX_INV_REQ_DETAIL_REQ_MAST_ID";
       public            postgres    false    479            �           1259    35906    IX_INV_REQ_DETAIL_SPEC_ID    INDEX     ]   CREATE INDEX "IX_INV_REQ_DETAIL_SPEC_ID" ON public."INV_REQ_DETAIL" USING btree ("SPEC_ID");
 /   DROP INDEX public."IX_INV_REQ_DETAIL_SPEC_ID";
       public            postgres    false    479            ]           1259    35913    IX_INV_ROOM_MST_DEPT_ID    INDEX     Y   CREATE INDEX "IX_INV_ROOM_MST_DEPT_ID" ON public."INV_ROOM_MST" USING btree ("DEPT_ID");
 -   DROP INDEX public."IX_INV_ROOM_MST_DEPT_ID";
       public            postgres    false    385            }           1259    35914    IX_INV_STATUS_DETAIL_ACCEPTBY    INDEX     e   CREATE INDEX "IX_INV_STATUS_DETAIL_ACCEPTBY" ON public."INV_STATUS_DETAIL" USING btree ("ACCEPTBY");
 3   DROP INDEX public."IX_INV_STATUS_DETAIL_ACCEPTBY";
       public            postgres    false    456            ~           1259    35915    IX_INV_STATUS_DETAIL_CHECKEDBY    INDEX     g   CREATE INDEX "IX_INV_STATUS_DETAIL_CHECKEDBY" ON public."INV_STATUS_DETAIL" USING btree ("CHECKEDBY");
 4   DROP INDEX public."IX_INV_STATUS_DETAIL_CHECKEDBY";
       public            postgres    false    456                       1259    35916    IX_INV_STATUS_DETAIL_PREBY    INDEX     _   CREATE INDEX "IX_INV_STATUS_DETAIL_PREBY" ON public."INV_STATUS_DETAIL" USING btree ("PREBY");
 0   DROP INDEX public."IX_INV_STATUS_DETAIL_PREBY";
       public            postgres    false    456            d           1259    35917    IX_MAP_AREA_GND_COV_REGIONID    INDEX     c   CREATE INDEX "IX_MAP_AREA_GND_COV_REGIONID" ON public."MAP_AREA_GND_COV" USING btree ("REGIONID");
 2   DROP INDEX public."IX_MAP_AREA_GND_COV_REGIONID";
       public            postgres    false    388            �           1259    35924    IX_MAP_INCOME_TYPE_ACC_ID    INDEX     ]   CREATE INDEX "IX_MAP_INCOME_TYPE_ACC_ID" ON public."MAP_INCOME_TYPE" USING btree ("ACC_ID");
 /   DROP INDEX public."IX_MAP_INCOME_TYPE_ACC_ID";
       public            postgres    false    412            g           1259    35928    IX_MAP_REGION_FAR_REGIONID    INDEX     _   CREATE INDEX "IX_MAP_REGION_FAR_REGIONID" ON public."MAP_REGION_FAR" USING btree ("REGIONID");
 0   DROP INDEX public."IX_MAP_REGION_FAR_REGIONID";
       public            postgres    false    389            x           1259    35938    IX_ORGANIZATION_TREE_GEO_REGION    INDEX     i   CREATE INDEX "IX_ORGANIZATION_TREE_GEO_REGION" ON public."ORGANIZATION_TREE" USING btree ("GEO_REGION");
 5   DROP INDEX public."IX_ORGANIZATION_TREE_GEO_REGION";
       public            postgres    false    394            y           1259    35939    IX_ORGANIZATION_TREE_PARENT_ID    INDEX     g   CREATE INDEX "IX_ORGANIZATION_TREE_PARENT_ID" ON public."ORGANIZATION_TREE" USING btree ("PARENT_ID");
 4   DROP INDEX public."IX_ORGANIZATION_TREE_PARENT_ID";
       public            postgres    false    394            �           1259    35935 &   IX_ORG_BANK_ACCOUNT_BANK_ACCNT_TYPE_ID    INDEX     w   CREATE INDEX "IX_ORG_BANK_ACCOUNT_BANK_ACCNT_TYPE_ID" ON public."ORG_BANK_ACCOUNT" USING btree ("BANK_ACCNT_TYPE_ID");
 <   DROP INDEX public."IX_ORG_BANK_ACCOUNT_BANK_ACCNT_TYPE_ID";
       public            postgres    false    426            �           1259    35936    IX_ORG_BANK_ACCOUNT_BRANCH_ID    INDEX     e   CREATE INDEX "IX_ORG_BANK_ACCOUNT_BRANCH_ID" ON public."ORG_BANK_ACCOUNT" USING btree ("BRANCH_ID");
 3   DROP INDEX public."IX_ORG_BANK_ACCOUNT_BRANCH_ID";
       public            postgres    false    426            �           1259    35937    IX_ORG_BANK_ACCOUNT_ORG_ID    INDEX     _   CREATE INDEX "IX_ORG_BANK_ACCOUNT_ORG_ID" ON public."ORG_BANK_ACCOUNT" USING btree ("ORG_ID");
 0   DROP INDEX public."IX_ORG_BANK_ACCOUNT_ORG_ID";
       public            postgres    false    426            �           1259    35940    IX_PIS_AWARDS_LOCAL_POST_ID    INDEX     a   CREATE INDEX "IX_PIS_AWARDS_LOCAL_POST_ID" ON public."PIS_AWARDS" USING btree ("LOCAL_POST_ID");
 1   DROP INDEX public."IX_PIS_AWARDS_LOCAL_POST_ID";
       public            postgres    false    428            �           1259    35941    IX_PIS_BANK_PAYROLL_BANK_ID    INDEX     a   CREATE INDEX "IX_PIS_BANK_PAYROLL_BANK_ID" ON public."PIS_BANK_PAYROLL" USING btree ("BANK_ID");
 1   DROP INDEX public."IX_PIS_BANK_PAYROLL_BANK_ID";
       public            postgres    false    457            �           1259    35942    IX_PIS_BANK_PAYROLL_EMP_ID    INDEX     _   CREATE INDEX "IX_PIS_BANK_PAYROLL_EMP_ID" ON public."PIS_BANK_PAYROLL" USING btree ("EMP_ID");
 0   DROP INDEX public."IX_PIS_BANK_PAYROLL_EMP_ID";
       public            postgres    false    457            �           1259    35943    IX_PIS_DARBANDI_LOCAL_POST_ID    INDEX     e   CREATE INDEX "IX_PIS_DARBANDI_LOCAL_POST_ID" ON public."PIS_DARBANDI" USING btree ("LOCAL_POST_ID");
 3   DROP INDEX public."IX_PIS_DARBANDI_LOCAL_POST_ID";
       public            postgres    false    429            �           1259    35944    IX_PIS_DARBANDI_OFFICE_ID    INDEX     ]   CREATE INDEX "IX_PIS_DARBANDI_OFFICE_ID" ON public."PIS_DARBANDI" USING btree ("OFFICE_ID");
 /   DROP INDEX public."IX_PIS_DARBANDI_OFFICE_ID";
       public            postgres    false    429                        1259    35945    IX_PIS_DARBANDI_POST_ID    INDEX     Y   CREATE INDEX "IX_PIS_DARBANDI_POST_ID" ON public."PIS_DARBANDI" USING btree ("POST_ID");
 -   DROP INDEX public."IX_PIS_DARBANDI_POST_ID";
       public            postgres    false    429            �           1259    35946 .   IX_PIS_DELETD_FRM_FULFILD_DARB_FRM_DARBANDI_ID    INDEX     �   CREATE INDEX "IX_PIS_DELETD_FRM_FULFILD_DARB_FRM_DARBANDI_ID" ON public."PIS_DELETD_FRM_FULFILD_DARB" USING btree ("FRM_DARBANDI_ID");
 D   DROP INDEX public."IX_PIS_DELETD_FRM_FULFILD_DARB_FRM_DARBANDI_ID";
       public            postgres    false    473            �           1259    35947 ,   IX_PIS_DELETD_FRM_FULFILD_DARB_FRM_OFFICE_ID    INDEX     �   CREATE INDEX "IX_PIS_DELETD_FRM_FULFILD_DARB_FRM_OFFICE_ID" ON public."PIS_DELETD_FRM_FULFILD_DARB" USING btree ("FRM_OFFICE_ID");
 B   DROP INDEX public."IX_PIS_DELETD_FRM_FULFILD_DARB_FRM_OFFICE_ID";
       public            postgres    false    473            �           1259    35948 +   IX_PIS_DELETD_FRM_FULFILD_DARB_FRM_SN_IN_FD    INDEX     �   CREATE INDEX "IX_PIS_DELETD_FRM_FULFILD_DARB_FRM_SN_IN_FD" ON public."PIS_DELETD_FRM_FULFILD_DARB" USING btree ("FRM_SN_IN_FD");
 A   DROP INDEX public."IX_PIS_DELETD_FRM_FULFILD_DARB_FRM_SN_IN_FD";
       public            postgres    false    473            �           1259    35949 *   IX_PIS_DELETD_FRM_FULFILD_DARB_TO_SN_IN_FD    INDEX        CREATE INDEX "IX_PIS_DELETD_FRM_FULFILD_DARB_TO_SN_IN_FD" ON public."PIS_DELETD_FRM_FULFILD_DARB" USING btree ("TO_SN_IN_FD");
 @   DROP INDEX public."IX_PIS_DELETD_FRM_FULFILD_DARB_TO_SN_IN_FD";
       public            postgres    false    473            q           1259    35950    IX_PIS_EDUCATION_BOARD_ID    INDEX     ]   CREATE INDEX "IX_PIS_EDUCATION_BOARD_ID" ON public."PIS_EDUCATION" USING btree ("BOARD_ID");
 /   DROP INDEX public."IX_PIS_EDUCATION_BOARD_ID";
       public            postgres    false    392            r           1259    35951    IX_PIS_EDUCATION_EDU_LEVEL_ID    INDEX     e   CREATE INDEX "IX_PIS_EDUCATION_EDU_LEVEL_ID" ON public."PIS_EDUCATION" USING btree ("EDU_LEVEL_ID");
 3   DROP INDEX public."IX_PIS_EDUCATION_EDU_LEVEL_ID";
       public            postgres    false    392                       1259    35967    IX_PIS_EMPLOYEE_MASTER_DEPT_ID    INDEX     g   CREATE INDEX "IX_PIS_EMPLOYEE_MASTER_DEPT_ID" ON public."PIS_EMPLOYEE_MASTER" USING btree ("DEPT_ID");
 4   DROP INDEX public."IX_PIS_EMPLOYEE_MASTER_DEPT_ID";
       public            postgres    false    430                       1259    35968 ,   IX_PIS_EMPLOYEE_MASTER_FIRST_APPOINT_POST_ID    INDEX     �   CREATE INDEX "IX_PIS_EMPLOYEE_MASTER_FIRST_APPOINT_POST_ID" ON public."PIS_EMPLOYEE_MASTER" USING btree ("FIRST_APPOINT_POST_ID");
 B   DROP INDEX public."IX_PIS_EMPLOYEE_MASTER_FIRST_APPOINT_POST_ID";
       public            postgres    false    430                       1259    35969 $   IX_PIS_EMPLOYEE_MASTER_LOCAL_POST_ID    INDEX     s   CREATE INDEX "IX_PIS_EMPLOYEE_MASTER_LOCAL_POST_ID" ON public."PIS_EMPLOYEE_MASTER" USING btree ("LOCAL_POST_ID");
 :   DROP INDEX public."IX_PIS_EMPLOYEE_MASTER_LOCAL_POST_ID";
       public            postgres    false    430                       1259    35970 '   IX_PIS_EMPLOYEE_MASTER_PAYEMENT_BANK_ID    INDEX     y   CREATE INDEX "IX_PIS_EMPLOYEE_MASTER_PAYEMENT_BANK_ID" ON public."PIS_EMPLOYEE_MASTER" USING btree ("PAYEMENT_BANK_ID");
 =   DROP INDEX public."IX_PIS_EMPLOYEE_MASTER_PAYEMENT_BANK_ID";
       public            postgres    false    430                       1259    35971    IX_PIS_EMPLOYEE_MASTER_POST_ID    INDEX     g   CREATE INDEX "IX_PIS_EMPLOYEE_MASTER_POST_ID" ON public."PIS_EMPLOYEE_MASTER" USING btree ("POST_ID");
 4   DROP INDEX public."IX_PIS_EMPLOYEE_MASTER_POST_ID";
       public            postgres    false    430            �           1259    35952    IX_PIS_EMP_ADV_DED_DTL_EMP_ID    INDEX     e   CREATE INDEX "IX_PIS_EMP_ADV_DED_DTL_EMP_ID" ON public."PIS_EMP_ADV_DED_DTL" USING btree ("EMP_ID");
 3   DROP INDEX public."IX_PIS_EMP_ADV_DED_DTL_EMP_ID";
       public            postgres    false    458            u           1259    35953 &   IX_PIS_EMP_DEP_SOURCE_BUDJET_SOURCE_ID    INDEX     w   CREATE INDEX "IX_PIS_EMP_DEP_SOURCE_BUDJET_SOURCE_ID" ON public."PIS_EMP_DEP_SOURCE" USING btree ("BUDJET_SOURCE_ID");
 <   DROP INDEX public."IX_PIS_EMP_DEP_SOURCE_BUDJET_SOURCE_ID";
       public            postgres    false    393            �           1259    35954    IX_PIS_EMP_LOANS_EMP_ID    INDEX     Y   CREATE INDEX "IX_PIS_EMP_LOANS_EMP_ID" ON public."PIS_EMP_LOANS" USING btree ("EMP_ID");
 -   DROP INDEX public."IX_PIS_EMP_LOANS_EMP_ID";
       public            postgres    false    459            �           1259    35955    IX_PIS_EMP_LONG_LEAVES_EMP_ID    INDEX     e   CREATE INDEX "IX_PIS_EMP_LONG_LEAVES_EMP_ID" ON public."PIS_EMP_LONG_LEAVES" USING btree ("EMP_ID");
 3   DROP INDEX public."IX_PIS_EMP_LONG_LEAVES_EMP_ID";
       public            postgres    false    460            �           1259    35956 $   IX_PIS_EMP_LONG_LEAVES_LOCAL_POST_ID    INDEX     s   CREATE INDEX "IX_PIS_EMP_LONG_LEAVES_LOCAL_POST_ID" ON public."PIS_EMP_LONG_LEAVES" USING btree ("LOCAL_POST_ID");
 :   DROP INDEX public."IX_PIS_EMP_LONG_LEAVES_LOCAL_POST_ID";
       public            postgres    false    460            �           1259    35957    IX_PIS_EMP_MED_EXPENSE_EMP_ID    INDEX     e   CREATE INDEX "IX_PIS_EMP_MED_EXPENSE_EMP_ID" ON public."PIS_EMP_MED_EXPENSE" USING btree ("EMP_ID");
 3   DROP INDEX public."IX_PIS_EMP_MED_EXPENSE_EMP_ID";
       public            postgres    false    461            �           1259    35958 $   IX_PIS_EMP_MED_EXPENSE_LOCAL_POST_ID    INDEX     s   CREATE INDEX "IX_PIS_EMP_MED_EXPENSE_LOCAL_POST_ID" ON public."PIS_EMP_MED_EXPENSE" USING btree ("LOCAL_POST_ID");
 :   DROP INDEX public."IX_PIS_EMP_MED_EXPENSE_LOCAL_POST_ID";
       public            postgres    false    461            �           1259    35959    IX_PIS_EMP_PUNISHMNTS_EMP_ID    INDEX     c   CREATE INDEX "IX_PIS_EMP_PUNISHMNTS_EMP_ID" ON public."PIS_EMP_PUNISHMNTS" USING btree ("EMP_ID");
 2   DROP INDEX public."IX_PIS_EMP_PUNISHMNTS_EMP_ID";
       public            postgres    false    462            �           1259    35960 #   IX_PIS_EMP_PUNISHMNTS_LOCAL_POST_ID    INDEX     q   CREATE INDEX "IX_PIS_EMP_PUNISHMNTS_LOCAL_POST_ID" ON public."PIS_EMP_PUNISHMNTS" USING btree ("LOCAL_POST_ID");
 9   DROP INDEX public."IX_PIS_EMP_PUNISHMNTS_LOCAL_POST_ID";
       public            postgres    false    462            �           1259    35961    IX_PIS_EMP_SRVC_DTLS_EMP_ID    INDEX     a   CREATE INDEX "IX_PIS_EMP_SRVC_DTLS_EMP_ID" ON public."PIS_EMP_SRVC_DTLS" USING btree ("EMP_ID");
 1   DROP INDEX public."IX_PIS_EMP_SRVC_DTLS_EMP_ID";
       public            postgres    false    463            �           1259    35962 "   IX_PIS_EMP_SRVC_DTLS_LOCAL_POST_ID    INDEX     o   CREATE INDEX "IX_PIS_EMP_SRVC_DTLS_LOCAL_POST_ID" ON public."PIS_EMP_SRVC_DTLS" USING btree ("LOCAL_POST_ID");
 8   DROP INDEX public."IX_PIS_EMP_SRVC_DTLS_LOCAL_POST_ID";
       public            postgres    false    463            �           1259    35963    IX_PIS_EMP_SUSPENDS_EMP_ID    INDEX     _   CREATE INDEX "IX_PIS_EMP_SUSPENDS_EMP_ID" ON public."PIS_EMP_SUSPENDS" USING btree ("EMP_ID");
 0   DROP INDEX public."IX_PIS_EMP_SUSPENDS_EMP_ID";
       public            postgres    false    464            �           1259    35964 !   IX_PIS_EMP_SUSPENDS_LOCAL_POST_ID    INDEX     m   CREATE INDEX "IX_PIS_EMP_SUSPENDS_LOCAL_POST_ID" ON public."PIS_EMP_SUSPENDS" USING btree ("LOCAL_POST_ID");
 7   DROP INDEX public."IX_PIS_EMP_SUSPENDS_LOCAL_POST_ID";
       public            postgres    false    464            �           1259    35965    IX_PIS_EMP_TRNSFR_REC_EMP_ID    INDEX     c   CREATE INDEX "IX_PIS_EMP_TRNSFR_REC_EMP_ID" ON public."PIS_EMP_TRNSFR_REC" USING btree ("EMP_ID");
 2   DROP INDEX public."IX_PIS_EMP_TRNSFR_REC_EMP_ID";
       public            postgres    false    465            �           1259    35966 #   IX_PIS_EMP_TRNSFR_REC_LOCAL_POST_ID    INDEX     q   CREATE INDEX "IX_PIS_EMP_TRNSFR_REC_LOCAL_POST_ID" ON public."PIS_EMP_TRNSFR_REC" USING btree ("LOCAL_POST_ID");
 9   DROP INDEX public."IX_PIS_EMP_TRNSFR_REC_LOCAL_POST_ID";
       public            postgres    false    465            
           1259    35972 #   IX_PIS_FOREIGN_VISITS_LOCAL_POST_ID    INDEX     q   CREATE INDEX "IX_PIS_FOREIGN_VISITS_LOCAL_POST_ID" ON public."PIS_FOREIGN_VISITS" USING btree ("LOCAL_POST_ID");
 9   DROP INDEX public."IX_PIS_FOREIGN_VISITS_LOCAL_POST_ID";
       public            postgres    false    431            V           1259    35973 %   IX_PIS_FULFILLED_DARBANDI_DARBANDI_ID    INDEX     u   CREATE INDEX "IX_PIS_FULFILLED_DARBANDI_DARBANDI_ID" ON public."PIS_FULFILLED_DARBANDI" USING btree ("DARBANDI_ID");
 ;   DROP INDEX public."IX_PIS_FULFILLED_DARBANDI_DARBANDI_ID";
       public            postgres    false    450            W           1259    35974 '   IX_PIS_FULFILLED_DARBANDI_LOCAL_POST_ID    INDEX     y   CREATE INDEX "IX_PIS_FULFILLED_DARBANDI_LOCAL_POST_ID" ON public."PIS_FULFILLED_DARBANDI" USING btree ("LOCAL_POST_ID");
 =   DROP INDEX public."IX_PIS_FULFILLED_DARBANDI_LOCAL_POST_ID";
       public            postgres    false    450            X           1259    35975 #   IX_PIS_FULFILLED_DARBANDI_OFFICE_ID    INDEX     q   CREATE INDEX "IX_PIS_FULFILLED_DARBANDI_OFFICE_ID" ON public."PIS_FULFILLED_DARBANDI" USING btree ("OFFICE_ID");
 9   DROP INDEX public."IX_PIS_FULFILLED_DARBANDI_OFFICE_ID";
       public            postgres    false    450            �           1259    35976 (   IX_PIS_INTERNAL_TRANSFER_APPOINTMNT_TYPE    INDEX     {   CREATE INDEX "IX_PIS_INTERNAL_TRANSFER_APPOINTMNT_TYPE" ON public."PIS_INTERNAL_TRANSFER" USING btree ("APPOINTMNT_TYPE");
 >   DROP INDEX public."IX_PIS_INTERNAL_TRANSFER_APPOINTMNT_TYPE";
       public            postgres    false    466            �           1259    35977 $   IX_PIS_INTERNAL_TRANSFER_DARBANDI_ID    INDEX     s   CREATE INDEX "IX_PIS_INTERNAL_TRANSFER_DARBANDI_ID" ON public."PIS_INTERNAL_TRANSFER" USING btree ("DARBANDI_ID");
 :   DROP INDEX public."IX_PIS_INTERNAL_TRANSFER_DARBANDI_ID";
       public            postgres    false    466            �           1259    35978    IX_PIS_INTERNAL_TRANSFER_EMP_ID    INDEX     i   CREATE INDEX "IX_PIS_INTERNAL_TRANSFER_EMP_ID" ON public."PIS_INTERNAL_TRANSFER" USING btree ("EMP_ID");
 5   DROP INDEX public."IX_PIS_INTERNAL_TRANSFER_EMP_ID";
       public            postgres    false    466            �           1259    35979 "   IX_PIS_INTERNAL_TRANSFER_OFFICE_ID    INDEX     o   CREATE INDEX "IX_PIS_INTERNAL_TRANSFER_OFFICE_ID" ON public."PIS_INTERNAL_TRANSFER" USING btree ("OFFICE_ID");
 8   DROP INDEX public."IX_PIS_INTERNAL_TRANSFER_OFFICE_ID";
       public            postgres    false    466            �           1259    35980 +   IX_PIS_INTERNAL_TRANSFER_TO_APPOINTMNT_TYPE    INDEX     �   CREATE INDEX "IX_PIS_INTERNAL_TRANSFER_TO_APPOINTMNT_TYPE" ON public."PIS_INTERNAL_TRANSFER" USING btree ("TO_APPOINTMNT_TYPE");
 A   DROP INDEX public."IX_PIS_INTERNAL_TRANSFER_TO_APPOINTMNT_TYPE";
       public            postgres    false    466            �           1259    35981 )   IX_PIS_INTERNAL_TRANSFER_TO_LOCAL_POST_ID    INDEX     }   CREATE INDEX "IX_PIS_INTERNAL_TRANSFER_TO_LOCAL_POST_ID" ON public."PIS_INTERNAL_TRANSFER" USING btree ("TO_LOCAL_POST_ID");
 ?   DROP INDEX public."IX_PIS_INTERNAL_TRANSFER_TO_LOCAL_POST_ID";
       public            postgres    false    466            �           1259    35982 %   IX_PIS_INTERNAL_TRANSFER_TO_OFFICE_ID    INDEX     u   CREATE INDEX "IX_PIS_INTERNAL_TRANSFER_TO_OFFICE_ID" ON public."PIS_INTERNAL_TRANSFER" USING btree ("TO_OFFICE_ID");
 ;   DROP INDEX public."IX_PIS_INTERNAL_TRANSFER_TO_OFFICE_ID";
       public            postgres    false    466            |           1259    35983     IX_PIS_LOCAL_POST_MASTER_POST_ID    INDEX     k   CREATE INDEX "IX_PIS_LOCAL_POST_MASTER_POST_ID" ON public."PIS_LOCAL_POST_MASTER" USING btree ("POST_ID");
 6   DROP INDEX public."IX_PIS_LOCAL_POST_MASTER_POST_ID";
       public            postgres    false    395            �           1259    35984 %   IX_PIS_NIJAMATI_SEWA_SAMUHA_PARENT_ID    INDEX     u   CREATE INDEX "IX_PIS_NIJAMATI_SEWA_SAMUHA_PARENT_ID" ON public."PIS_NIJAMATI_SEWA_SAMUHA" USING btree ("PARENT_ID");
 ;   DROP INDEX public."IX_PIS_NIJAMATI_SEWA_SAMUHA_PARENT_ID";
       public            postgres    false    309                       1259    35985 "   IX_PIS_OTHER_ADD_SUB_LOCAL_POST_ID    INDEX     o   CREATE INDEX "IX_PIS_OTHER_ADD_SUB_LOCAL_POST_ID" ON public."PIS_OTHER_ADD_SUB" USING btree ("LOCAL_POST_ID");
 8   DROP INDEX public."IX_PIS_OTHER_ADD_SUB_LOCAL_POST_ID";
       public            postgres    false    432                       1259    35986    IX_PIS_PRIZES_LOCAL_POST_ID    INDEX     a   CREATE INDEX "IX_PIS_PRIZES_LOCAL_POST_ID" ON public."PIS_PRIZES" USING btree ("LOCAL_POST_ID");
 1   DROP INDEX public."IX_PIS_PRIZES_LOCAL_POST_ID";
       public            postgres    false    433                       1259    35987     IX_PIS_PUBLICATION_LOCAL_POST_ID    INDEX     k   CREATE INDEX "IX_PIS_PUBLICATION_LOCAL_POST_ID" ON public."PIS_PUBLICATION" USING btree ("LOCAL_POST_ID");
 6   DROP INDEX public."IX_PIS_PUBLICATION_LOCAL_POST_ID";
       public            postgres    false    434            �           1259    35988    IX_PIS_PYROLL_LOAN_DTLS_ACC_ID    INDEX     g   CREATE INDEX "IX_PIS_PYROLL_LOAN_DTLS_ACC_ID" ON public."PIS_PYROLL_LOAN_DTLS" USING btree ("ACC_ID");
 4   DROP INDEX public."IX_PIS_PYROLL_LOAN_DTLS_ACC_ID";
       public            postgres    false    480            �           1259    35989    IX_PIS_PYROLL_LOAN_DTLS_EMP_ID    INDEX     g   CREATE INDEX "IX_PIS_PYROLL_LOAN_DTLS_EMP_ID" ON public."PIS_PYROLL_LOAN_DTLS" USING btree ("EMP_ID");
 4   DROP INDEX public."IX_PIS_PYROLL_LOAN_DTLS_EMP_ID";
       public            postgres    false    480            �           1259    35990     IX_PIS_PYROLL_LOAN_DTLS_LOAND_ID    INDEX     k   CREATE INDEX "IX_PIS_PYROLL_LOAN_DTLS_LOAND_ID" ON public."PIS_PYROLL_LOAN_DTLS" USING btree ("LOAND_ID");
 6   DROP INDEX public."IX_PIS_PYROLL_LOAN_DTLS_LOAND_ID";
       public            postgres    false    480            �           1259    35991 "   IX_PIS_PYROLL_LOAN_DTLS_PAYROLL_ID    INDEX     o   CREATE INDEX "IX_PIS_PYROLL_LOAN_DTLS_PAYROLL_ID" ON public."PIS_PYROLL_LOAN_DTLS" USING btree ("PAYROLL_ID");
 8   DROP INDEX public."IX_PIS_PYROLL_LOAN_DTLS_PAYROLL_ID";
       public            postgres    false    480            �           1259    35992 #   IX_PIS_PYROLL_OTHR_DTLS_EMPLOYEE_ID    INDEX     q   CREATE INDEX "IX_PIS_PYROLL_OTHR_DTLS_EMPLOYEE_ID" ON public."PIS_PYROLL_OTHR_DTLS" USING btree ("EMPLOYEE_ID");
 9   DROP INDEX public."IX_PIS_PYROLL_OTHR_DTLS_EMPLOYEE_ID";
       public            postgres    false    467            �           1259    35993 "   IX_PIS_PYROLL_OTHR_DTLS_PAYROLL_ID    INDEX     o   CREATE INDEX "IX_PIS_PYROLL_OTHR_DTLS_PAYROLL_ID" ON public."PIS_PYROLL_OTHR_DTLS" USING btree ("PAYROLL_ID");
 8   DROP INDEX public."IX_PIS_PYROLL_OTHR_DTLS_PAYROLL_ID";
       public            postgres    false    467            �           1259    35994 '   IX_PIS_REPLACED_IN_DARBANDI_DARBANDI_ID    INDEX     y   CREATE INDEX "IX_PIS_REPLACED_IN_DARBANDI_DARBANDI_ID" ON public."PIS_REPLACED_IN_DARBANDI" USING btree ("DARBANDI_ID");
 =   DROP INDEX public."IX_PIS_REPLACED_IN_DARBANDI_DARBANDI_ID";
       public            postgres    false    474            �           1259    35995 *   IX_PIS_REPLACED_IN_DARBANDI_ENTRY_SN_IN_FD    INDEX        CREATE INDEX "IX_PIS_REPLACED_IN_DARBANDI_ENTRY_SN_IN_FD" ON public."PIS_REPLACED_IN_DARBANDI" USING btree ("ENTRY_SN_IN_FD");
 @   DROP INDEX public."IX_PIS_REPLACED_IN_DARBANDI_ENTRY_SN_IN_FD";
       public            postgres    false    474            �           1259    35996 %   IX_PIS_REPLACED_IN_DARBANDI_OFFICE_ID    INDEX     u   CREATE INDEX "IX_PIS_REPLACED_IN_DARBANDI_OFFICE_ID" ON public."PIS_REPLACED_IN_DARBANDI" USING btree ("OFFICE_ID");
 ;   DROP INDEX public."IX_PIS_REPLACED_IN_DARBANDI_OFFICE_ID";
       public            postgres    false    474                       1259    35997 !   IX_PIS_SGNFCNT_WORK_LOCAL_POST_ID    INDEX     m   CREATE INDEX "IX_PIS_SGNFCNT_WORK_LOCAL_POST_ID" ON public."PIS_SGNFCNT_WORK" USING btree ("LOCAL_POST_ID");
 7   DROP INDEX public."IX_PIS_SGNFCNT_WORK_LOCAL_POST_ID";
       public            postgres    false    435                       1259    35998    IX_PIS_TRAINING_LOCAL_POST_ID    INDEX     e   CREATE INDEX "IX_PIS_TRAINING_LOCAL_POST_ID" ON public."PIS_TRAINING" USING btree ("LOCAL_POST_ID");
 3   DROP INDEX public."IX_PIS_TRAINING_LOCAL_POST_ID";
       public            postgres    false    436            �           1259    35999 !   IX_PIS_VISITED_COUNTRIES_VISIT_ID    INDEX     m   CREATE INDEX "IX_PIS_VISITED_COUNTRIES_VISIT_ID" ON public."PIS_VISITED_COUNTRIES" USING btree ("VISIT_ID");
 7   DROP INDEX public."IX_PIS_VISITED_COUNTRIES_VISIT_ID";
       public            postgres    false    469                       1259    36000    IX_PIS_WORKSHOP_LOCAL_POST_ID    INDEX     e   CREATE INDEX "IX_PIS_WORKSHOP_LOCAL_POST_ID" ON public."PIS_WORKSHOP" USING btree ("LOCAL_POST_ID");
 3   DROP INDEX public."IX_PIS_WORKSHOP_LOCAL_POST_ID";
       public            postgres    false    437                       1259    36001    IX_SANITATION_RATE_GROUPID    INDEX     _   CREATE INDEX "IX_SANITATION_RATE_GROUPID" ON public."SANITATION_RATE" USING btree ("GROUPID");
 0   DROP INDEX public."IX_SANITATION_RATE_GROUPID";
       public            postgres    false    438                        1259    36002    IX_SANITATION_RATE_SUBGROUPID    INDEX     e   CREATE INDEX "IX_SANITATION_RATE_SUBGROUPID" ON public."SANITATION_RATE" USING btree ("SUBGROUPID");
 3   DROP INDEX public."IX_SANITATION_RATE_SUBGROUPID";
       public            postgres    false    438                       1259    36003    IX_SANITATION_SUBGROUP_GROUPID    INDEX     g   CREATE INDEX "IX_SANITATION_SUBGROUP_GROUPID" ON public."SANITATION_SUBGROUP" USING btree ("GROUPID");
 4   DROP INDEX public."IX_SANITATION_SUBGROUP_GROUPID";
       public            postgres    false    396            �           1259    36004    IX_SERVICE_CHARGE_MASTER_ACC_ID    INDEX     i   CREATE INDEX "IX_SERVICE_CHARGE_MASTER_ACC_ID" ON public."SERVICE_CHARGE_MASTER" USING btree ("ACC_ID");
 5   DROP INDEX public."IX_SERVICE_CHARGE_MASTER_ACC_ID";
       public            postgres    false    413            �           1259    36005    IX_STOREDBILLS_BILLTYPEID    INDEX     ]   CREATE INDEX "IX_STOREDBILLS_BILLTYPEID" ON public."STOREDBILLS" USING btree ("BILLTYPEID");
 /   DROP INDEX public."IX_STOREDBILLS_BILLTYPEID";
       public            postgres    false    400            X           1259    36006 %   IX_SUB_MODULE_SOURCE_BUDJET_SOURCE_ID    INDEX     u   CREATE INDEX "IX_SUB_MODULE_SOURCE_BUDJET_SOURCE_ID" ON public."SUB_MODULE_SOURCE" USING btree ("BUDJET_SOURCE_ID");
 ;   DROP INDEX public."IX_SUB_MODULE_SOURCE_BUDJET_SOURCE_ID";
       public            postgres    false    384            �           1259    36008    IX_TAX_ADDTNL_CHRG_DTLS_ACCODE    INDEX     g   CREATE INDEX "IX_TAX_ADDTNL_CHRG_DTLS_ACCODE" ON public."TAX_ADDTNL_CHRG_DTLS" USING btree ("ACCODE");
 4   DROP INDEX public."IX_TAX_ADDTNL_CHRG_DTLS_ACCODE";
       public            postgres    false    414            �           1259    36007    IX_TAX_ADDTNL_CHRG_DTLS_ACC_ID    INDEX     g   CREATE INDEX "IX_TAX_ADDTNL_CHRG_DTLS_ACC_ID" ON public."TAX_ADDTNL_CHRG_DTLS" USING btree ("ACC_ID");
 4   DROP INDEX public."IX_TAX_ADDTNL_CHRG_DTLS_ACC_ID";
       public            postgres    false    414            *           1259    36009    IX_TAX_THLI_ISSUED_CNTR_CNTR_ID    INDEX     i   CREATE INDEX "IX_TAX_THLI_ISSUED_CNTR_CNTR_ID" ON public."TAX_THLI_ISSUED_CNTR" USING btree ("CNTR_ID");
 5   DROP INDEX public."IX_TAX_THLI_ISSUED_CNTR_CNTR_ID";
       public            postgres    false    441            +           1259    36010     IX_TAX_THLI_ISSUED_CNTR_THELI_ID    INDEX     k   CREATE INDEX "IX_TAX_THLI_ISSUED_CNTR_THELI_ID" ON public."TAX_THLI_ISSUED_CNTR" USING btree ("THELI_ID");
 6   DROP INDEX public."IX_TAX_THLI_ISSUED_CNTR_THELI_ID";
       public            postgres    false    441            �           1259    36026 $   IX_TBLBUSINESS_SERVICE_CH_MST_ACC_ID    INDEX     s   CREATE INDEX "IX_TBLBUSINESS_SERVICE_CH_MST_ACC_ID" ON public."TBLBUSINESS_SERVICE_CH_MST" USING btree ("ACC_ID");
 :   DROP INDEX public."IX_TBLBUSINESS_SERVICE_CH_MST_ACC_ID";
       public            postgres    false    417            �           1259    36027    IX_TBLFYWISEMPOTASSRATE_GROUPID    INDEX     i   CREATE INDEX "IX_TBLFYWISEMPOTASSRATE_GROUPID" ON public."TBLFYWISEMPOTASSRATE" USING btree ("GROUPID");
 5   DROP INDEX public."IX_TBLFYWISEMPOTASSRATE_GROUPID";
       public            postgres    false    471            �           1259    36028    IX_TBLFYWISEMPOTASSRATE_RATEID    INDEX     g   CREATE INDEX "IX_TBLFYWISEMPOTASSRATE_RATEID" ON public."TBLFYWISEMPOTASSRATE" USING btree ("RATEID");
 4   DROP INDEX public."IX_TBLFYWISEMPOTASSRATE_RATEID";
       public            postgres    false    471            �           1259    36029 "   IX_TBLFYWISEMPOTASSRATE_SUBGROUPID    INDEX     o   CREATE INDEX "IX_TBLFYWISEMPOTASSRATE_SUBGROUPID" ON public."TBLFYWISEMPOTASSRATE" USING btree ("SUBGROUPID");
 8   DROP INDEX public."IX_TBLFYWISEMPOTASSRATE_SUBGROUPID";
       public            postgres    false    471            .           1259    36030    IX_TBLMALPOTRATES_GROUPID    INDEX     ]   CREATE INDEX "IX_TBLMALPOTRATES_GROUPID" ON public."TBLMALPOTRATES" USING btree ("GROUPID");
 /   DROP INDEX public."IX_TBLMALPOTRATES_GROUPID";
       public            postgres    false    442            /           1259    36031    IX_TBLMALPOTRATES_SUBGROUPID    INDEX     c   CREATE INDEX "IX_TBLMALPOTRATES_SUBGROUPID" ON public."TBLMALPOTRATES" USING btree ("SUBGROUPID");
 2   DROP INDEX public."IX_TBLMALPOTRATES_SUBGROUPID";
       public            postgres    false    442            �           1259    36032    IX_TBLMALPOTSUBGROUP_GROUPID    INDEX     c   CREATE INDEX "IX_TBLMALPOTSUBGROUP_GROUPID" ON public."TBLMALPOTSUBGROUP" USING btree ("GROUPID");
 2   DROP INDEX public."IX_TBLMALPOTSUBGROUP_GROUPID";
       public            postgres    false    401            �           1259    36033    IX_TBLVEH_SER_CH_MSTR_ACC_ID    INDEX     c   CREATE INDEX "IX_TBLVEH_SER_CH_MSTR_ACC_ID" ON public."TBLVEH_SER_CH_MSTR" USING btree ("ACC_ID");
 2   DROP INDEX public."IX_TBLVEH_SER_CH_MSTR_ACC_ID";
       public            postgres    false    418            �           1259    36011    IX_TBL_BGT_MGMT_EXP_BGT_MGMT_ID    INDEX     i   CREATE INDEX "IX_TBL_BGT_MGMT_EXP_BGT_MGMT_ID" ON public."TBL_BGT_MGMT_EXP" USING btree ("BGT_MGMT_ID");
 5   DROP INDEX public."IX_TBL_BGT_MGMT_EXP_BGT_MGMT_ID";
       public            postgres    false    397            �           1259    36012 '   IX_TBL_BGT_MGMT_EXP_ORG_BGT_MGMT_ORG_ID    INDEX     y   CREATE INDEX "IX_TBL_BGT_MGMT_EXP_ORG_BGT_MGMT_ORG_ID" ON public."TBL_BGT_MGMT_EXP_ORG" USING btree ("BGT_MGMT_ORG_ID");
 =   DROP INDEX public."IX_TBL_BGT_MGMT_EXP_ORG_BGT_MGMT_ORG_ID";
       public            postgres    false    398            2           1259    36013 /   IX_TBL_BGT_MGMT_EXP_RELEASE_BGT_MGMT_RELEASE_ID    INDEX     �   CREATE INDEX "IX_TBL_BGT_MGMT_EXP_RELEASE_BGT_MGMT_RELEASE_ID" ON public."TBL_BGT_MGMT_EXP_RELEASE" USING btree ("BGT_MGMT_RELEASE_ID");
 E   DROP INDEX public."IX_TBL_BGT_MGMT_EXP_RELEASE_BGT_MGMT_RELEASE_ID";
       public            postgres    false    443            �           1259    36014 &   IX_TBL_BGT_MGMT_RELEASE_BGT_RELEASE_ID    INDEX     w   CREATE INDEX "IX_TBL_BGT_MGMT_RELEASE_BGT_RELEASE_ID" ON public."TBL_BGT_MGMT_RELEASE" USING btree ("BGT_RELEASE_ID");
 <   DROP INDEX public."IX_TBL_BGT_MGMT_RELEASE_BGT_RELEASE_ID";
       public            postgres    false    407            #           1259    36015 #   IX_TBL_BGT_MGMT_SRC_BGT_MGMT_EXP_ID    INDEX     q   CREATE INDEX "IX_TBL_BGT_MGMT_SRC_BGT_MGMT_EXP_ID" ON public."TBL_BGT_MGMT_SRC" USING btree ("BGT_MGMT_EXP_ID");
 9   DROP INDEX public."IX_TBL_BGT_MGMT_SRC_BGT_MGMT_EXP_ID";
       public            postgres    false    439            &           1259    36016 +   IX_TBL_BGT_MGMT_SRC_ORG_BGT_MGMT_EXP_ORG_ID    INDEX     �   CREATE INDEX "IX_TBL_BGT_MGMT_SRC_ORG_BGT_MGMT_EXP_ORG_ID" ON public."TBL_BGT_MGMT_SRC_ORG" USING btree ("BGT_MGMT_EXP_ORG_ID");
 A   DROP INDEX public."IX_TBL_BGT_MGMT_SRC_ORG_BGT_MGMT_EXP_ORG_ID";
       public            postgres    false    440            '           1259    36017    IX_TBL_BGT_MGMT_SRC_ORG_CC_ID    INDEX     e   CREATE INDEX "IX_TBL_BGT_MGMT_SRC_ORG_CC_ID" ON public."TBL_BGT_MGMT_SRC_ORG" USING btree ("CC_ID");
 3   DROP INDEX public."IX_TBL_BGT_MGMT_SRC_ORG_CC_ID";
       public            postgres    false    440            �           1259    36018 3   IX_TBL_BGT_MGMT_SRC_RELEASE_BGT_MGMT_EXP_RELEASE_ID    INDEX     �   CREATE INDEX "IX_TBL_BGT_MGMT_SRC_RELEASE_BGT_MGMT_EXP_RELEASE_ID" ON public."TBL_BGT_MGMT_SRC_RELEASE" USING btree ("BGT_MGMT_EXP_RELEASE_ID");
 I   DROP INDEX public."IX_TBL_BGT_MGMT_SRC_RELEASE_BGT_MGMT_EXP_RELEASE_ID";
       public            postgres    false    472            �           1259    36019 !   IX_TBL_BGT_MGMT_SRC_RELEASE_CC_ID    INDEX     m   CREATE INDEX "IX_TBL_BGT_MGMT_SRC_RELEASE_CC_ID" ON public."TBL_BGT_MGMT_SRC_RELEASE" USING btree ("CC_ID");
 7   DROP INDEX public."IX_TBL_BGT_MGMT_SRC_RELEASE_CC_ID";
       public            postgres    false    472            =           1259    36020    IX_TBL_BGT_RELEASE_ORG_ID    INDEX     ]   CREATE INDEX "IX_TBL_BGT_RELEASE_ORG_ID" ON public."TBL_BGT_RELEASE" USING btree ("ORG_ID");
 /   DROP INDEX public."IX_TBL_BGT_RELEASE_ORG_ID";
       public            postgres    false    375            �           1259    36021 (   IX_TBL_CONSTRUCTION_OTHER_CHARGES_ACC_ID    INDEX     {   CREATE INDEX "IX_TBL_CONSTRUCTION_OTHER_CHARGES_ACC_ID" ON public."TBL_CONSTRUCTION_OTHER_CHARGES" USING btree ("ACC_ID");
 >   DROP INDEX public."IX_TBL_CONSTRUCTION_OTHER_CHARGES_ACC_ID";
       public            postgres    false    415            �           1259    36022     IX_TBL_LAND_OTHER_CHARGES_ACC_ID    INDEX     k   CREATE INDEX "IX_TBL_LAND_OTHER_CHARGES_ACC_ID" ON public."TBL_LAND_OTHER_CHARGES" USING btree ("ACC_ID");
 6   DROP INDEX public."IX_TBL_LAND_OTHER_CHARGES_ACC_ID";
       public            postgres    false    416            �           1259    36023 "   IX_TBL_MALPOT_OTHER_CHARGES_ACC_ID    INDEX     o   CREATE INDEX "IX_TBL_MALPOT_OTHER_CHARGES_ACC_ID" ON public."TBL_MALPOT_OTHER_CHARGES" USING btree ("ACC_ID");
 8   DROP INDEX public."IX_TBL_MALPOT_OTHER_CHARGES_ACC_ID";
       public            postgres    false    470            �           1259    36024 "   IX_TBL_MALPOT_OTHER_CHARGES_RATEID    INDEX     o   CREATE INDEX "IX_TBL_MALPOT_OTHER_CHARGES_RATEID" ON public."TBL_MALPOT_OTHER_CHARGES" USING btree ("RATEID");
 8   DROP INDEX public."IX_TBL_MALPOT_OTHER_CHARGES_RATEID";
       public            postgres    false    470            �           1259    36025 -   IX_TBL_PAYMENT_ORDER_DETAILS_PAYMENT_ORDER_ID    INDEX     �   CREATE INDEX "IX_TBL_PAYMENT_ORDER_DETAILS_PAYMENT_ORDER_ID" ON public."TBL_PAYMENT_ORDER_DETAILS" USING btree ("PAYMENT_ORDER_ID");
 C   DROP INDEX public."IX_TBL_PAYMENT_ORDER_DETAILS_PAYMENT_ORDER_ID";
       public            postgres    false    399            �           1259    36036    IX_WARD_MASTER_PRAMUKH_ID    INDEX     ]   CREATE INDEX "IX_WARD_MASTER_PRAMUKH_ID" ON public."WARD_MASTER" USING btree ("PRAMUKH_ID");
 /   DROP INDEX public."IX_WARD_MASTER_PRAMUKH_ID";
       public            postgres    false    468            �           1259    36037    IX_WARD_MASTER_UPPRAMUKH_ID    INDEX     a   CREATE INDEX "IX_WARD_MASTER_UPPRAMUKH_ID" ON public."WARD_MASTER" USING btree ("UPPRAMUKH_ID");
 1   DROP INDEX public."IX_WARD_MASTER_UPPRAMUKH_ID";
       public            postgres    false    468            �           1259    36038     IX_WARD_MASTER_WARD_SECRETARY_ID    INDEX     k   CREATE INDEX "IX_WARD_MASTER_WARD_SECRETARY_ID" ON public."WARD_MASTER" USING btree ("WARD_SECRETARY_ID");
 6   DROP INDEX public."IX_WARD_MASTER_WARD_SECRETARY_ID";
       public            postgres    false    468            �           1259    35918     MAP_CONSTRCTION_KIND_NAME_NP_key    INDEX     q   CREATE UNIQUE INDEX "MAP_CONSTRCTION_KIND_NAME_NP_key" ON public."MAP_CONSTRCTION_KIND" USING btree ("NAME_NP");
 6   DROP INDEX public."MAP_CONSTRCTION_KIND_NAME_NP_key";
       public            postgres    false    273            �           1259    35919    MAP_DESIGNER_DTL_REG_NO_key    INDEX     g   CREATE UNIQUE INDEX "MAP_DESIGNER_DTL_REG_NO_key" ON public."MAP_DESIGNER_DTL" USING btree ("REG_NO");
 1   DROP INDEX public."MAP_DESIGNER_DTL_REG_NO_key";
       public            postgres    false    274            �           1259    35920    MAP_DIRECTION_NAME_NP_key    INDEX     c   CREATE UNIQUE INDEX "MAP_DIRECTION_NAME_NP_key" ON public."MAP_DIRECTION" USING btree ("NAME_NP");
 /   DROP INDEX public."MAP_DIRECTION_NAME_NP_key";
       public            postgres    false    275            �           1259    35921    MAP_DRAIN_TYPE_NAME_NP_key    INDEX     e   CREATE UNIQUE INDEX "MAP_DRAIN_TYPE_NAME_NP_key" ON public."MAP_DRAIN_TYPE" USING btree ("NAME_NP");
 0   DROP INDEX public."MAP_DRAIN_TYPE_NAME_NP_key";
       public            postgres    false    276            �           1259    35922    MAP_FLOOR_NAME_NP_key    INDEX     [   CREATE UNIQUE INDEX "MAP_FLOOR_NAME_NP_key" ON public."MAP_FLOOR" USING btree ("NAME_NP");
 +   DROP INDEX public."MAP_FLOOR_NAME_NP_key";
       public            postgres    false    277            �           1259    35923    MAP_HOUSEUSE_TYPE_NAME_NP_key    INDEX     k   CREATE UNIQUE INDEX "MAP_HOUSEUSE_TYPE_NAME_NP_key" ON public."MAP_HOUSEUSE_TYPE" USING btree ("NAME_NP");
 3   DROP INDEX public."MAP_HOUSEUSE_TYPE_NAME_NP_key";
       public            postgres    false    278            �           1259    35925    MAP_INCOME_TYPE_NAME_NP_key    INDEX     g   CREATE UNIQUE INDEX "MAP_INCOME_TYPE_NAME_NP_key" ON public."MAP_INCOME_TYPE" USING btree ("NAME_NP");
 1   DROP INDEX public."MAP_INCOME_TYPE_NAME_NP_key";
       public            postgres    false    412            �           1259    35926    MAP_LAND_OWNER_TYPE_NAME_NP_key    INDEX     o   CREATE UNIQUE INDEX "MAP_LAND_OWNER_TYPE_NAME_NP_key" ON public."MAP_LAND_OWNER_TYPE" USING btree ("NAME_NP");
 5   DROP INDEX public."MAP_LAND_OWNER_TYPE_NAME_NP_key";
       public            postgres    false    280            �           1259    35927    MAP_NEIGHBOUR_TYPE_NAME_NP_key    INDEX     m   CREATE UNIQUE INDEX "MAP_NEIGHBOUR_TYPE_NAME_NP_key" ON public."MAP_NEIGHBOUR_TYPE" USING btree ("NAME_NP");
 4   DROP INDEX public."MAP_NEIGHBOUR_TYPE_NAME_NP_key";
       public            postgres    false    281            �           1259    35929 !   MAP_ROOF_CNSTRCT_TYPE_NAME_NP_key    INDEX     s   CREATE UNIQUE INDEX "MAP_ROOF_CNSTRCT_TYPE_NAME_NP_key" ON public."MAP_ROOF_CNSTRCT_TYPE" USING btree ("NAME_NP");
 7   DROP INDEX public."MAP_ROOF_CNSTRCT_TYPE_NAME_NP_key";
       public            postgres    false    283            �           1259    35930    MAP_ROOF_TYPE_NAME_NP_key    INDEX     c   CREATE UNIQUE INDEX "MAP_ROOF_TYPE_NAME_NP_key" ON public."MAP_ROOF_TYPE" USING btree ("NAME_NP");
 /   DROP INDEX public."MAP_ROOF_TYPE_NAME_NP_key";
       public            postgres    false    284            �           1259    35931    MAP_STOREYS_NAME_NP_key    INDEX     _   CREATE UNIQUE INDEX "MAP_STOREYS_NAME_NP_key" ON public."MAP_STOREYS" USING btree ("NAME_NP");
 -   DROP INDEX public."MAP_STOREYS_NAME_NP_key";
       public            postgres    false    287            �           1259    35932    MAP_STRUCTURE_TYPE_NAME_NP_key    INDEX     m   CREATE UNIQUE INDEX "MAP_STRUCTURE_TYPE_NAME_NP_key" ON public."MAP_STRUCTURE_TYPE" USING btree ("NAME_NP");
 4   DROP INDEX public."MAP_STRUCTURE_TYPE_NAME_NP_key";
       public            postgres    false    288            �           1259    35933    MAP_ZONE_NAME_NP_key    INDEX     Y   CREATE UNIQUE INDEX "MAP_ZONE_NAME_NP_key" ON public."MAP_ZONE" USING btree ("NAME_NP");
 *   DROP INDEX public."MAP_ZONE_NAME_NP_key";
       public            postgres    false    289            �           1259    35934    MINISTRY_CODE_key    INDEX     S   CREATE UNIQUE INDEX "MINISTRY_CODE_key" ON public."MINISTRY" USING btree ("CODE");
 '   DROP INDEX public."MINISTRY_CODE_key";
       public            postgres    false    290            J           1259    35837    RoleNameIndex    INDEX     \   CREATE UNIQUE INDEX "RoleNameIndex" ON public."AspNetRoles" USING btree ("NormalizedName");
 #   DROP INDEX public."RoleNameIndex";
       public            postgres    false    223            6           1259    36035    UserNameIndex    INDEX     _   CREATE UNIQUE INDEX "UserNameIndex" ON public."Usermaster" USING btree ("NormalizedUserName");
 #   DROP INDEX public."UserNameIndex";
       public            postgres    false    370            �           2606    35204 %   INV_PUR_ORDER_MAST FK_ACCEPTED_BY_USR    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_PUR_ORDER_MAST"
    ADD CONSTRAINT "FK_ACCEPTED_BY_USR" FOREIGN KEY ("ACCEPTED_BY") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 S   ALTER TABLE ONLY public."INV_PUR_ORDER_MAST" DROP CONSTRAINT "FK_ACCEPTED_BY_USR";
       public          postgres    false    4361    454    430            �           2606    35113 &   INV_GOODS_ADJUST FK_ACCEPT_BY_GOOD_ADJ    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_GOODS_ADJUST"
    ADD CONSTRAINT "FK_ACCEPT_BY_GOOD_ADJ" FOREIGN KEY ("ACCEPT_BY") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 T   ALTER TABLE ONLY public."INV_GOODS_ADJUST" DROP CONSTRAINT "FK_ACCEPT_BY_GOOD_ADJ";
       public          postgres    false    451    4361    430            �           2606    35146 (   INV_GOODS_REC_MAST FK_ACCEPT_BY_GOOD_EMP    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_GOODS_REC_MAST"
    ADD CONSTRAINT "FK_ACCEPT_BY_GOOD_EMP" FOREIGN KEY ("ACCEPT_BY") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 V   ALTER TABLE ONLY public."INV_GOODS_REC_MAST" DROP CONSTRAINT "FK_ACCEPT_BY_GOOD_EMP";
       public          postgres    false    430    4361    452                       2606    33995 &   ACC_ACC_MASTER FK_ACC_ACC_MASTER_TYPID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_ACC_MASTER"
    ADD CONSTRAINT "FK_ACC_ACC_MASTER_TYPID" FOREIGN KEY ("TYPE_ID") REFERENCES public."ACC_TRANS_TYPE"("TYPE_ID") ON DELETE RESTRICT;
 T   ALTER TABLE ONLY public."ACC_ACC_MASTER" DROP CONSTRAINT "FK_ACC_ACC_MASTER_TYPID";
       public          postgres    false    377    216    3899            �           2606    33946 #   ACC_BGT_RVSN FK_ACC_BGT_RVSN_BGT_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_BGT_RVSN"
    ADD CONSTRAINT "FK_ACC_BGT_RVSN_BGT_ID" FOREIGN KEY ("BGT_ALCTN_ID") REFERENCES public."ACC_BGT_ALLOCATE"("BGT_ALLOCATE_ID") ON DELETE RESTRICT;
 Q   ALTER TABLE ONLY public."ACC_BGT_RVSN" DROP CONSTRAINT "FK_ACC_BGT_RVSN_BGT_ID";
       public          postgres    false    373    3879    204            �           2606    33956 (   ACC_CURRENCTY_RATE FK_ACC_CURRENCTY_RATE    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_CURRENCTY_RATE"
    ADD CONSTRAINT "FK_ACC_CURRENCTY_RATE" FOREIGN KEY ("CURRENCY_ID") REFERENCES public."ACC_CURRENCTY"("ID") ON DELETE RESTRICT;
 V   ALTER TABLE ONLY public."ACC_CURRENCTY_RATE" DROP CONSTRAINT "FK_ACC_CURRENCTY_RATE";
       public          postgres    false    206    3883    374            B           2606    34567 +   ACC_PAYMENT_MASTER FK_ACC_PAMT_MST_SUB_MODL    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_PAYMENT_MASTER"
    ADD CONSTRAINT "FK_ACC_PAMT_MST_SUB_MODL" FOREIGN KEY ("SUB_MODULE_ID") REFERENCES public."ACC_SUB_MODULE_TYPE"("SUB_MODULE_ID") ON DELETE RESTRICT;
 Y   ALTER TABLE ONLY public."ACC_PAYMENT_MASTER" DROP CONSTRAINT "FK_ACC_PAMT_MST_SUB_MODL";
       public          postgres    false    215    3897    421            C           2606    34577 *   ACC_PAYMENT_MASTER FK_ACC_PAMT_MST_VCHR_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_PAYMENT_MASTER"
    ADD CONSTRAINT "FK_ACC_PAMT_MST_VCHR_ID" FOREIGN KEY ("VCHR_ID") REFERENCES public."ACC_VCHR_MASTER"("VCHR_ID") ON DELETE RESTRICT;
 X   ALTER TABLE ONLY public."ACC_PAYMENT_MASTER" DROP CONSTRAINT "FK_ACC_PAMT_MST_VCHR_ID";
       public          postgres    false    378    421    4167            D           2606    34562 *   ACC_PAYMENT_MASTER FK_ACC_PAMT_PER_TYPE_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_PAYMENT_MASTER"
    ADD CONSTRAINT "FK_ACC_PAMT_PER_TYPE_ID" FOREIGN KEY ("PERSON_TYPE_ID") REFERENCES public."PERSON_TYPE_MASTER"("PERSON_TYPE_ID") ON DELETE RESTRICT;
 X   ALTER TABLE ONLY public."ACC_PAYMENT_MASTER" DROP CONSTRAINT "FK_ACC_PAMT_PER_TYPE_ID";
       public          postgres    false    421    4035    296            E           2606    34572 '   ACC_PAYMENT_MASTER FK_ACC_PAMT_TRANS_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_PAYMENT_MASTER"
    ADD CONSTRAINT "FK_ACC_PAMT_TRANS_ID" FOREIGN KEY ("TRANS_TYPE_ID") REFERENCES public."ACC_TRANS_TYPE"("TYPE_ID") ON DELETE RESTRICT;
 U   ALTER TABLE ONLY public."ACC_PAYMENT_MASTER" DROP CONSTRAINT "FK_ACC_PAMT_TRANS_ID";
       public          postgres    false    421    216    3899            F           2606    34582 &   ACC_PAYMENT_MASTER FK_ACC_PAMT_WORK_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_PAYMENT_MASTER"
    ADD CONSTRAINT "FK_ACC_PAMT_WORK_ID" FOREIGN KEY ("WORK_ID") REFERENCES public."ACC_WORK_MASTER"("WORK_ID") ON DELETE RESTRICT;
 T   ALTER TABLE ONLY public."ACC_PAYMENT_MASTER" DROP CONSTRAINT "FK_ACC_PAMT_WORK_ID";
       public          postgres    false    3907    421    220                       2606    34167 $   ACC_ASULI_BIBARAN FK_ACC_PERSON_TYPE    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_ASULI_BIBARAN"
    ADD CONSTRAINT "FK_ACC_PERSON_TYPE" FOREIGN KEY ("PERSON_TYPE_ID") REFERENCES public."PERSON_TYPE_MASTER"("PERSON_TYPE_ID") ON DELETE RESTRICT;
 R   ALTER TABLE ONLY public."ACC_ASULI_BIBARAN" DROP CONSTRAINT "FK_ACC_PERSON_TYPE";
       public          postgres    false    296    4035    391                       2606    34038 (   ACC_WORK_FUNDS_DETAIL FK_ACC_PROVIDER_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_WORK_FUNDS_DETAIL"
    ADD CONSTRAINT "FK_ACC_PROVIDER_ID" FOREIGN KEY ("PROVIDER_ID") REFERENCES public."ACC_FUND_PROVIDR_MSTR"("PROVIDER_ID") ON DELETE RESTRICT;
 V   ALTER TABLE ONLY public."ACC_WORK_FUNDS_DETAIL" DROP CONSTRAINT "FK_ACC_PROVIDER_ID";
       public          postgres    false    3885    207    380                       2606    34008 &   ACC_VCHR_MASTER FK_ACC_SUB_MODULE_TYPE    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_VCHR_MASTER"
    ADD CONSTRAINT "FK_ACC_SUB_MODULE_TYPE" FOREIGN KEY ("SUB_MODULE_ID") REFERENCES public."ACC_SUB_MODULE_TYPE"("SUB_MODULE_ID") ON DELETE RESTRICT;
 T   ALTER TABLE ONLY public."ACC_VCHR_MASTER" DROP CONSTRAINT "FK_ACC_SUB_MODULE_TYPE";
       public          postgres    false    378    215    3897            +           2606    34399 &   ACC_EXPENSES_DETAILS FK_ACC_TRANS_TYPE    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_EXPENSES_DETAILS"
    ADD CONSTRAINT "FK_ACC_TRANS_TYPE" FOREIGN KEY ("TRANS_TYPE_ID") REFERENCES public."ACC_TRANS_TYPE"("TYPE_ID") ON DELETE RESTRICT;
 T   ALTER TABLE ONLY public."ACC_EXPENSES_DETAILS" DROP CONSTRAINT "FK_ACC_TRANS_TYPE";
       public          postgres    false    409    3899    216            �           2606    35034 &   ACC_PAYMENT_DETAILS FK_ACC_TRANS_TYPE1    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_PAYMENT_DETAILS"
    ADD CONSTRAINT "FK_ACC_TRANS_TYPE1" FOREIGN KEY ("TRANS_TYPE_ID") REFERENCES public."ACC_TRANS_TYPE"("TYPE_ID") ON DELETE RESTRICT;
 T   ALTER TABLE ONLY public."ACC_PAYMENT_DETAILS" DROP CONSTRAINT "FK_ACC_TRANS_TYPE1";
       public          postgres    false    3899    216    447            {           2606    34992 &   ACC_PAYMENT_DEDUCTION FK_ACID_PAY_DEDU    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_PAYMENT_DEDUCTION"
    ADD CONSTRAINT "FK_ACID_PAY_DEDU" FOREIGN KEY ("ACC_ID") REFERENCES public."ACC_ACC_MASTER"("ACC_ID") ON DELETE RESTRICT;
 T   ALTER TABLE ONLY public."ACC_PAYMENT_DEDUCTION" DROP CONSTRAINT "FK_ACID_PAY_DEDU";
       public          postgres    false    4164    446    377            0           2606    34414 )   ACC_PAYMENT_CLEARANCE FK_ACPAYCLEAR_ACCID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_PAYMENT_CLEARANCE"
    ADD CONSTRAINT "FK_ACPAYCLEAR_ACCID" FOREIGN KEY ("ACC_ID") REFERENCES public."ACC_ACC_MASTER"("ACC_ID") ON DELETE RESTRICT;
 W   ALTER TABLE ONLY public."ACC_PAYMENT_CLEARANCE" DROP CONSTRAINT "FK_ACPAYCLEAR_ACCID";
       public          postgres    false    377    410    4164            1           2606    34419 *   ACC_PAYMENT_CLEARANCE FK_ACPAYCLEAR_BUDGET    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_PAYMENT_CLEARANCE"
    ADD CONSTRAINT "FK_ACPAYCLEAR_BUDGET" FOREIGN KEY ("BUDGET_ACC_ID") REFERENCES public."ACC_ACC_MASTER"("ACC_ID") ON DELETE RESTRICT;
 X   ALTER TABLE ONLY public."ACC_PAYMENT_CLEARANCE" DROP CONSTRAINT "FK_ACPAYCLEAR_BUDGET";
       public          postgres    false    410    377    4164            ;           2606    34514 )   ACC_DHRTI_BILL_DTL FK_AC_DHRTI_DTL_ACC_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_DHRTI_BILL_DTL"
    ADD CONSTRAINT "FK_AC_DHRTI_DTL_ACC_ID" FOREIGN KEY ("ACC_ID") REFERENCES public."ACC_ACC_MASTER"("ACC_ID") ON DELETE RESTRICT;
 W   ALTER TABLE ONLY public."ACC_DHRTI_BILL_DTL" DROP CONSTRAINT "FK_AC_DHRTI_DTL_ACC_ID";
       public          postgres    false    419    377    4164            <           2606    34519 *   ACC_DHRTI_BILL_DTL FK_AC_DHRTI_DTL_VCHR_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_DHRTI_BILL_DTL"
    ADD CONSTRAINT "FK_AC_DHRTI_DTL_VCHR_ID" FOREIGN KEY ("VCHR_ID") REFERENCES public."ACC_VCHR_MASTER"("VCHR_ID") ON DELETE RESTRICT;
 X   ALTER TABLE ONLY public."ACC_DHRTI_BILL_DTL" DROP CONSTRAINT "FK_AC_DHRTI_DTL_VCHR_ID";
       public          postgres    false    4167    378    419            >           2606    34547 ,   ACC_DHRTI_BILL_MASTER FK_AC_DHRTI_MST_VCHRID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_DHRTI_BILL_MASTER"
    ADD CONSTRAINT "FK_AC_DHRTI_MST_VCHRID" FOREIGN KEY ("VCHR_ID") REFERENCES public."ACC_VCHR_MASTER"("VCHR_ID") ON DELETE RESTRICT;
 Z   ALTER TABLE ONLY public."ACC_DHRTI_BILL_MASTER" DROP CONSTRAINT "FK_AC_DHRTI_MST_VCHRID";
       public          postgres    false    378    4167    420            e           2606    34800 *   PIS_OTHER_ADD_SUB FK_ADD_SUB_LOCAL_POST_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_OTHER_ADD_SUB"
    ADD CONSTRAINT "FK_ADD_SUB_LOCAL_POST_ID" FOREIGN KEY ("LOCAL_POST_ID") REFERENCES public."PIS_LOCAL_POST_MASTER"("LOCAL_POST_ID") ON DELETE RESTRICT;
 X   ALTER TABLE ONLY public."PIS_OTHER_ADD_SUB" DROP CONSTRAINT "FK_ADD_SUB_LOCAL_POST_ID";
       public          postgres    false    4222    432    395            �           2606    35302 %   PIS_EMP_ADV_DED_DTL FK_ADV_DED_EMP_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_EMP_ADV_DED_DTL"
    ADD CONSTRAINT "FK_ADV_DED_EMP_ID" FOREIGN KEY ("EMP_ID") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 S   ALTER TABLE ONLY public."PIS_EMP_ADV_DED_DTL" DROP CONSTRAINT "FK_ADV_DED_EMP_ID";
       public          postgres    false    4361    430    458            [           2606    34727     PIS_AWARDS FK_AWARDS_LOC_POST_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_AWARDS"
    ADD CONSTRAINT "FK_AWARDS_LOC_POST_ID" FOREIGN KEY ("LOCAL_POST_ID") REFERENCES public."PIS_LOCAL_POST_MASTER"("LOCAL_POST_ID") ON DELETE RESTRICT;
 N   ALTER TABLE ONLY public."PIS_AWARDS" DROP CONSTRAINT "FK_AWARDS_LOC_POST_ID";
       public          postgres    false    428    395    4222            	           2606    34058 7   AspNetRoleClaims FK_AspNetRoleClaims_AspNetRoles_RoleId    FK CONSTRAINT     �   ALTER TABLE ONLY public."AspNetRoleClaims"
    ADD CONSTRAINT "FK_AspNetRoleClaims_AspNetRoles_RoleId" FOREIGN KEY ("RoleId") REFERENCES public."AspNetRoles"("Id") ON DELETE CASCADE;
 e   ALTER TABLE ONLY public."AspNetRoleClaims" DROP CONSTRAINT "FK_AspNetRoleClaims_AspNetRoles_RoleId";
       public          postgres    false    382    223    3913            "           2606    34300 6   AspNetUserClaims FK_AspNetUserClaims_Usermaster_UserId    FK CONSTRAINT     �   ALTER TABLE ONLY public."AspNetUserClaims"
    ADD CONSTRAINT "FK_AspNetUserClaims_Usermaster_UserId" FOREIGN KEY ("UserId") REFERENCES public."Usermaster"("Id") ON DELETE CASCADE;
 d   ALTER TABLE ONLY public."AspNetUserClaims" DROP CONSTRAINT "FK_AspNetUserClaims_Usermaster_UserId";
       public          postgres    false    370    4149    403            #           2606    34313 6   AspNetUserLogins FK_AspNetUserLogins_Usermaster_UserId    FK CONSTRAINT     �   ALTER TABLE ONLY public."AspNetUserLogins"
    ADD CONSTRAINT "FK_AspNetUserLogins_Usermaster_UserId" FOREIGN KEY ("UserId") REFERENCES public."Usermaster"("Id") ON DELETE CASCADE;
 d   ALTER TABLE ONLY public."AspNetUserLogins" DROP CONSTRAINT "FK_AspNetUserLogins_Usermaster_UserId";
       public          postgres    false    4149    404    370            $           2606    34326 5   AspNetUserRoles FK_AspNetUserRoles_AspNetRoles_RoleId    FK CONSTRAINT     �   ALTER TABLE ONLY public."AspNetUserRoles"
    ADD CONSTRAINT "FK_AspNetUserRoles_AspNetRoles_RoleId" FOREIGN KEY ("RoleId") REFERENCES public."AspNetRoles"("Id") ON DELETE CASCADE;
 c   ALTER TABLE ONLY public."AspNetUserRoles" DROP CONSTRAINT "FK_AspNetUserRoles_AspNetRoles_RoleId";
       public          postgres    false    223    405    3913            %           2606    34331 4   AspNetUserRoles FK_AspNetUserRoles_Usermaster_UserId    FK CONSTRAINT     �   ALTER TABLE ONLY public."AspNetUserRoles"
    ADD CONSTRAINT "FK_AspNetUserRoles_Usermaster_UserId" FOREIGN KEY ("UserId") REFERENCES public."Usermaster"("Id") ON DELETE CASCADE;
 b   ALTER TABLE ONLY public."AspNetUserRoles" DROP CONSTRAINT "FK_AspNetUserRoles_Usermaster_UserId";
       public          postgres    false    4149    370    405            &           2606    34344 6   AspNetUserTokens FK_AspNetUserTokens_Usermaster_UserId    FK CONSTRAINT     �   ALTER TABLE ONLY public."AspNetUserTokens"
    ADD CONSTRAINT "FK_AspNetUserTokens_Usermaster_UserId" FOREIGN KEY ("UserId") REFERENCES public."Usermaster"("Id") ON DELETE CASCADE;
 d   ALTER TABLE ONLY public."AspNetUserTokens" DROP CONSTRAINT "FK_AspNetUserTokens_Usermaster_UserId";
       public          postgres    false    370    4149    406            u           2606    34959 $   BANKTRANSACTIONS FK_BANKTRAN_VCHR_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."BANKTRANSACTIONS"
    ADD CONSTRAINT "FK_BANKTRAN_VCHR_ID" FOREIGN KEY ("VCHR_ID") REFERENCES public."ACC_VCHR_MASTER"("VCHR_ID") ON DELETE RESTRICT;
 R   ALTER TABLE ONLY public."BANKTRANSACTIONS" DROP CONSTRAINT "FK_BANKTRAN_VCHR_ID";
       public          postgres    false    444    378    4167            T           2606    34682 #   ORG_BANK_ACCOUNT FK_BANK_ACCNT_TYPE    FK CONSTRAINT     �   ALTER TABLE ONLY public."ORG_BANK_ACCOUNT"
    ADD CONSTRAINT "FK_BANK_ACCNT_TYPE" FOREIGN KEY ("BANK_ACCNT_TYPE_ID") REFERENCES public."TBL_BANK_ACCNT_TYPE"("ID") ON DELETE RESTRICT;
 Q   ALTER TABLE ONLY public."ORG_BANK_ACCOUNT" DROP CONSTRAINT "FK_BANK_ACCNT_TYPE";
       public          postgres    false    340    426    4102            �           2606    35056    ACC_BANK_TRANS FK_BANK_BANK_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_BANK_TRANS"
    ADD CONSTRAINT "FK_BANK_BANK_ID" FOREIGN KEY ("BANK_ID") REFERENCES public."BANKMASTER"("BANKID") ON DELETE RESTRICT;
 L   ALTER TABLE ONLY public."ACC_BANK_TRANS" DROP CONSTRAINT "FK_BANK_BANK_ID";
       public          postgres    false    3916    224    448            �           2606    35061    ACC_BANK_TRANS FK_BANK_BILL_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_BANK_TRANS"
    ADD CONSTRAINT "FK_BANK_BILL_ID" FOREIGN KEY ("BILL_ID") REFERENCES public."INCOMEBILLMASTER"("SN") ON DELETE RESTRICT;
 L   ALTER TABLE ONLY public."ACC_BANK_TRANS" DROP CONSTRAINT "FK_BANK_BILL_ID";
       public          postgres    false    425    4332    448            U           2606    34687    ORG_BANK_ACCOUNT FK_BANK_BRANCH    FK CONSTRAINT     �   ALTER TABLE ONLY public."ORG_BANK_ACCOUNT"
    ADD CONSTRAINT "FK_BANK_BRANCH" FOREIGN KEY ("BRANCH_ID") REFERENCES public."BANK_BRANCH"("BRANCH_ID") ON DELETE RESTRICT;
 M   ALTER TABLE ONLY public."ORG_BANK_ACCOUNT" DROP CONSTRAINT "FK_BANK_BRANCH";
       public          postgres    false    383    426    4182            
           2606    34071    BANK_BRANCH FK_BANK_MSTR    FK CONSTRAINT     �   ALTER TABLE ONLY public."BANK_BRANCH"
    ADD CONSTRAINT "FK_BANK_MSTR" FOREIGN KEY ("BANKID") REFERENCES public."BANKMASTER"("BANKID") ON DELETE RESTRICT;
 F   ALTER TABLE ONLY public."BANK_BRANCH" DROP CONSTRAINT "FK_BANK_MSTR";
       public          postgres    false    383    224    3916                       2606    34245    TBL_BGT_MGMT_EXP FK_BGT_MGMT    FK CONSTRAINT     �   ALTER TABLE ONLY public."TBL_BGT_MGMT_EXP"
    ADD CONSTRAINT "FK_BGT_MGMT" FOREIGN KEY ("BGT_MGMT_ID") REFERENCES public."TBL_BGT_MGMT"("ID") ON DELETE RESTRICT;
 J   ALTER TABLE ONLY public."TBL_BGT_MGMT_EXP" DROP CONSTRAINT "FK_BGT_MGMT";
       public          postgres    false    397    4106    342            m           2606    34881     TBL_BGT_MGMT_SRC FK_BGT_MGMT_EXP    FK CONSTRAINT     �   ALTER TABLE ONLY public."TBL_BGT_MGMT_SRC"
    ADD CONSTRAINT "FK_BGT_MGMT_EXP" FOREIGN KEY ("BGT_MGMT_EXP_ID") REFERENCES public."TBL_BGT_MGMT_EXP"("ID") ON DELETE RESTRICT;
 N   ALTER TABLE ONLY public."TBL_BGT_MGMT_SRC" DROP CONSTRAINT "FK_BGT_MGMT_EXP";
       public          postgres    false    397    439    4228                       2606    34255 $   TBL_BGT_MGMT_EXP_ORG FK_BGT_MGMT_ORG    FK CONSTRAINT     �   ALTER TABLE ONLY public."TBL_BGT_MGMT_EXP_ORG"
    ADD CONSTRAINT "FK_BGT_MGMT_ORG" FOREIGN KEY ("BGT_MGMT_ORG_ID") REFERENCES public."TBL_BGT_MGMT_ORG"("ID") ON DELETE RESTRICT;
 R   ALTER TABLE ONLY public."TBL_BGT_MGMT_EXP_ORG" DROP CONSTRAINT "FK_BGT_MGMT_ORG";
       public          postgres    false    4108    398    343            n           2606    34891 (   TBL_BGT_MGMT_SRC_ORG FK_BGT_MGMT_ORG_EXP    FK CONSTRAINT     �   ALTER TABLE ONLY public."TBL_BGT_MGMT_SRC_ORG"
    ADD CONSTRAINT "FK_BGT_MGMT_ORG_EXP" FOREIGN KEY ("BGT_MGMT_EXP_ORG_ID") REFERENCES public."TBL_BGT_MGMT_EXP_ORG"("ID") ON DELETE RESTRICT;
 V   ALTER TABLE ONLY public."TBL_BGT_MGMT_SRC_ORG" DROP CONSTRAINT "FK_BGT_MGMT_ORG_EXP";
       public          postgres    false    4231    398    440            '           2606    34354 $   TBL_BGT_MGMT_RELEASE FK_BGT_MGMT_REL    FK CONSTRAINT     �   ALTER TABLE ONLY public."TBL_BGT_MGMT_RELEASE"
    ADD CONSTRAINT "FK_BGT_MGMT_REL" FOREIGN KEY ("BGT_RELEASE_ID") REFERENCES public."TBL_BGT_RELEASE"("ID") ON DELETE RESTRICT;
 R   ALTER TABLE ONLY public."TBL_BGT_MGMT_RELEASE" DROP CONSTRAINT "FK_BGT_MGMT_REL";
       public          postgres    false    407    375    4159            t           2606    34936 ,   TBL_BGT_MGMT_EXP_RELEASE FK_BGT_MGMT_RELEASE    FK CONSTRAINT     �   ALTER TABLE ONLY public."TBL_BGT_MGMT_EXP_RELEASE"
    ADD CONSTRAINT "FK_BGT_MGMT_RELEASE" FOREIGN KEY ("BGT_MGMT_RELEASE_ID") REFERENCES public."TBL_BGT_MGMT_RELEASE"("ID") ON DELETE RESTRICT;
 Z   ALTER TABLE ONLY public."TBL_BGT_MGMT_EXP_RELEASE" DROP CONSTRAINT "FK_BGT_MGMT_RELEASE";
       public          postgres    false    4254    443    407            �           2606    35532 ,   TBL_BGT_MGMT_SRC_RELEASE FK_BGT_MGMT_REL_EXP    FK CONSTRAINT     �   ALTER TABLE ONLY public."TBL_BGT_MGMT_SRC_RELEASE"
    ADD CONSTRAINT "FK_BGT_MGMT_REL_EXP" FOREIGN KEY ("BGT_MGMT_EXP_RELEASE_ID") REFERENCES public."TBL_BGT_MGMT_EXP_RELEASE"("ID") ON DELETE RESTRICT;
 Z   ALTER TABLE ONLY public."TBL_BGT_MGMT_SRC_RELEASE" DROP CONSTRAINT "FK_BGT_MGMT_REL_EXP";
       public          postgres    false    472    4404    443                        2606    33969    TBL_BGT_RELEASE FK_BGT_REL_ORG    FK CONSTRAINT     �   ALTER TABLE ONLY public."TBL_BGT_RELEASE"
    ADD CONSTRAINT "FK_BGT_REL_ORG" FOREIGN KEY ("ORG_ID") REFERENCES public."ACC_ORG_MASTER"("ORG_ID") ON DELETE RESTRICT;
 L   ALTER TABLE ONLY public."TBL_BGT_RELEASE" DROP CONSTRAINT "FK_BGT_REL_ORG";
       public          postgres    false    375    3893    211            �           2606    35287 $   PIS_BANK_PAYROLL FK_BNK_PYRL_BANK_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_BANK_PAYROLL"
    ADD CONSTRAINT "FK_BNK_PYRL_BANK_ID" FOREIGN KEY ("BANK_ID") REFERENCES public."BANKMASTER"("BANKID") ON DELETE RESTRICT;
 R   ALTER TABLE ONLY public."PIS_BANK_PAYROLL" DROP CONSTRAINT "FK_BNK_PYRL_BANK_ID";
       public          postgres    false    3916    457    224            �           2606    35292 #   PIS_BANK_PAYROLL FK_BNK_PYRL_EMP_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_BANK_PAYROLL"
    ADD CONSTRAINT "FK_BNK_PYRL_EMP_ID" FOREIGN KEY ("EMP_ID") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 Q   ALTER TABLE ONLY public."PIS_BANK_PAYROLL" DROP CONSTRAINT "FK_BNK_PYRL_EMP_ID";
       public          postgres    false    4361    430    457            |           2606    34997 *   ACC_PAYMENT_DEDUCTION FK_BUDGETID_PAY_DEDU    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_PAYMENT_DEDUCTION"
    ADD CONSTRAINT "FK_BUDGETID_PAY_DEDU" FOREIGN KEY ("BUDGET_ACC_ID") REFERENCES public."ACC_ACC_MASTER"("ACC_ID") ON DELETE RESTRICT;
 X   ALTER TABLE ONLY public."ACC_PAYMENT_DEDUCTION" DROP CONSTRAINT "FK_BUDGETID_PAY_DEDU";
       public          postgres    false    446    377    4164                       2606    34154    ACC_BUDJET_SOURCE FK_BUD_SOURCE    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_BUDJET_SOURCE"
    ADD CONSTRAINT "FK_BUD_SOURCE" FOREIGN KEY ("SOURCE_ID") REFERENCES public."BUDJET_SOURCE"("ID") ON DELETE RESTRICT;
 M   ALTER TABLE ONLY public."ACC_BUDJET_SOURCE" DROP CONSTRAINT "FK_BUD_SOURCE";
       public          postgres    false    225    390    3918            9           2606    34494 .   TBLBUSINESS_SERVICE_CH_MST FK_BUS_SERCH_ACC_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."TBLBUSINESS_SERVICE_CH_MST"
    ADD CONSTRAINT "FK_BUS_SERCH_ACC_ID" FOREIGN KEY ("ACC_ID") REFERENCES public."ACC_ACC_MASTER"("ACC_ID") ON DELETE RESTRICT;
 \   ALTER TABLE ONLY public."TBLBUSINESS_SERVICE_CH_MST" DROP CONSTRAINT "FK_BUS_SERCH_ACC_ID";
       public          postgres    false    4164    417    377            x           2606    34982 #   CASHTRANSACTION FK_CASHTRAN_VCHR_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."CASHTRANSACTION"
    ADD CONSTRAINT "FK_CASHTRAN_VCHR_ID" FOREIGN KEY ("VCHR_ID") REFERENCES public."ACC_VCHR_MASTER"("VCHR_ID") ON DELETE RESTRICT;
 Q   ALTER TABLE ONLY public."CASHTRANSACTION" DROP CONSTRAINT "FK_CASHTRAN_VCHR_ID";
       public          postgres    false    4167    445    378            �           2606    35078    ACC_CASH_TRANS FK_CASH_BILL_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_CASH_TRANS"
    ADD CONSTRAINT "FK_CASH_BILL_ID" FOREIGN KEY ("BILL_ID") REFERENCES public."INCOMEBILLMASTER"("SN") ON DELETE RESTRICT;
 L   ALTER TABLE ONLY public."ACC_CASH_TRANS" DROP CONSTRAINT "FK_CASH_BILL_ID";
       public          postgres    false    449    425    4332            �           2606    35083    ACC_CASH_TRANS FK_CASH_VCHR_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_CASH_TRANS"
    ADD CONSTRAINT "FK_CASH_VCHR_ID" FOREIGN KEY ("VCHR_ID") REFERENCES public."ACC_VCHR_MASTER"("VCHR_ID") ON DELETE RESTRICT;
 L   ALTER TABLE ONLY public."ACC_CASH_TRANS" DROP CONSTRAINT "FK_CASH_VCHR_ID";
       public          postgres    false    4167    378    449            o           2606    34896    TBL_BGT_MGMT_SRC_ORG FK_CC    FK CONSTRAINT     �   ALTER TABLE ONLY public."TBL_BGT_MGMT_SRC_ORG"
    ADD CONSTRAINT "FK_CC" FOREIGN KEY ("CC_ID") REFERENCES public."CONTACTS"("ID") ON DELETE RESTRICT;
 H   ALTER TABLE ONLY public."TBL_BGT_MGMT_SRC_ORG" DROP CONSTRAINT "FK_CC";
       public          postgres    false    231    3923    440            �           2606    35537 &   TBL_BGT_MGMT_SRC_RELEASE FK_CC_RELEASE    FK CONSTRAINT     �   ALTER TABLE ONLY public."TBL_BGT_MGMT_SRC_RELEASE"
    ADD CONSTRAINT "FK_CC_RELEASE" FOREIGN KEY ("CC_ID") REFERENCES public."CONTACTS"("ID") ON DELETE RESTRICT;
 T   ALTER TABLE ONLY public."TBL_BGT_MGMT_SRC_RELEASE" DROP CONSTRAINT "FK_CC_RELEASE";
       public          postgres    false    231    472    3923            �           2606    35209 $   INV_PUR_ORDER_MAST FK_CHECKED_BY_USR    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_PUR_ORDER_MAST"
    ADD CONSTRAINT "FK_CHECKED_BY_USR" FOREIGN KEY ("CHECKED_BY") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 R   ALTER TABLE ONLY public."INV_PUR_ORDER_MAST" DROP CONSTRAINT "FK_CHECKED_BY_USR";
       public          postgres    false    454    430    4361            �           2606    35151 '   INV_GOODS_REC_MAST FK_CHECK_BY_GOOD_EMP    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_GOODS_REC_MAST"
    ADD CONSTRAINT "FK_CHECK_BY_GOOD_EMP" FOREIGN KEY ("CHECK_BY") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 U   ALTER TABLE ONLY public."INV_GOODS_REC_MAST" DROP CONSTRAINT "FK_CHECK_BY_GOOD_EMP";
       public          postgres    false    452    430    4361            7           2606    34474 5   TBL_CONSTRUCTION_OTHER_CHARGES FK_CONST_OTH_CH_ACC_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."TBL_CONSTRUCTION_OTHER_CHARGES"
    ADD CONSTRAINT "FK_CONST_OTH_CH_ACC_ID" FOREIGN KEY ("ACC_ID") REFERENCES public."ACC_ACC_MASTER"("ACC_ID") ON DELETE RESTRICT;
 c   ALTER TABLE ONLY public."TBL_CONSTRUCTION_OTHER_CHARGES" DROP CONSTRAINT "FK_CONST_OTH_CH_ACC_ID";
       public          postgres    false    377    415    4164            \           2606    34737 $   PIS_DARBANDI FK_DARBANDI_LOC_POST_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_DARBANDI"
    ADD CONSTRAINT "FK_DARBANDI_LOC_POST_ID" FOREIGN KEY ("LOCAL_POST_ID") REFERENCES public."PIS_LOCAL_POST_MASTER"("LOCAL_POST_ID") ON DELETE RESTRICT;
 R   ALTER TABLE ONLY public."PIS_DARBANDI" DROP CONSTRAINT "FK_DARBANDI_LOC_POST_ID";
       public          postgres    false    4222    429    395            ]           2606    34742 "   PIS_DARBANDI FK_DARBANDI_OFFICE_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_DARBANDI"
    ADD CONSTRAINT "FK_DARBANDI_OFFICE_ID" FOREIGN KEY ("OFFICE_ID") REFERENCES public."ORGANIZATION_TREE"("ID") ON DELETE RESTRICT;
 P   ALTER TABLE ONLY public."PIS_DARBANDI" DROP CONSTRAINT "FK_DARBANDI_OFFICE_ID";
       public          postgres    false    4219    429    394            ^           2606    34747     PIS_DARBANDI FK_DARBANDI_POST_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_DARBANDI"
    ADD CONSTRAINT "FK_DARBANDI_POST_ID" FOREIGN KEY ("POST_ID") REFERENCES public."PIS_POST_MASTER"("POST_ID") ON DELETE RESTRICT;
 N   ALTER TABLE ONLY public."PIS_DARBANDI" DROP CONSTRAINT "FK_DARBANDI_POST_ID";
       public          postgres    false    4074    429    315            �           2606    35547 1   PIS_DELETD_FRM_FULFILD_DARB FK_DEL_FD_DARBANDI_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_DELETD_FRM_FULFILD_DARB"
    ADD CONSTRAINT "FK_DEL_FD_DARBANDI_ID" FOREIGN KEY ("FRM_DARBANDI_ID") REFERENCES public."PIS_DARBANDI"("DARBANDI_ID") ON DELETE RESTRICT;
 _   ALTER TABLE ONLY public."PIS_DELETD_FRM_FULFILD_DARB" DROP CONSTRAINT "FK_DEL_FD_DARBANDI_ID";
       public          postgres    false    4354    473    429            �           2606    35552 /   PIS_DELETD_FRM_FULFILD_DARB FK_DEL_FD_OFFICE_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_DELETD_FRM_FULFILD_DARB"
    ADD CONSTRAINT "FK_DEL_FD_OFFICE_ID" FOREIGN KEY ("FRM_OFFICE_ID") REFERENCES public."ORGANIZATION_TREE"("ID") ON DELETE RESTRICT;
 ]   ALTER TABLE ONLY public."PIS_DELETD_FRM_FULFILD_DARB" DROP CONSTRAINT "FK_DEL_FD_OFFICE_ID";
       public          postgres    false    473    4219    394                       2606    34265 6   TBL_PAYMENT_ORDER_DETAILS FK_DETAILS_TBL_PAYMENT_ORDER    FK CONSTRAINT     �   ALTER TABLE ONLY public."TBL_PAYMENT_ORDER_DETAILS"
    ADD CONSTRAINT "FK_DETAILS_TBL_PAYMENT_ORDER" FOREIGN KEY ("PAYMENT_ORDER_ID") REFERENCES public."TBL_PAYMENT_ORDER"("ID") ON DELETE RESTRICT;
 d   ALTER TABLE ONLY public."TBL_PAYMENT_ORDER_DETAILS" DROP CONSTRAINT "FK_DETAILS_TBL_PAYMENT_ORDER";
       public          postgres    false    349    399    4120            ,           2606    34384 %   ACC_EXPENSES_DETAILS FK_DETAIL_ACC_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_EXPENSES_DETAILS"
    ADD CONSTRAINT "FK_DETAIL_ACC_ID" FOREIGN KEY ("ACC_ID") REFERENCES public."ACC_ACC_MASTER"("ACC_ID") ON DELETE RESTRICT;
 S   ALTER TABLE ONLY public."ACC_EXPENSES_DETAILS" DROP CONSTRAINT "FK_DETAIL_ACC_ID";
       public          postgres    false    377    409    4164            ~           2606    35014 %   ACC_PAYMENT_DETAILS FK_DETAIL_ACC_ID1    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_PAYMENT_DETAILS"
    ADD CONSTRAINT "FK_DETAIL_ACC_ID1" FOREIGN KEY ("ACC_ID") REFERENCES public."ACC_ACC_MASTER"("ACC_ID") ON DELETE RESTRICT;
 S   ALTER TABLE ONLY public."ACC_PAYMENT_DETAILS" DROP CONSTRAINT "FK_DETAIL_ACC_ID1";
       public          postgres    false    447    377    4164            G           2606    34604 &   ACC_VCHR_DETAILS FK_DETAIL_ACC_VCHR_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_VCHR_DETAILS"
    ADD CONSTRAINT "FK_DETAIL_ACC_VCHR_ID" FOREIGN KEY ("VCHR_ID") REFERENCES public."ACC_VCHR_MASTER"("VCHR_ID") ON DELETE RESTRICT;
 T   ALTER TABLE ONLY public."ACC_VCHR_DETAILS" DROP CONSTRAINT "FK_DETAIL_ACC_VCHR_ID";
       public          postgres    false    4167    378    422            -           2606    34389 ,   ACC_EXPENSES_DETAILS FK_DETAIL_PAMENT_SLIPID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_EXPENSES_DETAILS"
    ADD CONSTRAINT "FK_DETAIL_PAMENT_SLIPID" FOREIGN KEY ("PAYMENT_SLIP_ID") REFERENCES public."PAYMENT_SLIP_MASTER"("PAYMENT_SLIP_ID") ON DELETE RESTRICT;
 Z   ALTER TABLE ONLY public."ACC_EXPENSES_DETAILS" DROP CONSTRAINT "FK_DETAIL_PAMENT_SLIPID";
       public          postgres    false    4033    295    409            .           2606    34394 -   ACC_EXPENSES_DETAILS FK_DETAIL_PERSON_TYPE_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_EXPENSES_DETAILS"
    ADD CONSTRAINT "FK_DETAIL_PERSON_TYPE_ID" FOREIGN KEY ("PERSON_TYPE_ID") REFERENCES public."PERSON_TYPE_MASTER"("PERSON_TYPE_ID") ON DELETE RESTRICT;
 [   ALTER TABLE ONLY public."ACC_EXPENSES_DETAILS" DROP CONSTRAINT "FK_DETAIL_PERSON_TYPE_ID";
       public          postgres    false    409    296    4035            �           2606    35029 -   ACC_PAYMENT_DETAILS FK_DETAIL_PERSON_TYPE_ID1    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_PAYMENT_DETAILS"
    ADD CONSTRAINT "FK_DETAIL_PERSON_TYPE_ID1" FOREIGN KEY ("PERSON_TYPE_ID") REFERENCES public."PERSON_TYPE_MASTER"("PERSON_TYPE_ID") ON DELETE RESTRICT;
 [   ALTER TABLE ONLY public."ACC_PAYMENT_DETAILS" DROP CONSTRAINT "FK_DETAIL_PERSON_TYPE_ID1";
       public          postgres    false    4035    447    296            H           2606    34599 (   ACC_VCHR_DETAILS FK_DETAIL_TRANS_TYPE_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_VCHR_DETAILS"
    ADD CONSTRAINT "FK_DETAIL_TRANS_TYPE_ID" FOREIGN KEY ("TRANS_TYPE_ID") REFERENCES public."ACC_TRANS_TYPE"("TYPE_ID") ON DELETE RESTRICT;
 V   ALTER TABLE ONLY public."ACC_VCHR_DETAILS" DROP CONSTRAINT "FK_DETAIL_TRANS_TYPE_ID";
       public          postgres    false    422    216    3899            I           2606    34609 '   ACC_VCHR_DETAILS FK_DETAIL_VCHR_TYPE_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_VCHR_DETAILS"
    ADD CONSTRAINT "FK_DETAIL_VCHR_TYPE_ID" FOREIGN KEY ("VCHR_TYPE_ID") REFERENCES public."ACC_VCHR_TYPE_MASTER"("VCHR_TYPE_ID") ON DELETE RESTRICT;
 U   ALTER TABLE ONLY public."ACC_VCHR_DETAILS" DROP CONSTRAINT "FK_DETAIL_VCHR_TYPE_ID";
       public          postgres    false    3905    219    422            �           2606    35044 &   ACC_PAYMENT_DETAILS FK_DETAIL_WORK_ID1    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_PAYMENT_DETAILS"
    ADD CONSTRAINT "FK_DETAIL_WORK_ID1" FOREIGN KEY ("WORK_ID") REFERENCES public."ACC_WORK_MASTER"("WORK_ID") ON DELETE RESTRICT;
 T   ALTER TABLE ONLY public."ACC_PAYMENT_DETAILS" DROP CONSTRAINT "FK_DETAIL_WORK_ID1";
       public          postgres    false    3907    447    220            /           2606    34404 '   ACC_EXPENSES_DETAILS FK_DETAIL_WWORK_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_EXPENSES_DETAILS"
    ADD CONSTRAINT "FK_DETAIL_WWORK_ID" FOREIGN KEY ("WORK_ID") REFERENCES public."ACC_WORK_MASTER"("WORK_ID") ON DELETE RESTRICT;
 U   ALTER TABLE ONLY public."ACC_EXPENSES_DETAILS" DROP CONSTRAINT "FK_DETAIL_WWORK_ID";
       public          postgres    false    409    3907    220                       2606    35019 )   ACC_PAYMENT_DETAILS FK_DTL_BUDGET_ACC_ID1    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_PAYMENT_DETAILS"
    ADD CONSTRAINT "FK_DTL_BUDGET_ACC_ID1" FOREIGN KEY ("BUDGET_ACC_ID") REFERENCES public."ACC_ACC_MASTER"("ACC_ID") ON DELETE RESTRICT;
 W   ALTER TABLE ONLY public."ACC_PAYMENT_DETAILS" DROP CONSTRAINT "FK_DTL_BUDGET_ACC_ID1";
       public          postgres    false    447    377    4164            J           2606    34594 $   ACC_VCHR_DETAILS FK_DTL_SUB_MODULEID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_VCHR_DETAILS"
    ADD CONSTRAINT "FK_DTL_SUB_MODULEID" FOREIGN KEY ("SUB_MODULE_ID") REFERENCES public."ACC_SUB_MODULE_TYPE"("SUB_MODULE_ID") ON DELETE RESTRICT;
 R   ALTER TABLE ONLY public."ACC_VCHR_DETAILS" DROP CONSTRAINT "FK_DTL_SUB_MODULEID";
       public          postgres    false    3897    422    215                       2606    34177    PIS_EDUCATION FK_EDU_BRD    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_EDUCATION"
    ADD CONSTRAINT "FK_EDU_BRD" FOREIGN KEY ("BOARD_ID") REFERENCES public."PIS_EDU_BOARD"("ID") ON DELETE RESTRICT;
 F   ALTER TABLE ONLY public."PIS_EDUCATION" DROP CONSTRAINT "FK_EDU_BRD";
       public          postgres    false    4041    392    299                       2606    34182    PIS_EDUCATION FK_EDU_LVL    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_EDUCATION"
    ADD CONSTRAINT "FK_EDU_LVL" FOREIGN KEY ("EDU_LEVEL_ID") REFERENCES public."PIS_EDU_LEVEL"("EDU_ID") ON DELETE RESTRICT;
 F   ALTER TABLE ONLY public."PIS_EDUCATION" DROP CONSTRAINT "FK_EDU_LVL";
       public          postgres    false    300    392    4043            �           2606    35312 !   PIS_EMP_LOANS FK_EMP_LOANS_EMP_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_EMP_LOANS"
    ADD CONSTRAINT "FK_EMP_LOANS_EMP_ID" FOREIGN KEY ("EMP_ID") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 O   ALTER TABLE ONLY public."PIS_EMP_LOANS" DROP CONSTRAINT "FK_EMP_LOANS_EMP_ID";
       public          postgres    false    459    430    4361            �           2606    35577 *   PIS_REPLACED_IN_DARBANDI FK_ENTRY_SN_IN_FD    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_REPLACED_IN_DARBANDI"
    ADD CONSTRAINT "FK_ENTRY_SN_IN_FD" FOREIGN KEY ("ENTRY_SN_IN_FD") REFERENCES public."PIS_FULFILLED_DARBANDI"("SN") ON DELETE RESTRICT;
 X   ALTER TABLE ONLY public."PIS_REPLACED_IN_DARBANDI" DROP CONSTRAINT "FK_ENTRY_SN_IN_FD";
       public          postgres    false    4442    474    450            2           2606    34429 #   FIREBRIGADESTATE FK_FIREBRIG_ACC_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."FIREBRIGADESTATE"
    ADD CONSTRAINT "FK_FIREBRIG_ACC_ID" FOREIGN KEY ("ACC_ID") REFERENCES public."ACC_ACC_MASTER"("ACC_ID") ON DELETE RESTRICT;
 Q   ALTER TABLE ONLY public."FIREBRIGADESTATE" DROP CONSTRAINT "FK_FIREBRIG_ACC_ID";
       public          postgres    false    411    4164    377            _           2606    34765 )   PIS_EMPLOYEE_MASTER FK_FIRST_APMT_POST_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_EMPLOYEE_MASTER"
    ADD CONSTRAINT "FK_FIRST_APMT_POST_ID" FOREIGN KEY ("FIRST_APPOINT_POST_ID") REFERENCES public."PIS_POST_MASTER"("POST_ID") ON DELETE RESTRICT;
 W   ALTER TABLE ONLY public."PIS_EMPLOYEE_MASTER" DROP CONSTRAINT "FK_FIRST_APMT_POST_ID";
       public          postgres    false    430    315    4074            d           2606    34790 '   PIS_FOREIGN_VISITS FK_FORGN_LOC_POST_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_FOREIGN_VISITS"
    ADD CONSTRAINT "FK_FORGN_LOC_POST_ID" FOREIGN KEY ("LOCAL_POST_ID") REFERENCES public."PIS_LOCAL_POST_MASTER"("LOCAL_POST_ID") ON DELETE RESTRICT;
 U   ALTER TABLE ONLY public."PIS_FOREIGN_VISITS" DROP CONSTRAINT "FK_FORGN_LOC_POST_ID";
       public          postgres    false    431    4222    395            (           2606    34369    ACC_BGT_TRANSFER FK_FROM_ACC_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_BGT_TRANSFER"
    ADD CONSTRAINT "FK_FROM_ACC_ID" FOREIGN KEY ("FROM_ACC_ID") REFERENCES public."ACC_ACC_MASTER"("ACC_ID") ON DELETE RESTRICT;
 M   ALTER TABLE ONLY public."ACC_BGT_TRANSFER" DROP CONSTRAINT "FK_FROM_ACC_ID";
       public          postgres    false    4164    377    408            �           2606    35557 ,   PIS_DELETD_FRM_FULFILD_DARB FK_FROM_SN_IN_FD    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_DELETD_FRM_FULFILD_DARB"
    ADD CONSTRAINT "FK_FROM_SN_IN_FD" FOREIGN KEY ("FRM_SN_IN_FD") REFERENCES public."PIS_FULFILLED_DARBANDI"("SN") ON DELETE RESTRICT;
 Z   ALTER TABLE ONLY public."PIS_DELETD_FRM_FULFILD_DARB" DROP CONSTRAINT "FK_FROM_SN_IN_FD";
       public          postgres    false    450    4442    473            �           2606    35093 ,   PIS_FULFILLED_DARBANDI FK_FULFIL_DARBANDI_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_FULFILLED_DARBANDI"
    ADD CONSTRAINT "FK_FULFIL_DARBANDI_ID" FOREIGN KEY ("DARBANDI_ID") REFERENCES public."PIS_DARBANDI"("DARBANDI_ID") ON DELETE RESTRICT;
 Z   ALTER TABLE ONLY public."PIS_FULFILLED_DARBANDI" DROP CONSTRAINT "FK_FULFIL_DARBANDI_ID";
       public          postgres    false    450    4354    429            �           2606    35098 1   PIS_FULFILLED_DARBANDI FK_FULFIL_DARB_LOC_POST_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_FULFILLED_DARBANDI"
    ADD CONSTRAINT "FK_FULFIL_DARB_LOC_POST_ID" FOREIGN KEY ("LOCAL_POST_ID") REFERENCES public."PIS_LOCAL_POST_MASTER"("LOCAL_POST_ID") ON DELETE RESTRICT;
 _   ALTER TABLE ONLY public."PIS_FULFILLED_DARBANDI" DROP CONSTRAINT "FK_FULFIL_DARB_LOC_POST_ID";
       public          postgres    false    450    4222    395            �           2606    35103 /   PIS_FULFILLED_DARBANDI FK_FULFIL_DARB_OFFICE_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_FULFILLED_DARBANDI"
    ADD CONSTRAINT "FK_FULFIL_DARB_OFFICE_ID" FOREIGN KEY ("OFFICE_ID") REFERENCES public."ORGANIZATION_TREE"("ID") ON DELETE RESTRICT;
 ]   ALTER TABLE ONLY public."PIS_FULFILLED_DARBANDI" DROP CONSTRAINT "FK_FULFIL_DARB_OFFICE_ID";
       public          postgres    false    450    4219    394            �           2606    35118 )   INV_GOODS_ADJUST FK_GOODS_ADJUST_BRAND_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_GOODS_ADJUST"
    ADD CONSTRAINT "FK_GOODS_ADJUST_BRAND_ID" FOREIGN KEY ("BRAND_ID") REFERENCES public."INV_BRAND"("BRAND_ID") ON DELETE RESTRICT;
 W   ALTER TABLE ONLY public."INV_GOODS_ADJUST" DROP CONSTRAINT "FK_GOODS_ADJUST_BRAND_ID";
       public          postgres    false    451    3931    242            �           2606    35123 (   INV_GOODS_ADJUST FK_GOODS_ADJUST_ITEM_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_GOODS_ADJUST"
    ADD CONSTRAINT "FK_GOODS_ADJUST_ITEM_ID" FOREIGN KEY ("ITEM_ID") REFERENCES public."INV_ITEM_MST"("ITEM_ID") ON DELETE RESTRICT;
 V   ALTER TABLE ONLY public."INV_GOODS_ADJUST" DROP CONSTRAINT "FK_GOODS_ADJUST_ITEM_ID";
       public          postgres    false    4194    387    451            �           2606    35133 (   INV_GOODS_ADJUST FK_GOODS_ADJUST_SPEC_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_GOODS_ADJUST"
    ADD CONSTRAINT "FK_GOODS_ADJUST_SPEC_ID" FOREIGN KEY ("SPEC_ID") REFERENCES public."INV_ITEM_SPEC"("SPEC_ID") ON DELETE RESTRICT;
 V   ALTER TABLE ONLY public."INV_GOODS_ADJUST" DROP CONSTRAINT "FK_GOODS_ADJUST_SPEC_ID";
       public          postgres    false    250    451    3947            �           2606    35593 $   INV_GOODS_REC_DETL FK_GOODS_BRAND_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_GOODS_REC_DETL"
    ADD CONSTRAINT "FK_GOODS_BRAND_ID" FOREIGN KEY ("BRAND_ID") REFERENCES public."INV_BRAND"("BRAND_ID") ON DELETE RESTRICT;
 R   ALTER TABLE ONLY public."INV_GOODS_REC_DETL" DROP CONSTRAINT "FK_GOODS_BRAND_ID";
       public          postgres    false    3931    242    475            �           2606    35598 (   INV_GOODS_REC_DETL FK_GOODS_DTL_MASTERID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_GOODS_REC_DETL"
    ADD CONSTRAINT "FK_GOODS_DTL_MASTERID" FOREIGN KEY ("GOODS_MASTER_ID") REFERENCES public."INV_GOODS_REC_MAST"("ID") ON DELETE RESTRICT;
 V   ALTER TABLE ONLY public."INV_GOODS_REC_DETL" DROP CONSTRAINT "FK_GOODS_DTL_MASTERID";
       public          postgres    false    4454    452    475            �           2606    35603 #   INV_GOODS_REC_DETL FK_GOODS_ITEM_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_GOODS_REC_DETL"
    ADD CONSTRAINT "FK_GOODS_ITEM_ID" FOREIGN KEY ("ITEM_ID") REFERENCES public."INV_ITEM_MST"("ITEM_ID") ON DELETE RESTRICT;
 Q   ALTER TABLE ONLY public."INV_GOODS_REC_DETL" DROP CONSTRAINT "FK_GOODS_ITEM_ID";
       public          postgres    false    475    4194    387            �           2606    35608 #   INV_GOODS_REC_DETL FK_GOODS_SPEC_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_GOODS_REC_DETL"
    ADD CONSTRAINT "FK_GOODS_SPEC_ID" FOREIGN KEY ("SPEC_ID") REFERENCES public."INV_ITEM_SPEC"("SPEC_ID") ON DELETE RESTRICT;
 Q   ALTER TABLE ONLY public."INV_GOODS_REC_DETL" DROP CONSTRAINT "FK_GOODS_SPEC_ID";
       public          postgres    false    475    250    3947            �           2606    35613 #   INV_GOODS_REC_DETL FK_GOODS_UNIT_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_GOODS_REC_DETL"
    ADD CONSTRAINT "FK_GOODS_UNIT_ID" FOREIGN KEY ("UNIT_ID") REFERENCES public."INV_UNIT"("UNIT_ID") ON DELETE RESTRICT;
 Q   ALTER TABLE ONLY public."INV_GOODS_REC_DETL" DROP CONSTRAINT "FK_GOODS_UNIT_ID";
       public          postgres    false    264    3971    475                       2606    34023 %   ACC_BANK_GRNTY FK_GRNTY_PERSON_ORG_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_BANK_GRNTY"
    ADD CONSTRAINT "FK_GRNTY_PERSON_ORG_ID" FOREIGN KEY ("PERSON_ID") REFERENCES public."ACC_ORG_MASTER"("ORG_ID") ON DELETE RESTRICT;
 S   ALTER TABLE ONLY public."ACC_BANK_GRNTY" DROP CONSTRAINT "FK_GRNTY_PERSON_ORG_ID";
       public          postgres    false    3893    379    211                       2606    34028    ACC_BANK_GRNTY FK_GRNTY_WORK_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_BANK_GRNTY"
    ADD CONSTRAINT "FK_GRNTY_WORK_ID" FOREIGN KEY ("WORK_ID") REFERENCES public."ACC_WORK_MASTER"("WORK_ID") ON DELETE RESTRICT;
 M   ALTER TABLE ONLY public."ACC_BANK_GRNTY" DROP CONSTRAINT "FK_GRNTY_WORK_ID";
       public          postgres    false    379    220    3907            O           2606    34644 '   INCOMEBILLDETAILS FK_INBILL_DETL_ACC_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INCOMEBILLDETAILS"
    ADD CONSTRAINT "FK_INBILL_DETL_ACC_ID" FOREIGN KEY ("ACC_ID") REFERENCES public."ACC_ACC_MASTER"("ACC_ID") ON DELETE RESTRICT;
 U   ALTER TABLE ONLY public."INCOMEBILLDETAILS" DROP CONSTRAINT "FK_INBILL_DETL_ACC_ID";
       public          postgres    false    4164    377    424            P           2606    34649 '   INCOMEBILLDETAILS FK_INBILL_DET_VCHR_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INCOMEBILLDETAILS"
    ADD CONSTRAINT "FK_INBILL_DET_VCHR_ID" FOREIGN KEY ("VCHR_ID") REFERENCES public."ACC_VCHR_MASTER"("VCHR_ID") ON DELETE RESTRICT;
 U   ALTER TABLE ONLY public."INCOMEBILLDETAILS" DROP CONSTRAINT "FK_INBILL_DET_VCHR_ID";
       public          postgres    false    424    4167    378            Q           2606    34672 '   INCOMEBILLMASTER FK_INBILL_MAST_VCHR_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INCOMEBILLMASTER"
    ADD CONSTRAINT "FK_INBILL_MAST_VCHR_ID" FOREIGN KEY ("VCHR_ID") REFERENCES public."ACC_VCHR_MASTER"("VCHR_ID") ON DELETE RESTRICT;
 U   ALTER TABLE ONLY public."INCOMEBILLMASTER" DROP CONSTRAINT "FK_INBILL_MAST_VCHR_ID";
       public          postgres    false    4167    425    378            �           2606    35412 (   PIS_INTERNAL_TRANSFER FK_INT_APNTMT_TYPE    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_INTERNAL_TRANSFER"
    ADD CONSTRAINT "FK_INT_APNTMT_TYPE" FOREIGN KEY ("APPOINTMNT_TYPE") REFERENCES public."PIS_APPOINTMENT_TYPE"("ID") ON DELETE RESTRICT;
 V   ALTER TABLE ONLY public."PIS_INTERNAL_TRANSFER" DROP CONSTRAINT "FK_INT_APNTMT_TYPE";
       public          postgres    false    466    4037    297            �           2606    35437 (   PIS_INTERNAL_TRANSFER FK_INT_LOC_POST_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_INTERNAL_TRANSFER"
    ADD CONSTRAINT "FK_INT_LOC_POST_ID" FOREIGN KEY ("TO_LOCAL_POST_ID") REFERENCES public."PIS_LOCAL_POST_MASTER"("LOCAL_POST_ID") ON DELETE RESTRICT;
 V   ALTER TABLE ONLY public."PIS_INTERNAL_TRANSFER" DROP CONSTRAINT "FK_INT_LOC_POST_ID";
       public          postgres    false    4222    466    395            �           2606    35432 +   PIS_INTERNAL_TRANSFER FK_INT_TO_APNTMT_TYPE    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_INTERNAL_TRANSFER"
    ADD CONSTRAINT "FK_INT_TO_APNTMT_TYPE" FOREIGN KEY ("TO_APPOINTMNT_TYPE") REFERENCES public."PIS_APPOINTMENT_TYPE"("ID") ON DELETE RESTRICT;
 Y   ALTER TABLE ONLY public."PIS_INTERNAL_TRANSFER" DROP CONSTRAINT "FK_INT_TO_APNTMT_TYPE";
       public          postgres    false    297    4037    466            �           2606    35417 /   PIS_INTERNAL_TRANSFER FK_INT_TRNSFR_DARBANDI_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_INTERNAL_TRANSFER"
    ADD CONSTRAINT "FK_INT_TRNSFR_DARBANDI_ID" FOREIGN KEY ("DARBANDI_ID") REFERENCES public."PIS_DARBANDI"("DARBANDI_ID") ON DELETE RESTRICT;
 ]   ALTER TABLE ONLY public."PIS_INTERNAL_TRANSFER" DROP CONSTRAINT "FK_INT_TRNSFR_DARBANDI_ID";
       public          postgres    false    466    429    4354            �           2606    35422 *   PIS_INTERNAL_TRANSFER FK_INT_TRNSFR_EMP_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_INTERNAL_TRANSFER"
    ADD CONSTRAINT "FK_INT_TRNSFR_EMP_ID" FOREIGN KEY ("EMP_ID") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 X   ALTER TABLE ONLY public."PIS_INTERNAL_TRANSFER" DROP CONSTRAINT "FK_INT_TRNSFR_EMP_ID";
       public          postgres    false    4361    466    430            �           2606    35427 -   PIS_INTERNAL_TRANSFER FK_INT_TRNSFR_OFFICE_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_INTERNAL_TRANSFER"
    ADD CONSTRAINT "FK_INT_TRNSFR_OFFICE_ID" FOREIGN KEY ("OFFICE_ID") REFERENCES public."ORGANIZATION_TREE"("ID") ON DELETE RESTRICT;
 [   ALTER TABLE ONLY public."PIS_INTERNAL_TRANSFER" DROP CONSTRAINT "FK_INT_TRNSFR_OFFICE_ID";
       public          postgres    false    394    4219    466            �           2606    35442 0   PIS_INTERNAL_TRANSFER FK_INT_TRNSFR_TO_OFFICE_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_INTERNAL_TRANSFER"
    ADD CONSTRAINT "FK_INT_TRNSFR_TO_OFFICE_ID" FOREIGN KEY ("TO_OFFICE_ID") REFERENCES public."ORGANIZATION_TREE"("ID") ON DELETE RESTRICT;
 ^   ALTER TABLE ONLY public."PIS_INTERNAL_TRANSFER" DROP CONSTRAINT "FK_INT_TRNSFR_TO_OFFICE_ID";
       public          postgres    false    466    394    4219                       2606    34106 &   INV_LILAMAPPDETAILS FK_INV_APPLIMASTID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_LILAMAPPDETAILS"
    ADD CONSTRAINT "FK_INV_APPLIMASTID" FOREIGN KEY ("LILAMAPPLIID") REFERENCES public."INV_LILAM_APPMASTER"("ID") ON DELETE RESTRICT;
 T   ALTER TABLE ONLY public."INV_LILAMAPPDETAILS" DROP CONSTRAINT "FK_INV_APPLIMASTID";
       public          postgres    false    386    3949    251            W           2606    34702 (   INV_ISSUE_DETAIL FK_INV_ISS_DTL_BRAND_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_ISSUE_DETAIL"
    ADD CONSTRAINT "FK_INV_ISS_DTL_BRAND_ID" FOREIGN KEY ("BRAND_ID") REFERENCES public."INV_BRAND"("BRAND_ID") ON DELETE RESTRICT;
 V   ALTER TABLE ONLY public."INV_ISSUE_DETAIL" DROP CONSTRAINT "FK_INV_ISS_DTL_BRAND_ID";
       public          postgres    false    3931    242    427            X           2606    34707 '   INV_ISSUE_DETAIL FK_INV_ISS_DTL_ITEM_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_ISSUE_DETAIL"
    ADD CONSTRAINT "FK_INV_ISS_DTL_ITEM_ID" FOREIGN KEY ("ITEM_ID") REFERENCES public."INV_ITEM_MST"("ITEM_ID") ON DELETE RESTRICT;
 U   ALTER TABLE ONLY public."INV_ISSUE_DETAIL" DROP CONSTRAINT "FK_INV_ISS_DTL_ITEM_ID";
       public          postgres    false    4194    427    387            Y           2606    34712 )   INV_ISSUE_DETAIL FK_INV_ISS_DTL_ITEM_TYPE    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_ISSUE_DETAIL"
    ADD CONSTRAINT "FK_INV_ISS_DTL_ITEM_TYPE" FOREIGN KEY ("ITEM_TYPE") REFERENCES public."INV_ITEM_CATEGORY"("ID") ON DELETE RESTRICT;
 W   ALTER TABLE ONLY public."INV_ISSUE_DETAIL" DROP CONSTRAINT "FK_INV_ISS_DTL_ITEM_TYPE";
       public          postgres    false    3945    427    249            Z           2606    34717 '   INV_ISSUE_DETAIL FK_INV_ISS_DTL_SPEC_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_ISSUE_DETAIL"
    ADD CONSTRAINT "FK_INV_ISS_DTL_SPEC_ID" FOREIGN KEY ("SPEC_ID") REFERENCES public."INV_ITEM_SPEC"("SPEC_ID") ON DELETE RESTRICT;
 U   ALTER TABLE ONLY public."INV_ISSUE_DETAIL" DROP CONSTRAINT "FK_INV_ISS_DTL_SPEC_ID";
       public          postgres    false    3947    250    427            �           2606    35683 %   INV_PUR_ORDER_DETL FK_INV_PUR_MAST_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_PUR_ORDER_DETL"
    ADD CONSTRAINT "FK_INV_PUR_MAST_ID" FOREIGN KEY ("PUR_MST_ID") REFERENCES public."INV_PUR_ORDER_MAST"("ID") ON DELETE RESTRICT;
 S   ALTER TABLE ONLY public."INV_PUR_ORDER_DETL" DROP CONSTRAINT "FK_INV_PUR_MAST_ID";
       public          postgres    false    4468    454    477            �           2606    35267 (   INV_STATUS_DETAIL FK_INV_STADEL_ACCEPTBY    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_STATUS_DETAIL"
    ADD CONSTRAINT "FK_INV_STADEL_ACCEPTBY" FOREIGN KEY ("ACCEPTBY") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 V   ALTER TABLE ONLY public."INV_STATUS_DETAIL" DROP CONSTRAINT "FK_INV_STADEL_ACCEPTBY";
       public          postgres    false    456    4361    430            �           2606    35272 )   INV_STATUS_DETAIL FK_INV_STADEL_CHECKEDBY    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_STATUS_DETAIL"
    ADD CONSTRAINT "FK_INV_STADEL_CHECKEDBY" FOREIGN KEY ("CHECKEDBY") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 W   ALTER TABLE ONLY public."INV_STATUS_DETAIL" DROP CONSTRAINT "FK_INV_STADEL_CHECKEDBY";
       public          postgres    false    4361    456    430            �           2606    35277 %   INV_STATUS_DETAIL FK_INV_STADEL_PREBY    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_STATUS_DETAIL"
    ADD CONSTRAINT "FK_INV_STADEL_PREBY" FOREIGN KEY ("PREBY") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 S   ALTER TABLE ONLY public."INV_STATUS_DETAIL" DROP CONSTRAINT "FK_INV_STADEL_PREBY";
       public          postgres    false    4361    456    430            �           2606    35733 &   INV_REQ_DETAIL FK_IN_REQ_DETL_BRAND_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_REQ_DETAIL"
    ADD CONSTRAINT "FK_IN_REQ_DETL_BRAND_ID" FOREIGN KEY ("BRAND_ID") REFERENCES public."INV_BRAND"("BRAND_ID") ON DELETE RESTRICT;
 T   ALTER TABLE ONLY public."INV_REQ_DETAIL" DROP CONSTRAINT "FK_IN_REQ_DETL_BRAND_ID";
       public          postgres    false    242    479    3931            �           2606    35738 %   INV_REQ_DETAIL FK_IN_REQ_DETL_ITEM_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_REQ_DETAIL"
    ADD CONSTRAINT "FK_IN_REQ_DETL_ITEM_ID" FOREIGN KEY ("ITEM_ID") REFERENCES public."INV_ITEM_MST"("ITEM_ID") ON DELETE RESTRICT;
 S   ALTER TABLE ONLY public."INV_REQ_DETAIL" DROP CONSTRAINT "FK_IN_REQ_DETL_ITEM_ID";
       public          postgres    false    4194    479    387            �           2606    35743 '   INV_REQ_DETAIL FK_IN_REQ_DETL_MASTER_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_REQ_DETAIL"
    ADD CONSTRAINT "FK_IN_REQ_DETL_MASTER_ID" FOREIGN KEY ("REQ_MAST_ID") REFERENCES public."INV_REQUISITION_MAST"("ID") ON DELETE RESTRICT;
 U   ALTER TABLE ONLY public."INV_REQ_DETAIL" DROP CONSTRAINT "FK_IN_REQ_DETL_MASTER_ID";
       public          postgres    false    479    455    4476            �           2606    35748 %   INV_REQ_DETAIL FK_IN_REQ_DETL_SPEC_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_REQ_DETAIL"
    ADD CONSTRAINT "FK_IN_REQ_DETL_SPEC_ID" FOREIGN KEY ("SPEC_ID") REFERENCES public."INV_ITEM_SPEC"("SPEC_ID") ON DELETE RESTRICT;
 S   ALTER TABLE ONLY public."INV_REQ_DETAIL" DROP CONSTRAINT "FK_IN_REQ_DETL_SPEC_ID";
       public          postgres    false    250    479    3947            �           2606    35703 &   INV_ISSUE_MASTER FK_ISS_MAST_ACCEPT_BY    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_ISSUE_MASTER"
    ADD CONSTRAINT "FK_ISS_MAST_ACCEPT_BY" FOREIGN KEY ("ACCEPT_BY") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 T   ALTER TABLE ONLY public."INV_ISSUE_MASTER" DROP CONSTRAINT "FK_ISS_MAST_ACCEPT_BY";
       public          postgres    false    478    430    4361            �           2606    35708 %   INV_ISSUE_MASTER FK_ISS_MAST_CHECK_BY    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_ISSUE_MASTER"
    ADD CONSTRAINT "FK_ISS_MAST_CHECK_BY" FOREIGN KEY ("CHECK_BY") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 S   ALTER TABLE ONLY public."INV_ISSUE_MASTER" DROP CONSTRAINT "FK_ISS_MAST_CHECK_BY";
       public          postgres    false    478    430    4361            �           2606    35713 %   INV_ISSUE_MASTER FK_ISS_MAST_ISSUE_BY    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_ISSUE_MASTER"
    ADD CONSTRAINT "FK_ISS_MAST_ISSUE_BY" FOREIGN KEY ("ISSUE_BY") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 S   ALTER TABLE ONLY public."INV_ISSUE_MASTER" DROP CONSTRAINT "FK_ISS_MAST_ISSUE_BY";
       public          postgres    false    478    430    4361            �           2606    35718 $   INV_ISSUE_MASTER FK_ISS_MAST_PREP_BY    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_ISSUE_MASTER"
    ADD CONSTRAINT "FK_ISS_MAST_PREP_BY" FOREIGN KEY ("PREP_BY") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 R   ALTER TABLE ONLY public."INV_ISSUE_MASTER" DROP CONSTRAINT "FK_ISS_MAST_PREP_BY";
       public          postgres    false    4361    430    478            �           2606    35723 '   INV_ISSUE_MASTER FK_ISS_MAST_REQUEST_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_ISSUE_MASTER"
    ADD CONSTRAINT "FK_ISS_MAST_REQUEST_ID" FOREIGN KEY ("REQUEST_ID") REFERENCES public."INV_REQUISITION_MAST"("ID") ON DELETE RESTRICT;
 U   ALTER TABLE ONLY public."INV_ISSUE_MASTER" DROP CONSTRAINT "FK_ISS_MAST_REQUEST_ID";
       public          postgres    false    4476    478    455            �           2606    35623 '   INV_ITEM_DETAILS FK_ITEM_DETL_ACCEPT_BY    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_ITEM_DETAILS"
    ADD CONSTRAINT "FK_ITEM_DETL_ACCEPT_BY" FOREIGN KEY ("ACCEPT_BY") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 U   ALTER TABLE ONLY public."INV_ITEM_DETAILS" DROP CONSTRAINT "FK_ITEM_DETL_ACCEPT_BY";
       public          postgres    false    4361    430    476            �           2606    35628 &   INV_ITEM_DETAILS FK_ITEM_DETL_BRAND_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_ITEM_DETAILS"
    ADD CONSTRAINT "FK_ITEM_DETL_BRAND_ID" FOREIGN KEY ("BRAND_ID") REFERENCES public."INV_BRAND"("BRAND_ID") ON DELETE RESTRICT;
 T   ALTER TABLE ONLY public."INV_ITEM_DETAILS" DROP CONSTRAINT "FK_ITEM_DETL_BRAND_ID";
       public          postgres    false    242    476    3931            �           2606    35633 &   INV_ITEM_DETAILS FK_ITEM_DETL_CHECK_BY    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_ITEM_DETAILS"
    ADD CONSTRAINT "FK_ITEM_DETL_CHECK_BY" FOREIGN KEY ("CHECK_BY") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 T   ALTER TABLE ONLY public."INV_ITEM_DETAILS" DROP CONSTRAINT "FK_ITEM_DETL_CHECK_BY";
       public          postgres    false    476    4361    430            �           2606    35638 (   INV_ITEM_DETAILS FK_ITEM_DETL_DAKHILA_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_ITEM_DETAILS"
    ADD CONSTRAINT "FK_ITEM_DETL_DAKHILA_ID" FOREIGN KEY ("DAKHILA_ID") REFERENCES public."INV_GOODS_REC_MAST"("ID") ON DELETE RESTRICT;
 V   ALTER TABLE ONLY public."INV_ITEM_DETAILS" DROP CONSTRAINT "FK_ITEM_DETL_DAKHILA_ID";
       public          postgres    false    4454    452    476            �           2606    35643 '   INV_ITEM_DETAILS FK_ITEM_DETL_GD_ADJ_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_ITEM_DETAILS"
    ADD CONSTRAINT "FK_ITEM_DETL_GD_ADJ_ID" FOREIGN KEY ("GD_ADJ_ID") REFERENCES public."INV_GOODS_ADJUST"("ID") ON DELETE RESTRICT;
 U   ALTER TABLE ONLY public."INV_ITEM_DETAILS" DROP CONSTRAINT "FK_ITEM_DETL_GD_ADJ_ID";
       public          postgres    false    451    476    4449            �           2606    35648 %   INV_ITEM_DETAILS FK_ITEM_DETL_ITEM_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_ITEM_DETAILS"
    ADD CONSTRAINT "FK_ITEM_DETL_ITEM_ID" FOREIGN KEY ("ITEM_ID") REFERENCES public."INV_ITEM_MST"("ITEM_ID") ON DELETE RESTRICT;
 S   ALTER TABLE ONLY public."INV_ITEM_DETAILS" DROP CONSTRAINT "FK_ITEM_DETL_ITEM_ID";
       public          postgres    false    476    387    4194            �           2606    35653 %   INV_ITEM_DETAILS FK_ITEM_DETL_PREP_BY    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_ITEM_DETAILS"
    ADD CONSTRAINT "FK_ITEM_DETL_PREP_BY" FOREIGN KEY ("PREP_BY") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 S   ALTER TABLE ONLY public."INV_ITEM_DETAILS" DROP CONSTRAINT "FK_ITEM_DETL_PREP_BY";
       public          postgres    false    4361    476    430            �           2606    35658 %   INV_ITEM_DETAILS FK_ITEM_DETL_SPEC_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_ITEM_DETAILS"
    ADD CONSTRAINT "FK_ITEM_DETL_SPEC_ID" FOREIGN KEY ("SPEC_ID") REFERENCES public."INV_ITEM_SPEC"("SPEC_ID") ON DELETE RESTRICT;
 S   ALTER TABLE ONLY public."INV_ITEM_DETAILS" DROP CONSTRAINT "FK_ITEM_DETL_SPEC_ID";
       public          postgres    false    476    3947    250            �           2606    35176 )   INV_ITEM_STATUSCHECK FK_ITEM_STATUS_CHECK    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_ITEM_STATUSCHECK"
    ADD CONSTRAINT "FK_ITEM_STATUS_CHECK" FOREIGN KEY ("ITEM_ID") REFERENCES public."INV_ITEM_MST"("ITEM_ID") ON DELETE RESTRICT;
 W   ALTER TABLE ONLY public."INV_ITEM_STATUSCHECK" DROP CONSTRAINT "FK_ITEM_STATUS_CHECK";
       public          postgres    false    4194    453    387                       2606    34119    INV_ITEM_MST FK_ITEM_UNIT_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_ITEM_MST"
    ADD CONSTRAINT "FK_ITEM_UNIT_ID" FOREIGN KEY ("UNIT_ID") REFERENCES public."INV_UNIT"("UNIT_ID") ON DELETE RESTRICT;
 J   ALTER TABLE ONLY public."INV_ITEM_MST" DROP CONSTRAINT "FK_ITEM_UNIT_ID";
       public          postgres    false    387    3971    264            :           2606    34504 '   TBLVEH_SER_CH_MSTR FK_LAND_SERCH_ACC_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."TBLVEH_SER_CH_MSTR"
    ADD CONSTRAINT "FK_LAND_SERCH_ACC_ID" FOREIGN KEY ("ACC_ID") REFERENCES public."ACC_ACC_MASTER"("ACC_ID") ON DELETE RESTRICT;
 U   ALTER TABLE ONLY public."TBLVEH_SER_CH_MSTR" DROP CONSTRAINT "FK_LAND_SERCH_ACC_ID";
       public          postgres    false    4164    418    377            8           2606    34484 ,   TBL_LAND_OTHER_CHARGES FK_LAN_OTH_CHA_ACC_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."TBL_LAND_OTHER_CHARGES"
    ADD CONSTRAINT "FK_LAN_OTH_CHA_ACC_ID" FOREIGN KEY ("ACC_ID") REFERENCES public."ACC_ACC_MASTER"("ACC_ID") ON DELETE RESTRICT;
 Z   ALTER TABLE ONLY public."TBL_LAND_OTHER_CHARGES" DROP CONSTRAINT "FK_LAN_OTH_CHA_ACC_ID";
       public          postgres    false    4164    377    416            �           2606    35322 $   PIS_EMP_LONG_LEAVES FK_LEAVES_EMP_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_EMP_LONG_LEAVES"
    ADD CONSTRAINT "FK_LEAVES_EMP_ID" FOREIGN KEY ("EMP_ID") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 R   ALTER TABLE ONLY public."PIS_EMP_LONG_LEAVES" DROP CONSTRAINT "FK_LEAVES_EMP_ID";
       public          postgres    false    4361    460    430            �           2606    35327 )   PIS_EMP_LONG_LEAVES FK_LEAVES_LOC_POST_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_EMP_LONG_LEAVES"
    ADD CONSTRAINT "FK_LEAVES_LOC_POST_ID" FOREIGN KEY ("LOCAL_POST_ID") REFERENCES public."PIS_LOCAL_POST_MASTER"("LOCAL_POST_ID") ON DELETE RESTRICT;
 W   ALTER TABLE ONLY public."PIS_EMP_LONG_LEAVES" DROP CONSTRAINT "FK_LEAVES_LOC_POST_ID";
       public          postgres    false    460    4222    395            `           2606    34770 $   PIS_EMPLOYEE_MASTER FK_LOCAL_POST_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_EMPLOYEE_MASTER"
    ADD CONSTRAINT "FK_LOCAL_POST_ID" FOREIGN KEY ("LOCAL_POST_ID") REFERENCES public."PIS_LOCAL_POST_MASTER"("LOCAL_POST_ID") ON DELETE RESTRICT;
 R   ALTER TABLE ONLY public."PIS_EMPLOYEE_MASTER" DROP CONSTRAINT "FK_LOCAL_POST_ID";
       public          postgres    false    4222    395    430                       2606    34225 +   PIS_LOCAL_POST_MASTER FK_LO_PIS_POST_MASTER    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_LOCAL_POST_MASTER"
    ADD CONSTRAINT "FK_LO_PIS_POST_MASTER" FOREIGN KEY ("POST_ID") REFERENCES public."PIS_POST_MASTER"("POST_ID") ON DELETE RESTRICT;
 Y   ALTER TABLE ONLY public."PIS_LOCAL_POST_MASTER" DROP CONSTRAINT "FK_LO_PIS_POST_MASTER";
       public          postgres    false    4074    315    395            �           2606    35497 -   TBL_MALPOT_OTHER_CHARGES FK_MAL_OTH_CH_ACC_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."TBL_MALPOT_OTHER_CHARGES"
    ADD CONSTRAINT "FK_MAL_OTH_CH_ACC_ID" FOREIGN KEY ("ACC_ID") REFERENCES public."ACC_ACC_MASTER"("ACC_ID") ON DELETE RESTRICT;
 [   ALTER TABLE ONLY public."TBL_MALPOT_OTHER_CHARGES" DROP CONSTRAINT "FK_MAL_OTH_CH_ACC_ID";
       public          postgres    false    470    377    4164                       2606    34013 $   ACC_VCHR_MASTER FK_MAST_VCHR_TYPE_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_VCHR_MASTER"
    ADD CONSTRAINT "FK_MAST_VCHR_TYPE_ID" FOREIGN KEY ("VCHR_TYPE_ID") REFERENCES public."ACC_VCHR_TYPE_MASTER"("VCHR_TYPE_ID") ON DELETE RESTRICT;
 R   ALTER TABLE ONLY public."ACC_VCHR_MASTER" DROP CONSTRAINT "FK_MAST_VCHR_TYPE_ID";
       public          postgres    false    3905    219    378            �           2606    35337 !   PIS_EMP_MED_EXPENSE FK_MED_EMP_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_EMP_MED_EXPENSE"
    ADD CONSTRAINT "FK_MED_EMP_ID" FOREIGN KEY ("EMP_ID") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 O   ALTER TABLE ONLY public."PIS_EMP_MED_EXPENSE" DROP CONSTRAINT "FK_MED_EMP_ID";
       public          postgres    false    4361    461    430            �           2606    35342 &   PIS_EMP_MED_EXPENSE FK_MED_LOC_POST_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_EMP_MED_EXPENSE"
    ADD CONSTRAINT "FK_MED_LOC_POST_ID" FOREIGN KEY ("LOCAL_POST_ID") REFERENCES public."PIS_LOCAL_POST_MASTER"("LOCAL_POST_ID") ON DELETE RESTRICT;
 T   ALTER TABLE ONLY public."PIS_EMP_MED_EXPENSE" DROP CONSTRAINT "FK_MED_LOC_POST_ID";
       public          postgres    false    395    461    4222            3           2606    34439 %   MAP_INCOME_TYPE FK_MINCOME_TYPE_ACCID    FK CONSTRAINT     �   ALTER TABLE ONLY public."MAP_INCOME_TYPE"
    ADD CONSTRAINT "FK_MINCOME_TYPE_ACCID" FOREIGN KEY ("ACC_ID") REFERENCES public."ACC_ACC_MASTER"("ACC_ID") ON DELETE RESTRICT;
 S   ALTER TABLE ONLY public."MAP_INCOME_TYPE" DROP CONSTRAINT "FK_MINCOME_TYPE_ACCID";
       public          postgres    false    377    4164    412                       2606    34149    ACC_BUDJET_SOURCE FK_MIN_ACC    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_BUDJET_SOURCE"
    ADD CONSTRAINT "FK_MIN_ACC" FOREIGN KEY ("MIN_ACC_ID") REFERENCES public."MINISTRY_ACC_HEAD"("ID") ON DELETE CASCADE;
 J   ALTER TABLE ONLY public."ACC_BUDJET_SOURCE" DROP CONSTRAINT "FK_MIN_ACC";
       public          postgres    false    4027    390    291            �           2606    33583 .   PIS_NIJAMATI_SEWA_SAMUHA FK_NIJAMATI_PARENT_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_NIJAMATI_SEWA_SAMUHA"
    ADD CONSTRAINT "FK_NIJAMATI_PARENT_ID" FOREIGN KEY ("PARENT_ID") REFERENCES public."PIS_NIJAMATI_SEWA_SAMUHA"("ID") ON DELETE RESTRICT;
 \   ALTER TABLE ONLY public."PIS_NIJAMATI_SEWA_SAMUHA" DROP CONSTRAINT "FK_NIJAMATI_PARENT_ID";
       public          postgres    false    309    309    4062                       2606    34207    ORGANIZATION_TREE FK_ORG_GEO_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ORGANIZATION_TREE"
    ADD CONSTRAINT "FK_ORG_GEO_ID" FOREIGN KEY ("GEO_REGION") REFERENCES public."PIS_GEO_REGION"("ID") ON DELETE RESTRICT;
 M   ALTER TABLE ONLY public."ORGANIZATION_TREE" DROP CONSTRAINT "FK_ORG_GEO_ID";
       public          postgres    false    304    394    4051            V           2606    34692    ORG_BANK_ACCOUNT FK_ORG_MASTER    FK CONSTRAINT     �   ALTER TABLE ONLY public."ORG_BANK_ACCOUNT"
    ADD CONSTRAINT "FK_ORG_MASTER" FOREIGN KEY ("ORG_ID") REFERENCES public."ACC_ORG_MASTER"("ORG_ID") ON DELETE RESTRICT;
 L   ALTER TABLE ONLY public."ORG_BANK_ACCOUNT" DROP CONSTRAINT "FK_ORG_MASTER";
       public          postgres    false    426    211    3893                       2606    34212 "   ORGANIZATION_TREE FK_ORG_PARENT_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ORGANIZATION_TREE"
    ADD CONSTRAINT "FK_ORG_PARENT_ID" FOREIGN KEY ("PARENT_ID") REFERENCES public."ORGANIZATION_TREE"("ID") ON DELETE RESTRICT;
 P   ALTER TABLE ONLY public."ORGANIZATION_TREE" DROP CONSTRAINT "FK_ORG_PARENT_ID";
       public          postgres    false    394    4219    394            �           2606    35024 -   ACC_PAYMENT_DETAILS FK_PAM_DETAIL_PAYMENT_ID1    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_PAYMENT_DETAILS"
    ADD CONSTRAINT "FK_PAM_DETAIL_PAYMENT_ID1" FOREIGN KEY ("PAYMENT_ID") REFERENCES public."ACC_PAYMENT_MASTER"("PAYMENT_ID") ON DELETE RESTRICT;
 [   ALTER TABLE ONLY public."ACC_PAYMENT_DETAILS" DROP CONSTRAINT "FK_PAM_DETAIL_PAYMENT_ID1";
       public          postgres    false    447    4309    421            a           2606    34775 !   PIS_EMPLOYEE_MASTER FK_PAYBANK_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_EMPLOYEE_MASTER"
    ADD CONSTRAINT "FK_PAYBANK_ID" FOREIGN KEY ("PAYEMENT_BANK_ID") REFERENCES public."BANKMASTER"("BANKID") ON DELETE RESTRICT;
 O   ALTER TABLE ONLY public."PIS_EMPLOYEE_MASTER" DROP CONSTRAINT "FK_PAYBANK_ID";
       public          postgres    false    3916    430    224            }           2606    35002 $   ACC_PAYMENT_DEDUCTION FK_PAYID_DEDUC    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_PAYMENT_DEDUCTION"
    ADD CONSTRAINT "FK_PAYID_DEDUC" FOREIGN KEY ("PAYMENT_ID") REFERENCES public."ACC_PAYMENT_MASTER"("PAYMENT_ID") ON DELETE RESTRICT;
 R   ALTER TABLE ONLY public."ACC_PAYMENT_DEDUCTION" DROP CONSTRAINT "FK_PAYID_DEDUC";
       public          postgres    false    4309    421    446            L           2606    34624 .   ACC_WORK_PAYMNT_TRANS FK_PAYMENT_PERSON_TYP_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_WORK_PAYMNT_TRANS"
    ADD CONSTRAINT "FK_PAYMENT_PERSON_TYP_ID" FOREIGN KEY ("PERSON_TYPE_ID") REFERENCES public."PERSON_TYPE_MASTER"("PERSON_TYPE_ID") ON DELETE RESTRICT;
 \   ALTER TABLE ONLY public."ACC_WORK_PAYMNT_TRANS" DROP CONSTRAINT "FK_PAYMENT_PERSON_TYP_ID";
       public          postgres    false    423    4035    296            M           2606    34629 (   ACC_WORK_PAYMNT_TRANS FK_PAYMENT_VCHR_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_WORK_PAYMNT_TRANS"
    ADD CONSTRAINT "FK_PAYMENT_VCHR_ID" FOREIGN KEY ("VCHR_ID") REFERENCES public."ACC_VCHR_MASTER"("VCHR_ID") ON DELETE RESTRICT;
 V   ALTER TABLE ONLY public."ACC_WORK_PAYMNT_TRANS" DROP CONSTRAINT "FK_PAYMENT_VCHR_ID";
       public          postgres    false    378    423    4167            N           2606    34634 '   ACC_WORK_PAYMNT_TRANS FK_PAYMENT_WORKID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_WORK_PAYMNT_TRANS"
    ADD CONSTRAINT "FK_PAYMENT_WORKID" FOREIGN KEY ("WORK_ID") REFERENCES public."ACC_WORK_MASTER"("WORK_ID") ON DELETE RESTRICT;
 U   ALTER TABLE ONLY public."ACC_WORK_PAYMNT_TRANS" DROP CONSTRAINT "FK_PAYMENT_WORKID";
       public          postgres    false    423    3907    220            �           2606    35039 +   ACC_PAYMENT_DETAILS FK_PAYMNT_DETL_VCHR_ID1    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_PAYMENT_DETAILS"
    ADD CONSTRAINT "FK_PAYMNT_DETL_VCHR_ID1" FOREIGN KEY ("VCHR_ID") REFERENCES public."ACC_VCHR_MASTER"("VCHR_ID") ON DELETE RESTRICT;
 Y   ALTER TABLE ONLY public."ACC_PAYMENT_DETAILS" DROP CONSTRAINT "FK_PAYMNT_DETL_VCHR_ID1";
       public          postgres    false    447    378    4167            g           2606    34820 $   PIS_PUBLICATION FK_PBLCN_LOC_POST_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_PUBLICATION"
    ADD CONSTRAINT "FK_PBLCN_LOC_POST_ID" FOREIGN KEY ("LOCAL_POST_ID") REFERENCES public."PIS_LOCAL_POST_MASTER"("LOCAL_POST_ID") ON DELETE RESTRICT;
 R   ALTER TABLE ONLY public."PIS_PUBLICATION" DROP CONSTRAINT "FK_PBLCN_LOC_POST_ID";
       public          postgres    false    434    4222    395                       2606    33982    ACC_PADADHIKARI_MSTR FK_POST_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_PADADHIKARI_MSTR"
    ADD CONSTRAINT "FK_POST_ID" FOREIGN KEY ("POST_ID") REFERENCES public."ACC_PADADHIKARI_POST"("POST_ID") ON DELETE RESTRICT;
 M   ALTER TABLE ONLY public."ACC_PADADHIKARI_MSTR" DROP CONSTRAINT "FK_POST_ID";
       public          postgres    false    3895    212    376            b           2606    34780 '   PIS_EMPLOYEE_MASTER FK_POST_MST_POST_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_EMPLOYEE_MASTER"
    ADD CONSTRAINT "FK_POST_MST_POST_ID" FOREIGN KEY ("POST_ID") REFERENCES public."PIS_POST_MASTER"("POST_ID") ON DELETE RESTRICT;
 U   ALTER TABLE ONLY public."PIS_EMPLOYEE_MASTER" DROP CONSTRAINT "FK_POST_MST_POST_ID";
       public          postgres    false    4074    430    315            �           2606    35214 %   INV_PUR_ORDER_MAST FK_PREPARED_BY_USR    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_PUR_ORDER_MAST"
    ADD CONSTRAINT "FK_PREPARED_BY_USR" FOREIGN KEY ("PREPARED_BY") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 S   ALTER TABLE ONLY public."INV_PUR_ORDER_MAST" DROP CONSTRAINT "FK_PREPARED_BY_USR";
       public          postgres    false    454    430    4361            �           2606    35128 $   INV_GOODS_ADJUST FK_PREP_BY_GOOD_ADJ    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_GOODS_ADJUST"
    ADD CONSTRAINT "FK_PREP_BY_GOOD_ADJ" FOREIGN KEY ("PREP_BY") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 R   ALTER TABLE ONLY public."INV_GOODS_ADJUST" DROP CONSTRAINT "FK_PREP_BY_GOOD_ADJ";
       public          postgres    false    451    4361    430            �           2606    35156 &   INV_GOODS_REC_MAST FK_PREP_BY_GOOD_EMP    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_GOODS_REC_MAST"
    ADD CONSTRAINT "FK_PREP_BY_GOOD_EMP" FOREIGN KEY ("PREP_BY") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 T   ALTER TABLE ONLY public."INV_GOODS_REC_MAST" DROP CONSTRAINT "FK_PREP_BY_GOOD_EMP";
       public          postgres    false    452    4361    430            f           2606    34810    PIS_PRIZES FK_PRIZE_LOC_POST_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_PRIZES"
    ADD CONSTRAINT "FK_PRIZE_LOC_POST_ID" FOREIGN KEY ("LOCAL_POST_ID") REFERENCES public."PIS_LOCAL_POST_MASTER"("LOCAL_POST_ID") ON DELETE RESTRICT;
 M   ALTER TABLE ONLY public."PIS_PRIZES" DROP CONSTRAINT "FK_PRIZE_LOC_POST_ID";
       public          postgres    false    395    4222    433            �           2606    35352 #   PIS_EMP_PUNISHMNTS FK_PUNISH_EMP_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_EMP_PUNISHMNTS"
    ADD CONSTRAINT "FK_PUNISH_EMP_ID" FOREIGN KEY ("EMP_ID") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 Q   ALTER TABLE ONLY public."PIS_EMP_PUNISHMNTS" DROP CONSTRAINT "FK_PUNISH_EMP_ID";
       public          postgres    false    430    462    4361            �           2606    35357 (   PIS_EMP_PUNISHMNTS FK_PUNISH_LOC_POST_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_EMP_PUNISHMNTS"
    ADD CONSTRAINT "FK_PUNISH_LOC_POST_ID" FOREIGN KEY ("LOCAL_POST_ID") REFERENCES public."PIS_LOCAL_POST_MASTER"("LOCAL_POST_ID") ON DELETE RESTRICT;
 V   ALTER TABLE ONLY public."PIS_EMP_PUNISHMNTS" DROP CONSTRAINT "FK_PUNISH_LOC_POST_ID";
       public          postgres    false    4222    462    395            �           2606    35668 (   INV_PUR_ORDER_DETL FK_PUR_ORDER_BRAND_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_PUR_ORDER_DETL"
    ADD CONSTRAINT "FK_PUR_ORDER_BRAND_ID" FOREIGN KEY ("BRAND_ID") REFERENCES public."INV_BRAND"("BRAND_ID") ON DELETE RESTRICT;
 V   ALTER TABLE ONLY public."INV_PUR_ORDER_DETL" DROP CONSTRAINT "FK_PUR_ORDER_BRAND_ID";
       public          postgres    false    3931    242    477            �           2606    35673 '   INV_PUR_ORDER_DETL FK_PUR_ORDER_ITEM_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_PUR_ORDER_DETL"
    ADD CONSTRAINT "FK_PUR_ORDER_ITEM_ID" FOREIGN KEY ("ITEM_ID") REFERENCES public."INV_ITEM_MST"("ITEM_ID") ON DELETE RESTRICT;
 U   ALTER TABLE ONLY public."INV_PUR_ORDER_DETL" DROP CONSTRAINT "FK_PUR_ORDER_ITEM_ID";
       public          postgres    false    387    4194    477            �           2606    35678 )   INV_PUR_ORDER_DETL FK_PUR_ORDER_ITEM_TYPE    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_PUR_ORDER_DETL"
    ADD CONSTRAINT "FK_PUR_ORDER_ITEM_TYPE" FOREIGN KEY ("ITEM_TYPE") REFERENCES public."INV_ITEM_CATEGORY"("ID") ON DELETE RESTRICT;
 W   ALTER TABLE ONLY public."INV_PUR_ORDER_DETL" DROP CONSTRAINT "FK_PUR_ORDER_ITEM_TYPE";
       public          postgres    false    477    3945    249            �           2606    35688 '   INV_PUR_ORDER_DETL FK_PUR_ORDER_SPEC_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_PUR_ORDER_DETL"
    ADD CONSTRAINT "FK_PUR_ORDER_SPEC_ID" FOREIGN KEY ("SPEC_ID") REFERENCES public."INV_ITEM_SPEC"("SPEC_ID") ON DELETE RESTRICT;
 U   ALTER TABLE ONLY public."INV_PUR_ORDER_DETL" DROP CONSTRAINT "FK_PUR_ORDER_SPEC_ID";
       public          postgres    false    477    250    3947            �           2606    35693 '   INV_PUR_ORDER_DETL FK_PUR_ORDER_UNIT_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_PUR_ORDER_DETL"
    ADD CONSTRAINT "FK_PUR_ORDER_UNIT_ID" FOREIGN KEY ("UNIT_ID") REFERENCES public."INV_UNIT"("UNIT_ID") ON DELETE RESTRICT;
 U   ALTER TABLE ONLY public."INV_PUR_ORDER_DETL" DROP CONSTRAINT "FK_PUR_ORDER_UNIT_ID";
       public          postgres    false    3971    477    264            �           2606    35758 .   PIS_PYROLL_LOAN_DTLS FK_PYROLL_LOAN_DTLS_ACCID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_PYROLL_LOAN_DTLS"
    ADD CONSTRAINT "FK_PYROLL_LOAN_DTLS_ACCID" FOREIGN KEY ("ACC_ID") REFERENCES public."ACC_ACC_MASTER"("ACC_ID") ON DELETE RESTRICT;
 \   ALTER TABLE ONLY public."PIS_PYROLL_LOAN_DTLS" DROP CONSTRAINT "FK_PYROLL_LOAN_DTLS_ACCID";
       public          postgres    false    480    377    4164            �           2606    35763 .   PIS_PYROLL_LOAN_DTLS FK_PYROLL_LOAN_DTLS_EMPID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_PYROLL_LOAN_DTLS"
    ADD CONSTRAINT "FK_PYROLL_LOAN_DTLS_EMPID" FOREIGN KEY ("EMP_ID") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 \   ALTER TABLE ONLY public."PIS_PYROLL_LOAN_DTLS" DROP CONSTRAINT "FK_PYROLL_LOAN_DTLS_EMPID";
       public          postgres    false    430    480    4361            �           2606    35768 ,   PIS_PYROLL_LOAN_DTLS FK_PYROLL_LOAN_DTLS_LID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_PYROLL_LOAN_DTLS"
    ADD CONSTRAINT "FK_PYROLL_LOAN_DTLS_LID" FOREIGN KEY ("LOAND_ID") REFERENCES public."PIS_EMP_LOANS"("LOAN_ID") ON DELETE RESTRICT;
 Z   ALTER TABLE ONLY public."PIS_PYROLL_LOAN_DTLS" DROP CONSTRAINT "FK_PYROLL_LOAN_DTLS_LID";
       public          postgres    false    4491    480    459            �           2606    35773 -   PIS_PYROLL_LOAN_DTLS FK_PYROLL_LOAN_DTLS_PRID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_PYROLL_LOAN_DTLS"
    ADD CONSTRAINT "FK_PYROLL_LOAN_DTLS_PRID" FOREIGN KEY ("PAYROLL_ID") REFERENCES public."PIS_PAYROLLS"("ID") ON DELETE RESTRICT;
 [   ALTER TABLE ONLY public."PIS_PYROLL_LOAN_DTLS" DROP CONSTRAINT "FK_PYROLL_LOAN_DTLS_PRID";
       public          postgres    false    311    4066    480            �           2606    35457 +   PIS_PYROLL_OTHR_DTLS FK_PYROLL_OTHR_DTLS_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_PYROLL_OTHR_DTLS"
    ADD CONSTRAINT "FK_PYROLL_OTHR_DTLS_ID" FOREIGN KEY ("PAYROLL_ID") REFERENCES public."PIS_PAYROLLS"("ID") ON DELETE RESTRICT;
 Y   ALTER TABLE ONLY public."PIS_PYROLL_OTHR_DTLS" DROP CONSTRAINT "FK_PYROLL_OTHR_DTLS_ID";
       public          postgres    false    311    467    4066            �           2606    35452 -   PIS_PYROLL_OTHR_DTLS FK_PYROL_OTHR_DTLS_EMPID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_PYROLL_OTHR_DTLS"
    ADD CONSTRAINT "FK_PYROL_OTHR_DTLS_EMPID" FOREIGN KEY ("EMPLOYEE_ID") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 [   ALTER TABLE ONLY public."PIS_PYROLL_OTHR_DTLS" DROP CONSTRAINT "FK_PYROL_OTHR_DTLS_EMPID";
       public          postgres    false    430    467    4361                       2606    34139    MAP_REGION_FAR FK_REGIONID    FK CONSTRAINT     �   ALTER TABLE ONLY public."MAP_REGION_FAR"
    ADD CONSTRAINT "FK_REGIONID" FOREIGN KEY ("REGIONID") REFERENCES public."MAP_ZONE"("ID") ON DELETE RESTRICT;
 H   ALTER TABLE ONLY public."MAP_REGION_FAR" DROP CONSTRAINT "FK_REGIONID";
       public          postgres    false    389    4024    289                       2606    34129 &   MAP_AREA_GND_COV FK_REGN_ID_AP_GND_COV    FK CONSTRAINT     �   ALTER TABLE ONLY public."MAP_AREA_GND_COV"
    ADD CONSTRAINT "FK_REGN_ID_AP_GND_COV" FOREIGN KEY ("REGIONID") REFERENCES public."MAP_ZONE"("ID") ON DELETE RESTRICT;
 T   ALTER TABLE ONLY public."MAP_AREA_GND_COV" DROP CONSTRAINT "FK_REGN_ID_AP_GND_COV";
       public          postgres    false    4024    289    388            �           2606    35572 /   PIS_REPLACED_IN_DARBANDI FK_REPL_FD_DARBANDI_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_REPLACED_IN_DARBANDI"
    ADD CONSTRAINT "FK_REPL_FD_DARBANDI_ID" FOREIGN KEY ("DARBANDI_ID") REFERENCES public."PIS_DARBANDI"("DARBANDI_ID") ON DELETE RESTRICT;
 ]   ALTER TABLE ONLY public."PIS_REPLACED_IN_DARBANDI" DROP CONSTRAINT "FK_REPL_FD_DARBANDI_ID";
       public          postgres    false    429    4354    474            �           2606    35582 -   PIS_REPLACED_IN_DARBANDI FK_REPL_FD_OFFICE_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_REPLACED_IN_DARBANDI"
    ADD CONSTRAINT "FK_REPL_FD_OFFICE_ID" FOREIGN KEY ("OFFICE_ID") REFERENCES public."ORGANIZATION_TREE"("ID") ON DELETE RESTRICT;
 [   ALTER TABLE ONLY public."PIS_REPLACED_IN_DARBANDI" DROP CONSTRAINT "FK_REPL_FD_OFFICE_ID";
       public          postgres    false    474    4219    394            �           2606    35232 )   INV_REQUISITION_MAST FK_REQ_ACCEPT_BY_EMP    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_REQUISITION_MAST"
    ADD CONSTRAINT "FK_REQ_ACCEPT_BY_EMP" FOREIGN KEY ("ACCEPT_BY") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 W   ALTER TABLE ONLY public."INV_REQUISITION_MAST" DROP CONSTRAINT "FK_REQ_ACCEPT_BY_EMP";
       public          postgres    false    4361    430    455            �           2606    35237 (   INV_REQUISITION_MAST FK_REQ_CHECK_BY_EMP    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_REQUISITION_MAST"
    ADD CONSTRAINT "FK_REQ_CHECK_BY_EMP" FOREIGN KEY ("CHECK_BY") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 V   ALTER TABLE ONLY public."INV_REQUISITION_MAST" DROP CONSTRAINT "FK_REQ_CHECK_BY_EMP";
       public          postgres    false    4361    455    430            �           2606    35242 #   INV_REQUISITION_MAST FK_REQ_ITEM_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_REQUISITION_MAST"
    ADD CONSTRAINT "FK_REQ_ITEM_ID" FOREIGN KEY ("ITEM_ID") REFERENCES public."INV_ITEM_MST"("ITEM_ID") ON DELETE RESTRICT;
 Q   ALTER TABLE ONLY public."INV_REQUISITION_MAST" DROP CONSTRAINT "FK_REQ_ITEM_ID";
       public          postgres    false    4194    387    455            �           2606    35247 '   INV_REQUISITION_MAST FK_REQ_PREP_BY_EMP    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_REQUISITION_MAST"
    ADD CONSTRAINT "FK_REQ_PREP_BY_EMP" FOREIGN KEY ("PREP_BY") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 U   ALTER TABLE ONLY public."INV_REQUISITION_MAST" DROP CONSTRAINT "FK_REQ_PREP_BY_EMP";
       public          postgres    false    4361    430    455            �           2606    35252 &   INV_REQUISITION_MAST FK_REQ_PROJECT_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_REQUISITION_MAST"
    ADD CONSTRAINT "FK_REQ_PROJECT_ID" FOREIGN KEY ("PROJ_ID") REFERENCES public."INV_PROJECT"("PROJECT_ID") ON DELETE RESTRICT;
 T   ALTER TABLE ONLY public."INV_REQUISITION_MAST" DROP CONSTRAINT "FK_REQ_PROJECT_ID";
       public          postgres    false    455    3957    256            �           2606    35257 "   INV_REQUISITION_MAST FK_REQ_REQ_BY    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_REQUISITION_MAST"
    ADD CONSTRAINT "FK_REQ_REQ_BY" FOREIGN KEY ("REQ_BY") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 P   ALTER TABLE ONLY public."INV_REQUISITION_MAST" DROP CONSTRAINT "FK_REQ_REQ_BY";
       public          postgres    false    430    455    4361                       2606    34096    INV_ROOM_MST FK_ROOM_DEP_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_ROOM_MST"
    ADD CONSTRAINT "FK_ROOM_DEP_ID" FOREIGN KEY ("DEPT_ID") REFERENCES public."INV_DEPT"("DEPT_ID") ON DELETE RESTRICT;
 I   ALTER TABLE ONLY public."INV_ROOM_MST" DROP CONSTRAINT "FK_ROOM_DEP_ID";
       public          postgres    false    245    3937    385            4           2606    34449 +   SERVICE_CHARGE_MASTER FK_SERVICE_CHR_ACC_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."SERVICE_CHARGE_MASTER"
    ADD CONSTRAINT "FK_SERVICE_CHR_ACC_ID" FOREIGN KEY ("ACC_ID") REFERENCES public."ACC_ACC_MASTER"("ACC_ID") ON DELETE RESTRICT;
 Y   ALTER TABLE ONLY public."SERVICE_CHARGE_MASTER" DROP CONSTRAINT "FK_SERVICE_CHR_ACC_ID";
       public          postgres    false    377    413    4164            h           2606    34830 &   PIS_SGNFCNT_WORK FK_SGNWRK_LOC_POST_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_SGNFCNT_WORK"
    ADD CONSTRAINT "FK_SGNWRK_LOC_POST_ID" FOREIGN KEY ("LOCAL_POST_ID") REFERENCES public."PIS_LOCAL_POST_MASTER"("LOCAL_POST_ID") ON DELETE RESTRICT;
 T   ALTER TABLE ONLY public."PIS_SGNFCNT_WORK" DROP CONSTRAINT "FK_SGNWRK_LOC_POST_ID";
       public          postgres    false    435    395    4222            �           2606    35367     PIS_EMP_SRVC_DTLS FK_SRVC_EMP_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_EMP_SRVC_DTLS"
    ADD CONSTRAINT "FK_SRVC_EMP_ID" FOREIGN KEY ("EMP_ID") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 N   ALTER TABLE ONLY public."PIS_EMP_SRVC_DTLS" DROP CONSTRAINT "FK_SRVC_EMP_ID";
       public          postgres    false    430    463    4361            �           2606    35372 %   PIS_EMP_SRVC_DTLS FK_SRVC_LOC_POST_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_EMP_SRVC_DTLS"
    ADD CONSTRAINT "FK_SRVC_LOC_POST_ID" FOREIGN KEY ("LOCAL_POST_ID") REFERENCES public."PIS_LOCAL_POST_MASTER"("LOCAL_POST_ID") ON DELETE RESTRICT;
 S   ALTER TABLE ONLY public."PIS_EMP_SRVC_DTLS" DROP CONSTRAINT "FK_SRVC_LOC_POST_ID";
       public          postgres    false    463    395    4222            �           2606    35166 -   INV_ITEM_STATUSCHECK FK_STATUSCHECK_ACCEPT_BY    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_ITEM_STATUSCHECK"
    ADD CONSTRAINT "FK_STATUSCHECK_ACCEPT_BY" FOREIGN KEY ("ACCEPTED_BY") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 [   ALTER TABLE ONLY public."INV_ITEM_STATUSCHECK" DROP CONSTRAINT "FK_STATUSCHECK_ACCEPT_BY";
       public          postgres    false    453    430    4361            �           2606    35171 ,   INV_ITEM_STATUSCHECK FK_STATUSCHECK_BRAND_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_ITEM_STATUSCHECK"
    ADD CONSTRAINT "FK_STATUSCHECK_BRAND_ID" FOREIGN KEY ("BRAND_ID") REFERENCES public."INV_BRAND"("BRAND_ID") ON DELETE RESTRICT;
 Z   ALTER TABLE ONLY public."INV_ITEM_STATUSCHECK" DROP CONSTRAINT "FK_STATUSCHECK_BRAND_ID";
       public          postgres    false    242    3931    453            �           2606    35191 ,   INV_ITEM_STATUSCHECK FK_STATUSCHECK_CHECK_BY    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_ITEM_STATUSCHECK"
    ADD CONSTRAINT "FK_STATUSCHECK_CHECK_BY" FOREIGN KEY ("TALLY_BY") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 Z   ALTER TABLE ONLY public."INV_ITEM_STATUSCHECK" DROP CONSTRAINT "FK_STATUSCHECK_CHECK_BY";
       public          postgres    false    430    453    4361            �           2606    35181 +   INV_ITEM_STATUSCHECK FK_STATUSCHECK_PREP_BY    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_ITEM_STATUSCHECK"
    ADD CONSTRAINT "FK_STATUSCHECK_PREP_BY" FOREIGN KEY ("PREP_BY") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 Y   ALTER TABLE ONLY public."INV_ITEM_STATUSCHECK" DROP CONSTRAINT "FK_STATUSCHECK_PREP_BY";
       public          postgres    false    4361    453    430            �           2606    35186 +   INV_ITEM_STATUSCHECK FK_STATUSCHECK_SPEC_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_ITEM_STATUSCHECK"
    ADD CONSTRAINT "FK_STATUSCHECK_SPEC_ID" FOREIGN KEY ("SPEC_ID") REFERENCES public."INV_ITEM_SPEC"("SPEC_ID") ON DELETE RESTRICT;
 Y   ALTER TABLE ONLY public."INV_ITEM_STATUSCHECK" DROP CONSTRAINT "FK_STATUSCHECK_SPEC_ID";
       public          postgres    false    453    250    3947            �           2606    35219 %   INV_PUR_ORDER_MAST FK_SUPP_ID_SPPLIER    FK CONSTRAINT     �   ALTER TABLE ONLY public."INV_PUR_ORDER_MAST"
    ADD CONSTRAINT "FK_SUPP_ID_SPPLIER" FOREIGN KEY ("SUPP_ID") REFERENCES public."INV_SUPPLIER"("SUP_ID") ON DELETE RESTRICT;
 S   ALTER TABLE ONLY public."INV_PUR_ORDER_MAST" DROP CONSTRAINT "FK_SUPP_ID_SPPLIER";
       public          postgres    false    260    454    3963            �           2606    35382 !   PIS_EMP_SUSPENDS FK_SUSPND_EMP_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_EMP_SUSPENDS"
    ADD CONSTRAINT "FK_SUSPND_EMP_ID" FOREIGN KEY ("EMP_ID") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 O   ALTER TABLE ONLY public."PIS_EMP_SUSPENDS" DROP CONSTRAINT "FK_SUSPND_EMP_ID";
       public          postgres    false    464    4361    430            �           2606    35387 &   PIS_EMP_SUSPENDS FK_SUSPND_LOC_POST_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_EMP_SUSPENDS"
    ADD CONSTRAINT "FK_SUSPND_LOC_POST_ID" FOREIGN KEY ("LOCAL_POST_ID") REFERENCES public."PIS_LOCAL_POST_MASTER"("LOCAL_POST_ID") ON DELETE RESTRICT;
 T   ALTER TABLE ONLY public."PIS_EMP_SUSPENDS" DROP CONSTRAINT "FK_SUSPND_LOC_POST_ID";
       public          postgres    false    4222    395    464            5           2606    34464 3   TAX_ADDTNL_CHRG_DTLS FK_TAX_ADDTNL_CHRG_DTLS_ACCODE    FK CONSTRAINT     �   ALTER TABLE ONLY public."TAX_ADDTNL_CHRG_DTLS"
    ADD CONSTRAINT "FK_TAX_ADDTNL_CHRG_DTLS_ACCODE" FOREIGN KEY ("ACCODE") REFERENCES public."ACCODE"("ACCODE") ON DELETE RESTRICT;
 a   ALTER TABLE ONLY public."TAX_ADDTNL_CHRG_DTLS" DROP CONSTRAINT "FK_TAX_ADDTNL_CHRG_DTLS_ACCODE";
       public          postgres    false    3909    221    414            6           2606    34459 *   TAX_ADDTNL_CHRG_DTLS FK_TAX_ADD_DTL_ACC_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."TAX_ADDTNL_CHRG_DTLS"
    ADD CONSTRAINT "FK_TAX_ADD_DTL_ACC_ID" FOREIGN KEY ("ACC_ID") REFERENCES public."ACC_ACC_MASTER"("ACC_ID") ON DELETE RESTRICT;
 X   ALTER TABLE ONLY public."TAX_ADDTNL_CHRG_DTLS" DROP CONSTRAINT "FK_TAX_ADD_DTL_ACC_ID";
       public          postgres    false    4164    377    414            )           2606    34374    ACC_BGT_TRANSFER FK_TO_ACC_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_BGT_TRANSFER"
    ADD CONSTRAINT "FK_TO_ACC_ID" FOREIGN KEY ("TO_ACC_ID") REFERENCES public."ACC_ACC_MASTER"("ACC_ID") ON DELETE RESTRICT;
 K   ALTER TABLE ONLY public."ACC_BGT_TRANSFER" DROP CONSTRAINT "FK_TO_ACC_ID";
       public          postgres    false    4164    408    377            �           2606    35562 *   PIS_DELETD_FRM_FULFILD_DARB FK_TO_SN_IN_FD    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_DELETD_FRM_FULFILD_DARB"
    ADD CONSTRAINT "FK_TO_SN_IN_FD" FOREIGN KEY ("TO_SN_IN_FD") REFERENCES public."PIS_FULFILLED_DARBANDI"("SN") ON DELETE RESTRICT;
 X   ALTER TABLE ONLY public."PIS_DELETD_FRM_FULFILD_DARB" DROP CONSTRAINT "FK_TO_SN_IN_FD";
       public          postgres    false    450    4442    473            i           2606    34840     PIS_TRAINING FK_TRNG_LOC_POST_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_TRAINING"
    ADD CONSTRAINT "FK_TRNG_LOC_POST_ID" FOREIGN KEY ("LOCAL_POST_ID") REFERENCES public."PIS_LOCAL_POST_MASTER"("LOCAL_POST_ID") ON DELETE RESTRICT;
 N   ALTER TABLE ONLY public."PIS_TRAINING" DROP CONSTRAINT "FK_TRNG_LOC_POST_ID";
       public          postgres    false    395    4222    436            *           2606    34364 '   ACC_BGT_TRANSFER FK_TRNSFR_BGT_ALCTN_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_BGT_TRANSFER"
    ADD CONSTRAINT "FK_TRNSFR_BGT_ALCTN_ID" FOREIGN KEY ("BGT_ALCTN_ID") REFERENCES public."ACC_BGT_ALLOCATE"("BGT_ALLOCATE_ID") ON DELETE RESTRICT;
 U   ALTER TABLE ONLY public."ACC_BGT_TRANSFER" DROP CONSTRAINT "FK_TRNSFR_BGT_ALCTN_ID";
       public          postgres    false    408    3879    204            �           2606    35397 #   PIS_EMP_TRNSFR_REC FK_TRNSFR_EMP_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_EMP_TRNSFR_REC"
    ADD CONSTRAINT "FK_TRNSFR_EMP_ID" FOREIGN KEY ("EMP_ID") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 Q   ALTER TABLE ONLY public."PIS_EMP_TRNSFR_REC" DROP CONSTRAINT "FK_TRNSFR_EMP_ID";
       public          postgres    false    465    4361    430            �           2606    35402 (   PIS_EMP_TRNSFR_REC FK_TRNSFR_LOC_POST_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_EMP_TRNSFR_REC"
    ADD CONSTRAINT "FK_TRNSFR_LOC_POST_ID" FOREIGN KEY ("LOCAL_POST_ID") REFERENCES public."PIS_LOCAL_POST_MASTER"("LOCAL_POST_ID") ON DELETE RESTRICT;
 V   ALTER TABLE ONLY public."PIS_EMP_TRNSFR_REC" DROP CONSTRAINT "FK_TRNSFR_LOC_POST_ID";
       public          postgres    false    395    465    4222            �           2606    35487 !   PIS_VISITED_COUNTRIES FK_VISIT_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_VISITED_COUNTRIES"
    ADD CONSTRAINT "FK_VISIT_ID" FOREIGN KEY ("VISIT_ID") REFERENCES public."PIS_FOREIGN_VISITS"("SN") ON DELETE RESTRICT;
 O   ALTER TABLE ONLY public."PIS_VISITED_COUNTRIES" DROP CONSTRAINT "FK_VISIT_ID";
       public          postgres    false    431    4364    469            �           2606    35467    WARD_MASTER FK_WARD_PRAMUKH_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."WARD_MASTER"
    ADD CONSTRAINT "FK_WARD_PRAMUKH_ID" FOREIGN KEY ("PRAMUKH_ID") REFERENCES public."ACC_PADADHIKARI_MSTR"("PADADIKARI_ID") ON DELETE RESTRICT;
 L   ALTER TABLE ONLY public."WARD_MASTER" DROP CONSTRAINT "FK_WARD_PRAMUKH_ID";
       public          postgres    false    468    376    4161            �           2606    35477     WARD_MASTER FK_WARD_SECRETARY_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."WARD_MASTER"
    ADD CONSTRAINT "FK_WARD_SECRETARY_ID" FOREIGN KEY ("WARD_SECRETARY_ID") REFERENCES public."PIS_EMPLOYEE_MASTER"("EMP_ID") ON DELETE RESTRICT;
 N   ALTER TABLE ONLY public."WARD_MASTER" DROP CONSTRAINT "FK_WARD_SECRETARY_ID";
       public          postgres    false    430    468    4361            �           2606    35472 !   WARD_MASTER FK_WARD_UPAPRAMUKH_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."WARD_MASTER"
    ADD CONSTRAINT "FK_WARD_UPAPRAMUKH_ID" FOREIGN KEY ("UPPRAMUKH_ID") REFERENCES public."ACC_PADADHIKARI_MSTR"("PADADIKARI_ID") ON DELETE RESTRICT;
 O   ALTER TABLE ONLY public."WARD_MASTER" DROP CONSTRAINT "FK_WARD_UPAPRAMUKH_ID";
       public          postgres    false    468    4161    376                       2606    34043 '   ACC_WORK_FUNDS_DETAIL FK_WORK_MASTER_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_WORK_FUNDS_DETAIL"
    ADD CONSTRAINT "FK_WORK_MASTER_ID" FOREIGN KEY ("WORK_ID") REFERENCES public."ACC_WORK_MASTER"("WORK_ID") ON DELETE RESTRICT;
 U   ALTER TABLE ONLY public."ACC_WORK_FUNDS_DETAIL" DROP CONSTRAINT "FK_WORK_MASTER_ID";
       public          postgres    false    380    3907    220            j           2606    34853 "   PIS_WORKSHOP FK_WRKSHP_LOC_POST_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_WORKSHOP"
    ADD CONSTRAINT "FK_WRKSHP_LOC_POST_ID" FOREIGN KEY ("LOCAL_POST_ID") REFERENCES public."PIS_LOCAL_POST_MASTER"("LOCAL_POST_ID") ON DELETE RESTRICT;
 P   ALTER TABLE ONLY public."PIS_WORKSHOP" DROP CONSTRAINT "FK_WRKSHP_LOC_POST_ID";
       public          postgres    false    4222    437    395            �           2606    35066    ACC_BANK_TRANS FK__BANK_VCHR_ID    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_BANK_TRANS"
    ADD CONSTRAINT "FK__BANK_VCHR_ID" FOREIGN KEY ("VCHR_ID") REFERENCES public."ACC_VCHR_MASTER"("VCHR_ID") ON DELETE RESTRICT;
 M   ALTER TABLE ONLY public."ACC_BANK_TRANS" DROP CONSTRAINT "FK__BANK_VCHR_ID";
       public          postgres    false    378    448    4167            ?           2606    34542 !   ACC_DHRTI_BILL_MASTER SYS_C004315    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_DHRTI_BILL_MASTER"
    ADD CONSTRAINT "SYS_C004315" FOREIGN KEY ("SUB_MODULE_ID") REFERENCES public."ACC_SUB_MODULE_TYPE"("SUB_MODULE_ID") ON DELETE RESTRICT;
 O   ALTER TABLE ONLY public."ACC_DHRTI_BILL_MASTER" DROP CONSTRAINT "SYS_C004315";
       public          postgres    false    215    3897    420            R           2606    34667    INCOMEBILLMASTER SYS_C004316    FK CONSTRAINT     �   ALTER TABLE ONLY public."INCOMEBILLMASTER"
    ADD CONSTRAINT "SYS_C004316" FOREIGN KEY ("SUB_MODULE_ID") REFERENCES public."ACC_SUB_MODULE_TYPE"("SUB_MODULE_ID") ON DELETE RESTRICT;
 J   ALTER TABLE ONLY public."INCOMEBILLMASTER" DROP CONSTRAINT "SYS_C004316";
       public          postgres    false    3897    425    215                       2606    34086    SUB_MODULE_SOURCE SYS_C004317    FK CONSTRAINT     �   ALTER TABLE ONLY public."SUB_MODULE_SOURCE"
    ADD CONSTRAINT "SYS_C004317" FOREIGN KEY ("SUB_MODULE_ID") REFERENCES public."ACC_SUB_MODULE_TYPE"("SUB_MODULE_ID") ON DELETE RESTRICT;
 K   ALTER TABLE ONLY public."SUB_MODULE_SOURCE" DROP CONSTRAINT "SYS_C004317";
       public          postgres    false    384    3897    215            y           2606    34977    CASHTRANSACTION SYS_C004318    FK CONSTRAINT     �   ALTER TABLE ONLY public."CASHTRANSACTION"
    ADD CONSTRAINT "SYS_C004318" FOREIGN KEY ("SUBMODULE_TYPE_ID") REFERENCES public."ACC_SUB_MODULE_TYPE"("SUB_MODULE_ID") ON DELETE RESTRICT;
 I   ALTER TABLE ONLY public."CASHTRANSACTION" DROP CONSTRAINT "SYS_C004318";
       public          postgres    false    445    3897    215            v           2606    34954    BANKTRANSACTIONS SYS_C004319    FK CONSTRAINT     �   ALTER TABLE ONLY public."BANKTRANSACTIONS"
    ADD CONSTRAINT "SYS_C004319" FOREIGN KEY ("SUBMODULE_TYPE_ID") REFERENCES public."ACC_SUB_MODULE_TYPE"("SUB_MODULE_ID") ON DELETE RESTRICT;
 J   ALTER TABLE ONLY public."BANKTRANSACTIONS" DROP CONSTRAINT "SYS_C004319";
       public          postgres    false    444    3897    215            @           2606    34552 !   ACC_DHRTI_BILL_MASTER SYS_C004344    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_DHRTI_BILL_MASTER"
    ADD CONSTRAINT "SYS_C004344" FOREIGN KEY ("WORK_ID") REFERENCES public."ACC_WORK_MASTER"("WORK_ID") ON DELETE RESTRICT;
 O   ALTER TABLE ONLY public."ACC_DHRTI_BILL_MASTER" DROP CONSTRAINT "SYS_C004344";
       public          postgres    false    220    3907    420            =           2606    34524    ACC_DHRTI_BILL_DTL SYS_C004345    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_DHRTI_BILL_DTL"
    ADD CONSTRAINT "SYS_C004345" FOREIGN KEY ("WORK_ID") REFERENCES public."ACC_WORK_MASTER"("WORK_ID") ON DELETE RESTRICT;
 L   ALTER TABLE ONLY public."ACC_DHRTI_BILL_DTL" DROP CONSTRAINT "SYS_C004345";
       public          postgres    false    419    3907    220            K           2606    34614    ACC_VCHR_DETAILS SYS_C004349    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_VCHR_DETAILS"
    ADD CONSTRAINT "SYS_C004349" FOREIGN KEY ("WORK_ID") REFERENCES public."ACC_WORK_MASTER"("WORK_ID") ON DELETE RESTRICT;
 J   ALTER TABLE ONLY public."ACC_VCHR_DETAILS" DROP CONSTRAINT "SYS_C004349";
       public          postgres    false    422    3907    220                       2606    34192    PIS_EMP_DEP_SOURCE SYS_C004356    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_EMP_DEP_SOURCE"
    ADD CONSTRAINT "SYS_C004356" FOREIGN KEY ("BUDJET_SOURCE_ID") REFERENCES public."BUDJET_SOURCE"("ID") ON DELETE RESTRICT;
 L   ALTER TABLE ONLY public."PIS_EMP_DEP_SOURCE" DROP CONSTRAINT "SYS_C004356";
       public          postgres    false    3918    225    393                       2606    34081    SUB_MODULE_SOURCE SYS_C004357    FK CONSTRAINT     �   ALTER TABLE ONLY public."SUB_MODULE_SOURCE"
    ADD CONSTRAINT "SYS_C004357" FOREIGN KEY ("BUDJET_SOURCE_ID") REFERENCES public."BUDJET_SOURCE"("ID") ON DELETE RESTRICT;
 K   ALTER TABLE ONLY public."SUB_MODULE_SOURCE" DROP CONSTRAINT "SYS_C004357";
       public          postgres    false    225    384    3918            p           2606    34906     TAX_THLI_ISSUED_CNTR SYS_C004358    FK CONSTRAINT     �   ALTER TABLE ONLY public."TAX_THLI_ISSUED_CNTR"
    ADD CONSTRAINT "SYS_C004358" FOREIGN KEY ("CNTR_ID") REFERENCES public."COLLECTIONCOUNTERS"("COUNTERID") ON DELETE RESTRICT;
 N   ALTER TABLE ONLY public."TAX_THLI_ISSUED_CNTR" DROP CONSTRAINT "SYS_C004358";
       public          postgres    false    441    229    3921                       2606    34235    SANITATION_SUBGROUP SYS_C004385    FK CONSTRAINT     �   ALTER TABLE ONLY public."SANITATION_SUBGROUP"
    ADD CONSTRAINT "SYS_C004385" FOREIGN KEY ("GROUPID") REFERENCES public."SANITATION_GROUP"("ID") ON DELETE RESTRICT;
 M   ALTER TABLE ONLY public."SANITATION_SUBGROUP" DROP CONSTRAINT "SYS_C004385";
       public          postgres    false    322    396    4084            k           2606    34866    SANITATION_RATE SYS_C004386    FK CONSTRAINT     �   ALTER TABLE ONLY public."SANITATION_RATE"
    ADD CONSTRAINT "SYS_C004386" FOREIGN KEY ("GROUPID") REFERENCES public."SANITATION_GROUP"("ID") ON DELETE RESTRICT;
 I   ALTER TABLE ONLY public."SANITATION_RATE" DROP CONSTRAINT "SYS_C004386";
       public          postgres    false    322    4084    438            l           2606    34871    SANITATION_RATE SYS_C004387    FK CONSTRAINT     �   ALTER TABLE ONLY public."SANITATION_RATE"
    ADD CONSTRAINT "SYS_C004387" FOREIGN KEY ("SUBGROUPID") REFERENCES public."SANITATION_SUBGROUP"("ID") ON DELETE RESTRICT;
 I   ALTER TABLE ONLY public."SANITATION_RATE" DROP CONSTRAINT "SYS_C004387";
       public          postgres    false    438    4225    396            q           2606    34911     TAX_THLI_ISSUED_CNTR SYS_C004388    FK CONSTRAINT     �   ALTER TABLE ONLY public."TAX_THLI_ISSUED_CNTR"
    ADD CONSTRAINT "SYS_C004388" FOREIGN KEY ("THELI_ID") REFERENCES public."STOREDBILLS"("SN") ON DELETE RESTRICT;
 N   ALTER TABLE ONLY public."TAX_THLI_ISSUED_CNTR" DROP CONSTRAINT "SYS_C004388";
       public          postgres    false    4237    441    400            A           2606    34537 !   ACC_DHRTI_BILL_MASTER SYS_C004389    FK CONSTRAINT     �   ALTER TABLE ONLY public."ACC_DHRTI_BILL_MASTER"
    ADD CONSTRAINT "SYS_C004389" FOREIGN KEY ("BILLTYPEID") REFERENCES public."TBLBILLTYPE"("ID") ON DELETE RESTRICT;
 O   ALTER TABLE ONLY public."ACC_DHRTI_BILL_MASTER" DROP CONSTRAINT "SYS_C004389";
       public          postgres    false    420    4138    359            S           2606    34662    INCOMEBILLMASTER SYS_C004390    FK CONSTRAINT     �   ALTER TABLE ONLY public."INCOMEBILLMASTER"
    ADD CONSTRAINT "SYS_C004390" FOREIGN KEY ("BILLTYPEID") REFERENCES public."TBLBILLTYPE"("ID") ON DELETE RESTRICT;
 J   ALTER TABLE ONLY public."INCOMEBILLMASTER" DROP CONSTRAINT "SYS_C004390";
       public          postgres    false    425    4138    359                        2606    34275    STOREDBILLS SYS_C004391    FK CONSTRAINT     �   ALTER TABLE ONLY public."STOREDBILLS"
    ADD CONSTRAINT "SYS_C004391" FOREIGN KEY ("BILLTYPEID") REFERENCES public."TBLBILLTYPE"("ID") ON DELETE RESTRICT;
 E   ALTER TABLE ONLY public."STOREDBILLS" DROP CONSTRAINT "SYS_C004391";
       public          postgres    false    359    4138    400            !           2606    34285    TBLMALPOTSUBGROUP SYS_C004392    FK CONSTRAINT     �   ALTER TABLE ONLY public."TBLMALPOTSUBGROUP"
    ADD CONSTRAINT "SYS_C004392" FOREIGN KEY ("GROUPID") REFERENCES public."TBLMALPOTGROUP"("ID") ON DELETE RESTRICT;
 K   ALTER TABLE ONLY public."TBLMALPOTSUBGROUP" DROP CONSTRAINT "SYS_C004392";
       public          postgres    false    401    364    4144            r           2606    34921    TBLMALPOTRATES SYS_C004393    FK CONSTRAINT     �   ALTER TABLE ONLY public."TBLMALPOTRATES"
    ADD CONSTRAINT "SYS_C004393" FOREIGN KEY ("GROUPID") REFERENCES public."TBLMALPOTGROUP"("ID") ON DELETE RESTRICT;
 H   ALTER TABLE ONLY public."TBLMALPOTRATES" DROP CONSTRAINT "SYS_C004393";
       public          postgres    false    442    364    4144            �           2606    35512     TBLFYWISEMPOTASSRATE SYS_C004394    FK CONSTRAINT     �   ALTER TABLE ONLY public."TBLFYWISEMPOTASSRATE"
    ADD CONSTRAINT "SYS_C004394" FOREIGN KEY ("GROUPID") REFERENCES public."TBLMALPOTGROUP"("ID") ON DELETE RESTRICT;
 N   ALTER TABLE ONLY public."TBLFYWISEMPOTASSRATE" DROP CONSTRAINT "SYS_C004394";
       public          postgres    false    4144    364    471            �           2606    35517     TBLFYWISEMPOTASSRATE SYS_C004395    FK CONSTRAINT     �   ALTER TABLE ONLY public."TBLFYWISEMPOTASSRATE"
    ADD CONSTRAINT "SYS_C004395" FOREIGN KEY ("RATEID") REFERENCES public."TBLMALPOTRATES"("ID") ON DELETE RESTRICT;
 N   ALTER TABLE ONLY public."TBLFYWISEMPOTASSRATE" DROP CONSTRAINT "SYS_C004395";
       public          postgres    false    471    4401    442            �           2606    35502 $   TBL_MALPOT_OTHER_CHARGES SYS_C004396    FK CONSTRAINT     �   ALTER TABLE ONLY public."TBL_MALPOT_OTHER_CHARGES"
    ADD CONSTRAINT "SYS_C004396" FOREIGN KEY ("RATEID") REFERENCES public."TBLMALPOTRATES"("ID") ON DELETE RESTRICT;
 R   ALTER TABLE ONLY public."TBL_MALPOT_OTHER_CHARGES" DROP CONSTRAINT "SYS_C004396";
       public          postgres    false    4401    442    470            s           2606    34926    TBLMALPOTRATES SYS_C004397    FK CONSTRAINT     �   ALTER TABLE ONLY public."TBLMALPOTRATES"
    ADD CONSTRAINT "SYS_C004397" FOREIGN KEY ("SUBGROUPID") REFERENCES public."TBLMALPOTSUBGROUP"("ID") ON DELETE RESTRICT;
 H   ALTER TABLE ONLY public."TBLMALPOTRATES" DROP CONSTRAINT "SYS_C004397";
       public          postgres    false    4240    442    401            �           2606    35522     TBLFYWISEMPOTASSRATE SYS_C004398    FK CONSTRAINT     �   ALTER TABLE ONLY public."TBLFYWISEMPOTASSRATE"
    ADD CONSTRAINT "SYS_C004398" FOREIGN KEY ("SUBGROUPID") REFERENCES public."TBLMALPOTSUBGROUP"("ID") ON DELETE RESTRICT;
 N   ALTER TABLE ONLY public."TBLFYWISEMPOTASSRATE" DROP CONSTRAINT "SYS_C004398";
       public          postgres    false    471    4240    401                       2606    34197    PIS_EMP_DEP_SOURCE SYS_C004447    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_EMP_DEP_SOURCE"
    ADD CONSTRAINT "SYS_C004447" FOREIGN KEY ("DEPT_ID") REFERENCES public."PIS_EMP_DEP"("DEPT_ID") ON DELETE CASCADE;
 L   ALTER TABLE ONLY public."PIS_EMP_DEP_SOURCE" DROP CONSTRAINT "SYS_C004447";
       public          postgres    false    393    302    4047            c           2606    34760    PIS_EMPLOYEE_MASTER SYS_C004448    FK CONSTRAINT     �   ALTER TABLE ONLY public."PIS_EMPLOYEE_MASTER"
    ADD CONSTRAINT "SYS_C004448" FOREIGN KEY ("DEPT_ID") REFERENCES public."PIS_EMP_DEP"("DEPT_ID") ON DELETE RESTRICT;
 M   ALTER TABLE ONLY public."PIS_EMPLOYEE_MASTER" DROP CONSTRAINT "SYS_C004448";
       public          postgres    false    430    4047    302            z           2606    34972    CASHTRANSACTION SYS_C004544    FK CONSTRAINT     �   ALTER TABLE ONLY public."CASHTRANSACTION"
    ADD CONSTRAINT "SYS_C004544" FOREIGN KEY ("DHRTI_MASTER_ID") REFERENCES public."ACC_DHRTI_BILL_MASTER"("DHRTI_MASTER_ID") ON DELETE RESTRICT;
 I   ALTER TABLE ONLY public."CASHTRANSACTION" DROP CONSTRAINT "SYS_C004544";
       public          postgres    false    420    4303    445            w           2606    34949    BANKTRANSACTIONS SYS_C004545    FK CONSTRAINT     �   ALTER TABLE ONLY public."BANKTRANSACTIONS"
    ADD CONSTRAINT "SYS_C004545" FOREIGN KEY ("DHRTI_MASTER_ID") REFERENCES public."ACC_DHRTI_BILL_MASTER"("DHRTI_MASTER_ID") ON DELETE RESTRICT;
 J   ALTER TABLE ONLY public."BANKTRANSACTIONS" DROP CONSTRAINT "SYS_C004545";
       public          postgres    false    420    4303    444            �      x������ � �             x������ � �      .      x������ � �      "      x������ � �      r      x������ � �      g      x������ � �      s      x������ � �            x������ � �      ?      x������ � �      -      x������ � �      h      x������ � �      t      x������ � �      u      x������ � �            x������ � �      J      x������ � �      K      x������ � �      @      x������ � �      v      x������ � �      w      x������ � �      y      x������ � �      x      x������ � �      z      x������ � �            x������ � �      {      x������ � �      A      x������ � �      |      x������ � �      e      x������ � �      f      x������ � �      L      x������ � �      }      x������ � �      ~      x������ � �            x������ � �      �      x������ � �      �      x������ � �      M      x������ � �      !      x������ � �      �      x������ � �      #      x������ � �      �      x������ � �      N      x������ � �      �      x������ � �      %      x������ � �      �      x������ � �      :      x������ � �      ;      x������ � �      <      x������ � �      =      x������ � �      �      x������ � �      c      x������ � �      &      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      d      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      B      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      O      x������ � �      �      x������ � �      P      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      j      x������ � �      �      x������ � �      k      x������ � �      �      x������ � �      �      x������ � �      R      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      *      x������ � �      �      x������ � �      l      x������ � �      )      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      m      x������ � �      �      x������ � �      n      x������ � �      �      x������ � �      (      x������ � �      o      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      +      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      C      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      ,      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      1      x������ � �      Q      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      S      x������ � �      p      x������ � �      T      x������ � �      �      x������ � �      /      x������ � �      �      x������ � �      �      x������ � �      U      x������ � �      q      x������ � �      �      x������ � �      �      x������ � �      0      x������ � �      �      x������ � �      r      x������ � �      s      x������ � �      t      x������ � �      u      x������ � �      v      x������ � �      w      x������ � �      x      x������ � �      V      x������ � �      i      x������ � �      �      x������ � �      �      x������ � �      y      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      2      x������ � �      �      x������ � �      �      x������ � �      W      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      X      x������ � �      Y      x������ � �      �      x������ � �      z      x������ � �      �      x������ � �      �      x������ � �      Z      x������ � �      �      x������ � �      [      x������ � �      |      x������ � �      \      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      ]      x������ � �      3      x������ � �      D      x������ � �      �      x������ � �      7      x������ � �      �      x������ � �      '      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      E      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      `      x������ � �      �      x������ � �            x������ � �      H      x������ � �            x������ � �            x������ � �      ~      x������ � �            x������ � �            x������ � �            x������ � �      a      x������ � �      8      x������ � �            x������ � �            x������ � �      I      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      4      x������ � �      5      x������ � �      b      x������ � �      �      x������ � �      >      x������ � �      ^      x������ � �      _      x������ � �            x������ � �            x������ � �      F      x������ � �      �      x������ � �             x������ � �            x������ � �      G      x������ � �      }      x������ � �            x������ � �            x������ � �            x������ � �      6      x������ � �            x������ � �            x������ � �            x������ � �            x������ � �      	      x������ � �            x������ � �      
      x������ � �            x������ � �            x������ � �            x������ � �            x������ � �            x�}Z�r�H�}���5Î�M�$���ʢ��4u�$wGϘb�ą A���,Y�L�����mDO��ɺ�H���n�*++/'Of�2�Vf�����AM�t����Ӭ>,�4y����ό��i��":����̦���N����[Z���v��*,2?���/�u�n�26Y�);��e^$e�_�F}/���[�xD���ޘ�oѴ2כai�L� ���N���7aV��׋eX��(
���:���*��E(��H�@����ӯ�����"�IRVb�c�CvZ��,r��]�o�Q���}c0���`V?������e�����㼈O����&��ly�J?��`��>������g����8+���+y�Z�olo��m8�\Q�_�j���+w~��Yl�]�9��*�5KX��8������u������&�&�&�m(meu��<z��y�.���",�<��ȶrqϘ�8��J�:��vL*�5��Gi=�pmz�5�z�e�>�j��wc��k��W�sm��_���l�o���(��$-�N�ܬ�@����A(yF\��5G~��]c�U������4�g������͟��<�qU�҆�m�,M��~dUe-�n-'f,RJݜ�Hu�o�ʗ>�;,V�h�G�f�n�ra�װ�Y^}@<;�h�L'1�n�
Z��BԾZz��Z��cvf��tդ�I��_TI�=���D��K%t��<>v��ex��"7����7�*:_����\�!�l�F�:���o����b}�U���i9�G�7�uMI� H�7���9���I�ӏ��b"�[�Y��ŧ#�3~zn�B��Ŵ4�BtZ�|0ӷٚm\����<__���2\�E ���6�����5�(3wSBř�2��2V� ���S�+f2��mPeH���ŹIx�Хrc\�/�g��������������٧����ۚ�|����h��W�8����h����.P�L+�FŊ��-�V_&\%��U��� ��/f�r�3������\T�D�[�����"�"�2F�EX:
�$�;���Q^�+];��J��|{Q$�&��7��������Y��ba����O�F�X~��7����J��4,����֗h(Ԍ[9c�g���.��8�
ԧ�^TuΎ�~�0sٞ�~�텍섟�o�D\#����_��U���Hʸ�*��n&l�Σ<�.c�S�I��J��"�)!��֤��E�m����4���rۨ~ϣݸ�c����źފ�Q��z�j��z��ZǦIn勚�����qH�%6t��u�gӇ[.�2,�w��ݞD���^��i^�aҸ�$��1��4�	9�_¡ӯ�q�X�[�j��5��ʈs��w2�;�XU�+=����wV~*��{m���l�n��e�,���Wj�چ�o���N^F��#�=�����60�'4�'	����Ϋ�^�pl�(@8���������hV���SBs$������n�ք����Á�a�-��5�vG*��|����OO �"���k���e��	"38�TǴz}�jwI^ϰ��X�b��]O��*}{�x�ڎayR,��n�I�`�e��=�G2zP�'�Ep�H�NW��ͻwf�5����<~L�(��L�>7'[qe��~(������",� ��R~M(b;�l.t��̝���ZE�Ӱ�+}�x5Kdʼq$�]^�8�e�$�C�H�P?�#N����(����=v��7:��i�Rh9��r��(=�b� R��5o���ѷ�<�p��@���r�,���ҴsW�6l��#'��ȯ����Xl�8�
ӐE�ytQ�۰��?� q�j �6�%��A�X�������T��/��9���JٺEMm�:Rœ�P�!Ka"�I%u~�|�²�{i�Ʉ��������K�+�T&�.�E��P�٦�<p��}�(w5KC2F9�fL����pA�&��*'ߡ`sf���C_
S����=a[B"�=r��#��Y�9����=Ei�1WY��IujT����S�eJz���'���Z;&�"W��9����6l$�
�|;��R�lVfq9=��PZ�p�~��bEV��u%��࣐:{.�4�,^�����(�U�p�GԜk�N���Wx����#@|Y�/����J�A�֐s�2"ӂ�0�D����M�{R��:K�6I�� ��}�/�$EZ����ᙊΗ,4j��TE���)�^E��I\�G�^�=	�؍H-�0(��Bm�������&���F$J0�$"ä� ���t=%V﹍�S?��ՎH�bYLf��d����&:0h�̯���l�m�F�����HM6��c�.;�O+����چ#T���KD�M*�,[Z@�Y1O�:��F8cIS��p���tv�ti��h8E��J��y�T��b=+�'��-Ud0�G��"�<�a�L��9C.u��7Y}���)�Q�R�\�	aM	F�,�m��ּ����[��P	�B#s�n���VCu�n��k�.���V�]���c𬘘��&z&8p_69��ӗJ(A/E�M�PxT��o�:�G��/�6�~#�!��&�q�M�@�Z��/�����4�X-�F@@�\]\Ŭx���Eu;&i��b�5>�e�Ĉ�.���9�һ�[��@�kuL�4K���!�o]�6� ���)�z�
�\���o=����$��K����r�IDoȸ�������.)�'�l��y��9��jR��mΫ�L���4rϣ(Y���m�߆�R�`�]��C��Q�h1�O�عL;��N�V'%���H��N�0��s<��N٣��(�/퉓�G\<��n �*_�: ��-�3�c�[��)Z�I?�7lF+.��]X�+����5������K0�Rx�&ۀ��~c�.���h�HoX�G?�.��7��\ J��e A�=��`�_�u���� �}�� e�6	�B�]����l���fzLO6����J�ͫ
�fa,VL��i+�uR����!�Y�z[��u������]�a���Q�ʔ ��h3����f�au�]]��q���j�S�5�C�84:����Jǧ@�[�\Jق19��\�yzU!�OC>��ls�H0���OuP0�X7���芡"�;��'N Xu�:���ӿ� 97�?�4��gG����\'��U%ߧLO�o�F�D*\W+~0��rL�B����=� 5��is���Qh��F�
��r���^W��:*Q�Ks��M�i�J���s�C�އ�d/L����[iB�b�r�������mj*�E\嘣��9qE� e��9	���ˑK'�y���z��u9V�@c�� ()TX؈�B?.�$��g������7ۓ"Gy�����T' ���i�B��4~D3�:ۄ+q�Ƞ�T�9��h3��i[�� ����!(���b^�3{�zZc���`�l�&u%v�Ew�&�x��<�}7h��jܒ��Z�vBO7�o�
�\K/tW��BG��U�d4�9�hb��hDO�	��p�|��y�?�4��ak�E2r��y�/P{;�մ,��u>b6TjR�n�	������!�H�Ԕ�>��ϧ(PD�<��c��mu��z!m7��e��V�IlL��ڡe�-������9Z?���N_~���2��ĞV`��<�S�6�{�O�z�#����k�L$c;=]T�O���������R$�`��I�ǹZ|��Iƹ7�l�?��o82���֪c�@A�7�`�n��Qu���2�v�`�pt���;�k�j���1X�����s�'����BmH������j�[n�*�Y�e����5-l��z$��� �\.�m,��(B�#��������@�Œ� w.�n�����1͟��c���.ğq.����~�-�+�dZ=5�Q��GȡQ���C��I'H�Z`�a��hQ�����v[�����U��	�0ȍ��h�E�7���h|�%��Ð��X���-��H����V[�u��%���/)���� ����b�b���0�kY�ˁ	 3  ����7���"RC��&���$wM��T�0JA��؄�=���4F�֑� q�Eɚ91��ם�u�4#������hv}yxv���r6��6���;.Ov�nW��{���1f���K�PIb��=��Ɯ�rBd՚~��n�z|�P^�n[��I]��u{t�;>�s�������p<���]&�2��iϵ��41yǣ�I�l��p�8��hF&�+�fW������KM�`G/�͔i���^���'�����	<�y���-�X��OF�_GG�S=��P����x��e��Ea?]^�]36��fA�ۛ�f�0�>���G@0������Rdg�Bl���4al����1���o�nu,o�R�{����0m� g��yI����x�>eT�\����u������K��w�S]L�չi>��߿�'%�O�Gh�㜸) ��I�А��/��z�����~�ya��ns�I�,�`�'�e��D!�G���C_k�}d��cL ����vS����m�$��A��*%�D����C�N���[rJ�c�،�h:���f���F�T�(�bo�&�D� Nli���W�j,�EE%<�<r�P���=_J��'����P��ɀ>���;��o�Zޓ���������D����C\�����=�����&��O��-����z��֫:��k/���6Mp6�E��_!H�zgJC�t�=K\��iYQ�5Ɍ|�H�S�W�<)������]Ba�����#��8�c_{d MJB3�?�(YgÞ�R����s{JI�ּ��rC�'��tXQ'3v�^Ug�p�2�ȉ}��<����|�z���m}m�2�90�Q��%K_2�ʜ ����p�x��]��>Q�{�b�}��%�%H�hJa�,߶��6R�e���x�����ٍ�x8�R��v�~|�o��ņ�;Z�� ��M�s�1�ݧaSw���_��,O����t �����TM��<J��S�ʖ�y)������t�����.��CԳz3ƴل���	�b��Z�;�~6U~U���
	4ҷ^=$|�H G6t�h���
5_�¢��\8�,D�:"6k�z$SȬd��	�q���"A�ø\O|/ay��X$��y)�h���zx0$%��{d��X{��MD+��[�,�L3�ʊW"zP/.���A���ob���a� �}���M��6�Q;�H0�U^O{'���컉1뾭c�z��� �R����9�zl���1��o����<��b�}����6O�ߴZ�*i^Ws�����&��Ь�������� T`�#         �   x���QO�0ğ�W1%--t<,Y���cn���?uC���Ǘ�/��K��pw|� �0gN7�\b%f�)���.����r�aP�ԃLWq&�����B�RR��K�_��I~��k����p��唽6[5����4 �F��$��O����l���}�\"/~��NT��8k�S����!�XQ�(�P�aT0�rN1���>�֢�������~�gn��-�c�h[��-[[�            x������ � �      {      x������ � �            x������ � �      q   )   x�320�4420342611��H,N5�4�3�3������ }��     