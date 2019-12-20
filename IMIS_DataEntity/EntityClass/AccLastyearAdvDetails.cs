using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class AccLastyearAdvDetails
    {
        public int Id { get; set; }
        public int? PaymentId { get; set; }
        public string FiscalYear { get; set; }
        public int? WorkId { get; set; }
        public int? VhcrId { get; set; }
        public int? AccId { get; set; }
        public int? BudgetAccId { get; set; }
        public int? BudgetSourceId { get; set; }
        public int? PaymentTypeId { get; set; }
        public int? PersonId { get; set; }
        public float? DrAmount { get; set; }
        public string Status { get; set; }
        public string Remarks { get; set; }
        public int? AddUserId { get; set; }
        public string AddDate { get; set; }
        public string VoucherNo { get; set; }
        public string VoucherDate { get; set; }
        public int? LastYrPeskiId { get; set; }
    }
}
