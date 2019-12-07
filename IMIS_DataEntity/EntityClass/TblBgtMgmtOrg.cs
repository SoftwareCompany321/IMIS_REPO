using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class TblBgtMgmtOrg
    {
        public TblBgtMgmtOrg()
        {
            TblBgtMgmtExpOrg = new HashSet<TblBgtMgmtExpOrg>();
        }

        public decimal Id { get; set; }
        public string FiscalYear { get; set; }
        public decimal? MinistryId { get; set; }
        public decimal? OrgId { get; set; }
        public decimal? BgtSubHeadId { get; set; }
        public double? TotalBgtAmtOrg { get; set; }
        public string Remarks { get; set; }

        public virtual ICollection<TblBgtMgmtExpOrg> TblBgtMgmtExpOrg { get; set; }
    }
}
