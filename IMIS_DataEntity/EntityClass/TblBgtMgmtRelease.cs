using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class TblBgtMgmtRelease
    {
        public TblBgtMgmtRelease()
        {
            TblBgtMgmtExpRelease = new HashSet<TblBgtMgmtExpRelease>();
        }

        public int Id { get; set; }
        public int? BgtReleaseId { get; set; }
        public string FiscalYear { get; set; }
        public int? MinistryId { get; set; }
        public int? OrgId { get; set; }
        public int? BgtSubHeadId { get; set; }
        public float? Amt { get; set; }
        public string Remarks { get; set; }

        public virtual TblBgtRelease BgtRelease { get; set; }
        public virtual ICollection<TblBgtMgmtExpRelease> TblBgtMgmtExpRelease { get; set; }
    }
}
