using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class TaxRental
    {
        public int? Id { get; set; }
        public string Fiscalyear { get; set; }
        public int? Taxpayerid { get; set; }
        public int? Constructionid { get; set; }
        public int? Rentid { get; set; }
        public int? Rateid { get; set; }
        public string Remarks { get; set; }
        public float? Nettaxamount { get; set; }
        public float? Fineamount { get; set; }
        public float? Additionalcharges { get; set; }
        public float? Reductionalcharges { get; set; }
        public float? Taxpaidamount { get; set; }
        public float? LastTaxPaidAmount { get; set; }
        public int? Billid { get; set; }
        public string Billno { get; set; }
        public string Billdate { get; set; }
        public int? Counterid { get; set; }
        public int? Userid { get; set; }
        public string Dateentryvsdate { get; set; }
        public DateTime? Dataentryaddate { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
    }
}
