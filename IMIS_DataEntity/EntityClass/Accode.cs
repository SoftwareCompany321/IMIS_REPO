using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class Accode
    {
        public Accode()
        {
            TaxAddtnlChrgDtls = new HashSet<TaxAddtnlChrgDtls>();
        }

        public int Accode1 { get; set; }
        public int? Sbcode { get; set; }
        public int? Grcode { get; set; }
        public string Trantype { get; set; }
        public string Nepname { get; set; }
        public string Engname { get; set; }
        public string Isdollar { get; set; }
        public string Localcode { get; set; }
        public string Isassigned { get; set; }

        public virtual ICollection<TaxAddtnlChrgDtls> TaxAddtnlChrgDtls { get; set; }
    }
}
