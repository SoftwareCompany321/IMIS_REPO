using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvItemSpec
    {
        public InvItemSpec()
        {
            InvGoodsAdjust = new HashSet<InvGoodsAdjust>();
            InvGoodsRecDetl = new HashSet<InvGoodsRecDetl>();
            InvIssueDetail = new HashSet<InvIssueDetail>();
            InvItemDetails = new HashSet<InvItemDetails>();
            InvItemStatuscheck = new HashSet<InvItemStatuscheck>();
            InvPurOrderDetl = new HashSet<InvPurOrderDetl>();
            InvReqDetail = new HashSet<InvReqDetail>();
        }

        public int SpecId { get; set; }
        public string Code { get; set; }
        public string NameNp { get; set; }
        public string NameEn { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<InvGoodsAdjust> InvGoodsAdjust { get; set; }
        public virtual ICollection<InvGoodsRecDetl> InvGoodsRecDetl { get; set; }
        public virtual ICollection<InvIssueDetail> InvIssueDetail { get; set; }
        public virtual ICollection<InvItemDetails> InvItemDetails { get; set; }
        public virtual ICollection<InvItemStatuscheck> InvItemStatuscheck { get; set; }
        public virtual ICollection<InvPurOrderDetl> InvPurOrderDetl { get; set; }
        public virtual ICollection<InvReqDetail> InvReqDetail { get; set; }
    }
}
