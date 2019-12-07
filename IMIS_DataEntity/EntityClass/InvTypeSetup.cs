using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvTypeSetup
    {
        public decimal Id { get; set; }
        public string DescNp { get; set; }
        public string DescEn { get; set; }
        public decimal? TypeId { get; set; }
        public string IsActive { get; set; }
    }
}
