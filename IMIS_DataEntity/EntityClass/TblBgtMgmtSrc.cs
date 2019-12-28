using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class TblBgtMgmtSrc
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int? BgtMgmtExpId { get; set; }
        public int? SourceId { get; set; }
        public float? Amt { get; set; }
        public int? PaymentTypeId { get; set; }
        public int? PaymentProcessId { get; set; }
        public string Remarks { get; set; }

        public virtual TblBgtMgmtExp BgtMgmtExp { get; set; }
    }
}
