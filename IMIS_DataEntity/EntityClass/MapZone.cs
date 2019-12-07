using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class MapZone
    {
        public MapZone()
        {
            MapAreaGndCov = new HashSet<MapAreaGndCov>();
            MapRegionFar = new HashSet<MapRegionFar>();
        }

        public decimal Id { get; set; }
        public string NameNp { get; set; }
        public string NameEn { get; set; }
        public string Description { get; set; }

        public virtual ICollection<MapAreaGndCov> MapAreaGndCov { get; set; }
        public virtual ICollection<MapRegionFar> MapRegionFar { get; set; }
    }
}
