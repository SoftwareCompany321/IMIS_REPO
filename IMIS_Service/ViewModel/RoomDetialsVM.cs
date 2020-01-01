using System;
using System.Collections.Generic;
using System.Text;

namespace IMIS_Service.ViewModel
{
    public class RoomDetialsVM
    {

        public int RoomId { get; set; }
        public string Code { get; set; }
        public int? FloorNo { get; set; }
        public string BlockNo { get; set; }
        public string DescNp { get; set; }
        public string DescEn { get; set; }
        public int? DeptId { get; set; }
        public bool IsActive { get; set; } = true;

    }
}
