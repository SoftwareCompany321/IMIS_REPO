using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisEmpTrnsfrRec
    {
        public decimal Sn { get; set; }
        public decimal? EmpId { get; set; }
        public decimal? LocalPostId { get; set; }
        public string RefNo { get; set; }
        public string TrnsfrDate { get; set; }
        public double? AmtTaken { get; set; }
        public string TrnsfrdOffice { get; set; }
        public string MovedDate { get; set; }
        public string Remarks { get; set; }
        public decimal? UserId { get; set; }
        public decimal? UserIde { get; set; }
        public string DataEntryVsDate { get; set; }
        public DateTime? DataEntryAdDate { get; set; }
        public DateTime? DataEditAdDate { get; set; }

        public virtual PisEmployeeMaster Emp { get; set; }
        public virtual PisLocalPostMaster LocalPost { get; set; }
    }
}
