using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class Tblfywisebtrates
    {
        public decimal? Id { get; set; }
        public decimal? Groupid { get; set; }
        public decimal? Subgroupid { get; set; }
        public decimal? Snsubgroup { get; set; }
        public decimal? Rateid { get; set; }
        public string Nepname { get; set; }
        public string Description { get; set; }
        public string Fiscalyear { get; set; }
        public decimal? Rateperunit { get; set; }
    }
}
