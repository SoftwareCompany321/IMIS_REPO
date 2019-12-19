using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class RentDarRate
    {
        public int Id { get; set; }
        public string Ratename { get; set; }
        public float? RentPer { get; set; }
        public int? RentTypeid { get; set; }
    }
}
