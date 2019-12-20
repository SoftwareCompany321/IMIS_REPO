using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class SubjectArea
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Code { get; set; }
        public string NepName { get; set; }
        public string EngName { get; set; }
        public string Remarks { get; set; }
    }
}
