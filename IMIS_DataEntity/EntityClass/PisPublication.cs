﻿using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisPublication
    {
        public decimal Sn { get; set; }
        public decimal? EmpId { get; set; }
        public decimal? LocalPostId { get; set; }
        public string NepName { get; set; }
        public string Description { get; set; }
        public string WorkingOffice { get; set; }
        public string PublshDateVs { get; set; }
        public DateTime? PublshDateAd { get; set; }
        public string Publisher { get; set; }
        public string Remarks { get; set; }
        public string ApplyTo { get; set; }

        public virtual PisLocalPostMaster LocalPost { get; set; }
    }
}
