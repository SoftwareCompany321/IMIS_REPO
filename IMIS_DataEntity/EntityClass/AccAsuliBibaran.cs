using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class AccAsuliBibaran
    {
        public decimal AsuliId { get; set; }
        public decimal? PersonTypeId { get; set; }
        public decimal? PaymentPersonId { get; set; }
        public string PersonName { get; set; }
        public string WorkName { get; set; }
        public double? AmtTaken { get; set; }
        public string ResponsiveTaken { get; set; }
        public string CollectReason { get; set; }
        public double? PeskiAmt { get; set; }
        public decimal? PeskiEmployeeId { get; set; }
        public string PropertyDetails { get; set; }
        public decimal? PropertyEmployeeId { get; set; }
        public string PropertyRoka { get; set; }

        public virtual PersonTypeMaster PersonType { get; set; }
    }
}
