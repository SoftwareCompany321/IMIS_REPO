using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class AccCashTrans
    {
        public decimal CashTransId { get; set; }
        public decimal? VchrId { get; set; }
        public string VchrDateNep { get; set; }
        public string Description { get; set; }
        public double? DrAmt { get; set; }
        public double? CrAmt { get; set; }
        public string IsOfLastyear { get; set; }
        public decimal? IncomeExpTypeId { get; set; }
        public decimal? BillId { get; set; }

        public virtual Incomebillmaster Bill { get; set; }
        public virtual AccVchrMaster Vchr { get; set; }
    }
}
