using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvLilamDetail
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public float? Minimumrate { get; set; }
        public int? LilamId { get; set; }
        public int? Dakhilaid { get; set; }
        public int? Nikashaid { get; set; }
        public int? ItemId { get; set; }
        public int? UnitId { get; set; }
        public int? SpecId { get; set; }
        public int? BrandId { get; set; }
        public int? ItemType { get; set; }
        public float? ItemIssueNo { get; set; }
        public float? TotalInStock { get; set; }
        public float? DepAmt { get; set; }
        public string IssueDt { get; set; }
        public string DeliveryStatus { get; set; }
        public string Remarks { get; set; }
        public DateTime? IssueDtEng { get; set; }
    }
}
