using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisEmpMedExpense
    {
        public decimal Sn { get; set; }
        public decimal? EmpId { get; set; }
        public decimal? LocalPostId { get; set; }
        public string WorkingOffice { get; set; }
        public string IssuedDate { get; set; }
        public double? RegularAmt { get; set; }
        public double? SpecialAmt { get; set; }
        public string Remarks { get; set; }

        public virtual PisEmployeeMaster Emp { get; set; }
        public virtual PisLocalPostMaster LocalPost { get; set; }
    }
}
