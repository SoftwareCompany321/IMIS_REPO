using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class TaxRental
    {
        public decimal? Id { get; set; }
        public string Fiscalyear { get; set; }
        public decimal? Taxpayerid { get; set; }
        public decimal? Constructionid { get; set; }
        public decimal? Rentid { get; set; }
        public decimal? Rateid { get; set; }
        public string Remarks { get; set; }
        public double? Nettaxamount { get; set; }
        public double? Fineamount { get; set; }
        public double? Additionalcharges { get; set; }
        public double? Reductionalcharges { get; set; }
        public double? Taxpaidamount { get; set; }
        public double? LastTaxPaidAmount { get; set; }
        public decimal? Billid { get; set; }
        public string Billno { get; set; }
        public string Billdate { get; set; }
        public decimal? Counterid { get; set; }
        public decimal? Userid { get; set; }
        public string Dateentryvsdate { get; set; }
        public DateTime? Dataentryaddate { get; set; }
        public decimal? Year { get; set; }
        public decimal? Month { get; set; }
    }
}
