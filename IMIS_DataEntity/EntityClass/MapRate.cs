using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class MapRate
    {
        public decimal Id { get; set; }
        public string Description { get; set; }
        public double? RatePermit { get; set; }
        public double? DepositeRatePermit { get; set; }
        public decimal? Userid { get; set; }
        public string EntryDate { get; set; }
    }
}
