using System;
using System.Collections.Generic;
using System.Text;

namespace IMIS_Service.ViewModel
{
    public class ItemOtherSetupTypeVM
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string DescNp { get; set; }
        public string DescEn { get; set; }
        public int? TypeId { get; set; }
        public string type { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
