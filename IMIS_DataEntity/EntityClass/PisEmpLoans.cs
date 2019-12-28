using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisEmpLoans
    {
        public PisEmpLoans()
        {
            PisPyrollLoanDtls = new HashSet<PisPyrollLoanDtls>();
        }

        public int LoanId { get; set; }
        public string Code { get; set; }
        public string NameNp { get; set; }
        public string NameEn { get; set; }
        public int? EmpId { get; set; }
        public int? AccId { get; set; }
        public float? LoanAmt { get; set; }
        public float? InstallmentAmt { get; set; }
        public float? PaidAmount { get; set; }
        public string Cleared { get; set; }

        public virtual PisEmployeeMaster Emp { get; set; }
        public virtual ICollection<PisPyrollLoanDtls> PisPyrollLoanDtls { get; set; }
    }
}
