using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisInternalTransfer
    {
        public int Sn { get; set; }
        public string Code { get; set; }
        public int? EmpId { get; set; }
        public int? OfficeId { get; set; }
        public int? DarbandiId { get; set; }
        public string DateFrom { get; set; }
        public string DateTo { get; set; }
        public int? AppointmntType { get; set; }
        public string DateOfDecision { get; set; }
        public string DecisionReference { get; set; }
        public string Remarks { get; set; }
        public int? ToOfficeId { get; set; }
        public int? ToLocalPostId { get; set; }
        public int? ToAppointmntType { get; set; }
        public int? ReplacedEmpId { get; set; }

        public virtual PisAppointmentType AppointmntTypeNavigation { get; set; }
        public virtual PisDarbandi Darbandi { get; set; }
        public virtual PisEmployeeMaster Emp { get; set; }
        public virtual OrganizationTree Office { get; set; }
        public virtual PisAppointmentType ToAppointmntTypeNavigation { get; set; }
        public virtual PisLocalPostMaster ToLocalPost { get; set; }
        public virtual OrganizationTree ToOffice { get; set; }
    }
}
