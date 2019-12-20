using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisPrizes
    {
        public int Sn { get; set; }
        public int? EmpId { get; set; }
        public int? LocalPostId { get; set; }
        public string NameNp { get; set; }
        public string Description { get; set; }
        public string AwardType { get; set; }
        public float? Amount { get; set; }
        public string AwardedBy { get; set; }
        public string WorkingOffice { get; set; }
        public string IssuedDate { get; set; }
        public string Remarks { get; set; }
        public string ApplyTo { get; set; }

        public virtual PisLocalPostMaster LocalPost { get; set; }
    }
}
