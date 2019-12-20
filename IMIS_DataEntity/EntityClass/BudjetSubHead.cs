using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class BudjetSubHead
    {
        public int? Id { get; set; }
        public string Code { get; set; }
        public int? MinistryId { get; set; }
        public string MinistryCode { get; set; }
        public int? ParentCode { get; set; }
        public string FiscalYear { get; set; }
        public string Nepname { get; set; }
        public string Engname { get; set; }
        public string Remarks { get; set; }
    }
}
