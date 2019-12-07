using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvLilamDetail
    {
        public decimal Id { get; set; }
        public double? Minimumrate { get; set; }
        public decimal? LilamId { get; set; }
        public decimal? Dakhilaid { get; set; }
        public decimal? Nikashaid { get; set; }
        public decimal? ItemId { get; set; }
        public decimal? UnitId { get; set; }
        public decimal? SpecId { get; set; }
        public decimal? BrandId { get; set; }
        public decimal? ItemType { get; set; }
        public double? ItemIssueNo { get; set; }
        public double? TotalInStock { get; set; }
        public double? DepAmt { get; set; }
        public string IssueDt { get; set; }
        public string DeliveryStatus { get; set; }
        public string Remarks { get; set; }
        public DateTime? IssueDtEng { get; set; }
    }
}
