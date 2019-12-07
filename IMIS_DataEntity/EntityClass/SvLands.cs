using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class SvLands
    {
        public decimal Id { get; set; }
        public decimal? Iid { get; set; }
        public decimal? Oldvdcid { get; set; }
        public string Oldwardno { get; set; }
        public string LandRules { get; set; }
        public decimal? Wardno { get; set; }
        public string Mothnumber { get; set; }
        public string Mapnumber { get; set; }
        public string Kittanumber { get; set; }
        public string Streetname { get; set; }
        public short? Hastrack { get; set; }
        public decimal? Trackid { get; set; }
        public decimal? Trackrelationid { get; set; }
        public string Aquisitiondate { get; set; }
        public decimal? Aquisitiontypeid { get; set; }
        public decimal? Usestypeid { get; set; }
        public decimal? Valueinrsonaquisition { get; set; }
        public decimal? Areainsqft { get; set; }
        public decimal? Nonfunctionalareainsqft { get; set; }
        public string Eastboundary { get; set; }
        public string Westboundary { get; set; }
        public string Northtboundary { get; set; }
        public string Southtboundary { get; set; }
        public decimal? Lqtypeid { get; set; }
        public decimal? Landnatureid { get; set; }
        public decimal? Locationfactorid { get; set; }
        public decimal? Selfdeclaredvalueinrs { get; set; }
        public string Specialnote { get; set; }
        public decimal? Generalrateid { get; set; }
        public short? Includeinevaluation { get; set; }
        public decimal? Userid { get; set; }
        public decimal? Useride { get; set; }
        public string Dataentryvsdate { get; set; }
        public string SalesDt { get; set; }
        public DateTime? Dataentryaddatetime { get; set; }
        public DateTime? Dataeditaddatetime { get; set; }
        public decimal? Evalexclusionreasonid { get; set; }
        public decimal? Malpotrate { get; set; }
        public decimal? AreaTypeId { get; set; }
        public decimal? NominationDirection { get; set; }
        public decimal? NominationArea { get; set; }
        public decimal? NominationLength { get; set; }
        public decimal? NominationBreadth { get; set; }
        public decimal? NominationTf { get; set; }
        public decimal? Landtype { get; set; }
        public string EastboundaryKitta { get; set; }
        public string WestboundaryKitta { get; set; }
        public string NorthboundaryKitta { get; set; }
        public string SouthboundaryKitta { get; set; }
        public string Tolename { get; set; }
        public decimal? Landmeasuringunitid { get; set; }
        public string GridNo { get; set; }
        public string SheetNo { get; set; }
        public string Eastrunft { get; set; }
        public string Westrunft { get; set; }
        public string Northrunft { get; set; }
        public string Southrunft { get; set; }
        public decimal? AreainsqftField { get; set; }
        public string IsLrmisAdd { get; set; }
        public string Deigstertypeid { get; set; }
    }
}
