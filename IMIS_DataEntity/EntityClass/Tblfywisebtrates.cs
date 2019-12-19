using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class Tblfywisebtrates
    {
        public int? Id { get; set; }
        public int? Groupid { get; set; }
        public int? Subgroupid { get; set; }
        public int? Snsubgroup { get; set; }
        public int? Rateid { get; set; }
        public string Nepname { get; set; }
        public string Description { get; set; }
        public string Fiscalyear { get; set; }
        public int? Rateperunit { get; set; }
    }
}
