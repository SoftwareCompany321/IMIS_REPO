using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class TblTaxType
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string NpName { get; set; }
        public string EngName { get; set; }
        public string Descriptiong { get; set; }
        public int? AccId { get; set; }
    }
}
