using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class AccWorkMaster
    {
        public AccWorkMaster()
        {
            AccBankGrnty = new HashSet<AccBankGrnty>();
            AccDhrtiBillDtl = new HashSet<AccDhrtiBillDtl>();
            AccDhrtiBillMaster = new HashSet<AccDhrtiBillMaster>();
            AccExpensesDetails = new HashSet<AccExpensesDetails>();
            AccPaymentDetails = new HashSet<AccPaymentDetails>();
            AccPaymentMaster = new HashSet<AccPaymentMaster>();
            AccVchrDetails = new HashSet<AccVchrDetails>();
            AccWorkFundsDetail = new HashSet<AccWorkFundsDetail>();
            AccWorkPaymntTrans = new HashSet<AccWorkPaymntTrans>();
        }

        public decimal WorkId { get; set; }
        public string NameNp { get; set; }
        public string NameEn { get; set; }
        public double? EstimatedAmt { get; set; }
        public double? VariationAmt { get; set; }
        public double? CorrectedAmt { get; set; }
        public double? FinalActualAmtTobePaid { get; set; }
        public double? TotalActualCost { get; set; }
        public string AgreementParty { get; set; }
        public double? AgreementAmt { get; set; }
        public string AgreementDate { get; set; }
        public string AgreementExpiryDate { get; set; }
        public string WorkCompleteDate { get; set; }
        public string MeasureBookNo { get; set; }
        public double? DepositAmt { get; set; }
        public double? BankGuaranteeAmt { get; set; }
        public string DepositReleaseDate { get; set; }
        public string DepositReleasedDate { get; set; }
        public decimal? WardNo { get; set; }
        public string IsCompleted { get; set; }
        public string DeadlineDate { get; set; }
        public string TpNo { get; set; }
        public decimal? Bankid { get; set; }
        public decimal? EmpId { get; set; }
        public decimal? PartyPersontypeid { get; set; }
        public decimal? PartyId { get; set; }
        public decimal? PersonPersontypeid { get; set; }
        public decimal? PersonId { get; set; }
        public decimal? DepositsAccId { get; set; }
        public decimal? DepositsForfeitAccId { get; set; }
        public string IsKramagat { get; set; }
        public decimal? YojanaNaturId { get; set; }
        public string AgreementSigningPerson { get; set; }

        public virtual ICollection<AccBankGrnty> AccBankGrnty { get; set; }
        public virtual ICollection<AccDhrtiBillDtl> AccDhrtiBillDtl { get; set; }
        public virtual ICollection<AccDhrtiBillMaster> AccDhrtiBillMaster { get; set; }
        public virtual ICollection<AccExpensesDetails> AccExpensesDetails { get; set; }
        public virtual ICollection<AccPaymentDetails> AccPaymentDetails { get; set; }
        public virtual ICollection<AccPaymentMaster> AccPaymentMaster { get; set; }
        public virtual ICollection<AccVchrDetails> AccVchrDetails { get; set; }
        public virtual ICollection<AccWorkFundsDetail> AccWorkFundsDetail { get; set; }
        public virtual ICollection<AccWorkPaymntTrans> AccWorkPaymntTrans { get; set; }
    }
}
