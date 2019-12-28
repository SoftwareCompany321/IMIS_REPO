using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisPyrollLoanDtls
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int? LoandId { get; set; }
        public short? Month { get; set; }
        public string NameNp { get; set; }
        public int? EmpId { get; set; }
        public int? AccId { get; set; }
        public float? LoandAmt { get; set; }
        public float? InstallmentAmt { get; set; }
        public string Cleared { get; set; }
        public int? PayrollId { get; set; }

        public virtual AccAccMaster Acc { get; set; }
        public virtual PisEmployeeMaster Emp { get; set; }
        public virtual PisEmpLoans Loand { get; set; }
        public virtual PisPayrolls Payroll { get; set; }
    }
}
