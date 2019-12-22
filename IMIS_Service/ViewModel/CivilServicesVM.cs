using System;
using System.Collections.Generic;
using System.Text;

namespace IMIS_Service.ViewModel
{
    public class CivilServicesVM
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string NameNp { get; set; }
        public string NameEn { get; set; }
        public int? GrpLevel { get; set; }
    }
}
