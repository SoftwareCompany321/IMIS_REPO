using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvSupplierFiscalyear
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int? SupId { get; set; }
        public string FiscalYear { get; set; }
        public bool IsActive { get; set; }
    }
}
