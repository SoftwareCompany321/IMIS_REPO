using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class TaxRtRentdtl
    {
        public int? Id { get; set; }
        public string Code { get; set; }
        public int? ConstructionId { get; set; }
        public string Rname { get; set; }
        public int? RentTypeId { get; set; }
        public int? RentInsqfeet { get; set; }
        public float? AnualRentIncome { get; set; }
        public string FiscalYear { get; set; }
        public string AgreementDate { get; set; }
        public string ValidUntil { get; set; }
        public string RentStatus { get; set; }
        public int? Rateid { get; set; }
        public int? Taxpayerid { get; set; }
        public int? Businessid { get; set; }
        public string Remarks { get; set; }
        public DateTime? Dataentryaddatetime { get; set; }
        public DateTime? Dataeditaddatetime { get; set; }
        public int? Userid { get; set; }
        public int? Useride { get; set; }
        public string Dataentryvsdate { get; set; }
        public string IsTaxPaidBusinessPerson { get; set; }
    }
}
