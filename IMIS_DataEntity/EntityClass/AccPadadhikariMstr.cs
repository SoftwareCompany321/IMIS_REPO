using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class AccPadadhikariMstr
    {
        public AccPadadhikariMstr()
        {
            WardMasterPramukh = new HashSet<WardMaster>();
            WardMasterUppramukh = new HashSet<WardMaster>();
        }

        public decimal PadadikariId { get; set; }
        public string NameNp { get; set; }
        public string NameEn { get; set; }
        public decimal? PostId { get; set; }
        public string Address { get; set; }
        public decimal? WardNo { get; set; }
        public string ElectedDateNp { get; set; }
        public string Qualification { get; set; }
        public string MobileNo { get; set; }
        public string LastNameNp { get; set; }
        public string LastNameEn { get; set; }
        public string Title { get; set; }
        public string Gender { get; set; }
        public decimal? ReligionId { get; set; }
        public decimal? MotherLangId { get; set; }
        public string DateOfBirth { get; set; }
        public string ParentName { get; set; }
        public decimal? POcupation { get; set; }
        public string SpouseName { get; set; }
        public decimal? SOcupation { get; set; }
        public string GrandfatherName { get; set; }
        public decimal? GfOcupation { get; set; }
        public string MarriedStatus { get; set; }
        public decimal? NoOfSon { get; set; }
        public decimal? NoOfDaughter { get; set; }
        public string FirstAppointDate { get; set; }
        public decimal? FirstAppointPostId { get; set; }
        public string CurrentPostAppointDate { get; set; }
        public string RetireDate { get; set; }
        public string PreExperience { get; set; }
        public decimal? ZoneId { get; set; }
        public decimal? DistrictId { get; set; }
        public decimal? VdcId { get; set; }
        public decimal? TrackId { get; set; }
        public string Street { get; set; }
        public string Phones { get; set; }
        public string Emails { get; set; }
        public string Mobile { get; set; }
        public string CitizenshipNo { get; set; }
        public string CitznIssuedDate { get; set; }
        public decimal? CitznIssuedDistrId { get; set; }
        public string IsToiletInHome { get; set; }
        public string SpecialNotes { get; set; }
        public decimal? UserId { get; set; }
        public decimal? UserIde { get; set; }
        public string DataEntryVsDate { get; set; }
        public DateTime? DataEntryAdDate { get; set; }
        public DateTime? DataEditAdDate { get; set; }
        public DateTime? DateOfBirthAd { get; set; }

        public virtual AccPadadhikariPost Post { get; set; }
        public virtual ICollection<WardMaster> WardMasterPramukh { get; set; }
        public virtual ICollection<WardMaster> WardMasterUppramukh { get; set; }
    }
}
