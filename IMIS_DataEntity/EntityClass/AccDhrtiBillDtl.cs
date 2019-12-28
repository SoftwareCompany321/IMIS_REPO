using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class AccDhrtiBillDtl
    {
        public int DhrtiDtlId { get; set; }
        public string Code { get; set; }
        public int? DhrtiMasterId { get; set; }
        public string BillNo { get; set; }
        public string BillDateNp { get; set; }
        public int? CounterId { get; set; }
        public int? PersonId { get; set; }
        public float? Amount { get; set; }
        public int? VchrId { get; set; }
        public int? AccId { get; set; }
        public string VchrDateNp { get; set; }
        public int? OrderInBill { get; set; }
        public string Remarks { get; set; }
        public int? BudgetSourceId { get; set; }
        public int? WorkId { get; set; }

        public virtual AccAccMaster Acc { get; set; }
        public virtual AccVchrMaster Vchr { get; set; }
        public virtual AccWorkMaster Work { get; set; }
    }
}
