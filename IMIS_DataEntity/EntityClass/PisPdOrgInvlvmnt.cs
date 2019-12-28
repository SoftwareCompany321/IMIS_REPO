using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisPdOrgInvlvmnt
    {
        public int Sn { get; set; }
        public string Code { get; set; }
        public int? EmpId { get; set; }
        public string OrgName { get; set; }
        public string OrgAdd { get; set; }
        public string OrgFormedDate { get; set; }
        public string OrgAims { get; set; }
        public string OrgAcheivmnts { get; set; }
        public int? NoOfBenificPopln { get; set; }
        public string PostInOrg { get; set; }
        public string RespnsbltyInOrg { get; set; }
        public string OrgJoinedDate { get; set; }
        public string OrgLeftDate { get; set; }
        public string Remarks { get; set; }
        public int? UserId { get; set; }
        public int? UserIde { get; set; }
        public string DataEntryVsDate { get; set; }
        public DateTime? DataEntryAdDate { get; set; }
        public DateTime? DataEditAdDate { get; set; }
    }
}
