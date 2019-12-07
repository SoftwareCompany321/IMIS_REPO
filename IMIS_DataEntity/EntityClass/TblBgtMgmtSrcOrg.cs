using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class TblBgtMgmtSrcOrg
    {
        public decimal Id { get; set; }
        public decimal? BgtMgmtExpOrgId { get; set; }
        public decimal? SourceId { get; set; }
        public double? Amt { get; set; }
        public decimal? CcId { get; set; }
        public string CcActive { get; set; }
        public decimal? PaymentTypeId { get; set; }
        public decimal? PaymentProcessId { get; set; }
        public string Remarks { get; set; }

        public virtual TblBgtMgmtExpOrg BgtMgmtExpOrg { get; set; }
        public virtual Contacts Cc { get; set; }
    }
}
