using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class SvLands
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int? Iid { get; set; }
        public int? Oldvdcid { get; set; }
        public string Oldwardno { get; set; }
        public string LandRules { get; set; }
        public int? Wardno { get; set; }
        public string Mothnumber { get; set; }
        public string Mapnumber { get; set; }
        public string Kittanumber { get; set; }
        public string Streetname { get; set; }
        public short? Hastrack { get; set; }
        public int? Trackid { get; set; }
        public int? Trackrelationid { get; set; }
        public string Aquisitiondate { get; set; }
        public int? Aquisitiontypeid { get; set; }
        public int? Usestypeid { get; set; }
        public int? Valueinrsonaquisition { get; set; }
        public int? Areainsqft { get; set; }
        public int? Nonfunctionalareainsqft { get; set; }
        public string Eastboundary { get; set; }
        public string Westboundary { get; set; }
        public string Northtboundary { get; set; }
        public string Southtboundary { get; set; }
        public int? Lqtypeid { get; set; }
        public int? Landnatureid { get; set; }
        public int? Locationfactorid { get; set; }
        public int? Selfdeclaredvalueinrs { get; set; }
        public string Specialnote { get; set; }
        public int? Generalrateid { get; set; }
        public short? Includeinevaluation { get; set; }
        public int? Userid { get; set; }
        public int? Useride { get; set; }
        public string Dataentryvsdate { get; set; }
        public string SalesDt { get; set; }
        public DateTime? Dataentryaddatetime { get; set; }
        public DateTime? Dataeditaddatetime { get; set; }
        public int? Evalexclusionreasonid { get; set; }
        public int? Malpotrate { get; set; }
        public int? AreaTypeId { get; set; }
        public int? NominationDirection { get; set; }
        public int? NominationArea { get; set; }
        public int? NominationLength { get; set; }
        public int? NominationBreadth { get; set; }
        public int? NominationTf { get; set; }
        public int? Landtype { get; set; }
        public string EastboundaryKitta { get; set; }
        public string WestboundaryKitta { get; set; }
        public string NorthboundaryKitta { get; set; }
        public string SouthboundaryKitta { get; set; }
        public string Tolename { get; set; }
        public int? Landmeasuringunitid { get; set; }
        public string GridNo { get; set; }
        public string SheetNo { get; set; }
        public string Eastrunft { get; set; }
        public string Westrunft { get; set; }
        public string Northrunft { get; set; }
        public string Southrunft { get; set; }
        public int? AreainsqftField { get; set; }
        public string IsLrmisAdd { get; set; }
        public string Deigstertypeid { get; set; }
    }
}
