using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class Collectioncounters
    {
        public Collectioncounters()
        {
            TaxThliIssuedCntr = new HashSet<TaxThliIssuedCntr>();
        }

        public decimal Counterid { get; set; }
        public string Nepname { get; set; }
        public decimal? Counterheadid { get; set; }
        public decimal? Wardno { get; set; }
        public string Location { get; set; }
        public string Specialnotes { get; set; }
        public string CmptrName { get; set; }
        public string Macaddress { get; set; }

        public virtual ICollection<TaxThliIssuedCntr> TaxThliIssuedCntr { get; set; }
    }
}
