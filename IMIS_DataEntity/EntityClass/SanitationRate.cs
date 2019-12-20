using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class SanitationRate
    {
        public int Id { get; set; }
        public int? Groupid { get; set; }
        public int? Subgroupid { get; set; }
        public int? RoadTypeid { get; set; }
        public string Ratename { get; set; }
        public float? Rate { get; set; }
        public string FiscalYear { get; set; }
        public int? AreaUpto { get; set; }
        public int? ForEachArea { get; set; }
        public int? EachAreaRate { get; set; }

        public virtual SanitationGroup Group { get; set; }
        public virtual SanitationSubgroup Subgroup { get; set; }
    }
}
