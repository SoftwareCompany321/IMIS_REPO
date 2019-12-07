using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class TblPaymentOrderDetails
    {
        public decimal Id { get; set; }
        public decimal? PaymentOrderId { get; set; }
        public decimal? VoucherId { get; set; }
        public decimal? LinkVoucherId { get; set; }
        public string PaymentPermissNo { get; set; }

        public virtual TblPaymentOrder PaymentOrder { get; set; }
    }
}
