using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisPrizes
    {
        public decimal Sn { get; set; }
        public decimal? EmpId { get; set; }
        public decimal? LocalPostId { get; set; }
        public string NameNp { get; set; }
        public string Description { get; set; }
        public string AwardType { get; set; }
        public double? Amount { get; set; }
        public string AwardedBy { get; set; }
        public string WorkingOffice { get; set; }
        public string IssuedDate { get; set; }
        public string Remarks { get; set; }
        public string ApplyTo { get; set; }

        public virtual PisLocalPostMaster LocalPost { get; set; }
    }
}
