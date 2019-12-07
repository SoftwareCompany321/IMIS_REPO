using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvPurType
    {
        public decimal? Id { get; set; }
        public string NepName { get; set; }
        public string NepEng { get; set; }
        public string Remarks { get; set; }
        public string Isdefault { get; set; }
    }
}
