using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class SanitationGroup
    {
        public SanitationGroup()
        {
            SanitationRate = new HashSet<SanitationRate>();
            SanitationSubgroup = new HashSet<SanitationSubgroup>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Groupname { get; set; }

        public virtual ICollection<SanitationRate> SanitationRate { get; set; }
        public virtual ICollection<SanitationSubgroup> SanitationSubgroup { get; set; }
    }
}
