using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvItemCategory
    {
        public InvItemCategory()
        {
            InvIssueDetail = new HashSet<InvIssueDetail>();
            InvPurOrderDetl = new HashSet<InvPurOrderDetl>();
        }

        public decimal Id { get; set; }
        public string NameNp { get; set; }
        public string NameEn { get; set; }
        public decimal? ParentId { get; set; }
        public decimal? GrpLevel { get; set; }
        public decimal? IsHeader { get; set; }
        public short? Isexp { get; set; }
        public short? Islast { get; set; }
        public string Code { get; set; }
        public decimal? Unit { get; set; }
        public decimal? Minl { get; set; }
        public decimal? Maxl { get; set; }
        public decimal? Rminl { get; set; }
        public decimal? Rmaxl { get; set; }
        public double? DepreciationPer { get; set; }
        public double? DepreciationMin { get; set; }
        public double? DepreciationMax { get; set; }
        public string Remarks { get; set; }
        public decimal? ItemId { get; set; }

        public virtual ICollection<InvIssueDetail> InvIssueDetail { get; set; }
        public virtual ICollection<InvPurOrderDetl> InvPurOrderDetl { get; set; }
    }
}
