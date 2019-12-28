using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisTraining
    {
        public int Sn { get; set; }
        public string Code { get; set; }
        public int? EmpId { get; set; }
        public int? LocalPostId { get; set; }
        public string TrainingType { get; set; }
        public string TrainingName { get; set; }
        public string Institute { get; set; }
        public int? CountryId { get; set; }
        public string FrmDateVs { get; set; }
        public string ToDateVs { get; set; }
        public DateTime? FrmDateAd { get; set; }
        public DateTime? ToDateAd { get; set; }
        public string Duration { get; set; }
        public string Division { get; set; }
        public float? MarksObtnd { get; set; }
        public int? ValidForEval { get; set; }
        public string ApplyTo { get; set; }

        public virtual PisLocalPostMaster LocalPost { get; set; }
    }
}
