using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisOtherAddSub
    {
        public decimal Id { get; set; }
        public decimal? AccId { get; set; }
        public decimal? LocalPostId { get; set; }
        public double? Amount { get; set; }
        public string AddSub { get; set; }
        public string Description { get; set; }

        public virtual PisLocalPostMaster LocalPost { get; set; }
    }
}
