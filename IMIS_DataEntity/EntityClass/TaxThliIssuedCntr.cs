using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class TaxThliIssuedCntr
    {
        public int Id { get; set; }
        public int? TheliId { get; set; }
        public int? CntrId { get; set; }

        public virtual Collectioncounters Cntr { get; set; }
        public virtual Storedbills Theli { get; set; }
    }
}
