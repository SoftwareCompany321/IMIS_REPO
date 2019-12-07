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

        public decimal Sn { get; set; }
        public string Dateissued { get; set; }
        public string Description { get; set; }
        public string Billnofrom { get; set; }
        public string Billnoto { get; set; }
        public decimal? Code { get; set; }
        public decimal? Billtypeid { get; set; }

        public virtual Tblbilltype Billtype { get; set; }
        public virtual ICollection<TaxThliIssuedCntr> TaxThliIssuedCntr { get; set; }
    }
}
