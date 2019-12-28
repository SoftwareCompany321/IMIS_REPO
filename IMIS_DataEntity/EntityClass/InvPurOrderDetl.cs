using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvPurOrderDetl
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int? PurMstId { get; set; }
        public int? ItemId { get; set; }
        public int? UnitId { get; set; }
        public int? SpecId { get; set; }
        public int? BrandId { get; set; }
        public int? ItemType { get; set; }
        public float? Qty { get; set; }
        public float? ItemRate { get; set; }
        public float? TotalAmt { get; set; }
        public float? TaxAmt { get; set; }
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
