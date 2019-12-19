using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisEmpTrnsfrRec
    {
        public int Sn { get; set; }
        public int? EmpId { get; set; }
        public int? LocalPostId { get; set; }
        public string RefNo { get; set; }
        public string TrnsfrDate { get; set; }
        public float? AmtTaken { get; set; }
        public string TrnsfrdOffice { get; set; }
        public string MovedDate { get; set; }
        public string Remarks { get; set; }
        public int? UserId { get; set; }
        public int? UserIde { get; set; }
        public string DataEntryVsDate { get; set; }
        public DateTime? DataEntryAdDate { get; set; }
        public DateTime? DataEditAdDate { get; set; }

        public virtual PisEmployeeMaster Emp { get; set; }
        public virtual PisLocalPostMaster LocalPost { get; set; }
    }
}
