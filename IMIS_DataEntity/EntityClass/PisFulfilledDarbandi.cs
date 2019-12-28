using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisFulfilledDarbandi
    {
        public PisFulfilledDarbandi()
        {
            PisDeletdFrmFulfildDarbFrmSnInFdNavigation = new HashSet<PisDeletdFrmFulfildDarb>();
            PisDeletdFrmFulfildDarbToSnInFdNavigation = new HashSet<PisDeletdFrmFulfildDarb>();
            PisReplacedInDarbandi = new HashSet<PisReplacedInDarbandi>();
        }

        public int Sn { get; set; }
        public string Code { get; set; }
        public int? OfficeId { get; set; }
        public int? DarbandiId { get; set; }
        public int? PersonTypeId { get; set; }
        public int? EmpId { get; set; }
        public string DateFulfilled { get; set; }
        public int? AppointmntType { get; set; }
        public int? LocalPostId { get; set; }

        public virtual PisDarbandi Darbandi { get; set; }
        public virtual PisLocalPostMaster LocalPost { get; set; }
        public virtual OrganizationTree Office { get; set; }
        public virtual ICollection<PisDeletdFrmFulfildDarb> PisDeletdFrmFulfildDarbFrmSnInFdNavigation { get; set; }
        public virtual ICollection<PisDeletdFrmFulfildDarb> PisDeletdFrmFulfildDarbToSnInFdNavigation { get; set; }
        public virtual ICollection<PisReplacedInDarbandi> PisReplacedInDarbandi { get; set; }
    }
}
