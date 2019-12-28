using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisEduBoard
    {
        public PisEduBoard()
        {
            PisEducation = new HashSet<PisEducation>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string NameNep { get; set; }
        public string NameEng { get; set; }
        public int? CountryId { get; set; }
        public string Place { get; set; }

        public virtual ICollection<PisEducation> PisEducation { get; set; }
    }
}
