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

        public decimal OrgId { get; set; }
        public string NameNp { get; set; }
        public string NameEn { get; set; }
        public string Address { get; set; }
        public string Phones { get; set; }
        public string Emails { get; set; }
        public string RegNo { get; set; }
        public string VatNo { get; set; }
        public string PanNo { get; set; }
        public decimal? Zone { get; set; }
        public decimal? District { get; set; }
        public decimal? Vdc { get; set; }
        public decimal? Ministry { get; set; }
        public string Code { get; set; }
        public string Head { get; set; }
        public string MobileNo { get; set; }
        public string RelatedPerson { get; set; }
        public decimal? OrgMasterId { get; set; }
        public string Sapati { get; set; }
        public decimal? OrcAccTypeId { get; set; }

        public virtual ICollection<AccBankGrnty> AccBankGrnty { get; set; }
        public virtual ICollection<OrgBankAccount> OrgBankAccount { get; set; }
        public virtual ICollection<TblBgtRelease> TblBgtRelease { get; set; }
    }
}
