using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PersonTypeMaster
    {
        public PersonTypeMaster()
        {
            AccAsuliBibaran = new HashSet<AccAsuliBibaran>();
            AccExpensesDetails = new HashSet<AccExpensesDetails>();
            AccPaymentDetails = new HashSet<AccPaymentDetails>();
            AccPaymentMaster = new HashSet<AccPaymentMaster>();
            AccWorkPaymntTrans = new HashSet<AccWorkPaymntTrans>();
        }

        public int PersonTypeId { get; set; }
        public string NameNp { get; set; }
        public string NameEn { get; set; }
        public string Isfixed { get; set; }

        public virtual ICollection<AccAsuliBibaran> AccAsuliBibaran { get; set; }
        public virtual ICollection<AccExpensesDetails> AccExpensesDetails { get; set; }
        public virtual ICollection<AccPaymentDetails> AccPaymentDetails { get; set; }
        public virtual ICollection<AccPaymentMaster> AccPaymentMaster { get; set; }
        public virtual ICollection<AccWorkPaymntTrans> AccWorkPaymntTrans { get; set; }
    }
}
