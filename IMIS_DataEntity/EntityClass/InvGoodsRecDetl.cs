using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvGoodsRecDetl
    {
        public int Id { get; set; }
        public int? GoodsMasterId { get; set; }
        public int? ItemId { get; set; }
        public int? UnitId { get; set; }
        public int? BrandId { get; set; }
        public int? SpecId { get; set; }
        public float? PurQty { get; set; }
        public float? RecvQty { get; set; }
        public float? Rate { get; set; }
        public string WhetherTax { get; set; }
        public float? TaxPerUnitAmt { get; set; }
        public float? DiscAmt { get; set; }
        public float? OtherExpencesAmt { get; set; }
        public float? NetAmt { get; set; }
        public string Remarks { get; set; }
        public string Isnumbered { get; set; }
        public DateTime? DakhilaDtEng { get; set; }

        public virtual InvBrand Brand { get; set; }
        public virtual InvGoodsRecMast GoodsMaster { get; set; }
        public virtual InvItemMst Item { get; set; }
        public virtual InvItemSpec Spec { get; set; }
        public virtual InvUnit Unit { get; set; }
    }
}
