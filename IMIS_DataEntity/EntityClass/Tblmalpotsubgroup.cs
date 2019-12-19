using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class Tblmalpotsubgroup
    {
        public Tblmalpotsubgroup()
        {
            Tblfywisempotassrate = new HashSet<Tblfywisempotassrate>();
            Tblmalpotrates = new HashSet<Tblmalpotrates>();
        }

        public int Id { get; set; }
        public int? Groupid { get; set; }
        public string Nepname { get; set; }
        public string Description { get; set; }
        public int? Worda { get; set; }

        public virtual Tblmalpotgroup Group { get; set; }
        public virtual ICollection<Tblfywisempotassrate> Tblfywisempotassrate { get; set; }
        public virtual ICollection<Tblmalpotrates> Tblmalpotrates { get; set; }
    }
}
