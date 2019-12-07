using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class TblDegister
    {
        public decimal Id { get; set; }
        public string NpName { get; set; }
        public string EngName { get; set; }
        public string Remarks { get; set; }
        public decimal? IsFullDegister { get; set; }
    }
}
