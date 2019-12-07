using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class TblBgtRelease
    {
        public TblBgtRelease()
        {
            TblBgtMgmtRelease = new HashSet<TblBgtMgmtRelease>();
        }

        public decimal Id { get; set; }
        public string FiscalYear { get; set; }
        public decimal? MinistryId { get; set; }
        public decimal? OrgId { get; set; }
        public decimal? ReleaseType { get; set; }
        public string ReleaseDate { get; set; }
        public string ChalaniNo { get; set; }
        public string LetterSn { get; set; }
        public double? ApprovedBgtYearly { get; set; }
        public double? PreviousReleaseAmt { get; set; }
        public double? ReleaseAmount { get; set; }
        public string SpecialTippani { get; set; }

        public virtual AccOrgMaster Org { get; set; }
        public virtual ICollection<TblBgtMgmtRelease> TblBgtMgmtRelease { get; set; }
    }
}
