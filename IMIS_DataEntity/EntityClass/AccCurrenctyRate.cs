using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class AccCurrenctyRate
    {
        public int Id { get; set; }
        public int? CurrencyId { get; set; }
        public string NpDate { get; set; }
        public float? Rate { get; set; }

        public virtual AccCurrencty Currency { get; set; }
    }
}
