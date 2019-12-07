using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class AccWorkFundsDetail
    {
        public decimal FundDetailId { get; set; }
        public decimal? WorkId { get; set; }
        public decimal? ProviderId { get; set; }
        public double? FundedAmt { get; set; }
        public double? FundedPercent { get; set; }
        public decimal? Isjanasaramdha { get; set; }
        public decimal? Isownoffice { get; set; }

        public virtual AccFundProvidrMstr Provider { get; set; }
        public virtual AccWorkMaster Work { get; set; }
    }
}
