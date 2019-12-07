using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisPdOrgInvlvmnt
    {
        public decimal Sn { get; set; }
        public decimal? EmpId { get; set; }
        public string OrgName { get; set; }
        public string OrgAdd { get; set; }
        public string OrgFormedDate { get; set; }
        public string OrgAims { get; set; }
        public string OrgAcheivmnts { get; set; }
        public decimal? NoOfBenificPopln { get; set; }
        public string PostInOrg { get; set; }
        public string RespnsbltyInOrg { get; set; }
        public string OrgJoinedDate { get; set; }
        public string OrgLeftDate { get; set; }
        public string Remarks { get; set; }
        public decimal? UserId { get; set; }
        public decimal? UserIde { get; set; }
        public string DataEntryVsDate { get; set; }
        public DateTime? DataEntryAdDate { get; set; }
        public DateTime? DataEditAdDate { get; set; }
    }
}
