using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisEmpAdvDedDtl
    {
        public decimal Id { get; set; }
        public decimal? EmpId { get; set; }
        public decimal? AccId { get; set; }
        public double? AmountCur { get; set; }
        public double? AmountPrev { get; set; }

        public virtual PisEmployeeMaster Emp { get; set; }
    }
}
