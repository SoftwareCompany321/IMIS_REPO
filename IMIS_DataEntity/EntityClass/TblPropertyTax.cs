using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class TblPropertyTax
    {
        public decimal Id { get; set; }
        public decimal? Iid { get; set; }
        public string NpEntryDate { get; set; }
        public string FiscalYear { get; set; }
        public double? HouseLandAmount { get; set; }
        public double? MalpotAmount { get; set; }
        public double? TotalTax { get; set; }
        public string Remarks { get; set; }
    }
}
