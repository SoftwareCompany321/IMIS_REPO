using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class TblPaymentProcess
    {
        public int Id { get; set; }
        public string PaymentProcess { get; set; }
        public string PaymentProcessEng { get; set; }
        public string Remarks { get; set; }
    }
}
