using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class AccReceivable
    {
        public decimal? Sn { get; set; }
        public decimal? Taxpayerid { get; set; }
        public string Fiscalyear { get; set; }
        public double? Nettaxamount { get; set; }
        public double? Fineamount { get; set; }
        public double? Additionalcharges { get; set; }
        public double? Reductionalcharges { get; set; }
        public string Taxtype { get; set; }
        public int? Type { get; set; }
        public decimal? Vchrid { get; set; }
        public string VchrDate { get; set; }
    }
}
