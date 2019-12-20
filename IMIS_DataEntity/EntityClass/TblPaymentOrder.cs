using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class TblPaymentOrder
    {
        public TblPaymentOrder()
        {
            TblPaymentOrderDetails = new HashSet<TblPaymentOrderDetails>();
        }

        public int Id { get; set; }
        public string OrderCode { get; set; }
        public string DateBs { get; set; }
        public string TokenNo { get; set; }
        public string Remarks { get; set; }

        public virtual ICollection<TblPaymentOrderDetails> TblPaymentOrderDetails { get; set; }
    }
}
