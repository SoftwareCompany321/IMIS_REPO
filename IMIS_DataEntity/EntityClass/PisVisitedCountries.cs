using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisVisitedCountries
    {
        public decimal Sn { get; set; }
        public decimal? VisitId { get; set; }
        public decimal? EmpId { get; set; }
        public decimal? CountryId { get; set; }
        public string ApplyTo { get; set; }

        public virtual PisForeignVisits Visit { get; set; }
    }
}
