using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class TblbusinessServiceChMst
    {
        public int Id { get; set; }
        public int? Rateid { get; set; }
        public int? Accode { get; set; }
        public int? AccId { get; set; }
        public float? Servicechargepercent { get; set; }
        public float? Flatchargerate { get; set; }
        public string FiscalYear { get; set; }

        public virtual AccAccMaster Acc { get; set; }
    }
}
