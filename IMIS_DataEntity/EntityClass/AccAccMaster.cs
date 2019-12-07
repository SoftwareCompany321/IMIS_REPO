using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class AccAccMaster
    {
        public AccAccMaster()
        {
            AccBgtTransferFromAcc = new HashSet<AccBgtTransfer>();
            AccBgtTransferToAcc = new HashSet<AccBgtTransfer>();
            AccDhrtiBillDtl = new HashSet<AccDhrtiBillDtl>();
            AccExpensesDetails = new HashSet<AccExpensesDetails>();
            AccPaymentClearanceAcc = new HashSet<AccPaymentClearance>();
            AccPaymentClearanceBudgetAcc = new HashSet<AccPaymentClearance>();
            AccPaymentDeductionAcc = new HashSet<AccPaymentDeduction>();
            AccPaymentDeductionBudgetAcc = new HashSet<AccPaymentDeduction>();
            AccPaymentDetailsAcc = new HashSet<AccPaymentDetails>();
            AccPaymentDetailsBudgetAcc = new HashSet<AccPaymentDetails>();
            Firebrigadestate = new HashSet<Firebrigadestate>();
            Incomebilldetails = new HashSet<Incomebilldetails>();
            MapIncomeType = new HashSet<MapIncomeType>();
            PisPyrollLoanDtls = new HashSet<PisPyrollLoanDtls>();
            ServiceChargeMaster = new HashSet<ServiceChargeMaster>();
            TaxAddtnlChrgDtls = new HashSet<TaxAddtnlChrgDtls>();
            TblConstructionOtherCharges = new HashSet<TblConstructionOtherCharges>();
            TblLandOtherCharges = new HashSet<TblLandOtherCharges>();
            TblMalpotOtherCharges = new HashSet<TblMalpotOtherCharges>();
            TblbusinessServiceChMst = new HashSet<TblbusinessServiceChMst>();
            TblvehSerChMstr = new HashSet<TblvehSerChMstr>();
        }

        public decimal AccId { get; set; }
        public string Code { get; set; }
        public string NepName { get; set; }
        public string EngName { get; set; }
        public decimal? ParentAccId { get; set; }
        public int? GrpLevel { get; set; }
        public string IsFixed { get; set; }
        public string IsTransactable { get; set; }
        public string IsBudgetable { get; set; }
        public string DispCode { get; set; }
        public string DispName { get; set; }
        public string AccType { get; set; }
        public decimal? TypeId { get; set; }
        public string AccCode { get; set; }
        public decimal? SubModuleId { get; set; }
        public string FiscalYear { get; set; }
        public string IsHide { get; set; }
        public decimal? Iscapitalcurrent { get; set; }

        public virtual AccTransType Type { get; set; }
        public virtual ICollection<AccBgtTransfer> AccBgtTransferFromAcc { get; set; }
        public virtual ICollection<AccBgtTransfer> AccBgtTransferToAcc { get; set; }
        public virtual ICollection<AccDhrtiBillDtl> AccDhrtiBillDtl { get; set; }
        public virtual ICollection<AccExpensesDetails> AccExpensesDetails { get; set; }
        public virtual ICollection<AccPaymentClearance> AccPaymentClearanceAcc { get; set; }
        public virtual ICollection<AccPaymentClearance> AccPaymentClearanceBudgetAcc { get; set; }
        public virtual ICollection<AccPaymentDeduction> AccPaymentDeductionAcc { get; set; }
        public virtual ICollection<AccPaymentDeduction> AccPaymentDeductionBudgetAcc { get; set; }
        public virtual ICollection<AccPaymentDetails> AccPaymentDetailsAcc { get; set; }
        public virtual ICollection<AccPaymentDetails> AccPaymentDetailsBudgetAcc { get; set; }
        public virtual ICollection<Firebrigadestate> Firebrigadestate { get; set; }
        public virtual ICollection<Incomebilldetails> Incomebilldetails { get; set; }
        public virtual ICollection<MapIncomeType> MapIncomeType { get; set; }
        public virtual ICollection<PisPyrollLoanDtls> PisPyrollLoanDtls { get; set; }
        public virtual ICollection<ServiceChargeMaster> ServiceChargeMaster { get; set; }
        public virtual ICollection<TaxAddtnlChrgDtls> TaxAddtnlChrgDtls { get; set; }
        public virtual ICollection<TblConstructionOtherCharges> TblConstructionOtherCharges { get; set; }
        public virtual ICollection<TblLandOtherCharges> TblLandOtherCharges { get; set; }
        public virtual ICollection<TblMalpotOtherCharges> TblMalpotOtherCharges { get; set; }
        public virtual ICollection<TblbusinessServiceChMst> TblbusinessServiceChMst { get; set; }
        public virtual ICollection<TblvehSerChMstr> TblvehSerChMstr { get; set; }
    }
}
