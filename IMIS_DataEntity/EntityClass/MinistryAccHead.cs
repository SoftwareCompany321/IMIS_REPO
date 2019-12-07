using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class MinistryAccHead
    {
        public MinistryAccHead()
        {
            AccBudjetSource = new HashSet<AccBudjetSource>();
        }

        public decimal Id { get; set; }
        public decimal? MinistryId { get; set; }
        public decimal? AccId { get; set; }
        public decimal? SubHeadId { get; set; }
        public string FiscalYear { get; set; }
        public string Remarks { get; set; }

        public virtual ICollection<AccBudjetSource> AccBudjetSource { get; set; }
    }
}
