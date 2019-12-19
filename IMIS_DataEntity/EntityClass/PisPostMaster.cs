using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisPostMaster
    {
        public PisPostMaster()
        {
            PisDarbandi = new HashSet<PisDarbandi>();
            PisEmployeeMasterFirstAppointPost = new HashSet<PisEmployeeMaster>();
            PisEmployeeMasterPost = new HashSet<PisEmployeeMaster>();
            PisLocalPostMaster = new HashSet<PisLocalPostMaster>();
        }

        public int PostId { get; set; }
        public string GeneralPost { get; set; }
        public string GeneralPostShort { get; set; }
        public int? PostLevel { get; set; }
        public float? BasicSalary { get; set; }
        public int? RateOfGrade { get; set; }
        public int? MaxGradeRate { get; set; }
        public int? PrabidikOrPrasasan { get; set; }

        public virtual ICollection<PisDarbandi> PisDarbandi { get; set; }
        public virtual ICollection<PisEmployeeMaster> PisEmployeeMasterFirstAppointPost { get; set; }
        public virtual ICollection<PisEmployeeMaster> PisEmployeeMasterPost { get; set; }
        public virtual ICollection<PisLocalPostMaster> PisLocalPostMaster { get; set; }
    }
}
