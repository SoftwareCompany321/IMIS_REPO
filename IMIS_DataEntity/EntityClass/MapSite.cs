using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class MapSite
    {
        public int Sn { get; set; }
        public int? Permitid { get; set; }
        public short? Landshape { get; set; }
        public float? SideA { get; set; }
        public float? SideB { get; set; }
        public float? SideC { get; set; }
        public float? Area { get; set; }
    }
}
