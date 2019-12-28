using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvIncreaseDecrease
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int? NumId { get; set; }
        public int? DakhilaId { get; set; }
        public int? ItemId { get; set; }
        public int? BrandId { get; set; }
        public int? SpecId { get; set; }
        public int? UnitId { get; set; }
        public string PurchaseDate { get; set; }
        public float? StockQty { get; set; }
        public float? Amount { get; set; }
        public float? ScapAmount { get; set; }
        public string Fiscalyear { get; set; }
    }
}
