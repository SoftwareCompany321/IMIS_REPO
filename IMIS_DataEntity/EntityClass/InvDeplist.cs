using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvDeplist
    {
        public decimal Id { get; set; }
        public string Fiscalyear { get; set; }
        public decimal? DakhilaId { get; set; }
        public decimal? ItemId { get; set; }
        public double? Qty { get; set; }
        public string PurchaseDate { get; set; }
        public double? PurchaseAmt { get; set; }
        public decimal? BrandId { get; set; }
        public decimal? SpecId { get; set; }
        public decimal? UnitId { get; set; }
        public double? DepreDuraton { get; set; }
        public decimal? DeprePer { get; set; }
        public double? DepreAmt { get; set; }
        public double? MaxDepreAmt { get; set; }
        public double? MinDepreAmt { get; set; }
        public double? DeductAmt { get; set; }
        public double? NetAmt { get; set; }
    }
}
