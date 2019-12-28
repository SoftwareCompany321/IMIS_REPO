using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class AccCashTrans
    {
        public int CashTransId { get; set; }

        public string Code { get; set; }
        public int? VchrId { get; set; }
        public string VchrDateNep { get; set; }
        public string Description { get; set; }
        public float? DrAmt { get; set; }
        public float? CrAmt { get; set; }
        public string IsOfLastyear { get; set; }
        public int? IncomeExpTypeId { get; set; }
        public int? BillId { get; set; }

        public virtual Incomebillmaster Bill { get; set; }
        public virtual AccVchrMaster Vchr { get; set; }
    }
}
