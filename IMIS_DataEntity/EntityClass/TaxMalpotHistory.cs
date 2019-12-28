using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class TaxMalpotHistory
    {
        public long? Sn { get; set; }
        public string Code { get; set; }
        public long? MalpotId { get; set; }
        public string Fiscalyear { get; set; }
        public int? Taxpayerid { get; set; }
        public int? Landid { get; set; }
        public string Kittanumber { get; set; }
        public int? Generalrateid { get; set; }
        public float? Rateperunit { get; set; }
        public string Specialnotes { get; set; }
        public float? Nettaxamount { get; set; }
        public float? Fineamount { get; set; }
        public float? Additionalcharges { get; set; }
        public float? Reductionalcharges { get; set; }
        public float? Taxpaidamount { get; set; }
        public float? LastTaxPaidAmount { get; set; }
        public int? Totalarea { get; set; }
        public int? Nonevaluatedarea { get; set; }
        public int? Netevaluatingarea { get; set; }
        public int? Billid { get; set; }
        public string Billdate { get; set; }
        public string Billno { get; set; }
        public int? Counterid { get; set; }
        public int? Userid { get; set; }
        public int? Useride { get; set; }
        public string Dataentryvsdate { get; set; }
        public DateTime? Dataentryaddatetime { get; set; }
        public DateTime? Dataeditaddatetime { get; set; }
    }
}
