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

        public int WorkId { get; set; }
        public string NameNp { get; set; }
        public string NameEn { get; set; }
        public float? EstimatedAmt { get; set; }
        public float? VariationAmt { get; set; }
        public float? CorrectedAmt { get; set; }
        public float? FinalActualAmtTobePaid { get; set; }
        public float? TotalActualCost { get; set; }
        public string AgreementParty { get; set; }
        public float? AgreementAmt { get; set; }
        public string AgreementDate { get; set; }
        public string AgreementExpiryDate { get; set; }
        public string WorkCompleteDate { get; set; }
        public string MeasureBookNo { get; set; }
        public float? DepositAmt { get; set; }
        public float? BankGuaranteeAmt { get; set; }
        public string DepositReleaseDate { get; set; }
        public string DepositReleasedDate { get; set; }
        public int? WardNo { get; set; }
        public string IsCompleted { get; set; }
        public string DeadlineDate { get; set; }
        public string TpNo { get; set; }
        public int? Bankid { get; set; }
        public int? EmpId { get; set; }
        public int? PartyPersontypeid { get; set; }
        public int? PartyId { get; set; }
        public int? PersonPersontypeid { get; set; }
        public int? PersonId { get; set; }
        public int? DepositsAccId { get; set; }
        public int? DepositsForfeitAccId { get; set; }
        public string IsKramagat { get; set; }
        public int? YojanaNaturId { get; set; }
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
