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

        public int Id { get; set; }
        public string Code { get; set; }
        public string FiscalYear { get; set; }
        public int? MinistryId { get; set; }
        public int? OrgId { get; set; }
        public int? BgtSubHeadId { get; set; }
        public float? TotalBgtAmtOrg { get; set; }
        public string Remarks { get; set; }

        public virtual ICollection<TblBgtMgmtExpOrg> TblBgtMgmtExpOrg { get; set; }
    }
}
