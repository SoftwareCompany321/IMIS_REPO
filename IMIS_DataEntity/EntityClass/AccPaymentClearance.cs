using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class AccPaymentClearance
    {
        public decimal Id { get; set; }
        public decimal? PaymentId { get; set; }
        public string IsOfLastYear { get; set; }
        public decimal? AccId { get; set; }
        public decimal? BudgetAccId { get; set; }
        public double? Amount { get; set; }
        public decimal? BudgetSourceId { get; set; }

        public virtual AccAccMaster Acc { get; set; }
        public virtual AccAccMaster BudgetAcc { get; set; }
    }
}
