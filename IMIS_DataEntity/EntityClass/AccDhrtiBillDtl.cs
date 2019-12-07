using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class AccDhrtiBillDtl
    {
        public decimal DhrtiDtlId { get; set; }
        public decimal? DhrtiMasterId { get; set; }
        public string BillNo { get; set; }
        public string BillDateNp { get; set; }
        public decimal? CounterId { get; set; }
        public decimal? PersonId { get; set; }
        public double? Amount { get; set; }
        public decimal? VchrId { get; set; }
        public decimal? AccId { get; set; }
        public string VchrDateNp { get; set; }
        public decimal? OrderInBill { get; set; }
        public string Remarks { get; set; }
        public decimal? BudgetSourceId { get; set; }
        public decimal? WorkId { get; set; }

        public virtual AccAccMaster Acc { get; set; }
        public virtual AccVchrMaster Vchr { get; set; }
        public virtual AccWorkMaster Work { get; set; }
    }
}
