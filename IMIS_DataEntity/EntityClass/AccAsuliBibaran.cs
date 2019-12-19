using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class AccAsuliBibaran
    {
        public int AsuliId { get; set; }
        public int? PersonTypeId { get; set; }
        public int? PaymentPersonId { get; set; }
        public string PersonName { get; set; }
        public string WorkName { get; set; }
        public float? AmtTaken { get; set; }
        public string ResponsiveTaken { get; set; }
        public string CollectReason { get; set; }
        public float? PeskiAmt { get; set; }
        public int? PeskiEmployeeId { get; set; }
        public string PropertyDetails { get; set; }
        public int? PropertyEmployeeId { get; set; }
        public string PropertyRoka { get; set; }

        public virtual PersonTypeMaster PersonType { get; set; }
    }
}
