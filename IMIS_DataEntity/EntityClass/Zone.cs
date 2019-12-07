using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class Zone
    {
        public decimal? Zoneid { get; set; }
        public string Nepname { get; set; }
        public string Engname { get; set; }
        public string Code { get; set; }
        public string Remarks { get; set; }
        public decimal? Regionid { get; set; }
    }
}
