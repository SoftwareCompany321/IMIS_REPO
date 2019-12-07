using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class AccFundProvidrMstr
    {
        public AccFundProvidrMstr()
        {
            AccWorkFundsDetail = new HashSet<AccWorkFundsDetail>();
        }

        public decimal ProviderId { get; set; }
        public string NameNp { get; set; }
        public string NameEn { get; set; }
        public string Phones { get; set; }
        public string Emails { get; set; }
        public string Chairman { get; set; }
        public string ContactPerson { get; set; }

        public virtual ICollection<AccWorkFundsDetail> AccWorkFundsDetail { get; set; }
    }
}
