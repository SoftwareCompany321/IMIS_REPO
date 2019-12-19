using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class TbltaxFineRebate
    {
        public int Sn { get; set; }
        public string FiscalYear { get; set; }
        public float? DurationInYears { get; set; }
        public string TaxType { get; set; }
        public int? FlatRate { get; set; }
        public float? RatePercent { get; set; }
        public string RebateFlag { get; set; }
    }
}
