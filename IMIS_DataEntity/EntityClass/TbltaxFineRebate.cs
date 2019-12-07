using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class TbltaxFineRebate
    {
        public decimal Sn { get; set; }
        public string FiscalYear { get; set; }
        public double? DurationInYears { get; set; }
        public string TaxType { get; set; }
        public decimal? FlatRate { get; set; }
        public double? RatePercent { get; set; }
        public string RebateFlag { get; set; }
    }
}
