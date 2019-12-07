using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class TblBgtMgmtSrc
    {
        public decimal Id { get; set; }
        public decimal? BgtMgmtExpId { get; set; }
        public decimal? SourceId { get; set; }
        public double? Amt { get; set; }
        public decimal? PaymentTypeId { get; set; }
        public decimal? PaymentProcessId { get; set; }
        public string Remarks { get; set; }

        public virtual TblBgtMgmtExp BgtMgmtExp { get; set; }
    }
}
