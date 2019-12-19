using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisEmpSrvcDtls
    {
        public int Sn { get; set; }
        public int? EmpId { get; set; }
        public int? LocalPostId { get; set; }
        public string OfficeDetail { get; set; }
        public int? GeoRegion { get; set; }
        public int? AppointmentType { get; set; }
        public string DateFrom { get; set; }
        public string DateTo { get; set; }
        public string Remarks { get; set; }

        public virtual PisEmployeeMaster Emp { get; set; }
        public virtual PisLocalPostMaster LocalPost { get; set; }
    }
}
