using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class ReportGeneral
    {
        public decimal? ReportId { get; set; }
        public decimal? OfficeTypeId { get; set; }
        public string ReportName { get; set; }
        public string ReportFor { get; set; }
        public string AnusuchiHead { get; set; }
        public string AnusuchiDetails { get; set; }
        public string ReportHeading { get; set; }
    }
}
