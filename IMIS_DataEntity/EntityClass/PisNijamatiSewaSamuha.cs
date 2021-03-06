﻿using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisNijamatiSewaSamuha
    {
        public PisNijamatiSewaSamuha()
        {
            InverseParent = new HashSet<PisNijamatiSewaSamuha>();
        }

        public decimal Id { get; set; }
        public decimal? ParentId { get; set; }
        public string NameNp { get; set; }
        public string NameEn { get; set; }
        public decimal? GrpLevel { get; set; }

        public virtual PisNijamatiSewaSamuha Parent { get; set; }
        public virtual ICollection<PisNijamatiSewaSamuha> InverseParent { get; set; }
    }
}
