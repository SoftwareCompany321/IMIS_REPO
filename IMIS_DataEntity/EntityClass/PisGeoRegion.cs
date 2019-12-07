using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisGeoRegion
    {
        public PisGeoRegion()
        {
            OrganizationTree = new HashSet<OrganizationTree>();
        }

        public decimal Id { get; set; }
        public string GrId { get; set; }
        public string GrName { get; set; }
        public double? MarksPerYear { get; set; }
        public string Details { get; set; }

        public virtual ICollection<OrganizationTree> OrganizationTree { get; set; }
    }
}
