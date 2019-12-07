using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvItemMst
    {
        public InvItemMst()
        {
            InvGoodsAdjust = new HashSet<InvGoodsAdjust>();
            InvGoodsRecDetl = new HashSet<InvGoodsRecDetl>();
            InvIssueDetail = new HashSet<InvIssueDetail>();
            InvItemDetails = new HashSet<InvItemDetails>();
            InvItemStatuscheck = new HashSet<InvItemStatuscheck>();
            InvPurOrderDetl = new HashSet<InvPurOrderDetl>();
            InvReqDetail = new HashSet<InvReqDetail>();
            InvRequisitionMast = new HashSet<InvRequisitionMast>();
        }

        public decimal ItemId { get; set; }
        public string NameNp { get; set; }
        public string NameEn { get; set; }
        public decimal? UnitId { get; set; }
        public decimal? ItemMainClass { get; set; }
        public decimal? ItemType { get; set; }
        public decimal? ItemNature { get; set; }
        public decimal? Maxl { get; set; }
        public decimal? Minl { get; set; }
        public decimal? Rmaxl { get; set; }
        public decimal? Rminl { get; set; }
        public decimal? Gussage { get; set; }
        public decimal? Sizes { get; set; }
        public decimal? Countryid { get; set; }
        public string Companyname { get; set; }
        public string Source { get; set; }
        public string Remarks { get; set; }
        public string Code { get; set; }
        public string KittaNo { get; set; }
        public string LandLocation { get; set; }
        public string Constructontype { get; set; }
        public double? Depreciation { get; set; }
        public double? Minrate { get; set; }
        public double? Depmaxrate { get; set; }
        public decimal? Propertytype { get; set; }
        public decimal? LandAreaInsqFeets { get; set; }
        public decimal? AreaInsqFeets { get; set; }
        public decimal? LandUnitRate { get; set; }
        public decimal? LandMarketRate { get; set; }
        public decimal? Landid { get; set; }
        public decimal? AccId { get; set; }
        public decimal? BudgetAccId { get; set; }
        public decimal? VehiclePartsId { get; set; }

        public virtual InvUnit Unit { get; set; }
        public virtual ICollection<InvGoodsAdjust> InvGoodsAdjust { get; set; }
        public virtual ICollection<InvGoodsRecDetl> InvGoodsRecDetl { get; set; }
        public virtual ICollection<InvIssueDetail> InvIssueDetail { get; set; }
        public virtual ICollection<InvItemDetails> InvItemDetails { get; set; }
        public virtual ICollection<InvItemStatuscheck> InvItemStatuscheck { get; set; }
        public virtual ICollection<InvPurOrderDetl> InvPurOrderDetl { get; set; }
        public virtual ICollection<InvReqDetail> InvReqDetail { get; set; }
        public virtual ICollection<InvRequisitionMast> InvRequisitionMast { get; set; }
    }
}
