using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisOrnaments
    {
        public int Sn { get; set; }
        public int? EmpId { get; set; }
        public string Description { get; set; }
        public string UnitDesc { get; set; }
        public int? AquisitionTypeId { get; set; }
        public string SpecialNotes { get; set; }
        public string ApplyTo { get; set; }
        public int? UserId { get; set; }
        public int? UserIde { get; set; }
        public string DataEntryVsDate { get; set; }
        public DateTime? DataEntryAdDate { get; set; }
        public DateTime? DataEditAdDate { get; set; }
    }
}
