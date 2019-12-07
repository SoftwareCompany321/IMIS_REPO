using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class AccCurrenctyRate
    {
        public decimal Id { get; set; }
        public decimal? CurrencyId { get; set; }
        public string NpDate { get; set; }
        public double? Rate { get; set; }

        public virtual AccCurrencty Currency { get; set; }
    }
}
