﻿using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvUnit
    {
        public InvUnit()
        {
            InvGoodsRecDetl = new HashSet<InvGoodsRecDetl>();
            InvItemMst = new HashSet<InvItemMst>();
            InvPurOrderDetl = new HashSet<InvPurOrderDetl>();
        }

        public int UnitId { get; set; }
        public string DescNp { get; set; }
        public string DescEn { get; set; }
        public int? MulFactor { get; set; }
        public string RelatedTo { get; set; }
        public int? NoOfUnits { get; set; }
        public string IsActive { get; set; }

        public virtual ICollection<InvGoodsRecDetl> InvGoodsRecDetl { get; set; }
        public virtual ICollection<InvItemMst> InvItemMst { get; set; }
        public virtual ICollection<InvPurOrderDetl> InvPurOrderDetl { get; set; }
    }
}
