using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class TaxRateCeiling
    {
        public decimal Id { get; set; }
        public string NpFrom { get; set; }
        public string NpTo { get; set; }
        public string MarriedStatus { get; set; }
        public double? TaxRate { get; set; }
    }
}
