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

        public decimal Id { get; set; }
        public decimal? BgtMgmtId { get; set; }
        public decimal? AccId { get; set; }
        public double? BgtAmt { get; set; }
        public string Remarks { get; set; }

        public virtual TblBgtMgmt BgtMgmt { get; set; }
        public virtual ICollection<TblBgtMgmtSrc> TblBgtMgmtSrc { get; set; }
    }
}
