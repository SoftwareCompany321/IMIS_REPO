using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class AccPaymentDeduction
    {
        public int Id { get; set; }
        public int? PaymentId { get; set; }
        public int? AccId { get; set; }
        public int? BudgetAccId { get; set; }
        public float? Amount { get; set; }
        public string Status { get; set; }
        public string Deductiontype { get; set; }
        public int? BudgetSourceId { get; set; }

        public virtual AccAccMaster Acc { get; set; }
        public virtual AccAccMaster BudgetAcc { get; set; }
        public virtual AccPaymentMaster Payment { get; set; }
    }
}
