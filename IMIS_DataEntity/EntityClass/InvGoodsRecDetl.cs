using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvGoodsRecDetl
    {
        public decimal Id { get; set; }
        public decimal? GoodsMasterId { get; set; }
        public decimal? ItemId { get; set; }
        public decimal? UnitId { get; set; }
        public decimal? BrandId { get; set; }
        public decimal? SpecId { get; set; }
        public double? PurQty { get; set; }
        public double? RecvQty { get; set; }
        public double? Rate { get; set; }
        public string WhetherTax { get; set; }
        public double? TaxPerUnitAmt { get; set; }
        public double? DiscAmt { get; set; }
        public double? OtherExpencesAmt { get; set; }
        public double? NetAmt { get; set; }
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
