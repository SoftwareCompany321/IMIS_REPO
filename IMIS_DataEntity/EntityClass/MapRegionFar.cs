using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class MapRegionFar
    {
        public short Id { get; set; }
        public decimal? Regionid { get; set; }
        public decimal? AreaFrom { get; set; }
        public decimal? AreaTo { get; set; }
        public string FiscalYear { get; set; }
        public double? Far { get; set; }
        public string Remarks { get; set; }

        public virtual MapZone Region { get; set; }
    }
}
