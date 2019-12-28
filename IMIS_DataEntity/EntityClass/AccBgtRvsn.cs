using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class AccBgtRvsn
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int? BgtAlctnId { get; set; }
        public string RvsnDateNp { get; set; }
        public float? Amount { get; set; }
        public string RvsnReason { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateDatetime { get; set; }

        public virtual AccBgtAllocate BgtAlctn { get; set; }
    }
}
