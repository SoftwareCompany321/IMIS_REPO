using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisVisitedCountries
    {
        public int Sn { get; set; }
        public int? VisitId { get; set; }
        public int? EmpId { get; set; }
        public int? CountryId { get; set; }
        public string ApplyTo { get; set; }

        public virtual PisForeignVisits Visit { get; set; }
    }
}
