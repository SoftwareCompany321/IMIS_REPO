using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class SvBusinessmaster
    {
        public int Id { get; set; }
        public string Nepname { get; set; }
        public string Description { get; set; }
        public int? Businessgroupid { get; set; }
        public int? Typeid { get; set; }
        public int? Taxpayerid { get; set; }
        public int? Initialcapital { get; set; }
        public int? Zoneid { get; set; }
        public int? Districtid { get; set; }
        public int? Vdcid { get; set; }
        public int? Wardno { get; set; }
        public string Street { get; set; }
        public int? Trackid { get; set; }
        public string Houseno { get; set; }
        public string Phones { get; set; }
        public string Emails { get; set; }
        public string Houseowner { get; set; }
        public short? Isinrent { get; set; }
        public int? Monthlyrent { get; set; }
        public int? Areainsquarefeets { get; set; }
        public string Initialregisteredoffice { get; set; }
        public string Initialregno { get; set; }
        public string Initialregdate { get; set; }
        public string Municipalregno { get; set; }
        public string Municipallregdate { get; set; }
        public int? Sqfeetsofsignboard { get; set; }
        public int? Lengthofsignboard { get; set; }
        public int? Widthofsignboard { get; set; }
        public string Contentofsignboard { get; set; }
        public string Businessstartingdate { get; set; }
        public string Specialnotes { get; set; }
        public int? Userid { get; set; }
        public int? Useride { get; set; }
        public string Dataentryvsdate { get; set; }
        public DateTime? Dataentryaddatetime { get; set; }
        public DateTime? Dataeditaddatetime { get; set; }
        public int? Generalrateid { get; set; }
        public string MailAddress { get; set; }
        public short? BusinessStatus { get; set; }
        public string ClosedVsDate { get; set; }
        public string CloseReason { get; set; }
        public string PaidLastFiscalyear { get; set; }
        public int? Sanitationid { get; set; }
        public float? Maxcapital { get; set; }
        public float? YearlyTranAmount { get; set; }
        public string Shiftdate { get; set; }
        public int? Shifttaxpayerid { get; set; }
        public string Addresschange { get; set; }
        public int? Houseid { get; set; }
        public int? BusinessownertaxIid { get; set; }
    }
}
