using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class TblhlAddSubtract
    {
        public int Sn { get; set; }
        public string FiscalYear { get; set; }
        public int? Rateid { get; set; }
        public int? FlatRate { get; set; }
        public float? RatePercent { get; set; }
        public string AddFlag { get; set; }
        public string AddSubTractType { get; set; }
    }
}
