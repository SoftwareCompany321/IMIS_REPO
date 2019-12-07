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

        public decimal BgtAllocateId { get; set; }
        public decimal? AccId { get; set; }
        public double? RevisedAmount { get; set; }
        public double? Amount { get; set; }
        public string FiscalYear { get; set; }
        public string AllocatedDateNp { get; set; }
        public decimal? EntryUserId { get; set; }
        public DateTime? EntryDatetime { get; set; }
        public decimal? UpdateUserId { get; set; }
        public DateTime? UpdateDatetime { get; set; }
        public decimal? SubModuleId { get; set; }
        public decimal? BudgetSourceId { get; set; }

        public virtual ICollection<AccBgtRvsn> AccBgtRvsn { get; set; }
        public virtual ICollection<AccBgtTransfer> AccBgtTransfer { get; set; }
    }
}
