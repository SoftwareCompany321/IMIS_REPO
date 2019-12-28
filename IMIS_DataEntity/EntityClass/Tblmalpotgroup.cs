using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class Tblmalpotgroup
    {
        public Tblmalpotgroup()
        {
            Tblfywisempotassrate = new HashSet<Tblfywisempotassrate>();
            Tblmalpotrates = new HashSet<Tblmalpotrates>();
            Tblmalpotsubgroup = new HashSet<Tblmalpotsubgroup>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Nepname { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Tblfywisempotassrate> Tblfywisempotassrate { get; set; }
        public virtual ICollection<Tblmalpotrates> Tblmalpotrates { get; set; }
        public virtual ICollection<Tblmalpotsubgroup> Tblmalpotsubgroup { get; set; }
    }
}
