using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisAwards
    {
        public int Sn { get; set; }
        public int? EmpId { get; set; }
        public int? LocalPostId { get; set; }
        public string NepName { get; set; }
        public string LevelDesc { get; set; }
        public string Description { get; set; }
        public string WorkingOffice { get; set; }
        public string RvcdDateVs { get; set; }
        public DateTime? RcvdDateAd { get; set; }
        public string Remarks { get; set; }
        public string ApplyTo { get; set; }

        public virtual PisLocalPostMaster LocalPost { get; set; }
    }
}
