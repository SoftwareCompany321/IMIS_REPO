using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvItemDetails
    {
        public decimal ItemDtlId { get; set; }
        public decimal ItemId { get; set; }
        public decimal BrandId { get; set; }
        public decimal SpecId { get; set; }
        public double? Qty { get; set; }
        public double? ItemRate { get; set; }
        public string ItemStatus { get; set; }
        public string BudgetYear { get; set; }
        public decimal? DakhilaId { get; set; }
        public string EntryDt { get; set; }
        public decimal? IssueId { get; set; }
        public string IssueDt { get; set; }
        public decimal? GdAdjId { get; set; }
        public decimal? AdjType { get; set; }
        public decimal? LilamId { get; set; }
        public string LilamDt { get; set; }
        public decimal? StokRtId { get; set; }
        public string StokRtDt { get; set; }
        public string EngineNo { get; set; }
        public string ChasisNo { get; set; }
        public string ModelNo { get; set; }
        public string RegNo { get; set; }
        public decimal? WeightVeh { get; set; }
        public decimal? PrepBy { get; set; }
        public string PrepDt { get; set; }
        public decimal? CheckBy { get; set; }
        public string CheckDt { get; set; }
        public decimal? AcceptBy { get; set; }
        public string AcceptDt { get; set; }
        public decimal? Unit { get; set; }
        public string RelUnit { get; set; }
        public double? RelQty { get; set; }

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
