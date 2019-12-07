using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvSupItmDet
    {
        public decimal Id { get; set; }
        public decimal? ItemId { get; set; }
        public decimal? SupId { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Rate { get; set; }
        public decimal? AccId { get; set; }
        public string FiscalYear { get; set; }
    }
}
