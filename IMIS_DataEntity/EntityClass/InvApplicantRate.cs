using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvApplicantRate
    {
        public decimal Id { get; set; }
        public decimal? Applicantid { get; set; }
        public decimal? ItemDetailId { get; set; }
        public double? Amount { get; set; }
    }
}
