using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class SanitationSubgroup
    {
        public SanitationSubgroup()
        {
            SanitationRate = new HashSet<SanitationRate>();
        }

        public decimal Id { get; set; }
        public decimal? Groupid { get; set; }
        public string Subgroupname { get; set; }
        public string Remarks { get; set; }

        public virtual SanitationGroup Group { get; set; }
        public virtual ICollection<SanitationRate> SanitationRate { get; set; }
    }
}
