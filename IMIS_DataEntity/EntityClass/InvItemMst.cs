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

        public int ItemId { get; set; }
        public string NameNp { get; set; }
        public string NameEn { get; set; }
        public int? UnitId { get; set; }
        public int? ItemMainClass { get; set; }
        public int? ItemType { get; set; }
        public int? ItemNature { get; set; }
        public int? Maxl { get; set; }
        public int? Minl { get; set; }
        public int? Rmaxl { get; set; }
        public int? Rminl { get; set; }
        public int? Gussage { get; set; }
        public int? Sizes { get; set; }
        public int? Countryid { get; set; }
        public string Companyname { get; set; }
        public string Source { get; set; }
        public string Remarks { get; set; }
        public string Code { get; set; }
        public string KittaNo { get; set; }
        public string LandLocation { get; set; }
        public string Constructontype { get; set; }
        public float? Depreciation { get; set; }
        public float? Minrate { get; set; }
        public float? Depmaxrate { get; set; }
        public int? Propertytype { get; set; }
        public int? LandAreaInsqFeets { get; set; }
        public int? AreaInsqFeets { get; set; }
        public int? LandUnitRate { get; set; }
        public int? LandMarketRate { get; set; }
        public int? Landid { get; set; }
        public int? AccId { get; set; }
        public int? BudgetAccId { get; set; }
        public int? VehiclePartsId { get; set; }

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
