using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class AccWorkPaymntTrans
    {
        public int TransId { get; set; }
        public string Code { get; set; }
        public int? WorkId { get; set; }
        public int? PaymentSlipId { get; set; }
        public int? PersonTypeId { get; set; }
        public int? EmpId { get; set; }
        public int? PadadhikariId { get; set; }
        public int? OrgId { get; set; }
        public int? UcId { get; set; }
        public float? BillAmt { get; set; }
        public float? VatAmt { get; set; }
        public int? VchrId { get; set; }
        public string VchrDateNp { get; set; }
        public string IsOfLastYear { get; set; }
        public string FiscalYear { get; set; }

        public virtual PersonTypeMaster PersonType { get; set; }
        public virtual AccVchrMaster Vchr { get; set; }
        public virtual AccWorkMaster Work { get; set; }
    }
}
