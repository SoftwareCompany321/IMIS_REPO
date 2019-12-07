using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class AccBgtRvsn
    {
        public decimal Id { get; set; }
        public decimal? BgtAlctnId { get; set; }
        public string RvsnDateNp { get; set; }
        public double? Amount { get; set; }
        public string RvsnReason { get; set; }
        public decimal? UpdateUserId { get; set; }
        public DateTime? UpdateDatetime { get; set; }

        public virtual AccBgtAllocate BgtAlctn { get; set; }
    }
}
