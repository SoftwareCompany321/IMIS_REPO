using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class IpttaxsummaryHistory
    {
        public decimal? Sn { get; set; }
        public decimal? Iid { get; set; }
        public string Fiscalyear { get; set; }
        public decimal? Nettaxamount { get; set; }
        public decimal? Fineamount { get; set; }
        public decimal? Additionalcharges { get; set; }
        public decimal? Reductionalcharges { get; set; }
        public decimal? Isthisfromrevenueaccount { get; set; }
        public decimal? Taxpaidamount { get; set; }
        public string Datepaid { get; set; }
        public string Specialnotes { get; set; }
        public decimal? Userid { get; set; }
        public decimal? Useride { get; set; }
        public string Dataentryvsdate { get; set; }
        public DateTime? Dataentryaddatetime { get; set; }
        public DateTime? Dataeditaddatetime { get; set; }
        public decimal? Billid { get; set; }
        public string Billno { get; set; }
        public double? LastTaxPaidAmount { get; set; }
        public string TaxType { get; set; }
        public double? RemIptPaidAmount { get; set; }
        public double? RemHlPaidAmount { get; set; }
        public double? RemIptFineAmount { get; set; }
        public double? RemHlFineAmount { get; set; }
        public string RemHlFineStatus { get; set; }
        public string RemIptFineStatus { get; set; }
        public decimal? Year { get; set; }
        public decimal? Month { get; set; }
        public DateTime? AddDate { get; set; }
        public string ComputerName { get; set; }
        public string DataStatus { get; set; }
        public string WindowsUser { get; set; }
        public string TranTime { get; set; }
    }
}
