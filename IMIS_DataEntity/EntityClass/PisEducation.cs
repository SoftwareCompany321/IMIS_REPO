using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisEducation
    {
        public decimal Sn { get; set; }
        public decimal? EmpId { get; set; }
        public string EduName { get; set; }
        public decimal? EduLevelId { get; set; }
        public string Institute { get; set; }
        public decimal? BoardId { get; set; }
        public double? MarksPercnt { get; set; }
        public double? MarksGrade { get; set; }
        public string Division { get; set; }
        public string CompletionYrVs { get; set; }
        public DateTime? CompletionYrAd { get; set; }
        public string Subjects { get; set; }
        public decimal? ValidForEval { get; set; }
        public string ApplyTo { get; set; }

        public virtual PisEduBoard Board { get; set; }
        public virtual PisEduLevel EduLevel { get; set; }
    }
}
