using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class Landmeasuringunits
    {
        public int Unitid { get; set; }
        public string Code { get; set; }
        public string Unitname { get; set; }
        public int? Sqftperunit { get; set; }
    }
}
