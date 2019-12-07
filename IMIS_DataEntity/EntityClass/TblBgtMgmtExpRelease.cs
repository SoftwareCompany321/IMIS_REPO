using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class TblBgtMgmtExpRelease
    {
        public TblBgtMgmtExpRelease()
        {
            TblBgtMgmtSrcRelease = new HashSet<TblBgtMgmtSrcRelease>();
        }

        public decimal Id { get; set; }
        public decimal? BgtMgmtReleaseId { get; set; }
        public decimal? AccId { get; set; }
        public double? Amt { get; set; }
        public string Remarks { get; set; }

        public virtual TblBgtMgmtRelease BgtMgmtRelease { get; set; }
        public virtual ICollection<TblBgtMgmtSrcRelease> TblBgtMgmtSrcRelease { get; set; }
    }
}
