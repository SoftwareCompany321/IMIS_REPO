using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class MapStdheightRw
    {
        public short Id { get; set; }
        public string Code { get; set; }
        public float? RoadWidth { get; set; }
        public float? HouseHeight { get; set; }
        public string FiscalYear { get; set; }
        public string Remarks { get; set; }
    }
}
