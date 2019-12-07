using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvIncreaseDecrease
    {
        public decimal Id { get; set; }
        public decimal? NumId { get; set; }
        public decimal? DakhilaId { get; set; }
        public decimal? ItemId { get; set; }
        public decimal? BrandId { get; set; }
        public decimal? SpecId { get; set; }
        public decimal? UnitId { get; set; }
        public string PurchaseDate { get; set; }
        public double? StockQty { get; set; }
        public double? Amount { get; set; }
        public double? ScapAmount { get; set; }
        public string Fiscalyear { get; set; }
    }
}
