using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class TblBgtMgmtSrcRelease
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int? BgtMgmtExpReleaseId { get; set; }
        public int? SourceId { get; set; }
        public float? Amt { get; set; }
        public int? CcId { get; set; }
        public string CcActive { get; set; }
        public int? PaymentTypeId { get; set; }
        public int? PaymentProcessId { get; set; }
        public string Remarks { get; set; }

        public virtual TblBgtMgmtExpRelease BgtMgmtExpRelease { get; set; }
        public virtual Contacts Cc { get; set; }
    }
}
