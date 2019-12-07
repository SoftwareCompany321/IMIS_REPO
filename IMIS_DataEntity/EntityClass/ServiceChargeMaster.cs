using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class ServiceChargeMaster
    {
        public int Id { get; set; }
        public int? Rateid { get; set; }
        public int? Accode { get; set; }
        public decimal? AccId { get; set; }
        public double? ServiceChargePercent { get; set; }
        public double? FlatChargeRate { get; set; }
        public short? Isapplicableforhouse { get; set; }

        public virtual AccAccMaster Acc { get; set; }
    }
}
