using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class Tblfywisempotassrate
    {
        public decimal Id { get; set; }
        public decimal? Groupid { get; set; }
        public decimal? Subgroupid { get; set; }
        public decimal? Rateid { get; set; }
        public string Nepname { get; set; }
        public string Fiscalyear { get; set; }
        public decimal? Rateperunit { get; set; }
        public decimal? AreaUpto { get; set; }
        public decimal? ForEachArea { get; set; }
        public decimal? EachAreaRate { get; set; }

        public virtual Tblmalpotgroup Group { get; set; }
        public virtual Tblmalpotrates Rate { get; set; }
        public virtual Tblmalpotsubgroup Subgroup { get; set; }
    }
}
