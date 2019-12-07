using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class AccBudjetSource
    {
        public decimal? Id { get; set; }
        public decimal? MinAccId { get; set; }
        public decimal? SourceId { get; set; }
        public decimal? Amount { get; set; }
        public string Remarks { get; set; }

        public virtual MinistryAccHead MinAcc { get; set; }
        public virtual BudjetSource Source { get; set; }
    }
}
