using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class Tblmalpotrates
    {
        public Tblmalpotrates()
        {
            TblMalpotOtherCharges = new HashSet<TblMalpotOtherCharges>();
            Tblfywisempotassrate = new HashSet<Tblfywisempotassrate>();
        }

        public int Id { get; set; }
        public int? Groupid { get; set; }
        public int? Subgroupid { get; set; }
        public string Nepname { get; set; }
        public int? Rateperunit { get; set; }
        public string Description { get; set; }
        public int? AreaUpto { get; set; }
        public int? ForEachArea { get; set; }
        public int? EachAreaRate { get; set; }

        public virtual Tblmalpotgroup Group { get; set; }
        public virtual Tblmalpotsubgroup Subgroup { get; set; }
        public virtual ICollection<TblMalpotOtherCharges> TblMalpotOtherCharges { get; set; }
        public virtual ICollection<Tblfywisempotassrate> Tblfywisempotassrate { get; set; }
    }
}
