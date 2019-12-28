using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class AccReceivable
    {
        public int Sn { get; set; }
        public string Code { get; set; }
        public int? Taxpayerid { get; set; }
        public string Fiscalyear { get; set; }
        public float? Nettaxamount { get; set; }
        public float? Fineamount { get; set; }
        public float? Additionalcharges { get; set; }
        public float? Reductionalcharges { get; set; }
        public string Taxtype { get; set; }
        public int? Type { get; set; }
        public int? Vchrid { get; set; }
        public string VchrDate { get; set; }
    }
}
