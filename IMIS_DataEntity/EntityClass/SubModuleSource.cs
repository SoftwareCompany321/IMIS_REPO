using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class SubModuleSource
    {
        public decimal SubModuleId { get; set; }
        public decimal BudjetSourceId { get; set; }

        public virtual BudjetSource BudjetSource { get; set; }
        public virtual AccSubModuleType SubModule { get; set; }
    }
}
