using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class TblBgtMgmtExpOrg
    {
        public TblBgtMgmtExpOrg()
        {
            TblBgtMgmtSrcOrg = new HashSet<TblBgtMgmtSrcOrg>();
        }

        public decimal Id { get; set; }
        public decimal? BgtMgmtOrgId { get; set; }
        public decimal? AccId { get; set; }
        public double? BgtAmtOrg { get; set; }
        public string Remarks { get; set; }

        public virtual TblBgtMgmtOrg BgtMgmtOrg { get; set; }
        public virtual ICollection<TblBgtMgmtSrcOrg> TblBgtMgmtSrcOrg { get; set; }
    }
}
