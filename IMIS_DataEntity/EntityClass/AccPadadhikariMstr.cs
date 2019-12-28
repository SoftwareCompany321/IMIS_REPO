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

        public int PadadikariId { get; set; }
        public string Code { get; set; }
        public string NameNp { get; set; }
        public string NameEn { get; set; }
        public int? PostId { get; set; }
        public string Address { get; set; }
        public int? WardNo { get; set; }
        public string ElectedDateNp { get; set; }
        public string Qualification { get; set; }
        public string MobileNo { get; set; }
        public string LastNameNp { get; set; }
        public string LastNameEn { get; set; }
        public string Title { get; set; }
        public string Gender { get; set; }
        public int? ReligionId { get; set; }
        public int? MotherLangId { get; set; }
        public string DateOfBirth { get; set; }
        public string ParentName { get; set; }
        public int? POcupation { get; set; }
        public string SpouseName { get; set; }
        public int? SOcupation { get; set; }
        public string GrandfatherName { get; set; }
        public int? GfOcupation { get; set; }
        public string MarriedStatus { get; set; }
        public int? NoOfSon { get; set; }
        public int? NoOfDaughter { get; set; }
        public string FirstAppointDate { get; set; }
        public int? FirstAppointPostId { get; set; }
        public string CurrentPostAppointDate { get; set; }
        public string RetireDate { get; set; }
        public string PreExperience { get; set; }
        public int? ZoneId { get; set; }
        public int? DistrictId { get; set; }
        public int? VdcId { get; set; }
        public int? TrackId { get; set; }
        public string Street { get; set; }
        public string Phones { get; set; }
        public string Emails { get; set; }
        public string Mobile { get; set; }
        public string CitizenshipNo { get; set; }
        public string CitznIssuedDate { get; set; }
        public int? CitznIssuedDistrId { get; set; }
        public string IsToiletInHome { get; set; }
        public string SpecialNotes { get; set; }
        public int? UserId { get; set; }
        public int? UserIde { get; set; }
        public string DataEntryVsDate { get; set; }
        public DateTime? DataEntryAdDate { get; set; }
        public DateTime? DataEditAdDate { get; set; }
        public DateTime? DateOfBirthAd { get; set; }

        public virtual AccPadadhikariPost Post { get; set; }
        public virtual ICollection<WardMaster> WardMasterPramukh { get; set; }
        public virtual ICollection<WardMaster> WardMasterUppramukh { get; set; }
    }
}
