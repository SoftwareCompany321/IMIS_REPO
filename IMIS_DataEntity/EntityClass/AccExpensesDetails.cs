using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class AccExpensesDetails
    {
        public int ExpenseId { get; set; }
        public string Code { get; set; }
        public int? TransTypeId { get; set; }
        public int? PersonTypeId { get; set; }
        public int? EmpId { get; set; }
        public int? PadadhikariId { get; set; }
        public int? OrgId { get; set; }
        public int? UcId { get; set; }
        public int? WardId { get; set; }
        public int? WorkId { get; set; }
        public int? AccId { get; set; }
        public float? DrAmt { get; set; }
        public float? CrAmt { get; set; }
        public float? VatAmt { get; set; }
        public int? PaymentSlipId { get; set; }
        public int? VchrId { get; set; }
        public string VchrDateNp { get; set; }
        public int? OrderInPaymentSlip { get; set; }
        public string Advexptype { get; set; }
        public string IsOfLastYear { get; set; }

        public virtual AccAccMaster Acc { get; set; }
        public virtual PaymentSlipMaster PaymentSlip { get; set; }
        public virtual PersonTypeMaster PersonType { get; set; }
        public virtual AccTransType TransType { get; set; }
        public virtual AccWorkMaster Work { get; set; }
    }
}
