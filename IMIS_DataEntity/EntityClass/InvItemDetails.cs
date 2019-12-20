using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvItemDetails
    {
        public int ItemDtlId { get; set; }
        public int ItemId { get; set; }
        public int BrandId { get; set; }
        public int SpecId { get; set; }
        public float? Qty { get; set; }
        public float? ItemRate { get; set; }
        public string ItemStatus { get; set; }
        public string BudgetYear { get; set; }
        public int? DakhilaId { get; set; }
        public string EntryDt { get; set; }
        public int? IssueId { get; set; }
        public string IssueDt { get; set; }
        public int? GdAdjId { get; set; }
        public int? AdjType { get; set; }
        public int? LilamId { get; set; }
        public string LilamDt { get; set; }
        public int? StokRtId { get; set; }
        public string StokRtDt { get; set; }
        public string EngineNo { get; set; }
        public string ChasisNo { get; set; }
        public string ModelNo { get; set; }
        public string RegNo { get; set; }
        public int? WeightVeh { get; set; }
        public int? PrepBy { get; set; }
        public string PrepDt { get; set; }
        public int? CheckBy { get; set; }
        public string CheckDt { get; set; }
        public int? AcceptBy { get; set; }
        public string AcceptDt { get; set; }
        public int? Unit { get; set; }
        public string RelUnit { get; set; }
        public float? RelQty { get; set; }

        public virtual PisEmployeeMaster AcceptByNavigation { get; set; }
        public virtual InvBrand Brand { get; set; }
        public virtual PisEmployeeMaster CheckByNavigation { get; set; }
        public virtual InvGoodsRecMast Dakhila { get; set; }
        public virtual InvGoodsAdjust GdAdj { get; set; }
        public virtual InvItemMst Item { get; set; }
        public virtual PisEmployeeMaster PrepByNavigation { get; set; }
        public virtual InvItemSpec Spec { get; set; }
    }
}
