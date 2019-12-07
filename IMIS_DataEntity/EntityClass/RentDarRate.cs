using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class RentDarRate
    {
        public decimal Id { get; set; }
        public string Ratename { get; set; }
        public double? RentPer { get; set; }
        public decimal? RentTypeid { get; set; }
    }
}
