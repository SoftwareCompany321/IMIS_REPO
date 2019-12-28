using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class TblPaymentOrderDetails
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int? PaymentOrderId { get; set; }
        public int? VoucherId { get; set; }
        public int? LinkVoucherId { get; set; }
        public string PaymentPermissNo { get; set; }

        public virtual TblPaymentOrder PaymentOrder { get; set; }
    }
}
