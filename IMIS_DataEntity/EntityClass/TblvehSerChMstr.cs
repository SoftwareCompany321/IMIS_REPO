using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class TblvehSerChMstr
    {
        public int Id { get; set; }
        public int? Rateid { get; set; }
        public int? Accode { get; set; }
        public int? AccId { get; set; }
        public float? ServiceChargePercent { get; set; }
        public float? FlatChargeRate { get; set; }
        public string FiscalYear { get; set; }

        public virtual AccAccMaster Acc { get; set; }
    }
}
