using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class AccVchrDetails
    {
        public decimal VchrDetailId { get; set; }
        public decimal? VchrId { get; set; }
        public decimal? AccId { get; set; }
        public double? DrAmt { get; set; }
        public double? CrAmt { get; set; }
        public decimal? VchrTypeId { get; set; }
        public int? IdFromSrc { get; set; }
        public string AccType { get; set; }
        public decimal? TransTypeId { get; set; }
        public DateTime? VchrDateEng { get; set; }
        public string VchrDateNep { get; set; }
        public string Remarks { get; set; }
        public string IsPosted { get; set; }
        public string Module { get; set; }
        public decimal SubModuleId { get; set; }
        public decimal? BudgetSourceId { get; set; }
        public decimal? Bankid { get; set; }
        public decimal? BillId { get; set; }
        public decimal? BudgetAccId { get; set; }
        public decimal? OrgId { get; set; }
        public decimal? WorkId { get; set; }
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
