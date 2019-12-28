using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class Firebrigadestate
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Nepname { get; set; }
        public int? Servicechargerate { get; set; }
        public int? Minimumservicecharge { get; set; }
        public int? AccId { get; set; }
        public short? Type { get; set; }
        public string FiscalYear { get; set; }
        public int? Rateid { get; set; }

        public virtual AccAccMaster Acc { get; set; }
    }
}
