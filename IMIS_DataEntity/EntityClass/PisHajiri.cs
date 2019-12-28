using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisHajiri
    {
        public int Sn { get; set; }
        public string Code { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
        public int? EmpId { get; set; }
        public int? LocalPost { get; set; }
        public int? TotalDays { get; set; }
        public int? PublicHolidays { get; set; }
        public int? HajiriDays { get; set; }
        public int? Ghabis { get; set; }
        public int? Bibis { get; set; }
        public int? Cabis { get; set; }
        public int? Betalabis { get; set; }
        public int? Other { get; set; }
        public int? Gayal { get; set; }
    }
}
