using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class TblVehicleParts
    {
        public int Sn { get; set; }
        public string Code { get; set; }
        public string NpName { get; set; }
        public string EngName { get; set; }
        public string Remarks { get; set; }
        public bool IsActive { get; set; }
    }
}
