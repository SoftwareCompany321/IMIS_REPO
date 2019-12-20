using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisEducation
    {
        public int Sn { get; set; }
        public int? EmpId { get; set; }
        public string EduName { get; set; }
        public int? EduLevelId { get; set; }
        public string Institute { get; set; }
        public int? BoardId { get; set; }
        public float? MarksPercnt { get; set; }
        public float? MarksGrade { get; set; }
        public string Division { get; set; }
        public string CompletionYrVs { get; set; }
        public DateTime? CompletionYrAd { get; set; }
        public string Subjects { get; set; }
        public int? ValidForEval { get; set; }
        public string ApplyTo { get; set; }

        public virtual PisEduBoard Board { get; set; }
        public virtual PisEduLevel EduLevel { get; set; }
    }
}
