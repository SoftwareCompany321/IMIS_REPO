using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvDepreciation
    {
        public decimal Id { get; set; }
        public string Fiscalyear { get; set; }
        public decimal? DakhilaId { get; set; }
        public decimal? ItemId { get; set; }
        public decimal? BrandId { get; set; }
        public decimal? SpecId { get; set; }
        public decimal? UnitId { get; set; }
        public double? Qty { get; set; }
        public double? OrginalRate { get; set; }
        public double? DepreRate { get; set; }
        public decimal? DeprePer { get; set; }
    }
}
