using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisEduLevel
    {
        public PisEduLevel()
        {
            PisEducation = new HashSet<PisEducation>();
        }

        public int EduId { get; set; }
        public string Code { get; set; }
        public string EduName { get; set; }

        public virtual ICollection<PisEducation> PisEducation { get; set; }
    }
}
