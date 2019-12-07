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

        public decimal LoanId { get; set; }
        public string NameNp { get; set; }
        public string NameEn { get; set; }
        public decimal? EmpId { get; set; }
        public decimal? AccId { get; set; }
        public double? LoanAmt { get; set; }
        public double? InstallmentAmt { get; set; }
        public double? PaidAmount { get; set; }
        public string Cleared { get; set; }

        public virtual PisEmployeeMaster Emp { get; set; }
        public virtual ICollection<PisPyrollLoanDtls> PisPyrollLoanDtls { get; set; }
    }
}
