using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class TblBgtMgmtExp
    {
        public TblBgtMgmtExp()
        {
            TblBgtMgmtSrc = new HashSet<TblBgtMgmtSrc>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public int? BgtMgmtId { get; set; }
        public int? AccId { get; set; }
        public float? BgtAmt { get; set; }
        public string Remarks { get; set; }

        public virtual TblBgtMgmt BgtMgmt { get; set; }
        public virtual ICollection<TblBgtMgmtSrc> TblBgtMgmtSrc { get; set; }
    }
}
