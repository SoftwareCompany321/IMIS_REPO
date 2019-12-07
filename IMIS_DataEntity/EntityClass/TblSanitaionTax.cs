using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class TblSanitaionTax
    {
        public decimal? Id { get; set; }
        public double? FromArea { get; set; }
        public double? ToArea { get; set; }
        public double? Amount { get; set; }
        public string Remarks { get; set; }
        public string FiscalYear { get; set; }
        public decimal? AccId { get; set; }
        public string IsApartment { get; set; }
    }
}
