using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvLilamRecList
    {
        public int? Id { get; set; }
        public string Code { get; set; }
        public string RecDateNp { get; set; }
        public int? Applicantid { get; set; }
        public int? EmpId { get; set; }
        public int? UserId { get; set; }
    }
}
