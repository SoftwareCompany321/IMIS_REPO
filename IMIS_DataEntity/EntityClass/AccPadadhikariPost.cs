using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class AccPadadhikariPost
    {
        public AccPadadhikariPost()
        {
            AccPadadhikariMstr = new HashSet<AccPadadhikariMstr>();
        }

        public decimal PostId { get; set; }
        public string NameNp { get; set; }
        public string NameEn { get; set; }
        public decimal? DurationInYrs { get; set; }
        public decimal? PostLevel { get; set; }

        public virtual ICollection<AccPadadhikariMstr> AccPadadhikariMstr { get; set; }
    }
}
