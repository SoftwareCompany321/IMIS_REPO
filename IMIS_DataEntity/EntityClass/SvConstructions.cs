using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class SvConstructions
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int? Iid { get; set; }
        public int? Houseid { get; set; }
        public int? Talanumber { get; set; }
        public int? Constructiontypeid { get; set; }
        public int? Lengthinfeet { get; set; }
        public int? Widththinfeet { get; set; }
        public int? Heightinfeet { get; set; }
        public int? Areainsqfeet { get; set; }
        public string Vsdateofmade { get; set; }
        public int? Constructionusestypeid { get; set; }
        public short? Selfuseorinrent { get; set; }
        public int? Generalrateid { get; set; }
        public short? Includeinevaluation { get; set; }
        public string Specialnote { get; set; }
        public int? Userid { get; set; }
        public int? Useride { get; set; }
        public string Dataentryvsdate { get; set; }
        public DateTime? Dataentryaddatetime { get; set; }
        public DateTime? Dataeditaddatetime { get; set; }
        public int? TaxpayerDefineAmount { get; set; }
        public string Vsmappdate { get; set; }
    }
}
