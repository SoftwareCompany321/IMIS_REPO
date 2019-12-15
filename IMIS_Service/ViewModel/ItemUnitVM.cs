using System;
using System.Collections.Generic;
using System.Text;

namespace IMIS_Service.ViewModel
{
    public class ItemUnitVM
    {
        public decimal UnitId { get; set; }
        public string DescNp { get; set; }
        public string DescEn { get; set; }
        public decimal? MulFactor { get; set; }
        public string RelatedTo { get; set; }
        public decimal? NoOfUnits { get; set; }
        public string IsActive { get; set; }
    }
}
