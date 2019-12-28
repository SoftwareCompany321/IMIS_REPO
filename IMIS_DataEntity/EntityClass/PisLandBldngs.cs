using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisLandBldngs
    {
        public int Sn { get; set; }
        public string Code { get; set; }
        public int? EmpId { get; set; }
        public string Description { get; set; }
        public string UnitDesc { get; set; }
        public int? ZoneId { get; set; }
        public int? DistrictId { get; set; }
        public int? VdcId { get; set; }
        public string WardNo { get; set; }
        public int? RoadId { get; set; }
        public string Street { get; set; }
        public string OwnershipDetails { get; set; }
        public int? AquisitionTypeId { get; set; }
        public string SpecialNotes { get; set; }
        public string ApplyTo { get; set; }
        public int? UserId { get; set; }
        public int? UserIde { get; set; }
        public string DataEntryVsDate { get; set; }
        public DateTime? DataEntryAdDate { get; set; }
        public DateTime? DataEditAdDate { get; set; }
    }
}
