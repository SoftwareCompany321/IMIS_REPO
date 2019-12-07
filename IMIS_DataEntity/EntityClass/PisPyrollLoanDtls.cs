using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisPyrollLoanDtls
    {
        public decimal Id { get; set; }
        public decimal? LoandId { get; set; }
        public short? Month { get; set; }
        public string NameNp { get; set; }
        public decimal? EmpId { get; set; }
        public decimal? AccId { get; set; }
        public double? LoandAmt { get; set; }
        public double? InstallmentAmt { get; set; }
        public string Cleared { get; set; }
        public decimal? PayrollId { get; set; }

        public virtual AccAccMaster Acc { get; set; }
        public virtual PisEmployeeMaster Emp { get; set; }
        public virtual PisEmpLoans Loand { get; set; }
        public virtual PisPayrolls Payroll { get; set; }
    }
}
