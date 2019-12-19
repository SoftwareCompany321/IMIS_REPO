using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class TblConstructionOtherCharges
    {
        public int Id { get; set; }
        public int? Rateid { get; set; }
        public int? Accode { get; set; }
        public int? AccId { get; set; }
        public float? PercentOfTax { get; set; }
        public int? FlatChargeRate { get; set; }
        public string FiscalYear { get; set; }
        public int? ServiceChargeCalculation { get; set; }

        public virtual AccAccMaster Acc { get; set; }
    }
}
