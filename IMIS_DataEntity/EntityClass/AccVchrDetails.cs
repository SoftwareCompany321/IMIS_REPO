using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class AccVchrDetails
    {
        public int VchrDetailId { get; set; }
        public string Code { get; set; }
        public int? VchrId { get; set; }
        public int? AccId { get; set; }
        public float? DrAmt { get; set; }
        public float? CrAmt { get; set; }
        public int? VchrTypeId { get; set; }
        public int? IdFromSrc { get; set; }
        public string AccType { get; set; }
        public int? TransTypeId { get; set; }
        public DateTime? VchrDateEng { get; set; }
        public string VchrDateNep { get; set; }
        public string Remarks { get; set; }
        public string IsPosted { get; set; }
        public string Module { get; set; }
        public int SubModuleId { get; set; }
        public int? BudgetSourceId { get; set; }
        public int? Bankid { get; set; }
        public int? BillId { get; set; }
        public int? BudgetAccId { get; set; }
        public int? OrgId { get; set; }
        public int? WorkId { get; set; }
        public string IsJafat { get; set; }
        public string ExpireDateNp { get; set; }
        public string IsGroup { get; set; }

        public virtual AccSubModuleType SubModule { get; set; }
        public virtual AccTransType TransType { get; set; }
        public virtual AccVchrMaster Vchr { get; set; }
        public virtual AccVchrTypeMaster VchrType { get; set; }
        public virtual AccWorkMaster Work { get; set; }
    }
}
