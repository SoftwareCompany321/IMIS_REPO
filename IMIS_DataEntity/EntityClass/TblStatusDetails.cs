using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class TblStatusDetails
    {
        public int Id { get; set; }
        public int? Masterid { get; set; }
        public int? ItemId { get; set; }
        public int? BrandId { get; set; }
        public int? SpecId { get; set; }
        public int? UnitId { get; set; }
        public float? Rate { get; set; }
        public float? StockQty { get; set; }
        public float? UseInQty { get; set; }
        public float? NotUseInQty { get; set; }
        public float? RepairQty { get; set; }
        public float? NotRepairQty { get; set; }
    }
}
