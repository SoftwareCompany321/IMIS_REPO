using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class AccBgtTransfer
    {
        public decimal Id { get; set; }
        public decimal? FromAccId { get; set; }
        public decimal? ToAccId { get; set; }
        public decimal? BgtAlctnId { get; set; }
        public string TrnsfrDateNp { get; set; }
        public string TrnsfrReason { get; set; }
        public decimal? UpdateUserId { get; set; }
        public DateTime? UpdateDatetime { get; set; }
        public double? Amount { get; set; }

        public virtual AccBgtAllocate BgtAlctn { get; set; }
        public virtual AccAccMaster FromAcc { get; set; }
        public virtual AccAccMaster ToAcc { get; set; }
    }
}
