using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisEmpDepSource
    {
        public int DeptId { get; set; }
        public string Code { get; set; }
        public int BudjetSourceId { get; set; }

        public virtual BudjetSource BudjetSource { get; set; }
        public virtual PisEmpDep Dept { get; set; }
    }
}
