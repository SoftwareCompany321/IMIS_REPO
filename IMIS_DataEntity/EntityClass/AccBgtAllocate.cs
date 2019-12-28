using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class AccBgtAllocate
    {
        public AccBgtAllocate()
        {
            AccBgtRvsn = new HashSet<AccBgtRvsn>();
            AccBgtTransfer = new HashSet<AccBgtTransfer>();
        }

        public int BgtAllocateId { get; set; }
        public int? AccId { get; set; }
        public string Code { get; set; }
        public float? RevisedAmount { get; set; }
        public float? Amount { get; set; }
        public string FiscalYear { get; set; }
        public string AllocatedDateNp { get; set; }
        public int? EntryUserId { get; set; }
        public DateTime? EntryDatetime { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateDatetime { get; set; }
        public int? SubModuleId { get; set; }
        public int? BudgetSourceId { get; set; }

        public virtual ICollection<AccBgtRvsn> AccBgtRvsn { get; set; }
        public virtual ICollection<AccBgtTransfer> AccBgtTransfer { get; set; }
    }
}
