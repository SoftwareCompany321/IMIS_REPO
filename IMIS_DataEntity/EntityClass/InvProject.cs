using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvProject
    {
        public InvProject()
        {
            InvRequisitionMast = new HashSet<InvRequisitionMast>();
        }

        public int ProjectId { get; set; }
        public string NameNp { get; set; }
        public string NameEn { get; set; }
        public bool IsActive { get; set; } = true;

        public virtual ICollection<InvRequisitionMast> InvRequisitionMast { get; set; }
    }
}
