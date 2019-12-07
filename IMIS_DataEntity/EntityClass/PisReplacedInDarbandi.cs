using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisReplacedInDarbandi
    {
        public decimal Sn { get; set; }
        public decimal? EmpId { get; set; }
        public decimal? EntrySnInFd { get; set; }
        public decimal? OfficeId { get; set; }
        public decimal? DarbandiId { get; set; }
        public string DateFulfilled { get; set; }
        public decimal? AppointmntType { get; set; }
        public decimal? ReplacedBy { get; set; }
        public string DateReplaced { get; set; }
        public string DateOfDecision { get; set; }
        public string DecisionReference { get; set; }
        public decimal? IsPlacedInDarbandi { get; set; }
        public string Remarks { get; set; }

        public virtual PisDarbandi Darbandi { get; set; }
        public virtual PisFulfilledDarbandi EntrySnInFdNavigation { get; set; }
        public virtual OrganizationTree Office { get; set; }
    }
}
