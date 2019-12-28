using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class TblSanitaionTax
    {
        public int? Id { get; set; }
        public string Code { get; set; }
        public float? FromArea { get; set; }
        public float? ToArea { get; set; }
        public float? Amount { get; set; }
        public string Remarks { get; set; }
        public string FiscalYear { get; set; }
        public int? AccId { get; set; }
        public string IsApartment { get; set; }
    }
}
