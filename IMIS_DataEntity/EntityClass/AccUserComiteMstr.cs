using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class AccUserComiteMstr
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string NepName { get; set; }
        public string EngName { get; set; }
        public int? Ward { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phones { get; set; }
        public string Chairman { get; set; }
        public string ConcernPerson { get; set; }
        public string MobileNo { get; set; }
    }
}
