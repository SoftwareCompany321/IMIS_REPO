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

        public decimal Id { get; set; }
        public string FiscalYear { get; set; }
        public decimal? MinistryId { get; set; }
        public decimal? BgtSubHeadId { get; set; }
        public double? TotalBgtAmt { get; set; }
        public string Remarks { get; set; }

        public virtual ICollection<TblBgtMgmtExp> TblBgtMgmtExp { get; set; }
    }
}
