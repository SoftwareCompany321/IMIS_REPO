using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class OrganizationTree
    {
        public OrganizationTree()
        {
            InverseParent = new HashSet<OrganizationTree>();
            PisDarbandi = new HashSet<PisDarbandi>();
            PisDeletdFrmFulfildDarb = new HashSet<PisDeletdFrmFulfildDarb>();
            PisFulfilledDarbandi = new HashSet<PisFulfilledDarbandi>();
            PisInternalTransferOffice = new HashSet<PisInternalTransfer>();
            PisInternalTransferToOffice = new HashSet<PisInternalTransfer>();
            PisReplacedInDarbandi = new HashSet<PisReplacedInDarbandi>();
        }

        public decimal Id { get; set; }
        public decimal? ParentId { get; set; }
        public string NepName { get; set; }
        public string EngName { get; set; }
        public decimal? ContainsDarbandi { get; set; }
        public decimal? GeoRegion { get; set; }
        public int? GrpLevel { get; set; }

        public virtual PisGeoRegion GeoRegionNavigation { get; set; }
        public virtual OrganizationTree Parent { get; set; }
        public virtual ICollection<OrganizationTree> InverseParent { get; set; }
        public virtual ICollection<PisDarbandi> PisDarbandi { get; set; }
        public virtual ICollection<PisDeletdFrmFulfildDarb> PisDeletdFrmFulfildDarb { get; set; }
        public virtual ICollection<PisFulfilledDarbandi> PisFulfilledDarbandi { get; set; }
        public virtual ICollection<PisInternalTransfer> PisInternalTransferOffice { get; set; }
        public virtual ICollection<PisInternalTransfer> PisInternalTransferToOffice { get; set; }
        public virtual ICollection<PisReplacedInDarbandi> PisReplacedInDarbandi { get; set; }
    }
}
