using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisEmpDepSource
    {
        public decimal? DeptId { get; set; }
        public decimal BudjetSourceId { get; set; }

        public virtual BudjetSource BudjetSource { get; set; }
        public virtual PisEmpDep Dept { get; set; }
    }
}
