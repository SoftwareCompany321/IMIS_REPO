using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisHajiri
    {
        public decimal Sn { get; set; }
        public decimal? Year { get; set; }
        public decimal? Month { get; set; }
        public decimal? EmpId { get; set; }
        public decimal? LocalPost { get; set; }
        public decimal? TotalDays { get; set; }
        public decimal? PublicHolidays { get; set; }
        public decimal? HajiriDays { get; set; }
        public decimal? Ghabis { get; set; }
        public decimal? Bibis { get; set; }
        public decimal? Cabis { get; set; }
        public decimal? Betalabis { get; set; }
        public decimal? Other { get; set; }
        public decimal? Gayal { get; set; }
    }
}
