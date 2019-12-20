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

        public int Id { get; set; }
        public string GrId { get; set; }
        public string GrName { get; set; }
        public float? MarksPerYear { get; set; }
        public string Details { get; set; }

        public virtual ICollection<OrganizationTree> OrganizationTree { get; set; }
    }
}
