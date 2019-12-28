using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class Tblfywisempotassrate
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int? Groupid { get; set; }
        public int? Subgroupid { get; set; }
        public int? Rateid { get; set; }
        public string Nepname { get; set; }
        public string Fiscalyear { get; set; }
        public int? Rateperunit { get; set; }
        public int? AreaUpto { get; set; }
        public int? ForEachArea { get; set; }
        public int? EachAreaRate { get; set; }

        public virtual Tblmalpotgroup Group { get; set; }
        public virtual Tblmalpotrates Rate { get; set; }
        public virtual Tblmalpotsubgroup Subgroup { get; set; }
    }
}
