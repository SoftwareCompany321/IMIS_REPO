using System;
using System.Collections.Generic;
using System.Text;

namespace IMIS_Service.ViewModel
{
    public class SupplierListingDescVM
    {
        public int Id { get; set; }
        public int SupId { get; set; }
        public string FiscalYear { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
