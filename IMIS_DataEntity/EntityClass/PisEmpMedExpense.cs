using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisEmpMedExpense
    {
        public int Sn { get; set; }
        public string Code { get; set; }
        public int? EmpId { get; set; }
        public int? LocalPostId { get; set; }
        public string WorkingOffice { get; set; }
        public string IssuedDate { get; set; }
        public float? RegularAmt { get; set; }
        public float? SpecialAmt { get; set; }
        public string Remarks { get; set; }

        public virtual PisEmployeeMaster Emp { get; set; }
        public virtual PisLocalPostMaster LocalPost { get; set; }
    }
}
