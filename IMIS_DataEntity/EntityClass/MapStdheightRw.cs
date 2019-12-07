using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class MapStdheightRw
    {
        public short Id { get; set; }
        public double? RoadWidth { get; set; }
        public double? HouseHeight { get; set; }
        public string FiscalYear { get; set; }
        public string Remarks { get; set; }
    }
}
