using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisPdSrvcDtls
    {
        public decimal Sn { get; set; }
        public decimal? EmpId { get; set; }
        public decimal? LocalPostId { get; set; }
        public string AppointmntLevel { get; set; }
        public decimal? AppointmntType { get; set; }
        public string OfficeDetail { get; set; }
        public string DateFrom { get; set; }
        public string DateTo { get; set; }
        public string Remarks { get; set; }
    }
}
