using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvTypeSetup
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string DescNp { get; set; }
        public string DescEn { get; set; }
        public int? TypeId { get; set; }
        public bool IsActive { get; set; }
    }
}
