using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisEmployeeMaster
    {
        public PisEmployeeMaster()
        {
            InvGoodsAdjustAcceptByNavigation = new HashSet<InvGoodsAdjust>();
            InvGoodsAdjustPrepByNavigation = new HashSet<InvGoodsAdjust>();
            InvGoodsRecMastAcceptByNavigation = new HashSet<InvGoodsRecMast>();
            InvGoodsRecMastCheckByNavigation = new HashSet<InvGoodsRecMast>();
            InvGoodsRecMastPrepByNavigation = new HashSet<InvGoodsRecMast>();
            InvIssueMasterAcceptByNavigation = new HashSet<InvIssueMaster>();
            InvIssueMasterCheckByNavigation = new HashSet<InvIssueMaster>();
            InvIssueMasterIssueByNavigation = new HashSet<InvIssueMaster>();
            InvIssueMasterPrepByNavigation = new HashSet<InvIssueMaster>();
            InvItemDetailsAcceptByNavigation = new HashSet<InvItemDetails>();
            InvItemDetailsCheckByNavigation = new HashSet<InvItemDetails>();
            InvItemDetailsPrepByNavigation = new HashSet<InvItemDetails>();
            InvItemStatuscheckAcceptedByNavigation = new HashSet<InvItemStatuscheck>();
            InvItemStatuscheckPrepByNavigation = new HashSet<InvItemStatuscheck>();
            InvItemStatuscheckTallyByNavigation = new HashSet<InvItemStatuscheck>();
            InvPurOrderMastAcceptedByNavigation = new HashSet<InvPurOrderMast>();
            InvPurOrderMastCheckedByNavigation = new HashSet<InvPurOrderMast>();
            InvPurOrderMastPreparedByNavigation = new HashSet<InvPurOrderMast>();
            InvRequisitionMastAcceptByNavigation = new HashSet<InvRequisitionMast>();
            InvRequisitionMastCheckByNavigation = new HashSet<InvRequisitionMast>();
            InvRequisitionMastPrepByNavigation = new HashSet<InvRequisitionMast>();
            InvRequisitionMastReqByNavigation = new HashSet<InvRequisitionMast>();
            InvStatusDetailAcceptbyNavigation = new HashSet<InvStatusDetail>();
            InvStatusDetailCheckedbyNavigation = new HashSet<InvStatusDetail>();
            InvStatusDetailPrebyNavigation = new HashSet<InvStatusDetail>();
            PisBankPayroll = new HashSet<PisBankPayroll>();
            PisEmpAdvDedDtl = new HashSet<PisEmpAdvDedDtl>();
            PisEmpLoans = new HashSet<PisEmpLoans>();
            PisEmpLongLeaves = new HashSet<PisEmpLongLeaves>();
            PisEmpMedExpense = new HashSet<PisEmpMedExpense>();
            PisEmpPunishmnts = new HashSet<PisEmpPunishmnts>();
            PisEmpSrvcDtls = new HashSet<PisEmpSrvcDtls>();
            PisEmpSuspends = new HashSet<PisEmpSuspends>();
            PisEmpTrnsfrRec = new HashSet<PisEmpTrnsfrRec>();
            PisInternalTransfer = new HashSet<PisInternalTransfer>();
            PisPyrollLoanDtls = new HashSet<PisPyrollLoanDtls>();
            PisPyrollOthrDtls = new HashSet<PisPyrollOthrDtls>();
            WardMaster = new HashSet<WardMaster>();
        }

        public int EmpId { get; set; }
        public string FirstNameNp { get; set; }
        public string LastNameNp { get; set; }
        public string FirstNameEn { get; set; }
        public string LastNameEn { get; set; }
        public int? PostId { get; set; }
        public string ServiceGroup { get; set; }
        public string Title { get; set; }
        public string Gender { get; set; }
        public string FatherName { get; set; }
        public string HusbandName { get; set; }
        public string WillPerson { get; set; }
        public string Address { get; set; }
        public string DateOfBirth { get; set; }
        public string FirstAppointDate { get; set; }
        public int? FirstAppointPostId { get; set; }
        public string CurrentPostAppointDate { get; set; }
        public string ServiceStatus { get; set; }
        public string PostStatus { get; set; }
        public int? Grades { get; set; }
        public int? CitPercent { get; set; }
        public string Paymode { get; set; }
        public string GovtEmpId { get; set; }
        public string PfId { get; set; }
        public string CitId { get; set; }
        public int? PostLevel { get; set; }
        public string RetireDate { get; set; }
        public int? LocalPostId { get; set; }
        public string Phones { get; set; }
        public string Emails { get; set; }
        public int? PayementBankId { get; set; }
        public string MarriedStatus { get; set; }
        public string InsuranceNo { get; set; }
        public string MobileNo { get; set; }
        public int? Religion { get; set; }
        public int? ParentOcupation { get; set; }
        public int? SpouseOcupation { get; set; }
        public string GfName { get; set; }
        public int? GfOcupation { get; set; }
        public string RelWithWillPerson { get; set; }
        public int? ZoneId { get; set; }
        public int? DistrictId { get; set; }
        public int? VdcId { get; set; }
        public int? WardNo { get; set; }
        public string MailAddress { get; set; }
        public int? AppoinmentType { get; set; }
        public string CitizenshipNo { get; set; }
        public string CsIssuedDate { get; set; }
        public int? CsIssuedDistrict { get; set; }
        public DateTime? DateOfBirthAd { get; set; }
        public string InsuranceFacility { get; set; }
        public string DeductAbsent { get; set; }
        public string LekhaNo { get; set; }
        public int? DeptId { get; set; }
        public string PensionKosh { get; set; }
        public string CitCode { get; set; }
        public int? RoomId { get; set; }
        public string Code { get; set; }

        public virtual PisEmpDep Dept { get; set; }
        public virtual PisPostMaster FirstAppointPost { get; set; }
        public virtual PisLocalPostMaster LocalPost { get; set; }
        public virtual Bankmaster PayementBank { get; set; }
        public virtual PisPostMaster Post { get; set; }
        public virtual ICollection<InvGoodsAdjust> InvGoodsAdjustAcceptByNavigation { get; set; }
        public virtual ICollection<InvGoodsAdjust> InvGoodsAdjustPrepByNavigation { get; set; }
        public virtual ICollection<InvGoodsRecMast> InvGoodsRecMastAcceptByNavigation { get; set; }
        public virtual ICollection<InvGoodsRecMast> InvGoodsRecMastCheckByNavigation { get; set; }
        public virtual ICollection<InvGoodsRecMast> InvGoodsRecMastPrepByNavigation { get; set; }
        public virtual ICollection<InvIssueMaster> InvIssueMasterAcceptByNavigation { get; set; }
        public virtual ICollection<InvIssueMaster> InvIssueMasterCheckByNavigation { get; set; }
        public virtual ICollection<InvIssueMaster> InvIssueMasterIssueByNavigation { get; set; }
        public virtual ICollection<InvIssueMaster> InvIssueMasterPrepByNavigation { get; set; }
        public virtual ICollection<InvItemDetails> InvItemDetailsAcceptByNavigation { get; set; }
        public virtual ICollection<InvItemDetails> InvItemDetailsCheckByNavigation { get; set; }
        public virtual ICollection<InvItemDetails> InvItemDetailsPrepByNavigation { get; set; }
        public virtual ICollection<InvItemStatuscheck> InvItemStatuscheckAcceptedByNavigation { get; set; }
        public virtual ICollection<InvItemStatuscheck> InvItemStatuscheckPrepByNavigation { get; set; }
        public virtual ICollection<InvItemStatuscheck> InvItemStatuscheckTallyByNavigation { get; set; }
        public virtual ICollection<InvPurOrderMast> InvPurOrderMastAcceptedByNavigation { get; set; }
        public virtual ICollection<InvPurOrderMast> InvPurOrderMastCheckedByNavigation { get; set; }
        public virtual ICollection<InvPurOrderMast> InvPurOrderMastPreparedByNavigation { get; set; }
        public virtual ICollection<InvRequisitionMast> InvRequisitionMastAcceptByNavigation { get; set; }
        public virtual ICollection<InvRequisitionMast> InvRequisitionMastCheckByNavigation { get; set; }
        public virtual ICollection<InvRequisitionMast> InvRequisitionMastPrepByNavigation { get; set; }
        public virtual ICollection<InvRequisitionMast> InvRequisitionMastReqByNavigation { get; set; }
        public virtual ICollection<InvStatusDetail> InvStatusDetailAcceptbyNavigation { get; set; }
        public virtual ICollection<InvStatusDetail> InvStatusDetailCheckedbyNavigation { get; set; }
        public virtual ICollection<InvStatusDetail> InvStatusDetailPrebyNavigation { get; set; }
        public virtual ICollection<PisBankPayroll> PisBankPayroll { get; set; }
        public virtual ICollection<PisEmpAdvDedDtl> PisEmpAdvDedDtl { get; set; }
        public virtual ICollection<PisEmpLoans> PisEmpLoans { get; set; }
        public virtual ICollection<PisEmpLongLeaves> PisEmpLongLeaves { get; set; }
        public virtual ICollection<PisEmpMedExpense> PisEmpMedExpense { get; set; }
        public virtual ICollection<PisEmpPunishmnts> PisEmpPunishmnts { get; set; }
        public virtual ICollection<PisEmpSrvcDtls> PisEmpSrvcDtls { get; set; }
        public virtual ICollection<PisEmpSuspends> PisEmpSuspends { get; set; }
        public virtual ICollection<PisEmpTrnsfrRec> PisEmpTrnsfrRec { get; set; }
        public virtual ICollection<PisInternalTransfer> PisInternalTransfer { get; set; }
        public virtual ICollection<PisPyrollLoanDtls> PisPyrollLoanDtls { get; set; }
        public virtual ICollection<PisPyrollOthrDtls> PisPyrollOthrDtls { get; set; }
        public virtual ICollection<WardMaster> WardMaster { get; set; }
    }
}
