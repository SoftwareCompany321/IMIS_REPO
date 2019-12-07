using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class AccUnauthorised
    {
        public decimal UnauthorisedId { get; set; }
        public decimal? SubModuleId { get; set; }
        public decimal? WorkId { get; set; }
        public decimal? UnauthorisedDafaId { get; set; }
        public decimal? UnauthorisedAmt { get; set; }
        public string InspectDate { get; set; }
        public string InspectDetails { get; set; }
        public decimal? InspectAmt { get; set; }
        public decimal? FilledbyEmpid { get; set; }
        public decimal? VerifiedbyEmpid { get; set; }
    }
}
