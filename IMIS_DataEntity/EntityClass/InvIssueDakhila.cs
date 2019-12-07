using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvIssueDakhila
    {
        public decimal Id { get; set; }
        public decimal? ItemId { get; set; }
        public decimal? SpecId { get; set; }
        public decimal? BrandId { get; set; }
        public decimal? UnitId { get; set; }
        public decimal? IssueDetailId { get; set; }
        public decimal? IssuMasterId { get; set; }
        public decimal? DakhilaId { get; set; }
        public double? IssueNo { get; set; }
        public string Remarks { get; set; }
    }
}
