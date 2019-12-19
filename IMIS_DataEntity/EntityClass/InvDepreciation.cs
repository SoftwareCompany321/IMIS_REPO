using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvDepreciation
    {
        public int Id { get; set; }
        public string Fiscalyear { get; set; }
        public int? DakhilaId { get; set; }
        public int? ItemId { get; set; }
        public int? BrandId { get; set; }
        public int? SpecId { get; set; }
        public int? UnitId { get; set; }
        public float? Qty { get; set; }
        public float? OrginalRate { get; set; }
        public float? DepreRate { get; set; }
        public int? DeprePer { get; set; }
    }
}
