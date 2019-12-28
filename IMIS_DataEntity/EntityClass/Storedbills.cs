using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class Storedbills
    {
        public Storedbills()
        {
            TaxThliIssuedCntr = new HashSet<TaxThliIssuedCntr>();
        }

        public int Sn { get; set; } 
        public string Dateissued { get; set; }
        public string Description { get; set; }
        public string Billnofrom { get; set; }
        public string Billnoto { get; set; }
        public int? Code { get; set; }
        public int? Billtypeid { get; set; }

        public virtual Tblbilltype Billtype { get; set; }
        public virtual ICollection<TaxThliIssuedCntr> TaxThliIssuedCntr { get; set; }
    }
}
