using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class Userassignments
    {
        public int? Sn { get; set; }
        public string Nepname { get; set; }
        public string Rightsname { get; set; }
        public string Module { get; set; }
        public bool Active { get; set; }
        public DateTime Createdat { get; set; }
        public string Createdby { get; set; }
        public string Displayname { get; set; }
        public string Icon { get; set; }
        public bool Islocked { get; set; }
        public string Menuname { get; set; }
        public short Menuorder { get; set; }
        public string Menuurl { get; set; }
        public int Parentmenuid { get; set; }
        public bool Visible { get; set; }
    }
}
