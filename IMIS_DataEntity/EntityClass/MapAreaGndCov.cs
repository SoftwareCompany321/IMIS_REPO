using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class MapAreaGndCov
    {
        public int Id { get; set; }
        public decimal? Regionid { get; set; }
        public double? GroundCov { get; set; }
        public long? Area { get; set; }
        public string Remarks { get; set; }

        public virtual MapZone Region { get; set; }
    }
}
