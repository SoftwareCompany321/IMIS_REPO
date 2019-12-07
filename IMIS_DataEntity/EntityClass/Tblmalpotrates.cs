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

        public decimal Id { get; set; }
        public decimal? Groupid { get; set; }
        public decimal? Subgroupid { get; set; }
        public string Nepname { get; set; }
        public decimal? Rateperunit { get; set; }
        public string Description { get; set; }
        public decimal? AreaUpto { get; set; }
        public decimal? ForEachArea { get; set; }
        public decimal? EachAreaRate { get; set; }

        public virtual Tblmalpotgroup Group { get; set; }
        public virtual Tblmalpotsubgroup Subgroup { get; set; }
        public virtual ICollection<TblMalpotOtherCharges> TblMalpotOtherCharges { get; set; }
        public virtual ICollection<Tblfywisempotassrate> Tblfywisempotassrate { get; set; }
    }
}
