using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class TblbusinessServiceChMst
    {
        public decimal Id { get; set; }
        public decimal? Rateid { get; set; }
        public decimal? Accode { get; set; }
        public decimal? AccId { get; set; }
        public double? Servicechargepercent { get; set; }
        public double? Flatchargerate { get; set; }
        public string FiscalYear { get; set; }

        public virtual AccAccMaster Acc { get; set; }
    }
}
