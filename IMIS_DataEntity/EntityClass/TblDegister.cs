using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class TblDegister
    {
        public int Id { get; set; }
        public string NpName { get; set; }
        public string EngName { get; set; }
        public string Remarks { get; set; }
        public int? IsFullDegister { get; set; }
    }
}
