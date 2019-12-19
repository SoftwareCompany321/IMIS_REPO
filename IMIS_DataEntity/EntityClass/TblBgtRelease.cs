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

        public int Id { get; set; }
        public string FiscalYear { get; set; }
        public int? MinistryId { get; set; }
        public int? OrgId { get; set; }
        public int? ReleaseType { get; set; }
        public string ReleaseDate { get; set; }
        public string ChalaniNo { get; set; }
        public string LetterSn { get; set; }
        public float? ApprovedBgtYearly { get; set; }
        public float? PreviousReleaseAmt { get; set; }
        public float? ReleaseAmount { get; set; }
        public string SpecialTippani { get; set; }

        public virtual AccOrgMaster Org { get; set; }
        public virtual ICollection<TblBgtMgmtRelease> TblBgtMgmtRelease { get; set; }
    }
}
