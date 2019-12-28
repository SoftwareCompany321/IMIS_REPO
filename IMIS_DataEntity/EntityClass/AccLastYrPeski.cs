using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class AccLastYrPeski
    {
        public int Sn { get; set; }
        public string Code { get; set; }
        public int? PersonTypeId { get; set; }
        public int? PersonId { get; set; }
        public string AdvanceType { get; set; }
        public int? SubModuleId { get; set; }
        public float? TotalPesRem { get; set; }
    }
}
