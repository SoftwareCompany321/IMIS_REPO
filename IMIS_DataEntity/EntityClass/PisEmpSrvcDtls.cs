﻿using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisEmpSrvcDtls
    {
        public decimal Sn { get; set; }
        public decimal? EmpId { get; set; }
        public decimal? LocalPostId { get; set; }
        public string OfficeDetail { get; set; }
        public decimal? GeoRegion { get; set; }
        public decimal? AppointmentType { get; set; }
        public string DateFrom { get; set; }
        public string DateTo { get; set; }
        public string Remarks { get; set; }

        public virtual PisEmployeeMaster Emp { get; set; }
        public virtual PisLocalPostMaster LocalPost { get; set; }
    }
}
