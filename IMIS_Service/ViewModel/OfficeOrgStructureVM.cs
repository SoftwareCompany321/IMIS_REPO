using System;
using System.Collections.Generic;
using System.Text;

namespace IMIS_Service.ViewModel
{
    public class OfficeOrgStructureVM
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int? ParentId { get; set; }
        public string NepName { get; set; }
        public string EngName { get; set; }
        public int? ContainsDarbandi { get; set; }
        public int? GeoRegion { get; set; }
        public int? GrpLevel { get; set; }
    }
}
