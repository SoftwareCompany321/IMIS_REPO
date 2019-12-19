using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvDept
    {
        public InvDept()
        {
            InvRoomMst = new HashSet<InvRoomMst>();
        }

        public int DeptId { get; set; }
        public string NameNp { get; set; }
        public string NameEn { get; set; }
        public int? OfficeId { get; set; }
        public string IsActive { get; set; }

        public virtual ICollection<InvRoomMst> InvRoomMst { get; set; }
    }
}
