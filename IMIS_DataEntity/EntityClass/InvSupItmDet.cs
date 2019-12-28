using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvSupItmDet
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int? ItemId { get; set; }
        public int? SupId { get; set; }
        public int? Qty { get; set; }
        public int? Rate { get; set; }
        public int? AccId { get; set; }
        public string FiscalYear { get; set; }
    }
}
