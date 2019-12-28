using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvReqDetail
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int? ReqMastId { get; set; }
        public int? ItemId { get; set; }
        public int? SpecId { get; set; }
        public int? BrandId { get; set; }
        public float? Qty { get; set; }
        public string Remarks { get; set; }
        public bool IsActive { get; set; }

        public virtual InvBrand Brand { get; set; }
        public virtual InvItemMst Item { get; set; }
        public virtual InvRequisitionMast ReqMast { get; set; }
        public virtual InvItemSpec Spec { get; set; }
    }
}
