using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class NewPropertyTaxtable
    {
        public int Sn { get; set; }
        public string Code { get; set; }
        public int? Ratesn { get; set; }
        public float? Frompropertyvalue { get; set; }
        public float? Topropertyvalue { get; set; }
        public float? Fromtaxamount { get; set; }
        public float? Totaxamount { get; set; }
        public string Remarks { get; set; }
        public string Fiscalyear { get; set; }
        public float? TaxPercent { get; set; }
    }
}
