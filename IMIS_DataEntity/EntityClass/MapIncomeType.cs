﻿using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class MapIncomeType
    {
        public short Id { get; set; }
        public string NameNp { get; set; }
        public string NameEn { get; set; }
        public decimal? AccId { get; set; }
        public string Description { get; set; }

        public virtual AccAccMaster Acc { get; set; }
    }
}
