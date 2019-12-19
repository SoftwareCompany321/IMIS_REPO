using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class AccBankTrans
    {
        public int BankTransId { get; set; }
        public int? VchrId { get; set; }
        public string VchrDateNep { get; set; }
        public string Description { get; set; }
        public float? DrAmt { get; set; }
        public float? CrAmt { get; set; }
        public string IsOfLastyear { get; set; }
        public int? TransTypeId { get; set; }
        public int? BillId { get; set; }
        public int? BankId { get; set; }

        public virtual Bankmaster Bank { get; set; }
        public virtual Incomebillmaster Bill { get; set; }
        public virtual AccVchrMaster Vchr { get; set; }
    }
}
