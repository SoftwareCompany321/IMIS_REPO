using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvIssueDakhila
    {
        public int Id { get; set; }
        public int? ItemId { get; set; }
        public int? SpecId { get; set; }
        public int? BrandId { get; set; }
        public int? UnitId { get; set; }
        public int? IssueDetailId { get; set; }
        public int? IssuMasterId { get; set; }
        public int? DakhilaId { get; set; }
        public float? IssueNo { get; set; }
        public string Remarks { get; set; }
    }
}
