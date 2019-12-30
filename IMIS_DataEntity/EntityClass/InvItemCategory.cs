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

        public int Id { get; set; }

        public string NameNp { get; set; }
        public string NameEn { get; set; }
        public int? ParentId { get; set; }
        public int? GrpLevel { get; set; }
        public int? IsHeader { get; set; }
        public short? Isexp { get; set; }
        public short? Islast { get; set; }
        public string Code { get; set; }
        public int? Unit { get; set; }
        public int? Minl { get; set; }
        public int? Maxl { get; set; }
        public int? Rminl { get; set; }
        public int? Rmaxl { get; set; }
        public decimal? DepreciationPer { get; set; }
        public decimal? DepreciationMin { get; set; }
        public decimal? DepreciationMax { get; set; }
        public string Remarks { get; set; }
        public int? ItemId { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<InvIssueDetail> InvIssueDetail { get; set; }
        public virtual ICollection<InvPurOrderDetl> InvPurOrderDetl { get; set; }
    }
}
