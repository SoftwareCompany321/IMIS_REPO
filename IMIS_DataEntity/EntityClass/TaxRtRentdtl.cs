using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class TaxRtRentdtl
    {
        public decimal? Id { get; set; }
        public decimal? ConstructionId { get; set; }
        public string Rname { get; set; }
        public decimal? RentTypeId { get; set; }
        public decimal? RentInsqfeet { get; set; }
        public double? AnualRentIncome { get; set; }
        public string FiscalYear { get; set; }
        public string AgreementDate { get; set; }
        public string ValidUntil { get; set; }
        public string RentStatus { get; set; }
        public decimal? Rateid { get; set; }
        public decimal? Taxpayerid { get; set; }
        public decimal? Businessid { get; set; }
        public string Remarks { get; set; }
        public DateTime? Dataentryaddatetime { get; set; }
        public DateTime? Dataeditaddatetime { get; set; }
        public decimal? Userid { get; set; }
        public decimal? Useride { get; set; }
        public string Dataentryvsdate { get; set; }
        public string IsTaxPaidBusinessPerson { get; set; }
    }
}
