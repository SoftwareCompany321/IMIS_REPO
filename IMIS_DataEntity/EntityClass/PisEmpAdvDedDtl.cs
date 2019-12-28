using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisEmpAdvDedDtl
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int? EmpId { get; set; }
        public int? AccId { get; set; }
        public float? AmountCur { get; set; }
        public float? AmountPrev { get; set; }

        public virtual PisEmployeeMaster Emp { get; set; }
    }
}
