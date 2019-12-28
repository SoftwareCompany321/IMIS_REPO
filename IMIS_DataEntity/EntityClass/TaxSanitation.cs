using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class TaxSanitation
    {
        public int? Sn { get; set; }
        public string Code { get; set; }
        public string Fiscalyear { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
        public int? Taxpayerid { get; set; }
        public int? Houseid { get; set; }
        public int? Rateid { get; set; }
        public string Specialnotes { get; set; }
        public float? Nettaxamount { get; set; }
        public float? Fineamount { get; set; }
        public float? Reductionalcharges { get; set; }
        public float? Taxpaidamount { get; set; }
        public float? LastTaxPaidAmount { get; set; }
        public int? Billid { get; set; }
        public string Billno { get; set; }
        public string Billdate { get; set; }
        public int? Counterid { get; set; }
        public int? Userid { get; set; }
        public int? Useride { get; set; }
        public string Dataentryvsdate { get; set; }
        public DateTime? Dataentryaddatetime { get; set; }
        public DateTime? Dataeditaddatetime { get; set; }
        public string Servicetype { get; set; }
    }
}
