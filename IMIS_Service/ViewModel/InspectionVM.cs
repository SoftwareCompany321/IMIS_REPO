using System;
using System.Collections.Generic;
using System.Text;

namespace IMIS_Service.ViewModel
{
    public class InspectionVM
    {
        public int UnitId { get; set; }
        public string Code { get; set; }
        public string DescNp { get; set; }
        public string DescEn { get; set; }
        public decimal? MulFactor { get; set; }
        public string RelatedTo { get; set; }
        public int? NoOfUnits { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
