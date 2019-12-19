using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class AccPaymentCredit
    {
        public int Id { get; set; }
        public int? PaymentId { get; set; }
        public string IsOfLastYear { get; set; }
        public int? AccId { get; set; }
        public int? BudgetAccId { get; set; }
        public int? BudgetSourceId { get; set; }
        public float? Amount { get; set; }
    }
}
