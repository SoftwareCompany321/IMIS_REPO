using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvRoomMst
    {
        public int RoomId { get; set; }
        public int? FloorNo { get; set; }
        public string BlockNo { get; set; }
        public string DescNp { get; set; }
        public string DescEn { get; set; }
        public int? DeptId { get; set; }

        public virtual InvDept Dept { get; set; }
    }
}
