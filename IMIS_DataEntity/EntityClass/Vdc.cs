using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class Vdc
    {
        public decimal? Vdcid { get; set; }
        public string Nepname { get; set; }
        public string Engname { get; set; }
        public string Code { get; set; }
        public string Remarks { get; set; }
        public decimal? Districtid { get; set; }
        public decimal? Typeid { get; set; }
    }
}
