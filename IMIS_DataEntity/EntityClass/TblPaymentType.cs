using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class TblPaymentType
    {
        public decimal Id { get; set; }
        public string PaymentType { get; set; }
        public string PaymentTypeEng { get; set; }
        public string Remarks { get; set; }
    }
}
