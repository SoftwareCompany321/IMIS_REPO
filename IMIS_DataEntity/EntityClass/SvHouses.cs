using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class SvHouses
    {
        public decimal Id { get; set; }
        public decimal? Iid { get; set; }
        public decimal? Landid { get; set; }
        public string Housenumber { get; set; }
        public decimal? Housetypeid { get; set; }
        public decimal? Houseconstructiontypeid { get; set; }
        public string SalesDt { get; set; }
        public string Vsdateofmade { get; set; }
        public string Aquisitiondate { get; set; }
        public decimal? Usestypeid { get; set; }
        public short? Hasmapregistered { get; set; }
        public string Mapregistereddate { get; set; }
        public decimal? Numoftalas { get; set; }
        public decimal? Heightinfeets { get; set; }
        public decimal? Lengthinfeets { get; set; }
        public decimal? Widthinfeets { get; set; }
        public decimal? Areainsqfeets { get; set; }
        public string Specialnote { get; set; }
        public short? Includeinevaluation { get; set; }
        public decimal? Areaofconstructionsinsqfeets { get; set; }
        public decimal? Userid { get; set; }
        public decimal? Useride { get; set; }
        public string Dataentryvsdate { get; set; }
        public DateTime? Dataentryaddatetime { get; set; }
        public DateTime? Dataeditaddatetime { get; set; }
        public double? DefineAmt { get; set; }
        public decimal? Sanitationrateid { get; set; }
        public string Buildingcode { get; set; }
        public decimal? BinGis { get; set; }
    }
}
