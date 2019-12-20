using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class WardMaster
    {
        public int Id { get; set; }
        public string NepName { get; set; }
        public string EngName { get; set; }
        public string Address { get; set; }
        public int? PramukhId { get; set; }
        public int? UppramukhId { get; set; }
        public int? NumberOfMembers { get; set; }
        public int? WardSecretaryId { get; set; }
        public string MobileNo { get; set; }

        public virtual AccPadadhikariMstr Pramukh { get; set; }
        public virtual AccPadadhikariMstr Uppramukh { get; set; }
        public virtual PisEmployeeMaster WardSecretary { get; set; }
    }
}
