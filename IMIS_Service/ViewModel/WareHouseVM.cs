﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IMIS_Service.ViewModel
{
    public class WareHouseVM 
    {
        public int WarehouseId { get; set; }
        public string NameNp { get; set; }
        public string NameEn { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
