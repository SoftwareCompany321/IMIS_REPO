using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvIssueDetail
    {
        public int Id { get; set; }
        public int? IssueMastId { get; set; }
        public int? ItemId { get; set; }
        public int? SpecId { get; set; }
        public int? BrandId { get; set; }
        public int? ItemType { get; set; }
        public float? ItemReqNo { get; set; }
        public float? ItemIssueNo { get; set; }
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
