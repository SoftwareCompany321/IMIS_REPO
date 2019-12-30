using IMIS_DataEntity.EntityClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace IMIS_Service.ViewModel
{
    public class ReceiptDistributionCenterVM //: Collectioncounters
    {
        public int Counterid { get; set; }
        public string Code { get; set; }
        public string Nepname { get; set; }
        public int? Counterheadid { get; set; }
        public int? Wardno { get; set; }
        public string Location { get; set; }
        public string Specialnotes { get; set; }
        public string CmptrName { get; set; }
        public string Macaddress { get; set; }
    }
}
