using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class AccBankTrans
    {
        public decimal BankTransId { get; set; }
        public decimal? VchrId { get; set; }
        public string VchrDateNep { get; set; }
        public string Description { get; set; }
        public double? DrAmt { get; set; }
        public double? CrAmt { get; set; }
        public string IsOfLastyear { get; set; }
        public decimal? TransTypeId { get; set; }
        public decimal? BillId { get; set; }
        public decimal? BankId { get; set; }

        public virtual Bankmaster Bank { get; set; }
        public virtual Incomebillmaster Bill { get; set; }
        public virtual AccVchrMaster Vchr { get; set; }
    }
}
