using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class AccCurrencty
    {
        public AccCurrencty()
        {
            AccCurrenctyRate = new HashSet<AccCurrenctyRate>();
        }

        public int Id { get; set; }

        public string Code { get; set; }
        public string NpName { get; set; }
        public string EngName { get; set; }
        public string Symbol { get; set; }

        public virtual ICollection<AccCurrenctyRate> AccCurrenctyRate { get; set; }
    }
}
