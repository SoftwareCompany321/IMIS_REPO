using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class TblPropertyTax
    {
        public int Id { get; set; }
        public int? Iid { get; set; }
        public string NpEntryDate { get; set; }
        public string FiscalYear { get; set; }
        public float? HouseLandAmount { get; set; }
        public float? MalpotAmount { get; set; }
        public float? TotalTax { get; set; }
        public string Remarks { get; set; }
    }
}
