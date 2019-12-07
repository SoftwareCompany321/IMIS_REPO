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

        public decimal Sn { get; set; }
        public decimal? OfficeId { get; set; }
        public decimal? DarbandiId { get; set; }
        public decimal? PersonTypeId { get; set; }
        public decimal? EmpId { get; set; }
        public string DateFulfilled { get; set; }
        public decimal? AppointmntType { get; set; }
        public decimal? LocalPostId { get; set; }

        public virtual PisDarbandi Darbandi { get; set; }
        public virtual PisLocalPostMaster LocalPost { get; set; }
        public virtual OrganizationTree Office { get; set; }
        public virtual ICollection<PisDeletdFrmFulfildDarb> PisDeletdFrmFulfildDarbFrmSnInFdNavigation { get; set; }
        public virtual ICollection<PisDeletdFrmFulfildDarb> PisDeletdFrmFulfildDarbToSnInFdNavigation { get; set; }
        public virtual ICollection<PisReplacedInDarbandi> PisReplacedInDarbandi { get; set; }
    }
}
