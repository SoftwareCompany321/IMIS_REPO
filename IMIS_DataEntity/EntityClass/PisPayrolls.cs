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

        public int Id { get; set; }
        public string Code { get; set; }
        public short? Month { get; set; }
        public int EmpId { get; set; }
        public int? LocalPostId { get; set; }
        public string PostInShort { get; set; }
        public string LocalPost { get; set; }
        public string EmpNameNp { get; set; }
        public float? BasicSalary { get; set; }
        public short? GradeIncMonth { get; set; }
        public float? RateOfGrade { get; set; }
        public float? GradeAmount { get; set; }
        public float? GradeSalaryTotal { get; set; }
        public float? AllowanceAmt { get; set; }
        public float? OtherAllowanceAmt { get; set; }
        public float? PfAddAmt { get; set; }
        public float? InsuranceAddAmt { get; set; }
        public float? NetSalary { get; set; }
        public float? PfDeductAmt { get; set; }
        public float? InsuranceDeductAmt { get; set; }
        public float? CitPercent { get; set; }
        public float? CitAmt { get; set; }
        public float? TaxAmt { get; set; }
        public float? AdvanceDeductAmt { get; set; }
        public float? LoanDeductAmt { get; set; }
        public int? AbsentDays { get; set; }
        public float? AbsentDeductAmt { get; set; }
        public float? OtherDeductTotal { get; set; }
        public float? TotalPayableSalary { get; set; }
        public string Paymode { get; set; }
        public int? PostLevel { get; set; }
        public int? VchrId { get; set; }
        public string VchrDateNp { get; set; }
        public int? PayBankId { get; set; }
        public int? TransTpeId { get; set; }
        public int? DeductDepVchrId { get; set; }
        public string DeductDepVchrDateNep { get; set; }
        public string Remarks { get; set; }
        public string FiscalYear { get; set; }
        public int? FestiveVchrId { get; set; }
        public string FestiveVchrDateNep { get; set; }
        public int? PensionkoshAddAmt { get; set; }
        public int? PensionkoshDedAmt { get; set; }
        public float? TdsAmt { get; set; }

        public virtual ICollection<PisPyrollLoanDtls> PisPyrollLoanDtls { get; set; }
        public virtual ICollection<PisPyrollOthrDtls> PisPyrollOthrDtls { get; set; }
    }
}
