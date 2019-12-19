using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisDarbandi
    {
        public PisDarbandi()
        {
            PisDeletdFrmFulfildDarb = new HashSet<PisDeletdFrmFulfildDarb>();
            PisFulfilledDarbandi = new HashSet<PisFulfilledDarbandi>();
            PisInternalTransfer = new HashSet<PisInternalTransfer>();
            PisReplacedInDarbandi = new HashSet<PisReplacedInDarbandi>();
        }

        public int DarbandiId { get; set; }
        public int? OfficeId { get; set; }
        public int? PostId { get; set; }
        public int? PostLevel { get; set; }
        public int? LocalPostId { get; set; }
        public string SewaSamuhaUpasamuha { get; set; }
        public int? NoOfPost { get; set; }

        public virtual PisLocalPostMaster LocalPost { get; set; }
        public virtual OrganizationTree Office { get; set; }
        public virtual PisPostMaster Post { get; set; }
        public virtual ICollection<PisDeletdFrmFulfildDarb> PisDeletdFrmFulfildDarb { get; set; }
        public virtual ICollection<PisFulfilledDarbandi> PisFulfilledDarbandi { get; set; }
        public virtual ICollection<PisInternalTransfer> PisInternalTransfer { get; set; }
        public virtual ICollection<PisReplacedInDarbandi> PisReplacedInDarbandi { get; set; }
    }
}
