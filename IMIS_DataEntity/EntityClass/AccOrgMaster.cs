using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class AccOrgMaster
    {
        public AccOrgMaster()
        {
            AccBankGrnty = new HashSet<AccBankGrnty>();
            OrgBankAccount = new HashSet<OrgBankAccount>();
            TblBgtRelease = new HashSet<TblBgtRelease>();
        }

        public int OrgId { get; set; } 
        public string NameNp { get; set; }
        public string NameEn { get; set; }
        public string Address { get; set; }
        public string Phones { get; set; }
        public string Emails { get; set; }
        public string RegNo { get; set; }
        public string VatNo { get; set; }
        public string PanNo { get; set; }
        public int? Zone { get; set; }
        public int? District { get; set; }
        public int? Vdc { get; set; }
        public int? Ministry { get; set; }
        public string Code { get; set; }
        public string Head { get; set; }
        public string MobileNo { get; set; }
        public string RelatedPerson { get; set; }
        public int? OrgMasterId { get; set; }
        public string Sapati { get; set; }
        public int? OrcAccTypeId { get; set; }

        public virtual ICollection<AccBankGrnty> AccBankGrnty { get; set; }
        public virtual ICollection<OrgBankAccount> OrgBankAccount { get; set; }
        public virtual ICollection<TblBgtRelease> TblBgtRelease { get; set; }
    }
}
