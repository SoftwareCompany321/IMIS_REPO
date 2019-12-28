using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisPersonVisitRecrd
    {
        public int Sn { get; set; }
        public string Code { get; set; }
        public int? PersonTypeId { get; set; }
        public int? PersonId { get; set; }
        public string PersonName { get; set; }
        public string PersonPost { get; set; }
        public string RefNo { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public float? AmountTaken { get; set; }
        public string VisitLocation { get; set; }
        public string JobDetails { get; set; }
        public string Remarks { get; set; }
        public int? UserId { get; set; }
        public int? UserIde { get; set; }
        public string DataEntryVsDate { get; set; }
        public DateTime? DataEntryAdDate { get; set; }
        public DateTime? DataEditAdDate { get; set; }
    }
}
