using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class MapRegionFar
    {
        public short Id { get; set; }
        public int? Regionid { get; set; }
        public int? AreaFrom { get; set; }
        public int? AreaTo { get; set; }
        public string FiscalYear { get; set; }
        public float? Far { get; set; }
        public string Remarks { get; set; }

        public virtual MapZone Region { get; set; }
    }
}
