using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class TaxMalpotHistory
    {
        public long? Sn { get; set; }
        public long? MalpotId { get; set; }
        public string Fiscalyear { get; set; }
        public decimal? Taxpayerid { get; set; }
        public decimal? Landid { get; set; }
        public string Kittanumber { get; set; }
        public decimal? Generalrateid { get; set; }
        public double? Rateperunit { get; set; }
        public string Specialnotes { get; set; }
        public double? Nettaxamount { get; set; }
        public double? Fineamount { get; set; }
        public double? Additionalcharges { get; set; }
        public double? Reductionalcharges { get; set; }
        public double? Taxpaidamount { get; set; }
        public double? LastTaxPaidAmount { get; set; }
        public decimal? Totalarea { get; set; }
        public decimal? Nonevaluatedarea { get; set; }
        public decimal? Netevaluatingarea { get; set; }
        public decimal? Billid { get; set; }
        public string Billdate { get; set; }
        public string Billno { get; set; }
        public decimal? Counterid { get; set; }
        public decimal? Userid { get; set; }
        public decimal? Useride { get; set; }
        public string Dataentryvsdate { get; set; }
        public DateTime? Dataentryaddatetime { get; set; }
        public DateTime? Dataeditaddatetime { get; set; }
    }
}
