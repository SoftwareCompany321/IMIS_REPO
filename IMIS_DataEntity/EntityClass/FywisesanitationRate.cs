using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class FywisesanitationRate
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int? Rateid { get; set; }
        public int? Groupid { get; set; }
        public int? Subgroupid { get; set; }
        public int? RoadTypeid { get; set; }
        public string Ratename { get; set; }
        public float? Rate { get; set; }
        public string FiscalYear { get; set; }
        public int? AreaUpto { get; set; }
        public int? ForEachArea { get; set; }
        public int? EachAreaRate { get; set; }
    }
}
