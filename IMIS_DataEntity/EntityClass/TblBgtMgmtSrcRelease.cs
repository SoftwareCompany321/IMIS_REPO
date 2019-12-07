using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class TblBgtMgmtSrcRelease
    {
        public decimal Id { get; set; }
        public decimal? BgtMgmtExpReleaseId { get; set; }
        public decimal? SourceId { get; set; }
        public double? Amt { get; set; }
        public decimal? CcId { get; set; }
        public string CcActive { get; set; }
        public decimal? PaymentTypeId { get; set; }
        public decimal? PaymentProcessId { get; set; }
        public string Remarks { get; set; }

        public virtual TblBgtMgmtExpRelease BgtMgmtExpRelease { get; set; }
        public virtual Contacts Cc { get; set; }
    }
}
