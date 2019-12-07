using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvTaxRate
    {
        public decimal TaxRateId { get; set; }
        public string NameNp { get; set; }
        public string NameEn { get; set; }
        public double TaxRate { get; set; }
    }
}
