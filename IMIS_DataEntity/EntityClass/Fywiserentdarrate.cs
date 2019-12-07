using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class Fywiserentdarrate
    {
        public decimal Id { get; set; }
        public decimal? Rateid { get; set; }
        public string Ratename { get; set; }
        public double? RentPer { get; set; }
        public decimal? RentTypeid { get; set; }
        public string FiscalYear { get; set; }
    }
}
