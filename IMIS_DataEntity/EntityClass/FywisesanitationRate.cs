using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class FywisesanitationRate
    {
        public decimal Id { get; set; }
        public decimal? Rateid { get; set; }
        public decimal? Groupid { get; set; }
        public decimal? Subgroupid { get; set; }
        public decimal? RoadTypeid { get; set; }
        public string Ratename { get; set; }
        public double? Rate { get; set; }
        public string FiscalYear { get; set; }
        public decimal? AreaUpto { get; set; }
        public decimal? ForEachArea { get; set; }
        public decimal? EachAreaRate { get; set; }
    }
}
