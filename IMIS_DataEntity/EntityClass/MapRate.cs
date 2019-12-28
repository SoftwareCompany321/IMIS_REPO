using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class MapRate
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public float? RatePermit { get; set; }
        public float? DepositeRatePermit { get; set; }
        public int? Userid { get; set; }
        public string EntryDate { get; set; }
    }
}
