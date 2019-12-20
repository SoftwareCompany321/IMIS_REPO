using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisReplacedInDarbandi
    {
        public int Sn { get; set; }
        public int? EmpId { get; set; }
        public int? EntrySnInFd { get; set; }
        public int? OfficeId { get; set; }
        public int? DarbandiId { get; set; }
        public string DateFulfilled { get; set; }
        public int? AppointmntType { get; set; }
        public int? ReplacedBy { get; set; }
        public string DateReplaced { get; set; }
        public string DateOfDecision { get; set; }
        public string DecisionReference { get; set; }
        public int? IsPlacedInDarbandi { get; set; }
        public string Remarks { get; set; }

        public virtual PisDarbandi Darbandi { get; set; }
        public virtual PisFulfilledDarbandi EntrySnInFdNavigation { get; set; }
        public virtual OrganizationTree Office { get; set; }
    }
}
