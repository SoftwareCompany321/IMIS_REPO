using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class TblConstructionOtherCharges
    {
        public decimal Id { get; set; }
        public decimal? Rateid { get; set; }
        public decimal? Accode { get; set; }
        public decimal? AccId { get; set; }
        public double? PercentOfTax { get; set; }
        public decimal? FlatChargeRate { get; set; }
        public string FiscalYear { get; set; }
        public decimal? ServiceChargeCalculation { get; set; }

        public virtual AccAccMaster Acc { get; set; }
    }
}
