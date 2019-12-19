using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class Issuedbills
    {
        public int? Sn { get; set; }
        public string Dateissued { get; set; }
        public int? Thelino { get; set; }
        public string Billnofrom { get; set; }
        public string Billnoto { get; set; }
        public int? Counterid { get; set; }
        public int? Userid { get; set; }
        public string Specialnotes { get; set; }
    }
}
