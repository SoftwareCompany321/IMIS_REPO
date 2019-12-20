using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class Ministry
    {
        public int? Id { get; set; }
        public string Code { get; set; }
        public int? Zone { get; set; }
        public int? District { get; set; }
        public int? Vdc { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Nepname { get; set; }
        public string Engname { get; set; }
        public string Remarks { get; set; }
    }
}
