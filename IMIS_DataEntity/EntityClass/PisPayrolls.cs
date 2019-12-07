using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisPayrolls
    {
        public PisPayrolls()
        {
            PisPyrollLoanDtls = new HashSet<PisPyrollLoanDtls>();
            PisPyrollOthrDtls = new HashSet<PisPyrollOthrDtls>();
        }

        public decimal Id { get; set; }
        public short? Month { get; set; }
        public int EmpId { get; set; }
        public decimal? LocalPostId { get; set; }
        public string PostInShort { get; set; }
        public string LocalPost { get; set; }
        public string EmpNameNp { get; set; }
        public double? BasicSalary { get; set; }
        public short? GradeIncMonth { get; set; }
        public double? RateOfGrade { get; set; }
        public double? GradeAmount { get; set; }
        public double? GradeSalaryTotal { get; set; }
        public double? AllowanceAmt { get; set; }
        public double? OtherAllowanceAmt { get; set; }
        public double? PfAddAmt { get; set; }
        public double? InsuranceAddAmt { get; set; }
        public double? NetSalary { get; set; }
        public double? PfDeductAmt { get; set; }
        public double? InsuranceDeductAmt { get; set; }
        public double? CitPercent { get; set; }
        public double? CitAmt { get; set; }
        public double? TaxAmt { get; set; }
        public double? AdvanceDeductAmt { get; set; }
        public double? LoanDeductAmt { get; set; }
        public decimal? AbsentDays { get; set; }
        public double? AbsentDeductAmt { get; set; }
        public double? OtherDeductTotal { get; set; }
        public double? TotalPayableSalary { get; set; }
        public string Paymode { get; set; }
        public decimal? PostLevel { get; set; }
        public decimal? VchrId { get; set; }
        public string VchrDateNp { get; set; }
        public decimal? PayBankId { get; set; }
        public decimal? TransTpeId { get; set; }
        public decimal? DeductDepVchrId { get; set; }
        public string DeductDepVchrDateNep { get; set; }
        public string Remarks { get; set; }
        public string FiscalYear { get; set; }
        public decimal? FestiveVchrId { get; set; }
        public string FestiveVchrDateNep { get; set; }
        public decimal? PensionkoshAddAmt { get; set; }
        public decimal? PensionkoshDedAmt { get; set; }
        public double? TdsAmt { get; set; }

        public virtual ICollection<PisPyrollLoanDtls> PisPyrollLoanDtls { get; set; }
        public virtual ICollection<PisPyrollOthrDtls> PisPyrollOthrDtls { get; set; }
    }
}
