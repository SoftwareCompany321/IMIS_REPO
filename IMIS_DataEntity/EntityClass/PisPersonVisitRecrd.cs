using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisPersonVisitRecrd
    {
        public decimal Sn { get; set; }
        public decimal? PersonTypeId { get; set; }
        public decimal? PersonId { get; set; }
        public string PersonName { get; set; }
        public string PersonPost { get; set; }
        public string RefNo { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public double? AmountTaken { get; set; }
        public string VisitLocation { get; set; }
        public string JobDetails { get; set; }
        public string Remarks { get; set; }
        public decimal? UserId { get; set; }
        public decimal? UserIde { get; set; }
        public string DataEntryVsDate { get; set; }
        public DateTime? DataEntryAdDate { get; set; }
        public DateTime? DataEditAdDate { get; set; }
    }
}
