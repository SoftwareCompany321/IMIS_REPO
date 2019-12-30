using System;
using System.Collections.Generic;
using System.Text;

namespace IMIS_Service.ViewModel
{
    public class ItemSpecificationVM
    {
        public int SpecId { get; set; }
        public string Code { get; set; }
        public string NameNp { get; set; }
        public string NameEn { get; set; }
        public bool IsActive { get; set; } = true;
       
    }
}
