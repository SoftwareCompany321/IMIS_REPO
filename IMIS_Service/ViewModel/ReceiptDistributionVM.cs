using System;
using System.Collections.Generic;
using System.Text;

namespace IMIS_Service.ViewModel
{
    public class ReceiptDistributionVM
    {
        public int Sn { get; set; }
        public string Dateissued { get; set; }
        public int Thelino { get; set; }
        public string Billnofrom { get; set; }
        public string Billnoto { get; set; }
        public int Counterid { get; set; }
        public int Userid { get; set; }
        public string Specialnotes { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
