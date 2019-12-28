using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisAttributes
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string NameNep { get; set; }
        public string Description { get; set; }
        public string ApplyTo { get; set; }
    }
}
