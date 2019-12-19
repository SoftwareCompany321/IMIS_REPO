using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class AccWorkFundsDetail
    {
        public int FundDetailId { get; set; }
        public int? WorkId { get; set; }
        public int? ProviderId { get; set; }
        public float? FundedAmt { get; set; }
        public float? FundedPercent { get; set; }
        public int? Isjanasaramdha { get; set; }
        public int? Isownoffice { get; set; }

        public virtual AccFundProvidrMstr Provider { get; set; }
        public virtual AccWorkMaster Work { get; set; }
    }
}
