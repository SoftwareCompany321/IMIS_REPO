using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class AccBudjetSource
    {
        public int Id { get; set; }
        public int? MinAccId { get; set; }
        public int? SourceId { get; set; }
        public int? Amount { get; set; }
        public string Remarks { get; set; }

        public virtual MinistryAccHead MinAcc { get; set; }
        public virtual BudjetSource Source { get; set; }
    }
}
