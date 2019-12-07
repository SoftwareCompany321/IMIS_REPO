using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisDeletdFrmFulfildDarb
    {
        public decimal Sn { get; set; }
        public decimal? EmpId { get; set; }
        public decimal? FrmSnInFd { get; set; }
        public decimal? FrmOfficeId { get; set; }
        public decimal? FrmDarbandiId { get; set; }
        public string FrmDateFulfilled { get; set; }
        public decimal? FrmAppointmntType { get; set; }
        public decimal? ToSnInFd { get; set; }

        public virtual PisDarbandi FrmDarbandi { get; set; }
        public virtual OrganizationTree FrmOffice { get; set; }
        public virtual PisFulfilledDarbandi FrmSnInFdNavigation { get; set; }
        public virtual PisFulfilledDarbandi ToSnInFdNavigation { get; set; }
    }
}
