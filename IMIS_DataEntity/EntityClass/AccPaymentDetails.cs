using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class AccPaymentDetails
    {
        public decimal PaymentDetailId { get; set; }
        public decimal? PaymentId { get; set; }
        public decimal? TransTypeId { get; set; }
        public decimal? PersonTypeId { get; set; }
        public decimal? EmpId { get; set; }
        public decimal? PadadhikariId { get; set; }
        public decimal? OrgId { get; set; }
        public decimal? UcId { get; set; }
        public decimal? WardId { get; set; }
        public decimal? WorkId { get; set; }
        public decimal? AccId { get; set; }
        public decimal? BudgetAccId { get; set; }
        public double? DrAmt { get; set; }
        public double? CrAmt { get; set; }
        public double? VatAmt { get; set; }
        public decimal? PaymentSlipId { get; set; }
        public decimal? VchrId { get; set; }
        public string VchrDateNp { get; set; }
        public decimal? OrderInPaymentSlip { get; set; }
        public string Advexptype { get; set; }
        public string IsOfLastYear { get; set; }
        public string FiscalYear { get; set; }
        public decimal? BudgetSourceId { get; set; }
        public decimal? SubModuleId { get; set; }
        public string AdvanceType { get; set; }
        public string ExpireDateNp { get; set; }
        public decimal? SupplierId { get; set; }

        public virtual AccAccMaster Acc { get; set; }
        public virtual AccAccMaster BudgetAcc { get; set; }
        public virtual AccPaymentMaster Payment { get; set; }
        public virtual PersonTypeMaster PersonType { get; set; }
        public virtual AccTransType TransType { get; set; }
        public virtual AccVchrMaster Vchr { get; set; }
        public virtual AccWorkMaster Work { get; set; }
    }
}
