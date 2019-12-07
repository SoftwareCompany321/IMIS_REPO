using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class Issuedbills
    {
        public decimal? Sn { get; set; }
        public string Dateissued { get; set; }
        public decimal? Thelino { get; set; }
        public string Billnofrom { get; set; }
        public string Billnoto { get; set; }
        public decimal? Counterid { get; set; }
        public decimal? Userid { get; set; }
        public string Specialnotes { get; set; }
    }
}
