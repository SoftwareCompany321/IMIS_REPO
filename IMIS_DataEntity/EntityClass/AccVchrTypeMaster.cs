using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class AccVchrTypeMaster
    {
        public AccVchrTypeMaster()
        {
            AccVchrDetails = new HashSet<AccVchrDetails>();
            AccVchrMaster = new HashSet<AccVchrMaster>();
        }

        public decimal VchrTypeId { get; set; }
        public string NepName { get; set; }
        public string EngName { get; set; }
        public string Module { get; set; }
        public string Isautomatic { get; set; }
        public string Isfixed { get; set; }

        public virtual ICollection<AccVchrDetails> AccVchrDetails { get; set; }
        public virtual ICollection<AccVchrMaster> AccVchrMaster { get; set; }
    }
}
