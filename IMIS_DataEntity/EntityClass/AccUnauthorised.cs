using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class AccUnauthorised
    {
        public int UnauthorisedId { get; set; }
        public string Code { get; set; }
        public int? SubModuleId { get; set; }
        public int? WorkId { get; set; }
        public int? UnauthorisedDafaId { get; set; }
        public int? UnauthorisedAmt { get; set; }
        public string InspectDate { get; set; }
        public string InspectDetails { get; set; }
        public int? InspectAmt { get; set; }
        public int? FilledbyEmpid { get; set; }
        public int? VerifiedbyEmpid { get; set; }
    }
}
