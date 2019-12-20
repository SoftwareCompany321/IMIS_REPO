using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class AccIncomeRate
    {
        public int RateId { get; set; }
        public int? AccId { get; set; }
        public int? Rate { get; set; }
        public string FiscalYear { get; set; }
    }
}
