using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvPurOrderDetl
    {
        public decimal Id { get; set; }
        public decimal? PurMstId { get; set; }
        public decimal? ItemId { get; set; }
        public decimal? UnitId { get; set; }
        public decimal? SpecId { get; set; }
        public decimal? BrandId { get; set; }
        public decimal? ItemType { get; set; }
        public double? Qty { get; set; }
        public double? ItemRate { get; set; }
        public double? TotalAmt { get; set; }
        public double? TaxAmt { get; set; }
        public string Remarks { get; set; }
        public string Isdakhila { get; set; }

        public virtual InvBrand Brand { get; set; }
        public virtual InvItemMst Item { get; set; }
        public virtual InvItemCategory ItemTypeNavigation { get; set; }
        public virtual InvPurOrderMast PurMst { get; set; }
        public virtual InvItemSpec Spec { get; set; }
        public virtual InvUnit Unit { get; set; }
    }
}
