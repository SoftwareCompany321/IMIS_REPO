using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisLandBldngs
    {
        public decimal Sn { get; set; }
        public decimal? EmpId { get; set; }
        public string Description { get; set; }
        public string UnitDesc { get; set; }
        public decimal? ZoneId { get; set; }
        public decimal? DistrictId { get; set; }
        public decimal? VdcId { get; set; }
        public string WardNo { get; set; }
        public decimal? RoadId { get; set; }
        public string Street { get; set; }
        public string OwnershipDetails { get; set; }
        public decimal? AquisitionTypeId { get; set; }
        public string SpecialNotes { get; set; }
        public string ApplyTo { get; set; }
        public decimal? UserId { get; set; }
        public decimal? UserIde { get; set; }
        public string DataEntryVsDate { get; set; }
        public DateTime? DataEntryAdDate { get; set; }
        public DateTime? DataEditAdDate { get; set; }
    }
}
