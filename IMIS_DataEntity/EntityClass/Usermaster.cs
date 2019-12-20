using System;
using System.Collections.Generic; 
using Microsoft.AspNetCore.Identity;

namespace IMIS_DataEntity.EntityClass
{
    public partial class Usermaster: IdentityUser
    { 
        public string Userid { get; set; }
        public string Userpassword { get; set; }
        public string Nepname { get; set; }
        public string Engname { get; set; }
        public short? Userstatus { get; set; }
        public DateTime? Lastloggedon { get; set; }
        public DateTime? Lastloggedout { get; set; }
        public string Grants { get; set; }
        public int? Updatedby { get; set; }
        public int? EmpId { get; set; }
        public string OrgCode { get; set; }
        public string Code { get; set; }
        public string FromCentral { get; set; }
        public string WardNo { get; set; }
        public DateTime? PwdChangedDate { get; set; }
        public string FiscalYear { get; set; }
    }
}
