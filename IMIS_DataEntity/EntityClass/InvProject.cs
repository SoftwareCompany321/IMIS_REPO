﻿using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvProject
    {
        public InvProject()
        {
            InvRequisitionMast = new HashSet<InvRequisitionMast>();
        }

        public decimal ProjectId { get; set; }
        public string NameNp { get; set; }
        public string NameEn { get; set; }
        public string IsActive { get; set; }

        public virtual ICollection<InvRequisitionMast> InvRequisitionMast { get; set; }
    }
}
