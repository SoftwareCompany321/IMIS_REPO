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

        public decimal Id { get; set; }
        public decimal? BgtReleaseId { get; set; }
        public string FiscalYear { get; set; }
        public decimal? MinistryId { get; set; }
        public decimal? OrgId { get; set; }
        public decimal? BgtSubHeadId { get; set; }
        public double? Amt { get; set; }
        public string Remarks { get; set; }

        public virtual TblBgtRelease BgtRelease { get; set; }
        public virtual ICollection<TblBgtMgmtExpRelease> TblBgtMgmtExpRelease { get; set; }
    }
}
