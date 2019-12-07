using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class SvBusinessmaster
    {
        public decimal Id { get; set; }
        public string Nepname { get; set; }
        public string Description { get; set; }
        public decimal? Businessgroupid { get; set; }
        public decimal? Typeid { get; set; }
        public decimal? Taxpayerid { get; set; }
        public decimal? Initialcapital { get; set; }
        public decimal? Zoneid { get; set; }
        public decimal? Districtid { get; set; }
        public decimal? Vdcid { get; set; }
        public decimal? Wardno { get; set; }
        public string Street { get; set; }
        public decimal? Trackid { get; set; }
        public string Houseno { get; set; }
        public string Phones { get; set; }
        public string Emails { get; set; }
        public string Houseowner { get; set; }
        public short? Isinrent { get; set; }
        public decimal? Monthlyrent { get; set; }
        public decimal? Areainsquarefeets { get; set; }
        public string Initialregisteredoffice { get; set; }
        public string Initialregno { get; set; }
        public string Initialregdate { get; set; }
        public string Municipalregno { get; set; }
        public string Municipallregdate { get; set; }
        public decimal? Sqfeetsofsignboard { get; set; }
        public decimal? Lengthofsignboard { get; set; }
        public decimal? Widthofsignboard { get; set; }
        public string Contentofsignboard { get; set; }
        public string Businessstartingdate { get; set; }
        public string Specialnotes { get; set; }
        public decimal? Userid { get; set; }
        public decimal? Useride { get; set; }
        public string Dataentryvsdate { get; set; }
        public DateTime? Dataentryaddatetime { get; set; }
        public DateTime? Dataeditaddatetime { get; set; }
        public decimal? Generalrateid { get; set; }
        public string MailAddress { get; set; }
        public short? BusinessStatus { get; set; }
        public string ClosedVsDate { get; set; }
        public string CloseReason { get; set; }
        public string PaidLastFiscalyear { get; set; }
        public decimal? Sanitationid { get; set; }
        public double? Maxcapital { get; set; }
        public double? YearlyTranAmount { get; set; }
        public string Shiftdate { get; set; }
        public decimal? Shifttaxpayerid { get; set; }
        public string Addresschange { get; set; }
        public decimal? Houseid { get; set; }
        public decimal? BusinessownertaxIid { get; set; }
    }
}
