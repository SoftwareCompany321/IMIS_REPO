using System;
using System.Collections.Generic;
using System.Text;

namespace IMIS_Service.ViewModel
{
    public class DepartmentVM
    {
        public int DeptId { get; set; }
        public string NameNp { get; set; }
        public string NameEn { get; set; }
        public int OfficeId { get; set; }
        public string IsActive { get; set; }
    }
}
