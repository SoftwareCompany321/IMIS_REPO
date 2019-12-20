using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvDeplist
    {
        public int Id { get; set; }
        public string Fiscalyear { get; set; }
        public int? DakhilaId { get; set; }
        public int? ItemId { get; set; }
        public float? Qty { get; set; }
        public string PurchaseDate { get; set; }
        public float? PurchaseAmt { get; set; }
        public int? BrandId { get; set; }
        public int? SpecId { get; set; }
        public int? UnitId { get; set; }
        public float? DepreDuraton { get; set; }
        public int? DeprePer { get; set; }
        public float? DepreAmt { get; set; }
        public float? MaxDepreAmt { get; set; }
        public float? MinDepreAmt { get; set; }
        public float? DeductAmt { get; set; }
        public float? NetAmt { get; set; }
    }
}
