using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class AccWorkPaymntTrans
    {
        public decimal TransId { get; set; }
        public decimal? WorkId { get; set; }
        public decimal? PaymentSlipId { get; set; }
        public decimal? PersonTypeId { get; set; }
        public decimal? EmpId { get; set; }
        public decimal? PadadhikariId { get; set; }
        public decimal? OrgId { get; set; }
        public decimal? UcId { get; set; }
        public double? BillAmt { get; set; }
        public double? VatAmt { get; set; }
        public decimal? VchrId { get; set; }
        public string VchrDateNp { get; set; }
        public string IsOfLastYear { get; set; }
        public string FiscalYear { get; set; }

        public virtual PersonTypeMaster PersonType { get; set; }
        public virtual AccVchrMaster Vchr { get; set; }
        public virtual AccWorkMaster Work { get; set; }
    }
}
