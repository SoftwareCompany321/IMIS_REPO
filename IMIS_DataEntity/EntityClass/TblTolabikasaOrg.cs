﻿using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class TblTolabikasaOrg
    {
        public decimal Id { get; set; }
        public string NpName { get; set; }
        public string EngName { get; set; }
        public string Address { get; set; }
        public string Chairman { get; set; }
        public string Sachiba { get; set; }
        public string Contactno { get; set; }
        public string Email { get; set; }
        public decimal? Wardno { get; set; }
    }
}
