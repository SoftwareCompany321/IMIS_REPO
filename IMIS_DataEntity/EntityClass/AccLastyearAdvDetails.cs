using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class AccLastyearAdvDetails
    {
        public decimal Id { get; set; }
        public decimal? PaymentId { get; set; }
        public string FiscalYear { get; set; }
        public decimal? WorkId { get; set; }
        public decimal? VhcrId { get; set; }
        public decimal? AccId { get; set; }
        public decimal? BudgetAccId { get; set; }
        public decimal? BudgetSourceId { get; set; }
        public decimal? PaymentTypeId { get; set; }
        public decimal? PersonId { get; set; }
        public double? DrAmount { get; set; }
        public string Status { get; set; }
        public string Remarks { get; set; }
        public decimal? AddUserId { get; set; }
        public string AddDate { get; set; }
        public string VoucherNo { get; set; }
        public string VoucherDate { get; set; }
        public decimal? LastYrPeskiId { get; set; }
    }
}
