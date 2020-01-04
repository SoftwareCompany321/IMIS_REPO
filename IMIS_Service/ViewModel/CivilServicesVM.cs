using System;
using System.Collections.Generic;
using System.Text;

namespace IMIS_Service.ViewModel
{
    public class CivilServicesVM
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int? ParentId { get; set; }
        public string NameNp { get; set; }
        public string NameEn { get; set; }
        public int order { get; set; }
        public int? GrpLevel { get; set; }
        public IList<CivilServicesSubCivilServicesVM> CivilServicesSubCivilServices { get; set; }
    }
    public class CivilServicesSubCivilServicesVM : CivilServicesVM //inheriting from the parent CivilServices
    {

    }
}
