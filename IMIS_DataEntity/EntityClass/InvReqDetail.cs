using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvReqDetail
    {
        public decimal Id { get; set; }
        public decimal? ReqMastId { get; set; }
        public decimal? ItemId { get; set; }
        public decimal? SpecId { get; set; }
        public decimal? BrandId { get; set; }
        public double? Qty { get; set; }
        public string Remarks { get; set; }
        public string IsActive { get; set; }

        public virtual InvBrand Brand { get; set; }
        public virtual InvItemMst Item { get; set; }
        public virtual InvRequisitionMast ReqMast { get; set; }
        public virtual InvItemSpec Spec { get; set; }
    }
}
