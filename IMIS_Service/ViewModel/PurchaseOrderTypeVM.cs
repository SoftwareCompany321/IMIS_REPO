using System;
using System.Collections.Generic;
using System.Text;

namespace IMIS_Service.ViewModel
{
    public class PurchaseOrderTypeVM
    {
        public int Id { get; set; }
        public string NpName { get; set; }
        public string EngName { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
