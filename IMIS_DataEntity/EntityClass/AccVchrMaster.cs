using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class AccVchrMaster
    {
        public AccVchrMaster()
        {
            AccBankTrans = new HashSet<AccBankTrans>();
            AccCashTrans = new HashSet<AccCashTrans>();
            AccDhrtiBillDtl = new HashSet<AccDhrtiBillDtl>();
            AccDhrtiBillMaster = new HashSet<AccDhrtiBillMaster>();
            AccPaymentDetails = new HashSet<AccPaymentDetails>();
            AccPaymentMaster = new HashSet<AccPaymentMaster>();
            AccVchrDetails = new HashSet<AccVchrDetails>();
            AccWorkPaymntTrans = new HashSet<AccWorkPaymntTrans>();
            Banktransactions = new HashSet<Banktransactions>();
            Cashtransaction = new HashSet<Cashtransaction>();
            Incomebilldetails = new HashSet<Incomebilldetails>();
            Incomebillmaster = new HashSet<Incomebillmaster>();
        }

        public int VchrId { get; set; }
        public string Code { get; set; }
        public int? VchrNo { get; set; }
        public string VchrDateNep { get; set; }
        public int? VchrTypeId { get; set; }
        public string Narration { get; set; }
        public int? UserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Fiscalyear { get; set; }
        public string Module { get; set; }
        public string IsPosted { get; set; }
        public int? SubModuleId { get; set; }
        public string NameChequePayee { get; set; }
        public string IsOfLastYear { get; set; }
        public string Remarks { get; set; }
        public short? ChequeTypeId { get; set; }
        public string FatherName { get; set; }
        public string GrandFatherName { get; set; }
        public string ContactPhone { get; set; }
        public string IsNikash { get; set; }
        public string Wardno { get; set; }
        public int? PrepBy { get; set; }
        public int? CheckBy { get; set; }
        public int? AcceptBy { get; set; }
        public string InternalLekha { get; set; }
        public float? NiyamitAmt { get; set; }
        public float? AsuliAmt { get; set; }
        public float? ValidAmt { get; set; }
        public float? NValidAmt { get; set; }

        public virtual AccSubModuleType SubModule { get; set; }
        public virtual AccVchrTypeMaster VchrType { get; set; }
        public virtual ICollection<AccBankTrans> AccBankTrans { get; set; }
        public virtual ICollection<AccCashTrans> AccCashTrans { get; set; }
        public virtual ICollection<AccDhrtiBillDtl> AccDhrtiBillDtl { get; set; }
        public virtual ICollection<AccDhrtiBillMaster> AccDhrtiBillMaster { get; set; }
        public virtual ICollection<AccPaymentDetails> AccPaymentDetails { get; set; }
        public virtual ICollection<AccPaymentMaster> AccPaymentMaster { get; set; }
        public virtual ICollection<AccVchrDetails> AccVchrDetails { get; set; }
        public virtual ICollection<AccWorkPaymntTrans> AccWorkPaymntTrans { get; set; }
        public virtual ICollection<Banktransactions> Banktransactions { get; set; }
        public virtual ICollection<Cashtransaction> Cashtransaction { get; set; }
        public virtual ICollection<Incomebilldetails> Incomebilldetails { get; set; }
        public virtual ICollection<Incomebillmaster> Incomebillmaster { get; set; }
    }
}
