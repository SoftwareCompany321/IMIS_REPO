using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class Userassignments
    {
        public decimal? Sn { get; set; }
        public string Nepname { get; set; }
        public string Rightsname { get; set; }
        public string Module { get; set; }
        public string MenuName { get; set; }
        public string MenuUrl { get; set; }
        public string DisplayName { get; set; }
        public int ParentMenuId { get; set; }
        public bool Active { get; set; }
        public bool IsLocked { get; set; }
        public bool Visible { get; set; }
        public string Icon { get; set; }
        public int MenuOrder { get; set; }
        public string CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
