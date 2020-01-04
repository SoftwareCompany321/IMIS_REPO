using System;
using System.Collections.Generic;
using System.Text;

namespace IMIS_Service.ViewModel
{
    public class TaxRateVM
    {
        public int TaxRateId { get; set; }
        public string Code { get; set; }
        public string NameNp { get; set; }
        public string NameEn { get; set; }
        public float TaxRate { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
