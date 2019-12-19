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

        public int Id { get; set; }
        public int? BgtMgmtReleaseId { get; set; }
        public int? AccId { get; set; }
        public float? Amt { get; set; }
        public string Remarks { get; set; }

        public virtual TblBgtMgmtRelease BgtMgmtRelease { get; set; }
        public virtual ICollection<TblBgtMgmtSrcRelease> TblBgtMgmtSrcRelease { get; set; }
    }
}
