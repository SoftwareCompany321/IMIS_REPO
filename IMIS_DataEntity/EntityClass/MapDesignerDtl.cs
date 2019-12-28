using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class MapDesignerDtl
    {
        public short Id { get; set; }
        public string Code { get; set; }
        public string RegNo { get; set; }
        public string EngcouncilregNo { get; set; }
        public string FirmName { get; set; }
        public string DesignerName { get; set; }
        public string Address { get; set; }
        public string PhoneNo { get; set; }
        public string Class { get; set; }
        public string StatusId { get; set; }
        public string Remarks { get; set; }
    }
}
