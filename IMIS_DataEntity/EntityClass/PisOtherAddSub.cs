using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisOtherAddSub
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int? AccId { get; set; }
        public int? LocalPostId { get; set; }
        public float? Amount { get; set; }
        public string AddSub { get; set; }
        public string Description { get; set; }

        public virtual PisLocalPostMaster LocalPost { get; set; }
    }
}
