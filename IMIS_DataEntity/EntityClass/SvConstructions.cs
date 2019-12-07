using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class SvConstructions
    {
        public decimal Id { get; set; }
        public decimal? Iid { get; set; }
        public decimal? Houseid { get; set; }
        public decimal? Talanumber { get; set; }
        public decimal? Constructiontypeid { get; set; }
        public decimal? Lengthinfeet { get; set; }
        public decimal? Widththinfeet { get; set; }
        public decimal? Heightinfeet { get; set; }
        public decimal? Areainsqfeet { get; set; }
        public string Vsdateofmade { get; set; }
        public decimal? Constructionusestypeid { get; set; }
        public short? Selfuseorinrent { get; set; }
        public decimal? Generalrateid { get; set; }
        public short? Includeinevaluation { get; set; }
        public string Specialnote { get; set; }
        public decimal? Userid { get; set; }
        public decimal? Useride { get; set; }
        public string Dataentryvsdate { get; set; }
        public DateTime? Dataentryaddatetime { get; set; }
        public DateTime? Dataeditaddatetime { get; set; }
        public decimal? TaxpayerDefineAmount { get; set; }
        public string Vsmappdate { get; set; }
    }
}
