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

        public int Id { get; set; }
        public int? BgtMgmtOrgId { get; set; }
        public int? AccId { get; set; }
        public float? BgtAmtOrg { get; set; }
        public string Remarks { get; set; }

        public virtual TblBgtMgmtOrg BgtMgmtOrg { get; set; }
        public virtual ICollection<TblBgtMgmtSrcOrg> TblBgtMgmtSrcOrg { get; set; }
    }
}
