using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class SvHouses
    {
        public int Id { get; set; }
        public int? Iid { get; set; }
        public int? Landid { get; set; }
        public string Housenumber { get; set; }
        public int? Housetypeid { get; set; }
        public int? Houseconstructiontypeid { get; set; }
        public string SalesDt { get; set; }
        public string Vsdateofmade { get; set; }
        public string Aquisitiondate { get; set; }
        public int? Usestypeid { get; set; }
        public short? Hasmapregistered { get; set; }
        public string Mapregistereddate { get; set; }
        public int? Numoftalas { get; set; }
        public int? Heightinfeets { get; set; }
        public int? Lengthinfeets { get; set; }
        public int? Widthinfeets { get; set; }
        public int? Areainsqfeets { get; set; }
        public string Specialnote { get; set; }
        public short? Includeinevaluation { get; set; }
        public int? Areaofconstructionsinsqfeets { get; set; }
        public int? Userid { get; set; }
        public int? Useride { get; set; }
        public string Dataentryvsdate { get; set; }
        public DateTime? Dataentryaddatetime { get; set; }
        public DateTime? Dataeditaddatetime { get; set; }
        public float? DefineAmt { get; set; }
        public int? Sanitationrateid { get; set; }
        public string Buildingcode { get; set; }
        public int? BinGis { get; set; }
    }
}
