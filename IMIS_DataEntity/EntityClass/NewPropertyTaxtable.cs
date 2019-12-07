using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class NewPropertyTaxtable
    {
        public decimal Sn { get; set; }
        public decimal? Ratesn { get; set; }
        public double? Frompropertyvalue { get; set; }
        public double? Topropertyvalue { get; set; }
        public double? Fromtaxamount { get; set; }
        public double? Totaxamount { get; set; }
        public string Remarks { get; set; }
        public string Fiscalyear { get; set; }
        public double? TaxPercent { get; set; }
    }
}
