using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvTaxRate
    {
        public int TaxRateId { get; set; }
        public string Code { get; set; }
        public string NameNp { get; set; }
        public string NameEn { get; set; }
        public float TaxRate { get; set; }
    }
}
