using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisEmpLongLeaves
    {
        public decimal Sn { get; set; }
        public decimal? EmpId { get; set; }
        public decimal? LocalPostId { get; set; }
        public string LeaveName { get; set; }
        public string WorkingOffice { get; set; }
        public string FromDateVs { get; set; }
        public string ToDateVs { get; set; }
        public string Remarks { get; set; }

        public virtual PisEmployeeMaster Emp { get; set; }
        public virtual PisLocalPostMaster LocalPost { get; set; }
    }
}
