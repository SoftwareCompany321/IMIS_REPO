using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvWarehouse
    {
        public decimal WarehouseId { get; set; }
        public string NameNp { get; set; }
        public string NameEn { get; set; }
        public string IsActive { get; set; }
    }
}
