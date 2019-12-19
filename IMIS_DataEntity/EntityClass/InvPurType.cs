using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvPurType
    {
        public int Id { get; set; }
        public string NepName { get; set; }
        public string NepEng { get; set; }
        public string Remarks { get; set; }
        public char? Isdefault { get; set; }
    }
}
