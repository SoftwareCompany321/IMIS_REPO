using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvIssueDetail
    {
        public decimal Id { get; set; }
        public decimal? IssueMastId { get; set; }
        public decimal? ItemId { get; set; }
        public decimal? SpecId { get; set; }
        public decimal? BrandId { get; set; }
        public decimal? ItemType { get; set; }
        public double? ItemReqNo { get; set; }
        public double? ItemIssueNo { get; set; }
        public string IssueDt { get; set; }
        public string DeliveryStatus { get; set; }
        public string Remarks { get; set; }
        public DateTime? IssueDtEng { get; set; }

        public virtual InvBrand Brand { get; set; }
        public virtual InvItemMst Item { get; set; }
        public virtual InvItemCategory ItemTypeNavigation { get; set; }
        public virtual InvItemSpec Spec { get; set; }
    }
}
