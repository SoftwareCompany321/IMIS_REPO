using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvApplicantRate
    {
        public int Id { get; set; }
        public int? Applicantid { get; set; }
        public int? ItemDetailId { get; set; }
        public float? Amount { get; set; }
    }
}
