using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class IpttaxsummaryHistory
    {
        public int? Sn { get; set; }
        public int? Iid { get; set; }
        public string Fiscalyear { get; set; }
        public int? Nettaxamount { get; set; }
        public int? Fineamount { get; set; }
        public int? Additionalcharges { get; set; }
        public int? Reductionalcharges { get; set; }
        public int? Isthisfromrevenueaccount { get; set; }
        public int? Taxpaidamount { get; set; }
        public string Datepaid { get; set; }
        public string Specialnotes { get; set; }
        public int? Userid { get; set; }
        public int? Useride { get; set; }
        public string Dataentryvsdate { get; set; }
        public DateTime? Dataentryaddatetime { get; set; }
        public DateTime? Dataeditaddatetime { get; set; }
        public int? Billid { get; set; }
        public string Billno { get; set; }
        public float? LastTaxPaidAmount { get; set; }
        public string TaxType { get; set; }
        public float? RemIptPaidAmount { get; set; }
        public float? RemHlPaidAmount { get; set; }
        public float? RemIptFineAmount { get; set; }
        public float? RemHlFineAmount { get; set; }
        public string RemHlFineStatus { get; set; }
        public string RemIptFineStatus { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
        public DateTime? AddDate { get; set; }
        public string ComputerName { get; set; }
        public string DataStatus { get; set; }
        public string WindowsUser { get; set; }
        public string TranTime { get; set; }
    }
}
