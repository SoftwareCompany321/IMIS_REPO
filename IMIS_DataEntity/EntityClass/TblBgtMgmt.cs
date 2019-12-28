using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class TblBgtMgmt
    {
        public TblBgtMgmt()
        {
            TblBgtMgmtExp = new HashSet<TblBgtMgmtExp>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string FiscalYear { get; set; }
        public int? MinistryId { get; set; }
        public int? BgtSubHeadId { get; set; }
        public float? TotalBgtAmt { get; set; }
        public string Remarks { get; set; }

        public virtual ICollection<TblBgtMgmtExp> TblBgtMgmtExp { get; set; }
    }
}
