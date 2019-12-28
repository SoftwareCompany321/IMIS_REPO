using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class AccBgtTransfer
    {
        public int Id { get; set; }
        public string Code { get; set; }
           
        public int? FromAccId { get; set; }
        public int? ToAccId { get; set; }
        public int? BgtAlctnId { get; set; }
        public string TrnsfrDateNp { get; set; }
        public string TrnsfrReason { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateDatetime { get; set; }
        public float? Amount { get; set; }

        public virtual AccBgtAllocate BgtAlctn { get; set; }
        public virtual AccAccMaster FromAcc { get; set; }
        public virtual AccAccMaster ToAcc { get; set; }
    }
}
