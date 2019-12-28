using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class Fywiserentdarrate
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int? Rateid { get; set; }
        public string Ratename { get; set; }
        public float? RentPer { get; set; }
        public int? RentTypeid { get; set; }
        public string FiscalYear { get; set; }
    }
}
