using System;
using System.Collections.Generic;
using System.Text;

namespace IMIS_Service.ViewModel
{
    public class ItemBrandVM
    {
        public int BrandId { get; set; }
        public string Code { get; set; }
        public string NameNp { get; set; }
        public string NameEn { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
