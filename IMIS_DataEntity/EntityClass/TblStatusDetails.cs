using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class TblStatusDetails
    {
        public decimal Id { get; set; }
        public decimal? Masterid { get; set; }
        public decimal? ItemId { get; set; }
        public decimal? BrandId { get; set; }
        public decimal? SpecId { get; set; }
        public decimal? UnitId { get; set; }
        public double? Rate { get; set; }
        public double? StockQty { get; set; }
        public double? UseInQty { get; set; }
        public double? NotUseInQty { get; set; }
        public double? RepairQty { get; set; }
        public double? NotRepairQty { get; set; }
    }
}
