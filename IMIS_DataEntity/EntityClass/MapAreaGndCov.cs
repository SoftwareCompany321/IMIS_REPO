using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class MapAreaGndCov
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int? Regionid { get; set; }
        public float? GroundCov { get; set; }
        public long? Area { get; set; }
        public string Remarks { get; set; }

        public virtual MapZone Region { get; set; }
    }
}
