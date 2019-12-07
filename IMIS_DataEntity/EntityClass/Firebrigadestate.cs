using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class Firebrigadestate
    {
        public decimal Id { get; set; }
        public string Nepname { get; set; }
        public decimal? Servicechargerate { get; set; }
        public decimal? Minimumservicecharge { get; set; }
        public decimal? AccId { get; set; }
        public short? Type { get; set; }
        public string FiscalYear { get; set; }
        public decimal? Rateid { get; set; }

        public virtual AccAccMaster Acc { get; set; }
    }
}
