using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisInternalTransfer
    {
        public decimal Sn { get; set; }
        public decimal? EmpId { get; set; }
        public decimal? OfficeId { get; set; }
        public decimal? DarbandiId { get; set; }
        public string DateFrom { get; set; }
        public string DateTo { get; set; }
        public decimal? AppointmntType { get; set; }
        public string DateOfDecision { get; set; }
        public string DecisionReference { get; set; }
        public string Remarks { get; set; }
        public decimal? ToOfficeId { get; set; }
        public decimal? ToLocalPostId { get; set; }
        public decimal? ToAppointmntType { get; set; }
        public decimal? ReplacedEmpId { get; set; }

        public virtual PisAppointmentType AppointmntTypeNavigation { get; set; }
        public virtual PisDarbandi Darbandi { get; set; }
        public virtual PisEmployeeMaster Emp { get; set; }
        public virtual OrganizationTree Office { get; set; }
        public virtual PisAppointmentType ToAppointmntTypeNavigation { get; set; }
        public virtual PisLocalPostMaster ToLocalPost { get; set; }
        public virtual OrganizationTree ToOffice { get; set; }
    }
}
