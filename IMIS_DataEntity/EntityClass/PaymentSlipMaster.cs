using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PaymentSlipMaster
    {
        public PaymentSlipMaster()
        {
            AccExpensesDetails = new HashSet<AccExpensesDetails>();
        }

        public decimal PaymentSlipId { get; set; }
        public string PaymentDescription { get; set; }
        public decimal? TransactionTypeid { get; set; }
        public decimal? PersonTypeId { get; set; }
        public decimal? PersonId { get; set; }
        public decimal? WorkId { get; set; }
        public double? BillAmt { get; set; }
        public double? VatAmt { get; set; }
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
        public string IsPeski { get; set; }
        public decimal? VrNo { get; set; }
        public string VrDate { get; set; }

        public virtual ICollection<AccExpensesDetails> AccExpensesDetails { get; set; }
    }
}
