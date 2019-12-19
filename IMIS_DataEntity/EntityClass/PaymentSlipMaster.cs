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

        public int PaymentSlipId { get; set; }
        public string PaymentDescription { get; set; }
        public int? TransactionTypeid { get; set; }
        public int? PersonTypeId { get; set; }
        public int? PersonId { get; set; }
        public int? WorkId { get; set; }
        public float? BillAmt { get; set; }
        public float? VatAmt { get; set; }
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
        public string IsPeski { get; set; }
        public int? VrNo { get; set; }
        public string VrDate { get; set; }

        public virtual ICollection<AccExpensesDetails> AccExpensesDetails { get; set; }
    }
}
