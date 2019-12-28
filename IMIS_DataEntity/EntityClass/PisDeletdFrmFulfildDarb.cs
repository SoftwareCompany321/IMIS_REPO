using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisDeletdFrmFulfildDarb
    {
        public int Sn { get; set; }
        public string Code { get; set; }
        public int? EmpId { get; set; }
        public int? FrmSnInFd { get; set; }
        public int? FrmOfficeId { get; set; }
        public int? FrmDarbandiId { get; set; }
        public string FrmDateFulfilled { get; set; }
        public int? FrmAppointmntType { get; set; }
        public int? ToSnInFd { get; set; }

        public virtual PisDarbandi FrmDarbandi { get; set; }
        public virtual OrganizationTree FrmOffice { get; set; }
        public virtual PisFulfilledDarbandi FrmSnInFdNavigation { get; set; }
        public virtual PisFulfilledDarbandi ToSnInFdNavigation { get; set; }
    }
}
