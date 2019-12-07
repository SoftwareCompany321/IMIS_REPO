using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class AccPaymentMaster
    {
        public AccPaymentMaster()
        {
            AccPaymentDeduction = new HashSet<AccPaymentDeduction>();
            AccPaymentDetails = new HashSet<AccPaymentDetails>();
        }

        public decimal PaymentId { get; set; }
        public decimal? TransTypeId { get; set; }
        public decimal? PersonTypeId { get; set; }
        public decimal? PersonId { get; set; }
        public decimal? WorkId { get; set; }
        public string BillNo { get; set; }
        public double? BillAmt { get; set; }
        public double? VatAmt { get; set; }
        public string PaymentDescription { get; set; }
        public double? RetentionMoneyEduction { get; set; }
        public double? ContractTaxDeduction { get; set; }
        public double? IncomeTaxDeduction { get; set; }
        public double? LastYearsAdvDeduction { get; set; }
        public double? VatDeduction { get; set; }
        public double? OtherDeduction { get; set; }
        public double? ChequePayment { get; set; }
        public double? CashPayment { get; set; }
        public double? AdvClearedFromBill { get; set; }
        public double? AdvClearedFromBank { get; set; }
        public double? AdvClearedFromCash { get; set; }
        public double? LyAdvClearedFromBill { get; set; }
        public double? LyAdvClearedFromBank { get; set; }
        public double? LyAdvClearedFromCash { get; set; }
        public string Advexptype { get; set; }
        public decimal? VchrId { get; set; }
        public string VchrDateNp { get; set; }
        public string FiscalYear { get; set; }
        public decimal? SubModuleId { get; set; }
        public string Ispeski { get; set; }
        public decimal? DeductDepVchrId { get; set; }
        public string DeductDepVchrDateNep { get; set; }
        public decimal? AccDeductDepVchrId { get; set; }
        public string AccDeductDepVchrDate { get; set; }
        public string ExpireDateNp { get; set; }
        public double? CrAmount { get; set; }
        public decimal? SubjectAreaId { get; set; }

        public virtual PersonTypeMaster PersonType { get; set; }
        public virtual AccSubModuleType SubModule { get; set; }
        public virtual AccTransType TransType { get; set; }
        public virtual AccVchrMaster Vchr { get; set; }
        public virtual AccWorkMaster Work { get; set; }
        public virtual ICollection<AccPaymentDeduction> AccPaymentDeduction { get; set; }
        public virtual ICollection<AccPaymentDetails> AccPaymentDetails { get; set; }
    }
}
