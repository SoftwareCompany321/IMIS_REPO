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

        public int PaymentId { get; set; }
        public string Code { get; set; }
        public int? TransTypeId { get; set; }
        public int? PersonTypeId { get; set; }
        public int? PersonId { get; set; }
        public int? WorkId { get; set; }
        public string BillNo { get; set; }
        public float? BillAmt { get; set; }
        public float? VatAmt { get; set; }
        public string PaymentDescription { get; set; }
        public float? RetentionMoneyEduction { get; set; }
        public float? ContractTaxDeduction { get; set; }
        public float? IncomeTaxDeduction { get; set; }
        public float? LastYearsAdvDeduction { get; set; }
        public float? VatDeduction { get; set; }
        public float? OtherDeduction { get; set; }
        public float? ChequePayment { get; set; }
        public float? CashPayment { get; set; }
        public float? AdvClearedFromBill { get; set; }
        public float? AdvClearedFromBank { get; set; }
        public float? AdvClearedFromCash { get; set; }
        public float? LyAdvClearedFromBill { get; set; }
        public float? LyAdvClearedFromBank { get; set; }
        public float? LyAdvClearedFromCash { get; set; }
        public string Advexptype { get; set; }
        public int? VchrId { get; set; }
        public string VchrDateNp { get; set; }
        public string FiscalYear { get; set; }
        public int? SubModuleId { get; set; }
        public string Ispeski { get; set; }
        public int? DeductDepVchrId { get; set; }
        public string DeductDepVchrDateNep { get; set; }
        public int? AccDeductDepVchrId { get; set; }
        public string AccDeductDepVchrDate { get; set; }
        public string ExpireDateNp { get; set; }
        public float? CrAmount { get; set; }
        public int? SubjectAreaId { get; set; }

        public virtual PersonTypeMaster PersonType { get; set; }
        public virtual AccSubModuleType SubModule { get; set; }
        public virtual AccTransType TransType { get; set; }
        public virtual AccVchrMaster Vchr { get; set; }
        public virtual AccWorkMaster Work { get; set; }
        public virtual ICollection<AccPaymentDeduction> AccPaymentDeduction { get; set; }
        public virtual ICollection<AccPaymentDetails> AccPaymentDetails { get; set; }
    }
}
