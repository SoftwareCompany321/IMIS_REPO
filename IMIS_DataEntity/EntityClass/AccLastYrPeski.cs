using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class AccLastYrPeski
    {
        public decimal Sn { get; set; }
        public decimal? PersonTypeId { get; set; }
        public decimal? PersonId { get; set; }
        public string AdvanceType { get; set; }
        public decimal? SubModuleId { get; set; }
        public double? TotalPesRem { get; set; }
    }
}
