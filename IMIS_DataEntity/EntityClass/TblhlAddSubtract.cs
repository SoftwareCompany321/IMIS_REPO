using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class TblhlAddSubtract
    {
        public decimal Sn { get; set; }
        public string FiscalYear { get; set; }
        public decimal? Rateid { get; set; }
        public decimal? FlatRate { get; set; }
        public double? RatePercent { get; set; }
        public string AddFlag { get; set; }
        public string AddSubTractType { get; set; }
    }
}
