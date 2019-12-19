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

        public int Id { get; set; }
        public int? MinistryId { get; set; }
        public int? AccId { get; set; }
        public int? SubHeadId { get; set; }
        public string FiscalYear { get; set; }
        public string Remarks { get; set; }

        public virtual ICollection<AccBudjetSource> AccBudjetSource { get; set; }
    }
}
