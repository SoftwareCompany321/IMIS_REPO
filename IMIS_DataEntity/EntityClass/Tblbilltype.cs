using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class Tblbilltype
    {
        public Tblbilltype()
        {
            AccDhrtiBillMaster = new HashSet<AccDhrtiBillMaster>();
            Incomebillmaster = new HashSet<Incomebillmaster>();
            Storedbills = new HashSet<Storedbills>();
        }

        public int Id { get; set; }
        public string Nepname { get; set; }
        public string Isincome { get; set; }
        public string Description { get; set; }

        public virtual ICollection<AccDhrtiBillMaster> AccDhrtiBillMaster { get; set; }
        public virtual ICollection<Incomebillmaster> Incomebillmaster { get; set; }
        public virtual ICollection<Storedbills> Storedbills { get; set; }
    }
}
