using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class AccTransType
    {
        public AccTransType()
        {
            AccAccMaster = new HashSet<AccAccMaster>();
            AccExpensesDetails = new HashSet<AccExpensesDetails>();
            AccPaymentDetails = new HashSet<AccPaymentDetails>();
            AccPaymentMaster = new HashSet<AccPaymentMaster>();
            AccVchrDetails = new HashSet<AccVchrDetails>();
        }

        public decimal TypeId { get; set; }
        public string TypeCode { get; set; }
        public string NepName { get; set; }
        public string EngName { get; set; }
        public string Module { get; set; }

        public virtual ICollection<AccAccMaster> AccAccMaster { get; set; }
        public virtual ICollection<AccExpensesDetails> AccExpensesDetails { get; set; }
        public virtual ICollection<AccPaymentDetails> AccPaymentDetails { get; set; }
        public virtual ICollection<AccPaymentMaster> AccPaymentMaster { get; set; }
        public virtual ICollection<AccVchrDetails> AccVchrDetails { get; set; }
    }
}
