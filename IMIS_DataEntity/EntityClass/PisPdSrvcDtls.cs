using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisPdSrvcDtls
    {
        public int Sn { get; set; }
        public int? EmpId { get; set; }
        public int? LocalPostId { get; set; }
        public string AppointmntLevel { get; set; }
        public int? AppointmntType { get; set; }
        public string OfficeDetail { get; set; }
        public string DateFrom { get; set; }
        public string DateTo { get; set; }
        public string Remarks { get; set; }
    }
}
