using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class TaxThliIssuedCntr
    {
        public decimal? Id { get; set; }
        public decimal? TheliId { get; set; }
        public decimal? CntrId { get; set; }

        public virtual Collectioncounters Cntr { get; set; }
        public virtual Storedbills Theli { get; set; }
    }
}
