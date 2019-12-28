using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class TblBgtMgmtSrcOrg
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int? BgtMgmtExpOrgId { get; set; }
        public int? SourceId { get; set; }
        public float? Amt { get; set; }
        public int? CcId { get; set; }
        public string CcActive { get; set; }
        public int? PaymentTypeId { get; set; }
        public int? PaymentProcessId { get; set; }
        public string Remarks { get; set; }

        public virtual TblBgtMgmtExpOrg BgtMgmtExpOrg { get; set; }
        public virtual Contacts Cc { get; set; }
    }
}
