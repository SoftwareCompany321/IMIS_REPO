using System;
using System.Collections.Generic;
using System.Text;

namespace IMIS_Service.ViewModel
{
    public class ItemPurchaseTypeVM
    {
        public int Id { get; set; } 
        public string Code { get; set; }
        public string NepName { get; set; } 
        public string NepEng { get; set; } 
        public string Remarks { get; set; } 
        public char? Isdefault { get; set; }
    }
}
