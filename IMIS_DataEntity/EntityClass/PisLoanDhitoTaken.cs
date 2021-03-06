﻿using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisLoanDhitoTaken
    {
        public decimal Sn { get; set; }
        public decimal? EmpId { get; set; }
        public string Description { get; set; }
        public string TransDesc { get; set; }
        public string ReasonToTake { get; set; }
        public double? ValueInNrs { get; set; }
        public string ReturningDuration { get; set; }
        public string SpecialNotes { get; set; }
        public string ApplyTo { get; set; }
        public decimal? UserId { get; set; }
        public decimal? UserIde { get; set; }
        public string DataEntryVsDate { get; set; }
        public DateTime? DataEntryAdDate { get; set; }
        public DateTime? DataEditAdDate { get; set; }
    }
}
