using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class WardMaster
    {
        public decimal Id { get; set; }
        public string NepName { get; set; }
        public string EngName { get; set; }
        public string Address { get; set; }
        public decimal? PramukhId { get; set; }
        public decimal? UppramukhId { get; set; }
        public decimal? NumberOfMembers { get; set; }
        public decimal? WardSecretaryId { get; set; }
        public string MobileNo { get; set; }

        public virtual AccPadadhikariMstr Pramukh { get; set; }
        public virtual AccPadadhikariMstr Uppramukh { get; set; }
        public virtual PisEmployeeMaster WardSecretary { get; set; }
    }
}
