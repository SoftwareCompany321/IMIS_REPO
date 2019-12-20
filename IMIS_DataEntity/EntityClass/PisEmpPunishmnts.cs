using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisEmpPunishmnts
    {
        public int Sn { get; set; }
        public int? EmpId { get; set; }
        public int? LocalPostId { get; set; }
        public string WorkingOffice { get; set; }
        public string PunishType { get; set; }
        public string PunishDate { get; set; }
        public string Remarks { get; set; }

        public virtual PisEmployeeMaster Emp { get; set; }
        public virtual PisLocalPostMaster LocalPost { get; set; }
    }
}
