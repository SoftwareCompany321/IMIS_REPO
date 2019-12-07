using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class AccIncomeRate
    {
        public decimal RateId { get; set; }
        public decimal? AccId { get; set; }
        public decimal? Rate { get; set; }
        public string FiscalYear { get; set; }
    }
}
