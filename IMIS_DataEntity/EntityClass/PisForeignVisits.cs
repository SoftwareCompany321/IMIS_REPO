using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisForeignVisits
    {
        public PisForeignVisits()
        {
            PisVisitedCountries = new HashSet<PisVisitedCountries>();
        }

        public decimal Sn { get; set; }
        public decimal? EmpId { get; set; }
        public decimal? LocalPostId { get; set; }
        public string WorkingOffice { get; set; }
        public string FromDateVs { get; set; }
        public string ToDateVs { get; set; }
        public DateTime? FromDateAd { get; set; }
        public DateTime? ToDateAd { get; set; }
        public string VisitingPrpse { get; set; }
        public string FundedBy { get; set; }
        public string Remarks { get; set; }
        public string ApplyTo { get; set; }

        public virtual PisLocalPostMaster LocalPost { get; set; }
        public virtual ICollection<PisVisitedCountries> PisVisitedCountries { get; set; }
    }
}
